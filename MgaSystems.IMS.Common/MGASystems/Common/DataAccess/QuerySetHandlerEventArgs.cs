// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.QuerySetHandlerEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.Common.DataAccess;

public sealed class QuerySetHandlerEventArgs : EventArgs
{
  private SqlConnection _connection;
  private SqlTransaction _transaction;
  private Database _db;
  private object[] _args;

  public QuerySetHandlerEventArgs(SqlConnection connection, SqlTransaction t, Database db)
  {
    this._connection = connection;
    this._transaction = t;
    this._db = db;
  }

  public QuerySetHandlerEventArgs(
    SqlConnection connection,
    SqlTransaction t,
    Database db,
    object[] args)
  {
    this._connection = connection;
    this._transaction = t;
    this._db = db;
    this._args = args;
  }

  public object[] GetArgs() => this._args;

  public SqlConnection Connection => this._connection;

  public SqlTransaction Transaction => this._transaction;

  public bool HasTransaction => this._transaction != null;

  public Database Database => this._db;
}
