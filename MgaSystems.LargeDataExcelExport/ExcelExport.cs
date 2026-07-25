// Decompiled with JetBrains decompiler
// Type: MgaSystems.LargeDataExcelExport.ExcelExport
// Assembly: MgaSystems.LargeDataExcelExport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4F6E514B-28D1-48BF-8E06-BB678B09C1E7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.LargeDataExcelExport.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Xml;

#nullable disable
namespace MgaSystems.LargeDataExcelExport;

public class ExcelExport : IDisposable
{
  private LargeDataExcelExportOptions _exportOptions;
  private DataSet _schemaDs;
  private string _zipArchivePath;
  private string _tempFilename;
  private int _xmlRowsWritten;
  private LargeDataExcelExportProgress _localProgress;
  private bool _disposed;

  public ExcelExport()
  {
    this._exportOptions = new LargeDataExcelExportOptions();
    this._exportOptions.TablesWanted = new List<int>();
    this._exportOptions.TableNames = new List<string>();
    this._localProgress = new LargeDataExcelExportProgress();
  }

  public ExcelExport(LargeDataExcelExportOptions exportOptions)
  {
    this._exportOptions = new LargeDataExcelExportOptions()
    {
      TableNames = exportOptions.TableNames == null ? new List<string>() : exportOptions.TableNames,
      TablesWanted = exportOptions.TablesWanted == null ? new List<int>() : exportOptions.TablesWanted
    };
    this._localProgress = new LargeDataExcelExportProgress();
  }

  [Obsolete("Use DbCommand version instead.")]
  public int RetrieveData(SqlCommand command, string tempFileFolderPath)
  {
    return this.RetrieveData((DbCommand) command, tempFileFolderPath);
  }

  public int RetrieveData(DbCommand command, string tempFileFolderPath)
  {
    this._tempFilename = Guid.NewGuid().ToString() + "_DataSet";
    this._zipArchivePath = $"{tempFileFolderPath}{this._tempFilename}.zip";
    List<object> objectList = new List<object>();
    foreach (SqlParameter parameter in command.Parameters)
    {
      objectList.Add((object) parameter.ParameterName);
      objectList.Add(parameter.Value);
    }
    if (command.Connection != null && !string.IsNullOrEmpty(command.Connection.ConnectionString))
      new Database(command.Connection.ConnectionString, "System.Data.SqlClient").ExecuteReader(new object(), new EventHandler<ExecuteReaderArgs>(this.WriteTempXML), command.CommandType, command.CommandText, command.CommandTimeout, (CommandArgumentType) 0, objectList.ToArray());
    else
      DefaultDatabase.ExecuteReader(new object(), new EventHandler<ExecuteReaderArgs>(this.WriteTempXML), command.CommandType, command.CommandText, command.CommandTimeout, (CommandArgumentType) 0, objectList.ToArray());
    return this._xmlRowsWritten;
  }

  public async Task<int> RetrieveDataAsync(
    SqlCommand command,
    string tempFileFolderPath,
    IProgress<LargeDataExcelExportProgress> progress)
  {
    this._tempFilename = Guid.NewGuid().ToString() + "_DataSet";
    this._zipArchivePath = $"{tempFileFolderPath}{this._tempFilename}.zip";
    List<object> sqlParams = new List<object>();
    foreach (SqlParameter parameter in (DbParameterCollection) command.Parameters)
    {
      sqlParams.Add((object) parameter.ParameterName);
      sqlParams.Add(parameter.Value);
    }
    this._localProgress.ProgressMessage = "Retrieving data";
    this._localProgress.ProgressPercentChange = 0;
    progress.Report(new LargeDataExcelExportProgress()
    {
      ProgressMessage = this._localProgress.ProgressMessage,
      ProgressPercentChange = this._localProgress.ProgressPercentChange
    });
    LargeDataExcelExportProgress excelExportProgress = (LargeDataExcelExportProgress) null;
    await Task.Run((Action) (() =>
    {
      if (command.Connection != null && !string.IsNullOrEmpty(command.Connection.ConnectionString))
        new Database(command.Connection.ConnectionString, "System.Data.SqlClient").ExecuteReader(new object(), new EventHandler<ExecuteReaderArgs>(this.WriteTempXML), command.CommandType, command.CommandText, command.CommandTimeout, (CommandArgumentType) 0, sqlParams.ToArray());
      else
        DefaultDatabase.ExecuteReader(new object(), new EventHandler<ExecuteReaderArgs>(this.WriteTempXML), command.CommandType, command.CommandText, command.CommandTimeout, (CommandArgumentType) 0, sqlParams.ToArray());
    }));
    this._localProgress.ProgressMessage = "Data retrieval complete";
    this._localProgress.ProgressPercentChange = 0;
    progress.Report(new LargeDataExcelExportProgress()
    {
      ProgressMessage = this._localProgress.ProgressMessage,
      ProgressPercentChange = this._localProgress.ProgressPercentChange
    });
    excelExportProgress = (LargeDataExcelExportProgress) null;
    return this._xmlRowsWritten;
  }

