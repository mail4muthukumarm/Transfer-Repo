// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Logging.Log
// Assembly: MGASystems.IMS.Logging, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DEDE5ABB-2A35-47E4-BD3C-0B33B15168EB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Logging.dll

using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace MGASystems.IMS.Logging;

public static class Log
{
  private static readonly TraceSource liveLogSource = new TraceSource(nameof (LiveLogSource));
  private static LogSettings logSettings;

  static Log() => Trace.UseGlobalLock = false;

  public static TraceSource LiveLogSource => Log.liveLogSource;

  public static void Write(string message, params string[] categories)
  {
    foreach (string category in categories)
      Trace.Write((object) message, category);
  }

  public static LogDestination GetDestination(string categoryCode)
  {
    return !Log.LogCategoryDestinations.ContainsKey(categoryCode) ? LogDestination.Disabled : Log.LogSettings.LogCategoryDestinations[categoryCode];
  }

  public static void SetDestination(string categoryCode, LogDestination destination)
  {
    Log.LogSettings.LogCategoryDestinations[categoryCode] = destination;
  }

  public static Dictionary<string, string> LogCategories => Log.LogSettings.LogCategories;

  public static Dictionary<string, LogDestination> LogCategoryDestinations
  {
    get => Log.LogSettings.LogCategoryDestinations;
  }

  public static void SerializeLogSettings() => Log.LogSettings.Serialize();

  public static string SerializationSettingsDirectory => LogSettings.SerializationSettingsDirectory;

  private static LogSettings LogSettings
  {
    get => Log.logSettings ?? (Log.logSettings = LogSettings.Deserialize());
  }
}
