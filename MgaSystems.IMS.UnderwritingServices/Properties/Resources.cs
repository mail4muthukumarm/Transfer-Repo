// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Properties.Resources
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
      if (MgaSystems.IMS.UnderwritingServices.Properties.Resources.resourceMan == null)
        MgaSystems.IMS.UnderwritingServices.Properties.Resources.resourceMan = new ResourceManager("MgaSystems.IMS.UnderwritingServices.Properties.Resources", typeof (MgaSystems.IMS.UnderwritingServices.Properties.Resources).Assembly);
      return MgaSystems.IMS.UnderwritingServices.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MgaSystems.IMS.UnderwritingServices.Properties.Resources.resourceCulture;
    set => MgaSystems.IMS.UnderwritingServices.Properties.Resources.resourceCulture = value;
  }

  internal static string MVR
  {
    get => MgaSystems.IMS.UnderwritingServices.Properties.Resources.ResourceManager.GetString(nameof (MVR), MgaSystems.IMS.UnderwritingServices.Properties.Resources.resourceCulture);
  }
}
