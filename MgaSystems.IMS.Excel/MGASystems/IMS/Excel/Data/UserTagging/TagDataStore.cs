// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.UserTagging.TagDataStore
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Excel.Data.UserTagging;

[TableMapping("tblCustomTaggingDataStores")]
[Description("Data Store")]
public abstract class TagDataStore : DependentBindingObject, IDataErrorInfo
{
  private BulkObservableCollection<UserTag> userTags;
  private Lazy<TagDataStore> _nestedParent;

  [DataKey]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual int? ID { get; set; }

  public UserTaggingManager Parent { get; }

  public TagDataStore(
    UserTaggingManager parent,
    string name,
    string storedProcedure,
    string tagPrefix,
    bool repeatableStore,
    int? nestedParentId)
  {
    this.Parent = parent;
    this.Name = name;
    this.StoredProcedure = storedProcedure;
    this.TagPrefix = tagPrefix;
    this.RepeatableStore = repeatableStore;
    this.NestedParentID = nestedParentId;
    this._nestedParent = new Lazy<TagDataStore>((Func<TagDataStore>) (() => this.NestedParentID.HasValue ? ((IEnumerable<TagDataStore>) this.Parent.DataStores).FirstOrDefault<TagDataStore>((System.Func<TagDataStore, bool>) (ds =>
    {
      int? id = ds.ID;
      int? nestedParentId1 = this.NestedParentID;
      return id.GetValueOrDefault() == nestedParentId1.GetValueOrDefault() & id.HasValue == nestedParentId1.HasValue;
    })) : (TagDataStore) null));
  }

  public TagDataStore(
    UserTaggingManager parent,
    int id,
    bool repeatableStore,
    int? nestedParentId)
  {
    this.Parent = parent;
    this.ID = new int?(id);
    this.RepeatableStore = repeatableStore;
    this.NestedParentID = nestedParentId;
    this._nestedParent = new Lazy<TagDataStore>((Func<TagDataStore>) (() => this.NestedParentID.HasValue ? ((IEnumerable<TagDataStore>) this.Parent.DataStores).FirstOrDefault<TagDataStore>((System.Func<TagDataStore, bool>) (ds =>
    {
      int? id1 = ds.ID;
      int? nestedParentId1 = this.NestedParentID;
      return id1.GetValueOrDefault() == nestedParentId1.GetValueOrDefault() & id1.HasValue == nestedParentId1.HasValue;
    })) : (TagDataStore) null));
  }

  public static TagDataStore Create(
    UserTaggingManager parent,
    string name,
    string storedProcedure,
    string tagPrefix,
    bool repeatableStore,
    int? nestedParentId)
  {
    return NotifyProxyTypeManager.Allocate<TagDataStore>(new object[6]
    {
      (object) parent,
      (object) name,
      (object) storedProcedure,
      (object) tagPrefix,
      (object) repeatableStore,
      (object) nestedParentId
    });
  }

  public static TagDataStore Create(
    UserTaggingManager parent,
    int id,
    bool repeatableStore,
    int? nestedParentId)
  {
    return NotifyProxyTypeManager.Allocate<TagDataStore>(new object[4]
    {
      (object) parent,
      (object) id,
      (object) repeatableStore,
      (object) nestedParentId
    });
  }

  [DisallowDuplicateValues("Name")]
  public BulkObservableCollection<UserTag> UserTags
  {
    get
    {
      if (this.userTags == null)
      {
        this.userTags = new BulkObservableCollection<UserTag>();
        if (this.ID.HasValue && !this.Parent.ReadOnly)
          Utility.ExecuteThread((DoWorkEventHandler) ((s, e) => e.Result = (object) DefaultDatabase.ExecuteMappedObjectSelectMultiple<UserTag>((System.Func<DataRow, UserTag>) (row => UserTag.Create(this, (int) row["ID"])), $"where DataStoreId = {this.ID}", Array.Empty<object>())), (RunWorkerCompletedEventHandler) ((s, e) =>
          {
            this.UserTags.AddRange((IEnumerable<UserTag>) e.Result);
            this.Parent.ChangeManager.StartMonitor((INotifyPropertyChanged) this.userTags, nameof (UserTags));
          }), (ProgressChangedEventHandler) null);
        else if (!this.Parent.ReadOnly)
          this.Parent.ChangeManager.StartMonitor((INotifyPropertyChanged) this.userTags, nameof (UserTags));
      }
      return this.userTags;
    }
  }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [StringLength(150)]
  [RegularExpression("^[a-zA-Z0-9_]*$")]
  [NotificationProperty]
  public virtual string StoredProcedure { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [StringLength(50)]
  [RegularExpression("^[a-zA-Z0-9_]*$")]
  [NotificationProperty]
  public virtual string Name { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [StringLength(20)]
  [RegularExpression("^[a-zA-Z0-9_]*$")]
  [NotificationProperty]
  public virtual string TagPrefix { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [NotificationProperty]
  public virtual bool RepeatableStore { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual int? NestedParentID { get; set; }

  public TagDataStore NestedParent => this._nestedParent?.Value;

  public IEnumerable<TagDataStore> NestCandidates
  {
    get
    {
      return (IEnumerable<TagDataStore>) ((IEnumerable<TagDataStore>) this.Parent.DataStores).Where<TagDataStore>((System.Func<TagDataStore, bool>) (ds =>
      {
        if (ds == this || !ds.RepeatableStore || !ds.ID.HasValue)
          return false;
        int? nestedParentId = ds.NestedParentID;
        int? id = this.ID;
        return !(nestedParentId.GetValueOrDefault() == id.GetValueOrDefault() & nestedParentId.HasValue == id.HasValue);
      })).OrderBy<TagDataStore, string>((System.Func<TagDataStore, string>) (ds => ds.Name));
    }
  }

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }
}
