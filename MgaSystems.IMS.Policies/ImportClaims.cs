// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ImportClaims
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinListView;
using MGASystems.AsposeFacade.Cells;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.ThreadingFunctions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class ImportClaims : Form
{
  private IContainer components;
  private PictureBox PictureBox1;
  private dsExcelImport _dsImport;
  private int _policyNumberColumnIndex;
  private Worksheet _worksheet;
  private DateTime _dateCriteria;
  private int _dateCriteriaColumnIndex;
  private object _valuationDate;
  private bool _hasValuationDate;
  private string __controlNumberSelectedString;
  protected int _controlNumberColumnIndex;
  private bool _onlyImportExistingClaims;
  private bool _ignoreEmptyPolicyNumber;
  private string _claimsImportStoredProcName;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ImportClaims));
    Appearance appearance = new Appearance();
    this.listImportStatus = new UltraListView();
    this.ImageList1 = new ImageList(this.components);
    this.lblStatus = new Label();
    this.PictureBox1 = new PictureBox();
    this.spinner = new PictureBox();
    this.progress = new ProgressBar();
    this.btnPrint = new MGAButton();
    ((ISupportInitialize) this.listImportStatus).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.spinner).BeginInit();
    ((ISupportInitialize) this.btnPrint).BeginInit();
    this.SuspendLayout();
    ((Control) this.listImportStatus).Location = new Point(12, 66);
    ((Control) this.listImportStatus).Name = "listImportStatus";
    ((Control) this.listImportStatus).Size = new Size(585, 243);
    ((Control) this.listImportStatus).TabIndex = 0;
    ((Control) this.listImportStatus).Text = "UltraListView1";
    this.listImportStatus.View = (UltraListViewStyle) 0;
    ((UltraListViewSettingsBase) this.listImportStatus.ViewSettingsDetails).ImageList = this.ImageList1;
    ((UltraListViewSettingsBase) this.listImportStatus.ViewSettingsIcons).ImageList = this.ImageList1;
    ((UltraListViewSettingsBase) this.listImportStatus.ViewSettingsList).ImageList = this.ImageList1;
    this.listImportStatus.ViewSettingsList.MultiColumn = false;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "bullet_green.png");
    this.ImageList1.Images.SetKeyName(1, "bullet_red.png");
    this.lblStatus.AutoSize = true;
    this.lblStatus.Font = new Font("Tahoma", 10f);
    this.lblStatus.Location = new Point(66, 27);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(126, 17);
    this.lblStatus.TabIndex = 1;
    this.lblStatus.Text = "Importing Claims ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(12, 12);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 2;
    this.PictureBox1.TabStop = false;
    this.spinner.Image = (Image) componentResourceManager.GetObject("spinner.Image");
    this.spinner.Location = new Point(559, 19);
    this.spinner.Name = "spinner";
    this.spinner.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.spinner.SizeMode = PictureBoxSizeMode.AutoSize;
    this.spinner.TabIndex = 3;
    this.spinner.TabStop = false;
    this.progress.Location = new Point(12, 329);
    this.progress.Name = "progress";
    this.progress.Size = new Size(585, 10);
    this.progress.TabIndex = 4;
    appearance.BackColor = Color.Gainsboro;
    appearance.BackColor2 = Color.White;
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.Gray;
    ((ControlBase) this.btnPrint).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnPrint).Location = new Point(502, 345);
    ((Control) this.btnPrint).Name = "btnPrint";
    ((Control) this.btnPrint).Size = new Size(104, 24);
    ((Control) this.btnPrint).TabIndex = 5;
    ((ControlBase) this.btnPrint).Text = "Print to Text File";
    this.btnPrint.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(609, 381);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.progress);
    this.Controls.Add((Control) this.spinner);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.listImportStatus);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (ImportClaims);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Importing Claims";
    ((ISupportInitialize) this.listImportStatus).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.spinner).EndInit();
    ((ISupportInitialize) this.btnPrint).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblStatus")]
  protected virtual Label lblStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnPrint
  {
    get => this._btnPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      MGAButton btnPrint1 = this._btnPrint;
      if (btnPrint1 != null)
        ((Control) btnPrint1).Click -= eventHandler;
      this._btnPrint = value;
      MGAButton btnPrint2 = this._btnPrint;
      if (btnPrint2 == null)
        return;
      ((Control) btnPrint2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("listImportStatus")]
  public virtual UltraListView listImportStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spinner")]
  public virtual PictureBox spinner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("progress")]
  public virtual ProgressBar progress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ImageList1")]
  public virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public object ValuationDate
  {
    get => this._valuationDate;
    set => this._valuationDate = RuntimeHelpers.GetObjectValue(value);
  }

  public bool HasValuationOnSpreadsheet
  {
    get => this._hasValuationDate;
    set => this._hasValuationDate = value;
  }

  public string ControlNumberSelectedColumnName
  {
    get => this.__controlNumberSelectedString;
    set => this.__controlNumberSelectedString = value;
  }

  protected virtual bool ImportRequiresResolvedPolicy => true;

  public ImportClaims(
    dsExcelImport dsImport,
    string policyNumberColumnName,
    Worksheet worksheet,
    string dateCritieraColumnName,
    DateTime dateCriteria)
    : this(dsImport, policyNumberColumnName, worksheet)
  {
    this._worksheet = worksheet;
    if (this.progress != null)
      this.progress.Maximum = this._worksheet.Cells.Rows.Count;
    try
    {
      foreach (Column column in (IEnumerable<Column>) worksheet.Cells.Columns)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(worksheet.Cells[0, column.Index].StringValue, dateCritieraColumnName, false) == 0)
        {
          this._dateCriteriaColumnIndex = column.Index;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<Column> enumerator;
      enumerator?.Dispose();
    }
    this._dateCriteria = dateCriteria;
  }

  public ImportClaims(dsExcelImport dsImport, string policyNumberColumnName, Worksheet worksheet)
  {
    this.Load += new EventHandler(this.ImportClaims_Load);
    this._valuationDate = (object) null;
    this._hasValuationDate = false;
    this.__controlNumberSelectedString = string.Empty;
    this._controlNumberColumnIndex = int.MinValue;
    this._onlyImportExistingClaims = false;
    this._ignoreEmptyPolicyNumber = false;
    this._claimsImportStoredProcName = "ImportClaimsData";
    this._dsImport = dsImport;
    int num = worksheet.Cells.MaxDataColumn - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(worksheet.Cells[0, index].StringValue, policyNumberColumnName, false) == 0)
      {
        this._policyNumberColumnIndex = index;
        break;
      }
    }
    this._worksheet = worksheet;
    this.InitializeComponent();
    this.progress.Maximum = this._worksheet.Cells.Rows.Count;
  }

  private void ImportClaims_Load(object sender, EventArgs e)
  {
    if (!this.ControlNumberSelectedColumnName.Equals(string.Empty))
    {
      int num = this._worksheet.Cells.MaxDataColumn - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._worksheet.Cells[0, index].StringValue, this.ControlNumberSelectedColumnName, false) == 0)
        {
          this._controlNumberColumnIndex = index;
          break;
        }
      }
    }
    if (SystemSettings.GetSetting<bool>("ClaimsImport.OnlyImportExistingClaims"))
      this._onlyImportExistingClaims = true;
    if (SystemSettings.GetSetting<bool>("ClaimsImport.IgnoreEmptyPolicyNumber"))
      this._ignoreEmptyPolicyNumber = true;
    if (SystemSettings.KeyExists("ClaimsImport.StoredProcName"))
      this._claimsImportStoredProcName = SystemSettings.GetStringSetting("ClaimsImport.StoredProcName");
    this.progress.Maximum = this._ignoreEmptyPolicyNumber ? this._worksheet.Cells.Rows.Count : this._worksheet.Cells.Rows.Count - 1;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ImportThread));
  }

  private void ImportThread(object state)
  {
    this.OnImportThread(RuntimeHelpers.GetObjectValue(state));
  }

  [CLSCompliant(false)]
  protected virtual string GetPolicyNumber(Row worksheetRow)
  {
    string stringValue = this._worksheet.Cells[worksheetRow.Index, this._policyNumberColumnIndex].StringValue;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetPolicyNumberFromString", new object[2]
    {
      (object) "@polNumString",
      (object) stringValue
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      stringValue = objectValue.ToString();
    return stringValue;
  }

  [CLSCompliant(false)]
  protected virtual void OnInsertRecord(int controlNo, Row worksheetRow)
  {
    this.InsertClaimRecord(controlNo, worksheetRow);
  }

  [CLSCompliant(false)]
  protected virtual string GetAddListItemSuccessString(
    int controlNo,
    Row worksheetRow,
    string policyNumber)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.GetMappedValue("ClaimNo", worksheetRow, false));
    return objectValue == null || objectValue == DBNull.Value ? "Successfully imported Policy #" + policyNumber : (this._controlNumberColumnIndex != int.MinValue ? $"Successfully imported Claim # {objectValue.ToString()} to Control # {controlNo.ToString()}" : $"Successfully imported Claim # {objectValue.ToString()} to Policy # {policyNumber}");
  }

  protected virtual object GetControlNo(string policyNumber)
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

  [CLSCompliant(false)]
  protected virtual object GetControlNoFromRow(Row worksheetRow)
  {
    object controlNoFromRow;
    if (this._controlNumberColumnIndex == int.MinValue)
    {
      controlNoFromRow = (object) null;
    }
    else
    {
      string stringValue = this._worksheet.Cells[worksheetRow.Index, this._controlNumberColumnIndex].StringValue;
      if (stringValue.Replace(" ", string.Empty).Length == 0)
      {
        controlNoFromRow = (object) null;
      }
      else
      {
        int result = -1;
        controlNoFromRow = !int.TryParse(stringValue.ToString(), out result) ? (object) null : (object) result;
      }
    }
    return controlNoFromRow;
  }

  protected virtual void OnImportThread(object state)
  {
    List<string> stringList = new List<string>();
    int num1;
    int num2;
    int num3;
    try
    {
      foreach (Row row in (IEnumerable<Row>) this._worksheet.Cells.Rows)
      {
        if (row.Index > 0 & row.Index <= this._worksheet.Cells.MaxDataRow)
        {
          bool flag = true;
          if (this._dateCriteriaColumnIndex != 0 && DateTime.Compare(Conversions.ToDate(this._worksheet.Cells[row.Index, this._dateCriteriaColumnIndex].Value), this._dateCriteria) < 0)
          {
            flag = false;
            ++num1;
          }
          if (flag)
          {
            string policyNumber = this.GetPolicyNumber(row);
            string mappedValue = (string) this.GetMappedValue("ClaimNo", row, false);
            int? nullable;
            if (this.ImportRequiresResolvedPolicy)
              nullable = this.CheckDuplicateControlNo((int?) (this._controlNumberColumnIndex != int.MinValue ? this.GetControlNoFromRow(row) : this.GetControlNo(policyNumber)), mappedValue);
            if (nullable.HasValue || !this.ImportRequiresResolvedPolicy)
            {
              try
              {
                this.OnInsertRecord(nullable ?? -1, row);
                UltraListViewItem ultraListViewItem = new UltraListViewItem();
                ((UltraListViewItemBase) ultraListViewItem).Value = (object) this.GetAddListItemSuccessString(nullable ?? -1, row, policyNumber);
                ((UltraListViewItemBase) ultraListViewItem).Appearance.Image = (object) 0;
                this.AddListItem(ultraListViewItem);
                ++num2;
              }
              catch (SqlException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                SqlException sqlException = ex;
                ++num1;
                UltraListViewItem ultraListViewItem = new UltraListViewItem();
                ((UltraListViewItemBase) ultraListViewItem).Appearance.ForeColor = Color.Red;
                string empty = string.Empty;
                if (mappedValue != null)
                {
                  if (!string.IsNullOrEmpty(policyNumber))
                    ((UltraListViewItemBase) ultraListViewItem).Value = (object) $"Skipped claim #{mappedValue.ToString()} for  Policy #{policyNumber} - {sqlException.Message}{this.RowString(row)}";
                  else
                    ((UltraListViewItemBase) ultraListViewItem).Value = (object) $"Skipped claim #{mappedValue.ToString()} for  Control #{nullable.ToString()} - {sqlException.Message}{this.RowString(row)}";
                }
                else
                  ((UltraListViewItemBase) ultraListViewItem).Value = (object) $"Policy #{policyNumber} - {sqlException.Message}{this.RowString(row)}";
                ((UltraListViewItemBase) ultraListViewItem).Appearance.Image = (object) 1;
                this.AddListItem(ultraListViewItem);
                if (!stringList.Contains(sqlException.Message))
                {
                  stringList.Add(sqlException.Message);
                  if (sqlException.Message.Contains("expects parameter"))
                    MessageBox.Show(sqlException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  else
                    MessageBox.Show(sqlException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                ProjectData.ClearProjectError();
              }
              catch (ImportClaims.InvalidClaimException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                ImportClaims.InvalidClaimException invalidClaimException = ex;
                UltraListViewItem ultraListViewItem = new UltraListViewItem();
                ((UltraListViewItemBase) ultraListViewItem).Appearance.ForeColor = Color.Red;
                ((UltraListViewItemBase) ultraListViewItem).Value = (object) invalidClaimException.Message;
                ((UltraListViewItemBase) ultraListViewItem).Appearance.Image = (object) 1;
                this.AddListItem(ultraListViewItem);
                ProjectData.ClearProjectError();
              }
              catch (InvalidOperationException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
                ProjectData.ClearProjectError();
              }
            }
            else
            {
              if (string.IsNullOrEmpty(policyNumber) && this._ignoreEmptyPolicyNumber)
              {
                this.MoveProgress();
                continue;
              }
              UltraListViewItem ultraListViewItem = new UltraListViewItem();
              ((UltraListViewItemBase) ultraListViewItem).Appearance.ForeColor = Color.Red;
              ((UltraListViewItemBase) ultraListViewItem).Value = (object) $"Policy #{policyNumber} was not found.{this.RowString(row)}";
              ((UltraListViewItemBase) ultraListViewItem).Appearance.Image = (object) 1;
              this.AddListItem(ultraListViewItem);
              ++num3;
            }
          }
          this.MoveProgress();
        }
      }
    }
    finally
    {
      IEnumerator<Row> enumerator;
      enumerator?.Dispose();
    }
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) this, (Delegate) new ImportClaims.ImportCompleteHandler(this.ImportComplete), new object[3]
    {
      (object) num2,
      (object) num1,
      (object) num3
    });
  }

  protected virtual int? CheckDuplicateControlNo(int? controlNo, string claimNo)
  {
    if (controlNo.HasValue && claimNo != null)
    {
      int? nullable = DefaultDatabase.ExecuteScalar<int?>("GetDuplicateControlNoForClaim", new object[4]
      {
        (object) "@ClaimNo",
        (object) claimNo,
        (object) "@ControlNo",
        (object) controlNo
      });
      if (nullable.HasValue)
      {
        Quote quote = Quote.FromControlNo(nullable.Value);
        UltraListViewItem ultraListViewItem = new UltraListViewItem();
        ((UltraListViewItemBase) ultraListViewItem).Appearance.ForeColor = Color.Magenta;
        if (quote != null && quote.HasPolicyNumber)
          ((UltraListViewItemBase) ultraListViewItem).Value = (object) $"Claim # {claimNo.ToString()} is already associated to Policy # {quote.PolicyNumber}";
        else
          ((UltraListViewItemBase) ultraListViewItem).Value = (object) $"Claim # {claimNo.ToString()} is already associated to Control # {nullable.ToString()}";
        ((UltraListViewItemBase) ultraListViewItem).Appearance.Image = (object) 1;
        this.AddListItem(ultraListViewItem);
      }
    }
    return controlNo;
  }

  [CLSCompliant(false)]
  protected internal object GetMappedValue(
    string imsColumnName,
    Row workSheetRow,
    bool isNullableData)
  {
    dsExcelImport.ImportMappingsRow byImsColumn = this._dsImport.ImportMappings.FindByIMSColumn(imsColumnName);
    object mappedValue;
    if (byImsColumn != null && !byImsColumn.IsSpreadsheetColumnNull() && !string.IsNullOrEmpty(byImsColumn.SpreadsheetColumn))
    {
      if (Information.IsDate((object) byImsColumn.SpreadsheetColumn))
      {
        mappedValue = (object) Conversions.ToDate(byImsColumn.SpreadsheetColumn);
      }
      else
      {
        int num = -1;
        int maxDataColumn = this._worksheet.Cells.MaxDataColumn;
        for (int index = 0; index <= maxDataColumn; ++index)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this._worksheet.Cells[0, index].StringValue).ToUpper(), Strings.Trim(byImsColumn.SpreadsheetColumn).ToUpper(), false) == 0)
          {
            num = index;
            break;
          }
        }
        if (num == -1)
        {
          if (!isNullableData)
            throw new InvalidOperationException("Column not found");
          mappedValue = (object) null;
        }
        else
          mappedValue = (object) this._worksheet.Cells[workSheetRow.Index, num].StringValue;
      }
    }
    else
      mappedValue = (object) null;
    return mappedValue;
  }

  private void InsertClaimRecord(int controlNo, Row worksheetRow)
  {
    if (this._onlyImportExistingClaims)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this.GetMappedValue("ClaimNo", worksheetRow, false));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select count(ClaimID) from tblClaimInformation with (nolock) where ClaimNo = @CN", new object[2]
        {
          (object) "@CN",
          objectValue
        }) == 0)
          throw new ImportClaims.InvalidClaimException($"Unknown - Claim # {RuntimeHelpers.GetObjectValue(objectValue)} does not exist in the IMS.");
      }
    }
    DefaultDatabase.ExecuteNonQuery(this._claimsImportStoredProcName, new object[262]
    {
      (object) "@controlNo",
      (object) controlNo,
      (object) "@claimNo",
      this.GetMappedValue("ClaimNo", worksheetRow, false),
      (object) "@dateReceived",
      this.GetMappedValue("DateReceived", worksheetRow, false),
      (object) "@dateReported",
      this.GetMappedValue("DateReported", worksheetRow, false),
      (object) "@lossDate",
      this.GetMappedValue("LossDate", worksheetRow, false),
      (object) "@lossType",
      this.GetMappedValue("LossType", worksheetRow, false),
      (object) "@status",
      this.GetMappedValue("status", worksheetRow, false),
      (object) "@dateClosed",
      this.GetMappedValue("dateClosed", worksheetRow, false),
      (object) "@inLitigation",
      this.GetMappedValue("inLitigation", worksheetRow, false),
      (object) "@descriptionInjury",
      this.GetMappedValue("descriptionInjury", worksheetRow, false),
      (object) "@catNo",
      this.GetMappedValue("catNo", worksheetRow, false),
      (object) "@OutIndRes",
      this.GetMappedValue("OutIndRes", worksheetRow, false),
      (object) "@OutLAERes",
      this.GetMappedValue("OutLAERes", worksheetRow, false),
      (object) "@OutLegalRes",
      this.GetMappedValue("OutLegalRes", worksheetRow, false),
      (object) "@DedRecovery",
      this.GetMappedValue("DedRecovery", worksheetRow, false),
      (object) "@Subrogation",
      this.GetMappedValue("Subrogation", worksheetRow, false),
      (object) "@Salvage",
      this.GetMappedValue("Salvage", worksheetRow, false),
      (object) "@OtherRecovery",
      this.GetMappedValue("OtherRecovery", worksheetRow, false),
      (object) "@MTDIndemnityPaid",
      this.GetMappedValue("MTDIndemnityPaid", worksheetRow, false),
      (object) "@IndemnityPTD",
      this.GetMappedValue("IndemnityPTD", worksheetRow, false),
      (object) "@MTDLAEPaid",
      this.GetMappedValue("MTDLAEPaid", worksheetRow, false),
      (object) "@LAEPTD",
      this.GetMappedValue("LAEPTD", worksheetRow, false),
      (object) "@MTDLegalPaid",
      this.GetMappedValue("MTDLegalPaid", worksheetRow, false),
      (object) "@LegalPTD",
      this.GetMappedValue("LegalPTD", worksheetRow, false),
      (object) "@MTDTPAExpPaid",
      this.GetMappedValue("MTDTPAExpPaid", worksheetRow, false),
      (object) "@TPAExpPTD",
      this.GetMappedValue("TPAExpPTD", worksheetRow, false),
      (object) "@TotalIncurred",
      this.GetMappedValue("TotalIncurred", worksheetRow, false),
      (object) "@LocationID",
      this.GetLocationID("LocationID", worksheetRow, true),
      (object) "@Claimant",
      this.GetMappedValue("Claimant", worksheetRow, true),
      (object) "@Deductible",
      this.GetMappedValue("Deductible", worksheetRow, true),
      (object) "@CoverageDescription",
      this.GetMappedValue("CoverageDescription", worksheetRow, true),
      (object) "@Company",
      this.GetMappedValue("Company", worksheetRow, true),
      (object) "@CorresBranchName",
      this.GetMappedValue("CorresBranchName", worksheetRow, true),
      (object) "@Occurence",
      this.GetMappedValue("Occurence", worksheetRow, true),
      (object) "@LOB",
      this.GetMappedValue("LOB", worksheetRow, true),
      (object) "@Lien",
      this.GetMappedValue("Lien", worksheetRow, true),
      (object) "@SubroPotential",
      this.GetMappedValue("SubroPotential", worksheetRow, true),
      (object) "@FirstThirdParty",
      this.GetMappedValue("FirstThirdParty", worksheetRow, true),
      (object) "@Fatality",
      this.GetMappedValue("Fatality", worksheetRow, true),
      (object) "@NCCICode",
      this.GetMappedValue("NCCICode", worksheetRow, true),
      (object) "@DateReOpened",
      this.GetMappedValue("DateReOpened", worksheetRow, true),
      (object) "@InitialContact",
      this.GetMappedValue("InitialContact", worksheetRow, true),
      (object) "@FirstInsp",
      this.GetMappedValue("FirstInsp", worksheetRow, true),
      (object) "@FirstReport",
      this.GetMappedValue("FirstReport", worksheetRow, true),
      (object) "@ReportToCarrier",
      this.GetMappedValue("ReportToCarrier", worksheetRow, true),
      (object) "@AdjusterName",
      this.GetMappedValue("AdjusterName", worksheetRow, true),
      (object) "@AdjusterTitle",
      this.GetMappedValue("AdjusterTitle", worksheetRow, true),
      (object) "@AdjusterCategory",
      this.GetMappedValue("AdjusterCategory", worksheetRow, true),
      (object) "@IndepAdjuster",
      this.GetMappedValue("IndepAdjuster", worksheetRow, true),
      (object) "@DefFirm",
      this.GetMappedValue("DefFirm", worksheetRow, true),
      (object) "@ClaimantCounsel",
      this.GetMappedValue("ClaimantCounsel", worksheetRow, true),
      (object) "@Gender",
      this.GetMappedValue("Gender", worksheetRow, true),
      (object) "@Age",
      this.GetMappedValue("Age", worksheetRow, true),
      (object) "@County",
      this.GetMappedValue("County", worksheetRow, true),
      (object) "@RecType",
      this.GetMappedValue("RecType", worksheetRow, true),
      (object) "@MedicalPTD",
      this.GetMappedValue("MedicalPTD", worksheetRow, true),
      (object) "@OutMedRes",
      this.GetMappedValue("OutMedRes", worksheetRow, true),
      (object) "@CarrierClaimNo",
      this.GetMappedValue("CarrierClaimNo", worksheetRow, true),
      (object) "@BorrowersName",
      this.GetMappedValue("BorrowersName", worksheetRow, true),
      (object) "@TotalPaid",
      this.GetMappedValue("TotalPaid", worksheetRow, true),
      (object) "@RecoveryPaid",
      this.GetMappedValue("RecoveryPaid", worksheetRow, true),
      (object) "@BorrowersFICOScore",
      this.GetMappedValue("BorrowersFICOScore", worksheetRow, true),
      (object) "@LoanToValueRatio",
      this.GetMappedValue("LoanToValueRatio", worksheetRow, true),
      (object) "@DebtRatio",
      this.GetMappedValue("DebtRatio", worksheetRow, true),
      (object) "@PropertyState",
      this.GetMappedValue("PropertyState", worksheetRow, true),
      (object) "@PropertyType",
      this.GetMappedValue("PropertyType", worksheetRow, true),
      (object) "@ValueDate ",
      this.GetValuationDate("ValueDate", worksheetRow, true),
      (object) "@TotalReserve",
      this.GetMappedValue("TotalReserve", worksheetRow, true),
      (object) "@RespayTotalPaid",
      this.GetMappedValue("RespayTotalPaid", worksheetRow, true),
      (object) "@DateCreated",
      this.GetMappedValue("DateCreated", worksheetRow, true),
      (object) "@TPAReserve",
      this.GetMappedValue("TPAReserve", worksheetRow, true),
      (object) "@BIPaid",
      this.GetMappedValue("BIPaid", worksheetRow, true),
      (object) "@BIReserve",
      this.GetMappedValue("BIReserve", worksheetRow, true),
      (object) "@PDPaid",
      this.GetMappedValue("PDPaid", worksheetRow, true),
      (object) "@PDReserve",
      this.GetMappedValue("PDReserve", worksheetRow, true),
      (object) "@Driver",
      this.GetMappedValue("Driver", worksheetRow, true),
      (object) "@DatePaid",
      this.GetMappedValue("DatePaid", worksheetRow, true),
      (object) "@OriginalLoanDate",
      this.GetMappedValue("OriginalLoanDate", worksheetRow, true),
      (object) "@RejectedDate",
      this.GetMappedValue("RejectedDate", worksheetRow, true),
      (object) "@RejectedAmount",
      this.GetMappedValue("RejectedAmount", worksheetRow, true),
      (object) "@ExpenseReserved",
      this.GetMappedValue("ExpenseReserved", worksheetRow, true),
      (object) "@GrossLoss",
      this.GetMappedValue("GrossLoss", worksheetRow, true),
      (object) "@DetailDescription",
      this.GetMappedValue("DetailDescription", worksheetRow, true),
      (object) "@LossStreet",
      this.GetMappedValue("LossStreet", worksheetRow, true),
      (object) "@LossCity",
      this.GetMappedValue("LossCity", worksheetRow, true),
      (object) "@LossState",
      this.GetMappedValue("LossState", worksheetRow, true),
      (object) "@LossZip",
      this.GetMappedValue("LossZip", worksheetRow, true),
      (object) "@Longitude",
      this.GetMappedValue("Longitude", worksheetRow, true),
      (object) "@Latitude",
      this.GetMappedValue("Latitude", worksheetRow, true),
      (object) "@BodyPart",
      this.GetMappedValue("BodyPart", worksheetRow, true),
      (object) "@ISO_Cat_Type",
      this.GetMappedValue("ISO_Cat_Type", worksheetRow, true),
      (object) "@CAT_Name_Details",
      this.GetMappedValue("CAT_Name_Details", worksheetRow, true),
      (object) "@Loss_ExposureAdjusted_Lruns",
      this.GetMappedValue("Loss_ExposureAdjusted_Lruns", worksheetRow, true),
      (object) "@GrossLoss_Lruns",
      this.GetMappedValue("GrossLoss_Lruns", worksheetRow, true),
      (object) "@Policy_Deductible_Insured_Retention",
      this.GetMappedValue("Policy_Deductible_Insured_Retention", worksheetRow, true),
      (object) "@BuyDown_Deductible_Attachment_Point ",
      this.GetMappedValue("BuyDown_Deductible_Attachment_Point ", worksheetRow, true),
      (object) "@Program_Deductible_Attachment_Point ",
      this.GetMappedValue("Program_Deductible_Attachment_Point ", worksheetRow, true),
      (object) "@Program_Loss_Transfer_toBuyDown",
      this.GetMappedValue("Program_Loss_Transfer_toBuyDown", worksheetRow, true),
      (object) "@Reserve_DBB",
      this.GetMappedValue("Reserve_DBB", worksheetRow, true),
      (object) "@Indemnity_Paid_DBB",
      this.GetMappedValue("Indemnity_Paid_DBB", worksheetRow, true),
      (object) "@Indemnity_Reserve_SectionA",
      this.GetMappedValue("Indemnity_Reserve_SectionA", worksheetRow, true),
      (object) "@Expense_Reserve_SectionA",
      this.GetMappedValue("Expense_Reserve_SectionA", worksheetRow, true),
      (object) "@Indemnity_Paid_SectionA",
      this.GetMappedValue("Indemnity_Paid_SectionA", worksheetRow, true),
      (object) "@Expenses_Paid_SectionA",
      this.GetMappedValue("Expenses_Paid_SectionA", worksheetRow, true),
      (object) "@Net_SectionA",
      this.GetMappedValue("Net_SectionA", worksheetRow, true),
      (object) "@Indemnity_Reserve_SectionB",
      this.GetMappedValue("Indemnity_Reserve_SectionB", worksheetRow, true),
      (object) "@Expenses_Reserve_SectionB",
      this.GetMappedValue("Expenses_Reserve_SectionB", worksheetRow, true),
      (object) "@Indemnity_Paid_SectionB",
      this.GetMappedValue("Indemnity_Paid_SectionB", worksheetRow, true),
      (object) "@Expenses_Paid_SectionB",
      this.GetMappedValue("Expenses_Paid_SectionB", worksheetRow, true),
      (object) "@Net_SectionB",
      this.GetMappedValue("Net_SectionB", worksheetRow, true),
      (object) "@Recovery_Lruns",
      this.GetMappedValue("Recovery_Lruns", worksheetRow, true),
      (object) "@Subro_Lruns",
      this.GetMappedValue("Subro_Lruns", worksheetRow, true),
      (object) "@Total_Incurred_Individual_Policy",
      this.GetMappedValue("Total_Incurred_Individual_Policy", worksheetRow, true),
      (object) "@Total_Incurred_DBB",
      this.GetMappedValue("Total_Incurred_DBB", worksheetRow, true),
      (object) "@Total_Incurred_Program",
      this.GetMappedValue("Total_Incurred_Program", worksheetRow, true),
      (object) "@Comments_Lruns",
      this.GetMappedValue("Comments_Lruns", worksheetRow, true),
      (object) "@AdjCaseReserves",
      this.GetMappedValue("AdjCaseReserves", worksheetRow, true),
      (object) "@Indemnity_Reserve_SectionC",
      this.GetMappedValue("Indemnity_Reserve_SectionC", worksheetRow, true),
      (object) "@Expenses_Reserve_SectionC",
      this.GetMappedValue("Expenses_Reserve_SectionC", worksheetRow, true),
      (object) "@Indemnity_Paid_SectionC",
      this.GetMappedValue("Indemnity_Paid_SectionC", worksheetRow, true),
      (object) "@Expenses_Paid_SectionC",
      this.GetMappedValue("Expenses_Paid_SectionC", worksheetRow, true),
      (object) "@Net_SectionC",
      this.GetMappedValue("Net_SectionC", worksheetRow, true),
      (object) "@Loss_Type_Detail",
      this.GetMappedValue("Loss_Type_Detail", worksheetRow, true),
      (object) "@AdjIncurred",
      this.GetMappedValue("AdjIncurred", worksheetRow, true),
      (object) "@CurrencyCode",
      this.GetMappedValue("CurrencyCode", worksheetRow, true),
      (object) "@TotalRecovery",
      this.GetMappedValue("TotalRecovery", worksheetRow, true),
      (object) "@CoverageType",
      this.GetMappedValue("CoverageType", worksheetRow, true),
      (object) "@Limit",
      this.GetMappedValue("Limit", worksheetRow, true),
      (object) "@WatchList",
      this.GetMappedValue("WatchList", worksheetRow, true),
      (object) "@ExpensePaid",
      this.GetMappedValue("ExpensePaid", worksheetRow, true),
      (object) "@Comments",
      this.GetMappedValue("Comments", worksheetRow, true)
    });
  }

  protected virtual void ImportComplete(int importCount, int skipCount, int notFoundCount)
  {
    this.spinner.Visible = false;
    int num = (int) MessageBox.Show($"The claims import is complete.\n\nImported: {importCount.ToString()}\n\nSkipped: {skipCount.ToString()}\n\nPolicy Not Found: {notFoundCount.ToString()}", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  protected virtual void AddListItem(UltraListViewItem item)
  {
    if (this.InvokeRequired)
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) this, (Delegate) new ImportClaims.AddListItemHandler(this.AddListItem), new object[1]
      {
        (object) item
      });
    }
    else
    {
      this.listImportStatus.Items.Add(item);
      this.listImportStatus.PerformAction((UltraListViewAction) 23);
    }
  }

  protected virtual void MoveProgress()
  {
    if (this.InvokeRequired)
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) this, (Delegate) new MethodInvoker(this.MoveProgress), new object[0]);
    }
    else
    {
      ProgressBar progress;
      int num = (progress = this.progress).Value + 1;
      progress.Value = num;
    }
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    if (this.listImportStatus.Items.Count == 0)
    {
      int num1 = (int) MessageBox.Show("There are no items to print.", "No Print Items", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
          saveFileDialog.DefaultExt = "txt";
          saveFileDialog.Filter = "txt files(*.txt)|";
          saveFileDialog.AddExtension = true;
          if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;
          if (saveFileDialog.FileName.Replace(" ", "").Length == 0)
          {
            int num2 = (int) MessageBox.Show("Please enter a valid file name.", "Invalid File Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else
          {
            if (File.Exists(saveFileDialog.FileName))
              File.Delete(saveFileDialog.FileName);
            using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
            {
              using (StreamWriter streamWriter = new StreamWriter((Stream) fileStream))
              {
                streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
                foreach (UltraListViewItem ultraListViewItem in this.listImportStatus.Items)
                {
                  if (((UltraListViewItemBase) ultraListViewItem).Value != null)
                    streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(((UltraListViewItemBase) ultraListViewItem).Value));
                }
                streamWriter.Close();
              }
            }
          }
        }
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private string RowString(Row workSheetRow)
  {
    string str = string.Empty;
    if (workSheetRow != null)
      str = " Row#" + (workSheetRow.Index + 1).ToString();
    return str;
  }

  private object GetValuationDate(string imsColumnName, Row workSheetRow, bool isNullableData)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.GetMappedValue("ValueDate", workSheetRow, true));
    return this.ValuationDate == null || this.ValuationDate == DBNull.Value ? objectValue : (this.HasValuationOnSpreadsheet ? objectValue : this.ValuationDate);
  }

  private object GetLocationID(string imsColumnName, Row workSheetRow, bool isNullableData)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.GetMappedValue("LocationID", workSheetRow, true));
    object locationId;
    if (objectValue == null || objectValue == DBNull.Value)
      locationId = (object) null;
    else if (objectValue.ToString().Replace(" ", string.Empty).Length == 0)
    {
      locationId = (object) null;
    }
    else
    {
      Decimal result = -1M;
      locationId = !Decimal.TryParse(objectValue.ToString(), NumberStyles.Any, (IFormatProvider) CultureInfo.InvariantCulture, out result) ? (object) null : (object) result;
    }
    return locationId;
  }

  private delegate void ImportCompleteHandler(int importCount, int skipCount, int notFoundCount);

  private delegate void AddListItemHandler(UltraListViewItem item);

  private class InvalidClaimException : Exception
  {
    private string _str;

    public InvalidClaimException(string exceptionString) => this._str = exceptionString;

    public override string Message => this._str;
  }
}
