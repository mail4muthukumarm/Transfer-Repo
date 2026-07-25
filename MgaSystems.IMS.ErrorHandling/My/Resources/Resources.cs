// Decompiled with JetBrains decompiler
// Type: MGASystems.ErrorHandling.My.Resources.Resources
// Assembly: MgaSystems.IMS.ErrorHandling, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4686CAD5-B68D-4F03-A647-C480B9E54EB4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.ErrorHandling.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.ErrorHandling.My.Resources;

[CompilerGenerated]
[HideModuleName]
[StandardModule]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) MGASystems.ErrorHandling.My.Resources.Resources.resourceMan, (object) null))
        MGASystems.ErrorHandling.My.Resources.Resources.resourceMan = new ResourceManager("MGASystems.ErrorHandling.Resources", typeof (MGASystems.ErrorHandling.My.Resources.Resources).Assembly);
      return MGASystems.ErrorHandling.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.ErrorHandling.My.Resources.Resources.resourceCulture;
    set => MGASystems.ErrorHandling.My.Resources.Resources.resourceCulture = value;
  }
}
