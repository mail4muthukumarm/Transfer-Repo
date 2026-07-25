// Decompiled with JetBrains decompiler
// Type: Word.ApplicationEvents2
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Word;

[CompilerGenerated]
[Guid("000209FE-0000-0000-C000-000000000046")]
[InterfaceType(2)]
[TypeIdentifier]
[ComImport]
public interface ApplicationEvents2
{
  [SpecialName]
  [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
  sealed extern void _VtblGap1_6();

  [DispId(8)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentBeforeSave([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] ref bool SaveAsUI, [In] ref bool Cancel);
}
