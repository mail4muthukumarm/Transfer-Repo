// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerContacts
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Sircon;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

[SecureResource("{72A14282-79A9-4911-AFE1-8CB943352762}", "New Producer Contact", "Controls the ability for the user to add a new producer contact.", "Producers")]
[SecureResource("{BA4D1F6A-179A-42C6-8592-160F05478BFC}", "Edit Producer Contact", "Controls the ability to Edit producer contact.", "Producers")]
[SecureResource("{E4424AE8-1B00-4ACF-B843-FC0C261A654D}", "Delete Producer Contact", "Controls the ability to Delete producer contact.", "Producers")]
[SecureResource("{E6F93833-1F2E-48e6-83B6-42036CAEBCF0}", "Authorize User for External Access", "Controls the ability to authorize a contact for external access.", "Producers")]
[SecureResource("{D8A1C515-4396-4790-84CB-CF44B3650BC1}", "Edit Producer Contact SSN", "Controls the ability to edit a contact SSN.", "Producers")]
[SecureResource("{0C159028-1264-4218-872F-68B6CF19955C}", "Edit Producer Contact DOB", "Controls the ability to edit a contact DOB.", "Producers")]
[SecureResource("{9B676E43-1FAA-4a3f-BC03-75459E82FBE6}", "Update Special Producer Contacts", "Controls the ability to update special producer comtacts.", "Producers")]
[SecureResource("{88E157A8-27B4-4E2C-AB3E-C0DC06E2CD11}", "Edit OFAC Cleared", "Controls whether or not a user is allowed to edit OFAC Cleared.", "Producers")]
public class frmProducerContacts : Form
{
  private IContainer components;
  protected Label lblAddress1;
  protected Label lblAddress2;
  protected Label lblPhone;
  protected Label Label3;
  protected Label Label8;
  protected Label Label13;
  protected MGAListBox lstContacts;
  protected Label Label7;
  protected ToolTip ToolTip;
  protected SqlDataAdapter daContacts;
  protected MGATextBox txtEmail;
  protected MGATextBox txtTitle;
  protected MGATextBox txtLName;
  protected MGATextBox txtFName;
  protected MGATextBox txtExt;
  private Label Label4;
  private SqlDataAdapter daSpecialContacts;
  private Label Label11;
  private MGACheckBox chk1099;
  private ErrorProvider err;
  private MGAMaskedEdit txtPhone;
  private MGAMaskedEdit txtCell;
  private MGAMaskedEdit txtSSNNo;
  private MGAMaskedEdit txtFax;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlCommand SqlSelectCommand6;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  private SqlDataAdapter daFillData;
  private SqlCommand SqlSelectCommand1;
  [CLSCompliant(false)]
  protected Guid _producerLocationGuid;
  private Guid _producerGuid;
  private Guid _producerContactGuid;
  private frmProducerContacts.ScreenMode _screenMode;
  private bool _permissionToAddContact;
  private bool _canUpdateSpecialProducerContacts;
  private int _AddByUserID;
  private object _NewContactPhone;
  private object _NewContactFax;
  private bool _UseServerTime;
  private bool _canEditContact;
  private bool _canDeleteContact;
  private bool _isFormLoading;
  private bool _canEditSSN;
  private bool _canEditDOB;
  private bool _canClearOfac;
  private readonly bool _allowOfacSearch;
  private readonly bool _showOfac;
  private readonly Dictionary<Guid, OfacSystem.OfacStatus> _ofacData;
  private readonly Dictionary<Guid, string> _ofacUnderwriters;
  private readonly SqlConnection _cn;
  internal const string NewProducerContact = "{72A14282-79A9-4911-AFE1-8CB943352762}";
  internal const string CanUpdateSpecialProducerContacts = "{9B676E43-1FAA-4a3f-BC03-75459E82FBE6}";
  public const string CanAuthorizeContactForExternalAccess = "{E6F93833-1F2E-48e6-83B6-42036CAEBCF0}";
  public const string CanEditProducerContacts = "{BA4D1F6A-179A-42C6-8592-160F05478BFC}";
  public const string CanDeleteProducerContacts = "{E4424AE8-1B00-4ACF-B843-FC0C261A654D}";
  public const string CanEditProducerContactSSN = "{D8A1C515-4396-4790-84CB-CF44B3650BC1}";
  public const string CanEditProducerContactDOB = "{0C159028-1264-4218-872F-68B6CF19955C}";
  public const string CanEditOfacData = "{88E157A8-27B4-4E2C-AB3E-C0DC06E2CD11}";
  private frmProducerContacts.d_FilterContacts md;
  [SpecialName]
  private bool \u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore;
  [SpecialName]
  private StaticLocalInitFlag \u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init;

