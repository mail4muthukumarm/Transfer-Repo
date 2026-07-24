// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Data;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MgaSystems.IMS.Policies.Misc.Lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

[TableMapping("tblAuthorityLimits")]
public abstract class AuthorityLimit : ValidatingBindingObject
{
  public AuthorityLimitManager Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int AuthorityLimitsID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual int RatingTypeID { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual string RatingType { get; set; }

  [TrackChanges]
  public virtual BulkObservableCollection<AuthorityLimitUser> Users { get; } = new BulkObservableCollection<AuthorityLimitUser>();

  [TrackChanges]
  public virtual BulkObservableCollection<AuthorityLimitDatabaseField> DatabaseFields { get; } = new BulkObservableCollection<AuthorityLimitDatabaseField>();

  internal static MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit Create(
    AuthorityLimitManager parent,
    DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public AuthorityLimit(AuthorityLimitManager parent, DataRow row)
  {
    this.Parent = parent;
    this.AuthorityLimitsID = row.Field<int>(nameof (AuthorityLimitsID));
    this.RatingTypeID = row.Field<int>(nameof (RatingTypeID));
    this.RatingType = row.Field<string>(nameof (RatingType));
  }

  public void GetChildren()
  {
    this.Parent.ChangeManager.SuspendMonitoring((Action) (() =>
    {
      foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spAuthorityLimitGetUsers", new object[2]
      {
        (object) "@AuthorityLimitID",
        (object) this.AuthorityLimitsID
      }).Rows)
        ((Collection<AuthorityLimitUser>) this.Users).Add(AuthorityLimitUser.Create(this, row));
      this.DatabaseFields.AddRange((IEnumerable<AuthorityLimitDatabaseField>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT cn.* FROM cnAuthorityLimitsDatabaseField cn WHERE cn.AuthorityLimitsID = @AuthorityLimitID", new object[2]
      {
        (object) "@AuthorityLimitID",
        (object) this.AuthorityLimitsID
      }).AsEnumerable().Select<DataRow, AuthorityLimitDatabaseField>((System.Func<DataRow, AuthorityLimitDatabaseField>) (dr => AuthorityLimitDatabaseField.Create(this, dr))));
    }));
  }

  public AuthorityLimitUser AddUser(SearchObject searchObject)
  {
    IMSUser usr = searchObject.DefiningObject as IMSUser;
    if (((IEnumerable<AuthorityLimitUser>) this.Users).Where<AuthorityLimitUser>((System.Func<AuthorityLimitUser, bool>) (f => f.UserGuid == usr.UserGUID)).FirstOrDefault<AuthorityLimitUser>() == null)
      ((Collection<AuthorityLimitUser>) this.Users).Add(AuthorityLimitUser.Create(this, usr.UserGUID, usr.Name_FirstLast));
    return ((IEnumerable<AuthorityLimitUser>) this.Users).Where<AuthorityLimitUser>((System.Func<AuthorityLimitUser, bool>) (f => f.UserGuid == usr.UserGUID)).FirstOrDefault<AuthorityLimitUser>();
  }

  public AuthorityLimitUser AddLimitToUser(AuthorityLimitUser authorityLimUser)
  {
    AuthorityLimitUser user = AuthorityLimitUser.Create(this, authorityLimUser.UserGuid, authorityLimUser.UserName);
    ((Collection<AuthorityLimitUser>) this.Users).Add(user);
    return user;
  }

  public void AddFields(
    ObservableCollection<SearchObject> searchObjectList)
  {
    foreach (SearchObject searchObject in searchObjectList.Where<SearchObject>((System.Func<SearchObject, bool>) (s => s.ChosenItem)))
    {
      RaterField raterField = searchObject.DefiningObject as RaterField;
      if (((IEnumerable<AuthorityLimitDatabaseField>) this.DatabaseFields).Where<AuthorityLimitDatabaseField>((System.Func<AuthorityLimitDatabaseField, bool>) (f => f.DatabaseField == raterField.DatabaseField)).FirstOrDefault<AuthorityLimitDatabaseField>() == null)
        ((Collection<AuthorityLimitDatabaseField>) this.DatabaseFields).Add(AuthorityLimitDatabaseField.Create(this, raterField.DatabaseField));
    }
  }
}
