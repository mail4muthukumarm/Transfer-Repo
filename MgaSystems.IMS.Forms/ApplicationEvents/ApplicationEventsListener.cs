// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.ApplicationEvents.ApplicationEventsListener
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.IMS.DocumentAutomation;
using System;
using System.ComponentModel;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Forms.ApplicationEvents;

[ApplicationEventsListener]
public class ApplicationEventsListener : IApplicationEvents
{
  public void QueryShutDown(object sender, CancelEventArgs e)
  {
  }

  public void ShutDown()
  {
  }

  public void StartUp()
  {
    new Thread(new ThreadStart(Licensing.LicenseAsposeAssemblies))
    {
      Name = "License Aspose Assemblies"
    }.Start();
  }

  void IDisposable.Dispose()
  {
  }
}
