// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.Logging
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.Email;

[StandardModule]
public sealed class Logging
{
  internal static string WriteLogWithArgs(
    string method,
    string protocol,
    string message,
    bool isOptional,
    params object[] args)
  {
    if (args != null)
      message = $"{message} {ActionLog.ToArgString(args)}";
    return ActionLog.Write($"Email.{protocol}", method, message, isOptional);
  }

  internal static string WriteLogWithObjects(
    string method,
    string protocol,
    string message,
    UserEmail user,
    MessageObject mailObj,
    bool isOptional = false)
  {
    List<object> objectList1 = new List<object>();
    if (user != null)
      objectList1.AddRange((IEnumerable<object>) new object[18]
      {
        (object) $"user.{"Address"}",
        (object) user.Address,
        (object) $"user.{"Server"}",
        (object) user.Server,
        (object) $"user.{"Username"}",
        (object) user.Username,
        (object) $"user.{"Password"}",
        (object) user.Password,
        (object) $"user.{"Domain"}",
        (object) user.Domain,
        (object) $"user.{"UseOutlookWS"}",
        (object) user.UseOutlookWS,
        (object) $"user.{"AzureClientID"}",
        (object) user.AzureClientID,
        (object) $"user.{"AzureTenantID"}",
        (object) user.AzureTenantID,
        (object) $"user.Using{"AzureSecret"}",
        (object) !string.IsNullOrEmpty(user.AzureSecret)
      });
    if (mailObj != null)
    {
      List<object> objectList2 = objectList1;
      object[] collection = new object[22];
      collection[0] = (object) "message.SendOutlook";
      collection[1] = (object) mailObj.SendOutlook.ToString();
      collection[2] = (object) "message.UserProperties";
      IEnumerable<DictionaryEntry> source = mailObj.UserProperties.Cast<DictionaryEntry>();
      Func<DictionaryEntry, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (Logging._Closure\u0024__.\u0024I1\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = Logging._Closure\u0024__.\u0024I1\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Logging._Closure\u0024__.\u0024I1\u002D0 = selector = (Func<DictionaryEntry, string>) ([SpecialName] (x) => $"[{RuntimeHelpers.GetObjectValue(x.Key)},{RuntimeHelpers.GetObjectValue(x.Value)}]");
      }
      collection[3] = (object) string.Join(",", source.Select<DictionaryEntry, string>(selector));
      collection[4] = (object) "message.FromAddress";
      collection[5] = (object) mailObj.FromAddress;
      collection[6] = (object) "message.Recipients";
      collection[7] = (object) string.Join(";", (IEnumerable<string>) mailObj.Recipients);
      collection[8] = (object) "message.CC";
      collection[9] = (object) string.Join(";", (IEnumerable<string>) mailObj.CCRecipients);
      collection[10] = (object) "message.BCC";
      collection[11] = (object) string.Join(";", (IEnumerable<string>) mailObj.BCCRecipients);
      collection[12] = (object) "message.Subject";
      collection[13] = (object) mailObj.Subject;
      collection[14] = (object) "message.TextBody";
      collection[15] = (object) mailObj.TextBody;
      collection[16 /*0x10*/] = (object) "message.HTMLBody";
      collection[17] = (object) mailObj.HTMLBody;
      collection[18] = (object) "message.ImageBody";
      collection[19] = (object) mailObj.ImageBody;
      collection[20] = (object) "message.FileAttachments";
      collection[21] = (object) string.Join(",", (IEnumerable<string>) mailObj.FileAttachments);
      objectList2.AddRange((IEnumerable<object>) collection);
    }
    return Logging.WriteLogWithArgs(method, protocol, message, isOptional, objectList1.ToArray());
  }

  internal static string WriteLog(string method, string protocol, string message, bool isOptional = false)
  {
    return ActionLog.Write($"Email.{protocol}", method, message, isOptional);
  }
}
