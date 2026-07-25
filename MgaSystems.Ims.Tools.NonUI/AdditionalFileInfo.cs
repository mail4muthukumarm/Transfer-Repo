// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Tools.NonUI.FileTransfer.AdditionalFileInfo
// Assembly: MgaSystems.Ims.Tools.NonUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3C7A706E-5725-406E-877A-EB3C164B7042
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.Ims.Tools.NonUI.dll

using System;

#nullable disable
namespace MgaSystems.Ims.Tools.NonUI.FileTransfer;

public class AdditionalFileInfo
{
  public string RemoteFileName { get; set; } = string.Empty;

  public DateTime? LastAccessTimeRemote { get; set; }

  public DateTime? LastWriteTimeRemote { get; set; }

  public DateTime? LastAccessTimeUtcRemote { get; set; }

  public DateTime? LastWriteTimeUtcRemote { get; set; }

  public AdditionalFileInfo(
    string remoteFileName,
    DateTime lastWriteTimeRemote,
    DateTime? lastWriteTimeUtcRemote = null,
    DateTime? lastAccessTimeRemote = null,
    DateTime? lastAccessTimeUtcRemote = null)
  {
    this.RemoteFileName = remoteFileName;
    this.LastAccessTimeRemote = lastAccessTimeRemote;
    this.LastWriteTimeRemote = new DateTime?(lastWriteTimeRemote);
    this.LastAccessTimeUtcRemote = lastAccessTimeUtcRemote;
    this.LastWriteTimeUtcRemote = lastWriteTimeUtcRemote;
  }
}
