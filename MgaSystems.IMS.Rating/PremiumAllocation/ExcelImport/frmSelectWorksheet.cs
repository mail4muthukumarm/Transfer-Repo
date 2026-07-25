// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport.frmSelectWorksheet
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Tools;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport;

public sealed class frmSelectWorksheet : Form
{
  private IContainer components;
  private PictureBox PictureBox1;
  private System.Windows.Forms.Label Label1;
  private System.Windows.Forms.Label Label2;
  private MGAComboBox cboWorksheets;
  private dsWorksheets ds;
  private ErrorProvider err;
  private Workbook _workbook;
  private string _selectedWorksheet;

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
    ResourceManager resourceManager = new ResourceManager(typeof (frmSelectWorksheet));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Worksheets", -1);
    UltraGridColumn ultraGridColumn = new UltraGridColumn("WorksheetName");
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
    MGAScrollBarLook mgaScrollBarLook = new MGAScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new System.Windows.Forms.Label();
    this.Label2 = new System.Windows.Forms.Label();
    this.cboWorksheets = new MGAComboBox();
    this.ds = new dsWorksheets();
    this.btnNext = new MGAButton();
    this.err = new ErrorProvider();
    ((ISupportInitialize) this.cboWorksheets).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    this.SuspendLayout();
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new System.Drawing.Point(16 /*0x10*/, 23);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.Location = new System.Drawing.Point(88, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(269, 17);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "This Excel Spreadsheet has multiple worksheets in it.";
    this.Label2.AutoSize = true;
    this.Label2.Location = new System.Drawing.Point(88, 39);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(394, 17);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Please select the worksheet you would like to import the allocation data from:";
    this.cboWorksheets.BorderStyle = (UIElementBorderStyle) 4;
    this.cboWorksheets.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboWorksheets).DataSource = (object) this.ds.Worksheets;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboWorksheets.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboWorksheets.DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn.Header.VisiblePosition = 0;
    ultraGridBand.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn
    });
    this.cboWorksheets.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cboWorksheets.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboWorksheets.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboWorksheets.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboWorksheets.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    this.cboWorksheets.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) this.cboWorksheets.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    this.cboWorksheets.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    this.cboWorksheets.DisplayLayout.MaxColScrollRegions = 1;
    this.cboWorksheets.DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    this.cboWorksheets.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    this.cboWorksheets.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    this.cboWorksheets.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboWorksheets.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboWorksheets.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboWorksheets.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboWorksheets.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboWorksheets.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboWorksheets.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboWorksheets.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance7.BackColor = SystemColors.Window;
    this.cboWorksheets.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    this.cboWorksheets.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    this.cboWorksheets.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboWorksheets.DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    this.cboWorksheets.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    appearance10.TextHAlign = (HAlign) 1;
    this.cboWorksheets.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    this.cboWorksheets.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboWorksheets.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    this.cboWorksheets.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    this.cboWorksheets.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Gainsboro;
    appearance12.ForeColor = Color.Black;
    this.cboWorksheets.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = SystemColors.ControlLight;
    this.cboWorksheets.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.WhiteSmoke;
    appearance14.BorderColor = Color.Silver;
    mgaScrollBarLook.ButtonAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.WhiteSmoke;
    mgaScrollBarLook.TrackAppearance = (AppearanceBase) appearance15;
    this.cboWorksheets.DisplayLayout.ScrollBarLook = (ScrollBarLook) mgaScrollBarLook;
    this.cboWorksheets.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboWorksheets.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboWorksheets.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboWorksheets).DisplayMember = "WorksheetName";
    this.cboWorksheets.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboWorksheets).Location = new System.Drawing.Point(88, 64 /*0x40*/);
    this.cboWorksheets.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboWorksheets).Name = "cboWorksheets";
    ((Control) this.cboWorksheets).Size = new Size(392, 20);
    ((Control) this.cboWorksheets).TabIndex = 3;
    ((UltraDropDownBase) this.cboWorksheets).ValueMember = "WorksheetName";
    this.ds.DataSetName = "dsWorksheets";
    this.ds.Locale = new CultureInfo("en-US");
    appearance16.BackColor = Color.FromArgb(248, 248, 248);
    appearance16.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = Color.DarkGray;
    appearance16.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance16.Image"));
    appearance16.ImageHAlign = (HAlign) 3;
    appearance16.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance16;
    ((ControlBase) this.btnNext).ImageSize = new Size(15, 11);
    ((Control) this.btnNext).Location = new System.Drawing.Point(400, 96 /*0x60*/);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnNext).TabIndex = 4;
    ((ControlBase) this.btnNext).Text = "Next";
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(506, 128 /*0x80*/);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.cboWorksheets);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Font = new System.Drawing.Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectWorksheet);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select a Worksheet";
    ((ISupportInitialize) this.cboWorksheets).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    this.ResumeLayout(false);
  }

  [CLSCompliant(false)]
  public frmSelectWorksheet(Workbook myWorkbook)
  {
    this.Load += new EventHandler(this.frmSelectWorksheet_Load);
    this._selectedWorksheet = string.Empty;
    this.InitializeComponent();
    this._workbook = myWorkbook;
  }

  public string SelectedWorksheet => this._selectedWorksheet;

  private void frmSelectWorksheet_Load(object sender, EventArgs e)
  {
    IEnumerator enumerator;
    try
    {
      enumerator = (IEnumerator) this._workbook.Worksheets.GetEnumerator();
      while (enumerator.MoveNext())
        this.ds.Worksheets.AddWorksheetsRow(((_Worksheet) enumerator.Current).Name);
    }
    finally
    {
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      this._workbook = (Workbook) null;
      if (this.components != null)
        this.components.Dispose();
    }
    base.Dispose(disposing);
  }

  private void btnNext_Click(object sender, EventArgs e)
  {
    if (this.cboWorksheets.Value == null)
    {
      this.err.SetError((Control) this.cboWorksheets, "Please select a worksheet.");
    }
    else
    {
      this._selectedWorksheet = this.cboWorksheets.Text;
      this.Close();
    }
  }
}
