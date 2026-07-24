// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Interfaces.IExcelAutomation
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Interfaces;

public interface IExcelAutomation
{
  void AutomateInvoiceSearch(
    Guid entityGuid,
    int glCompanyId,
    int invoiceNumber,
    string policyNumber,
    string insuredName,
    DateTime effectiveDate,
    string userDefinedAccountNumber,
    Decimal appliedAmount,
    bool isPayable,
    string entityName,
    Utility.PayablesSearchType payableSearchType,
    Utility.ReceivablesSearchType receivableSearchType,
    formTransactionSearch.SearchTypes searchType);

  void AutomateInvoiceSearch(
    Guid entityGuid,
    int glCompanyId,
    string entityName,
    Utility.PayablesSearchType payableSearchType,
    Utility.ReceivablesSearchType receivableSearchType,
    formTransactionSearch.SearchTypes searchType);

  void ApplyFormSettings();

  void CheckAppliedErrors();
}
