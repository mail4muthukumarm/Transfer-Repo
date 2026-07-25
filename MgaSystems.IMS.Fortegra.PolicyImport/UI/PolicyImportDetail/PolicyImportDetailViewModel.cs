// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.UI.PolicyImportDetail.PolicyImportDetailViewModel
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data.Binding;
using MgaSystems.Ims.Fortegra.PolicyImport.Data;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using MgaSystems.Ims.Fortegra.PolicyImport.UI.PreparedXMLViewer;
using MgaSystems.Ims.Fortegra.PolicyImport.UI.PreprocessErrorViewer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.UI.PolicyImportDetail;

public abstract class PolicyImportDetailViewModel : BindingObject
{
  private CancellationTokenSource _ctsImportProgressMonitor;
  private readonly IWinMsgBoxService msgBoxSvc;

  [NotificationProperty]
  public virtual PolicyImportDataManager PolicyImportDataManager { get; set; }

  [NotificationProperty]
  public virtual string ImportFilePath { get; set; }

  [NotificationProperty]
  public virtual int ExcelToXMLConvertRowsTotal { get; set; }

  [NotificationProperty]
  public virtual int ExcelToXMLConvertRowsProcessed { get; set; }

  [NotificationProperty]
  public virtual string ImportXMLAsString { get; set; }

  [NotificationProperty]
  public virtual bool PreviewBeforeUploading { get; set; }

  [NotificationProperty]
  public virtual Visibility ImportStep1Visibility { get; set; }

  [NotificationProperty]
  public virtual Visibility ImportStep1VisibilityComplete { get; set; }

  [NotificationProperty]
  public virtual Visibility ImportStep2ChoiceVisible { get; set; }

  [NotificationProperty]
  public virtual Visibility ImportStep2Visibility { get; set; }

  [NotificationProperty]
  public virtual Visibility ImportStep2ErrorVisibility { get; set; }

  [NotificationProperty]
  public virtual bool pgImportingFilesIsIndeterminate { get; set; }

  [NotificationProperty]
  public virtual int pgImportingFilesValue { get; set; }

  [NotificationProperty]
  public virtual BulkObservableCollection<ExcelToXMLVersion> ExcelToXMLVersionFilteredList { get; set; } = new BulkObservableCollection<ExcelToXMLVersion>();

  [NotificationProperty]
  public virtual ExcelToXMLVersion SelectedExcelToXMLVersion { get; set; }

  [NotificationProperty]
  public virtual BulkObservableCollection<ImportSourceProducerLocationItem> ImportSourceProducerLocationFilteredList { get; set; } = new BulkObservableCollection<ImportSourceProducerLocationItem>();

  [NotificationProperty]
  public virtual ImportSourceProducerLocationItem SelectedImportSourceProducerLocation { get; set; }

  [NotificationProperty]
  public virtual BulkObservableCollection<ImportSourceImportVersionItem> ImportSourceImportVersionFilteredList { get; set; } = new BulkObservableCollection<ImportSourceImportVersionItem>();

  [NotificationProperty]
  public virtual ImportSourceImportVersionItem SelectedImportSourceImportVersion { get; set; }

  [NotificationProperty]
  public virtual List<int> CurrentlyImportingFilesList { get; set; } = new List<int>();

  [NotificationProperty]
  public virtual int CurrentlyImportingNumberOfFilesMax { get; set; }

  [NotificationProperty]
  public virtual string CurrentlyImportingFilesProgress { get; set; }

  public virtual ImportSource CurrentImportSource { get; private set; }

  public virtual bool NewImportMode { get; private set; }

  public virtual List<string> ImportProgress { get; private set; }

  internal static PolicyImportDetailViewModel Create(
    IWinMsgBoxService msgBoxService,
    PolicyImportDataManager pidm,
    ImportSource importSource,
    bool newImportMode)
  {
    return NotifyProxyTypeManager.Allocate<PolicyImportDetailViewModel>(new object[5]
    {
      (object) msgBoxService,
      (object) pidm,
      (object) importSource,
      (object) newImportMode,
      (object) 0
    });
  }

  internal static PolicyImportDetailViewModel Create(
    IWinMsgBoxService msgBoxService,
    PolicyImportDataManager pidm,
    ImportSource importSource,
    bool newImportMode,
    int importLogID)
  {
    return NotifyProxyTypeManager.Allocate<PolicyImportDetailViewModel>(new object[5]
    {
      (object) msgBoxService,
      (object) pidm,
      (object) importSource,
      (object) newImportMode,
      (object) importLogID
    });
  }

  public PolicyImportDetailViewModel(
    IWinMsgBoxService msgBoxService,
    PolicyImportDataManager pidm,
    ImportSource importSource,
    bool newImportMode,
    int importLogID)
  {
    this.msgBoxSvc = msgBoxService;
    this.PolicyImportDataManager = pidm;
    this.CurrentImportSource = importSource;
    this.NewImportMode = newImportMode;
    if (importLogID == 0)
      return;
    this.CurrentlyImportingFilesList.Add(importLogID);
  }

