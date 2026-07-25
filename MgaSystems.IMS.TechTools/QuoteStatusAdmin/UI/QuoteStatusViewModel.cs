// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.QuoteStatusAdmin.UI.QuoteStatusViewModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using MgaSystems.IMS.TechTools.QuoteStatusAdmin.Model;
using MgaSystems.IMS.TechTools.SharedModel;
using System;
using System.Collections.Generic;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.TechTools.QuoteStatusAdmin.UI;

public abstract class QuoteStatusViewModel : BindingObject, ISubmittable
{
  private readonly IWinMsgBoxService msgBoxSvc;

  [NotificationProperty]
  public virtual QuoteStatusManager QuoteStatusManager { get; set; }

  [NotificationProperty]
  public virtual QuoteStatus SelectedItem { get; set; }

  internal static QuoteStatusViewModel Create(IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<QuoteStatusViewModel>(new object[1]
    {
      (object) msgBoxService
    });
  }

  public QuoteStatusViewModel(IWinMsgBoxService msgBoxService)
  {
    this.msgBoxSvc = msgBoxService;
    this.QuoteStatusManager = QuoteStatusManager.Create();
  }

  public RelayCommand SaveCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        foreach (ValidationResult submitChange in this.SubmitChanges())
        {
          int num = (int) this.msgBoxSvc.ShowMessageBox(submitChange.ErrorMessage, "Quote Status Admin", MessageBoxButton.OK);
        }
      }), (Func<bool>) (() => this.QuoteStatusManager.HasChanges));
    }
  }

  public List<ValidationResult> SubmitChanges() => this.QuoteStatusManager.SubmitChanges();

  public RelayCommand FindEventCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        SearchObject searchObject = (SearchObject) null;
        ((ISearchService) new SearchService()).ShowSimpleSearchSingle(AutomationEvent.GetEventList(), "Find Event", "Event Name", "Event Name", (Action<SearchObject>) (r => searchObject = r));
        if (!(searchObject?.DefiningObject is AutomationEvent definingObject2))
          return;
        this.SelectedItem.EventGuid = new Guid?(definingObject2.EventGuid);
        this.SelectedItem.EventName = definingObject2.EventName;
      }), (Func<bool>) (() => this.SelectedItem != null));
    }
  }

  public RelayCommand ClearEventCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        if (this.msgBoxSvc.ShowMessageBox("Clear Event?", "Quote Status Admin", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
          return;
        this.SelectedItem.EventGuid = new Guid?();
        this.SelectedItem.EventName = "";
      }), (Func<bool>) (() =>
      {
        QuoteStatus selectedItem = this.SelectedItem;
        return selectedItem != null && selectedItem.EventGuid.HasValue;
      }));
    }
  }

  public RelayCommand AddQuoteStatusCommand
  {
    get
    {
      return new RelayCommand((Action) (() => this.SelectedItem = this.QuoteStatusManager.NewQuoteStatus()), (Func<bool>) (() => true));
    }
  }

  public bool HasChanges => this.QuoteStatusManager.HasChanges;
}
