// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.ToggleButtonToolbarControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinToolbars;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;

public class ToggleButtonToolbarControl : CheckboxToolbarControl
{
  protected override StateButtonToolbarDisplayStyle ButtonStyle
  {
    get => (StateButtonToolbarDisplayStyle) 0;
  }

  public ToggleButtonToolbarControl(
    string caption,
    Action onCheck,
    Action onUnCheck,
    object image = null,
    bool isDefaultChecked = false)
    : base(caption, onCheck, onUnCheck, image, isDefaultChecked)
  {
  }

  public ToggleButtonToolbarControl(
    string caption,
    Action<bool> onStateChange,
    object image = null,
    bool isDefaultChecked = false)
    : base(caption, onStateChange, image, isDefaultChecked)
  {
  }

  public ToggleButtonToolbarControl(
    string caption,
    Action onStateChange,
    object image = null,
    bool isDefaultChecked = false)
    : base(caption, onStateChange, image, isDefaultChecked)
  {
  }
}
