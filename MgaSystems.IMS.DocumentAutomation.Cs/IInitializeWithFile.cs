// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.DocumentAutomation.DocumentPreview.IInitializeWithFile
// Assembly: MgaSystems.IMS.DocumentAutomation.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 40237120-7607-4A2A-83F2-11594214BFC1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.DocumentAutomation.Cs.dll

using System.Runtime.InteropServices;

#nullable disable
namespace MgaSystems.IMS.DocumentAutomation.DocumentPreview;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b7d14566-0509-4cce-a71f-0a554233bd9b")]
[ComImport]
internal interface IInitializeWithFile
{
  void Initialize([MarshalAs(UnmanagedType.LPWStr)] string pszFilePath, uint grfMode);
}
