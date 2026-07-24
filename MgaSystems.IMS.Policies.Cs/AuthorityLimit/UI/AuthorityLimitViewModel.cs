// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.UI.AuthorityLimitViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using MgaSystems.IMS.Policies.AuthorityLimit.Lib;
using MgaSystems.IMS.Policies.Misc.Lib;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.UI;

public abstract class AuthorityLimitViewModel : BindingObject, ISubmittable
{
  private readonly IWinMsgBoxService _msgBoxSvc;

  [NotificationProperty]
  public virtual AuthorityLimitManager AuthorityManager { get; set; }

  [NotificationProperty]
  public virtual AuthorityLimitUser SelectedUser { get; set; }

  [NotificationProperty]
  public virtual bool IsUserSelected { get; set; }

  [NotificationProperty]
  public virtual MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit SelectedItem { get; set; }

  public bool HasChanges => this.AuthorityManager != null && this.AuthorityManager.HasChanges;

  [NotificationProperty]
  public virtual CollectionViewSource UserCSV { get; set; }

  [NotificationProperty]
  public virtual CollectionViewSource UserLimitCSV { get; set; }

  [NotificationProperty]
  public virtual AuthorityLimitUser SelectedLimitUser { get; set; }

  [NotificationProperty]
  public virtual string SendTaskContent { get; set; }

  [NotificationProperty]
  public virtual bool ShowSendTaskQuote { get; set; }

  [NotificationProperty]
  public virtual AuthorityLimitDatabaseField SelectedField { get; set; }

  [NotificationProperty]
  public virtual AuthorityLimitsDatabaseFieldLine SelectedLine { get; set; }

  internal static AuthorityLimitViewModel Create(IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitViewModel>(new object[1]
    {
      (object) msgBoxService
    });
  }

