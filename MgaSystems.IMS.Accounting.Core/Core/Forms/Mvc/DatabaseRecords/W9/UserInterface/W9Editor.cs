// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.UserInterface.W9Editor
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.Interface;
using MGASystems.Data.Repository.ToDataTable;
using MGASystems.IMS.Accounting.Core.DataAccess.W9;
using MGASystems.IMS.Accounting.Core.DataAccess.W9EntityType;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Controller;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Model;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;
using MGASystems.IMS.Accounting.Services.Forms.MVC.UserInterface;
using MGASystems.IMS.Accounting.Services.Forms.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.UserInterface;

public class W9Editor : RecordEditorForm
{
  private IW9Repository _w9Repository;
  private IW9EntityTypeRepositoryReadOnly _w9EntityTypeRepository;
  private INamedValue<int>[] _entityTypes;
  private IContainer components;

  private INamedValue<int>[] EntityTypes
  {
    get
    {
      if (this._entityTypes == null)
        this._entityTypes = (INamedValue<int>[]) ((IGetAllRepository<W9EntityTypeDto, int>) this._w9EntityTypeRepository).GetAll();
      return this._entityTypes;
    }
  }

  protected override IDatabaseSaveModel[] AllRecords
  {
    get
    {
      return (IDatabaseSaveModel[]) ((IEnumerable<W9Dto>) ((IGetAllRepository<W9Dto, Guid>) this._w9Repository).GetAll()).Select<W9Dto, IW9Model>((Func<W9Dto, IW9Model>) (x => ObjectFactory.Instance.CreateObjectAs<IW9Model>((object) x, (object) this.EntityTypes, (object) this._w9Repository))).ToArray<IW9Model>();
    }
  }

  protected override Func<IDatabaseSaveModel> CreateNewFunc
  {
    get
    {
      return (Func<IDatabaseSaveModel>) (() => (IDatabaseSaveModel) ObjectFactory.Instance.CreateObjectAs<IW9Model>((object) this.EntityTypes, (object) this._w9Repository));
    }
  }

  protected override IExcelExporter ExcelExporter { get; } = (IExcelExporter) new MGASystems.IMS.Accounting.Services.Forms.Utility.ExcelExporter<IW9Model>((IEnumerable<IDataTableColumnMapping<IW9Model>>) new List<IDataTableColumnMapping<IW9Model>>()
  {
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("Business Name", (Func<IW9Model, string>) (w9 => w9.BusinessName)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("Tin Ein", (Func<IW9Model, string>) (w9 => w9.TinEin)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("Taxing Entity", (Func<IW9Model, string>) (w9 => w9.TaxingEntity)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, DateTime?>("W9Date", (Func<IW9Model, DateTime?>) (w9 => w9.W9Date)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("Address 1", (Func<IW9Model, string>) (w9 => w9.Address.Address1)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("Address 2", (Func<IW9Model, string>) (w9 => w9.Address.Address2)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("City", (Func<IW9Model, string>) (w9 => w9.Address.City)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("State", (Func<IW9Model, string>) (w9 => w9.Address.State)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("Zip Code", (Func<IW9Model, string>) (w9 => w9.Address.ZipCode)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("Zip Code Extension", (Func<IW9Model, string>) (w9 => w9.Address.ZipCodeExtension)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, DateTime?>("Date Last Modified", (Func<IW9Model, DateTime?>) (w9 => w9.ModificationData.ModifiedDate)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("Modified By", (Func<IW9Model, string>) (w9 => w9.ModificationData.UserName)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("W9 Entity Type", (Func<IW9Model, string>) (w9 => w9.EntityType.SelectableValueModel.SelectedNamedValue.Name)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("W9 Other Entity Type", (Func<IW9Model, string>) (w9 => w9.EntityType.OtherText)),
    (IDataTableColumnMapping<IW9Model>) new DataTableColumnMapping<IW9Model, string>("IMS Entity Type", (Func<IW9Model, string>) (w9 => w9.AccountingType.ToString()))
  });

  protected override IDataGridDisplaySettings ListDisplaySettings
  {
    get
    {
      return (IDataGridDisplaySettings) new DataGridDisplaySettings(new IDisplayColumnSettings[3]
      {
        (IDisplayColumnSettings) new DisplayColumn("BusinessName", 149, "Business Name", typeof (string), (Func<IMvcModel, string>) (w9 => (w9 as IW9Model).BusinessName)),
        (IDisplayColumnSettings) new DisplayColumn("Address", 250, "Address", typeof (string), (Func<IMvcModel, string>) (w9 => (w9 as IW9Model).Address.ToString())),
        (IDisplayColumnSettings) new DisplayColumn("ImsEntityType", 100, "Entity Type", typeof (string), (Func<IMvcModel, string>) (w9 => (w9 as IW9Model).AccountingType.ToString()))
      });
    }
  }

  public W9Editor(
    IW9EntityTypeRepositoryReadOnly w9EntityTypeRepository,
    IW9Repository w9Repository)
  {
    this.InitializeComponent();
    this._w9EntityTypeRepository = w9EntityTypeRepository;
    this._w9Repository = w9Repository;
    IW9Controller objectAs = ObjectFactory.Instance.CreateObjectAs<IW9Controller>();
    this.Setup((IMvcView) ObjectFactory.Instance.CreateObjectAs<IW9View>(), (IMvcController) objectAs);
  }

  public W9Editor(IW9Repository repository)
    : this((IW9EntityTypeRepositoryReadOnly) new W9EntityTypeRepository(), repository)
  {
  }

  public W9Editor()
    : this((IW9Repository) new W9Repository())
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.ClientSize = new Size(1063, 645);
    this.MaximizeBox = false;
    this.Name = nameof (W9Editor);
    this.Text = "Add/Edit W9 Information";
    this.ResumeLayout(false);
  }
}
