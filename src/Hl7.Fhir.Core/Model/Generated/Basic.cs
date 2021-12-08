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
  /// Resource for non-supported content
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Basic","http://hl7.org/fhir/StructureDefinition/Basic", IsResource=true)]
  public partial class Basic : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Basic"; } }

    /// <summary>
    /// Business identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Kind of Resource
    /// </summary>
    [FhirElement("code", InSummary=true, Order=100)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Code
    {
      get { return _Code; }
      set { _Code = value; OnPropertyChanged("Code"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Code;

    /// <summary>
    /// Identifies the focus of this resource
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=110)]
    [CLSCompliant(false)]
    [References("Resource")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// When created
    /// </summary>
    [FhirElement("created", InSummary=true, Order=120)]
    [DataMember]
    public Hl7.Fhir.Model.Date CreatedElement
    {
      get { return _CreatedElement; }
      set { _CreatedElement = value; OnPropertyChanged("CreatedElement"); }
    }

    private Hl7.Fhir.Model.Date _CreatedElement;

    /// <summary>
    /// When created
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Created
    {
      get { return CreatedElement != null ? CreatedElement.Value : null; }
      set
      {
        if (value == null)
          CreatedElement = null;
        else
          CreatedElement = new Hl7.Fhir.Model.Date(value);
        OnPropertyChanged("Created");
      }
    }

    /// <summary>
    /// Who created
    /// </summary>
    [FhirElement("author", InSummary=true, Order=130)]
    [CLSCompliant(false)]
    [References("Practitioner","Patient","RelatedPerson")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Author
    {
      get { return _Author; }
      set { _Author = value; OnPropertyChanged("Author"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Author;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Basic;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(CreatedElement != null) dest.CreatedElement = (Hl7.Fhir.Model.Date)CreatedElement.DeepCopy();
      if(Author != null) dest.Author = (Hl7.Fhir.Model.ResourceReference)Author.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Basic());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Basic;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Code, otherT.Code)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
      if( !DeepComparable.Matches(Author, otherT.Author)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Basic;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
      if( !DeepComparable.IsExactly(Author, otherT.Author)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (Code != null) yield return Code;
        if (Subject != null) yield return Subject;
        if (CreatedElement != null) yield return CreatedElement;
        if (Author != null) yield return Author;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (Code != null) yield return new ElementValue("code", Code);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
        if (Author != null) yield return new ElementValue("author", Author);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "code":
          value = Code;
          return Code is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "created":
          value = CreatedElement;
          return CreatedElement is not null;
        case "author":
          value = Author;
          return Author is not null;
        default:
          return base.TryGetValue(key, out value);
      };

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (CreatedElement is not null) yield return new KeyValuePair<string,object>("created",CreatedElement);
      if (Author is not null) yield return new KeyValuePair<string,object>("author",Author);
    }

  }

}

// end of file
