// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.Model.QuoteStatusSystemEventManager
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using MgaSystems.IMS.TechTools.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.Model;

public abstract class QuoteStatusSystemEventManager : ValidatingBindingObject
{
  private int NewElementID { get; } = -1;

  public static QuoteStatusSystemEventManager Create()
  {
    return NotifyProxyTypeManager.Allocate<QuoteStatusSystemEventManager>();
  }

  [NotificationProperty]
  public virtual ObservableCollection<QuoteStatusModel> QuoteStatuses { get; set; } = new ObservableCollection<QuoteStatusModel>();

  [NotificationProperty]
  public virtual ObservableCollection<AutomationDocumentEventModel> SystemEvents { get; set; } = new ObservableCollection<AutomationDocumentEventModel>();

  [NotificationProperty]
  [TrackChanges]
  public virtual ObservableCollection<QuoteStatusSystemEventModel> QuoteStatusSystemEventList { get; set; } = new ObservableCollection<QuoteStatusSystemEventModel>();

  private QuoteStatusSystemEventModel NewRowUserSelection { get; set; }

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  public QuoteStatusSystemEventManager()
  {
    this.LoadControls();
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  public void CreateNewRowUserSelection()
  {
    if (this.NewRowUserSelectionExists())
      return;
    this.NewRowUserSelection = new QuoteStatusSystemEventModel(this.NewElementID, 0, string.Empty, string.Empty, Guid.Empty);
    this.QuoteStatusSystemEventList.Add(this.NewRowUserSelection);
  }

  public bool NewRowUserSelectionExists() => this.NewRowUserSelection != null;

  public bool IsPopulatedNewRowUserSelection()
  {
    return this.NewRowUserSelectionExists() && this.NewRowUserSelection.QuoteStatusId > 0 && this.NewRowUserSelection.EventGuid != Guid.Empty;
  }

  public bool IsDuplicateNewRowUserSelection()
  {
    return this.IsPopulatedNewRowUserSelection() && this.QuoteStatusSystemEventList.Where<QuoteStatusSystemEventModel>((System.Func<QuoteStatusSystemEventModel, bool>) (p => ((object) p).Equals((object) this.NewRowUserSelection))).Count<QuoteStatusSystemEventModel>() > 1;
  }

  public bool IsValidNewRowUserSelection()
  {
    return this.IsPopulatedNewRowUserSelection() && !this.IsDuplicateNewRowUserSelection();
  }

  private void LoadControls()
  {
    this.LoadComboBoxes();
    this.LoadSystemEventList();
  }

  public void SaveNewRowUserSelection()
  {
    if (!this.IsValidNewRowUserSelection())
      return;
    this.SubmitChanges();
    this.LoadSystemEventList();
    this.NewRowUserSelection = (QuoteStatusSystemEventModel) null;
  }

  private void LoadComboBoxes()
  {
    string[] strArray = new string[2]
    {
      "lstQuoteStatus",
      "lstAutomationDocumentEvents"
    };
    DataSet dataSet = new DataSet();
    DefaultDatabase.LoadDataSet(dataSet, strArray, "dbo.GetQuoteStatusAutomationEvents");
    this.LoadQuoteStatusCombo(dataSet.Tables[0]);
    this.LoadSystemEventCombo(dataSet.Tables[1]);
  }

  private void LoadQuoteStatusCombo(DataTable quoteStatuses)
  {
    this.QuoteStatuses.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) quoteStatuses.Rows)
      this.QuoteStatuses.Add(QuoteStatusModel.Create(row));
  }

  private void LoadSystemEventCombo(DataTable automationDocumentEvents)
  {
    this.SystemEvents.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) automationDocumentEvents.Rows)
      this.SystemEvents.Add(new AutomationDocumentEventModel(row));
  }

  private void LoadSystemEventList()
  {
    this.ChangeManager.SuspendMonitoring((Action) (() =>
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetQuoteStatusEventsExt");
      this.QuoteStatusSystemEventList.Clear();
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
        this.QuoteStatusSystemEventList.Add(new QuoteStatusSystemEventModel(row));
    }));
  }
}
