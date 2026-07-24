// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Controller.AutoSizingControlStackNonModelController`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Controller;

public abstract class AutoSizingControlStackNonModelController<TDisplayItem> : 
  ControlStackNonModelController<TDisplayItem>,
  ITopControlController,
  IMvcController
  where TDisplayItem : class
{
  private readonly string _formDisplayName;

  protected virtual int FormHeaderAndBottomPaddingPixelSize => 31 /*0x1F*/;

  protected virtual int LeftRightPaddingPixelSize => 6;

  protected virtual ShortcutAction[] ShortcutActions
  {
    get
    {
      return new ShortcutAction[3]
      {
        ShortcutAction.CreateSave(new Action(((ControlStackController<IControlStackObjectAdapterModel<TDisplayItem>, IControlStackView>) this).RequestSave)),
        ShortcutAction.CreateReset(new Action(((ControlStackController<IControlStackObjectAdapterModel<TDisplayItem>, IControlStackView>) this).RequestReset)),
        ShortcutAction.CreateCancel((Action) (() => this.View.RequestCloseForm(DialogResult.Abort)))
      };
    }
  }

  public bool IsMaximizeable { get; set; }

  protected AutoSizingControlStackNonModelController(string formDisplayName)
  {
    this._formDisplayName = formDisplayName ?? throw new ArgumentNullException(nameof (formDisplayName));
  }

  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Height = (this.IdealControlHeight + this.FormHeaderAndBottomPaddingPixelSize),
        Width = (this.IdealControlWidth + this.LeftRightPaddingPixelSize),
        Name = this._formDisplayName,
        BorderStyle = FormBorderStyle.Sizable,
        Maximizeable = this.IsMaximizeable,
        ShortcutActions = this.ShortcutActions
      };
    }
  }

  public abstract IToolbarItem[] GetToolBarItems();
}
