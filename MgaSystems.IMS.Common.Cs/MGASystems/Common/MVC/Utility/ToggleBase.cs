// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.Utility.ToggleBase
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;

#nullable disable
namespace MGASystems.Common.MVC.Utility;

public abstract class ToggleBase : IToggleable
{
  private bool _isEnabled;

  protected ToggleBase(bool isEnabled) => this._isEnabled = isEnabled;

  public bool IsEnabled => this._isEnabled;

  public event Action<bool> EnabledChanged;

  public void Disable()
  {
    if (!this.IsEnabled)
      throw new InvalidOperationException("Cannot disable while already disabled.");
    this._isEnabled = false;
    this.ChildDisable();
    Action<bool> enabledChanged = this.EnabledChanged;
    if (enabledChanged == null)
      return;
    enabledChanged(this._isEnabled);
  }

  public void Enable()
  {
    if (this.IsEnabled)
      throw new InvalidOperationException("Cannot disable while already disabled.");
    this._isEnabled = true;
    this.ChildEnable();
    Action<bool> enabledChanged = this.EnabledChanged;
    if (enabledChanged == null)
      return;
    enabledChanged(this._isEnabled);
  }

  public void Toggle()
  {
    if (this._isEnabled)
      this.Disable();
    else
      this.Enable();
  }

  public void DisableIfEnabled()
  {
    if (!this._isEnabled)
      return;
    this.Disable();
  }

  public void EnableIfDisabled()
  {
    if (this._isEnabled)
      return;
    this.Enable();
  }

  public void SetState(bool enabled)
  {
    if (enabled)
      this.Enable();
    else
      this.Disable();
  }

  public void SetStateIfNotAlready(bool enabled)
  {
    if (enabled)
      this.EnableIfDisabled();
    else
      this.DisableIfEnabled();
  }

  protected abstract void ChildEnable();

  protected abstract void ChildDisable();
}