  private void WriteTempXML(object e, ExecuteReaderArgs arg)
  {
    XmlWriterSettings settings = new XmlWriterSettings();
    settings.Indent = true;
    settings.NewLineChars = Environment.NewLine;
    using (FileStream fileStream = new FileStream(this._zipArchivePath, FileMode.Create))
    {
      using (ZipArchive zipArchive = new ZipArchive((Stream) fileStream, ZipArchiveMode.Create))
      {
        using (XmlWriter xmlWriter1 = XmlWriter.Create(zipArchive.CreateEntry(this._tempFilename + ".xml").Open(), settings))
        {
          this._schemaDs = new DataSet();
          int num1 = 0;
          int num2 = 0;
          if (true)
          {
            xmlWriter1.WriteStartDocument();
            xmlWriter1.WriteStartElement("NewDataSet");
          }
          do
          {
            ++num1;
            if (this._exportOptions.TablesWanted.Contains(num1 - 1) || this._exportOptions.TablesWanted.Count == 0)
            {
              ++num2;
              if (!this._disposed)
              {
                this._schemaDs.Tables.Add();
                bool flag = false;
                int i1 = 0;
                while (true)
                {
                  if (i1 < arg.Reader.FieldCount)
                  {
                    if (!this._disposed)
                    {
                      if (!this._schemaDs.Tables[num2 - 1].Columns.Contains(arg.Reader.GetName(i1)))
                        this._schemaDs.Tables[num2 - 1].Columns.Add(arg.Reader.GetName(i1));
                      ++i1;
                    }
                    else
                      goto label_30;
                  }
                  else
                    break;
                }
                while (arg.Reader.Read())
                {
                  xmlWriter1.WriteStartElement("Table" + num2.ToString());
                  flag = true;
                  for (int i2 = 0; i2 < arg.Reader.FieldCount; ++i2)
                  {
                    string str = arg.Reader.GetName(i2);
                    if (string.IsNullOrEmpty(str))
                      str = "Column" + i2.ToString();
                    string localName = str.Replace(" ", "_x0020_").Replace("/", "_x002F_").Replace("(", "_x0028_").Replace(")", "_x0029_").Replace("&", "_x0026_").Replace("'", "_x2019_").Replace("’", "_x2019_").Replace("#", "_x0023_").Replace("%", "_x0025_");
                    string name = arg.Reader.GetFieldType(i2).Name;
                    if (name != null)
                    {
                      int num3 = name.Length;
                      switch (num3)
                      {
                        case 4:
                          switch (name[0])
                          {
                            case 'B':
                              if (name == "Byte")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter1.WriteStartElement(localName);
                                  xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter1.WriteString(string.Empty);
                                  xmlWriter1.WriteEndElement();
                                  continue;
                                }
                                xmlWriter1.WriteStartElement(localName);
                                xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter1.WriteString(arg.Reader.GetByte(i2).ToString());
                                xmlWriter1.WriteEndElement();
                                continue;
                              }
                              goto label_58;
                            case 'G':
                              if (name == "Guid")
                                break;
                              goto label_58;
                            default:
                              goto label_58;
                          }
                          break;
                        case 5:
                          switch (name[3])
                          {
                            case '1':
                              if (name == "Int16")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter1.WriteStartElement(localName);
                                  xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter1.WriteEndElement();
                                  continue;
                                }
                                xmlWriter1.WriteStartElement(localName);
                                xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter1.WriteString(arg.Reader.GetInt16(i2).ToString());
                                xmlWriter1.WriteEndElement();
                                continue;
                              }
                              goto label_58;
                            case '3':
                              if (name == "Int32")
                                goto label_49;
                              goto label_58;
                            default:
                              goto label_58;
                          }
                        case 6:
                          switch (name[0])
                          {
                            case 'D':
                              if (name == "Double")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter1.WriteStartElement(localName);
                                  xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter1.WriteEndElement();
                                  continue;
                                }
                                xmlWriter1.WriteStartElement(localName);
                                xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter1.WriteString(arg.Reader.GetDouble(i2).ToString());
                                xmlWriter1.WriteEndElement();
                                continue;
                              }
                              goto label_58;
                            case 'S':
                              if (name == "String")
                                break;
                              goto label_58;
                            default:
                              goto label_58;
                          }
                          break;
                        case 7:
                          switch (name[0])
                          {
                            case 'B':
                              if (name == "Boolean")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter1.WriteStartElement(localName);
                                  xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter1.WriteString(string.Empty);
                                  xmlWriter1.WriteEndElement();
                                  continue;
                                }
                                xmlWriter1.WriteStartElement(localName);
                                xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter1.WriteString(arg.Reader.GetBoolean(i2) ? "1" : "0");
                                xmlWriter1.WriteEndElement();
                                continue;
                              }
                              goto label_58;
                            case 'D':
                              if (name == "Decimal")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter1.WriteStartElement(localName);
                                  xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter1.WriteEndElement();
                                  continue;
                                }
                                xmlWriter1.WriteStartElement(localName);
                                xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter1.WriteString(arg.Reader.GetDecimal(i2).ToString());
                                xmlWriter1.WriteEndElement();
                                continue;
                              }
                              goto label_58;
                            case 'I':
                              if (name == "Integer")
                                goto label_49;
                              goto label_58;
                            default:
                              goto label_58;
                          }
                        case 8:
                          if (name == "DateTime")
                          {
                            if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                            {
                              xmlWriter1.WriteStartElement(localName);
                              xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                              xmlWriter1.WriteEndElement();
                              continue;
                            }
                            xmlWriter1.WriteStartElement(localName);
                            xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                            xmlWriter1.WriteString(arg.Reader.GetDateTime(i2).ToShortDateString());
                            xmlWriter1.WriteEndElement();
                            continue;
                          }
                          goto label_58;
                        default:
                          goto label_58;
                      }
                      if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                      {
                        xmlWriter1.WriteStartElement(localName);
                        xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                        xmlWriter1.WriteString(string.Empty);
                        xmlWriter1.WriteEndElement();
                        continue;
                      }
                      xmlWriter1.WriteStartElement(localName);
                      xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                      xmlWriter1.WriteString(arg.Reader.GetValue(i2).ToString());
                      xmlWriter1.WriteEndElement();
                      continue;
label_49:
                      if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                      {
                        xmlWriter1.WriteStartElement(localName);
                        xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                        xmlWriter1.WriteEndElement();
                        continue;
                      }
                      xmlWriter1.WriteStartElement(localName);
                      xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                      XmlWriter xmlWriter2 = xmlWriter1;
                      num3 = arg.Reader.GetInt32(i2);
                      string text = num3.ToString();
                      xmlWriter2.WriteString(text);
                      xmlWriter1.WriteEndElement();
                      continue;
                    }
