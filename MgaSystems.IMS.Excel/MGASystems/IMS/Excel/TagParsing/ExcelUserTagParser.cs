// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.TagParsing.ExcelUserTagParser
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Excel.Data.UserTagging;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Excel.TagParsing;

[Override(typeof (ExcelDynamicTagManager))]
[LogCategory("MGASystems.IMS.Excel.TagParsing", "MGASystems.IMS.Excel.TagParsing")]
public class ExcelUserTagParser : ExcelDynamicTagManager
{
  private const string ExcelUserTagParserLog = "MGASystems.IMS.Excel.TagParsing";

  public override void GetAvailableTagList(dsTemplateDocs.TagsDataTable dt)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("ExcelRating_SelectAllMappings");
    if (dataTable != null)
    {
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      {
        string tagName = ExcelUserTagParser.CreateTagName((string) row["Name"], (string) row["TagParserTagName"]);
        dt.AddTagsRow(tagName, "Value is derived from a cell in the excel rater", string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Excel Rating {0}", (object) (string) row["Name"]));
      }
    }
    Log.Write("ExcelUserTagParser.GetAvailableTagList Executing", "MGASystems.IMS.Excel.TagParsing");
    foreach (IGrouping<TagDataStore, UserTag> grouping in new UserTaggingManager(true).UserTags.GroupBy<UserTag, TagDataStore>((System.Func<UserTag, TagDataStore>) (ut => ut.Parent)))
    {
      string group = string.Format((IFormatProvider) CultureInfo.InvariantCulture, grouping.Key.RepeatableStore ? "Custom User Repeatable Data Store {0}" : "Custom User Tag Data Store {0}", (object) grouping.Key.Name);
      if (grouping.Key.RepeatableStore)
      {
        dt.AddTagsRow("TableStart:" + grouping.Key.Name, "Start tag for repeatable data.", group);
        dt.AddTagsRow("TableEnd:" + grouping.Key.Name, "End tag for repeatable data.", group);
      }
      foreach (UserTag userTag in (IEnumerable<UserTag>) grouping)
        dt.AddTagsRow(userTag.ResolvedTagName, userTag.Description ?? "User Defined Tag", group);
    }
    Log.Write("ExcelUserTagParser.GetAvailableTagList Executed", "MGASystems.IMS.Excel.TagParsing");
    base.GetAvailableTagList(dt);
  }

  public static string CreateTagName(string raterName, string tagParserTagName)
  {
    return string.Format((IFormatProvider) CultureInfo.InvariantCulture, "ER_{1}_{0}", (object) raterName.Replace(" ", "_"), (object) tagParserTagName);
  }

