// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.CheckboxToolbarControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;

public class CheckboxToolbarControl : ButtonBaseToolbarControl<StateButtonTool>
{
  private readonly Action _onUnCheck;
  private readonly bool _isDefaultChecked;

  protected virtual StateButtonToolbarDisplayStyle ButtonStyle
  {
    get => (StateButtonToolbarDisplayStyle) 1;
  }

  public bool IsChecked => this.CreatedInfragisticsTool.Checked;

  public CheckboxToolbarControl(
    string caption,
    Action onCheck,
    Action onUnCheck,
    object image = null,
    bool isDefaultChecked = false)
    : base(caption, onCheck, image)
  {
    this._onUnCheck = onUnCheck ?? throw new ArgumentNullException(nameof (onUnCheck));
    this._isDefaultChecked = isDefaultChecked;
  }

  public CheckboxToolbarControl(
    string identifier,
    string caption,
    Action onCheck,
    Action onUnCheck,
    object image = null,
    bool isDefaultChecked = false)
    : base(identifier, caption, onCheck, image)
  {
    this._onUnCheck = onUnCheck ?? throw new ArgumentNullException(nameof (onUnCheck));
    this._isDefaultChecked = isDefaultChecked;
  }

  public CheckboxToolbarControl(
    string caption,
    Action<bool> onStateChange,
    object image = null,
    bool isDefaultChecked = false)
    : this(caption, (Action) (() => onStateChange(true)), (Action) (() => onStateChange(false)), image, isDefaultChecked)
  {
  }

  public CheckboxToolbarControl(
    string identifier,
    string caption,
    Action<bool> onStateChange,
    object image = null,
    bool isDefaultChecked = false)
    : this(identifier, caption, (Action) (() => onStateChange(true)), (Action) (() => onStateChange(false)), image, isDefaultChecked)
  {
  }

  public CheckboxToolbarControl(
    string caption,
    Action onStateChange,
    object image = null,
    bool isDefaultChecked = false)
    : this(caption, (Action<bool>) (_ => onStateChange()), image, isDefaultChecked)
  {
  }

  public CheckboxToolbarControl(
    string identifier,
    string caption,
    Action onStateChange,
    object image = null,
    bool isDefaultChecked = false)
    : this(identifier, caption, (Action<bool>) (_ => onStateChange()), image, isDefaultChecked)
  {
  }

  public override void Click()
  {
    if (this.CreatedInfragisticsTool.Checked)
      base.Click();
    else
      this._onUnCheck();
  }

  protected override void ChildApplySettingsToInfragisticsTool(StateButtonTool tool)
  {
    tool.ToolbarDisplayStyle = this.ButtonStyle;
    tool.Checked = this._isDefaultChecked;
  }

  protected override StateButtonTool ChildCreateInfragisticsTool()
  {
    return new StateButtonTool(base.UniqueIdentifier);
  }
}
