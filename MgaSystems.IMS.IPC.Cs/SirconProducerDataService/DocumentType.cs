// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.DocumentType
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
public class DocumentType : INotifyPropertyChanged
{
  private DateTime createdDateField;
  private DateTime lastModifiedDateField;
  private bool lastModifiedDateFieldSpecified;
  private string nameField;
  private object itemField;
  private int sequenceField;
  private bool sequenceFieldSpecified;
  private string idField;
  private string customerIdField;

  [XmlElement(Order = 0)]
  public DateTime CreatedDate
  {
    get => this.createdDateField;
    set
    {
      this.createdDateField = value;
      this.RaisePropertyChanged(nameof (CreatedDate));
    }
  }

  [XmlElement(Order = 1)]
  public DateTime LastModifiedDate
  {
    get => this.lastModifiedDateField;
    set
    {
      this.lastModifiedDateField = value;
      this.RaisePropertyChanged(nameof (LastModifiedDate));
    }
  }

  [XmlIgnore]
  public bool LastModifiedDateSpecified
  {
    get => this.lastModifiedDateFieldSpecified;
    set
    {
      this.lastModifiedDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (LastModifiedDateSpecified));
    }
  }

  [XmlElement(Order = 2)]
  public string Name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (Name));
    }
  }

  [XmlElement("Attachment", typeof (ContentType), Order = 3)]
  [XmlElement("Form", typeof (DocumentTypeForm), Order = 3)]
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
  public int sequence
  {
    get => this.sequenceField;
    set
    {
      this.sequenceField = value;
      this.RaisePropertyChanged(nameof (sequence));
    }
  }

  [XmlIgnore]
  public bool sequenceSpecified
  {
    get => this.sequenceFieldSpecified;
    set
    {
      this.sequenceFieldSpecified = value;
      this.RaisePropertyChanged(nameof (sequenceSpecified));
    }
  }

  [XmlAttribute]
  public string id
  {
    get => this.idField;
    set
    {
      this.idField = value;
      this.RaisePropertyChanged(nameof (id));
    }
  }

  [XmlAttribute]
  public string customerId
  {
    get => this.customerIdField;
    set
    {
      this.customerIdField = value;
      this.RaisePropertyChanged(nameof (customerId));
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
