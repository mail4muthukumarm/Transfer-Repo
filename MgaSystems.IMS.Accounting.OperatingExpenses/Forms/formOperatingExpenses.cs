// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formOperatingExpenses
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.OperatingExpenses.UserControls;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Forms.Entities;
using MGASystems.Tools;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

[SecureResource("{A425EB6C-9B4D-46d9-BF1F-D0903E3B2798}", "Operating Expense Access Rights", "Determines whether or not a user is allowed access to the operating expense module.", "Accounting")]
public class formOperatingExpenses : AccountingNoteDocumentSupport
{
  private IContainer components;
  private ExpensesHome expensesHome1;
  private controlExpensePayees expensePayees1;
  internal SqlConnection FormDataConnection;
  internal Panel panelMain;
  internal Panel panelLeft;
  internal MGASimpleComboBox cmbOfficeLocations;
  internal Label lblOfficeLocation;
  internal UltraExplorerBar UltraExplorerBar1;
  internal SqlDataAdapter daGetOfficeLocations;
  internal SqlCommand SqlSelectCommand1;
  private dsOfficeLocations dsOfficeLocations1;
  private NewExpense controlNewExpense;
  private ExpenseCategory controlNewExpenseCategory;
  private CostCenterAssignment controlCostCenterAssignment;
  private ExpenseListing controlExpenseListing;
  private ExpenseAnalysisHome expenseAnalysisHome;
  private OpenExpenses openExpenses;
  private int glCompanyId;

