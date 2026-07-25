// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.Model.QuoteStatusSystemEventModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.Data.Binding;
using MGASystems.Data.DataMapping;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.Model;

[TableMapping("lstQuoteStatusEventsExt")]
public class QuoteStatusSystemEventModel : BindingObject
{
  [DataKey]
  [TableFieldMapping]
  public int Id { get; set; }

  [TableFieldMapping("QuoteStatusID")]
  public int QuoteStatusId { get; set; }

  [TableFieldMapping("EventGuid")]
  public Guid EventGuid { get; set; }

  public string QuoteStatus { get; set; }

  public string EventName { get; set; }

  public bool IsEnabledComboBox => this.Id < 1;

  public static QuoteStatusSystemEventModel Create(
    int id,
    int quoteStatusID,
    string quoteStatus,
    string eventName,
    Guid eventGuid)
  {
    return NotifyProxyTypeManager.Allocate<QuoteStatusSystemEventModel>(new object[5]
    {
      (object) id,
      (object) quoteStatusID,
      (object) quoteStatus,
      (object) eventName,
      (object) eventGuid
    });
  }

  public QuoteStatusSystemEventModel(
    int id,
    int quoteStatusID,
    string quoteStatus,
    string eventName,
    Guid eventGuid)
  {
    this.Id = id;
    this.QuoteStatusId = quoteStatusID;
    this.QuoteStatus = quoteStatus;
    this.EventName = eventName;
    this.EventGuid = eventGuid;
  }

  public QuoteStatusSystemEventModel(DataRow dr)
  {
    this.Id = dr.Field<int>(nameof (Id));
    this.QuoteStatusId = dr.Field<int>("QuoteStatusID");
    this.QuoteStatus = dr.Field<string>("QuoteStatusName");
    this.EventName = dr.Field<string>(nameof (EventName));
    this.EventGuid = dr.Field<Guid>(nameof (EventGuid));
  }

  public override bool Equals(object obj)
  {
    return obj is QuoteStatusSystemEventModel systemEventModel && this.QuoteStatusId == systemEventModel.QuoteStatusId && this.EventGuid.Equals(systemEventModel.EventGuid);
  }
}
