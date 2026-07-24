// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.RelationshipCriteria
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;

[GeneratedCode("System.Xml", "4.8.4161.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://px.sircon.com/schemas/2006/06/Transaction.xsd")]
[Serializable]
public class RelationshipCriteria : INotifyPropertyChanged
{
  private DateTime effectiveDateField;
  private bool effectiveDateFieldSpecified;
  private ProducerCriteriaType producerField;
  private ProducerCriteriaType relatedProducerField;
  private CompanyCriteriaType[] companiesField;
  private RelationshipCriteriaOverrideValues overrideValuesField;
  private StateCodeType[] statesField;

  [XmlElement(DataType = "date", Order = 0)]
  public DateTime EffectiveDate
  {
    get => this.effectiveDateField;
    set
    {
      this.effectiveDateField = value;
      this.RaisePropertyChanged(nameof (EffectiveDate));
    }
  }

  [XmlIgnore]
  public bool EffectiveDateSpecified
  {
    get => this.effectiveDateFieldSpecified;
    set
    {
      this.effectiveDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (EffectiveDateSpecified));
    }
  }

  [XmlElement(Order = 1)]
  public ProducerCriteriaType Producer
  {
    get => this.producerField;
    set
    {
      this.producerField = value;
      this.RaisePropertyChanged(nameof (Producer));
    }
  }

  [XmlElement(Order = 2)]
  public ProducerCriteriaType RelatedProducer
  {
    get => this.relatedProducerField;
    set
    {
      this.relatedProducerField = value;
      this.RaisePropertyChanged(nameof (RelatedProducer));
    }
  }

  [XmlArray(Order = 3)]
  [XmlArrayItem("Company", IsNullable = false)]
  public CompanyCriteriaType[] Companies
  {
    get => this.companiesField;
    set
    {
      this.companiesField = value;
      this.RaisePropertyChanged(nameof (Companies));
    }
  }

  [XmlElement(Order = 4)]
  public RelationshipCriteriaOverrideValues OverrideValues
  {
    get => this.overrideValuesField;
    set
    {
      this.overrideValuesField = value;
      this.RaisePropertyChanged(nameof (OverrideValues));
    }
  }

  [XmlArray(Order = 5)]
  [XmlArrayItem("State", IsNullable = false)]
  public StateCodeType[] States
  {
    get => this.statesField;
    set
    {
      this.statesField = value;
      this.RaisePropertyChanged(nameof (States));
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  protected void RaisePropertyChanged(string propertyName)
  {
    PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    if (propertyChanged == null)
      return;
    propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
  }
}
