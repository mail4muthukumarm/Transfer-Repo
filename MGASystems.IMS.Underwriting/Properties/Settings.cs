// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Properties.Settings
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Underwriting.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
  private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

  public static Settings Default => Settings.defaultInstance;

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.ConnectionString)]
  [DefaultSettingValue("Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True;Persist Security Info=False;Packet Size=4096;Workstation ID=ERICHARDS1")]
  public string IMSConnectionString => (string) this[nameof (IMSConnectionString)];
}
