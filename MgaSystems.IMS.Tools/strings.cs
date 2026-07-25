// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.strings
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Tools;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class strings
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
  internal strings()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) strings.resourceMan, (object) null))
        strings.resourceMan = new ResourceManager("MGASystems.Tools.strings", typeof (strings).Assembly);
      return strings.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => strings.resourceCulture;
    set => strings.resourceCulture = value;
  }

  internal static string FP_ADOBE_EXTENSION
  {
    get => strings.ResourceManager.GetString(nameof (FP_ADOBE_EXTENSION), strings.resourceCulture);
  }

  internal static string FP_MSG_EXTENSION
  {
    get => strings.ResourceManager.GetString(nameof (FP_MSG_EXTENSION), strings.resourceCulture);
  }

  internal static string FP_OFFICE_REG_KEY
  {
    get => strings.ResourceManager.GetString(nameof (FP_OFFICE_REG_KEY), strings.resourceCulture);
  }

  internal static string FP_PRINT_VERB
  {
    get => strings.ResourceManager.GetString(nameof (FP_PRINT_VERB), strings.resourceCulture);
  }

  internal static string FP_STARTUP_PATH_MASK
  {
    get
    {
      return strings.ResourceManager.GetString(nameof (FP_STARTUP_PATH_MASK), strings.resourceCulture);
    }
  }
}
