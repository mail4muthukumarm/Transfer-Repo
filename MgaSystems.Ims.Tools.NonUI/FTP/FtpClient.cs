// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Tools.NonUI.FileTransfer.Ftp.FtpClient
// Assembly: MgaSystems.Ims.Tools.NonUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3C7A706E-5725-406E-877A-EB3C164B7042
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.Ims.Tools.NonUI.dll

using FluentFTP;
using MgaSystems.Ims.Tools.NonUI.FileTransfer.FTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Authentication;

#nullable disable
namespace MgaSystems.Ims.Tools.NonUI.FileTransfer.Ftp;

public class FtpClient : IDisposable
{
  private readonly FtpClient _ftpClient;

  public FtpEncryptionMode EncryptionMode { get; set; }

  public SslProtocols SslProtocols { get; set; } = SslProtocols.Default;

  public int ConnectionTimeout { get; set; } = 15000;

  internal FtpClient(FtpClient ftpClient) => this._ftpClient = ftpClient;

  public FtpClient()
    : this(new FtpClient())
  {
  }

  public FtpClient(string host)
    : this(new FtpClient(host))
  {
  }

  public FtpClient(string host, NetworkCredential credential)
    : this(new FtpClient(host, credential))
  {
  }

  public FtpClient(string host, int port, NetworkCredential credential)
    : this(new FtpClient(host, port, credential))
  {
  }

  public FtpClient(string host, string userName, string password)
    : this(new FtpClient(host, userName, password))
  {
  }

  public FtpClient(string host, int port, string userName, string password)
    : this(new FtpClient(host, port, userName, password))
  {
  }

  public void Dispose() => this.Dispose(true);

  protected virtual void Dispose(bool disposing)
  {
    if (!disposing || this._ftpClient == null)
      return;
    this._ftpClient.Dispose();
  }

  private void Disconnect()
  {
    if (!this._ftpClient.IsConnected)
      return;
    this._ftpClient.Disconnect();
  }

  private void Connect()
  {
    switch (this.EncryptionMode)
    {
      case FtpEncryptionMode.Implicit:
        this._ftpClient.EncryptionMode = (FtpEncryptionMode) 1;
        break;
      case FtpEncryptionMode.Explicit:
        this._ftpClient.EncryptionMode = (FtpEncryptionMode) 2;
        break;
      default:
        this._ftpClient.EncryptionMode = (FtpEncryptionMode) 0;
        break;
    }
    this._ftpClient.SslProtocols = this.SslProtocols;
    this._ftpClient.ConnectTimeout = this.ConnectionTimeout;
    this._ftpClient.Connect();
  }

  private bool ShouldAttemptConnection(List<string> srcFilePaths)
  {
    return srcFilePaths != null && srcFilePaths.Count > 0;
  }

  public TransferResults UploadFile(string srcFilePath, string dstFolderPath, bool canOverwrite = true)
  {
    return this.UploadFiles(new List<string>()
    {
      srcFilePath
    }, dstFolderPath, canOverwrite);
  }

