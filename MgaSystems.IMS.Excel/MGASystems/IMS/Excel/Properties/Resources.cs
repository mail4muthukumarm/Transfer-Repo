// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Properties.Resources
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MgaSystems.IMS.Excel.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
  internal Resources()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (MgaSystems.IMS.Excel.Properties.Resources.resourceMan == null)
        MgaSystems.IMS.Excel.Properties.Resources.resourceMan = new ResourceManager("MgaSystems.IMS.Excel.Properties.Resources", typeof (MgaSystems.IMS.Excel.Properties.Resources).Assembly);
      return MgaSystems.IMS.Excel.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MgaSystems.IMS.Excel.Properties.Resources.resourceCulture;
    set => MgaSystems.IMS.Excel.Properties.Resources.resourceCulture = value;
  }

  internal static Bitmap excel
  {
    get => (Bitmap) MgaSystems.IMS.Excel.Properties.Resources.ResourceManager.GetObject(nameof (excel), MgaSystems.IMS.Excel.Properties.Resources.resourceCulture);
  }

  internal static Bitmap tag
  {
    get => (Bitmap) MgaSystems.IMS.Excel.Properties.Resources.ResourceManager.GetObject(nameof (tag), MgaSystems.IMS.Excel.Properties.Resources.resourceCulture);
  }
}
