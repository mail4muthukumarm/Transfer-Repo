// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Rating.ExcelFileTracker
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.MGAWebServicesLogon;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Excel.Data;
using MGASystems.IMS.Excel.Data.StandardRating;
using MgaSystems.IMS.Excel.Views;
using MGASystems.IMS.NoteDocuments.Serialization;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

#nullable disable
namespace MGASystems.IMS.Excel.Rating;

[Preference("ExcelRating.Override.ExcelPath", "")]
[Preference("ExcelRating.Override.ExcelVersion", 0)]
public class ExcelFileTracker
{
  private static readonly ExcelSecurityOverride excelSecurityOverride = ObjectFactory.Instance.CreateObjectAs<ExcelSecurityOverride>();
  private bool excelFileOpened;
  private readonly ExcelStandardRatingData ratingData;
  private Process process;
  private FileSystemWatcher fileSystemWatcher;
  private readonly object synchronizer;
  private readonly ExcelRater rater;
  private bool detectedFileLock;
  private int watcherReconnectAttempts;

  public ExcelFile ExcelFile { get; }

  public ExcelFileTracker(ExcelRater rater, object synchronizer)
  {
    this.rater = rater;
    this.synchronizer = synchronizer;
    this.ratingData = ExcelStandardRatingData.Create(rater.RaterID, rater.FactorSetGuid, rater.QuoteGuid);
    this.ExcelFile = this.ratingData.ExcelFile;
  }

  public void ShowExcelSheet()
  {
    this.ratingData.ExcelFile.PropertyChanged += new PropertyChangedEventHandler(this.ExcelFile_PropertyChanged);
    if (!this.ratingData.ExcelFile.FullPathIsValid)
      return;
    this.OpenExcelFile();
  }

  private void ExcelFile_PropertyChanged(object sender, PropertyChangedEventArgs e)
  {
    if (!(e.PropertyName == "FullPath"))
      return;
    this.ratingData.ExcelFile.PropertyChanged -= new PropertyChangedEventHandler(this.ExcelFile_PropertyChanged);
    this.OpenExcelFile();
  }