  public TransferResults UploadFiles(
    List<string> srcFilePaths,
    string dstFolderPath,
    bool canOverwrite = true)
  {
    srcFilePaths.RemoveAll(new Predicate<string>(string.IsNullOrWhiteSpace));
    TransferResults transferResults = new TransferResults(srcFilePaths, nameof (UploadFiles));
    if (this.ShouldAttemptConnection(srcFilePaths))
    {
      try
      {
        this.Connect();
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            using (Stream stream = (Stream) System.IO.File.OpenRead(operation.Key))
            {
              string fileName = Path.GetFileName(operation.Key);
              this._ftpClient.Upload(stream, Path.Combine(dstFolderPath, fileName).Replace('\\', '/'), canOverwrite ? (FtpExists) 2 : (FtpExists) 1, false, (IProgress<double>) null);
              operation.Value.OperationStatus = TransferStatus.Success;
            }
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
      catch (Exception ex)
      {
        transferResults.Operations[srcFilePaths[0]].CaughtException = ex;
      }
      finally
      {
        this.Disconnect();
      }
    }
    return transferResults;
  }

  public TransferResults UploadFolder(
    string srcFolderPath,
    string dstFolderPath,
    bool canOverwrite = true)
  {
    return this.UploadFiles(((IEnumerable<string>) Directory.GetFiles(srcFolderPath)).ToList<string>(), dstFolderPath, canOverwrite);
  }

  public TransferResults DownloadFile(string srcFilePath, string dstFolderPath)
  {
    return this.DownloadFiles(new List<string>()
    {
      srcFilePath
    }, dstFolderPath);
  }

  public TransferResults DownloadFiles(List<string> srcFilePaths, string dstFolderPath)
  {
    TransferResults transferResults = new TransferResults(srcFilePaths, nameof (DownloadFiles));
    if (this.ShouldAttemptConnection(srcFilePaths))
    {
      try
      {
        this.Connect();
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            using (MemoryStream memoryStream = new MemoryStream())
            {
              this._ftpClient.Download((Stream) memoryStream, dstFolderPath, (IProgress<double>) null);
              string fileName = Path.GetFileName(operation.Key);
              System.IO.File.WriteAllBytes(Path.Combine(dstFolderPath, fileName), memoryStream.ToArray());
              operation.Value.OperationStatus = TransferStatus.Success;
            }
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
      catch (Exception ex)
      {
        transferResults.Operations[srcFilePaths[0]].CaughtException = ex;
      }
      finally
      {
        this.Disconnect();
      }
    }
    return transferResults;
  }

  public TransferResults DownloadAllFiles(string srcFolderPath, string dstFolderPath)
  {
    List<string> filesInFolder;
    TransferResults fileNamesInFolder = this.GetFileNamesInFolder(srcFolderPath, out filesInFolder);
    return fileNamesInFolder.HasErrors ? fileNamesInFolder : this.DownloadFiles(filesInFolder, dstFolderPath);
  }

  public TransferResults DeleteFile(string filePath)
  {
    return this.DeleteFiles(new List<string>() { filePath });
  }

  public TransferResults DeleteFiles(List<string> srcFilePaths)
  {
    TransferResults transferResults = new TransferResults(srcFilePaths, nameof (DeleteFiles));
    if (this.ShouldAttemptConnection(srcFilePaths))
    {
      try
      {
        this.Connect();
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            this._ftpClient.DeleteFile(operation.Key);
            operation.Value.OperationStatus = TransferStatus.Success;
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
      catch (Exception ex)
      {
        transferResults.Operations[srcFilePaths[0]].CaughtException = ex;
      }
      finally
      {
        this.Disconnect();
      }
    }
    return transferResults;
  }

  public TransferResults DeleteAllFiles(string srcFolderPath)
  {
    List<string> filesInFolder;
    TransferResults fileNamesInFolder = this.GetFileNamesInFolder(srcFolderPath, out filesInFolder);
    return fileNamesInFolder.HasErrors ? fileNamesInFolder : this.DeleteFiles(filesInFolder);
  }

  public TransferResults GetFileNamesInFolder(string srcFolderPath, out List<string> filesInFolder)
  {
    List<string> stringList = new List<string>()
    {
      srcFolderPath
    };
    TransferResults fileNamesInFolder = new TransferResults(stringList, nameof (GetFileNamesInFolder));
    filesInFolder = new List<string>();
    if (this.ShouldAttemptConnection(stringList))
    {
      try
      {
        this.Connect();
        foreach (KeyValuePair<string, TransferOperation> operation in fileNamesInFolder.Operations)
        {
          try
          {
            filesInFolder = ((IEnumerable<string>) this._ftpClient.GetNameListing(srcFolderPath)).ToList<string>();
            operation.Value.OperationStatus = TransferStatus.Success;
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
      catch (Exception ex)
      {
        fileNamesInFolder.Operations[stringList[0]].CaughtException = ex;
      }
      finally
      {
        this.Disconnect();
      }
    }
    return fileNamesInFolder;
  }

  public TransferResults FolderExists(string ftpFolderPath)
  {
    List<string> stringList = new List<string>()
    {
      ftpFolderPath
    };
    TransferResults transferResults = new TransferResults(stringList, nameof (FolderExists));
    if (this.ShouldAttemptConnection(stringList))
    {
      try
      {
        this.Connect();
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            operation.Value.OperationStatus = this._ftpClient.DirectoryExists(operation.Key) ? TransferStatus.Success : TransferStatus.Failure;
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
      catch (Exception ex)
      {
        transferResults.Operations[stringList[0]].CaughtException = ex;
      }
      finally
      {
        this.Disconnect();
      }
    }
    return transferResults;
  }

  public TransferResults CreateFolder(string ftpFolderPath)
  {
    List<string> stringList = new List<string>()
    {
      ftpFolderPath
    };
    TransferResults folder = new TransferResults(stringList, nameof (CreateFolder));
    if (this.ShouldAttemptConnection(stringList))
    {
      try
      {
        this.Connect();
        foreach (KeyValuePair<string, TransferOperation> operation in folder.Operations)
        {
          try
          {
            bool flag = false;
            try
            {
              flag = this._ftpClient.DirectoryExists(operation.Key);
              operation.Value.OperationStatus = flag ? TransferStatus.Success : TransferStatus.Failure;
            }
            catch
            {
            }
            if (!flag)
            {
              this._ftpClient.CreateDirectory(operation.Key);
              operation.Value.OperationStatus = TransferStatus.Success;
            }
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
      catch (Exception ex)
      {
        folder.Operations[stringList[0]].CaughtException = ex;
      }
      finally
      {
        this.Disconnect();
      }
    }
    return folder;
  }

  public TransferResults GetFileNamesInFolder(
    string srcFolderPath,
    out List<AdditionalFileInfo> filesInFolder)
  {
    List<string> stringList = new List<string>()
    {
      srcFolderPath
    };
    TransferResults fileNamesInFolder = new TransferResults(stringList, nameof (GetFileNamesInFolder));
    filesInFolder = new List<AdditionalFileInfo>();
    if (this.ShouldAttemptConnection(stringList))
    {
      try
      {
        this.Connect();
        foreach (KeyValuePair<string, TransferOperation> operation in fileNamesInFolder.Operations)
        {
          try
          {
            foreach (FtpListItem ftpListItem in this._ftpClient.GetListing(srcFolderPath))
              filesInFolder.Add(new AdditionalFileInfo(ftpListItem.FullName, ftpListItem.Modified));
            operation.Value.OperationStatus = TransferStatus.Success;
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
      catch (Exception ex)
      {
        fileNamesInFolder.Operations[stringList[0]].CaughtException = ex;
      }
      finally
      {
        this.Disconnect();
      }
    }
    return fileNamesInFolder;
  }
}
