// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FluentFtpFileOperation
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using FluentFTP;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net;
using System.Security.Authentication;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class FluentFtpFileOperation
{
  public static void UploadSingleFile(
    string fileToUpload,
    string uploadFileName,
    string ftpsHost,
    string un,
    string pw,
    int port,
    string folderDestination)
  {
    using (FtpClient ftpClient = new FtpClient(ftpsHost))
    {
      ftpClient.Credentials = new NetworkCredential(un, pw);
      ftpClient.SslProtocols = SslProtocols.Tls12;
      ftpClient.EncryptionMode = (FtpEncryptionMode) 1;
      if (port != -1)
        ftpClient.Port = port;
      ftpClient.Connect();
      ftpClient.UploadFile(fileToUpload, folderDestination + uploadFileName, (FtpExists) 2, false, (FtpVerify) 0, (IProgress<double>) null);
    }
  }
}
