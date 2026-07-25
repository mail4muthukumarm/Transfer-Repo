// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Properties.Resources
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
      if (MgaSystems.Ims.Fortegra.Properties.Resources.resourceMan == null)
        MgaSystems.Ims.Fortegra.Properties.Resources.resourceMan = new ResourceManager("MgaSystems.Ims.Fortegra.Properties.Resources", typeof (MgaSystems.Ims.Fortegra.Properties.Resources).Assembly);
      return MgaSystems.Ims.Fortegra.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture;
    set => MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture = value;
  }

  internal static Bitmap arrow_in
  {
    get
    {
      return (Bitmap) MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetObject(nameof (arrow_in), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap delete
  {
    get => (Bitmap) MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetObject(nameof (delete), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
  }

  internal static Bitmap disk
  {
    get => (Bitmap) MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetObject(nameof (disk), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
  }

  internal static string ERROR_REQUIREDFIELD_HEADER
  {
    get
    {
      return MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetString(nameof (ERROR_REQUIREDFIELD_HEADER), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap folder_edit
  {
    get
    {
      return (Bitmap) MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetObject(nameof (folder_edit), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap house_link
  {
    get
    {
      return (Bitmap) MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetObject(nameof (house_link), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
    }
  }

  internal static string RESERVEPAYMENT_RESERVEREQUIRED
  {
    get
    {
      return MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetString(nameof (RESERVEPAYMENT_RESERVEREQUIRED), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap tab_edit
  {
    get
    {
      return (Bitmap) MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetObject(nameof (tab_edit), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap note_edit
  {
    get
    {
      return (Bitmap) MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetObject(nameof (note_edit), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
    }
  }

  internal static string INVALID_RESERVEPAYMENT_EXCEPTION1
  {
    get
    {
      return MgaSystems.Ims.Fortegra.Properties.Resources.ResourceManager.GetString(nameof (INVALID_RESERVEPAYMENT_EXCEPTION1), MgaSystems.Ims.Fortegra.Properties.Resources.resourceCulture);
    }
  }
}
