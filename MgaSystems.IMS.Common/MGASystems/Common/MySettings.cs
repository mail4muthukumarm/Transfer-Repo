// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MySettings
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
  private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

  public static MySettings Default => MySettings.defaultInstance;

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.WebServiceUrl)]
  [DefaultSettingValue("https://errors.mgasystems.com/imscriticalerror/MGACriticalErrorService.asmx")]
  public string MgaSystems_IMS_Common_MgaReportingServices_MGAReportingServices
  {
    get
    {
      return Conversions.ToString(this[nameof (MgaSystems_IMS_Common_MgaReportingServices_MGAReportingServices)]);
    }
  }

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.WebServiceUrl)]
  [DefaultSettingValue("https://adrconnect.mvrs.com/AdrConnect/AdrConnectWebService.svc")]
  public string MgaSystems_IMS_Common_adrconnect_AdrConnectWebService
  {
    get
    {
      return Conversions.ToString(this[nameof (MgaSystems_IMS_Common_adrconnect_AdrConnectWebService)]);
    }
  }

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [SpecialSetting(SpecialSetting.WebServiceUrl)]
  [DefaultSettingValue("https://ofacprdapp1.dxc-ins.com/PPWSPublic/PPWSPublic.asmx")]
  public string MgaSystems_IMS_Common_pws_PPWebServicePublic
  {
    get => Conversions.ToString(this[nameof (MgaSystems_IMS_Common_pws_PPWebServicePublic)]);
  }
}
