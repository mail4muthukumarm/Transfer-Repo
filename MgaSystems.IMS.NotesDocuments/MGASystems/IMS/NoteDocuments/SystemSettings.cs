// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.SystemSettings
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common.Settings;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[StandardModule]
public sealed class SystemSettings
{
  [Obsolete("Use MGASystems.Common.Settings.SystemSettings.cs instead")]
  public static object GetSetting(string settingKey)
  {
    return (object) SystemSettings.GetSetting<Decimal>(settingKey);
  }

  [Obsolete("Use MGASystems.Common.Settings.SystemSettings.cs instead")]
  public static T GetSetting<T>(string settingKey) => SystemSettings.GetSetting<T>(settingKey);

  [Obsolete("Use MGASystems.Common.Settings.SystemSettings.cs instead")]
  public static T GetSetting<T>(string settingKey, T defaultValue)
  {
    return SystemSettings.GetSetting<T>(settingKey, defaultValue);
  }

  [Obsolete("Use MGASystems.Common.Settings.SystemSettings.cs instead")]
  public static void SetSetting(string settingKey, object value)
  {
    if (value is string)
      SystemSettings.SetSetting<string>(settingKey, (string) value);
    else if (value is bool flag)
    {
      SystemSettings.SetSetting<bool>(settingKey, flag);
    }
    else
    {
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(value)))
        throw new ArgumentException("value must be numeric, string, or boolean", nameof (value));
      SystemSettings.SetSetting<Decimal>(settingKey, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(value)));
    }
  }
}
