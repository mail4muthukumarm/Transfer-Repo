// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AffidavitNumbering.Numbering
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.AffidavitNumbering;

[StandardModule]
public sealed class Numbering
{
  public static void AssignAffidavitNumbers(Guid quoteGuid)
  {
    // ISSUE: variable of a compiler-generated type
    Numbering._Closure\u0024__1\u002D1 closure11_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Numbering._Closure\u0024__1\u002D1 closure11_2 = new Numbering._Closure\u0024__1\u002D1(closure11_1)
    {
      \u0024VB\u0024Local_quoteGuid = quoteGuid
    };
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    closure11_2.\u0024VB\u0024Local_dtStates = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID FROM dbo.GetAffidavitStatesOnPolicy(@QG)", new object[2]
    {
      (object) "@QG",
      (object) closure11_2.\u0024VB\u0024Local_quoteGuid
    });
    // ISSUE: reference to a compiler-generated field
    if (closure11_2.\u0024VB\u0024Local_dtStates.Rows.Count <= 0)
      return;
    // ISSUE: reference to a compiler-generated method
    DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure11_2._Lambda\u0024__0));
  }

  private static Numbering.AffidavitNumber GetAutomatedAffidavitNumber(
    dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow dr,
    int quoteID,
    string stateID,
    DbTransaction t)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Numbering._Closure\u0024__3\u002D0 closure30 = new Numbering._Closure\u0024__3\u002D0()
    {
      \u0024VB\u0024Local_dr = dr,
      \u0024VB\u0024Local_quoteID = quoteID,
      \u0024VB\u0024Local_stateID = stateID,
      \u0024VB\u0024Local_an = new Numbering.AffidavitNumber()
    };
    // ISSUE: reference to a compiler-generated field
    closure30.\u0024VB\u0024Local_an.AffidavitIndex = -1;
    Numbering.AffidavitYearSuffixType suffixType;
    // ISSUE: reference to a compiler-generated field
    if (!closure30.\u0024VB\u0024Local_dr.IsCustomSuffixNull())
    {
      suffixType = Numbering.AffidavitYearSuffixType.CustomSuffix;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      if (!closure30.\u0024VB\u0024Local_dr.IsTwoDigitYearNull())
      {
        suffixType = Numbering.AffidavitYearSuffixType.TwoDigitYear;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (closure30.\u0024VB\u0024Local_dr.IsFourDigitYearNull())
          throw new InvalidOperationException("Could not determine the suffixType");
        suffixType = Numbering.AffidavitYearSuffixType.FourDigitYear;
      }
    }
    // ISSUE: reference to a compiler-generated field
    closure30.\u0024VB\u0024Local_resetOnMonth = (object) null;
    // ISSUE: reference to a compiler-generated field
    closure30.\u0024VB\u0024Local_resetOnDay = (object) null;
    // ISSUE: reference to a compiler-generated field
    if (!closure30.\u0024VB\u0024Local_dr.IsResetOnNull())
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      closure30.\u0024VB\u0024Local_resetOnMonth = (object) closure30.\u0024VB\u0024Local_dr.ResetOn.Month;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      closure30.\u0024VB\u0024Local_resetOnDay = (object) closure30.\u0024VB\u0024Local_dr.ResetOn.Day;
    }
    // ISSUE: reference to a compiler-generated field
    closure30.\u0024VB\u0024Local_affidavitYear = -1;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    closure30.\u0024VB\u0024Local_q = new Quote(closure30.\u0024VB\u0024Local_quoteID);
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction(t, new ExecuteHandler((object) closure30, __methodptr(_Lambda\u0024__0)));
    // ISSUE: reference to a compiler-generated field
    if (closure30.\u0024VB\u0024Local_an.AffidavitIndex != -1)
    {
      string customSuffix = string.Empty;
      string prefix = string.Empty;
      // ISSUE: reference to a compiler-generated field
      if (!closure30.\u0024VB\u0024Local_dr.IsPrefixNull())
      {
        // ISSUE: reference to a compiler-generated field
        prefix = closure30.\u0024VB\u0024Local_dr.Prefix;
      }
      // ISSUE: reference to a compiler-generated field
      if (!closure30.\u0024VB\u0024Local_dr.IsCustomSuffixNull())
      {
        // ISSUE: reference to a compiler-generated field
        customSuffix = closure30.\u0024VB\u0024Local_dr.CustomSuffix;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      closure30.\u0024VB\u0024Local_an.AffidavitNumber = Numbering.CreateAffidavitNumber(closure30.\u0024VB\u0024Local_an.AffidavitIndex, closure30.\u0024VB\u0024Local_dr.MinDigits, prefix, suffixType, customSuffix, closure30.\u0024VB\u0024Local_dr.SeparateSuffixWithDash, closure30.\u0024VB\u0024Local_affidavitYear, closure30.\u0024VB\u0024Local_dr.SwapSuffixAndAffNum);
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(closure30.\u0024VB\u0024Local_an.AffidavitNumber, string.Empty, false) == 0)
        throw new InvalidOperationException("The system generated a blank affidavit number.");
    }
    // ISSUE: reference to a compiler-generated field
    return closure30.\u0024VB\u0024Local_an;
  }

  private static void InsertAffidavitNumber(DbTransaction t, DataRow dr)
  {
    // ISSUE: variable of a compiler-generated type
    Numbering._Closure\u0024__4\u002D0 closure40_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Numbering._Closure\u0024__4\u002D0 closure40_2 = new Numbering._Closure\u0024__4\u002D0(closure40_1);
    // ISSUE: reference to a compiler-generated field
    closure40_2.\u0024VB\u0024Local_params = new Dictionary<string, DbParameter>((IDictionary<string, DbParameter>) DefaultDatabase.DiscoverParameters("dbo.spSaveAffidavitNumber"), (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) dr.Table.Columns)
      {
        DbParameter dbParameter = (DbParameter) null;
        // ISSUE: reference to a compiler-generated field
        if (closure40_2.\u0024VB\u0024Local_params.TryGetValue($"@{column.ColumnName}", out dbParameter))
          dbParameter.Value = RuntimeHelpers.GetObjectValue(dr[column.ColumnName]);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction(t, new ExecuteHandler((object) closure40_2, __methodptr(_Lambda\u0024__0)));
  }

  public static string CreateAffidavitNumber(
    int affidavitIndex,
    int minDigits,
    string prefix,
    Numbering.AffidavitYearSuffixType suffixType,
    string customSuffix,
    bool separateWithDash,
    int affidavitYear,
    bool swapSuffixAndAffNum)
  {
    string str1 = affidavitIndex.ToString();
    if (str1.Length < minDigits)
      str1 = str1.PadLeft(minDigits, '0');
    string str2 = string.Empty;
    if (separateWithDash)
      str2 = "-";
    switch (suffixType)
    {
      case Numbering.AffidavitYearSuffixType.CustomSuffix:
        str2 += customSuffix;
        break;
      case Numbering.AffidavitYearSuffixType.TwoDigitYear:
        str2 += Strings.Right(affidavitYear.ToString(), 2);
        break;
      case Numbering.AffidavitYearSuffixType.FourDigitYear:
        str2 += affidavitYear.ToString();
        break;
    }
    string affidavitNumber;
    if (!swapSuffixAndAffNum)
    {
      affidavitNumber = prefix + str1 + str2;
    }
    else
    {
      if (separateWithDash && !str2[str2.Length - 1].ToString().Equals("-"))
        str2 += "-";
      affidavitNumber = prefix + str2 + str1;
    }
    return affidavitNumber;
  }

  public enum AffidavitYearSuffixType
  {
    CustomSuffix = 1,
    TwoDigitYear = 2,
    FourDigitYear = 3,
  }

  private struct AffidavitNumber
  {
    public string AffidavitNumber;
    public int AffidavitIndex;
  }
}
