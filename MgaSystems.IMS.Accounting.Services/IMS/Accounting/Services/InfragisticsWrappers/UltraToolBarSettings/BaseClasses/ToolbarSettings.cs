// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses.ToolbarSettings
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;

public class ToolbarSettings : IToolbarSettings
{
  private IToolbarItem[] _toolbarItems { get; }

  public ToolbarSettings(IToolbarItem[] toolbarItems)
  {
    this._toolbarItems = toolbarItems ?? throw new ArgumentNullException(nameof (toolbarItems));
  }

  public void ApplyToToolbar(UltraToolbar toolbar)
  {
    this.AddToolbarItemsToUltraToolbar(toolbar);
    if (((DisposableObjectCollectionBase) ((UltraToolbarBase) toolbar).Tools).Count == 0)
      return;
    this.GroupTools(toolbar);
  }

  private void AddToolbarItemsToUltraToolbar(UltraToolbar toolBar)
  {
    toolBar.Visible = ((IEnumerable<IToolbarItem>) this._toolbarItems).Any<IToolbarItem>();
    foreach (IToolbarItem toolbarItem in this._toolbarItems)
      toolbarItem.AddToToolbar(toolBar);
  }

  private void GroupTools(UltraToolbar toolBar)
  {
    for (int index = 1; index < ((IEnumerable<IToolbarItem>) this._toolbarItems).Count<IToolbarItem>(); ++index)
    {
      IToolbarItem toolbarItem1 = this._toolbarItems[index - 1];
      IToolbarItem toolbarItem2 = this._toolbarItems[index];
      if (toolbarItem2 is ToolbarGroup toolbarGroup)
        ((ToolsCollectionBase) ((UltraToolbarBase) toolBar).Tools)[((IUniqueObject<string>) ((IEnumerable<IToolbarControl>) toolbarGroup.ToolbarControls).First<IToolbarControl>()).UniqueIdentifier].InstanceProps.IsFirstInGroup = true;
      else if (toolbarItem1 is ToolbarGroup && toolbarItem2 is IToolbarControl toolbarControl)
        ((ToolsCollectionBase) ((UltraToolbarBase) toolBar).Tools)[((IUniqueObject<string>) toolbarControl).UniqueIdentifier].InstanceProps.IsFirstInGroup = true;
    }
  }
}
