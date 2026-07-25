// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.Model.PolicyImportDataManager
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DbExtensions;
using MGASystems.Data.Validation;
using MgaSystems.Ims.Fortegra.PolicyImport.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.Model;

public abstract class PolicyImportDataManager : ValidatingBindingObject
{
  private CancellationTokenSource _ctsImportProcess;
  private CancellationTokenSource _ctsRefreshImportLogItemList;
  private CancellationTokenSource _ctsRefreshImportPreprocessErrorList;

  public virtual int CurrentImportSourceID { get; private set; }

  [TrackChanges]
  public virtual BulkObservableCollection<ImportSource> ImportSourceList { get; } = new BulkObservableCollection<ImportSource>();

  public virtual BulkObservableCollection<ImportLogItem> ImportLogItemList { get; } = new BulkObservableCollection<ImportLogItem>();

  public virtual BulkObservableCollection<ImportLogDetailItem> CurrentImportDetailList { get; } = new BulkObservableCollection<ImportLogDetailItem>();

  public virtual BulkObservableCollection<ExcelToXMLVersion> ExcelToXMLVersionList { get; } = new BulkObservableCollection<ExcelToXMLVersion>();

  public virtual BulkObservableCollection<ImportSourceProducerLocationItem> ImportSourceProducerLocationList { get; } = new BulkObservableCollection<ImportSourceProducerLocationItem>();

  public virtual BulkObservableCollection<ImportSourceImportVersionItem> ImportSourceImportVersionList { get; } = new BulkObservableCollection<ImportSourceImportVersionItem>();

  public virtual BulkObservableCollection<ImportPreprocessErrorItem> ImportLogPreprocessErrorList { get; } = new BulkObservableCollection<ImportPreprocessErrorItem>();

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  internal static PolicyImportDataManager Create()
  {
    return NotifyProxyTypeManager.Allocate<PolicyImportDataManager>();
  }

  public bool RetrievingSummaryData { get; private set; }

  public PolicyImportDataManager()
  {
    this.ImportSourceList.AddRange((IEnumerable<ImportSource>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "Fortegra_GetPolicyImportSources").AsEnumerable().Select<DataRow, ImportSource>((System.Func<DataRow, ImportSource>) (row => ImportSource.Create(this, row))));
    this.ExcelToXMLVersionList.AddRange((IEnumerable<ExcelToXMLVersion>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "Fortegra_AL3GetExcelToXMLVersions").AsEnumerable().Select<DataRow, ExcelToXMLVersion>((System.Func<DataRow, ExcelToXMLVersion>) (row => ExcelToXMLVersion.Create(this, row))));
    this.ImportSourceProducerLocationList.AddRange((IEnumerable<ImportSourceProducerLocationItem>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "Fortegra_AL3GetProducerLocationMappings").AsEnumerable().Select<DataRow, ImportSourceProducerLocationItem>((System.Func<DataRow, ImportSourceProducerLocationItem>) (row => ImportSourceProducerLocationItem.Create(this, row))));
    this.ImportSourceImportVersionList.AddRange((IEnumerable<ImportSourceImportVersionItem>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "Fortegra_AL3GetImportVersionMappings").AsEnumerable().Select<DataRow, ImportSourceImportVersionItem>((System.Func<DataRow, ImportSourceImportVersionItem>) (row => ImportSourceImportVersionItem.Create(this, row))));
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  public ImportSource NewImportSource()
  {
    ImportSource importSource = ImportSource.Create(this);
    ((Collection<ImportSource>) this.ImportSourceList).Add(importSource);
    return importSource;
  }

  public async Task RefreshImportPreprocessErrorListAsync(XElement importLogIDs)
  {
    if (this._ctsRefreshImportPreprocessErrorList != null)
    {
      this._ctsRefreshImportPreprocessErrorList.Cancel();
      this._ctsRefreshImportPreprocessErrorList.Dispose();
    }
    ((Collection<ImportPreprocessErrorItem>) this.ImportLogPreprocessErrorList).Clear();
    SqlXml importXMLParam = new SqlXml((XmlReader) new XmlTextReader((TextReader) new StringReader(importLogIDs.ToString())));
    this._ctsRefreshImportPreprocessErrorList = new CancellationTokenSource();
    EnumerableRowCollection<DataRow> source = await Task.Run<EnumerableRowCollection<DataRow>>((Func<EnumerableRowCollection<DataRow>>) (() =>
    {
      using (SqlCommand refreshErrorsSqlCommand = new SqlCommand("Fortegra_ParseAL3PreprocessErrors", DefaultDatabase.CreateConnection()))
      {
        refreshErrorsSqlCommand.CommandType = CommandType.StoredProcedure;
        refreshErrorsSqlCommand.CommandTimeout = 0;
        refreshErrorsSqlCommand.Parameters.Add("@ImportLogIDs", SqlDbType.Xml);
        refreshErrorsSqlCommand.Parameters[0].Value = (object) importXMLParam;
        CancellationToken token = this._ctsRefreshImportPreprocessErrorList.Token;
        token.Register((Action) (() =>
        {
          refreshErrorsSqlCommand.Cancel();
          refreshErrorsSqlCommand.Dispose();
        }));
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(refreshErrorsSqlCommand))
        {
          DataTable dataTable = new DataTable();
          if (!token.IsCancellationRequested)
          {
            try
            {
              sqlDataAdapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
              if (token.IsCancellationRequested)
                dataTable.Clear();
              if (!token.IsCancellationRequested)
                throw ex;
            }
          }
          return dataTable.AsEnumerable();
        }
      }
    }));
    ((Collection<ImportPreprocessErrorItem>) this.ImportLogPreprocessErrorList).Clear();
    this.ImportLogPreprocessErrorList.AddRange((IEnumerable<ImportPreprocessErrorItem>) source.Select<DataRow, ImportPreprocessErrorItem>((System.Func<DataRow, ImportPreprocessErrorItem>) (row => ImportPreprocessErrorItem.Create(this, row))));
  }

