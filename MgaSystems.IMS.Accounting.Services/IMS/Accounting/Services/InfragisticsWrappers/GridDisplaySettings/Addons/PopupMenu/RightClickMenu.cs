// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.PopupMenu.RightClickMenu
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using GrapeCity.Viewer.Common;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.PopupMenu;

public class RightClickMenu : UniqueObject<string>
{
  private UltraGridBase _appliedToGrid;
  private PopupMenuTool popupTool;
  private UltraToolbarsManager _ultraToolbarManager;

  public virtual IToolbarControl[] Tools { get; }

  public override string UniqueIdentifier { get; } = Guid.NewGuid().ToString();

  public RightClickMenu(IToolbarControl[] tools)
  {
    this.Tools = tools ?? throw new ArgumentNullException(nameof (tools));
    if (!((IEnumerable<IToolbarControl>) tools).Any<IToolbarControl>())
      throw new ArgumentException("Cannot create a menu with no tool bar items!");
    if (((IEnumerable<IToolbarControl>) tools).Any<IToolbarControl>((Func<IToolbarControl, bool>) (tool => tool == null)))
      throw new ArgumentException("Cannot except null tools.");
  }

  public RightClickMenu(IToolbarControl tool)
  {
    IToolbarControl[] tools = new IToolbarControl[1];
    tools[0] = tool ?? throw new ArgumentNullException(nameof (tool));
    // ISSUE: explicit constructor call
    this.\u002Ector(tools);
  }

  public virtual void ApplyToGrid(UltraGridBase grid)
  {
    if (this._appliedToGrid != null)
      throw new InvalidOperationException("Cannot apply to a grid if already applied!");
    this._appliedToGrid = grid ?? throw new ArgumentNullException(nameof (grid));
    this.popupTool = new PopupMenuTool(base.UniqueIdentifier);
    this._ultraToolbarManager = new UltraToolbarsManager();
    this._ultraToolbarManager.DesignerFlags = 1;
    this._ultraToolbarManager.DockWithinContainerBaseType = typeof (Form);
    EnumerableExtensions.ForEach<IToolbarControl>((IEnumerable<IToolbarControl>) this.Tools, (Action<IToolbarControl>) (tool => tool.AddToPopupMenu(this._ultraToolbarManager, this.popupTool)));
  }

  public virtual void DisplayContextMenu()
  {
    if (this._appliedToGrid == null)
      throw new InvalidOperationException("Must apply to a grid before displaying the context menu.");
    this._ultraToolbarManager.ShowPopup(base.UniqueIdentifier, (Control) this._appliedToGrid);
  }
}
