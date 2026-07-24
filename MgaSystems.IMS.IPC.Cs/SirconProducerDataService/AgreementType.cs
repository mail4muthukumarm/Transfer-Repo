// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.AgreementType
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
public class AgreementType : INotifyPropertyChanged
{
  private CodeType typeCodeField;
  private CodeType statusCodeField;
  private DateTime startDateField;
  private DateTime endDateField;
  private bool endDateFieldSpecified;
  private HierarchyTemplateType hierarchyTemplateField;
  private CompanyType[] companiesField;
  private ExternalSystemIdType externalSystemIdField;
  private ParentAgreementType[] agreementUplineField;
  private BusinessUnit businessUnitField;
  private string levelIdField;
  private string managerLevelIdField;
  private CodeType paymentFrequencyCodeField;
  private CodeType businessViaDtccCodeField;
  private CodeType advanceCommissionCodeField;
  private Decimal advancePercentageField;
  private bool advancePercentageFieldSpecified;
  private Decimal advanceMaxAmountField;
  private bool advanceMaxAmountFieldSpecified;
  private CodeType advanceTransactionStatusCodeField;
  private string statementDistributionIdField;
  private int idField;
  private bool idFieldSpecified;

  [XmlElement(Order = 0)]
  public CodeType TypeCode
  {
    get => this.typeCodeField;
    set
    {
      this.typeCodeField = value;
      this.RaisePropertyChanged(nameof (TypeCode));
    }
  }

  [XmlElement(Order = 1)]
  public CodeType StatusCode
  {
    get => this.statusCodeField;
    set
    {
      this.statusCodeField = value;
      this.RaisePropertyChanged(nameof (StatusCode));
    }
  }

  [XmlElement(DataType = "date", Order = 2)]
  public DateTime StartDate
  {
    get => this.startDateField;
    set
    {
      this.startDateField = value;
      this.RaisePropertyChanged(nameof (StartDate));
    }
  }

  [XmlElement(DataType = "date", Order = 3)]
  public DateTime EndDate
  {
    get => this.endDateField;
    set
    {
      this.endDateField = value;
      this.RaisePropertyChanged(nameof (EndDate));
    }
  }

  [XmlIgnore]
  public bool EndDateSpecified
  {
    get => this.endDateFieldSpecified;
    set
    {
      this.endDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (EndDateSpecified));
    }
  }

  [XmlElement(Order = 4)]
  public HierarchyTemplateType HierarchyTemplate
  {
    get => this.hierarchyTemplateField;
    set
    {
      this.hierarchyTemplateField = value;
      this.RaisePropertyChanged(nameof (HierarchyTemplate));
    }
  }

  [XmlArray(Order = 5)]
  [XmlArrayItem("Company", IsNullable = false)]
  public CompanyType[] Companies
  {
    get => this.companiesField;
    set
    {
      this.companiesField = value;
      this.RaisePropertyChanged(nameof (Companies));
    }
  }

  [XmlElement(Order = 6)]
  public ExternalSystemIdType ExternalSystemId
  {
    get => this.externalSystemIdField;
    set
    {
      this.externalSystemIdField = value;
      this.RaisePropertyChanged(nameof (ExternalSystemId));
    }
  }

  [XmlArray(Order = 7)]
  [XmlArrayItem("ParentAgreement", IsNullable = false)]
  public ParentAgreementType[] AgreementUpline
  {
    get => this.agreementUplineField;
    set
    {
      this.agreementUplineField = value;
      this.RaisePropertyChanged(nameof (AgreementUpline));
    }
  }

  [XmlElement(Order = 8)]
  public BusinessUnit BusinessUnit
  {
    get => this.businessUnitField;
    set
    {
      this.businessUnitField = value;
      this.RaisePropertyChanged(nameof (BusinessUnit));
    }
  }

  [XmlElement(Order = 9)]
  public string LevelId
  {
    get => this.levelIdField;
    set
    {
      this.levelIdField = value;
      this.RaisePropertyChanged(nameof (LevelId));
    }
  }

  [XmlElement(Order = 10)]
  public string ManagerLevelId
  {
    get => this.managerLevelIdField;
    set
    {
      this.managerLevelIdField = value;
      this.RaisePropertyChanged(nameof (ManagerLevelId));
    }
  }

  [XmlElement(Order = 11)]
  public CodeType PaymentFrequencyCode
  {
    get => this.paymentFrequencyCodeField;
    set
    {
      this.paymentFrequencyCodeField = value;
      this.RaisePropertyChanged(nameof (PaymentFrequencyCode));
    }
  }

  [XmlElement(Order = 12)]
  public CodeType BusinessViaDtccCode
  {
    get => this.businessViaDtccCodeField;
    set
    {
      this.businessViaDtccCodeField = value;
      this.RaisePropertyChanged(nameof (BusinessViaDtccCode));
    }
  }

  [XmlElement(Order = 13)]
  public CodeType AdvanceCommissionCode
  {
    get => this.advanceCommissionCodeField;
    set
    {
      this.advanceCommissionCodeField = value;
      this.RaisePropertyChanged(nameof (AdvanceCommissionCode));
    }
  }

  [XmlElement(Order = 14)]
  public Decimal AdvancePercentage
  {
    get => this.advancePercentageField;
    set
    {
      this.advancePercentageField = value;
      this.RaisePropertyChanged(nameof (AdvancePercentage));
    }
  }

  [XmlIgnore]
  public bool AdvancePercentageSpecified
  {
    get => this.advancePercentageFieldSpecified;
    set
    {
      this.advancePercentageFieldSpecified = value;
      this.RaisePropertyChanged(nameof (AdvancePercentageSpecified));
    }
  }

  [XmlElement(Order = 15)]
  public Decimal AdvanceMaxAmount
  {
    get => this.advanceMaxAmountField;
    set
    {
      this.advanceMaxAmountField = value;
      this.RaisePropertyChanged(nameof (AdvanceMaxAmount));
    }
  }

  [XmlIgnore]
  public bool AdvanceMaxAmountSpecified
  {
    get => this.advanceMaxAmountFieldSpecified;
    set
    {
      this.advanceMaxAmountFieldSpecified = value;
      this.RaisePropertyChanged(nameof (AdvanceMaxAmountSpecified));
    }
  }

  [XmlElement(Order = 16 /*0x10*/)]
  public CodeType AdvanceTransactionStatusCode
  {
    get => this.advanceTransactionStatusCodeField;
    set
    {
      this.advanceTransactionStatusCodeField = value;
      this.RaisePropertyChanged(nameof (AdvanceTransactionStatusCode));
    }
  }

  [XmlElement(Order = 17)]
  public string StatementDistributionId
  {
    get => this.statementDistributionIdField;
    set
    {
      this.statementDistributionIdField = value;
      this.RaisePropertyChanged(nameof (StatementDistributionId));
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

  public event PropertyChangedEventHandler PropertyChanged;

  protected void RaisePropertyChanged(string propertyName)
  {
    PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    if (propertyChanged == null)
      return;
    propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
  }
}
