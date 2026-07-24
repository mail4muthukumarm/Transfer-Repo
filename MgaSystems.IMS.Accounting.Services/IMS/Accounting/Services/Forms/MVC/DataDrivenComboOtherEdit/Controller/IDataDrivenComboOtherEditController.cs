// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Controller.IDataDrivenComboOtherEditController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Controller;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Controller;

public interface IDataDrivenComboOtherEditController : IMvcController
{
  IDataDrivenComboBoxController ComboBoxController { get; }

  void RequestSetOtherText(string text);
}
