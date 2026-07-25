// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.UserTagging.UserTag
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace MGASystems.IMS.Excel.Data.UserTagging;

[System.ComponentModel.Description("Custom Tag")]
[TableMapping("tblCustomTaggingUserTags")]
public abstract class UserTag : 
  DependentBindingObject,
  IDataTransferFilter,
  IDataErrorInfo,
  IEditableObject
{
  [DataKey]
  [TableFieldMapping]
  public virtual int? ID { get; set; }

  [TableFieldMapping]
  public virtual TagDataStore Parent { get; set; }

  public UserTag(TagDataStore parent, string name, string field)
  {
    this.Parent = parent;
    this.Field = field;
    this.Name = name;
  }

  public UserTag(TagDataStore parent, int id)
    : this(parent, "", "")
  {
    this.ID = new int?(id);
  }

  public static UserTag Create(TagDataStore parent, string name, string field)
  {
    return NotifyProxyTypeManager.Allocate<UserTag>(new object[3]
    {
      (object) parent,
      (object) name,
      (object) field
    });
  }

  public static UserTag Create(TagDataStore parent, int id)
  {
    return NotifyProxyTypeManager.Allocate<UserTag>(new object[2]
    {
      (object) parent,
      (object) id
    });
  }

  [TrackChanges]
  [TableFieldMapping("TagType")]
  [NotificationProperty]
  public virtual TagType Type { get; set; }

  [TrackChanges]
  [Required]
  [StringLength(50)]
  [RegularExpression("^[a-zA-Z0-9_]*$")]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Name { get; set; }

  [TrackChanges]
  [StringLength(50)]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Description { get; set; }

  [DependsOn("Name")]
  [DependsOn("Parent", "TagPrefix")]
  [DependsOn("Parent", "RepeatableStore")]
  public string ResolvedTagName
  {
    get
    {
      return string.Format("{2}_{0}_{1}", (object) this.Parent.TagPrefix, (object) this.Name, this.Parent.RepeatableStore ? (object) "RT" : (object) "UT");
    }
  }

  [TrackChanges]
  [Required]
  [StringLength(50)]
  [RegularExpression("^[a-zA-Z0-9_]*$")]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Field { get; set; }

  void IDataTransferFilter.OnWriteAdditionalValuesToSource(Dictionary<string, object> values)
  {
    if (!this.Parent.ID.HasValue)
      throw new InvalidOperationException("Parent Must Have Valid ID");
    values.Add("DataStoreID", (object) this.Parent.ID.Value);
  }

  void IDataTransferFilter.OnWriteToDestination(DataTransferFilterEventArgs e)
  {
    if (!(e.SourceField == "DataStoreID"))
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  void IDataTransferFilter.OnWriteToSource(DataTransferFilterEventArgs e)
  {
  }

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }

  void IEditableObject.BeginEdit()
  {
    this.Parent.Parent.ChangeManager.BeginEdit((IEditableObject) this);
  }

  void IEditableObject.CancelEdit()
  {
    this.Parent.Parent.ChangeManager.CancelEdit((IEditableObject) this);
  }

  void IEditableObject.EndEdit()
  {
    this.Parent.Parent.ChangeManager.EndEdit((IEditableObject) this);
  }
}
