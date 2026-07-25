// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.CopyConditionalViewModel
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class CopyConditionalViewModel : BindingObject
{
  private int? templateID;
  private Guid companyLineGuid;
  private Guid systemEventGuid;
  private IWinMsgBoxService msgBoxSvc;
  private ICommand _applyFilterCommand;
  private bool canClose;
  private ICommand _requestCloseCommand;
  private ICommand _okCommand;
  private ICommand _cancelCommand;

  [NotificationProperty]
  public virtual ObservableCollection<CompanyLocation> CompanyLocationList { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<State> StateList { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<Line> LineList { get; set; }

  [NotificationProperty]
  public virtual CompanyLocation SelectedCompanyLocation { get; set; }

  [NotificationProperty]
  public virtual State SelectedState { get; set; }

  [NotificationProperty]
  public virtual Line SelectedLine { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<CompanyLineInfo> CompanyLineList { get; set; }

  [NotificationProperty]
  public virtual string EventName { get; set; }

  [NotificationProperty]
  public virtual Cursor UICursor { get; set; }

  [NotificationProperty]
  public virtual DocumentConditional ConditionToCopy { get; set; }

  public CopyConditionalViewModel(
    int? _templateID,
    Guid _companyLineGuid,
    Guid _systemEventGuid,
    DocumentConditional _conditionToCopy)
  {
    this.msgBoxSvc = (IWinMsgBoxService) new WinMsgBoxService();
    this.canClose = true;
    this.CompanyLocationList = CompanyLocation.GetCompanyLocationList();
    this.StateList = State.GetStateList();
    this.LineList = Line.GetLineList();
    this.templateID = _templateID;
    this.companyLineGuid = _companyLineGuid;
    this.systemEventGuid = _systemEventGuid;
    this.ConditionToCopy = _conditionToCopy;
    this.EventName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT EventName FROM lstAutomationDocumentEvents WHERE EventGuid = @EG", new object[2]
    {
      (object) "@EG",
      (object) _systemEventGuid
    });
  }

  public static CopyConditionalViewModel Create(
    int? _templateID,
    Guid _companyLineGuid,
    Guid _systemEventGuid,
    DocumentConditional _conditionToCopy)
  {
    return NotifyProxyTypeManager.Allocate<CopyConditionalViewModel>(new object[4]
    {
      (object) _templateID,
      (object) _companyLineGuid,
      (object) _systemEventGuid,
      (object) _conditionToCopy
    });
  }

  public ICommand ApplyFilterCommand
  {
    get
    {
      if (this._applyFilterCommand == null)
        this._applyFilterCommand = (ICommand) new RelayCommand((Action) ([SpecialName] () => this.ApplyFilter()), (Func<bool>) ([SpecialName] () => this.CanExecuteApplyFilter()));
      return this._applyFilterCommand;
    }
  }

  private void ApplyFilter()
  {
    Guid? _companyLocationGuid = new Guid?();
    Guid? _lineGuid = new Guid?();
    string _stateID = (string) null;
    int? _quoteStatusReasonID = new int?();
    if (this.SelectedCompanyLocation != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SelectedCompanyLocation.Name, "Any", false) != 0)
      _companyLocationGuid = new Guid?(this.SelectedCompanyLocation.CompanyLocationGuid);
    if (this.SelectedLine != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SelectedLine.Name, "Any", false) != 0)
      _lineGuid = new Guid?(this.SelectedLine.LineGuid);
    if (this.SelectedState != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SelectedState.Name, "Any", false) != 0)
      _stateID = this.SelectedState.StateID;
    this.CompanyLineList = CompanyLineInfo.GetCompanyLine(_companyLocationGuid, _lineGuid, _stateID, new Guid?(this.companyLineGuid), new Guid?(this.systemEventGuid), this.templateID, new Guid?(), _quoteStatusReasonID);
  }

  private bool CanExecuteApplyFilter() => true;

  public ICommand RequestCloseCommand
  {
    get
    {
      if (this._requestCloseCommand == null)
        this._requestCloseCommand = (ICommand) new RelayCommand<CopyConditionalViewModel>((Action<CopyConditionalViewModel>) ([SpecialName] (param) => this.ExecuteRequestCloseCommand((object) param)));
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(closeObject.calledFrom, "CancelCommand", false) == 0)
      ((FrameworkElement) closeObject.mgaObject).DataContext = (object) null;
    ((MgaMdiChild) closeObject.mgaObject).Form.Close();
  }

  public ICommand OKCommand
  {
    get
    {
      if (this._okCommand == null)
        this._okCommand = (ICommand) new RelayCommand<CopyDocumentAutomationConditional>((Action<CopyDocumentAutomationConditional>) ([SpecialName] (param) => this.OK((object) param)), (Predicate<CopyDocumentAutomationConditional>) ([SpecialName] (param) => this.CanExecuteOK()));
      return this._okCommand;
    }
  }

  private void OK(object imsObject)
  {
    bool flag = true;
    ObservableCollection<CompanyLineInfo> companyLineList1 = this.CompanyLineList;
    System.Func<CompanyLineInfo, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (CopyConditionalViewModel._Closure\u0024__.\u0024I59\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = CopyConditionalViewModel._Closure\u0024__.\u0024I59\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      CopyConditionalViewModel._Closure\u0024__.\u0024I59\u002D0 = predicate = (System.Func<CompanyLineInfo, bool>) ([SpecialName] (e) => e.HasExistingConditional && e.Copy);
    }
    if (companyLineList1.Where<CompanyLineInfo>(predicate).Count<CompanyLineInfo>() > 0 && this.msgBoxSvc.ShowMessageBox("Copying will overwrite existing conditionals.  Continue copy?", "Copy Conditional", MessageBoxButton.YesNo) == MessageBoxResult.No)
      flag = false;
    if (!flag)
      return;
    this.UICursor = Cursors.Wait;
    ObservableCollection<CompanyLineInfo> companyLineList2 = this.CompanyLineList;
    DocumentConditional.CopyConditional(ref companyLineList2, this.templateID.Value, this.systemEventGuid, this.ConditionToCopy);
    this.CompanyLineList = companyLineList2;
    this.UICursor = Cursors.Arrow;
    this.ExecuteRequestCloseCommand((object) new CloseObject()
    {
      mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
      calledFrom = "OKCommand"
    });
  }

  private bool CanExecuteOK()
  {
    if (this.CompanyLineList == null)
      return false;
    ObservableCollection<CompanyLineInfo> companyLineList = this.CompanyLineList;
    System.Func<CompanyLineInfo, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (CopyConditionalViewModel._Closure\u0024__.\u0024I60\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = CopyConditionalViewModel._Closure\u0024__.\u0024I60\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      CopyConditionalViewModel._Closure\u0024__.\u0024I60\u002D0 = predicate = (System.Func<CompanyLineInfo, bool>) ([SpecialName] (s) => s.Copy);
    }
    return companyLineList.Where<CompanyLineInfo>(predicate).Count<CompanyLineInfo>() > 0;
  }

  public ICommand CancelCommand
  {
    get
    {
      if (this._cancelCommand == null)
        this._cancelCommand = (ICommand) new RelayCommand<CopyDocumentAutomationConditional>((Action<CopyDocumentAutomationConditional>) ([SpecialName] (param) => this.Cancel((object) param)));
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

  public RelayCommand<object> SelectUnselectItem
  {
    get
    {
      return new RelayCommand<object>((Action<object>) ([SpecialName] (selectItem) =>
      {
        try
        {
          foreach (CompanyLineInfo companyLine in (Collection<CompanyLineInfo>) this.CompanyLineList)
            companyLine.Copy = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(selectItem));
        }
        finally
        {
          IEnumerator<CompanyLineInfo> enumerator;
          enumerator?.Dispose();
        }
      }), (Predicate<object>) ([SpecialName] (selectedHistory) => this.CompanyLineList != null));
    }
  }
}
