// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerLicenses
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

[SecureResource("{97F7C4C5-50BB-4eb1-8B3A-D671AF498FB6}", "Access Producer Licenses Screen", "Controls access to the Producer Licenses screen.", "Producers")]
[DocumentFolderFilter("Producer Licenses Administration")]
public class frmProducerLicenses : Form, ISupportNoteSystem, ISupportDocumentSystem
{
  private IContainer components;
  private SqlConnection cnSQL;
  protected SqlDataAdapter daProdLicense;
  private Label lblExpires;
  private Label lblState;
  private Label lblType;
  private UltraLabel lblProducerLocation;
  private dsProducerLicenses dsLicense;
  protected ErrorProvider errProvider;
  private Label Label2;
  private UltraDropDown ddProducerContacts;
  private UltraDropDown ddLicenseTypes;
  internal const string OpenForm = "{97F7C4C5-50BB-4eb1-8B3A-D671AF498FB6}";
  private Guid _locationGuid;
  private frmProducerLicenses.FormModes _FormMode;
  private bool _refreshContacts;
  private Guid _CurrentProducerContactGUID;
  private Guid _CurrProducerLicenseGuid;
  private string _CurrProducerLicenseNum;
  private bool _showAllContacts;
  private static dsProducerLicenses.tblProducerContactsDataTable _contactCache = (dsProducerLicenses.tblProducerContactsDataTable) null;
  private MemoryStream _gridLayout;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpLicenseInfo")]
  protected virtual UltraGroupBox grpLicenseInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLicenseType")]
  protected virtual MGASimpleComboBox cboLicenseType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  protected virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLicenseNum")]
  protected virtual MGATextBox txtLicenseNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtExpires")]
  protected virtual MGADateTimePicker dtExpires { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugLicenses
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

  [field: AccessedThroughProperty("cboContacts")]
  protected virtual MGASimpleComboBox cboContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI DbSaveUI1
  {
    get => this._DbSaveUI1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.DbSaveUI1_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSaveUI1_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.DbSaveUI1_UIStateChanged);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSaveUI1_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSaveUI1_ClickingCancel);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.DbSaveUI1_ClickingDelete);
      EventHandler eventHandler3 = new EventHandler(this.DbSaveUI1_ClickedDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_1 = this._DbSaveUI1;
      if (dbSaveUi1_1 != null)
      {
        dbSaveUi1_1.ClickedCancel -= eventHandler1;
        dbSaveUi1_1.ClickingSave -= cancelEventHandler1;
        dbSaveUi1_1.UIStateChanged -= eventHandler2;
        dbSaveUi1_1.ClickingNew -= cancelEventHandler2;
        dbSaveUi1_1.ClickingCancel -= cancelEventHandler3;
        dbSaveUi1_1.ClickingDelete -= cancelEventHandler4;
        dbSaveUi1_1.ClickedDelete -= eventHandler3;
      }
      this._DbSaveUI1 = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_2 = this._DbSaveUI1;
      if (dbSaveUi1_2 == null)
        return;
      dbSaveUi1_2.ClickedCancel += eventHandler1;
      dbSaveUi1_2.ClickingSave += cancelEventHandler1;
      dbSaveUi1_2.UIStateChanged += eventHandler2;
      dbSaveUi1_2.ClickingNew += cancelEventHandler2;
      dbSaveUi1_2.ClickingCancel += cancelEventHandler3;
      dbSaveUi1_2.ClickingDelete += cancelEventHandler4;
      dbSaveUi1_2.ClickedDelete += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  protected virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLine")]
  protected virtual MGASimpleComboBox cboLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboSendDiaryTo")]
  protected virtual MGAComboBox cboSendDiaryTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelSearch")]
  private virtual UltraGroupBox panelSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spinner")]
  public virtual PictureBox spinner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelSearchText")]
  private virtual Label labelSearchText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("zipLicenses")]
  protected virtual MGA_ZipCodeResolver zipLicenses { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  protected virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducers")]
  protected virtual MGASimpleComboBox cboProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLicenseStatus")]
  protected virtual MGASimpleComboBox cboLicenseStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLicenseState")]
  private virtual Label lblLicenseState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtIssued")]
  protected virtual MGADateTimePicker dtIssued { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDefaultSLLicense")]
  protected virtual MGACheckBox chkDefaultSLLicense { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDefaultLicense")]
  protected virtual MGACheckBox chkDefaultLicense { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmProducerLicenses));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name_LastFirst");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstLicenseTypes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LicenseTypeID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LicenseType");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("lstLicenseTypestblProducerLicenses");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstLicenseTypestblProducerLicenses", 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProducerLicenseGUID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerContactGUID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LicenseTypeID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Expires");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DefaultLicense");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("SendDiaryTo");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("AltContactName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("LicenseCity");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("LicenseStateID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("LicenseZipCode");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("LicenseCounty");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LicenseZipCodeExt");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("LicenseCountryCode");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("LicenseAddress1");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("LicenseAddress2");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Issued");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("DefaultSLLicense");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblProducerContacts", -1);
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ProducerContactGUID");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Name");
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblProducerLicenses", -1);
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ProducerLicenseGUID", -1, (object) "ddLicenseTypes");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("ProducerContactGUID", -1, (object) "ddProducerContacts");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("LicenseTypeID", -1, (object) "ddLicenseTypes");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Expires");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("DefaultLicense");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("SendDiaryTo");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("AltContactName");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("LicenseCity");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("LicenseStateID");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("LicenseZipCode");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("LicenseCounty");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("LicenseZipCodeExt");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("LicenseCountryCode");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("LicenseAddress1");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("LicenseAddress2");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("Issued");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("DefaultSLLicense");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.cnSQL = new SqlConnection();
    this.daProdLicense = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.grpLicenseInfo = new UltraGroupBox();
    this.chkDefaultSLLicense = new MGACheckBox();
    this.dsLicense = new dsProducerLicenses();
    this.Label8 = new Label();
    this.dtIssued = new MGADateTimePicker();
    this.cboLicenseStatus = new MGASimpleComboBox();
    this.lblLicenseState = new Label();
    this.Label6 = new Label();
    this.cboProducers = new MGASimpleComboBox();
    this.cboLine = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.MgaTextBox1 = new MGATextBox();
    this.Label4 = new Label();
    this.cboSendDiaryTo = new MGAComboBox();
    this.Label3 = new Label();
    this.chkDefaultLicense = new MGACheckBox();
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
    this.zipLicenses = new MGA_ZipCodeResolver();
    this.lblProducerLocation = new UltraLabel();
    this.errProvider = new ErrorProvider(this.components);
    this.DbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.panelSearch = new UltraGroupBox();
    this.spinner = new PictureBox();
    this.labelSearchText = new Label();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.ddLicenseTypes = new UltraDropDown();
    this.ddProducerContacts = new UltraDropDown();
    this.ugLicenses = new UltraGrid();
    Label label = new Label();
    ((ISupportInitialize) this.grpLicenseInfo).BeginInit();
    ((Control) this.grpLicenseInfo).SuspendLayout();
    ((ISupportInitialize) this.chkDefaultSLLicense).BeginInit();
    this.dsLicense.BeginInit();
    ((ISupportInitialize) this.dtIssued).BeginInit();
    ((ISupportInitialize) this.cboLicenseStatus).BeginInit();
    ((ISupportInitialize) this.cboProducers).BeginInit();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.cboSendDiaryTo).BeginInit();
    ((ISupportInitialize) this.chkDefaultLicense).BeginInit();
    ((ISupportInitialize) this.cboContacts).BeginInit();
    ((ISupportInitialize) this.txtLicenseNum).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboLicenseType).BeginInit();
    ((ISupportInitialize) this.dtExpires).BeginInit();
    ((ISupportInitialize) this.errProvider).BeginInit();
    ((ISupportInitialize) this.panelSearch).BeginInit();
    ((Control) this.panelSearch).SuspendLayout();
    ((ISupportInitialize) this.spinner).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.ddLicenseTypes).BeginInit();
    ((ISupportInitialize) this.ddProducerContacts).BeginInit();
    ((ISupportInitialize) this.ugLicenses).BeginInit();
    this.SuspendLayout();
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(28, 17);
    label.Name = "Label27";
    label.Size = new Size(264, 19);
    label.TabIndex = 1;
    label.Text = "Loading All Contacts ... Please Wait.";
    this.cnSQL.ConnectionString = "Data Source=63.241.24.168,1433;Initial Catalog=Preferred_Test;User ID=Preferred_Test";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daProdLicense.DeleteCommand = this.SqlDeleteCommand1;
    this.daProdLicense.InsertCommand = this.SqlInsertCommand1;
    this.daProdLicense.SelectCommand = this.SqlSelectCommand3;
    this.daProdLicense.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerLicenses", new DataColumnMapping[23]
      {
        new DataColumnMapping("ProducerLocationGUID", "ProducerLocationGUID"),
        new DataColumnMapping("LicenseTypeID", "LicenseTypeID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("Expires", "Expires"),
        new DataColumnMapping("LicenseNumber", "LicenseNumber"),
        new DataColumnMapping("ProducerLicenseGUID", "ProducerLicenseGUID"),
        new DataColumnMapping("ProducerContactGUID", "ProducerContactGUID"),
        new DataColumnMapping("DefaultLicense", "DefaultLicense"),
        new DataColumnMapping("SendDiaryTo", "SendDiaryTo"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("AltContactName", "AltContactName"),
        new DataColumnMapping("LicenseCity", "LicenseCity"),
        new DataColumnMapping("LicenseStateID", "LicenseStateID"),
        new DataColumnMapping("LicenseZipCode", "LicenseZipCode"),
        new DataColumnMapping("LicenseCounty", "LicenseCounty"),
        new DataColumnMapping("LicenseZipCodeExt", "LicenseZipCodeExt"),
        new DataColumnMapping("LicenseCountryCode", "LicenseCountryCode"),
        new DataColumnMapping("LicenseAddress1", "LicenseAddress1"),
        new DataColumnMapping("LicenseAddress2", "LicenseAddress2"),
        new DataColumnMapping("ProducerGuid", "ProducerGuid"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Issued", "Issued"),
        new DataColumnMapping("DefaultSLLicense", "DefaultSLLicense")
      })
    });
    this.daProdLicense.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblProducerLicenses] WHERE (([ProducerLicenseGUID] = @Original_ProducerLicenseGUID))";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ProducerLicenseGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLicenseGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[23]
    {
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGUID"),
      new SqlParameter("@LicenseTypeID", SqlDbType.TinyInt, 1, "LicenseTypeID"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@Expires", SqlDbType.DateTime, 8, "Expires"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 20, "LicenseNumber"),
      new SqlParameter("@ProducerLicenseGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLicenseGUID"),
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGUID"),
      new SqlParameter("@DefaultLicense", SqlDbType.Bit, 1, "DefaultLicense"),
      new SqlParameter("@SendDiaryTo", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SendDiaryTo"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      new SqlParameter("@AltContactName", SqlDbType.VarChar, 75, "AltContactName"),
      new SqlParameter("@LicenseCity", SqlDbType.VarChar, 50, "LicenseCity"),
      new SqlParameter("@LicenseStateID", SqlDbType.Char, 2, "LicenseStateID"),
      new SqlParameter("@LicenseZipCode", SqlDbType.Char, 5, "LicenseZipCode"),
      new SqlParameter("@LicenseCounty", SqlDbType.VarChar, 50, "LicenseCounty"),
      new SqlParameter("@LicenseZipCodeExt", SqlDbType.VarChar, 4, "LicenseZipCodeExt"),
      new SqlParameter("@LicenseCountryCode", SqlDbType.Char, 3, "LicenseCountryCode"),
      new SqlParameter("@LicenseAddress1", SqlDbType.VarChar, 250, "LicenseAddress1"),
      new SqlParameter("@LicenseAddress2", SqlDbType.VarChar, 250, "LicenseAddress2"),
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGuid"),
      new SqlParameter("@StatusID", SqlDbType.Int, 4, "StatusID"),
      new SqlParameter("@Issued", SqlDbType.DateTime, 8, "Issued"),
      new SqlParameter("@DefaultSLLicense", SqlDbType.Bit, 1, "DefaultSLLicense")
    });
    this.SqlSelectCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand3.CommandText");
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[24]
    {
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGUID"),
      new SqlParameter("@LicenseTypeID", SqlDbType.TinyInt, 1, "LicenseTypeID"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@Expires", SqlDbType.DateTime, 8, "Expires"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 20, "LicenseNumber"),
      new SqlParameter("@ProducerLicenseGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLicenseGUID"),
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGUID"),
      new SqlParameter("@DefaultLicense", SqlDbType.Bit, 1, "DefaultLicense"),
      new SqlParameter("@SendDiaryTo", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SendDiaryTo"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      new SqlParameter("@AltContactName", SqlDbType.VarChar, 75, "AltContactName"),
      new SqlParameter("@LicenseCity", SqlDbType.VarChar, 50, "LicenseCity"),
      new SqlParameter("@LicenseStateID", SqlDbType.Char, 2, "LicenseStateID"),
      new SqlParameter("@LicenseZipCode", SqlDbType.Char, 5, "LicenseZipCode"),
      new SqlParameter("@LicenseCounty", SqlDbType.VarChar, 50, "LicenseCounty"),
      new SqlParameter("@LicenseZipCodeExt", SqlDbType.VarChar, 4, "LicenseZipCodeExt"),
      new SqlParameter("@LicenseCountryCode", SqlDbType.Char, 3, "LicenseCountryCode"),
      new SqlParameter("@LicenseAddress1", SqlDbType.VarChar, 250, "LicenseAddress1"),
      new SqlParameter("@LicenseAddress2", SqlDbType.VarChar, 250, "LicenseAddress2"),
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGuid"),
      new SqlParameter("@StatusID", SqlDbType.Int, 4, "StatusID"),
      new SqlParameter("@Issued", SqlDbType.DateTime, 8, "Issued"),
      new SqlParameter("@DefaultSLLicense", SqlDbType.Bit, 1, "DefaultSLLicense"),
      new SqlParameter("@Original_ProducerLicenseGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLicenseGUID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.grpLicenseInfo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.grpLicenseInfo.BackColorInternal = Color.Transparent;
    appearance1.BackColor = Color.FromArgb(246, 250, 253);
    appearance1.BackColorDisabled = Color.FromArgb(246, 250, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpLicenseInfo.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.chkDefaultSLLicense);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.Label8);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.dtIssued);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.cboLicenseStatus);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.lblLicenseState);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.Label6);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.cboProducers);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.cboLine);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.Label5);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.Label4);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.cboSendDiaryTo);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.Label3);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.chkDefaultLicense);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.Label2);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.cboContacts);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.txtLicenseNum);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.cboState);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.cboLicenseType);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.Label1);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.lblExpires);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.lblState);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.lblType);
    ((Control) this.grpLicenseInfo).Controls.Add((Control) this.dtExpires);
    ((Control) this.grpLicenseInfo).Enabled = false;
    ((Control) this.grpLicenseInfo).Location = new Point(7, 402);
    ((Control) this.grpLicenseInfo).Name = "grpLicenseInfo";
    ((Control) this.grpLicenseInfo).Size = new Size(582, 225);
    ((Control) this.grpLicenseInfo).TabIndex = 0;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDefaultSLLicense).Appearance = (AppearanceBase) appearance2;
    ((Control) this.chkDefaultSLLicense).DataBindings.Add(new Binding("Checked", (object) this.dsLicense, "tblProducerLicenses.DefaultSLLicense", true));
    ((UltraToggleEditorBase) this.chkDefaultSLLicense).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDefaultSLLicense).Location = new Point(434, 193);
    ((Control) this.chkDefaultSLLicense).Name = "chkDefaultSLLicense";
    ((Control) this.chkDefaultSLLicense).Size = new Size(112 /*0x70*/, 21);
    ((Control) this.chkDefaultSLLicense).TabIndex = 222;
    ((UltraToggleEditorBase) this.chkDefaultSLLicense).Text = "Default SL License";
    ((UltraControlBase) this.chkDefaultSLLicense).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDefaultSLLicense).UseOsThemes = (DefaultableBoolean) 2;
    this.dsLicense.DataSetName = "dsProducerLicenses";
    this.dsLicense.Locale = new CultureInfo("en-US");
    this.dsLicense.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(365, 107);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(43, 13);
    this.Label8.TabIndex = 221;
    this.Label8.Text = "Issued:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtIssued.Appearance = (AppearanceBase) appearance3;
    appearance4.AlphaLevel = (short) 14;
    appearance4.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance4.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance4.BackColorAlpha = (Alpha) 2;
    appearance4.BackGradientAlignment = (GradientAlignment) 4;
    appearance4.BackGradientStyle = (GradientStyle) 5;
    appearance4.BorderAlpha = (Alpha) 1;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    appearance4.ForeColor = Color.FromArgb(49, 85, 153);
    appearance4.ForegroundAlpha = (Alpha) 2;
    this.dtIssued.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dtIssued).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.Issued", true));
    this.dtIssued.DateTime = new DateTime(2003, 3, 3, 15, 20, 30, 548);
    ((Control) this.dtIssued).Location = new Point(423, 103);
    this.dtIssued.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtIssued).Name = "dtIssued";
    ((Control) this.dtIssued).Size = new Size(133, 20);
    ((Control) this.dtIssued).TabIndex = 8;
    ((UltraControlBase) this.dtIssued).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtIssued).UseOsThemes = (DefaultableBoolean) 2;
    this.dtIssued.Value = (object) new DateTime(2003, 3, 3, 15, 20, 30, 548);
    this.cboLicenseStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLicenseStatus).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.StatusID", true));
    ((UltraGridBase) this.cboLicenseStatus).DataMember = "lstProducerLicenseStatus";
    ((UltraGridBase) this.cboLicenseStatus).DataSource = (object) this.dsLicense;
    ((UltraDropDownBase) this.cboLicenseStatus).DisplayMember = "Description";
    this.cboLicenseStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLicenseStatus).Location = new Point(114, 133);
    this.cboLicenseStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLicenseStatus).Name = "cboLicenseStatus";
    ((Control) this.cboLicenseStatus).Size = new Size(190, 21);
    ((Control) this.cboLicenseStatus).TabIndex = 4;
    ((UltraControlBase) this.cboLicenseStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLicenseStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLicenseStatus).ValueMember = "StatusID";
    this.lblLicenseState.AutoSize = true;
    this.lblLicenseState.BackColor = Color.Transparent;
    this.lblLicenseState.Location = new Point(30, 137);
    this.lblLicenseState.Name = "lblLicenseState";
    this.lblLicenseState.Size = new Size(80 /*0x50*/, 13);
    this.lblLicenseState.TabIndex = 219;
    this.lblLicenseState.Text = "License Status:";
    this.lblLicenseState.TextAlign = ContentAlignment.MiddleRight;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(30, 47);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(54, 13);
    this.Label6.TabIndex = 217;
    this.Label6.Text = "Producer:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.cboProducers.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducers).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.ProducerGuid", true));
    ((UltraGridBase) this.cboProducers).DataMember = "dtProducers";
    ((UltraGridBase) this.cboProducers).DataSource = (object) this.dsLicense;
    ((UltraDropDownBase) this.cboProducers).DisplayMember = "ProducerName";
    this.cboProducers.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducers).DropDownWidth = 550;
    ((Control) this.cboProducers).Location = new Point(114, 43);
    this.cboProducers.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducers).Name = "cboProducers";
    ((Control) this.cboProducers).Size = new Size(442, 21);
    ((Control) this.cboProducers).TabIndex = 1;
    ((UltraControlBase) this.cboProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducers).ValueMember = "ProducerGuid";
    this.cboLine.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLine).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.LineGuid", true));
    ((UltraGridBase) this.cboLine).DataMember = "lstLines";
    ((UltraGridBase) this.cboLine).DataSource = (object) this.dsLicense;
    ((UltraDropDownBase) this.cboLine).DisplayMember = "LineName";
    this.cboLine.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLine).Location = new Point(114, 193);
    this.cboLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(190, 21);
    ((Control) this.cboLine).TabIndex = 6;
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLine).ValueMember = "LineGUID";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(30, 197);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(30, 13);
    this.Label5.TabIndex = 215;
    this.Label5.Text = "Line:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.dsLicense, "tblProducerLicenses.AltContactName", true));
    ((Control) this.MgaTextBox1).Location = new Point(423, 163);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 75;
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(133, 20);
    ((Control) this.MgaTextBox1).TabIndex = 10;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(318, 167);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(99, 13);
    this.Label4.TabIndex = 213;
    this.Label4.Text = "Alt. Contact Name:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.cboSendDiaryTo.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSendDiaryTo).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.SendDiaryTo", true));
    ((UltraGridBase) this.cboSendDiaryTo).DataMember = "tblUsers";
    ((UltraGridBase) this.cboSendDiaryTo).DataSource = (object) this.dsLicense;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboSendDiaryTo.DisplayLayout.Appearance = (AppearanceBase) appearance6;
    this.cboSendDiaryTo.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 8;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 231;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboSendDiaryTo.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboSendDiaryTo.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboSendDiaryTo.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboSendDiaryTo.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboSendDiaryTo.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboSendDiaryTo.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboSendDiaryTo.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboSendDiaryTo.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboSendDiaryTo.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboSendDiaryTo.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboSendDiaryTo.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance7.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance7.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboSendDiaryTo.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.White;
    this.cboSendDiaryTo.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    this.cboSendDiaryTo.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance9.ForeColor = Color.Black;
    this.cboSendDiaryTo.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboSendDiaryTo.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboSendDiaryTo).DisplayMember = "Name_LastFirst";
    this.cboSendDiaryTo.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboSendDiaryTo).DropDownWidth = 250;
    ((Control) this.cboSendDiaryTo).Location = new Point(114, 163);
    this.cboSendDiaryTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboSendDiaryTo).Name = "cboSendDiaryTo";
    ((Control) this.cboSendDiaryTo).Size = new Size(190, 21);
    ((Control) this.cboSendDiaryTo).TabIndex = 5;
    ((UltraControlBase) this.cboSendDiaryTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSendDiaryTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSendDiaryTo).ValueMember = "UserGUID";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(30, 167);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(78, 13);
    this.Label3.TabIndex = 27;
    this.Label3.Text = "Send Diary To:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance10.BorderColor = Color.Gray;
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDefaultLicense).Appearance = (AppearanceBase) appearance10;
    ((Control) this.chkDefaultLicense).DataBindings.Add(new Binding("Checked", (object) this.dsLicense, "tblProducerLicenses.DefaultLicense", true));
    ((UltraToggleEditorBase) this.chkDefaultLicense).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDefaultLicense).Location = new Point(321, 194);
    ((Control) this.chkDefaultLicense).Name = "chkDefaultLicense";
    ((Control) this.chkDefaultLicense).Size = new Size(112 /*0x70*/, 21);
    ((Control) this.chkDefaultLicense).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkDefaultLicense).Text = "Default License";
    ((UltraControlBase) this.chkDefaultLicense).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDefaultLicense).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(5, 17);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(99, 13);
    this.Label2.TabIndex = 24;
    this.Label2.Text = "Location / Contact:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.cboContacts.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboContacts).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.ProducerContactGuid", true));
    ((UltraGridBase) this.cboContacts).DataSource = (object) this.dsLicense.tblProducerContacts;
    ((UltraDropDownBase) this.cboContacts).DisplayMember = "Name";
    this.cboContacts.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboContacts).DropDownWidth = 550;
    ((Control) this.cboContacts).Location = new Point(114, 13);
    this.cboContacts.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboContacts).Name = "cboContacts";
    ((Control) this.cboContacts).Size = new Size(442, 21);
    ((Control) this.cboContacts).TabIndex = 0;
    ((UltraControlBase) this.cboContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboContacts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboContacts).ValueMember = "ProducerContactGuid";
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLicenseNum).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtLicenseNum).BackColor = Color.White;
    ((Control) this.txtLicenseNum).DataBindings.Add(new Binding("Text", (object) this.dsLicense, "tblProducerLicenses.LicenseNumber", true));
    ((Control) this.txtLicenseNum).Location = new Point(423, 133);
    this.txtLicenseNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLicenseNum).Name = "txtLicenseNum";
    ((Control) this.txtLicenseNum).Size = new Size(133, 20);
    ((Control) this.txtLicenseNum).TabIndex = 9;
    ((UltraControlBase) this.txtLicenseNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLicenseNum).UseOsThemes = (DefaultableBoolean) 2;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.StateID", true));
    ((UltraGridBase) this.cboState).DataSource = (object) this.dsLicense.lstStates;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboState).Location = new Point(114, 103);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(190, 21);
    ((Control) this.cboState).TabIndex = 3;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.cboLicenseType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLicenseType).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.LicenseTypeID", true));
    ((UltraGridBase) this.cboLicenseType).DataSource = (object) this.dsLicense.lstLicenseTypes;
    ((UltraDropDownBase) this.cboLicenseType).DisplayMember = "LicenseType";
    this.cboLicenseType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLicenseType).DropDownWidth = 200;
    ((Control) this.cboLicenseType).Location = new Point(114, 73);
    this.cboLicenseType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLicenseType).Name = "cboLicenseType";
    ((Control) this.cboLicenseType).Size = new Size(190, 21);
    ((Control) this.cboLicenseType).TabIndex = 2;
    ((UltraControlBase) this.cboLicenseType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLicenseType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLicenseType).ValueMember = "LicenseTypeID";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(354, 137);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(57, 13);
    this.Label1.TabIndex = 22;
    this.Label1.Text = "License #:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.lblExpires.AutoSize = true;
    this.lblExpires.BackColor = Color.Transparent;
    this.lblExpires.Location = new Point(365, 77);
    this.lblExpires.Name = "lblExpires";
    this.lblExpires.Size = new Size(46, 13);
    this.lblExpires.TabIndex = 20;
    this.lblExpires.Text = "Expires:";
    this.lblExpires.TextAlign = ContentAlignment.MiddleRight;
    this.lblState.AutoSize = true;
    this.lblState.BackColor = Color.Transparent;
    this.lblState.Location = new Point(30, 107);
    this.lblState.Name = "lblState";
    this.lblState.Size = new Size(37, 13);
    this.lblState.TabIndex = 19;
    this.lblState.Text = "State:";
    this.lblState.TextAlign = ContentAlignment.MiddleRight;
    this.lblType.AutoSize = true;
    this.lblType.BackColor = Color.Transparent;
    this.lblType.Location = new Point(30, 77);
    this.lblType.Name = "lblType";
    this.lblType.Size = new Size(35, 13);
    this.lblType.TabIndex = 18;
    this.lblType.Text = "Type:";
    this.lblType.TextAlign = ContentAlignment.MiddleRight;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtExpires.Appearance = (AppearanceBase) appearance12;
    appearance13.AlphaLevel = (short) 14;
    appearance13.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance13.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance13.BackColorAlpha = (Alpha) 2;
    appearance13.BackGradientAlignment = (GradientAlignment) 4;
    appearance13.BackGradientStyle = (GradientStyle) 5;
    appearance13.BorderAlpha = (Alpha) 1;
    appearance13.BorderColor = Color.FromArgb(78, 122, 171);
    appearance13.ForeColor = Color.FromArgb(49, 85, 153);
    appearance13.ForegroundAlpha = (Alpha) 2;
    this.dtExpires.ButtonAppearance = (AppearanceBase) appearance13;
    ((Control) this.dtExpires).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.Expires", true));
    this.dtExpires.DateTime = new DateTime(2003, 3, 3, 15, 20, 30, 548);
    ((Control) this.dtExpires).Location = new Point(423, 73);
    this.dtExpires.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtExpires).Name = "dtExpires";
    ((Control) this.dtExpires).Size = new Size(133, 20);
    ((Control) this.dtExpires).TabIndex = 7;
    ((UltraControlBase) this.dtExpires).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtExpires).UseOsThemes = (DefaultableBoolean) 2;
    this.dtExpires.Value = (object) new DateTime(2003, 3, 3, 15, 20, 30, 548);
    this.zipLicenses.AddressServiceURL = "";
    this.zipLicenses.AutoScrollMargin = new Size(0, 0);
    this.zipLicenses.AutoScrollMinSize = new Size(0, 0);
    this.zipLicenses.BackColor = Color.Transparent;
    this.zipLicenses.City = "";
    this.zipLicenses.County = "";
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("City", (object) this.dsLicense, "tblProducerLicenses.LicenseCity", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("County", (object) this.dsLicense, "tblProducerLicenses.LicenseCounty", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("ISOCountryCode", (object) this.dsLicense, "tblProducerLicenses.LicenseCountryCode", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("State", (object) this.dsLicense, "tblProducerLicenses.LicenseStateID", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("Street1", (object) this.dsLicense, "tblProducerLicenses.LicenseAddress1", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("Street2", (object) this.dsLicense, "tblProducerLicenses.LicenseAddress2", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("ZipCode", (object) this.dsLicense, "tblProducerLicenses.LicenseZipCode", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.dsLicense, "tblProducerLicenses.LicenseZipCodeExt", true));
    this.zipLicenses.GeoRegion = "";
    this.zipLicenses.ISOCountryCode = "";
    this.zipLicenses.ISOCountryCodeMember = "";
    this.zipLicenses.ISOCountryList = (object) null;
    this.zipLicenses.ISOCountryNameMember = "";
    ((Control) this.zipLicenses).Location = new Point(6, 14);
    this.zipLicenses.MGAStyle = MGAStyles.Blue;
    ((Control) this.zipLicenses).Name = "zipLicenses";
    this.zipLicenses.Password = "";
    this.zipLicenses.ShowGlobal = true;
    ((Control) this.zipLicenses).Size = new Size(235, 172);
    this.zipLicenses.State = "";
    this.zipLicenses.Street1 = "";
    this.zipLicenses.Street2 = "";
    ((Control) this.zipLicenses).TabIndex = 0;
    this.zipLicenses.UserID = "";
    this.zipLicenses.ZipCode = "";
    this.zipLicenses.ZipCodeExtension = "";
    ((Control) this.lblProducerLocation).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance14).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblProducerLocation).Appearance = (AppearanceBase) appearance14;
    ((Control) this.lblProducerLocation).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblProducerLocation).Location = new Point(7, 7);
    ((Control) this.lblProducerLocation).Name = "lblProducerLocation";
    ((Control) this.lblProducerLocation).Size = new Size(973, 25);
    ((Control) this.lblProducerLocation).TabIndex = 162;
    ((ControlBase) this.lblProducerLocation).Text = "location name goes here";
    this.errProvider.ContainerControl = (ContainerControl) this;
    this.errProvider.DataMember = "";
    this.DbSaveUI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.DbSaveUI1.AutoQueryRowCountOnLoad = false;
    this.DbSaveUI1.FreezeEvents = false;
    this.DbSaveUI1.Location = new Point(868, 587);
    this.DbSaveUI1.Name = "DbSaveUI1";
    this.DbSaveUI1.Size = new Size(112 /*0x70*/, 40);
    this.DbSaveUI1.TabIndex = 2;
    this.panelSearch.BackColorInternal = Color.White;
    appearance15.BorderColor = Color.Gray;
    this.panelSearch.ContentAreaAppearance = (AppearanceBase) appearance15;
    ((Control) this.panelSearch).Controls.Add((Control) this.spinner);
    ((Control) this.panelSearch).Controls.Add((Control) this.labelSearchText);
    ((Control) this.panelSearch).Controls.Add((Control) label);
    ((Control) this.panelSearch).ForeColor = Color.Black;
    ((Control) this.panelSearch).Location = new Point(313, 89);
    ((Control) this.panelSearch).Name = "panelSearch";
    ((Control) this.panelSearch).Size = new Size(318, 140);
    ((Control) this.panelSearch).TabIndex = 211;
    ((Control) this.panelSearch).Visible = false;
    this.spinner.Image = (Image) componentResourceManager.GetObject("spinner.Image");
    this.spinner.Location = new Point(128 /*0x80*/, 81);
    this.spinner.Name = "spinner";
    this.spinner.Size = new Size(60, 44);
    this.spinner.SizeMode = PictureBoxSizeMode.Zoom;
    this.spinner.TabIndex = 116;
    this.spinner.TabStop = false;
    this.labelSearchText.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelSearchText.Location = new Point(10, 52);
    this.labelSearchText.Name = "labelSearchText";
    this.labelSearchText.Size = new Size(299, 19);
    this.labelSearchText.TabIndex = 3;
    this.labelSearchText.Text = "Gathering Contacts and License Data ...";
    this.labelSearchText.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.UltraGroupBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.UltraGroupBox1.BackColorInternal = Color.Transparent;
    appearance16.BackColor = Color.FromArgb(246, 250, 253);
    appearance16.BackColorDisabled = Color.FromArgb(246, 250, 253);
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance16;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.zipLicenses);
    ((Control) this.UltraGroupBox1).Enabled = false;
    ((Control) this.UltraGroupBox1).Location = new Point(595, 402);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(249, 225);
    ((Control) this.UltraGroupBox1).TabIndex = 1;
    this.UltraGroupBox1.Text = "License   Address";
    ((UltraGridBase) this.ddLicenseTypes).DataSource = (object) this.dsLicense.lstLicenseTypes;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "License Type";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 171;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 3;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 5;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 6;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 7;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 22;
    ultraGridBand3.Columns.AddRange(new object[23]
    {
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
      (object) ultraGridColumn28
    });
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddLicenseTypes).DisplayMember = "LicenseType";
    ((Control) this.ddLicenseTypes).Location = new Point(710, 163);
    ((Control) this.ddLicenseTypes).Name = "ddLicenseTypes";
    ((Control) this.ddLicenseTypes).Size = new Size(189, 56);
    ((Control) this.ddLicenseTypes).TabIndex = 210;
    ((UltraDropDownBase) this.ddLicenseTypes).ValueMember = "LicenseTypeID";
    ((Control) this.ddLicenseTypes).Visible = false;
    ((UltraGridBase) this.ddProducerContacts).DataSource = (object) this.dsLicense.tblProducerContacts;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 0;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 1;
    ultraGridColumn30.Width = 206;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn29,
      (object) ultraGridColumn30
    });
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddProducerContacts).DisplayMember = "Name";
    ((Control) this.ddProducerContacts).Location = new Point(666, 101);
    ((Control) this.ddProducerContacts).Name = "ddProducerContacts";
    ((Control) this.ddProducerContacts).Size = new Size(224 /*0xE0*/, 56);
    ((Control) this.ddProducerContacts).TabIndex = 209;
    ((UltraDropDownBase) this.ddProducerContacts).ValueMember = "ProducerContactGuid";
    ((Control) this.ddProducerContacts).Visible = false;
    ((Control) this.ugLicenses).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugLicenses).DataSource = (object) this.dsLicense.tblProducerLicenses;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "License";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 0;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Style = (ColumnStyle) 6;
    ultraGridColumn31.Width = 120;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 1;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 131;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Contact";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 2;
    ultraGridColumn33.Style = (ColumnStyle) 6;
    ultraGridColumn33.Width = 123;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "License Type";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 4;
    ultraGridColumn34.Width = 215;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "License #";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 5;
    ultraGridColumn35.Width = 142;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn36.Format = "d";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 6;
    ultraGridColumn36.Width = 98;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 7;
    ultraGridColumn37.Width = 115;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Caption = "Default License";
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 9;
    ultraGridColumn38.Width = 95;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 10;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 181;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 11;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 79;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Alt Contact Name";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 3;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 131;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 12;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 65;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 13;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 69;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 14;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 74;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 15;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 84;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 97;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 17;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 66;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 18;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 61;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 19;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 54;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 20;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 191;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 21;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 52;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 8;
    ultraGridColumn52.Width = 62;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 22;
    ultraGridColumn53.Width = 102;
    ultraGridBand5.Columns.AddRange(new object[23]
    {
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53
    });
    ultraGridBand5.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance18.BackColor = Color.LightSteelBlue;
    appearance18.FontData.SizeInPoints = 10f;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance20.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance22.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance22;
    appearance23.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance24.BackColor = Color.Transparent;
    appearance24.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance24;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugLicenses).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugLicenses).Location = new Point(7, 35);
    ((Control) this.ugLicenses).Name = "ugLicenses";
    ((Control) this.ugLicenses).Size = new Size(973, 361);
    ((Control) this.ugLicenses).TabIndex = 207;
    ((UltraControlBase) this.ugLicenses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLicenses).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(988, 639);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.Controls.Add((Control) this.panelSearch);
    this.Controls.Add((Control) this.ddLicenseTypes);
    this.Controls.Add((Control) this.ddProducerContacts);
    this.Controls.Add((Control) this.DbSaveUI1);
    this.Controls.Add((Control) this.ugLicenses);
    this.Controls.Add((Control) this.lblProducerLocation);
    this.Controls.Add((Control) this.grpLicenseInfo);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmProducerLicenses);
    this.Text = "Producer Licenses";
    ((ISupportInitialize) this.grpLicenseInfo).EndInit();
    ((Control) this.grpLicenseInfo).ResumeLayout(false);
    ((Control) this.grpLicenseInfo).PerformLayout();
    ((ISupportInitialize) this.chkDefaultSLLicense).EndInit();
    this.dsLicense.EndInit();
    ((ISupportInitialize) this.dtIssued).EndInit();
    ((ISupportInitialize) this.cboLicenseStatus).EndInit();
    ((ISupportInitialize) this.cboProducers).EndInit();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.cboSendDiaryTo).EndInit();
    ((ISupportInitialize) this.chkDefaultLicense).EndInit();
    ((ISupportInitialize) this.cboContacts).EndInit();
    ((ISupportInitialize) this.txtLicenseNum).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboLicenseType).EndInit();
    ((ISupportInitialize) this.dtExpires).EndInit();
    ((ISupportInitialize) this.errProvider).EndInit();
    ((ISupportInitialize) this.panelSearch).EndInit();
    ((Control) this.panelSearch).ResumeLayout(false);
    ((Control) this.panelSearch).PerformLayout();
    ((ISupportInitialize) this.spinner).EndInit();
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.ddLicenseTypes).EndInit();
    ((ISupportInitialize) this.ddProducerContacts).EndInit();
    ((ISupportInitialize) this.ugLicenses).EndInit();
    this.ResumeLayout(false);
  }

  private BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.dsLicense, this.dsLicense.tblProducerLicenses.TableName];
    }
  }

  public frmProducerLicenses(Guid producerLocationGuid, string locationName, bool refreshContacts = false)
  {
    this.Load += new EventHandler(this.frmProducerLicenses_Load);
    this._refreshContacts = false;
    this._showAllContacts = false;
    this._gridLayout = new MemoryStream();
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._locationGuid = producerLocationGuid;
    ((ControlBase) this.lblProducerLocation).Text = locationName;
    this._refreshContacts = refreshContacts;
  }

  private void frmProducerLicenses_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.DbSaveUI1.Enabled = false;
    ((Control) this.panelSearch).Visible = true;
    this._showAllContacts = MGASystems.Common.SystemSettings.KeyExists("ShowAllProducerLicenseContacts") && MGASystems.Common.SystemSettings.GetBoolSetting("ShowAllProducerLicenseContacts");
    this.ClearBindings();
    this.FillTables(this._showAllContacts);
  }

  private void ClearBindings()
  {
    ((Control) this.cboContacts).DataBindings.Clear();
    ((Control) this.cboLicenseType).DataBindings.Clear();
    ((Control) this.cboState).DataBindings.Clear();
    ((Control) this.cboSendDiaryTo).DataBindings.Clear();
    ((Control) this.cboLine).DataBindings.Clear();
    ((Control) this.dtExpires).DataBindings.Clear();
    ((Control) this.txtLicenseNum).DataBindings.Clear();
    ((Control) this.chkDefaultLicense).DataBindings.Clear();
    ((Control) this.chkDefaultSLLicense).DataBindings.Clear();
    ((Control) this.MgaTextBox1).DataBindings.Clear();
    ((Control) this.zipLicenses).DataBindings.Clear();
    ((Control) this.cboProducers).DataBindings.Clear();
    ((Control) this.dtIssued).DataBindings.Clear();
    ((Control) this.cboLicenseStatus).DataBindings.Clear();
  }

  private void AddBindings()
  {
    ((Control) this.cboContacts).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.ProducerContactGuid", true));
    ((UltraGridBase) this.cboContacts).DataSource = (object) this.dsLicense.tblProducerContacts;
    ((UltraDropDownBase) this.cboContacts).DisplayMember = "Name";
    ((UltraDropDownBase) this.cboContacts).ValueMember = "ProducerContactGuid";
    ((Control) this.cboLicenseType).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.LicenseTypeID", true));
    ((UltraGridBase) this.cboLicenseType).DataSource = (object) this.dsLicense.lstLicenseTypes;
    ((UltraDropDownBase) this.cboLicenseType).DisplayMember = "LicenseType";
    ((UltraDropDownBase) this.cboLicenseType).ValueMember = "LicenseTypeID";
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.StateID", true));
    ((UltraGridBase) this.cboState).DataSource = (object) this.dsLicense.lstStates;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    ((Control) this.cboSendDiaryTo).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.SendDiaryTo", true));
    ((UltraGridBase) this.cboSendDiaryTo).DataMember = "tblUsers";
    ((UltraGridBase) this.cboSendDiaryTo).DataSource = (object) this.dsLicense;
    ((UltraDropDownBase) this.cboSendDiaryTo).DisplayMember = "Name_LastFirst";
    ((UltraDropDownBase) this.cboSendDiaryTo).ValueMember = "UserGUID";
    ((Control) this.cboLine).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.LineGuid", true));
    ((UltraGridBase) this.cboLine).DataMember = "lstLines";
    ((UltraGridBase) this.cboLine).DataSource = (object) this.dsLicense;
    ((UltraDropDownBase) this.cboLine).DisplayMember = "LineName";
    ((UltraDropDownBase) this.cboLine).ValueMember = "LineGUID";
    ((Control) this.dtExpires).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.Expires", true));
    ((Control) this.txtLicenseNum).DataBindings.Add(new Binding("Text", (object) this.dsLicense, "tblProducerLicenses.LicenseNumber", true));
    ((Control) this.chkDefaultLicense).DataBindings.Add(new Binding("Checked", (object) this.dsLicense, "tblProducerLicenses.DefaultLicense", true));
    ((Control) this.chkDefaultSLLicense).DataBindings.Add(new Binding("Checked", (object) this.dsLicense, "tblProducerLicenses.DefaultSLLicense", true));
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.dsLicense, "tblProducerLicenses.AltContactName", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("City", (object) this.dsLicense, "tblProducerLicenses.LicenseCity", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("County", (object) this.dsLicense, "tblProducerLicenses.LicenseCounty", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("ISOCountryCode", (object) this.dsLicense, "tblProducerLicenses.LicenseCountryCode", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("State", (object) this.dsLicense, "tblProducerLicenses.LicenseStateID", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("Street1", (object) this.dsLicense, "tblProducerLicenses.LicenseAddress1", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("Street2", (object) this.dsLicense, "tblProducerLicenses.LicenseAddress2", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("ZipCode", (object) this.dsLicense, "tblProducerLicenses.LicenseZipCode", true));
    ((Control) this.zipLicenses).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.dsLicense, "tblProducerLicenses.LicenseZipCodeExt", true));
    ((Control) this.cboProducers).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.ProducerGuid", true));
    ((UltraGridBase) this.cboProducers).DataMember = "dtProducers";
    ((UltraGridBase) this.cboProducers).DataSource = (object) this.dsLicense;
    ((UltraDropDownBase) this.cboProducers).DisplayMember = "ProducerName";
    ((Control) this.cboProducers).Name = "cboProducers";
    ((Control) this.dtIssued).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.Issued", true));
    ((Control) this.cboLicenseStatus).DataBindings.Add(new Binding("Value", (object) this.dsLicense, "tblProducerLicenses.StatusID", true));
    ((UltraGridBase) this.cboLicenseStatus).DataMember = "lstProducerLicenseStatus";
    ((UltraGridBase) this.cboLicenseStatus).DataSource = (object) this.dsLicense;
    ((UltraDropDownBase) this.cboLicenseStatus).DisplayMember = "Description";
    ((UltraDropDownBase) this.cboLicenseStatus).ValueMember = "StatusID";
  }

  private void FillTables(bool show)
  {
    this.dsLicense.tblProducerContacts.Clear();
    this.dsLicense.tblProducerLicenses.Clear();
    this.dsLicense.dtProducers.Clear();
    dsProducerLicenses.tblProducerContactsRow row1 = this.dsLicense.tblProducerContacts.NewtblProducerContactsRow();
    row1.SetProducerContactGUIDNull();
    row1.Name = ((ControlBase) this.lblProducerLocation).Text;
    this.dsLicense.tblProducerContacts.AddtblProducerContactsRow(row1);
    dsProducerLicenses.tblUsersRow row2 = this.dsLicense.tblUsers.NewtblUsersRow();
    row2.Name_LastFirst = string.Empty;
    this.dsLicense.tblUsers.AddtblUsersRow(row2);
    dsProducerLicenses.dtProducersRow row3 = this.dsLicense.dtProducers.NewdtProducersRow();
    row3.ProducerName = string.Empty;
    this.dsLicense.dtProducers.AdddtProducersRow(row3);
    dsProducerLicenses.lstProducerLicenseStatusRow row4 = this.dsLicense.lstProducerLicenseStatus.NewlstProducerLicenseStatusRow();
    row4.Description = string.Empty;
    this.dsLicense.lstProducerLicenseStatus.AddlstProducerLicenseStatusRow(row4);
    Producer producer = new Producer(new ProducerLocation(this._locationGuid).ProducerGuid);
    dsProducerLicenses.dtProducersRow row5 = this.dsLicense.dtProducers.NewdtProducersRow();
    row5.ProducerName = "Producer - " + producer.ProducerName;
    row5.ProducerGuid = producer.ProducerGuid;
    this.dsLicense.dtProducers.AdddtProducersRow(row5);
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.ugLicenses).DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill), (object) this._showAllContacts);
  }

  private void ThreadedFill(object state)
  {
    bool flag = (bool) state;
    if (this._refreshContacts)
      frmProducerLicenses._contactCache = (dsProducerLicenses.tblProducerContactsDataTable) null;
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("FillProducerLicenseData", new SqlConnection(CurrentUser.Instance.ConnectionString));
    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
    try
    {
      DataTableMappingCollection tableMappings = sqlDataAdapter.TableMappings;
      tableMappings.Clear();
      tableMappings.Add("Table", this.dsLicense.lstLicenseTypes.TableName);
      tableMappings.Add("Table1", this.dsLicense.lstStates.TableName);
      tableMappings.Add("Table2", this.dsLicense.tblUsers.TableName);
      tableMappings.Add("Table3", this.dsLicense.tblProducerLicenses.TableName);
      tableMappings.Add("Table4", this.dsLicense.tblProducerContacts.TableName);
      tableMappings.Add("Table5", this.dsLicense.lstLines.TableName);
      tableMappings.Add("Table6", this.dsLicense.lstProducerLicenseStatus.TableName);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ProducerLocationGuid", (object) this._locationGuid);
      if (frmProducerLicenses._contactCache == null && flag)
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@GetAllContacts", (object) true);
      sqlDataAdapter.SelectCommand.CommandTimeout = 600;
      try
      {
        DefaultDatabase.DataAdapterFill((DbDataAdapter) sqlDataAdapter, (DataSet) this.dsLicense);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
        ProjectData.ClearProjectError();
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
      this.Close();
      ProjectData.ClearProjectError();
      return;
    }
    finally
    {
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
    if (flag)
    {
      if (frmProducerLicenses._contactCache != null)
      {
        this.dsLicense.tblProducerContacts.BeginLoadData();
        this.dsLicense.tblProducerContacts.Load((IDataReader) frmProducerLicenses._contactCache.CreateDataReader());
        this.dsLicense.tblProducerContacts.EndLoadData();
      }
      else
      {
        frmProducerLicenses._contactCache = new dsProducerLicenses.tblProducerContactsDataTable();
        frmProducerLicenses._contactCache.BeginLoadData();
        frmProducerLicenses._contactCache.Load((IDataReader) this.dsLicense.tblProducerContacts.CreateDataReader());
        frmProducerLicenses._contactCache.EndLoadData();
      }
    }
    try
    {
      if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
        return;
      MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new frmProducerLicenses.ThreadCompleteHandler(this.ThreadFillComplete), (object) this, (object) EventArgs.Empty);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void ThreadFillComplete(object sender, EventArgs e)
  {
    this.AddBindings();
    this.DbSaveUI1.Enabled = true;
    ((Control) this.panelSearch).Visible = false;
    ((UltraGridBase) this.ugLicenses).DataSource = (object) this.dsLicense.tblProducerLicenses;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.ugLicenses).DisplayLayout.Load((Stream) this._gridLayout);
    if (this._showAllContacts)
      ((UltraGridBase) this.ugLicenses).DisplayLayout.Bands[0].Columns["AltContactName"].Hidden = false;
    this.DbSaveUI1.EditStyle = EditStyle.ShowEditButton;
    this.DbSaveUI1.UIState = this.dsLicense.tblProducerLicenses.Rows.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    ((EventManagerBase) this.ugLicenses.EventManager).AllEventsEnabled = true;
    this.FormLoadComplete();
  }

  protected virtual void FormLoadComplete()
  {
  }

  protected dsProducerLicenses.tblProducerLicensesRow CurrentLocationRow
  {
    get
    {
      return this.bmb.Position != -1 ? this.dsLicense.tblProducerLicenses[this.bmb.Position] : (dsProducerLicenses.tblProducerLicensesRow) null;
    }
  }

  private void ugLicenses_AfterRowActivate(object sender, EventArgs e)
  {
    Guid guid = ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["ProducerLicenseGuid"].Value == null || ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["ProducerLicenseGuid"].Value == DBNull.Value ? Guid.Empty : (Guid) ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["ProducerLicenseGuid"].Value;
    this._CurrProducerLicenseGuid = guid;
    this._CurrProducerLicenseNum = ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["LicenseNumber"].Value == null || ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["LicenseNumber"].Value == DBNull.Value ? string.Empty : (string) ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["LicenseNumber"].Value;
    this._CurrentProducerContactGUID = ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["ProducerContactGUID"].Value == null || ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["ProducerContactGUID"].Value == DBNull.Value ? Guid.Empty : (Guid) ((UltraGridBase) this.ugLicenses).ActiveRow.Cells["ProducerContactGUID"].Value;
    Database.MoveTo((object) guid, "ProducerLicenseGuid", (DataTable) this.dsLicense.tblProducerLicenses, this.bmb);
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent != null)
      infoChangedEvent((object) this, EventArgs.Empty);
    // ISSUE: reference to a compiler-generated field
    ISupportNoteSystem.EntityInfoChangedEventHandler infoChanged1Event = this.EntityInfoChanged1Event;
    if (infoChanged1Event == null)
      return;
    infoChanged1Event((object) this, EventArgs.Empty);
  }

  private bool ValidForm()
  {
    bool formValid = true;
    this.errProvider.SetError((Control) this.cboContacts, string.Empty);
    this.errProvider.SetError((Control) this.cboLicenseType, string.Empty);
    this.errProvider.SetError((Control) this.txtLicenseNum, string.Empty);
    if (this.cboContacts.Text.Length == 0)
    {
      this.errProvider.SetError((Control) this.cboContacts, "Select a value");
      formValid = false;
    }
    if (this.cboLicenseType.Text.Length == 0)
    {
      this.errProvider.SetError((Control) this.cboLicenseType, "Select a value");
      formValid = false;
    }
    bool flag = this.IsLicenseNumValid(formValid);
    if (flag)
      flag = this.IsValidLicenseExpirationDate();
    if (flag)
      flag = this.IsDuplicateLicense();
    if (flag)
      flag = this.IsClientControlsValid();
    return flag;
  }

  protected virtual bool IsLicenseNumValid(bool formValid)
  {
    if (((TextEditorControlBase) this.txtLicenseNum).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.errProvider.SetError((Control) this.txtLicenseNum, "Enter a value");
      formValid = false;
    }
    return formValid;
  }

  protected virtual bool IsClientControlsValid() => true;

  private void SetupDBUIState()
  {
    if (this.dsLicense.tblProducerLicenses.Count == 0)
      this.DbSaveUI1.UIState = UIState.NoRecordsNotEditing;
    else
      this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
  }

  private void DbSaveUI1_ClickedCancel(object sender, EventArgs e)
  {
    this.SetupDBUIState();
    this.dsLicense.tblProducerLicenses.RejectChanges();
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
        this.LogChanges((DataSet) this.dsLicense, this.dsLicense.tblProducerLicenses.TableName, "Modify Producer License:  The producer license(s) was modified. ", "producerlocationGuid", "LicenseNumber");
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daProdLicense, (DataTable) this.dsLicense.tblProducerLicenses);
        this.SaveClientData(this.dsLicense.tblProducerLicenses[position].ProducerLicenseGUID);
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Message.Contains("Only one default license per License Type and State for each location"))
        {
          int num = (int) MessageBox.Show(ex2.Message, "Only One Default License Needed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
          return;
        }
        if (ex2.Message.Contains("PK_tblProducerLicenses"))
        {
          int num1 = (int) MessageBox.Show("This setup already exists.\n\nPlease edit the existing setup if information needs to be changed.", "Unable to Save - Setup Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          ErrorHandler.HandleError((Exception) ex2);
          e.Cancel = true;
        }
        ProjectData.ClearProjectError();
      }
      ((Control) this.ugLicenses).Enabled = true;
      foreach (UltraGridRow row in ((UltraGridBase) this.ugLicenses).Rows)
      {
        if (((Guid) row.Cells["ProducerLicenseGUID"].Value).Equals(this.dsLicense.tblProducerLicenses[position].ProducerLicenseGUID))
        {
          ((UltraGridBase) this.ugLicenses).ActiveRow = row;
          break;
        }
      }
    }
  }

  protected virtual void SaveClientData(Guid ProducerLicenseGUID)
  {
  }

  protected void LogChanges(
    DataSet ds,
    string dtTableName,
    string strAction,
    string strGUIDtoLog,
    string strcontext)
  {
    DataTable table = ds.Tables[dtTableName];
    DataRow[] dataRowArray1 = table.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent);
    int index1 = 0;
    while (index1 < dataRowArray1.Length)
    {
      DataRow dataRow = dataRowArray1[index1];
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
        {
          string Left = dataRow[column, DataRowVersion.Original].ToString();
          string Right = dataRow[column, DataRowVersion.Current].ToString();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
            strAction = $"{strAction} Original {column.Caption}: {Left} was changed to: {Right}";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} for {strcontext}: {dataRow[strcontext].ToString()}", Guid.Parse(dataRow[strGUIDtoLog].ToString()), $"{strcontext}: {dataRow[strcontext].ToString()}");
      checked { ++index1; }
    }
    DataRow[] dataRowArray2 = table.Select((string) null, (string) null, DataViewRowState.Added);
    int index2 = 0;
    while (index2 < dataRowArray2.Length)
    {
      DataRow dataRow = dataRowArray2[index2];
      string str = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str = $"{str}  {column.Caption}: {dataRow[column, DataRowVersion.Current].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} User inserted new record. {str}", Guid.Parse(dataRow[strGUIDtoLog].ToString()), $"{strcontext}: {dataRow[strcontext].ToString()}");
      checked { ++index2; }
    }
    DataRow[] dataRowArray3 = table.Select((string) null, (string) null, DataViewRowState.Deleted);
    int index3 = 0;
    while (index3 < dataRowArray3.Length)
    {
      DataRow dataRow = dataRowArray3[index3];
      string str = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str = $"{str} {column.Caption}: {dataRow[column, DataRowVersion.Original].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} User deleted the record. {str}");
      checked { ++index3; }
    }
  }

  private void DbSaveUI1_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ugLicenses).Enabled = this.DbSaveUI1.UIState != UIState.Editing;
    ((Control) this.grpLicenseInfo).Enabled = this.DbSaveUI1.UIState == UIState.Editing;
    ((Control) this.UltraGroupBox1).Enabled = this.DbSaveUI1.UIState == UIState.Editing;
  }

  private void DbSaveUI1_ClickingNew(object sender, CancelEventArgs e)
  {
    dsProducerLicenses.tblProducerLicensesRow row = this.dsLicense.tblProducerLicenses.NewtblProducerLicensesRow();
    row.ProducerLicenseGUID = Guid.NewGuid();
    row.ProducerLocationGUID = this._locationGuid;
    this.dsLicense.tblProducerLicenses.AddtblProducerLicensesRow(row);
    this.bmb.Position = this.dsLicense.tblProducerLicenses.Count - 1;
    this.ClearClientControls();
  }

  protected virtual void ClearClientControls()
  {
  }

  private void DbSaveUI1_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.bmb.CancelCurrentEdit();
    try
    {
      foreach (Control control in ((Control) this.grpLicenseInfo).Controls)
        this.errProvider.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.dsLicense.tblProducerLicenses.RejectChanges();
  }

  private void DbSaveUI1_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this license?", "Delete License?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        string licenseNumber = this.dsLicense.tblProducerLicenses[this.bmb.Position].LicenseNumber;
        CurrentUser.Instance.LogAction("Modify Producer License:  The producer license(s) was deleted. License number: " + licenseNumber, this.dsLicense.tblProducerLicenses[this.bmb.Position].ProducerLocationGUID, "Licesne Number: " + licenseNumber);
        this.dsLicense.tblProducerLicenses[this.bmb.Position].Delete();
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daProdLicense, (DataTable) this.dsLicense.tblProducerLicenses);
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Message.Contains("FK_tblQuoteFilingProducers_tblProducerLicenses"))
        {
          int num = (int) MessageBox.Show("This license is in use on another quote and cannot be deleted.", "Cannot Delete License", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
          ProjectData.ClearProjectError();
        }
        else
        {
          ErrorHandler.HandleError((Exception) ex2);
          e.Cancel = true;
          ProjectData.ClearProjectError();
        }
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void DbSaveUI1_ClickedDelete(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugLicenses).Rows.Count > 0)
      ((UltraGridBase) this.ugLicenses).ActiveRow = ((UltraGridBase) this.ugLicenses).Rows[((UltraGridBase) this.ugLicenses).Rows.Count - 1];
    this.SetupDBUIState();
  }

  private bool IsDuplicateLicense()
  {
    List<object> objectList1 = new List<object>();
    bool flag;
    try
    {
      foreach (dsProducerLicenses.tblProducerLicensesRow row in this.dsLicense.tblProducerLicenses.Rows)
      {
        if (!(!row.DefaultLicense & !row.DefaultSLLicense))
        {
          List<object> objectList2 = objectList1;
          string[] strArray1 = new string[5];
          Guid producerLocationGuid = row.ProducerLocationGUID;
          strArray1[0] = producerLocationGuid.ToString();
          strArray1[1] = "/";
          strArray1[2] = Conversions.ToString(row.LicenseTypeID);
          strArray1[3] = "/";
          strArray1[4] = row.StateID;
          string str1 = string.Concat(strArray1);
          if (!objectList2.Contains((object) str1))
          {
            List<object> objectList3 = objectList1;
            string[] strArray2 = new string[5];
            producerLocationGuid = row.ProducerLocationGUID;
            strArray2[0] = producerLocationGuid.ToString();
            strArray2[1] = "/";
            strArray2[2] = Conversions.ToString(row.LicenseTypeID);
            strArray2[3] = "/";
            strArray2[4] = row.StateID;
            string str2 = string.Concat(strArray2);
            objectList3.Add((object) str2);
          }
          else
          {
            int num = (int) MessageBox.Show($"Only one default license and only one default SL license  per License Type and State for each location.\n\nThe state of '{row.StateID}' and License type '{this.dsLicense.lstLicenseTypes.FindByLicenseTypeID(row.LicenseTypeID).LicenseType}' are in duplicate.", "Only One Default License Needed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_11;
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = true;
label_11:
    return flag;
  }

  protected virtual bool IsValidLicenseExpirationDate()
  {
    bool flag = true;
    this.errProvider.SetError((Control) this.dtExpires, string.Empty);
    if (this.dtExpires.Value == null || this.dtExpires.Value == DBNull.Value)
    {
      flag = false;
      this.errProvider.SetError((Control) this.dtExpires, "Required");
    }
    return flag;
  }

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.HasControlGUID => false;

  string IRecreatableEntity.FriendlyEntityName => "Licenses";

  string IRecreatableEntity.RecreateTypeName => typeof (frmProducerLicenses).ToString();

  public bool CanCreateNewNote
  {
    get
    {
      bool canCreateNewNote;
      try
      {
        canCreateNewNote = this.CurrentLocationRow != null && this.CurrentLocationRow.RowState != DataRowState.Added;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        canCreateNewNote = false;
        ProjectData.ClearProjectError();
      }
      return canCreateNewNote;
    }
  }

  Guid IRecreatableEntity.EntityGUID
  {
    get
    {
      Guid entityGuid;
      try
      {
        entityGuid = this.CurrentLocationRow == null || this.CurrentLocationRow.RowState == DataRowState.Added ? new Guid() : this.CurrentLocationRow.ProducerLicenseGUID;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        entityGuid = new Guid();
        ProjectData.ClearProjectError();
      }
      return entityGuid;
    }
  }

  string IRecreatableEntity.EntityName
  {
    get
    {
      return this.CurrentLocationRow == null || this.CurrentLocationRow.RowState == DataRowState.Added || !(this._CurrProducerLicenseGuid != Guid.Empty) ? "New License" : this._CurrProducerLicenseNum;
    }
  }

  bool IRecreatableEntity.CanReCreateEntity => true;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGUID)
  {
    return !this._CurrProducerLicenseGuid.Equals(Guid.Empty);
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  private enum FormModes
  {
    EditMode,
    NewMode,
    Locked,
  }

  private delegate void ThreadCompleteHandler(object sender, EventArgs e);
}
