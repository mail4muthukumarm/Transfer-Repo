// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.DocumentTypeFormSignature
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
public class DocumentTypeFormSignature : INotifyPropertyChanged
{
  private string keyField;
  private DateTime appliedDateField;
  private bool appliedDateFieldSpecified;
  private object itemField;

  [XmlElement(Order = 0)]
  public string Key
  {
    get => this.keyField;
    set
    {
      this.keyField = value;
      this.RaisePropertyChanged(nameof (Key));
    }
  }

  [XmlElement(Order = 1)]
  public DateTime AppliedDate
  {
    get => this.appliedDateField;
    set
    {
      this.appliedDateField = value;
      this.RaisePropertyChanged(nameof (AppliedDate));
    }
  }

  [XmlIgnore]
  public bool AppliedDateSpecified
  {
    get => this.appliedDateFieldSpecified;
    set
    {
      this.appliedDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (AppliedDateSpecified));
    }
  }

  [XmlElement("GlobalSignatureIdRef", typeof (string), Order = 2)]
  [XmlElement("SignatureContent", typeof (DocumentTypeFormSignatureSignatureContent), Order = 2)]
  public object Item
  {
    get => this.itemField;
    set
    {
      this.itemField = value;
      this.RaisePropertyChanged(nameof (Item));
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
