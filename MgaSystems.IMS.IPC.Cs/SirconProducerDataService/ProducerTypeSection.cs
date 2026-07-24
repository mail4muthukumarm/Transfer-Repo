// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerTypeSection
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
public class ProducerTypeSection : INotifyPropertyChanged
{
  private string[] messageField;
  private ValidationSectionType nameField;
  private bool nameFieldSpecified;

  [XmlElement("Message", DataType = "normalizedString", Order = 0)]
  public string[] Message
  {
    get => this.messageField;
    set
    {
      this.messageField = value;
      this.RaisePropertyChanged(nameof (Message));
    }
  }

  [XmlAttribute]
  public ValidationSectionType name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (name));
    }
  }

  [XmlIgnore]
  public bool nameSpecified
  {
    get => this.nameFieldSpecified;
    set
    {
      this.nameFieldSpecified = value;
      this.RaisePropertyChanged(nameof (nameSpecified));
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
