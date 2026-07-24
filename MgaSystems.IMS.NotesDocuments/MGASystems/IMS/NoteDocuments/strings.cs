// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.strings
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class strings
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
  internal strings()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) strings.resourceMan, (object) null))
        strings.resourceMan = new ResourceManager("MGASystems.IMS.NoteDocuments.strings", typeof (strings).Assembly);
      return strings.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => strings.resourceCulture;
    set => strings.resourceCulture = value;
  }

  internal static string ASSOCIATED_ENTITY_PANEL_CONTROL_GUID_MISSING
  {
    get
    {
      return strings.ResourceManager.GetString(nameof (ASSOCIATED_ENTITY_PANEL_CONTROL_GUID_MISSING), strings.resourceCulture);
    }
  }

  internal static string ASSOCIATED_ENTITY_PANEL_CONTROL_GUID_MISSING_CAPTION
  {
    get
    {
      return strings.ResourceManager.GetString(nameof (ASSOCIATED_ENTITY_PANEL_CONTROL_GUID_MISSING_CAPTION), strings.resourceCulture);
    }
  }

  internal static string PREFERENCES_ATRRIBUTENOTDEFINEDERROR
  {
    get
    {
      return strings.ResourceManager.GetString(nameof (PREFERENCES_ATRRIBUTENOTDEFINEDERROR), strings.resourceCulture);
    }
  }

  internal static string PREFERENCES_REMOTEDBNOTFOUND
  {
    get
    {
      return strings.ResourceManager.GetString(nameof (PREFERENCES_REMOTEDBNOTFOUND), strings.resourceCulture);
    }
  }
}
