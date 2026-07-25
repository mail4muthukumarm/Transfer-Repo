// Decompiled with JetBrains decompiler
// Type: My.Resources.Resources
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace My.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
  internal Resources()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public static ResourceManager ResourceManager
  {
    get
    {
      if (My.Resources.Resources.resourceMan == null)
        My.Resources.Resources.resourceMan = new ResourceManager("MGASystems.Common.Resources", typeof (My.Resources.Resources).Assembly);
      return My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public static CultureInfo Culture
  {
    get => My.Resources.Resources.resourceCulture;
    set => My.Resources.Resources.resourceCulture = value;
  }

  public static byte[] aero_arrow
  {
    get
    {
      return (byte[]) My.Resources.Resources.ResourceManager.GetObject(nameof (aero_arrow), My.Resources.Resources.resourceCulture);
    }
  }

  public static byte[] aero_busy
  {
    get
    {
      return (byte[]) My.Resources.Resources.ResourceManager.GetObject(nameof (aero_busy), My.Resources.Resources.resourceCulture);
    }
  }

  public static byte[] aero_link
  {
    get
    {
      return (byte[]) My.Resources.Resources.ResourceManager.GetObject(nameof (aero_link), My.Resources.Resources.resourceCulture);
    }
  }

  public static byte[] aero_working
  {
    get
    {
      return (byte[]) My.Resources.Resources.ResourceManager.GetObject(nameof (aero_working), My.Resources.Resources.resourceCulture);
    }
  }

  public static Icon Logo
  {
    get => (Icon) My.Resources.Resources.ResourceManager.GetObject(nameof (Logo), My.Resources.Resources.resourceCulture);
  }

  public static Bitmap Troubleshooting
  {
    get
    {
      return (Bitmap) My.Resources.Resources.ResourceManager.GetObject(nameof (Troubleshooting), My.Resources.Resources.resourceCulture);
    }
  }
}
