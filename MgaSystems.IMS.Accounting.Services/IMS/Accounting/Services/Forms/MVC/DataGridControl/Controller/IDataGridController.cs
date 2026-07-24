// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Controller.IDataGridController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Controller;

public interface IDataGridController : IMvcController
{
  void RequestChangeSelection(IDatabaseSaveModel newSelection);

  void RequestClearSelectedRecord();

  void RequestAdd(IDatabaseSaveModel newModel);

  void RequestDeleteSelected();

  void RequestHandleDoubleClick();

  IDatabaseSaveModel GetSelectedRecord();

  bool GetHasSelectedRecord();

  void ExportToExcel();

  bool HasExistingId(object uniqueIdentifier);

  event DataGridController.ModelEventHandler DoubleClickedRow;
}
