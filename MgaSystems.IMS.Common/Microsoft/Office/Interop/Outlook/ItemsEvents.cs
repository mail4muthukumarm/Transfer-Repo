// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Outlook.ItemsEvents
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Outlook;

[CompilerGenerated]
[Guid("00063077-0000-0000-C000-000000000046")]
[InterfaceType(2)]
[TypeIdentifier]
[ComImport]
public interface ItemsEvents
{
  [DispId(61441)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemAdd([MarshalAs(UnmanagedType.IDispatch), In] object Item);
}
