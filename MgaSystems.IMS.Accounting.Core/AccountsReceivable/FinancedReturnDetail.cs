// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.FinancedReturnDetail
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

[Serializable]
public class FinancedReturnDetail : IEditableObject
{
  private int _invoiceNumber;
  private int _chargeCode;
  private Guid _companyLineGuid;
  private int _glAccountId;
  private Decimal _amount;
  private bool _selected;
  private string _policyNumber;
  private Guid _entityGuid;
  private FinancedReturnDetail _financeReturnObject;
  private int _controlNumber;

  public FinancedReturnDetail(
    int InvoiceNumber,
    int officeInvoiceNumber,
    int ChargeCode,
    Guid CompanyLineGuid,
    int GlAccountId,
    Decimal Amount,
    string policyNumber,
    int controlNumber,
    Guid entityGuid)
  {
    this._invoiceNumber = InvoiceNumber;
    this.OfficeInvoiceNum = officeInvoiceNumber;
    this._chargeCode = ChargeCode;
    this._companyLineGuid = CompanyLineGuid;
    this._glAccountId = GlAccountId;
    this._amount = Amount;
    this._policyNumber = policyNumber;
    this._controlNumber = controlNumber;
    this._entityGuid = entityGuid;
  }

  private FinancedReturnDetail()
  {
  }

  private FinancedReturnDetail InternalCopy
  {
    get
    {
      if (this._financeReturnObject == null)
        this._financeReturnObject = new FinancedReturnDetail();
      return this._financeReturnObject;
    }
  }

  public int ControlNumber => this._controlNumber;

  public int InvoiceNumber => this._invoiceNumber;

  public int ChargeCode => this._chargeCode;

  public Guid CompanyLineGuid => this._companyLineGuid;

  public int GlAccountId => this._glAccountId;

  public Decimal Amount => this._amount;

  public bool Selected
  {
    get => this._selected;
    set => this._selected = value;
  }

  public string PolicyNumber => this._policyNumber;

  public Guid EntityGuid => this._entityGuid;

  public int OfficeInvoiceNum { get; }

  public void BeginEdit()
  {
    this._financeReturnObject = new FinancedReturnDetail(this.InvoiceNumber, this.OfficeInvoiceNum, this.ChargeCode, this.CompanyLineGuid, this.GlAccountId, this.Amount, this.PolicyNumber, this.ControlNumber, this.EntityGuid);
  }

  public void CancelEdit()
  {
    if (this._financeReturnObject == null)
      return;
    this._amount = this._financeReturnObject.Amount;
    this._chargeCode = this._financeReturnObject.ChargeCode;
    this._companyLineGuid = this._financeReturnObject.CompanyLineGuid;
    this._glAccountId = this._financeReturnObject.GlAccountId;
    this._invoiceNumber = this._financeReturnObject.InvoiceNumber;
    this._policyNumber = this._financeReturnObject.PolicyNumber;
    this._controlNumber = this._financeReturnObject.ControlNumber;
    this._entityGuid = this._financeReturnObject.EntityGuid;
  }

  public void EndEdit()
  {
    this._financeReturnObject = new FinancedReturnDetail(this.InvoiceNumber, this.OfficeInvoiceNum, this.ChargeCode, this.CompanyLineGuid, this.GlAccountId, this.Amount, this.PolicyNumber, this.ControlNumber, this.EntityGuid);
  }
}
