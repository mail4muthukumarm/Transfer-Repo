// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.SR
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System.Reflection;
using System.Resources;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Policies;

internal class SR
{
  private static ResourceManager _rm;
  private const string RESNAME = "MGASystems.Policies.Strings";

  private SR()
  {
  }

  private static ResourceManager ResMan
  {
    get
    {
      if (SR._rm == null)
        SR._rm = new ResourceManager("MGASystems.Policies.Strings", Assembly.GetExecutingAssembly());
      return SR._rm;
    }
  }

  internal static string GetString(string id)
  {
    return SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture);
  }
}
