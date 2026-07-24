// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model.ISelectableValueWithOtherModel`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model;

public interface ISelectableValueWithOtherModel<TNamedValue, TIdentifier> : 
  ISelectableValueWithOtherModel,
  IValidateModel,
  IMvcModel,
  IValidate
  where TNamedValue : INamedValue<TIdentifier>
{
  ISelectableValueModel<TNamedValue, TIdentifier> SelectableValueModel { get; }

  TIdentifier SelectedValue { get; set; }
}
