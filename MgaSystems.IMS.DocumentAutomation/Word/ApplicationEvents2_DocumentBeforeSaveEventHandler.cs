// Decompiled with JetBrains decompiler
// Type: Word.ApplicationEvents2_DocumentBeforeSaveEventHandler
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Word;

[CompilerGenerated]
[TypeIdentifier("00020905-0000-0000-c000-000000000046", "Word.ApplicationEvents2_DocumentBeforeSaveEventHandler")]
public delegate void ApplicationEvents2_DocumentBeforeSaveEventHandler(
  [MarshalAs(UnmanagedType.Interface), In] Document Doc,
  [In] ref bool SaveAsUI,
  [In] ref bool Cancel);
