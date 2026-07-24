// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.FCWComments.NetrateFCWListViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using MgaSystems.IMS.Policies.FCWComments.LIb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.FCWComments;

public abstract class NetrateFCWListViewModel : BindingObject
{
  private readonly IWinMsgBoxService _msgBoxSvc;

  [NotificationProperty]
  public virtual FCWConditionList SelectedItem { get; set; }

  [NotificationProperty]
  public virtual FCWConditionListManager ConditionListManager { get; set; }

  [NotificationProperty]
  public virtual CollectionViewSource ConditionCVS { get; set; } = new CollectionViewSource();

  [NotificationProperty]
  public virtual string FilterCondition { get; set; }

  internal static NetrateFCWListViewModel Create(IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<NetrateFCWListViewModel>(new object[1]
    {
      (object) msgBoxService
    });
  }

  public NetrateFCWListViewModel(IWinMsgBoxService msgBoxService)
  {
    this._msgBoxSvc = msgBoxService;
    this.ConditionListManager = FCWConditionListManager.Create();
    if (((Collection<FCWConditionList>) this.ConditionListManager.CodeList).Count > 0)
      this.SelectedItem = ((Collection<FCWConditionList>) this.ConditionListManager.CodeList)[0];
    this.ConditionCVS.Source = (object) this.ConditionListManager.CodeList;
    this.ConditionCVS.Filter += (FilterEventHandler) ((s, e) =>
    {
      FCWConditionList fcwConditionList = e.Item as FCWConditionList;
      e.Accepted = string.IsNullOrEmpty(this.FilterCondition) || fcwConditionList.FCWConditionName.IndexOf(this.FilterCondition, StringComparison.CurrentCultureIgnoreCase) >= 0;
    });
  }

  public RelayCommand SaveCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        List<ValidationResult> validationResultList = this.ConditionListManager.SubmitChanges();
        if (validationResultList.Count <= 0)
          return;
        foreach (ValidationResult validationResult in validationResultList)
        {
          int num = (int) this._msgBoxSvc.ShowMessageBox(validationResult.ErrorMessage, "FCW Comments", MessageBoxButton.OK);
        }
      }), (Func<bool>) (() => this.ConditionListManager.HasChanges));
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

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    if (!(propertyName == "FilterCondition"))
      return;
    this.ConditionCVS.View.Refresh();
  }
}
