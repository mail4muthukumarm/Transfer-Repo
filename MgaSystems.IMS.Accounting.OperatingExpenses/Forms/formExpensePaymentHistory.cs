// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formExpensePaymentHistory
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formExpensePaymentHistory : AccountingNoteDocumentSupport
{
  private EllipsePanel ellipsePanel1;
  private MGAButton buttonClose;
  private UltraGrid gridPayments;
  private dsPOPaymentHistory dsPOPaymentHistory1;
  private CheckBox checkShowVoids;
  private System.ComponentModel.Container components;

  private formExpensePaymentHistory() => this.InitializeComponent();

  public formExpensePaymentHistory(int poNum)
  {
    this.InitializeComponent();
    this.LoadPaymentHistory(poNum);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Payments", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PostDate");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CheckNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CheckAmount");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Voided");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.ellipsePanel1 = new EllipsePanel();
    this.buttonClose = new MGAButton();
    this.gridPayments = new UltraGrid();
    this.dsPOPaymentHistory1 = new dsPOPaymentHistory();
    this.checkShowVoids = new CheckBox();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.buttonClose).BeginInit();
    ((ISupportInitialize) this.gridPayments).BeginInit();
    this.dsPOPaymentHistory1.BeginInit();
    this.SuspendLayout();
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.checkShowVoids);
    this.ellipsePanel1.Controls.Add((Control) this.buttonClose);
    this.ellipsePanel1.Controls.Add((Control) this.gridPayments);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(8, 8);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(488, 272);
    this.ellipsePanel1.TabIndex = 0;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClose).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.buttonClose).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonClose).Location = new Point(400, 240 /*0xF0*/);
    ((Control) this.buttonClose).Name = "buttonClose";
    ((Control) this.buttonClose).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonClose).TabIndex = 2;
    ((Control) this.buttonClose).Text = "Close";
    ((Control) this.buttonClose).Click += new EventHandler(this.buttonClose_Click);
    ((UltraGridBase) this.gridPayments).DataMember = "Payments";
    ((UltraGridBase) this.gridPayments).DataSource = (object) this.dsPOPaymentHistory1;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPayments).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Check Date";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 116;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Check Number";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 125;
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 3;
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 106;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 123;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 55;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.gridPayments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridPayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance6).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance7).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridPayments).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraControlBase) this.gridPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridPayments).Location = new Point(8, 8);
    ((Control) this.gridPayments).Name = "gridPayments";
    ((Control) this.gridPayments).Size = new Size(472, 224 /*0xE0*/);
    ((UltraControlBase) this.gridPayments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridPayments).TabIndex = 0;
    this.gridPayments.InitializeRow += new InitializeRowEventHandler(this.gridPayments_InitializeRow);
    this.dsPOPaymentHistory1.DataSetName = "dsPOPaymentHistory";
    this.dsPOPaymentHistory1.Locale = new CultureInfo("en-US");
    this.checkShowVoids.FlatStyle = FlatStyle.Flat;
    this.checkShowVoids.Location = new Point(8, 240 /*0xF0*/);
    this.checkShowVoids.Name = "checkShowVoids";
    this.checkShowVoids.TabIndex = 3;
    this.checkShowVoids.Text = "Show Voids";
    this.checkShowVoids.CheckedChanged += new EventHandler(this.checkShowVoids_CheckedChanged);
    this.AcceptButton = (IButtonControl) this.buttonClose;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonClose;
    this.ClientSize = new Size(506, 288);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formExpensePaymentHistory);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Expense Payment History";
    this.ellipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.buttonClose).EndInit();
    ((ISupportInitialize) this.gridPayments).EndInit();
    this.dsPOPaymentHistory1.EndInit();
    this.ResumeLayout(false);
  }

  private void buttonClose_Click(object sender, EventArgs e) => this.Close();

  private void LoadPaymentHistory(int poNum)
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetPOPaymentHistory", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ponum", (object) poNum);
      sqlDataAdapter.Fill((DataTable) this.dsPOPaymentHistory1.Payments);
    }
    this.FilterVoids();
  }

  private void gridPayments_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!bool.Parse(e.Row.Cells["voided"].Value.ToString()))
      return;
    ((AppearanceBase) e.Row.Appearance).FontData.Strikeout = (DefaultableBoolean) 1;
    ((AppearanceBase) e.Row.Appearance).ForeColor = Color.Red;
  }

  private void FilterVoids()
  {
    foreach (UltraGridBand band in ((UltraGridBase) this.gridPayments).DisplayLayout.Bands)
      band.ColumnFilters["voided"].FilterConditions.Add((FilterComparisionOperator) 0, (object) false);
  }

  private void UnFilterVoids()
  {
    foreach (UltraGridBand band in ((UltraGridBase) this.gridPayments).DisplayLayout.Bands)
      band.ColumnFilters.ClearAllFilters();
    ((UltraGridBase) this.gridPayments).DisplayLayout.RowScrollRegions[0].ScrollRowIntoView(((UltraGridBase) this.gridPayments).Rows[0]);
  }

  private void checkShowVoids_CheckedChanged(object sender, EventArgs e)
  {
    if (((CheckBox) sender).Checked)
      this.UnFilterVoids();
    else
      this.FilterVoids();
  }
}
