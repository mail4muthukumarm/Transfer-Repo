// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.CompanyType
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
public class CompanyType : INotifyPropertyChanged
{
  private string naicIdField;
  private string shortNameField;
  private string nameField;
  private CodeType statusCodeField;
  private DateTime startDateField;
  private bool startDateFieldSpecified;
  private DateTime endDateField;
  private bool endDateFieldSpecified;
  private CodeType vestingPeriodCodeField;
  private CodeType paymentStatusCodeField;
  private int idField;
  private bool idFieldSpecified;

  public string NaicId
  {
    get => this.naicIdField;
    set
    {
      this.naicIdField = value;
      this.RaisePropertyChanged(nameof (NaicId));
    }
  }

  public string ShortName
  {
    get => this.shortNameField;
    set
    {
      this.shortNameField = value;
      this.RaisePropertyChanged(nameof (ShortName));
    }
  }

  public string Name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (Name));
    }
  }

  public CodeType StatusCode
  {
    get => this.statusCodeField;
    set
    {
      this.statusCodeField = value;
      this.RaisePropertyChanged(nameof (StatusCode));
    }
  }

  [XmlElement(DataType = "date")]
  public DateTime StartDate
  {
    get => this.startDateField;
    set
    {
      this.startDateField = value;
      this.RaisePropertyChanged(nameof (StartDate));
    }
  }

  [XmlIgnore]
  public bool StartDateSpecified
  {
    get => this.startDateFieldSpecified;
    set
    {
      this.startDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StartDateSpecified));
    }
  }

  [XmlElement(DataType = "date")]
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

  public CodeType VestingPeriodCode
  {
    get => this.vestingPeriodCodeField;
    set
    {
      this.vestingPeriodCodeField = value;
      this.RaisePropertyChanged(nameof (VestingPeriodCode));
    }
  }

  public CodeType PaymentStatusCode
  {
    get => this.paymentStatusCodeField;
    set
    {
      this.paymentStatusCodeField = value;
      this.RaisePropertyChanged(nameof (PaymentStatusCode));
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
