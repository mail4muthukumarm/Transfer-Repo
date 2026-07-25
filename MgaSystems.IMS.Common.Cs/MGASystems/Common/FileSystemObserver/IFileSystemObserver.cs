// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FileSystemObserver.IFileSystemObserver
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

#nullable disable
namespace MGASystems.Common.FileSystemObserver;

public interface IFileSystemObserver
{
  event FileSystemEvent ChangedEvent;

  event FileSystemEvent CreatedEvent;

  event FileSystemEvent DeletedEvent;

  event FileSystemRenameEvent RenamedEvent;

  void Start();

  void Stop();
}
