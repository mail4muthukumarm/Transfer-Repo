// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.Properties.Resources
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  internal Resources()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (MgaSystems.IMS.WebIntegration.Properties.Resources.resourceMan == null)
        MgaSystems.IMS.WebIntegration.Properties.Resources.resourceMan = new ResourceManager("MgaSystems.IMS.WebIntegration.Properties.Resources", typeof (MgaSystems.IMS.WebIntegration.Properties.Resources).Assembly);
      return MgaSystems.IMS.WebIntegration.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MgaSystems.IMS.WebIntegration.Properties.Resources.resourceCulture;
    set => MgaSystems.IMS.WebIntegration.Properties.Resources.resourceCulture = value;
  }

  internal static Bitmap Loading
  {
    get
    {
      return (Bitmap) MgaSystems.IMS.WebIntegration.Properties.Resources.ResourceManager.GetObject(nameof (Loading), MgaSystems.IMS.WebIntegration.Properties.Resources.resourceCulture);
    }
  }

  internal static string Maptext
  {
    get => MgaSystems.IMS.WebIntegration.Properties.Resources.ResourceManager.GetString(nameof (Maptext), MgaSystems.IMS.WebIntegration.Properties.Resources.resourceCulture);
  }

  internal static string maptext_latlong
  {
    get => MgaSystems.IMS.WebIntegration.Properties.Resources.ResourceManager.GetString(nameof (maptext_latlong), MgaSystems.IMS.WebIntegration.Properties.Resources.resourceCulture);
  }
}
