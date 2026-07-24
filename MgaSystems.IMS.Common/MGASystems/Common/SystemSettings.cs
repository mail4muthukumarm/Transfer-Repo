// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SystemSettings
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
[Obsolete("See Common.Cs version of SystemSettings instead.")]
public sealed class SystemSettings
{
  public static string GetStringSetting(string key)
  {
    return (string) SystemSettings.GetSetting(key, "SettingValueString");
  }

  public static Decimal GetNumericSetting(string key)
  {
    return (Decimal) SystemSettings.GetSetting(key, "SettingValueNumeric");
  }

  public static bool GetBoolSetting(string key)
  {
    return Conversions.ToBoolean(SystemSettings.GetSetting(key, "SettingValueBool"));
  }

  private static object GetSetting(string key, string columnName)
  {
    return DefaultDatabase.ExecuteScalar(CommandType.Text, $"SELECT {columnName} FROM tblSystemSettings WHERE Setting=@Setting", new object[2]
    {
      (object) "@Setting",
      (object) key
    });
  }

  public static void SetStringSetting(string key, string value)
  {
    SystemSettings.SetSetting(key, "SettingValueString", (object) value);
  }

  public static void SetNumericSetting(string key, Decimal value)
  {
    SystemSettings.SetSetting(key, "SettingValueNumeric", (object) value);
  }

  public static void SetBoolSetting(string key, bool value)
  {
    SystemSettings.SetSetting(key, "SettingValueBool", (object) value);
  }

  private static void SetSetting(string key, string columnName, object value)
  {
    if (SystemSettings.KeyExists(key))
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"UPDATE tblSystemSettings SET {columnName} = @value WHERE Setting=@Setting", new object[4]
      {
        (object) "@value",
        value,
        (object) "@Setting",
        (object) key
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"INSERT INTO tblSystemSettings(Setting,{columnName})VALUES(@Setting,@value)", new object[4]
      {
        (object) "@value",
        value,
        (object) "@Setting",
        (object) key
      });
  }

  public static bool KeyExists(string key)
  {
    return SystemSettings.GetSetting(key, "SettingValueString") != null;
  }
}
