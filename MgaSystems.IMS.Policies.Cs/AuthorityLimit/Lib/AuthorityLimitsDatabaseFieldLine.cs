// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimitsDatabaseFieldLine
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
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

[TableMapping("cnAuthorityLimitsDatabaseFieldLine")]
public abstract class AuthorityLimitsDatabaseFieldLine : BindingObject
{
  private AuthorityLimitDatabaseField Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int cnID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  public int DatabaseFieldID => this.Parent.cnID;

  [TrackChanges]
  [TableFieldMapping]
  public Guid LineGuid { get; set; }

  public virtual string LineName { get; set; }

  internal static AuthorityLimitsDatabaseFieldLine Create(
    AuthorityLimitDatabaseField parent,
    DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitsDatabaseFieldLine>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public AuthorityLimitsDatabaseFieldLine(AuthorityLimitDatabaseField parent, DataRow row)
  {
    this.Parent = parent;
    this.cnID = row.Field<int>(nameof (cnID));
    this.LineGuid = row.Field<Guid>(nameof (LineGuid));
    this.LineName = row.Field<string>(nameof (LineName));
  }

  internal static AuthorityLimitsDatabaseFieldLine Create(
    AuthorityLimitDatabaseField parent,
    Line line)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitsDatabaseFieldLine>(new object[2]
    {
      (object) parent,
      (object) line
    });
  }

  public AuthorityLimitsDatabaseFieldLine(AuthorityLimitDatabaseField parent, Line line)
  {
    this.Parent = parent;
    this.LineGuid = line.LineGuid;
    this.LineName = line.LineName;
  }
}
