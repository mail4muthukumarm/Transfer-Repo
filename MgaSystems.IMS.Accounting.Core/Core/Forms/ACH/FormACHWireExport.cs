// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.FormACHWireExport
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using ChoETL.NACHA;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class FormACHWireExport : FormBase
{
  protected int GLAcctID;
  protected int GLCompanyID;
  protected string serviceClassCode = "PPD";
  protected string CompanyDiscretionaryData = "Desc Data";
  protected uint BlockFactor = 10;
  private string ACHFileName;
  private string ACHFileFullPathName;
  private int ACHBatchNumber;
  protected string sprocName = "spFin_GetReadyACH";
  protected string multiACHsprocName = "dbo.spFin_GetReadyACH_Multi";
  private IContainer components;
  private Panel panel1;
  private MGASimpleComboBox comboBankAccounts;
  private MGASimpleComboBox comboGLCompanies;
  protected StatusStrip statusStrip1;
  protected ToolStripStatusLabel toolLoadStatus;
  protected ToolStripProgressBar toolStripProgressBar1;
  private SaveFileDialog saveFileDialog1;
  private LinkLabel linkUnselectAll;
  private LinkLabel linkSelectAll;
  private MGASimpleComboBox comboACHTranactionsCodes;
  public UltraGrid gridACHWireResults;
  private Panel panel4;
  protected Label labelOfficeLocation;
  protected Label lblBankAccount;
  protected Label lblTransactionCode;
  private MGAButton buttonCancel;
  private MGATextBox textACHExportTotal;
  protected Label label1;
  protected Label labelServiceCode;
  private PictureBox picCalculateTotal;
  private MGASimpleComboBox comboACHServiceCodes;
  private Panel panel3;
  protected dsACHPayablesExport dsACHPayablesExport1;
  protected MGAButton buttonLoadACHPayables;
  protected MGAButton buttonExportACHResults;
  protected MGAButton buttonMGAExport;
  protected Panel panel2;
  private MGADateTimePicker dateTimeEffectiveDate;
  protected Label labelEffectiveDate;
  protected Label labelCompanyEntryDesc;
  protected MGATextBox textboxCompanyEntryDesc;

  public FormACHWireExport()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
    if (!(CurrentUser.Instance.UserName.ToUpper() != "ADMIN1"))
      return;
    ((Control) this.buttonMGAExport).Visible = false;
    ((Control) this.buttonMGAExport).Enabled = false;
  }

  private void LoadGLCompanies()
  {
    ((UltraGridBase) this.comboGLCompanies).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations");
    ((UltraDropDownBase) this.comboGLCompanies).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboGLCompanies).ValueMember = "ID";
    this.comboGLCompanies.Value = (object) CurrentUser.Instance.OfficeID;
  }

  protected virtual void LoadACHTransactionCodes()
  {
    ((UltraGridBase) this.comboACHTranactionsCodes).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetACHTransactionCodes");
    ((UltraDropDownBase) this.comboACHTranactionsCodes).DisplayMember = "ACHTransactionDescription";
    ((UltraDropDownBase) this.comboACHTranactionsCodes).ValueMember = "ACHTransactionCodeId";
  }

  private void LoadACHServiceCodes()
  {
    ((UltraGridBase) this.comboACHServiceCodes).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetACHServiceCodes");
    ((UltraDropDownBase) this.comboACHServiceCodes).DisplayMember = "ACHServiceCodeDescription";
    ((UltraDropDownBase) this.comboACHServiceCodes).ValueMember = "ACHServiceCodeId";
  }

  protected virtual void LoadReadyWires(int BankID)
  {
    this.dsACHPayablesExport1.Clear();
    if (CurrentUser.Instance.UserName.ToUpper() != "ADMIN1")
    {
      ((Control) this.buttonMGAExport).Visible = false;
      ((Control) this.buttonMGAExport).Enabled = false;
    }
    else
    {
      ((Control) this.buttonMGAExport).Visible = true;
      ((Control) this.buttonMGAExport).Enabled = true;
    }
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.statusStrip1.Visible = true;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("Accessing Database...... ");
      this.toolLoadStatus.Text = stringBuilder.ToString();
      this.statusStrip1.Refresh();
      this.panel2.Refresh();
      List<object> objectList = new List<object>()
      {
        (object) "@glaccountid",
        (object) this.GLAcctID
      };
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings"))
      {
        this.sprocName = this.multiACHsprocName;
      }
      else
      {
        objectList.Add((object) "@glcompanyid");
        objectList.Add((object) this.GLCompanyID);
      }
      using (DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, this.sprocName, 0, (CommandArgumentType) 0, objectList.ToArray()))
      {
        if (dataTable == null || dataTable.Rows.Count == 0)
        {
          int num = (int) MessageBox.Show("The system has not found any ACH payees.", "No Data Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.Cursor = MgaCursors.Default;
          this.statusStrip1.Visible = false;
          this.toolLoadStatus.Text = string.Empty;
          this.statusStrip1.Refresh();
          this.panel2.Refresh();
        }
        else
        {
          foreach (DataRow row1 in (InternalDataCollectionBase) dataTable.Rows)
          {
            dsACHPayablesExport.ACHPayeesRow row2 = this.dsACHPayablesExport1.ACHPayees.NewACHPayeesRow();
            row2.SelectPayee = false;
            row2.PayeeGUID = new Guid(row1["PayeeGuid"].ToString());
            row2.User = row1["User"].ToString();
            row2.Addendum = string.Empty;
            row2.TransactNum = (int) row1["transactnum"];
            row2.Payee = row1["Payee"].ToString();
            row2.Bank_Name = row1["Bank Name"].ToString();
            row2.Account_Type = row1["Account Type"].ToString();
            row2.Routing_Number = this.DecryptValue(row1["Routing Number"].ToString());
            row2.Account_Number = this.DecryptValue(row1["Account Number"].ToString());
            row2.Amount = (Decimal) row1["Amount"];
            this.dsACHPayablesExport1.ACHPayees.AddACHPayeesRow(row2);
          }
          this.statusStrip1.Visible = false;
          this.toolLoadStatus.Text = string.Empty;
          this.statusStrip1.Refresh();
          this.panel2.Refresh();
        }
      }
    }
    finally
    {
      this.toolLoadStatus.Text = string.Empty;
      this.statusStrip1.Visible = false;
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void ExportWires()
  {
    if (this.VerifyForm())
    {
      this.statusStrip1.Visible = true;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("Preparing to export...... ");
      this.toolLoadStatus.Text = stringBuilder.ToString();
      this.statusStrip1.Refresh();
      this.panel2.Refresh();
      ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Bands[0].ColumnFilters["SelectPayee"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
      ((UltraGridBase) this.gridACHWireResults).UpdateData();
      if (((UltraGridBase) this.gridACHWireResults).Rows.GetFilteredInNonGroupByRows().Length == 0)
      {
        int num = (int) MessageBox.Show("You have not selected any rows for ACH Export.", "Nothing Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      this.ExportNACHAFormat();
    }
    if (MessageBox.Show("Did the export complete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !this.VerifyForm())
      return;
    this.statusStrip1.Visible = true;
    StringBuilder stringBuilder1 = new StringBuilder();
    stringBuilder1.Append("Posting ACH Payees...... ");
    this.toolLoadStatus.Text = stringBuilder1.ToString();
    this.statusStrip1.Refresh();
    this.panel2.Refresh();
    this.PostWireRowsExported();
    this.statusStrip1.Visible = true;
    new StringBuilder().Append("ACH Payees posting completed.....");
    this.toolLoadStatus.Text = stringBuilder1.ToString();
    this.statusStrip1.Refresh();
    this.panel2.Refresh();
  }

  protected virtual void ExportWiresAsTest()
  {
    if (this.VerifyForm())
    {
      this.statusStrip1.Visible = true;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("Preparing to export...... ");
      this.toolLoadStatus.Text = stringBuilder.ToString();
      this.statusStrip1.Refresh();
      this.panel2.Refresh();
      ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Bands[0].ColumnFilters["SelectPayee"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
      ((UltraGridBase) this.gridACHWireResults).UpdateData();
      if (((UltraGridBase) this.gridACHWireResults).Rows.GetFilteredInNonGroupByRows().Length == 0)
      {
        int num = (int) MessageBox.Show("You have not selected any rows for ACH Export.", "Nothing Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      this.ExportNACHAFormat();
    }
    if (MessageBox.Show("Did the export complete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !this.VerifyForm())
      return;
    this.statusStrip1.Visible = true;
    StringBuilder stringBuilder1 = new StringBuilder();
    stringBuilder1.Append("ACH File will be posted when live...... ");
    this.toolLoadStatus.Text = stringBuilder1.ToString();
    this.statusStrip1.Refresh();
    this.panel2.Refresh();
    this.statusStrip1.Visible = true;
    new StringBuilder().Append("ACH Rows will be posted when live.....");
    this.toolLoadStatus.Text = stringBuilder1.ToString();
    this.statusStrip1.Refresh();
    this.panel2.Refresh();
  }

  protected virtual void UploadACHFile()
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        byte[] numArray;
        using (FileStream input = new FileStream(this.ACHFileFullPathName, FileMode.Open, FileAccess.Read))
        {
          using (BinaryReader binaryReader = new BinaryReader((Stream) input))
            numArray = binaryReader.ReadBytes((int) input.Length);
        }
        DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertACHFile", new object[8]
        {
          (object) "@BatchID",
          (object) this.ACHBatchNumber,
          (object) "@FileName",
          (object) this.ACHFileName,
          (object) "@File",
          (object) numArray,
          (object) "@User",
          (object) CurrentUser.Instance.UserGUID
        });
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw ex;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      e.Transaction.Commit();
    }));
    CurrentUser.Instance.LogAction($"The following ACH file was committed to the database.  FileName: {this.ACHFileName} , Containing Batch ID: {this.ACHBatchNumber}", "ACH Logs");
  }

  protected virtual void ExportNACHAFormat()
  {
    MGANACHAConfigCollection configCollection = new MGANACHAConfigCollection(this.GLAcctID, (int) this.comboACHServiceCodes.Value);
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.FileName = configCollection.MGAACHFileName;
    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    saveFileDialog.Title = "Please choose a destination for file";
    saveFileDialog.DefaultExt = "txt";
    saveFileDialog.CheckPathExists = true;
    configCollection.MGAEntryClassCode = this.serviceClassCode;
    configCollection.MGACompanyEntryDescription = ((TextEditorControlBase) this.textboxCompanyEntryDesc).Value.ToString();
    configCollection.BlockingFactor = this.BlockFactor;
    if (saveFileDialog.ShowDialog() == DialogResult.OK)
      configCollection.MGAACHFullPathFileName = saveFileDialog.FileName;
    using (ChoNACHAWriter choNachaWriter1 = new ChoNACHAWriter(configCollection.MGAACHFullPathFileName, configCollection.MGANACHAConfig))
    {
      ChoNACHAWriter choNachaWriter2 = choNachaWriter1;
      int num1 = (int) this.comboACHServiceCodes.Value;
      DateTime? nullable1 = new DateTime?(this.dateTimeEffectiveDate.DateTime.Date);
      string mgaEntryClassCode = configCollection.MGAEntryClassCode;
      string entryDescription = configCollection.MGACompanyEntryDescription;
      string mgaCompanyId = configCollection.MGACompanyID;
      string discretionaryData = this.CompanyDiscretionaryData;
      DateTime? nullable2 = new DateTime?();
      DateTime? nullable3 = nullable1;
      string str1 = discretionaryData;
      string str2 = mgaCompanyId;
      using (ChoNACHABatchWriter batch = choNachaWriter2.CreateBatch(num1, mgaEntryClassCode, entryDescription, nullable2, nullable3, (string) null, str1, '1', (string) null, str2, (string) null, "USD", "USD"))
      {
        if (configCollection.MGAServiceCodeType.ToUpper() == "DEBIT")
        {
          foreach (UltraGridRow row in ((UltraGridBase) this.gridACHWireResults).Rows)
          {
            if (row.Cells["selectPayee"].Value != null)
            {
              if ((bool) row.Cells["selectPayee"].Value)
              {
                using (ChoNACHAEntryDetailWriter debitEntryDetail = batch.CreateDebitEntryDetail((int) this.comboACHTranactionsCodes.Value, row.Cells["Routing Number"].Value.ToString(), row.Cells["Account Number"].Value.ToString(), (Decimal) row.Cells["Amount"].Value, row.Cells["transactnum"].Value.ToString(), row.Cells["Payee"].Value.ToString().ToUpper(), this.CompanyDiscretionaryData))
                {
                  if (!string.IsNullOrEmpty(row.Cells["Addendum"].Value.ToString()))
                    debitEntryDetail.CreateAddendaRecord(row.Cells["Addendum"].Value.ToString(), 5U);
                }
              }
              this.statusStrip1.Visible = true;
              StringBuilder stringBuilder = new StringBuilder();
              stringBuilder.Append("Exporting...... ");
              stringBuilder.Append(row.Cells["Payee"].Value.ToString());
              this.toolLoadStatus.Text = stringBuilder.ToString();
              this.statusStrip1.Refresh();
              this.panel2.Refresh();
            }
          }
        }
        else if (configCollection.MGAServiceCodeType.ToUpper() == "CREDIT")
        {
          foreach (UltraGridRow row in ((UltraGridBase) this.gridACHWireResults).Rows)
          {
            if (row.Cells["selectPayee"].Value != null)
            {
              if ((bool) row.Cells["selectPayee"].Value)
              {
                using (ChoNACHAEntryDetailWriter creditEntryDetail = batch.CreateCreditEntryDetail((int) this.comboACHTranactionsCodes.Value, row.Cells["Routing Number"].Value.ToString(), row.Cells["Account Number"].Value.ToString(), (Decimal) row.Cells["Amount"].Value, row.Cells["transactnum"].Value.ToString(), row.Cells["Payee"].Value.ToString().ToUpper(), this.CompanyDiscretionaryData))
                {
                  if (!string.IsNullOrEmpty(row.Cells["Addendum"].Value.ToString()))
                    creditEntryDetail.CreateAddendaRecord(row.Cells["Addendum"].Value.ToString(), 5U);
                }
              }
              this.statusStrip1.Visible = true;
              StringBuilder stringBuilder = new StringBuilder();
              stringBuilder.Append("Exporting...... ");
              stringBuilder.Append(row.Cells["Payee"].Value.ToString());
              this.toolLoadStatus.Text = stringBuilder.ToString();
              this.statusStrip1.Refresh();
              this.panel2.Refresh();
            }
          }
        }
        else if (configCollection.MGAServiceCodeType.ToUpper() == "BOTH")
        {
          foreach (UltraGridRow row in ((UltraGridBase) this.gridACHWireResults).Rows)
          {
            if (row.Cells["selectPayee"].Value != null)
            {
              if ((bool) row.Cells["selectPayee"].Value)
              {
                using (ChoNACHAEntryDetailWriter debitEntryDetail = batch.CreateDebitEntryDetail((int) this.comboACHTranactionsCodes.Value, row.Cells["Routing Number"].Value.ToString(), row.Cells["Account Number"].Value.ToString(), (Decimal) row.Cells["Amount"].Value, row.Cells["transactnum"].Value.ToString(), row.Cells["Payee"].Value.ToString().ToUpper(), "Desc Data"))
                {
                  if (!string.IsNullOrEmpty(row.Cells["Addendum"].Value.ToString()))
                    debitEntryDetail.CreateAddendaRecord(row.Cells["Addendum"].Value.ToString(), 5U);
                }
              }
              using (ChoNACHAEntryDetailWriter creditEntryDetail = batch.CreateCreditEntryDetail((int) this.comboACHTranactionsCodes.Value, row.Cells["Routing Number"].Value.ToString(), row.Cells["Account Number"].Value.ToString(), (Decimal) row.Cells["Amount"].Value, row.Cells["transactnum"].Value.ToString(), row.Cells["Payee"].Value.ToString().ToUpper(), "Desc Data"))
              {
                if (!string.IsNullOrEmpty(row.Cells["Addendum"].Value.ToString()))
                  creditEntryDetail.CreateAddendaRecord(row.Cells["Addendum"].Value.ToString(), 5U);
              }
              this.statusStrip1.Visible = true;
              StringBuilder stringBuilder = new StringBuilder();
              stringBuilder.Append("Exporting...... ");
              stringBuilder.Append(row.Cells["Payee"].Value.ToString());
              this.toolLoadStatus.Text = stringBuilder.ToString();
              this.statusStrip1.Refresh();
              this.panel2.Refresh();
            }
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("The service code selected can create the file.", "Service Code Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.ToggleSelectAll(false);
          return;
        }
      }
    }
    this.ACHBatchNumber = configCollection.MGABatchNumber;
    this.ACHFileName = configCollection.MGAACHFileName;
    this.ACHFileFullPathName = configCollection.MGAACHFullPathFileName;
    this.statusStrip1.Visible = false;
  }

  protected virtual void PostWireRowsExported()
  {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.RowFilterMode = (RowFilterMode) 1;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Bands[0].ColumnFilters["selectPayee"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    ((UltraGridBase) this.gridACHWireResults).UpdateData();
    if (((UltraGridBase) this.gridACHWireResults).Rows.GetFilteredInNonGroupByRows().Length == 0)
    {
      int num1 = (int) MessageBox.Show("You have not selected any rows to post.", "Nothing Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      try
      {
        for (int index = 0; index < ((UltraGridBase) this.gridACHWireResults).Rows.GetFilteredInNonGroupByRows().Length; ++index)
        {
          this.statusStrip1.Visible = true;
          StringBuilder stringBuilder = new StringBuilder();
          stringBuilder.Append("Processing ");
          stringBuilder.Append(((UltraGridBase) this.gridACHWireResults).Rows.GetFilteredInNonGroupByRows()[index].Cells["Payee"].Value.ToString());
          this.toolLoadStatus.Text = stringBuilder.ToString();
          this.statusStrip1.Refresh();
          this.panel2.Refresh();
          this.PostRow(((UltraGridBase) this.gridACHWireResults).Rows.GetFilteredInNonGroupByRows()[index], stringBuilder.ToString());
        }
      }
      finally
      {
        this.toolStripProgressBar1.Visible = false;
        this.statusStrip1.Visible = false;
        stopwatch.Stop();
        Console.WriteLine((stopwatch.ElapsedMilliseconds * 1000L).ToString());
      }
      int num2 = (int) MessageBox.Show("Processing completed successfully.", "Processing Complete!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  private void PostRow(UltraGridRow row, string processingStatus)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertACHSentPayment", new object[16 /*0x10*/]
        {
          (object) "@payeeguid",
          (object) Guid.Parse(row.Cells["PayeeGuid"].Value.ToString()),
          (object) "@payeeAmt",
          row.Cells["Amount"].Value,
          (object) "@transactnum",
          row.Cells["transactnum"].Value,
          (object) "@Payer",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@Addendum",
          row.Cells["Addendum"].Value,
          (object) "@TransactionCode",
          (object) (int) this.comboACHTranactionsCodes.Value,
          (object) "@ServiceCode",
          (object) (int) this.comboACHServiceCodes.Value,
          (object) "@BatchID",
          (object) this.ACHBatchNumber
        });
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw ex;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      ((AppearanceBase) row.CellAppearance).BackColor = Color.LightGray;
      e.Transaction.Commit();
    }));
    CurrentUser.Instance.LogAction($"The following ACH payment was committed to the database.  Payee: {row.Cells["Payee"]} , Pay Amt: {row.Cells["Amount"]}, Transaction #: {row.Cells["transactnum"]}", "ACH Logs");
  }

  private void FormACHWireExport_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadGLCompanies();
  }

  private void comboGLCompanies_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboGLCompanies).SelectedRow == null)
      return;
    ((UltraGridBase) this.comboBankAccounts).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetBankAccounts", new object[2]
    {
      (object) "@GLCOMPANYID",
      (object) (int) this.comboGLCompanies.Value
    });
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "bankname";
    ((UltraDropDownBase) this.comboBankAccounts).ValueMember = "glacctid";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboBankAccounts).Rows).Count != 1)
      return;
    this.comboBankAccounts.Value = ((UltraGridBase) this.comboBankAccounts).Rows[0].Cells["glacctid"].Value;
  }

  private void comboBankAccounts_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (this.comboBankAccounts.Value != null && int.Parse(this.comboBankAccounts.Value.ToString()) > 0)
    {
      this.GLAcctID = int.Parse(this.comboBankAccounts.Value.ToString());
      this.GLCompanyID = int.Parse(this.comboGLCompanies.Value.ToString());
    }
    this.LoadACHTransactionCodes();
    this.LoadACHServiceCodes();
  }

  private bool VerifyForm()
  {
    if (((UltraDropDownBase) this.comboGLCompanies).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("Please choose a office location from which you would like to export the ACH payables.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboBankAccounts).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("Please choose a bank from which you would like to export the ACH payables.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridACHWireResults).Rows).Count == 0)
    {
      int num = (int) MessageBox.Show("The office and bank combination supplied has produced no ACH payables.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboACHTranactionsCodes).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("Please choose a transaction code.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboACHServiceCodes).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("Please choose a service code for the current ACH payables ready to be posted.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dateTimeEffectiveDate.Value == null || this.dateTimeEffectiveDate.Value == null)
    {
      int num = (int) MessageBox.Show("You must supply an effective date for ACH payables.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!string.IsNullOrEmpty(((Control) this.textboxCompanyEntryDesc).Text))
      return true;
    int num1 = (int) MessageBox.Show("You must supply an entry description.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void gridACHWireResults_InitializeRow(object sender, InitializeRowEventArgs e)
  {
  }

  protected string DecryptValue(string valueString)
  {
    Encryption encryption = new Encryption();
    if (!string.IsNullOrEmpty(valueString.ToString()) && Utility.IsBase64(valueString.ToString()))
      return encryption.DecryptTripleDes(valueString.ToString());
    return string.IsNullOrEmpty(valueString.ToString()) ? string.Empty : valueString;
  }

  private void gridACHWireResults_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Bands[0];
    if (!((KeyedSubObjectsCollectionBase) band.Columns).Exists("Addendum"))
      band.Columns.Add("Addendum", "Addendum");
    band.Columns["Addendum"].CellClickAction = (CellClickAction) 1;
    foreach (UltraGridColumn column in band.Columns)
    {
      if (((KeyedSubObjectBase) column).Key != "Addendum" && ((KeyedSubObjectBase) column).Key != "SelectPayee")
        band.Columns[((KeyedSubObjectBase) column).Key].CellClickAction = (CellClickAction) 3;
    }
  }

  private void linkSelectAll_Click(object sender, EventArgs e) => this.ToggleSelectAll(true);

  private void linkUnselectAll_Click(object sender, EventArgs e) => this.ToggleSelectAll(false);

  protected void ToggleSelectAll(bool value)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridACHWireResults).Rows).Count == 0)
      return;
    for (int index = 0; index < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridACHWireResults).Rows).Count; ++index)
    {
      this.Cursor = MgaCursors.WaitCursor;
      ((UltraGridBase) this.gridACHWireResults).Rows[index].Cells["SelectPayee"].Value = (object) value;
      ((UltraGridBase) this.gridACHWireResults).Rows[index].Update();
      this.Cursor = MgaCursors.Default;
    }
    ((UltraGridBase) this.gridACHWireResults).UpdateData();
  }

  private void buttonLoadACHPayables_Click(object sender, EventArgs e)
  {
    this.LoadReadyWires(this.GLAcctID);
  }

  private void picCalculateTotal_Click(object sender, EventArgs e) => this.CalculateAllTotal();

  protected virtual void CalculateAllTotal()
  {
    ((Control) this.textACHExportTotal).Text = "Calculating...";
    Decimal ACHsTotal = 0M;
    ((UltraGridBase) this.gridACHWireResults).UpdateData();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) =>
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridACHWireResults).Rows)
        {
          if (row.Cells["selectPayee"].Value != null && (bool) row.Cells["selectPayee"].Value)
            ACHsTotal += (Decimal) row.Cells["Amount"].Value;
        }
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) => ((Control) this.textACHExportTotal).Text = ACHsTotal.ToString("c"));
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void buttonExportACHResults_Click(object sender, EventArgs e) => this.ExportWires();

  private void buttonMGAExport_Click(object sender, EventArgs e) => this.ExportWiresAsTest();

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("ACHPayees", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("TransactNum", -1, (object) null, 508128032, 0, 0);
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Payee", -1, (object) null, 508128032, 4, 0);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Bank Name", -1, (object) null, 508128032, 5, 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Account Type", -1, (object) null, 508128032, 6, 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Routing Number", -1, (object) null, 508128032, 7, 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Account Number", -1, (object) null, 508128032, 8, 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Amount", -1, (object) null, 508128032, 9, 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("User", -1, (object) null, 508128032, 2, 0);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("PayeeGUID", -1, (object) null, 508128032, 1, 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("SelectPayee", -1, (object) null, 508128032, 3, 0);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Addendum", -1, (object) null, 508128032, 10, 1, 0, (SortIndicator) 1, false);
    UltraGridGroup ultraGridGroup = new UltraGridGroup("ACHPayeesGroup", 508128032);
    SummarySettings summarySettings = new SummarySettings("", (SummaryType) 1, (string) null, "Amount", 6, true, "ACHPayees", 0, (SummaryPosition) 3, "Amount", 6, true);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    this.panel1 = new Panel();
    this.gridACHWireResults = new UltraGrid();
    this.dsACHPayablesExport1 = new dsACHPayablesExport();
    this.panel2 = new Panel();
    this.linkUnselectAll = new LinkLabel();
    this.linkSelectAll = new LinkLabel();
    this.statusStrip1 = new StatusStrip();
    this.toolLoadStatus = new ToolStripStatusLabel();
    this.toolStripProgressBar1 = new ToolStripProgressBar();
    this.saveFileDialog1 = new SaveFileDialog();
    this.panel4 = new Panel();
    this.textboxCompanyEntryDesc = new MGATextBox();
    this.labelCompanyEntryDesc = new Label();
    this.labelEffectiveDate = new Label();
    this.dateTimeEffectiveDate = new MGADateTimePicker();
    this.comboACHServiceCodes = new MGASimpleComboBox();
    this.picCalculateTotal = new PictureBox();
    this.labelServiceCode = new Label();
    this.label1 = new Label();
    this.textACHExportTotal = new MGATextBox();
    this.buttonMGAExport = new MGAButton();
    this.buttonExportACHResults = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.buttonLoadACHPayables = new MGAButton();
    this.lblTransactionCode = new Label();
    this.comboACHTranactionsCodes = new MGASimpleComboBox();
    this.lblBankAccount = new Label();
    this.labelOfficeLocation = new Label();
    this.comboBankAccounts = new MGASimpleComboBox();
    this.comboGLCompanies = new MGASimpleComboBox();
    this.panel3 = new Panel();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.gridACHWireResults).BeginInit();
    this.dsACHPayablesExport1.BeginInit();
    this.panel2.SuspendLayout();
    this.statusStrip1.SuspendLayout();
    this.panel4.SuspendLayout();
    ((ISupportInitialize) this.textboxCompanyEntryDesc).BeginInit();
    ((ISupportInitialize) this.dateTimeEffectiveDate).BeginInit();
    ((ISupportInitialize) this.comboACHServiceCodes).BeginInit();
    ((ISupportInitialize) this.picCalculateTotal).BeginInit();
    ((ISupportInitialize) this.textACHExportTotal).BeginInit();
    ((ISupportInitialize) this.buttonMGAExport).BeginInit();
    ((ISupportInitialize) this.buttonExportACHResults).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonLoadACHPayables).BeginInit();
    ((ISupportInitialize) this.comboACHTranactionsCodes).BeginInit();
    ((ISupportInitialize) this.comboBankAccounts).BeginInit();
    ((ISupportInitialize) this.comboGLCompanies).BeginInit();
    this.SuspendLayout();
    this.panel1.Controls.Add((Control) this.gridACHWireResults);
    this.panel1.Controls.Add((Control) this.panel2);
    this.panel1.Location = new Point(282, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(883, 654);
    this.panel1.TabIndex = 7;
    ((UltraGridBase) this.gridACHWireResults).DataSource = (object) this.dsACHPayablesExport1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 8;
    ultraGridColumn2.Width = 179;
    ultraGridColumn3.Width = 182;
    ultraGridColumn4.Width = 88;
    ultraGridColumn5.Width = 125;
    ultraGridColumn6.Width = 125;
    ultraGridColumn7.Format = "c";
    ultraGridColumn7.Width = 150;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 8;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.DefaultCellValue = (object) "false";
    ((HeaderBase) ultraGridColumn10.Header).Caption = "";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Style = (ColumnStyle) 3;
    ultraGridColumn10.Width = 32 /*0x20*/;
    ultraGridColumn11.ColSpan = (short) 2;
    ultraGridColumn11.Width = 881;
    ultraGridBand.Columns.AddRange(new object[11]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup).Key = "ACHPayeesGroup";
    ultraGridGroup.RowLayoutGroupInfo.LabelSpan = 1;
    ultraGridBand.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup
    });
    ultraGridBand.LevelCount = 2;
    summarySettings.DisplayFormat = "{0:c}";
    ultraGridBand.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings
    });
    ultraGridBand.SummaryFooterCaption = "ACH Total:";
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridACHWireResults).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridACHWireResults).Dock = DockStyle.Fill;
    ((Control) this.gridACHWireResults).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridACHWireResults).Location = new Point(0, 0);
    ((Control) this.gridACHWireResults).Name = "gridACHWireResults";
    ((Control) this.gridACHWireResults).Size = new Size(883, 654);
    ((Control) this.gridACHWireResults).TabIndex = 19;
    this.gridACHWireResults.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridACHWireResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridACHWireResults).UseOsThemes = (DefaultableBoolean) 2;
    this.gridACHWireResults.InitializeLayout += new InitializeLayoutEventHandler(this.gridACHWireResults_InitializeLayout);
    this.dsACHPayablesExport1.DataSetName = "dsACHPayablesExport";
    this.dsACHPayablesExport1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.panel2.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.panel2.Controls.Add((Control) this.linkUnselectAll);
    this.panel2.Controls.Add((Control) this.linkSelectAll);
    this.panel2.Controls.Add((Control) this.statusStrip1);
    this.panel2.Font = new Font("Tahoma", 8.25f);
    this.panel2.Location = new Point(0, 651);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(883, 24);
    this.panel2.TabIndex = 12;
    this.linkUnselectAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.linkUnselectAll.AutoSize = true;
    this.linkUnselectAll.LinkArea = new LinkArea(0, 13);
    this.linkUnselectAll.Location = new Point(-200, 8);
    this.linkUnselectAll.Name = "linkUnselectAll";
    this.linkUnselectAll.Size = new Size(67, 13);
    this.linkUnselectAll.TabIndex = 5;
    this.linkUnselectAll.TabStop = true;
    this.linkUnselectAll.Text = "Un-Select All";
    this.linkUnselectAll.Click += new EventHandler(this.linkUnselectAll_Click);
    this.linkSelectAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.linkSelectAll.AutoSize = true;
    this.linkSelectAll.Location = new Point(-269, 8);
    this.linkSelectAll.Name = "linkSelectAll";
    this.linkSelectAll.Size = new Size(50, 13);
    this.linkSelectAll.TabIndex = 4;
    this.linkSelectAll.TabStop = true;
    this.linkSelectAll.Text = "Select All";
    this.linkSelectAll.Click += new EventHandler(this.linkSelectAll_Click);
    this.statusStrip1.Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.toolLoadStatus,
      (ToolStripItem) this.toolStripProgressBar1
    });
    this.statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
    this.statusStrip1.Location = new Point(0, 2);
    this.statusStrip1.Name = "statusStrip1";
    this.statusStrip1.Size = new Size(883, 22);
    this.statusStrip1.TabIndex = 0;
    this.statusStrip1.Text = "statusStrip1";
    this.statusStrip1.Visible = false;
    this.toolLoadStatus.BorderStyle = Border3DStyle.SunkenOuter;
    this.toolLoadStatus.Name = "toolLoadStatus";
    this.toolLoadStatus.Size = new Size(0, 17);
    this.toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
    this.toolStripProgressBar1.Name = "toolStripProgressBar1";
    this.toolStripProgressBar1.Size = new Size(200, 16 /*0x10*/);
    this.toolStripProgressBar1.Step = 1;
    this.panel4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.panel4.Controls.Add((Control) this.textboxCompanyEntryDesc);
    this.panel4.Controls.Add((Control) this.labelCompanyEntryDesc);
    this.panel4.Controls.Add((Control) this.labelEffectiveDate);
    this.panel4.Controls.Add((Control) this.dateTimeEffectiveDate);
    this.panel4.Controls.Add((Control) this.comboACHServiceCodes);
    this.panel4.Controls.Add((Control) this.picCalculateTotal);
    this.panel4.Controls.Add((Control) this.labelServiceCode);
    this.panel4.Controls.Add((Control) this.label1);
    this.panel4.Controls.Add((Control) this.textACHExportTotal);
    this.panel4.Controls.Add((Control) this.buttonMGAExport);
    this.panel4.Controls.Add((Control) this.buttonExportACHResults);
    this.panel4.Controls.Add((Control) this.buttonCancel);
    this.panel4.Controls.Add((Control) this.buttonLoadACHPayables);
    this.panel4.Controls.Add((Control) this.lblTransactionCode);
    this.panel4.Controls.Add((Control) this.comboACHTranactionsCodes);
    this.panel4.Controls.Add((Control) this.lblBankAccount);
    this.panel4.Controls.Add((Control) this.labelOfficeLocation);
    this.panel4.Controls.Add((Control) this.comboBankAccounts);
    this.panel4.Controls.Add((Control) this.comboGLCompanies);
    this.panel4.Location = new Point(0, 0);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(281, 675);
    this.panel4.TabIndex = 18;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxCompanyEntryDesc).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textboxCompanyEntryDesc).BackColor = Color.White;
    ((Control) this.textboxCompanyEntryDesc).Location = new Point(13, 192 /*0xC0*/);
    ((TextEditorControlBase) this.textboxCompanyEntryDesc).MaxLength = 10;
    this.textboxCompanyEntryDesc.MGAStyle = MGAStyles.Blue;
    ((Control) this.textboxCompanyEntryDesc).Name = "textboxCompanyEntryDesc";
    ((Control) this.textboxCompanyEntryDesc).Size = new Size(260, 20);
    ((Control) this.textboxCompanyEntryDesc).TabIndex = 10;
    ((UltraControlBase) this.textboxCompanyEntryDesc).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textboxCompanyEntryDesc).UseOsThemes = (DefaultableBoolean) 2;
    this.labelCompanyEntryDesc.AutoSize = true;
    this.labelCompanyEntryDesc.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelCompanyEntryDesc.Location = new Point(9, 175);
    this.labelCompanyEntryDesc.Name = "labelCompanyEntryDesc";
    this.labelCompanyEntryDesc.Size = new Size(101, 14);
    this.labelCompanyEntryDesc.TabIndex = 9;
    this.labelCompanyEntryDesc.Text = "Entry Description";
    this.labelEffectiveDate.AutoSize = true;
    this.labelEffectiveDate.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelEffectiveDate.Location = new Point(9, 217);
    this.labelEffectiveDate.Name = "labelEffectiveDate";
    this.labelEffectiveDate.Size = new Size(81, 14);
    this.labelEffectiveDate.TabIndex = 11;
    this.labelEffectiveDate.Text = "Effective Date";
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeEffectiveDate.Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance12).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance12).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance12).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance12).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance12).ForegroundAlpha = (Alpha) 2;
    this.dateTimeEffectiveDate.ButtonAppearance = (AppearanceBase) appearance12;
    ((Control) this.dateTimeEffectiveDate).Location = new Point(13, 232);
    this.dateTimeEffectiveDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeEffectiveDate).Name = "dateTimeEffectiveDate";
    ((Control) this.dateTimeEffectiveDate).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.dateTimeEffectiveDate).TabIndex = 12;
    ((UltraControlBase) this.dateTimeEffectiveDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeEffectiveDate).UseOsThemes = (DefaultableBoolean) 2;
    this.comboACHServiceCodes.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.comboACHServiceCodes).DisplayMember = "ACHServiceCodeDescription";
    this.comboACHServiceCodes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboACHServiceCodes).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboACHServiceCodes).Location = new Point(13, 150);
    this.comboACHServiceCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboACHServiceCodes).Name = "comboACHServiceCodes";
    ((Control) this.comboACHServiceCodes).Size = new Size(261, 21);
    ((Control) this.comboACHServiceCodes).TabIndex = 8;
    ((UltraControlBase) this.comboACHServiceCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboACHServiceCodes).UseOsThemes = (DefaultableBoolean) 2;
    this.picCalculateTotal.BackColor = Color.White;
    this.picCalculateTotal.BorderStyle = BorderStyle.FixedSingle;
    this.picCalculateTotal.Image = (Image) Resources.eye;
    this.picCalculateTotal.InitialImage = (Image) Resources.eye;
    this.picCalculateTotal.Location = new Point(254, 360);
    this.picCalculateTotal.Name = "picCalculateTotal";
    this.picCalculateTotal.Size = new Size(19, 19);
    this.picCalculateTotal.SizeMode = PictureBoxSizeMode.CenterImage;
    this.picCalculateTotal.TabIndex = 15;
    this.picCalculateTotal.TabStop = false;
    this.picCalculateTotal.WaitOnLoad = true;
    this.picCalculateTotal.Click += new EventHandler(this.picCalculateTotal_Click);
    this.labelServiceCode.AutoSize = true;
    this.labelServiceCode.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelServiceCode.Location = new Point(9, 132);
    this.labelServiceCode.Name = "labelServiceCode";
    this.labelServiceCode.Size = new Size(80 /*0x50*/, 14);
    this.labelServiceCode.TabIndex = 7;
    this.labelServiceCode.Text = "Service Code";
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(9, 343);
    this.label1.Name = "label1";
    this.label1.Size = new Size(100, 14);
    this.label1.TabIndex = 17;
    this.label1.Text = "ACH Export Total:";
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.Gray;
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textACHExportTotal).Appearance = (AppearanceBase) appearance13;
    ((Control) this.textACHExportTotal).BackColor = Color.White;
    ((Control) this.textACHExportTotal).Location = new Point(12, 360);
    ((Control) this.textACHExportTotal).Name = "textACHExportTotal";
    ((Control) this.textACHExportTotal).Size = new Size(241, 20);
    ((Control) this.textACHExportTotal).TabIndex = 18;
    ((UltraControlBase) this.textACHExportTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textACHExportTotal).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance14).Image = (object) Resources.disk;
    ((AppearanceBase) appearance14).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance14).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonMGAExport).Appearance = (AppearanceBase) appearance14;
    ((Control) this.buttonMGAExport).Font = new Font("Tahoma", 8.25f);
    ((Control) this.buttonMGAExport).Location = new Point(153, 297);
    ((Control) this.buttonMGAExport).Name = "buttonMGAExport";
    ((Control) this.buttonMGAExport).Size = new Size(121, 24);
    ((Control) this.buttonMGAExport).TabIndex = 16 /*0x10*/;
    ((Control) this.buttonMGAExport).Text = "MGA Post Export";
    ((UltraControlBase) this.buttonMGAExport).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonMGAExport).Click += new EventHandler(this.buttonMGAExport_Click);
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance15).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance15).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance15).Image = (object) Resources.disk;
    ((AppearanceBase) appearance15).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance15).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonExportACHResults).Appearance = (AppearanceBase) appearance15;
    ((Control) this.buttonExportACHResults).Font = new Font("Tahoma", 7.99f);
    ((Control) this.buttonExportACHResults).Location = new Point(12, 297);
    ((Control) this.buttonExportACHResults).Name = "buttonExportACHResults";
    ((Control) this.buttonExportACHResults).Size = new Size(135, 24);
    ((Control) this.buttonExportACHResults).TabIndex = 15;
    ((Control) this.buttonExportACHResults).Text = "Post Selected Results";
    ((UltraControlBase) this.buttonExportACHResults).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonExportACHResults).Click += new EventHandler(this.buttonExportACHResults_Click);
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance16).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance16).Image = (object) Resources.delete;
    ((AppearanceBase) appearance16).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance16).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance16;
    ((Control) this.buttonCancel).Font = new Font("Tahoma", 8.25f);
    ((Control) this.buttonCancel).Location = new Point(153, 267);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(121, 24);
    ((Control) this.buttonCancel).TabIndex = 14;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance17).Image = (object) Resources.SearchTransaction;
    ((AppearanceBase) appearance17).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance17).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonLoadACHPayables).Appearance = (AppearanceBase) appearance17;
    ((Control) this.buttonLoadACHPayables).Font = new Font("Tahoma", 8.25f);
    ((Control) this.buttonLoadACHPayables).Location = new Point(12, 267);
    ((Control) this.buttonLoadACHPayables).Name = "buttonLoadACHPayables";
    ((Control) this.buttonLoadACHPayables).Size = new Size(135, 24);
    ((Control) this.buttonLoadACHPayables).TabIndex = 13;
    ((Control) this.buttonLoadACHPayables).Text = "Load ACH Payables";
    ((UltraControlBase) this.buttonLoadACHPayables).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonLoadACHPayables).Click += new EventHandler(this.buttonLoadACHPayables_Click);
    this.lblTransactionCode.AutoSize = true;
    this.lblTransactionCode.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTransactionCode.Location = new Point(9, 91);
    this.lblTransactionCode.Name = "lblTransactionCode";
    this.lblTransactionCode.Size = new Size(103, 14);
    this.lblTransactionCode.TabIndex = 5;
    this.lblTransactionCode.Text = "Transaction Code";
    this.comboACHTranactionsCodes.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.comboACHTranactionsCodes).DisplayMember = "ACHTransactionDescription";
    this.comboACHTranactionsCodes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboACHTranactionsCodes).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboACHTranactionsCodes).Location = new Point(12, 108);
    this.comboACHTranactionsCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboACHTranactionsCodes).Name = "comboACHTranactionsCodes";
    ((Control) this.comboACHTranactionsCodes).Size = new Size(261, 21);
    ((Control) this.comboACHTranactionsCodes).TabIndex = 6;
    ((UltraControlBase) this.comboACHTranactionsCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboACHTranactionsCodes).UseOsThemes = (DefaultableBoolean) 2;
    this.lblBankAccount.AutoSize = true;
    this.lblBankAccount.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblBankAccount.Location = new Point(12, 50);
    this.lblBankAccount.Name = "lblBankAccount";
    this.lblBankAccount.Size = new Size(82, 14);
    this.lblBankAccount.TabIndex = 3;
    this.lblBankAccount.Text = "Bank Account";
    this.labelOfficeLocation.AutoSize = true;
    this.labelOfficeLocation.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelOfficeLocation.Location = new Point(9, 9);
    this.labelOfficeLocation.Name = "labelOfficeLocation";
    this.labelOfficeLocation.Size = new Size(89, 14);
    this.labelOfficeLocation.TabIndex = 1;
    this.labelOfficeLocation.Text = "Office Location";
    this.comboBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "bankname";
    this.comboBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboBankAccounts).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboBankAccounts).Location = new Point(12, 67);
    this.comboBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccounts).Name = "comboBankAccounts";
    ((Control) this.comboBankAccounts).Size = new Size(261, 21);
    ((Control) this.comboBankAccounts).TabIndex = 4;
    ((UltraControlBase) this.comboBankAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboBankAccounts).UseOsThemes = (DefaultableBoolean) 2;
    this.comboBankAccounts.RowSelected += new RowSelectedEventHandler(this.comboBankAccounts_RowSelected);
    this.comboGLCompanies.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.comboGLCompanies).DisplayMember = "Office Location";
    this.comboGLCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGLCompanies).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboGLCompanies).Location = new Point(12, 26);
    this.comboGLCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompanies).Name = "comboGLCompanies";
    ((Control) this.comboGLCompanies).Size = new Size(261, 21);
    ((Control) this.comboGLCompanies).TabIndex = 2;
    ((UltraControlBase) this.comboGLCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompanies).UseOsThemes = (DefaultableBoolean) 2;
    this.comboGLCompanies.RowSelected += new RowSelectedEventHandler(this.comboGLCompanies_RowSelected);
    this.panel3.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.panel3.Location = new Point(282, 654);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(877, 21);
    this.panel3.TabIndex = 19;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.LightGray;
    this.ClientSize = new Size(1164, 675);
    this.Controls.Add((Control) this.panel3);
    this.Controls.Add((Control) this.panel4);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8f);
    this.Name = nameof (FormACHWireExport);
    this.Text = "ACH Export";
    this.Load += new EventHandler(this.FormACHWireExport_Load);
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.gridACHWireResults).EndInit();
    this.dsACHPayablesExport1.EndInit();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.statusStrip1.ResumeLayout(false);
    this.statusStrip1.PerformLayout();
    this.panel4.ResumeLayout(false);
    this.panel4.PerformLayout();
    ((ISupportInitialize) this.textboxCompanyEntryDesc).EndInit();
    ((ISupportInitialize) this.dateTimeEffectiveDate).EndInit();
    ((ISupportInitialize) this.comboACHServiceCodes).EndInit();
    ((ISupportInitialize) this.picCalculateTotal).EndInit();
    ((ISupportInitialize) this.textACHExportTotal).EndInit();
    ((ISupportInitialize) this.buttonMGAExport).EndInit();
    ((ISupportInitialize) this.buttonExportACHResults).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonLoadACHPayables).EndInit();
    ((ISupportInitialize) this.comboACHTranactionsCodes).EndInit();
    ((ISupportInitialize) this.comboBankAccounts).EndInit();
    ((ISupportInitialize) this.comboGLCompanies).EndInit();
    this.ResumeLayout(false);
  }
}
