// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.InactivateLicenseStateRequest
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
public class InactivateLicenseStateRequest : INotifyPropertyChanged
{
  private ProducerCriteriaType producerField;
  private StateCodeType[] statesField;
  private DateTime effectiveDateField;

  [XmlElement(Order = 0)]
  public ProducerCriteriaType Producer
  {
    get => this.producerField;
    set
    {
      this.producerField = value;
      this.RaisePropertyChanged(nameof (Producer));
    }
  }

  [XmlArray(Order = 1)]
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

  [XmlElement(DataType = "date", Order = 2)]
  public DateTime EffectiveDate
  {
    get => this.effectiveDateField;
    set
    {
      this.effectiveDateField = value;
      this.RaisePropertyChanged(nameof (EffectiveDate));
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
