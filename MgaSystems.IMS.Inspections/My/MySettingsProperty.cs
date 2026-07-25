// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.My.MySettingsProperty
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.My;

[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class MySettingsProperty
{
  [HelpKeyword("My.Settings")]
  internal static MySettings Settings => MySettings.Default;
}
