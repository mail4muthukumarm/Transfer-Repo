// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System.Reflection;
using System.Resources;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses;

public sealed class StringResourceManager
{
  private const string ResourceName = "MGASystems.IMS.Accounting.OperatingExpenses.Strings";
  private static ResourceManager resManager;

  private StringResourceManager()
  {
  }

  private static ResourceManager ResManager
  {
    get
    {
      if (StringResourceManager.resManager == null)
        StringResourceManager.resManager = new ResourceManager("MGASystems.IMS.Accounting.OperatingExpenses.Strings", Assembly.GetExecutingAssembly());
      return StringResourceManager.resManager;
    }
  }

  public static string GetString(string resourceId)
  {
    return StringResourceManager.ResManager.GetString(resourceId, Thread.CurrentThread.CurrentCulture);
  }
}
