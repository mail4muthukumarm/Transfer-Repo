// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Shared.Strings
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Shared;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class Strings
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  internal Strings()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public static ResourceManager ResourceManager
  {
    get
    {
      if (Strings.resourceMan == null)
        Strings.resourceMan = new ResourceManager("MGASystems.IMS.Accounting.Shared.Strings", typeof (Strings).Assembly);
      return Strings.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public static CultureInfo Culture
  {
    get => Strings.resourceCulture;
    set => Strings.resourceCulture = value;
  }

  public static string ALLOCATIONEXCEEDSEXPENSEEXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ALLOCATIONEXCEEDSEXPENSEEXCEPTION), Strings.resourceCulture);
    }
  }

  public static string COSTCENTER_ALLOCATION_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (COSTCENTER_ALLOCATION_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }
}
