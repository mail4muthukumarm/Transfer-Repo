// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SentAppointmentsResponse
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
public class SentAppointmentsResponse : INotifyPropertyChanged
{
  private EntityType entityTypeField;
  private int producerIdField;
  private AppointmentTransactionType[] appointmentTransactionsField;

  [XmlElement(Order = 0)]
  public EntityType EntityType
  {
    get => this.entityTypeField;
    set
    {
      this.entityTypeField = value;
      this.RaisePropertyChanged(nameof (EntityType));
    }
  }

  [XmlElement(Order = 1)]
  public int ProducerId
  {
    get => this.producerIdField;
    set
    {
      this.producerIdField = value;
      this.RaisePropertyChanged(nameof (ProducerId));
    }
  }

  [XmlArray(Order = 2)]
  [XmlArrayItem("AppointmentTransaction", IsNullable = false)]
  public AppointmentTransactionType[] AppointmentTransactions
  {
    get => this.appointmentTransactionsField;
    set
    {
      this.appointmentTransactionsField = value;
      this.RaisePropertyChanged(nameof (AppointmentTransactions));
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
