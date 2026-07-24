// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.SR
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using System.Reflection;
using System.Resources;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Forms;

internal class SR
{
  private static ResourceManager _rm;
  private const string RESNAME = "MGASystems.Ims.Forms.Strings";

  private SR()
  {
  }

  private static ResourceManager ResMan
  {
    get
    {
      if (SR._rm == null)
        SR._rm = new ResourceManager("MGASystems.Ims.Forms.Strings", Assembly.GetExecutingAssembly());
      return SR._rm;
    }
  }

  public static string GetString(string id)
  {
    return SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture);
  }
}
