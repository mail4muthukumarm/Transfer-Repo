// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Risk_Meter.RiskMeter
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Data;
using System.IO;

#nullable disable
namespace MGASystems.IMS.Underwriting.Risk_Meter;

internal class RiskMeter
{
  public static DataSet ConvertToDataSet(string xmlString)
  {
    if (string.IsNullOrEmpty(xmlString))
      return (DataSet) null;
    DataSet dataSet = (DataSet) null;
    try
    {
      using (StringReader reader = new StringReader(xmlString))
      {
        dataSet = new DataSet();
        int num = (int) dataSet.ReadXml((TextReader) reader);
      }
    }
    catch (Exception ex)
    {
      dataSet = (DataSet) null;
      string message = ex.Message;
    }
    return dataSet;
  }

  public static void LogRiskMeter(string action, Guid quoteGuid, string url)
  {
    DefaultDatabase.ExecuteNonQuery("spLogRiskMeter", new object[8]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@Action",
      (object) action,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@URL",
      (object) url
    });
  }
}
