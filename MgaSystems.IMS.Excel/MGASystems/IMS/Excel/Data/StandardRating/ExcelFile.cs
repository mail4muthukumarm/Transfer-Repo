// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.StandardRating.ExcelFile
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MgaSystems.IMS.Excel.Data;
using MGASystems.IMS.Excel.Data.Administration2;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Excel.Data.StandardRating;

public class ExcelFile : BindingObject
{
  private string _undecoratedFileName;
  private bool _workBookExistsInDatabase;
  private static readonly Dictionary<string, int> templateFileIndices = new Dictionary<string, int>();
  public readonly Guid FactorSetGuid;
  public readonly Guid QuoteGuid;
  public readonly int RaterId;
  private bool _cancelDownload;
  private bool _isDownloading;
  private int _percentDownloaded;
  private string _status;
  private static readonly string localApplicationData = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}\\Mga Systems\\Excel Rating\\", (object) Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
  private bool _isWorking;
  private Workbook _workbook;

  public List<ExcelMappingError> UpdateErrors { get; private set; }

  public bool WorkBookExistsInDatabase
  {
    get
    {
      if (!this._workBookExistsInDatabase)
        this._workBookExistsInDatabase = (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "select count(*) from tblExcelRating_ExcelFileStore where QuoteGuid = @QuoteGuid and RaterID = @RaterID", new object[4]
        {
          (object) "@quoteGuid",
          (object) this.QuoteGuid,
          (object) "@RaterID",
          (object) this.RaterId
        }) > 0;
      return this._workBookExistsInDatabase;
    }
    private set => this._workBookExistsInDatabase = value;
  }

  public bool FullPathIsValid => !string.IsNullOrEmpty(this.FullPath);

  public int PercentDownloaded
  {
    get => this._percentDownloaded;
    private set
    {
      this.SetPropertyValue<int>((Action) (() => { }), ref this._percentDownloaded, value);
    }
  }

  public void CancelDownload()
  {
    if (!this.IsDownloading)
      return;
    this._cancelDownload = true;
  }

  public string FullPath { get; private set; }

  public string Status
  {
    get => this._status;
    private set
    {
      if (!(this._status != value))
        return;
      this._status = value;
      this.OnPropertyChanged(nameof (Status));
      this.OnPropertyChanged("HasStatus");
    }
  }

  public bool HasStatus => !string.IsNullOrEmpty(this.Status);

  public bool IsWorking
  {
    get => this._isWorking;
    private set => this.SetPropertyValue<bool>((Action) (() => { }), ref this._isWorking, value);
  }

  public bool IsDownloading
  {
    get => this._isDownloading;
    private set
    {
      if (this._isDownloading == value)
        return;
      this._isDownloading = value;
      if (this._cancelDownload)
        return;
      this.OnPropertyChanged(nameof (IsDownloading));
    }
  }

  public Workbook Workbook => this._workbook ?? (this._workbook = new Workbook(this.FullPath));

  protected virtual string CreateExcelFileDestinationName(string templateFileName)
  {
    string str1 = "";
    string fileName = Path.GetFileName(templateFileName);
    string format = "{0}{1} {2}{3}{4}";
    string str2 = Guid.NewGuid().ToString().Substring(0, 4);
    if (ExcelFile.templateFileIndices.ContainsKey(fileName))
    {
      int num = ExcelFile.templateFileIndices[fileName] + 1;
      str1 = num.ToString();
      ExcelFile.templateFileIndices[fileName] = num;
      format = "{0}{1} {2} {3}{4}";
    }
    else
      ExcelFile.templateFileIndices.Add(fileName, 0);
    return string.Format((IFormatProvider) CultureInfo.InvariantCulture, format, (object) MGATempFolder.MGATempRandomFolderPath, (object) Path.GetFileNameWithoutExtension(templateFileName), (object) str2, (object) str1, (object) Path.GetExtension(templateFileName));
  }

  private void CopyExcelFileForUse(string templateFileName)
  {
    this._undecoratedFileName = string.IsNullOrEmpty(this._undecoratedFileName) ? templateFileName : throw new InvalidOperationException();
    string fileDestinationName = this.CreateExcelFileDestinationName(templateFileName);
    File.Copy(templateFileName, fileDestinationName);
    this.FullPath = fileDestinationName;
  }

  public ExcelFile(Guid factorSetGuid, Guid quoteGuid, int raterId)
  {
    this.FactorSetGuid = factorSetGuid;
    this.QuoteGuid = quoteGuid;
    this.RaterId = raterId;
  }

  public ExcelFile(Guid factorSetGuid, Guid quoteGuid, int raterId, string excelFile)
  {
    this.FactorSetGuid = factorSetGuid;
    this.QuoteGuid = quoteGuid;
    this.RaterId = raterId;
    if (!File.Exists(excelFile))
      throw new ArgumentException("Excel file does not exist.", nameof (excelFile));
    this.CopyExcelFileForUse(excelFile);
  }

  public void Update(List<ExcelMapping> excelMappings, string databaseTableName)
  {
    this.Update(excelMappings, true, databaseTableName);
  }

  protected virtual void UploadAdditionalData(int raterId, Guid quote, Workbook workbook)
  {
  }

  protected virtual void UploadAdditionalData(
    int raterId,
    Guid quote,
    Workbook workbook,
    BackgroundWorker backgroundWorker,
    bool uploadFile)
  {
  }

  private void UploadExtensionData(
    Workbook workbook,
    BackgroundWorker backgroundWorker,
    bool uploadFile)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "ExcelRating_GetRaterExtensionIDs", new object[2]
    {
      (object) "@RaterID",
      (object) this.RaterId
    });
    if (dataTable.Rows.Count <= 0 || dataTable == null)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      int excelRangeRaterId = row.Field<int>("ExtensionID");
      this.UpdateAdditionalMappings(backgroundWorker, workbook, excelRangeRaterId, uploadFile);
    }
  }

  public virtual void UpdateComplete(
    int raterId,
    Guid quote,
    Workbook workbook,
    BackgroundWorker backgroundWorker,
    bool uploadFile)
  {
  }

  protected void UpdateAdditionalMappings(
    BackgroundWorker backgroundWorker,
    Workbook workbook,
    string excelRangeRaterName,
    bool uploadFile)
  {
    int excelRangeRaterId = Utility.IsNull<int>(DefaultDatabase.ExecuteScalar(CommandType.Text, "select RatingTypeID from lstRatingTypes where RatingType = @ratername", new object[2]
    {
      (object) "@ratername",
      (object) excelRangeRaterName
    }), -1);
    if (excelRangeRaterId == -1)
      return;
    this.UpdateAdditionalMappings(backgroundWorker, workbook, excelRangeRaterId, uploadFile);
  }

  protected void UpdateAdditionalMappings(
    BackgroundWorker backgroundWorker,
    Workbook workbook,
    int excelRangeRaterId,
    bool uploadFile)
  {
    if (workbook == null)
      throw new ArgumentNullException(nameof (workbook));
    if (backgroundWorker == null)
      throw new ArgumentNullException(nameof (backgroundWorker));
    string databaseTableName = DefaultDatabase.ExecuteScalar(CommandType.Text, "select DatabaseTableName from tblExcelRating_Raters where RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) excelRangeRaterId
    }) as string;
    if (string.IsNullOrEmpty(databaseTableName))
      throw new ArgumentOutOfRangeException(nameof (excelRangeRaterId), "excelRangeRaterID is not an Excel based rater and has no associated table in the IMS DB");
    Dictionary<string, string> dictionary;
    try
    {
      dictionary = ((IEnumerable) workbook.Worksheets).Cast<Worksheet>().ToDictionary<Worksheet, string, string>((System.Func<Worksheet, string>) (ws => ws.Name.Replace(" ", "")), (System.Func<Worksheet, string>) (ws => ws.Name), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    }
    catch
    {
      dictionary = ((IEnumerable) workbook.Worksheets).Cast<Worksheet>().ToDictionary<Worksheet, string, string>((System.Func<Worksheet, string>) (ws => ws.Name), (System.Func<Worksheet, string>) (ws => ws.Name), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    }
    List<ExcelMapping> mappings = ExcelRaterFactorSet.GetMappings(this.QuoteGuid, (DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 tf.factorsetguid from tblFactorSets tf inner join tblExcelRating_FactorSets efs on efs.FactorSetGuid = tf.FactorSetGUID where tf.RaterID = @RaterID order by tf.EffectiveDate desc", new object[2]
    {
      (object) "@RaterID",
      (object) excelRangeRaterId
    }) as Guid? ?? throw new InvalidOperationException($"Unable to locate excel mappings for rater id {excelRangeRaterId}")).Value);
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"delete from {databaseTableName} where quoteGuid = @QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    });
    Dictionary<string, object> mappedValues = this.MapValuesFromSheet(mappings, backgroundWorker, workbook, dictionary);
    this.UploadMappedValues(uploadFile, databaseTableName, mappedValues, true);
  }

  public static bool ResolveRaterAllowsMissingSchedules(int raterID)
  {
    return DefaultDatabase.ExecuteScalar<int>("ExcelRating_ResolveRaterAllowsMissingSchedules", new object[2]
    {
      (object) "@RaterID",
      (object) raterID
    }) == 1;
  }

  private bool ValidateWorksheetExists(Workbook workbook, string workSheetName)
  {
    Worksheet worksheet = workbook.Worksheets[workSheetName];
    try
    {
      string name = worksheet.Name;
      return true;
    }
    catch (Exception ex)
    {
      if (!ExcelFile.ResolveRaterAllowsMissingSchedules(this.RaterId))
        this.UpdateErrors.Add(new ExcelMappingError("Worksheet does not exist", string.Format("The worksheet [{0}] could not be found in this workbook. {0} was expected as part of the current mappings assigned to this quote. You may need to revert to a prior set of mappings to rate successfully.", (object) workSheetName)));
    }
    return false;
  }

  protected void UpdateRange(
    BackgroundWorker backgroundWorker,
    Workbook workbook,
    int excelRangeRaterId,
    bool uploadFile,
    int rowStart,
    int rowEnd,
    Func<Worksheet, int, string> rowValidatePredicate = null)
  {
    if (workbook == null)
      throw new ArgumentNullException(nameof (workbook));
    if (backgroundWorker == null)
      throw new ArgumentNullException(nameof (backgroundWorker));
    if (rowEnd < rowStart)
      throw new ArgumentOutOfRangeException(nameof (rowEnd), "endRow cannot be greater than startRow");
    string databaseTableName = DefaultDatabase.ExecuteScalar(CommandType.Text, "select DatabaseTableName from tblExcelRating_Raters where RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) excelRangeRaterId
    }) as string;
    if (string.IsNullOrEmpty(databaseTableName))
      throw new ArgumentOutOfRangeException("excelRangeInputRaterId", "excelRangeInputRaterId is not an Excel based rater and has no associated table in the IMS DB");
    Dictionary<string, string> worksheetMappings = (Dictionary<string, string>) null;
    try
    {
      worksheetMappings = ((IEnumerable) workbook.Worksheets).Cast<Worksheet>().ToDictionary<Worksheet, string, string>((System.Func<Worksheet, string>) (ws => ws.Name.Replace(" ", "")), (System.Func<Worksheet, string>) (ws => ws.Name), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    }
    catch
    {
      worksheetMappings = ((IEnumerable) workbook.Worksheets).Cast<Worksheet>().ToDictionary<Worksheet, string, string>((System.Func<Worksheet, string>) (ws => ws.Name), (System.Func<Worksheet, string>) (ws => ws.Name), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    }
    Guid? nullable = DefaultDatabase.ExecuteScalar(CommandType.Text, "select rs.ScheduleFactorSetGuid from tblExcelRating_RaterSchedules rs inner join tblFactorSets f on f.FactorSetGUID = rs.ScheduleFactorSetGuid where f.RaterID = @scheduleRaterID and rs.RaterFactorSetGuid = @raterFactorSetGuid", new object[4]
    {
      (object) "@scheduleRaterID",
      (object) excelRangeRaterId,
      (object) "@raterFactorSetGuid",
      (object) this.FactorSetGuid
    }) as Guid?;
    if (!nullable.HasValue)
      nullable = DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 tf.factorsetguid from tblFactorSets tf inner join tblExcelRating_FactorSets efs on efs.FactorSetGuid = tf.FactorSetGUID where tf.RaterID = @RaterID order by tf.EffectiveDate desc", new object[2]
      {
        (object) "@RaterID",
        (object) excelRangeRaterId
      }) as Guid?;
    if (!nullable.HasValue)
      throw new InvalidOperationException($"Unable to locate excel mappings for rater id {excelRangeRaterId}");
    List<ExcelMapping> excelMappings = ExcelRaterFactorSet.GetMappings(this.QuoteGuid, nullable.Value);
    if (excelMappings == null || excelMappings.Count == 0)
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"delete from {databaseTableName} where quoteGuid = @QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      });
      string workSheetName = ExcelFile.GetWorksheetName(workbook, excelMappings[0], worksheetMappings);
      Worksheet worksheet = workbook.Worksheets[workSheetName];
      if (!this.ValidateWorksheetExists(workbook, workSheetName))
        return;
      DataTable bulkInsertTable = new DataTable(databaseTableName);
      bulkInsertTable.Columns.Add("QuoteGuid", typeof (Guid));
      bulkInsertTable.Columns.AddRange(excelMappings.Select<ExcelMapping, DataColumn>((System.Func<ExcelMapping, DataColumn>) (mapping => new DataColumn(mapping.DatabaseField, Type.GetType(mapping.DatabaseType)))).ToArray<DataColumn>());
      bulkInsertTable.BeginLoadData();
      int num1 = 0;
      for (int index = rowStart; index <= rowEnd; ++index)
      {
        ++num1;
        if (rowValidatePredicate != null)
        {
          string error = rowValidatePredicate(worksheet, index);
          if (!string.IsNullOrEmpty(error))
          {
            switch (error)
            {
              case "SKIP":
                continue;
              case "EOF":
                goto label_8;
              default:
                this.UpdateErrors.Add(new ExcelMappingError("Range Row", error));
                int num2 = uploadFile ? 1 : 0;
                continue;
            }
          }
        }
      }
label_8:
      float multiplier = 100f / (float) num1;
      int num3 = 0;
      for (int index = rowStart; index <= rowEnd; ++index)
      {
        ++num3;
        backgroundWorker.ReportProgress((int) ((double) multiplier * (double) num3), (object) $"Reading row {index} of the {workSheetName} sheet");
        if (rowValidatePredicate != null)
        {
          string error = rowValidatePredicate(worksheet, index);
          if (!string.IsNullOrEmpty(error))
          {
            switch (error)
            {
              case "SKIP":
                continue;
              case "EOF":
                goto label_24;
              default:
                this.UpdateErrors.Add(new ExcelMappingError("Range Row", error));
                if (uploadFile)
                  continue;
                break;
            }
          }
        }
        Dictionary<string, object> source = this.MapValuesFromSheet(excelMappings, backgroundWorker, workbook, worksheetMappings, new int?(index));
        source.Add("QuoteGuid", (object) this.QuoteGuid);
        DataRow row = bulkInsertTable.NewRow();
        foreach (KeyValuePair<string, object> keyValuePair in source.Where<KeyValuePair<string, object>>((System.Func<KeyValuePair<string, object>, bool>) (item => !Utility.IsNull(item.Value))))
          row[keyValuePair.Key] = keyValuePair.Value;
        bulkInsertTable.Rows.Add(row);
      }
label_24:
      bulkInsertTable.EndLoadData();
      if (bulkInsertTable.Rows.Count > 0)
      {
        backgroundWorker.ReportProgress((int) ((double) multiplier * (double) num3), (object) $"Starting data upload for {workSheetName} sheet");
        try
        {
          DefaultDatabase.ExecuteBulkInsert(new int?(TimeSpan.FromMinutes(4.0).Seconds), bulkInsertTable, (SqlRowsCopiedEventHandler) ((sender, rowsCopiedArgs) => backgroundWorker.ReportProgress((int) ((double) multiplier * (double) rowsCopiedArgs.RowsCopied), (object) $"Uploaded {rowsCopiedArgs.RowsCopied} of {bulkInsertTable.Rows.Count} rows for {workSheetName} sheet")), SqlBulkCopyOptions.FireTriggers, (string) null);
        }
        catch (Exception ex)
        {
          ex.Data[(object) "ScheduleRaterID"] = (object) excelRangeRaterId;
          ex.Data[(object) "ScheduleTable"] = (object) databaseTableName;
          if (ex.Message.StartsWith("The given ColumnMapping does not match"))
          {
            DataTable schemaTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, $"SELECT TOP(0) * FROM dbo.{databaseTableName} WITH(NOLOCK)");
            IEnumerable<string> strings1 = bulkInsertTable.Columns.OfType<DataColumn>().Where<DataColumn>((System.Func<DataColumn, bool>) (bulkColumn => !schemaTable.Columns.Contains(bulkColumn.ColumnName))).Select<DataColumn, string>((System.Func<DataColumn, string>) (bulkColumn => bulkColumn.ColumnName));
            if (strings1.Any<string>())
              ex.Data[(object) "MissingColumns"] = (object) string.Join(",", strings1);
            IEnumerable<string> strings2 = bulkInsertTable.Columns.OfType<DataColumn>().Where<DataColumn>((System.Func<DataColumn, bool>) (bulkColumn =>
            {
              DataColumn column = schemaTable.Columns[bulkColumn.ColumnName];
              return column != null && !column.ColumnName.Equals(bulkColumn.ColumnName);
            })).Select<DataColumn, string>((System.Func<DataColumn, string>) (bulkColumn => bulkColumn.ColumnName));
            if (strings2.Any<string>())
              ex.Data[(object) "MismatchedColumns"] = (object) string.Join(",", strings2);
          }
          throw;
        }
        backgroundWorker.ReportProgress((int) ((double) multiplier * (double) num3), (object) $"Completed uploading data for {workSheetName} sheet");
      }
      e.Transaction.Commit();
    }));
  }

  public void UpdateWithoutStatusProgress(
    List<ExcelMapping> excelMappings,
    bool uploadFile,
    string databaseTableName)
  {
    this.UpdateErrors = new List<ExcelMappingError>();
    if (!File.Exists(this.FullPath))
      return;
    string str = Path.Combine(MGATempFolder.MGATempRandomFolderPath, Path.GetFileName(this.FullPath));
    File.Copy(this.FullPath, str);
    byte[] newZipStream = new ZipUtility().CompressStreamToNewZipStream(FileReader.ReadAllBytes(str), Path.GetFileName(this._undecoratedFileName));
    if (newZipStream == null || newZipStream.Length == 0)
      return;
    if (uploadFile)
      this.UploadExcelFile(newZipStream, (BackgroundWorker) null);
    using (Workbook workbook = new Workbook(str))
    {
      Dictionary<string, string> dictionary;
      try
      {
        dictionary = ((IEnumerable) workbook.Worksheets).Cast<Worksheet>().ToDictionary<Worksheet, string, string>((System.Func<Worksheet, string>) (ws => ws.Name.Replace(" ", "")), (System.Func<Worksheet, string>) (ws => ws.Name), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      }
      catch
      {
        dictionary = ((IEnumerable) workbook.Worksheets).Cast<Worksheet>().ToDictionary<Worksheet, string, string>((System.Func<Worksheet, string>) (ws => ws.Name), (System.Func<Worksheet, string>) (ws => ws.Name), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      }
      Dictionary<string, object> mappedValues = this.MapValuesFromSheet(excelMappings, (BackgroundWorker) null, workbook, dictionary);
      this.UploadMappedValues(uploadFile, databaseTableName, mappedValues, false);
    }
    this.OnPropertyChanged("UpdateErrors");
    this.OnPropertyChanged("HasUpdateErrors");
  }

  public void UpdateNonThreaded(
    List<ExcelMapping> excelMappings,
    bool uploadFile,
    string databaseTableName,
    string fileName,
    byte[] worksheetBytes)
  {
    this.UpdateErrors = new List<ExcelMappingError>();
    byte[] newZipStream = new ZipUtility().CompressStreamToNewZipStream(worksheetBytes, Path.GetFileName(fileName));
    if (newZipStream == null || newZipStream.Length == 0)
      return;
    BackgroundWorker backgroundWorker = new BackgroundWorker()
    {
      WorkerReportsProgress = true,
      WorkerSupportsCancellation = true
    };
    using (MemoryStream memoryStream = new MemoryStream(worksheetBytes))
      this.OnDoWork(backgroundWorker, excelMappings, uploadFile, databaseTableName, newZipStream, (Func<Workbook>) (() => new Workbook((Stream) memoryStream)));
    this.OnRunWorkerCompleted(backgroundWorker, uploadFile);
  }

  public void Update(List<ExcelMapping> excelMappings, bool uploadFile, string databaseTableName)
  {
    this.UpdateErrors = new List<ExcelMappingError>();
    if (!File.Exists(this.FullPath))
      return;
    string tempFile = Path.Combine(MGATempFolder.MGATempRandomFolderPath, Path.GetFileName(this.FullPath));
    File.Copy(this.FullPath, tempFile);
    byte[] bytes = FileReader.ReadAllBytes(tempFile);
    bytes = new ZipUtility().CompressStreamToNewZipStream(bytes, Path.GetFileName(this._undecoratedFileName));
    if (bytes == null || bytes.Length == 0)
      return;
    BackgroundWorker backgroundWorker = new BackgroundWorker()
    {
      WorkerReportsProgress = true,
      WorkerSupportsCancellation = true
    };
    backgroundWorker.DoWork += (DoWorkEventHandler) ((s, e) => this.OnDoWork(backgroundWorker, excelMappings, uploadFile, databaseTableName, bytes, (Func<Workbook>) (() => new Workbook(tempFile))));
    backgroundWorker.ProgressChanged += (ProgressChangedEventHandler) ((s, e) => this.OnProgressChanged(backgroundWorker, e));
    backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((s, e) => this.OnRunWorkerCompleted(backgroundWorker, uploadFile));
    backgroundWorker.RunWorkerAsync();
    this.IsWorking = true;
  }

  private void OnRunWorkerCompleted(BackgroundWorker backgroundWorker, bool uploadFile)
  {
    if (!uploadFile)
      this.UpdateErrors.Clear();
    this.OnPropertyChanged("UpdateErrors");
    this.OnPropertyChanged("HasUpdateErrors");
    if (!backgroundWorker.CancellationPending)
    {
      this.Status = string.Empty;
      this.IsDownloading = false;
    }
    this.IsWorking = false;
    backgroundWorker.Dispose();
    this.AutoApplyFeesAndRefreshPolicyDetail();
  }

  private void OnProgressChanged(BackgroundWorker backgroundWorker, ProgressChangedEventArgs e)
  {
    if (this._cancelDownload && backgroundWorker.CancellationPending)
      backgroundWorker.CancelAsync();
    else if (e.UserState is Exception userState)
    {
      MGASystems.Common.ThreadingFunctions.MessageBox.Show(userState.Message, "An error occurred during the file update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      string upperInvariant = ((string) e.UserState).ToUpperInvariant();
      this.IsDownloading = upperInvariant.Contains("DOWNLOAD") || upperInvariant.Contains("UPLOAD");
      this.Status = (string) e.UserState;
      this.PercentDownloaded = e.ProgressPercentage;
    }
  }

  private void OnDoWork(
    BackgroundWorker backgroundWorker,
    List<ExcelMapping> excelMappings,
    bool uploadFile,
    string databaseTableName,
    byte[] compressedBytes,
    Func<Workbook> workBookCreateFunc)
  {
    if (uploadFile)
      this.UploadExcelFile(compressedBytes, backgroundWorker);
    backgroundWorker.ReportProgress(0, (object) "Uploading Cell Values");
    Workbook workbook = (Workbook) null;
    try
    {
      try
      {
        backgroundWorker.ReportProgress(99, (object) "Opening Sheet For Parse (may take awhile on large sheets)");
        workbook = workBookCreateFunc();
        backgroundWorker.ReportProgress(100, (object) "Opened Sheet For Parse");
      }
      catch (Exception ex1)
      {
        // ISSUE: explicit non-virtual call
        for (Exception ex2 = ex1; ex2 != null && __nonvirtual (ex2.InnerException)?.StackTrace != null; ex2 = ex2.InnerException)
        {
          ErrorHandler.SilentHandleError(ex2);
          MGASystems.Common.ThreadingFunctions.MessageBox.Show(ex2.Message, ex2.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        throw;
      }
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Excel.Import.CalculateBeforeParse"))
      {
        try
        {
          backgroundWorker.ReportProgress(100, (object) "Running calculate on workbook before parsing...");
          workbook.CalculateFormula();
          backgroundWorker.ReportProgress(100, (object) "Calculation complete. Beginning parse.");
        }
        catch (Exception ex)
        {
          ErrorHandler.SilentHandleError(ex);
        }
      }
      this.UploadAdditionalData(this.RaterId, this.QuoteGuid, workbook);
      this.UploadAdditionalData(this.RaterId, this.QuoteGuid, workbook, backgroundWorker, uploadFile);
      this.UploadExtensionData(workbook, backgroundWorker, uploadFile);
      this.UploadSchedules(workbook, backgroundWorker, uploadFile);
      Dictionary<string, string> dictionary;
      try
      {
        dictionary = ((IEnumerable) workbook.Worksheets).Cast<Worksheet>().ToDictionary<Worksheet, string, string>((System.Func<Worksheet, string>) (ws => ws.Name.Replace(" ", "")), (System.Func<Worksheet, string>) (ws => ws.Name), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      }
      catch
      {
        dictionary = ((IEnumerable) workbook.Worksheets).Cast<Worksheet>().ToDictionary<Worksheet, string, string>((System.Func<Worksheet, string>) (ws => ws.Name), (System.Func<Worksheet, string>) (ws => ws.Name), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      }
      backgroundWorker.ReportProgress(100, (object) "Uploading Mapped Values");
      Dictionary<string, object> mappedValues = this.MapValuesFromSheet(excelMappings, backgroundWorker, workbook, dictionary);
      this.UploadMappedValues(uploadFile, databaseTableName, mappedValues, false);
      backgroundWorker.ReportProgress(100, (object) "Post processing, please wait");
      this.UpdateComplete(this.RaterId, this.QuoteGuid, workbook, backgroundWorker, uploadFile);
      backgroundWorker.ReportProgress(100, (object) "Upload Completed");
    }
    catch (Exception ex3)
    {
      for (Exception ex4 = ex3; ex4 != null; ex4 = ex4.InnerException)
      {
        ErrorHandler.SilentHandleError(ex4);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show(ex4.Message, ex4.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      throw;
    }
    finally
    {
      workbook?.Dispose();
    }
  }

  private void UploadSchedules(
    Workbook workbook,
    BackgroundWorker backgroundWorker,
    bool uploadFile)
  {
    foreach (var data in DefaultDatabase.ExecuteDataTable("ExcelRating_FetchUploadSchedules", new object[2]
    {
      (object) "@RaterFactorSetGuid",
      (object) this.FactorSetGuid
    }).AsEnumerable().Select(row => new
    {
      RaterID = row.Field<int>("ScheduleRaterID"),
      FactorSetGuid = row.Field<Guid>("ScheduleFactorSetGuid"),
      RowStart = row.Field<int>("RowStart"),
      RowEnd = row.Field<int>("RowEnd"),
      SetinelColumn = row.Field<int>("SetinelColumn"),
      NullSetinelRetVal = row.Field<string>("NullSetinelRetVal")
    }))
    {
      var schedule = data;
      this.UpdateRange(backgroundWorker, workbook, schedule.RaterID, uploadFile, schedule.RowStart, schedule.RowEnd, (Func<Worksheet, int, string>) ((sheet, rowIndex) => !string.IsNullOrWhiteSpace(sheet.Cells[rowIndex - 1, schedule.SetinelColumn].StringValue) ? "" : schedule.NullSetinelRetVal));
    }
  }

  private void AutoApplyFeesAndRefreshPolicyDetail()
  {
    Quote quote = ObjectFactory.Instance.CreateObjectAs<Quote>((object) this.QuoteGuid);
    foreach (Guid quoteOptionGuid in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid FROM tblQuoteOptions WITH (NOLOCK) WHERE QuoteGuid=@QG", new object[2]
    {
      (object) "@QG",
      (object) this.QuoteGuid
    }).AsEnumerable().Select<DataRow, Guid>((System.Func<DataRow, Guid>) (row => row.Field<Guid>("QuoteOptionGuid"))))
      quote.AutoApplyFees(quoteOptionGuid);
    foreach (frmPolicyDetail frmPolicyDetail in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmPolicyDetail>().Where<frmPolicyDetail>((System.Func<frmPolicyDetail, bool>) (policyDetail => policyDetail.ControlNumber == quote.ControlNo)))
      frmPolicyDetail.RefreshPolicyData();
  }

  private void UploadMappedValues(
    bool uploadFile,
    string databaseTableName,
    Dictionary<string, object> mappedValues,
    bool insertOnly)
  {
    if (this.UpdateErrors.Count != 0 && uploadFile || mappedValues.Count <= 0)
      return;
    StringBuilder query = new StringBuilder();
    int num = 0;
    if (!insertOnly)
      num = (int) DefaultDatabase.ExecuteScalar(CommandType.Text, string.Format((IFormatProvider) CultureInfo.InvariantCulture, "select count(*) from {0} where quoteGuid = @quoteGuid", (object) databaseTableName), new object[2]
      {
        (object) "@quoteguid",
        (object) this.QuoteGuid
      });
    if (!insertOnly && num > 0)
    {
      query.Append("update ");
      query.Append(databaseTableName);
      query.Append(" set ");
      bool flag = true;
      foreach (KeyValuePair<string, object> mappedValue in mappedValues)
      {
        if (flag)
          flag = false;
        else
          query.Append(", ");
        query.Append($"[{mappedValue.Key}]");
        query.Append(" = @");
        query.Append(mappedValue.Key.Replace("(", "").Replace(")", ""));
      }
      query.Append(" where quoteGuid = @quoteGuid");
    }
    else
    {
      query.Append("insert into ");
      query.Append(databaseTableName);
      query.Append(" (QuoteGuid");
      foreach (KeyValuePair<string, object> mappedValue in mappedValues)
      {
        query.Append(", ");
        query.Append($"[{mappedValue.Key}]");
      }
      query.Append(" ) values ( @quoteGuid");
      foreach (KeyValuePair<string, object> mappedValue in mappedValues)
      {
        query.Append(", ");
        query.Append($" @{mappedValue.Key.Replace("(", "").Replace(")", "")}");
      }
      query.Append(" ) ");
    }
    if (query.Length <= 0)
      return;
    Dictionary<string, DbParameter> parameters = new Dictionary<string, DbParameter>();
    foreach (KeyValuePair<string, object> mappedValue in mappedValues)
    {
      string key = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "@{0}", (object) mappedValue.Key.Replace("(", "").Replace(")", ""));
      parameters.Add(key, DefaultDatabase.CreateParameter(ParameterDirection.Input, key, mappedValue.Value));
    }
    parameters.Add("[@quoteGuid]", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@quoteGuid", (object) this.QuoteGuid));
    ExcelFile.InsertExcelRowDataToDb(databaseTableName, query, parameters);
  }

  private static string GetWorksheetName(
    Workbook workbook,
    ExcelMapping mapping,
    Dictionary<string, string> worksheetMappings)
  {
    string key = mapping.Cell.Contains("!") ? mapping.Cell.Substring(0, mapping.Cell.IndexOf("!")) : "_firstWorkSheet_";
    string worksheetName;
    if (key == "_firstWorkSheet_" && workbook.Worksheets.Count > 0)
    {
      worksheetName = workbook.Worksheets[0].Name;
    }
    else
    {
      string str;
      if (!worksheetMappings.TryGetValue(key, out str))
      {
        if (!worksheetMappings.TryGetValue(key.Replace(" ", ""), out str))
          str = key;
        worksheetMappings.Add(key, str);
      }
      worksheetName = str;
    }
    return worksheetName;
  }

  private Dictionary<string, object> MapValuesFromSheet(
    List<ExcelMapping> excelMappings,
    BackgroundWorker backgroundWorker,
    Workbook workbook,
    Dictionary<string, string> worksheetMappings,
    int? rangeRowIndex = null)
  {
    Dictionary<string, object> dictionary = new Dictionary<string, object>();
    foreach (ExcelMapping excelMapping in excelMappings)
    {
      string str1 = excelMapping.Cell.Contains("!") ? excelMapping.Cell.Substring(excelMapping.Cell.IndexOf("!") + 1) : excelMapping.Cell;
      if (rangeRowIndex.HasValue)
      {
        Match match = Regex.Match(str1, "\\d");
        if (match.Success)
        {
          int index = match.Index;
          string str2 = str1.Substring(0, index);
          if (str1.Substring(index) != "0")
            this.UpdateErrors.Add(new ExcelMappingError(str1, "When defining a Range cell, the row index of the mapping must always be zero"));
          else
            str1 = str2 + rangeRowIndex.ToString();
        }
        else
          this.UpdateErrors.Add(new ExcelMappingError(str1, "When defining a Range cell, the row index of the mapping must always be zero and not empty"));
      }
      string worksheetName = ExcelFile.GetWorksheetName(workbook, excelMapping, worksheetMappings);
      object translatedValue = (object) null;
      string error;
      try
      {
        if (!this.ValidateWorksheetExists(workbook, worksheetName))
          continue;
      }
      catch (Exception ex)
      {
        error = $"Worksheet {worksheetName} specified in the mappings for this had the following problem {ex.Message}.";
        this.UpdateErrors.Add(new ExcelMappingError(str1, error));
        backgroundWorker?.ReportProgress(100, (object) string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Error Uploading {0}", (object) error));
      }
      try
      {
        if (this.UpdateErrors.Count == 0)
        {
          if (workbook.Worksheets[worksheetName].Cells[str1] == null)
          {
            error = $"Cell {str1} on Worksheet {worksheetName} specified in the mappings for this sheet does not exist on this excel file";
            this.UpdateErrors.Add(new ExcelMappingError(str1, error));
            backgroundWorker?.ReportProgress(100, (object) string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Error Uploading {0}", (object) error));
          }
        }
      }
      catch (Exception ex)
      {
        error = $"Cell {str1} on Worksheet {worksheetName} specified in the mappings for this sheet had the following problem {ex.Message}.";
        this.UpdateErrors.Add(new ExcelMappingError(str1, error));
        backgroundWorker?.ReportProgress(100, (object) string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Error Uploading {0}", (object) error));
      }
      if (this.UpdateErrors.Count == 0)
      {
        if (workbook.Worksheets[worksheetName].Cells[str1].Value == null)
        {
          if (excelMapping.DatabaseType == "System.Decimal")
            dictionary.Add(excelMapping.DatabaseField, (object) SqlDecimal.Null);
          else
            dictionary.Add(excelMapping.DatabaseField, (object) DBNull.Value);
        }
        else if (this.TranslateValue(workbook.Worksheets[worksheetName], excelMapping, str1, out translatedValue, out error))
        {
          dictionary.Add(excelMapping.DatabaseField, translatedValue);
        }
        else
        {
          this.UpdateErrors.Add(new ExcelMappingError(str1, error));
          backgroundWorker?.ReportProgress(100, (object) string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Error Uploading {0}", (object) error));
        }
      }
    }
    return dictionary;
  }

  private static void InsertExcelRowDataToDb(
    string databaseTableName,
    StringBuilder query,
    Dictionary<string, DbParameter> parameters)
  {
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, query.ToString(), (CommandArgumentType) 2, new object[1]
      {
        (object) parameters
      });
    }
    catch (Exception ex)
    {
      string str1 = "db error";
      if (ex.Message.Contains("Cannot convert a char value to money. The char value has incorrect syntax."))
      {
        using (SqlConnection connection = DefaultDatabase.CreateConnection())
        {
          connection.Open();
          using (SqlCommand sqlCommand = new SqlCommand("select top 1 * from " + databaseTableName, connection))
          {
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.KeyInfo))
            {
              DataTable schemaTable = sqlDataReader.GetSchemaTable();
              foreach (KeyValuePair<string, DbParameter> parameter in parameters)
              {
                if ((parameter.Value.DbType == DbType.AnsiString || parameter.Value.DbType == DbType.AnsiStringFixedLength || parameter.Value.DbType == DbType.String || parameter.Value.DbType == DbType.StringFixedLength) && !string.IsNullOrEmpty(parameter.Value.Value as string))
                {
                  DataRow[] dataRowArray = schemaTable.Select($"ColumnName = '{parameter.Key.Replace("@", "")}'");
                  if (dataRowArray.Length == 1)
                  {
                    string str2 = dataRowArray[0]["DataType"].ToString();
                    if (!str2.Contains("String") && CurrentUser.IsMGADeveloper)
                      str1 = $"This mapping has probably changed from money to string, please change it back to money or change the DB Column {parameter.Key.Replace("@", "")} from {str2} to varchar(text). Just be aware that if you change the db column to string you will not be able to do any premium math on it";
                  }
                }
              }
            }
          }
        }
      }
      else if (ex.Message.Contains("SqlDateTime overflow"))
      {
        using (SqlConnection connection = DefaultDatabase.CreateConnection())
        {
          connection.Open();
          using (SqlCommand sqlCommand = new SqlCommand("select top 1 * from " + databaseTableName, connection))
          {
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.KeyInfo))
            {
              DataTable schemaTable = sqlDataReader.GetSchemaTable();
              foreach (KeyValuePair<string, DbParameter> parameter in parameters)
              {
                if (parameter.Value.DbType == DbType.Date || parameter.Value.DbType == DbType.DateTime || parameter.Value.DbType == DbType.DateTime2)
                {
                  string str3 = parameter.Value.Value as string;
                  if (!string.IsNullOrEmpty(str3))
                  {
                    DataRow[] dataRowArray = schemaTable.Select($"ColumnName = '{parameter.Key.Replace("@", "")}'");
                    if (dataRowArray.Length == 1)
                    {
                      int num = (int) dataRowArray[0]["ColumnSize"];
                      if (str3.Length >= num && CurrentUser.IsMGADeveloper)
                        str1 = $"Please increase the size of column {parameter.Key.Replace("@", "")} from {num} to {str3.Length}";
                    }
                  }
                }
              }
            }
          }
        }
      }
      else if (ex.Message.Contains("truncated"))
      {
        using (SqlConnection connection = DefaultDatabase.CreateConnection())
        {
          connection.Open();
          using (SqlCommand sqlCommand = new SqlCommand("select top 1 * from " + databaseTableName, connection))
          {
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.KeyInfo))
            {
              DataTable schemaTable = sqlDataReader.GetSchemaTable();
              foreach (KeyValuePair<string, DbParameter> parameter in parameters)
              {
                if (parameter.Value.DbType == DbType.AnsiString)
                {
                  string str4 = parameter.Value.Value as string;
                  if (!string.IsNullOrEmpty(str4))
                  {
                    DataRow[] dataRowArray = schemaTable.Select($"ColumnName = '{parameter.Key.Replace("@", "")}'");
                    if (dataRowArray.Length == 1)
                    {
                      int num = (int) dataRowArray[0]["ColumnSize"];
                      if (str4.Length >= num && CurrentUser.IsMGADeveloper)
                        str1 = $"Please increase the size of column {parameter.Key.Replace("@", "")} from {num} to {str4.Length}";
                    }
                  }
                }
              }
            }
          }
        }
      }
      MGASystems.Common.ThreadingFunctions.MessageBox.Show($"{ex.Message} {str1}", "Please notify technical support", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      throw;
    }
  }

  public void UploadExcelFile(byte[] bytes, BackgroundWorker backgroundWorker)
  {
    if (bytes == null || bytes.Length == 0)
      throw new ArgumentNullException(nameof (bytes));
    switch (DatabaseInformation.ExcelFileStoreBinarySerializationType)
    {
      case "image":
        this.UploadExcelFileImage(bytes, backgroundWorker);
        break;
      case "varbinary":
        this.UploadExcelFileVarbinary(bytes, backgroundWorker);
        break;
      default:
        throw new NotImplementedException();
    }
  }

  private void UploadExcelFileVarbinary(byte[] bytes, BackgroundWorker backgroundWorker)
  {
    int num1 = 0;
    int percentProgress1 = 0;
    using (SqlConnection connection = DefaultDatabase.CreateConnection())
    {
      connection.Open();
      using (SqlTransaction transaction = connection.BeginTransaction())
      {
        try
        {
          SqlCommand sqlCommand1 = new SqlCommand("update tblExcelRating_ExcelFileStore set CompressedExcelSheet = @compressedExcelSheet where QuoteGuid = @QuoteGuid and RaterID = @raterID", connection, transaction);
          sqlCommand1.CommandTimeout = int.MaxValue;
          using (SqlCommand sqlCommand2 = sqlCommand1)
          {
            if (!this.WorkBookExistsInDatabase)
              sqlCommand2.CommandText = "insert into tblExcelRating_ExcelFileStore (QuoteGuid, CompressedExcelSheet, RaterID) values (@quoteGuid, @compressedExcelSheet, @raterID)";
            sqlCommand2.Parameters.AddWithValue("@quoteGuid", (object) this.QuoteGuid);
            sqlCommand2.Parameters.AddWithValue("@raterID", (object) this.RaterId);
            sqlCommand2.Parameters.AddWithValue("@compressedExcelSheet", (object) Array.Empty<byte>());
            sqlCommand2.ExecuteNonQuery();
            backgroundWorker?.ReportProgress(percentProgress1, (object) "Please wait while the file is uploaded to the server.");
            float num2 = 100f / (float) bytes.Length;
            sqlCommand2.CommandText = "UPDATE tblExcelRating_ExcelFileStore SET [CompressedExcelSheet].WRITE(@data, @offset, @len) WHERE quoteGuid = @quoteGuid and RaterID = @RaterID";
            sqlCommand2.Parameters.Clear();
            sqlCommand2.Parameters.AddWithValue("@quoteGuid", (object) this.QuoteGuid);
            sqlCommand2.Parameters.AddWithValue("@raterID", (object) this.RaterId);
            SqlParameter sqlParameter1 = sqlCommand2.Parameters.Add("@data", SqlDbType.VarBinary);
            SqlParameter sqlParameter2 = sqlCommand2.Parameters.Add("@offset", SqlDbType.BigInt);
            SqlParameter sqlParameter3 = sqlCommand2.Parameters.Add("@len", SqlDbType.BigInt);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
              byte[] buffer = new byte[UploadPacketSize.GetBufferLength(bytes.Length)];
              int num3 = 0;
              int num4 = memoryStream.Read(buffer, 0, buffer.Length);
              while (num4 > 0)
              {
                sqlParameter1.Value = (object) buffer;
                sqlParameter2.Value = (object) num3;
                sqlParameter3.Value = (object) num4;
                sqlCommand2.ExecuteNonQuery();
                num3 += num4;
                num4 = memoryStream.Read(buffer, 0, buffer.Length);
                int percentProgress2 = (int) ((double) num3 * (double) num2);
                if (percentProgress2 != num1)
                {
                  num1 = percentProgress2;
                  backgroundWorker?.ReportProgress(percentProgress2, (object) "Please wait while the file is uploaded to the server.");
                }
              }
              backgroundWorker?.ReportProgress(90, (object) "File upload complete");
              this.WorkBookExistsInDatabase = true;
            }
          }
          transaction.Commit();
        }
        catch (Exception ex)
        {
          backgroundWorker?.ReportProgress(0, (object) ex);
          ErrorHandler.SilentHandleError(ex);
          transaction.Rollback();
          throw;
        }
      }
    }
  }

  private void UploadExcelFileImage(byte[] bytes, BackgroundWorker backgroundWorker)
  {
    int num1 = 0;
    int percentProgress1 = 0;
    using (SqlConnection connection = DefaultDatabase.CreateConnection())
    {
      connection.Open();
      using (SqlTransaction transaction = connection.BeginTransaction())
      {
        try
        {
          SqlCommand sqlCommand1 = new SqlCommand("update tblExcelRating_ExcelFileStore set CompressedExcelSheet = @compressedExcelSheet where QuoteGuid = @QuoteGuid and RaterID = @raterID", connection, transaction);
          sqlCommand1.CommandTimeout = int.MaxValue;
          using (SqlCommand sqlCommand2 = sqlCommand1)
          {
            if (!this.WorkBookExistsInDatabase)
              sqlCommand2.CommandText = "insert into tblExcelRating_ExcelFileStore (QuoteGuid, CompressedExcelSheet, RaterID) values (@quoteGuid, @compressedExcelSheet, @raterID)";
            sqlCommand2.Parameters.AddWithValue("@quoteGuid", (object) this.QuoteGuid);
            sqlCommand2.Parameters.AddWithValue("@raterID", (object) this.RaterId);
            sqlCommand2.Parameters.AddWithValue("@compressedExcelSheet", (object) Array.Empty<byte>());
            sqlCommand2.ExecuteNonQuery();
            sqlCommand2.CommandText = "SELECT TEXTPTR(CompressedExcelSheet) FROM tblExcelRating_ExcelFileStore WHERE quoteGuid = @quoteGuid and RaterID = @RaterID";
            float num2 = 100f / (float) bytes.Length;
            backgroundWorker?.ReportProgress(percentProgress1, (object) "Please wait while the file is uploaded to the server.");
            int bufferLength = UploadPacketSize.GetBufferLength(bytes.Length);
            byte[] numArray1 = (byte[]) sqlCommand2.ExecuteScalar();
            sqlCommand2.Parameters.Clear();
            sqlCommand2.CommandText = "UPDATETEXT tblExcelRating_ExcelFileStore.CompressedExcelSheet @Pointer @Offset 0 @Bytes";
            sqlCommand2.Parameters.Add("@Pointer", SqlDbType.Binary, 16 /*0x10*/);
            sqlCommand2.Parameters["@Pointer"].Value = (object) numArray1;
            sqlCommand2.Parameters.Add("@Bytes", SqlDbType.Binary, bufferLength);
            sqlCommand2.Parameters.Add("@Offset", SqlDbType.Int);
            sqlCommand2.Parameters["@Offset"].Value = (object) 0;
            using (MemoryStream input = new MemoryStream(bytes))
            {
              using (BinaryReader binaryReader = new BinaryReader((Stream) input))
              {
                byte[] numArray2 = binaryReader.ReadBytes(bufferLength);
                int num3 = 0;
                while (numArray2.Length != 0)
                {
                  sqlCommand2.Parameters["@Bytes"].Value = (object) numArray2;
                  sqlCommand2.Parameters["@Bytes"].Size = numArray2.Length;
                  sqlCommand2.ExecuteNonQuery();
                  num3 += bufferLength;
                  sqlCommand2.Parameters["@Offset"].Value = (object) num3;
                  numArray2 = binaryReader.ReadBytes(bufferLength);
                  int percentProgress2 = (int) ((double) num3 * (double) num2);
                  if (percentProgress2 != num1)
                  {
                    num1 = percentProgress2;
                    backgroundWorker?.ReportProgress(percentProgress2, (object) "Please wait while the file is uploaded to the server.");
                  }
                }
                backgroundWorker?.ReportProgress(90, (object) "File upload complete");
                this.WorkBookExistsInDatabase = true;
              }
            }
          }
          transaction.Commit();
        }
        catch (Exception ex)
        {
          backgroundWorker?.ReportProgress(0, (object) ex);
          ErrorHandler.SilentHandleError(ex);
          transaction.Rollback();
          throw;
        }
      }
    }
  }

  protected virtual bool TranslateValue(
    Worksheet workSheet,
    ExcelMapping mapping,
    string cell,
    out object translatedValue,
    out string error)
  {
    return mapping.TranslateValue(workSheet.Cells[cell].Value, out translatedValue, out error);
  }

  public bool HasUpdateErrors => this.UpdateErrors != null && this.UpdateErrors.Count > 0;

  public void Retrieve()
  {
    string str = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}{1}\\", (object) ExcelFile.localApplicationData, (object) this.FactorSetGuid.ToString());
    this.Status = "Checking Template";
    if (!Directory.Exists(str))
      Directory.CreateDirectory(str);
    string[] files = Directory.GetFiles(str);
    if (!Directory.Exists(str))
      throw new InvalidOperationException("Problem occurred creating template directory");
    if (this.DownloadWorkBook(this.QuoteGuid, this.RaterId))
      return;
    if (files.Length == 1)
    {
      string templateFileName = files[0];
      this.IsDownloading = true;
      this.CopyExcelFileForUse(templateFileName);
      this.IsDownloading = false;
      this.OnPropertyChanged("FullPath");
      this.Status = string.Empty;
    }
    else
    {
      if (files.Length > 1)
        throw new InvalidOperationException("There can be only one template file in a template directory");
      this.DownloadTemplate(str, this.FactorSetGuid);
    }
  }

  private bool DownloadWorkBook(Guid quoteGuid, int raterId)
  {
    int num = (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "select count(*) from tblExcelRating_ExcelFileStore where QuoteGuid = @QuoteGuid and RaterID = @RaterID", new object[4]
    {
      (object) "@quoteGuid",
      (object) quoteGuid,
      (object) "@RaterID",
      (object) raterId
    });
    if (num > 1)
    {
      DefaultDatabase.ExecuteNonQuery("ExcelRating_ScrubInvalidSheets", new object[4]
      {
        (object) "@quoteGuid",
        (object) quoteGuid,
        (object) "@RaterID",
        (object) raterId
      });
      num = (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "select count(*) from tblExcelRating_ExcelFileStore where QuoteGuid = @QuoteGuid and RaterID = @RaterID", new object[4]
      {
        (object) "@quoteGuid",
        (object) quoteGuid,
        (object) "@RaterID",
        (object) raterId
      });
    }
    if (num != 1)
      return false;
    this.DownloadExcelFile("select datalength(compressedExcelSheet), compressedExcelSheet from tblExcelRating_ExcelFileStore where QuoteGuid = @QuoteGuid and RaterID = @RaterID", MGATempFolder.MGATempRandomFolderPath, this.FactorSetGuid, quoteGuid, raterId);
    this.WorkBookExistsInDatabase = true;
    return true;
  }

  private void DownloadTemplate(string templateDirectory, Guid factorSetGuid)
  {
    this.DownloadExcelFile("select datalength(compressedExcelSheet), compressedExcelSheet from tblExcelRating_FactorSets where factorSetGuid = @factorSetGuid", templateDirectory, factorSetGuid, this.QuoteGuid, this.RaterId);
  }

  private void DownloadExcelFile(
    string query,
    string downloadDirectory,
    Guid factorSetGuid,
    Guid quoteGuid,
    int raterId)
  {
    BackgroundWorker backgroundWorker = new BackgroundWorker()
    {
      WorkerReportsProgress = true,
      WorkerSupportsCancellation = true
    };
    backgroundWorker.DoWork += (DoWorkEventHandler) ((s, e) =>
    {
      int num1 = 0;
      long bytesRead = 0;
      long startIndex = 0;
      bool flag = false;
      long num2 = 0;
      int percentProgress1 = 0;
      string templateFileName;
      using (SqlConnection connection = DefaultDatabase.CreateConnection())
      {
        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
        {
          sqlCommand.CommandTimeout = int.MaxValue;
          sqlCommand.Parameters.AddWithValue("@factorSetGuid", (object) factorSetGuid);
          sqlCommand.Parameters.AddWithValue("@quoteGuid", (object) quoteGuid);
          sqlCommand.Parameters.AddWithValue("@raterID", (object) raterId);
          connection.Open();
          using (SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SequentialAccess))
          {
            reader.Read();
            int int32 = Convert.ToInt32(reader[0]);
            float num3 = 100f / (float) int32;
            backgroundWorker.ReportProgress(percentProgress1, (object) "Please wait while the file is downloaded from the server.");
            int bufferSize = int32 < 1000 ? int32 : (int32 <= 5000 ? 1024 /*0x0400*/ : (int32 <= 10000 ? 2048 /*0x0800*/ : (int32 <= 50000 ? 4096 /*0x1000*/ : 7168)));
            byte[] outByte = new byte[bufferSize];
            using (MemoryStream compressedMemoryStream = new MemoryStream(int32))
            {
              while ((num2 == 0L || bytesRead == (long) bufferSize) && !flag && ExcelFile.ReadBytesFromDatabase((IDataReader) reader, out bytesRead, ref outByte, startIndex, bufferSize))
              {
                compressedMemoryStream.Write(outByte, 0, outByte.Length);
                if (backgroundWorker.CancellationPending)
                  break;
                startIndex += (long) bufferSize;
                num2 += bytesRead;
                int percentProgress2 = (int) ((double) num2 * (double) num3);
                if (percentProgress2 != num1)
                {
                  num1 = percentProgress2;
                  backgroundWorker.ReportProgress(percentProgress2, (object) "Please wait while the file is downloaded from the server.");
                }
              }
              connection.Close();
              if (bytesRead > 0L)
              {
                compressedMemoryStream.Write(outByte, 0, (int) bytesRead);
                long num4 = num2 + bytesRead;
                backgroundWorker.ReportProgress(100, (object) "File download complete");
              }
              templateFileName = ExcelFile.WriteTemplateBytes(compressedMemoryStream, downloadDirectory);
            }
          }
        }
      }
      backgroundWorker.ReportProgress(0, (object) "");
      if (backgroundWorker.CancellationPending)
        return;
      this.CopyExcelFileForUse(templateFileName);
    });
    backgroundWorker.ProgressChanged += (ProgressChangedEventHandler) ((s, e) =>
    {
      if (this._cancelDownload && backgroundWorker.CancellationPending)
      {
        backgroundWorker.CancelAsync();
      }
      else
      {
        string userState = (string) e.UserState;
        this.IsDownloading = userState.Contains("download");
        this.Status = userState;
        this.PercentDownloaded = e.ProgressPercentage;
      }
    });
    backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((s, e) =>
    {
      if (!backgroundWorker.CancellationPending)
      {
        this.Status = string.Empty;
        this.IsDownloading = false;
        this.OnPropertyChanged("FullPath");
      }
      backgroundWorker.Dispose();
    });
    backgroundWorker.RunWorkerAsync();
  }

  private static bool ReadBytesFromDatabase(
    IDataReader reader,
    out long bytesRead,
    ref byte[] outByte,
    long startIndex,
    int bufferSize)
  {
    bool flag = false;
    int num = 0;
    bytesRead = 0L;
    while (!flag)
    {
      if (!reader.IsClosed)
      {
        try
        {
          if (!reader.IsClosed)
          {
            bytesRead = reader.GetBytes(1, startIndex, outByte, 0, bufferSize);
            flag = true;
          }
          else
            break;
        }
        catch (SqlException ex)
        {
          if (Utility.IsRetryableException((Exception) ex) && num < 5)
          {
            Thread.Sleep(1000);
            ++num;
          }
          else
            throw;
        }
      }
      else
        break;
    }
    return flag;
  }

  private static string WriteTemplateBytes(
    MemoryStream compressedMemoryStream,
    string templateDirectory)
  {
    ZipUtility zipUtility = new ZipUtility();
    string[] fileNames = (string[]) null;
    byte[][] fileStreams = (byte[][]) null;
    byte[] array = compressedMemoryStream.ToArray();
    try
    {
      zipUtility.ExtractFilesFromZipArchive(array, out fileNames, out fileStreams);
    }
    catch (InvalidDataException ex) when (ZipUtility.CanTryRepairArchive((Exception) ex) && ZipUtility.CheckWinRarInstalled())
    {
      if (System.Windows.MessageBox.Show("Press Yes to attempt to repair the Excel file.", "Repair Excel File", MessageBoxButton.YesNo, MessageBoxImage.Hand) == MessageBoxResult.Yes)
      {
        byte[] zipArchiveBytes = ZipUtility.RepairArchive(array);
        zipUtility.ExtractFilesFromZipArchive(zipArchiveBytes, out fileNames, out fileStreams);
        if (fileNames != null)
        {
          if (fileStreams != null)
            goto label_7;
        }
        throw;
      }
    }
label_7:
    string path = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}{1}", (object) templateDirectory, (object) Path.GetFileName(fileNames[0]));
    using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
      fileStream.Write(fileStreams[0], 0, fileStreams[0].Length);
    return path;
  }
}
