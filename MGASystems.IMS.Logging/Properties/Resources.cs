// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Logging.Properties.Resources
// Assembly: MGASystems.IMS.Logging, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DEDE5ABB-2A35-47E4-BD3C-0B33B15168EB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Logging.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Logging.Properties;

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
      if (MGASystems.IMS.Logging.Properties.Resources.resourceMan == null)
        MGASystems.IMS.Logging.Properties.Resources.resourceMan = new ResourceManager("MGASystems.IMS.Logging.Properties.Resources", typeof (MGASystems.IMS.Logging.Properties.Resources).Assembly);
      return MGASystems.IMS.Logging.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.IMS.Logging.Properties.Resources.resourceCulture;
    set => MGASystems.IMS.Logging.Properties.Resources.resourceCulture = value;
  }

  internal static string ExceptionTextCouldNotFindTopLevelMenu
  {
    get
    {
      return MGASystems.IMS.Logging.Properties.Resources.ResourceManager.GetString(nameof (ExceptionTextCouldNotFindTopLevelMenu), MGASystems.IMS.Logging.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap Troubleshooting
  {
    get
    {
      return (Bitmap) MGASystems.IMS.Logging.Properties.Resources.ResourceManager.GetObject(nameof (Troubleshooting), MGASystems.IMS.Logging.Properties.Resources.resourceCulture);
    }
  }
}
