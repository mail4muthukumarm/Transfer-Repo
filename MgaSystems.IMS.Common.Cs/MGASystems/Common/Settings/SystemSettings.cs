// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Settings.SystemSettings
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.Interfaces;
using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.Common.Settings;

public static class SystemSettings
{
  private static readonly Encryption _enc = new Encryption();
  private static IManageSettings _settings = (IManageSettings) new ImsDbSettings();

  [EditorBrowsable(EditorBrowsableState.Never)]
  public static void SetCustomProvider(IManageSettings settings)
  {
    if (settings == null)
      return;
    SystemSettings._settings = settings;
  }

  public static T GetSetting<T>(string settingKey, T defaultValue = null)
  {
    return SystemSettings._settings.GetSetting<T>(settingKey, defaultValue);
  }

  public static string GetEncryptedSetting(string settingKey, string defaultValue = null, bool allowSafe = false)
  {
    string setting = SystemSettings._settings.GetSetting<string>(settingKey, defaultValue.EnsureEncrypted());
    return setting != null ? setting.IMSDecrypt(allowSafe) : (string) null;
  }

  public static void SetSetting<T>(string settingKey, T value, string settingColumn = null)
  {
    SystemSettings._settings.SetSetting<T>(settingKey, value, settingColumn);
  }

  public static Lazy<T> GetLazySetting<T>(string settingKey, T defaultValue = null, bool threadSafe = true)
  {
    return new Lazy<T>((Func<T>) (() => SystemSettings._settings.GetSetting<T>(settingKey, defaultValue)), threadSafe);
  }

  public static Lazy<T> GetLazySetting<T>(string settingKey, Lazy<T> defaultValue = null, bool threadSafe = true)
  {
    return new Lazy<T>((Func<T>) (() => SystemSettings._settings.GetSetting<T>(settingKey, (defaultValue ?? new Lazy<T>((Func<T>) (() => default (T)))).Value)), threadSafe);
  }

  private static string EnsureEncrypted(this string value)
  {
    if (string.IsNullOrEmpty(value))
      return (string) null;
    try
    {
      SystemSettings._enc.DecryptTripleDes(value);
      return value;
    }
    catch
    {
      return SystemSettings._enc.EncryptTripleDes(value);
    }
  }

  private static string IMSDecrypt(this string value, bool allowSafe)
  {
    try
    {
      return SystemSettings._enc.DecryptTripleDes(value);
    }
    catch (Exception ex) when (allowSafe)
    {
      return value;
    }
  }
}
