// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.StringExtensions
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class StringExtensions
{
  public static bool IsGuid(this string aString) => Guid.TryParse(aString, out Guid _);

  public static bool EqualsNoCase(this string str, string checkStr)
  {
    return string.Equals(str, checkStr, StringComparison.InvariantCultureIgnoreCase);
  }

  public static bool ContainsNoCase(this string str, string checkStr)
  {
    return str.Contains(checkStr, StringComparison.InvariantCultureIgnoreCase);
  }

  public static bool Contains(this string str, string checkStr, StringComparison compareType)
  {
    return string.IsNullOrEmpty(str) && string.IsNullOrEmpty(checkStr) || (str != null ? str.IndexOf(checkStr, compareType) : -1) > -1;
  }

  public static string AppendUrlParts(this string baseUrl, params string[] urlParts)
  {
    baseUrl = baseUrl ?? string.Empty;
    if ((urlParts != null ? (urlParts.Length > 0 ? 1 : 0) : 0) != 0)
    {
      char[] charArray = "\\/".ToCharArray();
      int num = urlParts.Length - 1;
      for (int index = 0; index <= num; ++index)
        baseUrl = $"{baseUrl.TrimEnd(charArray)}/{(urlParts[index] ?? string.Empty).TrimStart(charArray)}";
    }
    return baseUrl;
  }

  public static string ToTitleCase(this string input, CultureInfo culture = null)
  {
    return input != null ? (input.Length <= 1 ? input.ToUpper() : (culture ?? CultureInfo.CurrentCulture).TextInfo.ToTitleCase(input)) : (string) null;
  }

  public static string FirstLetterToUpper(this string input, CultureInfo culture = null)
  {
    string upper;
    if (string.IsNullOrEmpty(input))
    {
      upper = input;
    }
    else
    {
      char[] charArray = input.ToCharArray();
      charArray[0] = char.ToUpper(charArray[0], culture ?? CultureInfo.CurrentCulture);
      upper = new string(charArray);
    }
    return upper;
  }
}