  private object ResolveExcelTagValue(
    Dictionary<string, DataTable> excelDataStores,
    string dataTableName,
    string fieldName,
    Guid quoteGuid,
    DocTag docTag)
  {
    DataTable dataTable;
    if (!excelDataStores.TryGetValue(dataTableName, out dataTable))
    {
      dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, $"select * from {dataTableName} where QuoteGuid = @quoteGuid", new object[2]
      {
        (object) "@quoteGuid",
        (object) quoteGuid
      });
      excelDataStores.Add(dataTableName, dataTable);
    }
    return dataTable != null && dataTable.Rows.Count == 1 ? dataTable.Rows[0][fieldName] : (object) null;
  }

  public override List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineId,
    Guid quoteGuid)
  {
    Log.Write("ExcelUserTagParser.ProcessTags Executing", "MGASystems.IMS.Excel.TagParsing");
    Dictionary<string, \u003C\u003Ef__AnonymousType4<string, string, string>> allExcelTags = DefaultDatabase.ExecuteDataTable("ExcelRating_SelectAllMappings").AsEnumerable().Select(row => new
    {
      TagName = ExcelUserTagParser.CreateTagName(row.Field<string>("Name"), row.Field<string>("TagParserTagName")),
      TagDbTableName = row.Field<string>("DatabaseTableName"),
      TagDbFieldName = row.Field<string>("DatabaseField")
    }).ToDictionary(excelTag => excelTag.TagName);
    Dictionary<string, DataTable> excelDataStores = new Dictionary<string, DataTable>();
    Dictionary<string, \u003C\u003Ef__AnonymousType5<string, object>> dictionary1 = tags.Where<DocTag>((System.Func<DocTag, bool>) (tag => allExcelTags.ContainsKey(tag.InnerTagName))).Select(tag => new
    {
      TagName = tag.InnerTagName,
      TagValue = this.ResolveExcelTagValue(excelDataStores, allExcelTags[tag.InnerTagName].TagDbTableName, allExcelTags[tag.InnerTagName].TagDbFieldName, quoteGuid, tag)
    }).Where(excelTag => !Utility.IsNull(excelTag.TagValue)).Distinct().ToDictionary(excelTag => excelTag.TagName);
    if (dictionary1.Any<KeyValuePair<string, \u003C\u003Ef__AnonymousType5<string, object>>>())
    {
      foreach (DocTag tag in tags)
      {
        var data;
        if (dictionary1.TryGetValue(tag.InnerTagName, out data))
          tag.TagValue = data.TagValue.ToString();
      }
    }
    Log.Write("ExcelUserTagParser.ProcessTags (Beginning Custom Tag Resolution)", "MGASystems.IMS.Excel.TagParsing");
    Dictionary<string, UserTag> dictionary2 = new UserTaggingManager(true).UserTags.ToDictionary<UserTag, string>((System.Func<UserTag, string>) (tr => tr.ResolvedTagName), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    DataSet dataSet = new DataSet();
    foreach (DocTag tag in tags)
    {
      if (dictionary2.ContainsKey(tag.InnerTagName))
      {
        UserTag userTag1 = dictionary2[tag.InnerTagName];
        if (!dataSet.Tables.Contains(userTag1.Parent.Name))
        {
          try
          {
            Log.Write("ExcelUserTagParser.ProcessTags Executing Datastore " + userTag1.Parent.Name, "MGASystems.IMS.Excel.TagParsing");
            List<object> objectList = new List<object>()
            {
              (object) quoteGuid
            };
            DataTable table1 = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, userTag1.Parent.StoredProcedure, (CommandArgumentType) 1, objectList.ToArray());
            table1.TableName = userTag1.Parent.Name;
            if (userTag1.Parent.RepeatableStore)
            {
              foreach (UserTag userTag2 in (Collection<UserTag>) userTag1.Parent.UserTags)
              {
                DataColumn column = table1.Columns[userTag2.Field];
                if (column != null)
                  column.ColumnName = userTag2.ResolvedTagName;
              }
            }
            dataSet.Merge(table1, false, MissingSchemaAction.Add);
            TagDataStore nestedParent = userTag1.Parent.NestedParent;
            if (nestedParent != null)
            {
              DataTable table2 = dataSet.Tables[nestedParent.Name];
              DataTable table3 = dataSet.Tables[table1.TableName];
              if (table3 != null)
              {
                if (table2 != null)
                {
                  foreach (DataColumn childColumn in table3.Columns.Cast<DataColumn>().Where<DataColumn>((System.Func<DataColumn, bool>) (t => t.ColumnName.StartsWith("_"))))
                  {
                    if (table2.Columns.Contains(childColumn.ColumnName))
                      dataSet.Relations.Add(new DataRelation($"{table2.TableName}To{table3.TableName}{childColumn.ColumnName}", table2.Columns[childColumn.ColumnName], childColumn, false));
                  }
                }
              }
            }
          }
          catch (SqlException ex)
          {
            ex.Data[(object) "MGA Datastore"] = (object) userTag1.Parent.Name;
            ex.Data[(object) "MGA Datastore.StoredProcedure"] = (object) userTag1.Parent.StoredProcedure;
            ErrorHandler.SilentHandleError((Exception) ex);
            DataTable table = new DataTable()
            {
              TableName = userTag1.Parent.Name
            };
            dataSet.Merge(table, false, MissingSchemaAction.Add);
            Log.Write("ExcelUserTagParser.ProcessTags Failure sqlException: " + ex.Message, "MGASystems.IMS.Excel.TagParsing");
            tag.TagValue = $"Datastore {userTag1.Parent.Name} failed to retrieve data";
            continue;
          }
          catch (InvalidOperationException ex)
          {
            ErrorHandler.SilentHandleError((Exception) ex);
            Log.Write("ExcelUserTagParser.ProcessTags Failure Exception: " + ex.Message, "MGASystems.IMS.Excel.TagParsing");
            tag.TagValue = "Error populating datastore " + userTag1.Parent.Name;
            continue;
          }
        }
        if (userTag1.Parent.RepeatableStore)
        {
          tag.TagDataset = dataSet;
          tag.TagValue = dataSet.Tables[userTag1.Parent.Name] == null || dataSet.Tables[userTag1.Parent.Name].Columns[userTag1.ResolvedTagName] != null ? $"Repeatable Tag {userTag1.ResolvedTagName} not valid outside of StartTable/EndTable region." : $"Repeatable Tag {userTag1.ResolvedTagName} Returned No Data for field {userTag1.Field}";
        }
        else
        {
          DataRow dataRow = dataSet.Tables[userTag1.Parent.Name].Rows.Cast<DataRow>().FirstOrDefault<DataRow>();
          if (dataRow == null)
            tag.TagValue = $"Custom Tag {userTag1.ResolvedTagName} Returned No Data from Procedure";
          else if (!dataRow.Table.Columns.Contains(userTag1.Field))
            tag.TagValue = $"Custom Tag {userTag1.ResolvedTagName} Returned No Data for field {userTag1.Field}";
          else if (!dataRow.IsNull(userTag1.Field))
          {
            string functionName = tag.FunctionName;
            if (functionName == "IMG" || functionName == "R270" || functionName == "R180" || functionName == "R90")
            {
              if (dataRow[userTag1.Field] is byte[] buffer && buffer.Length != 0)
                tag.TagImage = (Image) new Bitmap((Stream) new MemoryStream(buffer));
              else
                tag.TagValue = tag.FunctionName == "IMG" ? "" : dataRow[userTag1.Field].ToString();
            }
            else
              tag.TagValue = dataRow[userTag1.Field].ToString();
          }
        }
      }
    }
    Log.Write("ExcelUserTagParser.ProcessTags Executed", "MGASystems.IMS.Excel.TagParsing");
    return base.ProcessTags(tags, entityId, placedByCompanyLineId, quoteGuid);
  }
}
