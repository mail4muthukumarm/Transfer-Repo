// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FileSystemObserver.ExcelFileTracker
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Common.FileIO;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;

#nullable disable
namespace MGASystems.Common.FileSystemObserver;

public class ExcelFileTracker
{
  private readonly string filePath;
  private bool excelFileOpened;
  private Process process;
  private FileSystemWatcher fileSystemWatcher;
  private bool detectedFileLock;
  private int watcherReconnectAttempts;
  private string copyFileName;

  public event FileSystemEvent ChangedEvent;

  public event FileSystemEvent ClosedEvent;

  public ExcelFileTracker(string filepth) => this.filePath = filepth;

  public void ShowExcelSheet() => this.OpenExcelFile();

  private void ExcelFile_PropertyChanged(object sender, PropertyChangedEventArgs e)
  {
    if (!(e.PropertyName == "FullPath"))
      return;
    this.OpenExcelFile();
  }

  private void OpenExcelFile()
  {
    this.copyFileName = FilePath.Resolve($"{MGATempFolder.MGATempPath}{Path.GetFileNameWithoutExtension(this.filePath)}-copy{Path.GetExtension(this.filePath)}");
    File.Copy(this.filePath, this.copyFileName, true);
    if (this.excelFileOpened)
      return;
    this.excelFileOpened = true;
    this.process = new Process();
    this.process.StartInfo.FileName = "EXCEL.EXE";
    this.process.StartInfo.UseShellExecute = true;
    this.process.StartInfo.Arguments = $"\"{this.filePath}\"";
    try
    {
      this.process.Start();
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show("Error Starting Excel going to request UAC elevation as a test. Please contact Technical support");
      this.process.StartInfo.Verb = "runas";
      this.process.StartInfo.WorkingDirectory = Path.GetDirectoryName(this.filePath);
      this.process.Start();
    }
    this.AllocateWatcher();
    Utility.ExecuteThread(new DoWorkEventHandler(this.FileOpenTraceThread), new RunWorkerCompletedEventHandler(this.FileOpenTraceThreadCompleted), (ProgressChangedEventHandler) null);
  }

  private void AllocateWatcher()
  {
    string filter = "*" + Path.GetExtension(this.filePath);
    this.fileSystemWatcher = new FileSystemWatcher(Path.GetDirectoryName(this.filePath), filter)
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

  private static bool IsFileLocked(string fileName)
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
    Thread.Sleep(TimeSpan.FromSeconds(5.0));
    int num = 0;
    while (true)
    {
      Thread.Sleep(TimeSpan.FromSeconds(1.0));
      try
      {
        if (File.Exists(this.filePath))
        {
          if (ExcelFileTracker.IsFileLocked(this.filePath))
          {
            this.detectedFileLock = true;
            num = 0;
          }
          else
          {
            if (num > 5)
              break;
            ++num;
          }
        }
      }
      catch (Exception ex)
      {
        ErrorHandler.SilentHandleError(ex);
      }
    }
  }

  private void FileOpenTraceThreadCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    if (!this.detectedFileLock)
      ErrorHandler.SilentHandleError((Exception) new InvalidOperationException("Common.ExcelFileTracker.FileOpenTraceThreadCompleted File Lock never detected."));
    if (this.fileSystemWatcher == null)
      return;
    this.DeallocateWatcher();
    FileSystemEvent closedEvent = this.ClosedEvent;
    if (closedEvent == null)
      return;
    closedEvent(this.filePath);
  }

  private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
  {
    FileSystemEvent changedEvent = this.ChangedEvent;
    if (changedEvent == null)
      return;
    changedEvent(e.FullPath);
  }

  private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
  {
    FileSystemEvent changedEvent = this.ChangedEvent;
    if (changedEvent == null)
      return;
    changedEvent(e.FullPath);
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

  public void RevertToOriginalFile() => File.Copy(this.copyFileName, this.filePath, true);
}
