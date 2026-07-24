// Decompiled with JetBrains decompiler
// Type: CancellationNotices.My.Resources.Resources
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

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
namespace CancellationNotices.My.Resources;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
      if (object.ReferenceEquals((object) CancellationNotices.My.Resources.Resources.resourceMan, (object) null))
        CancellationNotices.My.Resources.Resources.resourceMan = new ResourceManager("CancellationNotices.Resources", typeof (CancellationNotices.My.Resources.Resources).Assembly);
      return CancellationNotices.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => CancellationNotices.My.Resources.Resources.resourceCulture;
    set => CancellationNotices.My.Resources.Resources.resourceCulture = value;
  }

  internal static Bitmap accept
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(CancellationNotices.My.Resources.Resources.ResourceManager.GetObject(nameof (accept), CancellationNotices.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Bitmap delete
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(CancellationNotices.My.Resources.Resources.ResourceManager.GetObject(nameof (delete), CancellationNotices.My.Resources.Resources.resourceCulture));
    }
  }

  internal static string ExceptionTextCouldNotFindTopLevelMenu
  {
    get
    {
      return CancellationNotices.My.Resources.Resources.ResourceManager.GetString(nameof (ExceptionTextCouldNotFindTopLevelMenu), CancellationNotices.My.Resources.Resources.resourceCulture);
    }
  }
}
