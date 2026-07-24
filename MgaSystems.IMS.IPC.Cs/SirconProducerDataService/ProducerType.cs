// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerType
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
public class ProducerType : INotifyPropertyChanged
{
  private object itemField;
  private bool connectedField;
  private bool connectedFieldSpecified;
  private LicenseType[] licensesField;
  private LOAType[] lOAsField;
  private AddressType mailingAddressField;
  private AddressType businessAddressField;
  private AddressType residentAddressField;
  private AddressType billingAddressField;
  private AddressType[] additionalAddressesField;
  private ProducerTypeResidentState[] residentStatesField;
  private AgreementType[] agreementsField;
  private ProducerTypeAppointmentState[] appointmentStatesField;
  private AppointmentType[] appointmentsField;
  private string residentLicenseNumberField;
  private ProducerTypeDirectDeposit directDepositField;
  private ProducerTypeBackgroundInvestigation[] backgroundInvestigationsField;
  private ProducerTypeProduct[] productsField;
  private ProducerTypeCoveragePolicy[] coveragePoliciesField;
  private CourseRequirementType[] courseRequirementsField;
  private CourseType[] coursesField;
  private EducationCredentialType[] educationCredentialsField;
  private ExternalSystemIdType[] externalSystemIdsField;
  private string roleField;
  private string additionalProducerRoleField;
  private ProducerTypeTelephoneNumbers telephoneNumbersField;
  private BusinessRuleType[] businessRulesField;
  private AssociationType[] associationsField;
  private ProducerTypeRequiredItem[] requiredItemsField;
  private ProducerTypeFinraExams finraExamsField;
  private ProducerTypeSection[] incompleteInformationErrorsField;
  private ProducerTypeSection1[] invalidInformationErrorsField;
  private ProducerBusinessUnit[] businessUnitsField;
  private SecuritiesType securitiesField;
  private AuthorizationOverrideType[] authorizationOverridesField;
  private int orderField;
  private bool orderFieldSpecified;

  [XmlElement("Individual", typeof (ProducerTypeIndividual), Order = 0)]
  [XmlElement("Organization", typeof (ProducerTypeOrganization), Order = 0)]
  public object Item
  {
    get => this.itemField;
    set
    {
      this.itemField = value;
      this.RaisePropertyChanged(nameof (Item));
    }
  }

  [XmlElement(Order = 1)]
  public bool Connected
  {
    get => this.connectedField;
    set
    {
      this.connectedField = value;
      this.RaisePropertyChanged(nameof (Connected));
    }
  }

  [XmlIgnore]
  public bool ConnectedSpecified
  {
    get => this.connectedFieldSpecified;
    set
    {
      this.connectedFieldSpecified = value;
      this.RaisePropertyChanged(nameof (ConnectedSpecified));
    }
  }

  [XmlArray(Order = 2)]
  [XmlArrayItem("License", IsNullable = false)]
  public LicenseType[] Licenses
  {
    get => this.licensesField;
    set
    {
      this.licensesField = value;
      this.RaisePropertyChanged(nameof (Licenses));
    }
  }

  [XmlArray(Order = 3)]
  [XmlArrayItem("LOA", IsNullable = false)]
  public LOAType[] LOAs
  {
    get => this.lOAsField;
    set
    {
      this.lOAsField = value;
      this.RaisePropertyChanged(nameof (LOAs));
    }
  }

  [XmlElement(Order = 4)]
  public AddressType MailingAddress
  {
    get => this.mailingAddressField;
    set
    {
      this.mailingAddressField = value;
      this.RaisePropertyChanged(nameof (MailingAddress));
    }
  }

  [XmlElement(Order = 5)]
  public AddressType BusinessAddress
  {
    get => this.businessAddressField;
    set
    {
      this.businessAddressField = value;
      this.RaisePropertyChanged(nameof (BusinessAddress));
    }
  }

  [XmlElement(Order = 6)]
  public AddressType ResidentAddress
  {
    get => this.residentAddressField;
    set
    {
      this.residentAddressField = value;
      this.RaisePropertyChanged(nameof (ResidentAddress));
    }
  }

  [XmlElement(Order = 7)]
  public AddressType BillingAddress
  {
    get => this.billingAddressField;
    set
    {
      this.billingAddressField = value;
      this.RaisePropertyChanged(nameof (BillingAddress));
    }
  }