label_58:
                    if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                    {
                      xmlWriter1.WriteStartElement(localName);
                      xmlWriter1.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                      xmlWriter1.WriteEndElement();
                    }
                    else
                    {
                      xmlWriter1.WriteStartElement(localName);
                      xmlWriter1.WriteAttributeString("DataType", "System.String");
                      xmlWriter1.WriteString(arg.Reader.GetValue(i2).ToString());
                      xmlWriter1.WriteEndElement();
                    }
                  }
                  xmlWriter1.WriteEndElement();
                  ++this._xmlRowsWritten;
                }
                if (!flag)
                {
                  xmlWriter1.WriteStartElement("Table" + num2.ToString());
                  for (int i3 = 0; i3 < arg.Reader.FieldCount; ++i3)
                  {
                    string str = arg.Reader.GetName(i3);
                    if (string.IsNullOrEmpty(str))
                      str = "Column" + i3.ToString();
                    string localName = str.Replace(" ", "_x0020_").Replace("/", "_x002F_").Replace("(", "_x0028_").Replace(")", "_x0029_").Replace("&", "_x0026_").Replace("'", "_x2019_").Replace("’", "_x2019_");
                    xmlWriter1.WriteStartElement(localName);
                    xmlWriter1.WriteAttributeString("DataType", "System.String");
                    xmlWriter1.WriteString(string.Empty);
                    xmlWriter1.WriteEndElement();
                  }
                  xmlWriter1.WriteEndElement();
                }
              }
              else
                goto label_32;
            }
          }
          while (arg.Reader.NextResult());
          goto label_73;
