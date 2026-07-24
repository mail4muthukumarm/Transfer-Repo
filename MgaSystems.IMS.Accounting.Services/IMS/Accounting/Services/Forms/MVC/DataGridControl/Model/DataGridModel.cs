// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model.DataGridModel
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;
using MGASystems.IMS.Accounting.Services.Forms.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model;

public class DataGridModel : MvcModelBase, IDataGridModel, IMvcModel
{
  private readonly IExcelExporter _excelExporter;
  private IDatabaseSaveModel _selectedRecord;

  public event EventHandler SelectedRecordChanged;

  public event EventHandler EntryDoubleClicked;

  public IDatabaseSaveModel SelectedRecord
  {
    get
    {
      if (!this.HasSelectedRecord())
        throw new InvalidOperationException("Cannot get the selected record when there is none.");
      return this._selectedRecord;
    }
    set
    {
      this._selectedRecord = this.Records.Contains(value) ? value : throw new InvalidOperationException("Can only set SelectedRecord to a value contained in Records");
      EventHandler selectedRecordChanged = this.SelectedRecordChanged;
      if (selectedRecordChanged != null)
        selectedRecordChanged((object) this, EventArgs.Empty);
      this.NotifyObservers();
    }
  }

  public BindingList<IDatabaseSaveModel> Records { get; }

  public IDataGridDisplaySettings DisplaySettings { get; }

  public DataGridModel(
    IEnumerable<IDatabaseSaveModel> records,
    IDataGridDisplaySettings entityDisplaySettings,
    IExcelExporter excelExporter)
  {
    this.Records = new BindingList<IDatabaseSaveModel>();
    this.SetRecords(records);
    this.DisplaySettings = entityDisplaySettings ?? throw new ArgumentNullException(nameof (entityDisplaySettings));
    this._excelExporter = excelExporter;
  }

  public bool ContainsRecord(IDatabaseSaveModel record)
  {
    return this.ContainsRecord(((IUniqueObject) record).UniqueIdentifier);
  }

  public bool ContainsRecord(object recordId)
  {
    return this.Records.Select<IDatabaseSaveModel, object>((Func<IDatabaseSaveModel, object>) (record => ((IUniqueObject) record).UniqueIdentifier)).Contains<object>(recordId);
  }

  public void ClearSelectedRecord()
  {
    this._selectedRecord = (IDatabaseSaveModel) null;
    this.NotifyObservers();
  }

  public bool HasSelectedRecord() => this._selectedRecord != null;

  public void AddRecord(IDatabaseSaveModel record)
  {
    this.ThrowIfInvalidRecordToAdd(record);
    this.Records.Add(record);
    this.NotifyObservers();
  }

  public void DeleteSelectedRecord()
  {
    if (!this.HasSelectedRecord())
      throw new InvalidOperationException("Cannot delete the selected record if there is none selected.");
    this.Records.Remove(this.SelectedRecord);
    this.SelectedRecord.DeleteFromDatabase();
    this.ClearSelectedRecord();
  }

  public bool CanExportToExcel() => this._excelExporter != null;

  public void ExportToExcel()
  {
    if (!this.CanExportToExcel())
      throw new InvalidOperationException("Cannot export if no exporter has been provided!");
    this._excelExporter.Export((IEnumerable<object>) this.Records, true);
  }

  private void SetRecords(IEnumerable<IDatabaseSaveModel> records)
  {
    if (records == null)
      throw new ArgumentNullException(nameof (records));
    this.SetListPermissions();
    foreach (IDatabaseSaveModel record in records)
    {
      this.ThrowIfInvalidRecordToAdd(record);
      this.Records.Add(record);
    }
  }

  private void SetListPermissions()
  {
    this.Records.AllowNew = true;
    this.Records.AllowRemove = true;
    this.Records.RaiseListChangedEvents = true;
    this.Records.AllowEdit = false;
  }

  private void ThrowIfInvalidRecordToAdd(IDatabaseSaveModel record)
  {
    if (((IUniqueObject) record)?.UniqueIdentifier == null)
      throw new ArgumentException("Cannot add a null record or a record with a null UniqueIdentifier.");
    if (this.ContainsRecord(record))
      throw new InvalidOperationException("Cannot add a record with an ID that already exists in Records.");
  }
}
