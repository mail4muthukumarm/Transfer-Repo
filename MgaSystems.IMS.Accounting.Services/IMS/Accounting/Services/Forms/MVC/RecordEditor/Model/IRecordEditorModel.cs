// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Model.IRecordEditorModel
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Model;

public interface IRecordEditorModel : IMvcModel
{
  IDataGridModel ListModel { get; set; }

  IDatabaseSaveModel EditingModel { get; set; }

  bool HasEditingModel();

  void ClearEditingModel();

  void CreateNewEditModel();
}