label_32:
          return;
label_30:
          return;
label_73:
          xmlWriter1.WriteEndElement();
        }
      }
    }
  }

  private void WriteTempXMLAsync(object e, ExecuteReaderArgs arg)
  {
    this._localProgress.ProgressMessage = "Writing retrieved data to file";
    LargeDataExcelExportProgress excelExportProgress1 = new LargeDataExcelExportProgress();
    excelExportProgress1.ProgressMessage = this._localProgress.ProgressMessage;
    excelExportProgress1.ProgressPercentChange = 33;
    if (arg.Context is IProgress<LargeDataExcelExportProgress> context1)
      context1.Report(excelExportProgress1);
    LargeDataExcelExportProgress excelExportProgress2 = (LargeDataExcelExportProgress) null;
    XmlWriterSettings settings = new XmlWriterSettings();
    settings.Indent = true;
    settings.NewLineChars = Environment.NewLine;
    using (FileStream fileStream = new FileStream(this._zipArchivePath, FileMode.Create))
    {
      using (ZipArchive zipArchive = new ZipArchive((Stream) fileStream, ZipArchiveMode.Create))
      {
        using (XmlWriter xmlWriter = XmlWriter.Create(zipArchive.CreateEntry(this._tempFilename + ".xml").Open(), settings))
        {
          this._schemaDs = new DataSet();
          int num1 = 0;
          int num2 = 0;
          if (true)
          {
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("NewDataSet");
          }
          do
          {
            ++num1;
            if (this._exportOptions.TablesWanted.Contains(num1 - 1) || this._exportOptions.TablesWanted.Count == 0)
            {
              ++num2;
              if (!this._disposed)
              {
                this._schemaDs.Tables.Add();
                bool flag = false;
                int i1 = 0;
                while (true)
                {
                  if (i1 < arg.Reader.FieldCount)
                  {
                    if (!this._disposed)
                    {
                      if (!this._schemaDs.Tables[num2 - 1].Columns.Contains(arg.Reader.GetName(i1)))
                        this._schemaDs.Tables[num2 - 1].Columns.Add(arg.Reader.GetName(i1));
                      ++i1;
                    }
                    else
                      goto label_32;
                  }
                  else
                    break;
                }
                while (arg.Reader.Read())
                {
                  xmlWriter.WriteStartElement("Table" + num2.ToString());
                  flag = true;
                  for (int i2 = 0; i2 < arg.Reader.FieldCount; ++i2)
                  {
                    string str = arg.Reader.GetName(i2);
                    if (string.IsNullOrEmpty(str))
                      str = "Column" + i2.ToString();
                    string localName = str.Replace(" ", "_x0020_").Replace("/", "_x002F_").Replace("(", "_x0028_").Replace(")", "_x0029_").Replace("&", "_x0026_").Replace("'", "_x2019_").Replace("’", "_x2019_");
                    string name = arg.Reader.GetFieldType(i2).Name;
                    if (name != null)
                    {
                      switch (name.Length)
                      {
                        case 4:
                          switch (name[0])
                          {
                            case 'B':
                              if (name == "Byte")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter.WriteStartElement(localName);
                                  xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter.WriteEndElement();
                                  continue;
                                }
                                xmlWriter.WriteStartElement(localName);
                                xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter.WriteString(arg.Reader.GetByte(i2).ToString());
                                xmlWriter.WriteEndElement();
                                continue;
                              }
                              goto label_60;
                            case 'G':
                              if (name == "Guid")
                                break;
                              goto label_60;
                            default:
                              goto label_60;
                          }
                          break;
                        case 5:
                          switch (name[3])
                          {
                            case '1':
                              if (name == "Int16")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter.WriteStartElement(localName);
                                  xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter.WriteEndElement();
                                  continue;
                                }
                                xmlWriter.WriteStartElement(localName);
                                xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter.WriteString(arg.Reader.GetInt16(i2).ToString());
                                xmlWriter.WriteEndElement();
                                continue;
                              }
                              goto label_60;
                            case '3':
                              if (name == "Int32")
                                goto label_51;
                              goto label_60;
                            default:
                              goto label_60;
                          }
                        case 6:
                          switch (name[0])
                          {
                            case 'D':
                              if (name == "Double")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter.WriteStartElement(localName);
                                  xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter.WriteEndElement();
                                  continue;
                                }
                                xmlWriter.WriteStartElement(localName);
                                xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter.WriteString(arg.Reader.GetDouble(i2).ToString());
                                xmlWriter.WriteEndElement();
                                continue;
                              }
                              goto label_60;
                            case 'S':
                              if (name == "String")
                                break;
                              goto label_60;
                            default:
                              goto label_60;
                          }
                          break;
                        case 7:
                          switch (name[0])
                          {
                            case 'B':
                              if (name == "Boolean")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter.WriteStartElement(localName);
                                  xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter.WriteString(string.Empty);
                                  xmlWriter.WriteEndElement();
                                  continue;
                                }
                                xmlWriter.WriteStartElement(localName);
                                xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter.WriteString(arg.Reader.GetBoolean(i2) ? "1" : "0");
                                xmlWriter.WriteEndElement();
                                continue;
                              }
                              goto label_60;
                            case 'D':
                              if (name == "Decimal")
                              {
                                if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                                {
                                  xmlWriter.WriteStartElement(localName);
                                  xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                  xmlWriter.WriteEndElement();
                                  continue;
                                }
                                xmlWriter.WriteStartElement(localName);
                                xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                                xmlWriter.WriteString(arg.Reader.GetDecimal(i2).ToString());
                                xmlWriter.WriteEndElement();
                                continue;
                              }
                              goto label_60;
                            case 'I':
                              if (name == "Integer")
                                goto label_51;
                              goto label_60;
                            default:
                              goto label_60;
                          }
                        case 8:
                          if (name == "DateTime")
                          {
                            if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                            {
                              xmlWriter.WriteStartElement(localName);
                              xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                              xmlWriter.WriteEndElement();
                              continue;
                            }
                            xmlWriter.WriteStartElement(localName);
                            xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                            xmlWriter.WriteString(arg.Reader.GetDateTime(i2).ToShortDateString());
                            xmlWriter.WriteEndElement();
                            continue;
                          }
                          goto label_60;
                        default:
                          goto label_60;
                      }
                      if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                      {
                        xmlWriter.WriteStartElement(localName);
                        xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                        xmlWriter.WriteEndElement();
                        continue;
                      }
                      xmlWriter.WriteStartElement(localName);
                      xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                      xmlWriter.WriteString(arg.Reader.GetString(i2));
                      xmlWriter.WriteEndElement();
                      continue;
label_51:
                      if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                      {
                        xmlWriter.WriteStartElement(localName);
                        xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                        xmlWriter.WriteEndElement();
                        continue;
                      }
                      xmlWriter.WriteStartElement(localName);
                      xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                      xmlWriter.WriteString(arg.Reader.GetInt32(i2).ToString());
                      xmlWriter.WriteEndElement();
                      continue;
                    }
label_60:
                    if (arg.Reader.GetValue(i2).Equals((object) DBNull.Value))
                    {
                      xmlWriter.WriteStartElement(localName);
                      xmlWriter.WriteAttributeString("DataType", arg.Reader.GetFieldType(i2).Name);
                      xmlWriter.WriteEndElement();
                    }
                    else
                    {
                      xmlWriter.WriteStartElement(localName);
                      xmlWriter.WriteAttributeString("DataType", "System.String");
                      xmlWriter.WriteString(arg.Reader.GetValue(i2).ToString());
                      xmlWriter.WriteEndElement();
                    }
                  }
                  xmlWriter.WriteEndElement();
                  ++this._xmlRowsWritten;
                  if (this._xmlRowsWritten % 1000 == 0)
                  {
                    if (this._xmlRowsWritten % 1000 == 0)
                      this._localProgress.ProgressMessage = this._xmlRowsWritten.ToString() + " rows written to file";
                    LargeDataExcelExportProgress excelExportProgress3 = new LargeDataExcelExportProgress();
                    excelExportProgress3.ProgressMessage = this._localProgress.ProgressMessage;
                    excelExportProgress3.ProgressPercentChange = 0;
                    if (arg.Context is IProgress<LargeDataExcelExportProgress> context2)
                      context2.Report(excelExportProgress3);
                    excelExportProgress2 = (LargeDataExcelExportProgress) null;
                  }
                }
                if (!flag)
                {
                  xmlWriter.WriteStartElement("Table" + num2.ToString());
                  for (int i3 = 0; i3 < arg.Reader.FieldCount; ++i3)
                  {
                    string str = arg.Reader.GetName(i3);
                    if (string.IsNullOrEmpty(str))
                      str = "Column" + i3.ToString();
                    string localName = str.Replace(" ", "_x0020_").Replace("/", "_x002F_").Replace("(", "_x0028_").Replace(")", "_x0029_").Replace("&", "_x0026_").Replace("'", "_x2019_").Replace("’", "_x2019_");
                    xmlWriter.WriteStartElement(localName);
                    xmlWriter.WriteAttributeString("DataType", "System.String");
                    xmlWriter.WriteString(string.Empty);
                    xmlWriter.WriteEndElement();
                  }
                  xmlWriter.WriteEndElement();
                }
              }
              else
                goto label_34;
            }
          }
          while (arg.Reader.NextResult());
          goto label_80;
