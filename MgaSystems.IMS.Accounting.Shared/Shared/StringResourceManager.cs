// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Shared.StringResourceManager
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using System.Reflection;
using System.Resources;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Accounting.Shared;

public sealed class StringResourceManager
{
  private const string ResourceName = "MGASystems.IMS.Accounting.Shared.Strings";
  private static ResourceManager resManager;

  private StringResourceManager()
  {
  }

  private static ResourceManager ResManager
  {
    get
    {
      if (StringResourceManager.resManager == null)
        StringResourceManager.resManager = new ResourceManager("MGASystems.IMS.Accounting.Shared.Strings", Assembly.GetExecutingAssembly());
      return StringResourceManager.resManager;
    }
  }

  public static string GetString(string resourceId)
  {
    return StringResourceManager.ResManager.GetString(resourceId, Thread.CurrentThread.CurrentCulture);
  }
}
