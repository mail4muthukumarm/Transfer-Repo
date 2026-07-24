// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.UI.ThresholdLimitApprovalViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using MgaSystems.IMS.Policies.ThresholdLimit.Lib;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.UI;

public abstract class ThresholdLimitApprovalViewModel : BindingObject, ISubmittable
{
  private IWinMsgBoxService _msgBoxSvc;

  [NotificationProperty]
  public virtual CollectionViewSource LimitCSV { get; set; }

  [NotificationProperty]
  public virtual ThresholdLimitCheck SelectedItem { get; set; }

  [NotificationProperty]
  public virtual ThresholdLimitCheckManager ThresholdLimitCheckManager { get; set; }

  public bool HasChanges
  {
    get => this.ThresholdLimitCheckManager != null && this.ThresholdLimitCheckManager.HasChanges;
  }

  public static ThresholdLimitApprovalViewModel Create(
    ThresholdLimitCheckManager thresholdLimitCheckManager,
    IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitApprovalViewModel>(new object[2]
    {
      (object) thresholdLimitCheckManager,
      (object) msgBoxService
    });
  }

  public ThresholdLimitApprovalViewModel(
    ThresholdLimitCheckManager thresholdLimitCheckManager,
    IWinMsgBoxService msgBoxService)
  {
    this.ThresholdLimitCheckManager = thresholdLimitCheckManager;
    this.LimitCSV = new CollectionViewSource()
    {
      Source = (object) this.ThresholdLimitCheckManager.ThresholdLimitCheckList
    };
    this.LimitCSV.Filter += (FilterEventHandler) ((s, e) =>
    {
      ThresholdLimitCheck thresholdLimitCheck = e.Item as ThresholdLimitCheck;
      e.Accepted = thresholdLimitCheck.StopBind || thresholdLimitCheck.StopQuote || thresholdLimitCheck.StopBindSoft || thresholdLimitCheck.StopQuoteSoft;
    });
  }

  public RelayCommand SaveCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        List<ValidationResult> validationResultList = this.SubmitChanges();
        if (validationResultList.Count <= 0)
          return;
        foreach (ValidationResult validationResult in validationResultList)
        {
          int num = (int) this._msgBoxSvc.ShowMessageBox(validationResult.ErrorMessage, "Threshold Limit Approval", MessageBoxButton.OK);
        }
      }), (Func<bool>) (() => this.ThresholdLimitCheckManager.HasChanges));
    }
  }

  public List<ValidationResult> SubmitChanges() => this.ThresholdLimitCheckManager.SubmitChanges();
}
