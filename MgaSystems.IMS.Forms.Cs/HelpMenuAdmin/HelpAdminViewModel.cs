// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.HelpMenuAdmin.HelpAdminViewModel
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Forms.HelpMenuAdmin;

public abstract class HelpAdminViewModel : BindingObject, ISubmittable
{
  private IWinMsgBoxService msgBoxSvc;

  [NotificationProperty]
  public virtual HelpAdminManager HelpAdminManager { get; set; }

  [NotificationProperty]
  public virtual HelpItemModel SelectedItem { get; set; }

  public bool HasChanges => this.HelpAdminManager.HasChanges;

  public static HelpAdminViewModel Create(IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<HelpAdminViewModel>(new object[1]
    {
      (object) msgBoxService
    });
  }

  public HelpAdminViewModel(IWinMsgBoxService msgBoxService) => this.msgBoxSvc = msgBoxService;

  public void LoadData()
  {
    this.HelpAdminManager = HelpAdminManager.Create();
    if (((Collection<HelpItemModel>) this.HelpAdminManager.HelpItems).Count <= 0)
      return;
    this.SelectedItem = ((Collection<HelpItemModel>) this.HelpAdminManager.HelpItems)[0];
  }

  public RelayCommand SaveCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        foreach (ValidationResult submitChange in this.SubmitChanges())
        {
          int num = (int) this.msgBoxSvc.ShowMessageBox(submitChange.ErrorMessage, "Help Menu Tools", MessageBoxButton.OK);
        }
      }), (Func<bool>) (() => this.HelpAdminManager.HasChanges));
    }
  }

  public List<ValidationResult> SubmitChanges() => this.HelpAdminManager.SubmitChanges();

  public RelayCommand AddHelpMenuCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        this.SelectedItem = HelpItemModel.Create();
        ((Collection<HelpItemModel>) this.HelpAdminManager.HelpItems).Add(this.SelectedItem);
      }), (Func<bool>) (() => true));
    }
  }

  public RelayCommand<object> DeleteHelpMenuCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) (collection =>
      {
        if (this.msgBoxSvc.ShowMessageBox("Delete Help Menu Item?", "Help Menu Tools", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        ICollectionView icollectionView = this.ToICollectionView(collection);
        if (icollectionView.CurrentItem == null)
          return;
        this.ToIList(icollectionView).Remove(icollectionView.CurrentItem);
      }), (Predicate<object>) (collection => collection != null && this.ToICollectionView(collection).CurrentItem != null));
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
}
