// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimitRater
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.Lib;

public abstract class ThresholdLimitRater : ValidatingBindingObject
{
  public ThresholdLimitManager Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int ThresholdLimitRaterID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual int RatingTypeID { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual string RatingType { get; set; }

  [TrackChanges]
  public virtual BulkObservableCollection<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit> Thresholds { get; } = new BulkObservableCollection<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit>();

  internal static ThresholdLimitRater Create(ThresholdLimitManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitRater>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ThresholdLimitRater(ThresholdLimitManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ThresholdLimitRaterID = row.Field<int>(nameof (ThresholdLimitRaterID));
    this.RatingTypeID = row.Field<int>(nameof (RatingTypeID));
    this.RatingType = row.Field<string>(nameof (RatingType));
  }

  public void GetThresholds()
  {
    this.Parent.ChangeManager.SuspendMonitoring((Action) (() =>
    {
      foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM cnThresholdLimits WHERE ThresholdLimitRaterID = @ThresholdLimitRaterID", new object[2]
      {
        (object) "@ThresholdLimitRaterID",
        (object) this.ThresholdLimitRaterID
      }).Rows)
        ((Collection<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit>) this.Thresholds).Add(MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit.Create(this, row));
    }));
  }

  public bool RaterContainsDatabaseField(string dbfield, int cnid)
  {
    return ((IEnumerable<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit>) this.Thresholds).Where<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit>((System.Func<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit, bool>) (tr => tr.DatabaseField == dbfield && tr.cnID != cnid)).Count<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit>() > 0;
  }
}
