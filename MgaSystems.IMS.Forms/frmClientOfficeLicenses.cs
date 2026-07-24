// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmClientOfficeLicenses
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.AddressResolver;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public class frmClientOfficeLicenses : Form
{
  private IContainer components;
  private Guid _officeGuid;
  private List<Guid> changedOfficeImages;

  public frmClientOfficeLicenses()
  {
    this.Load += new EventHandler(this.frmClientOfficeLicenses_Load);
    this.changedOfficeImages = new List<Guid>();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboContacts")]
  internal virtual MGASimpleComboBox cboContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLicenseNum")]
  internal virtual MGATextBox txtLicenseNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  internal virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLicenseType")]
  internal virtual MGASimpleComboBox cboLicenseType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblExpires")]
  internal virtual Label lblExpires { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblState")]
  internal virtual Label lblState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblType")]
  internal virtual Label lblType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtExpires")]
  internal virtual MGADateTimePicker dtExpires { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASystems.Tools.DBSaveUI.DBSaveUI DbSaveUI1
  {
    get => this._DbSaveUI1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.DbSaveUI1_ClickedNew);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSaveUI1_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSaveUI1_ClickingCancel);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSaveUI1_ClickingDelete);
      EventHandler eventHandler2 = new EventHandler(this.DbSaveUI1_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_1 = this._DbSaveUI1;
      if (dbSaveUi1_1 != null)
      {
        dbSaveUi1_1.ClickedNew -= eventHandler1;
        dbSaveUi1_1.ClickingSave -= cancelEventHandler1;
        dbSaveUi1_1.ClickingCancel -= cancelEventHandler2;
        dbSaveUi1_1.ClickingDelete -= cancelEventHandler3;
        dbSaveUi1_1.UIStateChanged -= eventHandler2;
      }
      this._DbSaveUI1 = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_2 = this._DbSaveUI1;
      if (dbSaveUi1_2 == null)
        return;
      dbSaveUi1_2.ClickedNew += eventHandler1;
      dbSaveUi1_2.ClickingSave += cancelEventHandler1;
      dbSaveUi1_2.ClickingCancel += cancelEventHandler2;
      dbSaveUi1_2.ClickingDelete += cancelEventHandler3;
      dbSaveUi1_2.UIStateChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsClientOfficeLicense ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLicenseTypes")]
  internal virtual UltraDropDown ddLicenseTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daClientLicense")]
  internal virtual SqlDataAdapter daClientLicense { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid ugLicenses
  {
    get => this._ugLicenses;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugLicenses_AfterRowActivate);
      UltraGrid ugLicenses1 = this._ugLicenses;
      if (ugLicenses1 != null)
        ugLicenses1.AfterRowActivate -= eventHandler;
      this._ugLicenses = value;
      UltraGrid ugLicenses2 = this._ugLicenses;
      if (ugLicenses2 == null)
        return;
      ugLicenses2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox1")]
  internal virtual MGASimpleComboBox MgaSimpleComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDays")]
  private virtual MGANumericEditor numDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbSignature")]
  private virtual UltraGroupBox gbSignature { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLoadingImage")]
  internal virtual Label lblLoadingImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pbLogo")]
  internal virtual PictureBox pbLogo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnNewImage
  {
    get => this._btnNewImage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewImage_Click);
      MGAButton btnNewImage1 = this._btnNewImage;
      if (btnNewImage1 != null)
        ((Control) btnNewImage1).Click -= eventHandler;
      this._btnNewImage = value;
      MGAButton btnNewImage2 = this._btnNewImage;
      if (btnNewImage2 == null)
        return;
      ((Control) btnNewImage2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("tabLocationInfo")]
  private virtual UltraTabControl tabLocationInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabLicense")]
  private virtual UltraTabPageControl tabLicense { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabAdditionalInfo")]
  private virtual UltraTabPageControl tabAdditionalInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ctlZipCode")]
  protected virtual AddressResolver_MULTI ctlZipCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddUser")]
  internal virtual UltraDropDown ddUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstLicenseTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LicenseTypeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LicenseType");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("lstLicenseTypestblClientOfficeLicenses");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstLicenseTypestblClientOfficeLicenses", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ClientOfficeLicenseGUID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ClientLocationGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LicenseTypeID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Expires");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("NumDaysToSendNote");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("UserReceivingNote");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Signature");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ISOCountryCode");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ZipPlus");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmClientOfficeLicenses));
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblClientOfficeLicenses", -1);
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ClientOfficeLicenseGUID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ClientLocationGUID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("LicenseTypeID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Expires");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("NumDaysToSendNote");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("UserReceivingNote", -1, (object) "ddUser");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Signature");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("ISOCountryCode");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ZipPlus");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("dtUsers", -1);
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Name_LastFirst");
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance15 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    this.tabLicense = new UltraTabPageControl();
    this.gbSignature = new UltraGroupBox();
    this.lblLoadingImage = new Label();
    this.pbLogo = new PictureBox();
    this.ds = new dsClientOfficeLicense();
    this.btnNewImage = new MGAButton();
    this.Label5 = new Label();
    this.numDays = new MGANumericEditor();
    this.Label4 = new Label();
    this.MgaSimpleComboBox1 = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.cboContacts = new MGASimpleComboBox();
    this.txtLicenseNum = new MGATextBox();
    this.cboState = new MGASimpleComboBox();
    this.cboLicenseType = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.lblExpires = new Label();
    this.lblState = new Label();
    this.lblType = new Label();
    this.dtExpires = new MGADateTimePicker();
    this.tabAdditionalInfo = new UltraTabPageControl();
    this.ctlZipCode = new AddressResolver_MULTI();
    this.DbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.ddLicenseTypes = new UltraDropDown();
    this.daClientLicense = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ugLicenses = new UltraGrid();
    this.err = new ErrorProvider(this.components);
    this.ddUser = new UltraDropDown();
    this.tabLocationInfo = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.tabLicense).SuspendLayout();
    ((ISupportInitialize) this.gbSignature).BeginInit();
    ((Control) this.gbSignature).SuspendLayout();
    ((ISupportInitialize) this.pbLogo).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnNewImage).BeginInit();
    ((ISupportInitialize) this.numDays).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).BeginInit();
    ((ISupportInitialize) this.cboContacts).BeginInit();
    ((ISupportInitialize) this.txtLicenseNum).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboLicenseType).BeginInit();
    ((ISupportInitialize) this.dtExpires).BeginInit();
    ((Control) this.tabAdditionalInfo).SuspendLayout();
    ((ISupportInitialize) this.ddLicenseTypes).BeginInit();
    ((ISupportInitialize) this.ugLicenses).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddUser).BeginInit();
    ((ISupportInitialize) this.tabLocationInfo).BeginInit();
    ((Control) this.tabLocationInfo).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.tabLicense).Controls.Add((Control) this.Label5);
    ((Control) this.tabLicense).Controls.Add((Control) this.gbSignature);
    ((Control) this.tabLicense).Controls.Add((Control) this.numDays);
    ((Control) this.tabLicense).Controls.Add((Control) this.Label4);
    ((Control) this.tabLicense).Controls.Add((Control) this.cboContacts);
    ((Control) this.tabLicense).Controls.Add((Control) this.MgaSimpleComboBox1);
    ((Control) this.tabLicense).Controls.Add((Control) this.Label3);
    ((Control) this.tabLicense).Controls.Add((Control) this.Label2);
    ((Control) this.tabLicense).Controls.Add((Control) this.txtLicenseNum);
    ((Control) this.tabLicense).Controls.Add((Control) this.cboLicenseType);
    ((Control) this.tabLicense).Controls.Add((Control) this.Label1);
    ((Control) this.tabLicense).Controls.Add((Control) this.lblType);
    ((Control) this.tabLicense).Controls.Add((Control) this.lblExpires);
    ((Control) this.tabLicense).Controls.Add((Control) this.cboState);
    ((Control) this.tabLicense).Controls.Add((Control) this.dtExpires);
    ((Control) this.tabLicense).Controls.Add((Control) this.lblState);
    ((Control) this.tabLicense).Location = new Point(1, 26);
    ((Control) this.tabLicense).Name = "tabLicense";
    ((Control) this.tabLicense).Size = new Size(727, 235);
    appearance1.BackColor = Color.Transparent;
    this.gbSignature.Appearance = (AppearanceBase) appearance1;
    ((Control) this.gbSignature).Controls.Add((Control) this.lblLoadingImage);
    ((Control) this.gbSignature).Controls.Add((Control) this.pbLogo);
    ((Control) this.gbSignature).Controls.Add((Control) this.btnNewImage);
    ((Control) this.gbSignature).Enabled = false;
    ((Control) this.gbSignature).Location = new Point(520, 10);
    ((Control) this.gbSignature).Name = "gbSignature";
    ((Control) this.gbSignature).Size = new Size(187, 192 /*0xC0*/);
    ((Control) this.gbSignature).TabIndex = 8;
    this.gbSignature.Text = "Signature";
    this.lblLoadingImage.AutoSize = true;
    this.lblLoadingImage.Location = new Point(50, 55);
    this.lblLoadingImage.Name = "lblLoadingImage";
    this.lblLoadingImage.Size = new Size(54, 13);
    this.lblLoadingImage.TabIndex = 4;
    this.lblLoadingImage.Text = "Loading...";
    this.lblLoadingImage.Visible = false;
    this.pbLogo.DataBindings.Add(new Binding("Image", (object) this.ds, "tblClientOfficeLicenses.Signature", true));
    this.pbLogo.Location = new Point(7, 20);
    this.pbLogo.Name = "pbLogo";
    this.pbLogo.Size = new Size(173, 91);
    this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
    this.pbLogo.TabIndex = 3;
    this.pbLogo.TabStop = false;
    this.ds.DataSetName = "dsClientOfficeLicense";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnNewImage).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnNewImage).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnNewImage).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNewImage).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNewImage).Location = new Point(140, 146);
    ((Control) this.btnNewImage).Name = "btnNewImage";
    ((Control) this.btnNewImage).Size = new Size(40, 40);
    ((Control) this.btnNewImage).TabIndex = 2;
    this.btnNewImage.UseOSThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(143, 190);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(90, 13);
    this.Label5.TabIndex = 7;
    this.Label5.Text = "prior to expiration.";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.Transparent;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDays).Appearance = (AppearanceBase) appearance3;
    ((UltraNumericEditorBase) this.numDays).BackColor = Color.Transparent;
    ((Control) this.numDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClientOfficeLicenses.NumDaysToSendNote", true));
    ((Control) this.numDays).Location = new Point(98, 187);
    this.numDays.MaskInput = "nnnn";
    this.numDays.MaxValue = (object) 9999;
    this.numDays.MGAStyle = MGAStyles.Blue;
    this.numDays.MinValue = (object) 0;
    ((Control) this.numDays).Name = "numDays";
    this.numDays.Nullable = true;
    ((Control) this.numDays).Size = new Size(37, 19);
    ((Control) this.numDays).TabIndex = 6;
    ((UltraControlBase) this.numDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDays).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(10, 190);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(34, 13);
    this.Label4.TabIndex = 27;
    this.Label4.Text = "Days:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.MgaSimpleComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClientOfficeLicenses.UserReceivingNote", true));
    ((UltraGridBase) this.MgaSimpleComboBox1).DataMember = "dtUsers";
    ((UltraGridBase) this.MgaSimpleComboBox1).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DisplayMember = "Name_LastFirst";
    this.MgaSimpleComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DropDownWidth = 350;
    ((Control) this.MgaSimpleComboBox1).Location = new Point(98, 96 /*0x60*/);
    this.MgaSimpleComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox1).Name = "MgaSimpleComboBox1";
    ((Control) this.MgaSimpleComboBox1).Size = new Size(202, 20);
    ((Control) this.MgaSimpleComboBox1).TabIndex = 3;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).ValueMember = "UserGUID";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(10, 100);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(77, 13);
    this.Label3.TabIndex = 26;
    this.Label3.Text = "Send Note To:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(10, 10);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(36, 13);
    this.Label2.TabIndex = 24;
    this.Label2.Text = "Client:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.cboContacts.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboContacts).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClientOfficeLicenses.UserGUID", true));
    ((UltraGridBase) this.cboContacts).DataMember = "tblUsers";
    ((UltraGridBase) this.cboContacts).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboContacts).DisplayMember = "Name_LastFirst";
    this.cboContacts.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboContacts).DropDownWidth = 300;
    ((Control) this.cboContacts).Location = new Point(98, 6);
    this.cboContacts.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboContacts).Name = "cboContacts";
    ((Control) this.cboContacts).Size = new Size(375, 20);
    ((Control) this.cboContacts).TabIndex = 0;
    ((UltraControlBase) this.cboContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboContacts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboContacts).ValueMember = "UserGUID";
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLicenseNum).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtLicenseNum).BackColor = Color.White;
    ((Control) this.txtLicenseNum).DataBindings.Add(new Binding("Text", (object) this.ds, "tblClientOfficeLicenses.LicenseNumber", true));
    ((Control) this.txtLicenseNum).Location = new Point(98, (int) sbyte.MaxValue);
    this.txtLicenseNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLicenseNum).Name = "txtLicenseNum";
    ((Control) this.txtLicenseNum).Size = new Size(133, 19);
    ((Control) this.txtLicenseNum).TabIndex = 4;
    ((UltraControlBase) this.txtLicenseNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLicenseNum).UseOsThemes = (DefaultableBoolean) 2;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClientOfficeLicenses.StateID", true));
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds.lstStates;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 350;
    ((Control) this.cboState).Location = new Point(98, 66);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(202, 20);
    ((Control) this.cboState).TabIndex = 2;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.cboLicenseType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLicenseType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClientOfficeLicenses.LicenseTypeID", true));
    ((UltraGridBase) this.cboLicenseType).DataSource = (object) this.ds.lstLicenseTypes;
    ((UltraDropDownBase) this.cboLicenseType).DisplayMember = "LicenseType";
    this.cboLicenseType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLicenseType).DropDownWidth = 350;
    ((Control) this.cboLicenseType).Location = new Point(98, 36);
    this.cboLicenseType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLicenseType).Name = "cboLicenseType";
    ((Control) this.cboLicenseType).Size = new Size(202, 20);
    ((Control) this.cboLicenseType).TabIndex = 1;
    ((UltraControlBase) this.cboLicenseType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLicenseType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLicenseType).ValueMember = "LicenseTypeID";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(10, 130);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(57, 13);
    this.Label1.TabIndex = 22;
    this.Label1.Text = "License #:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.lblExpires.AutoSize = true;
    this.lblExpires.BackColor = Color.Transparent;
    this.lblExpires.Location = new Point(10, 160 /*0xA0*/);
    this.lblExpires.Name = "lblExpires";
    this.lblExpires.Size = new Size(44, 13);
    this.lblExpires.TabIndex = 20;
    this.lblExpires.Text = "Expires:";
    this.lblExpires.TextAlign = ContentAlignment.MiddleRight;
    this.lblState.AutoSize = true;
    this.lblState.BackColor = Color.Transparent;
    this.lblState.Location = new Point(10, 70);
    this.lblState.Name = "lblState";
    this.lblState.Size = new Size(35, 13);
    this.lblState.TabIndex = 19;
    this.lblState.Text = "State:";
    this.lblState.TextAlign = ContentAlignment.MiddleRight;
    this.lblType.AutoSize = true;
    this.lblType.BackColor = Color.Transparent;
    this.lblType.Location = new Point(10, 40);
    this.lblType.Name = "lblType";
    this.lblType.Size = new Size(34, 13);
    this.lblType.TabIndex = 18;
    this.lblType.Text = "Type:";
    this.lblType.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtExpires.Appearance = (AppearanceBase) appearance5;
    appearance6.AlphaLevel = (short) 14;
    appearance6.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance6.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance6.BackColorAlpha = (Alpha) 2;
    appearance6.BackGradientAlignment = (GradientAlignment) 4;
    appearance6.BackGradientStyle = (GradientStyle) 5;
    appearance6.BorderAlpha = (Alpha) 1;
    appearance6.BorderColor = Color.FromArgb(78, 122, 171);
    appearance6.ForeColor = Color.FromArgb(49, 85, 153);
    appearance6.ForegroundAlpha = (Alpha) 2;
    this.dtExpires.ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.dtExpires).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClientOfficeLicenses.Expires", true));
    this.dtExpires.DateTime = new DateTime(2003, 3, 3, 15, 20, 30, 548);
    ((Control) this.dtExpires).Location = new Point(98, 157);
    this.dtExpires.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtExpires).Name = "dtExpires";
    ((Control) this.dtExpires).Size = new Size(133, 19);
    ((Control) this.dtExpires).TabIndex = 5;
    ((UltraControlBase) this.dtExpires).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtExpires).UseOsThemes = (DefaultableBoolean) 2;
    this.dtExpires.Value = (object) new DateTime(2003, 3, 3, 15, 20, 30, 548);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.ctlZipCode);
    ((Control) this.tabAdditionalInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabAdditionalInfo).Name = "tabAdditionalInfo";
    ((Control) this.tabAdditionalInfo).Size = new Size(727, 235);
    this.ctlZipCode.Address1 = "";
    this.ctlZipCode.Address2 = "";
    ((Control) this.ctlZipCode).BackColor = Color.Transparent;
    this.ctlZipCode.City = "";
    this.ctlZipCode.County = "";
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("State", (object) this.ds, "", true));
    ((Control) this.ctlZipCode).Font = new Font("Tahoma", 8f);
    this.ctlZipCode.ISOCountryCode = "";
    this.ctlZipCode.ISOCountryCodeMember = "";
    this.ctlZipCode.ISOCountryList = (object) null;
    this.ctlZipCode.ISOCountryNameMember = "";
    ((Control) this.ctlZipCode).Location = new Point(24, 20);
    this.ctlZipCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.ctlZipCode).Name = "ctlZipCode";
    this.ctlZipCode.Password = "";
    ((Control) this.ctlZipCode).Size = new Size(254, 171);
    this.ctlZipCode.State = "";
    ((Control) this.ctlZipCode).TabIndex = 3;
    this.ctlZipCode.UserID = "";
    this.ctlZipCode.WebserviceUrl = (string) null;
    this.ctlZipCode.ZipCode = "";
    this.ctlZipCode.ZipCodeExtension = "";
    this.DbSaveUI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.DbSaveUI1.AutoQueryRowCountOnLoad = false;
    this.DbSaveUI1.FreezeEvents = false;
    this.DbSaveUI1.Location = new Point(735, 446);
    this.DbSaveUI1.Name = "DbSaveUI1";
    this.DbSaveUI1.Size = new Size(112 /*0x70*/, 40);
    this.DbSaveUI1.TabIndex = 209;
    this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
    ((UltraControlBase) this.ddLicenseTypes).Cursor = Cursors.Default;
    ((UltraGridBase) this.ddLicenseTypes).DataSource = (object) this.ds.lstLicenseTypes;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "License Type";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 171;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 17;
    ultraGridBand2.Columns.AddRange(new object[18]
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
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddLicenseTypes).DisplayMember = "LicenseType";
    ((Control) this.ddLicenseTypes).Location = new Point(112 /*0x70*/, 96 /*0x60*/);
    ((Control) this.ddLicenseTypes).Name = "ddLicenseTypes";
    ((Control) this.ddLicenseTypes).Size = new Size(189, 56);
    ((Control) this.ddLicenseTypes).TabIndex = 211;
    ((UltraDropDownBase) this.ddLicenseTypes).ValueMember = "LicenseTypeID";
    ((Control) this.ddLicenseTypes).Visible = false;
    this.daClientLicense.DeleteCommand = this.SqlDeleteCommand1;
    this.daClientLicense.InsertCommand = this.SqlInsertCommand1;
    this.daClientLicense.SelectCommand = this.SqlSelectCommand3;
    this.daClientLicense.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblClientOfficeLicenses", new DataColumnMapping[18]
      {
        new DataColumnMapping("ClientOfficeLicenseGUID", "ClientOfficeLicenseGUID"),
        new DataColumnMapping("ClientLocationGUID", "ClientLocationGUID"),
        new DataColumnMapping("LicenseTypeID", "LicenseTypeID"),
        new DataColumnMapping("LicenseNumber", "LicenseNumber"),
        new DataColumnMapping("Expires", "Expires"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("NumDaysToSendNote", "NumDaysToSendNote"),
        new DataColumnMapping("UserReceivingNote", "UserReceivingNote"),
        new DataColumnMapping("Signature", "Signature"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode")
      })
    });
    this.daClientLicense.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblClientOfficeLicenses] WHERE (([ClientOfficeLicenseGUID] = @Original_ClientOfficeLicenseGUID))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ClientOfficeLicenseGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClientOfficeLicenseGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[18]
    {
      new SqlParameter("@ClientOfficeLicenseGUID", SqlDbType.UniqueIdentifier, 0, "ClientOfficeLicenseGUID"),
      new SqlParameter("@ClientLocationGUID", SqlDbType.UniqueIdentifier, 0, "ClientLocationGUID"),
      new SqlParameter("@LicenseTypeID", SqlDbType.TinyInt, 0, "LicenseTypeID"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 0, "LicenseNumber"),
      new SqlParameter("@Expires", SqlDbType.DateTime, 0, "Expires"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 0, "UserGUID"),
      new SqlParameter("@NumDaysToSendNote", SqlDbType.Int, 0, "NumDaysToSendNote"),
      new SqlParameter("@UserReceivingNote", SqlDbType.UniqueIdentifier, 0, "UserReceivingNote"),
      new SqlParameter("@Signature", SqlDbType.Image, 0, "Signature"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@State", SqlDbType.Char, 0, "State"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode")
    });
    this.SqlSelectCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand3.CommandText");
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ClientLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ClientLocationGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[19]
    {
      new SqlParameter("@ClientOfficeLicenseGUID", SqlDbType.UniqueIdentifier, 0, "ClientOfficeLicenseGUID"),
      new SqlParameter("@ClientLocationGUID", SqlDbType.UniqueIdentifier, 0, "ClientLocationGUID"),
      new SqlParameter("@LicenseTypeID", SqlDbType.TinyInt, 0, "LicenseTypeID"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 0, "LicenseNumber"),
      new SqlParameter("@Expires", SqlDbType.DateTime, 0, "Expires"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 0, "UserGUID"),
      new SqlParameter("@NumDaysToSendNote", SqlDbType.Int, 0, "NumDaysToSendNote"),
      new SqlParameter("@UserReceivingNote", SqlDbType.UniqueIdentifier, 0, "UserReceivingNote"),
      new SqlParameter("@Signature", SqlDbType.Image, 0, "Signature"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@State", SqlDbType.Char, 0, "State"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@Original_ClientOfficeLicenseGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClientOfficeLicenseGUID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.ugLicenses).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugLicenses).DataSource = (object) this.ds.tblClientOfficeLicenses;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 0;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 159;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 1;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 226;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 2;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 139;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "License #";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 3;
    ultraGridColumn25.Width = 212;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.Format = "d";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 4;
    ultraGridColumn26.Width = 196;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 5;
    ultraGridColumn27.Width = 99;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 6;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 173;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Days Prior to Send Note";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 8;
    ultraGridColumn29.Width = 147;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "User Receiving Note";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 7;
    ultraGridColumn30.Style = (ColumnStyle) 6;
    ultraGridColumn30.Width = 197;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 9;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 79;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 10;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 52;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 11;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 55;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 12;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 58;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 13;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 62;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 14;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 66;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 15;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 76;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 81;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 17;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 89;
    ultraGridBand3.Columns.AddRange(new object[18]
    {
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39
    });
    ((UltraGridBase) this.ugLicenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance8.BackColor = Color.LightSteelBlue;
    appearance8.FontData.SizeInPoints = 10f;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.Transparent;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((Control) this.ugLicenses).Enabled = false;
    ((Control) this.ugLicenses).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugLicenses).Location = new Point(0, 12);
    ((Control) this.ugLicenses).Name = "ugLicenses";
    ((Control) this.ugLicenses).Size = new Size(853, 217);
    ((Control) this.ugLicenses).TabIndex = 212;
    ((Control) this.ugLicenses).Text = "Available Licenses";
    ((UltraControlBase) this.ugLicenses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLicenses).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.err.DataMember = "";
    ((UltraControlBase) this.ddUser).Cursor = Cursors.Default;
    ((UltraGridBase) this.ddUser).DataMember = "dtUsers";
    ((UltraGridBase) this.ddUser).DataSource = (object) this.ds;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 1;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 0;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn40,
      (object) ultraGridColumn41
    });
    ((UltraGridBase) this.ddUser).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddUser).DisplayMember = "Name_LastFirst";
    ((Control) this.ddUser).Location = new Point(295, 82);
    ((Control) this.ddUser).Name = "ddUser";
    ((Control) this.ddUser).Size = new Size(189, 56);
    ((Control) this.ddUser).TabIndex = 213;
    ((UltraDropDownBase) this.ddUser).ValueMember = "UserGUID";
    ((Control) this.ddUser).Visible = false;
    ((Control) this.tabLocationInfo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.tabLicense);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.tabAdditionalInfo);
    ((Control) this.tabLocationInfo).Location = new Point(0, 233);
    ((Control) this.tabLocationInfo).Name = "tabLocationInfo";
    ((UltraTabControlBase) this.tabLocationInfo).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabLocationInfo).Size = new Size(729, 262);
    ((Control) this.tabLocationInfo).TabIndex = 214;
    ((UltraTabControlBase) this.tabLocationInfo).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.tabLocationInfo).TabPadding = new Size(5, 3);
    appearance15.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance15.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance15;
    ultraTab1.Key = "tabLicense";
    ultraTab1.TabPage = this.tabLicense;
    ultraTab1.Text = "License Info";
    ultraTab2.TabPage = this.tabAdditionalInfo;
    ultraTab2.Text = "Add'l Info";
    ((UltraTabControlBase) this.tabLocationInfo).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.tabLocationInfo).TabSize = new Size(110, 0);
    ((UltraTabControlBase) this.tabLocationInfo).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(727, 235);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(853, 498);
    this.Controls.Add((Control) this.tabLocationInfo);
    this.Controls.Add((Control) this.ddUser);
    this.Controls.Add((Control) this.ddLicenseTypes);
    this.Controls.Add((Control) this.ugLicenses);
    this.Controls.Add((Control) this.DbSaveUI1);
    this.Name = nameof (frmClientOfficeLicenses);
    this.Text = "Client License";
    ((Control) this.tabLicense).ResumeLayout(false);
    ((Control) this.tabLicense).PerformLayout();
    ((ISupportInitialize) this.gbSignature).EndInit();
    ((Control) this.gbSignature).ResumeLayout(false);
    ((Control) this.gbSignature).PerformLayout();
    ((ISupportInitialize) this.pbLogo).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnNewImage).EndInit();
    ((ISupportInitialize) this.numDays).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).EndInit();
    ((ISupportInitialize) this.cboContacts).EndInit();
    ((ISupportInitialize) this.txtLicenseNum).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboLicenseType).EndInit();
    ((ISupportInitialize) this.dtExpires).EndInit();
    ((Control) this.tabAdditionalInfo).ResumeLayout(false);
    ((ISupportInitialize) this.ddLicenseTypes).EndInit();
    ((ISupportInitialize) this.ugLicenses).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddUser).EndInit();
    ((ISupportInitialize) this.tabLocationInfo).EndInit();
    ((Control) this.tabLocationInfo).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmClientOfficeLicenses(Guid officeGuid)
  {
    this.Load += new EventHandler(this.frmClientOfficeLicenses_Load);
    this.changedOfficeImages = new List<Guid>();
    this.InitializeComponent();
    this._officeGuid = officeGuid;
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblClientOfficeLicenses.TableName];
  }

  private void frmClientOfficeLicenses_Load(object sender, EventArgs e)
  {
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daClientLicense, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    dsClientOfficeLicense.dtUsersRow row1 = this.ds.dtUsers.NewdtUsersRow();
    row1.UserGUID = Guid.Empty;
    row1.Name_LastFirst = string.Empty;
    this.ds.dtUsers.AdddtUsersRow(row1);
    try
    {
      foreach (dsClientOfficeLicense.tblUsersRow row2 in this.ds.tblUsers.Rows)
      {
        dsClientOfficeLicense.dtUsersRow row3 = this.ds.dtUsers.NewdtUsersRow();
        row3.UserGUID = row2.UserGUID;
        row3.Name_LastFirst = row2.Name_LastFirst;
        this.ds.dtUsers.AdddtUsersRow(row3);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Location FROM tblClientOffices WHERE OfficeGUID = @offGUID", new object[2]
    {
      (object) "@offGUID",
      (object) this._officeGuid
    });
    dsClientOfficeLicense.tblUsersRow row4 = this.ds.tblUsers.NewtblUsersRow();
    row4.UserGUID = Guid.Empty;
    row4.Name_LastFirst = str;
    this.ds.tblUsers.AddtblUsersRow(row4);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[5]
    {
      "lstStates",
      "lstLicenseTypes",
      "dtUsers",
      "tblUsers",
      "tblClientOfficeLicenses"
    }, "GetClientOfficeLicensesData", new object[2]
    {
      (object) "@ClientLocationGUID",
      (object) this._officeGuid
    });
    this.DbSaveUI1.EditStyle = EditStyle.ShowEditButton;
    this.DbSaveUI1.UIState = this.ds.tblClientOfficeLicenses.Rows.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    ((Control) this.ugLicenses).Text = str;
    ((ControlBase) this.btnNewImage).Appearance.Image = (object) ImageCache.Instance.Open;
    this.DbSaveUI1.UIState = this.ds.tblClientOfficeLicenses.Rows.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    ((Control) this.ugLicenses).Enabled = true;
  }

  private void DbSaveUI1_ClickedNew(object sender, EventArgs e)
  {
    this.bmb.AddNew();
    try
    {
      foreach (Control control in ((Control) this.tabLicense).Controls)
      {
        if (control is MGASimpleComboBox mgaSimpleComboBox)
        {
          mgaSimpleComboBox.SelectedIndex = -1;
          mgaSimpleComboBox.SelectedIndex = -1;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.ctlZipCode.Clear();
    dsClientOfficeLicense.tblClientOfficeLicensesRow row = (dsClientOfficeLicense.tblClientOfficeLicensesRow) ((DataRowView) this.bmb.Current).Row;
    row.ClientLocationGUID = this._officeGuid;
    row.ClientOfficeLicenseGUID = Guid.NewGuid();
  }

  private bool ValidForm()
  {
    bool flag = true;
    try
    {
      foreach (Control control in ((Control) this.tabLicense).Controls)
      {
        switch (control)
        {
          case MGASimpleComboBox _:
          case MGATextBox _:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Text, string.Empty, false) == 0)
            {
              this.err.SetError(control, "Required");
              flag = false;
              continue;
            }
            this.err.SetError(control, string.Empty);
            continue;
          case MGADateTimePicker mgaDateTimePicker:
            if (mgaDateTimePicker.Value == null)
            {
              this.err.SetError(control, "Required");
              flag = false;
              continue;
            }
            this.err.SetError(control, string.Empty);
            continue;
          default:
            continue;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return flag;
  }

  private void DbSaveUI1_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      int position = this.bmb.Position;
      this.bmb.EndCurrentEdit();
      try
      {
        if (this.ctlZipCode.ISOCountryCode.Length > 0)
          this.ds.tblClientOfficeLicenses[this.bmb.Position].ISOCountryCode = this.ctlZipCode.ISOCountryCode;
        else
          this.ds.tblClientOfficeLicenses[this.bmb.Position].SetISOCountryCodeNull();
        if (this.ctlZipCode.Address1.Length > 0)
          this.ds.tblClientOfficeLicenses[this.bmb.Position].Address1 = this.ctlZipCode.Address1;
        else
          this.ds.tblClientOfficeLicenses[this.bmb.Position].SetAddress1Null();
        if (this.ctlZipCode.Address2.Length > 0)
          this.ds.tblClientOfficeLicenses[this.bmb.Position].Address2 = this.ctlZipCode.Address2;
        else
          this.ds.tblClientOfficeLicenses[this.bmb.Position].SetAddress2Null();
        if (this.ctlZipCode.City.Length > 0)
          this.ds.tblClientOfficeLicenses[this.bmb.Position].City = this.ctlZipCode.City;
        else
          this.ds.tblClientOfficeLicenses[this.bmb.Position].SetCityNull();
        if (this.ctlZipCode.State.Length > 0)
          this.ds.tblClientOfficeLicenses[this.bmb.Position].State = this.ctlZipCode.State;
        else
          this.ds.tblClientOfficeLicenses[this.bmb.Position].SetStateNull();
        if (this.ctlZipCode.ZipCode.Length > 0)
          this.ds.tblClientOfficeLicenses[this.bmb.Position].ZipCode = this.ctlZipCode.ZipCode;
        else
          this.ds.tblClientOfficeLicenses[this.bmb.Position].SetZipCodeNull();
        if (this.ctlZipCode.ZipCodeExtension.Length > 0)
          this.ds.tblClientOfficeLicenses[this.bmb.Position].ZipPlus = this.ctlZipCode.ZipCodeExtension;
        else
          this.ds.tblClientOfficeLicenses[this.bmb.Position].SetZipPlusNull();
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daClientLicense, (DataTable) this.ds.tblClientOfficeLicenses);
        this.SetActiveGridRow(position);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      ((Control) this.ugLicenses).Enabled = true;
    }
  }

  private void DbSaveUI1_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.bmb.CancelCurrentEdit();
    try
    {
      foreach (Control control in ((Control) this.tabLicense).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.ds.tblClientOfficeLicenses.Rows.Count == 0)
      this.DbSaveUI1.UIState = UIState.NoRecordsNotEditing;
    else
      this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
  }

  private void DbSaveUI1_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this license?", "Delete License?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      this.ds.tblClientOfficeLicenses[this.bmb.Position].Delete();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daClientLicense, (DataTable) this.ds.tblClientOfficeLicenses);
      this.SetActiveGridRow(this.ds.tblClientOfficeLicenses.Count - 1);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void ugLicenses_AfterRowActivate(object sender, EventArgs e)
  {
    Database.MoveTo((object) (Guid) ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["ClientOfficeLicenseGUID"].Value, "ClientOfficeLicenseGUID", (DataTable) this.ds.tblClientOfficeLicenses, this.bmb);
    this.ctlZipCode.Clear();
    if (this.bmb.Position == -1)
      return;
    if (this.ctlZipCode.ISOCountryCode.Length > 0)
      this.ds.tblClientOfficeLicenses[this.bmb.Position].ISOCountryCode = this.ctlZipCode.ISOCountryCode;
    if (!this.ds.tblClientOfficeLicenses[this.bmb.Position].IsISOCountryCodeNull())
      this.ctlZipCode.ISOCountryCode = this.ds.tblClientOfficeLicenses[this.bmb.Position].ISOCountryCode;
    if (!this.ds.tblClientOfficeLicenses[this.bmb.Position].IsAddress1Null())
      this.ctlZipCode.Address1 = this.ds.tblClientOfficeLicenses[this.bmb.Position].Address1;
    if (!this.ds.tblClientOfficeLicenses[this.bmb.Position].IsAddress2Null())
      this.ctlZipCode.Address2 = this.ds.tblClientOfficeLicenses[this.bmb.Position].Address2;
    if (!this.ds.tblClientOfficeLicenses[this.bmb.Position].IsCityNull())
      this.ctlZipCode.City = this.ds.tblClientOfficeLicenses[this.bmb.Position].City;
    if (!this.ds.tblClientOfficeLicenses[this.bmb.Position].IsCountyNull())
      this.ctlZipCode.County = this.ds.tblClientOfficeLicenses[this.bmb.Position].County;
    if (!this.ds.tblClientOfficeLicenses[this.bmb.Position].IsStateNull())
      this.ctlZipCode.State = this.ds.tblClientOfficeLicenses[this.bmb.Position].State;
    if (!this.ds.tblClientOfficeLicenses[this.bmb.Position].IsZipCodeNull())
      this.ctlZipCode.ZipCode = this.ds.tblClientOfficeLicenses[this.bmb.Position].ZipCode;
    if (this.ds.tblClientOfficeLicenses[this.bmb.Position].IsZipPlusNull())
      return;
    this.ctlZipCode.ZipCodeExtension = this.ds.tblClientOfficeLicenses[this.bmb.Position].ZipPlus;
  }

  private void DbSaveUI1_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ugLicenses).Enabled = this.DbSaveUI1.UIState != UIState.Editing;
    ((Control) this.gbSignature).Enabled = this.DbSaveUI1.UIState == UIState.Editing;
    bool flag = this.DbSaveUI1.UIState == UIState.Editing;
    try
    {
      foreach (Control control in ((Control) this.tabLicense).Controls)
        control.Enabled = flag;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.tabAdditionalInfo).Controls)
        control.Enabled = flag;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public dsClientOfficeLicense.tblClientOfficeLicensesRow CurrentClientOfficeRow
  {
    get => (dsClientOfficeLicense.tblClientOfficeLicensesRow) ((DataRowView) this.bmb.Current).Row;
  }

  private void SetImage(PictureBox pb, byte[] bytes)
  {
    if (pb != null && pb.Image != null)
    {
      Image image = pb.Image;
      pb.Image = (Image) null;
      image.Dispose();
    }
    if (bytes == null || bytes.Length <= 0)
      return;
    using (MemoryStream memoryStream = new MemoryStream(bytes))
      pb.Image = Image.FromStream((Stream) memoryStream);
  }

  private void btnNewImage_Click(object sender, EventArgs e)
  {
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      openFileDialog.Title = "Please select a signature";
      openFileDialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK || !File.Exists(openFileDialog.FileName) || this.ds.tblClientOfficeLicenses.Rows.Count <= 0 || this.CurrentClientOfficeRow == null)
        return;
      this.CurrentClientOfficeRow.Signature = File.ReadAllBytes(openFileDialog.FileName);
      this.SetImage(this.pbLogo, this.CurrentClientOfficeRow.Signature);
      if (this.changedOfficeImages.Contains(this.CurrentClientOfficeRow.ClientOfficeLicenseGUID))
        return;
      this.changedOfficeImages.Add(this.CurrentClientOfficeRow.ClientOfficeLicenseGUID);
    }
  }

  private void SetActiveGridRow(int bPosition)
  {
    if (bPosition == -1)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLicenses).Rows)
    {
      if (((Guid) row.Cells["ClientOfficeLicenseGUID"].Value).Equals(this.ds.tblClientOfficeLicenses[bPosition].ClientOfficeLicenseGUID))
      {
        ((UltraGridBase) this.ugLicenses).ActiveRow = row;
        break;
      }
    }
  }
}
