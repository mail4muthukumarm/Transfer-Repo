// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.DocumentProviders.ProviderLogging
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentStorage.DocumentProviders;

internal static class ProviderLogging
{
  private static readonly ConcurrentDictionary<string, string[]> _cache = new ConcurrentDictionary<string, string[]>();

  internal static void WriteLog(string msg, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int line = -1)
  {
    string key = $"{memberName}:{filePath}:{line}";
    string[] strArray;
    if (!ProviderLogging._cache.TryGetValue(key, out strArray))
    {
      MethodBase method = new StackTrace().GetFrames()[1].GetMethod();
      ProviderLogging._cache[key] = strArray = new string[2]
      {
        method.DeclaringType.Name,
        method.Name
      };
    }
    try
    {
      MGASystems.IMS.Logging.Log.Write($"{strArray[0]}.{strArray[1]} {msg} - {line}:{filePath}", "DocumentStorage." + strArray[0]);
    }
    catch
    {
    }
  }
}
