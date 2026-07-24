// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.UpdateProducerRecordRequest
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
public class UpdateProducerRecordRequest : INotifyPropertyChanged
{
  private StatusType statusField;
  private bool statusFieldSpecified;
  private int statusOrderNumberField;
  private bool statusOrderNumberFieldSpecified;
  private DateTime lastTouchedDateField;
  private ProducerType producerField;
  private CodeDomainValueType transactionTypeField;
  private string trackingIdField;
  private int[] appointmentIdsField;
  private CodeDomainValueType latestMilestoneField;
  private string producerRequestIdField;

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
  public int StatusOrderNumber
  {
    get => this.statusOrderNumberField;
    set
    {
      this.statusOrderNumberField = value;
      this.RaisePropertyChanged(nameof (StatusOrderNumber));
    }
  }

  [XmlIgnore]
  public bool StatusOrderNumberSpecified
  {
    get => this.statusOrderNumberFieldSpecified;
    set
    {
      this.statusOrderNumberFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StatusOrderNumberSpecified));
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

  [XmlElement(Order = 3)]
  public ProducerType Producer
  {
    get => this.producerField;
    set
    {
      this.producerField = value;
      this.RaisePropertyChanged(nameof (Producer));
    }
  }

  [XmlElement(Order = 4)]
  public CodeDomainValueType TransactionType
  {
    get => this.transactionTypeField;
    set
    {
      this.transactionTypeField = value;
      this.RaisePropertyChanged(nameof (TransactionType));
    }
  }

  [XmlElement(Order = 5)]
  public string TrackingId
  {
    get => this.trackingIdField;
    set
    {
      this.trackingIdField = value;
      this.RaisePropertyChanged(nameof (TrackingId));
    }
  }

  [XmlArray(Order = 6)]
  [XmlArrayItem("AppointmentId", IsNullable = false)]
  public int[] AppointmentIds
  {
    get => this.appointmentIdsField;
    set
    {
      this.appointmentIdsField = value;
      this.RaisePropertyChanged(nameof (AppointmentIds));
    }
  }

  [XmlElement(Order = 7)]
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
  public string producerRequestId
  {
    get => this.producerRequestIdField;
    set
    {
      this.producerRequestIdField = value;
      this.RaisePropertyChanged(nameof (producerRequestId));
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
