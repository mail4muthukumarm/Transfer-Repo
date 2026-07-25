// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Extensions.Classes.NoNamespaceXmlWriter
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System.IO;
using System.Xml;

#nullable disable
namespace MGASystems.Common.Extensions.Classes;

public class NoNamespaceXmlWriter : XmlTextWriter
{
  public NoNamespaceXmlWriter(TextWriter output)
    : base(output)
  {
    this.Formatting = Formatting.Indented;
  }

  public override void WriteStartDocument()
  {
  }

  public override void WriteStartElement(string prefix, string localName, string ns)
  {
    base.WriteStartElement("", localName, "");
  }

  public override string LookupPrefix(string ns) => base.LookupPrefix(ns);
}
