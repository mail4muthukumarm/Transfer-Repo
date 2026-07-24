// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.TableFillingEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.ComponentModel;
using System.Data;

#nullable disable
namespace MGASystems.Common.DataAccess;

public sealed class TableFillingEventArgs : CancelEventArgs
{
  private long _currentRow;
  private DataRow _row;
  private bool _stopFill;

  public TableFillingEventArgs(long currentRow, DataRow row)
  {
    this._currentRow = currentRow;
    this._row = row;
  }

  public bool StopFill
  {
    get => this._stopFill;
    set => this._stopFill = value;
  }

  public long CurrentRow => this._currentRow;

  public DataRow Row => this._row;
}
