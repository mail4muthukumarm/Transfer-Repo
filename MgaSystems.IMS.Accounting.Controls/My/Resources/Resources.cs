// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.My.Resources.Resources
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

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
namespace MGASystems.IMS.Accounting.Controls.My.Resources;

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
      if (object.ReferenceEquals((object) MGASystems.IMS.Accounting.Controls.My.Resources.Resources.resourceMan, (object) null))
        MGASystems.IMS.Accounting.Controls.My.Resources.Resources.resourceMan = new ResourceManager("MGASystems.IMS.Accounting.Controls.Resources", typeof (MGASystems.IMS.Accounting.Controls.My.Resources.Resources).Assembly);
      return MGASystems.IMS.Accounting.Controls.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.IMS.Accounting.Controls.My.Resources.Resources.resourceCulture;
    set => MGASystems.IMS.Accounting.Controls.My.Resources.Resources.resourceCulture = value;
  }

  internal static Bitmap delete
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MGASystems.IMS.Accounting.Controls.My.Resources.Resources.ResourceManager.GetObject(nameof (delete), MGASystems.IMS.Accounting.Controls.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Bitmap disk
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MGASystems.IMS.Accounting.Controls.My.Resources.Resources.ResourceManager.GetObject(nameof (disk), MGASystems.IMS.Accounting.Controls.My.Resources.Resources.resourceCulture));
    }
  }
}
