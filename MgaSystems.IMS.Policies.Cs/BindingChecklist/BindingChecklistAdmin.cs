// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.BindingChecklist.BindingChecklistAdmin
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.BindingChecklist;

[Description("Binding Checklist Administration")]
[TableMapping("tblBindingChecklistAdmin")]
public abstract class BindingChecklistAdmin : ValidatingBindingObject
{
  [DataKey]
  [TableFieldMapping]
  public int? ID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Requirement { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool IsBind { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool IsIssue { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool IsQuote { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Comment { get; set; }

  public static BindingChecklistAdmin Create()
  {
    return NotifyProxyTypeManager.Allocate<BindingChecklistAdmin>();
  }

  public static BindingChecklistAdmin Create(
    int ID,
    string Requirement,
    bool IsBind,
    bool IsIssue,
    bool IsQuote,
    string Comment)
  {
    return NotifyProxyTypeManager.Allocate<BindingChecklistAdmin>(new object[6]
    {
      (object) ID,
      (object) Requirement,
      (object) IsBind,
      (object) IsIssue,
      (object) IsQuote,
      (object) Comment
    });
  }

  public BindingChecklistAdmin()
  {
  }

  public BindingChecklistAdmin(
    int iD,
    string requirement,
    bool isBind,
    bool isIssue,
    bool isQuote,
    string comment)
  {
    this.ID = new int?(iD);
    this.Requirement = requirement;
    this.IsBind = isBind;
    this.IsIssue = isIssue;
    this.IsQuote = isQuote;
    this.Comment = comment;
  }

  public static ObservableCollection<BindingChecklistAdmin> GetList()
  {
    return new ObservableCollection<BindingChecklistAdmin>((IEnumerable<BindingChecklistAdmin>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "sp_GetBindingChecklistAdminData").AsEnumerable().Select<DataRow, BindingChecklistAdmin>((System.Func<DataRow, BindingChecklistAdmin>) (row => BindingChecklistAdmin.Create(row.Field<int>("ID"), row.Field<string>("Requirement"), row.Field<bool>("IsBind"), row.Field<bool>("IsIssue"), row.Field<bool>("IsQuote"), row.Field<string>("Comment")))));
  }
}
