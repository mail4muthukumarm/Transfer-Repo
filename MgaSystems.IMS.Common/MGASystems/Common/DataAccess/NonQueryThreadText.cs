// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.NonQueryThreadText
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public class NonQueryThreadText : QueryThread
{
  private NonQueryMultithreadEventHandler _completedHandler;
  private int _rowsAffected;

  protected int RowsAffected
  {
    get => this._rowsAffected;
    set => this._rowsAffected = value;
  }

  public NonQueryThreadText(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    NonQueryMultithreadEventHandler completedHandler)
    : base(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters)
  {
    this._completedHandler = completedHandler;
  }

  protected override void ThreadCompletedUI()
  {
    NonQueryMultithreadEventArgs e = new NonQueryMultithreadEventArgs(this._rowsAffected, RuntimeHelpers.GetObjectValue(this.Key));
    if (this._completedHandler == null)
      return;
    this._completedHandler((object) this, e);
  }

  protected override void ThreadProcBG()
  {
    this._rowsAffected = this.DB.QueryText.PerformNonQuery(this.QueryText, this.GetSqlParameters());
  }
}
