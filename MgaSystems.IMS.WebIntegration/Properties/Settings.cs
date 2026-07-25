// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.Properties.Settings
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
  private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

  public static Settings Default => Settings.defaultInstance;

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.WebServiceUrl)]
  [DefaultSettingValue("http://dev.virtualearth.net/webservices/v1/geocodeservice/GeocodeService.svc")]
  public string MgaSystems_IMS_WebIntegration_GeocodeService_GeocodeService
  {
    get => (string) this[nameof (MgaSystems_IMS_WebIntegration_GeocodeService_GeocodeService)];
  }

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.WebServiceUrl)]
  [DefaultSettingValue("http://dev.virtualearth.net/webservices/v1/imageryservice/imageryservice.svc")]
  public string MgaSystems_IMS_WebIntegration_ImageryService_ImageryService
  {
    get => (string) this[nameof (MgaSystems_IMS_WebIntegration_ImageryService_ImageryService)];
  }
}
