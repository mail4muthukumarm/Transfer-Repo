// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.RowQueryMultithreadedEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.DataAccess;

public sealed class RowQueryMultithreadedEventArgs : KeyedThreadEventArgs
{
  private DataRow _dataRow;

  public RowQueryMultithreadedEventArgs(DataRow row, object key)
    : base(RuntimeHelpers.GetObjectValue(key))
  {
    this._dataRow = row != null ? row : throw new DatabaseException(SR.GetString("DB_RowCantBeNull"));
  }

  public DataRow Row => this._dataRow;
}
