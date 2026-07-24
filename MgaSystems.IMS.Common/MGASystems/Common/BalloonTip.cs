// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.BalloonTip
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public sealed class BalloonTip
{
  private const int ECM_FIRST = 5376;
  private const int EM_SHOWBALLOONTIP = 5379;

  [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern int SendMessage(
    IntPtr hWnd,
    int wMsg,
    int wParam,
    ref BalloonTip.EDITBALLOONTIP lParam);

  private BalloonTip()
  {
  }

  public static void ShowEditTip(
    Control targetTextBox,
    string title,
    string text,
    BalloonTip.BalloonTipIcons tipIcon)
  {
    if (targetTextBox == null)
      throw new ArgumentNullException(nameof (targetTextBox));
    if (!CurrentUser.Instance.UsingXP)
      throw new InvalidOperationException("User's OS does not support EDITBALLOONTIP");
    BalloonTip.EDITBALLOONTIP lParam;
    lParam.cbStruct = Marshal.SizeOf(typeof (BalloonTip.EDITBALLOONTIP));
    lParam.pszText = text;
    lParam.pszTitle = title;
    lParam.ttiIcon = (int) tipIcon;
    try
    {
      if (targetTextBox.Disposing || targetTextBox.IsDisposed || !targetTextBox.IsHandleCreated)
        return;
      BalloonTip.SendMessage(targetTextBox.Handle, 5379, 0, ref lParam);
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private struct EDITBALLOONTIP
  {
    public int cbStruct;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string pszTitle;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string pszText;
    public int ttiIcon;
  }

  public enum BalloonTipIcons
  {
    None,
    Info,
    Exclamation,
    Critical,
    Blank,
  }
}
