// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Taskbar.TaskBarTrackerManager
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Common.NativeWindowMethods.SafeAPICalls;
using MGASystems.IMS.NoteDocuments.Serialization;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Taskbar;

[AutoInstantiate]
[Preference("Screens.All.ShowInTaskbar", false)]
public class TaskBarTrackerManager : MgaDisposableObject
{
  private static TaskBarTrackerManager _manager;
  private ArrayList _trackers;
  internal const string PREFERENCE_TRACK_WINDOWS_IN_TASKBAR = "Screens.All.ShowInTaskbar";

  public static TaskBarTrackerManager Instance => TaskBarTrackerManager._manager;

  private TaskBarTrackerManager()
  {
    this._trackers = new ArrayList();
    ObjectFactory.Instance.ObjectConstructed += new ObjectFactory.ObjectConstructedEventHandler(this.ObjectFactory_ObjectCreated);
    TaskBarTrackerManager._manager = this;
  }

  private void ObjectFactory_ObjectCreated(object sender, EventArgs e)
  {
    if (!(sender is Form formToControl) || !CurrentUser.Instance.IsLoggedIn || !Preferences.GetPreferenceBool("Screens.All.ShowInTaskbar") || formToControl is ITaskBarTrackNever)
      return;
    TaskBarTrackerManager.frmTaskbarTracker frmTaskbarTracker = new TaskBarTrackerManager.frmTaskbarTracker(formToControl, this);
    frmTaskbarTracker.Show();
    this._trackers.Add((object) frmTaskbarTracker);
  }

  private void ClearAllTrackers()
  {
    ArrayList arrayList = new ArrayList();
    arrayList.AddRange((ICollection) this._trackers);
    try
    {
      foreach (Form form in arrayList)
        form.Close();
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    arrayList.Clear();
    this._trackers.Clear();
  }

  public void Reset()
  {
    this.ClearAllTrackers();
    if (!CurrentUser.Instance.IsLoggedIn || !Preferences.GetPreferenceBool("Screens.All.ShowInTaskbar"))
      return;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form formToControl = mdiChildren[index];
      if (!(formToControl is ITaskBarTrackNever))
      {
        TaskBarTrackerManager.frmTaskbarTracker frmTaskbarTracker = new TaskBarTrackerManager.frmTaskbarTracker(formToControl, this);
        frmTaskbarTracker.Show();
        this._trackers.Add((object) frmTaskbarTracker);
      }
      checked { ++index; }
    }
  }

  internal void RemoveTracker(Form tracker) => this._trackers.Remove((object) tracker);

  protected override void OnDisposeManaged()
  {
    TaskBarTrackerManager._manager = (TaskBarTrackerManager) null;
    ObjectFactory.Instance.ObjectConstructed -= new ObjectFactory.ObjectConstructedEventHandler(this.ObjectFactory_ObjectCreated);
  }

  protected override void OnDisposeUnManaged()
  {
  }

  private class frmTaskbarTracker : Form
  {
    private IContainer components;
    private Form _formToControl;
    private TaskBarTrackerManager _trackerManager;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(115, 26);
      this.Name = nameof (frmTaskbarTracker);
      this.WindowState = FormWindowState.Minimized;
    }

    public frmTaskbarTracker(Form formToControl, TaskBarTrackerManager trackerManager)
    {
      this.Closed += new EventHandler(this.frmTaskbarTracker_Closed);
      this.Load += new EventHandler(this.frmTaskbarTracker_Load);
      this.Activated += new EventHandler(this.frmTaskbarTracker_Activated);
      this.InitializeComponent();
      this._formToControl = formToControl;
      this.Text = this._formToControl.Text;
      this.Icon = this._formToControl.Icon;
      this._trackerManager = trackerManager;
    }

    private void frmTaskbarTracker_Closed(object sender, EventArgs e)
    {
      this._trackerManager.RemoveTracker((Form) this);
    }

    private void frmTaskbarTracker_Load(object sender, EventArgs e)
    {
      this.ConnectTrackingEvents();
      this.Text = this._formToControl.Text;
    }

    private void frmTaskbarTracker_Activated(object sender, EventArgs e)
    {
      if (this._formToControl == null || this._formToControl.IsDisposed)
        return;
      if (this._formToControl.ParentForm != null)
      {
        this._formToControl.ParentForm.Show();
        this._formToControl.ParentForm.Activate();
      }
      this._formToControl.Show();
      this._formToControl.BringToFront();
      this._formToControl.Activate();
      this.Text = this._formToControl.Text;
    }

    private void frmTracking_Activate(object sender, EventArgs e) => this.Activate();

    private void frmTracking_Closed(object sender, EventArgs e)
    {
      this.DisconnectTrackingEvents();
      this.Close();
    }

    private void DisconnectTrackingEvents()
    {
      this._formToControl.Activated -= new EventHandler(this.frmTracking_Activate);
      this._formToControl.Closed -= new EventHandler(this.frmTracking_Closed);
    }

    private void ConnectTrackingEvents()
    {
      this._formToControl.Activated += new EventHandler(this.frmTracking_Activate);
      this._formToControl.Closed += new EventHandler(this.frmTracking_Closed);
    }

    protected override void WndProc(ref Message m)
    {
      if (this._formToControl == null)
        base.WndProc(ref m);
      if (m.Msg == 278)
      {
        base.WndProc(ref m);
        IntPtr wparam = m.WParam;
        switch (this._formToControl.WindowState)
        {
          case FormWindowState.Normal:
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61728, 1);
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61472, 0);
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61488, 0);
            break;
          case FormWindowState.Minimized:
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61728, 0);
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61472, 1);
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61488, 0);
            break;
          case FormWindowState.Maximized:
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61728, 0);
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61488, 1);
            SafeAPI.EnableMenuItem(wparam.ToInt32(), 61472, 0);
            break;
        }
      }
      else if (m.Msg == 274)
      {
        switch (m.WParam.ToInt32())
        {
          case 61472:
            this._formToControl.WindowState = FormWindowState.Minimized;
            break;
          case 61488:
            this._formToControl.WindowState = FormWindowState.Maximized;
            break;
          case 61536:
            this._formToControl.Close();
            break;
          case 61728:
            SafeAPI.SendMessage(this._formToControl.Handle, 274, 61728, 0);
            break;
        }
      }
      else
        base.WndProc(ref m);
    }
  }
}
