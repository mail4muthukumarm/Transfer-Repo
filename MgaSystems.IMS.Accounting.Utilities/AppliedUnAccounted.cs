// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Utilities.AppliedUnAccounted
// Assembly: MgaSystems.IMS.Accounting.Utilities, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0980F864-5BDB-427E-98EE-09B90661DBB2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Utilities.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Utilities;

[Serializable]
public sealed class AppliedUnAccounted
{
  private Guid _entityguid;
  private Decimal _amount;
  private int _invoicenum;
  private int _chargecode;
  private Guid _companylineguid;
  private AppliedUnAccounted.UnAccountedTransactionType _transtype;
  private int _glcompanyid;
  private string _chargename;
  private int _officeinvoicenum;
  private int _checktransactnum;
  private string _appliedfrom;

  public Guid EntityGuid => this._entityguid;

  public Decimal Amount => this._amount;

  public int InvoiceNumber => this._invoicenum;

  public int ChargeCode => this._chargecode;

  public Guid CompanyLineGuid => this._companylineguid;

  public AppliedUnAccounted.UnAccountedTransactionType TransactionType => this._transtype;

  public int GLCompanyID => this._glcompanyid;

  public string ChargeName => this._chargename;

  public int OfficeInvoiceNumber => this._officeinvoicenum;

  public int CheckTransactionNumber => this._checktransactnum;

  public string AppliedFrom => this._appliedfrom;

  public AppliedUnAccounted(
    Guid EntityGuid,
    Decimal Amount,
    int InvoiceNumber,
    int ChargeCode,
    Guid CompanyLineGuid,
    AppliedUnAccounted.UnAccountedTransactionType TransactionType,
    string ChargeName,
    int OfficeInvoiceNumber,
    int GlCompanyID,
    int CheckTransaction,
    string AppliedFrom)
  {
    this._entityguid = EntityGuid;
    this._glcompanyid = GlCompanyID;
    this._amount = Amount;
    this._invoicenum = InvoiceNumber;
    this._chargecode = ChargeCode;
    this._companylineguid = CompanyLineGuid;
    this._transtype = TransactionType;
    this._chargename = ChargeName;
    this._officeinvoicenum = OfficeInvoiceNumber;
    this._checktransactnum = CheckTransaction;
    this._appliedfrom = AppliedFrom;
  }

  internal AppliedUnAccounted()
  {
  }

  public enum UnAccountedTransactionType
  {
    Receivables,
    Payables,
  }
}
