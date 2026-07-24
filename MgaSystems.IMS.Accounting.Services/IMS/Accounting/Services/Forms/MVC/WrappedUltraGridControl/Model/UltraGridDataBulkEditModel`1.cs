// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model.UltraGridDataBulkEditModel`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using GrapeCity.Viewer.Common;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;

public abstract class UltraGridDataBulkEditModel<TDisplayItem> : 
  UltraGridDataModel<TDisplayItem>,
  ISave
  where TDisplayItem : ITrackChanges, ISave, IValidate
{
  public virtual void SaveChanges()
  {
    foreach (TDisplayItem displayItem in this.DisplayItems)
    {
      if (displayItem.HasChanges())
      {
        displayItem.SaveChanges();
        displayItem.ResetChanges();
      }
    }
  }

  public virtual void ResetChanges()
  {
    foreach (TDisplayItem displayItem in this.DisplayItems)
    {
      if (displayItem.HasChanges())
        displayItem.ResetChanges();
    }
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    EnumerableExtensions.ForEach<TDisplayItem>(((IEnumerable<TDisplayItem>) this.DisplayItems).Where<TDisplayItem>((Func<TDisplayItem, bool>) (item => item.HasChanges())), (Action<TDisplayItem>) (item => item.ValidateData(validationResult)));
  }
}
