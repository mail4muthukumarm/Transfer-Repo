// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.DocumentTypeForm
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
public class DocumentTypeForm : INotifyPropertyChanged
{
  private FieldsTypeField[] fieldsField;
  private DocumentTypeFormSignature[] signaturesField;
  private int versionField;
  private bool versionFieldSpecified;
  private string templateNameField;
  private string typeCodeField;

  [XmlArray(Order = 0)]
  [XmlArrayItem("Field", IsNullable = false)]
  public FieldsTypeField[] Fields
  {
    get => this.fieldsField;
    set
    {
      this.fieldsField = value;
      this.RaisePropertyChanged(nameof (Fields));
    }
  }

  [XmlArray(Order = 1)]
  [XmlArrayItem("Signature", IsNullable = false)]
  public DocumentTypeFormSignature[] Signatures
  {
    get => this.signaturesField;
    set
    {
      this.signaturesField = value;
      this.RaisePropertyChanged(nameof (Signatures));
    }
  }

  [XmlAttribute]
  public int version
  {
    get => this.versionField;
    set
    {
      this.versionField = value;
      this.RaisePropertyChanged(nameof (version));
    }
  }

  [XmlIgnore]
  public bool versionSpecified
  {
    get => this.versionFieldSpecified;
    set
    {
      this.versionFieldSpecified = value;
      this.RaisePropertyChanged(nameof (versionSpecified));
    }
  }

  [XmlAttribute]
  public string templateName
  {
    get => this.templateNameField;
    set
    {
      this.templateNameField = value;
      this.RaisePropertyChanged(nameof (templateName));
    }
  }

  [XmlAttribute]
  public string typeCode
  {
    get => this.typeCodeField;
    set
    {
      this.typeCodeField = value;
      this.RaisePropertyChanged(nameof (typeCode));
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
