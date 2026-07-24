// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Controller.ChargeCodeGLAccountMappingGridController
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Core.DataAccess.GLAccount;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Controller;

[Override(typeof (IChargeCodeGLAccountMappingGridController))]
public class ChargeCodeGLAccountMappingGridController : 
  WrappedUltraGridDatabaseBulkEditController<IChargeCodeGLAccountMappingModel, ChargeCodeGLAccountMappingGridModel>,
  IChargeCodeGLAccountMappingGridController,
  IWrappedUltraGridController<IChargeCodeGLAccountMappingModel>,
  IWrappedUltraGridController,
  IMvcController,
  ISaveDataController,
  ITopControlController
{
  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Width = 1200,
        Height = 600,
        Name = "Charge Code GL Account Mapping",
        ShortcutActions = new ShortcutAction[3]
        {
          ShortcutAction.CreateSave(new Action(((WrappedUltraGridDatabaseBulkEditController<IChargeCodeGLAccountMappingModel, ChargeCodeGLAccountMappingGridModel>) this).RequestSave)),
          ShortcutAction.CreateReset(new Action(((WrappedUltraGridDatabaseBulkEditController<IChargeCodeGLAccountMappingModel, ChargeCodeGLAccountMappingGridModel>) this).RequestReset)),
          ShortcutAction.CreateCancel((Action) (() => this.View.RequestCloseForm(DialogResult.Abort)))
        }
      };
    }
  }

  public IToolbarItem[] GetToolBarItems()
  {
    return new IToolbarItem[1]
    {
      (IToolbarItem) new ToolbarGroup(new IToolbarControl[2]
      {
        (IToolbarControl) new ButtonToolbarControl("Save", new Action(this.Save), (object) Resources.disk),
        (IToolbarControl) new ButtonToolbarControl("Reset", new Action(this.Reset), (object) Resources.arrow_refresh)
      })
    };
  }

  protected override IUltraGridAdapter<IChargeCodeGLAccountMappingModel> ChildCreateGridAdapter()
  {
    IUltraGridColumnSettings<OfficeGlMapping>[] columnSettings = new IUltraGridColumnSettings<OfficeGlMapping>[4]
    {
      (IUltraGridColumnSettings<OfficeGlMapping>) new TextReadOnlyColumn<OfficeGlMapping>("Office", 225, (Func<OfficeGlMapping, object>) (x => (object) x.Name)),
      null,
      null,
      null
    };
    UniqueComboBoxColumn<OfficeGlMapping, GLAccountDto> uniqueComboBoxColumn = new UniqueComboBoxColumn<OfficeGlMapping, GLAccountDto>("GL Account", 200, (Func<OfficeGlMapping, GLAccountDto>) (mapping => mapping.GlAccount), (Action<OfficeGlMapping, GLAccountDto>) ((mapping, account) => mapping.GlAccount = account), (Func<OfficeGlMapping, IEnumerable<GLAccountDto>>) (mapping => mapping.GlAccounts), (Func<GLAccountDto, string>) (glAccount => $"{glAccount.FullName}, {glAccount.ShortName}"), true);
    uniqueComboBoxColumn.GetToolTipText = (Func<OfficeGlMapping, string>) (mapping => !mapping.IsEditable ? "This mapping cannot be changed, it already has a posting created against it." : "Select a GL Account");
    columnSettings[1] = (IUltraGridColumnSettings<OfficeGlMapping>) uniqueComboBoxColumn;
    columnSettings[2] = (IUltraGridColumnSettings<OfficeGlMapping>) new TextReadOnlyColumn<OfficeGlMapping>("Last Modified Date", 200, (Func<OfficeGlMapping, object>) (x =>
    {
      DateTime? lastModifiedDate = x.LastModifiedDate;
      ref DateTime? local = ref lastModifiedDate;
      return (local.HasValue ? (object) local.GetValueOrDefault().ToString("f") : (object) (string) null) ?? (object) string.Empty;
    }));
    columnSettings[3] = (IUltraGridColumnSettings<OfficeGlMapping>) new TextReadOnlyColumn<OfficeGlMapping>("Last Modified User", 175, (Func<OfficeGlMapping, object>) (x => (object) x.LastModifiedUser ?? (object) string.Empty));
    return (IUltraGridAdapter<IChargeCodeGLAccountMappingModel>) new UltraGridSettingsAdapter<IChargeCodeGLAccountMappingModel>((IUltraGridTableSettings<IChargeCodeGLAccountMappingModel>) new UltraGridTableSettings<IChargeCodeGLAccountMappingModel>(new IUltraGridColumnSettings<IChargeCodeGLAccountMappingModel>[3]
    {
      (IUltraGridColumnSettings<IChargeCodeGLAccountMappingModel>) new TextReadOnlyColumn<IChargeCodeGLAccountMappingModel>("Charge Code", 300, (Func<IChargeCodeGLAccountMappingModel, object>) (model => (object) model.Name)),
      (IUltraGridColumnSettings<IChargeCodeGLAccountMappingModel>) new TextReadOnlyColumn<IChargeCodeGLAccountMappingModel>("Description", 400, (Func<IChargeCodeGLAccountMappingModel, object>) (model => (object) model.Description)),
      (IUltraGridColumnSettings<IChargeCodeGLAccountMappingModel>) new TextReadOnlyColumn<IChargeCodeGLAccountMappingModel>("State", 100, (Func<IChargeCodeGLAccountMappingModel, object>) (model => (object) model.State))
    }, (IUltraGridTableSettings) new UltraGridTableSettings<OfficeGlMapping>("OfficeGlMappings", columnSettings)
    {
      RowEnabledFunc = (Func<OfficeGlMapping, bool>) (map => map.IsEditable)
    }));
  }

  public void Save()
  {
    List<OfficeGlMapping> modifiedMappings = this.GetModifiedMappings();
    this.RequestSave();
    this.UpdateGridItemsForModifiedMappings(modifiedMappings);
  }

  public void Reset()
  {
    List<OfficeGlMapping> modifiedMappings = this.GetModifiedMappings();
    this.RequestReset();
    this.UpdateGridItemsForModifiedMappings(modifiedMappings);
  }

  private void UpdateGridItemsForModifiedMappings(List<OfficeGlMapping> modifiedMappings)
  {
    foreach (object modifiedMapping in modifiedMappings)
      this.GridAdapter.UpdateDisplayValuesForItem(modifiedMapping);
  }

  private List<OfficeGlMapping> GetModifiedMappings()
  {
    IChargeCodeGLAccountMappingModel[] array = ((IEnumerable<IChargeCodeGLAccountMappingModel>) this.Model.DisplayItems).Where<IChargeCodeGLAccountMappingModel>((Func<IChargeCodeGLAccountMappingModel, bool>) (x => x.HasChanges())).ToArray<IChargeCodeGLAccountMappingModel>();
    List<OfficeGlMapping> modifiedMappings = new List<OfficeGlMapping>();
    foreach (IChargeCodeGLAccountMappingModel accountMappingModel in array)
      modifiedMappings.AddRange(accountMappingModel.OfficeGlMappings.Where<OfficeGlMapping>((Func<OfficeGlMapping, bool>) (x => x.HasChanges())));
    return modifiedMappings;
  }
}
