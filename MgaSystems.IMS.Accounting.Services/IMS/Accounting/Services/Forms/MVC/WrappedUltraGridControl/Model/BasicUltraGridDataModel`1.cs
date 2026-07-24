// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model.BasicUltraGridDataModel`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using System;
using System.Collections;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;

public class BasicUltraGridDataModel<TDisplayItem> : 
  ValidateModelBase,
  IUltraGridDataModel<TDisplayItem>,
  IUltraGridDataModel,
  IValidateModel,
  IMvcModel,
  IValidate
{
  public BasicUltraGridDataModel(TDisplayItem[] displayItems)
  {
    this.DisplayItems = displayItems ?? throw new ArgumentNullException(nameof (displayItems));
  }

  public virtual TDisplayItem[] DisplayItems { get; set; }

  IEnumerable IUltraGridDataModel.DisplayItems => (IEnumerable) this.DisplayItems;

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
  }
}
