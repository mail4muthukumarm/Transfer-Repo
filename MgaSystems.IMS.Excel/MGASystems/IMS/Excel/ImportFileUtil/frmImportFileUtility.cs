// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.frmImportFileUtility
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

public class frmImportFileUtility : Form
{
  private IContainer components;
  private OpenFileDialog openImportFile;
  private Button btnImportFile;
  private GroupBox grpSuccessfulImports;
  private TextBox txtSuccessfulImports;
  private GroupBox grpFailedImports;
  private TextBox txtFailedImports;
  private Label lblFileLoaded;
  private Label lblStatus;
  private TextBox txtStatusDisplay;
  private TextBox txtFileLoadedDisplay;
  private TextBox txtPassword;
  private TextBox txtUserName;
  private TextBox txtCatalog;
  private TextBox txtDataSource;
  private Label label4;
  private Label label3;
  private Label label2;
  private Label label1;

  public frmImportFileUtility() => this.InitializeComponent();

  private bool TestBasicSetup(ConfigInfo ci, XmlDocument xdoc)
  {
    try
    {
      if (!ci.InitializeConfigProperties(xdoc))
        throw new CustomException("Config File Error", new Exception("Error retrieving properties from Config file. Please check config file and review error log for more details."));
      if (!ci.setupSprocs(xdoc))
        throw new CustomException("Config File Error", new Exception("Error retrieving sproc properties from Config file. Please check config file and review error log for more details."));
    }
    catch (CustomException ex)
    {
      MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (TestBasicSetup), ci.ErrorLogDirectory, ci.AllDebugInfo, true);
      this.txtStatusDisplay.Text = ex.Message;
      return false;
    }
    catch (Exception ex)
    {
      MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (TestBasicSetup), ci.ErrorLogDirectory, ci.AllDebugInfo, true);
      this.txtStatusDisplay.Text = ex.Message;
      return false;
    }
    return true;
  }

  private void btnImportFile_Click(object sender, EventArgs e)
  {
    this.btnImportFile.Enabled = false;
    this.txtFileLoadedDisplay.Text = "";
    this.txtStatusDisplay.Text = "";
    this.txtSuccessfulImports.Text = "";
    this.txtFailedImports.Text = "";
    ConfigInfo ci = new ConfigInfo();
    try
    {
      if (!SystemSettings.KeyExists("MGAImportTransactionUtility") || !SystemSettings.GetBoolSetting("MGAImportTransactionUtility"))
      {
        this.txtStatusDisplay.Text = "You do not have rights to upload files. Please contact techsupport@mgasystems.com for additional information.";
      }
      else
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(SystemSettings.GetStringSetting("MGAImportTransactionUtility"));
        List<TransactionData> source = new List<TransactionData>();
        if (this.TestBasicSetup(ci, xmlDocument))
        {
          this.openImportFile.RestoreDirectory = true;
          this.openImportFile.InitialDirectory = XmlHelper.retrieveXMLNode(xmlDocument, ci.PathToFileDirectory, ci.ErrorLogDirectory).ToString();
          this.openImportFile.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls|Xml File (*.xml)|*.xml";
          if (this.openImportFile.ShowDialog() == DialogResult.OK)
          {
            this.txtFileLoadedDisplay.Text = this.openImportFile.FileName;
            string lower = Path.GetExtension(this.openImportFile.FileName).ToLower();
            if (!ci.SupportedFileTypes.Contains(lower))
              throw new CustomException("Incorrect File Type", new Exception("The upload utility does not support this file type."));
            if (lower == ".xml")
              source = new FileXml().LoadXMLData(xmlDocument, ci);
            if (lower == ".xls" || lower == ".xlsx")
            {
              if (!ci.InitializeExcelFileProperties(xmlDocument))
                throw new CustomException("Error Loading Excel File", new Exception("Error Loading Excel file. Please check excel file, config file and review error log for more details."));
              FileExcel fileExcel = new FileExcel();
              fileExcel.ISetDataForExcelWorksheet(this.openImportFile.FileName, ci.ExcelHeaderColumn, lower);
              int cellNumber = 1;
              if (ci.ExcelHeaderColumn)
                cellNumber = 2;
              foreach (DataRow row in (InternalDataCollectionBase) fileExcel.ExcelDataSet.Tables[0].Rows)
              {
                if (fileExcel.CheckPolicyNumber(ci, row))
                {
                  source.Add(fileExcel.LoadExcelDataFromTableRow(ci, row, cellNumber));
                  ++cellNumber;
                }
              }
            }
          }
          this.txtStatusDisplay.Text = "Processing file...";
          this.txtStatusDisplay.Refresh();
          if (source.Count == 0)
            this.txtStatusDisplay.Text = "No Files Loaded";
          this.Cursor = Cursors.WaitCursor;
          PoliciesStatusCollection statusCollection = new PoliciesStatusCollection();
          List<TransactionData> list = source.OrderByDescending<TransactionData, Decimal>((System.Func<TransactionData, Decimal>) (TransactionData => TransactionData.TransactionAmount)).ThenByDescending<TransactionData, string>((System.Func<TransactionData, string>) (TransactionData => TransactionData.PolicyNumber)).ToList<TransactionData>();
          using (SqlConnection connection = new SqlConnection(DefaultDatabase.ConnectionString))
          {
            connection.Open();
            bool flag1 = false;
            int num1 = 0;
            foreach (TransactionData td in list)
            {
              if (!flag1)
              {
                this.txtStatusDisplay.Text = "Processing policy number " + td.PolicyNumber.ToString();
                this.txtStatusDisplay.Refresh();
                using (SqlCommand sqlCommand = new SqlCommand($"Select dateissued from tblquotes where originalquoteguid is not null and strippedpolicynumber = '{td.PolicyNumber}'order by quoteid desc", connection))
                {
                  sqlCommand.CommandType = CommandType.Text;
                  using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                  {
                    sqlDataReader.Read();
                    if (sqlDataReader != null)
                    {
                      if (sqlDataReader.HasRows)
                      {
                        if (sqlDataReader.GetValue(0) != null)
                        {
                          if (!string.IsNullOrEmpty(sqlDataReader.GetValue(0).ToString()))
                            goto label_41;
                        }
                        td.Error = true;
                      }
                    }
                  }
                }
label_41:
                for (int key1 = 0; key1 < ci.AllSprocData.Count; ++key1)
                {
                  SprocData sprocData = ci.AllSprocData[key1];
                  if (td.Error)
                  {
                    PoliciesStatus ps = new PoliciesStatus(td.PolicyNumber, td.EffectiveDate, td.TransactionAmount, td.RowNumber, " Policy failed during initial setup. ");
                    statusCollection.Add(td.PolicyNumber, td.RowNumber, td.TransactionAmount, ps);
                    if (td.CancelTransactions)
                    {
                      flag1 = true;
                      break;
                    }
                  }
                  else
                  {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                      command.CommandTimeout = 200;
                      command.CommandType = CommandType.StoredProcedure;
                      command.CommandText = sprocData.SprocName;
                      Dictionary<int, string> parameters = sprocData.Parameters;
                      for (int key2 = 0; key2 < parameters.Count; ++key2)
                      {
                        string str = parameters[key2];
                        object propertyObject = td.GetPropertyObject(td, str);
                        if (str != "TransactionAmount")
                        {
                          command.Parameters.AddWithValue(str, (object) propertyObject.ToString());
                        }
                        else
                        {
                          double result = 0.0;
                          double.TryParse(propertyObject.ToString(), out result);
                          if (result != 0.0)
                          {
                            command.Parameters.AddWithValue(str, (object) result);
                          }
                          else
                          {
                            LogFile logFile = new LogFile($"Transaction Amount for policy number = {td.PolicyNumber} is incorrectly formatted. Please check transaction amount and correct figure.", "Transaction Amount is incorrectly formatted.", "method btnImportFile_Click", ci.ErrorLogDirectory);
                            statusCollection.Add(td.PolicyNumber, td.RowNumber, td.TransactionAmount, new PoliciesStatus(td.PolicyNumber, td.EffectiveDate, td.TransactionAmount, td.RowNumber, "Transaction Amount is incorrectly formatted."));
                          }
                        }
                      }
                      bool? policyStatus = sprocData.PolicyStatus;
                      if (!policyStatus.HasValue)
                      {
                        try
                        {
                          if ((sprocData.SprocName != "ImportUtility_AdditionalInterests" || sprocData.SprocName == "ImportUtility_AdditionalInterests" && !string.IsNullOrEmpty(td.AdditionalInterestName)) && command.ExecuteNonQuery() <= 0 && sprocData.CheckReturn)
                          {
                            LogFile logFile = new LogFile($"Data was not successfully imported into necessary table for policy number = {td.PolicyNumber}. Please check sproc = {sprocData.SprocName}.", sprocData.CustomReturnErrorMessage, "method btnImportFile_Click", ci.ErrorLogDirectory);
                            statusCollection.Add(td.PolicyNumber, td.RowNumber, td.TransactionAmount, new PoliciesStatus(td.PolicyNumber, td.EffectiveDate, td.TransactionAmount, td.RowNumber, sprocData.CustomReturnErrorMessage));
                            td.Error = true;
                          }
                          if (sprocData.SprocName.ToLower().Contains("checkimportingpolicies"))
                          {
                            using (SqlDataReader sqlDataReader = command.ExecuteReader())
                            {
                              if (sqlDataReader.HasRows)
                              {
                                sqlDataReader.Read();
                                bool flag2 = false;
                                if (num1 != 0)
                                {
                                  TransactionData transactionData = list[num1 - 1];
                                  if (transactionData.PolicyNumber == td.PolicyNumber)
                                  {
                                    DateTime? effectiveDate1 = transactionData.EffectiveDate;
                                    DateTime? effectiveDate2 = td.EffectiveDate;
                                    if ((effectiveDate1.HasValue == effectiveDate2.HasValue ? (effectiveDate1.HasValue ? (effectiveDate1.GetValueOrDefault() == effectiveDate2.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && transactionData.TransactionAmount == td.TransactionAmount && !transactionData.DuplicateError)
                                      flag2 = true;
                                  }
                                }
                                if (!flag2)
                                {
                                  td.DuplicateError = true;
                                  int num2 = (int) MessageBox.Show($"Policy Number {sqlDataReader["PolicyNumber"].ToString()} with effective date {sqlDataReader["EffectiveDate"].ToString()} and transaction amount {$"{(Decimal) sqlDataReader["WrittenPremium"]:F2}"} was imported on {sqlDataReader["DateProcessed"].ToString()}. Do you want to continue importing this policy?", "Policy Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                                  if (num2 == 7)
                                    td.Error = true;
                                  if (num2 == 2)
                                  {
                                    td.Error = true;
                                    td.CancelTransactions = true;
                                  }
                                }
                              }
                            }
                          }
                        }
                        catch (Exception ex)
                        {
                          string errorLogDirectory = ci.ErrorLogDirectory;
                          int num3 = ci.AllDebugInfo ? 1 : 0;
                          MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (btnImportFile_Click), errorLogDirectory, num3 != 0, false);
                          td.Error = true;
                        }
                      }
                      else
                      {
                        policyStatus = sprocData.PolicyStatus;
                        if (policyStatus.HasValue)
                        {
                          if (sprocData.CheckReturn)
                          {
                            try
                            {
                              using (SqlDataReader sqlDataReader = command.ExecuteReader())
                              {
                                if (!sqlDataReader.HasRows)
                                {
                                  LogFile logFile = new LogFile($"Data was not successfully imported into necessary table for policy number = {td.PolicyNumber}. Please check sproc = {sprocData.SprocName}.", sprocData.CustomReturnErrorMessage, "method btnImportFile_Click", ci.ErrorLogDirectory);
                                  statusCollection.Add(td.PolicyNumber, td.RowNumber, td.TransactionAmount, new PoliciesStatus(td.PolicyNumber, td.EffectiveDate, td.TransactionAmount, td.RowNumber, sprocData.CustomReturnErrorMessage));
                                  td.Error = true;
                                  continue;
                                }
                                continue;
                              }
                            }
                            catch (Exception ex)
                            {
                              string errorLogDirectory = ci.ErrorLogDirectory;
                              int num4 = ci.AllDebugInfo ? 1 : 0;
                              MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (btnImportFile_Click), errorLogDirectory, num4 != 0, false);
                              td.Error = true;
                              continue;
                            }
                          }
                        }
                        policyStatus = sprocData.PolicyStatus;
                        if (policyStatus.HasValue)
                        {
                          if (sprocData.CheckValue)
                          {
                            try
                            {
                              using (SqlDataReader sqlDataReader = command.ExecuteReader())
                              {
                                if (!sqlDataReader.HasRows)
                                {
                                  LogFile logFile = new LogFile($"Data was not successfully imported into necessary table for policy number = {td.PolicyNumber}. Please check sproc = {sprocData.SprocName}.", sprocData.CustomReturnErrorMessage, "method btnImportFile_Click", ci.ErrorLogDirectory);
                                  statusCollection.Add(td.PolicyNumber, td.RowNumber, td.TransactionAmount, new PoliciesStatus(td.PolicyNumber, td.EffectiveDate, td.TransactionAmount, td.RowNumber, sprocData.CustomReturnErrorMessage));
                                  td.Error = true;
                                  continue;
                                }
                                sqlDataReader.Read();
                                if (sqlDataReader[0].ToString() != sprocData.CheckValueEquals)
                                {
                                  LogFile logFile = new LogFile($"The automation endorsement does not support policies with more than one state. Policy Number = {td.PolicyNumber} failed. Please check sproc = {sprocData.SprocName}.", sprocData.CustomReturnErrorMessage, "method btnImportFile_Click", ci.ErrorLogDirectory);
                                  statusCollection.Add(td.PolicyNumber, td.RowNumber, td.TransactionAmount, new PoliciesStatus(td.PolicyNumber, td.EffectiveDate, td.TransactionAmount, td.RowNumber, sprocData.CustomReturnErrorMessage));
                                  td.Error = true;
                                  continue;
                                }
                                continue;
                              }
                            }
                            catch (Exception ex)
                            {
                              string errorLogDirectory = ci.ErrorLogDirectory;
                              int num5 = ci.AllDebugInfo ? 1 : 0;
                              MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (btnImportFile_Click), errorLogDirectory, num5 != 0, false);
                              td.Error = true;
                              continue;
                            }
                          }
                        }
                        using (SqlDataReader sqlDataReader = command.ExecuteReader())
                        {
                          if (sqlDataReader != null)
                          {
                            if (sqlDataReader.HasRows)
                            {
                              sqlDataReader.Read();
                              PoliciesStatus ps = new PoliciesStatus(int.Parse(sqlDataReader["ControlNo"].ToString()), int.Parse(sqlDataReader["QuoteId"].ToString()), DateTime.Parse(sqlDataReader["DateProcessed"].ToString()), td.EffectiveDate, sqlDataReader["Insuredname"].ToString(), sqlDataReader["PolicyNumber"].ToString(), Decimal.Parse(sqlDataReader["GrossBooking"].ToString()), td.RowNumber, sprocData.PolicyStatus);
                              statusCollection.Add(td.PolicyNumber, td.RowNumber, td.TransactionAmount, ps);
                            }
                          }
                        }
                      }
                    }
                  }
                }
                ++num1;
              }
              else
                break;
            }
          }
          foreach (PoliciesStatus policiesStatus in statusCollection)
          {
            bool? insertSuccessful = policiesStatus.InsertSuccessful;
            int num;
            DateTime dateProcessed;
            if (insertSuccessful.HasValue)
            {
              insertSuccessful = policiesStatus.InsertSuccessful;
              if (bool.Parse(insertSuccessful.ToString()))
              {
                TextBox successfulImports = this.txtSuccessfulImports;
                TextBox textBox = successfulImports;
                string[] strArray = new string[15];
                strArray[0] = successfulImports.Text;
                strArray[1] = "Control No=";
                num = policiesStatus.ControlNo;
                strArray[2] = num.ToString();
                strArray[3] = " Quote Id=";
                num = policiesStatus.QuoteId;
                strArray[4] = num.ToString();
                strArray[5] = " Date Processed=";
                dateProcessed = policiesStatus.DateProcessed;
                strArray[6] = dateProcessed.ToString();
                strArray[7] = " Policy Number=";
                strArray[8] = policiesStatus.PolicyNumber;
                strArray[9] = " Transaction Amount=";
                strArray[10] = policiesStatus.TransactionAmount.ToString();
                strArray[11] = " (";
                num = policiesStatus.RowNumber;
                strArray[12] = num.ToString();
                strArray[13] = ")";
                strArray[14] = Environment.NewLine;
                string str = string.Concat(strArray);
                textBox.Text = str;
                continue;
              }
            }
            string str1 = "";
            string str2 = "";
            DateTime? effectiveDate = policiesStatus.EffectiveDate;
            if (!string.IsNullOrEmpty(effectiveDate.ToString()))
            {
              effectiveDate = policiesStatus.EffectiveDate;
              dateProcessed = effectiveDate.Value;
              str1 = " Effective Date = " + dateProcessed.ToShortDateString();
            }
            if (policiesStatus.TransactionAmount != 0.0M)
              str2 = " Transaction Amount = " + policiesStatus.TransactionAmount.ToString();
            if (!string.IsNullOrEmpty(policiesStatus.OptionalErrorMessage))
            {
              TextBox txtFailedImports = this.txtFailedImports;
              TextBox textBox = txtFailedImports;
              string[] strArray = new string[10]
              {
                txtFailedImports.Text,
                "Policy Number=",
                policiesStatus.PolicyNumber,
                str1,
                str2,
                " (",
                null,
                null,
                null,
                null
              };
              num = policiesStatus.RowNumber;
              strArray[6] = num.ToString();
              strArray[7] = ") . ";
              strArray[8] = policiesStatus.OptionalErrorMessage;
              strArray[9] = Environment.NewLine;
              string str3 = string.Concat(strArray);
              textBox.Text = str3;
            }
            else
            {
              TextBox txtFailedImports = this.txtFailedImports;
              TextBox textBox = txtFailedImports;
              string[] strArray = new string[9]
              {
                txtFailedImports.Text,
                "Policy Number=",
                policiesStatus.PolicyNumber,
                str1,
                str2,
                " (",
                null,
                null,
                null
              };
              num = policiesStatus.RowNumber;
              strArray[6] = num.ToString();
              strArray[7] = ") . ";
              strArray[8] = Environment.NewLine;
              string str4 = string.Concat(strArray);
              textBox.Text = str4;
            }
          }
          this.txtStatusDisplay.Text = "Finished processing file.";
          this.txtStatusDisplay.Refresh();
        }
      }
    }
    catch (CustomException ex)
    {
      MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (btnImportFile_Click), ci.ErrorLogDirectory, ci.AllDebugInfo, true);
      ErrorHandler.SilentHandleError((Exception) ex);
      this.txtStatusDisplay.Text = ex.Message;
      this.txtStatusDisplay.Refresh();
    }
    catch (OutOfMemoryException ex)
    {
      MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (btnImportFile_Click), ci.ErrorLogDirectory, ci.AllDebugInfo, false);
      ErrorHandler.SilentHandleError((Exception) ex);
      this.txtStatusDisplay.Text = ex.Message;
      this.txtStatusDisplay.Refresh();
    }
    catch (SqlException ex)
    {
      MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (btnImportFile_Click), ci.ErrorLogDirectory, ci.AllDebugInfo, false);
      ErrorHandler.SilentHandleError((Exception) ex);
      this.txtStatusDisplay.Text = ex.Message;
      this.txtStatusDisplay.Refresh();
    }
    catch (Exception ex)
    {
      MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling errorHandling = new MGASystems.IMS.Excel.ImportFileUtil.ErrorHandling(ex, nameof (btnImportFile_Click), ci.ErrorLogDirectory, ci.AllDebugInfo, false);
      ErrorHandler.SilentHandleError(ex);
      this.txtStatusDisplay.Text = ex.Message;
      this.txtStatusDisplay.Refresh();
    }
    this.btnImportFile.Enabled = true;
    this.Cursor = Cursors.Default;
  }

  public string getFileName(string directoryWithFile)
  {
    int startIndex = directoryWithFile.LastIndexOf("\\") + 1;
    int length = directoryWithFile.Length;
    return directoryWithFile.Substring(startIndex, length - startIndex);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.openImportFile = new OpenFileDialog();
    this.btnImportFile = new Button();
    this.grpSuccessfulImports = new GroupBox();
    this.txtSuccessfulImports = new TextBox();
    this.txtPassword = new TextBox();
    this.txtUserName = new TextBox();
    this.txtCatalog = new TextBox();
    this.txtDataSource = new TextBox();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.grpFailedImports = new GroupBox();
    this.txtFailedImports = new TextBox();
    this.lblFileLoaded = new Label();
    this.lblStatus = new Label();
    this.txtStatusDisplay = new TextBox();
    this.txtFileLoadedDisplay = new TextBox();
    this.grpSuccessfulImports.SuspendLayout();
    this.grpFailedImports.SuspendLayout();
    this.SuspendLayout();
    this.openImportFile.FileName = "openImportFile";
    this.btnImportFile.BackColor = SystemColors.ButtonHighlight;
    this.btnImportFile.Location = new Point(26, 12);
    this.btnImportFile.Name = "btnImportFile";
    this.btnImportFile.Size = new Size(75, 23);
    this.btnImportFile.TabIndex = 0;
    this.btnImportFile.Text = "Import File";
    this.btnImportFile.UseVisualStyleBackColor = false;
    this.btnImportFile.Click += new EventHandler(this.btnImportFile_Click);
    this.grpSuccessfulImports.Controls.Add((Control) this.txtSuccessfulImports);
    this.grpSuccessfulImports.Controls.Add((Control) this.txtPassword);
    this.grpSuccessfulImports.Controls.Add((Control) this.txtUserName);
    this.grpSuccessfulImports.Controls.Add((Control) this.txtCatalog);
    this.grpSuccessfulImports.Controls.Add((Control) this.txtDataSource);
    this.grpSuccessfulImports.Controls.Add((Control) this.label4);
    this.grpSuccessfulImports.Controls.Add((Control) this.label3);
    this.grpSuccessfulImports.Controls.Add((Control) this.label2);
    this.grpSuccessfulImports.Controls.Add((Control) this.label1);
    this.grpSuccessfulImports.Location = new Point(13, 95);
    this.grpSuccessfulImports.Name = "grpSuccessfulImports";
    this.grpSuccessfulImports.Size = new Size(740, 158);
    this.grpSuccessfulImports.TabIndex = 1;
    this.grpSuccessfulImports.TabStop = false;
    this.grpSuccessfulImports.Text = "Successful Imports";
    this.txtSuccessfulImports.Location = new Point(13, 19);
    this.txtSuccessfulImports.Multiline = true;
    this.txtSuccessfulImports.Name = "txtSuccessfulImports";
    this.txtSuccessfulImports.ScrollBars = ScrollBars.Both;
    this.txtSuccessfulImports.Size = new Size(707, 124);
    this.txtSuccessfulImports.TabIndex = 0;
    this.txtPassword.Location = new Point(108, 103);
    this.txtPassword.Name = "txtPassword";
    this.txtPassword.Size = new Size(330, 20);
    this.txtPassword.TabIndex = 7;
    this.txtUserName.Location = new Point(108, 77);
    this.txtUserName.Name = "txtUserName";
    this.txtUserName.Size = new Size(330, 20);
    this.txtUserName.TabIndex = 6;
    this.txtCatalog.Location = new Point(108, 51);
    this.txtCatalog.Name = "txtCatalog";
    this.txtCatalog.Size = new Size(330, 20);
    this.txtCatalog.TabIndex = 5;
    this.txtDataSource.Location = new Point(108, 25);
    this.txtDataSource.Name = "txtDataSource";
    this.txtDataSource.Size = new Size(330, 20);
    this.txtDataSource.TabIndex = 4;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(29, 106);
    this.label4.Name = "label4";
    this.label4.Size = new Size(62, 13);
    this.label4.TabIndex = 3;
    this.label4.Text = "Password =";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(29, 80 /*0x50*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(69, 13);
    this.label3.TabIndex = 2;
    this.label3.Text = "UserName = ";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(29, 54);
    this.label2.Name = "label2";
    this.label2.Size = new Size(55, 13);
    this.label2.TabIndex = 1;
    this.label2.Text = "Catalog = ";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(29, 28);
    this.label1.Name = "label1";
    this.label1.Size = new Size(73, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "DataSource =";
    this.grpFailedImports.Controls.Add((Control) this.txtFailedImports);
    this.grpFailedImports.Location = new Point(13, 259);
    this.grpFailedImports.Name = "grpFailedImports";
    this.grpFailedImports.Size = new Size(740, 145);
    this.grpFailedImports.TabIndex = 2;
    this.grpFailedImports.TabStop = false;
    this.grpFailedImports.Text = "Failedl Imports";
    this.txtFailedImports.Location = new Point(13, 19);
    this.txtFailedImports.Multiline = true;
    this.txtFailedImports.Name = "txtFailedImports";
    this.txtFailedImports.ScrollBars = ScrollBars.Both;
    this.txtFailedImports.Size = new Size(707, 112 /*0x70*/);
    this.txtFailedImports.TabIndex = 1;
    this.lblFileLoaded.AutoSize = true;
    this.lblFileLoaded.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblFileLoaded.Location = new Point(107, 9);
    this.lblFileLoaded.Name = "lblFileLoaded";
    this.lblFileLoaded.Size = new Size(73, 13);
    this.lblFileLoaded.TabIndex = 3;
    this.lblFileLoaded.Text = "File Loaded";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.Location = new Point(35, 45);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(43, 13);
    this.lblStatus.TabIndex = 5;
    this.lblStatus.Text = "Status";
    this.txtStatusDisplay.BorderStyle = BorderStyle.None;
    this.txtStatusDisplay.Location = new Point(110, 45);
    this.txtStatusDisplay.Multiline = true;
    this.txtStatusDisplay.Name = "txtStatusDisplay";
    this.txtStatusDisplay.Size = new Size(623, 44);
    this.txtStatusDisplay.TabIndex = 7;
    this.txtFileLoadedDisplay.BorderStyle = BorderStyle.None;
    this.txtFileLoadedDisplay.Location = new Point(186, 7);
    this.txtFileLoadedDisplay.Multiline = true;
    this.txtFileLoadedDisplay.Name = "txtFileLoadedDisplay";
    this.txtFileLoadedDisplay.Size = new Size(547, 32 /*0x20*/);
    this.txtFileLoadedDisplay.TabIndex = 8;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.ControlLight;
    this.ClientSize = new Size(765, 416);
    this.Controls.Add((Control) this.txtFileLoadedDisplay);
    this.Controls.Add((Control) this.txtStatusDisplay);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.lblFileLoaded);
    this.Controls.Add((Control) this.grpFailedImports);
    this.Controls.Add((Control) this.grpSuccessfulImports);
    this.Controls.Add((Control) this.btnImportFile);
    this.Name = nameof (frmImportFileUtility);
    this.Text = "Import File Utility";
    this.grpSuccessfulImports.ResumeLayout(false);
    this.grpSuccessfulImports.PerformLayout();
    this.grpFailedImports.ResumeLayout(false);
    this.grpFailedImports.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
