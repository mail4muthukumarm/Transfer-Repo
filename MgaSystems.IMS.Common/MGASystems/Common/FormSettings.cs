// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FormSettings
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.NativeWindowMethods;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

[Serializable]
public sealed class FormSettings
{
  public Size Size;
  public Point Location;
  public FormWindowState WindowState;
  private static IRemoteObjectManager _remoteObjects;

  public FormSettings()
  {
  }

  public FormSettings(Form frm, IRemoteObjectManager remoteObjects)
  {
    if (frm == null)
      throw new ArgumentNullException(nameof (frm));
    FormSettings._remoteObjects = remoteObjects;
    if (frm.WindowState != FormWindowState.Maximized)
      this.Size = frm.Size;
    this.Location = frm.Location;
  }

  public static bool HasSecondaryMonitor => Screen.AllScreens.Length > 1;

  private static void VerifyOnUIThread()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      throw new InvalidOperationException("Forms can only be shown on the UI thread!");
  }

  public static Form ShowForm(Type formType)
  {
    return FormSettings.ShowForm(formType, false, (object[]) null);
  }

  public static Form ShowForm(Type formType, params object[] args)
  {
    return FormSettings.ShowForm(formType, false, args);
  }

  public static Form ShowForm(Type formType, bool displayOnSecondaryMonitorIfAvailable)
  {
    return FormSettings.ShowForm(formType, displayOnSecondaryMonitorIfAvailable, (object[]) null);
  }

  public static Form ShowForm(
    Type formType,
    bool displayOnSecondaryMonitorIfAvailable,
    params object[] args)
  {
    FormSettings.VerifyOnUIThread();
    Cursor.Current = MgaCursors.WaitCursor;
    Form form;
    try
    {
      form = ObjectFactory.Instance.CreateForm(formType, args);
      form.AutoScaleMode = AutoScaleMode.None;
      if (FormSettings._remoteObjects != null)
        ((FormSettings) RuntimeHelpers.GetObjectValue(FormSettings._remoteObjects.GetObject(form.GetType().FullName, (object) null)))?.ApplyToForm(form);
      MDIControls.Instance.MDIParent.Refresh();
      API.LockWindowUpdate(MDIControls.Instance.MDIParent.Handle);
      if (displayOnSecondaryMonitorIfAvailable && FormSettings.HasSecondaryMonitor)
      {
        if (form.Text.StartsWith("frm", StringComparison.OrdinalIgnoreCase))
          form.Text = "Insurance Management System";
        SystemInfo.MoveWindowToSecondaryMonitorRestored(form);
        form.Show();
      }
      else
      {
        form.MdiParent = MDIControls.Instance.MDIParent;
        form.Show();
      }
    }
    finally
    {
      API.LockWindowUpdate(new IntPtr());
      Cursor.Current = MgaCursors.Default;
    }
    return form;
  }

  public static Form ShowFormDialog(Type formType)
  {
    return FormSettings.ShowFormDialog(formType, (object[]) null);
  }

  public static Form ShowFormDialog(Type formType, params object[] args)
  {
    FormSettings.VerifyOnUIThread();
    Cursor.Current = MgaCursors.WaitCursor;
    Form formEx;
    try
    {
      formEx = ObjectFactory.Instance.CreateFormEX(formType, args);
      formEx.ShowInTaskbar = false;
      formEx.StartPosition = FormStartPosition.CenterScreen;
      int num = (int) formEx.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
    return formEx;
  }

  public static TForm ShowForm<TForm>() where TForm : Form
  {
    return (TForm) FormSettings.ShowForm(typeof (TForm));
  }

  public static TForm ShowForm<TForm>(params object[] args) where TForm : Form
  {
    return (TForm) FormSettings.ShowForm(typeof (TForm), args);
  }

  public static TForm ShowForm<TForm>(
    bool displayOnSecondaryMonitorIfAvailable,
    params object[] args)
    where TForm : Form
  {
    return (TForm) FormSettings.ShowForm(typeof (TForm), displayOnSecondaryMonitorIfAvailable, args);
  }

  public static TForm ShowFormDialog<TForm>() where TForm : Form
  {
    return (TForm) FormSettings.ShowFormDialog(typeof (TForm));
  }

  public static TForm ShowFormDialog<TForm>(params object[] args) where TForm : Form
  {
    return (TForm) FormSettings.ShowFormDialog(typeof (TForm), args);
  }

  public static void ShowFormOnSecondMonitorIfAvailable(Form frm)
  {
    FormSettings.ShowFormOnSecondMonitorIfAvailable(frm, true);
  }

  public static void ShowFormOnSecondMonitorIfAvailable(Form frm, bool setMDIParent)
  {
    if (frm == null)
      throw new ArgumentNullException(nameof (frm));
    FormSettings.VerifyOnUIThread();
    if (FormSettings.HasSecondaryMonitor)
    {
      SystemInfo.MoveWindowToSecondaryMonitorRestored(frm);
      frm.Show();
    }
    else
    {
      if (setMDIParent)
        frm.MdiParent = MDIControls.Instance.MDIParent;
      frm.Show();
    }
  }

  public void ApplyToForm(Form frm)
  {
    if (frm == null)
      throw new ArgumentNullException(nameof (frm));
    FormSettings.VerifyOnUIThread();
    if (frm is IFormSettingsIgnore)
      return;
    frm.StartPosition = FormStartPosition.Manual;
    if (frm.FormBorderStyle == FormBorderStyle.Sizable)
    {
      Size size;
      if (this.Size.Height < frm.Size.Height)
      {
        ref Size local = ref this.Size;
        size = frm.Size;
        int height = size.Height;
        local.Height = height;
      }
      int width1 = this.Size.Width;
      size = frm.Size;
      int width2 = size.Width;
      if (width1 < width2)
      {
        ref Size local = ref this.Size;
        size = frm.Size;
        int width3 = size.Width;
        local.Width = width3;
      }
      if (!FormSettings.HasSecondaryMonitor)
      {
        if (!MDIControls.Instance.MDIParent.ClientRectangle.Contains(this.Location))
          this.Location = new Point(0, 0);
        int width4 = this.Size.Width;
        size = MDIControls.Instance.MDIParent.ClientSize;
        int width5 = size.Width;
        if (width4 <= width5)
        {
          int height1 = this.Size.Height;
          size = MDIControls.Instance.MDIParent.ClientSize;
          int height2 = size.Height;
          if (height1 <= height2)
            frm.Size = this.Size;
        }
      }
    }
    frm.Location = this.Location;
  }
}
