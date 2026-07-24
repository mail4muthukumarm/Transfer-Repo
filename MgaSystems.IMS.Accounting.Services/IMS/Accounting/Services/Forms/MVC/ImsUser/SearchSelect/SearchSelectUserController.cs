// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.SearchSelect.SearchSelectUserController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.Repository;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.Utility;
using MGASystems.IMS.Accounting.Services.Properties;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.SearchSelect;

[Override(typeof (ISearchSelectImsUserController))]
public class SearchSelectUserController : 
  SearchSelectController<ImsUserDto>,
  ISearchSelectImsUserController,
  ISearchSelectController<ImsUserDto>,
  IWrappedUltraGridController<ImsUserDto>,
  IWrappedUltraGridController,
  IMvcController,
  ISearchSelectController,
  ITopControlController
{
  public SearchSelectUserController()
    : base((Func<string, ImsUserDto, bool>) ((s, dto) => $"{dto.FirstName} {dto.LastName}".ToLower().Contains(s.ToLower())))
  {
  }

  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Name = "Select a User",
        Height = 800,
        Width = 400
      };
    }
  }

  public IToolbarItem[] GetToolBarItems()
  {
    return new IToolbarItem[2]
    {
      (IToolbarItem) ToolbarItemFactory.CreateSaveButton((ISaveDataController) this, "Select", (object) Resources.accept),
      (IToolbarItem) ToolbarItemFactory.CreateResetButton((ISaveDataController) this, "Cancel", (object) Resources.cross)
    };
  }

  protected override IUltraGridAdapter<ImsUserDto> ChildCreateGridAdapter()
  {
    return (IUltraGridAdapter<ImsUserDto>) new UltraGridSettingsAdapter<ImsUserDto>((IUltraGridTableSettings<ImsUserDto>) new UltraGridTableSettings<ImsUserDto>(new IUltraGridColumnSettings<ImsUserDto>[1]
    {
      (IUltraGridColumnSettings<ImsUserDto>) new TextReadOnlyColumn<ImsUserDto>("Name", 400, (Func<ImsUserDto, object>) (dto => (object) $"{dto.FirstName} {dto.LastName}"))
    })
    {
      FilterAdapter = new UltraGridFilterAdapter<ImsUserDto>((FilterLogicalOperator) 0, true)
    });
  }
}
