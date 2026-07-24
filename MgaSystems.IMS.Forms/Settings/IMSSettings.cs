// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Settings.IMSSettings
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using System;

#nullable disable
namespace MGASystems.IMS.Forms.Settings;

public sealed class IMSSettings
{
  private const string QuickLaunchToolBarIconsUseLargeKey = "QuickLaunchToolBarIconsUseLarge";
  private const string DockLayoutKey = "DockLayoutKey";
  private const string DockLayoutCountKey = "DockLayoutCountKey";
  private static IMSSettings _imsSettings;

  private IMSSettings()
  {
  }

  [Obsolete("Please use MGASystems.IMS.Forms.Serialization.Preferences instead.")]
  public static IMSSettings Instance
  {
    get
    {
      if (IMSSettings._imsSettings == null)
        IMSSettings._imsSettings = new IMSSettings();
      return IMSSettings._imsSettings;
    }
  }
}
