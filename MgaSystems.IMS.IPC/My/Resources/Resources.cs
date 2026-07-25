// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
namespace MGASystems.IMS.InsuredsProducersCompanies.My.Resources;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
      if (object.ReferenceEquals((object) MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.resourceMan, (object) null))
        MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.resourceMan = new ResourceManager("MGASystems.IMS.InsuredsProducersCompanies.Resources", typeof (MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources).Assembly);
      return MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.resourceCulture;
    set => MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.resourceCulture = value;
  }

  internal static Bitmap application_cascade
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.ResourceManager.GetObject(nameof (application_cascade), MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Bitmap database_go
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.ResourceManager.GetObject(nameof (database_go), MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.resourceCulture));
    }
  }
}
