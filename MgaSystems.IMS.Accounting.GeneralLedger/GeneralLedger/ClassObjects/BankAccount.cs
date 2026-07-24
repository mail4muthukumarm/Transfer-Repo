// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.BankAccount
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

public class BankAccount
{
  private string bankName;
  private string accountNumber;
  private string abaRoutingNumber;
  private bool canIssueChecks;
  private int nextCheckNumber;
  private string abaFractional;
  private string depositSlipSuffix;
  private string bankAccountTypeId;
  private string address1;
  private string address2;
  private string city;
  private string state;
  private string isoCountryCode;
  private string zipCode;
  private string zipPlus;
  private string bankContactName;
  private string bankContactPhone;
  private string bankContactFax;
  private string bankContactEmail;

  public BankAccount()
  {
  }

  public BankAccount(int glAccountId)
  {
  }

  public BankAccount(
    string bankName,
    string accountNumber,
    string abaRoutingNumber,
    bool canIssueChecks,
    int nextCheckNumber,
    string abaFractional,
    string depositSlipSuffix,
    string address1,
    string address2,
    string city,
    string state,
    string isoCountryCode,
    string zipCode,
    string zipPlus,
    string bankContactName,
    string bankContactPhone,
    string bankContactFax,
    string bankContactEmail,
    string bankAccountTypeId)
  {
    this.bankName = bankName;
    this.accountNumber = accountNumber;
    this.abaRoutingNumber = abaRoutingNumber;
    this.canIssueChecks = canIssueChecks;
    this.nextCheckNumber = nextCheckNumber;
    this.abaFractional = abaFractional;
    this.depositSlipSuffix = depositSlipSuffix;
    this.address1 = address1;
    this.address2 = address2;
    this.city = city;
    this.state = state;
    this.isoCountryCode = isoCountryCode;
    this.zipCode = zipCode;
    this.zipPlus = zipPlus;
    this.bankContactName = bankContactName;
    this.bankContactPhone = bankContactPhone;
    this.bankContactFax = bankContactFax;
    this.bankContactEmail = bankContactEmail;
    this.bankAccountTypeId = bankAccountTypeId;
  }

  public GLAccount GlAccount => this.GlAccount;

  public string BankName
  {
    get => this.bankName;
    set => this.bankName = value;
  }

  public string AccountNumber
  {
    get => this.accountNumber;
    set => this.accountNumber = value;
  }

  public string AbaRoutingNumber
  {
    get => this.abaRoutingNumber;
    set => this.abaRoutingNumber = value;
  }

  public bool CanIssueChecks
  {
    get => this.canIssueChecks;
    set => this.canIssueChecks = value;
  }

  public int NextCheckNumber
  {
    get => this.nextCheckNumber;
    set => this.nextCheckNumber = value;
  }

  public string AbaFractional
  {
    get => this.abaFractional;
    set => this.abaFractional = value;
  }

  public string DepositSlipSuffix
  {
    get => this.depositSlipSuffix;
    set => this.depositSlipSuffix = value;
  }

  public string Address1
  {
    get => this.address1;
    set => this.address1 = value;
  }

  public string Address2
  {
    get => this.address2;
    set => this.address2 = value;
  }

  public string City
  {
    get => this.city;
    set => this.city = value;
  }

  public string State
  {
    get => this.state;
    set => this.state = value;
  }

  public string IsoCountryCode
  {
    get => this.isoCountryCode;
    set => this.isoCountryCode = value;
  }

  public string ZipCode
  {
    get => this.zipCode;
    set => this.zipCode = value;
  }

  public string ZipPlus
  {
    get => this.zipPlus;
    set => this.zipPlus = value;
  }

  public string BankContactName
  {
    get => this.bankContactName;
    set => this.bankContactName = value;
  }

  public string BankContactPhone
  {
    get => this.bankContactPhone;
    set => this.bankContactPhone = value;
  }

  public string BankContactFax
  {
    get => this.bankContactFax;
    set => this.bankContactFax = value;
  }

  public string BankContactEmail
  {
    get => this.bankContactEmail;
    set => this.bankContactEmail = value;
  }

  public string BankAccountTypeId
  {
    get => this.bankAccountTypeId;
    set => this.bankAccountTypeId = value;
  }

  private void Save()
  {
  }

  private void Save(int glCompanyId)
  {
  }

  public int Save(
    SqlCommand cmd,
    int glCompanyId,
    string glFullName,
    string glShortName,
    int financialAcctType)
  {
    int num1 = 0;
    int num2 = 0;
    cmd.CommandText = "spFin_GetGLCompanyCashRoot";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    SqlDataReader sqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow);
    if (sqlDataReader.Read())
    {
      num1 = int.Parse(sqlDataReader["RollupTo"].ToString());
      num2 = int.Parse(sqlDataReader["NextAcctNum"].ToString());
    }
    sqlDataReader.Close();
    cmd.CommandText = "dbo.spFin_InsertNewGLBankAccount";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@fullName", (object) glFullName);
    cmd.Parameters.AddWithValue("@shortName", (object) glShortName);
    cmd.Parameters.AddWithValue("@acctNum", (object) num2);
    cmd.Parameters.AddWithValue("@rollUpTo", (object) num1);
    cmd.Parameters.AddWithValue("@bankAcctTypeId", (object) this.BankAccountTypeId);
    cmd.Parameters.AddWithValue("@bankAcctNum", (object) this.AccountNumber);
    cmd.Parameters.AddWithValue("@abaRouting", (object) this.AbaRoutingNumber);
    cmd.Parameters.AddWithValue("@abaFractional", (object) this.AbaFractional);
    cmd.Parameters.AddWithValue("@nextCheckNumber", (object) this.NextCheckNumber);
    cmd.Parameters.AddWithValue("@bankName", (object) this.BankName);
    cmd.Parameters.AddWithValue("@addr1", (object) this.Address1);
    cmd.Parameters.AddWithValue("@addr2", (object) this.Address2);
    cmd.Parameters.AddWithValue("@city", (object) this.City);
    cmd.Parameters.AddWithValue("@state", (object) this.State);
    cmd.Parameters.AddWithValue("@zip", (object) this.ZipCode);
    cmd.Parameters.AddWithValue("@zipext", (object) this.ZipPlus);
    cmd.Parameters.AddWithValue("@contact", (object) this.BankContactName);
    cmd.Parameters.AddWithValue("@fax", (object) this.BankContactFax);
    cmd.Parameters.AddWithValue("@phone", (object) this.BankContactPhone);
    cmd.Parameters.AddWithValue("@email", (object) this.BankContactEmail);
    cmd.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
    cmd.Parameters.AddWithValue("@depositSlipSuffix", (object) this.DepositSlipSuffix);
    cmd.Parameters.AddWithValue("@ISOCountryCode", (object) this.IsoCountryCode);
    cmd.Parameters.AddWithValue("@financialType", (object) financialAcctType);
    cmd.Parameters.AddWithValue("@glCompanyId", (object) glCompanyId);
    return int.Parse(cmd.ExecuteScalar().ToString());
  }
}
