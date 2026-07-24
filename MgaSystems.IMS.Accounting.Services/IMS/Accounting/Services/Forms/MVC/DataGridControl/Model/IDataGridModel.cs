// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model.IDataGridModel
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;
using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model;

public interface IDataGridModel : IMvcModel
{
  IDatabaseSaveModel SelectedRecord { get; set; }

  IDataGridDisplaySettings DisplaySettings { get; }

  BindingList<IDatabaseSaveModel> Records { get; }

  bool HasSelectedRecord();

  void AddRecord(IDatabaseSaveModel record);

  void DeleteSelectedRecord();

  void ClearSelectedRecord();

  bool ContainsRecord(IDatabaseSaveModel record);

  bool ContainsRecord(object recordId);

  void ExportToExcel();

  bool CanExportToExcel();

  event EventHandler SelectedRecordChanged;

  event EventHandler EntryDoubleClicked;
}
