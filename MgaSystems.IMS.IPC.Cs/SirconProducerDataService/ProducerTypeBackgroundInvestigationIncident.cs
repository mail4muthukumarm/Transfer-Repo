// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerTypeBackgroundInvestigationIncident
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
public class ProducerTypeBackgroundInvestigationIncident : INotifyPropertyChanged
{
  private string stateField;
  private string countyField;
  private string dateField;
  private string detailsField;

  [XmlElement(Order = 0)]
  public string State
  {
    get => this.stateField;
    set
    {
      this.stateField = value;
      this.RaisePropertyChanged(nameof (State));
    }
  }

  [XmlElement(Order = 1)]
  public string County
  {
    get => this.countyField;
    set
    {
      this.countyField = value;
      this.RaisePropertyChanged(nameof (County));
    }
  }

  [XmlElement(Order = 2)]
  public string Date
  {
    get => this.dateField;
    set
    {
      this.dateField = value;
      this.RaisePropertyChanged(nameof (Date));
    }
  }

  [XmlElement(Order = 3)]
  public string Details
  {
    get => this.detailsField;
    set
    {
      this.detailsField = value;
      this.RaisePropertyChanged(nameof (Details));
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
