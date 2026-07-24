// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.StateRegistrationType
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
public class StateRegistrationType : INotifyPropertyChanged
{
  private StateCodeType stateCodeField;
  private CodeType categoryTypeCodeField;
  private DateTime approvalDateField;
  private bool approvalDateFieldSpecified;
  private CodeType finraStatusCodeField;
  private DateTime statusDateField;
  private OrganizationType firmField;

  public StateCodeType StateCode
  {
    get => this.stateCodeField;
    set
    {
      this.stateCodeField = value;
      this.RaisePropertyChanged(nameof (StateCode));
    }
  }

  public CodeType CategoryTypeCode
  {
    get => this.categoryTypeCodeField;
    set
    {
      this.categoryTypeCodeField = value;
      this.RaisePropertyChanged(nameof (CategoryTypeCode));
    }
  }

  [XmlElement(DataType = "date")]
  public DateTime ApprovalDate
  {
    get => this.approvalDateField;
    set
    {
      this.approvalDateField = value;
      this.RaisePropertyChanged(nameof (ApprovalDate));
    }
  }

  [XmlIgnore]
  public bool ApprovalDateSpecified
  {
    get => this.approvalDateFieldSpecified;
    set
    {
      this.approvalDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (ApprovalDateSpecified));
    }
  }

  public CodeType FinraStatusCode
  {
    get => this.finraStatusCodeField;
    set
    {
      this.finraStatusCodeField = value;
      this.RaisePropertyChanged(nameof (FinraStatusCode));
    }
  }

  [XmlElement(DataType = "date")]
  public DateTime StatusDate
  {
    get => this.statusDateField;
    set
    {
      this.statusDateField = value;
      this.RaisePropertyChanged(nameof (StatusDate));
    }
  }

  public OrganizationType Firm
  {
    get => this.firmField;
    set
    {
      this.firmField = value;
      this.RaisePropertyChanged(nameof (Firm));
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
