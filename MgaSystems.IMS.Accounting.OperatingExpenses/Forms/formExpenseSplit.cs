// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formExpenseSplit
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
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formExpenseSplit : AccountingNoteDocumentSupport
{
  private System.ComponentModel.Container components;
  internal UltraGrid gridOperatingExpenseJournal;
  private Panel panel1;
  private MGAButton buttonClose;
  private dsPOSplitDetails dsPOSplitDetails1;
  private SqlDataAdapter daGetPODetails;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private int poNumber;

  public formExpenseSplit(int PurchaseOrderNumber)
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.poNumber = PurchaseOrderNumber;
    this.daGetPODetails.SelectCommand.Parameters["@ponum"].Value = (object) this.poNumber;
    this.daGetPODetails.Fill((DataSet) this.dsPOSplitDetails1);
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
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_GetPurchaseOrderDetails", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Expense");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Amount");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Discount");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Total");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.gridOperatingExpenseJournal = new UltraGrid();
    this.panel1 = new Panel();
    this.buttonClose = new MGAButton();
    this.dsPOSplitDetails1 = new dsPOSplitDetails();
    this.daGetPODetails = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    ((ISupportInitialize) this.gridOperatingExpenseJournal).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.buttonClose).BeginInit();
    this.dsPOSplitDetails1.BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.gridOperatingExpenseJournal).DataSource = (object) this.dsPOSplitDetails1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Width = 236;
    ((AppearanceBase) appearance2).TextHAlign = (HAlign) 3;
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn2.Format = "c";
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance3;
    ultraGridColumn2.Width = 94;
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 3;
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance5).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 92;
    ((AppearanceBase) appearance6).TextHAlign = (HAlign) 3;
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance7).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 90;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand.GroupHeadersVisible = false;
    ultraGridBand.LevelCount = 2;
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance9).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BackColor2 = Color.SlateGray;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.LightSlateGray;
    ((AppearanceBase) appearance13).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance13).ForeColor = Color.White;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.RowConnectorColor = Color.Silver;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    scrollBarLook.Appearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance15).BackColor2 = Color.White;
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 6;
    ((AppearanceBase) appearance15).ForeColor = Color.DarkBlue;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridOperatingExpenseJournal).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridOperatingExpenseJournal).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridOperatingExpenseJournal).Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridOperatingExpenseJournal).Location = new Point(0, 0);
    ((Control) this.gridOperatingExpenseJournal).Name = "gridOperatingExpenseJournal";
    ((Control) this.gridOperatingExpenseJournal).Size = new Size(514, 296);
    ((UltraControlBase) this.gridOperatingExpenseJournal).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridOperatingExpenseJournal).TabIndex = 2;
    this.panel1.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.panel1.Controls.Add((Control) this.buttonClose);
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Location = new Point(0, 256 /*0x0100*/);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(514, 40);
    this.panel1.TabIndex = 3;
    ((Control) this.buttonClose).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance16).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance16).BackColor2 = Color.White;
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonClose).Appearance = (AppearanceBase) appearance16;
    ((Control) this.buttonClose).Location = new Point(408, 8);
    ((Control) this.buttonClose).Name = "buttonClose";
    ((Control) this.buttonClose).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonClose).TabIndex = 0;
    ((Control) this.buttonClose).Text = "Close";
    ((Control) this.buttonClose).Click += new EventHandler(this.buttonClose_Click);
    this.dsPOSplitDetails1.DataSetName = "dsPOSplitDetails";
    this.dsPOSplitDetails1.Locale = new CultureInfo("en-US");
    this.daGetPODetails.SelectCommand = this.sqlSelectCommand1;
    this.daGetPODetails.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetPurchaseOrderDetails", new DataColumnMapping[4]
      {
        new DataColumnMapping("Expense", "Expense"),
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("Discount", "Discount"),
        new DataColumnMapping("Total", "Total")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetPurchaseOrderDetails]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@PONUM", SqlDbType.Int, 4));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(514, 296);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.gridOperatingExpenseJournal);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (formExpenseSplit);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Expense Split";
    ((ISupportInitialize) this.gridOperatingExpenseJournal).EndInit();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.buttonClose).EndInit();
    this.dsPOSplitDetails1.EndInit();
    this.ResumeLayout(false);
  }

  private void buttonClose_Click(object sender, EventArgs e) => this.Close();
}
