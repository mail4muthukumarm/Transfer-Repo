// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Controller.DataGridController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Controller;

public class DataGridController : 
  MvcControllerBase<IDataGridModel, IDataGridView>,
  IDataGridController,
  IMvcController
{
  public event DataGridController.ModelEventHandler DoubleClickedRow;

  public void RequestAdd(IDatabaseSaveModel newModel)
  {
    this.View.RunInUpdateMode((Action) (() => this.Model.AddRecord(newModel)));
  }

  public void RequestDeleteSelected()
  {
    this.View.RunInUpdateMode(new Action(this.Model.DeleteSelectedRecord));
  }

  public void RequestChangeSelection(IDatabaseSaveModel newSelection)
  {
    this.Model.SelectedRecord = newSelection;
  }

  public void RequestClearSelectedRecord() => this.Model.ClearSelectedRecord();

  public IDatabaseSaveModel GetSelectedRecord() => this.Model.SelectedRecord;

  public bool GetHasSelectedRecord() => this.Model.HasSelectedRecord();

  public void RequestHandleDoubleClick() => this.DoubleClickedRow(this.Model.SelectedRecord);

  public void ExportToExcel() => this.Model.ExportToExcel();

  public bool HasExistingId(object uniqueIdentifier) => this.Model.ContainsRecord(uniqueIdentifier);

  public delegate void ModelEventHandler(IDatabaseSaveModel selectedRecord);
}
