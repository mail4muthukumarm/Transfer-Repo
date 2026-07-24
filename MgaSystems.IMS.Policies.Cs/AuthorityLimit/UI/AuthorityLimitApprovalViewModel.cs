// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.UI.AuthorityLimitApprovalViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using MgaSystems.IMS.Policies.AuthorityLimit.Lib;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.UI;

public abstract class AuthorityLimitApprovalViewModel : BindingObject, ISubmittable
{
  private IWinMsgBoxService _msgBoxSvc;

  [NotificationProperty]
  public virtual CollectionViewSource LimitCSV { get; set; }

  [NotificationProperty]
  public virtual AuthorityLimitCheck SelectedItem { get; set; }

  [NotificationProperty]
  public virtual AuthorityLimitCheckManager AuthorityLimitCheckManager { get; set; }

  public bool HasChanges
  {
    get => this.AuthorityLimitCheckManager != null && this.AuthorityLimitCheckManager.HasChanges;
  }

  public static AuthorityLimitApprovalViewModel Create(
    AuthorityLimitCheckManager authorityLimitCheckManager,
    IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitApprovalViewModel>(new object[2]
    {
      (object) authorityLimitCheckManager,
      (object) msgBoxService
    });
  }

  public AuthorityLimitApprovalViewModel(
    AuthorityLimitCheckManager authorityLimitCheckManager,
    IWinMsgBoxService msgBoxService)
  {
    this.AuthorityLimitCheckManager = authorityLimitCheckManager;
    this.LimitCSV = new CollectionViewSource()
    {
      Source = (object) this.AuthorityLimitCheckManager.AuthorityLimitCheckList
    };
    this.LimitCSV.Filter += (FilterEventHandler) ((s, e) =>
    {
      AuthorityLimitCheck authorityLimitCheck = e.Item as AuthorityLimitCheck;
      e.Accepted = authorityLimitCheck.StopBind || authorityLimitCheck.StopQuote || authorityLimitCheck.StopBindSoft || authorityLimitCheck.StopQuoteSoft;
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
          int num = (int) this._msgBoxSvc.ShowMessageBox(validationResult.ErrorMessage, "Authority Limit Approval", MessageBoxButton.OK);
        }
      }), (Func<bool>) (() => this.AuthorityLimitCheckManager.HasChanges));
    }
  }

  public List<ValidationResult> SubmitChanges() => this.AuthorityLimitCheckManager.SubmitChanges();
}
