// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Extensions.XmlExtensions
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Linq;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.Extensions;

public static class XmlExtensions
{
  public static T RemoveEmptyNodes<T>(this T element) where T : XContainer
  {
    foreach (XNode xnode in element.Descendants().Where<XElement>((Func<XElement, bool>) (t => string.IsNullOrEmpty(t?.Value))).ToList<XElement>())
      xnode.Remove();
    return element;
  }
}