  [field: AccessedThroughProperty("grpContactInfo")]
  protected virtual MGAGroupBox grpContactInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckedListBox lstSpecialContacts
  {
    get => this._lstSpecialContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
      MGACheckedListBox lstSpecialContacts1 = this._lstSpecialContacts;
      if (lstSpecialContacts1 != null)
        lstSpecialContacts1.ItemCheck -= checkEventHandler;
      this._lstSpecialContacts = value;
      MGACheckedListBox lstSpecialContacts2 = this._lstSpecialContacts;
      if (lstSpecialContacts2 == null)
        return;
      lstSpecialContacts2.ItemCheck += checkEventHandler;
    }
  }

  protected virtual MGAButton btnSpecialContact
  {
    get => this._btnSpecialContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSpecialContact_Click);
      MGAButton btnSpecialContact1 = this._btnSpecialContact;
      if (btnSpecialContact1 != null)
        ((Control) btnSpecialContact1).Click -= eventHandler;
      this._btnSpecialContact = value;
      MGAButton btnSpecialContact2 = this._btnSpecialContact;
      if (btnSpecialContact2 == null)
        return;
      ((Control) btnSpecialContact2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblProducer")]
  protected virtual UltraLabel lblProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsContacts")]
  protected virtual dsProducerContacts dsContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvProducerContacts")]
  private virtual DataView dvProducerContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkAuthorize
  {
    get => this._lnkAuthorize;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAuthorize_LinkClicked);
      LinkLabel lnkAuthorize1 = this._lnkAuthorize;
      if (lnkAuthorize1 != null)
        lnkAuthorize1.LinkClicked -= clickedEventHandler;
      this._lnkAuthorize = value;
      LinkLabel lnkAuthorize2 = this._lnkAuthorize;
      if (lnkAuthorize2 == null)
        return;
      lnkAuthorize2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.UIStateChanged -= eventHandler2;
        dbSave1.ClickedEdit -= eventHandler3;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingEdit -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.UIStateChanged += eventHandler2;
      dbSave2.ClickedEdit += eventHandler3;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingEdit += cancelEventHandler4;
    }
  }

  [field: AccessedThroughProperty("cbStatus")]
  private virtual MGASimpleComboBox cbStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDeliveryMethod")]
  protected virtual MGASimpleComboBox cboDeliveryMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox1")]
  protected virtual MGASimpleComboBox MgaSimpleComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox2")]
  protected virtual MGAGroupBox MgaGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("frmProducerContacts_Fill_Panel")]
  protected virtual Panel frmProducerContacts_Fill_Panel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmProducerContacts_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _frmProducerContacts_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual UltraToolbarsManager menuProducerContacts
  {
    get => this._menuProducerContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.menuProducerContacts_ToolClick);
      UltraToolbarsManager producerContacts1 = this._menuProducerContacts;
      if (producerContacts1 != null)
        producerContacts1.ToolClick -= clickEventHandler;
      this._menuProducerContacts = value;
      UltraToolbarsManager producerContacts2 = this._menuProducerContacts;
      if (producerContacts2 == null)
        return;
      producerContacts2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("_frmProducerContacts_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _frmProducerContacts_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmProducerContacts_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _frmProducerContacts_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmProducerContacts_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _frmProducerContacts_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ctlZipCode")]
  protected virtual AddressResolver_MULTI ctlZipCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDOB")]
  protected virtual MGADateTimePicker dtDOB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDOB")]
  protected virtual Label lblDOB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCEWaived")]
  private virtual MGACheckBox chkCEWaived { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel LinkProducerLocation
  {
    get => this._LinkProducerLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkProducerLocationClicked);
      LinkLabel producerLocation1 = this._LinkProducerLocation;
      if (producerLocation1 != null)
        producerLocation1.LinkClicked -= clickedEventHandler;
      this._LinkProducerLocation = value;
      LinkLabel producerLocation2 = this._LinkProducerLocation;
      if (producerLocation2 == null)
        return;
      producerLocation2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("LinkLabel1")]
  protected virtual LinkLabel LinkLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtComment")]
  protected virtual MGATextBox txtComment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpOfac")]
  protected virtual MGAGroupBox grpOfac { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfacClearedUser")]
  protected virtual Label lblOfacClearedUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfacScore")]
  protected virtual Label lblOfacScore { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  protected virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfacSearchDate")]
  protected virtual Label lblOfacSearchDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  protected virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkOfacCleared
  {
    get => this._chkOfacCleared;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkOfacCleared_CheckedChanged);
      MGACheckBox chkOfacCleared1 = this._chkOfacCleared;
      if (chkOfacCleared1 != null)
        ((UltraToggleEditorBase) chkOfacCleared1).CheckedChanged -= eventHandler;
      this._chkOfacCleared = value;
      MGACheckBox chkOfacCleared2 = this._chkOfacCleared;
      if (chkOfacCleared2 == null)
        return;
      ((UltraToggleEditorBase) chkOfacCleared2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  protected virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckedListBox lstInterest
  {
    get => this._lstInterest;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstInterest_ItemCheck);
      MGACheckedListBox lstInterest1 = this._lstInterest;
      if (lstInterest1 != null)
        lstInterest1.ItemCheck -= checkEventHandler;
      this._lstInterest = value;
      MGACheckedListBox lstInterest2 = this._lstInterest;
      if (lstInterest2 == null)
        return;
      lstInterest2.ItemCheck += checkEventHandler;
    }
  }

  protected virtual MGACheckedListBox lstJobFunction
  {
    get => this._lstJobFunction;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstJobFunction_ItemCheck);
      MGACheckedListBox lstJobFunction1 = this._lstJobFunction;
      if (lstJobFunction1 != null)
        lstJobFunction1.ItemCheck -= checkEventHandler;
      this._lstJobFunction = value;
      MGACheckedListBox lstJobFunction2 = this._lstJobFunction;
      if (lstJobFunction2 == null)
        return;
      lstJobFunction2.ItemCheck += checkEventHandler;
    }
  }

  [field: AccessedThroughProperty("daJobF")]
  private virtual SqlDataAdapter daJobF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand1")]
  private virtual SqlCommand SqlCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand2")]
  private virtual SqlCommand SqlCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand3")]
  private virtual SqlCommand SqlCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand4")]
  private virtual SqlCommand SqlCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daInt")]
  private virtual SqlDataAdapter daInt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand5")]
  private virtual SqlCommand SqlCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand6")]
  private virtual SqlCommand SqlCommand6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand7")]
  private virtual SqlCommand SqlCommand7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand8")]
  private virtual SqlCommand SqlCommand8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkOptOut")]
  private virtual MGACheckBox chkOptOut { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual CheckedListBox chkFilter
  {
    get => this._chkFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.chkFilter_ItemCheck);
      CheckedListBox chkFilter1 = this._chkFilter;
      if (chkFilter1 != null)
        chkFilter1.ItemCheck -= checkEventHandler;
      this._chkFilter = value;
      CheckedListBox chkFilter2 = this._chkFilter;
      if (chkFilter2 == null)
        return;
      chkFilter2.ItemCheck += checkEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label10")]
  protected virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboManagedBy")]
  protected virtual MGASimpleComboBox cboManagedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNPNNo")]
  protected virtual Label lblNPNNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNPNNo")]
  protected virtual MGATextBox txtNPNNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmProducerContacts));
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Contacts");
    ButtonTool buttonTool1 = new ButtonTool("DuplicateContact");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Contacts");
    ButtonTool buttonTool2 = new ButtonTool("DuplicateContact");
    ButtonTool buttonTool3 = new ButtonTool("Predominant Class");
    ButtonTool buttonTool4 = new ButtonTool("Class Specialty");
    ButtonTool buttonTool5 = new ButtonTool("Logging");
    ButtonTool buttonTool6 = new ButtonTool("Predominant Class");
    ButtonTool buttonTool7 = new ButtonTool("Class Specialty");
    ButtonTool buttonTool8 = new ButtonTool("Logging");
    this.grpContactInfo = new MGAGroupBox();
    this.Label12 = new Label();
    this.txtComment = new MGATextBox();
    this.dsContacts = new dsProducerContacts();
    this.chkCEWaived = new MGACheckBox();
    this.lblDOB = new Label();
    this.dtDOB = new MGADateTimePicker();
    this.ctlZipCode = new AddressResolver_MULTI();
    this.lblNPNNo = new Label();
    this.txtNPNNo = new MGATextBox();
    this.Label10 = new Label();
    this.cboManagedBy = new MGASimpleComboBox();
    this.chkOptOut = new MGACheckBox();
    this.lstInterest = new MGACheckedListBox();
    this.lstJobFunction = new MGACheckedListBox();
    this.MgaSimpleComboBox1 = new MGASimpleComboBox();
    this.txtFax = new MGAMaskedEdit();
    this.Label5 = new Label();
    this.txtSSNNo = new MGAMaskedEdit();
    this.txtCell = new MGAMaskedEdit();
    this.txtPhone = new MGAMaskedEdit();
    this.Label11 = new Label();
    this.cbStatus = new MGASimpleComboBox();
    this.chk1099 = new MGACheckBox();
    this.Label1 = new Label();
    this.lstSpecialContacts = new MGACheckedListBox();
    this.btnSpecialContact = new MGAButton();
    this.Label2 = new Label();
    this.txtExt = new MGATextBox();
    this.Label7 = new Label();
    this.cboDeliveryMethod = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.txtEmail = new MGATextBox();
    this.Label13 = new Label();
    this.txtTitle = new MGATextBox();
    this.Label8 = new Label();
    this.Label3 = new Label();
    this.txtLName = new MGATextBox();
    this.lblAddress1 = new Label();
    this.lblAddress2 = new Label();
    this.txtFName = new MGATextBox();
    this.lblPhone = new Label();
    this.lstContacts = new MGAListBox();
    this.dvProducerContacts = new DataView();
    this.ToolTip = new ToolTip(this.components);
    this.daContacts = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daSpecialContacts = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand6 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.lblProducer = new UltraLabel();
    this.err = new ErrorProvider(this.components);
    this.lnkAuthorize = new LinkLabel();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.daFillData = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.MgaGroupBox2 = new MGAGroupBox();
    this.chkFilter = new CheckedListBox();
    this.frmProducerContacts_Fill_Panel = new Panel();
    this.grpOfac = new MGAGroupBox();
    this.lblOfacClearedUser = new Label();
    this.lblOfacScore = new Label();
    this.Label15 = new Label();
    this.lblOfacSearchDate = new Label();
    this.Label14 = new Label();
    this.chkOfacCleared = new MGACheckBox();
    this.LinkProducerLocation = new LinkLabel();
    this._frmProducerContacts_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.menuProducerContacts = new UltraToolbarsManager(this.components);
    this._frmProducerContacts_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmProducerContacts_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmProducerContacts_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.daJobF = new SqlDataAdapter();
    this.SqlCommand1 = new SqlCommand();
    this.SqlCommand2 = new SqlCommand();
    this.SqlCommand3 = new SqlCommand();
    this.SqlCommand4 = new SqlCommand();
    this.daInt = new SqlDataAdapter();
    this.SqlCommand5 = new SqlCommand();
    this.SqlCommand6 = new SqlCommand();
    this.SqlCommand7 = new SqlCommand();
    this.SqlCommand8 = new SqlCommand();
    this.LinkLabel1 = new LinkLabel();
    this.lblSearchDate = new Label();
    this.Label16 = new Label();
    this.LinkSircon = new LinkLabel();
    Label label1 = new Label();
    Label label2 = new Label();
    ((ISupportInitialize) this.grpContactInfo).BeginInit();
    ((Control) this.grpContactInfo).SuspendLayout();
    ((ISupportInitialize) this.txtComment).BeginInit();
    this.dsContacts.BeginInit();
    ((ISupportInitialize) this.chkCEWaived).BeginInit();
    ((ISupportInitialize) this.dtDOB).BeginInit();
    ((ISupportInitialize) this.txtNPNNo).BeginInit();
    ((ISupportInitialize) this.cboManagedBy).BeginInit();
    ((ISupportInitialize) this.chkOptOut).BeginInit();
    ((ISupportInitialize) this.lstInterest).BeginInit();
    ((ISupportInitialize) this.lstJobFunction).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).BeginInit();
    ((ISupportInitialize) this.txtFax).BeginInit();
    ((ISupportInitialize) this.txtSSNNo).BeginInit();
    ((ISupportInitialize) this.txtCell).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.cbStatus).BeginInit();
    ((ISupportInitialize) this.chk1099).BeginInit();
    ((ISupportInitialize) this.lstSpecialContacts).BeginInit();
    ((ISupportInitialize) this.btnSpecialContact).BeginInit();
    ((ISupportInitialize) this.txtExt).BeginInit();
    ((ISupportInitialize) this.cboDeliveryMethod).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.txtLName).BeginInit();
    ((ISupportInitialize) this.txtFName).BeginInit();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    this.dvProducerContacts.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox2).BeginInit();
    ((Control) this.MgaGroupBox2).SuspendLayout();
    this.frmProducerContacts_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.grpOfac).BeginInit();
    ((Control) this.grpOfac).SuspendLayout();
    ((ISupportInitialize) this.chkOfacCleared).BeginInit();
    ((ISupportInitialize) this.menuProducerContacts).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(423, 305);
    label1.Name = "Label6";
    label1.Size = new Size(68, 13);
    label1.TabIndex = 163;
    label1.Text = "Job Function";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(423, 36);
    label2.Name = "Label9";
    label2.Size = new Size(51, 13);
    label2.TabIndex = 164;
    label2.Text = "Interests";
    label2.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpContactInfo.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label12);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtComment);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.chkCEWaived);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblDOB);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.dtDOB);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.ctlZipCode);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblNPNNo);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtNPNNo);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label10);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.cboManagedBy);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.chkOptOut);
    ((Control) this.grpContactInfo).Controls.Add((Control) label2);
    ((Control) this.grpContactInfo).Controls.Add((Control) label1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lstInterest);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lstJobFunction);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.MgaSimpleComboBox1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtFax);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label5);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtSSNNo);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtCell);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtPhone);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label11);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.cbStatus);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.chk1099);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lstSpecialContacts);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.btnSpecialContact);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label2);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtExt);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label7);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.cboDeliveryMethod);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label4);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtEmail);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label13);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtTitle);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label8);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label3);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtLName);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblAddress1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblAddress2);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtFName);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblPhone);
    ((Control) this.grpContactInfo).Enabled = false;
    appearance2.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpContactInfo.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpContactInfo).Location = new Point(175, 42);
    ((Control) this.grpContactInfo).Name = "grpContactInfo";
    ((Control) this.grpContactInfo).Size = new Size(599, 542);
    ((Control) this.grpContactInfo).TabIndex = 0;
    this.grpContactInfo.Text = "Contact Information";
    this.grpContactInfo.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(266, 299);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label12.TabIndex = 489;
    this.Label12.Text = "Comment";
    this.Label12.TextAlign = ContentAlignment.MiddleLeft;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComment).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtComment).BackColor = Color.White;
    ((Control) this.txtComment).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblProducerContacts.Comment", true));
    ((Control) this.txtComment).Location = new Point(269, 318);
    ((TextEditorControlBase) this.txtComment).MaxLength = 50;
    this.txtComment.MGAStyle = MGAStyles.Blue;
    this.txtComment.Multiline = true;
    ((Control) this.txtComment).Name = "txtComment";
    ((Control) this.txtComment).Size = new Size(136, 212);
    ((Control) this.txtComment).TabIndex = 488;
    ((UltraControlBase) this.txtComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComment).UseOsThemes = (DefaultableBoolean) 2;
    this.dsContacts.DataSetName = "dsProducerContacts";
    this.dsContacts.Locale = new CultureInfo("en-US");
    this.dsContacts.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCEWaived).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkCEWaived).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCEWaived).BackColorInternal = Color.Transparent;
    ((Control) this.chkCEWaived).DataBindings.Add(new Binding("Checked", (object) this.dsContacts, "tblProducerContacts.CEWaived", true));
    ((UltraToggleEditorBase) this.chkCEWaived).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCEWaived).Location = new Point(133, 305);
    this.chkCEWaived.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCEWaived).Name = "chkCEWaived";
    ((Control) this.chkCEWaived).Size = new Size(86, 20);
    ((Control) this.chkCEWaived).TabIndex = 487;
    ((UltraToggleEditorBase) this.chkCEWaived).Text = "CE Waived";
    ((UltraControlBase) this.chkCEWaived).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCEWaived).UseOsThemes = (DefaultableBoolean) 2;
    this.lblDOB.AutoSize = true;
    this.lblDOB.BackColor = Color.Transparent;
    this.lblDOB.Location = new Point(29, 360);
    this.lblDOB.Name = "lblDOB";
    this.lblDOB.Size = new Size(28, 13);
    this.lblDOB.TabIndex = 486;
    this.lblDOB.Text = "DOB";
    this.lblDOB.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtDOB.Appearance = (AppearanceBase) appearance5;
    this.dtDOB.BackColor = Color.White;
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
    this.dtDOB.ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.dtDOB).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.DOB", true));
    this.dtDOB.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtDOB).Location = new Point(64 /*0x40*/, 356);
    this.dtDOB.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtDOB).Name = "dtDOB";
    ((Control) this.dtDOB).Size = new Size(104, 20);
    ((Control) this.dtDOB).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.dtDOB).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDOB).UseOsThemes = (DefaultableBoolean) 2;
    this.dtDOB.Value = (object) null;
    this.ctlZipCode.Address1 = "";
    this.ctlZipCode.Address2 = "";
    ((Control) this.ctlZipCode).BackColor = Color.Transparent;
    this.ctlZipCode.City = "";
    this.ctlZipCode.County = "";
    ((Control) this.ctlZipCode).Font = new Font("Tahoma", 8f);
    this.ctlZipCode.ISOCountryCode = "";
    this.ctlZipCode.ISOCountryCodeMember = "";
    this.ctlZipCode.ISOCountryList = (object) null;
    this.ctlZipCode.ISOCountryNameMember = "";
    ((Control) this.ctlZipCode).Location = new Point(14, 381);
    this.ctlZipCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.ctlZipCode).Name = "ctlZipCode";
    this.ctlZipCode.Password = (string) null;
    ((Control) this.ctlZipCode).Size = new Size(249, 154);
    this.ctlZipCode.State = "";
    ((Control) this.ctlZipCode).TabIndex = 16 /*0x10*/;
    this.ctlZipCode.TextAlign = ContentAlignment.MiddleCenter;
    this.ctlZipCode.UserID = (string) null;
    this.ctlZipCode.WebserviceUrl = (string) null;
    this.ctlZipCode.ZipCode = "";
    this.ctlZipCode.ZipCodeExtension = "";
    this.lblNPNNo.AutoSize = true;
    this.lblNPNNo.BackColor = Color.Transparent;
    this.lblNPNNo.Location = new Point(18, 332);
    this.lblNPNNo.Name = "lblNPNNo";
    this.lblNPNNo.Size = new Size(43, 13);
    this.lblNPNNo.TabIndex = 169;
    this.lblNPNNo.Text = "NPN No";
    this.lblNPNNo.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNPNNo).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtNPNNo).BackColor = Color.White;
    ((Control) this.txtNPNNo).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblProducerContacts.NPNNo", true));
    ((Control) this.txtNPNNo).Location = new Point(64 /*0x40*/, 330);
    ((TextEditorControlBase) this.txtNPNNo).MaxLength = 50;
    this.txtNPNNo.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNPNNo).Name = "txtNPNNo";
    ((Control) this.txtNPNNo).Size = new Size(132, 20);
    ((Control) this.txtNPNNo).TabIndex = 15;
    ((UltraControlBase) this.txtNPNNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNPNNo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(11, 237);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(49, 13);
    this.Label10.TabIndex = 167;
    this.Label10.Text = "Manager";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.cboManagedBy.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboManagedBy).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.ManagedBy", true));
    ((UltraGridBase) this.cboManagedBy).DataMember = "tblProducerContactsCopy";
    ((UltraGridBase) this.cboManagedBy).DataSource = (object) this.dsContacts;
    ((UltraDropDownBase) this.cboManagedBy).DisplayMember = "Name";
    this.cboManagedBy.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboManagedBy).Location = new Point(64 /*0x40*/, 235);
    this.cboManagedBy.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboManagedBy).Name = "cboManagedBy";
    ((Control) this.cboManagedBy).Size = new Size(132, 21);
    ((Control) this.cboManagedBy).TabIndex = 11;
    ((UltraControlBase) this.cboManagedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboManagedBy).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboManagedBy).ValueMember = "ProducerContactGUID";
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOptOut).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.chkOptOut).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOptOut).BackColorInternal = Color.Transparent;
    ((Control) this.chkOptOut).DataBindings.Add(new Binding("Checked", (object) this.dsContacts, "tblProducerContacts.OptOut", true));
    ((UltraToggleEditorBase) this.chkOptOut).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOptOut).Location = new Point(64 /*0x40*/, 304);
    this.chkOptOut.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOptOut).Name = "chkOptOut";
    ((Control) this.chkOptOut).Size = new Size(72, 20);
    ((Control) this.chkOptOut).TabIndex = 14;
    ((UltraToggleEditorBase) this.chkOptOut).Text = "Opt Out ";
    ((UltraControlBase) this.chkOptOut).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOptOut).UseOsThemes = (DefaultableBoolean) 2;
    this.lstInterest.CheckOnClick = true;
    this.lstInterest.Location = new Point(426, 51);
    this.lstInterest.MGAStyle = MGAStyles.Blue;
    this.lstInterest.Name = "lstInterest";
    this.lstInterest.Size = new Size(166, 244);
    this.lstInterest.TabIndex = 162;
    this.lstJobFunction.CheckOnClick = true;
    this.lstJobFunction.Location = new Point(426, 318);
    this.lstJobFunction.MGAStyle = MGAStyles.Blue;
    this.lstJobFunction.Name = "lstJobFunction";
    this.lstJobFunction.Size = new Size(166, 212);
    this.lstJobFunction.TabIndex = 18;
    this.MgaSimpleComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox1).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.Salutation", true));
    ((UltraGridBase) this.MgaSimpleComboBox1).DataSource = (object) this.dsContacts.lstSalutations;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DisplayMember = "Salutation";
    this.MgaSimpleComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaSimpleComboBox1).Location = new Point(64 /*0x40*/, 28);
    this.MgaSimpleComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox1).Name = "MgaSimpleComboBox1";
    ((Control) this.MgaSimpleComboBox1).Size = new Size(63 /*0x3F*/, 21);
    ((Control) this.MgaSimpleComboBox1).TabIndex = 0;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).ValueMember = "Salutation";
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFax.Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtFax).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.Fax", true));
    this.txtFax.EditAs = (EditAsType) 1;
    this.txtFax.InputMask = "###-###-####";
    ((Control) this.txtFax).Location = new Point(64 /*0x40*/, 189);
    this.txtFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFax).Name = "txtFax";
    this.txtFax.NonAutoSizeHeight = 20;
    ((Control) this.txtFax).Size = new Size(77, 21);
    ((Control) this.txtFax).TabIndex = 9;
    this.txtFax.Text = "--";
    ((UltraControlBase) this.txtFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFax).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(38, 191);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(25, 13);
    this.Label5.TabIndex = 159;
    this.Label5.Text = "Fax";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtSSNNo.Appearance = (AppearanceBase) appearance10;
    ((Control) this.txtSSNNo).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.SSNo", true));
    this.txtSSNNo.EditAs = (EditAsType) 1;
    this.txtSSNNo.InputMask = "###-##-####";
    ((Control) this.txtSSNNo).Location = new Point(64 /*0x40*/, 120);
    this.txtSSNNo.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSSNNo).Name = "txtSSNNo";
    this.txtSSNNo.NonAutoSizeHeight = 20;
    ((Control) this.txtSSNNo).Size = new Size(77, 21);
    ((Control) this.txtSSNNo).TabIndex = 5;
    this.txtSSNNo.Text = "--";
    ((UltraControlBase) this.txtSSNNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSSNNo).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtCell.Appearance = (AppearanceBase) appearance11;
    ((Control) this.txtCell).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.Cell", true));
    this.txtCell.EditAs = (EditAsType) 1;
    this.txtCell.InputMask = "###-###-####";
    ((Control) this.txtCell).Location = new Point(64 /*0x40*/, 166);
    this.txtCell.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCell).Name = "txtCell";
    this.txtCell.NonAutoSizeHeight = 20;
    ((Control) this.txtCell).Size = new Size(77, 21);
    ((Control) this.txtCell).TabIndex = 8;
    this.txtCell.Text = "--";
    ((UltraControlBase) this.txtCell).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCell).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtPhone.Appearance = (AppearanceBase) appearance12;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.Phone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    this.txtPhone.InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(64 /*0x40*/, 143);
    this.txtPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(77, 21);
    ((Control) this.txtPhone).TabIndex = 6;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(25, 283);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(38, 13);
    this.Label11.TabIndex = 157;
    this.Label11.Text = "Status";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.cbStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbStatus).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.StatusID", true));
    ((UltraGridBase) this.cbStatus).DataSource = (object) this.dsContacts.lstStatus;
    ((UltraDropDownBase) this.cbStatus).DisplayMember = "Status";
    this.cbStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStatus).Location = new Point(64 /*0x40*/, 281);
    this.cbStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStatus).Name = "cbStatus";
    ((Control) this.cbStatus).Size = new Size(132, 21);
    ((Control) this.cbStatus).TabIndex = 13;
    ((UltraControlBase) this.cbStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStatus).ValueMember = "StatusID";
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chk1099).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chk1099).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chk1099).BackColorInternal = Color.Transparent;
    ((Control) this.chk1099).DataBindings.Add(new Binding("Checked", (object) this.dsContacts, "tblProducerContacts.Req1099", true));
    ((UltraToggleEditorBase) this.chk1099).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chk1099).Location = new Point(148, 26);
    this.chk1099.MGAStyle = MGAStyles.Blue;
    ((Control) this.chk1099).Name = "chk1099";
    ((Control) this.chk1099).Size = new Size(48 /*0x30*/, 24);
    ((Control) this.chk1099).TabIndex = 1;
    ((UltraToggleEditorBase) this.chk1099).Text = "1099";
    ((UltraControlBase) this.chk1099).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chk1099).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(23, 122);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(39, 13);
    this.Label1.TabIndex = 151;
    this.Label1.Text = "SS No.";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.lstSpecialContacts.CheckOnClick = true;
    this.lstSpecialContacts.Location = new Point(217, 53);
    this.lstSpecialContacts.MGAStyle = MGAStyles.Blue;
    this.lstSpecialContacts.Name = "lstSpecialContacts";
    this.lstSpecialContacts.Size = new Size(188, 244);
    this.lstSpecialContacts.TabIndex = 17;
    appearance14.BackColor = Color.FromArgb(248, 248, 248);
    appearance14.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = Color.DarkGray;
    appearance14.ImageHAlign = (HAlign) 2;
    appearance14.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSpecialContact).Appearance = (AppearanceBase) appearance14;
    ((Control) this.btnSpecialContact).Location = new Point(301, 30);
    ((Control) this.btnSpecialContact).Name = "btnSpecialContact";
    ((Control) this.btnSpecialContact).Size = new Size(28, 16 /*0x10*/);
    ((Control) this.btnSpecialContact).TabIndex = 149;
    ((ControlBase) this.btnSpecialContact).Text = "...";
    this.btnSpecialContact.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(203, 30);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label2.TabIndex = 148;
    this.Label2.Text = "Special Contacts";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtExt).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.txtExt).BackColor = Color.White;
    ((Control) this.txtExt).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblProducerContacts.Extension", true));
    ((Control) this.txtExt).Location = new Point(147, 143);
    this.txtExt.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtExt).Name = "txtExt";
    ((Control) this.txtExt).Size = new Size(49, 20);
    ((Control) this.txtExt).TabIndex = 7;
    ((UltraControlBase) this.txtExt).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExt).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(16 /*0x10*/, 260);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(46, 13);
    this.Label7.TabIndex = 136;
    this.Label7.Text = "Delivery";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.cboDeliveryMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDeliveryMethod).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblProducerContacts.DeliveryMethodID", true));
    ((UltraGridBase) this.cboDeliveryMethod).DataSource = (object) this.dsContacts.lstDeliveryMethod;
    ((UltraDropDownBase) this.cboDeliveryMethod).DisplayMember = "Description";
    this.cboDeliveryMethod.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeliveryMethod).Location = new Point(64 /*0x40*/, 258);
    this.cboDeliveryMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeliveryMethod).Name = "cboDeliveryMethod";
    ((Control) this.cboDeliveryMethod).Size = new Size(132, 21);
    ((Control) this.cboDeliveryMethod).TabIndex = 12;
    ((UltraControlBase) this.cboDeliveryMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeliveryMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDeliveryMethod).ValueMember = "DeliveryMethodID";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(6, 30);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(55, 13);
    this.Label4.TabIndex = 130;
    this.Label4.Text = "Salutation";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblProducerContacts.Email", true));
    ((Control) this.txtEmail).Location = new Point(64 /*0x40*/, 212);
    ((TextEditorControlBase) this.txtEmail).MaxLength = 50;
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(132, 20);
    ((Control) this.txtEmail).TabIndex = 10;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(29, 214);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(31 /*0x1F*/, 13);
    this.Label13.TabIndex = 121;
    this.Label13.Text = "Email";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTitle).Appearance = (AppearanceBase) appearance17;
    ((TextEditorControlBase) this.txtTitle).BackColor = Color.White;
    ((Control) this.txtTitle).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblProducerContacts.Title", true));
    ((Control) this.txtTitle).Location = new Point(64 /*0x40*/, 97);
    ((TextEditorControlBase) this.txtTitle).MaxLength = 50;
    this.txtTitle.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTitle).Name = "txtTitle";
    ((Control) this.txtTitle).Size = new Size(132, 20);
    ((Control) this.txtTitle).TabIndex = 4;
    ((UltraControlBase) this.txtTitle).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTitle).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(34, 99);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(27, 13);
    this.Label8.TabIndex = 111;
    this.Label8.Text = "Title";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(38, 168);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(24, 13);
    this.Label3.TabIndex = 98;
    this.Label3.Text = "Cell";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLName).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.txtLName).BackColor = Color.White;
    ((Control) this.txtLName).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblProducerContacts.LName", true));
    ((Control) this.txtLName).Location = new Point(64 /*0x40*/, 74);
    ((TextEditorControlBase) this.txtLName).MaxLength = 50;
    this.txtLName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLName).Name = "txtLName";
    ((Control) this.txtLName).Size = new Size(132, 20);
    ((Control) this.txtLName).TabIndex = 3;
    ((UltraControlBase) this.txtLName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblAddress1.AutoSize = true;
    this.lblAddress1.BackColor = Color.Transparent;
    this.lblAddress1.Location = new Point(34, 53);
    this.lblAddress1.Name = "lblAddress1";
    this.lblAddress1.Size = new Size(28, 13);
    this.lblAddress1.TabIndex = 89;
    this.lblAddress1.Text = "First";
    this.lblAddress1.TextAlign = ContentAlignment.MiddleRight;
    this.lblAddress2.AutoSize = true;
    this.lblAddress2.BackColor = Color.Transparent;
    this.lblAddress2.Location = new Point(35, 76);
    this.lblAddress2.Name = "lblAddress2";
    this.lblAddress2.Size = new Size(27, 13);
    this.lblAddress2.TabIndex = 90;
    this.lblAddress2.Text = "Last";
    this.lblAddress2.TextAlign = ContentAlignment.MiddleRight;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFName).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.txtFName).BackColor = Color.White;
    ((Control) this.txtFName).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblProducerContacts.FName", true));
    ((Control) this.txtFName).Location = new Point(64 /*0x40*/, 51);
    ((TextEditorControlBase) this.txtFName).MaxLength = 50;
    this.txtFName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFName).Name = "txtFName";
    ((Control) this.txtFName).Size = new Size(132, 20);
    ((Control) this.txtFName).TabIndex = 2;
    ((UltraControlBase) this.txtFName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(25, 145);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(37, 13);
    this.lblPhone.TabIndex = 92;
    this.lblPhone.Text = "Phone";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    this.lstContacts.DataSource = (object) this.dvProducerContacts;
    this.lstContacts.DisplayMember = "Name";
    this.lstContacts.Location = new Point(7, 30);
    this.lstContacts.MGAStyle = MGAStyles.Blue;
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(150, 353);
    this.lstContacts.TabIndex = 0;
    this.lstContacts.ValueMember = "ProducerContactGuid";
    this.dvProducerContacts.Table = (DataTable) this.dsContacts.tblProducerContacts;
    this.daContacts.DeleteCommand = this.SqlDeleteCommand1;
    this.daContacts.InsertCommand = this.SqlInsertCommand1;
    this.daContacts.SelectCommand = this.SqlSelectCommand2;
    this.daContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerContacts", new DataColumnMapping[36]
      {
        new DataColumnMapping("ProducerContactID", "ProducerContactID"),
        new DataColumnMapping("ProducerContactGUID", "ProducerContactGUID"),
        new DataColumnMapping("ProducerLocationGUID", "ProducerLocationGUID"),
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("FName", "FName"),
        new DataColumnMapping("LName", "LName"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Title", "Title"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Extension", "Extension"),
        new DataColumnMapping("Cell", "Cell"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("Salutation", "Salutation"),
        new DataColumnMapping("SSNo", "SSNo"),
        new DataColumnMapping("Req1099", "Req1099"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("OptOut", "OptOut"),
        new DataColumnMapping("AddByUserID", "AddByUserID"),
        new DataColumnMapping("DateAdded", "DateAdded"),
        new DataColumnMapping("DateModified", "DateModified"),
        new DataColumnMapping("EmailEditedBy", "EmailEditedBy"),
        new DataColumnMapping("DateEmailEdited", "DateEmailEdited"),
        new DataColumnMapping("ManagedBy", "ManagedBy"),
        new DataColumnMapping("NPNNo", "NPNNo"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("DOB", "DOB"),
        new DataColumnMapping("CEWaived", "CEWaived"),
        new DataColumnMapping("Comment", "Comment")
      })
    });
    this.daContacts.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblProducerContacts] WHERE (([ProducerContactID] = @Original_ProducerContactID))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ProducerContactID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[34]
    {
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 0, "ProducerContactGUID"),
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGUID"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 0, "DeliveryMethodID"),
      new SqlParameter("@FName", SqlDbType.VarChar, 0, "FName"),
      new SqlParameter("@LName", SqlDbType.VarChar, 0, "LName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 0, "Title"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Extension", SqlDbType.VarChar, 0, "Extension"),
      new SqlParameter("@Cell", SqlDbType.VarChar, 0, "Cell"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 0, "Salutation"),
      new SqlParameter("@SSNo", SqlDbType.VarChar, 0, "SSNo"),
      new SqlParameter("@Req1099", SqlDbType.Bit, 0, "Req1099"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@OptOut", SqlDbType.Bit, 0, "OptOut"),
      new SqlParameter("@AddByUserID", SqlDbType.Int, 0, "AddByUserID"),
      new SqlParameter("@DateAdded", SqlDbType.DateTime, 0, "DateAdded"),
      new SqlParameter("@DateModified", SqlDbType.DateTime, 0, "DateModified"),
      new SqlParameter("@EmailEditedBy", SqlDbType.Int, 0, "EmailEditedBy"),
      new SqlParameter("@DateEmailEdited", SqlDbType.DateTime, 0, "DateEmailEdited"),
      new SqlParameter("@ManagedBy", SqlDbType.UniqueIdentifier, 0, "ManagedBy"),
      new SqlParameter("@NPNNo", SqlDbType.VarChar, 0, "NPNNo"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@DOB", SqlDbType.DateTime, 0, "DOB"),
      new SqlParameter("@CEWaived", SqlDbType.Bit, 0, "CEWaived"),
      new SqlParameter("@Comment", SqlDbType.VarChar, 0, "Comment")
    });
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[35]
    {
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 0, "ProducerContactGUID"),
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGUID"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 0, "DeliveryMethodID"),
      new SqlParameter("@FName", SqlDbType.VarChar, 0, "FName"),
      new SqlParameter("@LName", SqlDbType.VarChar, 0, "LName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 0, "Title"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Extension", SqlDbType.VarChar, 0, "Extension"),
      new SqlParameter("@Cell", SqlDbType.VarChar, 0, "Cell"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 0, "Salutation"),
      new SqlParameter("@SSNo", SqlDbType.VarChar, 0, "SSNo"),
      new SqlParameter("@Req1099", SqlDbType.Bit, 0, "Req1099"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@OptOut", SqlDbType.Bit, 0, "OptOut"),
      new SqlParameter("@AddByUserID", SqlDbType.Int, 0, "AddByUserID"),
      new SqlParameter("@DateAdded", SqlDbType.DateTime, 0, "DateAdded"),
      new SqlParameter("@DateModified", SqlDbType.DateTime, 0, "DateModified"),
      new SqlParameter("@EmailEditedBy", SqlDbType.Int, 0, "EmailEditedBy"),
      new SqlParameter("@DateEmailEdited", SqlDbType.DateTime, 0, "DateEmailEdited"),
      new SqlParameter("@ManagedBy", SqlDbType.UniqueIdentifier, 0, "ManagedBy"),
      new SqlParameter("@NPNNo", SqlDbType.VarChar, 0, "NPNNo"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@DOB", SqlDbType.DateTime, 0, "DOB"),
      new SqlParameter("@CEWaived", SqlDbType.Bit, 0, "CEWaived"),
      new SqlParameter("@Comment", SqlDbType.VarChar, 0, "Comment"),
      new SqlParameter("@Original_ProducerContactID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactID", DataRowVersion.Original, (object) null)
    });
    this.daSpecialContacts.DeleteCommand = this.SqlDeleteCommand2;
    this.daSpecialContacts.InsertCommand = this.SqlInsertCommand2;
    this.daSpecialContacts.SelectCommand = this.SqlSelectCommand6;
    this.daSpecialContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerSpecialContacts", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerContactGuid", "ProducerContactGuid"),
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID")
      })
    });
    this.daSpecialContacts.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM tblProducerSpecialContacts WHERE (ProducerContactGuid = @Original_ProducerContactGuid) AND (SpecialContactTypeID = @Original_SpecialContactTypeID)";
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = "INSERT INTO tblProducerSpecialContacts(ProducerContactGuid, SpecialContactTypeID) VALUES (@ProducerContactGuid, @SpecialContactTypeID)";
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGuid"),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID")
    });
    this.SqlSelectCommand6.CommandText = "SELECT ProducerContactGUID, SpecialContactTypeID FROM tblProducerSpecialContacts WHERE (ProducerContactGUID = @ProducerContactGuid)";
    this.SqlSelectCommand6.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGUID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGuid"),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID"),
      new SqlParameter("@Original_ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null)
    });
    ((AppearanceBase) appearance20).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance20).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblProducer).Appearance = (AppearanceBase) appearance20;
    ((Control) this.lblProducer).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblProducer).Location = new Point(10, 5);
    ((Control) this.lblProducer).Name = "lblProducer";
    ((Control) this.lblProducer).Size = new Size(764, 32 /*0x20*/);
    ((Control) this.lblProducer).TabIndex = 5;
    ((ControlBase) this.lblProducer).Text = "Label2";
    this.err.ContainerControl = (ContainerControl) this;
    this.lnkAuthorize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkAuthorize.Cursor = Cursors.Hand;
    this.lnkAuthorize.Location = new Point(300, 589);
    this.lnkAuthorize.Name = "lnkAuthorize";
    this.lnkAuthorize.Size = new Size(196, 23);
    this.lnkAuthorize.TabIndex = 6;
    this.lnkAuthorize.TabStop = true;
    this.lnkAuthorize.Text = "Authorize Contact for External Access";
    this.lnkAuthorize.TextAlign = ContentAlignment.MiddleCenter;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(655, 600);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 7;
    this.daFillData.SelectCommand = this.SqlSelectCommand1;
    this.daFillData.TableMappings.AddRange(new DataTableMapping[4]
    {
      new DataTableMapping("Table", "dbo_spGetProducerContactsFormData", new DataColumnMapping[2]
      {
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID"),
        new DataColumnMapping("SpecialContactType", "SpecialContactType")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Status", "Status")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[1]
      {
        new DataColumnMapping("Salutation", "Salutation")
      })
    });
    this.SqlSelectCommand1.CommandText = "dbo.[spGetProducerContactsFormData]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@SpecialContactsOnly", SqlDbType.Bit, 1)
    });
    appearance21.BackColor = Color.FromArgb(239, 247, 253);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance21;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaGroupBox2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lstContacts);
    appearance22.ForeColor = Color.FromArgb(21, 66, 139);
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance22;
    ((Control) this.MgaGroupBox1).Location = new Point(5, 40);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(165, 544);
    ((Control) this.MgaGroupBox1).TabIndex = 8;
    this.MgaGroupBox1.Text = "Contacts";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    appearance23.BackColor = Color.FromArgb(239, 247, 253);
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance23;
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.chkFilter);
    appearance24.ForeColor = Color.FromArgb(21, 66, 139);
    this.MgaGroupBox2.HeaderAppearance = (AppearanceBase) appearance24;
    ((Control) this.MgaGroupBox2).Location = new Point(7, 385);
    ((Control) this.MgaGroupBox2).Name = "MgaGroupBox2";
    ((Control) this.MgaGroupBox2).Size = new Size(150, 131);
    ((Control) this.MgaGroupBox2).TabIndex = 9;
    this.MgaGroupBox2.Text = "Filter";
    this.MgaGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    this.chkFilter.BackColor = Color.FromArgb(239, 247, 253);
    this.chkFilter.BorderStyle = BorderStyle.None;
    this.chkFilter.Dock = DockStyle.Fill;
    this.chkFilter.FormattingEnabled = true;
    this.chkFilter.Items.AddRange(new object[6]
    {
      (object) "1",
      (object) "2",
      (object) "3",
      (object) "4",
      (object) "5",
      (object) "6"
    });
    this.chkFilter.Location = new Point(2, 19);
    this.chkFilter.Name = "chkFilter";
    this.chkFilter.Size = new Size(146, 110);
    this.chkFilter.TabIndex = 9;
    this.frmProducerContacts_Fill_Panel.AutoSize = true;
    this.frmProducerContacts_Fill_Panel.Controls.Add((Control) this.LinkSircon);
    this.frmProducerContacts_Fill_Panel.Controls.Add((Control) this.grpOfac);
    this.frmProducerContacts_Fill_Panel.Controls.Add((Control) this.LinkProducerLocation);
    this.frmProducerContacts_Fill_Panel.Controls.Add((Control) this.MgaGroupBox1);
    this.frmProducerContacts_Fill_Panel.Controls.Add((Control) this.dbSave);
    this.frmProducerContacts_Fill_Panel.Controls.Add((Control) this.lnkAuthorize);
    this.frmProducerContacts_Fill_Panel.Controls.Add((Control) this.lblProducer);
    this.frmProducerContacts_Fill_Panel.Controls.Add((Control) this.grpContactInfo);
    this.frmProducerContacts_Fill_Panel.Cursor = Cursors.Default;
    this.frmProducerContacts_Fill_Panel.Dock = DockStyle.Fill;
    this.frmProducerContacts_Fill_Panel.Location = new Point(0, 21);
    this.frmProducerContacts_Fill_Panel.Name = "frmProducerContacts_Fill_Panel";
    this.frmProducerContacts_Fill_Panel.Size = new Size(796, 669);
    this.frmProducerContacts_Fill_Panel.TabIndex = 0;
    ((Control) this.grpOfac).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    appearance25.BackColor = Color.FromArgb(239, 247, 253);
    this.grpOfac.ContentAreaAppearance = (AppearanceBase) appearance25;
    ((Control) this.grpOfac).Controls.Add((Control) this.lblOfacClearedUser);
    ((Control) this.grpOfac).Controls.Add((Control) this.lblOfacScore);
    ((Control) this.grpOfac).Controls.Add((Control) this.Label15);
    ((Control) this.grpOfac).Controls.Add((Control) this.lblOfacSearchDate);
    ((Control) this.grpOfac).Controls.Add((Control) this.Label14);
    ((Control) this.grpOfac).Controls.Add((Control) this.chkOfacCleared);
    appearance26.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpOfac.HeaderAppearance = (AppearanceBase) appearance26;
    ((Control) this.grpOfac).Location = new Point(5, 590);
    ((Control) this.grpOfac).Name = "grpOfac";
    ((Control) this.grpOfac).Size = new Size(270, 67);
    ((Control) this.grpOfac).TabIndex = 10;
    this.grpOfac.Text = "OFAC";
    this.grpOfac.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.grpOfac).Visible = false;
    this.lblOfacClearedUser.BackColor = Color.Transparent;
    this.lblOfacClearedUser.Location = new Point(111, 43);
    this.lblOfacClearedUser.Name = "lblOfacClearedUser";
    this.lblOfacClearedUser.Size = new Size(154, 13);
    this.lblOfacClearedUser.TabIndex = 121;
    this.lblOfacClearedUser.Text = "By: <CLEARUSER>";
    this.lblOfacClearedUser.TextAlign = ContentAlignment.MiddleCenter;
    this.lblOfacScore.AutoSize = true;
    this.lblOfacScore.BackColor = Color.Transparent;
    this.lblOfacScore.Location = new Point(51, 44);
    this.lblOfacScore.Name = "lblOfacScore";
    this.lblOfacScore.Size = new Size(31 /*0x1F*/, 13);
    this.lblOfacScore.TabIndex = 121;
    this.lblOfacScore.Text = "###";
    this.lblOfacScore.TextAlign = ContentAlignment.MiddleRight;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(7, 44);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(38, 13);
    this.Label15.TabIndex = 121;
    this.Label15.Text = "Score:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.lblOfacSearchDate.AutoSize = true;
    this.lblOfacSearchDate.BackColor = Color.Transparent;
    this.lblOfacSearchDate.Location = new Point(51, 22);
    this.lblOfacSearchDate.Name = "lblOfacSearchDate";
    this.lblOfacSearchDate.Size = new Size(67, 13);
    this.lblOfacSearchDate.TabIndex = 121;
    this.lblOfacSearchDate.Text = "yyyy-MM-dd";
    this.lblOfacSearchDate.TextAlign = ContentAlignment.MiddleRight;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(7, 22);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(34, 13);
    this.Label14.TabIndex = 121;
    this.Label14.Text = "Date:";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOfacCleared).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.chkOfacCleared).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOfacCleared).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOfacCleared).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOfacCleared).Location = new Point(133, 20);
    this.chkOfacCleared.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOfacCleared).Name = "chkOfacCleared";
    ((Control) this.chkOfacCleared).Size = new Size(132, 20);
    ((Control) this.chkOfacCleared).TabIndex = 14;
    ((UltraToggleEditorBase) this.chkOfacCleared).Text = "Cleared: yyyy-MM-dd";
    ((UltraControlBase) this.chkOfacCleared).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOfacCleared).UseOsThemes = (DefaultableBoolean) 2;
    this.LinkProducerLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.LinkProducerLocation.Cursor = Cursors.Hand;
    this.LinkProducerLocation.Location = new Point(300, 613);
    this.LinkProducerLocation.Name = "LinkProducerLocation";
    this.LinkProducerLocation.Size = new Size(196, 23);
    this.LinkProducerLocation.TabIndex = 9;
    this.LinkProducerLocation.TabStop = true;
    this.LinkProducerLocation.Text = "Producer Location ";
    this.LinkProducerLocation.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmProducerContacts_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Left).Location = new Point(0, 21);
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Left).Name = "_frmProducerContacts_Toolbars_Dock_Area_Left";
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Left).Size = new Size(0, 669);
    this._frmProducerContacts_Toolbars_Dock_Area_Left.ToolbarsManager = this.menuProducerContacts;
    this.menuProducerContacts.DesignerFlags = 1;
    this.menuProducerContacts.DockWithinContainer = (Control) this;
    this.menuProducerContacts.DockWithinContainerBaseType = typeof (Form);
    this.menuProducerContacts.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "MainMenu";
    this.menuProducerContacts.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Duplicate Contact under another Location";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Contacts";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5
    });
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Predominant Class";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Class Specialty";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Logging";
    this.menuProducerContacts.Tools.AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool1,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmProducerContacts_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Right).Location = new Point(796, 21);
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Right).Name = "_frmProducerContacts_Toolbars_Dock_Area_Right";
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Right).Size = new Size(0, 669);
    this._frmProducerContacts_Toolbars_Dock_Area_Right.ToolbarsManager = this.menuProducerContacts;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmProducerContacts_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Top).Name = "_frmProducerContacts_Toolbars_Dock_Area_Top";
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Top).Size = new Size(796, 21);
    this._frmProducerContacts_Toolbars_Dock_Area_Top.ToolbarsManager = this.menuProducerContacts;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmProducerContacts_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Bottom).Location = new Point(0, 690);
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Bottom).Name = "_frmProducerContacts_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmProducerContacts_Toolbars_Dock_Area_Bottom).Size = new Size(796, 0);
    this._frmProducerContacts_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.menuProducerContacts;
    this.daJobF.DeleteCommand = this.SqlCommand1;
    this.daJobF.InsertCommand = this.SqlCommand2;
    this.daJobF.SelectCommand = this.SqlCommand3;
    this.daJobF.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerContactJobFunctions", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerContactGuid", "ProducerContactGuid"),
        new DataColumnMapping("JobFunctionID", "JobFunctionID")
      })
    });
    this.daJobF.UpdateCommand = this.SqlCommand4;
    this.SqlCommand1.CommandText = "DELETE FROM [dbo].[tblProducerContactJobFunctions] WHERE (([ProducerContactGuid] = @Original_ProducerContactGuid) AND ([JobFunctionID] = @Original_JobFunctionID))";
    this.SqlCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_ProducerContactGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_JobFunctionID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "JobFunctionID", DataRowVersion.Original, (object) null)
    });
    this.SqlCommand2.CommandText = componentResourceManager.GetString("SqlCommand2.CommandText");
    this.SqlCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 0, "ProducerContactGuid"),
      new SqlParameter("@JobFunctionID", SqlDbType.Int, 0, "JobFunctionID")
    });
    this.SqlCommand3.CommandText = "SELECT     ProducerContactGuid, JobFunctionID\r\nFROM         dbo.tblProducerContactJobFunctions\r\nWHERE     (ProducerContactGuid = @ProducerContactGuid)";
    this.SqlCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGuid")
    });
    this.SqlCommand4.CommandText = componentResourceManager.GetString("SqlCommand4.CommandText");
    this.SqlCommand4.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 0, "ProducerContactGuid"),
      new SqlParameter("@JobFunctionID", SqlDbType.Int, 0, "JobFunctionID"),
      new SqlParameter("@Original_ProducerContactGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_JobFunctionID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "JobFunctionID", DataRowVersion.Original, (object) null)
    });
    this.daInt.DeleteCommand = this.SqlCommand5;
    this.daInt.InsertCommand = this.SqlCommand6;
    this.daInt.SelectCommand = this.SqlCommand7;
    this.daInt.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerContactInterests", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerContactGuid", "ProducerContactGuid"),
        new DataColumnMapping("IntID", "IntID")
      })
    });
    this.daInt.UpdateCommand = this.SqlCommand8;
    this.SqlCommand5.CommandText = "DELETE FROM [dbo].[tblProducerContactInterests] WHERE (([ProducerContactGuid] = @Original_ProducerContactGuid) AND ([IntID] = @Original_IntID))";
    this.SqlCommand5.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_ProducerContactGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IntID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntID", DataRowVersion.Original, (object) null)
    });
    this.SqlCommand6.CommandText = componentResourceManager.GetString("SqlCommand6.CommandText");
    this.SqlCommand6.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 0, "ProducerContactGuid"),
      new SqlParameter("@IntID", SqlDbType.Int, 0, "IntID")
    });
    this.SqlCommand7.CommandText = "SELECT     ProducerContactGuid, IntID\r\nFROM         dbo.tblProducerContactInterests\r\nWHERE     (ProducerContactGuid = @ProducerContactGuid)";
    this.SqlCommand7.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGuid")
    });
    this.SqlCommand8.CommandText = componentResourceManager.GetString("SqlCommand8.CommandText");
    this.SqlCommand8.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 0, "ProducerContactGuid"),
      new SqlParameter("@IntID", SqlDbType.Int, 0, "IntID"),
      new SqlParameter("@Original_ProducerContactGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IntID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntID", DataRowVersion.Original, (object) null)
    });
    this.LinkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.LinkLabel1.Cursor = Cursors.Hand;
    this.LinkLabel1.Location = new Point(93, 616);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(196, 23);
    this.LinkLabel1.TabIndex = 9;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "Producer Location ";
    this.LinkLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.lblSearchDate.AutoSize = true;
    this.lblSearchDate.BackColor = Color.Transparent;
    this.lblSearchDate.Location = new Point(51, 22);
    this.lblSearchDate.Name = "lblSearchDate";
    this.lblSearchDate.Size = new Size(67, 13);
    this.lblSearchDate.TabIndex = 121;
    this.lblSearchDate.Text = "yyyy-MM-dd";
    this.lblSearchDate.TextAlign = ContentAlignment.MiddleRight;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(51, 44);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(31 /*0x1F*/, 13);
    this.Label16.TabIndex = 121;
    this.Label16.Text = "###";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.LinkSircon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.LinkSircon.Cursor = Cursors.Hand;
    this.LinkSircon.Location = new Point(300, 637);
    this.LinkSircon.Name = "LinkSircon";
    this.LinkSircon.Size = new Size(196, 23);
    this.LinkSircon.TabIndex = 11;
    this.LinkSircon.TabStop = true;
    this.LinkSircon.Text = "Sircon";
    this.LinkSircon.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(796, 690);
    this.Controls.Add((Control) this.frmProducerContacts_Fill_Panel);
    this.Controls.Add((Control) this._frmProducerContacts_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmProducerContacts_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmProducerContacts_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmProducerContacts_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.Name = nameof (frmProducerContacts);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Producer Contacts";
    ((ISupportInitialize) this.grpContactInfo).EndInit();
    ((Control) this.grpContactInfo).ResumeLayout(false);
    ((Control) this.grpContactInfo).PerformLayout();
    ((ISupportInitialize) this.txtComment).EndInit();
    this.dsContacts.EndInit();
    ((ISupportInitialize) this.chkCEWaived).EndInit();
    ((ISupportInitialize) this.dtDOB).EndInit();
    ((ISupportInitialize) this.txtNPNNo).EndInit();
    ((ISupportInitialize) this.cboManagedBy).EndInit();
    ((ISupportInitialize) this.chkOptOut).EndInit();
    ((ISupportInitialize) this.lstInterest).EndInit();
    ((ISupportInitialize) this.lstJobFunction).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).EndInit();
    ((ISupportInitialize) this.txtFax).EndInit();
    ((ISupportInitialize) this.txtSSNNo).EndInit();
    ((ISupportInitialize) this.txtCell).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.cbStatus).EndInit();
    ((ISupportInitialize) this.chk1099).EndInit();
    ((ISupportInitialize) this.lstSpecialContacts).EndInit();
    ((ISupportInitialize) this.btnSpecialContact).EndInit();
    ((ISupportInitialize) this.txtExt).EndInit();
    ((ISupportInitialize) this.cboDeliveryMethod).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.txtLName).EndInit();
    ((ISupportInitialize) this.txtFName).EndInit();
    ((ISupportInitialize) this.lstContacts).EndInit();
    this.dvProducerContacts.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.MgaGroupBox2).EndInit();
    ((Control) this.MgaGroupBox2).ResumeLayout(false);
    this.frmProducerContacts_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.grpOfac).EndInit();
    ((Control) this.grpOfac).ResumeLayout(false);
    ((Control) this.grpOfac).PerformLayout();
    ((ISupportInitialize) this.chkOfacCleared).EndInit();
    ((ISupportInitialize) this.menuProducerContacts).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblSearchDate")]
  protected virtual Label lblSearchDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  protected virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel LinkSircon
  {
    get => this._LinkSircon;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkSircon_LinkClicked);
      LinkLabel linkSircon1 = this._LinkSircon;
      if (linkSircon1 != null)
        linkSircon1.LinkClicked -= clickedEventHandler;
      this._LinkSircon = value;
      LinkLabel linkSircon2 = this._LinkSircon;
      if (linkSircon2 == null)
        return;
      linkSircon2.LinkClicked += clickedEventHandler;
    }
  }

  public frmProducerContacts(Guid producerLocationGuid)
  {
    this.Load += new EventHandler(this.frmProducerContacts_Load);
    this.VisibleChanged += new EventHandler(this.frmProducerContacts_VisibleChanged);
    this._producerContactGuid = Guid.Empty;
    this._permissionToAddContact = true;
    this._canUpdateSpecialProducerContacts = true;
    this._AddByUserID = -1;
    this._NewContactPhone = (object) null;
    this._NewContactFax = (object) null;
    this._UseServerTime = false;
    this._isFormLoading = true;
    this._allowOfacSearch = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.ProducerContact.AllowSearch");
    this._showOfac = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.ProducerContact.ShowInfo", this._allowOfacSearch);
    this._ofacData = new Dictionary<Guid, OfacSystem.OfacStatus>();
    this._ofacUnderwriters = new Dictionary<Guid, string>();
    this.md = new frmProducerContacts.d_FilterContacts(this.FilterContacts);
    this.InitializeComponent();
    this._cn = DefaultDatabase.CreateConnection();
    this._producerGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT ProducerGuid FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGuid=@PLG", new object[2]
    {
      (object) "@PLG",
      (object) producerLocationGuid
    });
    this._producerLocationGuid = producerLocationGuid;
  }

  public frmProducerContacts(Guid producerLocationGuid, Guid producerContactGuid)
    : this(producerLocationGuid)
  {
    this._producerContactGuid = producerContactGuid;
  }

  public frmProducerContacts()
  {
    this.Load += new EventHandler(this.frmProducerContacts_Load);
    this.VisibleChanged += new EventHandler(this.frmProducerContacts_VisibleChanged);
    this._producerContactGuid = Guid.Empty;
    this._permissionToAddContact = true;
    this._canUpdateSpecialProducerContacts = true;
    this._AddByUserID = -1;
    this._NewContactPhone = (object) null;
    this._NewContactFax = (object) null;
    this._UseServerTime = false;
    this._isFormLoading = true;
    this._allowOfacSearch = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.ProducerContact.AllowSearch");
    this._showOfac = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.ProducerContact.ShowInfo", this._allowOfacSearch);
    this._ofacData = new Dictionary<Guid, OfacSystem.OfacStatus>();
    this._ofacUnderwriters = new Dictionary<Guid, string>();
    this.md = new frmProducerContacts.d_FilterContacts(this.FilterContacts);
    this.InitializeComponent();
  }

  protected MGAMaskedEdit GetTxtSSNNo() => this.txtSSNNo;

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._cn != null)
      {
        this._cn.Close();
        this._cn.Dispose();
      }
    }
    base.Dispose(disposing);
  }

  protected Guid ProducerLocationGuid => this._producerLocationGuid;

  protected Guid ProducerContactGuid => this._producerContactGuid;

  protected dsProducerContacts ContactDataset => this.dsContacts;

  protected BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.dsContacts, this.dsContacts.tblProducerContacts.TableName];
    }
  }

  private string NewContactPhone
  {
    get
    {
      if (this._NewContactPhone == null)
        this._NewContactPhone = (object) DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT IsNull(Phone,@E) FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGuid=@PLG", new object[4]
        {
          (object) "@PLG",
          (object) this.ProducerLocationGuid,
          (object) "@E",
          (object) ""
        });
      return this._NewContactPhone.ToString();
    }
  }

  private string NewContactFax
  {
    get
    {
      if (this._NewContactFax == null)
        this._NewContactFax = (object) DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT IsNull(Fax,@E) FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGuid=@PLG", new object[4]
        {
          (object) "@PLG",
          (object) this.ProducerLocationGuid,
          (object) "@E",
          (object) ""
        });
      return this._NewContactFax.ToString();
    }
  }

  private int AddedByUserID
  {
    get
    {
      if (this._AddByUserID == -1)
        this._AddByUserID = CurrentUser.Instance.UserID;
      return this._AddByUserID;
    }
  }

  private DateTime NewContactDateAdded
  {
    get => !this._UseServerTime ? DateAndTime.Now : CurrentUser.ServerTime;
  }

  private void frmProducerContacts_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    MDIControls.Instance.StatusBar.Text = "Producer Management";
    SqlDataAdapter daContacts = this.daContacts;
    daContacts.SelectCommand.Connection = this._cn;
    daContacts.InsertCommand.Connection = this._cn;
    daContacts.UpdateCommand.Connection = this._cn;
    daContacts.DeleteCommand.Connection = this._cn;
    SqlDataAdapter daSpecialContacts = this.daSpecialContacts;
    daSpecialContacts.SelectCommand.Connection = this._cn;
    daSpecialContacts.InsertCommand.Connection = this._cn;
    daSpecialContacts.UpdateCommand.Connection = this._cn;
    daSpecialContacts.DeleteCommand.Connection = this._cn;
    SqlDataAdapter daJobF = this.daJobF;
    daJobF.SelectCommand.Connection = this._cn;
    daJobF.InsertCommand.Connection = this._cn;
    daJobF.UpdateCommand.Connection = this._cn;
    daJobF.DeleteCommand.Connection = this._cn;
    SqlDataAdapter daInt = this.daInt;
    daInt.SelectCommand.Connection = this._cn;
    daInt.InsertCommand.Connection = this._cn;
    daInt.UpdateCommand.Connection = this._cn;
    daInt.DeleteCommand.Connection = this._cn;
    this.daFillData.SelectCommand.Connection = this._cn;
    if (MGASystems.Common.SystemSettings.KeyExists("UseServerTimeOnNewContacts"))
      this._UseServerTime = MGASystems.Common.SystemSettings.GetBoolSetting("UseServerTimeOnNewContacts");
    this.PopulateDataSet();
    this.PopulateFilterChk();
    this.chkFilter.ClearSelected();
    if (this._producerContactGuid.Equals(Guid.Empty))
      this.chkFilter.SetItemChecked(1, true);
    else
      this.chkFilter.SetItemChecked((int) DefaultDatabase.ExecuteScalar<byte>(CommandType.Text, "SELECT StatusID FROM tblProducerContacts WITH (NOLOCK) WHERE ProducerContactGUID = @PCG", new object[2]
      {
        (object) "@PCG",
        (object) this._producerContactGuid
      }), true);
    this.FilterContacts();
    this.LoadSpecialContactsAndInfo(this._producerContactGuid);
    this.AssignAddressData(this._producerContactGuid);
    if (!this._producerContactGuid.Equals(Guid.Empty))
      this.lstContacts.SelectedValue = (object) this._producerContactGuid;
    this.bmb.Position = this.lstContacts.SelectedIndex;
    this.lstContacts.MouseUp += new MouseEventHandler(this.SelectContact);
    this.lstContacts.KeyUp += new KeyEventHandler(this.SelectContact);
    this._permissionToAddContact = SecurityManager.Instance.AssertPermission("{72A14282-79A9-4911-AFE1-8CB943352762}");
    this._canEditContact = SecurityManager.Instance.AssertPermission("{BA4D1F6A-179A-42C6-8592-160F05478BFC}");
    this._canDeleteContact = SecurityManager.Instance.AssertPermission("{E4424AE8-1B00-4ACF-B843-FC0C261A654D}");
    this._canEditDOB = SecurityManager.Instance.AssertPermission("{0C159028-1264-4218-872F-68B6CF19955C}");
    this._canEditSSN = SecurityManager.Instance.AssertPermission("{D8A1C515-4396-4790-84CB-CF44B3650BC1}");
    this._canClearOfac = SecurityManager.Instance.AssertPermission("{88E157A8-27B4-4E2C-AB3E-C0DC06E2CD11}");
    if (this._producerContactGuid.Equals(Guid.Empty))
    {
      this.dbSave.FreezeEvents = false;
      this.dbSave.PerformAction(DBSaveUIAction.ClickNewButton);
      ((ToolsCollectionBase) this.menuProducerContacts.Tools)["Contacts"].SharedProps.Visible = false;
    }
    else
      this.dbSave.UIState = this.dsContacts.tblProducerContacts.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    this.lstSpecialContacts.DataSource = (object) this.dsContacts.lstProducerSpecialContactTypes;
    this.lstSpecialContacts.DisplayMember = this.dsContacts.lstProducerSpecialContactTypes.SpecialContactTypeColumn.ColumnName;
    this.lstSpecialContacts.ValueMember = this.dsContacts.lstProducerSpecialContactTypes.SpecialContactTypeIDColumn.ColumnName;
    this.lstJobFunction.DataSource = (object) this.dsContacts.lstProducerContactJobFunction;
    this.lstJobFunction.DisplayMember = this.dsContacts.lstProducerContactJobFunction.JobFunctionColumn.ColumnName;
    this.lstJobFunction.ValueMember = this.dsContacts.lstProducerContactJobFunction.JobFunctionIDColumn.ColumnName;
    this.lstInterest.DataSource = (object) this.dsContacts.lstProducerContactInterests;
    this.lstInterest.DisplayMember = this.dsContacts.lstProducerContactInterests.ContactInterestColumn.ColumnName;
    this.lstInterest.ValueMember = this.dsContacts.lstProducerContactInterests.IntIDColumn.ColumnName;
    this.OnFormLoad();
    this.SelectContact();
    this._canUpdateSpecialProducerContacts = SecurityManager.Instance.AssertPermission("{9B676E43-1FAA-4a3f-BC03-75459E82FBE6}");
    ProducerLocation producerLocation = new ProducerLocation(this._producerLocationGuid);
    if (!string.IsNullOrEmpty(producerLocation.CountryCode) && !producerLocation.CountryCode.Equals("USA"))
    {
      this.txtPhone.InputMask = string.Empty;
      string text = this.txtPhone.Text;
      this.txtPhone.EditAs = (EditAsType) 0;
      this.txtPhone.Text = text;
    }
    ((Control) this.grpOfac).Visible = this._showOfac;
    this._isFormLoading = false;
    this.LinkSircon.Enabled = Utilities.SirconEnabled;
    this.LinkSircon.Visible = Utilities.SirconEnabled;
    Cursor.Current = MgaCursors.Default;
  }

  private void PopulateFilterChk()
  {
    this.chkFilter.Items.Clear();
    this.chkFilter.Items.Add((object) "Show All");
    try
    {
      foreach (DataRow row in this.dsContacts.Tables["lstStatus"].Rows)
        this.chkFilter.Items.Add((object) row[1].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void PopulateDataSet()
  {
    this.dsContacts.tblProducerContactsCopy.Rows.Clear();
    SqlDataAdapter daFillData = this.daFillData;
    daFillData.TableMappings.Clear();
    daFillData.TableMappings.Add("Table", this.dsContacts.lstDeliveryMethod.TableName);
    daFillData.TableMappings.Add("Table1", this.dsContacts.lstProducerSpecialContactTypes.TableName);
    daFillData.TableMappings.Add("Table2", this.dsContacts.lstStatus.TableName);
    daFillData.TableMappings.Add("Table3", this.dsContacts.lstSalutations.TableName);
    daFillData.TableMappings.Add("Table4", this.dsContacts.lstProducerContactJobFunction.TableName);
    daFillData.TableMappings.Add("Table5", this.dsContacts.lstProducerContactInterests.TableName);
    daFillData.SelectCommand.Parameters["@SpecialContactsOnly"].Value = (object) false;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daFillData, (DataSet) this.dsContacts);
    this.daContacts.SelectCommand.Parameters["@ProducerLocationGuid"].Value = (object) this._producerLocationGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblProducerContacts);
    if (this.dsContacts.tblProducerContacts.Rows.Count > 0)
    {
      Guid producerContactGuid = this.dsContacts.tblProducerContacts[0].ProducerContactGUID;
      this.daSpecialContacts.SelectCommand.Parameters["@ProducerContactGuid"].Value = (object) producerContactGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblProducerSpecialContacts);
      this.daInt.SelectCommand.Parameters["@ProducerContactGuid"].Value = (object) producerContactGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daInt, (DataTable) this.dsContacts.tblProducerContactInterests);
      this.daJobF.SelectCommand.Parameters["@ProducerContactGuid"].Value = (object) producerContactGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daJobF, (DataTable) this.dsContacts.tblProducerContactJobFunctions);
      try
      {
        foreach (DataRow row in this.dsContacts.tblProducerContacts.Rows)
          this.dsContacts.tblProducerContactsCopy.Rows.Add((object) new Guid(row["ProducerContactGUID"].ToString()), (object) row["Name"].ToString());
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.dsContacts.Relations.Add("ManagedByRelation", this.dsContacts.tblProducerContactsCopy.Columns["ProducerContactGUID"], this.dsContacts.tblProducerContacts.Columns["ManagedBy"]);
    }
    ((ControlBase) this.lblProducer).Text = new ProducerLocation(this._producerLocationGuid).LocationName;
  }

  private void NewContact()
  {
    this.ClearAddress();
    dsProducerContacts.tblProducerContactsRow row = this.dsContacts.tblProducerContacts.NewtblProducerContactsRow();
    this._producerContactGuid = Guid.NewGuid();
    row.ProducerContactGUID = this._producerContactGuid;
    row.ProducerLocationGUID = this._producerLocationGuid;
    row.Phone = this.NewContactPhone;
    row.Fax = this.NewContactFax;
    row.AddByUserID = this.AddedByUserID;
    row.DateAdded = this.NewContactDateAdded;
    row.CEWaived = false;
    this.dsContacts.tblProducerContacts.AddtblProducerContactsRow(row);
    this.bmb.Position = this.bmb.Count - 1;
    this.ClientNewContact();
  }

  protected virtual bool ValidForm()
  {
    bool flag = true;
    if (this.bmb.Position != -1 && !string.IsNullOrEmpty(((TextEditorControlBase) this.txtEmail).Text) && !string.IsNullOrEmpty(this.cbStatus.Text) && Conversions.ToByte(this.cbStatus.Value) == (byte) 1)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetDuplicateEmailAddressContact(@Email,@ContactTypeGUID,@ContactType)", new object[6]
      {
        (object) "@Email",
        (object) ((TextEditorControlBase) this.txtEmail).Text,
        (object) "@ContactTypeGUID",
        (object) this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID,
        (object) "@ContactType",
        (object) "P"
      }));
      if (objectValue != DBNull.Value && objectValue != null)
      {
        if (MessageBox.Show($"There is at least one contact:\n\n{objectValue.ToString()}\n\nthat uses the current email address of '{((TextEditorControlBase) this.txtEmail).Text}'\n\nDo you wish to continue?", "Email Address In Use. Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
          flag = false;
      }
    }
    if (((UltraToggleEditorBase) this.chk1099).Checked && this.txtSSNNo.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.txtSSNNo, "Social security number is required when 1099.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtSSNNo, string.Empty);
    if (((TextEditorControlBase) this.txtFName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtFName, "Must enter contact first name");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtFName, string.Empty);
    if (((TextEditorControlBase) this.txtLName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtLName, "Must enter contact last name");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtLName, string.Empty);
    if (this.cbStatus.Text.Length == 0)
    {
      this.err.SetError((Control) this.cbStatus, "Must enter status");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cbStatus, string.Empty);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) != 0 && !Parsing.IsValidEmailAddress(Strings.Trim(((TextEditorControlBase) this.txtEmail).Text)))
    {
      this.err.SetError((Control) this.txtEmail, "Please enter a valid email address.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtEmail, string.Empty);
    if (this.cboDeliveryMethod.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboDeliveryMethod, "Please enter a delivery method.");
      flag = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.txtEmail, "Email must be provided when selecting email delivery type.");
      this.err.SetError((Control) this.txtFax, string.Empty);
      this.err.SetError((Control) this.cboDeliveryMethod, string.Empty);
      flag = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 2 && this.txtFax.Value == DBNull.Value | this.txtFax.Value == (object) string.Empty)
    {
      this.err.SetError((Control) this.txtFax, "Fax must be provided when selecting fax delivery type.");
      this.err.SetError((Control) this.txtEmail, string.Empty);
      this.err.SetError((Control) this.cboDeliveryMethod, string.Empty);
      flag = false;
    }
    else
    {
      this.err.SetError((Control) this.txtFax, string.Empty);
      this.err.SetError((Control) this.cboDeliveryMethod, string.Empty);
    }
    return flag;
  }

  private void ClearSpecialContactsAndInfo()
  {
    this.dsContacts.tblProducerSpecialContacts.Clear();
    this.lstSpecialContacts.ItemCheck -= new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    int num1 = this.lstSpecialContacts.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstSpecialContacts.SetItemChecked(index, false);
    this.lstSpecialContacts.ItemCheck += new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    this.dsContacts.tblProducerContactInterests.Clear();
    this.lstInterest.ItemCheck -= new ItemCheckEventHandler(this.lstInterest_ItemCheck);
    int num2 = this.lstInterest.Items.Count - 1;
    for (int index = 0; index <= num2; ++index)
      this.lstInterest.SetItemChecked(index, false);
    this.lstInterest.ItemCheck += new ItemCheckEventHandler(this.lstInterest_ItemCheck);
    this.dsContacts.tblProducerContactJobFunctions.Clear();
    this.lstJobFunction.ItemCheck -= new ItemCheckEventHandler(this.lstJobFunction_ItemCheck);
    int num3 = this.lstJobFunction.Items.Count - 1;
    for (int index = 0; index <= num3; ++index)
      this.lstJobFunction.SetItemChecked(index, false);
    this.lstJobFunction.ItemCheck += new ItemCheckEventHandler(this.lstJobFunction_ItemCheck);
  }

  private void LoadSpecialContactsAndInfo(Guid ContactGuid)
  {
    this.dsContacts.tblProducerSpecialContacts.Clear();
    this.daSpecialContacts.SelectCommand.Parameters["@ProducerContactGuid"].Value = (object) ContactGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblProducerSpecialContacts);
    this.dsContacts.tblProducerContactInterests.Clear();
    this.daInt.SelectCommand.Parameters["@ProducerContactGuid"].Value = (object) ContactGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daInt, (DataTable) this.dsContacts.tblProducerContactInterests);
    this.dsContacts.tblProducerContactJobFunctions.Clear();
    this.daJobF.SelectCommand.Parameters["@ProducerContactGuid"].Value = (object) ContactGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daJobF, (DataTable) this.dsContacts.tblProducerContactJobFunctions);
    this.FillSpecialContactsListbox();
    this.FillJobFunctionListBox();
    this.FillInterestListBox();
  }

  private void lstSpecialContacts_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    int specialContactTypeId = ((dsProducerContacts.lstProducerSpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[this.lstSpecialContacts.SelectedIndex]).Row).SpecialContactTypeID;
    Guid producerContactGuid = this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID;
    if (e.CurrentValue == CheckState.Unchecked)
    {
      dsProducerContacts.tblProducerSpecialContactsRow row = this.dsContacts.tblProducerSpecialContacts.NewtblProducerSpecialContactsRow();
      row.ProducerContactGUID = producerContactGuid;
      row.SpecialContactTypeID = specialContactTypeId;
      this.dsContacts.tblProducerSpecialContacts.AddtblProducerSpecialContactsRow(row);
      this.BindingContext[(object) this.dsContacts, this.dsContacts.tblProducerSpecialContacts.TableName].EndCurrentEdit();
    }
    else
    {
      this.dsContacts.tblProducerSpecialContacts.FindByProducerContactGUIDSpecialContactTypeID(producerContactGuid, specialContactTypeId)?.Delete();
      this.BindingContext[(object) this.dsContacts, this.dsContacts.tblProducerSpecialContacts.TableName].EndCurrentEdit();
    }
    Cursor.Current = MgaCursors.Default;
  }

  private void FillSpecialContactsListbox()
  {
    this.lstSpecialContacts.ItemCheck -= new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    int num1 = this.lstSpecialContacts.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstSpecialContacts.SetItemChecked(index, false);
    try
    {
      foreach (dsProducerContacts.tblProducerSpecialContactsRow producerSpecialContact in (TypedTableBase<dsProducerContacts.tblProducerSpecialContactsRow>) this.dsContacts.tblProducerSpecialContacts)
      {
        int num2 = this.lstSpecialContacts.Items.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          dsProducerContacts.lstProducerSpecialContactTypesRow row = (dsProducerContacts.lstProducerSpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[index]).Row;
          if (producerSpecialContact.SpecialContactTypeID == row.SpecialContactTypeID)
            this.lstSpecialContacts.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator<dsProducerContacts.tblProducerSpecialContactsRow> enumerator;
      enumerator?.Dispose();
    }
    this.lstSpecialContacts.ItemCheck += new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
  }

  private void SelectContact(object sender, KeyEventArgs e)
  {
    MouseEventArgs e1 = (MouseEventArgs) null;
    this.SelectContact(RuntimeHelpers.GetObjectValue(sender), e1);
  }

  private void SelectContact(object sender, MouseEventArgs e) => this.SelectContact();

  private void SelectContact()
  {
    this.ClearAddress();
    if (this.bmb.Position >= 0 && this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Added)
      return;
    if (this.lstContacts.SelectedIndex > -1)
    {
      Guid selectedValue = (Guid) this.lstContacts.SelectedValue;
      dsProducerContacts.tblProducerContactsRow producerContactGuid = this.dsContacts.tblProducerContacts.FindByProducerContactGUID(selectedValue);
      if (producerContactGuid == null)
        return;
      this.bmb.Position = this.dsContacts.tblProducerContacts.Rows.IndexOf((DataRow) producerContactGuid);
      this.LoadSpecialContactsAndInfo(selectedValue);
      this.AssignAddressData(selectedValue);
      this.lstSpecialContacts.Enabled = true;
      this.ClientSelectContact(selectedValue);
    }
    this.ShowOfacData();
  }

  private void UpdateOpenForms()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmProducers frmProducers && frmProducers.ProducerGuid.Equals(this._producerGuid))
      {
        frmProducers.LoadContacts();
        frmProducers.RefreshContacts = true;
      }
      checked { ++index; }
    }
  }

  private void btnSpecialContact_Click(object sender, EventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmAdminProducerSpecialContacts), (object) new EventHandler(this.frmAdminProducerSpecialContacts_Closing)))
      ;
  }

  private void frmAdminProducerSpecialContacts_Closing(object sender, EventArgs e)
  {
    try
    {
      this.RefillSpecialContactsListTable();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      this.Close();
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void FilterContacts()
  {
    string str = "";
    if (this.chkFilter.CheckedItems.Count == 0)
      this.chkFilter.SetItemChecked(0, true);
    else if (this.chkFilter.GetItemChecked(0))
    {
      this.dvProducerContacts.RowFilter = "";
    }
    else
    {
      int num = this.chkFilter.Items.Count - 1;
      for (int index = 1; index <= num; ++index)
      {
        if (this.chkFilter.GetItemChecked(index))
          str = $"{str}StatusID={index.ToString()} OR ";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) != 0)
        str = str.Remove(Strings.Len(str) - 4, 4);
      this.dvProducerContacts.RowFilter = str;
      this.SelectContact((object) null, (MouseEventArgs) null);
    }
  }

  private void frmProducerContacts_VisibleChanged(object sender, EventArgs e)
  {
    if (!this.Visible)
      return;
    this.FillSpecialContactsListbox();
    this.FillJobFunctionListBox();
    this.FillInterestListBox();
  }

  private void lnkAuthorize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{E6F93833-1F2E-48e6-83B6-42036CAEBCF0}"))
    {
      int num1 = (int) MessageBox.Show("Insufficient security to authorize contact for external access.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num2 = (int) MessageBox.Show("Please save this contact before configuring them for external access.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (frmAuthorizeContact), (object) this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID))
        ;
    }
  }

  private void ChangeProducerContact(Guid producerContactGuid, Guid locationGuid)
  {
    if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsProducerContactInUse(@producerContactGuid)", new object[2]
    {
      (object) "@producerContactGuid",
      (object) producerContactGuid
    }))
      return;
    using (FormChangeProducerContact changeProducerContact = new FormChangeProducerContact(locationGuid, producerContactGuid))
    {
      int num = (int) changeProducerContact.ShowDialog();
    }
  }

  private void chkFilter_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init == null)
      Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
    bool lockTaken = false;
    try
    {
      Monitor.Enter((object) this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init, ref lockTaken);
      if (this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init.State == (short) 0)
      {
        this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init.State = (short) 2;
        this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore = false;
      }
      else if (this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init.State == (short) 2)
        throw new IncompleteInitialization();
    }
    finally
    {
      this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init.State = (short) 1;
      if (lockTaken)
        Monitor.Exit((object) this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore\u0024Init);
    }
    if (this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore)
      return;
    this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore = true;
    if (e.Index == 0 && e.NewValue == CheckState.Checked)
    {
      int num = this.chkFilter.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.chkFilter.SetItemChecked(index, false);
      this.chkFilter.SetItemChecked(0, true);
    }
    if (e.Index != 0 && this.chkFilter.GetItemChecked(0))
      this.chkFilter.SetItemChecked(0, false);
    this.\u0024STATIC\u0024chkFilter_ItemCheck\u002420211C128321\u0024ignore = false;
    this.BeginInvoke((Delegate) this.md);
  }

  internal void RefillSpecialContactsListTable()
  {
    if (this.DesignMode)
      return;
    this.daFillData.SelectCommand.Parameters["@SpecialContactsOnly"].Value = (object) true;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daFillData, (DataTable) this.dsContacts.lstProducerSpecialContactTypes);
    this.FillSpecialContactsListbox();
    this.FillJobFunctionListBox();
    this.FillInterestListBox();
  }

  protected virtual void PostSave(
    bool blankEmailContact,
    bool noSpecialContact,
    string ContactName)
  {
  }

  protected virtual void OnFormLoad()
  {
  }

  protected virtual void ClientNewContact()
  {
  }

  protected virtual void ClientNewContactControls()
  {
  }

  protected virtual void ClientSelectContact(Guid contactGuid)
  {
  }

  protected virtual void ClientDeleteContact(Guid contactGuidToDelete)
  {
  }

  protected virtual void ClientSaveContact(Guid contactGuid)
  {
  }

  protected virtual void CheckEmailChange()
  {
    if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Added)
    {
      this.dsContacts.tblProducerContacts[this.bmb.Position].EmailEditedBy = this.AddedByUserID;
      this.dsContacts.tblProducerContacts[this.bmb.Position].DateEmailEdited = this.NewContactDateAdded;
    }
    else
    {
      object obj1 = RuntimeHelpers.GetObjectValue(this.dsContacts.tblProducerContacts[this.bmb.Position]["Email", DataRowVersion.Original]);
      object obj2 = (object) ((TextEditorControlBase) this.txtEmail).Text;
      if (obj1 == DBNull.Value || obj1 == null)
        obj1 = (object) string.Empty;
      if (obj2 == DBNull.Value || obj2 == null)
        obj2 = (object) string.Empty;
      if (obj1.ToString().Equals(RuntimeHelpers.GetObjectValue(obj2)))
        return;
      this.dsContacts.tblProducerContacts[this.bmb.Position].EmailEditedBy = this.AddedByUserID;
      this.dsContacts.tblProducerContacts[this.bmb.Position].DateEmailEdited = this.NewContactDateAdded;
    }
  }

  private void LogContactChanges(List<string> contactChangeList)
  {
    if (contactChangeList.Count == 0)
      return;
    Guid producerLocationGuid = this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerLocationGUID;
    Guid producerContactGuid = this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID;
    try
    {
      foreach (string contactChange in contactChangeList)
        DefaultDatabase.ExecuteNonQuery("spProducerContactLogging", new object[8]
        {
          (object) "@ProducerLocationGuid",
          (object) producerLocationGuid,
          (object) "@ProducerContactGuid",
          (object) producerContactGuid,
          (object) "@UserID",
          (object) CurrentUser.Instance.UserID,
          (object) "@Action",
          (object) contactChange
        });
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void GetContactLog(List<string> contactChangeList)
  {
    dsProducerContacts.tblProducerContactsRow tblProducerContact = this.dsContacts.tblProducerContacts[this.bmb.Position];
    if (tblProducerContact.RowState == DataRowState.Added)
    {
      contactChangeList.Add($"Added a new producer Contact - '{((TextEditorControlBase) this.txtFName).Text} {((TextEditorControlBase) this.txtLName).Text}'");
    }
    else
    {
      string str1 = string.Empty;
      string str2 = string.Empty;
      if (!tblProducerContact.IsFNameNull())
        str1 = tblProducerContact.FName;
      if (!tblProducerContact.IsLNameNull())
        str2 = tblProducerContact.LName;
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.dsContacts.tblProducerContacts.Columns)
        {
          if (!column.ColumnName.Equals("ProducerContactID") && !column.ColumnName.Equals("ProducerContactGUID") && !column.ColumnName.Equals("ProducerLocationGUID") && !column.ColumnName.Equals("DateModified") && !column.ColumnName.Equals("EmailEditedBy") && !column.ColumnName.Equals("DateEmailEdited") && !column.ColumnName.Equals("DateAdded") && !column.ColumnName.Equals("AddByUserID"))
          {
            object obj1 = RuntimeHelpers.GetObjectValue(tblProducerContact[column.ColumnName, DataRowVersion.Original]);
            object obj2 = RuntimeHelpers.GetObjectValue(tblProducerContact[column.ColumnName, DataRowVersion.Current]);
            if (Utility.IsNull(RuntimeHelpers.GetObjectValue(obj1)))
              obj1 = (object) "<Empty>";
            if (Utility.IsNull(RuntimeHelpers.GetObjectValue(obj2)))
              obj2 = (object) "<Empty>";
            if (!obj1.ToString().Equals(obj2.ToString()))
              contactChangeList.Add($"Modify contact {str1} {str2}. Change '{column.ColumnName}'  from  '{obj1}'  to  '{obj2}'");
          }
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

  private void ClearErrorProviders()
  {
    try
    {
      foreach (Control control in ((Control) this.grpContactInfo).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    this.dsContacts.tblProducerSpecialContacts.RejectChanges();
    this.dsContacts.tblProducerContacts[this.bmb.Position].RejectChanges();
    this.dbSave.UIState = this.dsContacts.tblProducerContacts.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    BindingManagerBase bmb;
    int num = (bmb = this.bmb).Position - 1;
    bmb.Position = num;
    if (this.bmb.Position != -1)
      this.LoadSpecialContactsAndInfo(this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID);
    else
      this.ClearSpecialContactsAndInfo();
    this.ClearErrorProviders();
    this.FilterContacts();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
      e.Cancel = true;
    else if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Deleted)
      e.Cancel = true;
    else if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Added && !this._permissionToAddContact)
    {
      int num = (int) MessageBox.Show("You do not have permission to add new producer contacts.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState != DataRowState.Added)
        this.dsContacts.tblProducerContacts[this.bmb.Position].DateModified = this.NewContactDateAdded;
      this.CheckEmailChange();
      bool flag1 = false;
      Guid producerContactGuid = this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID;
      Guid producerLocationGuid = this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerLocationGUID;
      bool blankEmailContact = false;
      bool noSpecialContact = false;
      string ContactName = $"{this.dsContacts.tblProducerContacts[this.bmb.Position].LName}, {this.dsContacts.tblProducerContacts[this.bmb.Position].FName}";
      bool flag2 = false;
      bool flag3 = false;
      List<string> contactChangeList = new List<string>();
      try
      {
        this.bmb.EndCurrentEdit();
        this.GetContactLog(contactChangeList);
        if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Modified)
        {
          object objectValue1 = RuntimeHelpers.GetObjectValue(this.dsContacts.tblProducerContacts[this.bmb.Position]["StatusID", DataRowVersion.Original]);
          object objectValue2 = RuntimeHelpers.GetObjectValue(this.dsContacts.tblProducerContacts[this.bmb.Position]["StatusID", DataRowVersion.Current]);
          if (objectValue1 != null && objectValue2 != null && Conversions.ToByte(objectValue1) == (byte) 1 && Conversions.ToByte(objectValue2) == (byte) 3)
            flag1 = true;
          if (objectValue1 != null && objectValue2 != null && Conversions.ToByte(objectValue1) == (byte) 1 && Conversions.ToByte(objectValue2) == (byte) 2)
            flag3 = true;
        }
        if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Added)
        {
          if (this.dsContacts.tblProducerContacts[this.bmb.Position].IsEmailNull())
            blankEmailContact = true;
          flag2 = true;
          noSpecialContact = this.dsContacts.tblProducerSpecialContacts.Count == 0;
        }
        bool flag4 = false;
        if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Added || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dsContacts.tblProducerContacts[this.bmb.Position].Name, $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}", false) != 0)
        {
          this.dsContacts.tblProducerContacts[this.bmb.Position].Name = $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}";
          flag4 = this._allowOfacSearch;
        }
        this.GetAddressData();
        if (this.dsContacts.HasChanges())
        {
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblProducerContacts);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblProducerSpecialContacts);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daInt, (DataTable) this.dsContacts.tblProducerContactInterests);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daJobF, (DataTable) this.dsContacts.tblProducerContactJobFunctions);
          this.UpdateOpenForms();
          this.PostSave(blankEmailContact, noSpecialContact, ContactName);
          this.LogContactChanges(contactChangeList);
          if (flag4)
          {
            if (OfacSystem.Instance.CheckOfac<ProducerContact>(new ProducerContact(producerContactGuid)))
              this._ofacData[producerContactGuid] = OfacSystem.Instance.GetEntityStatus(producerContactGuid, new Guid?(this.ProducerLocationGuid));
          }
          else if (this._canClearOfac)
          {
            OfacSystem.OfacStatus ofacStatus = (OfacSystem.OfacStatus) null;
            if (this._ofacData.TryGetValue(producerContactGuid, out ofacStatus) && ofacStatus != null && ((UltraToggleEditorBase) this.chkOfacCleared).Checked != ofacStatus.OFACCleared)
            {
              if (ofacStatus.OFACCleared)
                OfacSystem.Instance.ReinstateOfacHit(producerContactGuid, new Guid?(this.ProducerLocationGuid));
              else
                OfacSystem.Instance.ClearOfacHit(producerContactGuid, new Guid?(this.ProducerLocationGuid), new Guid?(CurrentUser.Instance.UserGUID), new DateTime?(CurrentUser.ServerTime), "Cleared via Producer Contact UI");
              this._ofacData.Remove(producerContactGuid);
            }
          }
        }
        this.ClientSaveContact(producerContactGuid);
        MDIControls.Instance.StatusBarText = "Producer contact saved succesfully.";
        string salutation = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("Salutation") ?? string.Empty;
        string firstName = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("FName") ?? string.Empty;
        string lastName = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("LName") ?? string.Empty;
        string phone = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("Phone") ?? string.Empty;
        string @extension = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("Extension") ?? string.Empty;
        string fax = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("Fax") ?? string.Empty;
        string cell = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("Cell") ?? string.Empty;
        string email = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("Email") ?? string.Empty;
        string NPNNo = this.dsContacts.tblProducerContacts[this.bmb.Position].Field<string>("NPNNo") ?? string.Empty;
        ProducerContactContext context = new ProducerContactContext(producerContactGuid, producerLocationGuid, salutation, firstName, lastName, phone, @extension, fax, cell, email, !flag1, NPNNo);
        if (flag2)
          Messaging.SendBroadcastMessage(BroadcastMessages.ProducerContactAdded, (object) context);
        else
          Messaging.SendBroadcastMessage(BroadcastMessages.ProducerContactUpdated, (object) context);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      this.SelectContact();
      if (!flag1 && !flag3)
        return;
      this.ChangeProducerContact(producerContactGuid, producerLocationGuid);
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!this._canDeleteContact)
    {
      int num = (int) MessageBox.Show("You do not have sufficient security to delete producer contacts", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this producer contact?", "Delete Producer Contact?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      string str1 = string.Empty;
      string str2 = string.Empty;
      if (!this.dsContacts.tblProducerContacts[this.bmb.Position].IsFNameNull())
        str1 = this.dsContacts.tblProducerContacts[this.bmb.Position].FName;
      if (!this.dsContacts.tblProducerContacts[this.bmb.Position].IsLNameNull())
        str2 = this.dsContacts.tblProducerContacts[this.bmb.Position].LName;
      Guid producerContactGuid = this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID;
      this.dsContacts.tblProducerContacts[this.bmb.Position].Delete();
      this.dsContacts.EnforceConstraints = false;
      this.dsContacts.tblProducerContactsCopy.Rows.Clear();
      try
      {
        foreach (dsProducerContacts.tblProducerContactsRow row in this.dsContacts.tblProducerContacts.Rows)
        {
          if (row.RowState != DataRowState.Deleted && !row.IsManagedByNull() && row.ManagedBy == producerContactGuid)
            row.SetManagedByNull();
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (DataRow row in this.dsContacts.tblProducerContacts.Rows)
        {
          if (row.RowState != DataRowState.Deleted)
            this.dsContacts.tblProducerContactsCopy.Rows.Add((object) new Guid(row["ProducerContactGUID"].ToString()), (object) row["Name"].ToString());
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.dsContacts.EnforceConstraints = true;
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblProducerContacts);
        this.ClientDeleteContact(producerContactGuid);
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Message.IndexOf("FK_tblSubmissionGroup_tblProducerContacts") != -1)
        {
          this.dsContacts.RejectChanges();
          int num = (int) MessageBox.Show("This contact can not be deleted because they have been assigned to submission groups.", "Unable To Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.IndexOf("FK_tblQuotes_tblProducerContacts") != -1)
        {
          this.dsContacts.RejectChanges();
          int num = (int) MessageBox.Show("This contact can not be deleted because they have been assigned to existing policies.", "Unable To Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.IndexOf("FK_tblUsersProducerContacts_tblProducerContacts") != -1)
        {
          this.dsContacts.RejectChanges();
          int num = (int) MessageBox.Show("This contact can not be deleted because they have been assigned as underwriters.", "Unable To Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      if (this.bmb.Position != -1)
      {
        this.LoadSpecialContactsAndInfo(this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID);
        this.ClientSelectContact(this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID);
      }
      else
        this.ClearSpecialContactsAndInfo();
      if (false)
        return;
      DefaultDatabase.ExecuteNonQuery("spProducerContactLogging", new object[8]
      {
        (object) "@ProducerLocationGuid",
        (object) this._producerLocationGuid,
        (object) "@ProducerContactGuid",
        (object) producerContactGuid,
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID,
        (object) "@Action",
        (object) $"Deleted producer contact {str1} {str2}"
      });
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.grpContactInfo).Enabled = this.dbSave.UIState == UIState.Editing;
    this.lstSpecialContacts.Enabled = this._canUpdateSpecialProducerContacts;
    ((Control) this.btnSpecialContact).Enabled = this._canUpdateSpecialProducerContacts;
    ((Control) this.grpOfac).Enabled = this._canClearOfac && this.dbSave.UIState == UIState.Editing;
  }

  private void dbSave_ClickedEdit(object sender, EventArgs e)
  {
    this.lstSpecialContacts.Enabled = this._canUpdateSpecialProducerContacts;
    ((Control) this.btnSpecialContact).Enabled = this._canUpdateSpecialProducerContacts;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!this._permissionToAddContact)
    {
      int num = (int) MessageBox.Show("You do not have permission to add new producer contacts.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      this.ClearSpecialContactsAndInfo();
      this.NewContact();
      this.lstSpecialContacts.Enabled = true;
      this.lstInterest.Enabled = true;
      this.lstJobFunction.Enabled = true;
      ((UltraDropDownBase) this.cboDeliveryMethod).SelectedRow = (UltraGridRow) null;
      ((UltraDropDownBase) this.cbStatus).SelectedRow = (UltraGridRow) null;
      ((Control) this.txtSSNNo).Enabled = true;
      ((Control) this.dtDOB).Enabled = true;
      ((Control) this.grpOfac).Enabled = false;
      this.ClientNewContactControls();
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (!this._canEditContact)
    {
      int num = (int) MessageBox.Show("You do not have sufficient security to edit producer contacts", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      ((Control) this.txtSSNNo).Enabled = this._canEditSSN;
      ((Control) this.dtDOB).Enabled = this._canEditDOB;
    }
  }

  private void FillJobFunctionListBox()
  {
    this.lstJobFunction.ItemCheck -= new ItemCheckEventHandler(this.lstJobFunction_ItemCheck);
    int num1 = this.lstJobFunction.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstJobFunction.SetItemChecked(index, false);
    try
    {
      foreach (dsProducerContacts.tblProducerContactJobFunctionsRow row1 in this.dsContacts.tblProducerContactJobFunctions.Rows)
      {
        int num2 = this.lstJobFunction.Items.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          dsProducerContacts.lstProducerContactJobFunctionRow row2 = (dsProducerContacts.lstProducerContactJobFunctionRow) ((DataRowView) this.lstJobFunction.Items[index]).Row;
          if (row1.JobFunctionID == row2.JobFunctionID)
            this.lstJobFunction.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lstJobFunction.ItemCheck += new ItemCheckEventHandler(this.lstJobFunction_ItemCheck);
  }

  private void FillInterestListBox()
  {
    this.lstInterest.ItemCheck -= new ItemCheckEventHandler(this.lstInterest_ItemCheck);
    int num1 = this.lstInterest.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstInterest.SetItemChecked(index, false);
    try
    {
      foreach (dsProducerContacts.tblProducerContactInterestsRow row1 in this.dsContacts.tblProducerContactInterests.Rows)
      {
        int num2 = this.lstInterest.Items.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          dsProducerContacts.lstProducerContactInterestsRow row2 = (dsProducerContacts.lstProducerContactInterestsRow) ((DataRowView) this.lstInterest.Items[index]).Row;
          if (row1.IntID == row2.IntID)
            this.lstInterest.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lstInterest.ItemCheck += new ItemCheckEventHandler(this.lstInterest_ItemCheck);
  }

  private void lstJobFunction_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    int jobFunctionId = ((dsProducerContacts.lstProducerContactJobFunctionRow) ((DataRowView) this.lstJobFunction.Items[this.lstJobFunction.SelectedIndex]).Row).JobFunctionID;
    Guid producerContactGuid = this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID;
    if (e.CurrentValue == CheckState.Unchecked)
    {
      dsProducerContacts.tblProducerContactJobFunctionsRow row = this.dsContacts.tblProducerContactJobFunctions.NewtblProducerContactJobFunctionsRow();
      row.ProducerContactGuid = producerContactGuid;
      row.JobFunctionID = jobFunctionId;
      this.dsContacts.tblProducerContactJobFunctions.AddtblProducerContactJobFunctionsRow(row);
      this.BindingContext[(object) this.dsContacts, this.dsContacts.tblProducerContactJobFunctions.TableName].EndCurrentEdit();
    }
    else
    {
      this.dsContacts.tblProducerContactJobFunctions.FindByProducerContactGuidJobFunctionID(producerContactGuid, jobFunctionId)?.Delete();
      this.BindingContext[(object) this.dsContacts, this.dsContacts.tblProducerContactJobFunctions.TableName].EndCurrentEdit();
    }
    Cursor.Current = MgaCursors.Default;
  }

  private void lstInterest_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    int intId = ((dsProducerContacts.lstProducerContactInterestsRow) ((DataRowView) this.lstInterest.Items[this.lstInterest.SelectedIndex]).Row).IntID;
    Guid producerContactGuid = this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID;
    if (e.CurrentValue == CheckState.Unchecked)
    {
      if (this.dsContacts.tblProducerContactInterests.FindByProducerContactGuidIntID(producerContactGuid, intId) != null)
        return;
      dsProducerContacts.tblProducerContactInterestsRow row = this.dsContacts.tblProducerContactInterests.NewtblProducerContactInterestsRow();
      row.ProducerContactGuid = producerContactGuid;
      row.IntID = intId;
      this.dsContacts.tblProducerContactInterests.AddtblProducerContactInterestsRow(row);
      this.BindingContext[(object) this.dsContacts, this.dsContacts.tblProducerContactInterests.TableName].EndCurrentEdit();
    }
    else
    {
      dsProducerContacts.tblProducerContactInterestsRow contactGuidIntId = this.dsContacts.tblProducerContactInterests.FindByProducerContactGuidIntID(producerContactGuid, intId);
      if (contactGuidIntId != null && contactGuidIntId.RowState != DataRowState.Deleted)
        contactGuidIntId.Delete();
      this.BindingContext[(object) this.dsContacts, this.dsContacts.tblProducerContactInterests.TableName].EndCurrentEdit();
    }
    Cursor.Current = MgaCursors.Default;
  }

  protected virtual void menuProducerContacts_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "DuplicateContact", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Predominant Class", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Class Specialty", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Logging", false) != 0)
            return;
          using (FormSettings.ShowFormDialog(typeof (FormProducerContactLogging), (object) this._producerLocationGuid))
            ;
        }
        else
        {
          using (FormSettings.ShowFormDialog(typeof (FormContactClassSpecialty), (object) this._producerContactGuid))
            ;
        }
      }
      else
      {
        using (FormSettings.ShowFormDialog(typeof (FormPredominantContactClass), (object) this._producerContactGuid))
          ;
      }
    }
    else
    {
      if (this.bmb.Position == -1)
        return;
      if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Added)
      {
        int num1 = (int) MessageBox.Show("Please save current contact.", "Current Contact not Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (this.dsContacts.tblProducerContacts[this.bmb.Position].RowState == DataRowState.Deleted)
      {
        int num2 = (int) MessageBox.Show("Current contact is not valid.", "Current Contact not Valid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        string str = string.Empty;
        if (!this.dsContacts.tblProducerContacts[this.bmb.Position].IsLNameNull())
          str = this.dsContacts.tblProducerContacts[this.bmb.Position].LName + ", ";
        if (!this.dsContacts.tblProducerContacts[this.bmb.Position].IsFNameNull())
          str += this.dsContacts.tblProducerContacts[this.bmb.Position].FName;
        using (FormSettings.ShowFormDialog(typeof (FormDuplicateProducerContact), (object) this._producerLocationGuid, (object) this.dsContacts.tblProducerContacts[this.bmb.Position].ProducerContactGUID, (object) str))
          ;
      }
    }
  }

  private void ClearAddress() => this.ctlZipCode.Clear();

  private void AssignAddressData(Guid contactGuid)
  {
    this.ClearAddress();
    dsProducerContacts.tblProducerContactsRow producerContactGuid = this.dsContacts.tblProducerContacts.FindByProducerContactGUID(contactGuid);
    if (producerContactGuid == null)
      return;
    if (!producerContactGuid.IsISOCountryCodeNull())
      this.ctlZipCode.ISOCountryCode = producerContactGuid.ISOCountryCode;
    if (!producerContactGuid.IsAddress1Null())
      this.ctlZipCode.Address1 = producerContactGuid.Address1;
    if (!producerContactGuid.IsAddress2Null())
      this.ctlZipCode.Address2 = producerContactGuid.Address2;
    if (!producerContactGuid.IsCityNull())
      this.ctlZipCode.City = producerContactGuid.City;
    if (!producerContactGuid.IsStateIDNull())
      this.ctlZipCode.State = producerContactGuid.StateID;
    if (!producerContactGuid.IsZipCodeNull())
      this.ctlZipCode.ZipCode = producerContactGuid.ZipCode;
    if (!producerContactGuid.IsZipPlusNull())
      this.ctlZipCode.ZipCodeExtension = producerContactGuid.ZipPlus;
    if (producerContactGuid.IsCountyNull())
      return;
    this.ctlZipCode.County = producerContactGuid.County;
  }

  private void GetAddressData()
  {
    if (this.ctlZipCode.Address1.Replace(" ", string.Empty).Length > 0)
      this.dsContacts.tblProducerContacts[this.bmb.Position].Address1 = this.ctlZipCode.Address1;
    else
      this.dsContacts.tblProducerContacts[this.bmb.Position].SetAddress1Null();
    if (this.ctlZipCode.Address2.Replace(" ", string.Empty).Length > 0)
      this.dsContacts.tblProducerContacts[this.bmb.Position].Address2 = this.ctlZipCode.Address2;
    else
      this.dsContacts.tblProducerContacts[this.bmb.Position].SetAddress2Null();
    if (this.ctlZipCode.City.Replace(" ", string.Empty).Length > 0)
      this.dsContacts.tblProducerContacts[this.bmb.Position].City = this.ctlZipCode.City;
    else
      this.dsContacts.tblProducerContacts[this.bmb.Position].SetCityNull();
    if (this.ctlZipCode.State.Replace(" ", string.Empty).Length > 0)
      this.dsContacts.tblProducerContacts[this.bmb.Position].StateID = this.ctlZipCode.State;
    else
      this.dsContacts.tblProducerContacts[this.bmb.Position].SetStateIDNull();
    if (this.ctlZipCode.ZipCode.Replace(" ", string.Empty).Length > 0)
      this.dsContacts.tblProducerContacts[this.bmb.Position].ZipCode = this.ctlZipCode.ZipCode;
    else
      this.dsContacts.tblProducerContacts[this.bmb.Position].SetZipCodeNull();
    if (this.ctlZipCode.ZipCodeExtension.Replace(" ", string.Empty).Length > 0)
      this.dsContacts.tblProducerContacts[this.bmb.Position].ZipPlus = this.ctlZipCode.ZipCodeExtension;
    else
      this.dsContacts.tblProducerContacts[this.bmb.Position].SetZipPlusNull();
    if (this.ctlZipCode.County.Replace(" ", string.Empty).Length > 0)
      this.dsContacts.tblProducerContacts[this.bmb.Position].County = this.ctlZipCode.County;
    else
      this.dsContacts.tblProducerContacts[this.bmb.Position].SetCountyNull();
    if (this.ctlZipCode.ISOCountryCode.Replace(" ", string.Empty).Length > 0)
      this.dsContacts.tblProducerContacts[this.bmb.Position].ISOCountryCode = this.ctlZipCode.ISOCountryCode;
    else
      this.dsContacts.tblProducerContacts[this.bmb.Position].SetISOCountryCodeNull();
  }

  private void LinkProducerLocationClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.lstContacts.Items.Count <= 0)
      return;
    Guid producerLocationGuid = new Guid(((DataRowView) this.lstContacts.Items[this.lstContacts.SelectedIndex]).Row["ProducerLocationGUID"].ToString());
    if (RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ProducerGuid FROM tblProducerLocations WHERE ProducerLocationGuid=@PLG", new object[2]
    {
      (object) "@PLG",
      (object) producerLocationGuid.ToString()
    })) == null)
    {
      int num = (int) MessageBox.Show("The selected producer cannot be found. It is possible it was removed by another user or not successfully saved.", "Producer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      ProducerLocation producerLocation = new ProducerLocation(producerLocationGuid);
      ObjectFactory.Instance.CreateFormEX(typeof (frmProducers), typeof (frmProducers), (object) producerLocation.ProducerGuid, (object) producerLocation.ProducerLocationGuid)?.Show();
    }
  }

  private void ShowOfacData()
  {
    if (!this._showOfac)
      return;
    this.lblOfacSearchDate.Text = string.Empty;
    this.lblOfacScore.Text = string.Empty;
    ((Control) this.chkOfacCleared).Tag = (object) null;
    ((Control) this.chkOfacCleared).Enabled = false;
    ((UltraToggleEditorBase) this.chkOfacCleared).Checked = false;
    ((UltraToggleEditorBase) this.chkOfacCleared).Text = "Cleared: N/A";
    this.lblOfacClearedUser.Text = string.Empty;
    if (this.bmb.Position == -1)
      return;
    dsProducerContacts.tblProducerContactsRow tblProducerContact = this.dsContacts.tblProducerContacts[this.bmb.Position];
    if (tblProducerContact == null || tblProducerContact.RowState == DataRowState.Added)
      return;
    OfacSystem.OfacStatus ofacStatus = (OfacSystem.OfacStatus) null;
    if (!this._ofacData.TryGetValue(tblProducerContact.ProducerContactGUID, out ofacStatus))
    {
      ofacStatus = OfacSystem.Instance.GetEntityStatus(tblProducerContact.ProducerContactGUID, new Guid?(tblProducerContact.ProducerLocationGUID));
      this._ofacData.Add(tblProducerContact.ProducerContactGUID, ofacStatus);
    }
    if (ofacStatus == null)
      return;
    this.lblOfacSearchDate.Text = ofacStatus.LogDate.ToString("yyyy-MM-dd");
    ((Control) this.chkOfacCleared).Enabled = ofacStatus.IsHit;
    ((UltraToggleEditorBase) this.chkOfacCleared).Checked = ofacStatus.OFACCleared;
    ((Control) this.chkOfacCleared).Tag = (object) ofacStatus;
    if (ofacStatus.ClearDate.HasValue)
      ((UltraToggleEditorBase) this.chkOfacCleared).Text = $"Cleared: {ofacStatus.ClearDate:yyyy-MM-dd}";
    Guid? clearByUserGuid = ofacStatus.ClearByUserGuid;
    if (!clearByUserGuid.HasValue)
      return;
    string str1 = (string) null;
    Dictionary<Guid, string> ofacUnderwriters1 = this._ofacUnderwriters;
    clearByUserGuid = ofacStatus.ClearByUserGuid;
    Guid key1 = clearByUserGuid.Value;
    ref string local = ref str1;
    if (!ofacUnderwriters1.TryGetValue(key1, out local))
    {
      clearByUserGuid = ofacStatus.ClearByUserGuid;
      MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(clearByUserGuid.Value);
      if (user.RecordExists())
      {
        str1 = user.Name_FirstLast;
        Dictionary<Guid, string> ofacUnderwriters2 = this._ofacUnderwriters;
        clearByUserGuid = ofacStatus.ClearByUserGuid;
        Guid key2 = clearByUserGuid.Value;
        string str2 = str1;
        ofacUnderwriters2[key2] = str2;
      }
    }
    this.lblOfacClearedUser.Text = $"By: {str1 ?? "Unknown User"}";
  }

  private void chkOfacCleared_CheckedChanged(object sender, EventArgs e)
  {
    if (!(((Control) this.chkOfacCleared).Tag is OfacSystem.OfacStatus tag))
      return;
    if (((UltraToggleEditorBase) this.chkOfacCleared).Checked)
    {
      DateTime? clearDate;
      ((UltraToggleEditorBase) this.chkOfacCleared).Text = $"Cleared: {((clearDate = tag.ClearDate).HasValue ? clearDate.GetValueOrDefault() : DateTime.Today):yyyy-MM-dd}";
      string str = CurrentUser.Instance.DisplayName;
      if (tag.ClearByUserGuid.HasValue && !this._ofacUnderwriters.TryGetValue(tag.ClearByUserGuid.Value, out str))
        str = "Unknown User";
      this.lblOfacClearedUser.Text = $"By: {str}";
    }
    else
    {
      ((UltraToggleEditorBase) this.chkOfacCleared).Text = "Cleared: N/A";
      this.lblOfacClearedUser.Text = string.Empty;
    }
  }

  private void LinkSircon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Form formEx = ObjectFactory.Instance.CreateFormEX(typeof (frmSirconIndividual), typeof (frmSirconIndividual), (object) ((TextEditorControlBase) this.txtLName).Text, (object) ((TextEditorControlBase) this.txtNPNNo).Text);
    if (formEx == null)
      return;
    formEx.MdiParent = MDIControls.Instance.MDIParent;
    formEx.Show();
  }

  private enum ScreenMode
  {
    NewMode,
    EditMode,
  }

  private delegate void d_FilterContacts();
}
