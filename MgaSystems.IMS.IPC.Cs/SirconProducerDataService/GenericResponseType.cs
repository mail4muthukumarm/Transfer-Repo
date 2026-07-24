// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.GenericResponseType
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
public class GenericResponseType : INotifyPropertyChanged
{
  private StatusType statusField;
  private GenericResponseTypeProcessingMessage[] processingMessagesField;
  private int transactionIdField;
  private bool transactionIdFieldSpecified;

  [XmlElement(Order = 0)]
  public StatusType Status
  {
    get => this.statusField;
    set
    {
      this.statusField = value;
      this.RaisePropertyChanged(nameof (Status));
    }
  }

  [XmlArray(Order = 1)]
  [XmlArrayItem("ProcessingMessage", IsNullable = false)]
  public GenericResponseTypeProcessingMessage[] ProcessingMessages
  {
    get => this.processingMessagesField;
    set
    {
      this.processingMessagesField = value;
      this.RaisePropertyChanged(nameof (ProcessingMessages));
    }
  }

  [XmlAttribute]
  public int transactionId
  {
    get => this.transactionIdField;
    set
    {
      this.transactionIdField = value;
      this.RaisePropertyChanged(nameof (transactionId));
    }
  }

  [XmlIgnore]
  public bool transactionIdSpecified
  {
    get => this.transactionIdFieldSpecified;
    set
    {
      this.transactionIdFieldSpecified = value;
      this.RaisePropertyChanged(nameof (transactionIdSpecified));
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
