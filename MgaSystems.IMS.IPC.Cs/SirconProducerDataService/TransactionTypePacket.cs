// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.TransactionTypePacket
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
public class TransactionTypePacket : INotifyPropertyChanged
{
  private TransactionTypePacketDocument[] documentsField;
  private TransactionTypePacketSignature[] globalSignaturesField;
  private FieldsTypeField[] fieldsField;
  private string typeCodeField;

  [XmlArrayItem("Document", IsNullable = false)]
  public TransactionTypePacketDocument[] Documents
  {
    get => this.documentsField;
    set
    {
      this.documentsField = value;
      this.RaisePropertyChanged(nameof (Documents));
    }
  }

  [XmlArrayItem("Signature", IsNullable = false)]
  public TransactionTypePacketSignature[] GlobalSignatures
  {
    get => this.globalSignaturesField;
    set
    {
      this.globalSignaturesField = value;
      this.RaisePropertyChanged(nameof (GlobalSignatures));
    }
  }

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
