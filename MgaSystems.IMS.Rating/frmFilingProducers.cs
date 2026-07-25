// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmFilingProducers
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.Tools;
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class frmFilingProducers : FormBase
{
  private IContainer components;
  private Label Label1;
  private SqlDataAdapter daQuoteFilings;
  private SqlConnection cn;
  private PictureBox PictureBox1;
  private Label lblTitle;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private readonly int _quoteID;
  private bool _dataFilled;
  private List<string> _arrProducerLocList;
  private bool _assigningData;
  protected bool _ClientAssigningData;
  protected bool _UseClientContact;
  private bool _cannotForceClose;
  private bool _isFormLoading;
  private bool _ismgaDTPDateReceivedChanged;
  private bool _invokeViaRater;
  protected string _currentStateID;
  private readonly Quote _quote;
  private bool _showAllContacts;
  private bool _defaultToOutsideProducer;
  private readonly Lazy<bool> _useClientLocationLicense;
  private readonly Lazy<bool> _useUserLicenseAsContacts;
  private readonly Lazy<string> _inHouseUsersProc;
  private readonly Lazy<bool> _getUserLicensesOnly;
  private readonly Lazy<string> _userLicenseProc;
  private readonly Lazy<bool> _useProducerLicenseAddress;
  private readonly bool _isNewRecord;
  private bool _isOutsideFiling;
  private bool _isInhouseFiling;
  private bool _hasQuoteIDParameter;
  private Dictionary<Guid, frmFilingProducers.UserAddressRecord> _userAddressList;
  private Guid _producerLocationGuid;

  [field: AccessedThroughProperty("ds")]
  protected virtual dsFilingProducers ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnContinue
  {
    get => this._btnContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContinue_Click);
      MGAButton btnContinue1 = this._btnContinue;
      if (btnContinue1 != null)
        ((Control) btnContinue1).Click -= eventHandler;
      this._btnContinue = value;
      MGAButton btnContinue2 = this._btnContinue;
      if (btnContinue2 == null)
        return;
      ((Control) btnContinue2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  protected virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboFilingProducers")]
  protected virtual MGASimpleComboBox cboFilingProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ToolTip1")]
  protected virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  protected virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbOutsideProducer")]
  protected virtual RadioButton rbOutsideProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual RadioButton rbInHouse
  {
    get => this._rbInHouse;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbInHouse_CheckedChanged);
      RadioButton rbInHouse1 = this._rbInHouse;
      if (rbInHouse1 != null)
        rbInHouse1.CheckedChanged -= eventHandler;
      this._rbInHouse = value;
      RadioButton rbInHouse2 = this._rbInHouse;
      if (rbInHouse2 == null)
        return;
      rbInHouse2.CheckedChanged += eventHandler;
    }
  }

  protected virtual LinkLabel lnkNextState
  {
    get => this._lnkNextState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkNextState_LinkClicked);
      LinkLabel lnkNextState1 = this._lnkNextState;
      if (lnkNextState1 != null)
        lnkNextState1.LinkClicked -= clickedEventHandler;
      this._lnkNextState = value;
      LinkLabel lnkNextState2 = this._lnkNextState;
      if (lnkNextState2 == null)
        return;
      lnkNextState2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkPreviousState
  {
    get => this._lnkPreviousState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPreviousState_LinkClicked);
      LinkLabel lnkPreviousState1 = this._lnkPreviousState;
      if (lnkPreviousState1 != null)
        lnkPreviousState1.LinkClicked -= clickedEventHandler;
      this._lnkPreviousState = value;
      LinkLabel lnkPreviousState2 = this._lnkPreviousState;
      if (lnkPreviousState2 == null)
        return;
      lnkPreviousState2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("MgA_ZipCodeResolver1")]
  protected virtual MGA_ZipCodeResolver MgA_ZipCodeResolver1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox cboLicenses
  {
    get => this._cboLicenses;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboLicenses_BeforeDropDown);
      KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.cboLicenses_KeyPress);
      EventHandler eventHandler1 = new EventHandler(this.CboLicenses_AfterCloseUp);
      EventHandler eventHandler2 = new EventHandler(this.CboLicenses_Leave);
      MGAComboBox cboLicenses1 = this._cboLicenses;
      if (cboLicenses1 != null)
      {
        cboLicenses1.BeforeDropDown -= cancelEventHandler;
        ((Control) cboLicenses1).KeyPress -= pressEventHandler;
        cboLicenses1.AfterCloseUp -= eventHandler1;
        ((Control) cboLicenses1).Leave -= eventHandler2;
      }
      this._cboLicenses = value;
      MGAComboBox cboLicenses2 = this._cboLicenses;
      if (cboLicenses2 == null)
        return;
      cboLicenses2.BeforeDropDown += cancelEventHandler;
      ((Control) cboLicenses2).KeyPress += pressEventHandler;
      cboLicenses2.AfterCloseUp += eventHandler1;
      ((Control) cboLicenses2).Leave += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("txtSLA")]
  protected virtual MGATextBox txtSLA { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  protected virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("mgaDTPDateReceived")]
  protected virtual MGADateTimePicker mgaDTPDateReceived { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkStateFilingInfo
  {
    get => this._lnkStateFilingInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkStateFilingInfo_LinkClicked);
      LinkLabel lnkStateFilingInfo1 = this._lnkStateFilingInfo;
      if (lnkStateFilingInfo1 != null)
        lnkStateFilingInfo1.LinkClicked -= clickedEventHandler;
      this._lnkStateFilingInfo = value;
      LinkLabel lnkStateFilingInfo2 = this._lnkStateFilingInfo;
      if (lnkStateFilingInfo2 == null)
        return;
      lnkStateFilingInfo2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtFEIN")]
  protected virtual MGATextBox txtFEIN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  protected virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpLicenseExpDate")]
  protected virtual MGADateTimePicker dtpLicenseExpDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  protected virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  protected virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboContacts
  {
    get => this._cboContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboContacts_BeforeDropDown);
      MGASimpleComboBox cboContacts1 = this._cboContacts;
      if (cboContacts1 != null)
        cboContacts1.BeforeDropDown -= cancelEventHandler;
      this._cboContacts = value;
      MGASimpleComboBox cboContacts2 = this._cboContacts;
      if (cboContacts2 == null)
        return;
      cboContacts2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtReasonForPlacement")]
  protected virtual MGATextBox txtReasonForPlacement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  protected virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TblQuoteFilingProducersBindingSource")]
  internal virtual BindingSource TblQuoteFilingProducersBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  protected virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpLicenseAdded")]
  protected virtual MGADateTimePicker dtpLicenseAdded { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFilingProducers));
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
    UltraGridBand ultraGridBand = new UltraGridBand("spGetProducerLicense", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerLicenseGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LicenseType");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Expires");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("License");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("DefaultLicense");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LicenseNumberDateAdded");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    this.Label1 = new Label();
    this.ds = new dsFilingProducers();
    this.daQuoteFilings = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.btnContinue = new MGAButton();
    this.lblTitle = new Label();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.Label11 = new Label();
    this.dtpLicenseAdded = new MGADateTimePicker();
    this.txtReasonForPlacement = new MGATextBox();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.cboContacts = new MGASimpleComboBox();
    this.Label8 = new Label();
    this.dtpLicenseExpDate = new MGADateTimePicker();
    this.txtFEIN = new MGATextBox();
    this.Label7 = new Label();
    this.lnkStateFilingInfo = new LinkLabel();
    this.mgaDTPDateReceived = new MGADateTimePicker();
    this.Label6 = new Label();
    this.cboLicenses = new MGAComboBox();
    this.Label5 = new Label();
    this.cboFilingProducers = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.rbInHouse = new RadioButton();
    this.rbOutsideProducer = new RadioButton();
    this.txtSLA = new MGATextBox();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.MgA_ZipCodeResolver1 = new MGA_ZipCodeResolver();
    this.PictureBox1 = new PictureBox();
    this.ToolTip1 = new ToolTip(this.components);
    this.lnkPreviousState = new LinkLabel();
    this.lnkNextState = new LinkLabel();
    this.err = new ErrorProvider(this.components);
    this.TblQuoteFilingProducersBindingSource = new BindingSource(this.components);
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnContinue).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.dtpLicenseAdded).BeginInit();
    ((ISupportInitialize) this.txtReasonForPlacement).BeginInit();
    ((ISupportInitialize) this.cboContacts).BeginInit();
    ((ISupportInitialize) this.dtpLicenseExpDate).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.mgaDTPDateReceived).BeginInit();
    ((ISupportInitialize) this.cboLicenses).BeginInit();
    ((ISupportInitialize) this.cboFilingProducers).BeginInit();
    ((ISupportInitialize) this.txtSLA).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.TblQuoteFilingProducersBindingSource).BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(8, 72);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(414, 27);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "This policy is non-admitted.  If another producer is handling the filing in a particular state, please enter their information below.";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.ds.DataSetName = "dsFilingProducers";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daQuoteFilings.DeleteCommand = this.SqlDeleteCommand1;
    this.daQuoteFilings.InsertCommand = this.SqlInsertCommand1;
    this.daQuoteFilings.SelectCommand = this.SqlSelectCommand1;
    this.daQuoteFilings.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteFilingProducers", new DataColumnMapping[24]
      {
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("FilingProducer", "FilingProducer"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("SLA_Number", "SLA_Number"),
        new DataColumnMapping("LicenseNumber", "LicenseNumber"),
        new DataColumnMapping("ProducerLicenseGuid", "ProducerLicenseGuid"),
        new DataColumnMapping("FilingProducerLocationGuid", "FilingProducerLocationGuid"),
        new DataColumnMapping("DateRecd", "DateRecd"),
        new DataColumnMapping("SortNum", "SortNum"),
        new DataColumnMapping("InHouse", "InHouse"),
        new DataColumnMapping("FEIN", "FEIN"),
        new DataColumnMapping("LicenseExpDate", "LicenseExpDate"),
        new DataColumnMapping("ProducerContactGUID", "ProducerContactGUID"),
        new DataColumnMapping("ProducerContact", "ProducerContact"),
        new DataColumnMapping("ReasonForPlacement", "ReasonForPlacement")
      })
    });
    this.daQuoteFilings.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblQuoteFilingProducers] WHERE (([QuoteID] = @Original_QuoteID) AND ([StateID] = @Original_StateID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_QuoteID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StateID", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null)
    });
    this.cn.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[24]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@FilingProducer", SqlDbType.VarChar, 200, "FilingProducer"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 250, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 250, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@State", SqlDbType.Char, 2, "State"),
      new SqlParameter("@Region", SqlDbType.VarChar, 100, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 3, "ISOCountryCode"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 5, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@SLA_Number", SqlDbType.VarChar, 50, "SLA_Number"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 50, "LicenseNumber"),
      new SqlParameter("@ProducerLicenseGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLicenseGuid"),
      new SqlParameter("@FilingProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "FilingProducerLocationGuid"),
      new SqlParameter("@DateRecd", SqlDbType.DateTime, 8, "DateRecd"),
      new SqlParameter("@InHouse", SqlDbType.Bit, 1, "InHouse"),
      new SqlParameter("@FEIN", SqlDbType.VarChar, 125, "FEIN"),
      new SqlParameter("@LicenseExpDate", SqlDbType.DateTime, 8, "LicenseExpDate"),
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGUID"),
      new SqlParameter("@ProducerContact", SqlDbType.VarChar, 200, "ProducerContact"),
      new SqlParameter("@ReasonForPlacement", SqlDbType.VarChar, 500, "ReasonForPlacement"),
      new SqlParameter("@LicenseNumberDateAdded", SqlDbType.DateTime, 8, "LicenseNumberDateAdded")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[26]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@FilingProducer", SqlDbType.VarChar, 200, "FilingProducer"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 250, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 250, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@State", SqlDbType.Char, 2, "State"),
      new SqlParameter("@Region", SqlDbType.VarChar, 100, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 3, "ISOCountryCode"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 5, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@SLA_Number", SqlDbType.VarChar, 50, "SLA_Number"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 50, "LicenseNumber"),
      new SqlParameter("@ProducerLicenseGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLicenseGuid"),
      new SqlParameter("@FilingProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "FilingProducerLocationGuid"),
      new SqlParameter("@DateRecd", SqlDbType.DateTime, 8, "DateRecd"),
      new SqlParameter("@InHouse", SqlDbType.Bit, 1, "InHouse"),
      new SqlParameter("@FEIN", SqlDbType.VarChar, 125, "FEIN"),
      new SqlParameter("@LicenseExpDate", SqlDbType.DateTime, 8, "LicenseExpDate"),
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGUID"),
      new SqlParameter("@ProducerContact", SqlDbType.VarChar, 200, "ProducerContact"),
      new SqlParameter("@ReasonForPlacement", SqlDbType.VarChar, 500, "ReasonForPlacement"),
      new SqlParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StateID", SqlDbType.Char, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      new SqlParameter("@LicenseNumberDateAdded", SqlDbType.DateTime, 8, "LicenseNumberDateAdded")
    });
    ((Control) this.btnContinue).Anchor = AnchorStyles.None;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnContinue).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnContinue).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnContinue).Location = new Point(312, 462);
    ((Control) this.btnContinue).Name = "btnContinue";
    ((ControlBase) this.btnContinue).Padding = new Size(7, 0);
    ((Control) this.btnContinue).Size = new Size(112 /*0x70*/, 23);
    ((Control) this.btnContinue).TabIndex = 4;
    ((ControlBase) this.btnContinue).Text = "Continue";
    this.btnContinue.UseOSThemes = (DefaultableBoolean) 2;
    this.lblTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.Location = new Point(88, 24);
    this.lblTitle.Name = "lblTitle";
    this.lblTitle.Size = new Size(336, 32 /*0x20*/);
    this.lblTitle.TabIndex = 5;
    this.lblTitle.Text = "Non-Admitted [insert state] Policy";
    this.lblTitle.TextAlign = ContentAlignment.MiddleLeft;
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label11);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtpLicenseAdded);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtReasonForPlacement);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label10);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label9);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboContacts);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label8);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtpLicenseExpDate);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtFEIN);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label7);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lnkStateFilingInfo);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.mgaDTPDateReceived);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label6);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboLicenses);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label5);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboFilingProducers);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.rbInHouse);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.rbOutsideProducer);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtSLA);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label4);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgA_ZipCodeResolver1);
    appearance3.AlphaLevel = (short) 230;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.White;
    appearance3.ForegroundAlpha = (Alpha) 2;
    appearance3.ImageAlpha = (Alpha) 2;
    appearance3.ImageBackground = (Image) componentResourceManager.GetObject("Appearance16.ImageBackground");
    appearance3.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 114);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(416, 344);
    ((Control) this.MgaGroupBox1).TabIndex = 6;
    this.MgaGroupBox1.Text = "Filing Information";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(294, 231);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(98, 14);
    this.Label11.TabIndex = 236;
    this.Label11.Text = "License Added";
    this.Label11.TextAlign = ContentAlignment.MiddleLeft;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpLicenseAdded.Appearance = (AppearanceBase) appearance4;
    appearance5.AlphaLevel = (short) 14;
    appearance5.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance5.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance5.BackColorAlpha = (Alpha) 2;
    appearance5.BackGradientAlignment = (GradientAlignment) 4;
    appearance5.BackGradientStyle = (GradientStyle) 5;
    appearance5.BorderAlpha = (Alpha) 1;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    appearance5.ForeColor = Color.FromArgb(49, 85, 153);
    appearance5.ForegroundAlpha = (Alpha) 2;
    this.dtpLicenseAdded.ButtonAppearance = (AppearanceBase) appearance5;
    this.dtpLicenseAdded.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpLicenseAdded).Location = new Point(297, 248);
    this.dtpLicenseAdded.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpLicenseAdded).Name = "dtpLicenseAdded";
    ((Control) this.dtpLicenseAdded).Size = new Size(95, 20);
    ((Control) this.dtpLicenseAdded).TabIndex = 235;
    ((UltraControlBase) this.dtpLicenseAdded).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpLicenseAdded).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpLicenseAdded.Value = (object) null;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtReasonForPlacement).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtReasonForPlacement).BackColor = Color.White;
    ((Control) this.txtReasonForPlacement).Location = new Point(294, 197);
    this.txtReasonForPlacement.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtReasonForPlacement).Name = "txtReasonForPlacement";
    ((Control) this.txtReasonForPlacement).Size = new Size(95, 20);
    ((Control) this.txtReasonForPlacement).TabIndex = 234;
    ((UltraControlBase) this.txtReasonForPlacement).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtReasonForPlacement).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(294, 180);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(98, 14);
    this.Label10.TabIndex = 233;
    this.Label10.Text = "Reason";
    this.Label10.TextAlign = ContentAlignment.MiddleLeft;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(19, 78);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(89, 20);
    this.Label9.TabIndex = 232;
    this.Label9.Text = "Contacts:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.cboContacts.BorderStyle = (UIElementBorderStyle) 4;
    this.cboContacts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboContacts).Location = new Point(120, 78);
    this.cboContacts.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboContacts).Name = "cboContacts";
    ((Control) this.cboContacts).Size = new Size(272, 21);
    ((Control) this.cboContacts).TabIndex = 231;
    this.ToolTip1.SetToolTip((Control) this.cboContacts, "If you do not see the contact your are looking for, you may type their name into the dropdown.");
    ((UltraControlBase) this.cboContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboContacts).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(294, 133);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(98, 14);
    this.Label8.TabIndex = 230;
    this.Label8.Text = "License Exp. Date";
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpLicenseExpDate.Appearance = (AppearanceBase) appearance7;
    appearance8.AlphaLevel = (short) 14;
    appearance8.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance8.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance8.BackColorAlpha = (Alpha) 2;
    appearance8.BackGradientAlignment = (GradientAlignment) 4;
    appearance8.BackGradientStyle = (GradientStyle) 5;
    appearance8.BorderAlpha = (Alpha) 1;
    appearance8.BorderColor = Color.FromArgb(78, 122, 171);
    appearance8.ForeColor = Color.FromArgb(49, 85, 153);
    appearance8.ForegroundAlpha = (Alpha) 2;
    this.dtpLicenseExpDate.ButtonAppearance = (AppearanceBase) appearance8;
    this.dtpLicenseExpDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpLicenseExpDate).Location = new Point(297, 150);
    this.dtpLicenseExpDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpLicenseExpDate).Name = "dtpLicenseExpDate";
    ((Control) this.dtpLicenseExpDate).Size = new Size(95, 20);
    ((Control) this.dtpLicenseExpDate).TabIndex = 229;
    ((UltraControlBase) this.dtpLicenseExpDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpLicenseExpDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpLicenseExpDate.Value = (object) null;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFEIN).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtFEIN).BackColor = Color.White;
    ((Control) this.txtFEIN).Location = new Point(120, 271);
    ((TextEditorControlBase) this.txtFEIN).MaxLength = 125;
    this.txtFEIN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    ((Control) this.txtFEIN).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.txtFEIN).TabIndex = 228;
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(19, 269);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(89, 23);
    this.Label7.TabIndex = 227;
    this.Label7.Text = "FEIN:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.lnkStateFilingInfo.AutoSize = true;
    this.lnkStateFilingInfo.BackColor = Color.Transparent;
    this.lnkStateFilingInfo.Location = new Point(117, 325);
    this.lnkStateFilingInfo.Name = "lnkStateFilingInfo";
    this.lnkStateFilingInfo.Size = new Size(188, 13);
    this.lnkStateFilingInfo.TabIndex = 226;
    this.lnkStateFilingInfo.TabStop = true;
    this.lnkStateFilingInfo.Tag = (object) "101";
    this.lnkStateFilingInfo.Text = "Show State-Specific Filing Information";
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaDTPDateReceived.Appearance = (AppearanceBase) appearance10;
    appearance11.AlphaLevel = (short) 14;
    appearance11.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance11.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance11.BackColorAlpha = (Alpha) 2;
    appearance11.BackGradientAlignment = (GradientAlignment) 4;
    appearance11.BackGradientStyle = (GradientStyle) 5;
    appearance11.BorderAlpha = (Alpha) 1;
    appearance11.BorderColor = Color.FromArgb(78, 122, 171);
    appearance11.ForeColor = Color.FromArgb(49, 85, 153);
    appearance11.ForegroundAlpha = (Alpha) 2;
    this.mgaDTPDateReceived.ButtonAppearance = (AppearanceBase) appearance11;
    this.mgaDTPDateReceived.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.mgaDTPDateReceived).Location = new Point(120, 294);
    this.mgaDTPDateReceived.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaDTPDateReceived).Name = "mgaDTPDateReceived";
    ((Control) this.mgaDTPDateReceived).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.mgaDTPDateReceived).TabIndex = 15;
    ((UltraControlBase) this.mgaDTPDateReceived).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaDTPDateReceived).UseOsThemes = (DefaultableBoolean) 2;
    this.mgaDTPDateReceived.Value = (object) null;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(22, 293);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(86, 23);
    this.Label6.TabIndex = 14;
    this.Label6.Text = "Date Received:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.cboLicenses.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboLicenses).DataSource = (object) this.ds.spGetProducerLicense;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboLicenses.DisplayLayout.Appearance = (AppearanceBase) appearance12;
    this.cboLicenses.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "License Type";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 115;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "License #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 8;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Format = "d";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 56;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 33;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 61;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 108;
    ultraGridBand.Columns.AddRange(new object[8]
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
    this.cboLicenses.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cboLicenses.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLicenses.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboLicenses.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboLicenses.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboLicenses.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboLicenses.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboLicenses.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboLicenses.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboLicenses.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboLicenses.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance13.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance13.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboLicenses.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance13;
    appearance14.BorderColor = Color.White;
    this.cboLicenses.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    this.cboLicenses.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance15.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance15.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance15.ForeColor = Color.Black;
    this.cboLicenses.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboLicenses.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboLicenses).DisplayMember = "License";
    this.cboLicenses.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLicenses).DropDownWidth = 400;
    ((Control) this.cboLicenses).Location = new Point(120, 102);
    this.cboLicenses.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLicenses).Name = "cboLicenses";
    ((Control) this.cboLicenses).Size = new Size(272, 21);
    ((Control) this.cboLicenses).TabIndex = 12;
    this.ToolTip1.SetToolTip((Control) this.cboLicenses, "If you do not see the license your are looking for, you may type their name into the dropdown.");
    ((UltraControlBase) this.cboLicenses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLicenses).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLicenses).ValueMember = "ProducerLicenseGUID";
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(8, 102);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(100, 20);
    this.Label5.TabIndex = 13;
    this.Label5.Text = "License:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.cboFilingProducers.BorderStyle = (UIElementBorderStyle) 4;
    this.cboFilingProducers.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboFilingProducers).Location = new Point(120, 54);
    this.cboFilingProducers.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFilingProducers).Name = "cboFilingProducers";
    ((Control) this.cboFilingProducers).Size = new Size(272, 21);
    ((Control) this.cboFilingProducers).TabIndex = 0;
    this.ToolTip1.SetToolTip((Control) this.cboFilingProducers, "If you do not see the producer your are looking for, you may type their name into the dropdown.");
    ((UltraControlBase) this.cboFilingProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFilingProducers).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 26);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(100, 20);
    this.Label2.TabIndex = 10;
    this.Label2.Text = "Filing Done By:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.rbInHouse.BackColor = Color.Transparent;
    this.rbInHouse.Checked = true;
    this.rbInHouse.Location = new Point(252, 26);
    this.rbInHouse.Name = "rbInHouse";
    this.rbInHouse.Size = new Size(72, 20);
    this.rbInHouse.TabIndex = 9;
    this.rbInHouse.TabStop = true;
    this.rbInHouse.Text = "In-House";
    this.rbInHouse.UseVisualStyleBackColor = false;
    this.rbOutsideProducer.BackColor = Color.Transparent;
    this.rbOutsideProducer.Location = new Point(120, 26);
    this.rbOutsideProducer.Name = "rbOutsideProducer";
    this.rbOutsideProducer.Size = new Size(112 /*0x70*/, 20);
    this.rbOutsideProducer.TabIndex = 8;
    this.rbOutsideProducer.Text = "Outside Producer";
    this.rbOutsideProducer.UseVisualStyleBackColor = false;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSLA).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtSLA).BackColor = Color.White;
    ((Control) this.txtSLA).Location = new Point(120, 248);
    this.txtSLA.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSLA).Name = "txtSLA";
    ((Control) this.txtSLA).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.txtSLA).TabIndex = 4;
    ((UltraControlBase) this.txtSLA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSLA).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(8, 243);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(100, 23);
    this.Label4.TabIndex = 3;
    this.Label4.Text = "SLA #:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(19, 54);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(89, 20);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Filing Producer:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.MgA_ZipCodeResolver1.AddressServiceURL = "";
    this.MgA_ZipCodeResolver1.AutoScrollMargin = new Size(0, 0);
    this.MgA_ZipCodeResolver1.AutoScrollMinSize = new Size(0, 0);
    this.MgA_ZipCodeResolver1.BackColor = Color.Transparent;
    this.MgA_ZipCodeResolver1.City = "";
    this.MgA_ZipCodeResolver1.County = "";
    this.MgA_ZipCodeResolver1.GeoRegion = "";
    this.MgA_ZipCodeResolver1.ISOCountryCode = "";
    this.MgA_ZipCodeResolver1.ISOCountryCodeMember = "";
    this.MgA_ZipCodeResolver1.ISOCountryList = (object) null;
    this.MgA_ZipCodeResolver1.ISOCountryNameMember = "";
    ((Control) this.MgA_ZipCodeResolver1).Location = new Point(56, 126);
    this.MgA_ZipCodeResolver1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgA_ZipCodeResolver1).Name = "MgA_ZipCodeResolver1";
    this.MgA_ZipCodeResolver1.Password = "";
    this.MgA_ZipCodeResolver1.ShowGlobal = true;
    ((Control) this.MgA_ZipCodeResolver1).Size = new Size(232, 119);
    this.MgA_ZipCodeResolver1.State = "";
    this.MgA_ZipCodeResolver1.Street1 = "";
    this.MgA_ZipCodeResolver1.Street2 = "";
    ((Control) this.MgA_ZipCodeResolver1).TabIndex = 11;
    this.MgA_ZipCodeResolver1.UserID = "";
    this.MgA_ZipCodeResolver1.ZipCode = "";
    this.MgA_ZipCodeResolver1.ZipCodeExtension = "";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 7;
    this.PictureBox1.TabStop = false;
    this.ToolTip1.AutomaticDelay = 0;
    this.lnkPreviousState.Anchor = AnchorStyles.None;
    this.lnkPreviousState.AutoSize = true;
    this.lnkPreviousState.Location = new Point(8, 466);
    this.lnkPreviousState.Name = "lnkPreviousState";
    this.lnkPreviousState.Size = new Size(92, 13);
    this.lnkPreviousState.TabIndex = 8;
    this.lnkPreviousState.TabStop = true;
    this.lnkPreviousState.Text = "<- Previous State";
    this.lnkPreviousState.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkNextState.Anchor = AnchorStyles.None;
    this.lnkNextState.AutoSize = true;
    this.lnkNextState.Location = new Point(112 /*0x70*/, 466);
    this.lnkNextState.Name = "lnkNextState";
    this.lnkNextState.Size = new Size(74, 13);
    this.lnkNextState.TabIndex = 9;
    this.lnkNextState.TabStop = true;
    this.lnkNextState.Text = "Next State ->";
    this.lnkNextState.TextAlign = ContentAlignment.MiddleCenter;
    this.err.ContainerControl = (ContainerControl) this;
    this.TblQuoteFilingProducersBindingSource.DataMember = "tblQuoteFilingProducers";
    this.TblQuoteFilingProducersBindingSource.DataSource = (object) this.ds;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(434, 493);
    this.ControlBox = false;
    this.Controls.Add((Control) this.lnkNextState);
    this.Controls.Add((Control) this.lnkPreviousState);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.lblTitle);
    this.Controls.Add((Control) this.btnContinue);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmFilingProducers);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Non-Admitted Policy - Filings";
    this.ds.EndInit();
    ((ISupportInitialize) this.btnContinue).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.dtpLicenseAdded).EndInit();
    ((ISupportInitialize) this.txtReasonForPlacement).EndInit();
    ((ISupportInitialize) this.cboContacts).EndInit();
    ((ISupportInitialize) this.dtpLicenseExpDate).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.mgaDTPDateReceived).EndInit();
    ((ISupportInitialize) this.cboLicenses).EndInit();
    ((ISupportInitialize) this.cboFilingProducers).EndInit();
    ((ISupportInitialize) this.txtSLA).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.TblQuoteFilingProducersBindingSource).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmFilingProducers(int quoteID)
    : this()
  {
    this._quoteID = quoteID;
    this._quote = new Quote(quoteID);
    this.cboFilingProducers.DropDownStyle = (UltraComboStyle) 0;
    this.cboLicenses.DropDownStyle = (UltraComboStyle) 0;
    this.cboContacts.DropDownStyle = (UltraComboStyle) 0;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._isNewRecord = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(QuoteID) from tblquotefilingproducers with (nolock) where QuoteID = @QuoteID", new object[2]
    {
      (object) "@QuoteID",
      (object) this._quoteID
    }) == 0;
    this.SetCompanyLineFilings();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public frmFilingProducers()
  {
    this.Load += new EventHandler(this.frmFilingProducers_Load);
    this.Closed += new EventHandler(this.frmFilingProducers_Closed);
    this._arrProducerLocList = new List<string>();
    this._assigningData = false;
    this._ClientAssigningData = false;
    this._UseClientContact = false;
    this._cannotForceClose = true;
    this._ismgaDTPDateReceivedChanged = false;
    this._invokeViaRater = false;
    this._currentStateID = string.Empty;
    this._showAllContacts = false;
    this._useClientLocationLicense = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("UseClientLocationLicense", false, true);
    this._useUserLicenseAsContacts = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("UseUserLicenseAsContacts", false, true);
    this._inHouseUsersProc = MGASystems.Common.Settings.SystemSettings.GetLazySetting<string>("InHouseUsersProc", "dbo.GetAllInhouseUsers");
    this._getUserLicensesOnly = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("GetUserLicensesOnly", false, true);
    this._userLicenseProc = MGASystems.Common.Settings.SystemSettings.GetLazySetting<string>("UseLicenseProc", "dbo.GetUserLicenses");
    this._useProducerLicenseAddress = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("FilingProducersUseProducerLicenseAddress", false, true);
    this._isOutsideFiling = false;
    this._isInhouseFiling = false;
    this._hasQuoteIDParameter = false;
    this._userAddressList = new Dictionary<Guid, frmFilingProducers.UserAddressRecord>();
    this.InitializeComponent();
  }

  private void SetCompanyLineFilings()
  {
    if (!this._isNewRecord)
      return;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Filing FROM tblCompanyLines WITH (NOLOCK) WHERE CompanylineGuid=@CG", new object[2]
    {
      (object) "@CG",
      (object) new Quote(this._quoteID).CompanyLineGuid
    });
    if (dataRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["Filing"])))
      return;
    string Left = dataRow["Filing"].ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "O", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "I", false) != 0)
        return;
      this._isInhouseFiling = true;
    }
    else
      this._isOutsideFiling = true;
  }

  public bool HasUnaskedStates
  {
    get
    {
      if (!this._dataFilled)
        throw new InvalidOperationException("Must call FillData method before reading this property.");
      return !this.CannotForceClose ? this.CannotForceClose : this.ds.GetFilingStates.Count != this.ds.tblQuoteFilingProducers.Count;
    }
  }

  public bool CompanyLineOutsideFiling => this._isOutsideFiling;

  public bool CompanyLineInhouseFiling => this._isInhouseFiling;

  public bool IsNewRow => this._isNewRecord;

  public virtual bool LoadUnderwritingLocations => false;

  protected virtual string InhouseUsersSQL() => string.Empty;

  protected virtual bool CannotForceClose
  {
    get => this._cannotForceClose;
    set => this._cannotForceClose = value;
  }

  public virtual bool InvokedViaRater
  {
    get => this._invokeViaRater;
    set => this._invokeViaRater = value;
  }

  public virtual bool DefaultToOutsideProducer
  {
    get => this._defaultToOutsideProducer;
    set => this._defaultToOutsideProducer = value;
  }

  public BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblQuoteFilingProducers.TableName];
  }

  private void SetAddressResolverProperties()
  {
    this.MgA_ZipCodeResolver1.AddressServiceURL = AddressResolverSettings.AddressResolverURL;
    this.MgA_ZipCodeResolver1.UserID = AddressResolverSettings.AddressResolveUserName;
    this.MgA_ZipCodeResolver1.Password = AddressResolverSettings.AddressResolverPassword;
  }

  private void frmFilingProducers_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((Control) this.btnContinue).Enabled = false;
    this._isFormLoading = true;
    this._hasQuoteIDParameter = DefaultDatabase.DiscoverParameters(this._inHouseUsersProc.Value).ContainsKey("@QuoteID");
    if (!this._dataFilled)
      throw new InvalidOperationException("Must call FillData method before showing form.");
    this.DefaultToOutsideProducer = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("FilingProducer.DefaultToOutsideProducer");
    this.SetAddressResolverProperties();
    if (this.HasUnaskedStates)
      this.GetUnaskedState();
    else if (this.ds.tblQuoteFilingProducers.Rows.Count == 0)
    {
      if (this.DefaultToOutsideProducer)
        this.rbOutsideProducer.Checked = true;
      else
        this.rbInHouse.Checked = true;
    }
    else if (this.ds.tblQuoteFilingProducers.Rows.Count > 0)
    {
      if (this.DefaultToOutsideProducer)
      {
        this.SetupDataBinding(false);
        this.rbOutsideProducer.Checked = !this.ds.tblQuoteFilingProducers[this.bmb.Position].InHouse;
        this.PlaceData();
      }
      else
      {
        this.SetupDataBinding(this.ds.tblQuoteFilingProducers[this.bmb.Position].InHouse);
        this._currentStateID = this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID;
        if (!this.ds.tblQuoteFilingProducers[this.bmb.Position].InHouse)
        {
          this.rbOutsideProducer.Checked = true;
          this.PlaceData();
        }
        else
        {
          this.rbInHouse.Checked = true;
          this.PlaceInhouseData();
        }
      }
    }
    if (this.ds.tblQuoteFilingProducers.Count >= 1)
      this.lblTitle.Text = $"Non-Admitted {DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT State FROM lstStates WHERE StateID=@StateID", new object[2]
      {
        (object) "@StateID",
        (object) this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID
      })} Premium";
    this.FillProducerList();
    this.rbInHouse.CheckedChanged += new EventHandler(this.ChangeFilingSource);
    this.rbOutsideProducer.CheckedChanged += new EventHandler(this.ChangeFilingSource);
    this.cboFilingProducers.ValueChanged += new EventHandler(this.cboFilingProducers_ValueChanged);
    this.cboLicenses.ValueChanged += new EventHandler(this.cboLicenses_ValueChanged);
    this.cboContacts.ValueChanged += new EventHandler(this.cboContacts_ValueChanged);
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboFilingProducers.Value)) && this.bmb.Position != -1 && this.ds.tblQuoteFilingProducers[this.bmb.Position].IsLicenseNumberNull())
    {
      if (this.ds.spGetProducerLicense.Count == 0)
      {
        try
        {
          this.GetProducerLicenses((Guid) this.cboFilingProducers.Value);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    this._isFormLoading = false;
    ((Control) this.btnContinue).Enabled = true;
    this.SetDefault();
    this.AfterLoad();
  }

  protected virtual void AfterLoad()
  {
  }

  public void FillData()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.ds.GetFilingStates, "[GetFilingStates]", new object[4]
    {
      (object) "@quoteID",
      (object) this._quoteID,
      (object) "@LoadUnderwritingLocations",
      (object) this.LoadUnderwritingLocations
    });
    this._showAllContacts = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowAllFilingProducerContacts");
    if (this._showAllContacts)
    {
      this.ds.tblProducerContacts.Clear();
      this.ds.tblProducerContacts.AddtblProducerContactsRow(Guid.Empty, Guid.Empty, string.Empty);
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblProducerContacts"
      }, "GetProducerLocationsContacts", new object[2]
      {
        (object) "@QuoteID",
        (object) this._quoteID
      });
    }
    else
    {
      this.ds.tblProducerContacts.Clear();
      this.ds.tblProducerContacts.AddtblProducerContactsRow(Guid.Empty, Guid.Empty, string.Empty);
    }
    try
    {
      this.daQuoteFilings.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quoteID;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daQuoteFilings, (DataTable) this.ds.tblQuoteFilingProducers);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.ds.InhouseUsers.AddInhouseUsersRow(Guid.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
    object obj = (object) null;
    if (this.bmb.Position != -1)
      obj = (object) this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID.ToString();
    Quote quote = new Quote(this._quoteID);
    int num = quote.HasUnderwriterAssistant ? 1 : 0;
    Guid? nullable;
    if (num != 0)
    {
      nullable = quote.UnderwritingAssistantGuid;
      this.FillUserAddress(nullable.Value, (dsFilingProducers.InhouseUsersRow) null);
    }
    nullable = quote.UnderwriterUserGuid;
    this.FillUserAddress(nullable.Value, (dsFilingProducers.InhouseUsersRow) null);
    dsFilingProducers.InhouseUsersDataTable inhouseUsers1 = this.ds.InhouseUsers;
    nullable = quote.UnderwriterUserGuid;
    string filterExpression1 = $"UserGuid = '{nullable.ToString()}'";
    if (inhouseUsers1.Select(filterExpression1).Length == 0)
    {
      Dictionary<Guid, frmFilingProducers.UserAddressRecord> userAddressList = this._userAddressList;
      nullable = quote.UnderwriterUserGuid;
      Guid key = nullable.Value;
      frmFilingProducers.UserAddressRecord userAddressRecord = userAddressList[key];
      dsFilingProducers.InhouseUsersDataTable inhouseUsers2 = this.ds.InhouseUsers;
      nullable = quote.UnderwriterUserGuid;
      Guid UserGUID = nullable.Value;
      string street = userAddressRecord.street;
      string street2 = userAddressRecord.street2;
      string city = userAddressRecord.city;
      string county = userAddressRecord.county;
      string state = userAddressRecord.state;
      string zipCode = userAddressRecord.zipCode;
      string UserName = $"{quote.Underwriter.LastName}, {quote.Underwriter.FirstName}";
      inhouseUsers2.AddInhouseUsersRow(UserGUID, street, street2, city, county, state, zipCode, UserName);
    }
    if (num != 0)
    {
      dsFilingProducers.InhouseUsersDataTable inhouseUsers3 = this.ds.InhouseUsers;
      nullable = quote.UnderwritingAssistantGuid;
      string filterExpression2 = $"UserGuid = '{nullable.ToString()}'";
      if (inhouseUsers3.Select(filterExpression2).Length == 0)
      {
        Dictionary<Guid, frmFilingProducers.UserAddressRecord> userAddressList = this._userAddressList;
        nullable = quote.UnderwritingAssistantGuid;
        Guid key = nullable.Value;
        frmFilingProducers.UserAddressRecord userAddressRecord = userAddressList[key];
        dsFilingProducers.InhouseUsersDataTable inhouseUsers4 = this.ds.InhouseUsers;
        nullable = quote.UnderwritingAssistantGuid;
        Guid UserGUID = nullable.Value;
        string street = userAddressRecord.street;
        string street2 = userAddressRecord.street2;
        string city = userAddressRecord.city;
        string county = userAddressRecord.county;
        string state = userAddressRecord.state;
        string zipCode = userAddressRecord.zipCode;
        string UserName = $"{quote.UnderwriterAssistant.LastName}, {quote.UnderwriterAssistant.FirstName}";
        inhouseUsers4.AddInhouseUsersRow(UserGUID, street, street2, city, county, state, zipCode, UserName);
      }
    }
    this.LoadInhouseUsers(RuntimeHelpers.GetObjectValue(obj));
    try
    {
      foreach (dsFilingProducers.InhouseUsersRow row in this.ds.InhouseUsers.Rows)
        this.FillUserAddress(row.UserGUID, row);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.RemoveDuplicateRows((DataTable) this.ds.InhouseUsers, "UserName");
    if (this._useClientLocationLicense.Value)
    {
      this.ds.tblClientOffices.AddtblClientOfficesRow(Guid.Empty, "", "", "", "", "", "", "", "", "", "");
      DefaultDatabase.LoadDataTable((DataTable) this.ds.tblClientOffices, CommandType.Text, "SELECT OfficeGUID, Location, Address1, Address2, City, County, State, FEIN, ZipCode, ZipPlus, Region FROM tblClientOffices");
    }
    DefaultDatabase.LoadDataTable((DataTable) this.ds.InHouseLicenses, "dbo.GetClientAndUserLicenses", new object[2]
    {
      (object) "@ClientLocationGUID",
      (object) DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT QuotingLocationGuid FROM tblQuotes WITH (NOLOCK) WHERE QuoteID = @qID", new object[2]
      {
        (object) "@qID",
        (object) this._quoteID
      })
    });
    if (this._getUserLicensesOnly.Value)
      DefaultDatabase.LoadDataTable((DataTable) this.ds.InHouseUserLicenses, this._userLicenseProc.Value, new object[2]
      {
        (object) "@StateID",
        obj
      });
    this.lnkNextState.Visible = this.ds.GetFilingStates.Count > 1;
    this.lnkPreviousState.Visible = this.ds.GetFilingStates.Count > 1;
    DataTable dataTable = (DataTable) PreLoadCache.Instance.Cache[(object) "tblProducerLocations"];
    string empty1 = string.Empty;
    try
    {
      foreach (DataRow row1 in dataTable.Rows)
      {
        string empty2 = string.Empty;
        if (!row1.IsNull("Name"))
          empty2 = row1["Name"].ToString();
        dsFilingProducers.dtLocationsRow row2 = this.ds.dtLocations.NewdtLocationsRow();
        row2.Name = empty2;
        row2.ProducerLocationGuid = (Guid) row1["ProducerLocationGuid"];
        this.ds.dtLocations.AdddtLocationsRow(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.OnFillData();
    this._dataFilled = true;
  }

  private void FillUserAddress(Guid userGuid, dsFilingProducers.InhouseUsersRow dr)
  {
    if (userGuid.Equals(Guid.Empty) || this._userAddressList.ContainsKey(userGuid))
      return;
    if (dr != null && !dr.IsAddress1Null())
    {
      string street = dr.IsAddress1Null() ? string.Empty : dr.Address1;
      string street2 = dr.IsAddress2Null() ? string.Empty : dr.Address2;
      string city = dr.IsCityNull() ? string.Empty : dr.City;
      string state = dr.IsStateNull() ? string.Empty : dr.State;
      string zipCode = dr.IsZipCodeNull() ? string.Empty : dr.ZipCode;
      string county = dr.IsCountyNull() ? string.Empty : dr.County;
      frmFilingProducers.UserAddressRecord userAddressRecord = new frmFilingProducers.UserAddressRecord(city, street, street2, state, zipCode, county);
      this._userAddressList.Add(userGuid, userAddressRecord);
    }
    else
    {
      if (dr != null && dr.IsAddress1Null() && this._userAddressList.ContainsKey(userGuid))
        this._userAddressList.Remove(userGuid);
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT City, State, ZipCode, County, Address1, Address2 FROM tblUsers WITH (NOLOCK) WHERE UserGUID = @UG", new object[2]
      {
        (object) "@UG",
        (object) userGuid
      });
      if (dataRow == null)
        return;
      string street = dataRow["Address1"].ToString();
      string street2 = Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["Address2"])) ? string.Empty : dataRow["Address2"].ToString();
      string city = dataRow["City"].ToString();
      string zipCode = Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["ZipCode"])) ? string.Empty : dataRow["ZipCode"].ToString();
      string state = Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["State"])) ? string.Empty : dataRow["State"].ToString();
      string county = Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["County"])) ? string.Empty : dataRow["County"].ToString();
      if (this._userAddressList.ContainsKey(userGuid))
        return;
      frmFilingProducers.UserAddressRecord userAddressRecord = new frmFilingProducers.UserAddressRecord(city, street, street2, state, zipCode, county);
      this._userAddressList.Add(userGuid, userAddressRecord);
    }
  }

  private void FillAddressControl(Guid userGuid)
  {
    if (this.bmb.Position == -1 || this._isFormLoading)
      return;
    if (!userGuid.Equals(Guid.Empty))
    {
      frmFilingProducers.UserAddressRecord userAddress = this._userAddressList[userGuid];
      this.MgA_ZipCodeResolver1.Street1 = userAddress.street;
      this.MgA_ZipCodeResolver1.Street2 = userAddress.street2;
      this.MgA_ZipCodeResolver1.City = userAddress.city;
      this.MgA_ZipCodeResolver1.State = userAddress.state;
      this.MgA_ZipCodeResolver1.County = userAddress.county;
      this.MgA_ZipCodeResolver1.ZipCode = userAddress.zipCode;
    }
    else
    {
      dsFilingProducers.tblQuoteFilingProducersRow quoteFilingProducer = this.ds.tblQuoteFilingProducers[this.bmb.Position];
      quoteFilingProducer.SetAddress1Null();
      quoteFilingProducer.SetAddress2Null();
      quoteFilingProducer.SetCityNull();
      quoteFilingProducer.SetCountyNull();
      quoteFilingProducer.SetStateNull();
      quoteFilingProducer.SetZipCodeNull();
      quoteFilingProducer.SetZipPlusNull();
      quoteFilingProducer.Set_RegionNull();
      this.ClearAddressData();
    }
  }

  private void RemoveDuplicateRows(DataTable dTable, string colName)
  {
    Dictionary<object, string> dictionary = new Dictionary<object, string>();
    List<DataRow> dataRowList = new List<DataRow>();
    try
    {
      foreach (DataRow row in dTable.Rows)
      {
        if (!dictionary.ContainsKey(RuntimeHelpers.GetObjectValue(row[colName])))
          dictionary.Add(RuntimeHelpers.GetObjectValue(row[colName]), string.Empty);
        else
          dataRowList.Add(row);
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
      foreach (DataRow row in dataRowList)
        dTable.Rows.Remove(row);
    }
    finally
    {
      List<DataRow>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void FilterDataByState()
  {
    if (!this.rbInHouse.Checked)
    {
      this.ds.InHouseLicenses.DefaultView.RowFilter = string.Empty;
    }
    else
    {
      object obj1 = (object) null;
      if (this.bmb.Position != -1)
      {
        obj1 = (object) this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID;
        this.ds.InhouseUsers.Clear();
        this.LoadInhouseUsers(RuntimeHelpers.GetObjectValue(obj1));
        try
        {
          foreach (dsFilingProducers.InhouseUsersRow row in this.ds.InhouseUsers.Rows)
            this.FillUserAddress(row.UserGUID, row);
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      bool flag = false;
      Guid userGuid = Guid.Empty;
      Guid guid1;
      if (((UltraDropDownBase) this.cboFilingProducers).SelectedRow != null && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboFilingProducers.Value)))
      {
        Quote quote = new Quote(this._quoteID);
        if (quote.Underwriter != null)
        {
          MGASystems.BusinessObjects.User underwriter = quote.Underwriter;
          if (underwriter.Name_LastFirst.Equals(RuntimeHelpers.GetObjectValue(this.cboFilingProducers.Value)))
          {
            if (this.ds.InHouseLicenses.Select($"StateID='{this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID}' AND UserGUID = '{underwriter.UserGuid.ToString()}'").Length > 0)
            {
              DataView defaultView = this.ds.InHouseLicenses.DefaultView;
              string[] strArray = new string[5]
              {
                "StateID='",
                this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID,
                "' AND UserGUID = '",
                null,
                null
              };
              guid1 = underwriter.UserGuid;
              strArray[3] = guid1.ToString();
              strArray[4] = "'";
              string str = string.Concat(strArray);
              defaultView.RowFilter = str;
              flag = true;
              userGuid = underwriter.UserGuid;
              this.FillUserAddress(userGuid, (dsFilingProducers.InhouseUsersRow) null);
            }
          }
        }
        if (!flag && quote.HasUnderwriterAssistant)
        {
          MGASystems.BusinessObjects.User underwriterAssistant = quote.UnderwriterAssistant;
          if (underwriterAssistant.Name_LastFirst.Equals(RuntimeHelpers.GetObjectValue(this.cboFilingProducers.Value)))
          {
            DataView defaultView = this.ds.InHouseLicenses.DefaultView;
            string[] strArray = new string[5]
            {
              "StateID='",
              this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID,
              "' AND UserGUID = '",
              null,
              null
            };
            guid1 = underwriterAssistant.UserGuid;
            strArray[3] = guid1.ToString();
            strArray[4] = "'";
            string str = string.Concat(strArray);
            defaultView.RowFilter = str;
            flag = true;
            userGuid = underwriterAssistant.UserGuid;
            this.FillUserAddress(userGuid, (dsFilingProducers.InhouseUsersRow) null);
          }
        }
      }
      if (!flag)
      {
        if (!string.IsNullOrEmpty(this.cboFilingProducers.Text))
        {
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, " SELECT TOP 1 tblUsers.UserGUID  FROM tblUsers WITH (NOLOCK)  INNER JOIN tblUserLicenses WITH (NOLOCK) ON tblUsers.UserGUID = tblUserLicenses.UserGUID  WHERE tblUserLicenses.StateID = COALESCE(@ST,tblUserLicenses.StateID)  AND tblUsers.Name_LastFirst = @NM  AND (tblUserLicenses.LicenseTypeID = 4)  AND (tblUserLicenses.Expires > @Now )", new object[6]
          {
            (object) "@NM",
            (object) this.cboFilingProducers.Text,
            (object) "@ST",
            obj1,
            (object) "@Now",
            (object) DateTime.Now
          }));
          if (objectValue != null)
          {
            this.FillUserAddress((Guid) objectValue, (dsFilingProducers.InhouseUsersRow) null);
            this.ds.InHouseLicenses.DefaultView.RowFilter = $"StateID='{this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID}' AND UserGUID = '{objectValue.ToString()}'";
          }
          else
            this.ds.InHouseLicenses.DefaultView.RowFilter = $"StateID='{this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID}'";
        }
        else if (this.ds.tblQuoteFilingProducers.Count > 0 && this.bmb.Position != -1 && !this.ds.tblQuoteFilingProducers[this.bmb.Position].IsFilingProducerNull())
          this.ds.InHouseLicenses.DefaultView.RowFilter = $"StateID='{this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID}' AND LicenseNumber LIKE '%{Regex.Replace(this.ds.tblQuoteFilingProducers[this.bmb.Position].FilingProducer, "[^A-Za-z0-9 ]", "")}%'";
        else
          this.ds.InHouseLicenses.DefaultView.RowFilter = $"StateID='{this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID}'";
      }
      else
      {
        this.cboLicenses.Value = (object) null;
        this.dtpLicenseAdded.Value = (object) null;
        if (this.ds.InHouseLicenses.Select($"StateID='{this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID}' AND UserGUID = '{userGuid.ToString()}'").Length == 1)
        {
          this.cboLicenses.Value = (object) userGuid;
          this.dtpLicenseAdded.Value = (object) DateAndTime.Now.Date;
        }
      }
      if (this.rbInHouse.Checked && this._useUserLicenseAsContacts.Value && ((UltraDropDownBase) this.cboContacts).SelectedRow != null)
      {
        object obj2 = this.cboContacts.Value;
        Guid guid2;
        if (obj2 == null)
        {
          guid1 = new Guid();
          guid2 = guid1;
        }
        else
          guid2 = (Guid) obj2;
        userGuid = guid2;
      }
      this.FillAddressControl(userGuid);
    }
  }

  private void DefaultToBroker()
  {
    if (this._isFormLoading && this.ds.tblQuoteFilingProducers.Count > 0 && !this.ds.tblQuoteFilingProducers[this.bmb.Position].IsFilingProducerNull())
      return;
    Quote quote = new Quote(this._quoteID);
    if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsUnderwriterLicenseValid(@userGuid, @date, @StateID)", new object[6]
    {
      (object) "@userGuid",
      (object) quote.Underwriter.UserGuid,
      (object) "@date",
      (object) DateTime.Now,
      (object) "@StateID",
      (object) this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID
    }) || quote.Underwriter == null)
      return;
    string str = $"{quote.Underwriter.LastName}, {quote.Underwriter.FirstName}";
    if (str == null || this.ds.InhouseUsers.Select($"UserName = '{str.Replace("'", "''")}'").Length <= 0)
      return;
    if (this.ds.InHouseLicenses.Select($"UserGUID = '{quote.Underwriter.UserGuid.ToString()}' AND StateID = '{this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID}'").Length <= 0)
      return;
    this.cboFilingProducers.Value = (object) str;
    this.cboLicenses.Value = (object) quote.Underwriter.UserGuid;
    this.FillAddressControl(quote.UnderwriterUserGuid.Value);
  }

  private void SetupDataBinding(bool Inhouse)
  {
    if (!Inhouse)
    {
      MGASimpleComboBox cboFilingProducers1 = this.cboFilingProducers;
      ((UltraGridBase) cboFilingProducers1).DataSource = (object) null;
      ((UltraDropDownBase) cboFilingProducers1).DisplayMember = string.Empty;
      ((UltraDropDownBase) cboFilingProducers1).ValueMember = string.Empty;
      MGASimpleComboBox cboContacts1 = this.cboContacts;
      ((UltraGridBase) cboContacts1).DataSource = (object) null;
      ((UltraDropDownBase) cboContacts1).DisplayMember = string.Empty;
      ((UltraDropDownBase) cboContacts1).ValueMember = string.Empty;
      MGAComboBox cboLicenses1 = this.cboLicenses;
      ((UltraGridBase) cboLicenses1).DataSource = (object) null;
      ((UltraDropDownBase) cboLicenses1).DisplayMember = string.Empty;
      ((UltraDropDownBase) cboLicenses1).ValueMember = string.Empty;
      MGASimpleComboBox cboFilingProducers2 = this.cboFilingProducers;
      ((UltraGridBase) cboFilingProducers2).DataSource = (object) this.ds.dtLocations;
      ((UltraDropDownBase) cboFilingProducers2).DisplayMember = "Name";
      ((UltraDropDownBase) cboFilingProducers2).ValueMember = "ProducerLocationGuid";
      ((UltraDropDownBase) cboFilingProducers2).DropDownWidth = 300;
      MGASimpleComboBox cboContacts2 = this.cboContacts;
      ((UltraGridBase) cboContacts2).DataSource = (object) this.ds.tblProducerContacts;
      ((UltraDropDownBase) cboContacts2).DisplayMember = "ContactName";
      ((UltraDropDownBase) cboContacts2).ValueMember = "ProducerContactGUID";
      ((UltraDropDownBase) cboContacts2).DropDownWidth = 300;
      MGAComboBox cboLicenses2 = this.cboLicenses;
      ((UltraGridBase) cboLicenses2).DataSource = (object) this.ds.spGetProducerLicense;
      ((UltraDropDownBase) cboLicenses2).DisplayMember = "License";
      ((UltraDropDownBase) cboLicenses2).ValueMember = "ProducerLicenseGUID";
      cboLicenses2.DisplayLayout.Bands[0].Columns["ProducerLicenseGUID"].Hidden = true;
      cboLicenses2.DisplayLayout.Bands[0].Columns["License"].Hidden = true;
      this.cboLicenses.Value = (object) Guid.Empty;
      this.cboLicenses.Text = string.Empty;
      this.dtpLicenseAdded.Value = (object) null;
    }
    else
    {
      MGASimpleComboBox cboFilingProducers3 = this.cboFilingProducers;
      ((UltraGridBase) cboFilingProducers3).DataSource = (object) null;
      ((UltraDropDownBase) cboFilingProducers3).DisplayMember = string.Empty;
      ((UltraDropDownBase) cboFilingProducers3).ValueMember = string.Empty;
      MGAComboBox cboLicenses3 = this.cboLicenses;
      ((UltraGridBase) cboLicenses3).DataSource = (object) null;
      ((UltraDropDownBase) cboLicenses3).DisplayMember = string.Empty;
      ((UltraDropDownBase) cboLicenses3).ValueMember = string.Empty;
      if (this._useClientLocationLicense.Value)
      {
        MGASimpleComboBox cboFilingProducers4 = this.cboFilingProducers;
        ((UltraGridBase) cboFilingProducers4).DataSource = (object) this.ds.tblClientOffices;
        ((UltraDropDownBase) cboFilingProducers4).DisplayMember = "Location";
        ((UltraDropDownBase) cboFilingProducers4).ValueMember = "OfficeGUID";
        ((UltraDropDownBase) cboFilingProducers4).DropDownWidth = 300;
        string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("UseClientLocationLicenseDefaultGuid", string.Empty);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(setting, string.Empty, false) != 0)
        {
          UltraGridRow Expression = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.cboFilingProducers).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) ([SpecialName] (x) =>
          {
            object obj = x.Cells["OfficeGUID"].Value;
            return (obj != null ? (Guid) obj : new Guid()) == new Guid(setting);
          })).SingleOrDefault<UltraGridRow>();
          if (!Information.IsNothing((object) Expression))
          {
            ((UltraGridBase) this.cboFilingProducers).ActiveRow = Expression;
            ((UltraDropDownBase) this.cboFilingProducers).SelectedRow = Expression;
          }
        }
      }
      else
      {
        MGASimpleComboBox cboFilingProducers5 = this.cboFilingProducers;
        ((UltraGridBase) cboFilingProducers5).DataSource = (object) this.ds.InhouseUsers;
        ((UltraDropDownBase) cboFilingProducers5).DisplayMember = "UserName";
        ((UltraDropDownBase) cboFilingProducers5).DropDownWidth = 300;
      }
      if (this._useUserLicenseAsContacts.Value)
      {
        MGASimpleComboBox cboContacts = this.cboContacts;
        ((UltraGridBase) cboContacts).DataSource = (object) this.ds.InhouseUsers;
        ((UltraDropDownBase) cboContacts).DisplayMember = "UserName";
        ((UltraDropDownBase) cboContacts).ValueMember = "UserGUID";
        ((UltraDropDownBase) cboContacts).DropDownWidth = 300;
        string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("UseUserLicenseAsContactsDefaultGuid", string.Empty);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(setting, string.Empty, false) != 0)
        {
          UltraGridRow Expression = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.cboContacts).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) ([SpecialName] (x) =>
          {
            object obj = x.Cells["UserGUID"].Value;
            return (obj != null ? (Guid) obj : new Guid()) == new Guid(setting);
          })).SingleOrDefault<UltraGridRow>();
          if (!Information.IsNothing((object) Expression))
          {
            ((UltraGridBase) this.cboContacts).ActiveRow = Expression;
            ((UltraDropDownBase) this.cboContacts).SelectedRow = Expression;
          }
        }
      }
      if (this._getUserLicensesOnly.Value)
      {
        MGAComboBox cboLicenses4 = this.cboLicenses;
        ((UltraGridBase) cboLicenses4).DataSource = (object) this.ds.InHouseUserLicenses;
        ((UltraDropDownBase) cboLicenses4).DisplayMember = "LicenseNumber";
        ((UltraDropDownBase) cboLicenses4).ValueMember = "UserGUID";
        cboLicenses4.DisplayLayout.Bands[0].Columns["UserGuid"].Hidden = true;
        cboLicenses4.DisplayLayout.Bands[0].Columns["StateID"].Width = 40;
        cboLicenses4.DisplayLayout.Bands[0].Columns["LicenseNumber"].Width = 100;
        cboLicenses4.DisplayLayout.Bands[0].Columns["Expires"].Hidden = true;
        string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("GetUserLicensesOnlyDefaultGuid", string.Empty);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(setting, string.Empty, false) != 0)
        {
          UltraGridRow Expression = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.cboLicenses).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) ([SpecialName] (x) =>
          {
            object obj = x.Cells["UserGUID"].Value;
            return (obj != null ? (Guid) obj : new Guid()) == new Guid(setting);
          })).SingleOrDefault<UltraGridRow>();
          if (!Information.IsNothing((object) Expression))
          {
            ((UltraGridBase) this.cboLicenses).ActiveRow = Expression;
            ((UltraDropDownBase) this.cboLicenses).SelectedRow = Expression;
            ((TextEditorControlBase) this.txtSLA).Text = ((UltraDropDownBase) this.cboLicenses).SelectedRow.Cells["LicenseNumber"].Value.ToString();
            this.dtpLicenseExpDate.Value = (object) ((UltraDropDownBase) this.cboLicenses).SelectedRow.Cells["Expires"].Value.ToString();
            this.dtpLicenseAdded.Value = (object) DateAndTime.Now.Date;
          }
        }
      }
      else
      {
        MGAComboBox cboLicenses5 = this.cboLicenses;
        ((UltraGridBase) cboLicenses5).DataSource = (object) this.ds.InHouseLicenses;
        ((UltraDropDownBase) cboLicenses5).DisplayMember = "LicenseNumber";
        ((UltraDropDownBase) cboLicenses5).ValueMember = "UserGUID";
        cboLicenses5.DisplayLayout.Bands[0].Columns["UserGuid"].Hidden = true;
        cboLicenses5.DisplayLayout.Bands[0].Columns["StateID"].Width = 40;
        cboLicenses5.DisplayLayout.Bands[0].Columns["LicenseNumber"].Width = 100;
      }
      this.DefaultToBroker();
    }
    this.FilterDataByState();
  }

  private void PlaceData()
  {
    dsFilingProducers.tblQuoteFilingProducersRow quoteFilingProducer = this.ds.tblQuoteFilingProducers[this.bmb.Position];
    if (!quoteFilingProducer.Is_RegionNull())
      this.MgA_ZipCodeResolver1.GeoRegion = quoteFilingProducer._Region;
    if (!quoteFilingProducer.IsFilingProducerLocationGUIDNull())
    {
      this.cboFilingProducers.Value = (object) quoteFilingProducer.FilingProducerLocationGUID;
      this.GetProducerLicenses(quoteFilingProducer.FilingProducerLocationGUID);
    }
    else if (!quoteFilingProducer.IsFilingProducerNull())
    {
      this.cboFilingProducers.Value = (object) quoteFilingProducer.FilingProducer;
      if (this.cboFilingProducers.Value.ToString().Contains(this.cboFilingProducers.Text) & quoteFilingProducer.FilingProducer.IsGuid())
      {
        string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP (1) Name\r\n                            FROM tblProducerLocations WHERE (ProducerLocationGUID = @ProducerLocationGUID)", new object[2]
        {
          (object) "@ProducerLocationGUID",
          (object) quoteFilingProducer.FilingProducer
        });
        this.cboFilingProducers.Value = (object) quoteFilingProducer.FilingProducer;
        this.cboFilingProducers.Text = str;
      }
      else
        this.cboFilingProducers.Value = (object) quoteFilingProducer.FilingProducer;
    }
    if (!quoteFilingProducer.IsISOCountryCodeNull())
      this.MgA_ZipCodeResolver1.ISOCountryCode = quoteFilingProducer.ISOCountryCode;
    if (!quoteFilingProducer.IsProducerLicenseGUIDNull())
      this.cboLicenses.Value = (object) quoteFilingProducer.ProducerLicenseGUID;
    else if (!quoteFilingProducer.IsLicenseNumberNull())
      this.cboLicenses.Text = quoteFilingProducer.LicenseNumber;
    if (!quoteFilingProducer.IsSLA_NumberNull())
      ((TextEditorControlBase) this.txtSLA).Text = quoteFilingProducer.SLA_Number;
    if (!quoteFilingProducer.IsFEINNull())
      ((TextEditorControlBase) this.txtFEIN).Text = quoteFilingProducer.FEIN;
    if (!quoteFilingProducer.IsLicenseExpDateNull())
      this.dtpLicenseExpDate.Value = (object) quoteFilingProducer.LicenseExpDate;
    if (!quoteFilingProducer.IsLicenseNumberDateAddedNull())
      this.dtpLicenseAdded.Value = (object) quoteFilingProducer.LicenseNumberDateAdded;
    if (!quoteFilingProducer.IsProducerContactGUIDNull())
    {
      this.LoadContacts();
      this.cboContacts.Value = (object) quoteFilingProducer.ProducerContactGUID;
    }
    else if (!quoteFilingProducer.IsProducerContactNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(quoteFilingProducer.ProducerContact, Guid.Empty.ToString(), false) != 0)
      this.cboContacts.Text = quoteFilingProducer.ProducerContact;
    if (!quoteFilingProducer.IsUserContactGuidNull())
      this.cboContacts.Value = (object) quoteFilingProducer.UserContactGuid;
    else if (!quoteFilingProducer.IsUserContactNull())
      this.cboContacts.Text = quoteFilingProducer.UserContact;
    if (!quoteFilingProducer.IsReasonForPlacementNull())
      ((TextEditorControlBase) this.txtReasonForPlacement).Text = quoteFilingProducer.ReasonForPlacement;
    this.AssignAddressInfo(this.ds.tblQuoteFilingProducers[this.bmb.Position]);
    if (!quoteFilingProducer.IsDateRecdNull())
      this.mgaDTPDateReceived.Value = (object) quoteFilingProducer.DateRecd;
  }

  private void PlaceInhouseData()
  {
    dsFilingProducers.tblQuoteFilingProducersRow quoteFilingProducer = this.ds.tblQuoteFilingProducers[this.bmb.Position];
    this.MgA_ZipCodeResolver1.GeoRegion = quoteFilingProducer.Is_RegionNull() ? string.Empty : quoteFilingProducer._Region;
    if (!quoteFilingProducer.IsISOCountryCodeNull())
      this.MgA_ZipCodeResolver1.ISOCountryCode = quoteFilingProducer.ISOCountryCode;
    if (!quoteFilingProducer.IsCityNull())
      this.MgA_ZipCodeResolver1.City = quoteFilingProducer.City;
    if (!quoteFilingProducer.IsStateNull())
      this.MgA_ZipCodeResolver1.State = quoteFilingProducer.State;
    if (!quoteFilingProducer.IsZipCodeNull())
      this.MgA_ZipCodeResolver1.ZipCode = quoteFilingProducer.ZipCode;
    if (!quoteFilingProducer.IsLicenseNumberNull())
      this.cboLicenses.Text = quoteFilingProducer.LicenseNumber;
    else
      this.cboLicenses.Text = string.Empty;
    if (!quoteFilingProducer.IsFilingProducerNull())
      this.cboFilingProducers.Text = quoteFilingProducer.FilingProducer;
    else
      this.cboFilingProducers.Text = string.Empty;
    if (!quoteFilingProducer.IsProducerContactNull())
    {
      this.LoadContacts();
      this.cboContacts.Text = quoteFilingProducer.ProducerContact;
    }
    else if (!this._useUserLicenseAsContacts.Value)
      this.cboContacts.Text = string.Empty;
    if (!quoteFilingProducer.IsUserContactGuidNull())
      this.cboContacts.Value = (object) quoteFilingProducer.UserContactGuid;
    else if (!quoteFilingProducer.IsUserContactNull())
      this.cboContacts.Text = quoteFilingProducer.UserContact;
    if (!quoteFilingProducer.IsSLA_NumberNull())
      ((TextEditorControlBase) this.txtSLA).Text = quoteFilingProducer.SLA_Number;
    else
      ((TextEditorControlBase) this.txtSLA).Text = string.Empty;
    if (!quoteFilingProducer.IsFEINNull())
      ((TextEditorControlBase) this.txtFEIN).Text = quoteFilingProducer.FEIN;
    else
      ((TextEditorControlBase) this.txtFEIN).Text = string.Empty;
    if (!quoteFilingProducer.IsReasonForPlacementNull())
      ((TextEditorControlBase) this.txtReasonForPlacement).Text = quoteFilingProducer.ReasonForPlacement;
    else
      ((TextEditorControlBase) this.txtReasonForPlacement).Text = string.Empty;
    if (!quoteFilingProducer.IsDateRecdNull())
      this.mgaDTPDateReceived.Value = (object) quoteFilingProducer.DateRecd;
    else
      this.mgaDTPDateReceived.Value = (object) null;
    if (!quoteFilingProducer.IsLicenseExpDateNull())
      this.dtpLicenseExpDate.Value = (object) quoteFilingProducer.LicenseExpDate;
    else
      this.dtpLicenseExpDate.Value = (object) null;
    if (!quoteFilingProducer.IsLicenseNumberDateAddedNull())
      this.dtpLicenseAdded.Value = (object) quoteFilingProducer.LicenseNumberDateAdded;
    else
      this.dtpLicenseAdded.Value = (object) null;
    this.AssignAddressInfo(this.ds.tblQuoteFilingProducers[this.bmb.Position]);
  }

  private void FillProducerInfo()
  {
    if (this.rbOutsideProducer.Checked)
      this.SetupDataBinding(false);
    Guid producerLocationGuid = new Quote(this._quoteID).ProducerLocationGuid;
    DataRow dataRow1 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ProducerName, ProducerAddress1, ProducerAddress2, ProducerCity, ProducerState, ProducerZipCode, ProducerZipPlus FROM tblQuotes WITH (NOLOCK) WHERE QuoteID=@QuoteID", new object[2]
    {
      (object) "@QuoteID",
      (object) this._quoteID
    });
    if (dataRow1 != null)
    {
      this.cboFilingProducers.Value = (object) producerLocationGuid;
      if (((UltraGridBase) this.cboFilingProducers).DataSource != null && ((UltraGridBase) this.cboFilingProducers).DataSource == this.ds.dtLocations)
      {
        if (this.ds.dtLocations.FindByProducerLocationGuid(producerLocationGuid) == null)
        {
          dsFilingProducers.dtLocationsRow row = this.ds.dtLocations.NewdtLocationsRow();
          row.ProducerLocationGuid = producerLocationGuid;
          row.Name = !dataRow1.IsNull("ProducerName") ? dataRow1["ProducerName"].ToString() : string.Empty;
          this.ds.dtLocations.AdddtLocationsRow(row);
        }
        foreach (UltraGridRow row in ((UltraGridBase) this.cboFilingProducers).Rows)
        {
          if (((Guid) row.Cells["ProducerLocationGUID"].Value).Equals(producerLocationGuid))
          {
            ((UltraDropDownBase) this.cboFilingProducers).SelectedRow = row;
            ((UltraGridBase) this.cboFilingProducers).ActiveRow = row;
          }
        }
      }
    }
    bool flag = false;
    if (this._useProducerLicenseAddress.Value)
    {
      string str = "select top 1 LicenseAddress1, LicenseAddress2,  LicenseCity, LicenseStateID, LicenseZipCode,LicenseZipCodeExt from tblProducerLicenses with (nolock) ";
      DataRow dataRow2;
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboLicenses.Value)) && this.cboLicenses.Value is Guid)
        dataRow2 = DefaultDatabase.ExecuteDataRow(CommandType.Text, str + " where ProducerLicenseGUID = @PLG", new object[2]
        {
          (object) "@PLG",
          this.cboLicenses.Value
        });
      else
        dataRow2 = DefaultDatabase.ExecuteDataRow(CommandType.Text, str + " where ProducerLocationGUID = @PLG", new object[2]
        {
          (object) "@PLG",
          (object) producerLocationGuid
        });
      if (dataRow2 != null)
      {
        flag = !Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow2["LicenseAddress1"]));
        MGA_ZipCodeResolver zipCodeResolver1 = this.MgA_ZipCodeResolver1;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow2["LicenseAddress1"])))
          zipCodeResolver1.Street1 = (string) dataRow2["LicenseAddress1"];
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow2["LicenseAddress2"])))
          zipCodeResolver1.Street2 = (string) dataRow2["LicenseAddress2"];
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow2["LicenseCity"])))
          zipCodeResolver1.City = (string) dataRow2["LicenseCity"];
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow2["LicenseStateID"])))
          zipCodeResolver1.State = (string) dataRow2["LicenseStateID"];
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow2["LicenseZipCode"])))
          zipCodeResolver1.ZipCode = (string) dataRow2["LicenseZipCode"];
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow2["LicenseZipCodeExt"])))
          zipCodeResolver1.ZipCodeExtension = (string) dataRow2["LicenseZipCodeExt"];
      }
    }
    if (this._useProducerLicenseAddress.Value && flag)
      return;
    MGA_ZipCodeResolver zipCodeResolver1_1 = this.MgA_ZipCodeResolver1;
    zipCodeResolver1_1.Street1 = (string) dataRow1["ProducerAddress1"];
    if (dataRow1["ProducerAddress2"] != DBNull.Value)
      zipCodeResolver1_1.Street2 = (string) dataRow1["ProducerAddress2"];
    if (dataRow1["ProducerCity"] != DBNull.Value)
      zipCodeResolver1_1.City = (string) dataRow1["ProducerCity"];
    if (dataRow1["ProducerState"] != DBNull.Value)
      zipCodeResolver1_1.State = (string) dataRow1["ProducerState"];
    if (dataRow1["ProducerZipCode"] != DBNull.Value)
      zipCodeResolver1_1.ZipCode = (string) dataRow1["ProducerZipCode"];
    if (dataRow1["ProducerZipPlus"] != DBNull.Value)
      zipCodeResolver1_1.ZipCodeExtension = (string) dataRow1["ProducerZipPlus"];
  }

  private void ShowStateLabel()
  {
    this.lblTitle.Text = $"Non-Admitted {DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT State FROM lstStates WHERE StateID=@StateID", new object[2]
    {
      (object) "@StateID",
      (object) this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID
    })} Policy";
  }

  private void FillProducerList()
  {
    this._arrProducerLocList.Clear();
    try
    {
      foreach (dsFilingProducers.tblQuoteFilingProducersRow row in this.ds.tblQuoteFilingProducers.Rows)
      {
        if (row != DBNull.Value && !row.IsFilingProducerNull())
          this._arrProducerLocList.Add(row.FilingProducer);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void UpdateOutSideProducerInfo()
  {
    dsFilingProducers.tblQuoteFilingProducersRow quoteFilingProducer = this.ds.tblQuoteFilingProducers[this.bmb.Position];
    this.rbOutsideProducer.Checked = !quoteFilingProducer.InHouse;
    if (!quoteFilingProducer.IsFilingProducerLocationGUIDNull())
      this.cboFilingProducers.Value = (object) quoteFilingProducer.FilingProducerLocationGUID;
    else
      this.cboFilingProducers.Value = (object) null;
    if (!quoteFilingProducer.IsProducerContactGUIDNull())
      this.cboContacts.Value = (object) quoteFilingProducer.ProducerContactGUID;
    else
      this.cboContacts.Value = (object) null;
    if (!quoteFilingProducer.IsProducerLicenseGUIDNull())
      this.cboLicenses.Value = (object) quoteFilingProducer.ProducerLicenseGUID;
    else
      this.cboLicenses.Value = (object) null;
    if (!quoteFilingProducer.IsLicenseNumberNull())
      this.cboLicenses.Text = quoteFilingProducer.LicenseNumber;
    else
      this.cboLicenses.Text = string.Empty;
    if (!quoteFilingProducer.IsSLA_NumberNull())
      ((TextEditorControlBase) this.txtSLA).Text = quoteFilingProducer.SLA_Number;
    else
      ((TextEditorControlBase) this.txtSLA).Text = string.Empty;
    if (!quoteFilingProducer.IsFEINNull())
      ((TextEditorControlBase) this.txtFEIN).Text = quoteFilingProducer.FEIN;
    else
      ((TextEditorControlBase) this.txtFEIN).Text = string.Empty;
    if (!quoteFilingProducer.IsDateRecdNull() && DateTime.Compare(quoteFilingProducer.DateRecd, DateTime.MinValue) > 0 && DateTime.Compare(quoteFilingProducer.DateRecd, DateTime.MaxValue) < 0)
      this.mgaDTPDateReceived.Value = (object) quoteFilingProducer.DateRecd;
    else
      this.mgaDTPDateReceived.Value = (object) null;
    if (!quoteFilingProducer.IsFilingProducerNull())
    {
      this.cboFilingProducers.Text = quoteFilingProducer.FilingProducer;
    }
    else
    {
      this.cboFilingProducers.Text = string.Empty;
      this.rbInHouse.Checked = true;
    }
    if (!quoteFilingProducer.IsLicenseExpDateNull() && DateTime.Compare(quoteFilingProducer.LicenseExpDate, DateTime.MinValue) > 0 && DateTime.Compare(quoteFilingProducer.LicenseExpDate, DateTime.MaxValue) < 0)
      this.dtpLicenseExpDate.Value = (object) quoteFilingProducer.LicenseExpDate;
    else
      this.dtpLicenseExpDate.Value = (object) null;
    if (!quoteFilingProducer.IsLicenseNumberDateAddedNull())
      this.dtpLicenseAdded.Value = (object) quoteFilingProducer.LicenseNumberDateAdded;
    else
      this.dtpLicenseAdded.Value = (object) null;
    this.AssignAddressInfo(this.ds.tblQuoteFilingProducers[this.bmb.Position]);
  }

  private void AssignAddressInfo(dsFilingProducers.tblQuoteFilingProducersRow dr)
  {
    dsFilingProducers.tblQuoteFilingProducersRow filingProducersRow = dr;
    this.MgA_ZipCodeResolver1.Street1 = filingProducersRow.IsAddress1Null() ? string.Empty : filingProducersRow.Address1;
    this.MgA_ZipCodeResolver1.Street2 = filingProducersRow.IsAddress2Null() ? string.Empty : filingProducersRow.Address2;
    this.MgA_ZipCodeResolver1.City = filingProducersRow.IsCityNull() ? string.Empty : filingProducersRow.City;
    this.MgA_ZipCodeResolver1.State = filingProducersRow.IsStateNull() ? string.Empty : filingProducersRow.State;
    this.MgA_ZipCodeResolver1.ZipCode = filingProducersRow.IsZipCodeNull() ? string.Empty : filingProducersRow.ZipCode;
    this.MgA_ZipCodeResolver1.County = filingProducersRow.IsCountyNull() ? string.Empty : filingProducersRow.County;
    this.MgA_ZipCodeResolver1.ZipCodeExtension = filingProducersRow.IsZipPlusNull() ? string.Empty : filingProducersRow.ZipPlus;
  }

  private void UpdateInhouseProducerInfo()
  {
    dsFilingProducers.tblQuoteFilingProducersRow quoteFilingProducer = this.ds.tblQuoteFilingProducers[this.bmb.Position];
    this.rbInHouse.Checked = quoteFilingProducer.InHouse;
    this.cboFilingProducers.Value = (object) null;
    this.cboLicenses.Value = (object) null;
    if (!quoteFilingProducer.IsFilingProducerNull())
      this.cboFilingProducers.Text = quoteFilingProducer.FilingProducer;
    else
      this.cboFilingProducers.Text = string.Empty;
    if (!quoteFilingProducer.IsLicenseNumberNull())
      this.cboLicenses.Text = quoteFilingProducer.LicenseNumber;
    else
      this.cboLicenses.Text = string.Empty;
    if (!quoteFilingProducer.IsSLA_NumberNull())
      ((TextEditorControlBase) this.txtSLA).Text = quoteFilingProducer.SLA_Number;
    else
      ((TextEditorControlBase) this.txtSLA).Text = string.Empty;
    if (!quoteFilingProducer.IsFEINNull())
      ((TextEditorControlBase) this.txtFEIN).Text = quoteFilingProducer.FEIN;
    else
      ((TextEditorControlBase) this.txtFEIN).Text = string.Empty;
    if (!quoteFilingProducer.IsDateRecdNull() && DateTime.Compare(quoteFilingProducer.DateRecd, DateTime.MinValue) > 0 && DateTime.Compare(quoteFilingProducer.DateRecd, DateTime.MaxValue) < 0)
      this.mgaDTPDateReceived.Value = (object) quoteFilingProducer.DateRecd;
    else
      this.mgaDTPDateReceived.Value = (object) null;
    if (!quoteFilingProducer.IsLicenseExpDateNull() && DateTime.Compare(quoteFilingProducer.LicenseExpDate, DateTime.MinValue) > 0 && DateTime.Compare(quoteFilingProducer.LicenseExpDate, DateTime.MaxValue) < 0)
      this.dtpLicenseExpDate.Value = (object) quoteFilingProducer.LicenseExpDate;
    else
      this.dtpLicenseExpDate.Value = (object) null;
    if (!quoteFilingProducer.IsLicenseNumberDateAddedNull())
      this.dtpLicenseAdded.Value = (object) quoteFilingProducer.LicenseNumberDateAdded;
    else
      this.dtpLicenseAdded.Value = (object) null;
    this.AssignAddressInfo(this.ds.tblQuoteFilingProducers[this.bmb.Position]);
  }

  private void UpdateFilingProducerInfo()
  {
    if (!this.ds.tblQuoteFilingProducers[this.bmb.Position].InHouse)
    {
      this.rbOutsideProducer.Checked = true;
      this.SetupDataBinding(false);
      this.UpdateOutSideProducerInfo();
    }
    else
    {
      this.rbInHouse.CheckedChanged -= new EventHandler(this.rbInHouse_CheckedChanged);
      this._assigningData = true;
      this.rbInHouse.Checked = true;
      this.FilterDataByState();
      this.SetupDataBinding(true);
      this.UpdateInhouseProducerInfo();
      this.rbInHouse.CheckedChanged += new EventHandler(this.rbInHouse_CheckedChanged);
      this._assigningData = false;
    }
  }

  private void ClearDatasetFields()
  {
    dsFilingProducers.tblQuoteFilingProducersRow quoteFilingProducer = this.ds.tblQuoteFilingProducers[this.bmb.Position];
    quoteFilingProducer.SetAddress1Null();
    quoteFilingProducer.SetAddress2Null();
    quoteFilingProducer.SetCityNull();
    quoteFilingProducer.SetCountyNull();
    quoteFilingProducer.SetISOCountryCodeNull();
    quoteFilingProducer.SetLicenseNumberNull();
    quoteFilingProducer.SetProducerLicenseGUIDNull();
    quoteFilingProducer.SetFilingProducerLocationGUIDNull();
    quoteFilingProducer.SetFilingProducerNull();
    quoteFilingProducer.SetSLA_NumberNull();
    quoteFilingProducer.SetFEINNull();
    quoteFilingProducer.SetStateNull();
    quoteFilingProducer.SetZipCodeNull();
    quoteFilingProducer.SetZipPlusNull();
    quoteFilingProducer.Set_RegionNull();
    quoteFilingProducer.SetDateRecdNull();
    quoteFilingProducer.SetLicenseNumberDateAddedNull();
    if (((IEnumerable<UltraGridRow>) ((UltraGridBase) this.cboContacts).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) ([SpecialName] (c) =>
    {
      object obj = c.Cells[((UltraDropDownBase) this.cboContacts).ValueMember.ToString()].Value;
      return (obj != null ? (Guid) obj : new Guid()) == Guid.Empty;
    })).SingleOrDefault<UltraGridRow>() == null)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraGridBase) this.cboContacts).DataSource.ToString(), "InhouseUsers", false) == 0)
        this.ds.InhouseUsers.AddInhouseUsersRow(Guid.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraGridBase) this.cboContacts).DataSource.ToString(), "", false) == 0)
        this.ds.tblProducerContacts.AddtblProducerContactsRow(Guid.Empty, Guid.Empty, string.Empty);
    }
    this.cboContacts.Value = (object) Guid.Empty;
  }

  private void SaveData()
  {
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daQuoteFilings, (DataTable) this.ds.tblQuoteFilingProducers);
      CurrentUser.Instance.LogAction("Filing Producer Information was modified. Quote ID: " + Conversions.ToString(this._quoteID), this._quote.QuoteGuid);
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.Message.Contains("FK_tblQuoteFilingProducers_tblProducerLocations"))
      {
        int num1 = (int) MessageBox.Show("There Is no existing Producer Location for this record", "Record Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (ex2.Message.Contains("PK_tblQuoteFilingProducers"))
      {
        int num2 = (int) MessageBox.Show("The system has detected duplicate filing producer records.\n\nMake sure that the states are unique.", "Existing Record Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
    this.SaveClientData();
  }

  protected virtual void SaveClientData()
  {
  }

  private void SetAddressInfo(dsFilingProducers.tblQuoteFilingProducersRow dr)
  {
    dsFilingProducers.tblQuoteFilingProducersRow filingProducersRow = dr;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgA_ZipCodeResolver1.Street1, string.Empty, false) != 0)
      filingProducersRow.Address1 = this.MgA_ZipCodeResolver1.Street1;
    else
      filingProducersRow.SetAddress1Null();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgA_ZipCodeResolver1.Street2, string.Empty, false) != 0)
      filingProducersRow.Address2 = this.MgA_ZipCodeResolver1.Street2;
    else
      filingProducersRow.SetAddress2Null();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgA_ZipCodeResolver1.City, string.Empty, false) != 0)
      filingProducersRow.City = this.MgA_ZipCodeResolver1.City;
    else
      filingProducersRow.SetCityNull();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgA_ZipCodeResolver1.County, string.Empty, false) != 0)
      filingProducersRow.County = this.MgA_ZipCodeResolver1.County;
    else
      filingProducersRow.SetCountyNull();
    filingProducersRow.ISOCountryCode = this.MgA_ZipCodeResolver1.ISOCountryCode;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgA_ZipCodeResolver1.State, string.Empty, false) != 0)
      filingProducersRow.State = this.MgA_ZipCodeResolver1.State;
    else
      filingProducersRow.SetStateNull();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgA_ZipCodeResolver1.ZipCode, string.Empty, false) != 0)
      filingProducersRow.ZipCode = this.MgA_ZipCodeResolver1.ZipCode;
    else
      filingProducersRow.SetZipCodeNull();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgA_ZipCodeResolver1.ZipCodeExtension, string.Empty, false) != 0)
      filingProducersRow.ZipPlus = this.MgA_ZipCodeResolver1.ZipCodeExtension;
    else
      filingProducersRow.SetZipPlusNull();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgA_ZipCodeResolver1.GeoRegion, string.Empty, false) != 0)
      filingProducersRow._Region = this.MgA_ZipCodeResolver1.GeoRegion;
    else
      filingProducersRow.Set_RegionNull();
  }

  private void SetDatasetFields()
  {
    dsFilingProducers.tblQuoteFilingProducersRow quoteFilingProducer = this.ds.tblQuoteFilingProducers[this.bmb.Position];
    quoteFilingProducer.InHouse = this.rbInHouse.Checked;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboLicenses.Text, string.Empty, false) != 0)
    {
      quoteFilingProducer.LicenseNumber = this.cboLicenses.Text;
      if (((UltraDropDownBase) this.cboLicenses).SelectedRow == null)
      {
        dsFilingProducers.spGetProducerLicenseRow[] producerLicenseRowArray = (dsFilingProducers.spGetProducerLicenseRow[]) this.ds.spGetProducerLicense.Select($"LicenseNumber = '{this.cboLicenses.Text}'");
        if (producerLicenseRowArray.Length == 1)
        {
          this.cboLicenses.Value = (object) producerLicenseRowArray[0].ProducerLicenseGUID;
          this.dtpLicenseAdded.Value = (object) DateAndTime.Now.Date;
        }
      }
      if (this.rbOutsideProducer.Checked && ((UltraDropDownBase) this.cboLicenses).SelectedRow != null && ((UltraDropDownBase) this.cboFilingProducers).SelectedRow != null && !this.cboFilingProducers.Value.Equals((object) Guid.Empty))
        quoteFilingProducer.ProducerLicenseGUID = (Guid) this.cboLicenses.Value;
      else
        quoteFilingProducer.SetProducerLicenseGUIDNull();
    }
    else
      quoteFilingProducer.SetLicenseNumberNull();
    if (this.rbOutsideProducer.Checked && ((UltraDropDownBase) this.cboFilingProducers).SelectedRow != null)
      quoteFilingProducer.FilingProducerLocationGUID = (Guid) this.cboFilingProducers.Value;
    else
      quoteFilingProducer.SetFilingProducerLocationGUIDNull();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboFilingProducers.Text, string.Empty, false) != 0)
      quoteFilingProducer.FilingProducer = this.cboFilingProducers.Text;
    else
      quoteFilingProducer.SetFilingProducerNull();
    if (this._useUserLicenseAsContacts.Value && this.rbInHouse.Checked)
    {
      quoteFilingProducer.SetProducerContactNull();
      quoteFilingProducer.SetProducerContactGUIDNull();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboContacts.Text, string.Empty, false) != 0)
      {
        quoteFilingProducer.UserContact = this.cboContacts.Text;
        if (this.cboContacts.Value is Guid)
        {
          dsFilingProducers.tblQuoteFilingProducersRow filingProducersRow = quoteFilingProducer;
          object obj = this.cboContacts.Value;
          Guid guid = obj != null ? (Guid) obj : new Guid();
          filingProducersRow.UserContactGuid = guid;
        }
      }
      else
        quoteFilingProducer.SetUserContactNull();
      if (((UltraDropDownBase) this.cboContacts).SelectedRow != null)
        quoteFilingProducer.UserContactGuid = (Guid) this.cboContacts.Value;
      else
        quoteFilingProducer.SetUserContactGuidNull();
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboContacts.Text, string.Empty, false) != 0)
        quoteFilingProducer.ProducerContact = this.cboContacts.Text;
      else
        quoteFilingProducer.SetProducerContactNull();
      if (((UltraDropDownBase) this.cboContacts).SelectedRow != null)
        quoteFilingProducer.ProducerContactGUID = (Guid) this.cboContacts.Value;
      else
        quoteFilingProducer.SetProducerContactGUIDNull();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtSLA).Text, string.Empty, false) == 0)
      quoteFilingProducer.SetSLA_NumberNull();
    else
      quoteFilingProducer.SLA_Number = ((TextEditorControlBase) this.txtSLA).Text;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtFEIN).Text, string.Empty, false) == 0)
      quoteFilingProducer.SetFEINNull();
    else
      quoteFilingProducer.FEIN = ((TextEditorControlBase) this.txtFEIN).Text;
    if (this.mgaDTPDateReceived.Value != null)
    {
      if (!this.ds.tblQuoteFilingProducers[this.bmb.Position]["DateRecd"].Equals((object) (DateTime) this.mgaDTPDateReceived.Value))
        this._ismgaDTPDateReceivedChanged = true;
      quoteFilingProducer.DateRecd = (DateTime) this.mgaDTPDateReceived.Value;
    }
    else
      quoteFilingProducer.SetDateRecdNull();
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpLicenseExpDate.Value)))
      quoteFilingProducer.LicenseExpDate = (DateTime) this.dtpLicenseExpDate.Value;
    else
      quoteFilingProducer.SetLicenseExpDateNull();
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpLicenseAdded.Value)))
      quoteFilingProducer.LicenseNumberDateAdded = (DateTime) this.dtpLicenseAdded.Value;
    else
      quoteFilingProducer.SetLicenseNumberDateAddedNull();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtReasonForPlacement).Text, string.Empty, false) == 0)
      quoteFilingProducer.SetReasonForPlacementNull();
    else
      quoteFilingProducer.ReasonForPlacement = ((TextEditorControlBase) this.txtReasonForPlacement).Text;
    this.SetAddressInfo(this.ds.tblQuoteFilingProducers[this.bmb.Position]);
  }

  protected virtual bool ValidateOutsideProducer()
  {
    bool flag = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboFilingProducers.Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.cboFilingProducers, "Required Field");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboFilingProducers, string.Empty);
    return flag;
  }

  private void DoSave()
  {
    if (!this.rbInHouse.Checked && !this.ValidateOutsideProducer())
      return;
    this.SetDatasetFields();
    this.SaveData();
    this.FillProducerList();
  }

  private void lnkPreviousState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.DoSave();
      if (this.bmb.Position == 0)
      {
        this.bmb.Position = this.ds.tblQuoteFilingProducers.Count - 1;
      }
      else
      {
        BindingManagerBase bmb;
        int num = (bmb = this.bmb).Position - 1;
        bmb.Position = num;
      }
      this.ShowStateLabel();
      this.UpdateFilingProducerInfo();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkNextState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.DoSave();
      if (this.bmb.Position == this.ds.tblQuoteFilingProducers.Count - 1)
      {
        this.bmb.Position = 0;
      }
      else
      {
        BindingManagerBase bmb;
        int num = (bmb = this.bmb).Position + 1;
        bmb.Position = num;
      }
      this.ShowStateLabel();
      this.UpdateFilingProducerInfo();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void SetDefaultProducerType(dsFilingProducers.tblQuoteFilingProducersRow row)
  {
  }

  protected virtual void GetUnaskedStateDefaultProducerType()
  {
    if (this.DefaultToOutsideProducer)
      this.rbOutsideProducer.Checked = true;
    else
      this.rbInHouse.Checked = true;
  }

  public void GetUnaskedState()
  {
    bool flag = false;
    try
    {
      foreach (dsFilingProducers.GetFilingStatesRow getFilingState in (TypedTableBase<dsFilingProducers.GetFilingStatesRow>) this.ds.GetFilingStates)
      {
        if (this.ds.tblQuoteFilingProducers.FindByQuoteIDStateID(this._quoteID, getFilingState.StateID) == null)
        {
          dsFilingProducers.tblQuoteFilingProducersRow row = this.ds.tblQuoteFilingProducers.NewtblQuoteFilingProducersRow();
          row.QuoteID = this._quoteID;
          row.StateID = getFilingState.StateID;
          this.SetDefaultProducerType(row);
          this.ds.tblQuoteFilingProducers.AddtblQuoteFilingProducersRow(row);
          this.bmb.Position = this.ds.tblQuoteFilingProducers.Count - 1;
          flag = true;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<dsFilingProducers.GetFilingStatesRow> enumerator;
      enumerator?.Dispose();
    }
    if (this.bmb.Position < 0)
      return;
    if (flag)
    {
      this.GetUnaskedStateDefaultProducerType();
      this.SetupDataBinding(this.rbInHouse.Checked);
    }
    this.ShowStateLabel();
  }

  protected virtual bool IsValidForm() => true;

  protected virtual void btnContinue_Click(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      this.Close();
    }
    else
    {
      if (!this.IsValidForm())
        return;
      this.LogIssue("frmFilingProducers Continue 1");
      this.ds.tblQuoteFilingProducers[this.bmb.Position].InHouse = !this.rbOutsideProducer.Checked;
      this.DoSave();
      this.LogIssue("frmFilingProducers Continue 2");
      if (this._ismgaDTPDateReceivedChanged)
      {
        Messaging.SendBroadcastMessage(BroadcastMessages.ProducerFilingInfoCompleted, (object) this._quote.QuoteGuid);
        CurrentUser.Instance.LogAction($"Ctrl#{this._quote.ControlNo.ToString()} Producer Filing Info Completed", this._quote.QuoteGuid);
      }
      this.LogIssue("frmFilingProducers Continue 3");
      if (!this.HasUnaskedStates)
        this.Close();
      else
        this.GetUnaskedState();
      this.LogIssue("frmFilingProducers Continue 4 - End");
    }
  }

  private void lnkNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.cboFilingProducers.Value = (object) null;
  }

  private void ChangeFilingSource(object sender, EventArgs e)
  {
    if (this.rbOutsideProducer.Checked)
    {
      this.SetupDataBinding(false);
    }
    else
    {
      if (this._assigningData | this._ClientAssigningData)
        return;
      this.SetupDataBinding(true);
      if (this._useUserLicenseAsContacts.Value)
        return;
      this.ClearDatasetFields();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
      this.components?.Dispose();
    base.Dispose(disposing);
  }

  private void cboFilingProducers_ValueChanged(object sender, EventArgs e)
  {
    if (this.rbInHouse.Checked)
    {
      this.cboLicenses.Value = (object) null;
      this.dtpLicenseAdded.Value = (object) null;
      this.FilterDataByState();
    }
    else
    {
      this.cboContacts.Value = (object) Guid.Empty;
      if (this.cboFilingProducers.Value == DBNull.Value || !(this.cboFilingProducers.Value is Guid))
        return;
      this._producerLocationGuid = (Guid) this.cboFilingProducers.Value;
      this.GetProducerLicenses(this._producerLocationGuid);
      if (this._arrProducerLocList.Contains(this.cboFilingProducers.Text))
      {
        DataRow[] dataRowArray = this.ds.tblQuoteFilingProducers.Select($"FilingProducer = '{this.cboFilingProducers.Text}'");
        if (dataRowArray.Length <= 0)
          return;
        this.GetProducerAddressComplete(dataRowArray[0]);
      }
      else
      {
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetProducerAddressThread));
        this.Cursor = MgaCursors.Working;
      }
    }
  }

  private void GetProducerLicenses(Guid producerLocationGuid)
  {
    this.ds.spGetProducerLicense.Clear();
    this.GetProducerlicense(producerLocationGuid);
    bool foundDefault = false;
    try
    {
      foreach (dsFilingProducers.spGetProducerLicenseRow producerLicenseRow in (TypedTableBase<dsFilingProducers.spGetProducerLicenseRow>) this.ds.spGetProducerLicense)
      {
        if (producerLicenseRow.DefaultLicense)
        {
          if (this._isNewRecord || this.bmb.Position != -1 && this.ds.tblQuoteFilingProducers[this.bmb.Position].RowState == DataRowState.Added)
            this.cboLicenses.Value = (object) producerLicenseRow.ProducerLicenseGUID;
          if (this.ds.tblQuoteFilingProducers.Count == 0 || this.bmb.Position != -1 && this.ds.tblQuoteFilingProducers[this.bmb.Position].RowState == DataRowState.Added)
            this.dtpLicenseAdded.Value = (object) DateAndTime.Now.Date;
          foundDefault = true;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<dsFilingProducers.spGetProducerLicenseRow> enumerator;
      enumerator?.Dispose();
    }
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("FilingProducer.FindFirstForProducer"))
      foundDefault = this.FindFirstDefaultForProducer(producerLocationGuid, foundDefault);
    if (this.DefaultClientLicense(foundDefault, producerLocationGuid))
      return;
    this.cboLicenses.Text = string.Empty;
    this.dtpLicenseAdded.Value = (object) null;
  }

  protected virtual void GetProducerlicense(Guid producerLocationGuid)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "spGetProducerLicense"
    }, "dbo.spGetProducerLicense", new object[2]
    {
      (object) "@producerLocationGuid",
      (object) producerLocationGuid
    });
  }

  private bool FindFirstDefaultForProducer(Guid proderLocationGuid, bool foundDefault)
  {
    bool defaultForProducer;
    if (foundDefault)
    {
      defaultForProducer = foundDefault;
    }
    else
    {
      DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.StoredProcedure, "spFilingProducerLicenseGetDefault", new object[4]
      {
        (object) "@ProducerLocationGuid",
        (object) proderLocationGuid,
        (object) "@CurrentStateID",
        (object) this._currentStateID
      });
      Guid? nullable = row.Field<Guid?>("ProducerLicenseGUID");
      if (nullable.HasValue)
      {
        DateTime Expires = row.Field<DateTime>("Expires");
        DateTime minValue = DateTime.MinValue;
        this.ds.spGetProducerLicense.AddspGetProducerLicenseRow(nullable.Value, row.Field<string>("LicenseType"), row.Field<string>("LicenseNumber"), Expires, row.Field<string>("License"), row.Field<string>("StateID"), row.Field<bool>("DefaultLicense"), minValue);
        this.cboLicenses.Value = (object) nullable;
        this.dtpLicenseExpDate.Value = (object) Expires;
        this.dtpLicenseAdded.Value = (object) minValue;
        this.ds.tblQuoteFilingProducers[this.bmb.Position].ProducerLicenseGUID = nullable.Value;
        string str1 = row.Field<string>("LicenseAddress1");
        string str2 = row.Field<string>("LicenseAddress2");
        string str3 = row.Field<string>("LicenseState");
        string str4 = row.Field<string>("LicenseZipCode");
        string str5 = row.Field<string>("LicenseCounty");
        string str6 = row.Field<string>("LicenseZipCodeExt");
        string str7 = row.Field<string>("LicenseCity");
        this.ds.tblQuoteFilingProducers[this.bmb.Position].Address1 = str1;
        this.ds.tblQuoteFilingProducers[this.bmb.Position].Address2 = str2;
        this.ds.tblQuoteFilingProducers[this.bmb.Position].City = str7;
        this.ds.tblQuoteFilingProducers[this.bmb.Position].State = str3;
        this.ds.tblQuoteFilingProducers[this.bmb.Position].ZipCode = str4;
        this.ds.tblQuoteFilingProducers[this.bmb.Position].County = str5;
        this.ds.tblQuoteFilingProducers[this.bmb.Position].ZipPlus = str6;
        this.cboFilingProducers.Value = (object) row.Field<Guid>("ProducerLocationGUID");
        defaultForProducer = true;
      }
      else
        defaultForProducer = false;
    }
    return defaultForProducer;
  }

  protected virtual bool DefaultClientLicense(bool foundDefault, Guid producerLocationGuid)
  {
    return foundDefault;
  }

  private void GetProducerAddressThread(object state)
  {
    Thread.Sleep(100);
    MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmFilingProducers.GetProducerAddressCompleteHandler(this.GetProducerAddressComplete), (object) DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Address1, Address2, City, County, State, Region, ISOCountryCode, ZipCode, ZipPlus FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGuid=@ProducerLocationGuid", new object[2]
    {
      (object) "@ProducerLocationGuid",
      (object) this._producerLocationGuid
    }));
  }

  private void GetProducerAddressComplete(DataRow dr)
  {
    if (dr != null)
    {
      MGA_ZipCodeResolver zipCodeResolver1 = this.MgA_ZipCodeResolver1;
      zipCodeResolver1.Street1 = dr["Address1"] == DBNull.Value ? string.Empty : (string) dr["Address1"];
      zipCodeResolver1.Street2 = dr["Address2"] == DBNull.Value ? string.Empty : (string) dr["Address2"];
      zipCodeResolver1.City = dr["City"] == DBNull.Value ? string.Empty : (string) dr["City"];
      zipCodeResolver1.State = dr["State"] == DBNull.Value ? string.Empty : (string) dr["State"];
      try
      {
        zipCodeResolver1.ZipCode = dr["ZipCode"] == DBNull.Value ? string.Empty : (string) dr["ZipCode"];
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      zipCodeResolver1.ZipCodeExtension = dr["ZipPlus"] == DBNull.Value ? string.Empty : (string) dr["ZipPlus"];
    }
    this.Cursor = MgaCursors.Default;
  }

  private void EmptyFilingProducerData()
  {
    dsFilingProducers.tblQuoteFilingProducersRow quoteFilingProducer = this.ds.tblQuoteFilingProducers[this.bmb.Position];
    quoteFilingProducer.SetFilingProducerNull();
    quoteFilingProducer.SetAddress1Null();
    quoteFilingProducer.SetAddress2Null();
    quoteFilingProducer.SetCityNull();
    quoteFilingProducer.SetCountyNull();
    quoteFilingProducer.SetStateNull();
    quoteFilingProducer.SetZipCodeNull();
    quoteFilingProducer.SetZipPlusNull();
    quoteFilingProducer.Set_RegionNull();
    this.MgA_ZipCodeResolver1.Street1 = string.Empty;
    this.MgA_ZipCodeResolver1.Street2 = string.Empty;
    this.MgA_ZipCodeResolver1.City = string.Empty;
    this.MgA_ZipCodeResolver1.State = string.Empty;
    this.MgA_ZipCodeResolver1.County = string.Empty;
    this.MgA_ZipCodeResolver1.ZipCode = string.Empty;
    this.MgA_ZipCodeResolver1.ZipCodeExtension = string.Empty;
    quoteFilingProducer.SetFilingProducerNull();
    quoteFilingProducer.SetFilingProducerLocationGUIDNull();
    quoteFilingProducer.SetISOCountryCodeNull();
    quoteFilingProducer.SetLicenseNumberNull();
    quoteFilingProducer.SetSLA_NumberNull();
    quoteFilingProducer.SetFEINNull();
    quoteFilingProducer.SetDateRecdNull();
    quoteFilingProducer.SetLicenseExpDateNull();
    this.mgaDTPDateReceived.Value = (object) null;
    this.cboFilingProducers.Text = string.Empty;
    this.cboLicenses.Text = string.Empty;
    ((TextEditorControlBase) this.txtSLA).Text = string.Empty;
    ((TextEditorControlBase) this.txtFEIN).Text = string.Empty;
    this.dtpLicenseExpDate.Value = (object) null;
    this.dtpLicenseAdded.Value = (object) null;
  }

  private void rbInHouse_CheckedChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position < 0)
      return;
    if (this.rbInHouse.Checked)
    {
      this.ClientInHouseFilingProducerData();
    }
    else
    {
      this._UseClientContact = false;
      this.FillProducerInfo();
    }
  }

  protected virtual void ClientInHouseFilingProducerData() => this.EmptyFilingProducerData();

  protected virtual void ShowSLLicenses()
  {
  }

  protected virtual void OutsideProducerLicenses()
  {
  }

  private void cboLicenses_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (this.rbInHouse.Checked)
    {
      MGAComboBox cboLicenses = this.cboLicenses;
      ((UltraDropDownBase) cboLicenses).DropDownWidth = 550;
      cboLicenses.DisplayLayout.Bands[0].Columns["StateID"].Width = 60;
      cboLicenses.DisplayLayout.Bands[0].Columns["LicenseNumber"].Width = 120;
      cboLicenses.DisplayLayout.Bands[0].Columns["LicenseType"].Width = 370;
      this.ShowSLLicenses();
    }
    else
    {
      ((UltraDropDownBase) this.cboLicenses).DropDownWidth = 400;
      this.OutsideProducerLicenses();
    }
  }

  private void lnkStateFilingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmb.Position < 0)
      return;
    FormSettings.ShowFormDialog(typeof (frmGenericInfo), (object) "State-Specific Filing Information:", (object) Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Description FROM tblStateSLRules WITH (NOLOCK) WHERE StateID = @ID", new object[2]
    {
      (object) "@ID",
      (object) this.ds.tblQuoteFilingProducers[this.bmb.Position].StateID
    }), string.Empty)).Dispose();
  }

  protected virtual void cboLicenses_KeyPress(object sender, KeyPressEventArgs e)
  {
  }

  private void cboLicenses_ValueChanged(object sender, EventArgs e)
  {
    if (this._useProducerLicenseAddress.Value && !Utility.IsNull((object) ((UltraDropDownBase) this.cboLicenses).SelectedRow))
      this.ClearAddressData();
    if (((UltraDropDownBase) this.cboLicenses).SelectedRow != null && this.cboLicenses.Value != DBNull.Value)
    {
      Guid ProducerLicenseGUID = (Guid) this.cboLicenses.Value;
      dsFilingProducers.spGetProducerLicenseRow producerLicenseGuid = this.ds.spGetProducerLicense.FindByProducerLicenseGUID(ProducerLicenseGUID);
      if (producerLicenseGuid != null)
      {
        this.dtpLicenseExpDate.Value = (object) producerLicenseGuid.Expires;
        if (producerLicenseGuid.IsLicenseNumberDateAddedNull())
          this.dtpLicenseAdded.Value = (object) null;
        else
          this.dtpLicenseAdded.Value = (object) producerLicenseGuid.LicenseNumberDateAdded;
      }
      if (this._useProducerLicenseAddress.Value)
      {
        this.ClearAddressData();
        DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "select top 1 LicenseAddress1, LicenseAddress2,  LicenseCity, LicenseStateID, LicenseZipCode,LicenseZipCodeExt from tblProducerLicenses with (nolock)  where ProducerLicenseGUID = @PLG", new object[2]
        {
          (object) "@PLG",
          (object) ProducerLicenseGUID
        });
        if (dataRow != null)
        {
          MGA_ZipCodeResolver zipCodeResolver1 = this.MgA_ZipCodeResolver1;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["LicenseAddress1"])))
            zipCodeResolver1.Street1 = (string) dataRow["LicenseAddress1"];
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["LicenseAddress2"])))
            zipCodeResolver1.Street2 = (string) dataRow["LicenseAddress2"];
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["LicenseCity"])))
            zipCodeResolver1.City = (string) dataRow["LicenseCity"];
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["LicenseStateID"])))
            zipCodeResolver1.State = (string) dataRow["LicenseStateID"];
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["LicenseZipCode"])))
            zipCodeResolver1.ZipCode = (string) dataRow["LicenseZipCode"];
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["LicenseZipCodeExt"])))
            zipCodeResolver1.ZipCodeExtension = (string) dataRow["LicenseZipCodeExt"];
        }
      }
      this.OnLicenseChanged();
    }
    else
      this.OnLicenseTextChanged();
  }

  protected virtual void OnLicenseChanged()
  {
  }

  protected virtual void OnLicenseTextChanged()
  {
  }

  private void cboContacts_ValueChanged(object sender, EventArgs e)
  {
    if (!this._useUserLicenseAsContacts.Value || !(this.cboContacts.Value is Guid))
      return;
    DataRow[] dataRowArray = this.ds.InhouseUsers.Select($"UserGuid = '{((Guid) this.cboContacts.Value).ToString()}'");
    if (dataRowArray.Length <= 0)
      return;
    dsFilingProducers.InhouseUsersRow inhouseUsersRow = (dsFilingProducers.InhouseUsersRow) dataRowArray[0];
    this.MgA_ZipCodeResolver1.Street1 = inhouseUsersRow.Address1;
    if (!inhouseUsersRow.IsAddress2Null())
      this.MgA_ZipCodeResolver1.Street2 = inhouseUsersRow.Address2;
    this.MgA_ZipCodeResolver1.City = inhouseUsersRow.City;
    this.MgA_ZipCodeResolver1.State = inhouseUsersRow.State;
    this.MgA_ZipCodeResolver1.ZipCode = inhouseUsersRow.ZipCode;
  }

  protected virtual void OnFillData()
  {
  }

  private void cboContacts_BeforeDropDown(object sender, CancelEventArgs e) => this.LoadContacts();

  private void LoadContacts()
  {
    if (this._UseClientContact || this._useUserLicenseAsContacts.Value || this._showAllContacts)
      return;
    Guid empty = Guid.Empty;
    if (this.cboFilingProducers.Value != null && this.cboFilingProducers.Value != DBNull.Value && this.cboFilingProducers.Value is Guid)
      empty = (Guid) this.cboFilingProducers.Value;
    this.ds.tblProducerContacts.Clear();
    this.ds.tblProducerContacts.AddtblProducerContactsRow(Guid.Empty, Guid.Empty, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblProducerContacts"
    }, "GetProducerLocationsContacts", new object[4]
    {
      (object) "@QuoteID",
      (object) this._quoteID,
      (object) "@ProducerLocationGUID",
      (object) empty
    });
  }

  private void CboLicenses_AfterCloseUp(object sender, EventArgs e)
  {
    if (this.cboLicenses.Value == null)
      return;
    this.dtpLicenseAdded.Value = (object) DateAndTime.Now.Date;
  }

  private void CboLicenses_Leave(object sender, EventArgs e)
  {
    if (!(!string.IsNullOrEmpty(this.cboLicenses.Text) & this.dtpLicenseAdded.Value == null))
      return;
    this.dtpLicenseAdded.Value = (object) DateAndTime.Now.Date;
  }

  private void SetDefault()
  {
    try
    {
      foreach (dsFilingProducers.tblQuoteFilingProducersRow row in this.ds.tblQuoteFilingProducers.Rows)
      {
        if (row.RowState == DataRowState.Added || this._isNewRecord)
        {
          if (this._isOutsideFiling)
          {
            row.InHouse = false;
            this.rbOutsideProducer.Checked = true;
          }
          if (this._isInhouseFiling)
          {
            row.InHouse = true;
            this.rbInHouse.Checked = true;
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
  }

  public void SaveDefaultFilingProducers()
  {
    int num = -1;
    this.GetUnaskedState();
    for (; this.HasUnaskedStates || this.bmb.Position != num && this.ds.tblQuoteFilingProducers[this.bmb.Position].RowState == DataRowState.Added; num = this.bmb.Position)
    {
      this.btnContinue_Click((object) this.btnContinue, EventArgs.Empty);
      if (this.bmb.Position == num)
        break;
    }
  }

  private void LoadInhouseUsers(object stateID)
  {
    List<object> objectList = new List<object>()
    {
      (object) "@StateID",
      RuntimeHelpers.GetObjectValue(stateID)
    };
    if (this._hasQuoteIDParameter)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@QuoteID",
        (object) this._quoteID
      });
    DefaultDatabase.LoadDataTable((DataTable) this.ds.InhouseUsers, this._inHouseUsersProc.Value, objectList.ToArray());
  }

  private void ClearAddressData()
  {
    this.MgA_ZipCodeResolver1.Street1 = string.Empty;
    this.MgA_ZipCodeResolver1.Street2 = string.Empty;
    this.MgA_ZipCodeResolver1.City = string.Empty;
    this.MgA_ZipCodeResolver1.State = string.Empty;
    this.MgA_ZipCodeResolver1.County = string.Empty;
    this.MgA_ZipCodeResolver1.ZipCode = string.Empty;
  }

  private void frmFilingProducers_Closed(object sender, EventArgs e)
  {
    this.LogIssue("frmFilingProducers Closed");
  }

  private void LogIssue(string logMessage)
  {
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("RaterSaveLogging"))
      return;
    CurrentUser.Instance.LogAction(logMessage, "TFS 87152");
  }

  private struct UserAddressRecord
  {
    public string street;
    public string street2;
    public string city;
    public string state;
    public string zipCode;
    public string county;

    public UserAddressRecord(
      string city,
      string street,
      string street2,
      string state,
      string zipCode,
      string county)
      : this()
    {
      this.city = city;
      this.county = county;
      this.zipCode = zipCode;
      this.state = state;
      this.street = street;
      this.street2 = street2;
    }
  }

  private delegate void GetProducerAddressCompleteHandler(DataRow dr);
}
