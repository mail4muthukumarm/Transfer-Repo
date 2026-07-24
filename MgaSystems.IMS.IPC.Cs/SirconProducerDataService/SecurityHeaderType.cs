// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SecurityHeaderType
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;

[GeneratedCode("System.Xml", "4.8.4161.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
[Serializable]
public class SecurityHeaderType : INotifyPropertyChanged
{
  private XmlElement[] anyField;
  private XmlAttribute[] anyAttrField;

  [XmlAnyElement(Order = 0)]
  public XmlElement[] Any
  {
    get => this.anyField;
    set
    {
      this.anyField = value;
      this.RaisePropertyChanged(nameof (Any));
    }
  }

  [XmlAnyAttribute]
  public XmlAttribute[] AnyAttr
  {
    get => this.anyAttrField;
    set
    {
      this.anyAttrField = value;
      this.RaisePropertyChanged(nameof (AnyAttr));
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

  [XmlElement(Order = 1)]
  public UsernameToken UsernameToken { get; set; } = new UsernameToken();
}
