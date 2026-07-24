// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.DirectBillReceivable
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.DirectBill.BaseClasses;
using System;
using System.Data;
using System.Globalization;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

internal class DirectBillReceivable : DirectBillObject
{
  private string currentStatus;
  private DataRow[] childRows;
  private DirectBillReceivableDetailCollection details;

  internal DirectBillReceivable(
    string policyNumber,
    string insuredName,
    int controlNumber,
    string currentStatus,
    DateTime effectiveDate,
    DateTime expirationDate,
    DataRow[] childRows)
    : base(policyNumber, insuredName, controlNumber, effectiveDate, expirationDate)
  {
    this.currentStatus = currentStatus;
    this.childRows = childRows;
  }

  internal DirectBillReceivable(
    string policyNumber,
    string insuredName,
    int controlNumber,
    string currentStatus,
    DateTime effectiveDate,
    DateTime expirationDate,
    dsGetAccountsReceivable.AccountsReceivableRow[] childRows)
    : base(policyNumber, insuredName, controlNumber, effectiveDate, expirationDate)
  {
    this.currentStatus = currentStatus;
    this.childRows = (DataRow[]) childRows;
  }

  internal string CurrentStatus => this.currentStatus;

  internal DirectBillReceivableDetailCollection Details
  {
    get
    {
      if (this.details == null)
        this.details = new DirectBillReceivableDetailCollection();
      return this.details;
    }
  }

  internal Decimal GetAmtBilled()
  {
    Decimal amtBilled = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      amtBilled += Decimal.Parse(this.childRows[index]["amtbilled"].ToString(), NumberStyles.Any);
    return amtBilled;
  }

  internal Decimal GetNetDue()
  {
    Decimal netDue = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      netDue += Decimal.Parse(this.childRows[index]["NetDue"].ToString(), NumberStyles.Any);
    return netDue;
  }

  internal Decimal GetAmtPTC()
  {
    Decimal amtPtc = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      amtPtc += Decimal.Parse(this.childRows[index]["AmtPTC"].ToString(), NumberStyles.Any);
    return amtPtc;
  }

  internal Decimal GetAmtPTD()
  {
    Decimal amtPtd = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      amtPtd += Decimal.Parse(this.childRows[index]["AmtPTD"].ToString(), NumberStyles.Any);
    return amtPtd;
  }

  internal Decimal GetAmtRTD()
  {
    Decimal amtRtd = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      amtRtd += Decimal.Parse(this.childRows[index]["AmtRTD"].ToString(), NumberStyles.Any);
    return amtRtd;
  }

  internal Decimal GetExchangeBalance()
  {
    Decimal exchangeBalance = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      exchangeBalance += Decimal.Parse(this.childRows[index]["ExchBalance"].ToString(), NumberStyles.Any);
    return exchangeBalance;
  }

  internal Decimal GetUnAccountedBalance()
  {
    Decimal accountedBalance = 0M;
    for (int index = 0; index < this.childRows.Length; ++index)
      accountedBalance += Decimal.Parse(this.childRows[index]["UnacctBalance"].ToString(), NumberStyles.Any);
    return accountedBalance;
  }

