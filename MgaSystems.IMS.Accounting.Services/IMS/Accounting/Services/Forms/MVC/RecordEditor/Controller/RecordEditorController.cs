// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Controller.RecordEditorController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.View;
using System;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Controller;

public class RecordEditorController : 
  MvcControllerBase<IRecordEditorModel, IRecordEditorView>,
  IRecordEditorController,
  ISaveDataController,
  IMvcController
{
  public IDataGridController ListController { get; }

  public RecordEditorController(IDataGridController listController)
  {
    this.ListController = listController ?? throw new ArgumentNullException(nameof (listController));
    this.ListController.DoubleClickedRow += new DataGridController.ModelEventHandler(this.ListController_DoubleClickedRow);
  }

  protected override void ChildWireUp()
  {
    base.ChildWireUp();
    this.SetToolBarOptions();
  }

  private void SetToolBarOptions()
  {
    bool excel = this.Model.ListModel.CanExportToExcel();
    if (excel)
      return;
    this.View.SetExcelExportVisibleStatus(excel);
  }

  private void ListController_DoubleClickedRow(IDatabaseSaveModel selectedRecord)
  {
    this.OpenSelectedRecordForEdit(selectedRecord);
  }

  private void OpenSelectedRecordForEdit(IDatabaseSaveModel selectedRecord)
  {
    if (this.Model.HasEditingModel())
    {
      if (!this.View.DisplayYesNo("Opening a new record will discard any pending changes to the open record.\nContinue?", "Unsaved Data May Be Lost"))
        return;
      this.Reset();
    }
    this.Model.EditingModel = selectedRecord;
    this.View.WireUpEditControl(this.Model.EditingModel);
  }

  public void RequestCreateModelIfNeeded()
  {
    if (this.Model.HasEditingModel())
      return;
    this.Model.CreateNewEditModel();
    this.View.WireUpEditControl(this.Model.EditingModel);
  }

  public void RequestSave()
  {
    if (!this.Model.HasEditingModel())
    {
      this.View.DisplayOkMessageBox("Must have a record open for edit to save it.", "Record not open for edit.", MessageBoxIcon.Hand);
    }
    else
    {
      try
      {
        this.CheckForExistingIdIfNecessary();
        bool isNew = this.Model.EditingModel.IsNew;
        this.Model.EditingModel.SaveChanges();
        this.AddEditModelToListIfIsNewRecord(isNew);
      }
      catch (DataValidationException ex)
      {
        this.View.DisplayOkMessageBox(ex.Message, "Error Saving Record.", MessageBoxIcon.Hand);
        return;
      }
      this.Reset();
    }
  }

  public void RequestDeleteSelectedRecord()
  {
    if (!this.ListController.GetHasSelectedRecord())
    {
      this.View.DisplayOkMessageBox("Cannot delete a record when none is selected.", "No Selected Record", MessageBoxIcon.Hand);
    }
    else
    {
      IDatabaseSaveModel selectedRecord = this.ListController.GetSelectedRecord();
      if (!selectedRecord.CanDelete())
      {
        this.HandleCannotDelete();
      }
      else
      {
        if (!this.View.DisplayYesNo("Deleting Records cannot be undone.\nContinue?", "Confirm Delete"))
          return;
        if (this.Model.HasEditingModel() && this.Model.EditingModel.Equals((object) selectedRecord))
          this.RequestReset();
        this.ListController.RequestDeleteSelected();
      }
    }
  }

  protected virtual void ChildHandleCannotDelete()
  {
  }

  private void HandleCannotDelete() => this.ChildHandleCannotDelete();

  public void RequestReset()
  {
    if (!this.Model.HasEditingModel())
      this.View.DisplayOkMessageBox("Cannot clear the open record when there is none.", "Unable to clear open record.", MessageBoxIcon.Hand);
    else
      this.View.InvokeIfUserConfirms("This will cause any unsaved data to be lost. Continue?", "Unsaved Data May Be Lost", (Action) (() => this.Reset()));
  }

  private void Reset()
  {
    this.Model.ClearEditingModel();
    this.View.UnWireUpEditControl();
    this.ListController.SetViewFocus();
  }

  public void RequestExportToExcel()
  {
    if (this.Model.ListModel.Records.Any<IDatabaseSaveModel>())
      this.View.MakeUserWaitForAction(new Action(this.ListController.ExportToExcel));
    else
      this.View.DisplayOkMessageBox("There are no records to export.", "No records to export.", MessageBoxIcon.Hand);
  }

  private void AddEditModelToListIfIsNewRecord(bool editingModelIsNewRecord)
  {
    if (!editingModelIsNewRecord)
      return;
    this.ListController.RequestAdd(this.Model.EditingModel);
  }

  private void CheckForExistingIdIfNecessary()
  {
    IDatabaseSaveModel editingModel = this.Model.EditingModel;
    if (editingModel.HasIdentifier() && (editingModel.IsNew || editingModel.IdChanged) && this.ListController.HasExistingId(editingModel.UpdatedId))
      throw new DataValidationException("A record corresponding to the given ID already exists. Please pick a different ID");
  }
}