  public formOperatingExpenses()
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetOfficeLocations.Fill((DataTable) this.dsOfficeLocations1.spFin_GetOfficeLocations);
    if (this.dsOfficeLocations1.spFin_GetOfficeLocations.Rows.Count <= 0)
      return;
    this.cmbOfficeLocations.Value = this.dsOfficeLocations1.spFin_GetOfficeLocations[0][0];
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
    if (this.expensesHome1 != null)
    {
      this.expensesHome1.Dispose();
      this.expensesHome1 = (ExpensesHome) null;
    }
    if (this.expensePayees1 != null)
    {
      this.expensePayees1.Dispose();
      this.expensePayees1 = (controlExpensePayees) null;
    }
    if (this.controlNewExpense != null)
    {
      this.controlNewExpense.Dispose();
      this.controlNewExpense = (NewExpense) null;
    }
    if (this.controlNewExpenseCategory != null)
    {
      this.controlNewExpenseCategory.Dispose();
      this.controlNewExpenseCategory = (ExpenseCategory) null;
    }
    if (this.controlCostCenterAssignment != null)
    {
      this.controlCostCenterAssignment.Dispose();
      this.controlCostCenterAssignment = (CostCenterAssignment) null;
    }
    if (this.controlExpenseListing == null)
      return;
    this.controlExpenseListing.Dispose();
    this.controlExpenseListing = (ExpenseListing) null;
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem();
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formOperatingExpenses));
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem();
    Appearance appearance3 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem3 = new UltraExplorerBarItem();
    Appearance appearance4 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem4 = new UltraExplorerBarItem();
    Appearance appearance5 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem5 = new UltraExplorerBarItem();
    Appearance appearance6 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem6 = new UltraExplorerBarItem();
    Appearance appearance7 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem7 = new UltraExplorerBarItem();
    Appearance appearance8 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem8 = new UltraExplorerBarItem();
    Appearance appearance9 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem9 = new UltraExplorerBarItem();
    Appearance appearance10 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem10 = new UltraExplorerBarItem();
    Appearance appearance11 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem11 = new UltraExplorerBarItem();
    Appearance appearance12 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem12 = new UltraExplorerBarItem();
    Appearance appearance13 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem13 = new UltraExplorerBarItem();
    Appearance appearance14 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem14 = new UltraExplorerBarItem();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup4 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem15 = new UltraExplorerBarItem();
    Appearance appearance17 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem16 = new UltraExplorerBarItem();
    Appearance appearance18 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup5 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem17 = new UltraExplorerBarItem();
    Appearance appearance19 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem18 = new UltraExplorerBarItem();
    Appearance appearance20 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem19 = new UltraExplorerBarItem();
    Appearance appearance21 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem20 = new UltraExplorerBarItem();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    this.FormDataConnection = new SqlConnection();
    this.panelMain = new Panel();
    this.panelLeft = new Panel();
    this.cmbOfficeLocations = new MGASimpleComboBox();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.lblOfficeLocation = new Label();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.panelLeft.SuspendLayout();
    ((ISupportInitialize) this.cmbOfficeLocations).BeginInit();
    this.dsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    this.SuspendLayout();
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.panelMain.BackColor = Color.White;
    this.panelMain.Dock = DockStyle.Fill;
    this.panelMain.Location = new Point(272, 0);
    this.panelMain.Name = "panelMain";
    this.panelMain.Size = new Size(760, 758);
    this.panelMain.TabIndex = 6;
    this.panelLeft.BackColor = Color.WhiteSmoke;
    this.panelLeft.Controls.Add((Control) this.cmbOfficeLocations);
    this.panelLeft.Controls.Add((Control) this.lblOfficeLocation);
    this.panelLeft.Controls.Add((Control) this.UltraExplorerBar1);
    this.panelLeft.Dock = DockStyle.Left;
    this.panelLeft.Location = new Point(0, 0);
    this.panelLeft.Name = "panelLeft";
    this.panelLeft.Size = new Size(272, 758);
    this.panelLeft.TabIndex = 5;
    this.cmbOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.cmbOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cmbOfficeLocations).Cursor = Cursors.Default;
    ((UltraGridBase) this.cmbOfficeLocations).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.cmbOfficeLocations).DisplayMember = "Office Location";
    this.cmbOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocations).Location = new Point(16 /*0x10*/, 18);
    this.cmbOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbOfficeLocations).Name = "cmbOfficeLocations";
    ((Control) this.cmbOfficeLocations).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.cmbOfficeLocations).TabIndex = 1;
    ((UltraDropDownBase) this.cmbOfficeLocations).ValueMember = "ID";
    this.cmbOfficeLocations.RowSelected += new RowSelectedEventHandler(this.cmbOfficeLocations_RowSelected);
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.lblOfficeLocation.AutoSize = true;
    this.lblOfficeLocation.BackColor = Color.White;
    this.lblOfficeLocation.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblOfficeLocation.ForeColor = Color.DarkBlue;
    this.lblOfficeLocation.Location = new Point(16 /*0x10*/, 4);
    this.lblOfficeLocation.Name = "lblOfficeLocation";
    this.lblOfficeLocation.Size = new Size(90, 17);
    this.lblOfficeLocation.TabIndex = 2;
    this.lblOfficeLocation.Text = "Office Location";
    this.UltraExplorerBar1.AnimationEnabled = false;
    this.UltraExplorerBar1.AnimationSpeed = (AnimationSpeed) 2;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance1;
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.UltraExplorerBar1.ColumnSpacing = 0;
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
    ultraExplorerBarItem1.Key = "Home";
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).Image = resourceManager.GetObject("appearance2.Image");
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ultraExplorerBarItem1.Text = "Expenses Home";
    explorerBarGroup1.Items.AddRange(new UltraExplorerBarItem[1]
    {
      ultraExplorerBarItem1
    });
    explorerBarGroup1.Settings.HeaderVisible = (DefaultableBoolean) 2;
    ultraExplorerBarItem2.Key = "AddExpense";
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance3).Image = resourceManager.GetObject("appearance3.Image");
    ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ultraExplorerBarItem2.Text = "New Expense";
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance4).Image = resourceManager.GetObject("appearance4.Image");
    ultraExplorerBarItem3.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ultraExplorerBarItem3.Text = "New Expense Report";
    ultraExplorerBarItem3.Visible = false;
    ultraExplorerBarItem4.Key = "EXPENSELISTING";
    ((AppearanceBase) appearance5).Image = resourceManager.GetObject("appearance5.Image");
    ultraExplorerBarItem4.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ultraExplorerBarItem4.Text = "Expenses Listing / History";
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(239, 247, 253);
    ultraExplorerBarItem5.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance6;
    ultraExplorerBarItem5.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem5.Text = "-";
    ultraExplorerBarItem5.Visible = false;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance7).Image = resourceManager.GetObject("appearance7.Image");
    ultraExplorerBarItem6.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance7;
    ultraExplorerBarItem6.Text = "Open Expense Reports";
    ultraExplorerBarItem6.Visible = false;
    ultraExplorerBarItem7.Key = "ScheduledExpense";
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance8).Image = resourceManager.GetObject("appearance8.Image");
    ultraExplorerBarItem7.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance8;
    ultraExplorerBarItem7.Text = "Scheduled Expenses";
    ultraExplorerBarItem7.Visible = false;
    ultraExplorerBarItem8.Key = "PREPAIDEXPENSES";
    ((AppearanceBase) appearance9).Image = resourceManager.GetObject("appearance9.Image");
    ultraExplorerBarItem8.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance9;
    ultraExplorerBarItem8.Text = "Open Pre-Paid Expenses";
    ultraExplorerBarItem8.Visible = false;
    ultraExplorerBarItem9.Key = "EXPENSEDCOMMISSIONS";
    ((AppearanceBase) appearance10).Image = resourceManager.GetObject("appearance10.Image");
    ultraExplorerBarItem9.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ultraExplorerBarItem9.Text = "Expensed Commissions";
    ultraExplorerBarItem9.Visible = false;
    ultraExplorerBarItem10.Key = "UNPAID";
    ((AppearanceBase) appearance11).Image = resourceManager.GetObject("appearance11.Image");
    ultraExplorerBarItem10.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ultraExplorerBarItem10.Text = "Un-Paid Expenses";
    ultraExplorerBarItem11.Key = "VENDORPAY";
    ((AppearanceBase) appearance12).Image = resourceManager.GetObject("appearance12.Image");
    ultraExplorerBarItem11.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ultraExplorerBarItem11.Text = "Vendor Information / Payment Utility";
    explorerBarGroup2.Items.AddRange(new UltraExplorerBarItem[10]
    {
      ultraExplorerBarItem2,
      ultraExplorerBarItem3,
      ultraExplorerBarItem4,
      ultraExplorerBarItem5,
      ultraExplorerBarItem6,
      ultraExplorerBarItem7,
      ultraExplorerBarItem8,
      ultraExplorerBarItem9,
      ultraExplorerBarItem10,
      ultraExplorerBarItem11
    });
    explorerBarGroup2.Settings.NavigationAllowHide = (DefaultableBoolean) 2;
    explorerBarGroup2.Text = "Expenses";
    ultraExplorerBarItem12.Key = "CostCenterAssignments";
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance13).Image = resourceManager.GetObject("appearance13.Image");
    ultraExplorerBarItem12.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ultraExplorerBarItem12.Text = "Cost Center Assignments";
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(239, 247, 253);
    ultraExplorerBarItem13.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ultraExplorerBarItem13.Settings.SeparatorStyle = (SeparatorStyle) 1;
    ultraExplorerBarItem13.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem14.Key = "CostCenterAnalysis";
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance15).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance15).Image = resourceManager.GetObject("appearance15.Image");
    ultraExplorerBarItem14.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ultraExplorerBarItem14.Text = "Cost Center Analysis";
    explorerBarGroup3.Items.AddRange(new UltraExplorerBarItem[3]
    {
      ultraExplorerBarItem12,
      ultraExplorerBarItem13,
      ultraExplorerBarItem14
    });
    ((AppearanceBase) appearance16).Image = (object) 12;
    explorerBarGroup3.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    explorerBarGroup3.Text = "Cost Centers";
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance17).Image = resourceManager.GetObject("appearance17.Image");
    ultraExplorerBarItem15.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ultraExplorerBarItem15.Text = "Expense Analysis";
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance18).Image = resourceManager.GetObject("appearance18.Image");
    ultraExplorerBarItem16.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ultraExplorerBarItem16.Text = "Reports";
    explorerBarGroup4.Items.AddRange(new UltraExplorerBarItem[2]
    {
      ultraExplorerBarItem15,
      ultraExplorerBarItem16
    });
    explorerBarGroup4.Text = "Expense Analysis";
    explorerBarGroup4.Visible = false;
    ultraExplorerBarItem17.Key = "ExpenseCategory";
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance19).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance19).Image = resourceManager.GetObject("appearance19.Image");
    ultraExplorerBarItem17.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ultraExplorerBarItem17.Text = "Expense Category";
    ultraExplorerBarItem18.Key = "Expenses";
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance20).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance20).Image = resourceManager.GetObject("appearance20.Image");
    ultraExplorerBarItem18.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ultraExplorerBarItem18.Text = "Expenses";
    ultraExplorerBarItem19.Key = "ExpensePayees";
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance21).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance21).Image = resourceManager.GetObject("appearance21.Image");
    ultraExplorerBarItem19.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ultraExplorerBarItem19.Text = "Vendors / Expense Payees";
    ultraExplorerBarItem20.Key = "ACCTLINKING";
    ((AppearanceBase) appearance22).Image = resourceManager.GetObject("appearance22.Image");
    ultraExplorerBarItem20.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance22;
    ultraExplorerBarItem20.Text = "Expense GL Account Linking";
    explorerBarGroup5.Items.AddRange(new UltraExplorerBarItem[4]
    {
      ultraExplorerBarItem17,
      ultraExplorerBarItem18,
      ultraExplorerBarItem19,
      ultraExplorerBarItem20
    });
    explorerBarGroup5.Text = "Expense Administration";
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[5]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3,
      explorerBarGroup4,
      explorerBarGroup5
    });
    this.UltraExplorerBar1.GroupSettings.AllowDrag = (DefaultableBoolean) 2;
    ((UltraExplorerBarSettingsBase) this.UltraExplorerBar1.GroupSettings).AllowEdit = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.GroupSettings.AllowItemDrop = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.GroupSettings.AllowItemUncheck = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance23).BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance24).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance24).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance24).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance24).BorderAlpha = (Alpha) 2;
    ((AppearanceBase) appearance24).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance24).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance24).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance24).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance24).ImageAlpha = (Alpha) 1;
    ((AppearanceBase) appearance24).ImageBackground = (Image) resourceManager.GetObject("appearance24.ImageBackground");
    ((AppearanceBase) appearance24).ImageBackgroundAlpha = (Alpha) 1;
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance25;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.GroupSettings.NavigationAllowHide = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.GroupSettings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.GroupSettings.Style = (GroupStyle) 2;
    this.UltraExplorerBar1.GroupSpacing = 16 /*0x10*/;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance26).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance26).BackGradientStyle = (GradientStyle) 3;
    this.UltraExplorerBar1.ItemSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance26;
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 0);
    this.UltraExplorerBar1.Margins.Top = 50;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    this.UltraExplorerBar1.NavigationCurrentGroupAreaHeaderVisible = false;
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(272, 758);
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraExplorerBar1).TabIndex = 0;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.UltraExplorerBar1.ItemClick += new ItemClickEventHandler(this.UltraExplorerBar1_ItemClick);
    this.UltraExplorerBar1.GroupCollapsing += new GroupCollapsingEventHandler(this.UltraExplorerBar1_GroupCollapsing);
    this.daGetOfficeLocations.SelectCommand = this.SqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(1032, 758);
    this.Controls.Add((Control) this.panelMain);
    this.Controls.Add((Control) this.panelLeft);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
    this.MinimumSize = new Size(1040, 650);
    this.Name = nameof (formOperatingExpenses);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Operating Expenses";
    this.panelLeft.ResumeLayout(false);
    ((ISupportInitialize) this.cmbOfficeLocations).EndInit();
    this.dsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    this.ResumeLayout(false);
  }

  private void UltraExplorerBar1_ItemClick(object sender, ItemEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    string upper = e.Item.Key.ToUpper();
    if (upper != null)
    {
      switch (upper.Length)
      {
        case 4:
          if (upper == "HOME")
          {
            if (this.expensesHome1 != null)
            {
              this.expensesHome1.Dispose();
              this.expensesHome1 = (ExpensesHome) null;
            }
            if (this.expensePayees1 != null)
            {
              this.expensePayees1.Dispose();
              this.expensePayees1 = (controlExpensePayees) null;
            }
            if (this.controlCostCenterAssignment != null)
            {
              this.controlCostCenterAssignment.Dispose();
              this.controlCostCenterAssignment = (CostCenterAssignment) null;
            }
            if (this.controlNewExpenseCategory != null)
            {
              this.controlNewExpenseCategory.Dispose();
              this.controlNewExpenseCategory = (ExpenseCategory) null;
            }
            if (this.controlExpenseListing != null)
            {
              this.controlExpenseListing.Dispose();
              this.controlExpenseListing = (ExpenseListing) null;
            }
            this.expensesHome1 = new ExpensesHome(int.Parse(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["ID"].Value.ToString()));
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add((Control) this.expensesHome1);
            break;
          }
          break;
        case 6:
          if (upper == "UNPAID")
          {
            this.openExpenses = new OpenExpenses(int.Parse(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["id"].Value.ToString()));
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add((Control) this.openExpenses);
            break;
          }
          break;
        case 8:
          if (upper == "EXPENSES")
          {
            if (this.expensesHome1 != null)
            {
              this.expensesHome1.Dispose();
              this.expensesHome1 = (ExpensesHome) null;
            }
            if (this.expensePayees1 != null)
            {
              this.expensePayees1.Dispose();
              this.expensePayees1 = (controlExpensePayees) null;
            }
            if (this.controlCostCenterAssignment != null)
            {
              this.controlCostCenterAssignment.Dispose();
              this.controlCostCenterAssignment = (CostCenterAssignment) null;
            }
            if (this.controlNewExpenseCategory != null)
            {
              this.controlNewExpenseCategory.Dispose();
              this.controlNewExpenseCategory = (ExpenseCategory) null;
            }
            if (this.controlExpenseListing != null)
            {
              this.controlExpenseListing.Dispose();
              this.controlExpenseListing = (ExpenseListing) null;
            }
            if (this.controlNewExpense == null)
            {
              this.controlNewExpense = new NewExpense();
              this.panelMain.Controls.Clear();
              this.panelMain.Controls.Add((Control) this.controlNewExpense);
              break;
            }
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add((Control) this.controlNewExpense);
            break;
          }
          break;
        case 9:
          if (upper == "VENDORPAY")
          {
            formVendorCard formVendorCard = new formVendorCard(this.GLCompanyId);
            formVendorCard.MdiParent = MDIControls.Instance.MDIParent;
            formVendorCard.Show();
            break;
          }
          break;
        case 10:
          if (upper == "ADDEXPENSE")
          {
            formNewExpensePO form = (formNewExpensePO) ObjectFactory.Instance.CreateForm(typeof (formNewExpensePO));
            form.MdiParent = MDIControls.Instance.MDIParent;
            form.Show();
            break;
          }
          break;
        case 11:
          if (upper == "ACCTLINKING")
          {
            formExpenseGLLinking expenseGlLinking = new formExpenseGLLinking();
            try
            {
              int num = (int) expenseGlLinking.ShowDialog();
              break;
            }
            finally
            {
              expenseGlLinking.Dispose();
            }
          }
          else
            break;
        case 13:
          if (upper == "EXPENSEPAYEES")
          {
            if (this.expensesHome1 != null)
            {
              this.expensesHome1.Dispose();
              this.expensesHome1 = (ExpensesHome) null;
            }
            if (this.expensePayees1 != null)
            {
              this.expensePayees1.Dispose();
              this.expensePayees1 = (controlExpensePayees) null;
            }
            if (this.controlCostCenterAssignment != null)
            {
              this.controlCostCenterAssignment.Dispose();
              this.controlCostCenterAssignment = (CostCenterAssignment) null;
            }
            if (this.controlNewExpenseCategory != null)
            {
              this.controlNewExpenseCategory.Dispose();
              this.controlNewExpenseCategory = (ExpenseCategory) null;
            }
            if (this.controlExpenseListing != null)
            {
              this.controlExpenseListing.Dispose();
              this.controlExpenseListing = (ExpenseListing) null;
            }
            if (this.expensePayees1 == null)
            {
              this.expensePayees1 = new controlExpensePayees();
              this.panelMain.Controls.Clear();
              this.panelMain.Controls.Add((Control) this.expensePayees1);
              break;
            }
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add((Control) this.expensePayees1);
            this.expensePayees1.Dock = DockStyle.Fill;
            break;
          }
          break;
        case 14:
          if (upper == "EXPENSELISTING")
          {
            if (this.expensesHome1 != null)
            {
              this.expensesHome1.Dispose();
              this.expensesHome1 = (ExpensesHome) null;
            }
            if (this.expensePayees1 != null)
            {
              this.expensePayees1.Dispose();
              this.expensePayees1 = (controlExpensePayees) null;
            }
            if (this.controlCostCenterAssignment != null)
            {
              this.controlCostCenterAssignment.Dispose();
              this.controlCostCenterAssignment = (CostCenterAssignment) null;
            }
            if (this.controlNewExpenseCategory != null)
            {
              this.controlNewExpenseCategory.Dispose();
              this.controlNewExpenseCategory = (ExpenseCategory) null;
            }
            if (this.controlExpenseListing != null)
            {
              this.controlExpenseListing.Dispose();
              this.controlExpenseListing = (ExpenseListing) null;
            }
            this.controlExpenseListing = new ExpenseListing(int.Parse(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["id"].Value.ToString()));
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add((Control) this.controlExpenseListing);
            break;
          }
          break;
        case 15:
          switch (upper[0])
          {
            case 'E':
              if (upper == "EXPENSECATEGORY")
              {
                if (this.expensesHome1 != null)
                {
                  this.expensesHome1.Dispose();
                  this.expensesHome1 = (ExpensesHome) null;
                }
                if (this.expensePayees1 != null)
                {
                  this.expensePayees1.Dispose();
                  this.expensePayees1 = (controlExpensePayees) null;
                }
                if (this.controlCostCenterAssignment != null)
                {
                  this.controlCostCenterAssignment.Dispose();
                  this.controlCostCenterAssignment = (CostCenterAssignment) null;
                }
                if (this.controlNewExpenseCategory != null)
                {
                  this.controlNewExpenseCategory.Dispose();
                  this.controlNewExpenseCategory = (ExpenseCategory) null;
                }
                if (this.controlExpenseListing != null)
                {
                  this.controlExpenseListing.Dispose();
                  this.controlExpenseListing = (ExpenseListing) null;
                }
                this.controlNewExpenseCategory = new ExpenseCategory();
                this.panelMain.Controls.Clear();
                this.panelMain.Controls.Add((Control) this.controlNewExpenseCategory);
                break;
              }
              break;
            case 'P':
              if (upper == "PREPAIDEXPENSES")
              {
                formOperatingTasks formOperatingTasks = new formOperatingTasks();
                formOperatingTasks.MdiParent = MDIControls.Instance.MDIParent;
                formOperatingTasks.Show();
                break;
              }
              break;
          }
          break;
        case 18:
          if (upper == "COSTCENTERANALYSIS")
          {
            if (this.expensesHome1 != null)
            {
              this.expensesHome1.Dispose();
              this.expensesHome1 = (ExpensesHome) null;
            }
            if (this.expensePayees1 != null)
            {
              this.expensePayees1.Dispose();
              this.expensePayees1 = (controlExpensePayees) null;
            }
            if (this.controlCostCenterAssignment != null)
            {
              this.controlCostCenterAssignment.Dispose();
              this.controlCostCenterAssignment = (CostCenterAssignment) null;
            }
            if (this.controlNewExpenseCategory != null)
            {
              this.controlNewExpenseCategory.Dispose();
              this.controlNewExpenseCategory = (ExpenseCategory) null;
            }
            if (this.controlExpenseListing != null)
            {
              this.controlExpenseListing.Dispose();
              this.controlExpenseListing = (ExpenseListing) null;
            }
            this.expenseAnalysisHome = new ExpenseAnalysisHome(int.Parse(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["id"].Value.ToString()));
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add((Control) this.expenseAnalysisHome);
            break;
          }
          break;
        case 19:
          if (upper == "EXPENSEDCOMMISSIONS")
          {
            if (this.expensesHome1 != null)
            {
              this.expensesHome1.Dispose();
              this.expensesHome1 = (ExpensesHome) null;
            }
            if (this.expensePayees1 != null)
            {
              this.expensePayees1.Dispose();
              this.expensePayees1 = (controlExpensePayees) null;
            }
            if (this.controlCostCenterAssignment != null)
            {
              this.controlCostCenterAssignment.Dispose();
              this.controlCostCenterAssignment = (CostCenterAssignment) null;
            }
            if (this.controlNewExpenseCategory != null)
            {
              this.controlNewExpenseCategory.Dispose();
              this.controlNewExpenseCategory = (ExpenseCategory) null;
            }
            if (this.controlExpenseListing != null)
            {
              this.controlExpenseListing.Dispose();
              this.controlExpenseListing = (ExpenseListing) null;
            }
            this.Cursor = Cursors.WaitCursor;
            break;
          }
          break;
        case 21:
          if (upper == "COSTCENTERASSIGNMENTS")
          {
            frmEntityGroups frmEntityGroups = new frmEntityGroups();
            frmEntityGroups.MdiParent = MDIControls.Instance.MDIParent;
            frmEntityGroups.Show();
            break;
          }
          break;
      }
    }
    this.Cursor = Cursors.Default;
  }

  public int GLCompanyId => this.glCompanyId;

  private void cmbOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow == null)
      return;
    this.glCompanyId = int.Parse(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["ID"].Value.ToString());
    this.expensesHome1 = new ExpensesHome(this.glCompanyId);
    this.panelMain.Controls.Clear();
    this.panelMain.Controls.Add((Control) this.expensesHome1);
  }

  private void UltraExplorerBar1_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }
}
