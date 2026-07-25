// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.CompanyLineInstallmentBillingTypeViewModel
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public abstract class CompanyLineInstallmentBillingTypeViewModel : BindingObject
{
  private IWinMsgBoxService _msgBoxSvc;
  public Action<CompanyLineInstallmentBillingTypeManager> CloseAction;
  public CompanyLineInstallmentBillingTypeManager responseObject;
  private bool canClose;
  private ICommand _requestCloseCommand;

  [NotificationProperty]
  public virtual CompanyLineInstallmentBillingTypeManager CodeManager { get; set; }

  internal static CompanyLineInstallmentBillingTypeViewModel Create(
    IWinMsgBoxService msgBoxService,
    int compLineID,
    int compLineInstallmentID)
  {
    return NotifyProxyTypeManager.Allocate<CompanyLineInstallmentBillingTypeViewModel>(new object[3]
    {
      (object) msgBoxService,
      (object) compLineID,
      (object) compLineInstallmentID
    });
  }

  public CompanyLineInstallmentBillingTypeViewModel(
    IWinMsgBoxService msgBoxService,
    int compLineID,
    int compLineInstallmentID)
  {
    this.canClose = true;
    this._msgBoxSvc = msgBoxService;
    this.CodeManager = CompanyLineInstallmentBillingTypeManager.Create(compLineID, compLineInstallmentID);
  }

  public RelayCommand<object> SaveCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) ([SpecialName] (imsObject) =>
      {
        List<ValidationResult> validationResultList = this.CodeManager.SubmitChanges();
        if (validationResultList.Count > 0)
        {
          try
          {
            foreach (ValidationResult validationResult in validationResultList)
            {
              int num = (int) this._msgBoxSvc.ShowMessageBox(validationResult.ErrorMessage, "Underwriting Teams", MessageBoxButton.OK);
            }
          }
          finally
          {
            List<ValidationResult>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        else
        {
          this.responseObject = this.CodeManager;
          this.ExecuteRequestCloseCommand((object) new CloseObject()
          {
            mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
            calledFrom = "OKCommand"
          });
        }
      }), (Predicate<object>) ([SpecialName] (imsObject) => this.CodeManager.HasChanges));
    }
  }

  public RelayCommand<object> CancelCommand
  {
    get
    {
      Action<object> action = (Action<object>) ([SpecialName] (imsObject) => this.ExecuteRequestCloseCommand((object) new CloseObject()
      {
        mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
        calledFrom = nameof (CancelCommand)
      }));
      Predicate<object> predicate;
      if (CompanyLineInstallmentBillingTypeViewModel._Closure\u0024__.\u0024I12\u002D1 != null)
        predicate = CompanyLineInstallmentBillingTypeViewModel._Closure\u0024__.\u0024I12\u002D1;
      else
        CompanyLineInstallmentBillingTypeViewModel._Closure\u0024__.\u0024I12\u002D1 = predicate = (Predicate<object>) ([SpecialName] (imsObject) => true);
      return new RelayCommand<object>(action, predicate);
    }
  }

  public ICommand RequestCloseCommand
  {
    get
    {
      if (this._requestCloseCommand == null)
        this._requestCloseCommand = (ICommand) new RelayCommand<CompanyLineInstallmentBillingTypeViewModel>((Action<CompanyLineInstallmentBillingTypeViewModel>) ([SpecialName] (param) => this.ExecuteRequestCloseCommand((object) param)));
      return this._requestCloseCommand;
    }
  }

  private void ExecuteRequestCloseCommand(object obj)
  {
    if (!(obj is CloseObject))
      return;
    CloseObject closeObject = obj as CloseObject;
    if (!(closeObject.mgaObject is MgaMdiChild))
      return;
    if (Operators.CompareString(closeObject.calledFrom, "CancelCommand", false) == 0)
      ((FrameworkElement) closeObject.mgaObject).DataContext = (object) null;
    ((MgaMdiChild) closeObject.mgaObject).Form.Close();
  }
}
