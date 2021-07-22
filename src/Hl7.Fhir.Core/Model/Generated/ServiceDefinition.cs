// <auto-generated/>
// Contents of: hl7.fhir.r3.core version: 3.0.2

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
  /// A description of decision support service functionality
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ServiceDefinition","http://hl7.org/fhir/StructureDefinition/ServiceDefinition", IsResource=true)]
  public partial class ServiceDefinition : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ServiceDefinition"; } }

    /// <summary>
    /// Logical URI to reference this service definition (globally unique)
    /// </summary>
    [FhirElement("url", InSummary=true, Order=90)]
    [DataMember]
    public Hl7.Fhir.Model.FhirUri UrlElement
    {
      get { return _UrlElement; }
      set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
    }

    private Hl7.Fhir.Model.FhirUri _UrlElement;

    /// <summary>
    /// Logical URI to reference this service definition (globally unique)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Url
    {
      get { return UrlElement != null ? UrlElement.Value : null; }
      set
      {
        if (value == null)
          UrlElement = null;
        else
          UrlElement = new Hl7.Fhir.Model.FhirUri(value);
        OnPropertyChanged("Url");
      }
    }

    /// <summary>
    /// Additional identifier for the service definition
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=100)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Business version of the service definition
    /// </summary>
    [FhirElement("version", InSummary=true, Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString VersionElement
    {
      get { return _VersionElement; }
      set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _VersionElement;

    /// <summary>
    /// Business version of the service definition
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Version
    {
      get { return VersionElement != null ? VersionElement.Value : null; }
      set
      {
        if (value == null)
          VersionElement = null;
        else
          VersionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Version");
      }
    }

    /// <summary>
    /// Name for this service definition (computer friendly)
    /// </summary>
    [FhirElement("name", InSummary=true, Order=120)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString NameElement
    {
      get { return _NameElement; }
      set { _NameElement = value; OnPropertyChanged("NameElement"); }
    }

    private Hl7.Fhir.Model.FhirString _NameElement;

    /// <summary>
    /// Name for this service definition (computer friendly)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Name
    {
      get { return NameElement != null ? NameElement.Value : null; }
      set
      {
        if (value == null)
          NameElement = null;
        else
          NameElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Name");
      }
    }

    /// <summary>
    /// Name for this service definition (human friendly)
    /// </summary>
    [FhirElement("title", InSummary=true, Order=130)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString TitleElement
    {
      get { return _TitleElement; }
      set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
    }

    private Hl7.Fhir.Model.FhirString _TitleElement;

    /// <summary>
    /// Name for this service definition (human friendly)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Title
    {
      get { return TitleElement != null ? TitleElement.Value : null; }
      set
      {
        if (value == null)
          TitleElement = null;
        else
          TitleElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Title");
      }
    }

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    [FhirElement("status", InSummary=true, Order=140)]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.PublicationStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.PublicationStatus> _StatusElement;

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.PublicationStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// For testing purposes, not real usage
    /// </summary>
    [FhirElement("experimental", InSummary=true, Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
    {
      get { return _ExperimentalElement; }
      set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;

    /// <summary>
    /// For testing purposes, not real usage
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Experimental
    {
      get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
      set
      {
        if (value == null)
          ExperimentalElement = null;
        else
          ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Experimental");
      }
    }

    /// <summary>
    /// Date this was last changed
    /// </summary>
    [FhirElement("date", InSummary=true, Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime DateElement
    {
      get { return _DateElement; }
      set { _DateElement = value; OnPropertyChanged("DateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _DateElement;

    /// <summary>
    /// Date this was last changed
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Date
    {
      get { return DateElement != null ? DateElement.Value : null; }
      set
      {
        if (value == null)
          DateElement = null;
        else
          DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Date");
      }
    }

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// </summary>
    [FhirElement("publisher", InSummary=true, Order=170)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString PublisherElement
    {
      get { return _PublisherElement; }
      set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
    }

    private Hl7.Fhir.Model.FhirString _PublisherElement;

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Publisher
    {
      get { return PublisherElement != null ? PublisherElement.Value : null; }
      set
      {
        if (value == null)
          PublisherElement = null;
        else
          PublisherElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Publisher");
      }
    }

    /// <summary>
    /// Natural language description of the service definition
    /// </summary>
    [FhirElement("description", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown Description
    {
      get { return _Description; }
      set { _Description = value; OnPropertyChanged("Description"); }
    }

    private Hl7.Fhir.Model.Markdown _Description;

    /// <summary>
    /// Why this service definition is defined
    /// </summary>
    [FhirElement("purpose", Order=190)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown Purpose
    {
      get { return _Purpose; }
      set { _Purpose = value; OnPropertyChanged("Purpose"); }
    }

    private Hl7.Fhir.Model.Markdown _Purpose;

    /// <summary>
    /// Describes the clinical usage of the module
    /// </summary>
    [FhirElement("usage", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString UsageElement
    {
      get { return _UsageElement; }
      set { _UsageElement = value; OnPropertyChanged("UsageElement"); }
    }

    private Hl7.Fhir.Model.FhirString _UsageElement;

    /// <summary>
    /// Describes the clinical usage of the module
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Usage
    {
      get { return UsageElement != null ? UsageElement.Value : null; }
      set
      {
        if (value == null)
          UsageElement = null;
        else
          UsageElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Usage");
      }
    }

    /// <summary>
    /// When the service definition was approved by publisher
    /// </summary>
    [FhirElement("approvalDate", Order=210)]
    [DataMember]
    public Hl7.Fhir.Model.Date ApprovalDateElement
    {
      get { return _ApprovalDateElement; }
      set { _ApprovalDateElement = value; OnPropertyChanged("ApprovalDateElement"); }
    }

    private Hl7.Fhir.Model.Date _ApprovalDateElement;

    /// <summary>
    /// When the service definition was approved by publisher
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string ApprovalDate
    {
      get { return ApprovalDateElement != null ? ApprovalDateElement.Value : null; }
      set
      {
        if (value == null)
          ApprovalDateElement = null;
        else
          ApprovalDateElement = new Hl7.Fhir.Model.Date(value);
        OnPropertyChanged("ApprovalDate");
      }
    }

    /// <summary>
    /// When the service definition was last reviewed
    /// </summary>
    [FhirElement("lastReviewDate", Order=220)]
    [DataMember]
    public Hl7.Fhir.Model.Date LastReviewDateElement
    {
      get { return _LastReviewDateElement; }
      set { _LastReviewDateElement = value; OnPropertyChanged("LastReviewDateElement"); }
    }

    private Hl7.Fhir.Model.Date _LastReviewDateElement;

    /// <summary>
    /// When the service definition was last reviewed
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string LastReviewDate
    {
      get { return LastReviewDateElement != null ? LastReviewDateElement.Value : null; }
      set
      {
        if (value == null)
          LastReviewDateElement = null;
        else
          LastReviewDateElement = new Hl7.Fhir.Model.Date(value);
        OnPropertyChanged("LastReviewDate");
      }
    }

    /// <summary>
    /// When the service definition is expected to be used
    /// </summary>
    [FhirElement("effectivePeriod", InSummary=true, Order=230)]
    [DataMember]
    public Hl7.Fhir.Model.Period EffectivePeriod
    {
      get { return _EffectivePeriod; }
      set { _EffectivePeriod = value; OnPropertyChanged("EffectivePeriod"); }
    }

    private Hl7.Fhir.Model.Period _EffectivePeriod;

    /// <summary>
    /// Context the content is intended to support
    /// </summary>
    [FhirElement("useContext", InSummary=true, Order=240)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.UsageContext> UseContext
    {
      get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.UsageContext>(); return _UseContext; }
      set { _UseContext = value; OnPropertyChanged("UseContext"); }
    }

    private List<Hl7.Fhir.Model.UsageContext> _UseContext;

    /// <summary>
    /// Intended jurisdiction for service definition (if applicable)
    /// </summary>
    [FhirElement("jurisdiction", InSummary=true, Order=250)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
    {
      get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
      set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;

    /// <summary>
    /// E.g. Education, Treatment, Assessment, etc
    /// </summary>
    [FhirElement("topic", Order=260)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Topic
    {
      get { if(_Topic==null) _Topic = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Topic; }
      set { _Topic = value; OnPropertyChanged("Topic"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Topic;

    /// <summary>
    /// A content contributor
    /// </summary>
    [FhirElement("contributor", Order=270)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Contributor> Contributor
    {
      get { if(_Contributor==null) _Contributor = new List<Hl7.Fhir.Model.Contributor>(); return _Contributor; }
      set { _Contributor = value; OnPropertyChanged("Contributor"); }
    }

    private List<Hl7.Fhir.Model.Contributor> _Contributor;

    /// <summary>
    /// Contact details for the publisher
    /// </summary>
    [FhirElement("contact", InSummary=true, Order=280)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ContactDetail> Contact
    {
      get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ContactDetail>(); return _Contact; }
      set { _Contact = value; OnPropertyChanged("Contact"); }
    }

    private List<Hl7.Fhir.Model.ContactDetail> _Contact;

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [FhirElement("copyright", Order=290)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown Copyright
    {
      get { return _Copyright; }
      set { _Copyright = value; OnPropertyChanged("Copyright"); }
    }

    private Hl7.Fhir.Model.Markdown _Copyright;

    /// <summary>
    /// Additional documentation, citations, etc
    /// </summary>
    [FhirElement("relatedArtifact", Order=300)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.RelatedArtifact> RelatedArtifact
    {
      get { if(_RelatedArtifact==null) _RelatedArtifact = new List<Hl7.Fhir.Model.RelatedArtifact>(); return _RelatedArtifact; }
      set { _RelatedArtifact = value; OnPropertyChanged("RelatedArtifact"); }
    }

    private List<Hl7.Fhir.Model.RelatedArtifact> _RelatedArtifact;

    /// <summary>
    /// "when" the module should be invoked
    /// </summary>
    [FhirElement("trigger", Order=310)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.TriggerDefinition> Trigger
    {
      get { if(_Trigger==null) _Trigger = new List<Hl7.Fhir.Model.TriggerDefinition>(); return _Trigger; }
      set { _Trigger = value; OnPropertyChanged("Trigger"); }
    }

    private List<Hl7.Fhir.Model.TriggerDefinition> _Trigger;

    /// <summary>
    /// What data is used by the module
    /// </summary>
    [FhirElement("dataRequirement", Order=320)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.DataRequirement> DataRequirement
    {
      get { if(_DataRequirement==null) _DataRequirement = new List<Hl7.Fhir.Model.DataRequirement>(); return _DataRequirement; }
      set { _DataRequirement = value; OnPropertyChanged("DataRequirement"); }
    }

    private List<Hl7.Fhir.Model.DataRequirement> _DataRequirement;

    /// <summary>
    /// Operation to invoke
    /// </summary>
    [FhirElement("operationDefinition", Order=330)]
    [CLSCompliant(false)]
    [References("OperationDefinition")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference OperationDefinition
    {
      get { return _OperationDefinition; }
      set { _OperationDefinition = value; OnPropertyChanged("OperationDefinition"); }
    }

    private Hl7.Fhir.Model.ResourceReference _OperationDefinition;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ServiceDefinition;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
      if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
      if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
      if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
      if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
      if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
      if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
      if(Purpose != null) dest.Purpose = (Hl7.Fhir.Model.Markdown)Purpose.DeepCopy();
      if(UsageElement != null) dest.UsageElement = (Hl7.Fhir.Model.FhirString)UsageElement.DeepCopy();
      if(ApprovalDateElement != null) dest.ApprovalDateElement = (Hl7.Fhir.Model.Date)ApprovalDateElement.DeepCopy();
      if(LastReviewDateElement != null) dest.LastReviewDateElement = (Hl7.Fhir.Model.Date)LastReviewDateElement.DeepCopy();
      if(EffectivePeriod != null) dest.EffectivePeriod = (Hl7.Fhir.Model.Period)EffectivePeriod.DeepCopy();
      if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.UsageContext>(UseContext.DeepCopy());
      if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
      if(Topic != null) dest.Topic = new List<Hl7.Fhir.Model.CodeableConcept>(Topic.DeepCopy());
      if(Contributor != null) dest.Contributor = new List<Hl7.Fhir.Model.Contributor>(Contributor.DeepCopy());
      if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.ContactDetail>(Contact.DeepCopy());
      if(Copyright != null) dest.Copyright = (Hl7.Fhir.Model.Markdown)Copyright.DeepCopy();
      if(RelatedArtifact != null) dest.RelatedArtifact = new List<Hl7.Fhir.Model.RelatedArtifact>(RelatedArtifact.DeepCopy());
      if(Trigger != null) dest.Trigger = new List<Hl7.Fhir.Model.TriggerDefinition>(Trigger.DeepCopy());
      if(DataRequirement != null) dest.DataRequirement = new List<Hl7.Fhir.Model.DataRequirement>(DataRequirement.DeepCopy());
      if(OperationDefinition != null) dest.OperationDefinition = (Hl7.Fhir.Model.ResourceReference)OperationDefinition.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ServiceDefinition());
    }

    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ServiceDefinition;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
      if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
      if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
      if( !DeepComparable.Matches(Description, otherT.Description)) return false;
      if( !DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
      if( !DeepComparable.Matches(UsageElement, otherT.UsageElement)) return false;
      if( !DeepComparable.Matches(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
      if( !DeepComparable.Matches(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
      if( !DeepComparable.Matches(EffectivePeriod, otherT.EffectivePeriod)) return false;
      if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
      if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.Matches(Topic, otherT.Topic)) return false;
      if( !DeepComparable.Matches(Contributor, otherT.Contributor)) return false;
      if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
      if( !DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
      if( !DeepComparable.Matches(RelatedArtifact, otherT.RelatedArtifact)) return false;
      if( !DeepComparable.Matches(Trigger, otherT.Trigger)) return false;
      if( !DeepComparable.Matches(DataRequirement, otherT.DataRequirement)) return false;
      if( !DeepComparable.Matches(OperationDefinition, otherT.OperationDefinition)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ServiceDefinition;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
      if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
      if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
      if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
      if( !DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
      if( !DeepComparable.IsExactly(UsageElement, otherT.UsageElement)) return false;
      if( !DeepComparable.IsExactly(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
      if( !DeepComparable.IsExactly(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
      if( !DeepComparable.IsExactly(EffectivePeriod, otherT.EffectivePeriod)) return false;
      if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
      if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
      if( !DeepComparable.IsExactly(Contributor, otherT.Contributor)) return false;
      if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
      if( !DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
      if( !DeepComparable.IsExactly(RelatedArtifact, otherT.RelatedArtifact)) return false;
      if( !DeepComparable.IsExactly(Trigger, otherT.Trigger)) return false;
      if( !DeepComparable.IsExactly(DataRequirement, otherT.DataRequirement)) return false;
      if( !DeepComparable.IsExactly(OperationDefinition, otherT.OperationDefinition)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (UrlElement != null) yield return UrlElement;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (VersionElement != null) yield return VersionElement;
        if (NameElement != null) yield return NameElement;
        if (TitleElement != null) yield return TitleElement;
        if (StatusElement != null) yield return StatusElement;
        if (ExperimentalElement != null) yield return ExperimentalElement;
        if (DateElement != null) yield return DateElement;
        if (PublisherElement != null) yield return PublisherElement;
        if (Description != null) yield return Description;
        if (Purpose != null) yield return Purpose;
        if (UsageElement != null) yield return UsageElement;
        if (ApprovalDateElement != null) yield return ApprovalDateElement;
        if (LastReviewDateElement != null) yield return LastReviewDateElement;
        if (EffectivePeriod != null) yield return EffectivePeriod;
        foreach (var elem in UseContext) { if (elem != null) yield return elem; }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
        foreach (var elem in Topic) { if (elem != null) yield return elem; }
        foreach (var elem in Contributor) { if (elem != null) yield return elem; }
        foreach (var elem in Contact) { if (elem != null) yield return elem; }
        if (Copyright != null) yield return Copyright;
        foreach (var elem in RelatedArtifact) { if (elem != null) yield return elem; }
        foreach (var elem in Trigger) { if (elem != null) yield return elem; }
        foreach (var elem in DataRequirement) { if (elem != null) yield return elem; }
        if (OperationDefinition != null) yield return OperationDefinition;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (UrlElement != null) yield return new ElementValue("url", UrlElement);
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (VersionElement != null) yield return new ElementValue("version", VersionElement);
        if (NameElement != null) yield return new ElementValue("name", NameElement);
        if (TitleElement != null) yield return new ElementValue("title", TitleElement);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
        if (DateElement != null) yield return new ElementValue("date", DateElement);
        if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
        if (Description != null) yield return new ElementValue("description", Description);
        if (Purpose != null) yield return new ElementValue("purpose", Purpose);
        if (UsageElement != null) yield return new ElementValue("usage", UsageElement);
        if (ApprovalDateElement != null) yield return new ElementValue("approvalDate", ApprovalDateElement);
        if (LastReviewDateElement != null) yield return new ElementValue("lastReviewDate", LastReviewDateElement);
        if (EffectivePeriod != null) yield return new ElementValue("effectivePeriod", EffectivePeriod);
        foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
        foreach (var elem in Topic) { if (elem != null) yield return new ElementValue("topic", elem); }
        foreach (var elem in Contributor) { if (elem != null) yield return new ElementValue("contributor", elem); }
        foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
        if (Copyright != null) yield return new ElementValue("copyright", Copyright);
        foreach (var elem in RelatedArtifact) { if (elem != null) yield return new ElementValue("relatedArtifact", elem); }
        foreach (var elem in Trigger) { if (elem != null) yield return new ElementValue("trigger", elem); }
        foreach (var elem in DataRequirement) { if (elem != null) yield return new ElementValue("dataRequirement", elem); }
        if (OperationDefinition != null) yield return new ElementValue("operationDefinition", OperationDefinition);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "url":
          value = UrlElement;
          return UrlElement is not null;
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "version":
          value = VersionElement;
          return VersionElement is not null;
        case "name":
          value = NameElement;
          return NameElement is not null;
        case "title":
          value = TitleElement;
          return TitleElement is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "experimental":
          value = ExperimentalElement;
          return ExperimentalElement is not null;
        case "date":
          value = DateElement;
          return DateElement is not null;
        case "publisher":
          value = PublisherElement;
          return PublisherElement is not null;
        case "description":
          value = Description;
          return Description is not null;
        case "purpose":
          value = Purpose;
          return Purpose is not null;
        case "usage":
          value = UsageElement;
          return UsageElement is not null;
        case "approvalDate":
          value = ApprovalDateElement;
          return ApprovalDateElement is not null;
        case "lastReviewDate":
          value = LastReviewDateElement;
          return LastReviewDateElement is not null;
        case "effectivePeriod":
          value = EffectivePeriod;
          return EffectivePeriod is not null;
        case "useContext":
          value = UseContext;
          return UseContext?.Any() == true;
        case "jurisdiction":
          value = Jurisdiction;
          return Jurisdiction?.Any() == true;
        case "topic":
          value = Topic;
          return Topic?.Any() == true;
        case "contributor":
          value = Contributor;
          return Contributor?.Any() == true;
        case "contact":
          value = Contact;
          return Contact?.Any() == true;
        case "copyright":
          value = Copyright;
          return Copyright is not null;
        case "relatedArtifact":
          value = RelatedArtifact;
          return RelatedArtifact?.Any() == true;
        case "trigger":
          value = Trigger;
          return Trigger?.Any() == true;
        case "dataRequirement":
          value = DataRequirement;
          return DataRequirement?.Any() == true;
        case "operationDefinition":
          value = OperationDefinition;
          return OperationDefinition is not null;
        default:
          return base.TryGetValue(key, out value);
      };

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (UrlElement is not null) yield return new KeyValuePair<string,object>("url",UrlElement);
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (VersionElement is not null) yield return new KeyValuePair<string,object>("version",VersionElement);
      if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
      if (TitleElement is not null) yield return new KeyValuePair<string,object>("title",TitleElement);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (ExperimentalElement is not null) yield return new KeyValuePair<string,object>("experimental",ExperimentalElement);
      if (DateElement is not null) yield return new KeyValuePair<string,object>("date",DateElement);
      if (PublisherElement is not null) yield return new KeyValuePair<string,object>("publisher",PublisherElement);
      if (Description is not null) yield return new KeyValuePair<string,object>("description",Description);
      if (Purpose is not null) yield return new KeyValuePair<string,object>("purpose",Purpose);
      if (UsageElement is not null) yield return new KeyValuePair<string,object>("usage",UsageElement);
      if (ApprovalDateElement is not null) yield return new KeyValuePair<string,object>("approvalDate",ApprovalDateElement);
      if (LastReviewDateElement is not null) yield return new KeyValuePair<string,object>("lastReviewDate",LastReviewDateElement);
      if (EffectivePeriod is not null) yield return new KeyValuePair<string,object>("effectivePeriod",EffectivePeriod);
      if (UseContext?.Any() == true) yield return new KeyValuePair<string,object>("useContext",UseContext);
      if (Jurisdiction?.Any() == true) yield return new KeyValuePair<string,object>("jurisdiction",Jurisdiction);
      if (Topic?.Any() == true) yield return new KeyValuePair<string,object>("topic",Topic);
      if (Contributor?.Any() == true) yield return new KeyValuePair<string,object>("contributor",Contributor);
      if (Contact?.Any() == true) yield return new KeyValuePair<string,object>("contact",Contact);
      if (Copyright is not null) yield return new KeyValuePair<string,object>("copyright",Copyright);
      if (RelatedArtifact?.Any() == true) yield return new KeyValuePair<string,object>("relatedArtifact",RelatedArtifact);
      if (Trigger?.Any() == true) yield return new KeyValuePair<string,object>("trigger",Trigger);
      if (DataRequirement?.Any() == true) yield return new KeyValuePair<string,object>("dataRequirement",DataRequirement);
      if (OperationDefinition is not null) yield return new KeyValuePair<string,object>("operationDefinition",OperationDefinition);
    }

  }

}

// end of file
