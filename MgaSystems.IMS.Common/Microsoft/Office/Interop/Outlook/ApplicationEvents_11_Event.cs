// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Outlook.ApplicationEvents_11_Event
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Outlook;

[CompilerGenerated]
[ComEventInterface(typeof (ApplicationEvents_11), typeof (ApplicationEvents_11))]
[TypeIdentifier("00062fff-0000-0000-c000-000000000046", "Microsoft.Office.Interop.Outlook.ApplicationEvents_11_Event")]
[ComImport]
public interface ApplicationEvents_11_Event
{
  [SpecialName]
  [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
  sealed extern void _VtblGap1_10();

  event ApplicationEvents_11_QuitEventHandler Quit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Quit([In] ApplicationEvents_11_QuitEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Quit([In] ApplicationEvents_11_QuitEventHandler obj0);
}
