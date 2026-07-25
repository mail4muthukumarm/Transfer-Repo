// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.UserTagging.UserTaggingManager
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.ExtensionMethods;
using Mga.Wpf.Ims.Interop;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using MGASystems.IMS.NoteDocuments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Data;

#nullable disable
namespace MGASystems.IMS.Excel.Data.UserTagging;

public class UserTaggingManager : DependentBindingObject, IDataErrorInfo, ISubmittable
{
  public ChangeManager ChangeManager { get; }

  [TrackChanges]
  [DisallowDuplicateValues("Name")]
  [DisallowDuplicateValues("TagPrefix")]
  [DisallowDuplicateValues("StoredProcedure")]
  public BulkObservableCollection<TagDataStore> DataStores { get; } = new BulkObservableCollection<TagDataStore>();

  public UserTaggingManager()
    : this(false)
  {
  }

  internal bool ReadOnly { get; }

  public UserTaggingManager(bool readOnly)
  {
    if (Information.IsDesignMode)
      return;
    this.ReadOnly = readOnly;
    if (this.ReadOnly)
    {
      Dictionary<int, TagDataStore> dataStoreLookup = new Dictionary<int, TagDataStore>();
      this.DataStores.AddRange((IEnumerable<TagDataStore>) DefaultDatabase.ExecuteMappedObjectSelectMultiple<TagDataStore>((System.Func<DataRow, TagDataStore>) (row =>
      {
        TagDataStore tagDataStore = TagDataStore.Create(this, (int) row["ID"], DataRowExtensions.FieldIfExists<bool>(row, "RepeatableStore", false), DataRowExtensions.FieldIfExists<int?>(row, "NestedParentID", new int?()));
        dataStoreLookup.Add(tagDataStore.ID.Value, tagDataStore);
        return tagDataStore;
      })));
      DefaultDatabase.ExecuteMappedObjectSelectMultiple<UserTag>((System.Func<DataRow, UserTag>) (row => UserTag.Create(dataStoreLookup[(int) row["DataStoreID"]], (int) row["ID"]))).ForEach((Action<UserTag>) (newUserTag => ((Collection<UserTag>) dataStoreLookup[newUserTag.Parent.ID.Value].UserTags).Add(newUserTag)));
    }
    else
    {
      this.ChangeManager = new ChangeManager();
      Utility.ExecuteThread((DoWorkEventHandler) ((s, e) => e.Result = (object) DefaultDatabase.ExecuteMappedObjectSelectMultiple<TagDataStore>((System.Func<DataRow, TagDataStore>) (row => TagDataStore.Create(this, (int) row["ID"], DataRowExtensions.FieldIfExists<bool>(row, "RepeatableStore", false), DataRowExtensions.FieldIfExists<int?>(row, "NestedParentID", new int?()))))), (RunWorkerCompletedEventHandler) ((s, e) =>
      {
        this.DataStores.AddRange((IEnumerable<TagDataStore>) e.Result);
        if (((Collection<TagDataStore>) this.DataStores).Count > 0)
          CollectionViewSource.GetDefaultView((object) this.DataStores).MoveCurrentToFirst();
        this.ChangeManager.Initialize((INotifyPropertyChanged) this);
        this.UseChangeMonitor = true;
      }), (ProgressChangedEventHandler) null);
    }
  }

  public IEnumerable<UserTag> UserTags
  {
    get
    {
      return ((IEnumerable<TagDataStore>) this.DataStores).SelectMany<TagDataStore, UserTag>((System.Func<TagDataStore, IEnumerable<UserTag>>) (dataStore => (IEnumerable<UserTag>) dataStore.UserTags));
    }
  }

  public List<ValidationResult> SubmitChanges()
  {
    if (this.ReadOnly)
      throw new InvalidOperationException("Cannot SubmitChanges while in Readonly Mode");
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }

  public bool HasChanges
  {
    get => !this.ReadOnly && this.ChangeManager != null && this.ChangeManager.HasChanges;
  }

  public bool SupportsRepeatableTags { get; } = SystemSettings.GetSetting<bool>("SupportRepeatableTags", false);
}
