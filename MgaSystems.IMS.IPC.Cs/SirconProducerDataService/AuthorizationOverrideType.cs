// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.AuthorizationOverrideType
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
public class AuthorizationOverrideType : INotifyPropertyChanged
{
  private AuthorizationOverrideResultType overrideResultField;
  private DateTime effectiveDateField;
  private DateTime expirationDateField;
  private bool expirationDateFieldSpecified;
  private StateCodeType stateCodeField;
  private bool stateCodeFieldSpecified;
  private string productField;
  private string eventField;
  private string naicIdField;
  private string reasonField;

  public AuthorizationOverrideResultType OverrideResult
  {
    get => this.overrideResultField;
    set
    {
      this.overrideResultField = value;
      this.RaisePropertyChanged(nameof (OverrideResult));
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

  [XmlElement(DataType = "date")]
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

  public StateCodeType StateCode
  {
    get => this.stateCodeField;
    set
    {
      this.stateCodeField = value;
      this.RaisePropertyChanged(nameof (StateCode));
    }
  }

  [XmlIgnore]
  public bool StateCodeSpecified
  {
    get => this.stateCodeFieldSpecified;
    set
    {
      this.stateCodeFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StateCodeSpecified));
    }
  }

  public string Product
  {
    get => this.productField;
    set
    {
      this.productField = value;
      this.RaisePropertyChanged(nameof (Product));
    }
  }

  public string Event
  {
    get => this.eventField;
    set
    {
      this.eventField = value;
      this.RaisePropertyChanged(nameof (Event));
    }
  }

  public string NaicId
  {
    get => this.naicIdField;
    set
    {
      this.naicIdField = value;
      this.RaisePropertyChanged(nameof (NaicId));
    }
  }

  public string Reason
  {
    get => this.reasonField;
    set
    {
      this.reasonField = value;
      this.RaisePropertyChanged(nameof (Reason));
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
