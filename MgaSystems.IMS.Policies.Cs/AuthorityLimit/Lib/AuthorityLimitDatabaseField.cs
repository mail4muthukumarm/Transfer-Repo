// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimitDatabaseField
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Data;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

[TableMapping("cnAuthorityLimitsDatabaseField")]
public abstract class AuthorityLimitDatabaseField : BindingObject
{
  private MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int cnID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  public int AuthorityLimitsID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  public string DatabaseField { get; set; }

  [TrackChanges]
  public virtual BulkObservableCollection<AuthorityLimitsDatabaseFieldLine> Lines { get; } = new BulkObservableCollection<AuthorityLimitsDatabaseFieldLine>();

  internal static AuthorityLimitDatabaseField Create(MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitDatabaseField>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public AuthorityLimitDatabaseField(MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit parent, DataRow row)
  {
    this.Parent = parent;
    this.cnID = row.Field<int>(nameof (cnID));
    this.AuthorityLimitsID = row.Field<int>(nameof (AuthorityLimitsID));
    this.DatabaseField = row.Field<string>(nameof (DatabaseField));
    this.Lines.AddRange((IEnumerable<AuthorityLimitsDatabaseFieldLine>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT cn.*, l.LineName FROM cnAuthorityLimitsDatabaseFieldLine cn INNER JOIN lstLines l ON cn.LineGuid = l.LineGuid WHERE cn.DatabaseFieldID = @DatabaseFieldID", new object[2]
    {
      (object) "@DatabaseFieldID",
      (object) this.cnID
    }).AsEnumerable().Select<DataRow, AuthorityLimitsDatabaseFieldLine>((System.Func<DataRow, AuthorityLimitsDatabaseFieldLine>) (dr => AuthorityLimitsDatabaseFieldLine.Create(this, dr))));
  }

  internal static AuthorityLimitDatabaseField Create(MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit parent, string databaseField)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitDatabaseField>(new object[2]
    {
      (object) parent,
      (object) databaseField
    });
  }

  public AuthorityLimitDatabaseField(MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit parent, string databaseField)
  {
    this.Parent = parent;
    this.AuthorityLimitsID = parent.AuthorityLimitsID;
    this.DatabaseField = databaseField;
  }

  public void AddLines(
    ObservableCollection<SearchObject> searchObjectList)
  {
    foreach (SearchObject searchObject in searchObjectList.Where<SearchObject>((System.Func<SearchObject, bool>) (s => s.ChosenItem)))
    {
      Line line = searchObject.DefiningObject as Line;
      if (((IEnumerable<AuthorityLimitsDatabaseFieldLine>) this.Lines).Where<AuthorityLimitsDatabaseFieldLine>((System.Func<AuthorityLimitsDatabaseFieldLine, bool>) (f => f.LineGuid == line.LineGuid)).FirstOrDefault<AuthorityLimitsDatabaseFieldLine>() == null)
        ((Collection<AuthorityLimitsDatabaseFieldLine>) this.Lines).Add(AuthorityLimitsDatabaseFieldLine.Create(this, line));
    }
  }
}
