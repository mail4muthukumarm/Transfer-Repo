// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.FormSettings
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[StandardModule]
internal sealed class FormSettings
{
  public static bool HasSecondaryMonitor => Screen.AllScreens.Length > 1;

  public static Form ShowFormDialog(Type formType)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      throw new InvalidOperationException("Can only call ShowFormDialog from the UI thread!");
    Cursor.Current = MgaCursors.WaitCursor;
    Form form;
    try
    {
      form = ObjectFactory.Instance.CreateForm(formType);
      form.ShowInTaskbar = false;
      int num = (int) form.ShowDialog((IWin32Window) MGASystems.IMS.DocumentAutomation.Common.ParentWindow);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
    return form;
  }

  public static void ShowFormOnSecondMonitorIfAvailable(Form frm, bool setMDIParent)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      throw new InvalidOperationException("Can only call ShowFormOnSecondMonitorIfAvailable from the UI thread!");
    if (FormSettings.HasSecondaryMonitor)
    {
      SystemInfo.MoveWindowToSecondaryMonitorRestored(frm);
      frm.Show();
    }
    else
    {
      if (setMDIParent)
        frm.MdiParent = (Form) MGASystems.IMS.DocumentAutomation.Common.ParentWindow;
      if (frm.FormBorderStyle == FormBorderStyle.Sizable)
      {
        Rectangle bounds = Screen.PrimaryScreen.Bounds;
        Size size = new Size(bounds.Size.Width, bounds.Size.Height - 40);
        bounds.Size = size;
        frm.DesktopBounds = bounds;
      }
      frm.Show();
    }
  }

  public static void ShowFormOnSecondMonitorIfAvailableOA(Form frm, bool setMDIParent)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      throw new InvalidOperationException("Can only call ShowFormOnSecondMonitorIfAvailable from the UI thread!");
    if (FormSettings.HasSecondaryMonitor)
    {
      FormSettings.MoveWindowToSecondaryMonitorRestoredTmp(frm);
      frm.Show();
    }
    else
    {
      if (setMDIParent)
        frm.MdiParent = (Form) MGASystems.IMS.DocumentAutomation.Common.ParentWindow;
      frm.DesktopBounds = Screen.PrimaryScreen.Bounds;
      frm.Width = 400;
      frm.Show();
    }
  }

  private static void MoveWindowToSecondaryMonitorRestoredTmp(Form frm)
  {
    if (frm == null)
      throw new ArgumentNullException(nameof (frm));
    if (frm == null)
      throw new ArgumentNullException(nameof (frm));
    if (Screen.AllScreens.Length <= 1)
      return;
    Screen[] allScreens = Screen.AllScreens;
    int index = 0;
    while (index < allScreens.Length)
    {
      Screen screen = allScreens[index];
      if (screen != Screen.PrimaryScreen)
      {
        Rectangle workingArea = screen.WorkingArea;
        if (frm.FormBorderStyle == FormBorderStyle.Sizable)
        {
          frm.DesktopBounds = screen.Bounds;
          frm.Width = 400;
          break;
        }
        frm.Location = new Point(workingArea.Left + (int) Math.Round((double) workingArea.Width / 2.0), workingArea.Top + (int) Math.Round((double) workingArea.Height / 2.0));
        break;
      }
      checked { ++index; }
    }
  }

  public static Form ShowFormDialog(Type formType, params object[] args)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      throw new InvalidOperationException("Can only call ShowFormDialog from the UI thread!");
    Cursor.Current = MgaCursors.WaitCursor;
    Form formEx;
    try
    {
      formEx = ObjectFactory.Instance.CreateFormEX(formType, args);
      formEx.ShowInTaskbar = false;
      formEx.StartPosition = FormStartPosition.CenterScreen;
      int num = (int) formEx.ShowDialog((IWin32Window) MGASystems.IMS.DocumentAutomation.Common.ParentWindow);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
    return formEx;
  }
}
