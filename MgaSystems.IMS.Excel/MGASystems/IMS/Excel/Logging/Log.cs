// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Logging.Log
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using System;

#nullable disable
namespace MGASystems.IMS.Excel.Logging;

[MGASystems.IMS.Logging.Administration.LogCategory("Excel Integration Log", "EIL")]
public static class Log
{
  private const string LogName = "Excel Integration Log";
  private const string LogCategory = "EIL";

  public static void WriteAction(Exception ex, string message)
  {
    if (ex != null)
    {
      try
      {
        Log.WriteAction(ex.Message);
        ErrorHandler.SilentHandleError(ex);
      }
      catch
      {
        Log.WriteAction(ex.Message);
      }
    }
    else
      Log.WriteAction("Write called with a null Exception, you should check that.");
    Log.WriteAction(message);
  }

  public static void WriteAction(string message)
  {
    if (string.IsNullOrEmpty(message))
      message = "The caller of Log.WriteAction did not specify a message";
    message = "Excel Integration: " + message;
    try
    {
      CurrentUser.Instance.LogAction(message, (int) sbyte.MaxValue);
      MGASystems.IMS.Logging.Log.Write(message, "EIL");
    }
    catch (Exception ex)
    {
      MGASystems.IMS.Logging.Log.Write($"Excel Integration CurrentUser.Log Failure: {ex.Message}, {ex.StackTrace ?? "no stack trace"}", "EIL");
      MGASystems.IMS.Logging.Log.Write(message, "EIL");
    }
  }

  public static void Write(string message) => MGASystems.IMS.Logging.Log.Write(message, "EIL");
}
