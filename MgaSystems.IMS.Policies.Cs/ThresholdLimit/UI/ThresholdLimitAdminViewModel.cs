// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.UI.ThresholdLimitAdminViewModel
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
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using MgaSystems.IMS.Policies.ThresholdLimit.Lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.UI;

public abstract class ThresholdLimitAdminViewModel : BindingObject, ISubmittable
{
  private readonly IWinMsgBoxService _msgBoxSvc;

  [NotificationProperty]
  public virtual ThresholdLimitManager ThresholdManager { get; set; }

  [NotificationProperty]
  public virtual ThresholdLimitRater SelectedRater { get; set; }

  [NotificationProperty]
  public virtual MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit SelectedLimit { get; set; }

  [NotificationProperty]
  public virtual CollectionViewSource ThresholdCSV { get; set; }

  [NotificationProperty]
  public virtual CollectionViewSource RaterCSV { get; set; }

  [NotificationProperty]
  public virtual bool IsThresholdSelected { get; set; }

  [NotificationProperty]
  public virtual string FilterRater { get; set; }

  public bool HasChanges => this.ThresholdManager != null && this.ThresholdManager.HasChanges;

  internal static ThresholdLimitAdminViewModel Create(IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitAdminViewModel>(new object[1]
    {
      (object) msgBoxService
    });
  }

  public ThresholdLimitAdminViewModel(IWinMsgBoxService msgBoxService)
  {
    this._msgBoxSvc = msgBoxService;
    this.ThresholdCSV = new CollectionViewSource();
    this.RaterCSV = new CollectionViewSource();
    this.ThresholdManager = ThresholdLimitManager.Create();
    if (((Collection<ThresholdLimitRater>) this.ThresholdManager.ThresholdRaterList).Count > 0)
      this.SelectedRater = ((Collection<ThresholdLimitRater>) this.ThresholdManager.ThresholdRaterList)[0];
    this.RaterCSV.Source = (object) this.ThresholdManager.ThresholdRaterList;
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
          int num = (int) this._msgBoxSvc.ShowMessageBox(validationResult.ErrorMessage, "Threshold Limits", MessageBoxButton.OK);
        }
      }), (Func<bool>) (() => this.ThresholdManager.HasChanges));
    }
  }

  public List<ValidationResult> SubmitChanges() => this.ThresholdManager.SubmitChanges();

  public RelayCommand AddThresholdCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit thresholdLimit = MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit.Create(this.SelectedRater);
        ((Collection<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit>) this.SelectedRater.Thresholds).Add(thresholdLimit);
        this.ThresholdCSV.View.Refresh();
        this.SelectedLimit = thresholdLimit;
      }), (Func<bool>) (() => this.SelectedRater != null));
    }
  }

  public RelayCommand<object> RemoveThresholdCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) (collection =>
      {
        if (this._msgBoxSvc.ShowMessageBox("Delete Threshold?", "Threshold Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        ICollectionView icollectionView = this.ToICollectionView(collection);
        if (icollectionView.CurrentItem == null)
          return;
        this.ToIList(icollectionView).Remove(icollectionView.CurrentItem);
      }), (Predicate<object>) (collection => true));
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
        this.SelectedLimit.AddLines(searchObjectList);
      }), (Func<bool>) (() => this.SelectedLimit != null));
    }
  }

  public RelayCommand<object> RemoveLineCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) (collection =>
      {
        if (this._msgBoxSvc.ShowMessageBox("Delete Line?", "Threshold Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        ICollectionView icollectionView = this.ToICollectionView(collection);
        if (icollectionView.CurrentItem == null)
          return;
        this.ToIList(icollectionView).Remove(icollectionView.CurrentItem);
      }), (Predicate<object>) (collection => this.SelectedLimit != null));
    }
  }

  private ICollectionView ToICollectionView(object collection)
  {
    if (collection == null)
      throw new ArgumentNullException(nameof (collection));
    if (!(collection is ICollectionView collectionView))
      collectionView = CollectionViewSource.GetDefaultView(collection);
    return collectionView != null ? collectionView : throw new ArgumentNullException("Could not get an ICollectionView from collection");
  }

  private IList ToIList(ICollectionView iCollectionView)
  {
    if (iCollectionView == null)
      throw new ArgumentNullException("collection");
    if (iCollectionView.SourceCollection is IList sourceCollection)
      return sourceCollection;
    throw new InvalidCastException("View.Source cannot be null and must derive from IList");
  }

  public RelayCommand FindDBFieldCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        SearchObject searchObject = (SearchObject) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchSingle(RaterField.GetDatabaseFields(this.SelectedRater.RatingTypeID), "Find Database Field", "Name", "Name", (Action<SearchObject>) (r => searchObject = r));
        if (searchObject == null || !(searchObject.DefiningObject is RaterField definingObject2))
          return;
        if (this.SelectedRater.RaterContainsDatabaseField(definingObject2.DatabaseField, this.SelectedLimit.cnID))
        {
          int num = (int) this._msgBoxSvc.ShowMessageBox($"A threshold already exists for Database Field {definingObject2.DatabaseField}.  Please select a different field.", "Threshold Limits Administration", MessageBoxButton.OK);
        }
        else
          this.SelectedLimit.DatabaseField = definingObject2.DatabaseField;
      }), (Func<bool>) (() => this.SelectedRater != null && this.SelectedLimit != null));
    }
  }

  public RelayCommand ClearDBFieldCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        if (this._msgBoxSvc.ShowMessageBox("Clear Field?", "Threshold Limits Administration", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        this.SelectedLimit.DatabaseField = "";
      }), (Func<bool>) (() => this.SelectedLimit != null && !string.IsNullOrEmpty(this.SelectedLimit.DatabaseField)));
    }
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    switch (propertyName)
    {
      case "SelectedRater":
        if (this.SelectedRater == null)
          break;
        if (this.ThresholdManager.FetchThresholds(this.SelectedRater.ThresholdLimitRaterID))
          this.SelectedRater.GetThresholds();
        this.ThresholdCSV.Source = (object) this.SelectedRater.Thresholds;
        break;
      case "SelectedLimit":
        this.IsThresholdSelected = this.SelectedLimit != null;
        break;
      case "FilterRater":
        this.RaterCSV.Filter += (FilterEventHandler) ((s, e) =>
        {
          ThresholdLimitRater thresholdLimitRater = e.Item as ThresholdLimitRater;
          if (string.IsNullOrEmpty(this.FilterRater))
            e.Accepted = true;
          else
            e.Accepted = thresholdLimitRater.RatingType.ToLower().Contains(this.FilterRater);
        });
        break;
    }
  }
}
