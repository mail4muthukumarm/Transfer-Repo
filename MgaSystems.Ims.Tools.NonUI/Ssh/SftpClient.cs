// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Tools.NonUI.FileTransfer.Ssh.SftpClient
// Assembly: MgaSystems.Ims.Tools.NonUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3C7A706E-5725-406E-877A-EB3C164B7042
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.Ims.Tools.NonUI.dll

using MgaSystems.Ims.Tools.NonUI.FileTransfer.SSH;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#nullable disable
namespace MgaSystems.Ims.Tools.NonUI.FileTransfer.Ssh;

public class SftpClient : IDisposable
{
  private readonly SftpClient _sftpCient;

  public SftpClient(string host, int port, string username, string password)
  {
    this._sftpCient = new SftpClient(host, port, username, password);
  }

  public SftpClient(string host, string username, string password)
  {
    this._sftpCient = new SftpClient(host, username, password);
  }

  public SftpClient(string host, int port, string username, params PrivateKeyFile[] keyFiles)
  {
    this._sftpCient = new SftpClient(host, port, username, ((IEnumerable<PrivateKeyFile>) keyFiles).Select<PrivateKeyFile, PrivateKeyFile>((Func<PrivateKeyFile, PrivateKeyFile>) (kf => kf._privateKeyFile)).ToArray<PrivateKeyFile>());
  }

  public SftpClient(
    string host,
    int port,
    string username,
    string password,
    PrivateKeyFile keyFile)
  {
    this._sftpCient = new SftpClient(new ConnectionInfo(host, port, username, new AuthenticationMethod[2]
    {
      (AuthenticationMethod) new PasswordAuthenticationMethod(username, password),
      (AuthenticationMethod) new PrivateKeyAuthenticationMethod(username, new PrivateKeyFile[1]
      {
        keyFile?._privateKeyFile
      })
    }));
  }

  public SftpClient(string host, string username, params PrivateKeyFile[] keyFiles)
  {
    this._sftpCient = new SftpClient(host, username, ((IEnumerable<PrivateKeyFile>) keyFiles).Select<PrivateKeyFile, PrivateKeyFile>((Func<PrivateKeyFile, PrivateKeyFile>) (kf => kf._privateKeyFile)).ToArray<PrivateKeyFile>());
  }

  public void Dispose() => this.Dispose(true);

  protected virtual void Dispose(bool disposing)
  {
    if (!disposing || this._sftpCient == null)
      return;
    this.Disconnect();
    ((BaseClient) this._sftpCient).Dispose();
  }

  private bool Connect(List<string> paths, TransferResults transferResults)
  {
    bool flag = false;
    if (paths != null)
    {
      if (paths.Count > 0)
      {
        try
        {
          ((BaseClient) this._sftpCient).Connect();
          flag = true;
        }
        catch (Exception ex)
        {
          transferResults.Operations[paths[0]].CaughtException = ex;
        }
      }
    }
    return flag;
  }

  private void Disconnect()
  {
    if (!((BaseClient) this._sftpCient).IsConnected)
      return;
    ((BaseClient) this._sftpCient).Disconnect();
  }

  public TransferResults UploadFile(
    string srcFilePath,
    string dstFolderPath,
    bool canOverwrite = true,
    Action<ulong> uploadCallback = null)
  {
    return this.UploadFiles(new List<string>()
    {
      srcFilePath
    }, dstFolderPath, canOverwrite, uploadCallback);
  }

