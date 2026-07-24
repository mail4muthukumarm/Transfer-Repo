// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.TransactionResponseType
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
public class TransactionResponseType : INotifyPropertyChanged
{
  private StatusType statusField;
  private CarrierType carrierField;
  private TransactionResponseTypeCurrentMilestone currentMilestoneField;
  private object itemField;
  private TransactionResponseTypeProcessingMessage[] processingMessagesField;
  private AppointmentType[] appointmentsField;
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

  [XmlElement(Order = 1)]
  public CarrierType Carrier
  {
    get => this.carrierField;
    set
    {
      this.carrierField = value;
      this.RaisePropertyChanged(nameof (Carrier));
    }
  }

  [XmlElement(Order = 2)]
  public TransactionResponseTypeCurrentMilestone CurrentMilestone
  {
    get => this.currentMilestoneField;
    set
    {
      this.currentMilestoneField = value;
      this.RaisePropertyChanged(nameof (CurrentMilestone));
    }
  }

  [XmlElement("Individual", typeof (IndividualType), Order = 3)]
  [XmlElement("Organization", typeof (OrganizationType), Order = 3)]
  public object Item
  {
    get => this.itemField;
    set
    {
      this.itemField = value;
      this.RaisePropertyChanged(nameof (Item));
    }
  }

  [XmlArray(Order = 4)]
  [XmlArrayItem("ProcessingMessage", IsNullable = false)]
  public TransactionResponseTypeProcessingMessage[] ProcessingMessages
  {
    get => this.processingMessagesField;
    set
    {
      this.processingMessagesField = value;
      this.RaisePropertyChanged(nameof (ProcessingMessages));
    }
  }

  [XmlArray(Order = 5)]
  [XmlArrayItem("Appointment", IsNullable = false)]
  public AppointmentType[] Appointments
  {
    get => this.appointmentsField;
    set
    {
      this.appointmentsField = value;
      this.RaisePropertyChanged(nameof (Appointments));
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
