// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Settings.ImsDbSettings
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.Interfaces;
using MGASystems.Data;
using System;
using System.Data;
using System.Runtime.Caching;

#nullable disable
namespace MGASystems.Common.Settings;

public class ImsDbSettings : IManageSettings
{
  private const string ExistSetting = "SELECT Setting FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @Setting";
  private const string SelectString = "SELECT SettingValueString FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @Setting";
  private const string SelectNumber = "SELECT SettingValueNumeric FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @Setting";
  private const string SelectBoolean = "SELECT SettingValueBool FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @Setting";
  private const string UpdateString = "UPDATE dbo.tblSystemSettings SET SettingValueString = @Value WHERE Setting = @Setting; INSERT INTO dbo.tblSystemSettings (Setting, SettingValueString) SELECT @Setting, @Value WHERE @@ROWCOUNT = 0";
  private const string UpdateNumber = "UPDATE dbo.tblSystemSettings SET SettingValueNumeric = @Value WHERE Setting = @Setting; INSERT INTO dbo.tblSystemSettings (Setting, SettingValueNumeric) SELECT @Setting, @Value WHERE @@ROWCOUNT = 0";
  private const string UpdateBoolean = "UPDATE dbo.tblSystemSettings SET SettingValueBool = @Value WHERE Setting = @Setting; INSERT INTO dbo.tblSystemSettings (Setting, SettingValueBool) SELECT @Setting, @Value WHERE @@ROWCOUNT = 0";

  private MemoryCache SettingsCache { get; } = MemoryCache.Default;

  public static bool CacheValues { get; set; } = true;

  public bool HasSetting(string settingKey)
  {
    if (this.SettingsCache.Contains("SystemSetting." + settingKey, (string) null))
      return true;
    return ((!(this.SettingsCache.AddOrGetExisting("SystemSetting.HasSetting." + settingKey, (object) (DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Setting FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @Setting", new object[2]
    {
      (object) "@Setting",
      (object) settingKey
    }) != null), DateTimeOffset.Now.AddHours(1.0), (string) null) is bool existing) ? 0 : 1) & (existing ? 1 : 0)) != 0;
  }

  public T GetSetting<T>(string settingKey, T defaultValue = null)
  {
    return this.GetSetting<T>(settingKey, defaultValue, new TimeSpan?(TimeSpan.FromMinutes(10.0)));
  }

  public T GetSetting<T>(string settingKey, T defaultValue, TimeSpan? expireIn)
  {
    if (ImsDbSettings.CacheValues && this.SettingsCache.Get("SystemSetting." + settingKey, (string) null) is T setting1)
      return setting1;
    object setting2 = (object) null;
    try
    {
      SettingColumn column = this.ResolveSettingColumn<T>();
      string str = ImsDbSettings.ResolveSelectText(column);
      if (str != null)
      {
        setting2 = DefaultDatabase.ExecuteScalar(CommandType.Text, str, new object[2]
        {
          (object) "@Setting",
          (object) settingKey
        });
        if (!Utility.IsNull(setting2))
        {
          object obj = setting2;
          Type conversionType = Nullable.GetUnderlyingType(typeof (T));
          if ((object) conversionType == null)
            conversionType = typeof (T);
          setting2 = Convert.ChangeType(obj, conversionType);
        }
        else if (!Utility.IsNull((object) defaultValue))
        {
          this.SetSetting<T>(settingKey, defaultValue, column);
          setting2 = (object) defaultValue;
        }
        else
          setting2 = (object) default (T);
        return (T) setting2;
      }
    }
    finally
    {
      if (ImsDbSettings.CacheValues && !Utility.IsNull(setting2))
        this.SettingsCache.Set("SystemSetting." + settingKey, setting2, DateTimeOffset.Now.Add(expireIn ?? TimeSpan.FromMinutes(10.0)), (string) null);
    }
    return default (T);
  }

  public void SetSetting<T>(string settingKey, T value, string settingDestination)
  {
    SettingColumn result;
    if (string.IsNullOrEmpty(settingDestination) || !Enum.TryParse<SettingColumn>(settingDestination, out result))
      result = this.ResolveSettingColumn<T>();
    this.SetSetting<T>(settingKey, value, result);
  }

  private void SetSetting<T>(string settingKey, T value, SettingColumn column)
  {
    if (Utility.IsNull((object) value))
      throw new ArgumentNullException("Persisting null setting values is not supported.", nameof (value));
    string str = ImsDbSettings.ResolveUpdateText(column);
    if (str == null)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, str, new object[4]
    {
      (object) "@Setting",
      (object) settingKey,
      (object) "@Value",
      (object) value
    });
  }

  protected SettingColumn ResolveSettingColumn<T>() => this.ResolveSettingColumn(typeof (T));

  protected SettingColumn ResolveSettingColumn(Type objType)
  {
    if (objType != (Type) null)
    {
      Type type = Nullable.GetUnderlyingType(objType);
      if ((object) type == null)
        type = objType;
      objType = type;
      switch (Type.GetTypeCode(objType))
      {
        case TypeCode.Boolean:
          return SettingColumn.SettingValueBool;
        case TypeCode.Char:
        case TypeCode.String:
          return SettingColumn.SettingValueString;
        case TypeCode.Byte:
        case TypeCode.Int16:
        case TypeCode.Int32:
        case TypeCode.Int64:
        case TypeCode.Single:
        case TypeCode.Double:
        case TypeCode.Decimal:
          return SettingColumn.SettingValueNumber;
      }
    }
    throw new ArgumentException("Value must be a non-null numeric, string, or boolean", nameof (objType));
  }

  private static string ResolveSelectText(SettingColumn column)
  {
    switch (column)
    {
      case SettingColumn.SettingValueString:
        return "SELECT SettingValueString FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @Setting";
      case SettingColumn.SettingValueNumber:
        return "SELECT SettingValueNumeric FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @Setting";
      case SettingColumn.SettingValueBool:
        return "SELECT SettingValueBool FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @Setting";
      default:
        throw new ArgumentException("Invalid column specified for select text", nameof (column));
    }
  }

  private static string ResolveUpdateText(SettingColumn column)
  {
    switch (column)
    {
      case SettingColumn.SettingValueString:
        return "UPDATE dbo.tblSystemSettings SET SettingValueString = @Value WHERE Setting = @Setting; INSERT INTO dbo.tblSystemSettings (Setting, SettingValueString) SELECT @Setting, @Value WHERE @@ROWCOUNT = 0";
      case SettingColumn.SettingValueNumber:
        return "UPDATE dbo.tblSystemSettings SET SettingValueNumeric = @Value WHERE Setting = @Setting; INSERT INTO dbo.tblSystemSettings (Setting, SettingValueNumeric) SELECT @Setting, @Value WHERE @@ROWCOUNT = 0";
      case SettingColumn.SettingValueBool:
        return "UPDATE dbo.tblSystemSettings SET SettingValueBool = @Value WHERE Setting = @Setting; INSERT INTO dbo.tblSystemSettings (Setting, SettingValueBool) SELECT @Setting, @Value WHERE @@ROWCOUNT = 0";
      default:
        throw new ArgumentException("Invalid column specified for update text", nameof (column));
    }
  }
}
