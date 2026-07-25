// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.My.MySettings
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
  private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

  public static MySettings Default => MySettings.defaultInstance;

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.ConnectionString)]
  [DefaultSettingValue("Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True")]
  public string IMSConnectionString => Conversions.ToString(this[nameof (IMSConnectionString)]);

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.WebServiceUrl)]
  [DefaultSettingValue("http://reports.reliableinspections.net/reliable/request.asmx")]
  public string MgaSystems_IMS_Inspections_Reliable_Request
  {
    get => Conversions.ToString(this[nameof (MgaSystems_IMS_Inspections_Reliable_Request)]);
  }

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.WebServiceUrl)]
  [DefaultSettingValue("http://legacy.majesticservice.com/ExpertInspectWS.asmx")]
  public string MgaSystems_IMS_Inspections_MajesticExpertInsp_ExpertInspectWS
  {
    get
    {
      return Conversions.ToString(this[nameof (MgaSystems_IMS_Inspections_MajesticExpertInsp_ExpertInspectWS)]);
    }
  }
}
