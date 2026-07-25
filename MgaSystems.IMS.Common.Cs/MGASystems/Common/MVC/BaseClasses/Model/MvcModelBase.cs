// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.MvcModelBase
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model;

public abstract class MvcModelBase : IMvcModel
{
  private readonly BlockingRunner _notificationRunner;

  private List<IModelObserver> _observers { get; } = new List<IModelObserver>();

  protected MvcModelBase()
  {
    this._notificationRunner = new BlockingRunner()
    {
      IgnoreInvocationIfRunning = true
    };
  }

  public virtual void AddObserver(IModelObserver observer) => this._observers.Add(observer);

  public virtual void AddObservers(IEnumerable<IModelObserver> observers)
  {
    this._observers.AddRange(observers);
  }

  public virtual void RemoveObserver(IModelObserver observer) => this._observers.Remove(observer);

  public void NotifyObservers()
  {
    this._notificationRunner.Run((Action) (() =>
    {
      this._observers.ForEach((Action<IModelObserver>) (observer => observer.Update((object) this)));
      this.ChildNotifyObservers();
    }));
  }

  protected virtual void ChildNotifyObservers()
  {
  }
}
