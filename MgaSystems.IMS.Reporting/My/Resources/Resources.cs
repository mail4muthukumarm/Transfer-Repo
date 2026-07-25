// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.My.Resources.Resources
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting.My.Resources;

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
      if (object.ReferenceEquals((object) MGASystems.IMS.Reporting.My.Resources.Resources.resourceMan, (object) null))
        MGASystems.IMS.Reporting.My.Resources.Resources.resourceMan = new ResourceManager("MGASystems.IMS.Reporting.Resources", typeof (MGASystems.IMS.Reporting.My.Resources.Resources).Assembly);
      return MGASystems.IMS.Reporting.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.IMS.Reporting.My.Resources.Resources.resourceCulture;
    set => MGASystems.IMS.Reporting.My.Resources.Resources.resourceCulture = value;
  }

  internal static string OFFLINEREPORT_PRODUCERLOCATIONEMAIL
  {
    get
    {
      return MGASystems.IMS.Reporting.My.Resources.Resources.ResourceManager.GetString(nameof (OFFLINEREPORT_PRODUCERLOCATIONEMAIL), MGASystems.IMS.Reporting.My.Resources.Resources.resourceCulture);
    }
  }

  internal static string OFFLINEREPORT_PRODUCERLOCATIONEMAIL_Parameter
  {
    get
    {
      return MGASystems.IMS.Reporting.My.Resources.Resources.ResourceManager.GetString(nameof (OFFLINEREPORT_PRODUCERLOCATIONEMAIL_Parameter), MGASystems.IMS.Reporting.My.Resources.Resources.resourceCulture);
    }
  }
}
