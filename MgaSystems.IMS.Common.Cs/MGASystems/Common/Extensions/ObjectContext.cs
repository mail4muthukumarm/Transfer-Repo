// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Extensions.ObjectContext
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.Extensions.Classes;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common.Extensions;

public static class ObjectContext
{
  private static XmlSerializerNamespaces EmptyNamespace = new XmlSerializerNamespaces(new XmlQualifiedName[1]
  {
    new XmlQualifiedName("", "")
  });

  public static string SerializeToXml(
    this object obj,
    XmlAttributeOverrides overrides = null,
    Type[] additionalTypes = null,
    string rootName = null,
    bool omitXmlDeclaration = true,
    string defaultNamespace = "")
  {
    switch (obj)
    {
      case DataTable _:
        StringWriter writer = new StringWriter();
        (obj as DataTable).WriteXml((TextWriter) writer);
        return writer.ToString();
      case DataSet _:
        return (obj as DataSet).GetXml();
      default:
        StringBuilder stringBuilder = new StringBuilder();
        try
        {
          XmlRootAttribute root = (XmlRootAttribute) null;
          if (!string.IsNullOrEmpty(rootName))
            root = new XmlRootAttribute(rootName);
          XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType(), overrides, additionalTypes, root, defaultNamespace);
          StringBuilder output = stringBuilder;
          using (XmlWriter xmlWriter = XmlWriter.Create(output, new XmlWriterSettings()
          {
            OmitXmlDeclaration = omitXmlDeclaration,
            Indent = true
          }))
          {
            xmlSerializer.Serialize(xmlWriter, obj);
            return stringBuilder.ToString();
          }
        }
        catch (Exception ex)
        {
          return ex.ToString();
        }
    }
  }

  public static string SerializeToLocalXml(
    this object obj,
    XmlAttributeOverrides overrides = null,
    Type[] additionalTypes = null,
    string rootName = null,
    bool omitXmlDeclaration = true)
  {
    switch (obj)
    {
      case DataTable _:
      case DataSet _:
        return obj.SerializeToXml();
      default:
        StringBuilder sb = new StringBuilder();
        try
        {
          XmlRootAttribute root = (XmlRootAttribute) null;
          if (!string.IsNullOrEmpty(rootName))
            root = new XmlRootAttribute(rootName);
          XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType(), overrides, additionalTypes, root, "");
          using (NoNamespaceXmlWriter namespaceXmlWriter = new NoNamespaceXmlWriter((TextWriter) new StringWriter(sb)))
          {
            NoNamespaceXmlWriter output = namespaceXmlWriter;
            using (XmlWriter xmlWriter = XmlWriter.Create((XmlWriter) output, new XmlWriterSettings()
            {
              OmitXmlDeclaration = omitXmlDeclaration,
              Indent = true
            }))
            {
              xmlSerializer.Serialize(xmlWriter, obj, ObjectContext.EmptyNamespace);
              return sb.ToString();
            }
          }
        }
        catch (Exception ex)
        {
          return ex.ToString();
        }
    }
  }

  public static XDocument SerializeToXNode<T>(this T toConvert, Type[] additionalTypes = null)
  {
    XDocument xnode = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), Array.Empty<object>());
    using (XmlWriter writer = xnode.CreateWriter())
      new XmlSerializer(typeof (T), additionalTypes).Serialize(writer, (object) toConvert);
    return xnode;
  }
}
