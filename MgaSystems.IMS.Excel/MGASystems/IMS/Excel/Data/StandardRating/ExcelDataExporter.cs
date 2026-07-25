// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.StandardRating.ExcelDataExporter
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data;
using MGASystems.IMS.Excel.TagParsing;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Excel.Data.StandardRating;

public class ExcelDataExporter
{
  public static string GetExcelTableName(Guid quoteGuid)
  {
    return DefaultDatabase.ExecuteScalar(CommandType.Text, "select  ter.DatabaseTableName    from        tblQuoteDetails tqd    inner join        tblExcelRating_Raters ter    on        ter.RatingTypeId = tqd.RaterID    where        tqd.quoteGuid = @quoteGuid", new object[2]
    {
      (object) "@quoteGuid",
      (object) quoteGuid
    }) as string;
  }

  public virtual DataSet GetRatingData(Guid quoteGuid)
  {
    string excelTableName = ExcelDataExporter.GetExcelTableName(quoteGuid);
    if (excelTableName == null)
      return (DataSet) null;
    DataTable dataTable1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, $"select * from {excelTableName} where QuoteGuid = @QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid
    });
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select      distinct  \t\ter.Name, \t\term.DatabaseField, \t\term.TagParserTagName, \t\term.DatabaseFieldType    from          tblExcelRating_Raters er     inner join         tblFactorSets fs     on          er.RatingTypeId = fs.RaterID     inner join         tblExcelRating_Mappings erm     on         erm.ExcelFactorSetId = fs.FactorSetGUID  \tinner join \t\ttblQuoteDetails tqd \ton \t\ttqd.FactorSetGUID = fs.FactorSetGUID  \twhere \t\ttqd.QuoteGuid = @QuoteGuid \torder by \t\term.TagParserTagName", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid
    });
    DataSet ratingData = new DataSet("Export Data");
    DataTable dataTable3 = ratingData.Tables.Add(excelTableName);
    dataTable3.Columns.Add("Database Field", typeof (string));
    dataTable3.Columns.Add("Tag Name", typeof (string));
    dataTable3.Columns.Add("Type", typeof (string));
    dataTable3.Columns.Add("Data", typeof (object));
    foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
    {
      string columnName = row.Field<string>("DatabaseField");
      object obj = (object) null;
      if (dataTable1.Rows.Count > 0)
        obj = dataTable1.Rows[0].Field<object>(columnName);
      dataTable3.Rows.Add((object) columnName, (object) ExcelUserTagParser.CreateTagName(row.Field<string>("Name"), row.Field<string>("TagParserTagName")), (object) row.Field<string>("DatabaseFieldType").Replace("System.", ""), obj);
    }
    return ratingData;
  }
}
