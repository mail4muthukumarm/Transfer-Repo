// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport.frmMapFields
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport;

public sealed class frmMapFields : Form
{
  private IContainer components;
  private System.Windows.Forms.Label Label1;
  private PictureBox PictureBox1;
  private System.Windows.Forms.Label Label2;
  private System.Windows.Forms.Label Label3;
  private MGAComboBox cboTIV;
  private MGAComboBox cboState;
  private DataView dvTIV;
  private dsMapFields ds;
  private DataView dvStates;
  private ErrorProvider err;
  private readonly string _excelFileName;
  private readonly Worksheet _worksheet;
  private System.Data.DataTable _dtExcelData;
  private bool _allStatesValid;
  private bool _cancelled;
  private readonly Quote _quote;
  private readonly bool _PlacePremInStateOfIssuance;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNext_Click);
      MGAButton btnNext1 = this._btnNext;
      if (btnNext1 != null)
        ((Control) btnNext1).Click -= eventHandler;
      this._btnNext = value;
      MGAButton btnNext2 = this._btnNext;
      if (btnNext2 == null)
        return;
      ((Control) btnNext2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (frmMapFields));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("WorksheetColumns", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ColumnName");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    MGAScrollBarLook mgaScrollBarLook1 = new MGAScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("WorksheetColumns", -1);
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ColumnName");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    MGAScrollBarLook mgaScrollBarLook2 = new MGAScrollBarLook();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    this.Label1 = new System.Windows.Forms.Label();
    this.PictureBox1 = new PictureBox();
    this.Label2 = new System.Windows.Forms.Label();
    this.Label3 = new System.Windows.Forms.Label();
    this.cboTIV = new MGAComboBox();
    this.dvTIV = new DataView();
    this.ds = new dsMapFields();
    this.cboState = new MGAComboBox();
    this.dvStates = new DataView();
    this.btnNext = new MGAButton();
    this.err = new ErrorProvider();
    ((ISupportInitialize) this.cboTIV).BeginInit();
    this.dvTIV.BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    this.dvStates.BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new System.Drawing.Point(64 /*0x40*/, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(423, 17);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Please select the Excel spreadsheet column you would like to use for state and TIV:";
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new System.Drawing.Point(8, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 2;
    this.PictureBox1.TabStop = false;
    this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
    this.Label2.Location = new System.Drawing.Point(24, 87);
    this.Label2.Name = "Label2";
    this.Label2.TabIndex = 4;
    this.Label2.Text = "TIV Column:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
    this.Label3.Location = new System.Drawing.Point(24, 119);
    this.Label3.Name = "Label3";
    this.Label3.TabIndex = 5;
    this.Label3.Text = "State Column:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.cboTIV.BorderStyle = (UIElementBorderStyle) 4;
    this.cboTIV.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboTIV).DataSource = (object) this.dvTIV;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboTIV.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboTIV.DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridBand1.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn1
    });
    this.cboTIV.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboTIV.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboTIV.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboTIV.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboTIV.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    this.cboTIV.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) this.cboTIV.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    this.cboTIV.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    this.cboTIV.DisplayLayout.MaxColScrollRegions = 1;
    this.cboTIV.DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    this.cboTIV.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    this.cboTIV.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    this.cboTIV.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboTIV.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboTIV.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboTIV.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboTIV.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboTIV.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboTIV.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboTIV.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance7.BackColor = SystemColors.Window;
    this.cboTIV.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    this.cboTIV.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    this.cboTIV.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboTIV.DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    this.cboTIV.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    appearance10.TextHAlign = (HAlign) 1;
    this.cboTIV.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    this.cboTIV.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboTIV.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    this.cboTIV.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    this.cboTIV.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Gainsboro;
    appearance12.ForeColor = Color.Black;
    this.cboTIV.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = SystemColors.ControlLight;
    this.cboTIV.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.WhiteSmoke;
    appearance14.BorderColor = Color.Silver;
    mgaScrollBarLook1.ButtonAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.WhiteSmoke;
    mgaScrollBarLook1.TrackAppearance = (AppearanceBase) appearance15;
    this.cboTIV.DisplayLayout.ScrollBarLook = (ScrollBarLook) mgaScrollBarLook1;
    this.cboTIV.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboTIV.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboTIV.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboTIV).DisplayMember = "ColumnName";
    this.cboTIV.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboTIV).Location = new System.Drawing.Point(136, 88);
    this.cboTIV.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboTIV).Name = "cboTIV";
    ((Control) this.cboTIV).Size = new Size(352, 20);
    ((Control) this.cboTIV).TabIndex = 6;
    ((UltraDropDownBase) this.cboTIV).ValueMember = "ColumnName";
    this.dvTIV.Table = (System.Data.DataTable) this.ds.WorksheetColumns;
    this.ds.DataSetName = "dsMapFields";
    this.ds.Locale = new CultureInfo("en-US");
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    this.cboState.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboState).DataSource = (object) this.dvStates;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboState.DisplayLayout.Appearance = (AppearanceBase) appearance16;
    this.cboState.DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridBand2.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn2
    });
    this.cboState.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboState.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboState.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance17.BackColor = SystemColors.ActiveBorder;
    appearance17.BackColor2 = SystemColors.ControlDark;
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboState.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance17;
    appearance18.ForeColor = SystemColors.GrayText;
    this.cboState.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance18;
    ((SpecialBoxBase) this.cboState.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance19.BackColor = SystemColors.ControlLightLight;
    appearance19.BackColor2 = SystemColors.Control;
    appearance19.BackGradientStyle = (GradientStyle) 3;
    appearance19.ForeColor = SystemColors.GrayText;
    this.cboState.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance19;
    this.cboState.DisplayLayout.MaxColScrollRegions = 1;
    this.cboState.DisplayLayout.MaxRowScrollRegions = 1;
    appearance20.BackColor = SystemColors.Window;
    appearance20.ForeColor = SystemColors.ControlText;
    this.cboState.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = SystemColors.Highlight;
    appearance21.ForeColor = SystemColors.HighlightText;
    this.cboState.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    this.cboState.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance22.BackColor = SystemColors.Window;
    this.cboState.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance22;
    appearance23.BorderColor = Color.Silver;
    appearance23.TextTrimming = (TextTrimming) 3;
    this.cboState.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance23;
    this.cboState.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboState.DisplayLayout.Override.CellPadding = 0;
    appearance24.BackColor = SystemColors.Control;
    appearance24.BackColor2 = SystemColors.ControlDark;
    appearance24.BackGradientAlignment = (GradientAlignment) 1;
    appearance24.BackGradientStyle = (GradientStyle) 3;
    appearance24.BorderColor = SystemColors.Window;
    this.cboState.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance24;
    appearance25.TextHAlign = (HAlign) 1;
    this.cboState.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance25;
    this.cboState.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboState.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance26.BackColor = SystemColors.Window;
    appearance26.BorderColor = Color.Silver;
    this.cboState.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance26;
    this.cboState.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance27.BackColor = Color.Gainsboro;
    appearance27.ForeColor = Color.Black;
    this.cboState.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance27;
    appearance28.BackColor = SystemColors.ControlLight;
    this.cboState.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance28;
    appearance29.BackColor = Color.WhiteSmoke;
    appearance29.BorderColor = Color.Silver;
    mgaScrollBarLook2.ButtonAppearance = (AppearanceBase) appearance29;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.WhiteSmoke;
    mgaScrollBarLook2.TrackAppearance = (AppearanceBase) appearance30;
    this.cboState.DisplayLayout.ScrollBarLook = (ScrollBarLook) mgaScrollBarLook2;
    this.cboState.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboState.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboState.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboState).DisplayMember = "ColumnName";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboState).Location = new System.Drawing.Point(136, 120);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(352, 20);
    ((Control) this.cboState).TabIndex = 7;
    ((UltraDropDownBase) this.cboState).ValueMember = "ColumnName";
    this.dvStates.Table = (System.Data.DataTable) this.ds.WorksheetColumns;
    appearance31.BackColor = Color.FromArgb(248, 248, 248);
    appearance31.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance31.BackGradientStyle = (GradientStyle) 2;
    appearance31.BorderColor = Color.DarkGray;
    appearance31.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance31.Image"));
    appearance31.ImageHAlign = (HAlign) 3;
    appearance31.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance31;
    ((ControlBase) this.btnNext).ImageSize = new Size(15, 11);
    ((Control) this.btnNext).Location = new System.Drawing.Point(408, 160 /*0xA0*/);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnNext).TabIndex = 8;
    ((ControlBase) this.btnNext).Text = "Next";
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(530, 192 /*0xC0*/);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.cboState);
    this.Controls.Add((Control) this.cboTIV);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Font = new System.Drawing.Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMapFields);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Map Excel Fields for Allocation";
    ((ISupportInitialize) this.cboTIV).EndInit();
    this.dvTIV.EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    this.dvStates.EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    this.ResumeLayout(false);
  }

  internal bool Cancelled => this._cancelled;

  [CLSCompliant(false)]
  public frmMapFields(
    string excelFileName,
    Worksheet worksheet,
    Quote quote,
    bool PlacePremInStateOfIssuance)
  {
    this.Load += new EventHandler(this.frmMapFields_Load);
    this._dtExcelData = new System.Data.DataTable();
    this.InitializeComponent();
    this._excelFileName = excelFileName;
    this._worksheet = worksheet;
    this._quote = quote;
    this._PlacePremInStateOfIssuance = PlacePremInStateOfIssuance;
  }

  private void frmMapFields_Load(object sender, EventArgs e) => this.GetWorksheetData();

  private void GetWorksheetData()
  {
    if (this._worksheet == null)
      return;
    OleDbCommand selectCommand = new OleDbCommand($"Select * from [{this._worksheet.Name}$]", new OleDbConnection(string.Format(ConfigurationManager.AppSettings["ExcelConnectionString"] + "Data Source={0}", (object) this._excelFileName)));
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      oleDbDataAdapter.Fill(this._dtExcelData);
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this._dtExcelData.Columns)
          this.ds.WorksheetColumns.AddWorksheetColumnsRow(column.ColumnName);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    finally
    {
      selectCommand.Connection.Dispose();
      selectCommand.Dispose();
      oleDbDataAdapter.Dispose();
      this.Cursor = MgaCursors.Default;
    }
  }

  private void btnNext_Click(object sender, EventArgs e)
  {
    if (!this.ValidForm())
      return;
    while (!this._allStatesValid && !this._cancelled)
      this.ValidateStates();
    if (!this._cancelled)
    {
      this.ValidateTIV();
      this.SaveData();
    }
    else
      this.Close();
  }

  private void SaveData()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPremiumAllocationStates WHERE QuoteGuid = @QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    int num1 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT OfficeID FROM tblClientOffices WHERE OfficeGuid = @OG", new object[2]
    {
      (object) "@OG",
      (object) this._quote.QuotingLocationGuid
    });
    Guid quoteGuid = this._quote.QuoteGuid;
    if (this._PlacePremInStateOfIssuance)
    {
      Decimal num2 = 0M;
      object objectValue = RuntimeHelpers.GetObjectValue(this._dtExcelData.Compute("SUM(TIV)", "TIV IS NOT NULL"));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        num2 = Conversions.ToDecimal(objectValue);
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblPremiumAllocationStates(QuoteGuid, StateID, TIV, QuotingLocationID)VALUES(@QuoteGuid,@StateID,@TIV,@QLID)", new object[8]
      {
        (object) "@QuoteGuid",
        (object) quoteGuid,
        (object) "@StateID",
        (object) this._quote.StateID,
        (object) "@TIV",
        (object) num2,
        (object) "@QLID",
        (object) num1
      });
    }
    else
    {
      try
      {
        foreach (DataRow row in this._dtExcelData.Rows)
        {
          if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row[this.cboTIV.Text])))
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblPremiumAllocationStates(QuoteGuid, StateID, TIV, QuotingLocationID)VALUES(@QuoteGuid,@StateID,@TIV,@QLID)", new object[8]
            {
              (object) "@QuoteGuid",
              (object) quoteGuid,
              (object) "@StateID",
              row[this.cboState.Text],
              (object) "@TIV",
              (object) Conversions.ToDouble(row[this.cboTIV.Text]),
              (object) "@QLID",
              (object) num1
            });
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.Close();
  }

  private bool ValidForm()
  {
    bool flag = true;
    if (this.cboState.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboState, "Please select a field.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboState, string.Empty);
    if (this.cboTIV.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboTIV, "Please select a field.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboTIV, string.Empty);
    return flag;
  }

  private void ValidateStates()
  {
    System.Data.DataTable dtStates = (System.Data.DataTable) null;
    for (int index = this._dtExcelData.Rows.Count - 1; index >= 0; index += -1)
    {
      DataRow row = this._dtExcelData.Rows[index];
      row[this.cboState.Text] = (object) row[this.cboState.Text].ToString().Replace(".", string.Empty);
      string str = row[this.cboState.Text].ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, string.Empty, false) == 0)
        this._dtExcelData.Rows.Remove(row);
      else if (!this.IsValidState(str, row))
      {
        if (dtStates == null)
          dtStates = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY State");
        frmSelectValidState selectValidState = new frmSelectValidState(str, dtStates);
        try
        {
          int num = (int) selectValidState.ShowDialog();
          if (!selectValidState.Saved)
          {
            if (MessageBox.Show("The import process can not continue without the selection of a valid state.\n\nAre you sure you want to cancel the import process?", "Cancel Import?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
              return;
            this._cancelled = true;
            return;
          }
          row[this.cboState.Text] = (object) selectValidState.SelectedStateID;
        }
        finally
        {
          selectValidState.Dispose();
        }
      }
    }
    this._allStatesValid = true;
  }

  private void ValidateTIV()
  {
    try
    {
      foreach (DataRow row in this._dtExcelData.Rows)
      {
        string str = row[this.cboTIV.Text].ToString();
        char[] charArray = str.ToCharArray();
        int index = 0;
        while (index < charArray.Length)
        {
          char ch = charArray[index];
          if (!Versioned.IsNumeric((object) ch.ToString()))
            str = str.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private bool IsValidState(string state, DataRow dr)
  {
    bool flag;
    if (state.Length == 2)
      flag = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT StateID FROM lstStates WHERE StateID=@SID", new object[2]
      {
        (object) "@SID",
        (object) state
      }) != null;
    else if (state.Length > 2)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT StateID FROM lstStates WHERE State=@S", new object[2]
      {
        (object) "@S",
        (object) state
      }));
      if (objectValue != null)
      {
        dr[this.cboState.Text] = RuntimeHelpers.GetObjectValue(objectValue);
        flag = true;
      }
      else
        flag = false;
    }
    else
      flag = false;
    return flag;
  }
}
