// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Model.RecordEditorModel
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Model;

public class RecordEditorModel : MvcModelBase, IRecordEditorModel, IMvcModel
{
  private Func<IDatabaseSaveModel> _createNewModelFunc;
  private IDatabaseSaveModel _editingModel;

  public IDataGridModel ListModel { get; set; }

  public IDatabaseSaveModel EditingModel
  {
    get
    {
      return this._editingModel ?? throw new InvalidOperationException("Cannot get the current EditingModel if there is none.");
    }
    set
    {
      this._editingModel = value ?? throw new InvalidOperationException("Cannot set EditingModel to null.");
    }
  }

  public RecordEditorModel(
    IDataGridModel searchEditListModel,
    Func<IDatabaseSaveModel> createNewModelFunc)
  {
    this.ListModel = searchEditListModel ?? throw new ArgumentNullException();
    this._createNewModelFunc = createNewModelFunc ?? throw new ArgumentNullException();
  }

  public bool HasEditingModel() => this._editingModel != null;

  public void CreateNewEditModel()
  {
    if (this.HasEditingModel())
      throw new InvalidOperationException("Cannot create a new EditingModel if there already is one.");
    this.EditingModel = this._createNewModelFunc();
  }

  public void ClearEditingModel()
  {
    if (!this.HasEditingModel())
      throw new InvalidOperationException("Cannot clear EditingModel when there is none.");
    this.EditingModel.ResetChanges();
    this._editingModel = (IDatabaseSaveModel) null;
  }
}
