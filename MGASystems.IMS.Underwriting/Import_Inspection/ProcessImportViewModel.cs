// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.ProcessImportViewModel
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public abstract class ProcessImportViewModel : BindingObject
{
  private int policyNumberColumnIndex;
  private BackgroundWorker bwProcessSheet;
  private IWin32DialogService win32DialogSvc;
  private IWinMsgBoxService msgBoxSvc;

  public SpreadsheetInfo SpreadsheetInfo { get; set; }

  public InspectionInfoMapping InspectionMapping { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<ImportMessage> Messages { get; set; }

  [NotificationProperty]
  public virtual int Maximum { get; set; }

  [NotificationProperty]
  public virtual int CurrentRow { get; set; }

  [NotificationProperty]
  public virtual string ProcessingMsg { get; set; }

  public static ProcessImportViewModel Create(
    InspectionInfoMapping inspectionMapping,
    SpreadsheetInfo spreadsheetInfo)
  {
    return NotifyProxyTypeManager.Allocate<ProcessImportViewModel>(new object[2]
    {
      (object) inspectionMapping,
      (object) spreadsheetInfo
    });
  }

  public ProcessImportViewModel(
    InspectionInfoMapping inspectionMapping,
    SpreadsheetInfo spreadsheetInfo)
  {
    this.Messages = new ObservableCollection<ImportMessage>();
    this.SpreadsheetInfo = spreadsheetInfo;
    this.InspectionMapping = inspectionMapping;
    this.policyNumberColumnIndex = this.GetColumnIndex(this.InspectionMapping.PolicyNumberColumn);
    this.Maximum = ((IEnumerable<Row>) this.SpreadsheetInfo.SelectedWorksheet.Cells.Rows).Count<Row>();
    this.bwProcessSheet = new BackgroundWorker();
    this.bwProcessSheet.WorkerReportsProgress = true;
    this.bwProcessSheet.DoWork += new DoWorkEventHandler(this.BwProcessSheet_DoWork);
    this.bwProcessSheet.ProgressChanged += new ProgressChangedEventHandler(this.BwProcessSheet_ProgressChanged);
    this.bwProcessSheet.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BwProcessSheet_RunWorkerCompleted);
    this.bwProcessSheet.RunWorkerAsync();
  }

  private void BwProcessSheet_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    this.ProcessingMsg = "";
    if (this.msgBoxSvc == null)
      this.msgBoxSvc = (IWinMsgBoxService) new WinMsgBoxService();
    int num = (int) this.msgBoxSvc.ShowMessageBox($"The Inspection Import is complete.  {Environment.NewLine} Imported:  {this.Messages.Where<ImportMessage>((System.Func<ImportMessage, bool>) (m => !m.IsError)).Count<ImportMessage>()} {Environment.NewLine} Policy Not Found:  {this.Messages.Where<ImportMessage>((System.Func<ImportMessage, bool>) (m => m.IsError)).Count<ImportMessage>()}", "Inspection Import", MessageBoxButton.OK);
  }

  private void BwProcessSheet_ProgressChanged(object sender, ProgressChangedEventArgs e)
  {
    this.CurrentRow = e.ProgressPercentage;
    if (e.UserState == null)
      return;
    this.Messages.Add(e.UserState as ImportMessage);
  }

  private void BwProcessSheet_DoWork(object sender, DoWorkEventArgs e)
  {
    foreach (Row row in (IEnumerable<Row>) this.SpreadsheetInfo.SelectedWorksheet.Cells.Rows)
    {
      if (row.Index > 0 && row.Index <= this.SpreadsheetInfo.SelectedWorksheet.Cells.MaxDataRow)
      {
        string policyNumber = this.GetPolicyNumber(row);
        object controlNo = this.GetControlNo(policyNumber);
        this.ProcessingMsg = $"Processing row {row.Index + 1}...";
        ImportMessage userState;
        if (controlNo != null)
        {
          int result;
          int.TryParse(controlNo.ToString(), out result);
          InspectionInformation inspectionInformation = new InspectionInformation();
          inspectionInformation.UpdateInspectionInformation(result, this.SpreadsheetInfo.SelectedWorksheet, row, this.InspectionMapping.ColumnMapping, this.SpreadsheetInfo);
          if (inspectionInformation.InvalidData.Count == 0)
            userState = ImportMessage.Create($"Successfully imported Case No. {inspectionInformation.CaseNumber} to Policy No. {policyNumber}.", false, false);
          else
            userState = ImportMessage.Create($"Successfully imported Case No. {inspectionInformation.CaseNumber} to Policy No. {policyNumber}.  Invalid data detected in {string.Join(", ", (IEnumerable<string>) inspectionInformation.InvalidData)}", false, true);
        }
        else
          userState = ImportMessage.Create($"Policy No. {policyNumber} was not found.  Row# {row.Index + 1}", true, false);
        ((BackgroundWorker) sender).ReportProgress(row.Index, (object) userState);
      }
    }
  }

  protected virtual string GetPolicyNumber(Row worksheetRow)
  {
    string stringValue = this.SpreadsheetInfo.SelectedWorksheet.Cells[worksheetRow.Index, this.policyNumberColumnIndex].StringValue;
    object obj = DefaultDatabase.ExecuteScalar("GetPolicyNumberFromString", new object[2]
    {
      (object) "@polNumString",
      (object) stringValue
    });
    if (obj != null && obj != DBNull.Value)
      stringValue = obj.ToString();
    return stringValue;
  }

  private int GetColumnIndex(string columnName)
  {
    for (int columnIndex = 0; columnIndex <= this.SpreadsheetInfo.SelectedWorksheet.Cells.MaxDataColumn - 1; ++columnIndex)
    {
      if (this.SpreadsheetInfo.SelectedWorksheet.Cells[0, columnIndex].StringValue == columnName)
        return columnIndex;
    }
    return -1;
  }

  private object GetControlNo(string policyNumber)
  {
    return DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 ControlNo FROM tblQuotes WITH (NOLOCK) WHERE StrippedPolicyNumber = @SPN ORDER BY ControlNo DESC", new object[2]
    {
      (object) "@SPN",
      (object) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.StripPolicyNumbers(@PN)", new object[2]
      {
        (object) "@PN",
        (object) policyNumber
      }).ToString()
    });
  }

  public RelayCommand PrintToTextCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        if (this.win32DialogSvc == null)
          this.win32DialogSvc = (IWin32DialogService) new Win32DialogService();
        string path = this.win32DialogSvc.SaveFileDialog("Inspection Import", "Text Files |*.txt");
        if (string.IsNullOrEmpty(path))
          return;
        using (StreamWriter streamWriter = new StreamWriter(path))
        {
          foreach (ImportMessage message in (Collection<ImportMessage>) this.Messages)
            streamWriter.WriteLine(message.Message);
        }
      }), (Func<bool>) (() => this.Messages.Count > 0));
    }
  }
}
