// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.PotentialAppointingTransactionType
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
public class PotentialAppointingTransactionType : INotifyPropertyChanged
{
  private AppointmentType appointmentField;
  private string[] availableCostCentersField;
  private PotentialAppointingTransactionTypeAvailableMethod[] availableMethodsField;
  private CodeType[] availableLicenseCategoryCodesField;
  private PotentialAppointingTransactionTypeAvailability availabilityField;
  private bool requireStateProducerNumberField;
  private bool requireLicenseCategoryCodeField;
  private bool requireLicenseTypeCodeField;
  private bool requireResidentCountyCodeField;
  private bool allowAppointmentCountiesField;
  private PotentialAppointingTransactionTypeMessage[] messagesField;

  public AppointmentType Appointment
  {
    get => this.appointmentField;
    set
    {
      this.appointmentField = value;
      this.RaisePropertyChanged(nameof (Appointment));
    }
  }

  [XmlArrayItem("CostCenter", IsNullable = false)]
  public string[] AvailableCostCenters
  {
    get => this.availableCostCentersField;
    set
    {
      this.availableCostCentersField = value;
      this.RaisePropertyChanged(nameof (AvailableCostCenters));
    }
  }

  [XmlArrayItem("AvailableMethod", IsNullable = false)]
  public PotentialAppointingTransactionTypeAvailableMethod[] AvailableMethods
  {
    get => this.availableMethodsField;
    set
    {
      this.availableMethodsField = value;
      this.RaisePropertyChanged(nameof (AvailableMethods));
    }
  }

  [XmlArrayItem("LicenseCategoryCode", IsNullable = false)]
  public CodeType[] AvailableLicenseCategoryCodes
  {
    get => this.availableLicenseCategoryCodesField;
    set
    {
      this.availableLicenseCategoryCodesField = value;
      this.RaisePropertyChanged(nameof (AvailableLicenseCategoryCodes));
    }
  }

  public PotentialAppointingTransactionTypeAvailability Availability
  {
    get => this.availabilityField;
    set
    {
      this.availabilityField = value;
      this.RaisePropertyChanged(nameof (Availability));
    }
  }

  public bool RequireStateProducerNumber
  {
    get => this.requireStateProducerNumberField;
    set
    {
      this.requireStateProducerNumberField = value;
      this.RaisePropertyChanged(nameof (RequireStateProducerNumber));
    }
  }

  public bool RequireLicenseCategoryCode
  {
    get => this.requireLicenseCategoryCodeField;
    set
    {
      this.requireLicenseCategoryCodeField = value;
      this.RaisePropertyChanged(nameof (RequireLicenseCategoryCode));
    }
  }

  public bool RequireLicenseTypeCode
  {
    get => this.requireLicenseTypeCodeField;
    set
    {
      this.requireLicenseTypeCodeField = value;
      this.RaisePropertyChanged(nameof (RequireLicenseTypeCode));
    }
  }

  public bool RequireResidentCountyCode
  {
    get => this.requireResidentCountyCodeField;
    set
    {
      this.requireResidentCountyCodeField = value;
      this.RaisePropertyChanged(nameof (RequireResidentCountyCode));
    }
  }

  public bool AllowAppointmentCounties
  {
    get => this.allowAppointmentCountiesField;
    set
    {
      this.allowAppointmentCountiesField = value;
      this.RaisePropertyChanged(nameof (AllowAppointmentCounties));
    }
  }

  [XmlArrayItem("Message", IsNullable = false)]
  public PotentialAppointingTransactionTypeMessage[] Messages
  {
    get => this.messagesField;
    set
    {
      this.messagesField = value;
      this.RaisePropertyChanged(nameof (Messages));
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
