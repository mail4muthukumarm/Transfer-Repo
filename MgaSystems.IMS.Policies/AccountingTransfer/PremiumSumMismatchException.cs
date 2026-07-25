// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AccountingTransfer.PremiumSumMismatchException
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.Data;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Policies.AccountingTransfer;

public sealed class PremiumSumMismatchException : Exception
{
  private int _quoteID;
  private Decimal _accountingTotal;
  private Decimal _underwritingTotal;

  public PremiumSumMismatchException(int quoteID, SqlTransaction trans)
  {
    if (trans == null)
      throw new ArgumentNullException(nameof (trans));
    this._quoteID = quoteID;
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT dbo.GetAmountBilled(@quoteID, @U), dbo.GetAmountBilled(@quoteID, @A)", new object[6]
    {
      (object) "@quoteID",
      (object) this._quoteID,
      (object) "@A",
      (object) "A",
      (object) "@U",
      (object) "U"
    });
    this._accountingTotal = row.Field<Decimal>(0);
    this._underwritingTotal = row.Field<Decimal>(1);
  }

  public override string Message
  {
    get
    {
      return $"The premiums transferred to accounting ({Strings.FormatCurrency((object) this._accountingTotal)}) do not match underwriting totals ({Strings.FormatCurrency((object) this._underwritingTotal)}).";
    }
  }
}
