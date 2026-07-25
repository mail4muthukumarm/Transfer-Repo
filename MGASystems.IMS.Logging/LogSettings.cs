// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Logging.LogSettings
// Assembly: MGASystems.IMS.Logging, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DEDE5ABB-2A35-47E4-BD3C-0B33B15168EB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Logging.dll

using MGASystems.IMS.Logging.Administration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

#nullable disable
namespace MGASystems.IMS.Logging;

[Serializable]
internal class LogSettings
{
  public static readonly string SerializationSettingsDirectory = Path.GetTempPath() + "MGA Systems\\IMS 2.0\\Logging\\";
  private static readonly string serializationSettingsFile = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}serializationsettings.mga", (object) LogSettings.SerializationSettingsDirectory);

  public Dictionary<string, string> LogCategories { get; set; }

  public Dictionary<string, LogDestination> LogCategoryDestinations { get; set; }

  public void Serialize()
  {
    if (!Directory.Exists(LogSettings.SerializationSettingsDirectory))
      Directory.CreateDirectory(LogSettings.SerializationSettingsDirectory);
    using (FileStream serializationStream = new FileStream(LogSettings.serializationSettingsFile, FileMode.Create, FileAccess.ReadWrite))
      new BinaryFormatter().Serialize((Stream) serializationStream, (object) this);
  }

  public static LogSettings Deserialize()
  {
    LogSettings logSettings = (LogSettings) null;
    if (File.Exists(LogSettings.serializationSettingsFile))
    {
      using (FileStream serializationStream = new FileStream(LogSettings.serializationSettingsFile, FileMode.Open, FileAccess.ReadWrite))
      {
        try
        {
          logSettings = new BinaryFormatter().Deserialize((Stream) serializationStream) as LogSettings;
        }
        catch (Exception ex) when (ex is SerializationException || ex is FileLoadException)
        {
          logSettings = LogSettings.CreateLogSettings();
        }
        if (logSettings.LogCategories == null)
          logSettings.LogCategories = new Dictionary<string, string>();
        if (logSettings.LogCategoryDestinations == null)
          logSettings.LogCategoryDestinations = new Dictionary<string, LogDestination>();
      }
    }
    else
      logSettings = LogSettings.CreateLogSettings();
    LogSettings.InitializeSettings(logSettings);
    return logSettings;
  }

  private static void InitializeSettings(LogSettings logSettings)
  {
    if (logSettings == null)
      throw new ArgumentNullException(nameof (logSettings));
    Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
    Type imsVisibleType = ((IEnumerable<Assembly>) assemblies).Select<Assembly, Type>((Func<Assembly, Type>) (assembly => assembly.GetType("MGASystems.Common.ImsVisibleAttribute", false))).FirstOrDefault<Type>((Func<Type, bool>) (type => type != (Type) null));
    List<string> stringList = new List<string>(logSettings.LogCategories.Select<KeyValuePair<string, string>, string>((Func<KeyValuePair<string, string>, string>) (item => item.Key)));
    foreach (LogCategoryAttribute categoryAttribute in ((IEnumerable<Assembly>) assemblies).Where<Assembly>((Func<Assembly, bool>) (assembly =>
    {
      if (assembly.FullName.Contains("MGASystems.Data"))
        return true;
      return imsVisibleType != (Type) null && assembly.GetCustomAttributes(imsVisibleType, true).Length == 1;
    })).SelectMany<Assembly, Type>((Func<Assembly, IEnumerable<Type>>) (assembly => (IEnumerable<Type>) assembly.GetTypes())).SelectMany<Type, object>((Func<Type, IEnumerable<object>>) (type => (IEnumerable<object>) type.GetCustomAttributes(typeof (LogCategoryAttribute), false))).Cast<LogCategoryAttribute>())
    {
      if (!logSettings.LogCategories.ContainsKey(categoryAttribute.CategoryCode))
        logSettings.LogCategories.Add(categoryAttribute.CategoryCode, categoryAttribute.Category);
      if (stringList.Contains(categoryAttribute.CategoryCode))
        stringList.Remove(categoryAttribute.CategoryCode);
    }
    foreach (string key in stringList)
      logSettings.LogCategories.Remove(key);
    foreach (KeyValuePair<string, string> keyValuePair in logSettings.LogCategories.Where<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (logCategory => !logSettings.LogCategoryDestinations.ContainsKey(logCategory.Key))))
      logSettings.LogCategoryDestinations.Add(keyValuePair.Key, LogDestination.Disabled);
  }

  private static LogSettings CreateLogSettings()
  {
    return new LogSettings()
    {
      LogCategories = new Dictionary<string, string>(),
      LogCategoryDestinations = new Dictionary<string, LogDestination>()
    };
  }
}
