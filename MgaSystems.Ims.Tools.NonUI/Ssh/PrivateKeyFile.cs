// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Tools.NonUI.FileTransfer.SSH.PrivateKeyFile
// Assembly: MgaSystems.Ims.Tools.NonUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3C7A706E-5725-406E-877A-EB3C164B7042
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.Ims.Tools.NonUI.dll

using Renci.SshNet;
using System;
using System.IO;

#nullable disable
namespace MgaSystems.Ims.Tools.NonUI.FileTransfer.SSH;

public class PrivateKeyFile : IDisposable
{
  public readonly PrivateKeyFile _privateKeyFile;

  public PrivateKeyFile(Stream privateKey) => this._privateKeyFile = new PrivateKeyFile(privateKey);

  public PrivateKeyFile(string fileName) => this._privateKeyFile = new PrivateKeyFile(fileName);

  public PrivateKeyFile(string fileName, string passPhrase)
  {
    this._privateKeyFile = new PrivateKeyFile(fileName, passPhrase);
  }

  public PrivateKeyFile(Stream privateKey, string passPhrase)
  {
    this._privateKeyFile = new PrivateKeyFile(privateKey, passPhrase);
  }

  public void Dispose() => this.Dispose(true);

  protected virtual void Dispose(bool disposing)
  {
    if (!disposing)
      return;
    this._privateKeyFile.Dispose();
  }
}
