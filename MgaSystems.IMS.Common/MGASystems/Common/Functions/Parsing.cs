// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Functions.Parsing
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text.RegularExpressions;

#nullable disable
namespace MGASystems.Common.Functions;

[StandardModule]
public sealed class Parsing
{
  public static bool IsValidEmailAddress(string sEmail)
  {
    return sEmail != null && !sEmail.Contains("\t") && Regex.IsMatch(sEmail.ToLower(), "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", RegexOptions.IgnorePatternWhitespace);
  }

  public static Decimal PercentToDecimal(string percentage)
  {
    return percentage != null ? Decimal.Divide(Conversions.ToDecimal(percentage.Replace("%", string.Empty)), 100M) : throw new ArgumentNullException(nameof (percentage));
  }

  public static Decimal[] IntelliParseStringToDecimals(string parseString)
  {
    return parseString != null ? Parsing.IntelliParseStringToDecimals(parseString, 1L) : throw new ArgumentNullException(nameof (parseString));
  }

  public static Decimal[] IntelliParseStringToDecimals(string parseString, long noSpecMultiplier)
  {
    if (parseString == null)
      throw new ArgumentNullException(nameof (parseString));
    string[] strArray1 = new string[2]{ "/", "-" };
    string str1 = string.Empty;
    Decimal d1_1 = 0M;
    string[] strArray2 = strArray1;
    int index1 = 0;
    while (index1 < strArray2.Length)
    {
      string str2 = strArray2[index1];
      if (parseString.IndexOf(str2) != -1)
      {
        d1_1 = Decimal.Add(d1_1, 1M);
        str1 = str2;
      }
      checked { ++index1; }
    }
    Decimal[] stringToDecimals;
    if (Decimal.Compare(d1_1, 1M) != 0 || !Versioned.IsNumeric((object) noSpecMultiplier))
    {
      stringToDecimals = (Decimal[]) null;
    }
    else
    {
      string[] strArray3 = parseString.Split(str1.ToCharArray());
      Decimal[] numArray = new Decimal[strArray3.Length - 1 + 1];
      int num = strArray3.Length - 1;
      for (int index2 = 0; index2 <= num; ++index2)
      {
        string Expression = strArray3[index2];
        if (Versioned.IsNumeric((object) Expression))
        {
          string s = Expression.Replace(",", string.Empty);
          numArray[index2] = Decimal.Parse(s);
        }
        else
        {
          string empty1 = string.Empty;
          string empty2 = string.Empty;
          string str3 = Expression;
          int index3 = 0;
          while (index3 < str3.Length)
          {
            char c = str3[index3];
            if (char.IsNumber(c) || Operators.CompareString(Conversions.ToString(c), ".", false) == 0)
              empty1 += Conversions.ToString(c);
            else
              empty2 += Conversions.ToString(c);
            checked { ++index3; }
          }
          string upper = empty2.Trim().ToUpper();
          Decimal d1_2 = Decimal.Parse(empty1);
          if ("HUNDRED".Contains(upper))
            d1_2 = Decimal.Multiply(d1_2, 100M);
          else if ("THOUSAND".Contains(upper))
            d1_2 = Decimal.Multiply(d1_2, 1000M);
          else if ("MILLION".Contains(upper))
            d1_2 = Decimal.Multiply(d1_2, 1000000M);
          else if ("MIL".Contains(upper))
            d1_2 = Decimal.Multiply(d1_2, 1000000M);
          else if ("BILLION".Contains(upper))
            d1_2 = Decimal.Multiply(d1_2, 1000000000M);
          numArray[index2] = d1_2;
        }
      }
      stringToDecimals = numArray;
    }
    return stringToDecimals;
  }
}
