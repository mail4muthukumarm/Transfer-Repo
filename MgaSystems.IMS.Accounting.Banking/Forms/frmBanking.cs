// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmBanking
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{E7CE118D-D5DD-4e32-BB79-A486589A92AE}", "Bank Management Rights", "Grants users access to the bank management screens.", "Accounting")]
[DocumentFolderFilter("Accounting-Banking")]
public class frmBanking : Form, IRecreatableEntity, ISupportDocumentSystem, ISupportNoteSystem
{
  private IContainer components;
  private BankManagementHome _bankManagementHome;
  private BankReconciliation _reconcile;
  private IssueCheck _issueCheck;
  private AcctCheckRegister _checkRegister;
  private BankAccountTransfer _BankAccountTransfer;
  internal BankAccountRegister _BankAccountRegister;
  private int _bankGlAccount;

  public frmBanking()
  {
    this.Load += new EventHandler(this.frmBanking_Load);
    this._bankGlAccount = 0;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public virtual UltraExplorerBar UltraExplorerBar1
  {
    get => this._UltraExplorerBar1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemClickEventHandler clickEventHandler = new ItemClickEventHandler(this.UltraExplorerBar1_ItemClick);
      GroupCollapsingEventHandler collapsingEventHandler = new GroupCollapsingEventHandler(this.UltraExplorerBar1_GroupCollapsing);
      UltraExplorerBar ultraExplorerBar1_1 = this._UltraExplorerBar1;
      if (ultraExplorerBar1_1 != null)
      {
        ultraExplorerBar1_1.ItemClick -= clickEventHandler;
        ultraExplorerBar1_1.GroupCollapsing -= collapsingEventHandler;
      }
      this._UltraExplorerBar1 = value;
      UltraExplorerBar ultraExplorerBar1_2 = this._UltraExplorerBar1;
      if (ultraExplorerBar1_2 == null)
        return;
      ultraExplorerBar1_2.ItemClick += clickEventHandler;
      ultraExplorerBar1_2.GroupCollapsing += collapsingEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelMain")]
  internal virtual Panel panelMain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsOfficeLocations1")]
  internal virtual dsOfficeLocations DsOfficeLocations1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOfficeLocations")]
  internal virtual SqlDataAdapter daGetOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cmbOfficeLocations
  {
    get => this._cmbOfficeLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.cmbOfficeLocations_RowSelected);
      MGASimpleComboBox cmbOfficeLocations1 = this._cmbOfficeLocations;
      if (cmbOfficeLocations1 != null)
        cmbOfficeLocations1.RowSelected -= selectedEventHandler;
      this._cmbOfficeLocations = value;
      MGASimpleComboBox cmbOfficeLocations2 = this._cmbOfficeLocations;
      if (cmbOfficeLocations2 == null)
        return;
      cmbOfficeLocations2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblOfficeLocation")]
  internal virtual Label lblOfficeLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBanking));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem();
    Appearance appearance5 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem3 = new UltraExplorerBarItem();
    Appearance appearance6 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem4 = new UltraExplorerBarItem();
    Appearance appearance7 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem5 = new UltraExplorerBarItem();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem6 = new UltraExplorerBarItem();
    Appearance appearance11 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem7 = new UltraExplorerBarItem();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup4 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem8 = new UltraExplorerBarItem();
    Appearance appearance14 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem9 = new UltraExplorerBarItem();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup5 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem10 = new UltraExplorerBarItem();
    Appearance appearance17 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem11 = new UltraExplorerBarItem();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup6 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem12 = new UltraExplorerBarItem();
    Appearance appearance20 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem13 = new UltraExplorerBarItem();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup7 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem14 = new UltraExplorerBarItem();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    this.Panel1 = new Panel();
    this.cmbOfficeLocations = new MGASimpleComboBox();
    this.DsOfficeLocations1 = new dsOfficeLocations();
    this.lblOfficeLocation = new Label();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.panelMain = new Panel();
    this.FormDataConnection = new SqlConnection();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ImageList1 = new ImageList(this.components);
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.cmbOfficeLocations).BeginInit();
    this.DsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    this.SuspendLayout();
    this.Panel1.Controls.Add((Control) this.cmbOfficeLocations);
    this.Panel1.Controls.Add((Control) this.lblOfficeLocation);
    this.Panel1.Controls.Add((Control) this.UltraExplorerBar1);
    this.Panel1.Dock = DockStyle.Left;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(307, 728);
    this.Panel1.TabIndex = 0;
    this.cmbOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraControlBase) this.cmbOfficeLocations).Cursor = Cursors.Default;
    ((UltraGridBase) this.cmbOfficeLocations).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) this.DsOfficeLocations1;
    ((UltraDropDownBase) this.cmbOfficeLocations).DisplayMember = "Office Location";
    this.cmbOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocations).Location = new Point(16 /*0x10*/, 24);
    this.cmbOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbOfficeLocations).Name = "cmbOfficeLocations";
    ((Control) this.cmbOfficeLocations).Size = new Size(276, 21);
    ((Control) this.cmbOfficeLocations).TabIndex = 3;
    ((UltraControlBase) this.cmbOfficeLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbOfficeLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbOfficeLocations).ValueMember = "ID";
    this.DsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.DsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.lblOfficeLocation.AutoSize = true;
    this.lblOfficeLocation.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    this.lblOfficeLocation.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblOfficeLocation.Location = new Point(16 /*0x10*/, 8);
    this.lblOfficeLocation.Name = "lblOfficeLocation";
    this.lblOfficeLocation.Size = new Size(90, 13);
    this.lblOfficeLocation.TabIndex = 4;
    this.lblOfficeLocation.Text = "Office Location";
    appearance1.BackColor = Color.FromArgb(230, 236, (int) byte.MaxValue);
    appearance1.FontData.BoldAsString = "False";
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance1;
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
    ((Control) this.UltraExplorerBar1).Font = new Font("Tahoma", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ultraExplorerBarItem1.Key = "Home";
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ultraExplorerBarItem1.Text = "Bank Management Home";
    explorerBarGroup1.Items.AddRange(new UltraExplorerBarItem[1]
    {
      ultraExplorerBarItem1
    });
    appearance3.BackColor = Color.Orange;
    explorerBarGroup1.ItemSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance3;
    explorerBarGroup1.Key = "Accounts";
    appearance4.BackColor = Color.Orange;
    explorerBarGroup1.Settings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance4;
    explorerBarGroup1.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup1.Text = "Banking Management Home";
    explorerBarGroup1.Visible = false;
    ultraExplorerBarItem2.Key = "NewDeposit";
    appearance5.BackColor = Color.FromArgb(239, 247, 253);
    appearance5.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance5.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance5.Image"));
    ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ultraExplorerBarItem2.Text = "Create Deposit Ticket";
    ultraExplorerBarItem3.Key = "CashReceipt";
    appearance6.BackColor = Color.FromArgb(239, 247, 253);
    appearance6.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    ultraExplorerBarItem3.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance6;
    ultraExplorerBarItem3.Text = "New Cash Receipt";
    appearance7.BackColor = Color.FromArgb(239, 247, 253);
    appearance7.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance7.ForeColor = Color.LightSteelBlue;
    ultraExplorerBarItem4.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance7;
    ultraExplorerBarItem4.Settings.SeparatorStyle = (SeparatorStyle) 1;
    ultraExplorerBarItem4.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem4.Text = "New Item";
    ultraExplorerBarItem5.Key = "ViewDepositDetail";
    appearance8.BackColor = Color.FromArgb(239, 247, 253);
    appearance8.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance8.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image"));
    ultraExplorerBarItem5.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance8;
    ultraExplorerBarItem5.Text = "View Deposit Detail";
    explorerBarGroup2.Items.AddRange(new UltraExplorerBarItem[4]
    {
      ultraExplorerBarItem2,
      ultraExplorerBarItem3,
      ultraExplorerBarItem4,
      ultraExplorerBarItem5
    });
    appearance9.BackColor = Color.Orange;
    appearance9.FontData.BoldAsString = "True";
    explorerBarGroup2.ItemSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance9;
    explorerBarGroup2.Key = "AccountOptions";
    appearance10.BackColor = Color.Orange;
    appearance10.FontData.BoldAsString = "True";
    explorerBarGroup2.Settings.AppearancesSmall.SelectedAppearance = (AppearanceBase) appearance10;
    explorerBarGroup2.Text = "Bank Account Options";
    explorerBarGroup2.Visible = false;
    ultraExplorerBarItem6.Key = "Reconcile";
    appearance11.BackColor = Color.FromArgb(239, 247, 253);
    appearance11.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image"));
    ultraExplorerBarItem6.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ultraExplorerBarItem6.Text = "Reconcile Transaction";
    ultraExplorerBarItem7.Key = "ReconcileMultiple";
    appearance12.BackColor = Color.FromArgb(239, 247, 253);
    appearance12.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance12.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance12.Image"));
    ultraExplorerBarItem7.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ultraExplorerBarItem7.Text = "Reconcile Mutiple Transactions";
    ultraExplorerBarItem7.Visible = false;
    explorerBarGroup3.Items.AddRange(new UltraExplorerBarItem[2]
    {
      ultraExplorerBarItem6,
      ultraExplorerBarItem7
    });
    appearance13.FontData.BoldAsString = "True";
    explorerBarGroup3.ItemSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance13;
    explorerBarGroup3.Key = "ReconOptions";
    explorerBarGroup3.Text = "Reconciliation Options";
    explorerBarGroup3.Visible = false;
    ultraExplorerBarItem8.Key = "BankFees";
    appearance14.BackColor = Color.FromArgb(239, 247, 253);
    appearance14.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance14.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance14.Image"));
    ultraExplorerBarItem8.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ultraExplorerBarItem8.Text = "Bank Fees Entry";
    ultraExplorerBarItem9.Key = "BankInterest";
    appearance15.BackColor = Color.FromArgb(239, 247, 253);
    appearance15.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance15.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance15.Image"));
    ultraExplorerBarItem9.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ultraExplorerBarItem9.Text = "Bank Interest Income Entry";
    explorerBarGroup4.Items.AddRange(new UltraExplorerBarItem[2]
    {
      ultraExplorerBarItem8,
      ultraExplorerBarItem9
    });
    appearance16.FontData.BoldAsString = "True";
    explorerBarGroup4.ItemSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance16;
    explorerBarGroup4.Key = "BankOptions";
    explorerBarGroup4.Text = "Bank Transactions";
    explorerBarGroup4.Visible = false;
    ultraExplorerBarItem10.Key = "PrintChecks";
    appearance17.BackColor = Color.FromArgb(239, 247, 253);
    appearance17.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance17.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance17.Image"));
    ultraExplorerBarItem10.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ultraExplorerBarItem10.Text = "Print Checks";
    ultraExplorerBarItem11.Key = "CreateCheck";
    appearance18.BackColor = Color.FromArgb(239, 247, 253);
    appearance18.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance18.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image"));
    ultraExplorerBarItem11.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ultraExplorerBarItem11.Text = "Create Check";
    explorerBarGroup5.Items.AddRange(new UltraExplorerBarItem[2]
    {
      ultraExplorerBarItem10,
      ultraExplorerBarItem11
    });
    appearance19.FontData.BoldAsString = "True";
    explorerBarGroup5.ItemSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance19;
    explorerBarGroup5.Key = "CheckOptions";
    explorerBarGroup5.Text = "Check Options";
    explorerBarGroup5.Visible = false;
    ultraExplorerBarItem12.Key = "BankTransfer";
    appearance20.BackColor = Color.FromArgb(239, 247, 253);
    appearance20.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance20.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance20.Image"));
    ultraExplorerBarItem12.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ultraExplorerBarItem12.Text = "Bank Transfer";
    ultraExplorerBarItem13.Key = "SWEEPWIZARD";
    appearance21.BackColor = Color.FromArgb(239, 247, 253);
    appearance21.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance21.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance21.Image"));
    ultraExplorerBarItem13.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ultraExplorerBarItem13.Text = "Sweep Automation Wizard";
    ultraExplorerBarItem13.Visible = false;
    explorerBarGroup6.Items.AddRange(new UltraExplorerBarItem[2]
    {
      ultraExplorerBarItem12,
      ultraExplorerBarItem13
    });
    appearance22.FontData.BoldAsString = "True";
    explorerBarGroup6.ItemSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance22;
    explorerBarGroup6.Key = "TransferOptions";
    explorerBarGroup6.Text = "Bank Transfers";
    ultraExplorerBarItem14.Key = "Search";
    appearance23.BackColor = Color.FromArgb(239, 247, 253);
    appearance23.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance23.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance23.Image"));
    ultraExplorerBarItem14.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ultraExplorerBarItem14.Text = "Search";
    explorerBarGroup7.Items.AddRange(new UltraExplorerBarItem[1]
    {
      ultraExplorerBarItem14
    });
    appearance24.FontData.BoldAsString = "True";
    explorerBarGroup7.ItemSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance24;
    explorerBarGroup7.Key = "SearchOptions";
    explorerBarGroup7.Text = "Search";
    explorerBarGroup7.Visible = false;
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[7]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3,
      explorerBarGroup4,
      explorerBarGroup5,
      explorerBarGroup6,
      explorerBarGroup7
    });
    this.UltraExplorerBar1.GroupSettings.AllowDrag = (DefaultableBoolean) 2;
    ((UltraExplorerBarSettingsBase) this.UltraExplorerBar1.GroupSettings).AllowEdit = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.GroupSettings.AllowItemDrop = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.GroupSettings.AllowItemUncheck = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.FromArgb(239, 247, 253);
    appearance25.BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance25;
    appearance26.BackColor = Color.FromArgb(239, 247, 253);
    appearance26.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = SystemColors.MenuText;
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance26;
    appearance27.AlphaLevel = (short) 32 /*0x20*/;
    appearance27.BackColor = Color.LightSteelBlue;
    appearance27.BackColor2 = Color.LightSteelBlue;
    appearance27.BackColorAlpha = (Alpha) 2;
    appearance27.BorderAlpha = (Alpha) 2;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.FontData.BoldAsString = "True";
    appearance27.FontData.Name = "Tahoma";
    appearance27.FontData.SizeInPoints = 8.5f;
    appearance27.ForeColor = Color.Black;
    appearance27.ForegroundAlpha = (Alpha) 2;
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance27;
    appearance28.BackColor = Color.FromArgb(239, 247, 253);
    appearance28.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance28;
    appearance29.BackColor = Color.Orange;
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.SelectedAppearance = (AppearanceBase) appearance29;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    ((UltraExplorerBarSettingsBase) this.UltraExplorerBar1.GroupSettings).HotTracking = (DefaultableBoolean) 1;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.UltraExplorerBar1.GroupSettings.NavigationAllowHide = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.GroupSpacing = 3;
    appearance30.BackColor = Color.Orange;
    appearance30.FontData.BoldAsString = "True";
    this.UltraExplorerBar1.ItemSettings.AppearancesSmall.ActiveAppearance = (AppearanceBase) appearance30;
    appearance31.ForeColor = SystemColors.MenuText;
    this.UltraExplorerBar1.ItemSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance31;
    appearance32.BackColor = Color.LightSteelBlue;
    this.UltraExplorerBar1.ItemSettings.AppearancesSmall.HotTrackAppearance = (AppearanceBase) appearance32;
    this.UltraExplorerBar1.ItemSettings.HotTrackStyle = (ItemHotTrackStyle) 2;
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 0);
    this.UltraExplorerBar1.Margins.Top = 50;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    this.UltraExplorerBar1.NavigationCurrentGroupAreaHeaderVisible = false;
    this.UltraExplorerBar1.ShowDefaultContextMenu = false;
    ((Control) this.UltraExplorerBar1).Size = new Size(307, 728);
    ((Control) this.UltraExplorerBar1).TabIndex = 0;
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 3;
    this.panelMain.BackColor = Color.White;
    this.panelMain.Dock = DockStyle.Fill;
    this.panelMain.Location = new Point(307, 0);
    this.panelMain.Margin = new Padding(0);
    this.panelMain.Name = "panelMain";
    this.panelMain.Size = new Size(687, 728);
    this.panelMain.TabIndex = 1;
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
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
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(994, 728);
    this.Controls.Add((Control) this.panelMain);
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmBanking);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank Management";
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.cmbOfficeLocations).EndInit();
    this.DsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    this.ResumeLayout(false);
  }

  protected int BankGLAccountId => this._bankGlAccount;

  protected string BankName => this._BankAccountRegister.BankName;

  protected BankAccountRegister CurrentBankAccountRegister => this._BankAccountRegister;

  private void frmBanking_Load(object sender, EventArgs e)
  {
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    if (((UltraGridBase) this.cmbOfficeLocations).Rows.Count == 0)
      return;
    this.cmbOfficeLocations.Value = (object) Conversions.ToInteger(((UltraGridBase) this.cmbOfficeLocations).Rows[0].Cells["ID"].Value);
  }

  protected virtual void UltraExplorerBar1_ItemClick(object sender, ItemEventArgs e)
  {
    string key = e.Item.Key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
    {
      case 108490041:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NewDeposit", false) == 0)
        {
          if (this._BankAccountRegister == null)
            return;
          this._BankAccountRegister.NewDeposit();
          return;
        }
        break;
      case 355989241:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "PrintChecks", false) == 0)
        {
          if (this._BankAccountRegister == null)
            return;
          this._BankAccountRegister.PrintChecks();
          return;
        }
        break;
      case 1391791790:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Home", false) == 0)
          return;
        break;
      case 1800720343:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Reconcile", false) == 0)
        {
          if (this._BankAccountRegister == null)
            return;
          Form[] all = Array.FindAll<Form>(this.MdiParent.MdiChildren, new Predicate<Form>(this.IsReconcilliationForm));
          if (all.Length == 1)
          {
            formBankReconciliation bankReconciliation = (formBankReconciliation) all[0];
            if (this._BankAccountRegister.BankGLAccountId != bankReconciliation._bankGlAccountId)
              return;
            bankReconciliation.WindowState = FormWindowState.Normal;
            bankReconciliation.BringToFront();
            return;
          }
          using (formBankRecInputs formBankRecInputs = new formBankRecInputs(this._BankAccountRegister._bankaccountgl))
          {
            if (formBankRecInputs.ShowDialog() != DialogResult.OK)
              return;
            formBankReconciliation form = (formBankReconciliation) ObjectFactory.Instance.CreateForm(typeof (formBankReconciliation), new object[5]
            {
              (object) this._BankAccountRegister._bankaccountgl,
              (object) this._BankAccountRegister.lblBankName.Text,
              (object) formBankRecInputs.PeriodDate,
              (object) formBankRecInputs.StartingBalance,
              (object) formBankRecInputs.EndingBalance
            });
            form.MdiParent = this.MdiParent;
            form.Show();
            return;
          }
        }
        break;
      case 2154241103:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "CreateCheck", false) == 0)
        {
          if (this._BankAccountRegister == null)
            return;
          this._BankAccountRegister.IssueCheck();
          return;
        }
        break;
      case 2419255602:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "BankFees", false) == 0)
        {
          if (this._BankAccountRegister == null)
            return;
          this._BankAccountRegister.BankFeesEntry();
          return;
        }
        break;
      case 2676189306:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "CashReceipt", false) == 0)
        {
          if (this._BankAccountRegister == null)
            return;
          this._BankAccountRegister.NewCashReceipt();
          return;
        }
        break;
      case 2799982380:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "BankTransfer", false) == 0)
        {
          if (!SecurityManager.Instance.AssertPermission("{1A2183F1-8CEF-47b4-97D0-573AF021AD16}"))
          {
            MGASystems.IMS.Accounting.Banking.Utility.DenyAccess();
            return;
          }
          Form form = !MGASystems.Common.SystemSettings.GetBoolSetting("BANKTRANSFER_ALLOWMULTIOFFICE") ? ObjectFactory.Instance.CreateForm(typeof (frmBankTransfer)) : ObjectFactory.Instance.CreateForm(typeof (FormAdvancedBankTransfer));
          try
          {
            if (form.ShowDialog() != DialogResult.OK || this._BankAccountRegister == null)
              return;
            this._BankAccountRegister.ReloadRegister();
            return;
          }
          finally
          {
            form.Dispose();
          }
        }
        else
          break;
      case 3314270937:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "BankInterest", false) == 0)
        {
          if (this._BankAccountRegister == null)
            return;
          this._BankAccountRegister.BankInterestEntry();
          return;
        }
        break;
      case 3326517961:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Search", false) == 0)
        {
          if (this._BankAccountRegister == null)
            return;
          frmSearchDeposit frmSearchDeposit = new frmSearchDeposit(this._BankAccountRegister._bankaccountgl);
          try
          {
            int num = (int) frmSearchDeposit.ShowDialog((IWin32Window) this);
            return;
          }
          finally
          {
            frmSearchDeposit.Dispose();
          }
        }
        else
          break;
      case 3852639300:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "SWEEPWIZARD", false) == 0)
        {
          if (!SecurityManager.Instance.AssertPermission("{D269A4DA-B77B-4021-9AE6-43FAC3C2C5BE}"))
          {
            MGASystems.IMS.Accounting.Banking.Utility.DenyAccess();
            return;
          }
          formSweepAutomationWizard automationWizard = new formSweepAutomationWizard();
          try
          {
            if (automationWizard.ShowDialog() != DialogResult.OK || this._BankAccountRegister == null)
              return;
            this._BankAccountRegister.ReloadRegister();
            return;
          }
          finally
          {
            automationWizard.Dispose();
          }
        }
        else
          break;
      case 4008688239:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ViewDepositDetail", false) == 0)
        {
          if (!SecurityManager.Instance.AssertPermission("{F0B7BA7B-AB2D-4ac8-A7AE-DC57991D3E3B}"))
          {
            MGASystems.IMS.Accounting.Banking.Utility.DenyAccess();
            return;
          }
          if (this._BankAccountRegister == null)
            return;
          this._BankAccountRegister.ViewDeposit();
          return;
        }
        break;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Item.Key.Substring(0, 4), "BANK", false) != 0)
      return;
    this.LoadBankAccountRegister(Conversions.ToInteger(e.Item.Key.Substring(4, Microsoft.VisualBasic.Strings.Len(e.Item.Key) - 4)));
    this.SetGroupVisible(true);
  }

  protected void LoadBankAccountRegister(int bankGLId)
  {
    if (this._BankAccountRegister != null)
    {
      this._BankAccountRegister.Dispose();
      this._BankAccountRegister = (BankAccountRegister) null;
    }
    this._BankAccountRegister = this.InitBankRegisterControl(bankGLId, Conversions.ToInteger(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["id"].Value));
    this.panelMain.Controls.Clear();
    this.panelMain.Controls.Add((Control) this._BankAccountRegister);
    this._BankAccountRegister.Initialize();
  }

  private void SetGroupVisible(bool Value)
  {
    this.UltraExplorerBar1.Groups["AccountOptions"].Visible = Value;
    this.UltraExplorerBar1.Groups["ReconOptions"].Visible = Value;
    this.UltraExplorerBar1.Groups["BankOptions"].Visible = Value;
    this.UltraExplorerBar1.Groups["CheckOptions"].Visible = Value;
    this.UltraExplorerBar1.Groups["SearchOptions"].Visible = Value;
  }

  private void cmbOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow == null)
      return;
    this._bankGlAccount = Conversions.ToInteger(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["id"].Value);
    BankAccountsExplorerGroup accountsExplorerGroup = (BankAccountsExplorerGroup) ObjectFactory.Instance.CreateObject(typeof (BankAccountsExplorerGroup), new object[2]
    {
      (object) this._bankGlAccount,
      null
    });
    accountsExplorerGroup.ItemSettings.AppearancesSmall.ActiveAppearance.BackColor = Color.Orange;
    accountsExplorerGroup.ItemSettings.AppearancesSmall.ActiveAppearance.FontData.Bold = (DefaultableBoolean) 1;
    this.RemoveAccountsGroup();
    this.UltraExplorerBar1.Groups.Insert(1, (UltraExplorerBarGroup) accountsExplorerGroup);
    if (this._BankAccountRegister != null)
    {
      this._BankAccountRegister.Dispose();
      this._BankAccountRegister = (BankAccountRegister) null;
    }
    this._BankAccountRegister = this.InitBankRegisterControl(Conversions.ToInteger(accountsExplorerGroup.Items[0].Key.Substring(4, Microsoft.VisualBasic.Strings.Len(accountsExplorerGroup.Items[0].Key) - 4)), Conversions.ToInteger(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["id"].Value));
    this.panelMain.Controls.Clear();
    this.panelMain.Controls.Add((Control) this._BankAccountRegister);
    this._BankAccountRegister.Initialize();
    this.SetGroupVisible(true);
  }

  private BankAccountRegister InitBankRegisterControl(int BankAccountId, int glCompanyId)
  {
    return ObjectFactory.Instance.CreateObjectAs<BankAccountRegister>((object) BankAccountId, (object) glCompanyId);
  }

  private void RemoveAccountsGroup()
  {
    foreach (UltraExplorerBarGroup group in this.UltraExplorerBar1.Groups)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(group.Text, "Accounts", false) == 0)
      {
        this.UltraExplorerBar1.Groups.RemoveAt(group.Index);
        break;
      }
    }
  }

  private void UltraExplorerBar1_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private bool IsReconcilliationForm(Form f) => f is formBankReconciliation;

  public bool AllowAddNewDocument => true;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler DocumentChanged1;

  public bool CanCreateNewNote => true;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler NoteChanged;

  public bool CanReCreateEntity => false;

  public Guid ControlGUID => Guid.Empty;

  public Guid EntityGuid => new Guid("{F21DF59D-87D7-479e-8F59-6E9B4D776EE4}");

  public string EntityName => "Accounting";

  public string FriendlyEntityName => "Accounting";

  public bool HasControlGUID => false;

  public bool RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  public string RecreateTypeName => this.GetType().ToString();
}
