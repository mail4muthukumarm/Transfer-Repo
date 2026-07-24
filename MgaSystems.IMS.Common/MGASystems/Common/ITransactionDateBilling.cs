// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ITransactionDateBilling
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;

#nullable disable
namespace MGASystems.Common;

public interface ITransactionDateBilling
{
  DataRow InitializeTransactionDate(int quoteOptionID);

  bool MonthFollowing(DataRow row);

  DateTime GetTransactionDate(
    UltraGridRow row,
    int quoteOptionID,
    ref int paymentTerm,
    ref DateTime transDate);

  bool HasAlreadyProcessTerms { get; set; }

  bool HasDownPaymentInstallment { get; set; }

  DataRow TransactionDataRow { get; set; }

  bool UseMonthIncrement { get; set; }

  bool HasTransactionSetup { get; set; }
}
