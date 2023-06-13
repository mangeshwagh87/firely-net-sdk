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
  /// Availability data for an {item}
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Availability","http://hl7.org/fhir/StructureDefinition/Availability")]
  public partial class Availability : Hl7.Fhir.Model.DataType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Availability"; } }

    /// <summary>
    /// Times the {item} is available
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Availability#AvailableTime", IsNestedType=true)]
    [BackboneType("Availability.availableTime")]
    public partial class AvailableTimeComponent : Hl7.Fhir.Model.Element
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Availability#AvailableTime"; } }

      /// <summary>
      /// mon | tue | wed | thu | fri | sat | sun
      /// </summary>
      [FhirElement("daysOfWeek", InSummary=true, Order=30)]
      [DeclaredType(Type = typeof(Code))]
      [Binding("DaysOfWeek")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Code<Hl7.Fhir.Model.DaysOfWeek>> DaysOfWeekElement
      {
        get { if(_DaysOfWeekElement==null) _DaysOfWeekElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DaysOfWeek>>(); return _DaysOfWeekElement; }
        set { _DaysOfWeekElement = value; OnPropertyChanged("DaysOfWeekElement"); }
      }

      private List<Code<Hl7.Fhir.Model.DaysOfWeek>> _DaysOfWeekElement;

      /// <summary>
      /// mon | tue | wed | thu | fri | sat | sun
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public IEnumerable<Hl7.Fhir.Model.DaysOfWeek?> DaysOfWeek
      {
        get { return DaysOfWeekElement != null ? DaysOfWeekElement.Select(elem => elem.Value) : null; }
        set
        {
          if (value == null)
            DaysOfWeekElement = null;
          else
            DaysOfWeekElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DaysOfWeek>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DaysOfWeek>(elem)));
          OnPropertyChanged("DaysOfWeek");
        }
      }

      /// <summary>
      /// Always available? i.e. 24 hour service
      /// </summary>
      [FhirElement("allDay", InSummary=true, Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.FhirBoolean AllDayElement
      {
        get { return _AllDayElement; }
        set { _AllDayElement = value; OnPropertyChanged("AllDayElement"); }
      }

      private Hl7.Fhir.Model.FhirBoolean _AllDayElement;

      /// <summary>
      /// Always available? i.e. 24 hour service
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public bool? AllDay
      {
        get { return AllDayElement != null ? AllDayElement.Value : null; }
        set
        {
          if (value == null)
            AllDayElement = null;
          else
            AllDayElement = new Hl7.Fhir.Model.FhirBoolean(value);
          OnPropertyChanged("AllDay");
        }
      }

      /// <summary>
      /// Opening time of day (ignored if allDay = true)
      /// </summary>
      [FhirElement("availableStartTime", InSummary=true, Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.Time AvailableStartTimeElement
      {
        get { return _AvailableStartTimeElement; }
        set { _AvailableStartTimeElement = value; OnPropertyChanged("AvailableStartTimeElement"); }
      }

      private Hl7.Fhir.Model.Time _AvailableStartTimeElement;

      /// <summary>
      /// Opening time of day (ignored if allDay = true)
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string AvailableStartTime
      {
        get { return AvailableStartTimeElement != null ? AvailableStartTimeElement.Value : null; }
        set
        {
          if (value == null)
            AvailableStartTimeElement = null;
          else
            AvailableStartTimeElement = new Hl7.Fhir.Model.Time(value);
          OnPropertyChanged("AvailableStartTime");
        }
      }

      /// <summary>
      /// Closing time of day (ignored if allDay = true)
      /// </summary>
      [FhirElement("availableEndTime", InSummary=true, Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.Time AvailableEndTimeElement
      {
        get { return _AvailableEndTimeElement; }
        set { _AvailableEndTimeElement = value; OnPropertyChanged("AvailableEndTimeElement"); }
      }

      private Hl7.Fhir.Model.Time _AvailableEndTimeElement;

      /// <summary>
      /// Closing time of day (ignored if allDay = true)
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string AvailableEndTime
      {
        get { return AvailableEndTimeElement != null ? AvailableEndTimeElement.Value : null; }
        set
        {
          if (value == null)
            AvailableEndTimeElement = null;
          else
            AvailableEndTimeElement = new Hl7.Fhir.Model.Time(value);
          OnPropertyChanged("AvailableEndTime");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as AvailableTimeComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(DaysOfWeekElement != null) dest.DaysOfWeekElement = new List<Code<Hl7.Fhir.Model.DaysOfWeek>>(DaysOfWeekElement.DeepCopy());
        if(AllDayElement != null) dest.AllDayElement = (Hl7.Fhir.Model.FhirBoolean)AllDayElement.DeepCopy();
        if(AvailableStartTimeElement != null) dest.AvailableStartTimeElement = (Hl7.Fhir.Model.Time)AvailableStartTimeElement.DeepCopy();
        if(AvailableEndTimeElement != null) dest.AvailableEndTimeElement = (Hl7.Fhir.Model.Time)AvailableEndTimeElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new AvailableTimeComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as AvailableTimeComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(DaysOfWeekElement, otherT.DaysOfWeekElement)) return false;
        if( !DeepComparable.Matches(AllDayElement, otherT.AllDayElement)) return false;
        if( !DeepComparable.Matches(AvailableStartTimeElement, otherT.AvailableStartTimeElement)) return false;
        if( !DeepComparable.Matches(AvailableEndTimeElement, otherT.AvailableEndTimeElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as AvailableTimeComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(DaysOfWeekElement, otherT.DaysOfWeekElement)) return false;
        if( !DeepComparable.IsExactly(AllDayElement, otherT.AllDayElement)) return false;
        if( !DeepComparable.IsExactly(AvailableStartTimeElement, otherT.AvailableStartTimeElement)) return false;
        if( !DeepComparable.IsExactly(AvailableEndTimeElement, otherT.AvailableEndTimeElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          foreach (var elem in DaysOfWeekElement) { if (elem != null) yield return elem; }
          if (AllDayElement != null) yield return AllDayElement;
          if (AvailableStartTimeElement != null) yield return AvailableStartTimeElement;
          if (AvailableEndTimeElement != null) yield return AvailableEndTimeElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          foreach (var elem in DaysOfWeekElement) { if (elem != null) yield return new ElementValue("daysOfWeek", elem); }
          if (AllDayElement != null) yield return new ElementValue("allDay", AllDayElement);
          if (AvailableStartTimeElement != null) yield return new ElementValue("availableStartTime", AvailableStartTimeElement);
          if (AvailableEndTimeElement != null) yield return new ElementValue("availableEndTime", AvailableEndTimeElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "daysOfWeek":
            value = DaysOfWeekElement;
            return DaysOfWeekElement?.Any() == true;
          case "allDay":
            value = AllDayElement;
            return AllDayElement is not null;
          case "availableStartTime":
            value = AvailableStartTimeElement;
            return AvailableStartTimeElement is not null;
          case "availableEndTime":
            value = AvailableEndTimeElement;
            return AvailableEndTimeElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (DaysOfWeekElement?.Any() == true) yield return new KeyValuePair<string,object>("daysOfWeek",DaysOfWeekElement);
        if (AllDayElement is not null) yield return new KeyValuePair<string,object>("allDay",AllDayElement);
        if (AvailableStartTimeElement is not null) yield return new KeyValuePair<string,object>("availableStartTime",AvailableStartTimeElement);
        if (AvailableEndTimeElement is not null) yield return new KeyValuePair<string,object>("availableEndTime",AvailableEndTimeElement);
      }

    }

    /// <summary>
    /// Not available during this time due to provided reason
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Availability#NotAvailableTime", IsNestedType=true)]
    [BackboneType("Availability.notAvailableTime")]
    public partial class NotAvailableTimeComponent : Hl7.Fhir.Model.Element
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Availability#NotAvailableTime"; } }

      /// <summary>
      /// Reason presented to the user explaining why time not available
      /// </summary>
      [FhirElement("description", InSummary=true, Order=30)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString DescriptionElement
      {
        get { return _DescriptionElement; }
        set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
      }

      private Hl7.Fhir.Model.FhirString _DescriptionElement;

      /// <summary>
      /// Reason presented to the user explaining why time not available
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Description
      {
        get { return DescriptionElement != null ? DescriptionElement.Value : null; }
        set
        {
          if (value == null)
            DescriptionElement = null;
          else
            DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Description");
        }
      }

      /// <summary>
      /// Service not available during this period
      /// </summary>
      [FhirElement("during", InSummary=true, Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.Period During
      {
        get { return _During; }
        set { _During = value; OnPropertyChanged("During"); }
      }

      private Hl7.Fhir.Model.Period _During;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as NotAvailableTimeComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
        if(During != null) dest.During = (Hl7.Fhir.Model.Period)During.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new NotAvailableTimeComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as NotAvailableTimeComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
        if( !DeepComparable.Matches(During, otherT.During)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as NotAvailableTimeComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
        if( !DeepComparable.IsExactly(During, otherT.During)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (DescriptionElement != null) yield return DescriptionElement;
          if (During != null) yield return During;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
          if (During != null) yield return new ElementValue("during", During);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "description":
            value = DescriptionElement;
            return DescriptionElement is not null;
          case "during":
            value = During;
            return During is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
        if (During is not null) yield return new KeyValuePair<string,object>("during",During);
      }

    }

    /// <summary>
    /// Times the {item} is available
    /// </summary>
    [FhirElement("availableTime", InSummary=true, Order=30)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Availability.AvailableTimeComponent> AvailableTime
    {
      get { if(_AvailableTime==null) _AvailableTime = new List<Hl7.Fhir.Model.Availability.AvailableTimeComponent>(); return _AvailableTime; }
      set { _AvailableTime = value; OnPropertyChanged("AvailableTime"); }
    }

    private List<Hl7.Fhir.Model.Availability.AvailableTimeComponent> _AvailableTime;

    /// <summary>
    /// Not available during this time due to provided reason
    /// </summary>
    [FhirElement("notAvailableTime", InSummary=true, Order=40)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Availability.NotAvailableTimeComponent> NotAvailableTime
    {
      get { if(_NotAvailableTime==null) _NotAvailableTime = new List<Hl7.Fhir.Model.Availability.NotAvailableTimeComponent>(); return _NotAvailableTime; }
      set { _NotAvailableTime = value; OnPropertyChanged("NotAvailableTime"); }
    }

    private List<Hl7.Fhir.Model.Availability.NotAvailableTimeComponent> _NotAvailableTime;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Availability;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(AvailableTime != null) dest.AvailableTime = new List<Hl7.Fhir.Model.Availability.AvailableTimeComponent>(AvailableTime.DeepCopy());
      if(NotAvailableTime != null) dest.NotAvailableTime = new List<Hl7.Fhir.Model.Availability.NotAvailableTimeComponent>(NotAvailableTime.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Availability());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Availability;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(AvailableTime, otherT.AvailableTime)) return false;
      if( !DeepComparable.Matches(NotAvailableTime, otherT.NotAvailableTime)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Availability;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(AvailableTime, otherT.AvailableTime)) return false;
      if( !DeepComparable.IsExactly(NotAvailableTime, otherT.NotAvailableTime)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in AvailableTime) { if (elem != null) yield return elem; }
        foreach (var elem in NotAvailableTime) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in AvailableTime) { if (elem != null) yield return new ElementValue("availableTime", elem); }
        foreach (var elem in NotAvailableTime) { if (elem != null) yield return new ElementValue("notAvailableTime", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "availableTime":
          value = AvailableTime;
          return AvailableTime?.Any() == true;
        case "notAvailableTime":
          value = NotAvailableTime;
          return NotAvailableTime?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (AvailableTime?.Any() == true) yield return new KeyValuePair<string,object>("availableTime",AvailableTime);
      if (NotAvailableTime?.Any() == true) yield return new KeyValuePair<string,object>("notAvailableTime",NotAvailableTime);
    }

  }

}

// end of file
