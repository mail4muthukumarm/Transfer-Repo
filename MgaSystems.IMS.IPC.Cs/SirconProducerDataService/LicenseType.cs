// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.LicenseType
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
public class LicenseType : INotifyPropertyChanged
{
  private CodeType typeField;
  private StateCodeType stateField;
  private GeneralStatusType statusField;
  private DateTime statusDateField;
  private bool copyReceivedField;
  private DateTime effectiveDateField;
  private bool effectiveDateFieldSpecified;
  private DateTime expirationDateField;
  private bool expirationDateFieldSpecified;
  private string numberField;
  private CodeType inactivationReasonField;
  private DateTime suspensionStartDateField;
  private bool suspensionStartDateFieldSpecified;
  private DateTime suspensionEndDateField;
  private bool suspensionEndDateFieldSpecified;
  private int idField;
  private bool idFieldSpecified;

  [XmlElement(Order = 0)]
  public CodeType Type
  {
    get => this.typeField;
    set
    {
      this.typeField = value;
      this.RaisePropertyChanged(nameof (Type));
    }
  }

  [XmlElement(Order = 1)]
  public StateCodeType State
  {
    get => this.stateField;
    set
    {
      this.stateField = value;
      this.RaisePropertyChanged(nameof (State));
    }
  }

  [XmlElement(Order = 2)]
  public GeneralStatusType Status
  {
    get => this.statusField;
    set
    {
      this.statusField = value;
      this.RaisePropertyChanged(nameof (Status));
    }
  }

  [XmlElement(DataType = "date", Order = 3)]
  public DateTime StatusDate
  {
    get => this.statusDateField;
    set
    {
      this.statusDateField = value;
      this.RaisePropertyChanged(nameof (StatusDate));
    }
  }

  [XmlElement(Order = 4)]
  public bool CopyReceived
  {
    get => this.copyReceivedField;
    set
    {
      this.copyReceivedField = value;
      this.RaisePropertyChanged(nameof (CopyReceived));
    }
  }

  [XmlElement(DataType = "date", Order = 5)]
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

  [XmlElement(DataType = "date", Order = 6)]
  public DateTime ExpirationDate
  {
    get => this.expirationDateField;
    set
    {
      this.expirationDateField = value;
      this.RaisePropertyChanged(nameof (ExpirationDate));
    }
  }

  [XmlIgnore]
  public bool ExpirationDateSpecified
  {
    get => this.expirationDateFieldSpecified;
    set
    {
      this.expirationDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (ExpirationDateSpecified));
    }
  }

  [XmlElement(Order = 7)]
  public string Number
  {
    get => this.numberField;
    set
    {
      this.numberField = value;
      this.RaisePropertyChanged(nameof (Number));
    }
  }

  [XmlElement(Order = 8)]
  public CodeType InactivationReason
  {
    get => this.inactivationReasonField;
    set
    {
      this.inactivationReasonField = value;
      this.RaisePropertyChanged(nameof (InactivationReason));
    }
  }

  [XmlElement(DataType = "date", Order = 9)]
  public DateTime SuspensionStartDate
  {
    get => this.suspensionStartDateField;
    set
    {
      this.suspensionStartDateField = value;
      this.RaisePropertyChanged(nameof (SuspensionStartDate));
    }
  }

  [XmlIgnore]
  public bool SuspensionStartDateSpecified
  {
    get => this.suspensionStartDateFieldSpecified;
    set
    {
      this.suspensionStartDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (SuspensionStartDateSpecified));
    }
  }

  [XmlElement(DataType = "date", Order = 10)]
  public DateTime SuspensionEndDate
  {
    get => this.suspensionEndDateField;
    set
    {
      this.suspensionEndDateField = value;
      this.RaisePropertyChanged(nameof (SuspensionEndDate));
    }
  }

  [XmlIgnore]
  public bool SuspensionEndDateSpecified
  {
    get => this.suspensionEndDateFieldSpecified;
    set
    {
      this.suspensionEndDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (SuspensionEndDateSpecified));
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
