// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.My.Resources.Resources
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating.My.Resources;

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
      if (object.ReferenceEquals((object) MGASystems.IMS.Policies.Rating.My.Resources.Resources.resourceMan, (object) null))
        MGASystems.IMS.Policies.Rating.My.Resources.Resources.resourceMan = new ResourceManager("MGASystems.IMS.Policies.Rating.Resources", typeof (MGASystems.IMS.Policies.Rating.My.Resources.Resources).Assembly);
      return MGASystems.IMS.Policies.Rating.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.IMS.Policies.Rating.My.Resources.Resources.resourceCulture;
    set => MGASystems.IMS.Policies.Rating.My.Resources.Resources.resourceCulture = value;
  }

  internal static Bitmap page_edit
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MGASystems.IMS.Policies.Rating.My.Resources.Resources.ResourceManager.GetObject(nameof (page_edit), MGASystems.IMS.Policies.Rating.My.Resources.Resources.resourceCulture));
    }
  }
}