  internal async Task InitializeAsync()
  {
    this.ExcelToXMLVersionFilteredList.AddRange(((IEnumerable<ExcelToXMLVersion>) this.PolicyImportDataManager.ExcelToXMLVersionList).Where<ExcelToXMLVersion>((System.Func<ExcelToXMLVersion, bool>) (s => s.ImportSource.Equals(this.CurrentImportSource.ID))));
    if (((Collection<ExcelToXMLVersion>) this.ExcelToXMLVersionFilteredList).Count == 1)
      this.SelectedExcelToXMLVersion = ((Collection<ExcelToXMLVersion>) this.ExcelToXMLVersionFilteredList)[0];
    this.ImportSourceProducerLocationFilteredList.AddRange(((IEnumerable<ImportSourceProducerLocationItem>) this.PolicyImportDataManager.ImportSourceProducerLocationList).Where<ImportSourceProducerLocationItem>((System.Func<ImportSourceProducerLocationItem, bool>) (s => s.ImportSource.Equals(this.CurrentImportSource.ID))));
    if (((Collection<ImportSourceProducerLocationItem>) this.ImportSourceProducerLocationFilteredList).Count == 1)
      this.SelectedImportSourceProducerLocation = ((Collection<ImportSourceProducerLocationItem>) this.ImportSourceProducerLocationFilteredList)[0];
    this.ImportSourceImportVersionFilteredList.AddRange(((IEnumerable<ImportSourceImportVersionItem>) this.PolicyImportDataManager.ImportSourceImportVersionList).Where<ImportSourceImportVersionItem>((System.Func<ImportSourceImportVersionItem, bool>) (s => s.ImportSource.Equals(this.CurrentImportSource.ID))));
    if (((Collection<ImportSourceImportVersionItem>) this.ImportSourceImportVersionFilteredList).Count == 1)
      this.SelectedImportSourceImportVersion = ((Collection<ImportSourceImportVersionItem>) this.ImportSourceImportVersionFilteredList)[0];
    this.ExcelToXMLConvertRowsTotal = 1;
    this.ExcelToXMLConvertRowsProcessed = 0;
    this.ImportStep1Visibility = Visibility.Collapsed;
    this.ImportStep1VisibilityComplete = Visibility.Collapsed;
    this.ImportStep2ChoiceVisible = Visibility.Collapsed;
    this.ImportStep2ErrorVisibility = Visibility.Collapsed;
    this.ImportStep2Visibility = Visibility.Collapsed;
    this.pgImportingFilesIsIndeterminate = true;
    this.pgImportingFilesValue = 0;
    ((Collection<ImportPreprocessErrorItem>) this.PolicyImportDataManager.ImportLogPreprocessErrorList).Clear();
    if (this.CurrentlyImportingFilesList.Count == 0)
      return;
    try
    {
      await this.PolicyImportDataManager.RefreshImportLogDetailItemListAsync(this.ImportLogIDsToXML(this.CurrentlyImportingFilesList));
    }
    catch (Exception ex)
    {
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
    }
  }

  public RelayCommand SelectFileToImport
  {
    get
    {
      return new RelayCommand((Action) (() => this.ImportFilePath = new Win32DialogService().OpenFileDialog("Excel Files (.xls, .xlsx)|*.xls;*.xlsx")), (Func<bool>) (() => true));
    }
  }

