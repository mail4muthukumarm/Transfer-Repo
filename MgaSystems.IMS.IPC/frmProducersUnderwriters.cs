// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmProducersUnderwriters
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[SecureResource("{ed79bbf4-0246-4d3a-9128-398f9884c27d}", "View underwriter producer location assignment Screen", "Controls the ability to assign producer underwriter to locations.", "Producers")]
public class frmProducersUnderwriters : Form
{
  public const string CanViewForm = "{ed79bbf4-0246-4d3a-9128-398f9884c27d}";
  private IContainer components;
  private Guid _producerLocationGUID;
  private bool _AllowBothProducerAndLocationFilled;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("cnSQL")]
  internal virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddProducers")]
  internal virtual UltraDropDown ddProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddProducerLocations")]
  internal virtual UltraDropDown ddProducerLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid ugUnderwriterProducer
  {
    get => this._ugUnderwriterProducer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugUnderwriterProducer_AfterRowActivate);
      UltraGrid underwriterProducer1 = this._ugUnderwriterProducer;
      if (underwriterProducer1 != null)
        underwriterProducer1.AfterRowActivate -= eventHandler;
      this._ugUnderwriterProducer = value;
      UltraGrid underwriterProducer2 = this._ugUnderwriterProducer;
      if (underwriterProducer2 == null)
        return;
      underwriterProducer2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ddUnderwriter")]
  internal virtual UltraDropDown ddUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daProducerUnderwriter")]
  internal virtual SqlDataAdapter daProducerUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand2")]
  internal virtual SqlCommand SqlInsertCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand2")]
  internal virtual SqlCommand SqlUpdateCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkBulkAssignment
  {
    get => this._lnkBulkAssignment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkBulkAssignment_LinkClicked);
      LinkLabel lnkBulkAssignment1 = this._lnkBulkAssignment;
      if (lnkBulkAssignment1 != null)
        lnkBulkAssignment1.LinkClicked -= clickedEventHandler;
      this._lnkBulkAssignment = value;
      LinkLabel lnkBulkAssignment2 = this._lnkBulkAssignment;
      if (lnkBulkAssignment2 == null)
        return;
      lnkBulkAssignment2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsPU ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLines")]
  internal virtual UltraDropDown ddLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddStates")]
  internal virtual UltraDropDown ddStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddProducerContact")]
  internal virtual UltraDropDown ddProducerContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboUnderwriters")]
  protected virtual MGASimpleComboBox cboUnderwriters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducers")]
  protected virtual MGASimpleComboBox cboProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducerLocations")]
  protected virtual MGASimpleComboBox cboProducerLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboProducerContact
  {
    get => this._cboProducerContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboProducerContact_BeforeDropDown);
      MGASimpleComboBox cboProducerContact1 = this._cboProducerContact;
      if (cboProducerContact1 != null)
        cboProducerContact1.BeforeDropDown -= cancelEventHandler;
      this._cboProducerContact = value;
      MGASimpleComboBox cboProducerContact2 = this._cboProducerContact;
      if (cboProducerContact2 == null)
        return;
      cboProducerContact2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLines")]
  protected virtual MGASimpleComboBox cboLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboStates")]
  protected virtual MGASimpleComboBox cboStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboCounty
  {
    get => this._cboCounty;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboCounty_BeforeDropDown);
      MGASimpleComboBox cboCounty1 = this._cboCounty;
      if (cboCounty1 != null)
        cboCounty1.BeforeDropDown -= cancelEventHandler;
      this._cboCounty = value;
      MGASimpleComboBox cboCounty2 = this._cboCounty;
      if (cboCounty2 == null)
        return;
      cboCounty2.BeforeDropDown += cancelEventHandler;
    }
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("gbDetails")]
  private virtual UltraGroupBox gbDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkViewCurrentProducerLocation
  {
    get => this._lnkViewCurrentProducerLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkViewCurrentProducerLocation_LinkClicked);
      LinkLabel producerLocation1 = this._lnkViewCurrentProducerLocation;
      if (producerLocation1 != null)
        producerLocation1.LinkClicked -= clickedEventHandler;
      this._lnkViewCurrentProducerLocation = value;
      LinkLabel producerLocation2 = this._lnkViewCurrentProducerLocation;
      if (producerLocation2 == null)
        return;
      producerLocation2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual Label lblLimitedResults
  {
    get => this._lblLimitedResults;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LblLimitedResults_Click);
      Label lblLimitedResults1 = this._lblLimitedResults;
      if (lblLimitedResults1 != null)
        lblLimitedResults1.Click -= eventHandler;
      this._lblLimitedResults = value;
      Label lblLimitedResults2 = this._lblLimitedResults;
      if (lblLimitedResults2 == null)
        return;
      lblLimitedResults2.Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkAdvanceProducerSearch
  {
    get => this._lnkAdvanceProducerSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkAdvanceProducerSearch_LinkClicked);
      LinkLabel advanceProducerSearch1 = this._lnkAdvanceProducerSearch;
      if (advanceProducerSearch1 != null)
        advanceProducerSearch1.LinkClicked -= clickedEventHandler;
      this._lnkAdvanceProducerSearch = value;
      LinkLabel advanceProducerSearch2 = this._lnkAdvanceProducerSearch;
      if (advanceProducerSearch2 == null)
        return;
      advanceProducerSearch2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual UltraPopupControlContainer SearchPopupControlContainer
  {
    get => this._SearchPopupControlContainer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SearchPopupControlContainer_Opened);
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.SearchPopupControlContainer_Opening);
      UltraPopupControlContainer controlContainer1 = this._SearchPopupControlContainer;
      if (controlContainer1 != null)
      {
        controlContainer1.Opened -= eventHandler;
        controlContainer1.Opening -= cancelEventHandler;
      }
      this._SearchPopupControlContainer = value;
      UltraPopupControlContainer controlContainer2 = this._SearchPopupControlContainer;
      if (controlContainer2 == null)
        return;
      controlContainer2.Opened += eventHandler;
      controlContainer2.Opening += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboTACSR")]
  protected virtual MGASimpleComboBox cboTACSR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand2")]
  internal virtual SqlCommand SqlDeleteCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmProducersUnderwriters));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblProducerContacts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerContactGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ContactName");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("State");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LineName");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Name_LastFirst");
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Name");
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblProducers", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ProducerName");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("tblProducerUnderwriters", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("UnderwriterGUID", -1, (object) "ddUnderwriter");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ProducerGUID", -1, (object) "ddProducers");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ProducerLocationGUID", -1, (object) "ddProducerLocations");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ProducerContactGUID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("TACSRUserGuid");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.cnSQL = new SqlConnection();
    this.daProducerUnderwriter = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.lnkBulkAssignment = new LinkLabel();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.gbDetails = new UltraGroupBox();
    this.Label8 = new Label();
    this.cboTACSR = new MGASimpleComboBox();
    this.ds = new dsPU();
    this.cboLines = new MGASimpleComboBox();
    this.cboProducerContact = new MGASimpleComboBox();
    this.cboStates = new MGASimpleComboBox();
    this.cboCounty = new MGASimpleComboBox();
    this.cboProducerLocations = new MGASimpleComboBox();
    this.cboUnderwriters = new MGASimpleComboBox();
    this.cboProducers = new MGASimpleComboBox();
    this.err = new ErrorProvider(this.components);
    this.lnkViewCurrentProducerLocation = new LinkLabel();
    this.lblLimitedResults = new Label();
    this.lnkAdvanceProducerSearch = new LinkLabel();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.SearchPopupControlContainer = new UltraPopupControlContainer(this.components);
    this.ddProducerContact = new UltraDropDown();
    this.ddStates = new UltraDropDown();
    this.ddLines = new UltraDropDown();
    this.ddUnderwriter = new UltraDropDown();
    this.ddProducerLocations = new UltraDropDown();
    this.ddProducers = new UltraDropDown();
    this.ugUnderwriterProducer = new UltraGrid();
    ((ISupportInitialize) this.gbDetails).BeginInit();
    ((Control) this.gbDetails).SuspendLayout();
    ((ISupportInitialize) this.cboTACSR).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboLines).BeginInit();
    ((ISupportInitialize) this.cboProducerContact).BeginInit();
    ((ISupportInitialize) this.cboStates).BeginInit();
    ((ISupportInitialize) this.cboCounty).BeginInit();
    ((ISupportInitialize) this.cboProducerLocations).BeginInit();
    ((ISupportInitialize) this.cboUnderwriters).BeginInit();
    ((ISupportInitialize) this.cboProducers).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddProducerContact).BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    ((ISupportInitialize) this.ddUnderwriter).BeginInit();
    ((ISupportInitialize) this.ddProducerLocations).BeginInit();
    ((ISupportInitialize) this.ddProducers).BeginInit();
    ((ISupportInitialize) this.ugUnderwriterProducer).BeginInit();
    this.SuspendLayout();
    this.cnSQL.ConnectionString = "Data Source=mgasystems;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daProducerUnderwriter.DeleteCommand = this.SqlDeleteCommand2;
    this.daProducerUnderwriter.InsertCommand = this.SqlInsertCommand2;
    this.daProducerUnderwriter.SelectCommand = this.SqlSelectCommand2;
    this.daProducerUnderwriter.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerUnderwriters", new DataColumnMapping[8]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("ProducerGUID", "ProducerGUID"),
        new DataColumnMapping("UnderwriterGUID", "UnderwriterGUID"),
        new DataColumnMapping("ProducerLocationGUID", "ProducerLocationGUID"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("ProducerContactGUID", "ProducerContactGUID")
      })
    });
    this.daProducerUnderwriter.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblProducerUnderwriters] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand2.Connection = this.cnSQL;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 0, "ProducerGUID"),
      new SqlParameter("@UnderwriterGUID", SqlDbType.UniqueIdentifier, 0, "UnderwriterGUID"),
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGUID"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 0, "ProducerContactGUID"),
      new SqlParameter("@TACSRUserGuid", SqlDbType.UniqueIdentifier, 0, "TACSRUserGuid")
    });
    this.SqlSelectCommand2.CommandText = "SELECT        ID, ProducerGUID, UnderwriterGUID, ProducerLocationGUID, LineGuid, StateID, County, ProducerContactGUID, TACSRUserGuid \r\nFROM            dbo.tblProducerUnderwriters";
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[10]
    {
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 0, "ProducerGUID"),
      new SqlParameter("@UnderwriterGUID", SqlDbType.UniqueIdentifier, 0, "UnderwriterGUID"),
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGUID"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 0, "ProducerContactGUID"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID"),
      new SqlParameter("@TACSRUserGuid", SqlDbType.UniqueIdentifier, 0, "TACSRUserGuid")
    });
    this.lnkBulkAssignment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkBulkAssignment.AutoSize = true;
    this.lnkBulkAssignment.Location = new Point(12, 577);
    this.lnkBulkAssignment.Name = "lnkBulkAssignment";
    this.lnkBulkAssignment.Size = new Size(329, 13);
    this.lnkBulkAssignment.TabIndex = 3;
    this.lnkBulkAssignment.TabStop = true;
    this.lnkBulkAssignment.Text = "Bulk Assignment - Assign Underwriter to multiple Producer/Locations";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(19, 23);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 13);
    this.Label1.TabIndex = 33;
    this.Label1.Text = "Underwriter:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(19, 69);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(53, 13);
    this.Label2.TabIndex = 35;
    this.Label2.Text = "Producer:";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(19, 115);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(97, 13);
    this.Label3.TabIndex = 37;
    this.Label3.Text = "Producer Location:";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(18, 161);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(93, 13);
    this.Label4.TabIndex = 39;
    this.Label4.Text = "Producer Contact:";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(423, 23);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(30, 13);
    this.Label5.TabIndex = 41;
    this.Label5.Text = "Line:";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(423, 69);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(35, 13);
    this.Label6.TabIndex = 43;
    this.Label6.Text = "State:";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(423, 115);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(43, 13);
    this.Label7.TabIndex = 45;
    this.Label7.Text = "County:";
    ((Control) this.gbDetails).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbDetails.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.gbDetails).Controls.Add((Control) this.Label8);
    ((Control) this.gbDetails).Controls.Add((Control) this.cboTACSR);
    ((Control) this.gbDetails).Controls.Add((Control) this.cboLines);
    ((Control) this.gbDetails).Controls.Add((Control) this.Label5);
    ((Control) this.gbDetails).Controls.Add((Control) this.Label4);
    ((Control) this.gbDetails).Controls.Add((Control) this.Label7);
    ((Control) this.gbDetails).Controls.Add((Control) this.cboProducerContact);
    ((Control) this.gbDetails).Controls.Add((Control) this.cboStates);
    ((Control) this.gbDetails).Controls.Add((Control) this.Label3);
    ((Control) this.gbDetails).Controls.Add((Control) this.cboCounty);
    ((Control) this.gbDetails).Controls.Add((Control) this.cboProducerLocations);
    ((Control) this.gbDetails).Controls.Add((Control) this.Label6);
    ((Control) this.gbDetails).Controls.Add((Control) this.Label2);
    ((Control) this.gbDetails).Controls.Add((Control) this.cboUnderwriters);
    ((Control) this.gbDetails).Controls.Add((Control) this.cboProducers);
    ((Control) this.gbDetails).Controls.Add((Control) this.Label1);
    appearance2.ForeColor = Color.Black;
    this.gbDetails.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.gbDetails).Location = new Point(7, 345);
    ((Control) this.gbDetails).Name = "gbDetails";
    ((Control) this.gbDetails).Size = new Size(764, 193);
    ((Control) this.gbDetails).TabIndex = 0;
    this.gbDetails.Text = "Record Details";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(423, 161);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(51, 13);
    this.Label8.TabIndex = 47;
    this.Label8.Text = "TA/CSR:";
    this.cboTACSR.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboTACSR).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerUnderwriters.TACSRUserGuid", true));
    ((UltraGridBase) this.cboTACSR).DataMember = "tblUsers";
    ((UltraGridBase) this.cboTACSR).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboTACSR).DisplayMember = "Name_LastFirst";
    this.cboTACSR.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboTACSR).Location = new Point(480, 157);
    this.cboTACSR.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboTACSR).Name = "cboTACSR";
    ((Control) this.cboTACSR).Size = new Size(274, 20);
    ((Control) this.cboTACSR).TabIndex = 46;
    ((UltraControlBase) this.cboTACSR).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboTACSR).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboTACSR).ValueMember = "UserGUID";
    this.ds.DataSetName = "dsPU";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboLines.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLines).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerUnderwriters.LineGuid", true));
    ((UltraGridBase) this.cboLines).DataMember = "lstLines";
    ((UltraGridBase) this.cboLines).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboLines).DisplayMember = "LineName";
    this.cboLines.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLines).DropDownWidth = 300;
    ((Control) this.cboLines).Location = new Point(480, 19);
    this.cboLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLines).Name = "cboLines";
    ((Control) this.cboLines).Size = new Size(274, 20);
    ((Control) this.cboLines).TabIndex = 4;
    ((UltraControlBase) this.cboLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLines).ValueMember = "LineGUID";
    this.cboProducerContact.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerContact).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerUnderwriters.ProducerContactGUID", true));
    ((UltraGridBase) this.cboProducerContact).DataMember = "tblProducerContacts";
    ((UltraGridBase) this.cboProducerContact).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboProducerContact).DisplayMember = "ContactName";
    this.cboProducerContact.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerContact).Location = new Point(131, 157);
    this.cboProducerContact.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerContact).Name = "cboProducerContact";
    ((Control) this.cboProducerContact).Size = new Size(277, 20);
    ((Control) this.cboProducerContact).TabIndex = 3;
    ((UltraControlBase) this.cboProducerContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerContact).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerContact).ValueMember = "ProducerContactGUID";
    this.cboStates.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboStates).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerUnderwriters.StateID", true));
    ((UltraGridBase) this.cboStates).DataMember = "lstStates";
    ((UltraGridBase) this.cboStates).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboStates).DisplayMember = "State";
    this.cboStates.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStates).Location = new Point(480, 65);
    this.cboStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStates).Name = "cboStates";
    ((Control) this.cboStates).Size = new Size(274, 20);
    ((Control) this.cboStates).TabIndex = 5;
    ((UltraControlBase) this.cboStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStates).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStates).ValueMember = "StateID";
    this.cboCounty.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCounty).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerUnderwriters.County", true));
    ((UltraGridBase) this.cboCounty).DataMember = "dtCounty";
    ((UltraGridBase) this.cboCounty).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCounty).DisplayMember = "County";
    this.cboCounty.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCounty).Location = new Point(480, 111);
    this.cboCounty.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCounty).Name = "cboCounty";
    ((Control) this.cboCounty).Size = new Size(274, 20);
    ((Control) this.cboCounty).TabIndex = 6;
    ((UltraControlBase) this.cboCounty).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCounty).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCounty).ValueMember = "County";
    this.cboProducerLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerLocations).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerUnderwriters.ProducerLocationGUID", true));
    ((UltraGridBase) this.cboProducerLocations).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.cboProducerLocations).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboProducerLocations).DisplayMember = "Name";
    this.cboProducerLocations.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducerLocations).DropDownWidth = 550;
    ((Control) this.cboProducerLocations).Location = new Point(131, 111);
    this.cboProducerLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerLocations).Name = "cboProducerLocations";
    ((Control) this.cboProducerLocations).Size = new Size(277, 20);
    ((Control) this.cboProducerLocations).TabIndex = 2;
    ((UltraControlBase) this.cboProducerLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerLocations).ValueMember = "ProducerLocationGUID";
    this.cboUnderwriters.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboUnderwriters).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerUnderwriters.UnderwriterGUID", true));
    ((UltraGridBase) this.cboUnderwriters).DataMember = "tblUsers";
    ((UltraGridBase) this.cboUnderwriters).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboUnderwriters).DisplayMember = "Name_LastFirst";
    this.cboUnderwriters.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUnderwriters).DropDownWidth = 300;
    ((Control) this.cboUnderwriters).Location = new Point(131, 19);
    this.cboUnderwriters.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUnderwriters).Name = "cboUnderwriters";
    ((Control) this.cboUnderwriters).Size = new Size(277, 20);
    ((Control) this.cboUnderwriters).TabIndex = 0;
    ((UltraControlBase) this.cboUnderwriters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwriters).ValueMember = "UserGUID";
    this.cboProducers.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducers).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerUnderwriters.ProducerGUID", true));
    ((UltraGridBase) this.cboProducers).DataMember = "tblProducers";
    ((UltraGridBase) this.cboProducers).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboProducers).DisplayMember = "ProducerName";
    this.cboProducers.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducers).DropDownWidth = 350;
    ((Control) this.cboProducers).Location = new Point(131, 65);
    this.cboProducers.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducers).Name = "cboProducers";
    ((Control) this.cboProducers).Size = new Size(277, 20);
    ((Control) this.cboProducers).TabIndex = 1;
    ((UltraControlBase) this.cboProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducers).ValueMember = "ProducerGUID";
    this.err.ContainerControl = (ContainerControl) this;
    this.lnkViewCurrentProducerLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkViewCurrentProducerLocation.AutoSize = true;
    this.lnkViewCurrentProducerLocation.Location = new Point(12, 550);
    this.lnkViewCurrentProducerLocation.Name = "lnkViewCurrentProducerLocation";
    this.lnkViewCurrentProducerLocation.Size = new Size(159, 13);
    this.lnkViewCurrentProducerLocation.TabIndex = 2;
    this.lnkViewCurrentProducerLocation.TabStop = true;
    this.lnkViewCurrentProducerLocation.Text = "View Current Producer/Location";
    this.lblLimitedResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lblLimitedResults.AutoSize = true;
    this.lblLimitedResults.Cursor = Cursors.Hand;
    this.lblLimitedResults.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.lblLimitedResults.ForeColor = Color.Red;
    this.lblLimitedResults.Location = new Point(477, 550);
    this.lblLimitedResults.Name = "lblLimitedResults";
    this.lblLimitedResults.Size = new Size(135, 13);
    this.lblLimitedResults.TabIndex = 32 /*0x20*/;
    this.lblLimitedResults.Text = "Limiting to top 1000 results.";
    this.lblLimitedResults.Visible = false;
    this.lnkAdvanceProducerSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAdvanceProducerSearch.AutoSize = true;
    this.lnkAdvanceProducerSearch.Location = new Point(378, 550);
    this.lnkAdvanceProducerSearch.Name = "lnkAdvanceProducerSearch";
    this.lnkAdvanceProducerSearch.Size = new Size(93, 13);
    this.lnkAdvanceProducerSearch.TabIndex = 33;
    this.lnkAdvanceProducerSearch.TabStop = true;
    this.lnkAdvanceProducerSearch.Text = "Advanced Search";
    this.lnkAdvanceProducerSearch.Visible = false;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(660, 550);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 1;
    appearance3.AlphaLevel = (short) 159;
    appearance3.ImageAlpha = (Alpha) 1;
    this.SearchPopupControlContainer.DropDownResizeHandleAppearance = (AppearanceBase) appearance3;
    this.SearchPopupControlContainer.PreferredDropDownSize = new Size(522, 100);
    ((UltraGridBase) this.ddProducerContact).DataMember = "tblProducerContacts";
    ((UltraGridBase) this.ddProducerContact).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 265;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ddProducerContact).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddProducerContact).DisplayMember = "ContactName";
    ((Control) this.ddProducerContact).Location = new Point(562, 101);
    ((Control) this.ddProducerContact).Name = "ddProducerContact";
    ((Control) this.ddProducerContact).Size = new Size(205, 89);
    ((Control) this.ddProducerContact).TabIndex = 31 /*0x1F*/;
    ((UltraDropDownBase) this.ddProducerContact).ValueMember = "ProducerContactGUID";
    ((Control) this.ddProducerContact).Visible = false;
    ((UltraGridBase) this.ddStates).DataMember = "lstStates";
    ((UltraGridBase) this.ddStates).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((Control) this.ddStates).Location = new Point(426, 101);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(130, 63 /*0x3F*/);
    ((Control) this.ddStates).TabIndex = 30;
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((Control) this.ddLines).Location = new Point(237, 217);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(152, 68);
    ((Control) this.ddLines).TabIndex = 29;
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineGUID";
    ((Control) this.ddLines).Visible = false;
    ((UltraGridBase) this.ddUnderwriter).DataMember = "tblUsers";
    ((UltraGridBase) this.ddUnderwriter).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridColumn10.Width = 206;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ddUnderwriter).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddUnderwriter).DisplayMember = "Name_LastFirst";
    ((Control) this.ddUnderwriter).Location = new Point(58, 217);
    ((Control) this.ddUnderwriter).Name = "ddUnderwriter";
    ((Control) this.ddUnderwriter).Size = new Size(173, 72);
    ((Control) this.ddUnderwriter).TabIndex = 27;
    ((UltraDropDownBase) this.ddUnderwriter).ValueMember = "UserGUID";
    ((Control) this.ddUnderwriter).Visible = false;
    ((UltraGridBase) this.ddProducerLocations).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.ddProducerLocations).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Hidden = true;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Width = 350;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.ddProducerLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraDropDownBase) this.ddProducerLocations).DisplayMember = "Name";
    ((Control) this.ddProducerLocations).Location = new Point(395, 205);
    ((Control) this.ddProducerLocations).Name = "ddProducerLocations";
    ((Control) this.ddProducerLocations).Size = new Size(207, 80 /*0x50*/);
    ((Control) this.ddProducerLocations).TabIndex = 26;
    ((UltraDropDownBase) this.ddProducerLocations).ValueMember = "ProducerLocationGUID";
    ((Control) this.ddProducerLocations).Visible = false;
    ((UltraGridBase) this.ddProducers).DataMember = "tblProducers";
    ((UltraGridBase) this.ddProducers).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Width = 350;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ((UltraGridBase) this.ddProducers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraDropDownBase) this.ddProducers).DisplayMember = "ProducerName";
    ((Control) this.ddProducers).Location = new Point(608, 205);
    ((Control) this.ddProducers).Name = "ddProducers";
    ((Control) this.ddProducers).Size = new Size(142, 74);
    ((Control) this.ddProducers).TabIndex = 25;
    ((UltraDropDownBase) this.ddProducers).ValueMember = "ProducerGUID";
    ((Control) this.ddProducers).Visible = false;
    ((Control) this.ugUnderwriterProducer).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugUnderwriterProducer).DataMember = "tblProducerUnderwriters";
    ((UltraGridBase) this.ugUnderwriterProducer).DataSource = (object) this.ds;
    appearance4.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.WhiteSmoke;
    appearance5.BorderColor = Color.WhiteSmoke;
    appearance5.FontData.UnderlineAsString = "True";
    appearance5.ForeColor = Color.Blue;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance5;
    ((SpecialBoxBase) ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 25;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Underwriter";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn16.Style = (ColumnStyle) 6;
    ultraGridColumn16.Width = 206;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridColumn17.Style = (ColumnStyle) 6;
    ultraGridColumn17.Width = 236;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Producer Location";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 3;
    ultraGridColumn18.Style = (ColumnStyle) 6;
    ultraGridColumn18.Width = 315;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 4;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 186;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 5;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 67;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 6;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 62;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 7;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 129;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 8;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 90;
    ultraGridBand7.Columns.AddRange(new object[9]
    {
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
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = Color.LightSteelBlue;
    appearance7.FontData.SizeInPoints = 10f;
    appearance7.ForeColor = Color.Navy;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.MaxSelectedRows = 10;
    appearance11.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance13.BackColor = Color.Transparent;
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugUnderwriterProducer).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugUnderwriterProducer).Location = new Point(-6, 0);
    ((Control) this.ugUnderwriterProducer).Name = "ugUnderwriterProducer";
    ((Control) this.ugUnderwriterProducer).Size = new Size(778, 339);
    ((Control) this.ugUnderwriterProducer).TabIndex = 0;
    ((Control) this.ugUnderwriterProducer).Text = "Underwriter Producer / Location Assignment";
    ((UltraControlBase) this.ugUnderwriterProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugUnderwriterProducer).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(779, 599);
    this.Controls.Add((Control) this.lnkAdvanceProducerSearch);
    this.Controls.Add((Control) this.lblLimitedResults);
    this.Controls.Add((Control) this.lnkViewCurrentProducerLocation);
    this.Controls.Add((Control) this.gbDetails);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ddProducerContact);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.lnkBulkAssignment);
    this.Controls.Add((Control) this.ddUnderwriter);
    this.Controls.Add((Control) this.ddProducerLocations);
    this.Controls.Add((Control) this.ddProducers);
    this.Controls.Add((Control) this.ugUnderwriterProducer);
    this.Name = nameof (frmProducersUnderwriters);
    this.Text = "Assign Underwriters To Producers";
    ((ISupportInitialize) this.gbDetails).EndInit();
    ((Control) this.gbDetails).ResumeLayout(false);
    ((Control) this.gbDetails).PerformLayout();
    ((ISupportInitialize) this.cboTACSR).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboLines).EndInit();
    ((ISupportInitialize) this.cboProducerContact).EndInit();
    ((ISupportInitialize) this.cboStates).EndInit();
    ((ISupportInitialize) this.cboCounty).EndInit();
    ((ISupportInitialize) this.cboProducerLocations).EndInit();
    ((ISupportInitialize) this.cboUnderwriters).EndInit();
    ((ISupportInitialize) this.cboProducers).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddProducerContact).EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    ((ISupportInitialize) this.ddUnderwriter).EndInit();
    ((ISupportInitialize) this.ddProducerLocations).EndInit();
    ((ISupportInitialize) this.ddProducers).EndInit();
    ((ISupportInitialize) this.ugUnderwriterProducer).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblProducerUnderwriters.TableName];
  }

  public frmProducersUnderwriters()
  {
    this.Load += new EventHandler(this.frmProducersUnderwriters_Load);
    this._producerLocationGUID = Guid.Empty;
    this._AllowBothProducerAndLocationFilled = false;
    this.InitializeComponent();
  }

  public frmProducersUnderwriters(Guid producerLocationGUID)
    : this()
  {
    this._producerLocationGUID = producerLocationGUID;
  }

  private void frmProducersUnderwriters_Load(object sender, EventArgs e)
  {
    try
    {
      if (this._producerLocationGUID == Guid.Empty)
      {
        this.lnkAdvanceProducerSearch.Visible = true;
        this.lblLimitedResults.Visible = true;
      }
      this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
      dsPU.lstLinesRow row1 = this.ds.lstLines.NewlstLinesRow();
      row1.LineName = "ANY";
      row1.LineGUID = Guid.Empty;
      this.ds.lstLines.AddlstLinesRow(row1);
      dsPU.lstStatesRow row2 = this.ds.lstStates.NewlstStatesRow();
      row2.State = "ANY";
      row2.StateID = "??";
      this.ds.lstStates.AddlstStatesRow(row2);
      this.AddComboEmptyRow();
      this.LoadTables();
      ((Control) this.gbDetails).Enabled = false;
      this.bmb.Position = this.ds.tblProducerUnderwriters.Count - 1;
      this.dbSave.UIState = this.ds.tblProducerUnderwriters.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
      if (SystemSettings.KeyExists("AllowBothProducerAndLocationFilled"))
        this._AllowBothProducerAndLocationFilled = SystemSettings.GetBoolSetting("AllowBothProducerAndLocationFilled");
      ((UltraGridBase) this.ugUnderwriterProducer).DisplayLayout.Bands[0].Columns["UnderwriterGUID"].SortIndicator = (SortIndicator) 1;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void LoadTables()
  {
    string[] strArray = new string[8]
    {
      "tblUsers",
      "tblProducers",
      "tblProducerLocations",
      "tblProducerUnderwriters",
      "lstLines",
      "lstStates",
      "dtCounty",
      "tblProducerContacts"
    };
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "GetUnderWriterProducerLocAssignment", new object[2]
      {
        (object) "@ProducerLocationGUID",
        this._producerLocationGUID.Equals(Guid.Empty) ? (object) null : (object) this._producerLocationGUID
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
  }

  private void AddComboEmptyRow()
  {
    DataRow row1 = this.ds.Tables["tblUsers"].NewRow();
    row1["UserGuid"] = (object) Guid.Empty;
    row1["Name_LastFirst"] = (object) "";
    this.ds.Tables["tblUsers"].Rows.Add(row1);
    DataRow row2 = this.ds.Tables["tblProducers"].NewRow();
    row2["ProducerGuid"] = (object) Guid.Empty;
    row2["ProducerName"] = (object) "";
    this.ds.Tables["tblProducers"].Rows.Add(row2);
    DataRow row3 = this.ds.Tables["tblProducerLocations"].NewRow();
    row3["ProducerLocationGUID"] = (object) Guid.Empty;
    row3["Name"] = (object) "";
    this.ds.Tables["tblProducerLocations"].Rows.Add(row3);
  }

  private bool DefaultToUnderwriterOnRecord(Guid underWriterGUID)
  {
    bool underwriterOnRecord = false;
    try
    {
      foreach (DataRow row in this.ds.tblProducerUnderwriters.Rows)
      {
        if (((Guid) row["UnderwriterGUID"]).Equals(underWriterGUID))
        {
          underwriterOnRecord = true;
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return underwriterOnRecord;
  }

  private bool ValidForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboUnderwriters, string.Empty);
    this.err.SetError((Control) this.cboProducerLocations, string.Empty);
    this.err.SetError((Control) this.cboProducers, string.Empty);
    if (this.IsEmptyComboBoxValue(this.cboUnderwriters))
    {
      this.err.SetError((Control) this.cboUnderwriters, "Must assign an underwriter.");
      flag = false;
    }
    if (this.IsEmptyComboBoxValue(this.cboProducerLocations) && this.IsEmptyComboBoxValue(this.cboProducers))
    {
      this.err.SetError((Control) this.cboProducerLocations, "Both Producer and Location cannot be empty.");
      this.err.SetError((Control) this.cboProducers, "Both Producer and Location cannot be empty.");
      flag = false;
    }
    if (!this._AllowBothProducerAndLocationFilled && !this.IsEmptyComboBoxValue(this.cboProducerLocations) && !this.IsEmptyComboBoxValue(this.cboProducers))
    {
      this.err.SetError((Control) this.cboProducerLocations, "Both cannot be filled in. Cannot assign underwriter to both Producer and Location.");
      this.err.SetError((Control) this.cboProducers, "Both cannot be filled in. Cannot assign underwriter to both Producer and Location.");
      flag = false;
    }
    return flag;
  }

  private bool IsEmptyComboBoxValue(MGASimpleComboBox cb)
  {
    return cb == null || cb.Value == null || cb.Value == DBNull.Value;
  }

  private void lnkBulkAssignment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (FormBulkProducerUnderwriterAssign formEx = (FormBulkProducerUnderwriterAssign) ObjectFactory.Instance.CreateFormEX(typeof (FormBulkProducerUnderwriterAssign)))
    {
      int num = (int) formEx.ShowDialog();
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblProducerUnderwriters.RejectChanges();
    ((Control) this.gbDetails).Enabled = false;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a record in the grid to delete", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (MessageBox.Show("Continue delete?", "Continue Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      e.Cancel = true;
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        this.ds.tblProducerUnderwriters[this.bmb.Position].Delete();
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daProducerUnderwriter, (DataTable) this.ds.tblProducerUnderwriters);
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    ((Control) this.gbDetails).Enabled = true;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    ((Control) this.gbDetails).Enabled = true;
    this.ds.tblProducerUnderwriters.AddtblProducerUnderwritersRow(this.ds.tblProducerUnderwriters.NewtblProducerUnderwritersRow());
    this.bmb.Position = this.ds.tblProducerUnderwriters.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        this.bmb.EndCurrentEdit();
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daProducerUnderwriter, (DataTable) this.ds.tblProducerUnderwriters);
        ((Control) this.gbDetails).Enabled = false;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool flag = this.dbSave.UIState == UIState.Editing;
    ((Control) this.gbDetails).Enabled = !flag;
    ((Control) this.gbDetails).Enabled = flag;
    if (flag)
      return;
    if (((UltraGridBase) this.ugUnderwriterProducer).ActiveRow == null)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void ugUnderwriterProducer_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugUnderwriterProducer).ActiveRow == null)
      return;
    Database.MoveTo((object) (int) ((UltraGridBase) this.ugUnderwriterProducer).ActiveRow.Cells["ID"].Value, this.ds.tblProducerUnderwriters.IDColumn.ColumnName, (DataTable) this.ds.tblProducerUnderwriters, this.bmb);
    if (this.dbSave.UIState == UIState.Editing)
      return;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void cboProducerContact_BeforeDropDown(object sender, CancelEventArgs e)
  {
    Guid empty1 = Guid.Empty;
    Guid empty2 = Guid.Empty;
    if (!this.IsEmptyComboBoxValue(this.cboProducers))
      empty1 = (Guid) this.cboProducers.Value;
    if (!this.IsEmptyComboBoxValue(this.cboProducerLocations))
      empty2 = (Guid) this.cboProducerLocations.Value;
    foreach (UltraGridRow row in ((UltraGridBase) this.cboProducerContact).Rows)
    {
      row.Hidden = true;
      if (row.Cells["ProducerLocationGUID"].Value != DBNull.Value & empty2.Equals((Guid) row.Cells["ProducerLocationGUID"].Value))
        row.Hidden = false;
      if (row.Cells["ProducerGUID"].Value != DBNull.Value & empty1.Equals((Guid) row.Cells["ProducerGUID"].Value))
        row.Hidden = false;
    }
  }

  private void cboCounty_BeforeDropDown(object sender, CancelEventArgs e)
  {
    string empty = string.Empty;
    if (this.cboStates.Value != null && this.cboStates.Value != DBNull.Value)
      empty = this.cboStates.Value.ToString();
    foreach (UltraGridRow row in ((UltraGridBase) this.cboCounty).Rows)
    {
      row.Hidden = true;
      if (row.Cells["StateID"].Value != DBNull.Value & empty.Equals(row.Cells["StateID"].Value.ToString()))
        row.Hidden = false;
    }
  }

  private void lnkViewCurrentProducerLocation_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.ugUnderwriterProducer).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a record in the grid to continue", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (((UltraGridBase) this.ugUnderwriterProducer).ActiveRow.Cells["ProducerLocationGUID"].Value != DBNull.Value)
    {
      Guid producerLocationGuid = (Guid) ((UltraGridBase) this.ugUnderwriterProducer).ActiveRow.Cells["ProducerLocationGUID"].Value;
      using (FormSettings.ShowFormDialog(typeof (frmProducers), (object) new ProducerLocation(producerLocationGuid).ProducerGuid, (object) producerLocationGuid))
        ;
    }
    else
    {
      if (((UltraGridBase) this.ugUnderwriterProducer).ActiveRow.Cells["ProducerGUID"].Value == DBNull.Value)
        return;
      using (FormSettings.ShowFormDialog(typeof (frmProducers), (object) (Guid) ((UltraGridBase) this.ugUnderwriterProducer).ActiveRow.Cells["ProducerGUID"].Value))
        ;
    }
  }

  private void LnkAdvanceProducerSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = (int) ObjectFactory.Instance.CreateFormEX(typeof (FormProducerUnderwriterAdvanceSearch), (object) this.ds, (object) this.ugUnderwriterProducer).ShowDialog();
  }

  private void SearchPopupControlContainer_Opened(object sender, EventArgs e)
  {
  }

  private void SearchPopupControlContainer_Opening(object sender, CancelEventArgs e)
  {
  }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
  }

  private void LblLimitedResults_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.ds.tblProducerUnderwriters.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblProducerUnderwriters"
      }, "GetUnderWriterProducerLocAssignmentAdvanced", new object[2]
      {
        (object) "@HasReturnLimit",
        (object) 1
      });
      ((UltraGridBase) this.ugUnderwriterProducer).DataSource = (object) this.ds.Tables["tblProducerUnderwriters"];
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }
}
