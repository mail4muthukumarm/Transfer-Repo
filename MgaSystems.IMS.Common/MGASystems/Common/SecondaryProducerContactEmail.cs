// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SecondaryProducerContactEmail
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class SecondaryProducerContactEmail
{
  public static string[] SetSecondaryProducerCarbonCopyEmail(Guid quoteGuid, string[] currentList)
  {
    string[] strArray1;
    if (!SystemSettings.KeyExists("ccGlobalSecondaryProducerContact") || !SystemSettings.GetBoolSetting("ccGlobalSecondaryProducerContact"))
    {
      strArray1 = currentList;
    }
    else
    {
      string str1 = DefaultDatabase.ExecuteScalar<string>("spGetSecProducerContactEmail_CC", new object[2]
      {
        (object) "@QuoteGuid",
        (object) quoteGuid
      });
      if (string.IsNullOrEmpty(str1))
        strArray1 = currentList;
      else if (currentList != null && ((IEnumerable<string>) currentList).Contains<string>(str1))
      {
        strArray1 = currentList;
      }
      else
      {
        List<string> stringList = new List<string>();
        stringList.Add(str1);
        if (currentList != null)
        {
          string[] strArray2 = currentList;
          int index = 0;
          while (index < strArray2.Length)
          {
            string str2 = strArray2[index];
            stringList.Add(str2);
            checked { ++index; }
          }
        }
        strArray1 = stringList.ToArray();
      }
    }
    return strArray1;
  }

  public static List<string> SetSecondaryProducerCarbonCopyEmail(
    Guid quoteGuid,
    List<string> currentList)
  {
    List<string> stringList;
    if (!SystemSettings.KeyExists("ccGlobalSecondaryProducerContact") || !SystemSettings.GetBoolSetting("ccGlobalSecondaryProducerContact"))
    {
      stringList = currentList;
    }
    else
    {
      string str = DefaultDatabase.ExecuteScalar<string>("spGetSecProducerContactEmail_CC", new object[2]
      {
        (object) "@QuoteGuid",
        (object) quoteGuid
      });
      if (string.IsNullOrEmpty(str))
        stringList = currentList;
      else if (currentList != null && currentList.Contains(str))
      {
        stringList = currentList;
      }
      else
      {
        currentList.Add(str);
        stringList = currentList;
      }
    }
    return stringList;
  }
}
