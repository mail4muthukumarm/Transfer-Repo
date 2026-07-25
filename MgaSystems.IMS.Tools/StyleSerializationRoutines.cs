// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.StyleSerializationRoutines
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Tools;

[StandardModule]
public sealed class StyleSerializationRoutines
{
  [DebuggerStepThrough]
  public static string SerializeObject(object Obj, Type T, XmlAttributeOverrides AttOverrides = null)
  {
    XmlSerializer xmlSerializer = !Information.IsNothing((object) AttOverrides) ? new XmlSerializer(T, AttOverrides) : new XmlSerializer(T);
    MemoryStream output = new MemoryStream();
    xmlSerializer.Serialize(XmlWriter.Create((Stream) output), RuntimeHelpers.GetObjectValue(Obj));
    output.Flush();
    output.Seek(0L, SeekOrigin.Begin);
    return Encoding.UTF8.GetString(output.ToArray()).Trim();
  }

  [DebuggerStepThrough]
  public static object DeserializeObject(string Obj, Type T, XmlAttributeOverrides AttOverrides = null)
  {
    return (!Information.IsNothing((object) AttOverrides) ? new XmlSerializer(T, AttOverrides) : new XmlSerializer(T)).Deserialize((Stream) new MemoryStream(Encoding.UTF8.GetBytes(Obj)));
  }

  public static string SerializeStyleInXML(StyleInXML CellStyle)
  {
    return Regex.Replace(StyleSerializationRoutines.SerializeObject((object) CellStyle, typeof (StyleInXML)), "[^\\u0000-\\u007F]+", string.Empty);
  }

  public static string SerializeStyle(Style CellStyle)
  {
    return Regex.Replace(StyleSerializationRoutines.SerializeObject((object) new StyleInXML(CellStyle), typeof (StyleInXML)), "[^\\u0000-\\u007F]+", string.Empty);
  }

  public static string SerializeSheetInXML(SheetInXML sheet)
  {
    return Regex.Replace(StyleSerializationRoutines.SerializeObject((object) sheet, typeof (SheetInXML)), "[^\\u0000-\\u007F]+", string.Empty);
  }

  public static string SerializeSheet(Worksheet sheet)
  {
    return Regex.Replace(StyleSerializationRoutines.SerializeObject((object) new SheetInXML(sheet), typeof (SheetInXML)), "[^\\u0000-\\u007F]+", string.Empty);
  }

  public static StyleInXML DeSerializeStyleInXML(string XMLString)
  {
    return (StyleInXML) RuntimeHelpers.GetObjectValue(StyleSerializationRoutines.DeserializeObject(XMLString, typeof (StyleInXML)));
  }

  public static SheetInXML DeserializeSheetInXML(string XMLString)
  {
    return (SheetInXML) RuntimeHelpers.GetObjectValue(StyleSerializationRoutines.DeserializeObject(XMLString, typeof (SheetInXML)));
  }
}
