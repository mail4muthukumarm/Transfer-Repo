// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses.ButtonBaseToolbarControl`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;

public abstract class ButtonBaseToolbarControl<TButton> : ToolbarControlBase<TButton> where TButton : ToolBase
{
  private readonly Action _onClick;

  protected ButtonBaseToolbarControl(string caption, Action onClick, object image = null)
    : base(caption, image)
  {
    this._onClick = onClick ?? throw new ArgumentNullException(nameof (onClick));
  }

  protected ButtonBaseToolbarControl(
    string identifier,
    string caption,
    Action onClick,
    object image = null)
    : base(identifier, caption, image)
  {
    this._onClick = onClick ?? throw new ArgumentNullException(nameof (onClick));
  }

  public virtual void Click() => this._onClick();

  protected override void AttachListeners(UltraToolbarsManager toolbarManager)
  {
    toolbarManager.ToolClick += new ToolClickEventHandler(this.ToolBarManager_ToolClick);
  }

  private void ToolBarManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (!((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.Equals(base.UniqueIdentifier))
      return;
    this.Click();
  }
}
