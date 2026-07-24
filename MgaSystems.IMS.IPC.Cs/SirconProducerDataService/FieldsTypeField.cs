// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.FieldsTypeField
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
public class FieldsTypeField : INotifyPropertyChanged
{
  private string[] keysField;
  private string valueField;
  private string sourceField;

  [XmlArray(Order = 0)]
  [XmlArrayItem("Key", IsNullable = false)]
  public string[] Keys
  {
    get => this.keysField;
    set
    {
      this.keysField = value;
      this.RaisePropertyChanged(nameof (Keys));
    }
  }

  [XmlElement(Order = 1)]
  public string Value
  {
    get => this.valueField;
    set
    {
      this.valueField = value;
      this.RaisePropertyChanged(nameof (Value));
    }
  }

  [XmlElement(Order = 2)]
  public string Source
  {
    get => this.sourceField;
    set
    {
      this.sourceField = value;
      this.RaisePropertyChanged(nameof (Source));
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
