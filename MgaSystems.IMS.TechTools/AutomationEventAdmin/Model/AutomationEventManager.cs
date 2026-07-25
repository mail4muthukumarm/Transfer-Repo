// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.AutomationEventAdmin.Model.AutomationEventManager
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using MgaSystems.IMS.TechTools.SharedModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.AutomationEventAdmin.Model;

public abstract class AutomationEventManager : ValidatingBindingObject
{
  [TrackChanges]
  public virtual BulkObservableCollection<AutomationEvent> AutomationEventList { get; } = new BulkObservableCollection<AutomationEvent>();

  public ObservableCollection<DocumentAutomationGroup> DocumentAutomationGroups { get; } = DocumentAutomationGroup.GetDocumentAutomationGroups();

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  internal static AutomationEventManager Create()
  {
    return NotifyProxyTypeManager.Allocate<AutomationEventManager>();
  }

  public AutomationEventManager()
  {
    this.AutomationEventList.AddRange((IEnumerable<AutomationEvent>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.spGetAutomationDocumentEvents").AsEnumerable().Select<DataRow, AutomationEvent>((System.Func<DataRow, AutomationEvent>) (row => AutomationEvent.Create(this, row))));
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  public AutomationEvent NewAutomationEvent()
  {
    AutomationEvent automationEvent = AutomationEvent.Create(this);
    ((Collection<AutomationEvent>) this.AutomationEventList).Add(automationEvent);
    return automationEvent;
  }
}
