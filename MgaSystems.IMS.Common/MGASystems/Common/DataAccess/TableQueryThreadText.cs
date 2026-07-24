// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.TableQueryThreadText
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public class TableQueryThreadText : QueryThread
{
  private TableQueryMultithreadEventHandler _completedHandler;
  private DataTable _table;
  private TableFillingEventHandler _fillingHandler;

  protected DataTable InternalTable => this._table;

  protected TableFillingEventHandler FillingHandler => this._fillingHandler;

  protected DataTable Table
  {
    get => this._table;
    set => this._table = value;
  }

  public TableQueryThreadText(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler)
    : base(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters)
  {
    this._completedHandler = completedHandler;
    this._fillingHandler = fillingHandler;
  }

  protected override void ThreadCompletedUI()
  {
    TableQueryMultithreadEventArgs e = new TableQueryMultithreadEventArgs(this.Table, RuntimeHelpers.GetObjectValue(this.Key));
    if (this._completedHandler == null)
      return;
    this._completedHandler((object) this, e);
  }

  protected override void ThreadProcBG()
  {
    if (this._fillingHandler == null)
      this.Table = this.DB.QueryText.PerformTableQuery(this.QueryText, this.GetSqlParameters());
    else
      this.Table = this.DB.QueryText.PerformTableQuery(this.QueryText, this.GetSqlParameters(), new TableFillingEventHandler(this.BGFillingHander));
  }

  private void BGFillingHander(object sender, TableFillingEventArgs e)
  {
    if (this.UiContext != null && !this.UiContext.IsDisposed)
    {
      if (this.UiContext.InvokeRequired)
        this.UiContext.Invoke((Delegate) new TableFillingEventHandler(this.UIFillingHandler), sender, (object) e);
      else
        this.UIFillingHandler(RuntimeHelpers.GetObjectValue(sender), e);
    }
    else
    {
      if (this.UiContext != null)
        return;
      this.UIFillingHandler(RuntimeHelpers.GetObjectValue(sender), e);
    }
  }

  private void UIFillingHandler(object sender, TableFillingEventArgs e)
  {
    if (this.UiContext == null || this.UiContext.IsDisposed)
      return;
    this._fillingHandler(RuntimeHelpers.GetObjectValue(sender), e);
  }
}
