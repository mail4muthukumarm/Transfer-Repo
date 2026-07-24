// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.ApplicationEvents.ApplicationEventManager
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Forms.ApplicationEvents;

public class ApplicationEventManager : IDisposable
{
  private static ApplicationEventManager _applicationEventManager;
  private List<IApplicationEvents> _applicationEventListeners;

  public static ApplicationEventManager Instance
  {
    get
    {
      if (ApplicationEventManager._applicationEventManager == null)
        ApplicationEventManager._applicationEventManager = new ApplicationEventManager();
      return ApplicationEventManager._applicationEventManager;
    }
  }

  private List<IApplicationEvents> ApplicationEventListeners
  {
    get
    {
      if (this._applicationEventListeners == null)
      {
        this._applicationEventListeners = new List<IApplicationEvents>();
        Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new ApplicationEventsListenerAttribute());
        int index = 0;
        while (index < typeArray.Length)
        {
          this._applicationEventListeners.Add((IApplicationEvents) ObjectFactory.Instance.CreateObject(typeArray[index], typeof (IApplicationEvents)));
          checked { ++index; }
        }
      }
      return this._applicationEventListeners;
    }
  }

  public void NotifyStartup()
  {
    try
    {
      foreach (IApplicationEvents applicationEventListener in this.ApplicationEventListeners)
        applicationEventListener.StartUp();
    }
    finally
    {
      List<IApplicationEvents>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public bool NotifyShutdown()
  {
    CancelEventArgs cancelEventArgs = new CancelEventArgs();
    bool flag;
    try
    {
      foreach (IApplicationEvents applicationEventListener in this.ApplicationEventListeners)
      {
        cancelEventArgs.Cancel = false;
        CancelEventArgs e = cancelEventArgs;
        applicationEventListener.QueryShutDown((object) this, e);
        if (cancelEventArgs.Cancel)
        {
          flag = true;
          goto label_11;
        }
      }
    }
    finally
    {
      List<IApplicationEvents>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (IApplicationEvents applicationEventListener in this.ApplicationEventListeners)
        applicationEventListener.ShutDown();
    }
    finally
    {
      List<IApplicationEvents>.Enumerator enumerator;
      enumerator.Dispose();
    }
    flag = false;
label_11:
    return flag;
  }

  public void Dispose()
  {
    try
    {
      foreach (IDisposable applicationEventListener in this._applicationEventListeners)
        applicationEventListener.Dispose();
    }
    finally
    {
      List<IApplicationEvents>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this._applicationEventListeners.Clear();
    this._applicationEventListeners = (List<IApplicationEvents>) null;
  }
}
