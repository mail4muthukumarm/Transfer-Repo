// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries.frmIntermediaries
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;

[SecureResource("{167C34C4-5E8F-4ce2-860B-76B8AAC20435}", "Access Intermediaries Screen", "Controls access to the Intermediaries screen.", "Companies")]
public class frmIntermediaries : Form, ISupportDocumentSystem
{
  private IContainer components;
  private MGATextBox txtIntermediary;
  private Label Label17;
  private dsIntermediaries ds;
  private SqlDataAdapter da;
  private SqlConnection cnSQL;
  private ErrorProvider err;
  private MGAListBox lstContacts;
  private UltraTabControl UltraTabControl1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private Label Label8;
  private Label lblPhone;
  private MGATextBox txtWebSite;
  private Label Label3;
  private MGATextBox txtEmail;
  private Label Label15;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private bool _newIntermediary;
  private Guid _intermediaryGuid;
  private string _intermediaryName;
  public const string CanOpenIntermediariesForm = "{167C34C4-5E8F-4ce2-860B-76B8AAC20435}";

  public frmIntermediaries()
  {
    this.Load += new EventHandler(this.frmIntermediaries_Load);
    this._newIntermediary = false;
    this._intermediaryGuid = Guid.Empty;
    this._intermediaryName = "";
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ctlIntermediaryZip")]
  private virtual AddressResolver_MULTI ctlIntermediaryZip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingCancel);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler3;
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingDelete -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler3;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingDelete += cancelEventHandler4;
    }
  }

  private virtual UltraGrid dg
  {
    get => this._dg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dg_AfterRowActivate);
      UltraGrid dg1 = this._dg;
      if (dg1 != null)
        dg1.AfterRowActivate -= eventHandler;
      this._dg = value;
      UltraGrid dg2 = this._dg;
      if (dg2 == null)
        return;
      dg2.AfterRowActivate += eventHandler;
    }
  }

  private virtual MGAButton btnOpenContact
  {
    get => this._btnOpenContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOpenContact_Click);
      MGAButton btnOpenContact1 = this._btnOpenContact;
      if (btnOpenContact1 != null)
        ((Control) btnOpenContact1).Click -= eventHandler;
      this._btnOpenContact = value;
      MGAButton btnOpenContact2 = this._btnOpenContact;
      if (btnOpenContact2 == null)
        return;
      ((Control) btnOpenContact2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnNewContact
  {
    get => this._btnNewContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewContact_Click);
      MGAButton btnNewContact1 = this._btnNewContact;
      if (btnNewContact1 != null)
        ((Control) btnNewContact1).Click -= eventHandler;
      this._btnNewContact = value;
      MGAButton btnNewContact2 = this._btnNewContact;
      if (btnNewContact2 == null)
        return;
      ((Control) btnNewContact2).Click += eventHandler;
    }
  }

  internal virtual UltraToolbarsManager mnuIntermediary
  {
    get => this._mnuIntermediary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.mnuIntermediary_ToolClick);
      UltraToolbarsManager mnuIntermediary1 = this._mnuIntermediary;
      if (mnuIntermediary1 != null)
        mnuIntermediary1.ToolClick -= clickEventHandler;
      this._mnuIntermediary = value;
      UltraToolbarsManager mnuIntermediary2 = this._mnuIntermediary;
      if (mnuIntermediary2 == null)
        return;
      mnuIntermediary2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("_frmCompanies_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _frmCompanies_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmCompanies_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _frmCompanies_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmCompanies_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _frmCompanies_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  internal virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkboxBillingSameAsPrimary")]
  internal virtual MGACheckBox checkboxBillingSameAsPrimary { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("billingAddressResolver")]
  private virtual AddressResolver_MULTI billingAddressResolver { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNIAC")]
  private virtual MGATextBox txtNIAC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("mgaInternationalFax")]
  protected virtual MGAInternationalPhoneNumberEditor mgaInternationalFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("mgaInternationalPhone")]
  protected virtual MGAInternationalPhoneNumberEditor mgaInternationalPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmCompanies_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _frmCompanies_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmIntermediaries));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblIntermediaries", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("IntermediaryGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("IntermediaryName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("WebSite");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ISOCountryCode");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Region");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("IntermediaryID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("BillingSameAsPrimary");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("BillingAddress1");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("BillingAddress2");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("BillingCity");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("BillingCounty");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("BillingState");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("BillingZipCode");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("BillingZipPlus");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("BillingRegion");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("BillingISOCountryCode");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("NAIC");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("CountryCodeforPhone");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("CountryCodeforFax");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance17 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance18 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance19 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Intermediary");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Intermediary");
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.mgaInternationalFax = new MGAInternationalPhoneNumberEditor();
    this.mgaInternationalPhone = new MGAInternationalPhoneNumberEditor();
    this.txtNIAC = new MGATextBox();
    this.ds = new dsIntermediaries();
    this.Label1 = new Label();
    this.Label8 = new Label();
    this.lblPhone = new Label();
    this.txtWebSite = new MGATextBox();
    this.Label3 = new Label();
    this.txtEmail = new MGATextBox();
    this.Label15 = new Label();
    this.ctlIntermediaryZip = new AddressResolver_MULTI();
    this.txtIntermediary = new MGATextBox();
    this.Label17 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.btnOpenContact = new MGAButton();
    this.btnNewContact = new MGAButton();
    this.lstContacts = new MGAListBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.billingAddressResolver = new AddressResolver_MULTI();
    this.checkboxBillingSameAsPrimary = new MGACheckBox();
    this.dg = new UltraGrid();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.mnuIntermediary = new UltraToolbarsManager(this.components);
    this._frmCompanies_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmCompanies_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._frmCompanies_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmCompanies_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtNIAC).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtWebSite).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.txtIntermediary).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.btnOpenContact).BeginInit();
    ((ISupportInitialize) this.btnNewContact).BeginInit();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.checkboxBillingSameAsPrimary).BeginInit();
    ((ISupportInitialize) this.dg).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.mnuIntermediary).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.mgaInternationalFax);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.mgaInternationalPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtNIAC);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtWebSite);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtEmail);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ctlIntermediaryZip);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtIntermediary);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label17);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(667, 211);
    this.mgaInternationalFax.CountryCode = "";
    this.mgaInternationalFax.Location = new Point(457, 70);
    this.mgaInternationalFax.MGAStyle = MGAStyles.Gray;
    this.mgaInternationalFax.Name = "mgaInternationalFax";
    this.mgaInternationalFax.Size = new Size(184, 21);
    this.mgaInternationalFax.TabIndex = 172;
    this.mgaInternationalFax.Value = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("mgaInternationalFax.Value"));
    this.mgaInternationalPhone.CountryCode = "";
    this.mgaInternationalPhone.Location = new Point(457, 43);
    this.mgaInternationalPhone.MGAStyle = MGAStyles.Gray;
    this.mgaInternationalPhone.Name = "mgaInternationalPhone";
    this.mgaInternationalPhone.Size = new Size(184, 21);
    this.mgaInternationalPhone.TabIndex = 171;
    this.mgaInternationalPhone.Value = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("mgaInternationalPhone.Value"));
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNIAC).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtNIAC).BackColor = Color.White;
    ((Control) this.txtNIAC).DataBindings.Add(new Binding("Text", (object) this.ds, "tblIntermediaries.NAIC", true));
    ((Control) this.txtNIAC).Location = new Point(457, 14);
    this.txtNIAC.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNIAC).Name = "txtNIAC";
    ((Control) this.txtNIAC).Size = new Size(184, 20);
    ((Control) this.txtNIAC).TabIndex = 143;
    ((UltraControlBase) this.txtNIAC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNIAC).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsIntermediaries";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(394, 14);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(36, 13);
    this.Label1.TabIndex = 142;
    this.Label1.Text = "NIAC:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(394, 97);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(54, 13);
    this.Label8.TabIndex = 138;
    this.Label8.Text = "Web Site:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(394, 47);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(41, 13);
    this.lblPhone.TabIndex = 134;
    this.lblPhone.Text = "Phone:";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtWebSite).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtWebSite).BackColor = Color.White;
    ((Control) this.txtWebSite).DataBindings.Add(new Binding("Value", (object) this.ds, "tblIntermediaries.WebSite", true));
    ((Control) this.txtWebSite).Location = new Point(457, 95);
    this.txtWebSite.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtWebSite).Name = "txtWebSite";
    ((Control) this.txtWebSite).Size = new Size(184, 20);
    ((Control) this.txtWebSite).TabIndex = 139;
    ((UltraControlBase) this.txtWebSite).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtWebSite).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(394, 73);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(29, 13);
    this.Label3.TabIndex = 136;
    this.Label3.Text = "Fax:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Value", (object) this.ds, "tblIntermediaries.Email", true));
    ((Control) this.txtEmail).Location = new Point(457, 120);
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(184, 20);
    ((Control) this.txtEmail).TabIndex = 141;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(394, 120);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(35, 13);
    this.Label15.TabIndex = 140;
    this.Label15.Text = "Email:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.ctlIntermediaryZip.Address1 = "";
    this.ctlIntermediaryZip.Address2 = "";
    ((Control) this.ctlIntermediaryZip).BackColor = Color.Transparent;
    this.ctlIntermediaryZip.City = "";
    this.ctlIntermediaryZip.County = "";
    ((Control) this.ctlIntermediaryZip).DataBindings.Add(new Binding("Address1", (object) this.ds, "tblIntermediaries.Address1", true));
    ((Control) this.ctlIntermediaryZip).DataBindings.Add(new Binding("Address2", (object) this.ds, "tblIntermediaries.Address2", true));
    ((Control) this.ctlIntermediaryZip).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.ds, "tblIntermediaries.ZipPlus", true));
    ((Control) this.ctlIntermediaryZip).Font = new Font("Tahoma", 8f);
    this.ctlIntermediaryZip.ISOCountryCode = "";
    this.ctlIntermediaryZip.ISOCountryCodeMember = "";
    this.ctlIntermediaryZip.ISOCountryList = (object) null;
    this.ctlIntermediaryZip.ISOCountryNameMember = "";
    ((Control) this.ctlIntermediaryZip).Location = new Point(7, 35);
    this.ctlIntermediaryZip.MGAStyle = MGAStyles.Blue;
    ((Control) this.ctlIntermediaryZip).Name = "ctlIntermediaryZip";
    this.ctlIntermediaryZip.Password = (string) null;
    ((Control) this.ctlIntermediaryZip).Size = new Size(272, 171);
    this.ctlIntermediaryZip.State = "";
    ((Control) this.ctlIntermediaryZip).TabIndex = 1;
    this.ctlIntermediaryZip.UserID = (string) null;
    this.ctlIntermediaryZip.WebserviceUrl = (string) null;
    this.ctlIntermediaryZip.ZipCode = "";
    this.ctlIntermediaryZip.ZipCodeExtension = "";
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtIntermediary).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtIntermediary).BackColor = Color.White;
    ((Control) this.txtIntermediary).DataBindings.Add(new Binding("Text", (object) this.ds, "tblIntermediaries.IntermediaryName", true));
    ((Control) this.txtIntermediary).Location = new Point(71, 14);
    this.txtIntermediary.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtIntermediary).Name = "txtIntermediary";
    ((Control) this.txtIntermediary).Size = new Size(202, 20);
    ((Control) this.txtIntermediary).TabIndex = 0;
    ((UltraControlBase) this.txtIntermediary).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtIntermediary).UseOsThemes = (DefaultableBoolean) 2;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(17, 14);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(38, 13);
    this.Label17.TabIndex = 130;
    this.Label17.Text = "Name:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(543, 158);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 133;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnOpenContact);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnNewContact);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lstContacts);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(667, 211);
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOpenContact).Appearance = (AppearanceBase) appearance5;
    ((ControlBase) this.btnOpenContact).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnOpenContact).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnOpenContact).Location = new Point(210, 112 /*0x70*/);
    ((Control) this.btnOpenContact).Name = "btnOpenContact";
    ((Control) this.btnOpenContact).Size = new Size(40, 40);
    ((Control) this.btnOpenContact).TabIndex = 1;
    this.btnOpenContact.UseOSThemes = (DefaultableBoolean) 2;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnNewContact).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.btnNewContact).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNewContact).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNewContact).Location = new Point(210, 161);
    ((Control) this.btnNewContact).Name = "btnNewContact";
    ((Control) this.btnNewContact).Size = new Size(40, 40);
    ((Control) this.btnNewContact).TabIndex = 2;
    this.btnNewContact.UseOSThemes = (DefaultableBoolean) 2;
    this.lstContacts.DataSource = (object) this.ds.tblIntermediaryContacts;
    this.lstContacts.DisplayMember = "Contact";
    this.lstContacts.Location = new Point(7, 7);
    this.lstContacts.MGAStyle = MGAStyles.Blue;
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(192 /*0xC0*/, 197);
    this.lstContacts.TabIndex = 0;
    this.lstContacts.ValueMember = "IntermediaryContactGuid";
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.billingAddressResolver);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.checkboxBillingSameAsPrimary);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(667, 211);
    this.billingAddressResolver.Address1 = "";
    this.billingAddressResolver.Address2 = "";
    ((Control) this.billingAddressResolver).BackColor = Color.Transparent;
    this.billingAddressResolver.City = "";
    this.billingAddressResolver.County = "";
    ((Control) this.billingAddressResolver).DataBindings.Add(new Binding("Address1", (object) this.ds, "tblIntermediaries.BillingAddress1", true));
    ((Control) this.billingAddressResolver).DataBindings.Add(new Binding("Address2", (object) this.ds, "tblIntermediaries.BillingAddress2", true));
    ((Control) this.billingAddressResolver).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.ds, "tblIntermediaries.BillingZipPlus", true));
    ((Control) this.billingAddressResolver).Font = new Font("Tahoma", 8f);
    this.billingAddressResolver.ISOCountryCode = "";
    this.billingAddressResolver.ISOCountryCodeMember = "";
    this.billingAddressResolver.ISOCountryList = (object) null;
    this.billingAddressResolver.ISOCountryNameMember = "";
    ((Control) this.billingAddressResolver).Location = new Point(7, 37);
    this.billingAddressResolver.MGAStyle = MGAStyles.Blue;
    ((Control) this.billingAddressResolver).Name = "billingAddressResolver";
    this.billingAddressResolver.Password = (string) null;
    ((Control) this.billingAddressResolver).Size = new Size(272, 171);
    this.billingAddressResolver.State = "";
    ((Control) this.billingAddressResolver).TabIndex = 146;
    this.billingAddressResolver.UserID = (string) null;
    this.billingAddressResolver.WebserviceUrl = (string) null;
    this.billingAddressResolver.ZipCode = "";
    this.billingAddressResolver.ZipCodeExtension = "";
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkboxBillingSameAsPrimary).Appearance = (AppearanceBase) appearance7;
    ((Control) this.checkboxBillingSameAsPrimary).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblIntermediaries.BillingSameAsPrimary", true));
    ((UltraToggleEditorBase) this.checkboxBillingSameAsPrimary).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkboxBillingSameAsPrimary).Location = new Point(17, 12);
    ((Control) this.checkboxBillingSameAsPrimary).Name = "checkboxBillingSameAsPrimary";
    ((Control) this.checkboxBillingSameAsPrimary).Size = new Size(188, 20);
    ((Control) this.checkboxBillingSameAsPrimary).TabIndex = 145;
    ((UltraToggleEditorBase) this.checkboxBillingSameAsPrimary).Text = "Billing Same As Primary Address";
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dg).DataSource = (object) this.ds.tblIntermediaries;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 89;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Intermediary";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 444;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 44;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 44;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 162;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 50;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 67;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 53;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 53;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 53;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 53;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 53;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 53;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 53;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 115;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 117;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 51;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 39;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 39;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 39;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 39;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 39;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 39;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 39;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 39;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 52;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 87;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 93;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 96 /*0x60*/;
    ultraGridBand.Columns.AddRange(new object[29]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29
    });
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance9.BackColor = Color.LightSteelBlue;
    appearance9.FontData.SizeInPoints = 10f;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance13.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance13;
    appearance14.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance15.BackColor = Color.Transparent;
    appearance15.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dg).Location = new Point(7, 7);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(675, 213);
    ((Control) this.dg).TabIndex = 134;
    ((UltraControlBase) this.dg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dg).UseOsThemes = (DefaultableBoolean) 2;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblIntermediaries", new DataColumnMapping[29]
      {
        new DataColumnMapping("IntermediaryGuid", "IntermediaryGuid"),
        new DataColumnMapping("IntermediaryName", "IntermediaryName"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("WebSite", "WebSite"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("IntermediaryID", "IntermediaryID"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("BillingSameAsPrimary", "BillingSameAsPrimary"),
        new DataColumnMapping("BillingAddress1", "BillingAddress1"),
        new DataColumnMapping("BillingAddress2", "BillingAddress2"),
        new DataColumnMapping("BillingCity", "BillingCity"),
        new DataColumnMapping("BillingCounty", "BillingCounty"),
        new DataColumnMapping("BillingState", "BillingState"),
        new DataColumnMapping("BillingZipCode", "BillingZipCode"),
        new DataColumnMapping("BillingZipPlus", "BillingZipPlus"),
        new DataColumnMapping("BillingRegion", "BillingRegion"),
        new DataColumnMapping("BillingISOCountryCode", "BillingISOCountryCode"),
        new DataColumnMapping("NAIC", "NAIC"),
        new DataColumnMapping("CountryCodeforPhone", "CountryCodeforPhone"),
        new DataColumnMapping("CountryCodeforFax", "CountryCodeforFax")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[48 /*0x30*/]
    {
      new SqlParameter("@Original_IntermediaryGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IntermediaryName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_County", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "County", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_State", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_State", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ZipCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Phone", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Fax", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_WebSite", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "WebSite", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_WebSite", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WebSite", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Region", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IntermediaryID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Email", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_BillingSameAsPrimary", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingSameAsPrimary", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingAddress1", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingAddress1", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingAddress1", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingAddress1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingAddress2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingAddress2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingAddress2", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingAddress2", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingCity", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingCity", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingCity", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingCity", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingCounty", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingCounty", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingCounty", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingCounty", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingState", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingState", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingState", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingState", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingZipCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingZipCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingZipCode", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingZipPlus", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingRegion", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingRegion", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingRegion", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingRegion", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingISOCountryCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingISOCountryCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingISOCountryCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_NAIC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NAIC", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_NAIC", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NAIC", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CountryCodeforPhone", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CountryCodeforPhone", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CountryCodeforFax", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CountryCodeforFax", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "Data Source=172.16.8.29,1433;Initial Catalog=AlliedPublicRisk_Test;User ID=alliedtest_ims";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[28]
    {
      new SqlParameter("@IntermediaryGuid", SqlDbType.UniqueIdentifier, 0, "IntermediaryGuid"),
      new SqlParameter("@IntermediaryName", SqlDbType.VarChar, 0, "IntermediaryName"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@State", SqlDbType.VarChar, 0, "State"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@WebSite", SqlDbType.VarChar, 0, "WebSite"),
      new SqlParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@BillingSameAsPrimary", SqlDbType.Bit, 0, "BillingSameAsPrimary"),
      new SqlParameter("@BillingAddress1", SqlDbType.VarChar, 0, "BillingAddress1"),
      new SqlParameter("@BillingAddress2", SqlDbType.VarChar, 0, "BillingAddress2"),
      new SqlParameter("@BillingCity", SqlDbType.VarChar, 0, "BillingCity"),
      new SqlParameter("@BillingCounty", SqlDbType.VarChar, 0, "BillingCounty"),
      new SqlParameter("@BillingState", SqlDbType.VarChar, 0, "BillingState"),
      new SqlParameter("@BillingZipCode", SqlDbType.VarChar, 0, "BillingZipCode"),
      new SqlParameter("@BillingZipPlus", SqlDbType.VarChar, 0, "BillingZipPlus"),
      new SqlParameter("@BillingRegion", SqlDbType.VarChar, 0, "BillingRegion"),
      new SqlParameter("@BillingISOCountryCode", SqlDbType.Char, 0, "BillingISOCountryCode"),
      new SqlParameter("@NAIC", SqlDbType.VarChar, 0, "NAIC"),
      new SqlParameter("@CountryCodeforPhone", SqlDbType.VarChar, 0, "CountryCodeforPhone"),
      new SqlParameter("@CountryCodeforFax", SqlDbType.VarChar, 0, "CountryCodeforFax")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[76]
    {
      new SqlParameter("@IntermediaryGuid", SqlDbType.UniqueIdentifier, 0, "IntermediaryGuid"),
      new SqlParameter("@IntermediaryName", SqlDbType.VarChar, 0, "IntermediaryName"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@State", SqlDbType.VarChar, 0, "State"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@WebSite", SqlDbType.VarChar, 0, "WebSite"),
      new SqlParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@BillingSameAsPrimary", SqlDbType.Bit, 0, "BillingSameAsPrimary"),
      new SqlParameter("@BillingAddress1", SqlDbType.VarChar, 0, "BillingAddress1"),
      new SqlParameter("@BillingAddress2", SqlDbType.VarChar, 0, "BillingAddress2"),
      new SqlParameter("@BillingCity", SqlDbType.VarChar, 0, "BillingCity"),
      new SqlParameter("@BillingCounty", SqlDbType.VarChar, 0, "BillingCounty"),
      new SqlParameter("@BillingState", SqlDbType.VarChar, 0, "BillingState"),
      new SqlParameter("@BillingZipCode", SqlDbType.VarChar, 0, "BillingZipCode"),
      new SqlParameter("@BillingZipPlus", SqlDbType.VarChar, 0, "BillingZipPlus"),
      new SqlParameter("@BillingRegion", SqlDbType.VarChar, 0, "BillingRegion"),
      new SqlParameter("@BillingISOCountryCode", SqlDbType.Char, 0, "BillingISOCountryCode"),
      new SqlParameter("@NAIC", SqlDbType.VarChar, 0, "NAIC"),
      new SqlParameter("@CountryCodeforPhone", SqlDbType.VarChar, 0, "CountryCodeforPhone"),
      new SqlParameter("@CountryCodeforFax", SqlDbType.VarChar, 0, "CountryCodeforFax"),
      new SqlParameter("@Original_IntermediaryGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IntermediaryName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_County", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "County", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_State", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_State", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ZipCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Phone", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Fax", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_WebSite", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "WebSite", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_WebSite", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WebSite", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Region", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IntermediaryID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Email", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_BillingSameAsPrimary", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingSameAsPrimary", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingAddress1", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingAddress1", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingAddress1", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingAddress1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingAddress2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingAddress2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingAddress2", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingAddress2", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingCity", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingCity", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingCity", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingCity", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingCounty", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingCounty", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingCounty", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingCounty", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingState", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingState", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingState", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingState", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingZipCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingZipCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingZipCode", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingZipPlus", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingRegion", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingRegion", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingRegion", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingRegion", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillingISOCountryCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillingISOCountryCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillingISOCountryCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillingISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_NAIC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NAIC", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_NAIC", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NAIC", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CountryCodeforPhone", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CountryCodeforPhone", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CountryCodeforFax", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CountryCodeforFax", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Location = new Point(7, 227);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    appearance16.BackColor = Color.FromArgb(246, 250, 253);
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraTabControlBase) this.UltraTabControl1).SelectedTabAppearance = (AppearanceBase) appearance16;
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(669, 238);
    ((Control) this.UltraTabControl1).TabIndex = 137;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance17.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance17.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance17;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Intermediary Info";
    appearance18.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance18;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Contacts";
    appearance19.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance19.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance19;
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "Billing";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(135, 25);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(667, 211);
    this.mnuIntermediary.DesignerFlags = 1;
    this.mnuIntermediary.DockWithinContainer = (Control) this;
    this.mnuIntermediary.DockWithinContainerBaseType = typeof (Form);
    this.mnuIntermediary.LockToolbars = true;
    this.mnuIntermediary.MenuSettings.IsSideStripVisible = (DefaultableBoolean) 2;
    this.mnuIntermediary.MenuSettings.PopupStyle = (PopupStyle) 1;
    this.mnuIntermediary.ShowFullMenusDelay = 500;
    this.mnuIntermediary.ShowQuickCustomizeButton = false;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Text = "MainMenu";
    this.mnuIntermediary.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Intermediary";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.Category = "Company";
    this.mnuIntermediary.Tools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool2
    });
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmCompanies_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).Name = "_frmCompanies_Toolbars_Dock_Area_Top";
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).Size = new Size(688, 21);
    this._frmCompanies_Toolbars_Dock_Area_Top.ToolbarsManager = this.mnuIntermediary;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmCompanies_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).Location = new Point(0, 473);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).Name = "_frmCompanies_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).Size = new Size(688, 0);
    this._frmCompanies_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.mnuIntermediary;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmCompanies_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).Location = new Point(0, 21);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).Name = "_frmCompanies_Toolbars_Dock_Area_Left";
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).Size = new Size(0, 452);
    this._frmCompanies_Toolbars_Dock_Area_Left.ToolbarsManager = this.mnuIntermediary;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmCompanies_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).Location = new Point(688, 21);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).Name = "_frmCompanies_Toolbars_Dock_Area_Right";
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).Size = new Size(0, 452);
    this._frmCompanies_Toolbars_Dock_Area_Right.ToolbarsManager = this.mnuIntermediary;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(688, 473);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.dg);
    this.Controls.Add((Control) this._frmCompanies_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmCompanies_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmCompanies_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmIntermediaries);
    this.Text = "Administer Intermediaries";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtNIAC).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtWebSite).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.txtIntermediary).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.btnOpenContact).EndInit();
    ((ISupportInitialize) this.btnNewContact).EndInit();
    ((ISupportInitialize) this.lstContacts).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.checkboxBillingSameAsPrimary).EndInit();
    ((ISupportInitialize) this.dg).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.mnuIntermediary).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("_bmb")]
  private virtual BindingManagerBase _bmb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public Guid IntermediaryGuid => this._intermediaryGuid;

  public bool IsNewIntermediary => this._newIntermediary;

  public bool AllowAddNewDocument => this._intermediaryGuid != Guid.Empty;

  string IRecreatableEntity.EntityName => this._intermediaryName;

  Guid IRecreatableEntity.EntityGuid => this._intermediaryGuid;

  string IRecreatableEntity.FriendlyEntityName => "Administer Intermediaries Form";

  string IRecreatableEntity.RecreateTypeName => "";

  bool IRecreatableEntity.CanReCreateEntity => false;

  bool IRecreatableEntity.HasControlGUID => false;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  private void frmIntermediaries_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((ControlBase) this.btnNewContact).Appearance.Image = (object) ImageCache.Instance.NewImage;
    ((ControlBase) this.btnOpenContact).Appearance.Image = (object) ImageCache.Instance.Forward;
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Bands[0].Override.AllowRowFiltering = (DefaultableBoolean) 1;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblIntermediaries);
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblIntermediaries.TableName];
    if (this._bmb.Position != -1 && this.ds.tblIntermediaries.Count > 0)
    {
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsCountryCodeforPhoneNull())
        this.mgaInternationalPhone.CountryCode = this.ds.tblIntermediaries[this._bmb.Position].CountryCodeforPhone;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsCountryCodeforFaxNull())
        this.mgaInternationalFax.CountryCode = this.ds.tblIntermediaries[this._bmb.Position].CountryCodeforFax;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsPhoneNull())
        this.mgaInternationalPhone.Value = (object) this.ds.tblIntermediaries[this._bmb.Position].Phone;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsFaxNull())
        this.mgaInternationalFax.Value = (object) this.ds.tblIntermediaries[this._bmb.Position].Fax;
      this.ctlIntermediaryZip.ZipCode = this.ds.tblIntermediaries[this._bmb.Position].ZipCode;
      this.ctlIntermediaryZip.City = this.ds.tblIntermediaries[this._bmb.Position].City;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsCountyNull())
        this.ctlIntermediaryZip.County = this.ds.tblIntermediaries[this._bmb.Position].County;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsStateNull())
        this.ctlIntermediaryZip.State = this.ds.tblIntermediaries[this._bmb.Position].State;
      this.ctlIntermediaryZip.ISOCountryCode = this.ds.tblIntermediaries[this._bmb.Position].ISOCountryCode;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsBillingZipCodeNull())
        this.billingAddressResolver.ZipCode = this.ds.tblIntermediaries[this._bmb.Position].BillingZipCode;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsBillingCityNull())
        this.billingAddressResolver.City = this.ds.tblIntermediaries[this._bmb.Position].BillingCity;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsBillingCountyNull())
        this.billingAddressResolver.County = this.ds.tblIntermediaries[this._bmb.Position].BillingCounty;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsBillingStateNull())
        this.billingAddressResolver.State = this.ds.tblIntermediaries[this._bmb.Position].BillingState;
      if (!this.ds.tblIntermediaries[this._bmb.Position].IsBillingISOCountryCodeNull())
        this.billingAddressResolver.ISOCountryCode = this.ds.tblIntermediaries[this._bmb.Position].BillingISOCountryCode;
    }
    this.dbSave.UIState = UIState.NoRecordsNotEditing;
    ((UltraTabControlBase) this.UltraTabControl1).SelectedTabChanged += new SelectedTabChangedEventHandler(this.UltraTabControl1_SelectedTabChanged);
    this.AfterLoadComplete();
  }

  private void dg_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dg).ActiveRow == null)
      return;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["IntermediaryGuid"].Value)))
      this._intermediaryGuid = (Guid) ((UltraGridBase) this.dg).ActiveRow.Cells["IntermediaryGuid"].Value;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["IntermediaryName"].Value)))
      this._intermediaryName = Conversions.ToString(((UltraGridBase) this.dg).ActiveRow.Cells["IntermediaryName"].Value);
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent != null)
      infoChangedEvent((object) this, EventArgs.Empty);
    int num = 0;
    try
    {
      foreach (dsIntermediaries.tblIntermediariesRow tblIntermediary in (TypedTableBase<dsIntermediaries.tblIntermediariesRow>) this.ds.tblIntermediaries)
      {
        if (tblIntermediary.IntermediaryGuid.Equals(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["IntermediaryGuid"].Value)))
        {
          this._bmb.Position = num;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["CountryCodeforPhone"].Value)))
            this.mgaInternationalPhone.CountryCode = ((UltraGridBase) this.dg).ActiveRow.Cells["CountryCodeforPhone"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["CountryCodeforFax"].Value)))
            this.mgaInternationalFax.CountryCode = ((UltraGridBase) this.dg).ActiveRow.Cells["CountryCodeforFax"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["phone"].Value)))
            this.mgaInternationalPhone.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["phone"].Value);
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["fax"].Value)))
            this.mgaInternationalFax.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["fax"].Value);
          this.ctlIntermediaryZip.ISOCountryCode = ((UltraGridBase) this.dg).ActiveRow.Cells["ISOCountryCode"].Value.ToString();
          this.ctlIntermediaryZip.ZipCode = ((UltraGridBase) this.dg).ActiveRow.Cells["ZipCode"].Value.ToString();
          this.ctlIntermediaryZip.City = ((UltraGridBase) this.dg).ActiveRow.Cells["City"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["County"].Value)))
            this.ctlIntermediaryZip.County = ((UltraGridBase) this.dg).ActiveRow.Cells["County"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["State"].Value)))
            this.ctlIntermediaryZip.State = ((UltraGridBase) this.dg).ActiveRow.Cells["State"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["BillingISOCountryCode"].Value)))
            this.billingAddressResolver.ISOCountryCode = ((UltraGridBase) this.dg).ActiveRow.Cells["BillingISOCountryCode"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["BillingZipCode"].Value)))
            this.billingAddressResolver.ZipCode = ((UltraGridBase) this.dg).ActiveRow.Cells["BillingZipCode"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["BillingCity"].Value)))
            this.billingAddressResolver.City = ((UltraGridBase) this.dg).ActiveRow.Cells["BillingCity"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["BillingCounty"].Value)))
            this.billingAddressResolver.County = ((UltraGridBase) this.dg).ActiveRow.Cells["BillingCounty"].Value.ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["BillingState"].Value)))
            this.billingAddressResolver.State = ((UltraGridBase) this.dg).ActiveRow.Cells["BillingState"].Value.ToString();
          if (((UltraTabControlBase) this.UltraTabControl1).SelectedTab.Index != 1)
            break;
          this.FillContacts();
          break;
        }
        ++num;
      }
    }
    finally
    {
      IEnumerator<dsIntermediaries.tblIntermediariesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private bool ValidForm()
  {
    bool flag = this.ctlIntermediaryZip.ValidateFields();
    if (((TextEditorControlBase) this.txtIntermediary).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtIntermediary, "Please enter a name for this intermediary.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtIntermediary, string.Empty);
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    this._newIntermediary = this.ds.tblIntermediaries[this._bmb.Position].RowState == DataRowState.Added;
    if (this._newIntermediary && this._bmb.Position >= 0)
      this._intermediaryGuid = this.ds.tblIntermediaries[this._bmb.Position].IntermediaryGuid;
    if (this.ValidForm())
    {
      Cursor.Current = MgaCursors.WaitCursor;
      this._bmb.EndCurrentEdit();
      this.ds.tblIntermediaries[this._bmb.Position].Phone = this.mgaInternationalPhone.ValueString;
      this.ds.tblIntermediaries[this._bmb.Position].Fax = this.mgaInternationalFax.ValueString;
      this.ds.tblIntermediaries[this._bmb.Position].CountryCodeforPhone = this.mgaInternationalPhone.CountryCode;
      this.ds.tblIntermediaries[this._bmb.Position].CountryCodeforFax = this.mgaInternationalFax.CountryCode;
      this.ds.tblIntermediaries[this._bmb.Position].ZipCode = this.ctlIntermediaryZip.ZipCode;
      this.ds.tblIntermediaries[this._bmb.Position].City = this.ctlIntermediaryZip.City;
      this.ds.tblIntermediaries[this._bmb.Position].County = this.ctlIntermediaryZip.County;
      this.ds.tblIntermediaries[this._bmb.Position].State = this.ctlIntermediaryZip.State;
      this.ds.tblIntermediaries[this._bmb.Position].ISOCountryCode = this.ctlIntermediaryZip.ISOCountryCode;
      this.ds.tblIntermediaries[this._bmb.Position].BillingZipCode = this.billingAddressResolver.ZipCode;
      this.ds.tblIntermediaries[this._bmb.Position].BillingCity = this.billingAddressResolver.City;
      this.ds.tblIntermediaries[this._bmb.Position].BillingCounty = this.billingAddressResolver.County;
      this.ds.tblIntermediaries[this._bmb.Position].BillingState = this.billingAddressResolver.State;
      this.ds.tblIntermediaries[this._bmb.Position].BillingISOCountryCode = this.billingAddressResolver.ISOCountryCode;
      this.ds.EnforceConstraints = true;
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblIntermediaries);
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Message.IndexOf("IX_tblIntermediaries") != -1)
        {
          int num = (int) MessageBox.Show("An intermediary already exists with the name you have entered.", "Duplicate Intermediary", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
      this.AfterSave();
    }
    else
      e.Cancel = true;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.ds.EnforceConstraints = false;
    dsIntermediaries.tblIntermediariesRow row = this.ds.tblIntermediaries.NewtblIntermediariesRow();
    row.IntermediaryGuid = Guid.NewGuid();
    row.CountryCodeforPhone = "USA";
    row.CountryCodeforFax = "USA";
    row.Phone = string.Empty;
    row.Fax = string.Empty;
    row.ZipCode = "";
    row.City = "";
    row.County = "";
    row.State = "";
    row.ISOCountryCode = "USA";
    row.SetBillingZipPlusNull();
    row.BillingZipCode = "";
    row.BillingCity = "";
    row.BillingCounty = "";
    row.BillingState = "";
    row.BillingISOCountryCode = "USA";
    row.SetZipPlusNull();
    this.mgaInternationalPhone.CountryCode = "USA";
    this.mgaInternationalFax.CountryCode = "USA";
    this.mgaInternationalPhone.Value = (object) string.Empty;
    this.mgaInternationalFax.Value = (object) string.Empty;
    this.ctlIntermediaryZip.ISOCountryCode = "USA";
    this.ctlIntermediaryZip.ZipCode = "";
    this.ctlIntermediaryZip.City = "";
    this.ctlIntermediaryZip.County = "";
    this.ctlIntermediaryZip.State = "";
    this.ctlIntermediaryZip.ZipCodeExtension = "";
    this.billingAddressResolver.ZipCode = "";
    this.billingAddressResolver.City = "";
    this.billingAddressResolver.County = "";
    this.billingAddressResolver.State = "";
    this.billingAddressResolver.ISOCountryCode = "USA";
    this.billingAddressResolver.ZipCodeExtension = "";
    this.ds.tblIntermediaries.AddtblIntermediariesRow(row);
    this._bmb.Position = this.ds.tblIntermediaries.Rows.Count - 1;
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e) => this.ds.RejectChanges();

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.dg).Enabled = this.dbSave.UIState != UIState.Editing;
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control != this.dbSave)
            control.Enabled = this.dbSave.UIState == UIState.Editing;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dg).ActiveRow == null)
      return;
    if (MessageBox.Show("Are you sure you want to delete this intermediary?", "Delete Intermediary?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      this.ds.tblIntermediaries[this._bmb.Position].Delete();
      this._bmb.EndCurrentEdit();
      this.ds.EnforceConstraints = true;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblIntermediaries);
      this._bmb.Position = 0;
      Cursor.Current = MgaCursors.Default;
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      this.ds.tblIntermediaries.RejectChanges();
      if (ex2.Message.IndexOf("FK_tblQuoteDetails_tblIntermediaryContacts") != -1)
      {
        int num = (int) MessageBox.Show("This intermediary can not be deleted, because it is associated with one or more policies.", "Unable To Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
  }

  private void btnNewContact_Click(object sender, EventArgs e)
  {
    if (this._bmb.Position == -1 || this.ds.tblIntermediaries[this._bmb.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save this intermediary before establishing contacts.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (frmIntermediaryContacts), (object) this.ds.tblIntermediaries[this._bmb.Position].IntermediaryID))
        ;
      this.FillContacts();
    }
  }

  private void FillContactsThread(object state)
  {
    this.ds.tblIntermediaryContacts.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblIntermediaryContacts, CommandType.StoredProcedure, "spGetIntermediaryContacts", new object[2]
    {
      (object) "@IntermediaryID",
      (object) this.ds.tblIntermediaries[this._bmb.Position].IntermediaryID
    });
    this.Invoke((Delegate) new MethodInvoker(this.ContactsFilled));
  }

  private void ContactsFilled()
  {
    MGAListBox lstContacts = this.lstContacts;
    lstContacts.DataSource = (object) this.ds.tblIntermediaryContacts;
    lstContacts.DisplayMember = this.ds.tblIntermediaryContacts.ContactColumn.ColumnName;
    lstContacts.ValueMember = this.ds.tblIntermediaryContacts.IntermediaryContactGuidColumn.ColumnName;
    Cursor.Current = MgaCursors.Default;
  }

  private void FillContacts()
  {
    if (this._bmb.Position == -1)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    this.lstContacts.DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillContactsThread));
  }

  private void UltraTabControl1_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    this.FillContacts();
  }

  private void btnOpenContact_Click(object sender, EventArgs e)
  {
    if (this.lstContacts.SelectedIndex == -1 || this._bmb.Position == -1)
      return;
    using (FormSettings.ShowFormDialog(typeof (frmIntermediaryContacts), (object) this.ds.tblIntermediaries[this._bmb.Position].IntermediaryID, (object) (Guid) this.lstContacts.SelectedValue))
      ;
    this.FillContacts();
  }

  protected virtual void AfterLoadComplete()
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.mnuIntermediary.Toolbars[0]).Tools)[0].SharedProps.Visible = false;
  }

  protected virtual void AddMenuItem(string key, string caption)
  {
    if (((ToolsCollectionBase) this.mnuIntermediary.Tools).Exists(key))
      return;
    ButtonTool buttonTool = new ButtonTool(key);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = caption;
    this.mnuIntermediary.Tools.Add((ToolBase) buttonTool);
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.mnuIntermediary.Toolbars[0]).Tools)[0]).Tools).Add((ToolBase) buttonTool);
    this.mnuIntermediary.RefreshMerge();
  }

  protected virtual void AfterSave()
  {
  }

  protected virtual void mnuIntermediary_ToolClick(object sender, ToolClickEventArgs e)
  {
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    throw new NotImplementedException();
  }
}
