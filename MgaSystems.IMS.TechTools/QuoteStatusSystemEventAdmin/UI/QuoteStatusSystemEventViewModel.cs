// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.UI.QuoteStatusSystemEventViewModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.Model;
using System;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.UI;

public abstract class QuoteStatusSystemEventViewModel : BindingObject
{
  private const string HideText = "Hidden";
  private const string ShowText = "Visible";
  private string _selectedQuoteStatus;
  private string _selectedEvent;
  private string _duplicateEntryError = "Hidden";

  public static QuoteStatusSystemEventViewModel Create()
  {
    return NotifyProxyTypeManager.Allocate<QuoteStatusSystemEventViewModel>();
  }

  [NotificationProperty]
  public virtual QuoteStatusSystemEventManager QuoteStatusSystemEventManager { get; set; } = QuoteStatusSystemEventManager.Create();

  [TrackChanges]
  public string DuplicateEntryError
  {
    get => this._duplicateEntryError;
    set
    {
      this._duplicateEntryError = value;
      this.OnPropertyChanged(nameof (DuplicateEntryError));
    }
  }

  [TrackChanges]
  public string SelectedQuoteStatus
  {
    get => this._selectedQuoteStatus;
    set
    {
      this._selectedQuoteStatus = value;
      this.OnPropertyChanged(nameof (SelectedQuoteStatus));
      this.OnPropertyChanged("SaveCommand");
    }
  }

  [TrackChanges]
  public string SelectedEvent
  {
    get => this._selectedEvent;
    set
    {
      this._selectedEvent = value;
      this.OnPropertyChanged(nameof (SelectedEvent));
      this.OnPropertyChanged("SaveCommand");
    }
  }

  public RelayCommand SaveCommand
  {
    get
    {
      return new RelayCommand((Action) (() => this.QuoteStatusSystemEventManager.SaveNewRowUserSelection()), (Func<bool>) (() =>
      {
        this.DuplicateEntryError = this.QuoteStatusSystemEventManager.IsDuplicateNewRowUserSelection() ? "Visible" : "Hidden";
        return this.QuoteStatusSystemEventManager.IsValidNewRowUserSelection();
      }));
    }
  }

  public RelayCommand AddCommand
  {
    get
    {
      return new RelayCommand((Action) (() => this.QuoteStatusSystemEventManager.CreateNewRowUserSelection()), (Func<bool>) (() => !this.QuoteStatusSystemEventManager.NewRowUserSelectionExists()));
    }
  }

  public List<ValidationResult> SubmitChanges()
  {
    return this.QuoteStatusSystemEventManager.SubmitChanges();
  }

  public bool HasChanges => this.QuoteStatusSystemEventManager.HasChanges;
}
