// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.InfragisticsExtensions.InfragisticsExtensions
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.Tools.InfragisticsExtensions;

[StandardModule]
public sealed class InfragisticsExtensions
{
  public static PopupMenuTool FindPopupMenu(this UltraToolbarsManager menu, string menuKey)
  {
    return menu.FindTool(menuKey) as PopupMenuTool;
  }

  public static ButtonTool FindButton(this UltraToolbarsManager menu, string menuKey)
  {
    return menu.FindTool(menuKey) as ButtonTool;
  }

  public static ToolBase FindTool(this UltraToolbarsManager menu, string menuKey)
  {
    return menu != null && ((ToolsCollectionBase) menu.Tools).Exists(menuKey) ? ((ToolsCollectionBase) menu.Tools)[menuKey] : (ToolBase) null;
  }

  public static PopupMenuTool FindPopupMenu(this PopupMenuTool popup, string menuKey)
  {
    return popup.FindTool(menuKey) as PopupMenuTool;
  }

  public static ButtonTool FindButton(this PopupMenuTool popup, string menuKey)
  {
    return popup.FindTool(menuKey) as ButtonTool;
  }

  public static ToolBase FindTool(this PopupMenuTool popup, string menuKey)
  {
    return popup != null && ((ToolsCollectionBase) popup.Tools).Exists(menuKey) ? ((ToolsCollectionBase) popup.Tools)[menuKey] : (ToolBase) null;
  }

  public static void FindMergedTool(
    this UltraToolbarsManager ultraToolbarsManager,
    string key,
    Action<ToolBase> onMergedToolFound)
  {
    UltraToolbarsManager ultraToolbarsManager1 = ultraToolbarsManager;
    string str = key;
    Action<ToolBase> action = onMergedToolFound;
    ultraToolbarsManager1.RefreshMerge();
    if (((ToolsCollectionBase) ultraToolbarsManager1.MergedTools).Count == 0)
    {
      SubObjectPropChangeEventHandler changeEventHandler = (SubObjectPropChangeEventHandler) null;
      changeEventHandler = (SubObjectPropChangeEventHandler) ([SpecialName] (propChange) =>
      {
        if (!((ToolsCollectionBase) ultraToolbarsManager.MergedTools).Exists(key))
          return;
        ((SubObjectBase) ultraToolbarsManager.MergedTools).SubObjectPropChanged -= changeEventHandler;
        Action<ToolBase> action1 = onMergedToolFound;
        if (action1 == null)
          return;
        action1(((ToolsCollectionBase) ultraToolbarsManager.MergedTools)[key]);
      });
      ((SubObjectBase) ultraToolbarsManager.MergedTools).SubObjectPropChanged += changeEventHandler;
    }
    else
    {
      if (!((ToolsCollectionBase) ultraToolbarsManager1.MergedTools).Exists(str))
        return;
      Action<ToolBase> action2 = action;
      if (action2 == null)
        return;
      action2(((ToolsCollectionBase) ultraToolbarsManager1.MergedTools)[str]);
    }
  }

  public static void AddOrShowButtonTool(
    this PopupMenuTool popupMenuTool,
    string key,
    string text,
    bool visible,
    Action<ButtonTool> creationHandler = null)
  {
    MGASystems.Tools.InfragisticsExtensions.InfragisticsExtensions.InternalAddOrShowButtonTool(popupMenuTool, key, text, visible, new int?(), creationHandler, (Action<ButtonTool>) null);
  }

  public static void AddOrShowButtonTool(
    this PopupMenuTool popupMenuTool,
    string key,
    string text,
    bool visible,
    int? index,
    Action<ButtonTool> creationHandler,
    Action<ButtonTool> onButtonVisible)
  {
    MGASystems.Tools.InfragisticsExtensions.InfragisticsExtensions.InternalAddOrShowButtonTool(popupMenuTool, key, text, visible, index, creationHandler, onButtonVisible);
  }

  public static void AddOrShowButtonTool(
    this PopupMenuTool popupMenuTool,
    string key,
    string text,
    bool visible,
    int index,
    Action<ButtonTool> creationHandler = null)
  {
    MGASystems.Tools.InfragisticsExtensions.InfragisticsExtensions.InternalAddOrShowButtonTool(popupMenuTool, key, text, visible, new int?(index), creationHandler, (Action<ButtonTool>) null);
  }

  public static void AddOrShowButtonTool(
    this PopupMenuTool popupMenuTool,
    string key,
    string text,
    Func<bool> predicate = null,
    Action<ButtonTool> creationHandler = null)
  {
    popupMenuTool.AddOrShowButtonTool(key, text, new int?(), predicate, creationHandler, (Action<ButtonTool>) null);
  }

  public static void AddOrShowButtonTool(
    this PopupMenuTool popupMenuTool,
    string key,
    string text,
    int index,
    Func<bool> predicate = null,
    Action<ButtonTool> creationHandler = null)
  {
    popupMenuTool.AddOrShowButtonTool(key, text, new int?(index), predicate, creationHandler, (Action<ButtonTool>) null);
  }

  public static void AddOrShowButtonTool(
    this PopupMenuTool popupMenuTool,
    string key,
    string text,
    int? index,
    Func<bool> predicate,
    Action<ButtonTool> creationHandler,
    Action<ButtonTool> onButtonVisible)
  {
    if (predicate == null)
    {
      MGASystems.Tools.InfragisticsExtensions.InfragisticsExtensions.InternalAddOrShowButtonTool(popupMenuTool, key, text, true, index, creationHandler, onButtonVisible);
    }
    else
    {
      if (((ToolsCollectionBase) popupMenuTool.Tools).Exists(key))
        ((ToolsCollectionBase) popupMenuTool.Tools)[key].SharedProps.Visible = false;
      Task.Run<bool>(predicate).ContinueWith((Action<Task<bool>>) ([SpecialName] (visible) => MGASystems.Tools.InfragisticsExtensions.InfragisticsExtensions.InternalAddOrShowButtonTool(popupMenuTool, key, text, visible.Result, index, creationHandler, onButtonVisible)), TaskScheduler.FromCurrentSynchronizationContext());
    }
  }

  public static void InternalAddOrShowButtonTool(
    PopupMenuTool PopupMenuTool,
    string key,
    string Text,
    bool isVisible,
    int? index,
    Action<ButtonTool> creationHandler,
    Action<ButtonTool> onSetVisible)
  {
    ButtonTool buttonTool1 = (ButtonTool) null;
    if (((ToolsCollectionBase) PopupMenuTool.Tools).Exists(key))
    {
      buttonTool1 = PopupMenuTool.FindButton(key);
      ((ToolBase) buttonTool1).SharedProps.Visible = isVisible;
    }
    else if (isVisible)
    {
      ButtonTool buttonTool2 = new ButtonTool(key);
      ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).Caption = Text;
      ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.Edit;
      if (creationHandler != null)
        creationHandler(buttonTool2);
      if (!((ToolsCollectionBase) ((ToolBase) PopupMenuTool).ToolbarsManager.Tools).Exists(key))
        ((ToolBase) PopupMenuTool).ToolbarsManager.Tools.Add((ToolBase) buttonTool2);
      buttonTool1 = index.HasValue ? (ButtonTool) PopupMenuTool.Tools.InsertTool(index.Value, key) : (ButtonTool) PopupMenuTool.Tools.AddTool(key);
    }
    if (!isVisible || buttonTool1 == null || onSetVisible == null)
      return;
    onSetVisible(buttonTool1);
  }
}
