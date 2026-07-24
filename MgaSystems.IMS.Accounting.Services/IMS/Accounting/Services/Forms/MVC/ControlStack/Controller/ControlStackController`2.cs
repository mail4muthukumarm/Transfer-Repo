// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Controller.ControlStackController`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using GrapeCity.Viewer.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry;
using MGASystems.IMS.Accounting.Services.Forms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Controller;

public abstract class ControlStackController<TModel, TView> : 
  MvcControllerBase<TModel, TView>,
  IControlStackController<TModel>,
  IControlStackController,
  ISaveDataController,
  IMvcController
  where TModel : class, IMvcModel, ISave
  where TView : class, IControlStackView
{
  private int _idealControlHeight;
  private int _idealControlWidth;
  private IControlStackAdapter<TModel> _controlStackAdapter;
  private IControlStackSettings<TModel> _displaySettings;

  private IControlStackSettings<TModel> DisplaySettings
  {
    get
    {
      if (this._displaySettings == null)
        this._displaySettings = this.GetDisplayOptions();
      return this._displaySettings;
    }
  }

  public virtual bool SuspendEdit => false;

  public int IdealControlHeight
  {
    get
    {
      return this._idealControlHeight <= this.MaximumAutoStackControlHeight ? this._idealControlHeight : this.MaximumAutoStackControlHeight;
    }
  }

  public int IdealControlWidth
  {
    get
    {
      return this._idealControlWidth <= this.MaximumAutoStackControlWidth ? this._idealControlWidth : this.MaximumAutoStackControlWidth;
    }
  }

  protected virtual int MaximumLabelWidth => 100;

  protected abstract int MaximumAutoStackControlWidth { get; }

  protected virtual int MaximumAutoStackControlHeight => 1000;

  public bool HasFilledControlFlow => this._controlStackAdapter != null;

  public void RequestReset()
  {
    if (!this.HasFilledControlFlow)
      throw new InvalidOperationException("Must invoke FillControlFlow() before resetting.");
    this.Model.ResetChanges();
    DialogResult dialogResult = DialogResult.Abort;
    this.View.RequestCloseForm(dialogResult);
    this.ChildAfterClose(dialogResult);
  }

  public void RequestSave()
  {
    if (!this.HasFilledControlFlow)
      throw new InvalidOperationException("Must invoke FillControlFlow() before saving.");
    this.View.UnSetFocus();
    if (this.SuspendEdit)
    {
      foreach (IControlStackEntry<TModel> control in this._controlStackAdapter.Controls)
        control.UpdateDisplayItem();
    }
    this.Model.SaveChanges();
    this.ChildSave();
    DialogResult dialogResult = DialogResult.OK;
    this.View.RequestCloseForm(dialogResult);
    this.ChildAfterClose(dialogResult);
  }

  protected virtual void ChildSave()
  {
  }

  public void FillControlFlow(FlowLayoutPanel controlFlow)
  {
    if (this.HasFilledControlFlow)
      throw new InvalidOperationException("Cannot build view more than once");
    IControlStackSettings<TModel> displaySettings = this.DisplaySettings;
    this._controlStackAdapter = displaySettings.ApplyToFlowLayout(controlFlow ?? throw new ArgumentNullException(nameof (controlFlow)));
    this.View.ResizeControlsToFlowLayout();
    foreach (IControlStackEntry<TModel> control in this._controlStackAdapter.Controls)
      control.SetDisplayValue(this.Model);
  }

  public void FormatControls()
  {
    IEnumerable<IStackEntryControl> source = ((IEnumerable<IControlStackEntry<TModel>>) this.DisplaySettings.ControlSettings).Select<IControlStackEntry<TModel>, IStackEntryControl>((Func<IControlStackEntry<TModel>, IStackEntryControl>) (c => c.CreatedControl));
    int biggestLabelWidth = source.Max<IStackEntryControl>((Func<IStackEntryControl, int>) (control => control.GetPreferredTextWidth()));
    biggestLabelWidth = biggestLabelWidth > this.MaximumLabelWidth ? this.MaximumLabelWidth : biggestLabelWidth;
    EnumerableExtensions.ForEach<IStackEntryControl>(source, (Action<IStackEntryControl>) (control => control.AdjustControlSizeToFitLabelOfMaximumWidth(biggestLabelWidth)));
    biggestLabelWidth = source.Max<IStackEntryControl>((Func<IStackEntryControl, int>) (control => control.GetTextWidth()));
    EnumerableExtensions.ForEach<IStackEntryControl>(source, (Action<IStackEntryControl>) (control => control.SetLabelWidth(biggestLabelWidth)));
    this._idealControlWidth = source.Max<IStackEntryControl>((Func<IStackEntryControl, int>) (control => control.GetControlWidth()));
    EnumerableExtensions.ForEach<IStackEntryControl>(source, (Action<IStackEntryControl>) (control => control.SetStartingWidth(this.IdealControlWidth)));
    this._idealControlHeight = source.Sum<IStackEntryControl>((Func<IStackEntryControl, int>) (control => control.GetTotalHeight()));
  }

  public void UpdateControlValuesFromModel(TModel model)
  {
    if (!this.HasFilledControlFlow)
      throw new InvalidOperationException("Must invoke FillControlFlow() before updating controls.");
    EnumerableExtensions.ForEach<IControlStackEntry<TModel>>((IEnumerable<IControlStackEntry<TModel>>) this._controlStackAdapter.Controls, (Action<IControlStackEntry<TModel>>) (control =>
    {
      IControlStackEntry<TModel> controlStackEntry = control;
      controlStackEntry.SetDisplayValue(model ?? throw new ArgumentNullException(nameof (model)));
    }));
  }

  public void UpdateControlValuesFromModel(object model)
  {
    if (!(model is TModel model1))
      throw new InvalidOperationException("Must pass in an object of type TDisplayItem to Update Display Values");
    this.UpdateControlValuesFromModel(model1);
  }

  protected abstract IControlStackSettings<TModel> GetDisplayOptions();

  protected override void ChildWireUp()
  {
    base.ChildWireUp();
    if (this.SuspendEdit)
      return;
    EnumerableExtensions.ForEach<IControlStackEntry<TModel>>((IEnumerable<IControlStackEntry<TModel>>) this.DisplaySettings.ControlSettings, (Action<IControlStackEntry<TModel>>) (control => control.ValueChanged += new Action(this.Control_ValueChanged)));
  }

  protected virtual void ChildAfterClose(DialogResult dialogResult)
  {
  }

  private void Control_ValueChanged() => this.Model.NotifyObservers();
}
