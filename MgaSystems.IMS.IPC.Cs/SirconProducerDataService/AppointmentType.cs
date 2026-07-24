// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.AppointmentType
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
public class AppointmentType : INotifyPropertyChanged
{
  private StateCodeType stateField;
  private AppointmentTypeType typeField;
  private DateTime effectiveDateField;
  private bool effectiveDateFieldSpecified;
  private GeneralStatusType statusField;
  private bool statusFieldSpecified;
  private AppointmentStatusType transactionStatusField;
  private bool transactionStatusFieldSpecified;
  private CompanyType companyField;
  private string licenseTypeCodeField;
  private string licenseCategoryField;
  private string stateProducerNumberField;
  private string costCenterField;
  private AppointmentMethodType methodField;
  private bool methodFieldSpecified;
  private string residentCountyCodeField;
  private string[] countiesField;
  private string transactionMessageField;
  private string terminationReasonField;
  private string sharingProducerNameField;
  private bool isPendingField;
  private bool isPendingFieldSpecified;
  private int idField;
  private bool idFieldSpecified;
  private int sirconIntrfcIdField;
  private bool sirconIntrfcIdFieldSpecified;

  public StateCodeType State
  {
    get => this.stateField;
    set
    {
      this.stateField = value;
      this.RaisePropertyChanged(nameof (State));
    }
  }

  public AppointmentTypeType Type
  {
    get => this.typeField;
    set
    {
      this.typeField = value;
      this.RaisePropertyChanged(nameof (Type));
    }
  }

  [XmlElement(DataType = "date")]
  public DateTime EffectiveDate
  {
    get => this.effectiveDateField;
    set
    {
      this.effectiveDateField = value;
      this.RaisePropertyChanged(nameof (EffectiveDate));
    }
  }

  [XmlIgnore]
  public bool EffectiveDateSpecified
  {
    get => this.effectiveDateFieldSpecified;
    set
    {
      this.effectiveDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (EffectiveDateSpecified));
    }
  }

  public GeneralStatusType Status
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

  public AppointmentStatusType TransactionStatus
  {
    get => this.transactionStatusField;
    set
    {
      this.transactionStatusField = value;
      this.RaisePropertyChanged(nameof (TransactionStatus));
    }
  }

  [XmlIgnore]
  public bool TransactionStatusSpecified
  {
    get => this.transactionStatusFieldSpecified;
    set
    {
      this.transactionStatusFieldSpecified = value;
      this.RaisePropertyChanged(nameof (TransactionStatusSpecified));
    }
  }

  public CompanyType Company
  {
    get => this.companyField;
    set
    {
      this.companyField = value;
      this.RaisePropertyChanged(nameof (Company));
    }
  }

  public string LicenseTypeCode
  {
    get => this.licenseTypeCodeField;
    set
    {
      this.licenseTypeCodeField = value;
      this.RaisePropertyChanged(nameof (LicenseTypeCode));
    }
  }

  public string LicenseCategory
  {
    get => this.licenseCategoryField;
    set
    {
      this.licenseCategoryField = value;
      this.RaisePropertyChanged(nameof (LicenseCategory));
    }
  }

  public string StateProducerNumber
  {
    get => this.stateProducerNumberField;
    set
    {
      this.stateProducerNumberField = value;
      this.RaisePropertyChanged(nameof (StateProducerNumber));
    }
  }

  public string CostCenter
  {
    get => this.costCenterField;
    set
    {
      this.costCenterField = value;
      this.RaisePropertyChanged(nameof (CostCenter));
    }
  }

  public AppointmentMethodType Method
  {
    get => this.methodField;
    set
    {
      this.methodField = value;
      this.RaisePropertyChanged(nameof (Method));
    }
  }

  [XmlIgnore]
  public bool MethodSpecified
  {
    get => this.methodFieldSpecified;
    set
    {
      this.methodFieldSpecified = value;
      this.RaisePropertyChanged(nameof (MethodSpecified));
    }
  }

  public string ResidentCountyCode
  {
    get => this.residentCountyCodeField;
    set
    {
      this.residentCountyCodeField = value;
      this.RaisePropertyChanged(nameof (ResidentCountyCode));
    }
  }

  [XmlArrayItem("CountyCode", IsNullable = false)]
  public string[] Counties
  {
    get => this.countiesField;
    set
    {
      this.countiesField = value;
      this.RaisePropertyChanged(nameof (Counties));
    }
  }

  public string TransactionMessage
  {
    get => this.transactionMessageField;
    set
    {
      this.transactionMessageField = value;
      this.RaisePropertyChanged(nameof (TransactionMessage));
    }
  }

  public string TerminationReason
  {
    get => this.terminationReasonField;
    set
    {
      this.terminationReasonField = value;
      this.RaisePropertyChanged(nameof (TerminationReason));
    }
  }

  public string SharingProducerName
  {
    get => this.sharingProducerNameField;
    set
    {
      this.sharingProducerNameField = value;
      this.RaisePropertyChanged(nameof (SharingProducerName));
    }
  }

  public bool IsPending
  {
    get => this.isPendingField;
    set
    {
      this.isPendingField = value;
      this.RaisePropertyChanged(nameof (IsPending));
    }
  }

  [XmlIgnore]
  public bool IsPendingSpecified
  {
    get => this.isPendingFieldSpecified;
    set
    {
      this.isPendingFieldSpecified = value;
      this.RaisePropertyChanged(nameof (IsPendingSpecified));
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
  public int sirconIntrfcId
  {
    get => this.sirconIntrfcIdField;
    set
    {
      this.sirconIntrfcIdField = value;
      this.RaisePropertyChanged(nameof (sirconIntrfcId));
    }
  }

  [XmlIgnore]
  public bool sirconIntrfcIdSpecified
  {
    get => this.sirconIntrfcIdFieldSpecified;
    set
    {
      this.sirconIntrfcIdFieldSpecified = value;
      this.RaisePropertyChanged(nameof (sirconIntrfcIdSpecified));
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
