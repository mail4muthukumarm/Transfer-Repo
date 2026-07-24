// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.TransactionResponses
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
public class TransactionResponses : INotifyPropertyChanged
{
  private TransactionResponseType[] transactionResponseField;
  private int idField;
  private bool idFieldSpecified;
  private string customerBatchIdField;
  private int startRecordField;
  private bool startRecordFieldSpecified;
  private int endRecordField;
  private bool endRecordFieldSpecified;
  private int totalRecordsField;
  private bool totalRecordsFieldSpecified;

  [XmlElement("TransactionResponse", Order = 0)]
  public TransactionResponseType[] TransactionResponse
  {
    get => this.transactionResponseField;
    set
    {
      this.transactionResponseField = value;
      this.RaisePropertyChanged(nameof (TransactionResponse));
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

  [XmlAttribute]
  public string customerBatchId
  {
    get => this.customerBatchIdField;
    set
    {
      this.customerBatchIdField = value;
      this.RaisePropertyChanged(nameof (customerBatchId));
    }
  }

  [XmlAttribute]
  public int startRecord
  {
    get => this.startRecordField;
    set
    {
      this.startRecordField = value;
      this.RaisePropertyChanged(nameof (startRecord));
    }
  }

  [XmlIgnore]
  public bool startRecordSpecified
  {
    get => this.startRecordFieldSpecified;
    set
    {
      this.startRecordFieldSpecified = value;
      this.RaisePropertyChanged(nameof (startRecordSpecified));
    }
  }

  [XmlAttribute]
  public int endRecord
  {
    get => this.endRecordField;
    set
    {
      this.endRecordField = value;
      this.RaisePropertyChanged(nameof (endRecord));
    }
  }

  [XmlIgnore]
  public bool endRecordSpecified
  {
    get => this.endRecordFieldSpecified;
    set
    {
      this.endRecordFieldSpecified = value;
      this.RaisePropertyChanged(nameof (endRecordSpecified));
    }
  }

  [XmlAttribute]
  public int totalRecords
  {
    get => this.totalRecordsField;
    set
    {
      this.totalRecordsField = value;
      this.RaisePropertyChanged(nameof (totalRecords));
    }
  }

  [XmlIgnore]
  public bool totalRecordsSpecified
  {
    get => this.totalRecordsFieldSpecified;
    set
    {
      this.totalRecordsFieldSpecified = value;
      this.RaisePropertyChanged(nameof (totalRecordsSpecified));
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
