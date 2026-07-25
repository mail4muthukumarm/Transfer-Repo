// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.AutomationDocumentEventModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

[TableMapping("lstAutomationDocumentEvents")]
public class AutomationDocumentEventModel
{
  [TableFieldMapping("EventGuid")]
  public Guid EventGuid { get; set; }

  [TableFieldMapping("EventName")]
  public string EventName { get; set; }

  public AutomationDocumentEventModel(Guid eventGuid, string eventName)
  {
    this.EventGuid = eventGuid;
    this.EventName = eventName;
  }

  public AutomationDocumentEventModel(DataRow automationDocumentEvent)
    : this(ExtensionsMethods.FieldAs<Guid>(automationDocumentEvent, nameof (EventGuid), DataRowVersion.Current), automationDocumentEvent.Field<string>(nameof (EventName)))
  {
  }
}
