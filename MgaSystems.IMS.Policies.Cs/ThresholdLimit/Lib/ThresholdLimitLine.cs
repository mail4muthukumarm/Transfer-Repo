// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimitLine
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.Lib;

[TableMapping("cnThresholdLimitsLine")]
public abstract class ThresholdLimitLine : BindingObject
{
  private MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int cnID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  public int ThresholdLimitID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  public Guid LineGuid { get; set; }

  public virtual string LineName { get; set; }

  internal static ThresholdLimitLine Create(MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitLine>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ThresholdLimitLine(MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit parent, DataRow row)
  {
    this.Parent = parent;
    this.cnID = row.Field<int>(nameof (cnID));
    this.ThresholdLimitID = row.Field<int>(nameof (ThresholdLimitID));
    this.LineGuid = row.Field<Guid>(nameof (LineGuid));
    this.LineName = row.Field<string>(nameof (LineName));
  }

  internal static ThresholdLimitLine Create(MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit parent)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitLine>(new object[1]
    {
      (object) parent
    });
  }

  public ThresholdLimitLine(MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit parent)
  {
    this.Parent = parent;
    this.ThresholdLimitID = parent.cnID;
  }

  internal static ThresholdLimitLine Create(MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit parent, Line line)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitLine>(new object[2]
    {
      (object) parent,
      (object) line
    });
  }

  public ThresholdLimitLine(MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimit parent, Line line)
  {
    this.Parent = parent;
    this.ThresholdLimitID = parent.cnID;
    this.LineGuid = line.LineGuid;
    this.LineName = line.LineName;
  }
}
