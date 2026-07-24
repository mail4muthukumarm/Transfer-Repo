// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NativeMethods
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[StandardModule]
public sealed class NativeMethods
{
  internal const int WS_EX_TOOLWINDOW = 128 /*0x80*/;
  internal const int WS_EX_NOACTIVATE = 134217728 /*0x08000000*/;
  internal const int WS_EX_TOPMOST = 8;
  internal const int WM_NCHITTEST = 132;
  internal const int HTTRANSPARENT = -1;

  [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
  internal static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

  [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
  internal static extern int ShowWindow(IntPtr hWnd, int nCmdShow);
}
