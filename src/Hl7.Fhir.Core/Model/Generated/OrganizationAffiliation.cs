// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0-snapshot1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// Defines an affiliation/assotiation/relationship between 2 distinct organizations, that is not a part-of relationship/sub-division relationship
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("OrganizationAffiliation","http://hl7.org/fhir/StructureDefinition/OrganizationAffiliation", IsResource=true)]
  public partial class OrganizationAffiliation : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "OrganizationAffiliation"; } }

    /// <summary>
    /// Business identifiers that are specific to this role
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Whether this organization affiliation record is in active use
    /// </summary>
    [FhirElement("active", InSummary=true, Order=100, FiveWs="FiveWs.status")]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ActiveElement
    {
      get { return _ActiveElement; }
      set { _ActiveElement = value; OnPropertyChanged("ActiveElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ActiveElement;

    /// <summary>
    /// Whether this organization affiliation record is in active use
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Active
    {
      get { return ActiveElement != null ? ActiveElement.Value : null; }
      set
      {
        if (value == null)
          ActiveElement = null;
        else
          ActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Active");
      }
    }

    /// <summary>
    /// The period during which the participatingOrganization is affiliated with the primary organization
    /// </summary>
    [FhirElement("period", InSummary=true, Order=110, FiveWs="FiveWs.done[x]")]
    [DataMember]
    public Hl7.Fhir.Model.Period Period
    {
      get { return _Period; }
      set { _Period = value; OnPropertyChanged("Period"); }
    }

    private Hl7.Fhir.Model.Period _Period;

    /// <summary>
    /// Organization where the role is available
    /// </summary>
    [FhirElement("organization", InSummary=true, Order=120)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Organization
    {
      get { return _Organization; }
      set { _Organization = value; OnPropertyChanged("Organization"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Organization;

    /// <summary>
    /// Organization that provides/performs the role (e.g. providing services or is a member of)
    /// </summary>
    [FhirElement("participatingOrganization", InSummary=true, Order=130)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference ParticipatingOrganization
    {
      get { return _ParticipatingOrganization; }
      set { _ParticipatingOrganization = value; OnPropertyChanged("ParticipatingOrganization"); }
    }

    private Hl7.Fhir.Model.ResourceReference _ParticipatingOrganization;

    /// <summary>
    /// Health insurance provider network in which the participatingOrganization provides the role's services (if defined) at the indicated locations (if defined)
    /// </summary>
    [FhirElement("network", InSummary=true, Order=140)]
    [CLSCompliant(false)]
    [References("Organization")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Network
    {
      get { if(_Network==null) _Network = new List<Hl7.Fhir.Model.ResourceReference>(); return _Network; }
      set { _Network = value; OnPropertyChanged("Network"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Network;

    /// <summary>
    /// Definition of the role the participatingOrganization plays
    /// </summary>
    [FhirElement("code", InSummary=true, Order=150)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Code
    {
      get { if(_Code==null) _Code = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Code; }
      set { _Code = value; OnPropertyChanged("Code"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Code;

    /// <summary>
    /// Specific specialty of the participatingOrganization in the context of the role
    /// </summary>
    [FhirElement("specialty", InSummary=true, Order=160)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Specialty
    {
      get { if(_Specialty==null) _Specialty = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Specialty; }
      set { _Specialty = value; OnPropertyChanged("Specialty"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Specialty;

    /// <summary>
    /// The location(s) at which the role occurs
    /// </summary>
    [FhirElement("location", InSummary=true, Order=170, FiveWs="FiveWs.where[x]")]
    [CLSCompliant(false)]
    [References("Location")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Location
    {
      get { if(_Location==null) _Location = new List<Hl7.Fhir.Model.ResourceReference>(); return _Location; }
      set { _Location = value; OnPropertyChanged("Location"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Location;

    /// <summary>
    /// Healthcare services provided through the role
    /// </summary>
    [FhirElement("healthcareService", Order=180)]
    [CLSCompliant(false)]
    [References("HealthcareService")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> HealthcareService
    {
      get { if(_HealthcareService==null) _HealthcareService = new List<Hl7.Fhir.Model.ResourceReference>(); return _HealthcareService; }
      set { _HealthcareService = value; OnPropertyChanged("HealthcareService"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _HealthcareService;

    /// <summary>
    /// Contact details at the participatingOrganization relevant to this Affiliation
    /// </summary>
    [FhirElement("telecom", InSummary=true, Order=190)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ContactPoint> Telecom
    {
      get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.ContactPoint>(); return _Telecom; }
      set { _Telecom = value; OnPropertyChanged("Telecom"); }
    }

    private List<Hl7.Fhir.Model.ContactPoint> _Telecom;

    /// <summary>
    /// Technical endpoints providing access to services operated for this role
    /// </summary>
    [FhirElement("endpoint", Order=200)]
    [CLSCompliant(false)]
    [References("Endpoint")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Endpoint
    {
      get { if(_Endpoint==null) _Endpoint = new List<Hl7.Fhir.Model.ResourceReference>(); return _Endpoint; }
      set { _Endpoint = value; OnPropertyChanged("Endpoint"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Endpoint;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as OrganizationAffiliation;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(ActiveElement != null) dest.ActiveElement = (Hl7.Fhir.Model.FhirBoolean)ActiveElement.DeepCopy();
      if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
      if(Organization != null) dest.Organization = (Hl7.Fhir.Model.ResourceReference)Organization.DeepCopy();
      if(ParticipatingOrganization != null) dest.ParticipatingOrganization = (Hl7.Fhir.Model.ResourceReference)ParticipatingOrganization.DeepCopy();
      if(Network != null) dest.Network = new List<Hl7.Fhir.Model.ResourceReference>(Network.DeepCopy());
      if(Code != null) dest.Code = new List<Hl7.Fhir.Model.CodeableConcept>(Code.DeepCopy());
      if(Specialty != null) dest.Specialty = new List<Hl7.Fhir.Model.CodeableConcept>(Specialty.DeepCopy());
      if(Location != null) dest.Location = new List<Hl7.Fhir.Model.ResourceReference>(Location.DeepCopy());
      if(HealthcareService != null) dest.HealthcareService = new List<Hl7.Fhir.Model.ResourceReference>(HealthcareService.DeepCopy());
      if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.ContactPoint>(Telecom.DeepCopy());
      if(Endpoint != null) dest.Endpoint = new List<Hl7.Fhir.Model.ResourceReference>(Endpoint.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new OrganizationAffiliation());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as OrganizationAffiliation;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.Matches(Period, otherT.Period)) return false;
      if( !DeepComparable.Matches(Organization, otherT.Organization)) return false;
      if( !DeepComparable.Matches(ParticipatingOrganization, otherT.ParticipatingOrganization)) return false;
      if( !DeepComparable.Matches(Network, otherT.Network)) return false;
      if( !DeepComparable.Matches(Code, otherT.Code)) return false;
      if( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
      if( !DeepComparable.Matches(Location, otherT.Location)) return false;
      if( !DeepComparable.Matches(HealthcareService, otherT.HealthcareService)) return false;
      if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
      if( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as OrganizationAffiliation;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
      if( !DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
      if( !DeepComparable.IsExactly(ParticipatingOrganization, otherT.ParticipatingOrganization)) return false;
      if( !DeepComparable.IsExactly(Network, otherT.Network)) return false;
      if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
      if( !DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
      if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
      if( !DeepComparable.IsExactly(HealthcareService, otherT.HealthcareService)) return false;
      if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
      if( !DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (ActiveElement != null) yield return ActiveElement;
        if (Period != null) yield return Period;
        if (Organization != null) yield return Organization;
        if (ParticipatingOrganization != null) yield return ParticipatingOrganization;
        foreach (var elem in Network) { if (elem != null) yield return elem; }
        foreach (var elem in Code) { if (elem != null) yield return elem; }
        foreach (var elem in Specialty) { if (elem != null) yield return elem; }
        foreach (var elem in Location) { if (elem != null) yield return elem; }
        foreach (var elem in HealthcareService) { if (elem != null) yield return elem; }
        foreach (var elem in Telecom) { if (elem != null) yield return elem; }
        foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
        if (Period != null) yield return new ElementValue("period", Period);
        if (Organization != null) yield return new ElementValue("organization", Organization);
        if (ParticipatingOrganization != null) yield return new ElementValue("participatingOrganization", ParticipatingOrganization);
        foreach (var elem in Network) { if (elem != null) yield return new ElementValue("network", elem); }
        foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
        foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", elem); }
        foreach (var elem in Location) { if (elem != null) yield return new ElementValue("location", elem); }
        foreach (var elem in HealthcareService) { if (elem != null) yield return new ElementValue("healthcareService", elem); }
        foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
        foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "active":
          value = ActiveElement;
          return ActiveElement is not null;
        case "period":
          value = Period;
          return Period is not null;
        case "organization":
          value = Organization;
          return Organization is not null;
        case "participatingOrganization":
          value = ParticipatingOrganization;
          return ParticipatingOrganization is not null;
        case "network":
          value = Network;
          return Network?.Any() == true;
        case "code":
          value = Code;
          return Code?.Any() == true;
        case "specialty":
          value = Specialty;
          return Specialty?.Any() == true;
        case "location":
          value = Location;
          return Location?.Any() == true;
        case "healthcareService":
          value = HealthcareService;
          return HealthcareService?.Any() == true;
        case "telecom":
          value = Telecom;
          return Telecom?.Any() == true;
        case "endpoint":
          value = Endpoint;
          return Endpoint?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      };

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (ActiveElement is not null) yield return new KeyValuePair<string,object>("active",ActiveElement);
      if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      if (Organization is not null) yield return new KeyValuePair<string,object>("organization",Organization);
      if (ParticipatingOrganization is not null) yield return new KeyValuePair<string,object>("participatingOrganization",ParticipatingOrganization);
      if (Network?.Any() == true) yield return new KeyValuePair<string,object>("network",Network);
      if (Code?.Any() == true) yield return new KeyValuePair<string,object>("code",Code);
      if (Specialty?.Any() == true) yield return new KeyValuePair<string,object>("specialty",Specialty);
      if (Location?.Any() == true) yield return new KeyValuePair<string,object>("location",Location);
      if (HealthcareService?.Any() == true) yield return new KeyValuePair<string,object>("healthcareService",HealthcareService);
      if (Telecom?.Any() == true) yield return new KeyValuePair<string,object>("telecom",Telecom);
      if (Endpoint?.Any() == true) yield return new KeyValuePair<string,object>("endpoint",Endpoint);
    }

  }

}

// end of file
