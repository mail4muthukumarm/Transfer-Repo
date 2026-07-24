// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.CarrierType
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
[XmlType(Namespace = "http://px.sircon.com/schemas/2006/06/Transaction.xsd")]
[Serializable]
public class CarrierType : INotifyPropertyChanged
{
  private object itemField;
  private int idField;
  private bool idFieldSpecified;

  [XmlElement("Companies", typeof (CompaniesType), Order = 0)]
  [XmlElement("NaicGroup", typeof (string), Order = 0)]
  public object Item
  {
    get => this.itemField;
    set
    {
      this.itemField = value;
      this.RaisePropertyChanged(nameof (Item));
    }
  }

  [XmlAttribute]
  public int id
  {
    get => this.idField;
    set
    {
      this.idField = value;
      this.RaisePropertyChanged(nameof (id));
    }
  }

  [XmlIgnore]
  public bool idSpecified
  {
    get => this.idFieldSpecified;
    set
    {
      this.idFieldSpecified = value;
      this.RaisePropertyChanged(nameof (idSpecified));
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
