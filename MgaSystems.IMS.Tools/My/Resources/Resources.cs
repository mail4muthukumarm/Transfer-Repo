// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.My.Resources.Resources
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

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
namespace MGASystems.Tools.My.Resources;

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
      if (object.ReferenceEquals((object) MGASystems.Tools.My.Resources.Resources.resourceMan, (object) null))
        MGASystems.Tools.My.Resources.Resources.resourceMan = new ResourceManager("MGASystems.Tools.Resources", typeof (MGASystems.Tools.My.Resources.Resources).Assembly);
      return MGASystems.Tools.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MGASystems.Tools.My.Resources.Resources.resourceCulture;
    set => MGASystems.Tools.My.Resources.Resources.resourceCulture = value;
  }

  internal static string COMPANY
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (COMPANY), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string COMPANYGROUP
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (COMPANYGROUP), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string COMPANYLINE
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (COMPANYLINE), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string COMPANYLOCATION
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (COMPANYLOCATION), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string EXPENSEPAYEE
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (EXPENSEPAYEE), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string FINANCECOMPANY
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (FINANCECOMPANY), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static Bitmap flags16
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MGASystems.Tools.My.Resources.Resources.ResourceManager.GetObject(nameof (flags16), MGASystems.Tools.My.Resources.Resources.resourceCulture));
    }
  }

  internal static string INSPECTIONCOMPANY
  {
    get
    {
      return MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (INSPECTIONCOMPANY), MGASystems.Tools.My.Resources.Resources.resourceCulture);
    }
  }

  internal static string INSURED
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (INSURED), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string INTERMEDIARY
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (INTERMEDIARY), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static Bitmap money
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MGASystems.Tools.My.Resources.Resources.ResourceManager.GetObject(nameof (money), MGASystems.Tools.My.Resources.Resources.resourceCulture));
    }
  }

  internal static string PRODUCER
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (PRODUCER), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string PRODUCERLOCATION
  {
    get
    {
      return MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (PRODUCERLOCATION), MGASystems.Tools.My.Resources.Resources.resourceCulture);
    }
  }

  internal static string THIRDPARTYPAYEE
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (THIRDPARTYPAYEE), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string USER
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (USER), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }

  internal static string USERGROUP
  {
    get => MGASystems.Tools.My.Resources.Resources.ResourceManager.GetString(nameof (USERGROUP), MGASystems.Tools.My.Resources.Resources.resourceCulture);
  }
}
