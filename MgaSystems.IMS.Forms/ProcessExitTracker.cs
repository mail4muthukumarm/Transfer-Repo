// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.ProcessExitTracker
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class ProcessExitTracker
{
  private ProcessExitTracker.ProcessCompleteEventHandler _processCompleteEventHandler;
  private Process _process;
  private Control _uiContext;
  private string _fileName;
  private Guid _docGuid;

  public ProcessExitTracker(
    Guid documentGUID,
    Process p,
    string fileName,
    Control uiContext,
    ProcessExitTracker.ProcessCompleteEventHandler processCompleteHandler)
  {
    if (p == null)
      throw new ApplicationException("Process cannot be null");
    this._processCompleteEventHandler = processCompleteHandler;
    this._process = p;
    this._uiContext = uiContext;
    this._fileName = fileName;
    this._docGuid = documentGUID;
  }

  public void StartTracking() => ThreadPool.QueueUserWorkItem(new WaitCallback(this.TrackerThread));

  public void TrackerThread(object stateInfo)
  {
    bool success = true;
    try
    {
      this._process.WaitForExit();
    }
    catch (ThreadAbortException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      success = false;
      ProjectData.ClearProjectError();
    }
    this._uiContext.BeginInvoke((Delegate) this._processCompleteEventHandler, (object) this, (object) new ProcessExitTracker.ProcessCompleteEventArgs(this._fileName, success, this._docGuid));
  }

  public sealed class ProcessCompleteEventArgs : EventArgs
  {
    private string _fileName;
    private Guid _documentGuid;
    private bool _success;

    public ProcessCompleteEventArgs(string fileName, bool success, Guid documentGUID)
    {
      this._fileName = fileName;
      this._success = success;
      this._documentGuid = documentGUID;
    }

    public Guid DocumentGuid => this._documentGuid;

    public string FileName => this._fileName;

    public bool Success => this._success;
  }

  public delegate void ProcessCompleteEventHandler(
    object sender,
    ProcessExitTracker.ProcessCompleteEventArgs e);
}
