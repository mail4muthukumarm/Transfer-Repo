// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.MySettings
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
  private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

  public static MySettings Default => MySettings.defaultInstance;

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.ConnectionString)]
  [DefaultSettingValue("Data Source=TEAMMGA;Initial Catalog=IMS;Integrated Security=True")]
  public string IMSConnectionString => Conversions.ToString(this[nameof (IMSConnectionString)]);
}