  public RelayCommand ExecuteImportFile
  {
    get
    {
      return new RelayCommand((Action) (async () =>
      {
        ((Collection<ImportLogDetailItem>) this.PolicyImportDataManager.CurrentImportDetailList).Clear();
        this.CurrentlyImportingFilesList.Clear();
        this.ExcelToXMLConvertRowsTotal = 1;
        this.ExcelToXMLConvertRowsProcessed = 0;
        this.ImportStep1Visibility = Visibility.Collapsed;
        this.ImportStep1VisibilityComplete = Visibility.Collapsed;
        this.ImportStep2ChoiceVisible = Visibility.Collapsed;
        this.ImportStep2ErrorVisibility = Visibility.Collapsed;
        this.ImportStep2Visibility = Visibility.Collapsed;
        this.pgImportingFilesIsIndeterminate = true;
        this.pgImportingFilesValue = 0;
        this.ImportXMLAsString = await this.PolicyImportConvertExcelToXML(this.ImportFilePath, this.CurrentImportSource);
        this.ImportStep1VisibilityComplete = Visibility.Visible;
        if (!this.PreviewBeforeUploading)
        {
          this.PolicyImportDataManager.InitiateXMLImportAsync(this.ImportXMLAsString, (Action<int>) (x =>
          {
            this.CurrentlyImportingFilesList.Add(x);
            this.CurrentlyImportingFilesProgress = $"Importing {this.CurrentlyImportingFilesList.Count} of {this.CurrentlyImportingNumberOfFilesMax}";
          }), (Action<int>) (x =>
          {
            this.CurrentlyImportingNumberOfFilesMax = x;
            this.CurrentlyImportingFilesProgress = $"Importing {this.CurrentlyImportingFilesList.Count} of {this.CurrentlyImportingNumberOfFilesMax}";
          })).ContinueWith((Action<Task>) (importTask =>
          {
            if (importTask.Exception.InnerExceptions.Count == importTask.Exception.InnerExceptions.Where<Exception>((System.Func<Exception, bool>) (x => x.Message.Contains("Operation cancelled by user"))).Count<Exception>())
              return;
            ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) importTask.Exception);
          }), TaskContinuationOptions.OnlyOnFaulted);
          this.ImportStep2Visibility = ((Collection<ImportPreprocessErrorItem>) this.PolicyImportDataManager.ImportLogPreprocessErrorList).Count != this.CurrentlyImportingNumberOfFilesMax ? Visibility.Visible : Visibility.Collapsed;
          this.ImportStep2ErrorVisibility = ((Collection<ImportPreprocessErrorItem>) this.PolicyImportDataManager.ImportLogPreprocessErrorList).Count <= 0 ? Visibility.Collapsed : Visibility.Visible;
          try
          {
            await this.RefreshImportDetailList(-1);
          }
          catch (OperationCanceledException ex)
          {
          }
          catch (Exception ex)
          {
            ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
            this.CurrentlyImportingFilesProgress = "Errors Encountered";
            this.ImportStep2ErrorVisibility = Visibility.Visible;
            this.pgImportingFilesIsIndeterminate = false;
            this.pgImportingFilesValue = 1;
          }
        }
        else
          this.ImportStep2ChoiceVisible = Visibility.Visible;
      }), (Func<bool>) (() => File.Exists(this.ImportFilePath) && this.SelectedExcelToXMLVersion != null && this.SelectedImportSourceProducerLocation != null && this.SelectedImportSourceImportVersion != null));
    }
  }

  public RelayCommand ExecuteResumeImport
  {
    get
    {
      return new RelayCommand((Action) (async () =>
      {
        this.PolicyImportDataManager.ResumeImportAsync(this.CurrentlyImportingFilesList[0]).ContinueWith((Action<Task>) (importTask =>
        {
          if (importTask.Exception.InnerExceptions.Count == importTask.Exception.InnerExceptions.Where<Exception>((System.Func<Exception, bool>) (x => x.Message.Contains("Operation cancelled by user"))).Count<Exception>())
            return;
          ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) importTask.Exception);
        }), TaskContinuationOptions.OnlyOnFaulted);
        this.ImportStep2Visibility = ((Collection<ImportPreprocessErrorItem>) this.PolicyImportDataManager.ImportLogPreprocessErrorList).Count != this.CurrentlyImportingNumberOfFilesMax ? Visibility.Visible : Visibility.Collapsed;
        this.ImportStep2ErrorVisibility = ((Collection<ImportPreprocessErrorItem>) this.PolicyImportDataManager.ImportLogPreprocessErrorList).Count <= 0 ? Visibility.Collapsed : Visibility.Visible;
        try
        {
          await this.RefreshImportDetailList(-1);
        }
        catch (OperationCanceledException ex)
        {
        }
        catch (Exception ex)
        {
          ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
          this.CurrentlyImportingFilesProgress = "Errors Encountered";
          this.ImportStep2ErrorVisibility = Visibility.Visible;
          this.pgImportingFilesIsIndeterminate = false;
          this.pgImportingFilesValue = 1;
        }
      }), (Func<bool>) (() => this.CurrentlyImportingFilesList.Count == 1));
    }
  }

  public RelayCommand PreviewPreparedData
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        PreparedXMLViewerView preparedXmlViewerView = MgaMdiChild.Create<PreparedXMLViewerView>(new object[2]
        {
          (object) new WinMsgBoxService(),
          (object) this.ImportXMLAsString
        });
        preparedXmlViewerView.Form.MdiParent = MDIControls.Instance.MDIParent;
        preparedXmlViewerView.Form.Show();
      }), (Func<bool>) (() => true));
    }
  }

  public RelayCommand ShowImportPreprocessErrors
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        if (((IEnumerable<Form>) MDIControls.Instance.MDIParent.MdiChildren).Where<Form>((System.Func<Form, bool>) (x => x.Text.Equals("Preprocess Errors"))).Count<Form>() != 0)
          return;
        PreprocessErrorViewerView preprocessErrorViewerView = MgaMdiChild.Create<PreprocessErrorViewerView>(new object[1]
        {
          (object) this.PolicyImportDataManager
        });
        preprocessErrorViewerView.Form.MdiParent = MDIControls.Instance.MDIParent;
        preprocessErrorViewerView.Form.Show();
      }), (Func<bool>) (() => true));
    }
  }

  public RelayCommand UploadToImportProcess
  {
    get
    {
      return new RelayCommand((Action) (async () =>
      {
        this.CurrentlyImportingFilesList.Clear();
        this.PolicyImportDataManager.InitiateXMLImportAsync(this.ImportXMLAsString, (Action<int>) (x => this.CurrentlyImportingFilesList.Add(x)), (Action<int>) (x => this.CurrentlyImportingNumberOfFilesMax = x)).ContinueWith((Action<Task>) (importTask =>
        {
          if (importTask.Exception.InnerExceptions.Count == importTask.Exception.InnerExceptions.Where<Exception>((System.Func<Exception, bool>) (x => x.Message.Contains("Operation cancelled by user"))).Count<Exception>())
            return;
          ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) importTask.Exception);
        }), TaskContinuationOptions.OnlyOnFaulted);
        this.ImportStep2Visibility = ((Collection<ImportPreprocessErrorItem>) this.PolicyImportDataManager.ImportLogPreprocessErrorList).Count != this.CurrentlyImportingNumberOfFilesMax ? Visibility.Visible : Visibility.Collapsed;
        this.ImportStep2ErrorVisibility = ((Collection<ImportPreprocessErrorItem>) this.PolicyImportDataManager.ImportLogPreprocessErrorList).Count <= 0 ? Visibility.Collapsed : Visibility.Visible;
        try
        {
          await this.RefreshImportDetailList(-1);
        }
        catch (OperationCanceledException ex)
        {
        }
        catch (Exception ex)
        {
          ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
          this.CurrentlyImportingFilesProgress = "Errors Encountered";
          this.ImportStep2ErrorVisibility = Visibility.Visible;
          this.pgImportingFilesIsIndeterminate = false;
          this.pgImportingFilesValue = 1;
        }
      }), (Func<bool>) (() => true));
    }
  }

  internal async Task<string> PolicyImportConvertExcelToXML(
    string excelFilePath,
    ImportSource importSource)
  {
    string empty = string.Empty;
    this.ImportStep1Visibility = Visibility.Visible;
    MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions result = MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.Undetermined;
    System.Enum.TryParse<MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions>(System.Enum.GetName(typeof (MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions), (object) this.SelectedExcelToXMLVersion.ExcelToXMLVersionID), out result);
    string xml;
    switch (result)
    {
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.NonAdmitted:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLNonAdmittedFormat(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.LloydsStandard:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLLloydsStandard(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.Lloyds:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLLloyds(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.OSC:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLOSC(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.Coalition:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLCoalition(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.AdmittedExcess:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLAdmittedExcessFormat(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.Breckenridge:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLBreckenridge(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.AdmittedHO3:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLAdmittedHO3Format(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.AdmittedHO4:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLAdmittedHO3Format(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.GL:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLAdmittedGLFormat(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.ResidentialMH:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLAdmittedResidentialMHFormat(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.Convelo:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLConveloFormat(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.Rokstone:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLRokstoneFormat(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      case MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions.AdmittedUniversal:
        xml = await Task.Run<string>((Func<string>) (() => this.ConvertExcelToXMLAdmittedUniversalFormat(excelFilePath, this.SelectedImportSourceProducerLocation.ProducerLocationID, this.SelectedImportSourceImportVersion.ImportVersion, importSource.ID)));
        break;
      default:
        xml = string.Empty;
        break;
    }
    return xml;
  }

  internal string ConvertExcelToXMLNonAdmittedFormat(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    DataSet localDs = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[0, index].Value.ToString());
      for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      localDs.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = localDs.Tables["PRM"]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    this.CheckForPolicyUnit(localDs);
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("ISO-8859-1"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("ISO-8859-1"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < localDs.Tables.Count; ++index1)
      {
        if (localDs.Tables[index1].TableName == "HDR")
        {
          for (int index2 = 0; index2 < localDs.Tables[index1].Rows.Count; ++index2)
          {
            xmlWriter.WriteStartElement("Header");
            for (int index3 = 0; index3 < localDs.Tables[index1].Columns.Count; ++index3)
              xmlWriter.WriteElementString(localDs.Tables[index1].Columns[index3].ColumnName, localDs.Tables[index1].Rows[index2][index3].ToString());
            xmlWriter.WriteEndElement();
          }
        }
        if (localDs.Tables[index1].TableName == "POL")
        {
          DataTable table1 = localDs.Tables[localDs.Tables.IndexOf("UNT")];
          DataTable table2 = localDs.Tables[localDs.Tables.IndexOf("PRM")];
          DataView dataView1 = new DataView(table1);
          DataView dataView2 = new DataView(table2);
          DataTable dataTable1 = new DataTable();
          DataTable dataTable2 = new DataTable();
          for (int index4 = 0; index4 < localDs.Tables[index1].Rows.Count; ++index4)
          {
            string empty1 = string.Empty;
            xmlWriter.WriteStartElement("Policy");
            for (int index5 = 0; index5 < localDs.Tables[index1].Columns.Count; ++index5)
            {
              xmlWriter.WriteElementString(this.LloydsStandardCleanColumnNameForXML(localDs.Tables[index1].Columns[index5].ColumnName), this.CleanValueForXML(localDs.Tables[index1].Rows[index4][index5].ToString()));
              if (localDs.Tables[index1].Columns[index5].ColumnName.Equals("PolicyNumber"))
                empty1 = localDs.Tables[index1].Rows[index4][index5].ToString();
            }
            xmlWriter.WriteElementString("PolicyRecordID", index4.ToString());
            dataView1.RowFilter = $"PolicyNumber = '{empty1}'";
            DataTable table3 = dataView1.ToTable();
            for (int index6 = 0; index6 < table3.Rows.Count; ++index6)
            {
              string empty2 = string.Empty;
              xmlWriter.WriteStartElement("PolicyUnit");
              for (int index7 = 0; index7 < table3.Columns.Count; ++index7)
              {
                xmlWriter.WriteElementString(table3.Columns[index7].ColumnName.Replace(" ", string.Empty), table3.Rows[index6][index7].ToString());
                if (table3.Columns[index7].ColumnName.Equals("PolicyUnit"))
                  empty2 = table3.Rows[index6][index7].ToString();
              }
              xmlWriter.WriteElementString("PolicyRecordID", index4.ToString());
              xmlWriter.WriteElementString("UnitRecordID", index6.ToString());
              dataView2.RowFilter = $"PolicyNumber = '{empty1}' AND PolicyUnit = '{empty2.Replace("'", "''")}'";
              DataTable table4 = dataView2.ToTable();
              for (int index8 = 0; index8 < table4.Rows.Count; ++index8)
              {
                xmlWriter.WriteStartElement("Premium");
                for (int index9 = 0; index9 < table4.Columns.Count; ++index9)
                  xmlWriter.WriteElementString(table4.Columns[index9].ColumnName.Replace(" ", string.Empty).Replace("/", "-"), table4.Rows[index8][index9].ToString());
                xmlWriter.WriteElementString("PolicyRecordID", index4.ToString());
                xmlWriter.WriteElementString("UnitRecordID", index6.ToString());
                xmlWriter.WriteElementString("PremiumRecordID", index8.ToString());
                xmlWriter.WriteEndElement();
                ++this.ExcelToXMLConvertRowsProcessed;
              }
              for (int index10 = table2.Rows.Count - 1; index10 >= 0; --index10)
              {
                if (table2.Rows[index10]["PolicyNumber"].Equals((object) empty1) && table2.Rows[index10]["PolicyUnit"].Equals((object) empty2.Replace("'", "''")))
                  table2.Rows.RemoveAt(index10);
              }
              dataView2.Table = table2;
              xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            for (int index11 = table1.Rows.Count - 1; index11 >= 0; --index11)
            {
              if (table1.Rows[index11]["PolicyNumber"].Equals((object) empty1))
                table1.Rows.RemoveAt(index11);
            }
            dataView1.Table = table1;
          }
        }
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    localDs.Dispose();
    return sb.ToString();
  }

  internal string ConvertExcelToXMLLloydsStandard(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    List<string> stringList = new List<string>();
    stringList.Add("US");
    stringList.Add("Premium Reporting - SBLL");
    string name = string.Empty;
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      if (stringList.Contains(worksheet.Name))
      {
        name = worksheet.Name;
        int num1 = 5;
        int num2 = 6;
        DataTable table = new DataTable(worksheet.Name);
        for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        {
          int num3 = index;
          int num4 = index;
          if (worksheet.Cells[num1, num3].IsMerged)
          {
            Range mergedRange = worksheet.Cells[num1, num3].GetMergedRange();
            num1 = mergedRange.FirstRow;
            num3 = mergedRange.FirstColumn;
          }
          if (worksheet.Cells[num2, num4].IsMerged)
          {
            Range mergedRange = worksheet.Cells[num2, num4].GetMergedRange();
            num2 = mergedRange.FirstRow;
            num4 = mergedRange.FirstColumn;
          }
          string empty = string.Empty;
          string columnName = num1 != num2 || num3 != num4 ? worksheet.Cells[num1, num3]?.Value?.ToString() + worksheet.Cells[num2, num4]?.Value?.ToString() : worksheet.Cells[num1, num3]?.Value?.ToString();
          if (string.IsNullOrEmpty(columnName))
            throw new Exception();
          try
          {
            table.Columns.Add(columnName);
          }
          catch (DuplicateNameException ex)
          {
            int num5 = (int) System.Windows.MessageBox.Show(ex.Message);
            ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
            return string.Empty;
          }
        }
        if (!table.Columns.Contains("ROWNO"))
          table.Columns.Add("ROWNO");
        for (int index1 = num2 + 1; index1 <= worksheet.Cells.MaxDataRow; ++index1)
        {
          DataRow row = table.NewRow();
          for (int index2 = 0; index2 < table.Columns.Count; ++index2)
            row[index2] = !table.Columns[index2].ColumnName.Equals("ROWNO") ? worksheet.Cells[index1, index2].Value : (object) (index1 - 1);
          table.Rows.Add(row);
        }
        dataSet.Tables.Add(table);
      }
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[name]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("UTF-8"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("UTF-8"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index3 = 0; index3 < dataSet.Tables.Count; ++index3)
      {
        xmlWriter.WriteStartElement("LloydsRecords");
        for (int index4 = 0; index4 < dataSet.Tables[index3].Rows.Count; ++index4)
        {
          xmlWriter.WriteStartElement("LloydsRecord");
          for (int index5 = 0; index5 < dataSet.Tables[index3].Columns.Count; ++index5)
            xmlWriter.WriteElementString(this.LloydsStandardCleanColumnNameForXML(dataSet.Tables[index3].Columns[index5].ColumnName), this.CleanValueForXML(dataSet.Tables[index3].Rows[index4][index5].ToString()));
          xmlWriter.WriteEndElement();
          ++this.ExcelToXMLConvertRowsProcessed;
        }
        xmlWriter.WriteEndElement();
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLLloyds(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    string name = "Premium Reporting";
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      if (worksheet.Name == name)
      {
        DataTable table = new DataTable(worksheet.Name);
        for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        {
          int num1 = 1;
          int num2 = index;
          int num3 = 2;
          int num4 = index;
          if (worksheet.Cells[num1, num2].IsMerged)
          {
            Range mergedRange = worksheet.Cells[num1, num2].GetMergedRange();
            num1 = mergedRange.FirstRow;
            num2 = mergedRange.FirstColumn;
          }
          if (worksheet.Cells[num3, num4].IsMerged)
          {
            Range mergedRange = worksheet.Cells[num3, num4].GetMergedRange();
            num3 = mergedRange.FirstRow;
            num4 = mergedRange.FirstColumn;
          }
          string empty = string.Empty;
          string columnName = num1 != num3 || num2 != num4 ? worksheet.Cells[num1, num2]?.Value?.ToString() + worksheet.Cells[num3, num4]?.Value?.ToString() : worksheet.Cells[num1, num2]?.Value?.ToString();
          if (string.IsNullOrEmpty(columnName))
            throw new Exception();
          try
          {
            table.Columns.Add(columnName);
          }
          catch (DuplicateNameException ex)
          {
            int num5 = (int) System.Windows.MessageBox.Show(ex.Message);
            ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
            return string.Empty;
          }
        }
        for (int index = 3; index <= worksheet.Cells.MaxDataRow; ++index)
        {
          DataRow row = table.NewRow();
          for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
            row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
          table.Rows.Add(row);
        }
        dataSet.Tables.Add(table);
      }
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[name]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("UTF-8"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("UTF-8"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        xmlWriter.WriteStartElement("LloydsRecords");
        for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
        {
          xmlWriter.WriteStartElement("LloydsRecord");
          for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
            xmlWriter.WriteElementString(this.LloydsStandardCleanColumnNameForXML(dataSet.Tables[index1].Columns[index3].ColumnName), dataSet.Tables[index1].Rows[index2][index3].ToString().Replace("–", "-"));
          xmlWriter.WriteEndElement();
          ++this.ExcelToXMLConvertRowsProcessed;
        }
        xmlWriter.WriteEndElement();
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLOSC(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    int num = 0;
    string empty = string.Empty;
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      empty = worksheet.Cells[1, 66].Value.ToString();
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
      {
        if (table.Columns.Contains(worksheet.Cells[num, index].Value.ToString()))
          table.Columns.Add(worksheet.Cells[num, index].Value.ToString() + index.ToString());
        else
          table.Columns.Add(worksheet.Cells[num, index].Value.ToString());
      }
      for (int index = num + 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("UTF-8"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("UTF-8"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      xmlWriter.WriteElementString("SubmissionDate", empty);
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        xmlWriter.WriteStartElement("BreckenridgeOSCRecords");
        for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
        {
          xmlWriter.WriteStartElement("BreckenridgeOSCRecord");
          for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
            xmlWriter.WriteElementString(this.OSCCleanColumnNameForXML(dataSet.Tables[index1].Columns[index3].ColumnName).Trim(), this.OSCCleanValueForXML(dataSet.Tables[index1].Rows[index2][index3].ToString()));
          xmlWriter.WriteEndElement();
        }
        xmlWriter.WriteEndElement();
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLCoalition(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    string str = "FortegraAccountCurrent";
    if (workbook.Worksheets.Count == 1)
      str = workbook.Worksheets[0].Name;
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      if (worksheet.Name == str)
      {
        DataTable table = new DataTable(worksheet.Name);
        for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        {
          string columnName = worksheet.Cells[0, index]?.Value?.ToString();
          if (string.IsNullOrEmpty(columnName))
            throw new Exception();
          table.Columns.Add(columnName);
        }
        for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
        {
          DataRow row = table.NewRow();
          for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
            row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
          table.Rows.Add(row);
        }
        dataSet.Tables.Add(table);
      }
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("UTF-8"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("UTF-8"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        xmlWriter.WriteStartElement("PremiumRecords");
        for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
        {
          xmlWriter.WriteStartElement("PremiumRecord");
          for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
            xmlWriter.WriteElementString(this.LloydsStandardCleanColumnNameForXML(dataSet.Tables[index1].Columns[index3].ColumnName), dataSet.Tables[index1].Rows[index2][index3].ToString().Replace("’", "'"));
          xmlWriter.WriteEndElement();
          ++this.ExcelToXMLConvertRowsProcessed;
        }
        xmlWriter.WriteEndElement();
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLGAPFormat(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[0, index].Value.ToString());
      for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("ISO-8859-1"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("ISO-8859-1"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        if (dataSet.Tables[index1].TableName == "Sheet1")
        {
          for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
          {
            xmlWriter.WriteStartElement("Policy");
            for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
              xmlWriter.WriteElementString(dataSet.Tables[index1].Columns[index3].ColumnName.Replace(" ", string.Empty), dataSet.Tables[index1].Rows[index2][index3].ToString());
            xmlWriter.WriteElementString("PolicyRecordID", index2.ToString());
            xmlWriter.WriteEndElement();
          }
        }
      }
      xmlWriter.WriteEndElement();
      ++this.ExcelToXMLConvertRowsProcessed;
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLAdmittedExcessFormat(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[0, index].Value.ToString());
      for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("ISO-8859-1"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("ISO-8859-1"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        if (dataSet.Tables[index1].TableName == "Buffer Layer")
        {
          for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
          {
            xmlWriter.WriteStartElement("ExcessFeedRecords");
            xmlWriter.WriteStartElement("ExcessFeedRecord");
            for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
              xmlWriter.WriteElementString(dataSet.Tables[index1].Columns[index3].ColumnName.Replace(" ", ""), dataSet.Tables[index1].Rows[index2][index3].ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            ++this.ExcelToXMLConvertRowsProcessed;
          }
        }
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLAdmittedHO3Format(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[0, index].Value.ToString());
      for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("ISO-8859-1"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("ISO-8859-1"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        if (dataSet.Tables[index1].TableName == "HO3" || dataSet.Tables[index1].TableName == "HO4")
        {
          for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
          {
            xmlWriter.WriteStartElement("HO3FeedRecords");
            xmlWriter.WriteStartElement("HO3FeedRecord");
            for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
              xmlWriter.WriteElementString(dataSet.Tables[index1].Columns[index3].ColumnName.Replace(" ", ""), dataSet.Tables[index1].Rows[index2][index3].ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            ++this.ExcelToXMLConvertRowsProcessed;
          }
        }
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLConveloFormat(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[0, index].Value.ToString());
      for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("ISO-8859-1"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("ISO-8859-1"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
        {
          xmlWriter.WriteStartElement("ConveloRecords");
          xmlWriter.WriteStartElement("ConveloRecord");
          for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
            xmlWriter.WriteElementString(dataSet.Tables[index1].Columns[index3].ColumnName.Replace(" ", ""), dataSet.Tables[index1].Rows[index2][index3].ToString());
          xmlWriter.WriteEndElement();
          xmlWriter.WriteEndElement();
          ++this.ExcelToXMLConvertRowsProcessed;
        }
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLAdmittedGLFormat(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[0, index].Value.ToString());
      for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("ISO-8859-1"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("ISO-8859-1"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        if (dataSet.Tables[index1].TableName == "GL")
        {
          for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
          {
            xmlWriter.WriteStartElement("GLFeedRecords");
            xmlWriter.WriteStartElement("GLFeedRecord");
            for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
              xmlWriter.WriteElementString(dataSet.Tables[index1].Columns[index3].ColumnName.Replace(" ", ""), dataSet.Tables[index1].Rows[index2][index3].ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            ++this.ExcelToXMLConvertRowsProcessed;
          }
        }
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLAdmittedResidentialMHFormat(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[0, index].Value.ToString());
      for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("ISO-8859-1"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("ISO-8859-1"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        if (dataSet.Tables[index1].TableName == "Residential MH")
        {
          for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
          {
            xmlWriter.WriteStartElement("ResidentialMHFeedRecords");
            xmlWriter.WriteStartElement("ResidentialMHFeedRecord");
            for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
              xmlWriter.WriteElementString(dataSet.Tables[index1].Columns[index3].ColumnName.Replace(" ", ""), dataSet.Tables[index1].Rows[index2][index3].ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            ++this.ExcelToXMLConvertRowsProcessed;
          }
        }
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLBreckenridge(
    string excelFilePath,
    int ClientID,
    int ImportVersion,
    int ImportSource)
  {
    int num = 0;
    List<string> stringList = new List<string>();
    string str = string.Empty;
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      str = "6/1/2023";
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[num, index].Value.ToString());
      for (int index = num + 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("UTF-8"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("UTF-8"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString(nameof (ClientID), ClientID.ToString());
      xmlWriter.WriteElementString(nameof (ImportVersion), ImportVersion.ToString());
      xmlWriter.WriteElementString(nameof (ImportSource), ImportSource.ToString());
      xmlWriter.WriteElementString("SubmissionDate", str);
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        xmlWriter.WriteStartElement("BreckenridgeRecords");
        for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
        {
          xmlWriter.WriteStartElement("BreckenridgeRecord");
          for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
            xmlWriter.WriteElementString(this.BreckenridgeCleanColumnNameForXML(dataSet.Tables[index1].Columns[index3].ColumnName), dataSet.Tables[index1].Rows[index2][index3].ToString().Replace(Convert.ToChar(160 /*0xA0*/), ' '));
          xmlWriter.WriteEndElement();
        }
        xmlWriter.WriteEndElement();
        ++this.ExcelToXMLConvertRowsProcessed;
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLRokstoneFormat(
    string excelFilePath,
    int clientID,
    int importVersion,
    int importSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    string name = "Rolling Bdx (2)";
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      if (worksheet.Name == name)
      {
        DataTable table = new DataTable(worksheet.Name);
        for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        {
          string columnName = worksheet.Cells[0, index]?.Value?.ToString();
          if (string.IsNullOrEmpty(columnName))
            throw new Exception();
          try
          {
            table.Columns.Add(this.CleanColumnNameForXML(columnName));
          }
          catch (DuplicateNameException ex)
          {
            int num = (int) System.Windows.MessageBox.Show(ex.Message);
            ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
            return string.Empty;
          }
        }
        for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
        {
          DataRow row = table.NewRow();
          for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
            row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
          table.Rows.Add(row);
        }
        dataSet.Tables.Add(table);
      }
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[name]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("UTF-8"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("UTF-8"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString("ClientID", clientID.ToString());
      xmlWriter.WriteElementString("ImportVersion", importVersion.ToString());
      xmlWriter.WriteElementString("ImportSource", importSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        xmlWriter.WriteStartElement("LloydsRecords");
        for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
        {
          xmlWriter.WriteStartElement("LloydsRecord");
          for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
            xmlWriter.WriteElementString(this.CleanColumnNameForXML(dataSet.Tables[index1].Columns[index3].ColumnName), dataSet.Tables[index1].Rows[index2][index3].ToString());
          xmlWriter.WriteEndElement();
          ++this.ExcelToXMLConvertRowsProcessed;
        }
        xmlWriter.WriteEndElement();
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  internal string ConvertExcelToXMLAdmittedUniversalFormat(
    string excelFilePath,
    int clientID,
    int importVersion,
    int importSource)
  {
    Workbook workbook = new Workbook(excelFilePath);
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
    {
      DataTable table = new DataTable(worksheet.Name);
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
        table.Columns.Add(worksheet.Cells[0, index].Value.ToString());
      for (int index = 1; index <= worksheet.Cells.MaxDataRow; ++index)
      {
        DataRow row = table.NewRow();
        for (int columnIndex = 0; columnIndex < table.Columns.Count; ++columnIndex)
          row[columnIndex] = worksheet.Cells[index, columnIndex].Value;
        table.Rows.Add(row);
      }
      dataSet.Tables.Add(table);
    }
    this.ExcelToXMLConvertRowsTotal = dataSet.Tables[0]?.Rows?.Count.GetValueOrDefault();
    this.ExcelToXMLConvertRowsProcessed = 0;
    StringBuilder sb = new StringBuilder();
    PolicyImportDetailViewModel.StringWriterWithEncoding output = new PolicyImportDetailViewModel.StringWriterWithEncoding(sb, Encoding.GetEncoding("ISO-8859-1"));
    XmlWriterSettings settings = new XmlWriterSettings()
    {
      Encoding = Encoding.GetEncoding("ISO-8859-1"),
      CloseOutput = true
    };
    using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output, settings))
    {
      xmlWriter.WriteStartElement("Feed");
      xmlWriter.WriteElementString("ClientID", clientID.ToString());
      xmlWriter.WriteElementString("ImportVersion", importVersion.ToString());
      xmlWriter.WriteElementString("ImportSource", importSource.ToString());
      for (int index1 = 0; index1 < dataSet.Tables.Count; ++index1)
      {
        xmlWriter.WriteStartElement("AdmittedFeedRecords");
        for (int index2 = 0; index2 < dataSet.Tables[index1].Rows.Count; ++index2)
        {
          xmlWriter.WriteStartElement("AdmittedFeedRecord");
          for (int index3 = 0; index3 < dataSet.Tables[index1].Columns.Count; ++index3)
            xmlWriter.WriteElementString(this.CleanColumnNameForXML(dataSet.Tables[index1].Columns[index3].ColumnName), dataSet.Tables[index1].Rows[index2][index3].ToString());
          xmlWriter.WriteEndElement();
          ++this.ExcelToXMLConvertRowsProcessed;
        }
        xmlWriter.WriteEndElement();
      }
      xmlWriter.WriteEndElement();
      xmlWriter.Flush();
    }
    this.ExcelToXMLConvertRowsProcessed = this.ExcelToXMLConvertRowsTotal;
    return sb.ToString();
  }

  private void CheckForPolicyUnit(DataSet localDs)
  {
    List<string> stringList = new List<string>();
    foreach (DataRow row in (InternalDataCollectionBase) localDs.Tables[1].Rows)
    {
      if (!stringList.Contains(row["PolicyNumber"].ToString()))
        stringList.Add(row["PolicyNumber"].ToString());
    }
    foreach (string str in stringList)
    {
      string polnum = str;
      if (localDs.Tables[localDs.Tables.Count - 1].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (x => x["PolicyNumber"].Equals((object) polnum) && x["PolicyUnit"].Equals((object) "0"))).Count<DataRow>() > 0 && localDs.Tables[localDs.Tables.Count - 2].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (x => x["PolicyNumber"].Equals((object) polnum) && x["PolicyUnit"].Equals((object) "0"))).Count<DataRow>() == 0)
      {
        DataRow row = localDs.Tables[localDs.Tables.Count - 2].NewRow();
        row["RecordType"] = (object) "UNT";
        row["RecordID"] = (object) (localDs.Tables[localDs.Tables.Count - 2].Rows.Count + 1);
        row["PolicyNumber"] = (object) polnum;
        row["PolicyUnit"] = (object) "0";
        row["PolicyUnitState"] = localDs.Tables[2].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (x => x["PolicyNumber"].Equals((object) polnum))).Count<DataRow>() <= 0 ? localDs.Tables[localDs.Tables.Count - 3].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (x => x["PolicyNumber"].Equals((object) polnum))).First<DataRow>()["InsuredState"] : localDs.Tables[localDs.Tables.Count - 2].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (x => x["PolicyNumber"].Equals((object) polnum))).First<DataRow>()["PolicyUnitState"];
        localDs.Tables[localDs.Tables.Count - 2].Rows.Add(row);
      }
    }
  }

  [Obsolete("This method is obsolete. Use CleanColumnNameForXML instead.")]
  private string BreckenridgeCleanColumnNameForXML(string columnName)
  {
    return columnName.Replace(" ", "").Replace("/", "-").Replace("(", "").Replace(")", "").Replace("%", "Pct").Replace("#", "").Trim();
  }

  [Obsolete("This method is obsolete. Use CleanColumnNameForXML instead.")]
  private string LloydsStandardCleanColumnNameForXML(string columnName)
  {
    return columnName.Replace(" ", "").Replace("/", "-").Replace("(", "").Replace(")", "").Replace("%", "Pct").Replace("#", "").Replace(",", "").Replace("'", "").Replace("\r", "").Replace("\n", "").Replace(":", "").Replace("100Pct", "HundredPct").Replace("’", "").Replace("–", "-").Replace("&", "And").Replace("$", "");
  }

  [Obsolete("This method is obsolete. Use CleanColumnNameForXML instead.")]
  private string OSCCleanColumnNameForXML(string columnName)
  {
    return columnName.Replace(" ", "").Replace("/", "-").Replace("(", "").Replace(")", "").Replace("%", "Pct").Replace("#", "");
  }

  [Obsolete("This method is obsolete. Use CleanColumnNameForXML instead.")]
  private string OSCCleanValueForXML(string value)
  {
    return value.Replace(Convert.ToChar(160 /*0xA0*/), ' ').Replace("’", "'").Replace("\u00BD", "").Replace("–", "-").Replace("™", "");
  }

  [Obsolete("This method is obsolete. Use CleanColumnNameForXML instead.")]
  private string CleanValueForXML(string value) => value.Replace("’", "'");

  private string CleanColumnNameForXML(string columnName)
  {
    return Regex.Replace(columnName.Replace("%", "Pct"), "[^a-zA-Z0-9]", "");
  }

  private async Task RefreshImportDetailList(int totalRecords)
  {
    if (this._ctsImportProgressMonitor == null)
      this._ctsImportProgressMonitor = new CancellationTokenSource();
    if (this._ctsImportProgressMonitor.IsCancellationRequested)
      return;
    Task task = this.PolicyImportDataManager.RefreshImportLogDetailItemListAsync(this.ImportLogIDsToXML(this.CurrentlyImportingFilesList));
    Task<bool> tskAllImportsDataSaved = this.PolicyImportDataManager.AllImportsDataSavedOrErroredAsync(this.ImportLogIDsToXML(this.CurrentlyImportingFilesList));
    CancellationToken xclToken = this._ctsImportProgressMonitor.Token;
    xclToken.ThrowIfCancellationRequested();
    await Task.WhenAll(task, (Task) tskAllImportsDataSaved);
    int num = totalRecords;
    int currentTotalRecords = ((Collection<ImportLogDetailItem>) this.PolicyImportDataManager.CurrentImportDetailList).Count;
    if (num < 0 || !tskAllImportsDataSaved.Result)
    {
      xclToken.ThrowIfCancellationRequested();
      await Task.Delay(10000);
      xclToken.ThrowIfCancellationRequested();
      await this.RefreshImportDetailList(currentTotalRecords);
    }
    else
    {
      this.pgImportingFilesIsIndeterminate = false;
      this.pgImportingFilesValue = 1;
      xclToken.ThrowIfCancellationRequested();
      try
      {
        await this.PolicyImportDataManager.RefreshImportPreprocessErrorListAsync(this.ImportLogIDsToXML(this.CurrentlyImportingFilesList));
        if (((Collection<ImportPreprocessErrorItem>) this.PolicyImportDataManager.ImportLogPreprocessErrorList).Count > 0)
        {
          this.CurrentlyImportingFilesProgress = "Errors Encountered";
          this.ImportStep2ErrorVisibility = Visibility.Visible;
        }
        else
          this.CurrentlyImportingFilesProgress = "Import Complete!";
      }
      catch (Exception ex)
      {
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      }
    }
    tskAllImportsDataSaved = (Task<bool>) null;
    xclToken = new CancellationToken();
  }

  private XElement ImportLogIDsToXML(List<int> importLogIDs)
  {
    XElement returnValue = new XElement((XName) "ImportLogIDs");
    importLogIDs.ForEach((Action<int>) (x => returnValue.Add((object) new XElement((XName) "ImportLogID", (object) x))));
    return returnValue;
  }

  public void CancelAllProcessing()
  {
    this.PolicyImportDataManager.CancelAllProcessing();
    this._ctsImportProgressMonitor?.Cancel();
  }

  public class StringWriterWithEncoding : StringWriter
  {
    private readonly Encoding m_Encoding;

    public StringWriterWithEncoding(StringBuilder sb, Encoding encoding)
      : base(sb)
    {
      this.m_Encoding = encoding;
    }

    public override Encoding Encoding => this.m_Encoding;
  }
}
