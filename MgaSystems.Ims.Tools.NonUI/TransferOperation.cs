// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Tools.NonUI.FileTransfer.TransferOperation
// Assembly: MgaSystems.Ims.Tools.NonUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3C7A706E-5725-406E-877A-EB3C164B7042
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.Ims.Tools.NonUI.dll

using System;

#nullable disable
namespace MgaSystems.Ims.Tools.NonUI.FileTransfer;

public class TransferOperation
{
  private Exception _caughtException;

  internal TransferOperation(string path) => this.Path = path;

  public string Path { get; set; } = string.Empty;

  public TransferStatus OperationStatus { get; set; }

  public Exception CaughtException
  {
    get => this._caughtException;
    internal set
    {
      if (value == null)
        return;
      this._caughtException = value;
      this.OperationStatus = TransferStatus.Failure;
    }
  }
}
