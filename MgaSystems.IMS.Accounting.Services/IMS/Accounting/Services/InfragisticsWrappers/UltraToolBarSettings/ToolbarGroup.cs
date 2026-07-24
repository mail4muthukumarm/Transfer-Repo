// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.ToolbarGroup
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using GrapeCity.Viewer.Common;
using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;

public class ToolbarGroup : UniqueObject<string>, IToolbarItem, IUniqueObject<string>, IUniqueObject
{
  public IToolbarControl[] ToolbarControls { get; }

  public override string UniqueIdentifier { get; }

  public ToolbarGroup(params IToolbarControl[] toolbarControls)
    : this(new Guid().ToString(), toolbarControls)
  {
  }

  public ToolbarGroup(string identifier, params IToolbarControl[] toolbarControls)
  {
    this.UniqueIdentifier = identifier;
    this.ToolbarControls = toolbarControls ?? throw new ArgumentNullException(nameof (toolbarControls));
    if (!((IEnumerable<IToolbarControl>) this.ToolbarControls).Any<IToolbarControl>())
      throw new ArgumentException("Must have at least one control in a toolbar group.");
    if (((IEnumerable<IToolbarControl>) this.ToolbarControls).Any<IToolbarControl>((Func<IToolbarControl, bool>) (control => control == null)))
      throw new ArgumentException("Cannot have null values in a toolbar group.");
    ((IEnumerable<IToolbarControl>) this.ToolbarControls).First<IToolbarControl>().CreatedInfragisticsTool.CustomizedIsFirstInGroup = (DefaultableBoolean) 1;
  }

  public void AddToPopupMenu(UltraToolbarsManager toolbarManager, PopupMenuTool popupTool)
  {
    EnumerableExtensions.ForEach<IToolbarControl>((IEnumerable<IToolbarControl>) this.ToolbarControls, (Action<IToolbarControl>) (control => control.AddToPopupMenu(toolbarManager, popupTool)));
  }

  public void AddToToolbar(UltraToolbar toolbar)
  {
    EnumerableExtensions.ForEach<IToolbarControl>((IEnumerable<IToolbarControl>) this.ToolbarControls, (Action<IToolbarControl>) (control => control.AddToToolbar(toolbar)));
  }
}
