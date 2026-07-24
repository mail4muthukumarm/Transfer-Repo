// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ErrorHandling.ErrorHandler
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.DataAccess;
using MGASystems.Common.MgaReportingServices;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.ErrorHandling;

[StandardModule]
[LogCategory("MGASystems.Common.ErrorHandler", "MGASystems.Common.ErrorHandler")]
[LogCategory("MGASystems.Common.ErrorHandler(Verbose)", "MGASystems.Common.ErrorHandler(Verbose)")]
public sealed class ErrorHandler
{
  internal const string LogKey = "MGASystems.Common.ErrorHandler";
  internal const string LogKeyVerbose = "MGASystems.Common.ErrorHandler(Verbose)";

  public static void ShowConnectivityIssuesForm(Exception ex)
  {
    using (ConnectivityIssuesForm connectivityIssuesForm = new ConnectivityIssuesForm(ex))
    {
      connectivityIssuesForm.MdiParent = MDIControls.Instance.MDIParent;
      connectivityIssuesForm.Show();
    }
  }

  public static void HandleErrorOnThread(Control uiContext, Exception ex)
  {
    if (uiContext == null)
      throw new ArgumentNullException(nameof (uiContext));
    if (MDIControls.Instance.BlackBoxMode)
      ExceptionDispatchInfo.Capture(ex).Throw();
    else if (uiContext.InvokeRequired)
      uiContext.Invoke((Delegate) new Action<Exception>(ErrorHandler.HandleError), (object) ex);
    else
      ErrorHandler.HandleError(ex);
  }

  public static void SilentLogError(Exception ex)
  {
    if (ex == null)
      throw new ArgumentNullException(nameof (ex));
    ErrorHandler.WriteLog(ex);
  }

  public static void SilentHandleError(Exception ex)
  {
    ErrorHandler.SilentHandleError(ex, CurrentUser.Instance.SupportCenterClientID, CurrentUser.Instance.UserName);
  }

