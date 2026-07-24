// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller.WrappedUltraGridDatabaseBulkEditController`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;

public abstract class WrappedUltraGridDatabaseBulkEditController<TDisplayItem, TModel> : 
  WrappedUltraGridController<TDisplayItem, TModel, IWrappedUltraGridView>,
  ISaveDataController,
  IMvcController
  where TDisplayItem : ITrackChanges, ISave, IValidate
  where TModel : class, IUltraGridDataModel<TDisplayItem>, ISave
{
  protected virtual string ResetActionVerb { get; } = "Resetting";

  public void RequestReset()
  {
    this.View.InvokeIfUserConfirms(this.ResetActionVerb + " will cause any unsaved data to be lost. Continue?", "Unsaved data may be lost", (Action) (() => this.View.RunInUpdateMode((Action) (() =>
    {
      this.View.UnSetFocus();
      TDisplayItem[] changedDisplayItems = this.GetChangedDisplayItems();
      this.Model.ResetChanges();
      this.UpdateDisplayValues((IEnumerable<TDisplayItem>) changedDisplayItems);
      this.ChildReset();
    }))));
  }

  public void RequestSave()
  {
    this.View.RunInUpdateMode((Action) (() =>
    {
      TDisplayItem[] changedDisplayItems = this.GetChangedDisplayItems();
      try
      {
        this.View.UnSetFocus();
        this.Model.ValidateData();
        this.Model.SaveChanges();
        this.ChildSave();
      }
      catch (DataValidationException ex)
      {
        this.View.DisplayOkMessageBox(ex.Message, "Error Saving", MessageBoxIcon.Exclamation);
        return;
      }
      this.UpdateDisplayValues((IEnumerable<TDisplayItem>) changedDisplayItems);
    }));
  }

  protected virtual void ChildReset()
  {
  }

  protected virtual void ChildSave()
  {
  }

  private TDisplayItem[] GetChangedDisplayItems()
  {
    return ((IEnumerable<TDisplayItem>) this.Model.DisplayItems).Where<TDisplayItem>((Func<TDisplayItem, bool>) (x => x.HasChanges())).ToArray<TDisplayItem>();
  }

  private void UpdateDisplayValues(IEnumerable<TDisplayItem> updates)
  {
    foreach (TDisplayItem update in updates)
      this.GridAdapter.UpdateDisplayValuesForItem((object) update);
  }
}
