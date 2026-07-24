// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.QueryThread
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class QueryThread : IDisposable
{
  private Control _uiContext;
  private Database _threadSafeDB;
  private bool _classUsed;
  private string _queryText;
  private bool _listeningToFormClosing;
  private SqlParameter[] _sqlParameters;
  private object _key;
  private bool _abortCallback;

  protected virtual void OnDispose()
  {
    if (this._threadSafeDB == null)
      return;
    this._threadSafeDB.Dispose();
    this._threadSafeDB = (Database) null;
  }

  protected Control UiContext => this._uiContext;

  protected object Key => this._key;

  protected SqlParameter[] GetSqlParameters() => this._sqlParameters;

  protected string QueryText => this._queryText;

  protected Database DB
  {
    get
    {
      if (this._threadSafeDB == null)
        this._threadSafeDB = new Database();
      return this._threadSafeDB;
    }
  }

  protected QueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters)
  {
    this._key = RuntimeHelpers.GetObjectValue(key);
    this._queryText = queryText;
    this._sqlParameters = sqlParameters;
    this._uiContext = uiContext;
  }

  protected QueryThread(
    Control uiContext,
    object key,
    string queryText,
    params object[] namevalueArgs)
  {
    this._key = RuntimeHelpers.GetObjectValue(key);
    this._queryText = queryText;
    this._sqlParameters = Database.ParseNamevalueArgs(namevalueArgs);
    this._uiContext = uiContext;
  }

  protected QueryThread(Control uiContext, object key, string queryText)
  {
    this._key = RuntimeHelpers.GetObjectValue(key);
    this._queryText = queryText;
    this._uiContext = uiContext;
  }

  public void Abort() => this._abortCallback = true;

  private void SetupUIContext()
  {
    this._listeningToFormClosing = this._uiContext != null && this._uiContext is Form;
    if (!this._listeningToFormClosing)
      return;
    this.FindForm().Closing += new CancelEventHandler(this.form_closing);
  }

  private void form_closing(object sender, CancelEventArgs e) => this.DisconnectUIContext();

  private void DisconnectUIContext()
  {
    if (!this._listeningToFormClosing)
      return;
    this.FindForm().Closing -= new CancelEventHandler(this.form_closing);
    this._listeningToFormClosing = false;
  }

  private Form FindForm()
  {
    Form form1;
    if (this._uiContext is Form)
    {
      form1 = (Form) this._uiContext;
    }
    else
    {
      Control control = this._uiContext;
      while (control.Parent != null)
      {
        control = control.Parent;
        if (control is Form form2)
        {
          form1 = form2;
          goto label_7;
        }
      }
      form1 = (Form) null;
    }
label_7:
    return form1;
  }

  public void StartThread() => this.StartThread(ThreadPriority.Normal);

  public void StartThread(ThreadPriority priorty)
  {
    this._classUsed = !this._classUsed ? true : throw new DatabaseException(MGASystems.Common.SR.GetString("DB_ThreadOnce"));
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.InternalThreadProc));
  }

  private void InternalThreadProc(object state)
  {
    this.SetupUIContext();
    this.ThreadProcBG();
    if (this._threadSafeDB != null)
    {
      this._threadSafeDB.Dispose();
      this._threadSafeDB = (Database) null;
    }
    if (this._uiContext != null)
    {
      if (!this._uiContext.IsDisposed)
      {
        try
        {
          if (this._uiContext.InvokeRequired)
          {
            this._uiContext.BeginInvoke((Delegate) new EventHandler(this.InternalThreadCompleted));
            return;
          }
          this.InternalThreadCompleted((object) null, EventArgs.Empty);
          return;
        }
        catch (InvalidOperationException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
          return;
        }
      }
    }
    if (this._uiContext == null)
    {
      this.InternalThreadCompleted((object) null, EventArgs.Empty);
    }
    else
    {
      if (!this._abortCallback)
        return;
      this.InternalThreadCompleted((object) null, EventArgs.Empty);
    }
  }

  private void InternalThreadCompleted(object sender, EventArgs e)
  {
    this.DisconnectUIContext();
    if (this._uiContext != null && !this._uiContext.IsDisposed && this._uiContext.IsHandleCreated)
    {
      if (this._uiContext.InvokeRequired)
        throw new DatabaseException(MGASystems.Common.SR.GetString("DB_IncorrectThread"));
      this.ThreadCompletedUI();
    }
    else
    {
      if (this._uiContext != null)
        return;
      this.ThreadCompletedUI();
    }
  }

  protected abstract void ThreadProcBG();

  protected abstract void ThreadCompletedUI();

  public void Dispose() => this.OnDispose();
}
