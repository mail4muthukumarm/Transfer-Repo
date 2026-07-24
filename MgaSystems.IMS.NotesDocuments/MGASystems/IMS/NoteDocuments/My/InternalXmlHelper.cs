// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.My.InternalXmlHelper
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.My;

[Embedded]
[DebuggerNonUserCode]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class InternalXmlHelper
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  private InternalXmlHelper()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public static XAttribute CreateAttribute(XName name, object value)
  {
    return value != null ? new XAttribute(name, RuntimeHelpers.GetObjectValue(value)) : (XAttribute) null;
  }
}
