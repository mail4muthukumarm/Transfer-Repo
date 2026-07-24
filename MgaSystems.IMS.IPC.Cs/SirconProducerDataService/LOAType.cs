// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.LOAType
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
public class LOAType : INotifyPropertyChanged
{
  private CodeType typeField;
  private StateCodeType stateField;
  private GeneralStatusType statusField;
  private DateTime statusDateField;
  private DateTime issueDateField;
  private bool issueDateFieldSpecified;
  private DateTime expirationDateField;
  private bool expirationDateFieldSpecified;
  private CodeType inactivationReasonField;
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

  [XmlElement(DataType = "date", Order = 4)]
  public DateTime IssueDate
  {
    get => this.issueDateField;
    set
    {
      this.issueDateField = value;
      this.RaisePropertyChanged(nameof (IssueDate));
    }
  }

  [XmlIgnore]
  public bool IssueDateSpecified
  {
    get => this.issueDateFieldSpecified;
    set
    {
      this.issueDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (IssueDateSpecified));
    }
  }

  [XmlElement(DataType = "date", Order = 5)]
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

  [XmlElement(Order = 6)]
  public CodeType InactivationReason
  {
    get => this.inactivationReasonField;
    set
    {
      this.inactivationReasonField = value;
      this.RaisePropertyChanged(nameof (InactivationReason));
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
