// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UpdateCheck.UpdaterSettings
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Configuration;
using System.IO;

#nullable disable
namespace MGASystems.Common.UpdateCheck;

internal class UpdaterSettings
{
  public static string ApplicationDirectory => AppContext.BaseDirectory;

  public bool Valid { get; }

  public string UpdateServicesUrl { get; }

  public Guid UpdatePackageKey { get; }

  public string UpdaterPath { get; }

  public UpdaterSettings()
  {
    try
    {
      this.UpdaterPath = Path.Combine(UpdaterSettings.ApplicationDirectory, "IMS_Update.exe");
      string path = Path.Combine(UpdaterSettings.ApplicationDirectory, "IMS_Update.exe.config");
      if (!File.Exists(this.UpdaterPath) || !File.Exists(path))
        return;
      SettingElementCollection settings = ((ClientSettingsSection) ConfigurationManager.OpenExeConfiguration(this.UpdaterPath).SectionGroups["applicationSettings"].Sections["MGASystems.Updater.Properties.Settings"]).Settings;
      this.UpdatePackageKey = new Guid(settings.Get(nameof (UpdatePackageKey)).Value.ValueXml.InnerText);
      this.UpdateServicesUrl = settings.Get("MGAUpdateURL").Value.ValueXml.InnerText;
      this.Valid = true;
    }
    catch (Exception ex)
    {
    }
  }
}
