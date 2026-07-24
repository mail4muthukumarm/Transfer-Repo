// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.BindingChecklist.BindingChecklistQuote_ViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.BindingChecklist;

public abstract class BindingChecklistQuote_ViewModel : ValidatingBindingObject, ISubmittable
{
  private Guid _quoteguid = Guid.Empty;

  [TrackChanges]
  [NotificationProperty]
  public virtual ObservableCollection<BindingChecklistQuote> pBindingChecklistQuote { get; set; }

  [NotificationProperty]
  public virtual BindingChecklistQuote SelectedItemGrid { get; set; }

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  public static BindingChecklistQuote_ViewModel Create(Guid quoteguid)
  {
    return NotifyProxyTypeManager.Allocate<BindingChecklistQuote_ViewModel>(new object[1]
    {
      (object) quoteguid
    });
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  public BindingChecklistQuote_ViewModel(Guid quoteguid)
  {
    this._quoteguid = quoteguid;
    this.pBindingChecklistQuote = BindingChecklistQuote.GetList(quoteguid);
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public RelayCommand SaveCommand
  {
    get
    {
      return new RelayCommand((Action) (() => this.SubmitChanges()), (Func<bool>) (() => this.HasChanges));
    }
  }

  public RelayCommand RemoveItem
  {
    get
    {
      return new RelayCommand((Action) (() => this.deleteRow()), (Func<bool>) (() => this.SelectedItemGrid != null));
    }
  }

  public void deleteRow() => this.pBindingChecklistQuote.Remove(this.SelectedItemGrid);

  public void AddRow()
  {
    BindingChecklistQuote bindingChecklistQuote = BindingChecklistQuote.Create();
    bindingChecklistQuote.UserGuid = new Guid?(Guid.Empty);
    bindingChecklistQuote.Quoteguid = Guid.Empty;
    bindingChecklistQuote.Comment = string.Empty;
    bindingChecklistQuote.IsCompleted = false;
    this.pBindingChecklistQuote.Add(bindingChecklistQuote);
  }

  public RelayCommand AddSingleItemCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        SearchObject searchObject = (SearchObject) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchSingle(this.GetSearchList(), "Find Requirement", "Requirement", "Requirement", (Action<SearchObject>) (r => searchObject = r));
        if (searchObject == null)
          return;
        BindingChecklistQuote bindingChecklistQuote = BindingChecklistQuote.Create();
        BindingChecklistAdmin definingObject = searchObject.DefiningObject as BindingChecklistAdmin;
        bindingChecklistQuote.Quoteguid = this._quoteguid;
        bindingChecklistQuote.IsCompleted = false;
        bindingChecklistQuote.UserGuid = new Guid?(CurrentUser.Instance.UserGUID);
        bindingChecklistQuote.BindingChecklistID = definingObject.ID.Value;
        bindingChecklistQuote.Requirement = definingObject.Requirement;
        bindingChecklistQuote.IsBind = definingObject.IsBind;
        bindingChecklistQuote.IsQuote = definingObject.IsQuote;
        bindingChecklistQuote.IsIssue = definingObject.IsIssue;
        bindingChecklistQuote.AdminBindingReqComment = definingObject.Comment;
        this.pBindingChecklistQuote.Add(bindingChecklistQuote);
      }), (Func<bool>) (() => true));
    }
  }

  public RelayCommand AddMultipleItemsCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        ObservableCollection<SearchObject> searchObjectList = (ObservableCollection<SearchObject>) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchMultiple(this.GetSearchList(), "Find Requirements", "Requirement", "Requirement", (Action<ObservableCollection<SearchObject>>) (r => searchObjectList = r));
        if (searchObjectList == null)
          return;
        foreach (SearchObject searchObject in searchObjectList.Where<SearchObject>((System.Func<SearchObject, bool>) (s => s.ChosenItem)))
        {
          BindingChecklistQuote bindingChecklistQuote = BindingChecklistQuote.Create();
          BindingChecklistAdmin definingObject = searchObject.DefiningObject as BindingChecklistAdmin;
          bindingChecklistQuote.Quoteguid = this.pBindingChecklistQuote[0].Quoteguid;
          bindingChecklistQuote.IsCompleted = false;
          bindingChecklistQuote.UserGuid = new Guid?(CurrentUser.Instance.UserGUID);
          bindingChecklistQuote.BindingChecklistID = definingObject.ID.Value;
          bindingChecklistQuote.DateCompleted = new DateTime?(DateTime.MinValue);
          bindingChecklistQuote.Requirement = definingObject.Requirement;
          bindingChecklistQuote.IsBind = definingObject.IsBind;
          bindingChecklistQuote.IsQuote = definingObject.IsQuote;
          bindingChecklistQuote.IsIssue = definingObject.IsIssue;
          bindingChecklistQuote.AdminBindingReqComment = definingObject.Comment;
          this.pBindingChecklistQuote.Add(bindingChecklistQuote);
        }
      }), (Func<bool>) (() => true));
    }
  }

  private ObservableCollection<SearchObject> GetSearchList()
  {
    return new ObservableCollection<SearchObject>((IEnumerable<SearchObject>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "sp_GetBindingChecklistAdminData").AsEnumerable().Select<DataRow, SearchObject>((System.Func<DataRow, SearchObject>) (row =>
    {
      BindingChecklistAdmin bindingChecklistAdmin = BindingChecklistAdmin.Create(row.Field<int>("ID"), row.Field<string>("Requirement"), row.Field<bool>("IsBind"), row.Field<bool>("IsIssue"), row.Field<bool>("IsQuote"), row.Field<string>("Comment"));
      return SearchObject.Create(bindingChecklistAdmin.ID.Value, bindingChecklistAdmin.Requirement, (object) bindingChecklistAdmin);
    })));
  }
}
