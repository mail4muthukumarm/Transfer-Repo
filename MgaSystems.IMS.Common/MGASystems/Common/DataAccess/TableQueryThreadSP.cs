// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.TableQueryThreadSP
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class TableQueryThreadSP(
  Control uiContext,
  object key,
  string queryText,
  SqlParameter[] sqlParameters,
  TableQueryMultithreadEventHandler completedHandler,
  TableFillingEventHandler fillingHandler) : TableQueryThreadText(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler, fillingHandler)
{
  protected override void ThreadProcBG()
  {
    if (this.FillingHandler == null)
      this.Table = this.DB.QuerySP.PerformTableQuery(this.QueryText, this.GetSqlParameters());
    else
      this.Table = this.DB.QuerySP.PerformTableQuery(this.QueryText, this.GetSqlParameters(), new TableFillingEventHandler(this.BGFillingHander));
  }

  private void BGFillingHander(object sender, TableFillingEventArgs e)
  {
    if (this.UiContext != null && !this.UiContext.IsDisposed && !this.UiContext.Disposing)
    {
      if (this.UiContext.InvokeRequired)
      {
        try
        {
          if (this.UiContext.IsDisposed || this.UiContext.Disposing || !this.UiContext.IsHandleCreated)
            return;
          this.UiContext.Invoke((Delegate) new TableFillingEventHandler(this.UIFillingHandler), sender, (object) e);
        }
        catch (ObjectDisposedException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
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
    if (this.UiContext != null && !this.UiContext.IsDisposed)
    {
      this.FillingHandler(RuntimeHelpers.GetObjectValue(sender), e);
    }
    else
    {
      if (this.UiContext != null)
        return;
      this.FillingHandler(RuntimeHelpers.GetObjectValue(sender), e);
    }
  }
}
