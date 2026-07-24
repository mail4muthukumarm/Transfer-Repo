// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.View.IRecordEditorView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.View;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.View;

public interface IRecordEditorView : IMvcView, IModelObserver
{
  void SetEditControl(IMvcView mvcView, IMvcController mvcController);

  void WireUpEditControl(IDatabaseSaveModel record);

  void UnWireUpEditControl();

  void SetExcelExportVisibleStatus(bool isVisible);

  void UserEnterEditControl();

  void UserSave();

  void UserDelete();

  void UserReset();

  void UserExport();
}
