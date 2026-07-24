// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DatabaseTypeConvertor
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Collections;
using System.Data;

#nullable disable
namespace MGASystems.Common;

public sealed class DatabaseTypeConvertor
{
  private static ArrayList _DbTypeList = new ArrayList();

  static DatabaseTypeConvertor()
  {
    DatabaseTypeConvertor.DbTypeMapEntry dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (bool), DbType.Boolean, SqlDbType.Bit);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (byte), DbType.Double, SqlDbType.TinyInt);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (byte[]), DbType.Binary, SqlDbType.Image);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (DateTime), DbType.DateTime, SqlDbType.DateTime);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (Decimal), DbType.Decimal, SqlDbType.Decimal);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (double), DbType.Double, SqlDbType.Float);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (Guid), DbType.Guid, SqlDbType.UniqueIdentifier);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (short), DbType.Int16, SqlDbType.SmallInt);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (int), DbType.Int32, SqlDbType.Int);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (long), DbType.Int64, SqlDbType.BigInt);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (object), DbType.Object, SqlDbType.Variant);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
    dbTypeMapEntry = new DatabaseTypeConvertor.DbTypeMapEntry(typeof (string), DbType.String, SqlDbType.VarChar);
    DatabaseTypeConvertor._DbTypeList.Add((object) dbTypeMapEntry);
  }

  private DatabaseTypeConvertor()
  {
  }

  public static Type ToNetType(DbType dbType) => DatabaseTypeConvertor.Find(dbType).Type;

  public static Type ToNetType(SqlDbType sqlDbType) => DatabaseTypeConvertor.Find(sqlDbType).Type;

  public static DbType ToDbType(Type type) => DatabaseTypeConvertor.Find(type).DbType;

  public static DbType ToDbType(SqlDbType sqlDbType)
  {
    return DatabaseTypeConvertor.Find(sqlDbType).DbType;
  }

  public static SqlDbType ToSqlDbType(Type type) => DatabaseTypeConvertor.Find(type).SqlDbType;

  public static SqlDbType ToSqlDbType(DbType dbType)
  {
    return DatabaseTypeConvertor.Find(dbType).SqlDbType;
  }

  private static DatabaseTypeConvertor.DbTypeMapEntry Find(Type type)
  {
    object obj1 = (object) null;
    for (int index = 0; index < DatabaseTypeConvertor._DbTypeList.Count; ++index)
    {
      object dbType = DatabaseTypeConvertor._DbTypeList[index];
      DatabaseTypeConvertor.DbTypeMapEntry dbTypeMapEntry = dbType != null ? (DatabaseTypeConvertor.DbTypeMapEntry) dbType : new DatabaseTypeConvertor.DbTypeMapEntry();
      if ((object) dbTypeMapEntry.Type == (object) type)
      {
        obj1 = (object) dbTypeMapEntry;
        break;
      }
    }
    object obj2 = obj1 != null ? obj1 : throw new ApplicationException("Referenced an unsupported Type");
    return obj2 == null ? new DatabaseTypeConvertor.DbTypeMapEntry() : (DatabaseTypeConvertor.DbTypeMapEntry) obj2;
  }

  private static DatabaseTypeConvertor.DbTypeMapEntry Find(DbType dbType)
  {
    object obj1 = (object) null;
    for (int index = 0; index < DatabaseTypeConvertor._DbTypeList.Count; ++index)
    {
      object dbType1 = DatabaseTypeConvertor._DbTypeList[index];
      DatabaseTypeConvertor.DbTypeMapEntry dbTypeMapEntry = dbType1 != null ? (DatabaseTypeConvertor.DbTypeMapEntry) dbType1 : new DatabaseTypeConvertor.DbTypeMapEntry();
      if (dbTypeMapEntry.DbType == dbType)
      {
        obj1 = (object) dbTypeMapEntry;
        break;
      }
    }
    object obj2 = obj1 != null ? obj1 : throw new ApplicationException("Referenced an unsupported DbType");
    return obj2 == null ? new DatabaseTypeConvertor.DbTypeMapEntry() : (DatabaseTypeConvertor.DbTypeMapEntry) obj2;
  }

  private static DatabaseTypeConvertor.DbTypeMapEntry Find(SqlDbType sqlDbType)
  {
    object obj1 = (object) null;
    for (int index = 0; index < DatabaseTypeConvertor._DbTypeList.Count; ++index)
    {
      object dbType = DatabaseTypeConvertor._DbTypeList[index];
      DatabaseTypeConvertor.DbTypeMapEntry dbTypeMapEntry = dbType != null ? (DatabaseTypeConvertor.DbTypeMapEntry) dbType : new DatabaseTypeConvertor.DbTypeMapEntry();
      if (dbTypeMapEntry.SqlDbType == sqlDbType)
      {
        obj1 = (object) dbTypeMapEntry;
        break;
      }
    }
    object obj2 = obj1 != null ? obj1 : throw new ApplicationException("Referenced an unsupported SqlDbType");
    return obj2 == null ? new DatabaseTypeConvertor.DbTypeMapEntry() : (DatabaseTypeConvertor.DbTypeMapEntry) obj2;
  }

  private struct DbTypeMapEntry
  {
    public Type Type;
    public DbType DbType;
    public SqlDbType SqlDbType;

    public DbTypeMapEntry(Type type, DbType dbType, SqlDbType sqlDbType)
      : this()
    {
      this.Type = type;
      this.DbType = dbType;
      this.SqlDbType = sqlDbType;
    }
  }
}