  [XmlArray(Order = 8)]
  [XmlArrayItem("Address", IsNullable = false)]
  public AddressType[] AdditionalAddresses
  {
    get => this.additionalAddressesField;
    set
    {
      this.additionalAddressesField = value;
      this.RaisePropertyChanged(nameof (AdditionalAddresses));
    }
  }

  [XmlArray(Order = 9)]
  [XmlArrayItem("ResidentState", IsNullable = false)]
  public ProducerTypeResidentState[] ResidentStates
  {
    get => this.residentStatesField;
    set
    {
      this.residentStatesField = value;
      this.RaisePropertyChanged(nameof (ResidentStates));
    }
  }

  [XmlArray(Order = 10)]
  [XmlArrayItem("Agreement", IsNullable = false)]
  public AgreementType[] Agreements
  {
    get => this.agreementsField;
    set
    {
      this.agreementsField = value;
      this.RaisePropertyChanged(nameof (Agreements));
    }
  }

  [XmlArray(Order = 11)]
  [XmlArrayItem("AppointmentState", IsNullable = false)]
  public ProducerTypeAppointmentState[] AppointmentStates
  {
    get => this.appointmentStatesField;
    set
    {
      this.appointmentStatesField = value;
      this.RaisePropertyChanged(nameof (AppointmentStates));
    }
  }

  [XmlArray(Order = 12)]
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

  [XmlElement(Order = 13)]
  public string ResidentLicenseNumber
  {
    get => this.residentLicenseNumberField;
    set
    {
      this.residentLicenseNumberField = value;
      this.RaisePropertyChanged(nameof (ResidentLicenseNumber));
    }
  }

  [XmlElement(Order = 14)]
  public ProducerTypeDirectDeposit DirectDeposit
  {
    get => this.directDepositField;
    set
    {
      this.directDepositField = value;
      this.RaisePropertyChanged(nameof (DirectDeposit));
    }
  }

  [XmlArray(Order = 15)]
  [XmlArrayItem("BackgroundInvestigation", IsNullable = false)]
  public ProducerTypeBackgroundInvestigation[] BackgroundInvestigations
  {
    get => this.backgroundInvestigationsField;
    set
    {
      this.backgroundInvestigationsField = value;
      this.RaisePropertyChanged(nameof (BackgroundInvestigations));
    }
  }

  [XmlArray(Order = 16 /*0x10*/)]
  [XmlArrayItem("Product", IsNullable = false)]
  public ProducerTypeProduct[] Products
  {
    get => this.productsField;
    set
    {
      this.productsField = value;
      this.RaisePropertyChanged(nameof (Products));
    }
  }

  [XmlArray(Order = 17)]
  [XmlArrayItem("CoveragePolicy", IsNullable = false)]
  public ProducerTypeCoveragePolicy[] CoveragePolicies
  {
    get => this.coveragePoliciesField;
    set
    {
      this.coveragePoliciesField = value;
      this.RaisePropertyChanged(nameof (CoveragePolicies));
    }
  }

  [XmlArray(Order = 18)]
  [XmlArrayItem("CourseRequirement", IsNullable = false)]
  public CourseRequirementType[] CourseRequirements
  {
    get => this.courseRequirementsField;
    set
    {
      this.courseRequirementsField = value;
      this.RaisePropertyChanged(nameof (CourseRequirements));
    }
  }

  [XmlArray(Order = 19)]
  [XmlArrayItem("Course", IsNullable = false)]
  public CourseType[] Courses
  {
    get => this.coursesField;
    set
    {
      this.coursesField = value;
      this.RaisePropertyChanged(nameof (Courses));
    }
  }

  [XmlArray(Order = 20)]
  [XmlArrayItem("EducationCredential", IsNullable = false)]
  public EducationCredentialType[] EducationCredentials
  {
    get => this.educationCredentialsField;
    set
    {
      this.educationCredentialsField = value;
      this.RaisePropertyChanged(nameof (EducationCredentials));
    }
  }

  [XmlArray(Order = 21)]
  [XmlArrayItem("ExternalSystemId", IsNullable = false)]
  public ExternalSystemIdType[] ExternalSystemIds
  {
    get => this.externalSystemIdsField;
    set
    {
      this.externalSystemIdsField = value;
      this.RaisePropertyChanged(nameof (ExternalSystemIds));
    }
  }

