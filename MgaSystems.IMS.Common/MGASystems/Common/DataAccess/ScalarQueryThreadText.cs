// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.ScalarQueryThreadText
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
public class ScalarQueryThreadText : QueryThread
{
  private ScalarQueryMultithreadedEventHandler _completedHandler;
  private object _result;

  protected object Result
  {
    get => this._result;
    set => this._result = RuntimeHelpers.GetObjectValue(value);
  }

  public ScalarQueryThreadText(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    ScalarQueryMultithreadedEventHandler completedHandler)
    : base(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters)
  {
    this._completedHandler = completedHandler;
  }

  protected override void ThreadCompletedUI()
  {
    ScalarQueryMultithreadedEventArgs e = new ScalarQueryMultithreadedEventArgs(RuntimeHelpers.GetObjectValue(this._result), RuntimeHelpers.GetObjectValue(this.Key));
    if (this._completedHandler == null)
      return;
    this._completedHandler((object) this, e);
  }

  protected override void ThreadProcBG()
  {
    this._result = RuntimeHelpers.GetObjectValue(this.DB.QueryText.PerformScalarQuery(this.QueryText, this.GetSqlParameters()));
  }
}
