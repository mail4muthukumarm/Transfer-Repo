// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimitCheck
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Common;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.Lib;

public abstract class ThresholdLimitCheck : BindingObject
{
  public ThresholdLimitCheckManager Parent { get; set; }

  public int ThresholdLimitsCheckID { get; set; }

  public int ThresholdLimitID { get; set; }

  public Guid QuoteGuid { get; set; }

  public long? MaxValue { get; set; }

  public bool StopQuote { get; set; }

  public bool StopBind { get; set; }

  public string DatabaseField { get; set; }

  public Decimal? FieldValue { get; set; }

  public Decimal? CellValueAtCheck { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual DateTime? ApproveDate { get; set; }

  public string RatingType { get; set; }

  [TrackChanges]
  public Guid? ApproveUserGuid { get; set; }

  [NotificationProperty]
  public virtual string ApproveUserName { get; set; }

  [NotificationProperty]
  public virtual bool Approve { get; set; }

  public int? ApprovalDaysOverage { get; set; }

  public bool ForNewPolicy { get; set; }

  public bool ForRenewalPolicy { get; set; }

  public bool StopQuoteSoft { get; set; }

  public bool StopBindSoft { get; set; }

  public string Cell { get; set; }

  public long? MaxValueAtCheck { get; set; }

  [NotificationProperty]
  public virtual bool UserCanApprove { get; set; }

  internal static ThresholdLimitCheck Create(ThresholdLimitCheckManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitCheck>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ThresholdLimitCheck(ThresholdLimitCheckManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ThresholdLimitID = row.Field<int>(nameof (ThresholdLimitID));
    this.MaxValue = row.Field<long?>(nameof (MaxValue));
    this.StopQuote = row.Field<bool>(nameof (StopQuote));
    this.StopBind = row.Field<bool>(nameof (StopBind));
    this.DatabaseField = row.Field<string>(nameof (DatabaseField));
    this.RatingType = row.Field<string>(nameof (RatingType));
    this.ForNewPolicy = row.Field<bool>(nameof (ForNewPolicy));
    this.ForRenewalPolicy = row.Field<bool>(nameof (ForRenewalPolicy));
    this.ApproveUserGuid = row.Field<Guid?>(nameof (ApproveUserGuid));
    this.Approve = this.ApproveUserGuid.HasValue;
    this.ApproveUserName = row.Field<string>(nameof (ApproveUserName));
    this.ApproveDate = row.Field<DateTime?>(nameof (ApproveDate));
    this.QuoteGuid = parent.QuoteGuid;
    this.FieldValue = row.Field<Decimal?>(nameof (FieldValue));
    this.ThresholdLimitsCheckID = row.Field<int>(nameof (ThresholdLimitsCheckID));
    this.ApprovalDaysOverage = row.Field<int?>(nameof (ApprovalDaysOverage));
    this.StopQuoteSoft = row.Field<bool>(nameof (StopQuoteSoft));
    this.StopBindSoft = row.Field<bool>(nameof (StopBindSoft));
    this.Cell = row.Field<string>(nameof (Cell));
    this.MaxValueAtCheck = row.Field<long?>(nameof (MaxValueAtCheck));
    this.CellValueAtCheck = row.Field<Decimal?>(nameof (CellValueAtCheck));
    this.UserCanApprove = PolSecurity.CanApproveThresholdLimit;
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    if (!(propertyName == "Approve"))
      return;
    if (this.Approve)
    {
      this.ApproveDate = new DateTime?(DateTime.Now);
      this.ApproveUserGuid = new Guid?(CurrentUser.Instance.UserGUID);
      this.ApproveUserName = CurrentUser.Instance.DisplayName;
    }
    else
    {
      this.ApproveDate = new DateTime?();
      this.ApproveUserGuid = new Guid?();
      this.ApproveUserName = "";
    }
  }
}
