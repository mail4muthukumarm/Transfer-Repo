// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.SearchSelect.DocumentTemplateMetaData.SearchSelectDocumentTemplateController
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Core.DataAccess.DocumentTemplateMetaData;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.Utility;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.SearchSelect.DocumentTemplateMetaData;

[Override(typeof (ISearchSelectDocumentTemplateController))]
public class SearchSelectDocumentTemplateController : 
  SearchSelectController<DocumentTemplateMetaDataDto>,
  ISearchSelectDocumentTemplateController,
  ISearchSelectController<DocumentTemplateMetaDataDto>,
  IWrappedUltraGridController<DocumentTemplateMetaDataDto>,
  IWrappedUltraGridController,
  IMvcController,
  ISearchSelectController,
  ITopControlController
{
  public SearchSelectDocumentTemplateController()
    : base((Func<string, DocumentTemplateMetaDataDto, bool>) ((s, dto) => (dto.TemplateName ?? "").ToLower().Contains(s.ToLower())))
  {
  }

  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Name = "Select a Document Template",
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

  protected override IUltraGridAdapter<DocumentTemplateMetaDataDto> ChildCreateGridAdapter()
  {
    return (IUltraGridAdapter<DocumentTemplateMetaDataDto>) new UltraGridSettingsAdapter<DocumentTemplateMetaDataDto>((IUltraGridTableSettings<DocumentTemplateMetaDataDto>) new UltraGridTableSettings<DocumentTemplateMetaDataDto>(new IUltraGridColumnSettings<DocumentTemplateMetaDataDto>[1]
    {
      (IUltraGridColumnSettings<DocumentTemplateMetaDataDto>) new TextReadOnlyColumn<DocumentTemplateMetaDataDto>("Name", 400, (Func<DocumentTemplateMetaDataDto, object>) (dto => (object) dto.TemplateName))
    })
    {
      FilterAdapter = new UltraGridFilterAdapter<DocumentTemplateMetaDataDto>((FilterLogicalOperator) 0, true)
    });
  }
}
