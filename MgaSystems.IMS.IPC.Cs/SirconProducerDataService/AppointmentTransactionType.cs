// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.AppointmentTransactionType
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
public class AppointmentTransactionType : INotifyPropertyChanged
{
  private AppointmentType appointmentField;
  private AppointmentTransactionTypeType[] combinedAppointmentTypesField;
  private AppointmentTransactionTypeTransactionMessage transactionMessageField;
  private int xmlTransIdField;
  private bool xmlTransIdFieldSpecified;
  private int sirconInterfaceIdField;
  private bool sirconInterfaceIdFieldSpecified;

  public AppointmentType Appointment
  {
    get => this.appointmentField;
    set
    {
      this.appointmentField = value;
      this.RaisePropertyChanged(nameof (Appointment));
    }
  }

  [XmlArrayItem("Type", IsNullable = false)]
  public AppointmentTransactionTypeType[] CombinedAppointmentTypes
  {
    get => this.combinedAppointmentTypesField;
    set
    {
      this.combinedAppointmentTypesField = value;
      this.RaisePropertyChanged(nameof (CombinedAppointmentTypes));
    }
  }

  public AppointmentTransactionTypeTransactionMessage TransactionMessage
  {
    get => this.transactionMessageField;
    set
    {
      this.transactionMessageField = value;
      this.RaisePropertyChanged(nameof (TransactionMessage));
    }
  }

  [XmlAttribute]
  public int xmlTransId
  {
    get => this.xmlTransIdField;
    set
    {
      this.xmlTransIdField = value;
      this.RaisePropertyChanged(nameof (xmlTransId));
    }
  }

  [XmlIgnore]
  public bool xmlTransIdSpecified
  {
    get => this.xmlTransIdFieldSpecified;
    set
    {
      this.xmlTransIdFieldSpecified = value;
      this.RaisePropertyChanged(nameof (xmlTransIdSpecified));
    }
  }

  [XmlAttribute]
  public int sirconInterfaceId
  {
    get => this.sirconInterfaceIdField;
    set
    {
      this.sirconInterfaceIdField = value;
      this.RaisePropertyChanged(nameof (sirconInterfaceId));
    }
  }

  [XmlIgnore]
  public bool sirconInterfaceIdSpecified
  {
    get => this.sirconInterfaceIdFieldSpecified;
    set
    {
      this.sirconInterfaceIdFieldSpecified = value;
      this.RaisePropertyChanged(nameof (sirconInterfaceIdSpecified));
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
