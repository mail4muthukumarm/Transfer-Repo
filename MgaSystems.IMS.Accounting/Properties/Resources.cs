// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Properties.Resources
// Assembly: MgaSystems.IMS.Accounting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 118B765D-C703-4927-A662-CA3DF0A8B869
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Properties;

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
      if (MGASystems.IMS.Accounting.Properties.Resources.resourceMan == null)
        MGASystems.IMS.Accounting.Properties.Resources.resourceMan = new ResourceManager("MGASystems.IMS.Accounting.Properties.Resources", typeof (MGASystems.IMS.Accounting.Properties.Resources).Assembly);
      return MGASystems.IMS.Accounting.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.IMS.Accounting.Properties.Resources.resourceCulture;
    set => MGASystems.IMS.Accounting.Properties.Resources.resourceCulture = value;
  }
}
