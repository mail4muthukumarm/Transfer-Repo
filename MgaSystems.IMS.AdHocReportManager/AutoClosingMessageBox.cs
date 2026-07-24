// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.AutoClosingMessageBox
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

public class AutoClosingMessageBox
{
  private System.Threading.Timer _timeoutTimer;
  private string _caption;
  private const int WM_CLOSE = 16 /*0x10*/;

  private AutoClosingMessageBox(string text, string caption, int timeout)
  {
    this._caption = caption;
    this._timeoutTimer = new System.Threading.Timer(new TimerCallback(this.OnTimerElapsed), (object) null, timeout, -1);
    using (this._timeoutTimer)
    {
      int num = (int) MessageBox.Show(text, caption);
    }
  }

  public static void Show(string text, string caption, int timeout)
  {
    AutoClosingMessageBox closingMessageBox = new AutoClosingMessageBox(text, caption, timeout);
  }

  private void OnTimerElapsed(object state)
  {
    IntPtr window = AutoClosingMessageBox.FindWindow("#32770", this._caption);
    if (window != IntPtr.Zero)
      AutoClosingMessageBox.SendMessage(window, 16U /*0x10*/, IntPtr.Zero, IntPtr.Zero);
    this._timeoutTimer.Dispose();
  }

  [DllImport("user32.dll", SetLastError = true)]
  private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
}
