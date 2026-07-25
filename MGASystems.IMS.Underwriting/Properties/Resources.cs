// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Properties.Resources
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Underwriting.Properties;

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
      if (MGASystems.IMS.Underwriting.Properties.Resources.resourceMan == null)
        MGASystems.IMS.Underwriting.Properties.Resources.resourceMan = new ResourceManager("MGASystems.IMS.Underwriting.Properties.Resources", typeof (MGASystems.IMS.Underwriting.Properties.Resources).Assembly);
      return MGASystems.IMS.Underwriting.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.IMS.Underwriting.Properties.Resources.resourceCulture;
    set => MGASystems.IMS.Underwriting.Properties.Resources.resourceCulture = value;
  }

  internal static Bitmap AdditionalInterest
  {
    get
    {
      return (Bitmap) MGASystems.IMS.Underwriting.Properties.Resources.ResourceManager.GetObject(nameof (AdditionalInterest), MGASystems.IMS.Underwriting.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap BulkRenewal
  {
    get
    {
      return (Bitmap) MGASystems.IMS.Underwriting.Properties.Resources.ResourceManager.GetObject(nameof (BulkRenewal), MGASystems.IMS.Underwriting.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap PieChart
  {
    get
    {
      return (Bitmap) MGASystems.IMS.Underwriting.Properties.Resources.ResourceManager.GetObject(nameof (PieChart), MGASystems.IMS.Underwriting.Properties.Resources.resourceCulture);
    }
  }
}
