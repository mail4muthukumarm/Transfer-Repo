// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common.ErrorHandling;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

public class ErrorHandling
{
  public const string CanViewImportFileUtility = "{D57DE89C-A197-484F-AFD7-87B61EC4C4AC}";

  public ErrorHandling(
    Exception ex,
    string function,
    string ErrorLogDirectory,
    bool AllDebugInfo,
    bool popupMessage)
  {
    if (popupMessage)
    {
      int num = (int) MessageBox.Show(ex.Message, "Error occured in : " + function, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ErrorHandler.SilentHandleError(ex);
    }
    LogFile logFile = new LogFile(ex, function, ErrorLogDirectory, AllDebugInfo);
  }

  public ErrorHandling(
    CustomException ex,
    string function,
    string ErrorLogDirectory,
    bool AllDebugInfo,
    bool popupMessage)
  {
    if (popupMessage)
    {
      int num = (int) MessageBox.Show(ex.InnerException.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ErrorHandler.SilentHandleError((Exception) ex);
    }
    LogFile logFile = new LogFile((Exception) ex, function, ErrorLogDirectory, AllDebugInfo);
  }

  public ErrorHandling(
    OutOfMemoryException ex,
    string function,
    string ErrorLogDirectory,
    bool AllDebugInfo,
    bool popupMessage)
  {
    if (popupMessage)
    {
      int num = (int) MessageBox.Show(ex.Message, "Error occured in : " + function, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ErrorHandler.SilentHandleError((Exception) ex);
    }
    LogFile logFile = new LogFile((Exception) ex, function, ErrorLogDirectory, AllDebugInfo);
  }

  public ErrorHandling(
    SqlException ex,
    string function,
    string ErrorLogDirectory,
    bool AllDebugInfo,
    bool popupMessage)
  {
    if (popupMessage)
    {
      int num = (int) MessageBox.Show(ex.Message, "Error occured in : " + function, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ErrorHandler.SilentHandleError((Exception) ex);
    }
    LogFile logFile = new LogFile((Exception) ex, function, ErrorLogDirectory, AllDebugInfo);
  }
}
