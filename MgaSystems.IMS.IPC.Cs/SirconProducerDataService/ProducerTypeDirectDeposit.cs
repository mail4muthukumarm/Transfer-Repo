// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerTypeDirectDeposit
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
public class ProducerTypeDirectDeposit : INotifyPropertyChanged
{
  private string bankNameField;
  private string routingNumberField;
  private string accountNumberField;
  private ProducerTypeDirectDepositAccountType accountTypeField;
  private bool accountTypeFieldSpecified;
  private ProducerTypeDirectDepositInstitutionType institutionTypeField;
  private bool institutionTypeFieldSpecified;
  private string bankCityField;
  private string bankStateField;
  private string accountOwnerNameField;
  private string emailField;

  public string BankName
  {
    get => this.bankNameField;
    set
    {
      this.bankNameField = value;
      this.RaisePropertyChanged(nameof (BankName));
    }
  }

  public string RoutingNumber
  {
    get => this.routingNumberField;
    set
    {
      this.routingNumberField = value;
      this.RaisePropertyChanged(nameof (RoutingNumber));
    }
  }

  public string AccountNumber
  {
    get => this.accountNumberField;
    set
    {
      this.accountNumberField = value;
      this.RaisePropertyChanged(nameof (AccountNumber));
    }
  }

  public ProducerTypeDirectDepositAccountType AccountType
  {
    get => this.accountTypeField;
    set
    {
      this.accountTypeField = value;
      this.RaisePropertyChanged(nameof (AccountType));
    }
  }

  [XmlIgnore]
  public bool AccountTypeSpecified
  {
    get => this.accountTypeFieldSpecified;
    set
    {
      this.accountTypeFieldSpecified = value;
      this.RaisePropertyChanged(nameof (AccountTypeSpecified));
    }
  }

  public ProducerTypeDirectDepositInstitutionType InstitutionType
  {
    get => this.institutionTypeField;
    set
    {
      this.institutionTypeField = value;
      this.RaisePropertyChanged(nameof (InstitutionType));
    }
  }

  [XmlIgnore]
  public bool InstitutionTypeSpecified
  {
    get => this.institutionTypeFieldSpecified;
    set
    {
      this.institutionTypeFieldSpecified = value;
      this.RaisePropertyChanged(nameof (InstitutionTypeSpecified));
    }
  }

  public string BankCity
  {
    get => this.bankCityField;
    set
    {
      this.bankCityField = value;
      this.RaisePropertyChanged(nameof (BankCity));
    }
  }

  public string BankState
  {
    get => this.bankStateField;
    set
    {
      this.bankStateField = value;
      this.RaisePropertyChanged(nameof (BankState));
    }
  }

  public string AccountOwnerName
  {
    get => this.accountOwnerNameField;
    set
    {
      this.accountOwnerNameField = value;
      this.RaisePropertyChanged(nameof (AccountOwnerName));
    }
  }

  public string Email
  {
    get => this.emailField;
    set
    {
      this.emailField = value;
      this.RaisePropertyChanged(nameof (Email));
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