label_34:
          return;
label_32:
          return;
label_80:
          xmlWriter.WriteEndElement();
        }
      }
    }
    this._localProgress.ProgressMessage = "Data write complete";
    this._localProgress.ProgressPercentChange = 0;
    LargeDataExcelExportProgress excelExportProgress4 = new LargeDataExcelExportProgress();
    excelExportProgress4.ProgressMessage = this._localProgress.ProgressMessage;
    excelExportProgress4.ProgressPercentChange = 34;
    if (arg.Context is IProgress<LargeDataExcelExportProgress> context3)
      context3.Report(excelExportProgress4);
    excelExportProgress2 = (LargeDataExcelExportProgress) null;
  }

  public void WriteExcel(string ExcelFilePath)
  {
    string str = ExcelFilePath;
    Workbook wkb = new Workbook();
    wkb.Worksheets.RemoveAt(0);
    if (this._disposed)
      return;
    for (int index = 0; index < this._schemaDs.Tables.Count; ++index)
    {
      if (index < this._exportOptions.TableNames.Count)
        wkb.Worksheets.Add(this._exportOptions.TableNames[index]);
      else
        wkb.Worksheets.Add();
    }
    if (this._disposed)
      return;
    OoxmlSaveOptions ooxmlSaveOptions = new OoxmlSaveOptions();
    LightweightExcelSave lightweightExcelSave = new LightweightExcelSave(wkb, this._schemaDs, this._zipArchivePath, this._tempFilename + ".xml", (IProgress<LargeDataExcelExportProgress>) null, this._xmlRowsWritten);
    ooxmlSaveOptions.LightCellsDataProvider = (LightCellsDataProvider) lightweightExcelSave;
    wkb.Save(str, ooxmlSaveOptions);
    lightweightExcelSave.Dispose();
  }

  public async Task<LargeDataExcelExportProgress> WriteExcelAsync(
    string ExcelFilePath,
    IProgress<LargeDataExcelExportProgress> progress)
  {
    this._localProgress.ProgressMessage = "Creating excel file";
    this._localProgress.ProgressPercentChange = 0;
    progress.Report(new LargeDataExcelExportProgress()
    {
      ProgressMessage = this._localProgress.ProgressMessage,
      ProgressPercentChange = this._localProgress.ProgressPercentChange
    });
    string workbookSavePath = ExcelFilePath;
    Workbook wkb = new Workbook();
    wkb.Worksheets.RemoveAt(0);
    if (this._disposed)
      return this._localProgress;
    for (int index = 0; index < this._schemaDs.Tables.Count; ++index)
    {
      if (index < this._exportOptions.TableNames.Count)
        wkb.Worksheets.Add(this._exportOptions.TableNames[index]);
      else
        wkb.Worksheets.Add();
    }
    if (this._disposed)
      return this._localProgress;
    OoxmlSaveOptions opt = new OoxmlSaveOptions();
    LightweightExcelSave xlSave = new LightweightExcelSave(wkb, this._schemaDs, this._zipArchivePath, this._tempFilename + ".xml", progress, this._xmlRowsWritten);
    opt.LightCellsDataProvider = (LightCellsDataProvider) xlSave;
    await Task.Run((Action) (() => wkb.Save(workbookSavePath, opt)));
    xlSave.Dispose();
    this._localProgress.ProgressMessage = "Excel file complete";
    this._localProgress.ProgressPercentChange = 0;
    progress.Report(new LargeDataExcelExportProgress()
    {
      ProgressMessage = this._localProgress.ProgressMessage,
      ProgressPercentChange = this._localProgress.ProgressPercentChange
    });
    xlSave = (LightweightExcelSave) null;
    return this._localProgress;
  }

  public void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }

  public void Dispose(bool disposing)
  {
    if (this._disposed || !disposing)
      return;
    if (this._schemaDs != null)
      this._schemaDs.Dispose();
    if (File.Exists(this._zipArchivePath))
      File.Delete(this._zipArchivePath);
    this._disposed = true;
  }
}