  internal void UpdateAllChildArAmounts(bool isPayAll)
  {
    Guid companyLineGuid = Guid.Empty;
    Decimal num = 0.0M;
    for (int index = 0; index < this.childRows.Length; ++index)
    {
      int invoiceNumber = int.Parse(this.childRows[index]["invoicenum"].ToString());
      int chargeCode = int.Parse(this.childRows[index]["chargecode"].ToString());
      companyLineGuid = new Guid(this.childRows[index]["companylineguid"].ToString());
      Decimal arApplied = Decimal.Parse(this.childRows[index]["NetDue"].ToString(), NumberStyles.Any);
      int detailIndex = this.Details.GetDetailIndex(invoiceNumber, chargeCode, companyLineGuid);
      num = !isPayAll ? 0.0M : arApplied;
      if (detailIndex != -1)
        this.Details[detailIndex].ArApplied = num;
      else
        this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, arApplied, 0M, 0M));
    }
  }

  internal void UpdateChildArAmounts(Decimal newAmount)
  {
    for (int index = 0; index < this.childRows.Length; ++index)
    {
      int invoiceNumber = int.Parse(this.childRows[index]["invoicenum"].ToString());
      int chargeCode = int.Parse(this.childRows[index]["chargecode"].ToString());
      Guid companyLineGuid = new Guid(this.childRows[index]["companylineguid"].ToString());
      Decimal arApplied = Decimal.Parse(this.childRows[index]["NetDue"].ToString(), NumberStyles.Any);
      int detailIndex = this.Details.GetDetailIndex(invoiceNumber, chargeCode, companyLineGuid);
      if (arApplied > 0M)
      {
        if (arApplied < newAmount)
        {
          if (detailIndex == -1)
            this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, arApplied, 0M, 0M));
          else
            this.Details[detailIndex].ArApplied = arApplied;
          newAmount -= arApplied;
        }
        else
        {
          if (detailIndex == -1)
            this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, newAmount, 0M, 0M));
          else
            this.Details[detailIndex].ArApplied = newAmount;
          newAmount = 0M;
        }
        if (newAmount == 0M)
          break;
      }
    }
  }

  internal void UpdateChildExchangeAmounts(Decimal newAmount)
  {
    for (int index = 0; index < this.childRows.Length; ++index)
    {
      int invoiceNumber = int.Parse(this.childRows[index]["invoicenum"].ToString());
      int chargeCode = int.Parse(this.childRows[index]["chargecode"].ToString());
      Guid companyLineGuid = new Guid(this.childRows[index]["companylineguid"].ToString());
      Decimal exchApplied = Decimal.Parse(this.childRows[index]["ExchBalance"].ToString(), NumberStyles.Any);
      int detailIndex = this.Details.GetDetailIndex(invoiceNumber, chargeCode, companyLineGuid);
      if (exchApplied < 0M)
      {
        if (exchApplied > newAmount)
        {
          if (detailIndex == -1)
            this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, 0M, exchApplied, 0M));
          else
            this.Details[detailIndex].ExchApplied = exchApplied;
          newAmount -= Decimal.Parse(this.childRows[index]["NetDue"].ToString(), NumberStyles.Any);
          newAmount *= -1M;
        }
        else
        {
          if (detailIndex == -1)
            this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, 0M, newAmount, 0M));
          else
            this.Details[detailIndex].ExchApplied = newAmount;
          newAmount = 0M;
        }
        if (newAmount == 0M)
          break;
      }
      else
      {
        if (detailIndex == -1)
          this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, 0M, newAmount, 0M));
        else
          this.Details[detailIndex].ExchApplied = newAmount;
        newAmount = 0M;
        if (newAmount == 0M)
          break;
      }
    }
  }

  internal void UpdateChildUnAccountedAmounts(Decimal newAmount)
  {
    for (int index = 0; index < this.childRows.Length; ++index)
    {
      int invoiceNumber = int.Parse(this.childRows[index]["invoicenum"].ToString());
      int chargeCode = int.Parse(this.childRows[index]["chargecode"].ToString());
      Guid companyLineGuid = new Guid(this.childRows[index]["companylineguid"].ToString());
      Decimal unAcctApplied = Decimal.Parse(this.childRows[index]["UnacctBalance"].ToString(), NumberStyles.Any);
      int detailIndex = this.Details.GetDetailIndex(invoiceNumber, chargeCode, companyLineGuid);
      if (Decimal.Parse(this.childRows[index]["UnacctBalance"].ToString(), NumberStyles.Any) < 0M)
      {
        if (unAcctApplied > newAmount)
        {
          if (detailIndex == -1)
            this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, 0M, 0M, unAcctApplied));
          else
            this.Details[detailIndex].UnAcctApplied = unAcctApplied;
          newAmount -= Decimal.Parse(this.childRows[index]["NetDue"].ToString(), NumberStyles.Any);
          newAmount *= -1M;
        }
        else
        {
          if (detailIndex == -1)
            this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, 0M, 0M, newAmount));
          else
            this.Details[detailIndex].UnAcctApplied = newAmount;
          newAmount = 0M;
        }
        if (newAmount == 0M)
          break;
      }
      else
      {
        if (detailIndex == -1)
          this.Details.Add(new DirectBillReceivableDetail(invoiceNumber, chargeCode, companyLineGuid, 0M, 0M, newAmount));
        else
          this.Details[detailIndex].UnAcctApplied = newAmount;
        newAmount = 0M;
        if (newAmount == 0M)
          break;
      }
    }
  }
}
