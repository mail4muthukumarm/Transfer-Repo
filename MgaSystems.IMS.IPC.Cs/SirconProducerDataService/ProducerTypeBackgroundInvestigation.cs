// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerTypeBackgroundInvestigation
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
public class ProducerTypeBackgroundInvestigation : INotifyPropertyChanged
{
  private string resultField;
  private string reviewResultField;
  private DateTime requestDateField;
  private DateTime resultDateField;
  private bool resultDateFieldSpecified;
  private string resultAddressField;
  private string referenceIdField;
  private string costCenterField;
  private DateTime statusDateField;
  private bool statusDateFieldSpecified;
  private ProducerTypeBackgroundInvestigationFirm firmField;
  private string[] typesField;
  private int sirconTransactionIdField;
  private bool sirconTransactionIdFieldSpecified;
  private string commentField;
  private ProducerTypeBackgroundInvestigationIncident[] incidentField;
  private int idField;
  private bool idFieldSpecified;

  [XmlElement(Order = 0)]
  public string Result
  {
    get => this.resultField;
    set
    {
      this.resultField = value;
      this.RaisePropertyChanged(nameof (Result));
    }
  }

  [XmlElement(Order = 1)]
  public string ReviewResult
  {
    get => this.reviewResultField;
    set
    {
      this.reviewResultField = value;
      this.RaisePropertyChanged(nameof (ReviewResult));
    }
  }

  [XmlElement(DataType = "date", Order = 2)]
  public DateTime RequestDate
  {
    get => this.requestDateField;
    set
    {
      this.requestDateField = value;
      this.RaisePropertyChanged(nameof (RequestDate));
    }
  }

  [XmlElement(DataType = "date", Order = 3)]
  public DateTime ResultDate
  {
    get => this.resultDateField;
    set
    {
      this.resultDateField = value;
      this.RaisePropertyChanged(nameof (ResultDate));
    }
  }

  [XmlIgnore]
  public bool ResultDateSpecified
  {
    get => this.resultDateFieldSpecified;
    set
    {
      this.resultDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (ResultDateSpecified));
    }
  }

  [XmlElement(Order = 4)]
  public string ResultAddress
  {
    get => this.resultAddressField;
    set
    {
      this.resultAddressField = value;
      this.RaisePropertyChanged(nameof (ResultAddress));
    }
  }

  [XmlElement(Order = 5)]
  public string ReferenceId
  {
    get => this.referenceIdField;
    set
    {
      this.referenceIdField = value;
      this.RaisePropertyChanged(nameof (ReferenceId));
    }
  }

  [XmlElement(Order = 6)]
  public string CostCenter
  {
    get => this.costCenterField;
    set
    {
      this.costCenterField = value;
      this.RaisePropertyChanged(nameof (CostCenter));
    }
  }

  [XmlElement(DataType = "date", Order = 7)]
  public DateTime StatusDate
  {
    get => this.statusDateField;
    set
    {
      this.statusDateField = value;
      this.RaisePropertyChanged(nameof (StatusDate));
    }
  }

  [XmlIgnore]
  public bool StatusDateSpecified
  {
    get => this.statusDateFieldSpecified;
    set
    {
      this.statusDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StatusDateSpecified));
    }
  }

  [XmlElement(Order = 8)]
  public ProducerTypeBackgroundInvestigationFirm Firm
  {
    get => this.firmField;
    set
    {
      this.firmField = value;
      this.RaisePropertyChanged(nameof (Firm));
    }
  }

  [XmlArray(Order = 9)]
  [XmlArrayItem("Type", IsNullable = false)]
  public string[] Types
  {
    get => this.typesField;
    set
    {
      this.typesField = value;
      this.RaisePropertyChanged(nameof (Types));
    }
  }

  [XmlElement(Order = 10)]
  public int SirconTransactionId
  {
    get => this.sirconTransactionIdField;
    set
    {
      this.sirconTransactionIdField = value;
      this.RaisePropertyChanged(nameof (SirconTransactionId));
    }
  }

  [XmlIgnore]
  public bool SirconTransactionIdSpecified
  {
    get => this.sirconTransactionIdFieldSpecified;
    set
    {
      this.sirconTransactionIdFieldSpecified = value;
      this.RaisePropertyChanged(nameof (SirconTransactionIdSpecified));
    }
  }

  [XmlElement(Order = 11)]
  public string Comment
  {
    get => this.commentField;
    set
    {
      this.commentField = value;
      this.RaisePropertyChanged(nameof (Comment));
    }
  }

  [XmlElement("Incident", Order = 12)]
  public ProducerTypeBackgroundInvestigationIncident[] Incident
  {
    get => this.incidentField;
    set
    {
      this.incidentField = value;
      this.RaisePropertyChanged(nameof (Incident));
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
