// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormAccountClassifications
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Analysis.Properties;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

public class FormAccountClassifications : Form
{
  private IContainer components;
  private UltraGrid gridMasterAccounts;
  private dsMasterAccountClassifications dsMasterAccountClassifications1;

  public FormAccountClassifications()
  {
    this.InitializeComponent();
    this.LoadAccountClassfications();
    this.FormatAccountClassificationsGrid();
  }

  private void LoadAccountClassfications()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsMasterAccountClassifications1, new string[1]
    {
      "AccountClassifications"
    }, "spFin_GetMasterAccountClassifications");
  }

  private void FormatAccountClassificationsGrid()
  {
    if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.ChartOfAccountExists()"))
      return;
    UltraGridBand band = ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Bands[0];
    band.Columns["ClassLLimit"].CellActivation = (Activation) 2;
    band.Columns["ClassULimit"].CellActivation = (Activation) 2;
  }

  private void gridMasterAccounts_AfterRowUpdate(object sender, RowEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_UpdateMasterAccountClassification", new object[8]
    {
      (object) "@AccountClass",
      (object) e.Row.Cells["AccountClass"].Value.ToString(),
      (object) "@ClassLLimit",
      (object) int.Parse(e.Row.Cells["ClassLLimit"].Value.ToString()),
      (object) "@ClassULimit",
      (object) int.Parse(e.Row.Cells["ClassULimit"].Value.ToString()),
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  private void FormAccountClassifications_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this.VerifyLimits())
      return;
    int num = (int) MessageBox.Show(Resources.MSG_ACCOUNTCLASSIFICATIONWARNING, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    e.Cancel = true;
  }

  private bool VerifyLimits() => true;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("AccountClassifications", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("AccountClass");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ClassLLimit");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ClassULimit");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("Layout1");
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("AcctTypeDescription");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion1 = new ColScrollRegion(497);
    ColScrollRegion colScrollRegion2 = new ColScrollRegion(676);
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("Layout2");
    Appearance appearance26 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("AcctTypeDescription");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion3 = new ColScrollRegion(497);
    ColScrollRegion colScrollRegion4 = new ColScrollRegion(676);
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    this.gridMasterAccounts = new UltraGrid();
    this.dsMasterAccountClassifications1 = new dsMasterAccountClassifications();
    ((ISupportInitialize) this.gridMasterAccounts).BeginInit();
    this.dsMasterAccountClassifications1.BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.gridMasterAccounts).DataMember = "AccountClassifications";
    ((UltraGridBase) this.gridMasterAccounts).DataSource = (object) this.dsMasterAccountClassifications1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Account Class";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Style = (ColumnStyle) 6;
    ultraGridColumn1.Width = 201;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Class Lower Limit";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 149;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Class Upper Limit";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 147;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand1.Header).Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 192 /*0xC0*/;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.Transparent;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance15).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridMasterAccounts).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance17).BackColor = Color.White;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance17;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 152;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 2;
    ultraGridColumn5.Width = 128 /*0x80*/;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 3;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 128 /*0x80*/;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 4;
    ultraGridColumn7.Width = 48 /*0x30*/;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 5;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 189;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 6;
    ultraGridColumn9.Style = (ColumnStyle) 6;
    ultraGridColumn9.Width = 132;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 7;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 96 /*0x60*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 8;
    ultraGridColumn11.Style = (ColumnStyle) 6;
    ultraGridColumn11.Width = 144 /*0x90*/;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 9;
    ultraGridColumn12.Width = 45;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn13.Header).Caption = "";
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Style = (ColumnStyle) 3;
    ultraGridColumn13.Width = 32 /*0x20*/;
    ultraGridBand2.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout1.ColScrollRegions.Add((object) colScrollRegion1);
    ultraGridLayout1.ColScrollRegions.Add((object) colScrollRegion2);
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "Layout1";
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ultraGridLayout1.Override.AllowAddNew = (AllowAddNew) 4;
    ultraGridLayout1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance20).TextHAlignAsString = "Left";
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance20;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance22;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance23).BackColor = Color.Transparent;
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance24).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance25;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((AppearanceBase) appearance26).BackColor = Color.White;
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance26;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 1;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 152;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 2;
    ultraGridColumn15.Width = 124;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 3;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 128 /*0x80*/;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 4;
    ultraGridColumn17.Width = 49;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 5;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 189;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 6;
    ultraGridColumn19.Style = (ColumnStyle) 6;
    ultraGridColumn19.Width = 124;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 7;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 96 /*0x60*/;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 8;
    ultraGridColumn21.Style = (ColumnStyle) 6;
    ultraGridColumn21.Width = 136;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 9;
    ultraGridColumn22.Width = 43;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn23.Header).Caption = "";
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 0;
    ultraGridColumn23.Style = (ColumnStyle) 3;
    ultraGridColumn23.Width = 21;
    ultraGridBand3.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout2.ColScrollRegions.Add((object) colScrollRegion3);
    ultraGridLayout2.ColScrollRegions.Add((object) colScrollRegion4);
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "Layout2";
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance27;
    ultraGridLayout2.Override.AllowAddNew = (AllowAddNew) 4;
    ultraGridLayout2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout2.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance28).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance30).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance31;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance32).BackColor = Color.Transparent;
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance33).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance34;
    ultraGridLayout2.ScrollBarLook = scrollBarLook3;
    ((UltraGridBase) this.gridMasterAccounts).Layouts.Add(ultraGridLayout1);
    ((UltraGridBase) this.gridMasterAccounts).Layouts.Add(ultraGridLayout2);
    ((Control) this.gridMasterAccounts).Location = new Point(0, 0);
    ((Control) this.gridMasterAccounts).Name = "gridMasterAccounts";
    ((Control) this.gridMasterAccounts).Size = new Size(499, 214);
    ((Control) this.gridMasterAccounts).TabIndex = 1;
    this.gridMasterAccounts.UpdateMode = (UpdateMode) 1;
    ((UltraControlBase) this.gridMasterAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridMasterAccounts).UseOsThemes = (DefaultableBoolean) 2;
    this.gridMasterAccounts.AfterRowUpdate += new RowEventHandler(this.gridMasterAccounts_AfterRowUpdate);
    this.dsMasterAccountClassifications1.DataSetName = "dsMasterAccountClassifications";
    this.dsMasterAccountClassifications1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(499, 214);
    this.Controls.Add((Control) this.gridMasterAccounts);
    this.Name = nameof (FormAccountClassifications);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Master Account Classification Management";
    this.FormClosing += new FormClosingEventHandler(this.FormAccountClassifications_FormClosing);
    ((ISupportInitialize) this.gridMasterAccounts).EndInit();
    this.dsMasterAccountClassifications1.EndInit();
    this.ResumeLayout(false);
  }
}
