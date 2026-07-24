// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.GraphModel.StringHelper
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.Email.GraphModel;

[StandardModule]
internal sealed class StringHelper
{
  public static string ConvertTypeToTitleCase(string typeString)
  {
    string titleCase;
    if (!string.IsNullOrEmpty(typeString))
    {
      string[] source = typeString.Split('.');
      Func<string, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (StringHelper._Closure\u0024__.\u0024I0\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = StringHelper._Closure\u0024__.\u0024I0\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        StringHelper._Closure\u0024__.\u0024I0\u002D0 = selector = (Func<string, string>) ([SpecialName] (segment) => segment.Substring(0, 1).ToUpperInvariant() + segment.Substring(1));
      }
      titleCase = string.Join(".", ((IEnumerable<string>) source).Select<string, string>(selector));
    }
    else
      titleCase = typeString;
    return titleCase;
  }

  public static string ConvertTypeToLowerCamelCase(string typeString)
  {
    string lowerCamelCase;
    if (!string.IsNullOrEmpty(typeString))
    {
      string[] source = typeString.Split('.');
      Func<string, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (StringHelper._Closure\u0024__.\u0024I1\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = StringHelper._Closure\u0024__.\u0024I1\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        StringHelper._Closure\u0024__.\u0024I1\u002D0 = selector = (Func<string, string>) ([SpecialName] (segment) => segment.Substring(0, 1).ToLowerInvariant() + segment.Substring(1));
      }
      lowerCamelCase = string.Join(".", ((IEnumerable<string>) source).Select<string, string>(selector));
    }
    else
      lowerCamelCase = typeString;
    return lowerCamelCase;
  }

  public static string ConvertIdentifierToLowerCamelCase(string identifierString)
  {
    return string.IsNullOrEmpty(identifierString) ? identifierString : identifierString.Substring(0, 1).ToLowerInvariant() + identifierString.Substring(1);
  }
}
