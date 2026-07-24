// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.BindingChecklist.BindingChecklistQuote
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.BindingChecklist;

[Description("Binding Checklist at Polciy Level")]
[TableMapping("tblBindingChecklistQuote")]
public abstract class BindingChecklistQuote : ValidatingBindingObject
{
  [DataKey]
  [TableFieldMapping]
  public int? ID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual Guid Quoteguid { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual int BindingChecklistID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual Guid? UserGuid { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual DateTime? DateCompleted { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Comment { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool IsCompleted { get; set; }

  [TrackChanges]
  public virtual string Username { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual string Requirement { get; set; }

  [NotificationProperty]
  public virtual bool IsBind { get; set; }

  [NotificationProperty]
  public virtual bool IsIssue { get; set; }

  [NotificationProperty]
  public virtual bool IsQuote { get; set; }

  [NotificationProperty]
  public virtual string AdminBindingReqComment { get; set; }

  public static BindingChecklistQuote Create()
  {
    return NotifyProxyTypeManager.Allocate<BindingChecklistQuote>();
  }

  public static BindingChecklistQuote Create(
    int ID,
    Guid Quoteguid,
    int BindingChecklistID,
    Guid? UserGuid,
    DateTime? DateCompleted,
    string Comment,
    bool IsCompleted,
    string Username,
    string Requirement,
    bool IsBind,
    bool IsIssue,
    bool IsQuote,
    string AdminBindingReqComment)
  {
    return NotifyProxyTypeManager.Allocate<BindingChecklistQuote>(new object[13]
    {
      (object) ID,
      (object) Quoteguid,
      (object) BindingChecklistID,
      (object) UserGuid,
      (object) DateCompleted,
      (object) Comment,
      (object) IsCompleted,
      (object) Username,
      (object) Requirement,
      (object) IsBind,
      (object) IsIssue,
      (object) IsQuote,
      (object) AdminBindingReqComment
    });
  }

  public BindingChecklistQuote()
  {
  }

  public BindingChecklistQuote(
    int mID,
    Guid mQuoteguid,
    int mbBindingChecklistID,
    Guid mUserGuid,
    DateTime mDateCompleted,
    string mComment,
    bool mIsCompleted,
    string mUsername,
    string mRequirement,
    bool mIsBind,
    bool mIsIssue,
    bool mIsQuote,
    string mAdminBindingReqComment)
  {
    this.ID = new int?(mID);
    this.Quoteguid = mQuoteguid;
    this.BindingChecklistID = mbBindingChecklistID;
    this.UserGuid = new Guid?(mUserGuid);
    this.DateCompleted = !(mDateCompleted == DateTime.MinValue) ? new DateTime?(mDateCompleted) : new DateTime?();
    this.Comment = mComment;
    this.IsCompleted = mIsCompleted;
    this.Username = mUsername;
    this.Requirement = mRequirement;
    this.IsBind = mIsBind;
    this.IsIssue = mIsIssue;
    this.IsQuote = mIsQuote;
    this.AdminBindingReqComment = mAdminBindingReqComment;
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    ((BindingObject) this).OnPropertyChanged(propertyName);
    if (!(propertyName == "IsCompleted"))
      return;
    if (this.IsCompleted)
    {
      this.DateCompleted = new DateTime?(DateTime.Now);
      this.UserGuid = new Guid?(CurrentUser.Instance.UserGUID);
      this.Username = CurrentUser.Instance.UserName;
    }
    else
      this.DateCompleted = new DateTime?();
  }

  public static ObservableCollection<BindingChecklistQuote> GetList(Guid quoteguid)
  {
    return new ObservableCollection<BindingChecklistQuote>((IEnumerable<BindingChecklistQuote>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "sp_GetBindingChecklistQuoteData", new object[2]
    {
      (object) "@quoteguid",
      (object) quoteguid
    }).AsEnumerable().Select<DataRow, BindingChecklistQuote>((System.Func<DataRow, BindingChecklistQuote>) (row => BindingChecklistQuote.Create(row.Field<int>("ID"), row.Field<Guid>("Quoteguid"), row.Field<int>("BindingChecklistID"), row.Field<Guid?>("UserGuid"), row.Field<DateTime?>("dateCompleted"), row.Field<string>("comment"), row.Field<bool>("isCompleted"), row.Field<string>("username"), row.Field<string>("Requirement"), row.Field<bool>("IsBind"), row.Field<bool>("IsIssue"), row.Field<bool>("IsQuote"), row.Field<string>("AdminBindingReqComment")))));
  }
}
