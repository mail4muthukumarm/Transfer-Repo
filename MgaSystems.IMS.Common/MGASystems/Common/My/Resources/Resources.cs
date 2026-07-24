// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.My.Resources.Resources
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.My.Resources;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) MGASystems.Common.My.Resources.Resources.resourceMan, (object) null))
        MGASystems.Common.My.Resources.Resources.resourceMan = new ResourceManager("MGASystems.Common.Resources", typeof (MGASystems.Common.My.Resources.Resources).Assembly);
      return MGASystems.Common.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.Common.My.Resources.Resources.resourceCulture;
    set => MGASystems.Common.My.Resources.Resources.resourceCulture = value;
  }

  internal static byte[] aero_arrow
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(MGASystems.Common.My.Resources.Resources.ResourceManager.GetObject(nameof (aero_arrow), MGASystems.Common.My.Resources.Resources.resourceCulture));
    }
  }

  internal static byte[] aero_busy
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(MGASystems.Common.My.Resources.Resources.ResourceManager.GetObject(nameof (aero_busy), MGASystems.Common.My.Resources.Resources.resourceCulture));
    }
  }

  internal static byte[] aero_link
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(MGASystems.Common.My.Resources.Resources.ResourceManager.GetObject(nameof (aero_link), MGASystems.Common.My.Resources.Resources.resourceCulture));
    }
  }

  internal static byte[] aero_working
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(MGASystems.Common.My.Resources.Resources.ResourceManager.GetObject(nameof (aero_working), MGASystems.Common.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Icon Logo
  {
    get
    {
      return (Icon) RuntimeHelpers.GetObjectValue(MGASystems.Common.My.Resources.Resources.ResourceManager.GetObject(nameof (Logo), MGASystems.Common.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Bitmap Troubleshooting
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MGASystems.Common.My.Resources.Resources.ResourceManager.GetObject(nameof (Troubleshooting), MGASystems.Common.My.Resources.Resources.resourceCulture));
    }
  }
}
