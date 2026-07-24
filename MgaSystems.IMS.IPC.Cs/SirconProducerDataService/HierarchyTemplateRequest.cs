// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.HierarchyTemplateRequest
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
public class HierarchyTemplateRequest : INotifyPropertyChanged
{
  private ProducerType[] producersField;
  private HierarchyTemplateType hierarchyTemplateField;
  private DistributorType[] distributorHierarchyField;
  private CompanyType[] companiesField;
  private int parentAgreementIdField;
  private bool parentAgreementIdFieldSpecified;
  private string statusField;
  private DateTime beginDateField;
  private bool beginDateFieldSpecified;
  private DateTime endDateField;
  private bool endDateFieldSpecified;
  private string terminationReasonField;
  private string businessUnitField;
  private ExternalSystemIdType externalSystemIdField;

  [XmlArray(Order = 0)]
  [XmlArrayItem("Producer", IsNullable = false)]
  public ProducerType[] Producers
  {
    get => this.producersField;
    set
    {
      this.producersField = value;
      this.RaisePropertyChanged(nameof (Producers));
    }
  }

  [XmlElement(Order = 1)]
  public HierarchyTemplateType HierarchyTemplate
  {
    get => this.hierarchyTemplateField;
    set
    {
      this.hierarchyTemplateField = value;
      this.RaisePropertyChanged(nameof (HierarchyTemplate));
    }
  }

  [XmlArray(Order = 2)]
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

  [XmlArray(Order = 3)]
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

  [XmlElement(Order = 4)]
  public int ParentAgreementId
  {
    get => this.parentAgreementIdField;
    set
    {
      this.parentAgreementIdField = value;
      this.RaisePropertyChanged(nameof (ParentAgreementId));
    }
  }

  [XmlIgnore]
  public bool ParentAgreementIdSpecified
  {
    get => this.parentAgreementIdFieldSpecified;
    set
    {
      this.parentAgreementIdFieldSpecified = value;
      this.RaisePropertyChanged(nameof (ParentAgreementIdSpecified));
    }
  }

  [XmlElement(Order = 5)]
  public string Status
  {
    get => this.statusField;
    set
    {
      this.statusField = value;
      this.RaisePropertyChanged(nameof (Status));
    }
  }

  [XmlElement(DataType = "date", Order = 6)]
  public DateTime BeginDate
  {
    get => this.beginDateField;
    set
    {
      this.beginDateField = value;
      this.RaisePropertyChanged(nameof (BeginDate));
    }
  }

  [XmlIgnore]
  public bool BeginDateSpecified
  {
    get => this.beginDateFieldSpecified;
    set
    {
      this.beginDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (BeginDateSpecified));
    }
  }

  [XmlElement(DataType = "date", Order = 7)]
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

  [XmlElement(Order = 8)]
  public string TerminationReason
  {
    get => this.terminationReasonField;
    set
    {
      this.terminationReasonField = value;
      this.RaisePropertyChanged(nameof (TerminationReason));
    }
  }

  [XmlElement(Order = 9)]
  public string BusinessUnit
  {
    get => this.businessUnitField;
    set
    {
      this.businessUnitField = value;
      this.RaisePropertyChanged(nameof (BusinessUnit));
    }
  }

  [XmlElement(Order = 10)]
  public ExternalSystemIdType ExternalSystemId
  {
    get => this.externalSystemIdField;
    set
    {
      this.externalSystemIdField = value;
      this.RaisePropertyChanged(nameof (ExternalSystemId));
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
