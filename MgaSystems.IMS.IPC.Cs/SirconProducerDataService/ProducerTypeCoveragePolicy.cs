// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerTypeCoveragePolicy
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
public class ProducerTypeCoveragePolicy : INotifyPropertyChanged
{
  private string policyNumberField;
  private DateTime effectiveDateField;
  private bool effectiveDateFieldSpecified;
  private DateTime expirationDateField;
  private bool expirationDateFieldSpecified;
  private string carrierNameField;
  private Decimal incidentAmountField;
  private Decimal totalAmountField;

  [XmlElement(Order = 0)]
  public string PolicyNumber
  {
    get => this.policyNumberField;
    set
    {
      this.policyNumberField = value;
      this.RaisePropertyChanged(nameof (PolicyNumber));
    }
  }

  [XmlElement(DataType = "date", Order = 1)]
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

  [XmlElement(DataType = "date", Order = 2)]
  public DateTime ExpirationDate
  {
    get => this.expirationDateField;
    set
    {
      this.expirationDateField = value;
      this.RaisePropertyChanged(nameof (ExpirationDate));
    }
  }

  [XmlIgnore]
  public bool ExpirationDateSpecified
  {
    get => this.expirationDateFieldSpecified;
    set
    {
      this.expirationDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (ExpirationDateSpecified));
    }
  }

  [XmlElement(Order = 3)]
  public string CarrierName
  {
    get => this.carrierNameField;
    set
    {
      this.carrierNameField = value;
      this.RaisePropertyChanged(nameof (CarrierName));
    }
  }

  [XmlElement(Order = 4)]
  public Decimal IncidentAmount
  {
    get => this.incidentAmountField;
    set
    {
      this.incidentAmountField = value;
      this.RaisePropertyChanged(nameof (IncidentAmount));
    }
  }

  [XmlElement(Order = 5)]
  public Decimal TotalAmount
  {
    get => this.totalAmountField;
    set
    {
      this.totalAmountField = value;
      this.RaisePropertyChanged(nameof (TotalAmount));
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
