// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.RichText.UnsafeNativeMethods
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.RichText;

internal static class UnsafeNativeMethods
{
  internal const int EM_FORMATRANGE = 1081;

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, IntPtr lParam);
}
