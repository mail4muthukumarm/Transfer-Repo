// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.TransactionType
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
public class TransactionType : INotifyPropertyChanged
{
  private StatusType statusField;
  private bool statusFieldSpecified;
  private DateTime creationDateField;
  private DateTime lastTouchedDateField;
  private bool lastTouchedDateFieldSpecified;
  private DistributorType[] distributorHierarchyField;
  private TransactionTypeDisbursee disburseeField;
  private ProducerType producerField;
  private CarrierType carrierField;
  private TransactionTypePacket packetField;
  private string[] processingInstructionsField;
  private ProducerType[] additionalProducersField;
  private CodeDomainValueType transactionType1Field;
  private CodeDomainValueType latestMilestoneField;
  private int idField;
  private bool idFieldSpecified;
  private string customerIdField;

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

  [XmlIgnore]
  public bool StatusSpecified
  {
    get => this.statusFieldSpecified;
    set
    {
      this.statusFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StatusSpecified));
    }
  }

  [XmlElement(Order = 1)]
  public DateTime CreationDate
  {
    get => this.creationDateField;
    set
    {
      this.creationDateField = value;
      this.RaisePropertyChanged(nameof (CreationDate));
    }
  }

  [XmlElement(Order = 2)]
  public DateTime LastTouchedDate
  {
    get => this.lastTouchedDateField;
    set
    {
      this.lastTouchedDateField = value;
      this.RaisePropertyChanged(nameof (LastTouchedDate));
    }
  }

  [XmlIgnore]
  public bool LastTouchedDateSpecified
  {
    get => this.lastTouchedDateFieldSpecified;
    set
    {
      this.lastTouchedDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (LastTouchedDateSpecified));
    }
  }

  [XmlArray(Order = 3)]
  [XmlArrayItem("Distributor", IsNullable = false)]
  public DistributorType[] DistributorHierarchy
  {
    get => this.distributorHierarchyField;
    set
    {
      this.distributorHierarchyField = value;
      this.RaisePropertyChanged(nameof (DistributorHierarchy));
    }
  }

  [XmlElement(Order = 4)]
  public TransactionTypeDisbursee Disbursee
  {
    get => this.disburseeField;
    set
    {
      this.disburseeField = value;
      this.RaisePropertyChanged(nameof (Disbursee));
    }
  }

  [XmlElement(Order = 5)]
  public ProducerType Producer
  {
    get => this.producerField;
    set
    {
      this.producerField = value;
      this.RaisePropertyChanged(nameof (Producer));
    }
  }

  [XmlElement(Order = 6)]
  public CarrierType Carrier
  {
    get => this.carrierField;
    set
    {
      this.carrierField = value;
      this.RaisePropertyChanged(nameof (Carrier));
    }
  }

  [XmlElement(Order = 7)]
  public TransactionTypePacket Packet
  {
    get => this.packetField;
    set
    {
      this.packetField = value;
      this.RaisePropertyChanged(nameof (Packet));
    }
  }

  [XmlArray(Order = 8)]
  [XmlArrayItem("ProcessingInstruction", IsNullable = false)]
  public string[] ProcessingInstructions
  {
    get => this.processingInstructionsField;
    set
    {
      this.processingInstructionsField = value;
      this.RaisePropertyChanged(nameof (ProcessingInstructions));
    }
  }

  [XmlArray(Order = 9)]
  [XmlArrayItem("Producer", IsNullable = false)]
  public ProducerType[] AdditionalProducers
  {
    get => this.additionalProducersField;
    set
    {
      this.additionalProducersField = value;
      this.RaisePropertyChanged(nameof (AdditionalProducers));
    }
  }

  [XmlElement("TransactionType", Order = 10)]
  public CodeDomainValueType TransactionType1
  {
    get => this.transactionType1Field;
    set
    {
      this.transactionType1Field = value;
      this.RaisePropertyChanged(nameof (TransactionType1));
    }
  }

  [XmlElement(Order = 11)]
  public CodeDomainValueType LatestMilestone
  {
    get => this.latestMilestoneField;
    set
    {
      this.latestMilestoneField = value;
      this.RaisePropertyChanged(nameof (LatestMilestone));
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
