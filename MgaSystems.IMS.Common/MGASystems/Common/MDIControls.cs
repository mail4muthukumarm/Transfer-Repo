// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MDIControls
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinStatusBar;
using Infragistics.Win.UltraWinToolbars;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public sealed class MDIControls
{
  private static MDIControls _mDIControls;
  private Form _lastActivatedVisibleForm;
  private Form _mdiParent;
  private UltraStatusBar _statusBar;
  private bool _bInitialized;
  private UltraToolbarsManager _toolbarManager;
  private bool _blackBoxMode;

  private MDIControls() => this._blackBoxMode = false;

  public bool BlackBoxMode
  {
    get => this._blackBoxMode;
    set => this._blackBoxMode = value;
  }

  public Form MDIParent => this._mdiParent;

  public UltraStatusBar StatusBar
  {
    get
    {
      if (!this._bInitialized)
        throw new InvalidOperationException("You must call Initialize prior to using the instance.");
      return this._statusBar;
    }
  }

  public string StatusBarText
  {
    get => this._statusBar.Panels["Status"].Text;
    set => this.SetStatusBarText(value);
  }

  public void SetStatusBarText(string text)
  {
    if (this._statusBar?.Panels["Status"] == null)
      return;
    if (((Control) this._statusBar).InvokeRequired)
    {
      ((Control) this._statusBar).Invoke((Delegate) new Action<string>(this.SetStatusBarText), (object) text);
    }
    else
    {
      this._statusBar.Panels["Status"].Text = text;
      ((UltraControlBase) this._statusBar).Refresh();
    }
  }

  public ProgressBarInfo ProgressBar => this._statusBar.Panels["Progress"].ProgressBarInfo;

  public UltraStatusPanel ProgressPanel => this._statusBar.Panels["Progress"];

  public UltraToolbarsManager ToolBarManager => this._toolbarManager;

  public bool StatusBarInfoImageVisible
  {
    set => this._statusBar.Panels["DispImage"].Visible = value;
  }

  public Form LastActivatedVisibleForm
  {
    get => this._lastActivatedVisibleForm;
    set => this._lastActivatedVisibleForm = value;
  }

  public static MDIControls Instance
  {
    get
    {
      if (MDIControls._mDIControls == null)
        MDIControls._mDIControls = new MDIControls();
      return MDIControls._mDIControls;
    }
  }

  public static IProgress<string> GetSetStatusBarTextProgress()
  {
    MDIControls instance = MDIControls.Instance;
    return (instance != null ? (instance.BlackBoxMode ? 1 : 0) : 1) == 0 ? (IProgress<string>) new Progress<string>(new Action<string>(MDIControls.Instance.SetStatusBarText)) : (IProgress<string>) new Progress<string>(new Action<string>(Debug.WriteLine));
  }

  public void Initialize(
    UltraStatusBar statusBar,
    UltraToolbarsManager toolbarManager,
    Form mdiParent)
  {
    this._mdiParent = mdiParent;
    this._statusBar = statusBar;
    this._toolbarManager = toolbarManager;
    this._bInitialized = true;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public void BlackBoxInitialize(
    UltraStatusBar statusBar,
    UltraToolbarsManager toolbarManager,
    Form mdiParent)
  {
    this.Initialize(statusBar, toolbarManager, mdiParent);
    this.BlackBoxMode = true;
  }

  public bool IsFormOpen(Type formType) => this.IsFormOpen(formType, false);

  public bool IsFormOpen(Type formType, bool checkOverrides)
  {
    return this.GetForm(formType, checkOverrides) != null;
  }

  public Form ActivateForm(Type formType) => this.ActivateForm(formType, false);

  public Form ActivateForm(Type formType, bool forceCreate)
  {
    Form form = this.GetForm(formType, true);
    if (form != null)
    {
      if (form.WindowState == FormWindowState.Minimized)
        form.WindowState = FormWindowState.Normal;
      form.BringToFront();
    }
    else if (forceCreate)
      form = FormSettings.ShowForm(formType);
    return form;
  }

  private Form GetForm(Type formType, bool checkOverrides)
  {
    if (checkOverrides)
    {
      Type type = ObjectFactory.Instance.GetDerivedType(formType);
      if ((object) type == null)
        type = formType;
      formType = type;
    }
    Form[] mdiChildren = this._mdiParent.MdiChildren;
    int index = 0;
    Form form1;
    while (index < mdiChildren.Length)
    {
      Form form2 = mdiChildren[index];
      if (form2.GetType().Equals(formType))
      {
        form1 = form2;
        goto label_10;
      }
      checked { ++index; }
    }
    form1 = (Form) null;
label_10:
    return form1;
  }
}
