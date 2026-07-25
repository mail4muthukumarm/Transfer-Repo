// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.Utility.ToggleWrapper
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;

#nullable disable
namespace MGASystems.Common.MVC.Utility;

public class ToggleWrapper : ToggleBase
{
  private readonly Action _enableAction;
  private readonly Action _disableAction;

  public ToggleWrapper(Action enableAction, Action disableAction, bool isEnabled)
    : base(isEnabled)
  {
    this._enableAction = enableAction ?? throw new ArgumentNullException(nameof (enableAction));
    this._disableAction = disableAction ?? throw new ArgumentNullException(nameof (disableAction));
  }

  public ToggleWrapper(Action<bool> toggleAction, bool isEnabled)
    : this((Action) (() => toggleAction(true)), (Action) (() => toggleAction(false)), isEnabled)
  {
  }

  protected override void ChildDisable() => this._disableAction();

  protected override void ChildEnable() => this._enableAction();
}
