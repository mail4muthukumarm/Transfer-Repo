// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using System.Reflection;
using System.Resources;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger;

public sealed class StringResourceManager
{
  private const string ResourceName = "MGASystems.IMS.Accounting.GeneralLedger.Strings";
  private static ResourceManager resManager;

  private static ResourceManager ResManager
  {
    get
    {
      if (StringResourceManager.resManager == null)
        StringResourceManager.resManager = new ResourceManager("MGASystems.IMS.Accounting.GeneralLedger.Strings", Assembly.GetExecutingAssembly());
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
