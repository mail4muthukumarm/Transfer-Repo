// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.SharedModel.QuoteStatus
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MgaSystems.IMS.TechTools.QuoteStatusAdmin.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.SharedModel;

[TableMapping("lstQuoteStatus")]
public abstract class QuoteStatus : ValidatingBindingObject
{
  public QuoteStatusManager Parent { get; }

  [DataKey]
  [TableFieldMapping]
  [Required]
  [NotificationProperty]
  public virtual byte QuoteStatusID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool Bound { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Description { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool ReasonRequired { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool UserSelectable { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string AutomationCode { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool CanExpire { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string EmbeddedImageName { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual Guid? EventGuid { get; set; }

  [NotificationProperty]
  public virtual string EventName { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual byte? SortOrder { get; set; }

  internal static QuoteStatus Create(QuoteStatusManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<QuoteStatus>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public QuoteStatus(QuoteStatusManager parent, DataRow row)
  {
    this.Parent = parent;
    this.QuoteStatusID = row.Field<byte>(nameof (QuoteStatusID));
    this.Bound = row.Field<bool>(nameof (Bound));
    this.Description = row.Field<string>(nameof (Description));
    this.ReasonRequired = row.Field<bool>(nameof (ReasonRequired));
    this.UserSelectable = row.Field<bool>(nameof (UserSelectable));
    this.AutomationCode = row.Field<string>(nameof (AutomationCode));
    this.CanExpire = row.Field<bool>(nameof (CanExpire));
    this.EmbeddedImageName = row.Field<string>(nameof (EmbeddedImageName));
    this.EventGuid = row.Field<Guid?>(nameof (EventGuid));
    this.EventName = row.Field<string>(nameof (EventName));
    this.SortOrder = row.Field<byte?>(nameof (SortOrder));
  }

  internal static QuoteStatus Create(QuoteStatusManager parent)
  {
    return NotifyProxyTypeManager.Allocate<QuoteStatus>(new object[1]
    {
      (object) parent
    });
  }

  public QuoteStatus(QuoteStatusManager parent)
  {
    this.Parent = parent;
    this.QuoteStatusID = DefaultDatabase.ExecuteScalar<byte>(CommandType.StoredProcedure, "spGetNextCustomQuoteStatusID");
  }
}
