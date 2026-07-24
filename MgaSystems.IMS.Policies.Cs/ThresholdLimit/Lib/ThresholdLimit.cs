// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Data;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MgaSystems.IMS.Policies.AuthorityLimit;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.Lib;

[TableMapping("cnThresholdLimits")]
public abstract class ThresholdLimit : ValidatingBindingObject
{
  private ThresholdLimitRater Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int cnID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  public int ThresholdLimitRaterID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  [ThresholdDatabaseField("HasValueSet")]
  public virtual string DatabaseField { get; set; }

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
  public virtual bool ForNewPolicy { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool ForRenewalPolicy { get; set; }

  public bool HasValueSet => this.MaxValue.HasValue && this.MaxValue.Value > 0L;

  [TrackChanges]
  public virtual BulkObservableCollection<ThresholdLimitLine> ThresholdLimitLineList { get; } = new BulkObservableCollection<ThresholdLimitLine>();

  internal static MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit Create(
    ThresholdLimitRater parent,
    DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ThresholdLimit(ThresholdLimitRater parent, DataRow row)
  {
    this.Parent = parent;
    this.cnID = row.Field<int>(nameof (cnID));
    this.ThresholdLimitRaterID = row.Field<int>(nameof (ThresholdLimitRaterID));
    this.DatabaseField = row.Field<string>(nameof (DatabaseField));
    this.MaxValue = row.Field<long?>(nameof (MaxValue));
    this.StopQuote = row.Field<bool>(nameof (StopQuote));
    this.StopQuoteSoft = row.Field<bool>(nameof (StopQuoteSoft));
    this.StopBind = row.Field<bool>(nameof (StopBind));
    this.StopBindSoft = row.Field<bool>(nameof (StopBindSoft));
    this.ForNewPolicy = row.Field<bool>(nameof (ForNewPolicy));
    this.ForRenewalPolicy = row.Field<bool>(nameof (ForRenewalPolicy));
    this.ThresholdLimitLineList.AddRange((IEnumerable<ThresholdLimitLine>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT cn.*, l.LineName FROM cnThresholdLimitsLine cn JOIN lstLines l ON l.LineGUID = cn.LineGuid WHERE cn.ThresholdLimitID = @ThresholdLimitID", new object[2]
    {
      (object) "@ThresholdLimitID",
      (object) this.cnID
    }).AsEnumerable().Select<DataRow, ThresholdLimitLine>((System.Func<DataRow, ThresholdLimitLine>) (dr => ThresholdLimitLine.Create(this, dr))));
  }

  internal static MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit Create(
    ThresholdLimitRater parent)
  {
    return NotifyProxyTypeManager.Allocate<MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit>(new object[1]
    {
      (object) parent
    });
  }

  public ThresholdLimit(ThresholdLimitRater parent)
  {
    this.Parent = parent;
    this.ThresholdLimitRaterID = parent.ThresholdLimitRaterID;
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    ((BindingObject) this).OnPropertyChanged(propertyName);
    if (!(propertyName == "MaxValue"))
      return;
    ((BindingObject) this).OnPropertyChanged("HasValueSet");
  }

  public void AddLines(
    ObservableCollection<SearchObject> searchObjectList)
  {
    foreach (SearchObject searchObject in searchObjectList.Where<SearchObject>((System.Func<SearchObject, bool>) (s => s.ChosenItem)))
    {
      Line line = searchObject.DefiningObject as Line;
      if (((IEnumerable<ThresholdLimitLine>) this.ThresholdLimitLineList).Where<ThresholdLimitLine>((System.Func<ThresholdLimitLine, bool>) (f => f.LineGuid == line.LineGuid)).FirstOrDefault<ThresholdLimitLine>() == null)
        ((Collection<ThresholdLimitLine>) this.ThresholdLimitLineList).Add(ThresholdLimitLine.Create(this, line));
    }
  }
}
