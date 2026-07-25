// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.AvailableTagsViewModel
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.Data.Binding;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class AvailableTagsViewModel : BindingObject
{
  private int? templateID;
  private int? automationGroupID;
  public Action<Tag> CloseAction;
  public Tag responseObject;
  private IWinMsgBoxService msgBoxSvc;
  private bool canClose;
  private ICommand _requestCloseCommand;
  private ICommand _okCommand;
  private ICommand _cancelCommand;

  [NotificationProperty]
  public virtual CollectionViewSource TagsCVS { get; set; }

  [NotificationProperty]
  public virtual Tag SelectedItem { get; set; }

  [NotificationProperty]
  public virtual string FilterGroup { get; set; }

  [NotificationProperty]
  public virtual string FilterTagName { get; set; }

  [NotificationProperty]
  public virtual string FilterTagDescription { get; set; }

  [NotificationProperty]
  public virtual int SelectedItemIndex { get; set; }

  public AvailableTagsViewModel(int? _templateID, int? autoGroupID)
    : this(new Enums.AutomationDocGroups?(), _templateID, autoGroupID)
  {
  }

  public AvailableTagsViewModel(
    Enums.AutomationDocGroups? automationDocGroup,
    int? _templateID,
    int? autoGroupID)
  {
    this.msgBoxSvc = (IWinMsgBoxService) new WinMsgBoxService();
    this.canClose = true;
    this.templateID = _templateID;
    this.automationGroupID = autoGroupID;
    this.TagsCVS = new CollectionViewSource();
    this.TagsCVS.GroupDescriptions.Add((GroupDescription) new PropertyGroupDescription()
    {
      PropertyName = "GroupName"
    });
    this.TagsCVS.Filter += (FilterEventHandler) ([SpecialName] (s, e) =>
    {
      Tag tag = e.Item as Tag;
      bool flag1 = string.IsNullOrEmpty(this.FilterGroup) || tag.GroupName.ToLower().Contains(this.FilterGroup.ToLower());
      bool flag2 = string.IsNullOrEmpty(this.FilterTagName) || tag.TagName.ToLower().Contains(this.FilterTagName.ToLower());
      bool flag3 = string.IsNullOrEmpty(this.FilterTagDescription) || tag.Description.ToLower().Contains(this.FilterTagDescription.ToLower());
      e.Accepted = flag1 && flag2 && flag3;
    });
    if (!automationDocGroup.HasValue)
    {
      this.TagsCVS.Source = (object) Tag.GetUserTagList();
    }
    else
    {
      dsTemplateDocs.TagsDataTable availableTagList = ObjectFactory.Instance.CreateObjectAs<TagParserFactory>().GetAvailableTagList((int) automationDocGroup.Value);
      CollectionViewSource tagsCvs = this.TagsCVS;
      EnumerableRowCollection<dsTemplateDocs.TagsRow> source = availableTagList.AsEnumerable<dsTemplateDocs.TagsRow>();
      System.Func<dsTemplateDocs.TagsRow, Tag> selector;
      // ISSUE: reference to a compiler-generated field
      if (AvailableTagsViewModel._Closure\u0024__.\u0024I30\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = AvailableTagsViewModel._Closure\u0024__.\u0024I30\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        AvailableTagsViewModel._Closure\u0024__.\u0024I30\u002D1 = selector = (System.Func<dsTemplateDocs.TagsRow, Tag>) ([SpecialName] (row) => Tag.Create(string.IsNullOrEmpty(row.TagGroup) ? "Unspecified" : row.TagGroup, row.Tagname, "", -1, "", -1, "", row.Description));
      }
      ObservableCollection<Tag> observableCollection = new ObservableCollection<Tag>((IEnumerable<Tag>) source.Select<dsTemplateDocs.TagsRow, Tag>(selector));
      tagsCvs.Source = (object) observableCollection;
    }
    this.SelectedItemIndex = -1;
  }

  public static AvailableTagsViewModel Create(int? _templateID, int? _autoGroupID)
  {
    return NotifyProxyTypeManager.Allocate<AvailableTagsViewModel>(new object[2]
    {
      (object) _templateID,
      (object) _autoGroupID
    });
  }

  public static AvailableTagsViewModel Create(
    Enums.AutomationDocGroups automationDocGroup,
    int? _templateID,
    int? _autoGroupID)
  {
    return NotifyProxyTypeManager.Allocate<AvailableTagsViewModel>(new object[3]
    {
      (object) automationDocGroup,
      (object) _templateID,
      (object) _autoGroupID
    });
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyName, "FilterGroup", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyName, "FilterTagDescription", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyName, "FilterTagName", false) != 0)
      return;
    this.TagsCVS.View.Refresh();
  }

  public ICommand RequestCloseCommand
  {
    get
    {
      if (this._requestCloseCommand == null)
        this._requestCloseCommand = (ICommand) new RelayCommand<AvailableTagsViewModel>((Action<AvailableTagsViewModel>) ([SpecialName] (param) => this.ExecuteRequestCloseCommand((object) param)));
      return this._requestCloseCommand;
    }
  }

  private void ExecuteRequestCloseCommand(object obj)
  {
    if (!(obj is CloseObject))
      return;
    CloseObject closeObject = obj as CloseObject;
    Form form = ((MgaMdiChild) closeObject.mgaObject).Form;
    if (!(closeObject.mgaObject is MgaMdiChild))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(closeObject.calledFrom, "CancelCommand", false) == 0)
    {
      ((FrameworkElement) closeObject.mgaObject).DataContext = (object) null;
      form.DialogResult = DialogResult.Cancel;
    }
    else
      form.DialogResult = DialogResult.OK;
    form.Close();
  }

  public ICommand OKCommand
  {
    get
    {
      if (this._okCommand == null)
        this._okCommand = (ICommand) new RelayCommand<AvailableTags>((Action<AvailableTags>) ([SpecialName] (param) => this.OK((object) param)), (Predicate<AvailableTags>) ([SpecialName] (param) => this.CanExecuteOK()));
      return this._okCommand;
    }
  }

  private void OK(object imsObject)
  {
    this.responseObject = this.SelectedItem;
    this.ExecuteRequestCloseCommand((object) new CloseObject()
    {
      mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
      calledFrom = "OKCommand"
    });
  }

  private bool CanExecuteOK() => this.SelectedItem != null;

  public ICommand CancelCommand
  {
    get
    {
      if (this._cancelCommand == null)
        this._cancelCommand = (ICommand) new RelayCommand<AvailableTags>((Action<AvailableTags>) ([SpecialName] (param) => this.Cancel((object) param)));
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
