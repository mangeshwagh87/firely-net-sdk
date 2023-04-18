﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Hl7.Fhir.Serialization.Tests
{
    [TestClass]
    public class SerializationExceptionHandlersJsonPoco
    {
        private static T serializeResource<T>(string json)
            where T : Resource
        {
            var settings = new FhirJsonPocoDeserializerSettings()
            {
                OnPrimitiveParseFailed = (ref Utf8JsonReader reader,
                    Type targetType,
                    object originalValue,
                    FhirJsonException originalException) =>
                {
                    System.Diagnostics.Trace.WriteLine($"Primitive Parse Failed: {originalValue} {originalException.Message}");

                    // retry the conversion ourselves
                    try
                    {
                        var convertedValue = PrimitiveTypeConverter.ConvertTo(originalValue, targetType);
                        return (convertedValue, originalException.CloneWith(originalException.BaseErrorMessage, OperationOutcome.IssueSeverity.Warning, originalException.IssueType));
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Trace.WriteLine($" => {ex.Message}");
                        return (null, originalException.CloneWith(originalException.BaseErrorMessage, OperationOutcome.IssueSeverity.Fatal, originalException.IssueType));
                    }
                },
                // Validator = null
                ValidateOnFailedParse = true
            };
            var ds = new FhirJsonPocoDeserializer(settings);
            return (T)ds.DeserializeResource(json);
        }

        [TestMethod]
        public void JsonInvalidEnumerationValue()
        {
            // string containing a FHIR Patient with name John Doe, 17 Jan 1970, an invalid gender and an invalid date of birth
            string rawData = """
                {
                  "resourceType": "Patient",
                  "id": "pat1",
                  "name": [
                    {
                      "family": "Doe"
                    }
                  ],
                  "gender": "cat",
                  "birthDate": "1970"
                }
                """;

            try
            {
                var p = serializeResource<Patient>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Patient.gender", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[0].Severity);
                Assert.AreEqual("PVAL116", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual(1, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidEmptyObservation()
        {
            // string containing a FHIR Patient with name John Doe, 17 Jan 1970, an invalid gender and an invalid date of birth
            string rawData = """
                {
                  "resourceType": "Observation"
                  // ,"id": "pat1"
                }
                """;

            try
            {
                var p = serializeResource<Observation>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Observation", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, oc.Issue[0].Severity);
                Assert.AreEqual("JSON120", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual("Observation", oc.Issue[1].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[1].Severity);
                Assert.AreEqual("PVAL105", oc.Issue[1].Details.Coding[0].Code);

                Assert.AreEqual("Observation", oc.Issue[2].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[2].Severity);
                Assert.AreEqual("PVAL105", oc.Issue[2].Details.Coding[0].Code);

                Assert.AreEqual(3, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidPatientContainedInObservation()
        {
            // string containing a FHIR Patient with name John Doe, 17 Jan 1970, an invalid gender and an invalid date of birth
            string rawData = """
                {
                  "resourceType": "Observation",
                  "id": "obs",
                  "contained": [
                    {
                      "resourceType": "Patient",
                      "id": "pat1",
                      "birthDate": "xxxx",
                      "gender": "cat",
                      "name": [
                        {
                          "text": "demo"
                        }
                      ]
                    }
                  ],
                  "subject": {
                    "reference": "#pat1"
                  }
                }
                """;

            try
            {
                var p = serializeResource<Observation>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Observation.contained[0].birthDate", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[0].Severity);
                Assert.AreEqual("PVAL107", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual("Observation.contained[0].gender", oc.Issue[1].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[1].Severity);
                Assert.AreEqual("PVAL116", oc.Issue[1].Details.Coding[0].Code);

                Assert.AreEqual("Observation", oc.Issue[2].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[2].Severity);
                Assert.AreEqual("PVAL105", oc.Issue[2].Details.Coding[0].Code);
                Assert.IsTrue(oc.Issue[2].Details.Text.Contains("status"));

                Assert.AreEqual("Observation", oc.Issue[3].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[3].Severity);
                Assert.AreEqual("PVAL105", oc.Issue[3].Details.Coding[0].Code);
                Assert.IsTrue(oc.Issue[3].Details.Text.Contains("code"));

                Assert.AreEqual(4, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidDateValue()
        {
            // string containing a FHIR Patient with name John Doe, 17 Jan 1970, an invalid gender and an invalid date of birth
            string rawData = """
                {
                  "resourceType": "Patient",
                  "id": "pat1",
                  "name": [
                    {
                      "family": "Doe"
                    }
                  ],
                  "birthDate": "1 Jan 1970"
                }
                """;
            try
            {
                var p = serializeResource<Patient>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Patient.birthDate", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[0].Severity);
                Assert.AreEqual("PVAL107", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual(1, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidDateValueWithTime()
        {
            // string containing a FHIR Patient with name John Doe, 17 Jan 1970, an invalid gender and an invalid date of birth
            string rawData = """
                {
                  "resourceType": "Patient",
                  "id": "pat1",
                  "name": [
                    {
                      "family": "Doe"
                    }
                  ],
                  "birthDate": "1970-01-01T12:45:00Z"
                }
                """;

            try
            {
                var p = serializeResource<Patient>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Patient.birthDate", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[0].Severity);
                Assert.AreEqual("PVAL107", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual(1, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidPropertyDetected()
        {
            string rawData = """
                {
                  "resourceType": "Patient",
                  "id": "inv-prop",
                  "name": [
                    {
                      "family": "Doe"
                    },
                    {
                      "family": "Doe2",
                      "turkey": "blah blah blah"
                    }
                  ],
                  "chicken": "rubbish prop",
                  "gender": "male",
                  "birthDate": "1970-01-01"
                }
                """;

            try
            {
                var p = serializeResource<Patient>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Patient.name[1]", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[0].Severity);
                Assert.AreEqual("JSON118", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual("Patient", oc.Issue[1].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[1].Severity);
                Assert.AreEqual("JSON118", oc.Issue[1].Details.Coding[0].Code);

                Assert.AreEqual(2, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidDecimalValue()
        {
            string rawData = """
                {
                  "resourceType": "Observation",
                  "id": "decimal",
                  "status": "final",
                  "code": {
                    "text": "Decimal Testing Observation"
                  },
                  "component": [
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 1.0,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 1.00,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 1.0e0,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 0.00000000000000001,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 10000000000000000,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": "1.00000000000000000e-24",
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": "-1.00000000000000000e245",
                        "unit": "g"
                      }
                    }
                  ]
                }
                """;

            try
            {
                var p = serializeResource<Observation>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Observation.component[5].value.value", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, oc.Issue[0].Severity);
                Assert.AreEqual("JSON110", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual("Observation.component[6].value.value", oc.Issue[1].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, oc.Issue[1].Severity);
                Assert.AreEqual("JSON110", oc.Issue[1].Details.Coding[0].Code);

                Assert.AreEqual(2, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidIntegerValue()
        {
            string rawData = """
                {
                  "resourceType": "Observation",
                  "id": "obs-int",
                  "status": "final",
                  "code": {
                    "text": "Integer Testing Observation"
                  },
                  "component": [
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueInteger": 1
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueInteger": "2"
                    }
                  ]
                }
                """;

            try
            {
                var p = serializeResource<Observation>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Observation.component[1].value", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, oc.Issue[0].Severity);
                Assert.AreEqual("JSON110", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual(1, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidBooleanValue()
        {
            string rawData = """
                {
                  "resourceType": "Observation",
                  "id": "obs-bool",
                  "status": "final",
                  "code": {
                    "text": "Boolean Testing Observation"
                  },
                  "component": [
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueBoolean": true
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueBoolean": "false"
                    }
                  ]
                }
                """;

            try
            {
                var p = serializeResource<Observation>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Observation.component[1].value", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, oc.Issue[0].Severity);
                Assert.AreEqual("JSON110", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual(1, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonMixedInvalidParseIssues()
        {
            // string containing a FHIR Patient with name John Doe, 17 Jan 1970, an invalid gender and an invalid date of birth
            string rawData = """
                {
                  "resourceType": "Observation",
                  "id": "decimal",
                  "status": "glarb",
                  "code": {
                    "text": "Decimal Testing Observation"
                  },
                  "component": [
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": "1.00000000000000000e-24",
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": "-1.00000000000000000e245",
                        "unit": "g"
                      }
                    }
                  ]
                }
                """;

            try
            {
                var p = serializeResource<Patient>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                Assert.AreEqual("Observation.component[0].value.value", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, oc.Issue[0].Severity);
                Assert.AreEqual("JSON110", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual("Observation.component[1].value.value", oc.Issue[1].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, oc.Issue[1].Severity);
                Assert.AreEqual("JSON110", oc.Issue[1].Details.Coding[0].Code);

                Assert.AreEqual("Observation.status", oc.Issue[2].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[2].Severity);
                Assert.AreEqual("PVAL116", oc.Issue[2].Details.Coding[0].Code);

                Assert.AreEqual(3, oc.Issue.Count);
            }
        }

        [TestMethod]
        public void JsonInvalidBundledResources()
        {
            // string containing a FHIR Patient with name John Doe, 17 Jan 1970, an invalid gender and an invalid date of birth
            string rawData = """
                {
                "resourceType": "Bundle",
                "type": "searchset",
                "entry": [
                    {
                        "fullUrl": "https://example.org/Questionnaire/obs-comp",
                        "resource": {
                          "resourceType": "Patient",
                          "id": "pat1",
                          "name": [
                            {
                              "family": "Doe"
                            }
                          ],
                          "gender": "cat",
                          "birthDate": "1970"
                        }
                    },
                    {
                        "fullUrl": "https://example.org/Questionnaire/obs-comp",
                        "resource": {
                          "resourceType": "Patient",
                          "id": "pat1",
                          "name": [
                            {
                              "family": "Doe"
                            }
                          ],
                          "birthDate": "1 Jan 1970"
                        }
                    },
                    {
                        "fullUrl": "https://example.org/Questionnaire/obs-comp",
                        "resource": {
                          "resourceType": "Patient",
                          "id": "pat1",
                          "name": [
                            {
                              "family": "Doe"
                            }
                          ],
                          "birthDate": "1970-01-01T12:45:00Z"
                        }
                    },
                    {
                        "fullUrl": "https://example.org/Questionnaire/obs-comp",
                        "resource": {
                          "resourceType": "Patient",
                          "id": "inv-prop",
                          "name": [
                            {
                              "family": "Doe"
                            },
                            {
                              "family": "Doe2",
                              "turkey": "blah blah blah"
                            }
                          ],
                          "chicken": "rubbish prop",
                          "gender": "male",
                          "birthDate": "1970-01-01"
                        }
                    },
                    {
                        "fullUrl": "https://example.org/Questionnaire/obs-comp",
                        "resource": {
                  "resourceType": "Observation",
                  "id": "decimal",
                  "status": "final",
                  "code": {
                    "text": "Decimal Testing Observation"
                  },
                  "component": [
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 1.0,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 1.00,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 1.0e0,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 0.00000000000000001,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": 10000000000000000,
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": "1.00000000000000000e-24",
                        "unit": "g"
                      }
                    },
                    {
                      "code": {
                        "text": "Component"
                      },
                      "valueQuantity": {
                        "value": "-1.00000000000000000e245",
                        "unit": "g"
                      }
                    }
                  ]
                  }
                    },
                    {
                        "fullUrl": "https://example.org/Questionnaire/obs-comp",
                        "resource": {
                          "resourceType": "Observation",
                          "id": "obs-int",
                          "status": "final",
                          "code": {
                            "text": "Integer Testing Observation"
                          },
                          "component": [
                            {
                              "code": {
                                "text": "Component"
                              },
                              "valueInteger": 1
                            },
                            {
                              "code": {
                                "text": "Component"
                              },
                              "valueInteger": "2"
                            }
                          ]
                        }
                    },
                    {
                        "fullUrl": "https://example.org/Questionnaire/obs-comp",
                        "resource": {
                          "resourceType": "Observation",
                          "id": "obs-bool",
                          "status": "final",
                          "code": {
                            "text": "Boolean Testing Observation"
                          },
                          "component": [
                            {
                              "code": {
                                "text": "Component"
                              },
                              "valueBoolean": true
                            },
                            {
                              "code": {
                                "text": "Component"
                              },
                              "valueBoolean": "false"
                            }
                          ]
                         }
                    },
                    {
                        "fullUrl": "https://example.org/Questionnaire/obs-comp",
                        "resource": {
                          "resourceType": "Observation",
                          "id": "decimal",
                          "status": "glarb",
                          "code": {
                            "text": "Decimal Testing Observation"
                          },
                          "component": [
                            {
                              "code": {
                                "text": "Component"
                              },
                              "valueQuantity": {
                                "value": "1.00000000000000000e-24",
                                "unit": "g"
                              }
                            },
                            {
                              "code": {
                                "text": "Component"
                              },
                              "valueQuantity": {
                                "value": "-1.00000000000000000e245",
                                "unit": "g"
                              }
                            }
                          ]
                        }
                    }
                ]
                }
                """;

            try
            {
                var p = serializeResource<Patient>(rawData);
                DebugDump.OutputJson(p);
                Assert.Fail("Expected to throw parsing");
            }
            catch (DeserializationFailedException ex)
            {
                System.Diagnostics.Trace.WriteLine($"{ex.Message}");
                OperationOutcome oc = ex.ToOperationOutcome();
                DebugDump.OutputXml(oc);
                DebugDump.OutputJson(ex.PartialResult);

                // Now check over the content to see if the error annotations were included for contained resources
                if (ex.PartialResult is Bundle b)
                {
                    foreach (var resource in b.Entry.Select(e => e.Resource))
                    {
                        var errs = resource.Annotation<List<CodedException>>();
                        Console.WriteLine($"{resource.TypeName}/{resource.Id}");
                        if (errs != null)
                            Console.WriteLine($"    {String.Join("\r\n  ", errs.Select(ce => ce.Message))}");
                    }
                }

                Assert.AreEqual("Bundle.entry[0].resource.gender", oc.Issue[0].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[0].Severity);
                Assert.AreEqual("PVAL116", oc.Issue[0].Details.Coding[0].Code);

                Assert.AreEqual("Bundle.entry[1].resource.birthDate", oc.Issue[1].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[1].Severity);
                Assert.AreEqual("PVAL107", oc.Issue[1].Details.Coding[0].Code);

                Assert.AreEqual("Bundle.entry[2].resource.birthDate", oc.Issue[2].Expression.First());
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, oc.Issue[2].Severity);
                Assert.AreEqual("PVAL107", oc.Issue[2].Details.Coding[0].Code);

                Assert.AreEqual(12, oc.Issue.Count);
            }
        }
    }
}
