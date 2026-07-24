// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit.MultiLineTextEditController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.Utility;
using MGASystems.IMS.Accounting.Services.Properties;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit;

public class MultiLineTextEditController : 
  MvcControllerBase<MultiLineTextEditModel, MultiLineTextEditView>,
  ITopControlController,
  IMvcController,
  ISaveDataController
{
  private readonly int width;
  private readonly int height;
  private readonly string title;

  public MultiLineTextEditController(int width, int height, string title)
  {
    this.width = width;
    this.height = height;
    this.title = title;
  }

  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Width = this.width,
        Height = this.height,
        Name = this.title,
        Maximizeable = true,
        BorderStyle = FormBorderStyle.Sizable,
        ShortcutActions = new ShortcutAction[3]
        {
          ShortcutAction.CreateSave(new Action(this.RequestSave)),
          ShortcutAction.CreateReset(new Action(this.RequestReset)),
          ShortcutAction.CreateCancel((Action) (() => this.View.RequestCloseForm(DialogResult.Abort)))
        }
      };
    }
  }

  public IToolbarItem[] GetToolBarItems()
  {
    return new IToolbarItem[2]
    {
      (IToolbarItem) ToolbarItemFactory.CreateSaveButton((ISaveDataController) this, image: (object) Resources.disk),
      (IToolbarItem) ToolbarItemFactory.CreateResetButton((ISaveDataController) this, "Discard", (object) Resources.cross)
    };
  }

  public void RequestReset()
  {
    this.Model.ResetChanges();
    this.View.RequestCloseForm(DialogResult.Abort);
  }

  public void RequestSave()
  {
    this.Model.SaveChanges();
    this.View.RequestCloseForm(DialogResult.OK);
  }

  public void RequestSetText(string text) => this.Model.MultiLineText = text;
}
