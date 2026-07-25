// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.My.InternalXmlHelper
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.My;

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