  public async Task RefreshImportLogItemListAsync(int importSource)
  {
    if (this._ctsRefreshImportLogItemList != null)
    {
      this._ctsRefreshImportLogItemList.Cancel();
      this._ctsRefreshImportLogItemList.Dispose();
    }
    ((Collection<ImportLogItem>) this.ImportLogItemList).Clear();
    this.CurrentImportSourceID = importSource;
    this._ctsRefreshImportLogItemList = new CancellationTokenSource();
    DataTable dataTable1 = await Task.Run<DataTable>((Func<DataTable>) (() =>
    {
      using (SqlCommand importLogSqlCommand = new SqlCommand("Fortegra_GetImportLogs", DefaultDatabase.CreateConnection()))
      {
        importLogSqlCommand.CommandType = CommandType.StoredProcedure;
        importLogSqlCommand.CommandTimeout = 0;
        importLogSqlCommand.Parameters.Add("@ImportSource", SqlDbType.Int);
        importLogSqlCommand.Parameters[0].Value = (object) this.CurrentImportSourceID;
        CancellationToken token = this._ctsRefreshImportLogItemList.Token;
        token.Register((Action) (() =>
        {
          importLogSqlCommand.Cancel();
          importLogSqlCommand.Dispose();
        }));
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(importLogSqlCommand))
        {
          DataTable dataTable2 = new DataTable();
          if (!token.IsCancellationRequested)
          {
            try
            {
              sqlDataAdapter.Fill(dataTable2);
            }
            catch (SqlException ex)
            {
              if (token.IsCancellationRequested)
                dataTable2.Clear();
              if (!token.IsCancellationRequested)
                throw ex;
            }
          }
          return dataTable2;
        }
      }
    }));
    ((Collection<ImportLogItem>) this.ImportLogItemList).Clear();
    this.ImportLogItemList.AddRange(((IEnumerable<DataRow>) dataTable1.Select()).AsEnumerable<DataRow>().Select<DataRow, ImportLogItem>((System.Func<DataRow, ImportLogItem>) (row => ImportLogItem.Create(this, row))));
  }

  public async Task RefreshImportLogDetailItemListAsync(XElement importLogIDs)
  {
    ((Collection<ImportLogDetailItem>) this.CurrentImportDetailList).Clear();
    SqlXml importXMLParam = new SqlXml((XmlReader) new XmlTextReader((TextReader) new StringReader(importLogIDs.ToString())));
    EnumerableRowCollection<DataRow> source = await Task.Run<EnumerableRowCollection<DataRow>>((Func<EnumerableRowCollection<DataRow>>) (() => DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "Fortegra_AL3GetImportDetails", new object[2]
    {
      (object) "@ImportLogIDs",
      (object) importXMLParam
    }).AsEnumerable()));
    ((Collection<ImportLogDetailItem>) this.CurrentImportDetailList).Clear();
    this.CurrentImportDetailList.AddRange((IEnumerable<ImportLogDetailItem>) source.Select<DataRow, ImportLogDetailItem>((System.Func<DataRow, ImportLogDetailItem>) (row => ImportLogDetailItem.Create(this, row))));
  }

  public async Task<bool> AllImportsDataSavedOrErroredAsync(XElement importLogIDs)
  {
    SqlXml importXMLParam = new SqlXml((XmlReader) new XmlTextReader((TextReader) new StringReader(importLogIDs.ToString())));
    return await Task.Run<bool>((Func<bool>) (() => DefaultDatabase.ExecuteScalar<bool>(CommandType.StoredProcedure, "Fortegra_AL3GetAllImportsDataSavedOrErrored", new object[2]
    {
      (object) "@ImportLogIDs",
      (object) importXMLParam
    })));
  }

  public async Task InitiateXMLImportAsync(
    string importXML,
    Action<int> ReturnNewImportLogID,
    Action<int> ReturnNewImportLogIDsCount)
  {
    if (this._ctsImportProcess != null)
    {
      this._ctsImportProcess.Cancel();
      this._ctsImportProcess.Dispose();
    }
    this._ctsImportProcess = new CancellationTokenSource();
    ((Collection<ImportPreprocessErrorItem>) this.ImportLogPreprocessErrorList).Clear();
    List<XElement> xmlsToImport = new List<XElement>();
    XDocument xdocument = XDocument.Parse(importXML);
    if (xdocument.Root.Elements((XName) "Policy").Elements<XElement>((XName) "PolicyUnit").Elements<XElement>((XName) "Premium").Count<XElement>() > 30000)
    {
      string content1 = xdocument.Root.Element((XName) "ClientID")?.Value;
      string content2 = xdocument.Root.Element((XName) "ImportVersion")?.Value;
      string content3 = xdocument.Root.Element((XName) "ImportSource")?.Value;
      foreach (XElement xelement in xdocument.Root.Descendants((XName) "Policy").ToList<XElement>())
      {
        if (!this._ctsImportProcess.IsCancellationRequested)
        {
          XName name = (XName) "Feed";
          object[] objArray = new object[4]
          {
            (object) new XElement((XName) "ClientID", (object) content1),
            (object) new XElement((XName) "ImportVersion", (object) content2),
            (object) new XElement((XName) "ImportSource", (object) content3),
            (object) xelement
          };
          xmlsToImport.Add(new XElement(name, objArray));
        }
        else
          break;
      }
    }
    else
      xmlsToImport.Add(xdocument.Root);
    if (ReturnNewImportLogIDsCount != null)
      ReturnNewImportLogIDsCount(xmlsToImport.Count);
    for (int i = 0; i < xmlsToImport.Count; ++i)
    {
      CancellationToken xclImportToken = this._ctsImportProcess.Token;
      CancellationToken xclProcessToken = this._ctsImportProcess.Token;
      if (!xclImportToken.IsCancellationRequested && !xclProcessToken.IsCancellationRequested)
      {
        SqlXml importXMLParam = new SqlXml((XmlReader) new XmlTextReader((TextReader) new StringReader(xmlsToImport[i].ToString())));
        using (SqlConnection nonRetryConnection = DefaultDatabase.CreateConnection())
        {
          if (nonRetryConnection.State != ConnectionState.Open)
            await nonRetryConnection.OpenAsync();
          int importLogID = 0;
          using (SqlCommand nonRetryLogImportCommand = new SqlCommand("Fortegra_LogAL3Import", nonRetryConnection))
          {
            nonRetryLogImportCommand.CommandTimeout = 0;
            nonRetryLogImportCommand.CommandType = CommandType.StoredProcedure;
            nonRetryLogImportCommand.Parameters.AddWithValue("@ImportXML", (object) SqlDbType.Xml);
            nonRetryLogImportCommand.Parameters["@ImportXML"].Value = (object) importXMLParam;
            xclImportToken.Register((Action) (() =>
            {
              nonRetryLogImportCommand?.Cancel();
              nonRetryLogImportCommand?.Dispose();
            }));
            xclImportToken.ThrowIfCancellationRequested();
            try
            {
              importLogID = (int) await nonRetryLogImportCommand.ExecuteScalarAsync();
            }
            catch (SqlException ex)
            {
              if (!xclImportToken.IsCancellationRequested)
                throw ex;
            }
            if (ReturnNewImportLogID != null)
              ReturnNewImportLogID(importLogID);
          }
          ((Collection<ImportLogItem>) this.ImportLogItemList).Add(ImportLogItem.Create(this, importLogID, DateTime.Today.ToShortDateString()));
          using (SqlCommand nonRetryInitiateImportCommand = new SqlCommand("Fortegra_InitiateAL3Import", nonRetryConnection))
          {
            nonRetryInitiateImportCommand.CommandTimeout = 0;
            nonRetryInitiateImportCommand.CommandType = CommandType.StoredProcedure;
            nonRetryInitiateImportCommand.Parameters.Add("@ImportLogID", SqlDbType.Int);
            nonRetryInitiateImportCommand.Parameters["@ImportLogID"].Value = (object) importLogID;
            xclProcessToken.Register((Action) (() =>
            {
              if (nonRetryConnection.State == ConnectionState.Closed)
                return;
              nonRetryConnection.Close();
            }));
            xclProcessToken.ThrowIfCancellationRequested();
            try
            {
              if (nonRetryConnection.State == ConnectionState.Open)
              {
                int num = await nonRetryInitiateImportCommand.ExecuteNonQueryAsync();
              }
            }
            catch (SqlException ex)
            {
              if (!xclImportToken.IsCancellationRequested)
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
              if (!ex.Message.Contains("The connection is closed"))
                throw ex;
              if (!xclImportToken.IsCancellationRequested)
                throw ex;
            }
          }
        }
        importXMLParam = (SqlXml) null;
      }
      else
      {
        xclImportToken.ThrowIfCancellationRequested();
        xclProcessToken.ThrowIfCancellationRequested();
      }
      xclImportToken = new CancellationToken();
      xclProcessToken = new CancellationToken();
    }
    xmlsToImport = (List<XElement>) null;
  }

  public async Task ResumeImportAsync(int importLogId)
  {
    if (this._ctsImportProcess != null)
    {
      this._ctsImportProcess.Cancel();
      this._ctsImportProcess.Dispose();
    }
    this._ctsImportProcess = new CancellationTokenSource();
    CancellationToken xclImportToken = this._ctsImportProcess.Token;
    CancellationToken xclProcessToken = this._ctsImportProcess.Token;
    if (!xclImportToken.IsCancellationRequested && !xclProcessToken.IsCancellationRequested)
    {
      using (DbConnection conn = DefaultDatabase.CreateDbConnection())
      {
        await conn.OpenAsync(xclProcessToken);
        using (DbCommand nonRetryResumeImportCommand = DefaultDatabase.CreateCommand("Fortegra_ResumeAL3Import", conn))
        {
          nonRetryResumeImportCommand.CommandTimeout = 0;
          nonRetryResumeImportCommand.CommandType = CommandType.StoredProcedure;
          DbParameterCollectionExtensions.AddWithValue(nonRetryResumeImportCommand.Parameters, "@ImportLogID", (object) importLogId);
          xclProcessToken.ThrowIfCancellationRequested();
          try
          {
            if (conn.State == ConnectionState.Open)
            {
              int num = await nonRetryResumeImportCommand.ExecuteNonQueryAsync(xclProcessToken);
            }
          }
          catch (InvalidOperationException ex)
          {
            if (ex.Message.Contains("The connection is closed"))
            {
              if (!xclImportToken.IsCancellationRequested)
                throw;
            }
            else
              throw;
          }
          catch (Exception ex)
          {
            if (!xclImportToken.IsCancellationRequested)
              throw;
          }
        }
      }
      xclImportToken = new CancellationToken();
      xclProcessToken = new CancellationToken();
    }
    else
    {
      xclImportToken.ThrowIfCancellationRequested();
      xclProcessToken.ThrowIfCancellationRequested();
      xclImportToken = new CancellationToken();
      xclProcessToken = new CancellationToken();
    }
  }

  public void CancelAllProcessing()
  {
    this._ctsImportProcess?.Cancel();
    this._ctsRefreshImportLogItemList?.Cancel();
    this._ctsRefreshImportPreprocessErrorList?.Cancel();
  }
}
