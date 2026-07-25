// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.My.MySettings
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.My;

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
  [DefaultSettingValue("Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True;Persist Security Info=False;Packet Size=4096;Workstation ID=ERICHARDS1")]
  public string IMSConnectionString => Conversions.ToString(this[nameof (IMSConnectionString)]);

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.ConnectionString)]
  [DefaultSettingValue("Data Source=TEAMMGA;Initial Catalog=IMS;Integrated Security=True")]
  public string IMSConnectionString1 => Conversions.ToString(this[nameof (IMSConnectionString1)]);
}
