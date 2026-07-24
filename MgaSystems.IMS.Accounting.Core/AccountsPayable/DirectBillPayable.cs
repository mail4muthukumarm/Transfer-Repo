// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillPayable
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.DirectBill.BaseClasses;
using System;
using System.Data;
using System.Globalization;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillPayable : DirectBillObject
{
  private DataRow[] childRows;
  private DirectBillPayablesDetailCollection details;

  public DirectBillPayable(
    string policyNumber,
    string insuredName,
    int controlNumber,
    DateTime effectiveDate,
    DateTime expirationDate,
    dsGetAccountsPayable.AcctsPayableRow[] childRows)
    : base(policyNumber, insuredName, controlNumber, effectiveDate, expirationDate)
  {
    this.childRows = (DataRow[]) childRows;
  }

  public DirectBillPayable(
    string policyNumber,
    string insuredName,
    int controlNumber,
    DateTime effectiveDate,
    DateTime expirationDate,
    DataRow[] childRows)
    : base(policyNumber, insuredName, controlNumber, effectiveDate, expirationDate)
  {
    this.childRows = childRows;
  }

  public DirectBillPayable(
    string policyNumber,
    string insuredName,
    int controlNumber,
    DateTime effectiveDate,
    DateTime expirationDate,
    DataRow[] childRows,
    string currencyCode)
    : base(policyNumber, insuredName, controlNumber, effectiveDate, expirationDate, currencyCode)
  {
    this.childRows = childRows;
  }

  public DirectBillPayablesDetailCollection Details
  {
    get
    {
      if (this.details == null)
        this.details = new DirectBillPayablesDetailCollection();
      return this.details;
    }
  }

  public Decimal GetGrossPayableBalanceSum()
  {
    Decimal payableBalanceSum = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      payableBalanceSum += Decimal.Parse(this.childRows[index]["gross payable"].ToString(), NumberStyles.Any);
    return payableBalanceSum;
  }

  public Decimal GetAmountPaidToDateSum()
  {
    Decimal amountPaidToDateSum = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      amountPaidToDateSum += Decimal.Parse(this.childRows[index]["amtptd"].ToString(), NumberStyles.Any);
    return amountPaidToDateSum;
  }

  public Decimal GetNetPayableSum()
  {
    Decimal netPayableSum = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      netPayableSum += Decimal.Parse(this.childRows[index]["net payable"].ToString(), NumberStyles.Any);
    return netPayableSum;
  }

  public Decimal GetAmountReceivedSum()
  {
    Decimal amountReceivedSum = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      amountReceivedSum += Decimal.Parse(this.childRows[index]["amt rcvd"].ToString(), NumberStyles.Any);
    return amountReceivedSum;
  }

  public Decimal GetExchangeBalanceSum()
  {
    Decimal exchangeBalanceSum = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      exchangeBalanceSum += Decimal.Parse(this.childRows[index]["exch balance"].ToString(), NumberStyles.Any);
    return exchangeBalanceSum;
  }

  public Decimal GetUnAccountedBalanceSum()
  {
    Decimal accountedBalanceSum = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      accountedBalanceSum += Decimal.Parse(this.childRows[index]["unacct balance"].ToString(), NumberStyles.Any);
    return accountedBalanceSum;
  }

  public Decimal GetProportionalAmountDueSum()
  {
    Decimal proportionalAmountDueSum = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      proportionalAmountDueSum += Decimal.Parse(this.childRows[index]["propamt"].ToString(), NumberStyles.Any);
    return proportionalAmountDueSum;
  }

  public void UpdateAllChildApAmounts(bool isPayingAll)
  {
    for (int index = 0; index < this.childRows.Length; ++index)
    {
      int invoiceNumber = int.Parse(this.childRows[index]["invoicenum"].ToString());
      int chargeCode = int.Parse(this.childRows[index]["chargecode"].ToString());
      Guid companyLineGuid = new Guid(this.childRows[index]["companylineguid"].ToString());
      Decimal num = Decimal.Parse(this.childRows[index]["net payable"].ToString(), NumberStyles.Any);
      int detailIndex = this.Details.GetDetailIndex(invoiceNumber, chargeCode, companyLineGuid);
      Decimal apApplied = !isPayingAll ? 0M : num;
      if (detailIndex != -1)
        this.Details[detailIndex].ApApplied = apApplied;
      else
        this.Details.Add(new DirectBillPayableDetail(invoiceNumber, chargeCode, companyLineGuid, apApplied));
    }
  }

  public void UpdateChildApAmounts(Decimal newAmount)
  {
    for (int index = 0; index < this.childRows.Length; ++index)
    {
      int invoiceNumber = int.Parse(this.childRows[index]["invoicenum"].ToString());
      int chargeCode = int.Parse(this.childRows[index]["chargecode"].ToString());
      Guid companyLineGuid = new Guid(this.childRows[index]["companylineguid"].ToString());
      Decimal num = Decimal.Parse(this.childRows[index]["net payable"].ToString(), NumberStyles.Any);
      int detailIndex = this.Details.GetDetailIndex(invoiceNumber, chargeCode, companyLineGuid);
      if (num > 0M)
      {
        if (num < newAmount)
        {
          if (detailIndex == -1)
            this.Details.Add(new DirectBillPayableDetail(invoiceNumber, chargeCode, companyLineGuid, newAmount));
          else
            this.Details[detailIndex].ApApplied = num;
          newAmount -= num;
        }
        else
        {
          if (detailIndex == -1)
            this.Details.Add(new DirectBillPayableDetail(invoiceNumber, chargeCode, companyLineGuid, newAmount));
          else
            this.Details[detailIndex].ApApplied = newAmount;
          newAmount = 0M;
        }
        if (newAmount == 0M)
          break;
      }
    }
  }
}
