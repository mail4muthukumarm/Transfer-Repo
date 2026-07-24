// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerBusinessUnit
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
public class ProducerBusinessUnit : INotifyPropertyChanged
{
  private string codeField;
  private string nameField;
  private CodeType statusCodeField;
  private DateTime beginDateField;
  private DateTime endDateField;
  private bool endDateFieldSpecified;
  private string businessSegmentCodeField;
  private string servicingLocationCodeField;
  private string distributionChannelCodeField;
  private string costCenterField;
  private bool isDefaultField;

  [XmlElement(Order = 0)]
  public string Code
  {
    get => this.codeField;
    set
    {
      this.codeField = value;
      this.RaisePropertyChanged(nameof (Code));
    }
  }

  [XmlElement(Order = 1)]
  public string Name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (Name));
    }
  }

  [XmlElement(Order = 2)]
  public CodeType StatusCode
  {
    get => this.statusCodeField;
    set
    {
      this.statusCodeField = value;
      this.RaisePropertyChanged(nameof (StatusCode));
    }
  }

  [XmlElement(DataType = "date", Order = 3)]
  public DateTime BeginDate
  {
    get => this.beginDateField;
    set
    {
      this.beginDateField = value;
      this.RaisePropertyChanged(nameof (BeginDate));
    }
  }

  [XmlElement(DataType = "date", Order = 4)]
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

  [XmlElement(Order = 5)]
  public string BusinessSegmentCode
  {
    get => this.businessSegmentCodeField;
    set
    {
      this.businessSegmentCodeField = value;
      this.RaisePropertyChanged(nameof (BusinessSegmentCode));
    }
  }

  [XmlElement(Order = 6)]
  public string ServicingLocationCode
  {
    get => this.servicingLocationCodeField;
    set
    {
      this.servicingLocationCodeField = value;
      this.RaisePropertyChanged(nameof (ServicingLocationCode));
    }
  }

  [XmlElement(Order = 7)]
  public string DistributionChannelCode
  {
    get => this.distributionChannelCodeField;
    set
    {
      this.distributionChannelCodeField = value;
      this.RaisePropertyChanged(nameof (DistributionChannelCode));
    }
  }

  [XmlElement(Order = 8)]
  public string CostCenter
  {
    get => this.costCenterField;
    set
    {
      this.costCenterField = value;
      this.RaisePropertyChanged(nameof (CostCenter));
    }
  }

  [XmlElement(Order = 9)]
  public bool isDefault
  {
    get => this.isDefaultField;
    set
    {
      this.isDefaultField = value;
      this.RaisePropertyChanged(nameof (isDefault));
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
