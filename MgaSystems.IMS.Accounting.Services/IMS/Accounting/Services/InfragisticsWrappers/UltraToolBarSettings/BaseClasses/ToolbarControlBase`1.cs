// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses.ToolbarControlBase`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data.CommonInterface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;

public abstract class ToolbarControlBase<TTool> : 
  UniqueObject<string>,
  IToolbarControl<TTool>,
  IToolbarControl,
  IToolbarItem,
  IUniqueObject<string>,
  IUniqueObject
  where TTool : ToolBase
{
  private string _caption;
  private TTool _createdInfragisticsTool;

  ToolBase IToolbarControl.CreatedInfragisticsTool => (ToolBase) this.CreatedInfragisticsTool;

  protected object Image { get; }

  protected virtual ToolDisplayStyle DisplayStyle { get; }

  public string Caption
  {
    get => this._caption;
    set
    {
      this._caption = value;
      if (!this.HasCreatedTool())
        return;
      ((ToolPropsBase) this.CreatedInfragisticsTool.SharedPropsInternal).Caption = this._caption;
    }
  }

  public TTool CreatedInfragisticsTool
  {
    get
    {
      if (!this.HasCreatedTool())
        this._createdInfragisticsTool = this.CreateInfragisticsTool();
      return this._createdInfragisticsTool;
    }
  }

  public override string UniqueIdentifier { get; }

  protected ToolbarControlBase(string caption = null, object image = null)
    : this(Guid.NewGuid().ToString(), caption, image)
  {
  }

  protected ToolbarControlBase(string identifier, string caption = null, object image = null)
  {
    this.UniqueIdentifier = identifier;
    this.Image = image;
    this.Caption = caption;
    if (this.HasCaption())
    {
      this.DisplayStyle = this.HasImage() ? (ToolDisplayStyle) 4 : (ToolDisplayStyle) 2;
    }
    else
    {
      if (!this.HasImage())
        throw new ArgumentException("Either caption or image must not be null.");
      this.DisplayStyle = (ToolDisplayStyle) 5;
      this.Caption = string.Empty;
    }
  }

  public void AddToToolbar(UltraToolbar toolbar)
  {
    this.AddToToolbarManager(((UltraToolbarBase) toolbar).ToolbarsManager, (ToolBase) this.CreatedInfragisticsTool);
    ((UltraToolbarBase) toolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) this.CreatedInfragisticsTool
    });
  }

  public void AddToPopupMenu(UltraToolbarsManager toolbarManager, PopupMenuTool popupTool)
  {
    this.AddToToolbarManager(toolbarManager, (ToolBase) popupTool);
    ((ToolsCollectionBase) toolbarManager.Tools).Add((ToolBase) this.CreatedInfragisticsTool);
    ((ToolsCollectionBase) popupTool.Tools).Add((ToolBase) this.CreatedInfragisticsTool);
  }

  protected bool HasCreatedTool() => (object) this._createdInfragisticsTool != null;

  protected bool HasImage() => this.Image != null;

  protected bool HasCaption() => !string.IsNullOrWhiteSpace(this.Caption);

  protected abstract void AttachListeners(UltraToolbarsManager toolbarManager);

  protected abstract void ChildApplySettingsToInfragisticsTool(TTool tool);

  protected abstract TTool ChildCreateInfragisticsTool();

  private TTool CreateInfragisticsTool()
  {
    TTool infragisticsTool = this.ChildCreateInfragisticsTool();
    this.ApplySettingsToTool(infragisticsTool);
    infragisticsTool.CustomizedIsFirstInGroup = (DefaultableBoolean) 2;
    return infragisticsTool;
  }

  private void ApplySettingsToTool(TTool tool)
  {
    tool.InstanceProps.IsFirstInGroup = false;
    if (this.HasImage())
    {
      Appearance appearance = new Appearance();
      ((AppearanceBase) appearance).Image = this.Image;
      ((ToolPropsBase) tool.SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance;
    }
    ((ToolPropsBase) tool.SharedPropsInternal).Caption = this.Caption;
    ((ToolPropsBase) tool.SharedPropsInternal).DisplayStyle = this.DisplayStyle;
    this.ChildApplySettingsToInfragisticsTool(tool);
  }

  private void AddToToolbarManager(UltraToolbarsManager toolbarManager, ToolBase tool)
  {
    if (!((KeyedSubObjectsCollectionBase) toolbarManager.Tools).Contains((IKeyedSubObject) tool))
      ((ToolsCollectionBase) toolbarManager.Tools).Add(tool);
    this.AttachListeners(toolbarManager);
  }
}
