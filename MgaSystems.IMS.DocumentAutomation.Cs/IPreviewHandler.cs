// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.DocumentAutomation.DocumentPreview.IPreviewHandler
// Assembly: MgaSystems.IMS.DocumentAutomation.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 40237120-7607-4A2A-83F2-11594214BFC1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.DocumentAutomation.Cs.dll

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.DocumentAutomation.DocumentPreview;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8895b1c6-b41f-4c1c-a562-0d564250836f")]
[ComImport]
internal interface IPreviewHandler
{
  void SetWindow(IntPtr hwnd, ref Rectangle rect);

  void SetRect(ref Rectangle rect);

  void DoPreview();

  void Unload();

  void SetFocus();

  void QueryFocus(out IntPtr phwnd);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  uint TranslateAccelerator(ref Message pmsg);
}
