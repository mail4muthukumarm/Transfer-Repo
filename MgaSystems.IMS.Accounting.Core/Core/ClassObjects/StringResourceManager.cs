// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System.Reflection;
using System.Resources;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

public sealed class StringResourceManager
{
  private const string ResourceName = "MGASystems.IMS.Accounting.Core.Strings";
  private static ResourceManager resManager;

  private static ResourceManager ResManager
  {
    get
    {
      if (StringResourceManager.resManager == null)
        StringResourceManager.resManager = new ResourceManager("MGASystems.IMS.Accounting.Core.Strings", Assembly.GetExecutingAssembly());
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