  [XmlElement(Order = 22)]
  public string Role
  {
    get => this.roleField;
    set
    {
      this.roleField = value;
      this.RaisePropertyChanged(nameof (Role));
    }
  }

  [XmlElement(Order = 23)]
  public string AdditionalProducerRole
  {
    get => this.additionalProducerRoleField;
    set
    {
      this.additionalProducerRoleField = value;
      this.RaisePropertyChanged(nameof (AdditionalProducerRole));
    }
  }

  [XmlElement(Order = 24)]
  public ProducerTypeTelephoneNumbers TelephoneNumbers
  {
    get => this.telephoneNumbersField;
    set
    {
      this.telephoneNumbersField = value;
      this.RaisePropertyChanged(nameof (TelephoneNumbers));
    }
  }

  [XmlArray(Order = 25)]
  [XmlArrayItem("BusinessRule", IsNullable = false)]
  public BusinessRuleType[] BusinessRules
  {
    get => this.businessRulesField;
    set
    {
      this.businessRulesField = value;
      this.RaisePropertyChanged(nameof (BusinessRules));
    }
  }

  [XmlArray(Order = 26)]
  [XmlArrayItem("Association", IsNullable = false)]
  public AssociationType[] Associations
  {
    get => this.associationsField;
    set
    {
      this.associationsField = value;
      this.RaisePropertyChanged(nameof (Associations));
    }
  }

  [XmlArray(Order = 27)]
  [XmlArrayItem("RequiredItem", IsNullable = false)]
  public ProducerTypeRequiredItem[] RequiredItems
  {
    get => this.requiredItemsField;
    set
    {
      this.requiredItemsField = value;
      this.RaisePropertyChanged(nameof (RequiredItems));
    }
  }

  [XmlElement(Order = 28)]
  public ProducerTypeFinraExams FinraExams
  {
    get => this.finraExamsField;
    set
    {
      this.finraExamsField = value;
      this.RaisePropertyChanged(nameof (FinraExams));
    }
  }

  [XmlArray(Order = 29)]
  [XmlArrayItem("Section", IsNullable = false)]
  public ProducerTypeSection[] IncompleteInformationErrors
  {
    get => this.incompleteInformationErrorsField;
    set
    {
      this.incompleteInformationErrorsField = value;
      this.RaisePropertyChanged(nameof (IncompleteInformationErrors));
    }
  }

  [XmlArray(Order = 30)]
  [XmlArrayItem("Section", IsNullable = false)]
  public ProducerTypeSection1[] InvalidInformationErrors
  {
    get => this.invalidInformationErrorsField;
    set
    {
      this.invalidInformationErrorsField = value;
      this.RaisePropertyChanged(nameof (InvalidInformationErrors));
    }
  }

  [XmlArray(Order = 31 /*0x1F*/)]
  [XmlArrayItem("BusinessUnit", IsNullable = false)]
  public ProducerBusinessUnit[] BusinessUnits
  {
    get => this.businessUnitsField;
    set
    {
      this.businessUnitsField = value;
      this.RaisePropertyChanged(nameof (BusinessUnits));
    }
  }

  [XmlElement(Order = 32 /*0x20*/)]
  public SecuritiesType Securities
  {
    get => this.securitiesField;
    set
    {
      this.securitiesField = value;
      this.RaisePropertyChanged(nameof (Securities));
    }
  }

  [XmlArray(Order = 33)]
  [XmlArrayItem("AuthorizationOverride", IsNullable = false)]
  public AuthorizationOverrideType[] AuthorizationOverrides
  {
    get => this.authorizationOverridesField;
    set
    {
      this.authorizationOverridesField = value;
      this.RaisePropertyChanged(nameof (AuthorizationOverrides));
    }
  }

  [XmlAttribute]
  public int order
  {
    get => this.orderField;
    set
    {
      this.orderField = value;
      this.RaisePropertyChanged(nameof (order));
    }
  }

  [XmlIgnore]
  public bool orderSpecified
  {
    get => this.orderFieldSpecified;
    set
    {
      this.orderFieldSpecified = value;
      this.RaisePropertyChanged(nameof (orderSpecified));
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
