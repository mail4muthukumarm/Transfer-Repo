// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmBankDepositHistory
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public sealed class frmBankDepositHistory : Form
{
  private IContainer components;

  public frmBankDepositHistory()
  {
    this.Load += new EventHandler(this.frmBankDepositHistory_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("EllipsePanel1")]
  internal virtual EllipsePanel EllipsePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridHistory")]
  internal virtual UltraGrid gridHistory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankDepositHistory1")]
  internal virtual dsBankDepositHistory DsBankDepositHistory1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (frmBankDepositHistory));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("DepositHeader", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("depositId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("depositDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("userName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("bankName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("depositTotal");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.EllipsePanel1 = new EllipsePanel();
    this.gridHistory = new UltraGrid();
    this.DsBankDepositHistory1 = new dsBankDepositHistory();
    this.EllipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.gridHistory).BeginInit();
    this.DsBankDepositHistory1.BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.DarkGray;
    this.Label1.Location = new Point(88, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(240 /*0xF0*/, 29);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Bank Deposit History";
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.EllipsePanel1.Controls.Add((Control) this.gridHistory);
    this.EllipsePanel1.Controls.Add((Control) this.Label1);
    this.EllipsePanel1.Controls.Add((Control) this.PictureBox1);
    this.EllipsePanel1.CornerOffset = 20;
    this.EllipsePanel1.Dock = DockStyle.Fill;
    this.EllipsePanel1.Location = new Point(0, 0);
    this.EllipsePanel1.Name = "EllipsePanel1";
    this.EllipsePanel1.Size = new Size(674, 416);
    this.EllipsePanel1.TabIndex = 1;
    ((UltraGridBase) this.gridHistory).DataMember = "DepositHeader";
    ((UltraGridBase) this.gridHistory).DataSource = (object) this.DsBankDepositHistory1;
    appearance1.BackColor = Color.White;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 104;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Deposit Date";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 141;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "User";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 156;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Bank Name";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 155;
    appearance2.TextHAlign = (HAlign) 3;
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn5.Format = "c";
    appearance3.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Deposit Total";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 124;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.gridHistory).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridHistory).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance4.BackColor = Color.White;
    appearance4.FontData.BoldAsString = "True";
    appearance4.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.White;
    appearance5.BackColor2 = Color.LightSteelBlue;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.gridHistory).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    ((Control) this.gridHistory).Location = new Point(88, 40);
    ((Control) this.gridHistory).Name = "gridHistory";
    ((Control) this.gridHistory).Size = new Size(576, 368);
    ((UltraControlBase) this.gridHistory).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridHistory).TabIndex = 2;
    this.DsBankDepositHistory1.DataSetName = "dsBankDepositHistory";
    this.DsBankDepositHistory1.Locale = new CultureInfo("en-US");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(674, 416);
    this.Controls.Add((Control) this.EllipsePanel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBankDepositHistory);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank Deposit History";
    this.EllipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.gridHistory).EndInit();
    this.DsBankDepositHistory1.EndInit();
    this.ResumeLayout(false);
  }

  private void UltraButton1_Click(object sender, EventArgs e) => this.Close();

  private void frmBankDepositHistory_Load(object sender, EventArgs e)
  {
    this.SetStyle(ControlStyles.Opaque, true);
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    this.TransparencyKey = Color.Transparent;
  }
}
