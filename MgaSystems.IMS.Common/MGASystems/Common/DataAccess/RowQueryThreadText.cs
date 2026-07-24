// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.RowQueryThreadText
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public class RowQueryThreadText : QueryThread
{
  private RowQueryMultithreadedEventHandler _completedHandler;
  private DataRow _row;

  protected DataRow Row
  {
    get => this._row;
    set => this._row = value;
  }

  public RowQueryThreadText(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    RowQueryMultithreadedEventHandler completedHandler)
    : base(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters)
  {
    this._completedHandler = completedHandler;
  }

  protected override void ThreadCompletedUI()
  {
    RowQueryMultithreadedEventArgs e = new RowQueryMultithreadedEventArgs(this.Row, RuntimeHelpers.GetObjectValue(this.Key));
    if (this._completedHandler == null)
      return;
    this._completedHandler((object) this, e);
  }

  protected override void ThreadProcBG()
  {
    this.Row = this.DB.QueryText.PerformRowQuery(this.QueryText, this.GetSqlParameters());
  }
}
