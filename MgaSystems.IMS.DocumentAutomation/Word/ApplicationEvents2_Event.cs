// Decompiled with JetBrains decompiler
// Type: Word.ApplicationEvents2_Event
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Word;

[CompilerGenerated]
[ComEventInterface(typeof (ApplicationEvents2), typeof (ApplicationEvents2))]
[TypeIdentifier("00020905-0000-0000-c000-000000000046", "Word.ApplicationEvents2_Event")]
[ComImport]
public interface ApplicationEvents2_Event
{
  [SpecialName]
  [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
  sealed extern void _VtblGap1_12();

  event ApplicationEvents2_DocumentBeforeSaveEventHandler DocumentBeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforeSave(
    [In] ApplicationEvents2_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforeSave(
    [In] ApplicationEvents2_DocumentBeforeSaveEventHandler obj0);
}
