// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimitUser
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

[TableMapping("cnAuthorityLimitsUser")]
public abstract class AuthorityLimitUser : ValidatingBindingObject
{
  private MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int cnID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  public int AuthorityLimitsID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual Guid UserGuid { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual string UserName { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  [MgaSystems.IMS.Policies.AuthorityLimit.DatabaseField("HasValueSet")]
  public virtual string DatabaseField { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual int? CellTypeID { get; set; }

  [NotificationProperty]
  public virtual string CellType { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual long? MinValue { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual long? MaxValue { get; set; }

  [HardOrSoftValidation("StopQuoteSoft", "Stop Quote (Hard) or Stop Quote (Soft) can be checked but not both")]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool StopQuote { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool StopQuoteSoft { get; set; }

  [HardOrSoftValidation("StopBindSoft", "Stop Bind (Hard) or Stop Bind (Soft) can be checked but not both")]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool StopBind { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool StopBindSoft { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool SendTask { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool SendTaskQuote { get; set; }

  [SendTaskUserValidation("SendTask", "SendTaskQuote")]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual Guid? SendTaskUserGuid { get; set; }

  [NotificationProperty]
  public virtual string SendTaskUserName { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool ForNewPolicy { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool ForRenewalPolicy { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual long? MinApprovalValue { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual long? MaxApprovalValue { get; set; }

  public bool HasValueSet
  {
    get
    {
      if (this.MinValue.HasValue && this.MinValue.Value > 0L || this.MaxValue.HasValue && this.MaxValue.Value > 0L || this.MinApprovalValue.HasValue && this.MinApprovalValue.Value > 0L)
        return true;
      if (!this.MaxApprovalValue.HasValue)
        return false;
      long? maxApprovalValue = this.MaxApprovalValue;
      long num = 0;
      return maxApprovalValue.GetValueOrDefault() > num & maxApprovalValue.HasValue;
    }
  }

  internal static AuthorityLimitUser Create(MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitUser>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public AuthorityLimitUser(MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit parent, DataRow row)
  {
    this.Parent = parent;
    this.cnID = row.Field<int>(nameof (cnID));
    this.AuthorityLimitsID = row.Field<int>(nameof (AuthorityLimitsID));
    this.UserGuid = row.Field<Guid>(nameof (UserGuid));
    this.UserName = row.Field<string>(nameof (UserName));
    this.DatabaseField = row.Field<string>(nameof (DatabaseField));
    this.CellTypeID = row.Field<int?>(nameof (CellTypeID));
    this.CellType = row.Field<string>(nameof (CellType));
    this.MinValue = row.Field<long?>(nameof (MinValue));
    this.MaxValue = row.Field<long?>(nameof (MaxValue));
    this.StopQuote = row.Field<bool>(nameof (StopQuote));
    this.StopQuoteSoft = row.Field<bool>(nameof (StopQuoteSoft));
    this.StopBind = row.Field<bool>(nameof (StopBind));
    this.StopBindSoft = row.Field<bool>(nameof (StopBindSoft));
    this.SendTask = row.Field<bool>(nameof (SendTask));
    this.SendTaskQuote = row.Field<bool>(nameof (SendTaskQuote));
    this.SendTaskUserGuid = row.Field<Guid?>(nameof (SendTaskUserGuid));
    this.SendTaskUserName = row.Field<string>(nameof (SendTaskUserName));
    this.ForNewPolicy = row.Field<bool>(nameof (ForNewPolicy));
    this.ForRenewalPolicy = row.Field<bool>(nameof (ForRenewalPolicy));
    this.MinApprovalValue = row.Field<long?>(nameof (MinApprovalValue));
    this.MaxApprovalValue = row.Field<long?>(nameof (MaxApprovalValue));
  }

  internal static AuthorityLimitUser Create(
    MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit parent,
    Guid userGuid,
    string name_firstLast)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitUser>(new object[3]
    {
      (object) parent,
      (object) userGuid,
      (object) name_firstLast
    });
  }

  public AuthorityLimitUser(MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit parent, Guid userGuid, string name_firstLast)
  {
    this.Parent = parent;
    this.AuthorityLimitsID = parent.AuthorityLimitsID;
    this.UserGuid = userGuid;
    this.UserName = name_firstLast;
  }

  public void GetUserInfo()
  {
    this.Parent.Parent.ChangeManager.SuspendMonitoring((Action) (() =>
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT cnAuthorityLimitsUser.*, tblUsers.Name_FirstLast AS SendTaskUserName FROM cnAuthorityLimitsUser LEFT OUTER JOIN tblUsers ON tblUsers.UserGUID = cnAuthorityLimitsUser.SendTaskUserGuid WHERE AuthorityLimitsID = @AuthorityLimitsID AND cnAuthorityLimitsUser.UserGuid = @UserGuid", new object[4]
      {
        (object) "@AuthorityLimitsID",
        (object) this.AuthorityLimitsID,
        (object) "@UserGuid",
        (object) this.UserGuid
      });
      if (dataTable.Rows.Count <= 0)
        return;
      DataRow row = dataTable.Rows[0];
      this.DatabaseField = row.Field<string>("DatabaseField");
      this.CellTypeID = row.Field<int?>("CellTypeID");
      this.CellType = row.Field<string>("CellType");
      this.MinValue = row.Field<long?>("MinValue");
      this.MaxValue = row.Field<long?>("MaxValue");
      this.StopQuote = row.Field<bool>("StopQuote");
      this.StopQuoteSoft = row.Field<bool>("StopQuoteSoft");
      this.StopBind = row.Field<bool>("StopBind");
      this.StopBindSoft = row.Field<bool>("StopBindSoft");
      this.SendTask = row.Field<bool>("SendTask");
      this.SendTaskQuote = row.Field<bool>("SendTaskQuote");
      this.SendTaskUserGuid = row.Field<Guid?>("SendTaskUserGuid");
      this.SendTaskUserName = row.Field<string>("SendTaskUserName");
      this.ForNewPolicy = row.Field<bool>("ForNewPolicy");
      this.ForRenewalPolicy = row.Field<bool>("ForRenewalPolicy");
      this.MinApprovalValue = row.Field<long?>("MinApprovalValue");
      this.MaxApprovalValue = row.Field<long?>("MaxApprovalValue");
    }));
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    ((BindingObject) this).OnPropertyChanged(propertyName);
    switch (propertyName)
    {
      case "CellTypeID":
        int? cellTypeId = this.CellTypeID;
        if (cellTypeId.HasValue)
        {
          AuthorityLimitManager parent = this.Parent.Parent;
          cellTypeId = this.CellTypeID;
          int cellTypeID = cellTypeId.Value;
          this.CellType = parent.GetCellType(cellTypeID);
          break;
        }
        this.CellType = "";
        break;
      case "SendTask":
        if (!AuthorityLimitCheckManager.RunAuthorityCheckAtStartup)
          break;
        this.SendTaskQuote = this.SendTask;
        break;
      case "MinValue":
      case "MaxValue":
      case "MinApprovalValue":
      case "MaxApprovalValue":
        ((BindingObject) this).OnPropertyChanged("HasValueSet");
        break;
    }
  }
}
