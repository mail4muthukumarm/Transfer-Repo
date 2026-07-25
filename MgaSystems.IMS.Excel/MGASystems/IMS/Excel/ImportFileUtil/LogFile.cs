// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.LogFile
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common;
using MGASystems.IMS.Logging;
using System;
using System.Globalization;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

[MGASystems.IMS.Logging.Administration.LogCategory("Excel Import File Util Log", "EIF")]
internal class LogFile
{
  private const string LogName = "Excel Import File Util Log";
  private const string LogCategory = "EIF";

  public LogFile(
    Exception objException,
    string errorLocation,
    string errorLogPath,
    bool allDebugInfo)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("Error : " + objException.Message.ToString().Trim());
    stringBuilder.AppendLine("Additional Error Information : " + errorLocation);
    if (allDebugInfo)
    {
      stringBuilder.AppendLine("Source : " + objException.Source.ToString().Trim());
      stringBuilder.AppendLine("Method : " + objException.TargetSite.ToString());
      stringBuilder.AppendLine("Stack Trace : ");
      stringBuilder.AppendLine(objException.StackTrace.ToString().Trim());
    }
    LogFile.Write(stringBuilder.ToString());
  }

  public LogFile(
    Exception objException,
    string customErrorMessage,
    string errorLocation,
    string errorLogPath,
    bool allDebugInfo)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("Error : " + objException.Message.ToString().Trim());
    stringBuilder.AppendLine("Additional Error Information : " + errorLocation);
    if (!string.IsNullOrEmpty(customErrorMessage))
      stringBuilder.AppendLine("Custom Error Message : " + customErrorMessage);
    if (allDebugInfo)
    {
      stringBuilder.AppendLine("Source : " + objException.Source.ToString().Trim());
      stringBuilder.AppendLine("Method : " + objException.TargetSite.ToString());
      stringBuilder.AppendLine("Stack Trace : ");
      stringBuilder.AppendLine(objException.StackTrace.ToString().Trim());
    }
    LogFile.Write(stringBuilder.ToString());
  }

  public LogFile(string errorMessage, string errorLocation, string errorLogPath)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("Error : " + errorMessage);
    stringBuilder.AppendLine("Additional Error Information : " + errorLocation);
    LogFile.Write(stringBuilder.ToString());
  }

  public LogFile(
    string errorMessage,
    string customErrorMessage,
    string errorLocation,
    string errorLogPath)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("Error : " + errorMessage);
    stringBuilder.AppendLine("Additional Error Information : " + errorLocation);
    if (!string.IsNullOrEmpty(customErrorMessage))
      stringBuilder.AppendLine("Custom Error Message : " + customErrorMessage);
    LogFile.Write(stringBuilder.ToString());
  }

  public static string FormatInvariant(string format, params object[] args)
  {
    return string.Format((IFormatProvider) CultureInfo.InvariantCulture, format, args);
  }

  public static void Write(string message)
  {
    if (string.IsNullOrEmpty(message))
      message = "The caller of Log.Write did not specify a message";
    message = LogFile.FormatInvariant("Excel Import File Util: {0}", (object) message);
    try
    {
      CurrentUser.Instance.LogAction(message, 289);
      Log.Write(message, "EIF");
    }
    catch (Exception ex)
    {
      Log.Write(LogFile.FormatInvariant("Excel Import File Util CurrentUser.Log Failure: {0}, {1}", (object) ex.Message, ex.StackTrace != null ? (object) ex.StackTrace.ToString() : (object) "no stack trace"), "EIF");
      Log.Write(message, "EIF");
    }
  }
}
