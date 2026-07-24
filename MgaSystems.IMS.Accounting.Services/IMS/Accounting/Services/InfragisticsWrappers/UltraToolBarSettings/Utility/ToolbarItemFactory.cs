// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.Utility.ToolbarItemFactory
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using MGASystems.IMS.Accounting.Services.Properties;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.Utility;

public static class ToolbarItemFactory
{
  public static ButtonToolbarControl CreateSaveButton(
    ISaveDataController controller,
    string caption = "Save",
    object image = null)
  {
    return new ButtonToolbarControl(caption, (Action) (() =>
    {
      controller.UnSetViewFocus();
      controller.RequestSave();
    }), image ?? (object) Resources.disk);
  }

  public static ButtonToolbarControl CreateResetButton(
    ISaveDataController controller,
    string caption = "Reset",
    object image = null)
  {
    return new ButtonToolbarControl(caption, (Action) (() =>
    {
      controller.UnSetViewFocus();
      controller.RequestReset();
    }), image ?? (object) Resources.arrow_undo);
  }

  public static IToolbarItem[] GetSaveRestOptions(ISaveDataController controller)
  {
    return new IToolbarItem[1]
    {
      (IToolbarItem) new ToolbarGroup(new IToolbarControl[2]
      {
        (IToolbarControl) ToolbarItemFactory.CreateSaveButton(controller),
        (IToolbarControl) ToolbarItemFactory.CreateResetButton(controller)
      })
    };
  }
}
