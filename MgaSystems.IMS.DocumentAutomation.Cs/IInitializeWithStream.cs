// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.DocumentAutomation.DocumentPreview.IInitializeWithStream
// Assembly: MgaSystems.IMS.DocumentAutomation.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 40237120-7607-4A2A-83F2-11594214BFC1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.DocumentAutomation.Cs.dll

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

#nullable disable
namespace MgaSystems.IMS.DocumentAutomation.DocumentPreview;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b824b49d-22ac-4161-ac8a-9916e8fa3f7f")]
[ComImport]
internal interface IInitializeWithStream
{
  void Initialize(IStream pstream, uint grfMode);
}
