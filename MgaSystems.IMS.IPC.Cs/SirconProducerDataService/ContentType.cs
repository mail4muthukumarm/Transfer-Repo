// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ContentType
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
public class ContentType : INotifyPropertyChanged
{
  private MimeType mimeTypeField;
  private string fileNameField;
  private byte[] valueField;

  [XmlAttribute]
  public MimeType mimeType
  {
    get => this.mimeTypeField;
    set
    {
      this.mimeTypeField = value;
      this.RaisePropertyChanged(nameof (mimeType));
    }
  }

  [XmlAttribute]
  public string fileName
  {
    get => this.fileNameField;
    set
    {
      this.fileNameField = value;
      this.RaisePropertyChanged(nameof (fileName));
    }
  }

  [XmlText(DataType = "base64Binary")]
  public byte[] Value
  {
    get => this.valueField;
    set
    {
      this.valueField = value;
      this.RaisePropertyChanged(nameof (Value));
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