  public TransferResults UploadFiles(
    List<string> srcFilePaths,
    string dstFolderPath,
    bool canOverwrite = true,
    Action<ulong> uploadCallback = null)
  {
    do
      ;
    while (srcFilePaths.Remove(string.Empty));
    TransferResults transferResults = new TransferResults(srcFilePaths, nameof (UploadFiles));
    try
    {
      if (this.Connect(srcFilePaths, transferResults))
      {
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            using (Stream stream = (Stream) File.OpenRead(operation.Key))
            {
              string fileName = Path.GetFileName(operation.Key);
              this._sftpCient.UploadFile(stream, Path.Combine(dstFolderPath, fileName).Replace('\\', '/'), canOverwrite, uploadCallback);
              operation.Value.OperationStatus = TransferStatus.Success;
            }
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
    }
    finally
    {
      this.Disconnect();
    }
    return transferResults;
  }

  public TransferResults UploadFolder(
    string srcFolderPath,
    string dstFolderPath,
    bool canOverwrite = true,
    Action<ulong> uploadCallback = null)
  {
    return this.UploadFiles(((IEnumerable<string>) Directory.GetFiles(srcFolderPath)).ToList<string>(), dstFolderPath, canOverwrite, uploadCallback);
  }

  public TransferResults DownloadFile(
    string srcFilePath,
    string dstFolderPath,
    Action<ulong> downloadCallback = null)
  {
    return this.DownloadFiles(new List<string>()
    {
      srcFilePath
    }, dstFolderPath, downloadCallback);
  }

  public TransferResults DownloadFiles(
    List<string> srcFilePaths,
    string dstFolderPath,
    Action<ulong> downloadCallback = null)
  {
    TransferResults transferResults = new TransferResults(srcFilePaths, nameof (DownloadFiles));
    try
    {
      if (this.Connect(srcFilePaths, transferResults))
      {
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            using (MemoryStream memoryStream = new MemoryStream())
            {
              this._sftpCient.DownloadFile(operation.Key, (Stream) memoryStream, downloadCallback);
              string fileName = Path.GetFileName(operation.Key);
              File.WriteAllBytes(Path.Combine(dstFolderPath, fileName), memoryStream.ToArray());
              operation.Value.OperationStatus = TransferStatus.Success;
            }
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
    }
    finally
    {
      this.Disconnect();
    }
    return transferResults;
  }

  public TransferResults DownloadAllFiles(
    string srcFolderPath,
    string dstFolderPath,
    Action<ulong> downloadCallback = null)
  {
    List<string> filesInFolder;
    TransferResults fileNamesInFolder = this.GetFileNamesInFolder(srcFolderPath, out filesInFolder);
    return fileNamesInFolder.HasErrors ? fileNamesInFolder : this.DownloadFiles(filesInFolder, dstFolderPath, downloadCallback);
  }

  public TransferResults DeleteFile(string filePath)
  {
    return this.DeleteFiles(new List<string>() { filePath });
  }

  public TransferResults DeleteFiles(List<string> srcFilePaths)
  {
    TransferResults transferResults = new TransferResults(srcFilePaths, nameof (DeleteFiles));
    try
    {
      if (this.Connect(srcFilePaths, transferResults))
      {
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            this._sftpCient.DeleteFile(operation.Key);
            operation.Value.OperationStatus = TransferStatus.Success;
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
    }
    finally
    {
      this.Disconnect();
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
    List<string> paths = new List<string>()
    {
      srcFolderPath
    };
    TransferResults transferResults = new TransferResults(paths, nameof (GetFileNamesInFolder));
    filesInFolder = new List<string>();
    try
    {
      if (this.Connect(paths, transferResults))
      {
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            foreach (SftpFile sftpFile in this._sftpCient.ListDirectory(operation.Key, (Action<int>) null))
            {
              if (!sftpFile.IsDirectory)
                filesInFolder.Add(sftpFile.FullName);
            }
            operation.Value.OperationStatus = TransferStatus.Success;
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
    }
    finally
    {
      this.Disconnect();
    }
    return transferResults;
  }

  public TransferResults FolderExists(string ftpFolderPath)
  {
    List<string> paths = new List<string>()
    {
      ftpFolderPath
    };
    TransferResults transferResults = new TransferResults(paths, nameof (FolderExists));
    try
    {
      if (this.Connect(paths, transferResults))
      {
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            this._sftpCient.ChangeDirectory(operation.Key);
            operation.Value.OperationStatus = TransferStatus.Success;
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
    }
    finally
    {
      this.Disconnect();
    }
    return transferResults;
  }

  public TransferResults CreateFolder(string ftpFolderPath)
  {
    List<string> paths = new List<string>()
    {
      ftpFolderPath
    };
    TransferResults transferResults = new TransferResults(paths, nameof (CreateFolder));
    try
    {
      if (this.Connect(paths, transferResults))
      {
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            bool flag = false;
            try
            {
              this._sftpCient.ChangeDirectory(operation.Key);
              operation.Value.OperationStatus = TransferStatus.Success;
              flag = true;
            }
            catch
            {
            }
            if (!flag)
            {
              this._sftpCient.CreateDirectory(operation.Key);
              operation.Value.OperationStatus = TransferStatus.Success;
            }
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
    }
    finally
    {
      this.Disconnect();
    }
    return transferResults;
  }

  public TransferResults GetFileNamesInFolder(
    string srcFolderPath,
    out List<AdditionalFileInfo> filesInFolder)
  {
    List<string> paths = new List<string>()
    {
      srcFolderPath
    };
    TransferResults transferResults = new TransferResults(paths, nameof (GetFileNamesInFolder));
    filesInFolder = new List<AdditionalFileInfo>();
    try
    {
      if (this.Connect(paths, transferResults))
      {
        foreach (KeyValuePair<string, TransferOperation> operation in transferResults.Operations)
        {
          try
          {
            foreach (SftpFile sftpFile in this._sftpCient.ListDirectory(operation.Key, (Action<int>) null))
            {
              if (!sftpFile.IsDirectory)
                filesInFolder.Add(new AdditionalFileInfo(sftpFile.FullName, sftpFile.LastWriteTime, new DateTime?(sftpFile.LastWriteTimeUtc), new DateTime?(sftpFile.LastAccessTime), new DateTime?(sftpFile.LastAccessTimeUtc)));
            }
            operation.Value.OperationStatus = TransferStatus.Success;
          }
          catch (Exception ex)
          {
            operation.Value.CaughtException = ex;
          }
        }
      }
    }
    finally
    {
      this.Disconnect();
    }
    return transferResults;
  }
}
