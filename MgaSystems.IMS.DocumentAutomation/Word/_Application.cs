// Decompiled with JetBrains decompiler
// Type: Word._Application
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Word;

[CompilerGenerated]
[Guid("00020970-0000-0000-C000-000000000046")]
[DefaultMember("Name")]
[TypeIdentifier]
[ComImport]
public interface _Application
{
  [SpecialName]
  [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
  sealed extern void _VtblGap1_3();

  [DispId(0)]
  string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [SpecialName]
  [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
  sealed extern void _VtblGap2_2();

  [DispId(3)]
  Document ActiveDocument { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
