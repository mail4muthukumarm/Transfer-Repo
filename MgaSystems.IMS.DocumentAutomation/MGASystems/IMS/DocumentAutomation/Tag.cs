// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.Tag
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class Tag : BindingObject
{
  [NotificationProperty]
  public virtual string GroupName { get; set; }

  [NotificationProperty]
  public virtual string TagName { get; set; }

  public virtual string TagPrefix { get; set; }

  public virtual int ID { get; set; }

  public string StoredProcedure { get; set; }

  public int DataStoreID { get; set; }

  public string Field { get; set; }

  public string Description { get; set; }

  public Tag(
    string _groupName,
    string _tagName,
    string _tagPrefix,
    int _id,
    string _storedProc,
    int _dataStoreID,
    string _field,
    string _description)
  {
    this.GroupName = _groupName;
    this.TagName = _tagName;
    this.TagPrefix = _tagPrefix;
    this.ID = _id;
    this.StoredProcedure = _storedProc;
    this.DataStoreID = _dataStoreID;
    this.Field = _field;
    this.Description = _description;
  }

  public static Tag Create(
    string _groupName,
    string _tagName,
    string _tagPrefix,
    int _id,
    string _storedProc,
    int _dataStoreID,
    string _field,
    string _description)
  {
    return NotifyProxyTypeManager.Allocate<Tag>(new object[8]
    {
      (object) _groupName,
      (object) _tagName,
      (object) _tagPrefix,
      (object) _id,
      (object) _storedProc,
      (object) _dataStoreID,
      (object) _field,
      (object) _description
    });
  }

  public static ObservableCollection<Tag> GetUserTagList()
  {
    EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ds.Name AS GroupName, ds.TagPrefix, ds.StoredProcedure, ut.ID AS TagID, ut.DataStoreID, ut.Name AS TagName, ut.Field, ut.Description FROM tblCustomTaggingDataStores ds INNER JOIN tblCustomTaggingUserTags ut ON ut.DataStoreID = ds.ID WHERE ds.RepeatableStore = 0 ORDER BY ds.Name").AsEnumerable();
    System.Func<DataRow, Tag> selector;
    // ISSUE: reference to a compiler-generated field
    if (Tag._Closure\u0024__.\u0024I34\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = Tag._Closure\u0024__.\u0024I34\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      Tag._Closure\u0024__.\u0024I34\u002D0 = selector = (System.Func<DataRow, Tag>) ([SpecialName] (row) => Tag.Create(row.Field<string>("GroupName"), row.Field<string>("TagName"), row.Field<string>("TagPrefix"), row.Field<int>("TagID"), row.Field<string>("StoredProcedure"), row.Field<int>("DataStoreID"), row.Field<string>("Field"), row.Field<string>("Description")));
    }
    return new ObservableCollection<Tag>((IEnumerable<Tag>) source.Select<DataRow, Tag>(selector));
  }

  public static Tag GetUserTag(string _tagName, int _dataStoreID)
  {
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ds.Name AS GroupName, ds.TagPrefix, ds.StoredProcedure, ut.ID AS TagID, ut.DataStoreID, ut.Name AS TagName, ut.Field, ut.Description FROM tblCustomTaggingDataStores ds LEFT OUTER JOIN tblCustomTaggingUserTags ut ON ut.DataStoreID = ds.ID WHERE ut.Name = @TagName AND ut.DataStoreID = @DataStoreID", new object[4]
    {
      (object) "@TagName",
      (object) _tagName,
      (object) "@DataStoreID",
      (object) _dataStoreID
    });
    return Tag.Create(row.Field<string>("GroupName"), row.Field<string>("TagName"), row.Field<string>("TagPrefix"), row.Field<int>("TagID"), row.Field<string>("StoredProcedure"), row.Field<int>("DataStoreID"), row.Field<string>("Field"), row.Field<string>("Description"));
  }
}