  public AuthorityLimitViewModel(IWinMsgBoxService msgBoxService)
  {
    this._msgBoxSvc = msgBoxService;
    this.UserCSV = new CollectionViewSource();
    this.UserCSV.GroupDescriptions.Add((GroupDescription) new PropertyGroupDescription("UserGuid"));
    this.UserLimitCSV = new CollectionViewSource();
    this.AuthorityManager = AuthorityLimitManager.Create();
    if (((Collection<MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit>) this.AuthorityManager.AuthorityLimitList).Count > 0)
      this.SelectedItem = ((Collection<MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit>) this.AuthorityManager.AuthorityLimitList)[0];
    this.ShowSendTaskQuote = !AuthorityLimitCheckManager.RunAuthorityCheckAtStartup;
    this.SendTaskContent = AuthorityLimitCheckManager.RunAuthorityCheckAtStartup ? "Send Task" : "Send Task (Bind)";
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
          int num = (int) this._msgBoxSvc.ShowMessageBox(validationResult.ErrorMessage, "Authority Limits", MessageBoxButton.OK);
        }
      }), (Func<bool>) (() => this.AuthorityManager.HasChanges));
    }
  }

  public RelayCommand FindUserCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        SearchObject searchObject = (SearchObject) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchSingle(IMSUser.GetUserList(), "Find User", "Name", "Name", (Action<SearchObject>) (r => searchObject = r));
        if (searchObject == null || !(searchObject.DefiningObject is IMSUser definingObject2))
          return;
        this.SelectedLimitUser.SendTaskUserGuid = new Guid?(definingObject2.UserGUID);
        this.SelectedLimitUser.SendTaskUserName = definingObject2.Name_FirstLast;
      }), (Func<bool>) (() => this.SelectedLimitUser != null));
    }
  }

  public RelayCommand ClearUserCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        if (this._msgBoxSvc.ShowMessageBox("Clear Assign Task User?", "Authority Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        this.SelectedLimitUser.SendTaskUserGuid = new Guid?();
        this.SelectedLimitUser.SendTaskUserName = "";
      }), (Func<bool>) (() => this.SelectedLimitUser != null && this.SelectedLimitUser.SendTaskUserGuid.HasValue));
    }
  }

  public RelayCommand AddUserCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        SearchObject searchObject = (SearchObject) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchSingle(IMSUser.GetUserList(), "Find User", "Name", "Name", (Action<SearchObject>) (r => searchObject = r));
        if (searchObject == null)
          return;
        this.SelectedUser = this.SelectedItem.AddUser(searchObject);
        this.UserCSV.View.Refresh();
        this.SelectedLimitUser = this.SelectedUser;
      }), (Func<bool>) (() => this.SelectedItem != null));
    }
  }

  public RelayCommand<object> RemoveUserCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) (collection =>
      {
        ICollectionView icollectionView = this.ToICollectionView((object) this.UserCSV.View);
        if (!(collection is AuthorityLimitUser authorityLimitUser3) || this._msgBoxSvc.ShowMessageBox($"Delete User '{authorityLimitUser3.UserName}'?", "Authority Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        IList ilist = this.ToIList(icollectionView);
        for (int index = ilist.Count - 1; index >= 0; --index)
        {
          if (ilist[index] is AuthorityLimitUser authorityLimitUser4 && authorityLimitUser4.UserGuid == authorityLimitUser3.UserGuid)
            ilist.RemoveAt(index);
        }
      }), (Predicate<object>) (collection => true));
    }
  }

  public RelayCommand<Guid> AddLimitToUserCommand
  {
    get
    {
      return new RelayCommand<Guid>((Action<Guid>) (uguid =>
      {
        this.SelectedUser = ((IEnumerable<AuthorityLimitUser>) this.SelectedItem.Users).Where<AuthorityLimitUser>((Func<AuthorityLimitUser, bool>) (u => u.UserGuid == uguid)).FirstOrDefault<AuthorityLimitUser>();
        this.UserCSV.View.Refresh();
        this.SelectedLimitUser = this.SelectedItem.AddLimitToUser(this.SelectedUser);
      }), (Predicate<Guid>) (uguid => true));
    }
  }

  public RelayCommand<object> RemoveLimitFromUserCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) (collection =>
      {
        ICollectionView icollectionView = this.ToICollectionView((object) this.UserCSV.View);
        if (!(collection is AuthorityLimitUser authorityLimitUser2))
          return;
        if (this._msgBoxSvc.ShowMessageBox($"Delete Limit for {authorityLimitUser2.DatabaseField} from User {authorityLimitUser2.UserName}?", "Authority Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        this.ToIList(icollectionView).Remove((object) authorityLimitUser2);
      }), (Predicate<object>) (collection => collection is AuthorityLimitUser authorityLimitUser3 && this.SelectedLimitUser != null && this.SelectedLimitUser.UserGuid == authorityLimitUser3.UserGuid));
    }
  }

  private ICollectionView ToICollectionView(object collection)
  {
    if (collection == null)
      throw new ArgumentNullException(nameof (collection));
    if (!(collection is ICollectionView collectionView))
      collectionView = CollectionViewSource.GetDefaultView(collection);
    return collectionView ?? throw new ArgumentNullException("Could not get an ICollectionView from collection");
  }

  private IList ToIList(ICollectionView iCollectionView)
  {
    if (iCollectionView == null)
      throw new ArgumentNullException("collection");
    if (iCollectionView.SourceCollection is IList sourceCollection)
      return sourceCollection;
    throw new InvalidCastException("View.Source cannot be null and must derive from IList");
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    switch (propertyName)
    {
      case "SelectedItem":
        if (this.SelectedItem == null)
          break;
        if (this.AuthorityManager.FetchChildren(this.SelectedItem.AuthorityLimitsID))
          this.SelectedItem.GetChildren();
        this.UserCSV.Source = (object) this.SelectedItem.Users;
        break;
      case "SelectedLimitUser":
        this.IsUserSelected = this.SelectedLimitUser != null;
        break;
    }
  }

  public RelayCommand FindDBFieldCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        SearchObject searchObject = (SearchObject) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchSingle(RaterField.GetDatabaseFields(this.SelectedItem.RatingTypeID), "Find Database Field", "Name", "Name", (Action<SearchObject>) (r => searchObject = r));
        if (searchObject == null || !(searchObject.DefiningObject is RaterField definingObject2))
          return;
        this.SelectedLimitUser.DatabaseField = definingObject2.DatabaseField;
      }), (Func<bool>) (() => this.SelectedItem != null && this.SelectedLimitUser != null));
    }
  }

  public RelayCommand ClearDBFieldCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        if (this._msgBoxSvc.ShowMessageBox("Clear Field?", "Authority Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        this.SelectedLimitUser.DatabaseField = "";
      }), (Func<bool>) (() => this.SelectedLimitUser != null && !string.IsNullOrEmpty(this.SelectedLimitUser.DatabaseField)));
    }
  }

  public List<ValidationResult> SubmitChanges() => this.AuthorityManager.SubmitChanges();

  public RelayCommand AddFieldCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        ObservableCollection<SearchObject> searchObjectList = (ObservableCollection<SearchObject>) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchMultiple(RaterField.GetDatabaseFields(this.SelectedItem.RatingTypeID), "Find Database Field", "Name", "Name", (Action<ObservableCollection<SearchObject>>) (r => searchObjectList = r));
        if (searchObjectList == null)
          return;
        this.SelectedItem.AddFields(searchObjectList);
      }), (Func<bool>) (() => this.SelectedItem != null));
    }
  }

  public RelayCommand<object> RemoveFieldCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) (collection =>
      {
        if (this._msgBoxSvc.ShowMessageBox("Delete Field?", "Authority Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        ICollectionView icollectionView = this.ToICollectionView(collection);
        if (icollectionView.CurrentItem == null)
          return;
        this.ToIList(icollectionView).Remove(icollectionView.CurrentItem);
      }), (Predicate<object>) (collection => this.SelectedField != null));
    }
  }

  public RelayCommand AddLineCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        ObservableCollection<SearchObject> searchObjectList = (ObservableCollection<SearchObject>) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchMultiple(Line.GetThresholdLines(), "Find Line", "Name", "Name", (Action<ObservableCollection<SearchObject>>) (r => searchObjectList = r));
        if (searchObjectList == null)
          return;
        this.SelectedField.AddLines(searchObjectList);
      }), (Func<bool>) (() => this.SelectedField != null));
    }
  }

  public RelayCommand<object> RemoveLineCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) (collection =>
      {
        if (this._msgBoxSvc.ShowMessageBox("Delete Line?", "Authority Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        ICollectionView icollectionView = this.ToICollectionView(collection);
        if (icollectionView.CurrentItem == null)
          return;
        this.ToIList(icollectionView).Remove(icollectionView.CurrentItem);
      }), (Predicate<object>) (collection => this.SelectedLine != null));
    }
  }
}
