// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.InterCompanyTransfer
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class InterCompanyTransfer
{
  private int glAccountId;
  private string glAccountShortName;
  private string comments;
  private Decimal amount;
  private int costCenterId;
  private bool _isCredit;
  private string costCenterName;

  public InterCompanyTransfer(
    int glAccountId,
    string glAccountShortName,
    string comments,
    Decimal amount)
  {
    this.glAccountId = glAccountId;
    this.glAccountShortName = glAccountShortName;
    this.comments = comments;
    this.amount = amount;
  }

  public InterCompanyTransfer(
    int glAccountId,
    string glAccountShortName,
    string comments,
    Decimal amount,
    int costCenter,
    string costcentername,
    bool isCredit)
  {
    this.glAccountId = glAccountId;
    this.glAccountShortName = glAccountShortName;
    this.comments = comments;
    this.amount = amount;
    this.costCenterId = costCenter;
    this.costCenterName = costcentername;
    this._isCredit = isCredit;
  }

  public string CostCenterName
  {
    get => this.costCenterName;
    set => this.costCenterName = value;
  }

  public int GlAccountId
  {
    get => this.glAccountId;
    set => this.glAccountId = value;
  }

  public string GlAccountShortName
  {
    get => this.glAccountShortName;
    set => this.glAccountShortName = value;
  }

  public string TransactionType => !this._isCredit ? "Debit" : "Credit";

  public bool SetTransactionType
  {
    set => this._isCredit = value;
    get => this._isCredit;
  }

  public string Comments
  {
    get => this.comments;
    set => this.comments = value;
  }

  public Decimal Amount
  {
    get => this.amount;
    set => this.amount = value;
  }

  public int CostCenterId
  {
    get => this.costCenterId;
    set => this.costCenterId = value;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  internal void Copy(InterCompanyTransfer transferObject)
  {
    this.amount = transferObject.Amount;
    this.comments = transferObject.Comments;
    this.glAccountId = transferObject.GlAccountId;
    this.glAccountShortName = transferObject.GlAccountShortName;
    this.costCenterId = transferObject.costCenterId;
    this.CostCenterName = transferObject.CostCenterName;
    this._isCredit = transferObject._isCredit;
  }
}
