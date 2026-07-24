// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formVendorCard
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Reporting;
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

public class formVendorCard : AccountingNoteDocumentSupport
{
  internal UltraLabel UltraLabel1;
  internal Panel Panel2;
  internal Label label7;
  internal PictureBox PictureBox1;
  internal Label label8;
  internal Panel Panel1;
  internal MGAButton buttonClose;
  private UltraTabControl ultraTabControl1;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage1;
  private UltraTabPageControl ultraTabPageControl1;
  private UltraTabPageControl ultraTabPageControl2;
  private dsVendorCard dsVendorCard1;
  private UltraGrid gridOpenItems;
  internal Label labelEntityName;
  private DateRangeOptionPicker dateRangeOptionPicker1;
  private UltraGrid gridVendorHistory;
  internal MGAButton buttonChangeVendor;
  internal MGAButton buttonCreateCheck;
  internal UltraLabel ultraLabel4;
  internal UltraLabel ultraLabel8;
  internal MGAButton btnPrintHistory;
  private MGASimpleComboBox comboOfficeLocation;
  private System.ComponentModel.Container components;
  private Guid _payeeGuid;
  private int _glCompanyId;
  private bool _closeAfterActivate;

  public formVendorCard(int glCompanyId)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
  }

  public formVendorCard(Guid payeeGuid, int glCompanyId)
  {
    this.InitializeComponent();
    this._payeeGuid = payeeGuid;
    this._glCompanyId = glCompanyId;
    this.labelEntityName.Text = MGASystems.IMS.Accounting.Utilities.Tools.GetEntityName(payeeGuid);
    this.LoadOpenItems();
    this.LoadOfficeLocations();
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("OpenItems", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ponum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("podate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PaymentDueDate");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("paymentTerms");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("payeeInvNum");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Amount");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PAY", 0);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("VendorHistory", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ponum");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("podate");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PaymentDueDate");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("paymentTerms");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("payeeInvNum");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Amount");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Payments");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formVendorCard));
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.gridOpenItems = new UltraGrid();
    this.dsVendorCard1 = new dsVendorCard();
    this.labelEntityName = new Label();
    this.ultraTabPageControl2 = new UltraTabPageControl();
    this.dateRangeOptionPicker1 = new DateRangeOptionPicker();
    this.gridVendorHistory = new UltraGrid();
    this.UltraLabel1 = new UltraLabel();
    this.Panel2 = new Panel();
    this.label7 = new Label();
    this.PictureBox1 = new PictureBox();
    this.label8 = new Label();
    this.Panel1 = new Panel();
    this.btnPrintHistory = new MGAButton();
    this.buttonCreateCheck = new MGAButton();
    this.buttonChangeVendor = new MGAButton();
    this.buttonClose = new MGAButton();
    this.ultraTabControl1 = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.comboOfficeLocation = new MGASimpleComboBox();
    ((Control) this.ultraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.gridOpenItems).BeginInit();
    this.dsVendorCard1.BeginInit();
    ((Control) this.ultraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.gridVendorHistory).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.btnPrintHistory).BeginInit();
    ((ISupportInitialize) this.buttonCreateCheck).BeginInit();
    ((ISupportInitialize) this.buttonChangeVendor).BeginInit();
    ((ISupportInitialize) this.buttonClose).BeginInit();
    ((ISupportInitialize) this.ultraTabControl1).BeginInit();
    ((Control) this.ultraTabControl1).SuspendLayout();
    ((Control) this.ultraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.gridOpenItems);
    ((Control) this.ultraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(652, 460);
    ((UltraGridBase) this.gridOpenItems).DataSource = (object) this.dsVendorCard1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "PO Number";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Width = 73;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "PO Date";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 70;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Due Date";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Width = 69;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Payment Terms";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 78;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Vendor Invoice #";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Width = 106;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Width = 161;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 7;
    ultraGridColumn7.Width = 97;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.DataType = typeof (bool);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Click To Pay";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 0;
    ultraGridColumn8.Style = (ColumnStyle) 3;
    ultraGridColumn8.Width = 74;
    ultraGridBand1.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand1.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand1.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand1.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ultraGridBand1.Override.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ultraGridBand1.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BackColor = Color.Transparent;
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance13).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridOpenItems).Dock = DockStyle.Fill;
    ((Control) this.gridOpenItems).Location = new Point(0, 0);
    ((Control) this.gridOpenItems).Name = "gridOpenItems";
    ((Control) this.gridOpenItems).Size = new Size(652, 460);
    ((Control) this.gridOpenItems).TabIndex = 2;
    ((UltraControlBase) this.gridOpenItems).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOpenItems).UseOsThemes = (DefaultableBoolean) 2;
    this.dsVendorCard1.DataSetName = "dsVendorCard";
    this.dsVendorCard1.Locale = new CultureInfo("en-US");
    this.dsVendorCard1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.labelEntityName.Dock = DockStyle.Top;
    this.labelEntityName.Font = new Font("Tahoma", 10f);
    this.labelEntityName.ForeColor = Color.Black;
    this.labelEntityName.Location = new Point(0, 0);
    this.labelEntityName.Name = "labelEntityName";
    this.labelEntityName.Size = new Size(652, 30);
    this.labelEntityName.TabIndex = 1;
    this.labelEntityName.Text = "[VENDOR NAME]";
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.comboOfficeLocation);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.dateRangeOptionPicker1);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.gridVendorHistory);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.labelEntityName);
    ((Control) this.ultraTabPageControl2).Location = new Point(1, 1);
    ((Control) this.ultraTabPageControl2).Name = "ultraTabPageControl2";
    ((Control) this.ultraTabPageControl2).Size = new Size(652, 460);
    this.dateRangeOptionPicker1.Dock = DockStyle.Bottom;
    this.dateRangeOptionPicker1.Location = new Point(0, 436);
    this.dateRangeOptionPicker1.Name = "dateRangeOptionPicker1";
    this.dateRangeOptionPicker1.Size = new Size(652, 24);
    this.dateRangeOptionPicker1.TabIndex = 3;
    this.dateRangeOptionPicker1.DateChanged += new DateRangeOptionPicker.DateChangedEventHandler(this.dateRangeOptionPicker1_DateChanged);
    ((UltraGridBase) this.gridVendorHistory).DataMember = "VendorHistory";
    ((UltraGridBase) this.gridVendorHistory).DataSource = (object) this.dsVendorCard1;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Purchase Order #";
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 0;
    ultraGridColumn9.Width = 89;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "PO Date";
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 1;
    ultraGridColumn10.Width = 75;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 2;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 89;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 3;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 98;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 4;
    ultraGridColumn13.Width = 60;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 5;
    ultraGridColumn14.Width = 225;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance16;
    ultraGridColumn15.Format = "c";
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance17;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 6;
    ultraGridColumn15.Width = 119;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 7;
    ultraGridColumn16.Width = 82;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    ultraGridBand2.Override.CellAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance25).BackColor = Color.Transparent;
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance26).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridVendorHistory).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridVendorHistory).Dock = DockStyle.Fill;
    ((Control) this.gridVendorHistory).Location = new Point(0, 30);
    ((Control) this.gridVendorHistory).Name = "gridVendorHistory";
    ((Control) this.gridVendorHistory).Size = new Size(652, 430);
    ((Control) this.gridVendorHistory).TabIndex = 2;
    ((UltraControlBase) this.gridVendorHistory).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridVendorHistory).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance28).BackColor = Color.White;
    ((AppearanceBase) appearance28).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance28).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance28;
    ((Control) this.UltraLabel1).Dock = DockStyle.Left;
    ((Control) this.UltraLabel1).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(200, 486);
    ((Control) this.UltraLabel1).TabIndex = 41;
    this.Panel2.Controls.Add((Control) this.label7);
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Controls.Add((Control) this.label8);
    this.Panel2.Dock = DockStyle.Top;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(856, 80 /*0x50*/);
    this.Panel2.TabIndex = 40;
    this.label7.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label7.Dock = DockStyle.Bottom;
    this.label7.ForeColor = Color.FromArgb(239, 247, 253);
    this.label7.Location = new Point(0, 79);
    this.label7.Name = "label7";
    this.label7.Size = new Size(856, 1);
    this.label7.TabIndex = 1;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 0);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(80 /*0x50*/, 80 /*0x50*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold);
    this.label8.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label8.Location = new Point(648, 56);
    this.label8.Name = "label8";
    this.label8.Size = new Size(203, 19);
    this.label8.TabIndex = 0;
    this.label8.Text = "Vendor Information Utility";
    this.Panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel1.Controls.Add((Control) this.btnPrintHistory);
    this.Panel1.Controls.Add((Control) this.buttonCreateCheck);
    this.Panel1.Controls.Add((Control) this.buttonChangeVendor);
    this.Panel1.Controls.Add((Control) this.buttonClose);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 566);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(856, 40);
    this.Panel1.TabIndex = 42;
    ((AppearanceBase) appearance29).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance29).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance29).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance29).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance29).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance29).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnPrintHistory).Appearance = (AppearanceBase) appearance29;
    ((Control) this.btnPrintHistory).Location = new Point(112 /*0x70*/, 8);
    ((Control) this.btnPrintHistory).Name = "btnPrintHistory";
    ((Control) this.btnPrintHistory).Size = new Size(112 /*0x70*/, 24);
    ((Control) this.btnPrintHistory).TabIndex = 5;
    ((Control) this.btnPrintHistory).Text = "Print Vendor History";
    ((UltraControlBase) this.btnPrintHistory).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnPrintHistory).Visible = false;
    ((Control) this.btnPrintHistory).Click += new EventHandler(this.btnPrintHistory_Click);
    ((Control) this.buttonCreateCheck).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance30).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance30).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance30).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance30).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance30).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance30).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCreateCheck).Appearance = (AppearanceBase) appearance30;
    ((Control) this.buttonCreateCheck).Location = new Point(648, 8);
    ((Control) this.buttonCreateCheck).Name = "buttonCreateCheck";
    ((Control) this.buttonCreateCheck).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCreateCheck).TabIndex = 4;
    ((Control) this.buttonCreateCheck).Text = "Create Check";
    ((UltraControlBase) this.buttonCreateCheck).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCreateCheck).Click += new EventHandler(this.buttonCreateCheck_Click);
    ((AppearanceBase) appearance31).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance31).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance31).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance31).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance31).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance31).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonChangeVendor).Appearance = (AppearanceBase) appearance31;
    ((Control) this.buttonChangeVendor).Location = new Point(8, 8);
    ((Control) this.buttonChangeVendor).Name = "buttonChangeVendor";
    ((Control) this.buttonChangeVendor).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonChangeVendor).TabIndex = 3;
    ((Control) this.buttonChangeVendor).Text = "Change Vendor";
    ((UltraControlBase) this.buttonChangeVendor).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonChangeVendor).Click += new EventHandler(this.buttonChangeVendor_Click);
    ((Control) this.buttonClose).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance32).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance32).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance32).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance32).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance32).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance32).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClose).Appearance = (AppearanceBase) appearance32;
    ((Control) this.buttonClose).Location = new Point(752, 8);
    ((Control) this.buttonClose).Name = "buttonClose";
    ((Control) this.buttonClose).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonClose).TabIndex = 2;
    ((Control) this.buttonClose).Text = "Close";
    ((UltraControlBase) this.buttonClose).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonClose).Click += new EventHandler(this.buttonClose_Click);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabPageControl1);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabPageControl2);
    ((Control) this.ultraTabControl1).Dock = DockStyle.Fill;
    ((Control) this.ultraTabControl1).Location = new Point(200, 80 /*0x50*/);
    ((Control) this.ultraTabControl1).Name = "ultraTabControl1";
    ((UltraTabControlBase) this.ultraTabControl1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.labelEntityName
    });
    ((UltraTabControlBase) this.ultraTabControl1).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.ultraTabControl1).Size = new Size(656, 486);
    ((Control) this.ultraTabControl1).TabIndex = 43;
    ((UltraTabControlBase) this.ultraTabControl1).TabOrientation = (TabOrientation) 3;
    ultraTab1.TabPage = this.ultraTabPageControl1;
    ultraTab1.Text = "Open / Current Items";
    ultraTab2.TabPage = this.ultraTabPageControl2;
    ultraTab2.Text = "Vendor History";
    ((UltraTabControlBase) this.ultraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.ultraTabControl1).SelectedTabChanged += new SelectedTabChangedEventHandler(this.ultraTabControl1_SelectedTabChanged);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.labelEntityName);
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(652, 460);
    ((AppearanceBase) appearance33).BackColor = Color.White;
    ((AppearanceBase) appearance33).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance33).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance33).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance33).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance33;
    ((Control) this.ultraLabel4).Location = new Point(8, 104);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(160 /*0xA0*/, 72);
    ((Control) this.ultraLabel4).TabIndex = 45;
    ((Control) this.ultraLabel4).Text = "The Vendor Information Ultity can be used to review a vendors account. This utlity can also be used to pay a vendor for multiple purchase orders.";
    ((AppearanceBase) appearance34).BackColor = Color.White;
    ((AppearanceBase) appearance34).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance34).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance34).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance34).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance34;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, System.Drawing.FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 88);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(187, 15);
    ((Control) this.ultraLabel8).TabIndex = 44;
    ((Control) this.ultraLabel8).Text = "VENDOR INFORMATION UTILITY";
    ((Control) this.comboOfficeLocation).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.CharacterCasing = CharacterCasing.Normal;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(447, 3);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(200, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 4;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(856, 606);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.ultraTabControl1);
    this.Controls.Add((Control) this.UltraLabel1);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formVendorCard);
    this.Text = "Vendor Information Utility";
    this.Load += new EventHandler(this.formVendorCard_Load);
    this.VisibleChanged += new EventHandler(this.formVendorCard_VisibleChanged);
    ((Control) this.ultraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.gridOpenItems).EndInit();
    this.dsVendorCard1.EndInit();
    ((Control) this.ultraTabPageControl2).ResumeLayout(false);
    ((Control) this.ultraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.gridVendorHistory).EndInit();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.btnPrintHistory).EndInit();
    ((ISupportInitialize) this.buttonCreateCheck).EndInit();
    ((ISupportInitialize) this.buttonChangeVendor).EndInit();
    ((ISupportInitialize) this.buttonClose).EndInit();
    ((ISupportInitialize) this.ultraTabControl1).EndInit();
    ((Control) this.ultraTabControl1).ResumeLayout(false);
    ((Control) this.ultraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void buttonClose_Click(object sender, EventArgs e) => this.Close();

  private void LoadOpenItems()
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetVendorOpenItems", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.Clear();
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@entityGuid", (object) this._payeeGuid.ToString());
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._glCompanyId);
      this.dsVendorCard1.OpenItems.Clear();
      sqlDataAdapter.Fill((DataTable) this.dsVendorCard1.OpenItems);
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      ((Control) this.buttonCreateCheck).Enabled = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridOpenItems).Rows).Count > 0;
    }
  }

  private void LoadVendorHistory()
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetVendorHistory", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      this.dsVendorCard1.VendorHistory.Clear();
      sqlDataAdapter.SelectCommand.Parameters.Clear();
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@entityGuid", (object) this._payeeGuid.ToString());
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dateFrom", (object) this.dateRangeOptionPicker1.DateRangeFrom);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dateTo", (object) this.dateRangeOptionPicker1.DateRangeTo);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) (int) this.comboOfficeLocation.Value);
      sqlDataAdapter.Fill((DataTable) this.dsVendorCard1.VendorHistory);
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
    }
  }

  private void dateRangeOptionPicker1_DateChanged(object sender, MGASystems.IMS.Accounting.Controls.DateRangeEventArgs e)
  {
    this.LoadVendorHistory();
  }

  private void ultraTabControl1_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridVendorHistory).Rows).Count == 0 && ((UltraTabControlBase) this.ultraTabControl1).SelectedTab.Index == 1)
      this.LoadVendorHistory();
    ((Control) this.btnPrintHistory).Visible = ((UltraTabControlBase) this.ultraTabControl1).SelectedTab.Index == 1;
  }

  private void buttonCreateCheck_Click(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridOpenItems).DisplayLayout.Bands[0].ColumnFilters["pay"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridOpenItems).Rows.GetFilteredInNonGroupByRows();
    if (inNonGroupByRows.Length == 0)
    {
      int num = (int) MessageBox.Show("You must select at least one open expense to continue.", "Required Selection Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((UltraGridBase) this.gridOpenItems).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    }
    else
    {
      if (!this.VerifyCheckAmount(inNonGroupByRows))
        return;
      int[] poNumbers = new int[inNonGroupByRows.Length];
      for (int index = 0; index < inNonGroupByRows.Length; ++index)
        poNumbers[index] = int.Parse(inNonGroupByRows[index].Cells["ponum"].Value.ToString());
      ((UltraGridBase) this.gridOpenItems).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
      formListOpenPODetails listOpenPoDetails = new formListOpenPODetails(poNumbers, this._glCompanyId, this._payeeGuid, this.labelEntityName.Text);
      try
      {
        if (listOpenPoDetails.ShowDialog() != DialogResult.OK)
          return;
        this.LoadOpenItems();
      }
      finally
      {
        listOpenPoDetails.Dispose();
      }
    }
  }

  private bool VerifyCheckAmount(UltraGridRow[] rows)
  {
    Decimal num1 = 0M;
    for (int index = 0; index < rows.Length; ++index)
      num1 += Decimal.Parse(rows[index].Cells["Amount"].Value.ToString());
    if (!(num1 < 0M))
      return true;
    int num2 = (int) MessageBox.Show("Check amount can not be less than zero.", "Invalid Check Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void buttonChangeVendor_Click(object sender, EventArgs e)
  {
    FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.All);
    try
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      this._payeeGuid = formSearchEntity.EntityGuid;
      this.labelEntityName.Text = formSearchEntity.EntityName;
      this.LoadOpenItems();
      this.dsVendorCard1.VendorHistory.Clear();
    }
    finally
    {
      formSearchEntity.Dispose();
    }
  }

  private void formVendorCard_Load(object sender, EventArgs e)
  {
    if (!this._payeeGuid.Equals(Guid.Empty))
      return;
    this.Show();
    this.Refresh();
    FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.All);
    try
    {
      if (formSearchEntity.ShowDialog() == DialogResult.OK)
      {
        this._payeeGuid = formSearchEntity.EntityGuid;
        this.labelEntityName.Text = formSearchEntity.EntityName;
        this.LoadOpenItems();
        this.LoadOfficeLocations();
        this.dsVendorCard1.VendorHistory.Clear();
        this._closeAfterActivate = false;
      }
      else
        this._closeAfterActivate = true;
    }
    finally
    {
      formSearchEntity.Dispose();
    }
  }

  private void formVendorCard_VisibleChanged(object sender, EventArgs e)
  {
    if (!this._closeAfterActivate)
      return;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnPrintHistory_Click(object sender, EventArgs e)
  {
    ReportFactory.Instance.ShowReport(false, typeof (rptVendorHistoryReport), (object) this._payeeGuid, (object) this.dateRangeOptionPicker1.DateRangeFrom, (object) this.dateRangeOptionPicker1.DateRangeTo);
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations");
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.comboOfficeLocation.Value = (object) this._glCompanyId;
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.LoadVendorHistory();
  }
}
