// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MessageBalloon
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class MessageBalloon : IDisposable
{
  private Control m_parent;
  private MessageBalloon.TOOLINFO ti;
  private int m_maxWidth;
  private string m_text;
  private string m_title;
  private TooltipIcon m_titleIcon;
  private BalloonAlignment m_align;
  private bool m_absPosn;
  private bool m_centerStem;
  private const string TOOLTIPS_CLASS = "tooltips_class32";
  private const int WS_POPUP = -2147483648 /*0x80000000*/;
  private const int WM_USER = 1024 /*0x0400*/;
  private readonly IntPtr HWND_TOPMOST;
  private const int SWP_NOSIZE = 1;
  private const int SWP_NOMOVE = 2;
  private const int SWP_NOACTIVATE = 16 /*0x10*/;
  private const int SWP_NOZORDER = 4;
  private const int TTS_ALWAYSTIP = 1;
  private const int TTS_NOPREFIX = 2;
  private const int TTS_BALLOON = 64 /*0x40*/;
  private const int TTS_CLOSE = 128 /*0x80*/;
  private const int TTM_TRACKPOSITION = 1042;
  private const int TTM_SETMAXTIPWIDTH = 1048;
  private const int TTM_TRACKACTIVATE = 1041;
  private const int TTM_ADDTOOL = 1074;
  private const int TTM_SETTITLE = 1057;
  private const int TTF_IDISHWND = 1;
  private const int TTF_SUBCLASS = 16 /*0x10*/;
  private const int TTF_TRACK = 32 /*0x20*/;
  private const int TTF_ABSOLUTE = 128 /*0x80*/;
  private const int TTF_TRANSPARENT = 256 /*0x0100*/;
  private const int TTF_CENTERTIP = 2;
  private const int TTF_PARSELINKS = 4096 /*0x1000*/;
  private bool disposed;
  private static MessageBalloon.DWord m_DWord;

  private virtual MessageTool m_tool
  {
    get => this._m_tool;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DeActivateEventHandler activateEventHandler = new DeActivateEventHandler(this.Hide);
      MessageTool mTool1 = this._m_tool;
      if (mTool1 != null)
        mTool1.DeActivate -= activateEventHandler;
      this._m_tool = value;
      MessageTool mTool2 = this._m_tool;
      if (mTool2 == null)
        return;
      mTool2.DeActivate += activateEventHandler;
    }
  }

  [DllImport("User32", SetLastError = true)]
  private static extern int SetWindowPos(
    IntPtr hWnd,
    IntPtr hWndInsertAfter,
    int X,
    int Y,
    int cx,
    int cy,
    int uFlags);

  [DllImport("User32", SetLastError = true)]
  private static extern int GetClientRect(IntPtr hWnd, ref MessageBalloon.RECT lpRect);

  [DllImport("User32", SetLastError = true)]
  private static extern int ClientToScreen(IntPtr hWnd, ref MessageBalloon.RECT lpRect);

  [DllImport("User32", SetLastError = true)]
  private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);

  public MessageBalloon(Control parent)
  {
    this.m_maxWidth = 250;
    this.m_text = "FMS Balloon Tooltip Control Display Message";
    this.m_title = "FMS Balloon Tooltip Message";
    this.m_titleIcon = TooltipIcon.None;
    this.m_align = BalloonAlignment.TopRight;
    this.HWND_TOPMOST = new IntPtr(-1);
    this.m_parent = parent;
    this.m_tool = new MessageTool();
  }

  ~MessageBalloon() => this.Dispose(false);

  public void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }

  private void Dispose(bool disposing)
  {
    if (!this.disposed)
    {
      int num = disposing ? 1 : 0;
      this.Hide();
    }
    this.disposed = true;
  }

  private void CreateTool()
  {
    this.m_tool.CreateHandle(new CreateParams()
    {
      ClassName = "tooltips_class32",
      Style = -2147483453 /*0x800000C3*/
    });
    this.ti = new MessageBalloon.TOOLINFO();
    this.ti.cbSize = Marshal.SizeOf<MessageBalloon.TOOLINFO>(this.ti);
    this.ti.uFlags = 4401;
    if (this.m_absPosn)
      this.ti.uFlags |= 128 /*0x80*/;
    if (this.m_centerStem)
      this.ti.uFlags |= 2;
    this.ti.uId = this.m_tool.Handle;
    this.ti.lpszText = this.m_text;
    this.ti.hwnd = this.m_parent.Handle;
    MessageBalloon.GetClientRect(this.m_parent.Handle, ref this.ti.rect);
    MessageBalloon.ClientToScreen(this.m_parent.Handle, ref this.ti.rect);
    MessageBalloon.SetWindowPos(this.m_tool.Handle, this.HWND_TOPMOST, 0, 0, 0, 0, 19);
    IntPtr num = Marshal.AllocHGlobal(Marshal.SizeOf<MessageBalloon.TOOLINFO>(this.ti));
    Marshal.StructureToPtr<MessageBalloon.TOOLINFO>(this.ti, num, true);
    MessageBalloon.SendMessage(this.m_tool.Handle, 1074, 0, num);
    object structure = Marshal.PtrToStructure(num, typeof (MessageBalloon.TOOLINFO));
    this.ti = structure != null ? (MessageBalloon.TOOLINFO) structure : new MessageBalloon.TOOLINFO();
    MessageBalloon.SendMessage(this.m_tool.Handle, 1048, 0, new IntPtr(this.m_maxWidth));
    IntPtr hglobalAuto = Marshal.StringToHGlobalAuto(this.m_title);
    MessageBalloon.SendMessage(this.m_tool.Handle, 1057, (int) this.m_titleIcon, hglobalAuto);
    this.SetBalloonPosition(this.ti.rect);
    Marshal.FreeHGlobal(num);
    Marshal.FreeHGlobal(hglobalAuto);
  }

  private void SetBalloonPosition(MessageBalloon.RECT rect)
  {
    int LoWord;
    int HiWord;
    switch (this.m_align)
    {
      case BalloonAlignment.TopLeft:
        LoWord = rect.left;
        HiWord = rect.top;
        break;
      case BalloonAlignment.TopMiddle:
        LoWord = (int) Math.Round((double) rect.left + (double) rect.right / 2.0);
        HiWord = rect.top;
        break;
      case BalloonAlignment.TopRight:
        LoWord = rect.left + rect.right;
        HiWord = rect.top;
        break;
      case BalloonAlignment.LeftMiddle:
        LoWord = rect.left;
        HiWord = (int) Math.Round((double) rect.top + (double) rect.bottom / 2.0);
        break;
      case BalloonAlignment.RightMiddle:
        LoWord = rect.left + rect.right;
        HiWord = (int) Math.Round((double) rect.top + (double) rect.bottom / 2.0);
        break;
      case BalloonAlignment.BottomLeft:
        LoWord = rect.left;
        HiWord = rect.top + rect.bottom;
        break;
      case BalloonAlignment.BottomMiddle:
        LoWord = (int) Math.Round((double) rect.left + (double) rect.right / 2.0);
        HiWord = rect.top + rect.bottom;
        break;
      case BalloonAlignment.BottomRight:
        LoWord = rect.left + rect.right;
        HiWord = rect.top + rect.bottom;
        break;
    }
    MessageBalloon.SendMessage(this.m_tool.Handle, 1042, 0, new IntPtr(MessageBalloon.MakeLong(LoWord, HiWord)));
  }

  private void Display(int show)
  {
    IntPtr num = Marshal.AllocHGlobal(Marshal.SizeOf<MessageBalloon.TOOLINFO>(this.ti));
    try
    {
      Marshal.StructureToPtr<MessageBalloon.TOOLINFO>(this.ti, num, true);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    MessageBalloon.SendMessage(this.m_tool.Handle, 1041, show, num);
    Marshal.FreeHGlobal(num);
  }

  public void Hide()
  {
    this.Display(0);
    this.m_tool.DestroyHandle();
  }

  public static int MakeLong(int LoWord, int HiWord)
  {
    return MessageBalloon.MakeLong((short) LoWord, (short) HiWord);
  }

  public static int MakeLong(short LoWord, short HiWord)
  {
    MessageBalloon.m_DWord.LoWord = LoWord;
    MessageBalloon.m_DWord.HiWord = HiWord;
    return MessageBalloon.m_DWord.LongValue;
  }

  public string Title
  {
    get => this.m_title;
    set => this.m_title = value;
  }

  public TooltipIcon TitleIcon
  {
    get => this.m_titleIcon;
    set => this.m_titleIcon = value;
  }

  public string Text
  {
    get => this.m_text;
    set => this.m_text = value;
  }

  public Control Parent
  {
    get => this.m_parent;
    set => this.m_parent = value;
  }

  public void Show()
  {
    this.Hide();
    this.CreateTool();
    this.Display(-1);
  }

  public BalloonAlignment Align
  {
    get => this.m_align;
    set => this.m_align = value;
  }

  public bool UseAbsolutePositioning
  {
    get => this.m_absPosn;
    set => this.m_absPosn = value;
  }

  public bool CenterStem
  {
    get => this.m_centerStem;
    set => this.m_centerStem = value;
  }

  private struct RECT
  {
    public int left;
    public int top;
    public int right;
    public int bottom;
  }

  private struct TOOLINFO
  {
    public int cbSize;
    public int uFlags;
    public IntPtr hwnd;
    public IntPtr uId;
    public MessageBalloon.RECT rect;
    public IntPtr hinst;
    [MarshalAs(UnmanagedType.LPTStr)]
    public string lpszText;
    public uint lParam;
  }

  [StructLayout(LayoutKind.Explicit)]
  private struct DWord
  {
    [FieldOffset(0)]
    public int LongValue;
    [FieldOffset(0)]
    public short LoWord;
    [FieldOffset(2)]
    public short HiWord;
  }
}
