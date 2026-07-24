// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Utilities.AppliedExchange
// Assembly: MgaSystems.IMS.Accounting.Utilities, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0980F864-5BDB-427E-98EE-09B90661DBB2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Utilities.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Utilities;

[Serializable]
public sealed class AppliedExchange
{
  private int _exchangeinvoicenum;
  private int _exchchargecode;
  private Guid _exchcompanylineguid;
  private int _exchglacct;
  private int _invoicenumber;
  private int _chargecode;
  private Guid _companylineguid;
  private int _glacctid;
  private Decimal _amount;

  public AppliedExchange(
    int ExchInvoiceNumber,
    int ExchGLAccountId,
    int ExchChargeCode,
    Guid ExchCompanyLineGuid,
    int InvoiceNumber,
    int GLAccountId,
    Guid CompanyLineGuid,
    int ChargeCode,
    Decimal Amount)
  {
    this._exchangeinvoicenum = ExchInvoiceNumber;
    this._exchchargecode = ExchChargeCode;
    this._exchcompanylineguid = ExchCompanyLineGuid;
    this._exchglacct = ExchGLAccountId;
    this._invoicenumber = InvoiceNumber;
    this._chargecode = ChargeCode;
    this._companylineguid = CompanyLineGuid;
    this._glacctid = GLAccountId;
    this._amount = Amount;
  }

  internal int ExchangeInvoiceNumber => this._exchangeinvoicenum;

  internal int ExchangeGLAccountId => this._exchglacct;

  internal int ExchangeChargeCode => this._exchchargecode;

  internal Guid ExchangeCompanyLineGuid => this._exchcompanylineguid;

  internal int InvoiceNumber => this._invoicenumber;

  internal int ChargeCode => this._chargecode;

  internal Guid CompanyLineGuid => this._companylineguid;

  internal int GLAccountId => this._glacctid;

  internal Decimal Amount => this._amount;
}
