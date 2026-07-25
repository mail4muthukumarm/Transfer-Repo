// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.SyncProgress`1
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public class SyncProgress<T> : IProgress<T>
{
  private Action<T> ProgressHandler { get; }

  public SyncProgress(Action<T> handler) => this.ProgressHandler = handler;

  public void Report(T value) => this.ProgressHandler(value);

  void IProgress<T>.Report(T value) => this.Report(value);

  public static IProgress<T> FromAction(Action<T> action)
  {
    return (IProgress<T>) new SyncProgress<T>(action);
  }
}
