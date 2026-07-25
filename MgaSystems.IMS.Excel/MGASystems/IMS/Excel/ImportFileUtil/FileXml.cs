// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.FileXml
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System;
using System.Collections.Generic;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

internal class FileXml
{
  public List<TransactionData> LoadXMLData(XmlDocument xdoc, ConfigInfo ci)
  {
    XmlNodeList xmlNodeList = XmlHelper.retrieveXMLNodeList(xdoc, ci.NodesPolicy, ci.ErrorLogDirectory);
    List<TransactionData> transactionDataList = new List<TransactionData>();
    foreach (XmlNode xmlNode in xmlNodeList)
    {
      try
      {
        string innerText = xmlNode.SelectSingleNode(ci.NodeNamePolicyNumber).InnerText;
        Decimal result1;
        if (!Decimal.TryParse(this.formatAmount(xmlNode.SelectSingleNode(ci.NodeNameTransactionAmount).InnerText), out result1))
          throw new Exception($"Policy Number = '{innerText}'. Failed to Convert Transaction Amount = '{xmlNode.SelectSingleNode(ci.NodeNameTransactionAmount).InnerText}'.");
        DateTime result2 = new DateTime();
        if (!DateTime.TryParse(xmlNode.SelectSingleNode(ci.NodeNameEffectiveDate).InnerText, out result2))
          throw new Exception($"Policy Number = '{innerText}'. Failed to Convert Effective Date = '{xmlNode.SelectSingleNode(ci.NodeNameEffectiveDate).InnerText}'.");
        TransactionData transactionData = new TransactionData(innerText, result1, result2);
        transactionDataList.Add(transactionData);
      }
      catch (Exception ex)
      {
        string errorLogDirectory = ci.ErrorLogDirectory;
        int num = ci.AllDebugInfo ? 1 : 0;
        LogFile logFile = new LogFile(ex, "method RetrieveXMLDBData", errorLogDirectory, num != 0);
      }
    }
    return transactionDataList;
  }

  public string formatAmount(string s)
  {
    s = s.Replace("$", "");
    s = s.Replace(",", "");
    s = s.Replace(" ", "");
    return s;
  }
}
