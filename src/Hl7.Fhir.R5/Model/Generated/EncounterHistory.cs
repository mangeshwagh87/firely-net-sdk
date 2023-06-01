// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0

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
  /// A record of significant events/milestones key data throughout the history of an Encounter
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("EncounterHistory","http://hl7.org/fhir/StructureDefinition/EncounterHistory", IsResource=true)]
  public partial class EncounterHistory : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "EncounterHistory"; } }

    /// <summary>
    /// Location of the patient at this point in the encounter
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("EncounterHistory#Location", IsNestedType=true)]
    public partial class LocationComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "EncounterHistory#Location"; } }

      /// <summary>
      /// Location the encounter takes place
      /// </summary>
      [FhirElement("location", Order=40, FiveWs="FiveWs.where[x]")]
      [CLSCompliant(false)]
      [References("Location")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Location
      {
        get { return _Location; }
        set { _Location = value; OnPropertyChanged("Location"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Location;

      /// <summary>
      /// The physical type of the location (usually the level in the location hierarchy - bed, room, ward, virtual etc.)
      /// </summary>
      [FhirElement("form", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Form
      {
        get { return _Form; }
        set { _Form = value; OnPropertyChanged("Form"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Form;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as LocationComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Location != null) dest.Location = (Hl7.Fhir.Model.ResourceReference)Location.DeepCopy();
        if(Form != null) dest.Form = (Hl7.Fhir.Model.CodeableConcept)Form.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new LocationComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as LocationComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Location, otherT.Location)) return false;
        if( !DeepComparable.Matches(Form, otherT.Form)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as LocationComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
        if( !DeepComparable.IsExactly(Form, otherT.Form)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Location != null) yield return Location;
          if (Form != null) yield return Form;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Location != null) yield return new ElementValue("location", Location);
          if (Form != null) yield return new ElementValue("form", Form);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "location":
            value = Location;
            return Location is not null;
          case "form":
            value = Form;
            return Form is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Location is not null) yield return new KeyValuePair<string,object>("location",Location);
        if (Form is not null) yield return new KeyValuePair<string,object>("form",Form);
      }

    }

    /// <summary>
    /// The Encounter associated with this set of historic values
    /// </summary>
    [FhirElement("encounter", Order=90)]
    [CLSCompliant(false)]
    [References("Encounter")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Encounter
    {
      get { return _Encounter; }
      set { _Encounter = value; OnPropertyChanged("Encounter"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Encounter;

    /// <summary>
    /// Identifier(s) by which this encounter is known
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=100, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// planned | in-progress | on-hold | discharged | completed | cancelled | discontinued | entered-in-error | unknown
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=110, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("EncounterStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.EncounterStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.EncounterStatus> _StatusElement;

    /// <summary>
    /// planned | in-progress | on-hold | discharged | completed | cancelled | discontinued | entered-in-error | unknown
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.EncounterStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.EncounterStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Classification of patient encounter
    /// </summary>
    [FhirElement("class", InSummary=true, Order=120, FiveWs="FiveWs.class")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Class
    {
      get { return _Class; }
      set { _Class = value; OnPropertyChanged("Class"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Class;

    /// <summary>
    /// Specific type of encounter
    /// </summary>
    [FhirElement("type", InSummary=true, Order=130, FiveWs="FiveWs.what[x]")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Type
    {
      get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Type; }
      set { _Type = value; OnPropertyChanged("Type"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Type;

    /// <summary>
    /// Specific type of service
    /// </summary>
    [FhirElement("serviceType", InSummary=true, Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableReference> ServiceType
    {
      get { if(_ServiceType==null) _ServiceType = new List<Hl7.Fhir.Model.CodeableReference>(); return _ServiceType; }
      set { _ServiceType = value; OnPropertyChanged("ServiceType"); }
    }

    private List<Hl7.Fhir.Model.CodeableReference> _ServiceType;

    /// <summary>
    /// The patient or group related to this encounter
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=150, FiveWs="FiveWs.subject[x]")]
    [CLSCompliant(false)]
    [References("Patient","Group")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// The current status of the subject in relation to the Encounter
    /// </summary>
    [FhirElement("subjectStatus", Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept SubjectStatus
    {
      get { return _SubjectStatus; }
      set { _SubjectStatus = value; OnPropertyChanged("SubjectStatus"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _SubjectStatus;

    /// <summary>
    /// The actual start and end time associated with this set of values associated with the encounter
    /// </summary>
    [FhirElement("actualPeriod", Order=170, FiveWs="FiveWs.done[x]")]
    [DataMember]
    public Hl7.Fhir.Model.Period ActualPeriod
    {
      get { return _ActualPeriod; }
      set { _ActualPeriod = value; OnPropertyChanged("ActualPeriod"); }
    }

    private Hl7.Fhir.Model.Period _ActualPeriod;

    /// <summary>
    /// The planned start date/time (or admission date) of the encounter
    /// </summary>
    [FhirElement("plannedStartDate", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime PlannedStartDateElement
    {
      get { return _PlannedStartDateElement; }
      set { _PlannedStartDateElement = value; OnPropertyChanged("PlannedStartDateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _PlannedStartDateElement;

    /// <summary>
    /// The planned start date/time (or admission date) of the encounter
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string PlannedStartDate
    {
      get { return PlannedStartDateElement != null ? PlannedStartDateElement.Value : null; }
      set
      {
        if (value == null)
          PlannedStartDateElement = null;
        else
          PlannedStartDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("PlannedStartDate");
      }
    }

    /// <summary>
    /// The planned end date/time (or discharge date) of the encounter
    /// </summary>
    [FhirElement("plannedEndDate", Order=190)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime PlannedEndDateElement
    {
      get { return _PlannedEndDateElement; }
      set { _PlannedEndDateElement = value; OnPropertyChanged("PlannedEndDateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _PlannedEndDateElement;

    /// <summary>
    /// The planned end date/time (or discharge date) of the encounter
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string PlannedEndDate
    {
      get { return PlannedEndDateElement != null ? PlannedEndDateElement.Value : null; }
      set
      {
        if (value == null)
          PlannedEndDateElement = null;
        else
          PlannedEndDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("PlannedEndDate");
      }
    }

    /// <summary>
    /// Actual quantity of time the encounter lasted (less time absent)
    /// </summary>
    [FhirElement("length", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.Duration Length
    {
      get { return _Length; }
      set { _Length = value; OnPropertyChanged("Length"); }
    }

    private Hl7.Fhir.Model.Duration _Length;

    /// <summary>
    /// Location of the patient at this point in the encounter
    /// </summary>
    [FhirElement("location", Order=210)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.EncounterHistory.LocationComponent> Location
    {
      get { if(_Location==null) _Location = new List<Hl7.Fhir.Model.EncounterHistory.LocationComponent>(); return _Location; }
      set { _Location = value; OnPropertyChanged("Location"); }
    }

    private List<Hl7.Fhir.Model.EncounterHistory.LocationComponent> _Location;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as EncounterHistory;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.EncounterStatus>)StatusElement.DeepCopy();
      if(Class != null) dest.Class = (Hl7.Fhir.Model.CodeableConcept)Class.DeepCopy();
      if(Type != null) dest.Type = new List<Hl7.Fhir.Model.CodeableConcept>(Type.DeepCopy());
      if(ServiceType != null) dest.ServiceType = new List<Hl7.Fhir.Model.CodeableReference>(ServiceType.DeepCopy());
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(SubjectStatus != null) dest.SubjectStatus = (Hl7.Fhir.Model.CodeableConcept)SubjectStatus.DeepCopy();
      if(ActualPeriod != null) dest.ActualPeriod = (Hl7.Fhir.Model.Period)ActualPeriod.DeepCopy();
      if(PlannedStartDateElement != null) dest.PlannedStartDateElement = (Hl7.Fhir.Model.FhirDateTime)PlannedStartDateElement.DeepCopy();
      if(PlannedEndDateElement != null) dest.PlannedEndDateElement = (Hl7.Fhir.Model.FhirDateTime)PlannedEndDateElement.DeepCopy();
      if(Length != null) dest.Length = (Hl7.Fhir.Model.Duration)Length.DeepCopy();
      if(Location != null) dest.Location = new List<Hl7.Fhir.Model.EncounterHistory.LocationComponent>(Location.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new EncounterHistory());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as EncounterHistory;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Class, otherT.Class)) return false;
      if( !DeepComparable.Matches(Type, otherT.Type)) return false;
      if( !DeepComparable.Matches(ServiceType, otherT.ServiceType)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(SubjectStatus, otherT.SubjectStatus)) return false;
      if( !DeepComparable.Matches(ActualPeriod, otherT.ActualPeriod)) return false;
      if( !DeepComparable.Matches(PlannedStartDateElement, otherT.PlannedStartDateElement)) return false;
      if( !DeepComparable.Matches(PlannedEndDateElement, otherT.PlannedEndDateElement)) return false;
      if( !DeepComparable.Matches(Length, otherT.Length)) return false;
      if( !DeepComparable.Matches(Location, otherT.Location)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as EncounterHistory;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Class, otherT.Class)) return false;
      if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
      if( !DeepComparable.IsExactly(ServiceType, otherT.ServiceType)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(SubjectStatus, otherT.SubjectStatus)) return false;
      if( !DeepComparable.IsExactly(ActualPeriod, otherT.ActualPeriod)) return false;
      if( !DeepComparable.IsExactly(PlannedStartDateElement, otherT.PlannedStartDateElement)) return false;
      if( !DeepComparable.IsExactly(PlannedEndDateElement, otherT.PlannedEndDateElement)) return false;
      if( !DeepComparable.IsExactly(Length, otherT.Length)) return false;
      if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (Encounter != null) yield return Encounter;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        if (Class != null) yield return Class;
        foreach (var elem in Type) { if (elem != null) yield return elem; }
        foreach (var elem in ServiceType) { if (elem != null) yield return elem; }
        if (Subject != null) yield return Subject;
        if (SubjectStatus != null) yield return SubjectStatus;
        if (ActualPeriod != null) yield return ActualPeriod;
        if (PlannedStartDateElement != null) yield return PlannedStartDateElement;
        if (PlannedEndDateElement != null) yield return PlannedEndDateElement;
        if (Length != null) yield return Length;
        foreach (var elem in Location) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (Encounter != null) yield return new ElementValue("encounter", Encounter);
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (Class != null) yield return new ElementValue("class", Class);
        foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
        foreach (var elem in ServiceType) { if (elem != null) yield return new ElementValue("serviceType", elem); }
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (SubjectStatus != null) yield return new ElementValue("subjectStatus", SubjectStatus);
        if (ActualPeriod != null) yield return new ElementValue("actualPeriod", ActualPeriod);
        if (PlannedStartDateElement != null) yield return new ElementValue("plannedStartDate", PlannedStartDateElement);
        if (PlannedEndDateElement != null) yield return new ElementValue("plannedEndDate", PlannedEndDateElement);
        if (Length != null) yield return new ElementValue("length", Length);
        foreach (var elem in Location) { if (elem != null) yield return new ElementValue("location", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "encounter":
          value = Encounter;
          return Encounter is not null;
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "class":
          value = Class;
          return Class is not null;
        case "type":
          value = Type;
          return Type?.Any() == true;
        case "serviceType":
          value = ServiceType;
          return ServiceType?.Any() == true;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "subjectStatus":
          value = SubjectStatus;
          return SubjectStatus is not null;
        case "actualPeriod":
          value = ActualPeriod;
          return ActualPeriod is not null;
        case "plannedStartDate":
          value = PlannedStartDateElement;
          return PlannedStartDateElement is not null;
        case "plannedEndDate":
          value = PlannedEndDateElement;
          return PlannedEndDateElement is not null;
        case "length":
          value = Length;
          return Length is not null;
        case "location":
          value = Location;
          return Location?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Encounter is not null) yield return new KeyValuePair<string,object>("encounter",Encounter);
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Class is not null) yield return new KeyValuePair<string,object>("class",Class);
      if (Type?.Any() == true) yield return new KeyValuePair<string,object>("type",Type);
      if (ServiceType?.Any() == true) yield return new KeyValuePair<string,object>("serviceType",ServiceType);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (SubjectStatus is not null) yield return new KeyValuePair<string,object>("subjectStatus",SubjectStatus);
      if (ActualPeriod is not null) yield return new KeyValuePair<string,object>("actualPeriod",ActualPeriod);
      if (PlannedStartDateElement is not null) yield return new KeyValuePair<string,object>("plannedStartDate",PlannedStartDateElement);
      if (PlannedEndDateElement is not null) yield return new KeyValuePair<string,object>("plannedEndDate",PlannedEndDateElement);
      if (Length is not null) yield return new KeyValuePair<string,object>("length",Length);
      if (Location?.Any() == true) yield return new KeyValuePair<string,object>("location",Location);
    }

  }

}

// end of file
