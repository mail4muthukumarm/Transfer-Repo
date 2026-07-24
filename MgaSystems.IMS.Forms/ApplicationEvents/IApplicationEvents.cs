// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.ApplicationEvents.IApplicationEvents
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Forms.ApplicationEvents;

public interface IApplicationEvents : IDisposable
{
  void StartUp();

  void QueryShutDown(object sender, CancelEventArgs e);

  void ShutDown();
}
