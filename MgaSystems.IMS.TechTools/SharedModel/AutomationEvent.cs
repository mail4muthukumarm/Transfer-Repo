// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.SharedModel.AutomationEvent
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Data;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MgaSystems.IMS.TechTools.AutomationEventAdmin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.SharedModel;

[TableMapping("lstAutomationDocumentEvents")]
public abstract class AutomationEvent : BindingObject
{
  public AutomationEventManager Parent { get; }

  [DataKey]
  [TableFieldMapping]
  [Required]
  [NotificationProperty]
  public virtual Guid EventGuid { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string EventName { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual byte DocumentAutomationGroupID { get; set; }

  [TrackChanges]
  [TableFieldMapping("SendtoDocHandler")]
  [NotificationProperty]
  public virtual bool SendToDocHandler { get; set; }

  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool SystemDefined { get; set; }

  internal static AutomationEvent Create(DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<AutomationEvent>(new object[1]
    {
      (object) row
    });
  }

  public AutomationEvent(DataRow automationEventRow) => this.LoadData(automationEventRow);

  internal static AutomationEvent Create(AutomationEventManager parent, DataRow automationEventRow)
  {
    return NotifyProxyTypeManager.Allocate<AutomationEvent>(new object[2]
    {
      (object) parent,
      (object) automationEventRow
    });
  }

  public AutomationEvent(AutomationEventManager parent, DataRow automationEventRow)
  {
    this.Parent = parent;
    this.LoadData(automationEventRow);
  }

  internal static AutomationEvent Create(AutomationEventManager parent)
  {
    return NotifyProxyTypeManager.Allocate<AutomationEvent>(new object[1]
    {
      (object) parent
    });
  }

  public AutomationEvent(AutomationEventManager parent)
  {
    this.Parent = parent;
    this.EventGuid = Guid.NewGuid();
  }

  private void LoadData(DataRow automationEventRow)
  {
    this.EventGuid = automationEventRow.Field<Guid>("EventGuid");
    this.EventName = automationEventRow.Field<string>("EventName");
    this.DocumentAutomationGroupID = automationEventRow.Field<byte>("DocumentAutomationGroupID");
    this.SendToDocHandler = automationEventRow.Field<bool>("SendtoDocHandler");
    this.SystemDefined = automationEventRow.Field<bool>("SystemDefined");
  }

  public static ObservableCollection<SearchObject> GetEventList()
  {
    return new ObservableCollection<SearchObject>((IEnumerable<SearchObject>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.spGetAutomationDocumentEvents").AsEnumerable().Select<DataRow, SearchObject>((System.Func<DataRow, SearchObject>) (row => SearchObject.Create(0, row.Field<string>("EventName"), (object) AutomationEvent.Create(row)))));
  }
}
