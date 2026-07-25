// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.XmlHelper
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

internal class XmlHelper
{
  public static XmlNodeList retrieveXMLNodeList(
    XmlDocument doc,
    string xmlPath,
    string ErrorLogDirectory)
  {
    try
    {
      return doc.SelectNodes(xmlPath);
    }
    catch (Exception ex)
    {
      string errorLogPath = ErrorLogDirectory;
      LogFile logFile = new LogFile(ex, nameof (retrieveXMLNodeList), errorLogPath, false);
    }
    return (XmlNodeList) null;
  }

  public static XmlNode retrieveXMLNode(XmlDocument doc, string xmlPath, string ErrorLogDirectory)
  {
    try
    {
      return doc.SelectSingleNode(xmlPath);
    }
    catch (Exception ex)
    {
      string errorLogPath = ErrorLogDirectory;
      LogFile logFile = new LogFile(ex, nameof (retrieveXMLNode), errorLogPath, false);
    }
    return (XmlNode) null;
  }

  public static string retrieveXMLNodeInnerText(
    XmlDocument doc,
    string xmlPath,
    string ErrorLogDirectory)
  {
    try
    {
      return doc.SelectSingleNode(xmlPath).InnerText;
    }
    catch (Exception ex)
    {
      string errorLogPath = ErrorLogDirectory;
      LogFile logFile = new LogFile(ex, "retrieveXMLNode", errorLogPath, false);
    }
    return (string) null;
  }

  public static string RetrieveXMLDBData(XmlDocument doc, string xmlPath, string ErrorLogDirectory)
  {
    string str = "";
    try
    {
      if (doc.SelectSingleNode(xmlPath) == null)
        throw new Exception("Warning Node Not found. Path " + xmlPath);
      str = doc.SelectSingleNode(xmlPath).InnerText;
    }
    catch (Exception ex)
    {
      string errorLogPath = ErrorLogDirectory;
      LogFile logFile = new LogFile(ex, nameof (RetrieveXMLDBData), errorLogPath, false);
    }
    return str;
  }
}
