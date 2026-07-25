// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Data.SSMSInterop
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.Excel.Data;

internal static class SSMSInterop
{
  public static bool AdUserCanAccessDb { get; } = SSMSInterop.Initialize();

  public static bool CanCopySSMSPasswordToClipboard { get; } = CurrentUser.IsMGADeveloper && !SSMSInterop.AdUserCanAccessDb;

  private static string SanitizeConnectionString(string connectionString)
  {
    SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
    connectionStringBuilder.IntegratedSecurity = true;
    connectionStringBuilder.Remove("user");
    connectionStringBuilder.Remove("pwd");
    return connectionStringBuilder.ConnectionString + "; Connection Timeout=10";
  }

  private static void OpenSSMS()
  {
    try
    {
      SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(SSMSInterop.AdUserCanAccessDb ? SSMSInterop.SanitizeConnectionString(DefaultDatabase.ConnectionString) : DefaultDatabase.ConnectionString);
      using (Process process = new Process())
      {
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.FileName = "ssms.exe";
        process.StartInfo.Arguments = $"-S {connectionStringBuilder.DataSource.Replace(" ", "")} -D {connectionStringBuilder.InitialCatalog.Replace(" ", "")} -U {connectionStringBuilder.UserID.Replace(" ", "")}";
        process.Start();
      }
    }
    catch (Win32Exception ex)
    {
      ErrorHandler.SilentHandleError((Exception) ex);
      int num = (int) MessageBox.Show("Make sure you add the path to ssms.exe to your Environment PATH variable. " + ex.Message, "Could not find ssms.exe");
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show(ex.ToString());
    }
  }

  private static void CopySSMSPasswordToClipboard()
  {
    if (!SSMSInterop.CanCopySSMSPasswordToClipboard)
      return;
    string text = Clipboard.ContainsText() ? Clipboard.GetText() : "";
    Clipboard.SetText(new SqlConnectionStringBuilder(DefaultDatabase.ConnectionString).Password);
    int num = (int) MessageBox.Show("Password will be available in the clipboard until this message is dismissed.", "Password in clipboard", MessageBoxButton.OK, MessageBoxImage.Exclamation);
    Clipboard.SetText(text);
  }

  public static RelayCommand CreateOpenSSMSCommand()
  {
    return new RelayCommand(new Action(SSMSInterop.OpenSSMS));
  }

  public static RelayCommand CreateCopySSMSPasswordToClipboardCommand()
  {
    return new RelayCommand(new Action(SSMSInterop.CopySSMSPasswordToClipboard), (Func<bool>) (() => SSMSInterop.CanCopySSMSPasswordToClipboard));
  }

  private static bool ResolveAdUserCanAccessDb(string connectionString)
  {
    if (!MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ExcelRating.Debug.TestADConnectivity", true))
      return false;
    try
    {
      using (SqlConnection sqlConnection = new SqlConnection(SSMSInterop.SanitizeConnectionString(connectionString)))
      {
        sqlConnection.Open();
        return true;
      }
    }
    catch
    {
      return false;
    }
  }

  public static bool Initialize()
  {
    try
    {
      return CurrentUser.IsMGADeveloper && SSMSInterop.ResolveAdUserCanAccessDb(DefaultDatabase.ConnectionString);
    }
    catch
    {
      return false;
    }
  }
}
