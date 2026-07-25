// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.MySettings
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

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
