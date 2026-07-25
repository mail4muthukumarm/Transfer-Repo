// Decompiled with JetBrains decompiler
// Type: TrayBalloon
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
public class TrayBalloon
{
  private NotifyIcon _trayIcon;

  [DllImport("Shell32", SetLastError = true)]
  private static extern void Shell_NotifyIcon(uint dwMessage, ref TrayBalloon.NOTIFYICONDATA lpdata);

  public TrayBalloon(NotifyIcon trayIcon) => this._trayIcon = trayIcon;

  public void ShowBalloon(
    string title,
    string text,
    TrayBalloon.NotificationType flags,
    int timeout)
  {
    TrayBalloon.NOTIFYICONDATA lpdata = new TrayBalloon.NOTIFYICONDATA();
    NativeWindow nativeWindow = (NativeWindow) this._trayIcon.GetType().InvokeMember("window", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, (Binder) null, (object) this._trayIcon, new object[0]);
    int num = (int) this._trayIcon.GetType().InvokeMember("id", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, (Binder) null, (object) this._trayIcon, new object[0]);
    IntPtr handle = nativeWindow.Handle;
    lpdata.structureSize = (uint) Marshal.SizeOf<TrayBalloon.NOTIFYICONDATA>(lpdata);
    lpdata.notifyIconFlags = 16U /*0x10*/;
    lpdata.iconID = num;
    lpdata.windowHandle = handle;
    lpdata.balloonToolTip = text;
    lpdata.balloonTitle = title;
    lpdata.timeout = (uint) timeout;
    lpdata.infoFlags = (uint) flags;
    TrayBalloon.Shell_NotifyIcon(1U, ref lpdata);
  }

  public void ShowBalloon(string title, string text, TrayBalloon.NotificationType flags)
  {
    this.ShowBalloon(title, text, flags, 10000);
  }

  public void ShowBalloon(string title, string text)
  {
    this.ShowBalloon(title, text, TrayBalloon.NotificationType.Info);
  }

  private struct NOTIFYICONDATA
  {
    public uint structureSize;
    public IntPtr windowHandle;
    public int iconID;
    public uint notifyIconFlags;
    public uint callbackMessage;
    public IntPtr iconHandle;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128 /*0x80*/)]
    public string standardToolTip;
    public uint iconState;
    public uint stateMask;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256 /*0x0100*/)]
    public string balloonToolTip;
    public uint timeout;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64 /*0x40*/)]
    public string balloonTitle;
    public uint infoFlags;
  }

  [Flags]
  public enum NotificationType
  {
    None = 0,
    Info = 1,
    Warning = 2,
    Error = Warning | Info, // 0x00000003
    IconMask = 15, // 0x0000000F
    NoSound = 16, // 0x00000010
  }
}
