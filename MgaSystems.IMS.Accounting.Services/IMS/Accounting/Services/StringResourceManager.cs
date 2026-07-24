// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.StringResourceManager
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System.Reflection;
using System.Resources;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

public sealed class StringResourceManager
{
  private const string ResourceName = "MGASystems.IMS.Accounting.Services.Strings";
  private static ResourceManager resManager;

  private static ResourceManager ResManager
  {
    get
    {
      if (StringResourceManager.resManager == null)
        StringResourceManager.resManager = new ResourceManager("MGASystems.IMS.Accounting.Services.Strings", Assembly.GetExecutingAssembly());
      return StringResourceManager.resManager;
    }
  }

  private StringResourceManager()
  {
  }

  public static string GetString(string resourceId)
  {
    return StringResourceManager.ResManager.GetString(resourceId, Thread.CurrentThread.CurrentCulture);
  }
}
