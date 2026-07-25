// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Invoices.Invoices
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.IMS.Policies.AccountingTransfer;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Policies.Invoices;

public sealed class Invoices : ArrayList
{
  public List<int> DistinctOfficeIDs
  {
    get
    {
      List<int> distinctOfficeIds = new List<int>();
      try
      {
        foreach (AccountingTransferInvoice accountingTransferInvoice in (ArrayList) this)
        {
          if (!distinctOfficeIds.Contains(accountingTransferInvoice.OfficeID))
            distinctOfficeIds.Add(accountingTransferInvoice.OfficeID);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return distinctOfficeIds;
    }
  }

  public void AddInvoice(AccountingTransferInvoice i) => this.Add((object) i);

  public AccountingTransferInvoice FindByInvoiceNumber(int invoiceNumber)
  {
    AccountingTransferInvoice byInvoiceNumber;
    try
    {
      foreach (AccountingTransferInvoice accountingTransferInvoice in (ArrayList) this)
      {
        if (accountingTransferInvoice.InvoiceNumber == invoiceNumber)
        {
          byInvoiceNumber = accountingTransferInvoice;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    byInvoiceNumber = (AccountingTransferInvoice) null;
label_8:
    return byInvoiceNumber;
  }
}