  public static void SilentHandleError(Exception ex, int clientId, string userName)
  {
    if (ex == null)
      throw new ArgumentNullException(nameof (ex));
    ErrorHandler.WriteLog(ex);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(userName, string.Empty, false) == 0)
      userName = $"{Environment.UserName}@{Environment.MachineName}";
    string secondaryErrorMessage = string.Empty;
    if (ex.InnerException != null)
      secondaryErrorMessage = ex.InnerException.Message;
    StringBuilder stringBuilder = new StringBuilder(ex.Message);
    if (ex.Data != null && ex.Data.Count > 0)
    {
      stringBuilder.AppendLine("");
      foreach (object obj in ex.Data)
      {
        DictionaryEntry dictionaryEntry = obj != null ? (DictionaryEntry) obj : new DictionaryEntry();
        stringBuilder.AppendLine($"Exception Data Key: {RuntimeHelpers.GetObjectValue(dictionaryEntry.Key)}, Value: {RuntimeHelpers.GetObjectValue(dictionaryEntry.Value)}");
      }
    }
    using (CriticalErrorService criticalErrorService = new CriticalErrorService())
    {
      if (ConfigurationManager.AppSettings["CriticalErrorServiceURL"] != null)
        criticalErrorService.Url = ConfigurationManager.AppSettings["CriticalErrorServiceURL"];
      try
      {
        string stackTrace = ex.StackTrace + $"{Environment.NewLine}-----{Environment.NewLine}{Environment.StackTrace}";
        criticalErrorService.ReportCriticalError(clientId, userName, stringBuilder.ToString(), secondaryErrorMessage, stackTrace, ex.GetType().ToString());
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        ProjectData.ClearProjectError();
      }
    }
  }

  public static void HandleError(string newExceptionMessage, Exception innerException)
  {
    ErrorHandler.HandleError(new Exception(newExceptionMessage, innerException));
  }

  public static void HandleError(Exception ex) => ErrorHandler.HandleError(ex, false);

  public static IProgress<Exception> GetHandleErrorProgress()
  {
    MDIControls instance = MDIControls.Instance;
    return (instance != null ? (instance.BlackBoxMode ? 1 : 0) : 1) == 0 ? (IProgress<Exception>) new Progress<Exception>(new Action<Exception>(ErrorHandler.HandleError)) : (IProgress<Exception>) new Progress<Exception>(new Action<Exception>(ErrorHandler.SilentHandleError));
  }

  private static bool IsFilterableError(Exception ex)
  {
    return ex is NullReferenceException && ex.StackTrace.Contains("at Infragistics.Win.Utilities.IsActiveControlHelper(Control control, IContainerControl container)");
  }

  private static void HandleReflectionTypeLoadException(ReflectionTypeLoadException ex)
  {
    List<string> stringList = new List<string>();
    Type[] types = ex.Types;
    int index = 0;
    while (index < types.Length)
    {
      string fullName = types[index].Assembly.FullName;
      if (!stringList.Contains(fullName))
        stringList.Add(fullName);
      checked { ++index; }
    }
    string empty = string.Empty;
    try
    {
      foreach (string str in stringList)
        empty += $"{str}{Environment.NewLine}{Environment.NewLine}";
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    int num = (int) System.Windows.Forms.MessageBox.Show($"Assemblies that could not be loaded were: {Environment.NewLine}{Environment.NewLine}{empty}", "Could not load type", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  public static void HandleError(Exception ex, bool exitApplicationWhenDone)
  {
    if (ex == null)
      throw new ArgumentNullException(nameof (ex));
    ErrorHandler.WriteLog(ex);
    if (ex.StackTrace == null)
    {
      try
      {
        throw new ArgumentNullException("Exception is missing StackTrace", ex);
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        ErrorHandler.SilentHandleError(ex1);
        ProjectData.ClearProjectError();
      }
    }
    switch (ex)
    {
      case SqlException _ when ((SqlException) ex).State == (byte) 123:
        MGASystems.Common.ThreadingFunctions.MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      case SqlException _:
      case InvalidOperationException _ when ex.Message.Contains("Timeout expired"):
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS timed out while attempting to communicate with the database{Environment.NewLine}{Environment.NewLine}Please try this operation again, as this could be due to temporary network problems.{Environment.NewLine}{Environment.NewLine}You will now be presented with a dialog which allows you to send a report of this problem to MGA Systems.", "Network Connectivity Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case DatabaseRetryException _:
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS could not retrieve the data from the database in an acceptable period of time.{Environment.NewLine}{Environment.NewLine}Please try your action again.{Environment.NewLine}{Environment.NewLine}If this problem persists, please contact technical support", "Database Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      case IQuoteGuidNotFoundException _:
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The quote transaction you are working with could not be located.{Environment.NewLine}{Environment.NewLine}It is possible that it was removed by another user.", "Quote Transaction Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      default:
        if (ErrorHandler.IsFilterableError(ex))
          return;
        break;
    }
    try
    {
      bool flag1 = true;
      bool flag2 = CurrentUser.IsMGADeveloper;
      try
      {
        if (ErrorHandler.HasCustomizationKey("Debug.ShowExceptionExplorer"))
        {
          if ((bool) new AppSettingsReader().GetValue("Debug.ShowExceptionExplorer", typeof (bool)))
            flag2 = true;
        }
      }
      catch (Exception ex2)
      {
        ProjectData.SetProjectError(ex2);
        ProjectData.ClearProjectError();
      }
      if (flag2)
      {
        using (Form formEx = ObjectFactory.Instance.CreateFormEX(ObjectFactory.Instance.CreateTypeFromString("MgaSystems.IMS.Forms.DebugHelper.Views.DeveloperDebugHelper"), (object) ex))
        {
          int num = (int) formEx.ShowDialog();
        }
        flag1 = System.Windows.Forms.MessageBox.Show("Do you want to send this to the error reporting service?", "Send Report?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        exitApplicationWhenDone = System.Windows.Forms.MessageBox.Show("Shut down the IMS?", "Shut Down?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        if (ex is ReflectionTypeLoadException ex3)
          ErrorHandler.HandleReflectionTypeLoadException(ex3);
      }
      if (!flag1)
        return;
      ErrorHandler.ShowErrorHandlingForm(ex);
    }
    catch (Exception ex4)
    {
      ProjectData.SetProjectError(ex4);
      int num = (int) System.Windows.Forms.MessageBox.Show($"Fatal Error{Environment.NewLine}{Environment.NewLine}{ex.Message}", "Fatal Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (exitApplicationWhenDone)
      {
        CurrentUser.Instance.Logout();
        Application.Exit();
      }
    }
  }

  private static bool HasCustomizationKey(string key)
  {
    int num = ConfigurationManager.AppSettings.Keys.Count - 1;
    bool flag;
    for (int index = 0; index <= num; ++index)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ConfigurationManager.AppSettings.Keys[index], key, false) == 0)
      {
        flag = true;
        goto label_6;
      }
    }
    flag = false;
label_6:
    return flag;
  }

  private static void ShowErrorHandlingForm(Exception ex)
  {
    if (ex.Message.Contains("Timeout expired") || ex.Message.Contains("forcibly closed by the remote host") || ex.Message.Contains("Could not open a connection to SQL Server"))
    {
      using (ConnectivityIssuesForm connectivityIssuesForm = new ConnectivityIssuesForm(ex))
      {
        connectivityIssuesForm.ShowInTaskbar = true;
        int num = (int) connectivityIssuesForm.ShowDialog();
      }
    }
    else
    {
      using (FormCustomExceptionHandler exceptionHandler = new FormCustomExceptionHandler(ex))
      {
        exceptionHandler.GetDesktopImage();
        exceptionHandler.ShowInTaskbar = true;
        int num = (int) exceptionHandler.ShowDialog();
      }
    }
  }

  public static void ShowDataSetErrors(DataSet ds, ConstraintException ex)
  {
    if (ds == null)
      throw new ArgumentNullException(nameof (ds));
    if (!ds.HasErrors)
      return;
    ExceptionDispatchInfo.Capture((Exception) ex).Throw();
  }

  internal static string WriteLog(Exception ex)
  {
    string str;
    try
    {
      string message1 = $"Source: {ex.TargetSite?.ToString().Replace(" ", $" {ex.TargetSite?.DeclaringType.FullName}.")}{Environment.NewLine}Message: {ex.Message}";
      if (ex.InnerException != null)
        message1 = $"{message1}{Environment.NewLine}{Environment.NewLine}Inner Exception:{Environment.NewLine}Source: {ex.InnerException.TargetSite?.ToString().Replace(" ", $" {ex.InnerException.TargetSite?.DeclaringType.FullName}.")}{Environment.NewLine}Message: {ex.InnerException.Message}";
      Log.Write(message1, "MGASystems.Common.ErrorHandler");
      string message2 = $"{message1}{Environment.NewLine}Full Exception:{Environment.NewLine}{ex}";
      if (ex.InnerException != null)
        message2 = $"{message2}{Environment.NewLine}Full Inner Exception:{Environment.NewLine}{ex.InnerException}";
      Log.Write(message2, "MGASystems.Common.ErrorHandler(Verbose)");
      str = message2;
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      str = "Exception Occurred in ErrorHandler.WriteLog";
      ProjectData.ClearProjectError();
    }
    return str;
  }
}
