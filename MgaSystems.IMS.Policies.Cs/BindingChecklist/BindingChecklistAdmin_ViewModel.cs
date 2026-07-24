// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.BindingChecklist.BindingChecklistAdmin_ViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

#nullable disable
namespace MgaSystems.IMS.Policies.BindingChecklist;

public abstract class BindingChecklistAdmin_ViewModel : ValidatingBindingObject, ISubmittable
{
  [TrackChanges]
  [NotificationProperty]
  public virtual ObservableCollection<BindingChecklistAdmin> pBindingChecklistAdmin { get; set; }

  [NotificationProperty]
  public virtual BindingChecklistAdmin SelectedIteminGrid { get; set; }

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  public static BindingChecklistAdmin_ViewModel Create()
  {
    return NotifyProxyTypeManager.Allocate<BindingChecklistAdmin_ViewModel>();
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  public BindingChecklistAdmin_ViewModel()
  {
    this.pBindingChecklistAdmin = BindingChecklistAdmin.GetList();
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public RelayCommand SaveCommand
  {
    get
    {
      return new RelayCommand((Action) (() => this.SubmitChanges()), (Func<bool>) (() => this.HasChanges));
    }
  }

  public RelayCommand AddCommand
  {
    get => new RelayCommand((Action) (() => this.AddRow()), (Func<bool>) (() => true));
  }

  public RelayCommand RemoveItem
  {
    get
    {
      return new RelayCommand((Action) (() => this.deleteRow()), (Func<bool>) (() => this.SelectedIteminGrid != null));
    }
  }

  public void deleteRow() => this.pBindingChecklistAdmin.Remove(this.SelectedIteminGrid);

  public void AddRow()
  {
    BindingChecklistAdmin bindingChecklistAdmin = BindingChecklistAdmin.Create();
    bindingChecklistAdmin.IsBind = false;
    bindingChecklistAdmin.IsIssue = false;
    bindingChecklistAdmin.IsQuote = false;
    this.SelectedIteminGrid = bindingChecklistAdmin;
    this.pBindingChecklistAdmin.Add(bindingChecklistAdmin);
  }
}
