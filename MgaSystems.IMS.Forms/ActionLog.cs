// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.ActionLog
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Forms;

[LogCategory("MGASystems.IMS.Forms.Actions", "MGASystems.IMS.Forms.Actions")]
[LogCategory("MGASystems.IMS.Forms.Actions(Verbose)", "MGASystems.IMS.Forms.Actions(Verbose)")]
internal sealed class ActionLog
{
  internal const string LogKey = "MGASystems.IMS.Forms.Actions";
  internal const string LogKeyVerbose = "MGASystems.IMS.Forms.Actions(Verbose)";

  internal static string ToArgString(params object[] nameValueArgs)
  {
    string argString;
    try
    {
      if (nameValueArgs != null && nameValueArgs.Length > 0)
      {
        StringBuilder stringBuilder = new StringBuilder("Args: ");
        int num = nameValueArgs.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (index % 2 == 0)
          {
            if (index != 0)
              stringBuilder.Append(", ");
            stringBuilder.Append((nameValueArgs[index] ?? (object) "").ToString());
            stringBuilder.Append(": ");
          }
          else
            stringBuilder.Append((nameValueArgs[index] ?? (object) "").ToString());
        }
        argString = stringBuilder.ToString();
      }
      else
        argString = "";
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      argString = "Excecption Occurred in ActionLog.ToArgString";
      ProjectData.ClearProjectError();
    }
    return argString;
  }

  internal static string ToResultString(object result)
  {
    string resultString;
    try
    {
      if (result != null)
      {
        resultString = $" Result: {result.ToString()}";
        goto label_4;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      resultString = "Excecption Occurred in ActionLog.ToResultString";
      ProjectData.ClearProjectError();
      goto label_4;
    }
    resultString = "";
label_4:
    return resultString;
  }

  internal static string Write(string className, string methodName, string message, bool optional = false)
  {
    string str;
    try
    {
      string message1 = string.Format($"{className}.{methodName} {message}");
      if (!optional)
        Log.Write(message1, "MGASystems.IMS.Forms.Actions");
      Log.Write(message1, "MGASystems.IMS.Forms.Actions(Verbose)");
      str = message1;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = "Excecption Occurred in ActionLog.Write";
      ProjectData.ClearProjectError();
    }
    return str;
  }
}