  protected virtual void UpdateWorkBookData(ExcelFile file)
  {
    if (file == null)
      throw new ArgumentNullException(nameof (file));
    try
    {
      if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "select UseWebServiceParameters from tblExcelRating_FactorSets where FactorSetGuid = @FactorSetGuid", new object[2]
      {
        (object) "@FactorSetGuid",
        (object) file.FactorSetGuid
      }))
      {
        int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select QuoteID from tblQuotes where QuoteGUID = @quoteGuid", new object[2]
        {
          (object) "@quoteGuid",
          (object) file.QuoteGuid
        });
        ExcelFileTracker.WriteDocumentProperty(file.Workbook, "MGASystems.IMS.Policy.QuoteID", (object) num);
        ExcelFileTracker.WriteDocumentProperty(file.Workbook, "MGASystems.IMS.Policy.BaseWebServicesUri", (object) CurrentUser.Instance.BaseWebServicesUri.ToString());
        ExcelFileTracker.WriteDocumentProperty(file.Workbook, "MGASystems.IMS.ServiceToken", (object) this.GetWebServiceToken().ToString());
        file.Workbook.Save(file.FullPath);
      }
      (ObjectFactory.Instance.CreateObjectAs<ExcelFileStrategy>() ?? throw new InvalidOperationException("Unable to create ExcelFileStrategy")).UpdateWorkBookData(file.FullPath, this.rater);
    }
    catch (Exception ex1)
    {
      // ISSUE: explicit non-virtual call
      for (Exception ex2 = ex1; ex2 != null && __nonvirtual (ex2.InnerException)?.StackTrace != null; ex2 = ex2.InnerException)
      {
        ErrorHandler.SilentHandleError(ex2);
        int num = (int) MessageBox.Show(ex2.Message, ex2.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      throw;
    }
  }

  private static void WriteDocumentProperty(Workbook workBook, string propertyName, object value)
  {
    try
    {
      if (!workBook.CustomDocumentProperties.Contains(propertyName))
      {
        switch (value)
        {
          case int num:
            workBook.CustomDocumentProperties.Add(propertyName, num);
            break;
          case string str:
            workBook.CustomDocumentProperties.Add(propertyName, str);
            break;
          default:
            throw new NotImplementedException($"Type {typeof (object)}");
        }
      }
      else
        workBook.CustomDocumentProperties[propertyName].Value = value;
    }
    catch (Exception ex)
    {
      throw new InvalidOperationException($"An error occurred while writing custom document property {propertyName} to worksheet.", ex);
    }
  }

  private Guid GetWebServiceToken()
  {
    using (Logon logon = new Logon())
    {
      logon.Url = MGASystems.BusinessObjects.Common.WebServicesLogonUrl;
      if (!MGASystems.BusinessObjects.Common.WebServicesToken.Equals(Guid.Empty))
      {
        try
        {
          logon.TokenHeaderValue = new TokenHeader()
          {
            Token = MGASystems.BusinessObjects.Common.WebServicesToken
          };
          if (logon.ExtendToken())
            return MGASystems.BusinessObjects.Common.WebServicesToken;
        }
        catch
        {
        }
      }
      string tripleDESEncryptedPassword = new Encryption().EncryptTripleDes(CurrentUser.Instance.Password);
      MGASystems.BusinessObjects.Common.WebServicesToken = logon.LoginUser(CurrentUser.Instance.UserName, tripleDESEncryptedPassword);
      return MGASystems.BusinessObjects.Common.WebServicesToken;
    }
  }

  private void OpenExcelFile()
  {
    MGASystems.IMS.Excel.Logging.Log.WriteAction("OpenExcelFile Starting");
    if (!this.ratingData.ExcelFile.FullPathIsValid)
    {
      int num1 = (int) MessageBox.Show("The Excel file download failed or was interrupted, please try opening the sheet again.", "Unable to open Excel File", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      if (!this.excelFileOpened)
      {
        this.UpdateWorkBookData(this.ratingData.ExcelFile);
        this.excelFileOpened = true;
        this.process = new Process();
        string preferenceString = Preferences.GetPreferenceString("ExcelRating.Override.ExcelPath");
        this.process.StartInfo.FileName = string.IsNullOrEmpty(preferenceString) || !File.Exists(preferenceString) ? "EXCEL.EXE" : preferenceString;
        this.process.StartInfo.UseShellExecute = true;
        string str = $"\"{this.ratingData.ExcelFile.FullPath}\"";
        this.process.StartInfo.Arguments = str;
        MGASystems.IMS.Excel.Logging.Log.WriteAction("OpenExcelFile Attempting to start process with file: " + str);
        try
        {
          this.process.Start();
        }
        catch (Win32Exception ex) when (ex.Message.ContainsNoCase("The system cannot find the file specified"))
        {
          MGASystems.IMS.Excel.Logging.Log.WriteAction("Explicitly launching Excel file from Process (no container program specified)");
          Process.Start(this.ratingData.ExcelFile.FullPath);
        }
        catch (Exception ex)
        {
          ErrorHandler.SilentHandleError(ex);
          int num2 = (int) MessageBox.Show("Error Starting Excel going to request UAC elevation as a test. Please contact Technical support");
          this.process.StartInfo.Verb = "runas";
          this.process.StartInfo.WorkingDirectory = Path.GetDirectoryName(this.ratingData.ExcelFile.FullPath);
          MGASystems.IMS.Excel.Logging.Log.WriteAction("OpenExcelFile Attempting to start process with UAC elevation");
          this.process.Start();
        }
        MGASystems.IMS.Excel.Logging.Log.WriteAction("OpenExcelFile Also Beginning File Trace");
        this.AllocateWatcher();
        Utility.ExecuteThread(new DoWorkEventHandler(this.FileOpenTraceThread), new RunWorkerCompletedEventHandler(this.FileOpenTraceThreadCompleted), (ProgressChangedEventHandler) null);
      }
      else
        MGASystems.IMS.Excel.Logging.Log.WriteAction("OpenExcelFile Excel File Already Opened, not tracking");
      MGASystems.IMS.Excel.Logging.Log.WriteAction("OpenExcelFile Ended");
    }
  }

  private void AllocateWatcher()
  {
    MGASystems.IMS.Excel.Logging.Log.WriteAction("OpenExcelFile Starting FileWatcher on " + this.ratingData.ExcelFile.FullPath);
    string filter = "*" + Path.GetExtension(this.ratingData.ExcelFile.FullPath);
    this.fileSystemWatcher = new FileSystemWatcher(Path.GetDirectoryName(this.ratingData.ExcelFile.FullPath), filter)
    {
      IncludeSubdirectories = false,
      NotifyFilter = NotifyFilters.FileName,
      EnableRaisingEvents = true
    };
    this.fileSystemWatcher.Error += new ErrorEventHandler(this.FileSystemWatcher_Error);
    this.fileSystemWatcher.Renamed += new RenamedEventHandler(this.FileSystemWatcher_Renamed);
    this.fileSystemWatcher.Changed += new FileSystemEventHandler(this.FileSystemWatcher_Changed);
  }

  private void FileSystemWatcher_Error(object sender, ErrorEventArgs e)
  {
    ++this.watcherReconnectAttempts;
    Exception exception = e.GetException();
    this.DeallocateWatcher();
    if (this.watcherReconnectAttempts <= 5)
    {
      Thread.Sleep(TimeSpan.FromSeconds(5.0));
      this.AllocateWatcher();
    }
    else
      ErrorHandler.SilentHandleError((Exception) new InvalidOperationException($"ExcelFileTracker.FileSystemWatcher_Error occurred. Unable to reconnect after {this.watcherReconnectAttempts} attempts.", exception));
  }

  private bool IsFileLocked(string fileName)
  {
    FileStream fileStream = (FileStream) null;
    try
    {
      fileStream = new FileInfo(fileName).Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
    }
    catch (IOException ex)
    {
      return true;
    }
    finally
    {
      fileStream?.Close();
    }
    return false;
  }

  private void FileOpenTraceThread(object sender, DoWorkEventArgs e)
  {
    MGASystems.IMS.Excel.Logging.Log.WriteAction("Checking file load status");
    for (bool flag = false; !flag; flag = this.IsFileLocked(this.ratingData.ExcelFile.FullPath))
    {
      MGASystems.IMS.Excel.Logging.Log.Write("File not yet loaded. Executing lock check:");
      Thread.Sleep(TimeSpan.FromSeconds(5.0));
    }
    MGASystems.IMS.Excel.Logging.Log.WriteAction("File loaded in Excel");
    int num = 0;
    MGASystems.IMS.Excel.Logging.Log.WriteAction("FileOpenTraceThread Starting");
    while (true)
    {
      Thread.Sleep(TimeSpan.FromSeconds(5.0));
      try
      {
        if (File.Exists(this.ratingData.ExcelFile.FullPath))
        {
          if (this.IsFileLocked(this.ratingData.ExcelFile.FullPath))
          {
            this.detectedFileLock = true;
            num = 0;
          }
          else if (num <= 10)
            ++num;
          else
            break;
        }
      }
      catch (Exception ex)
      {
        MGASystems.IMS.Excel.Logging.Log.WriteAction(ex, "FileOpenTraceThread unexpected exception");
      }
    }
    MGASystems.IMS.Excel.Logging.Log.WriteAction("FileOpenTraceThread Ended");
  }

  private void FileOpenTraceThreadCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    if (!this.detectedFileLock)
      MGASystems.IMS.Excel.Logging.Log.WriteAction("ExcelFileTracker.FileOpenTraceThreadCompleted File Lock never detected.");
    MGASystems.IMS.Excel.Logging.Log.WriteAction("FileOpenTraceThreadCompleted Starting");
    if (this.fileSystemWatcher != null)
    {
      this.DeallocateWatcher();
      MGASystems.IMS.Excel.Logging.Log.WriteAction("FileOpenTraceThreadCompleted Notifying Rater");
      this.rater.OnRaterClosed();
    }
    MGASystems.IMS.Excel.Logging.Log.WriteAction("FileOpenTraceThreadCompleted Ended");
  }

  private void InvokeSaveDialogOnUIThread()
  {
    if (this.synchronizer is Dispatcher synchronizer)
    {
      Action<object> method = (Action<object>) (args =>
      {
        MGASystems.IMS.Excel.Logging.Log.WriteAction("fileSystemWatcher_Renamed Displaying Save Dialog");
        this.DisplaySaveOptions((string) args);
      });
      object[] objArray = new object[1]
      {
        (object) Path.GetFileName(this.ratingData.ExcelFile.FullPath)
      };
      synchronizer.BeginInvoke((Delegate) method, objArray);
    }
    else
    {
      MGASystems.IMS.Excel.Logging.Log.WriteAction("fileSystemWatcher_Renamed_Or_Changed Could not resolve synchronization object");
      throw new InvalidOperationException("Could not resolve synchronization object");
    }
  }

  private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
  {
    this.InvokeSaveDialogOnUIThread();
  }

  private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
  {
    this.InvokeSaveDialogOnUIThread();
    MGASystems.IMS.Excel.Logging.Log.WriteAction("fileSystemWatcher_Renamed Ended");
  }

  public void DisplaySaveOptions(string fileName)
  {
    ExcelFileTracker.DisplaySaveOptions(fileName, this.ratingData, this.rater);
  }

  public static void DisplaySaveOptions(
    string fileName,
    ExcelStandardRatingData ratingData,
    ExcelRater excelRater)
  {
    if (excelRater != null)
    {
      if (!ExcelFileTracker.excelSecurityOverride.CanSaveSheetOnBoundQuote(excelRater))
        return;
      if (!Security.CanSaveSheetOnIssuedQuote(excelRater.RaterID))
      {
        if (excelRater.Quote.IsEndorsement && excelRater.Quote.IsBound)
        {
          if (new Quote((Guid) DefaultDatabase.ExecuteScalar(CommandType.Text, "select QuoteGuid from tblQuotes where ControlNo = @ControlNo and OriginalQuoteGuid is null", new object[2]
          {
            (object) "@ControlNo",
            (object) excelRater.Quote.ControlNo
          })).IsIssued)
          {
            int num = (int) MessageBox.Show("Changes made to a spreadsheet on an Issued quote cannot be saved back into the IMS.", "Unable to save to IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
        }
        else if (excelRater.Quote.IsIssued)
        {
          int num = (int) MessageBox.Show("Changes made to a spreadsheet on an Issued quote cannot be saved back into the IMS.", "Unable to save to IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
      }
    }
    DisplayUI.DisplayExternalExcelSaveOptions(ratingData, excelRater);
  }

  private void DeallocateWatcher()
  {
    try
    {
      if (this.fileSystemWatcher == null)
        return;
      this.fileSystemWatcher.EnableRaisingEvents = false;
      this.fileSystemWatcher.Error -= new ErrorEventHandler(this.FileSystemWatcher_Error);
      this.fileSystemWatcher.Renamed -= new RenamedEventHandler(this.FileSystemWatcher_Renamed);
      this.fileSystemWatcher.Changed -= new FileSystemEventHandler(this.FileSystemWatcher_Changed);
      this.fileSystemWatcher.Dispose();
      this.fileSystemWatcher = (FileSystemWatcher) null;
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
    }
  }
}
