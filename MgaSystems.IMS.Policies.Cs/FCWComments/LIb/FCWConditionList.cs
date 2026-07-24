// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.FCWComments.LIb.FCWConditionList
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using System.ComponentModel.DataAnnotations;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.FCWComments.LIb;

[TableMapping("tblFCWConditions")]
public abstract class FCWConditionList : ValidatingBindingObject
{
  private FCWConditionListManager Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int ID { get; set; }

  [TableFieldMapping]
  [Required]
  [NotificationProperty]
  public virtual int FCWConditionID { get; set; }

  [NotificationProperty]
  public virtual string RatingType { get; set; }

  [TableFieldMapping]
  [NotificationProperty]
  public virtual string FCWConditionName { get; set; }

  [TableFieldMapping]
  [NotificationProperty]
  public virtual int RaterId { get; set; }

  [TableFieldMapping]
  [NotificationProperty]
  public virtual int OperatorTypeID { get; set; }

  [TableFieldMapping]
  [TrackChanges]
  [NotificationProperty]
  public virtual string FCWConditionComments { get; set; }

  internal static FCWConditionList Create(FCWConditionListManager parent)
  {
    return NotifyProxyTypeManager.Allocate<FCWConditionList>(new object[1]
    {
      (object) parent
    });
  }

  internal static FCWConditionList Create(FCWConditionListManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<FCWConditionList>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public FCWConditionList(FCWConditionListManager parent) => this.Parent = parent;

  public FCWConditionList(FCWConditionListManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ID = row.Field<int>(nameof (ID));
    this.FCWConditionID = row.Field<int>(nameof (FCWConditionID));
    this.RatingType = row.Field<string>(nameof (RatingType));
    this.FCWConditionName = row.Field<string>(nameof (FCWConditionName));
    this.RaterId = row.Field<int>(nameof (RaterId));
    this.OperatorTypeID = row.Field<int>(nameof (OperatorTypeID));
    this.FCWConditionComments = row.Field<string>(nameof (FCWConditionComments));
  }
}
