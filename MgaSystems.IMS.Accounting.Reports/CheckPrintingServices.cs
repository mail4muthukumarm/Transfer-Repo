// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.CheckPrintingServices
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class CheckPrintingServices
{
  public static string CreateE13BString(
    string CheckNumber,
    string RoutingNumber,
    string AccountNumber,
    string Amount)
  {
    string str = "C";
    int num = 0;
    while (checked (num + Strings.Len(CheckNumber)) < 6)
    {
      str += "0";
      checked { ++num; }
    }
    return $"{$"{str}{CheckNumber}C  A"}{RoutingNumber}A  {AccountNumber}C    B{Amount.Substring(0, checked (Strings.InStr(Amount, ".") - 1))}B{Amount.Substring(checked (Strings.InStr(Amount, ".") + 1), 2)}";
  }

  public static string CreateE13BCheckNumber(string CheckNumber)
  {
    string str = "C";
    int num = 0;
    while (checked (num + Strings.Len(CheckNumber)) < 6)
    {
      str += "0";
      checked { ++num; }
    }
    return $"{str}{CheckNumber}C";
  }

  public static string CreateE13BRoutingNumber(string RoutingNumber) => $"A{RoutingNumber}A";

  public static string CreateE13BAccountNumber(string AccountNumber) => AccountNumber + "C";

  public static string CreateE13BAmount(string Amount)
  {
    return $"B{Amount.Substring(0, checked (Strings.InStr(Amount, ".") - 1))}B{Amount.Substring(Strings.InStr(Amount, "."), 2)}";
  }

  public static string ConvertNumericToEnglish(Decimal N)
  {
    string english;
    if (Decimal.Compare(N, 0M) == 0)
    {
      english = "Zero Dollars and 00/100 Cents";
    }
    else
    {
      string str1 = Decimal.Compare(N, 0M) >= 0 ? string.Empty : "Negative ";
      Decimal d1 = Math.Abs(Decimal.Subtract(N, Conversion.Fix(N)));
      if (Decimal.Compare(N, 0M) < 0 || Decimal.Compare(d1, 0M) != 0)
        N = Math.Abs(Conversion.Fix(N));
      bool flag = Decimal.Compare(N, 1M) >= 0;
      if (Decimal.Compare(N, 1000000000000M) >= 0)
      {
        str1 = $"{str1}{CheckPrintingServices.EnglishDigitGroup(new Decimal(Convert.ToInt32(Decimal.Divide(N, 1000000000000M))))} Trillion";
        N = Decimal.Subtract(N, Decimal.Multiply(Conversion.Int(Decimal.Divide(N, 1000000000000M)), 1000000000000M));
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000000000M) >= 0)
      {
        str1 = $"{str1}{CheckPrintingServices.EnglishDigitGroup(new Decimal(Convert.ToInt32(Decimal.Divide(N, 1000000000M))))} Billion";
        N = Decimal.Subtract(N, Decimal.Multiply(Conversion.Int(Decimal.Divide(N, 1000000000M)), 1000000000M));
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000000M) >= 0)
      {
        str1 = $"{str1}{CheckPrintingServices.EnglishDigitGroup(new Decimal(Convert.ToInt32(N) / 1000000))} Million";
        N = Decimal.Remainder(N, 1000000M);
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000M) >= 0)
      {
        str1 = $"{str1}{CheckPrintingServices.EnglishDigitGroup(new Decimal(Convert.ToInt32(N) / 1000))} Thousand";
        N = Decimal.Remainder(N, 1000M);
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1M) >= 0)
        str1 += CheckPrintingServices.EnglishDigitGroup(N);
      if (Decimal.Compare(N, 1M) > 0)
        str1 = Decimal.Compare(N, 2M) >= 0 ? (Decimal.Compare(N, 1M) != 0 ? str1 + " Dollars" : str1 + " Dollar") : str1 + " Dollar";
      string str2;
      if (Decimal.Compare(d1, 0M) == 0)
        str2 = str1.Contains("Dollar") ? str1 + " and 00/100 Cents" : (Decimal.Compare(N, 1M) != 0 ? str1 + " Dollars and 00/100 Cents" : str1 + " Dollar and 00/100 Cents");
      else if (Decimal.Compare(Conversion.Int(Decimal.Multiply(d1, 100M)), Decimal.Multiply(d1, 100M)) == 0)
      {
        str2 = $"{(!flag ? str1 + "Zero Dollars And " : (!str1.Contains("Dollars") ? (Decimal.Compare(N, 1M) != 0 ? str1 + " Dollars and " : str1 + " Dollar and ") : str1 + " and "))}{Strings.Format((object) Convert.ToInt64(Decimal.Multiply(d1, 100M)), "00")}/100 Cents";
      }
      else
      {
        if (flag)
          str1 += " and ";
        str2 = $"{str1}{Strings.Format((object) Convert.ToInt64(Decimal.Multiply(d1, 10000M)), "00")}/10000";
      }
      if (Operators.CompareString(str2.ToUpper(), "ONE", false) == 0)
        str2 += " Dollar and 00/100 Cents";
      english = str2;
    }
    return english;
  }

  public static string EnglishDigitGroup(Decimal N)
  {
    string str1 = string.Empty;
    bool flag = false;
    switch (Convert.ToInt32(N) / 100)
    {
      case 0:
        str1 = string.Empty;
        flag = false;
        break;
      case 1:
        str1 = "One Hundred";
        flag = true;
        break;
      case 2:
        str1 = "Two Hundred";
        flag = true;
        break;
      case 3:
        str1 = "Three Hundred";
        flag = true;
        break;
      case 4:
        str1 = "Four Hundred";
        flag = true;
        break;
      case 5:
        str1 = "Five Hundred";
        flag = true;
        break;
      case 6:
        str1 = "Six Hundred";
        flag = true;
        break;
      case 7:
        str1 = "Seven Hundred";
        flag = true;
        break;
      case 8:
        str1 = "Eight Hundred";
        flag = true;
        break;
      case 9:
        str1 = "Nine Hundred";
        flag = true;
        break;
    }
    if (flag)
      N = Decimal.Remainder(N, 100M);
    string str2;
    if (Decimal.Compare(N, 0M) > 0)
    {
      if (flag)
        str1 += " ";
      switch (Convert.ToInt32(N) / 10)
      {
        case 0:
        case 1:
          flag = false;
          break;
        case 2:
          str1 += "Twenty";
          flag = true;
          break;
        case 3:
          str1 += "Thirty";
          flag = true;
          break;
        case 4:
          str1 += "Forty";
          flag = true;
          break;
        case 5:
          str1 += "Fifty";
          flag = true;
          break;
        case 6:
          str1 += "Sixty";
          flag = true;
          break;
        case 7:
          str1 += "Seventy";
          flag = true;
          break;
        case 8:
          str1 += "Eighty";
          flag = true;
          break;
        case 9:
          str1 += "Ninety";
          flag = true;
          break;
      }
      if (flag)
        N = Decimal.Remainder(N, 10M);
      if (Decimal.Compare(N, 0M) > 0)
      {
        if (flag)
          str1 += "-";
        Decimal d1 = N;
        if (Decimal.Compare(d1, 0M) != 0)
        {
          if (Decimal.Compare(d1, 1M) == 0)
            str1 += "One";
          else if (Decimal.Compare(d1, 2M) == 0)
            str1 += "Two";
          else if (Decimal.Compare(d1, 3M) == 0)
            str1 += "Three";
          else if (Decimal.Compare(d1, 4M) == 0)
            str1 += "Four";
          else if (Decimal.Compare(d1, 5M) == 0)
            str1 += "Five";
          else if (Decimal.Compare(d1, 6M) == 0)
            str1 += "Six";
          else if (Decimal.Compare(d1, 7M) == 0)
            str1 += "Seven";
          else if (Decimal.Compare(d1, 8M) == 0)
            str1 += "Eight";
          else if (Decimal.Compare(d1, 9M) == 0)
            str1 += "Nine";
          else if (Decimal.Compare(d1, 10M) == 0)
            str1 += "Ten";
          else if (Decimal.Compare(d1, 11M) == 0)
            str1 += "Eleven";
          else if (Decimal.Compare(d1, 12M) == 0)
            str1 += "Twelve";
          else if (Decimal.Compare(d1, 13M) == 0)
            str1 += "Thirteen";
          else if (Decimal.Compare(d1, 14M) == 0)
            str1 += "Fourteen";
          else if (Decimal.Compare(d1, 15M) == 0)
            str1 += "Fifteen";
          else if (Decimal.Compare(d1, 16M) == 0)
            str1 += "Sixteen";
          else if (Decimal.Compare(d1, 17M) == 0)
            str1 += "Seventeen";
          else if (Decimal.Compare(d1, 18M) == 0)
            str1 += "Eighteen";
          else if (Decimal.Compare(d1, 19M) == 0)
            str1 += "Nineteen";
        }
        str2 = str1;
      }
      else
        str2 = str1;
    }
    else
      str2 = str1;
    return str2;
  }
}
