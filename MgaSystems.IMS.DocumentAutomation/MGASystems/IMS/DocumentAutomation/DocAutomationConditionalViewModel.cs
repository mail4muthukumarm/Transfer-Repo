// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DocAutomationConditionalViewModel
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class DocAutomationConditionalViewModel : BindingObject
{
  private IDocAutomationConditionalService docConditionalSvc;
  private int? templateID;
  private int? automationGroupID;
  private Guid companyLineGuid;
  private Guid systemEventGuid;
  private IWinMsgBoxService msgBoxSvc;
  private ICommand _getTagCommand;
  private bool canClose;
  private ICommand _requestCloseCommand;
  private ICommand _copyCommand;
  private ICommand _deleteCommand;
  private ICommand _okCommand;
  private ICommand _cancelCommand;

  [NotificationProperty]
  public virtual DocumentConditional DocConditional { get; set; }

  public DocAutomationConditionalViewModel(
    int? _templateID,
    int _companyAutomationDocumentID,
    int? autoGroupID,
    Guid _companyLineGuid,
    Guid _systemEventGuid)
  {
    this.docConditionalSvc = (IDocAutomationConditionalService) null;
    this.msgBoxSvc = (IWinMsgBoxService) new WinMsgBoxService();
    this.canClose = true;
    this.templateID = _templateID;
    this.automationGroupID = autoGroupID;
    this.companyLineGuid = _companyLineGuid;
    this.systemEventGuid = _systemEventGuid;
    this.DocConditional = DocumentConditional.GetDocumentConditional(_companyAutomationDocumentID);
  }

  public static DocAutomationConditionalViewModel Create(
    int? _templateID,
    int _companyAutomationDocumentID,
    int? _autoGroupID,
    Guid _companyLineGuid,
    Guid _systemEventGuid)
  {
    return NotifyProxyTypeManager.Allocate<DocAutomationConditionalViewModel>(new object[5]
    {
      (object) _templateID,
      (object) _companyAutomationDocumentID,
      (object) _autoGroupID,
      (object) _companyLineGuid,
      (object) _systemEventGuid
    });
  }

  public ICommand GetTagCommand
  {
    get
    {
      if (this._getTagCommand == null)
        this._getTagCommand = (ICommand) new RelayCommand((Action) ([SpecialName] () => this.GetTag()), (Func<bool>) ([SpecialName] () => this.CanExecuteGetTag()));
      return this._getTagCommand;
    }
  }

  private void GetTag()
  {
    if (this.docConditionalSvc == null)
      this.docConditionalSvc = (IDocAutomationConditionalService) new DocAutomationConditionalService();
    this.docConditionalSvc.GetTag(this.templateID, this.automationGroupID, (Action<Tag>) ([SpecialName] (tg) =>
    {
      if (tg == null)
        return;
      this.DocConditional.TagName = tg.TagName;
      this.DocConditional.DataStoreID = tg.DataStoreID;
    }));
  }

  private bool CanExecuteGetTag() => true;

  public ICommand RequestCloseCommand
  {
    get
    {
      if (this._requestCloseCommand == null)
        this._requestCloseCommand = (ICommand) new RelayCommand<DocAutomationConditionalViewModel>((Action<DocAutomationConditionalViewModel>) ([SpecialName] (param) => this.ExecuteRequestCloseCommand((object) param)));
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

  public ICommand CopyCommand
  {
    get
    {
      if (this._copyCommand == null)
        this._copyCommand = (ICommand) new RelayCommand<DocAutomationConditional>((Action<DocAutomationConditional>) ([SpecialName] (param) => this.Copy((object) param)), (Predicate<DocAutomationConditional>) ([SpecialName] (param) => this.CanExecuteCopy()));
      return this._copyCommand;
    }
  }

  private void Copy(object imsObject)
  {
    List<ValidationResult> validationResultList = this.DocConditional.SubmitChanges();
    if (validationResultList.Count == 0)
    {
      if (this.docConditionalSvc == null)
        this.docConditionalSvc = (IDocAutomationConditionalService) new DocAutomationConditionalService();
      this.docConditionalSvc.CopyConditional(this.templateID, this.companyLineGuid, this.systemEventGuid, this.DocConditional);
      this.ExecuteRequestCloseCommand((object) new CloseObject()
      {
        mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
        calledFrom = "OKCommand"
      });
    }
    else
    {
      int num = (int) this.msgBoxSvc.ShowMessageBox($"{"Unable to copy conditional."}{Environment.NewLine}{validationResultList[0].ErrorMessage}", "", MessageBoxButton.OK);
    }
  }

  private bool CanExecuteCopy() => this.DocConditional != null && this.DocConditional.cnID > 0;

  public ICommand DeleteCommand
  {
    get
    {
      if (this._deleteCommand == null)
        this._deleteCommand = (ICommand) new RelayCommand<DocAutomationConditional>((Action<DocAutomationConditional>) ([SpecialName] (param) => this.Delete((object) param)), (Predicate<DocAutomationConditional>) ([SpecialName] (param) => this.CanExecuteDelete()));
      return this._deleteCommand;
    }
  }

  private void Delete(object imsObject)
  {
    if (this.msgBoxSvc.ShowMessageBox("Delete conditional?", "Document Automation Conditional", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
      return;
    this.DocConditional.CollectionBroker.MarkDeleted((INotifyPropertyChanged) this.DocConditional);
    List<ValidationResult> validationResultList = this.DocConditional.SubmitChanges();
    if (validationResultList.Count == 0)
    {
      this.ExecuteRequestCloseCommand((object) new CloseObject()
      {
        mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
        calledFrom = "DeleteCommand"
      });
    }
    else
    {
      int num = (int) this.msgBoxSvc.ShowMessageBox(validationResultList[0].ErrorMessage, "", MessageBoxButton.OK);
    }
  }

  private bool CanExecuteDelete() => this.DocConditional != null && this.DocConditional.cnID > 0;

  public ICommand OKCommand
  {
    get
    {
      if (this._okCommand == null)
        this._okCommand = (ICommand) new RelayCommand<DocAutomationConditional>((Action<DocAutomationConditional>) ([SpecialName] (param) => this.OK((object) param)), (Predicate<DocAutomationConditional>) ([SpecialName] (param) => this.CanExecuteOK()));
      return this._okCommand;
    }
  }

  private void OK(object imsObject)
  {
    List<ValidationResult> validationResultList = this.DocConditional.SubmitChanges();
    if (validationResultList.Count == 0)
    {
      this.ExecuteRequestCloseCommand((object) new CloseObject()
      {
        mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
        calledFrom = "OKCommand"
      });
    }
    else
    {
      int num = (int) this.msgBoxSvc.ShowMessageBox(validationResultList[0].ErrorMessage, "", MessageBoxButton.OK);
    }
  }

  private bool CanExecuteOK() => true;

  public ICommand CancelCommand
  {
    get
    {
      if (this._cancelCommand == null)
        this._cancelCommand = (ICommand) new RelayCommand<DocAutomationConditional>((Action<DocAutomationConditional>) ([SpecialName] (param) => this.Cancel((object) param)));
      return this._cancelCommand;
    }
  }

  private void Cancel(object imsObject)
  {
    this.ExecuteRequestCloseCommand((object) new CloseObject()
    {
      mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
      calledFrom = "CancelCommand"
    });
  }
}
