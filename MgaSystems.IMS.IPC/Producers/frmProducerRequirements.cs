// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerRequirements
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

[SecureResource("{31986E19-AE7B-448f-A898-EE86A9CB71AA}", "Access Producer Requirements Screen", "Controls access to the Producer Requirements screen.", "Producers")]
public class frmProducerRequirements : Form, IUIElementDrawFilter
{
  private IContainer components;
  private Label Label1;
  private SqlConnection cnSQL;
  private SqlDataAdapter daProducerReqs;
  private UltraLabel lblProducerLocation;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private MGATextBox txtPolNum;
  private ErrorProvider ep;
  private Label Label5;
  protected UltraDropDown ddRequirements;
  protected UltraDropDown ddContacts;
  private MGADateTimePicker dtValidThru;
  private Label Label7;
  protected MGANumericEditor UltraNumericEditor1;
  public const string OpenForm = "{31986E19-AE7B-448f-A898-EE86A9CB71AA}";
  private Guid _producerLocationGUID;
  protected int _CurrentRequirementID;
  private Guid _producerGUID;
  private string _locationName;
  private string _producerName;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("dsReqs")]
  protected virtual dsProducerRequirements dsReqs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboReqs
  {
    get => this._cboReqs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboReqs_ValueChanged);
      MGASimpleComboBox cboReqs1 = this._cboReqs;
      if (cboReqs1 != null)
        cboReqs1.ValueChanged -= eventHandler;
      this._cboReqs = value;
      MGASimpleComboBox cboReqs2 = this._cboReqs;
      if (cboReqs2 == null)
        return;
      cboReqs2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtCarrier")]
  protected virtual MGATextBox txtCarrier { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbEntry")]
  protected virtual MGAGroupBox gbEntry { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboContacts")]
  private virtual MGASimpleComboBox cboContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid dgView
  {
    get => this._dgView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgView_AfterRowActivate);
      UltraGrid dgView1 = this._dgView;
      if (dgView1 != null)
        dgView1.AfterRowActivate -= eventHandler;
      this._dgView = value;
      UltraGrid dgView2 = this._dgView;
      if (dgView2 == null)
        return;
      dgView2.AfterRowActivate += eventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.UIStateChanged -= eventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.UIStateChanged += eventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler3;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  protected virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbOnFile")]
  protected virtual MGACheckBox cbOnFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboUsers")]
  protected virtual MGASimpleComboBox cboUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpSignedAsOf")]
  private virtual MGADateTimePicker dtpSignedAsOf { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker1")]
  private virtual MGADateTimePicker MgaDateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtName1099")]
  protected virtual MGATextBox txtName1099 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNum1099")]
  protected virtual MGATextBox txtNum1099 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  protected virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  protected virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkNeededtoQuote")]
  internal virtual MGACheckBox chkNeededtoQuote { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkNeededtoBind")]
  internal virtual MGACheckBox chkNeededtoBind { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkNeededToClear")]
  internal virtual MGACheckBox chkNeededToClear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkNeededtoIssue")]
  internal virtual MGACheckBox chkNeededtoIssue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaEOPremium")]
  protected virtual MGANumericEditor MgaEOPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  protected virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  protected virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor1")]
  protected virtual MGANumericEditor MgaNumericEditor1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  protected virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  protected virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor3")]
  protected virtual MGANumericEditor MgaNumericEditor3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor2")]
  protected virtual MGANumericEditor MgaNumericEditor2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDocumentRequestedOn")]
  protected virtual MGADateTimePicker dtpDocumentRequestedOn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  protected virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRightSignatureRefNum")]
  protected virtual Label lblRightSignatureRefNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRightSignatureRefNum")]
  protected virtual MGATextBox txtRightSignatureRefNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPromptOnQuote")]
  internal virtual MGACheckBox chkPromptOnQuote { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmProducerRequirements));
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
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblProducerRequirements", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerRequirementsID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ProducerContactGUID", -1, (object) "ddContacts");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerRequirementListID", -1, (object) "ddRequirements");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ValidThrough");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Carrier");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PolicyNo");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PolicyLimit");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("OnFile");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DiaryUser");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("SignedAsOf");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Name1099");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Num1099");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("NeededToBind");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("NeededToClear");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("NeededToQuote");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("NeededToIssue");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("EOPremium");
    Appearance appearance30 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("NumDays");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("AggregateLimit");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Deductible");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("DocumentRequestedOn");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("RightSignatureRefNum");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("PromptOnQuote");
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstProducerRequirements", -1);
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("ProducerRequirementListID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("lstProducerRequirementstblProducerRequirements");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstProducerRequirementstblProducerRequirements", 0);
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ProducerRequirementsID");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ProducerContactGUID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("ProducerRequirementListID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("ValidThrough");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Carrier");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("PolicyNo");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("PolicyLimit");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("OnFile");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("DiaryUser");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("SignedAsOf");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Name1099");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Num1099");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("NeededToBind");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("NeededToClear");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("NeededToQuote");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("NeededToIssue");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("EOPremium");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("NumDays");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("AggregateLimit");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("Deductible");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("DocumentRequestedOn");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("RightSignatureRefNum");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("PromptOnQuote");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblProducerContacts", -1);
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("ProducerContactGUID");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("Name");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    this.Label1 = new Label();
    this.dsReqs = new dsProducerRequirements();
    this.cnSQL = new SqlConnection();
    this.daProducerReqs = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.gbEntry = new MGAGroupBox();
    this.chkPromptOnQuote = new MGACheckBox();
    this.lblRightSignatureRefNum = new Label();
    this.txtRightSignatureRefNum = new MGATextBox();
    this.dtpDocumentRequestedOn = new MGADateTimePicker();
    this.Label17 = new Label();
    this.Label16 = new Label();
    this.Label15 = new Label();
    this.MgaNumericEditor3 = new MGANumericEditor();
    this.MgaNumericEditor2 = new MGANumericEditor();
    this.Label14 = new Label();
    this.Label13 = new Label();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.Label12 = new Label();
    this.MgaEOPremium = new MGANumericEditor();
    this.chkNeededtoIssue = new MGACheckBox();
    this.chkNeededtoQuote = new MGACheckBox();
    this.chkNeededtoBind = new MGACheckBox();
    this.chkNeededToClear = new MGACheckBox();
    this.txtNum1099 = new MGATextBox();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.txtName1099 = new MGATextBox();
    this.Label9 = new Label();
    this.dtpSignedAsOf = new MGADateTimePicker();
    this.Label8 = new Label();
    this.cboUsers = new MGASimpleComboBox();
    this.cbOnFile = new MGACheckBox();
    this.UltraNumericEditor1 = new MGANumericEditor();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.dtValidThru = new MGADateTimePicker();
    this.Label5 = new Label();
    this.cboContacts = new MGASimpleComboBox();
    this.txtPolNum = new MGATextBox();
    this.Label4 = new Label();
    this.txtCarrier = new MGATextBox();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.cboReqs = new MGASimpleComboBox();
    this.lblProducerLocation = new UltraLabel();
    this.ep = new ErrorProvider(this.components);
    this.dgView = new UltraGrid();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.ddRequirements = new UltraDropDown();
    this.ddContacts = new UltraDropDown();
    this.MgaDateTimePicker1 = new MGADateTimePicker();
    this.dsReqs.BeginInit();
    ((ISupportInitialize) this.gbEntry).BeginInit();
    ((Control) this.gbEntry).SuspendLayout();
    ((ISupportInitialize) this.chkPromptOnQuote).BeginInit();
    ((ISupportInitialize) this.txtRightSignatureRefNum).BeginInit();
    ((ISupportInitialize) this.dtpDocumentRequestedOn).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor3).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor2).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    ((ISupportInitialize) this.MgaEOPremium).BeginInit();
    ((ISupportInitialize) this.chkNeededtoIssue).BeginInit();
    ((ISupportInitialize) this.chkNeededtoQuote).BeginInit();
    ((ISupportInitialize) this.chkNeededtoBind).BeginInit();
    ((ISupportInitialize) this.chkNeededToClear).BeginInit();
    ((ISupportInitialize) this.txtNum1099).BeginInit();
    ((ISupportInitialize) this.txtName1099).BeginInit();
    ((ISupportInitialize) this.dtpSignedAsOf).BeginInit();
    ((ISupportInitialize) this.cboUsers).BeginInit();
    ((ISupportInitialize) this.cbOnFile).BeginInit();
    ((ISupportInitialize) this.UltraNumericEditor1).BeginInit();
    ((ISupportInitialize) this.dtValidThru).BeginInit();
    ((ISupportInitialize) this.cboContacts).BeginInit();
    ((ISupportInitialize) this.txtPolNum).BeginInit();
    ((ISupportInitialize) this.txtCarrier).BeginInit();
    ((ISupportInitialize) this.cboReqs).BeginInit();
    ((ISupportInitialize) this.ep).BeginInit();
    ((ISupportInitialize) this.dgView).BeginInit();
    ((ISupportInitialize) this.ddRequirements).BeginInit();
    ((ISupportInitialize) this.ddContacts).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker1).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(36, 56);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(72, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Requirement:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.dsReqs.DataSetName = "dsProducerRequirements";
    this.dsReqs.Locale = new CultureInfo("en-US");
    this.dsReqs.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cnSQL.ConnectionString = "Data Source=10.0.0.52;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daProducerReqs.DeleteCommand = this.SqlDeleteCommand1;
    this.daProducerReqs.InsertCommand = this.SqlInsertCommand1;
    this.daProducerReqs.SelectCommand = this.SqlSelectCommand1;
    this.daProducerReqs.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerRequirements", new DataColumnMapping[25]
      {
        new DataColumnMapping("ProducerRequirementsID", "ProducerRequirementsID"),
        new DataColumnMapping("ProducerLocationGUID", "ProducerLocationGUID"),
        new DataColumnMapping("ProducerRequirementListID", "ProducerRequirementListID"),
        new DataColumnMapping("ValidThrough", "ValidThrough"),
        new DataColumnMapping("Carrier", "Carrier"),
        new DataColumnMapping("PolicyNo", "PolicyNo"),
        new DataColumnMapping("ProducerContactGUID", "ProducerContactGUID"),
        new DataColumnMapping("PolicyLimit", "PolicyLimit"),
        new DataColumnMapping("OnFile", "OnFile"),
        new DataColumnMapping("DiaryUser", "DiaryUser"),
        new DataColumnMapping("SignedAsOf", "SignedAsOf"),
        new DataColumnMapping("ProducerGUID", "ProducerGUID"),
        new DataColumnMapping("Name1099", "Name1099"),
        new DataColumnMapping("Num1099", "Num1099"),
        new DataColumnMapping("NeededToClear", "NeededToClear"),
        new DataColumnMapping("NeededToQuote", "NeededToQuote"),
        new DataColumnMapping("NeededToBind", "NeededToBind"),
        new DataColumnMapping("NeededToIssue", "NeededToIssue"),
        new DataColumnMapping("EOPremium", "EOPremium"),
        new DataColumnMapping("NumDays", "NumDays"),
        new DataColumnMapping("AggregateLimit", "AggregateLimit"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("DocumentRequestedOn", "DocumentRequestedOn"),
        new DataColumnMapping("RightSignatureRefNum", "RightSignatureRefNum"),
        new DataColumnMapping("PromptOnQuote", "PromptOnQuote")
      })
    });
    this.daProducerReqs.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblProducerRequirements] WHERE (([ProducerRequirementsID] = @Original_ProducerRequirementsID))";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ProducerRequirementsID", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 0, "ProducerRequirementsID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[24]
    {
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGUID"),
      new SqlParameter("@ProducerRequirementListID", SqlDbType.Int, 0, "ProducerRequirementListID"),
      new SqlParameter("@ValidThrough", SqlDbType.DateTime, 0, "ValidThrough"),
      new SqlParameter("@Carrier", SqlDbType.VarChar, 0, "Carrier"),
      new SqlParameter("@PolicyNo", SqlDbType.VarChar, 0, "PolicyNo"),
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 0, "ProducerContactGUID"),
      new SqlParameter("@PolicyLimit", SqlDbType.Int, 0, "PolicyLimit"),
      new SqlParameter("@OnFile", SqlDbType.Bit, 0, "OnFile"),
      new SqlParameter("@DiaryUser", SqlDbType.UniqueIdentifier, 0, "DiaryUser"),
      new SqlParameter("@SignedAsOf", SqlDbType.DateTime, 0, "SignedAsOf"),
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 0, "ProducerGUID"),
      new SqlParameter("@Name1099", SqlDbType.VarChar, 0, "Name1099"),
      new SqlParameter("@Num1099", SqlDbType.VarChar, 0, "Num1099"),
      new SqlParameter("@NeededToClear", SqlDbType.Bit, 0, "NeededToClear"),
      new SqlParameter("@NeededToQuote", SqlDbType.Bit, 0, "NeededToQuote"),
      new SqlParameter("@NeededToBind", SqlDbType.Bit, 0, "NeededToBind"),
      new SqlParameter("@NeededToIssue", SqlDbType.Bit, 0, "NeededToIssue"),
      new SqlParameter("@EOPremium", SqlDbType.Money, 0, "EOPremium"),
      new SqlParameter("@NumDays", SqlDbType.SmallInt, 0, "NumDays"),
      new SqlParameter("@AggregateLimit", SqlDbType.Money, 0, "AggregateLimit"),
      new SqlParameter("@Deductible", SqlDbType.Money, 0, "Deductible"),
      new SqlParameter("@DocumentRequestedOn", SqlDbType.SmallDateTime, 0, "DocumentRequestedOn"),
      new SqlParameter("@RightSignatureRefNum", SqlDbType.VarChar, 0, "RightSignatureRefNum"),
      new SqlParameter("@PromptOnQuote", SqlDbType.Bit, 0, "PromptOnQuote")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGUID"),
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[26]
    {
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGUID"),
      new SqlParameter("@ProducerRequirementListID", SqlDbType.Int, 0, "ProducerRequirementListID"),
      new SqlParameter("@ValidThrough", SqlDbType.DateTime, 0, "ValidThrough"),
      new SqlParameter("@Carrier", SqlDbType.VarChar, 0, "Carrier"),
      new SqlParameter("@PolicyNo", SqlDbType.VarChar, 0, "PolicyNo"),
      new SqlParameter("@ProducerContactGUID", SqlDbType.UniqueIdentifier, 0, "ProducerContactGUID"),
      new SqlParameter("@PolicyLimit", SqlDbType.Int, 0, "PolicyLimit"),
      new SqlParameter("@OnFile", SqlDbType.Bit, 0, "OnFile"),
      new SqlParameter("@DiaryUser", SqlDbType.UniqueIdentifier, 0, "DiaryUser"),
      new SqlParameter("@SignedAsOf", SqlDbType.DateTime, 0, "SignedAsOf"),
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 0, "ProducerGUID"),
      new SqlParameter("@Name1099", SqlDbType.VarChar, 0, "Name1099"),
      new SqlParameter("@Num1099", SqlDbType.VarChar, 0, "Num1099"),
      new SqlParameter("@NeededToClear", SqlDbType.Bit, 0, "NeededToClear"),
      new SqlParameter("@NeededToQuote", SqlDbType.Bit, 0, "NeededToQuote"),
      new SqlParameter("@NeededToBind", SqlDbType.Bit, 0, "NeededToBind"),
      new SqlParameter("@NeededToIssue", SqlDbType.Bit, 0, "NeededToIssue"),
      new SqlParameter("@EOPremium", SqlDbType.Money, 0, "EOPremium"),
      new SqlParameter("@NumDays", SqlDbType.SmallInt, 0, "NumDays"),
      new SqlParameter("@AggregateLimit", SqlDbType.Money, 0, "AggregateLimit"),
      new SqlParameter("@Deductible", SqlDbType.Money, 0, "Deductible"),
      new SqlParameter("@DocumentRequestedOn", SqlDbType.SmallDateTime, 0, "DocumentRequestedOn"),
      new SqlParameter("@RightSignatureRefNum", SqlDbType.VarChar, 0, "RightSignatureRefNum"),
      new SqlParameter("@PromptOnQuote", SqlDbType.Bit, 0, "PromptOnQuote"),
      new SqlParameter("@Original_ProducerRequirementsID", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 0, "ProducerRequirementsID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ProducerRequirementsID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "ProducerRequirementsID", DataRowVersion.Current, (object) null)
    });
    ((Control) this.gbEntry).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbEntry.Appearance = (AppearanceBase) appearance1;
    this.gbEntry.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(246, 250, 253);
    appearance2.BackColorDisabled = Color.FromArgb(246, 250, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbEntry.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.gbEntry).Controls.Add((Control) this.chkPromptOnQuote);
    ((Control) this.gbEntry).Controls.Add((Control) this.lblRightSignatureRefNum);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtRightSignatureRefNum);
    ((Control) this.gbEntry).Controls.Add((Control) this.dtpDocumentRequestedOn);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label17);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label16);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label15);
    ((Control) this.gbEntry).Controls.Add((Control) this.MgaNumericEditor3);
    ((Control) this.gbEntry).Controls.Add((Control) this.MgaNumericEditor2);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label14);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label13);
    ((Control) this.gbEntry).Controls.Add((Control) this.MgaNumericEditor1);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label12);
    ((Control) this.gbEntry).Controls.Add((Control) this.MgaEOPremium);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkNeededtoIssue);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkNeededtoQuote);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkNeededtoBind);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkNeededToClear);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtNum1099);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label11);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label10);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtName1099);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label9);
    ((Control) this.gbEntry).Controls.Add((Control) this.dtpSignedAsOf);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label8);
    ((Control) this.gbEntry).Controls.Add((Control) this.cboUsers);
    ((Control) this.gbEntry).Controls.Add((Control) this.cbOnFile);
    ((Control) this.gbEntry).Controls.Add((Control) this.UltraNumericEditor1);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label7);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label6);
    ((Control) this.gbEntry).Controls.Add((Control) this.dtValidThru);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label5);
    ((Control) this.gbEntry).Controls.Add((Control) this.cboContacts);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtPolNum);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label4);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtCarrier);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label3);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label2);
    ((Control) this.gbEntry).Controls.Add((Control) this.cboReqs);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label1);
    ((Control) this.gbEntry).Enabled = false;
    appearance3.AlphaLevel = (short) 230;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.White;
    appearance3.ForegroundAlpha = (Alpha) 2;
    appearance3.ImageBackgroundAlpha = (Alpha) 1;
    appearance3.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.gbEntry.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.gbEntry).Location = new Point(15, 235);
    ((Control) this.gbEntry).Name = "gbEntry";
    ((Control) this.gbEntry).Size = new Size(730, 410);
    ((Control) this.gbEntry).TabIndex = 0;
    this.gbEntry.Text = "Requirement Information";
    this.gbEntry.ViewStyle = (GroupBoxViewStyle) 2;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPromptOnQuote).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkPromptOnQuote).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPromptOnQuote).BackColorInternal = Color.Transparent;
    ((Control) this.chkPromptOnQuote).DataBindings.Add(new Binding("Checked", (object) this.dsReqs, "tblProducerRequirements.PromptOnQuote", true));
    ((UltraToggleEditorBase) this.chkPromptOnQuote).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPromptOnQuote).Location = new Point(128 /*0x80*/, 383);
    ((Control) this.chkPromptOnQuote).Name = "chkPromptOnQuote";
    ((Control) this.chkPromptOnQuote).Size = new Size(116, 21);
    ((Control) this.chkPromptOnQuote).TabIndex = 26;
    ((UltraToggleEditorBase) this.chkPromptOnQuote).Text = "Prompt On Quote";
    ((UltraControlBase) this.chkPromptOnQuote).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPromptOnQuote).UseOsThemes = (DefaultableBoolean) 2;
    this.lblRightSignatureRefNum.AutoSize = true;
    this.lblRightSignatureRefNum.BackColor = Color.Transparent;
    this.lblRightSignatureRefNum.Location = new Point(387, 233);
    this.lblRightSignatureRefNum.Name = "lblRightSignatureRefNum";
    this.lblRightSignatureRefNum.Size = new Size(120, 13);
    this.lblRightSignatureRefNum.TabIndex = 20;
    this.lblRightSignatureRefNum.Text = "Right Signature Ref. #:";
    this.lblRightSignatureRefNum.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRightSignatureRefNum).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtRightSignatureRefNum).BackColor = Color.White;
    ((Control) this.txtRightSignatureRefNum).DataBindings.Add(new Binding("Text", (object) this.dsReqs, "tblProducerRequirements.RightSignatureRefNum", true));
    ((Control) this.txtRightSignatureRefNum).Location = new Point(514, 229);
    ((TextEditorControlBase) this.txtRightSignatureRefNum).MaxLength = 50;
    this.txtRightSignatureRefNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtRightSignatureRefNum).Name = "txtRightSignatureRefNum";
    ((Control) this.txtRightSignatureRefNum).Size = new Size(105, 20);
    ((Control) this.txtRightSignatureRefNum).TabIndex = 21;
    ((UltraControlBase) this.txtRightSignatureRefNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRightSignatureRefNum).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpDocumentRequestedOn.Appearance = (AppearanceBase) appearance6;
    appearance7.AlphaLevel = (short) 14;
    appearance7.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance7.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance7.BackColorAlpha = (Alpha) 2;
    appearance7.BackGradientAlignment = (GradientAlignment) 4;
    appearance7.BackGradientStyle = (GradientStyle) 5;
    appearance7.BorderAlpha = (Alpha) 1;
    appearance7.BorderColor = Color.FromArgb(78, 122, 171);
    appearance7.ForeColor = Color.FromArgb(49, 85, 153);
    appearance7.ForegroundAlpha = (Alpha) 2;
    this.dtpDocumentRequestedOn.ButtonAppearance = (AppearanceBase) appearance7;
    ((Control) this.dtpDocumentRequestedOn).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.DocumentRequestedOn", true));
    this.dtpDocumentRequestedOn.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpDocumentRequestedOn).Location = new Point(514, 204);
    this.dtpDocumentRequestedOn.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpDocumentRequestedOn).Name = "dtpDocumentRequestedOn";
    ((Control) this.dtpDocumentRequestedOn).Size = new Size(105, 20);
    ((Control) this.dtpDocumentRequestedOn).TabIndex = 18;
    ((UltraControlBase) this.dtpDocumentRequestedOn).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDocumentRequestedOn).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpDocumentRequestedOn.Value = (object) null;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(376, 208 /*0xD0*/);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(131, 13);
    this.Label17.TabIndex = 17;
    this.Label17.Text = "Document Requested On:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    this.Label16.AutoSize = true;
    this.Label16.Location = new Point(36, 258);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(61, 13);
    this.Label16.TabIndex = 230;
    this.Label16.Text = "Deductible:";
    this.Label15.AutoSize = true;
    this.Label15.Location = new Point(36, 233);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(86, 13);
    this.Label15.TabIndex = 229;
    this.Label15.Text = "Aggregate Limit:";
    appearance8.BackColorDisabled = Color.Gainsboro;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor3).Appearance = (AppearanceBase) appearance8;
    ((Control) this.MgaNumericEditor3).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.Deductible", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor3).FormatString = "c";
    ((Control) this.MgaNumericEditor3).Location = new Point(128 /*0x80*/, 254);
    this.MgaNumericEditor3.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor3.MinValue = (object) 1;
    ((Control) this.MgaNumericEditor3).Name = "MgaNumericEditor3";
    this.MgaNumericEditor3.Nullable = true;
    ((Control) this.MgaNumericEditor3).Size = new Size(105, 20);
    ((Control) this.MgaNumericEditor3).TabIndex = 19;
    ((UltraControlBase) this.MgaNumericEditor3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor3).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BackColorDisabled = Color.Gainsboro;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor2).Appearance = (AppearanceBase) appearance9;
    ((Control) this.MgaNumericEditor2).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.AggregateLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor2).FormatString = "c";
    ((Control) this.MgaNumericEditor2).Location = new Point(128 /*0x80*/, 229);
    this.MgaNumericEditor2.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor2.MinValue = (object) 1;
    ((Control) this.MgaNumericEditor2).Name = "MgaNumericEditor2";
    this.MgaNumericEditor2.Nullable = true;
    ((Control) this.MgaNumericEditor2).Size = new Size(105, 20);
    ((Control) this.MgaNumericEditor2).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.MgaNumericEditor2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(395, 182);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(34, 13);
    this.Label14.TabIndex = 11;
    this.Label14.Text = "days.";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(336, 182);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(18, 13);
    this.Label13.TabIndex = 10;
    this.Label13.Text = "in ";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    appearance10.BackColorDisabled = Color.Gainsboro;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance10;
    ((Control) this.MgaNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.NumDays", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor1).FormatString = "";
    ((Control) this.MgaNumericEditor1).Location = new Point(360, 178);
    this.MgaNumericEditor1.MaskInput = "nnn";
    this.MgaNumericEditor1.MaxValue = (object) 999;
    this.MgaNumericEditor1.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor1.MinValue = (object) 1;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    this.MgaNumericEditor1.Nullable = true;
    ((Control) this.MgaNumericEditor1).Size = new Size(29, 20);
    ((Control) this.MgaNumericEditor1).TabIndex = 8;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(445, 107);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(65, 13);
    this.Label12.TabIndex = 223;
    this.Label12.Text = "EOPremium:";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    appearance11.BackColorDisabled = Color.Gainsboro;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaEOPremium).Appearance = (AppearanceBase) appearance11;
    ((Control) this.MgaEOPremium).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.EOPremium", true));
    ((UltraNumericEditorBase) this.MgaEOPremium).FormatString = "c";
    ((Control) this.MgaEOPremium).Location = new Point(514, 103);
    this.MgaEOPremium.MGAStyle = MGAStyles.Blue;
    this.MgaEOPremium.MinValue = (object) 1;
    ((Control) this.MgaEOPremium).Name = "MgaEOPremium";
    this.MgaEOPremium.Nullable = true;
    ((Control) this.MgaEOPremium).Size = new Size(105, 20);
    ((Control) this.MgaEOPremium).TabIndex = 4;
    ((UltraControlBase) this.MgaEOPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaEOPremium).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.Gray;
    appearance12.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkNeededtoIssue).Appearance = (AppearanceBase) appearance12;
    ((UltraToggleEditorBase) this.chkNeededtoIssue).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNeededtoIssue).BackColorInternal = Color.Transparent;
    ((Control) this.chkNeededtoIssue).DataBindings.Add(new Binding("Checked", (object) this.dsReqs, "tblProducerRequirements.NeededToIssue", true));
    ((UltraToggleEditorBase) this.chkNeededtoIssue).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkNeededtoIssue).Location = new Point(128 /*0x80*/, 357);
    ((Control) this.chkNeededtoIssue).Name = "chkNeededtoIssue";
    ((Control) this.chkNeededtoIssue).Size = new Size(116, 21);
    ((Control) this.chkNeededtoIssue).TabIndex = 25;
    ((UltraToggleEditorBase) this.chkNeededtoIssue).Text = "Needed to Issue";
    ((UltraControlBase) this.chkNeededtoIssue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkNeededtoIssue).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.Gray;
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkNeededtoQuote).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkNeededtoQuote).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNeededtoQuote).BackColorInternal = Color.Transparent;
    ((Control) this.chkNeededtoQuote).DataBindings.Add(new Binding("Checked", (object) this.dsReqs, "tblProducerRequirements.NeededToQuote", true));
    ((UltraToggleEditorBase) this.chkNeededtoQuote).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkNeededtoQuote).Location = new Point(128 /*0x80*/, 305);
    ((Control) this.chkNeededtoQuote).Name = "chkNeededtoQuote";
    ((Control) this.chkNeededtoQuote).Size = new Size(116, 21);
    ((Control) this.chkNeededtoQuote).TabIndex = 23;
    ((UltraToggleEditorBase) this.chkNeededtoQuote).Text = "Needed to Quote";
    ((UltraControlBase) this.chkNeededtoQuote).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkNeededtoQuote).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.Gray;
    appearance14.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkNeededtoBind).Appearance = (AppearanceBase) appearance14;
    ((UltraToggleEditorBase) this.chkNeededtoBind).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNeededtoBind).BackColorInternal = Color.Transparent;
    ((Control) this.chkNeededtoBind).DataBindings.Add(new Binding("Checked", (object) this.dsReqs, "tblProducerRequirements.NeededToBind", true));
    ((UltraToggleEditorBase) this.chkNeededtoBind).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkNeededtoBind).Location = new Point(128 /*0x80*/, 331);
    ((Control) this.chkNeededtoBind).Name = "chkNeededtoBind";
    ((Control) this.chkNeededtoBind).Size = new Size(105, 21);
    ((Control) this.chkNeededtoBind).TabIndex = 24;
    ((UltraToggleEditorBase) this.chkNeededtoBind).Text = "Needed to Bind";
    ((UltraControlBase) this.chkNeededtoBind).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkNeededtoBind).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.Gray;
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkNeededToClear).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.chkNeededToClear).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNeededToClear).BackColorInternal = Color.Transparent;
    ((Control) this.chkNeededToClear).DataBindings.Add(new Binding("Checked", (object) this.dsReqs, "tblProducerRequirements.NeededToClear", true));
    ((UltraToggleEditorBase) this.chkNeededToClear).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkNeededToClear).Location = new Point(128 /*0x80*/, 279);
    ((Control) this.chkNeededToClear).Name = "chkNeededToClear";
    ((Control) this.chkNeededToClear).Size = new Size(105, 21);
    ((Control) this.chkNeededToClear).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkNeededToClear).Text = "Needed to Clear";
    ((UltraControlBase) this.chkNeededToClear).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkNeededToClear).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNum1099).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtNum1099).BackColor = Color.White;
    ((Control) this.txtNum1099).DataBindings.Add(new Binding("Text", (object) this.dsReqs, "tblProducerRequirements.Num1099", true));
    ((Control) this.txtNum1099).Location = new Point(514, 178);
    ((TextEditorControlBase) this.txtNum1099).MaxLength = 50;
    this.txtNum1099.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNum1099).Name = "txtNum1099";
    ((Control) this.txtNum1099).Size = new Size(105, 20);
    ((Control) this.txtNum1099).TabIndex = 15;
    ((UltraControlBase) this.txtNum1099).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNum1099).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(461, 182);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(46, 13);
    this.Label11.TabIndex = 14;
    this.Label11.Text = "1099 #:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(445, 132);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(65, 13);
    this.Label10.TabIndex = 215;
    this.Label10.Text = "1099 Name:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtName1099).Appearance = (AppearanceBase) appearance17;
    ((TextEditorControlBase) this.txtName1099).BackColor = Color.White;
    ((Control) this.txtName1099).DataBindings.Add(new Binding("Text", (object) this.dsReqs, "tblProducerRequirements.Name1099", true));
    ((Control) this.txtName1099).Location = new Point(514, 132);
    ((TextEditorControlBase) this.txtName1099).MaxLength = 100;
    this.txtName1099.MGAStyle = MGAStyles.Blue;
    this.txtName1099.Multiline = true;
    ((Control) this.txtName1099).Name = "txtName1099";
    ((Control) this.txtName1099).Size = new Size(105, 42);
    ((Control) this.txtName1099).TabIndex = 6;
    ((UltraControlBase) this.txtName1099).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtName1099).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.Location = new Point(36, 208 /*0xD0*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(72, 13);
    this.Label9.TabIndex = 213;
    this.Label9.Text = "Signed as Of:";
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpSignedAsOf.Appearance = (AppearanceBase) appearance18;
    appearance19.AlphaLevel = (short) 14;
    appearance19.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance19.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance19.BackColorAlpha = (Alpha) 2;
    appearance19.BackGradientAlignment = (GradientAlignment) 4;
    appearance19.BackGradientStyle = (GradientStyle) 5;
    appearance19.BorderAlpha = (Alpha) 1;
    appearance19.BorderColor = Color.FromArgb(78, 122, 171);
    appearance19.ForeColor = Color.FromArgb(49, 85, 153);
    appearance19.ForegroundAlpha = (Alpha) 2;
    this.dtpSignedAsOf.ButtonAppearance = (AppearanceBase) appearance19;
    ((Control) this.dtpSignedAsOf).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.SignedAsOf", true));
    this.dtpSignedAsOf.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpSignedAsOf).Location = new Point(128 /*0x80*/, 204);
    this.dtpSignedAsOf.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpSignedAsOf).Name = "dtpSignedAsOf";
    ((Control) this.dtpSignedAsOf).Size = new Size(105, 20);
    ((Control) this.dtpSignedAsOf).TabIndex = 12;
    ((UltraControlBase) this.dtpSignedAsOf).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpSignedAsOf).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpSignedAsOf.Value = (object) null;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(36, 182);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(78, 13);
    this.Label8.TabIndex = 34;
    this.Label8.Text = "Send Diary To:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.cboUsers.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboUsers).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.DiaryUser", true));
    ((UltraGridBase) this.cboUsers).DataSource = (object) this.dsReqs.tblUsers;
    ((UltraDropDownBase) this.cboUsers).DisplayMember = "UserName";
    this.cboUsers.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUsers).Location = new Point(128 /*0x80*/, 178);
    this.cboUsers.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUsers).Name = "cboUsers";
    ((Control) this.cboUsers).Size = new Size(200, 21);
    ((Control) this.cboUsers).TabIndex = 9;
    ((UltraControlBase) this.cboUsers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUsers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUsers).ValueMember = "UserGuid";
    appearance20.BorderColor = Color.Gray;
    appearance20.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.cbOnFile).Appearance = (AppearanceBase) appearance20;
    ((UltraToggleEditorBase) this.cbOnFile).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.cbOnFile).BackColorInternal = Color.Transparent;
    ((Control) this.cbOnFile).DataBindings.Add(new Binding("Checked", (object) this.dsReqs, "tblProducerRequirements.OnFile", true));
    ((UltraToggleEditorBase) this.cbOnFile).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.cbOnFile).Location = new Point(265, 204);
    ((Control) this.cbOnFile).Name = "cbOnFile";
    ((Control) this.cbOnFile).Size = new Size(70, 21);
    ((Control) this.cbOnFile).TabIndex = 13;
    ((UltraToggleEditorBase) this.cbOnFile).Text = "On File";
    ((UltraControlBase) this.cbOnFile).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbOnFile).UseOsThemes = (DefaultableBoolean) 2;
    appearance21.BackColorDisabled = Color.Gainsboro;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.UltraNumericEditor1).Appearance = (AppearanceBase) appearance21;
    ((Control) this.UltraNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.PolicyLimit", true));
    ((UltraNumericEditorBase) this.UltraNumericEditor1).FormatString = "c";
    ((Control) this.UltraNumericEditor1).Location = new Point(128 /*0x80*/, 128 /*0x80*/);
    this.UltraNumericEditor1.MGAStyle = MGAStyles.Blue;
    this.UltraNumericEditor1.MinValue = (object) 1;
    ((Control) this.UltraNumericEditor1).Name = "UltraNumericEditor1";
    this.UltraNumericEditor1.Nullable = true;
    ((Control) this.UltraNumericEditor1).Size = new Size(100, 20);
    ((Control) this.UltraNumericEditor1).TabIndex = 5;
    ((UltraControlBase) this.UltraNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(36, 132);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(62, 13);
    this.Label7.TabIndex = 30;
    this.Label7.Text = "Policy Limit:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(269, 147);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(66, 13);
    this.Label6.TabIndex = 8;
    this.Label6.Text = "(clear if n/a)";
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtValidThru.Appearance = (AppearanceBase) appearance22;
    appearance23.AlphaLevel = (short) 14;
    appearance23.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance23.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance23.BackColorAlpha = (Alpha) 2;
    appearance23.BackGradientAlignment = (GradientAlignment) 4;
    appearance23.BackGradientStyle = (GradientStyle) 5;
    appearance23.BorderAlpha = (Alpha) 1;
    appearance23.BorderColor = Color.FromArgb(78, 122, 171);
    appearance23.ForeColor = Color.FromArgb(49, 85, 153);
    appearance23.ForegroundAlpha = (Alpha) 2;
    this.dtValidThru.ButtonAppearance = (AppearanceBase) appearance23;
    ((Control) this.dtValidThru).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.ValidThrough", true));
    this.dtValidThru.DateTime = new DateTime(2004, 8, 13, 12, 35, 50, 348);
    ((Control) this.dtValidThru).Location = new Point(128 /*0x80*/, 153);
    this.dtValidThru.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtValidThru).Name = "dtValidThru";
    ((Control) this.dtValidThru).Size = new Size(105, 20);
    ((Control) this.dtValidThru).TabIndex = 7;
    ((UltraControlBase) this.dtValidThru).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtValidThru).UseOsThemes = (DefaultableBoolean) 2;
    this.dtValidThru.Value = (object) new DateTime(2004, 8, 13, 12, 35, 50, 348);
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(11, 30);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(107, 13);
    this.Label5.TabIndex = 26;
    this.Label5.Text = "Producer / Contacts:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.cboContacts.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboContacts).DataSource = (object) this.dsReqs.tblProducerContacts;
    ((UltraDropDownBase) this.cboContacts).DisplayMember = "Name";
    this.cboContacts.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboContacts).DropDownWidth = 450;
    ((Control) this.cboContacts).Location = new Point(128 /*0x80*/, 26);
    this.cboContacts.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboContacts).Name = "cboContacts";
    ((Control) this.cboContacts).Size = new Size(491, 21);
    ((Control) this.cboContacts).TabIndex = 0;
    ((UltraControlBase) this.cboContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboContacts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboContacts).ValueMember = "ProducerContactGUID";
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolNum).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.txtPolNum).BackColor = Color.White;
    ((Control) this.txtPolNum).DataBindings.Add(new Binding("Text", (object) this.dsReqs, "tblProducerRequirements.PolicyNo", true));
    ((Control) this.txtPolNum).Location = new Point(128 /*0x80*/, 103);
    ((TextEditorControlBase) this.txtPolNum).MaxLength = 20;
    this.txtPolNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPolNum).Name = "txtPolNum";
    ((Control) this.txtPolNum).Size = new Size(100, 20);
    ((Control) this.txtPolNum).TabIndex = 3;
    ((UltraControlBase) this.txtPolNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolNum).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(36, 107);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(49, 13);
    this.Label4.TabIndex = 6;
    this.Label4.Text = "Policy #:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCarrier).Appearance = (AppearanceBase) appearance25;
    ((TextEditorControlBase) this.txtCarrier).BackColor = Color.White;
    ((Control) this.txtCarrier).DataBindings.Add(new Binding("Text", (object) this.dsReqs, "tblProducerRequirements.Carrier", true));
    ((Control) this.txtCarrier).Location = new Point(128 /*0x80*/, 78);
    ((TextEditorControlBase) this.txtCarrier).MaxLength = 50;
    this.txtCarrier.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCarrier).Name = "txtCarrier";
    ((Control) this.txtCarrier).Size = new Size(491, 20);
    ((Control) this.txtCarrier).TabIndex = 2;
    ((UltraControlBase) this.txtCarrier).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCarrier).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(36, 82);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(44, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Carrier:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(36, 157);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(58, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Valid Thru:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.cboReqs.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboReqs).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.ProducerRequirementListID", true));
    ((UltraGridBase) this.cboReqs).DataSource = (object) this.dsReqs.lstProducerRequirements;
    ((UltraDropDownBase) this.cboReqs).DisplayMember = "Description";
    this.cboReqs.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboReqs).Location = new Point(128 /*0x80*/, 52);
    this.cboReqs.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboReqs).Name = "cboReqs";
    ((Control) this.cboReqs).Size = new Size(491, 21);
    ((Control) this.cboReqs).TabIndex = 1;
    ((UltraControlBase) this.cboReqs).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboReqs).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboReqs).ValueMember = "ProducerRequirementListID";
    ((Control) this.lblProducerLocation).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance26).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblProducerLocation).Appearance = (AppearanceBase) appearance26;
    ((Control) this.lblProducerLocation).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblProducerLocation).Location = new Point(12, 5);
    ((Control) this.lblProducerLocation).Name = "lblProducerLocation";
    ((Control) this.lblProducerLocation).Size = new Size(676, 115);
    ((Control) this.lblProducerLocation).TabIndex = 3;
    ((ControlBase) this.lblProducerLocation).Text = "(producer location name)";
    ((ControlBase) this.lblProducerLocation).UseMnemonic = false;
    this.ep.ContainerControl = (ContainerControl) this;
    ((Control) this.dgView).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgView).DataSource = (object) this.dsReqs.tblProducerRequirements;
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Appearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.dgView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 130;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 115;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Contact";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 59;
    ultraGridColumn4.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Requirement";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 105;
    ultraGridColumn5.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Format = "d";
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Valid Through";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 128 /*0x80*/;
    ultraGridColumn6.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 148;
    ultraGridColumn7.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 76;
    ultraGridColumn8.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance28;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance29).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Policy Limit";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 105;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 64 /*0x40*/;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 197;
    ultraGridColumn11.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Signed as Of";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Width = 82;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 179;
    ultraGridColumn13.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Name 1099";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Width = 85;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Num 1099";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 78;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 58;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 61;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 63 /*0x3F*/;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 61;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn19.Format = "c";
    ((HeaderBase) ultraGridColumn19.Header).Caption = "EO Premium";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 96 /*0x60*/;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 60;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 73;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 64 /*0x40*/;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 111;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 109;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 85;
    ultraGridBand1.Columns.AddRange(new object[25]
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
      (object) ultraGridColumn25
    });
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance31.BackColor = Color.LightSteelBlue;
    appearance31.FontData.SizeInPoints = 10f;
    appearance31.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance31;
    appearance32.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance33.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance35.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance35;
    appearance36.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance37.BackColor = Color.Transparent;
    appearance37.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance37;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgView).Location = new Point(14, 35);
    ((Control) this.dgView).Name = "dgView";
    ((Control) this.dgView).Size = new Size(731, 194);
    ((Control) this.dgView).TabIndex = 209;
    ((UltraControlBase) this.dgView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgView).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(633, 651);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 1;
    ((UltraGridBase) this.ddRequirements).DataSource = (object) this.dsReqs.lstProducerRequirements;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 0;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 1;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28
    });
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 0;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 1;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 2;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 3;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 4;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 5;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 6;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 7;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 8;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 9;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 10;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 11;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 12;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 13;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 14;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 15;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 17;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 18;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 23;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 24;
    ultraGridBand3.Columns.AddRange(new object[25]
    {
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
    ((UltraGridBase) this.ddRequirements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddRequirements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddRequirements).DisplayMember = "Description";
    ((Control) this.ddRequirements).Location = new Point(175, 115);
    ((Control) this.ddRequirements).Name = "ddRequirements";
    ((Control) this.ddRequirements).Size = new Size(147, 56);
    ((Control) this.ddRequirements).TabIndex = 211;
    ((UltraDropDownBase) this.ddRequirements).ValueMember = "ProducerRequirementListID";
    ((Control) this.ddRequirements).Visible = false;
    ((UltraGridBase) this.ddContacts).DataSource = (object) this.dsReqs.tblProducerContacts;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 0;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 1;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn54,
      (object) ultraGridColumn55
    });
    ((UltraGridBase) this.ddContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddContacts).DisplayMember = "Name";
    ((Control) this.ddContacts).Location = new Point(408, 115);
    ((Control) this.ddContacts).Name = "ddContacts";
    ((Control) this.ddContacts).Size = new Size(140, 56);
    ((Control) this.ddContacts).TabIndex = 212;
    ((UltraDropDownBase) this.ddContacts).ValueMember = "ProducerContactGUID";
    ((Control) this.ddContacts).Visible = false;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaDateTimePicker1.Appearance = (AppearanceBase) appearance38;
    appearance39.AlphaLevel = (short) 14;
    appearance39.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance39.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance39.BackColorAlpha = (Alpha) 2;
    appearance39.BackGradientAlignment = (GradientAlignment) 4;
    appearance39.BackGradientStyle = (GradientStyle) 5;
    appearance39.BorderAlpha = (Alpha) 1;
    appearance39.BorderColor = Color.FromArgb(78, 122, 171);
    appearance39.ForeColor = Color.FromArgb(49, 85, 153);
    appearance39.ForegroundAlpha = (Alpha) 2;
    this.MgaDateTimePicker1.ButtonAppearance = (AppearanceBase) appearance39;
    ((Control) this.MgaDateTimePicker1).DataBindings.Add(new Binding("Value", (object) this.dsReqs, "tblProducerRequirements.ValidThrough", true));
    this.MgaDateTimePicker1.DateTime = new DateTime(2004, 8, 13, 12, 35, 50, 348);
    ((Control) this.MgaDateTimePicker1).Location = new Point(98, 192 /*0xC0*/);
    this.MgaDateTimePicker1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaDateTimePicker1).Name = "MgaDateTimePicker1";
    ((Control) this.MgaDateTimePicker1).Size = new Size(105, 19);
    ((Control) this.MgaDateTimePicker1).TabIndex = 35;
    ((UltraControlBase) this.MgaDateTimePicker1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker1).UseOsThemes = (DefaultableBoolean) 2;
    this.MgaDateTimePicker1.Value = (object) new DateTime(2004, 8, 13, 12, 35, 50, 348);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(764, 696);
    this.Controls.Add((Control) this.ddContacts);
    this.Controls.Add((Control) this.ddRequirements);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.dgView);
    this.Controls.Add((Control) this.lblProducerLocation);
    this.Controls.Add((Control) this.gbEntry);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmProducerRequirements);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Producer Requirements";
    this.dsReqs.EndInit();
    ((ISupportInitialize) this.gbEntry).EndInit();
    ((Control) this.gbEntry).ResumeLayout(false);
    ((Control) this.gbEntry).PerformLayout();
    ((ISupportInitialize) this.chkPromptOnQuote).EndInit();
    ((ISupportInitialize) this.txtRightSignatureRefNum).EndInit();
    ((ISupportInitialize) this.dtpDocumentRequestedOn).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor3).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor2).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    ((ISupportInitialize) this.MgaEOPremium).EndInit();
    ((ISupportInitialize) this.chkNeededtoIssue).EndInit();
    ((ISupportInitialize) this.chkNeededtoQuote).EndInit();
    ((ISupportInitialize) this.chkNeededtoBind).EndInit();
    ((ISupportInitialize) this.chkNeededToClear).EndInit();
    ((ISupportInitialize) this.txtNum1099).EndInit();
    ((ISupportInitialize) this.txtName1099).EndInit();
    ((ISupportInitialize) this.dtpSignedAsOf).EndInit();
    ((ISupportInitialize) this.cboUsers).EndInit();
    ((ISupportInitialize) this.cbOnFile).EndInit();
    ((ISupportInitialize) this.UltraNumericEditor1).EndInit();
    ((ISupportInitialize) this.dtValidThru).EndInit();
    ((ISupportInitialize) this.cboContacts).EndInit();
    ((ISupportInitialize) this.txtPolNum).EndInit();
    ((ISupportInitialize) this.txtCarrier).EndInit();
    ((ISupportInitialize) this.cboReqs).EndInit();
    ((ISupportInitialize) this.ep).EndInit();
    ((ISupportInitialize) this.dgView).EndInit();
    ((ISupportInitialize) this.ddRequirements).EndInit();
    ((ISupportInitialize) this.ddContacts).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker1).EndInit();
    this.ResumeLayout(false);
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.dsReqs, this.dsReqs.tblProducerRequirements.TableName];
  }

  public Guid ProducerLocationGuid => this._producerLocationGUID;

  public Guid ProducerGuid => this._producerGUID;

  public int bmb_Position => this.bmb.Position;

  public frmProducerRequirements()
  {
    this.Load += new EventHandler(this.frmProducerRequirements_Load);
    this.InitializeComponent();
  }

  public frmProducerRequirements(Guid producerLocationGUID, string locationName)
  {
    this.Load += new EventHandler(this.frmProducerRequirements_Load);
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._producerLocationGUID = producerLocationGUID;
    ((ControlBase) this.lblProducerLocation).Text = locationName;
  }

  private void frmProducerRequirements_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((UltraControlBase) this.dgView).DrawFilter = (IUIElementDrawFilter) this;
    ProducerLocation producerLocation = new ProducerLocation(this._producerLocationGUID);
    Producer producer = new Producer(producerLocation.ProducerGuid);
    this._producerGUID = producerLocation.ProducerGuid;
    dsProducerRequirements.tblProducerContactsRow row1 = this.dsReqs.tblProducerContacts.NewtblProducerContactsRow();
    row1.ProducerContactGUID = this._producerGUID;
    this._producerName = producer.ProducerName + " (Producer)";
    row1.Name = this._producerName;
    this.dsReqs.tblProducerContacts.AddtblProducerContactsRow(row1);
    dsProducerRequirements.tblProducerContactsRow row2 = this.dsReqs.tblProducerContacts.NewtblProducerContactsRow();
    row2.ProducerContactGUID = this._producerLocationGUID;
    this._locationName = ((ControlBase) this.lblProducerLocation).Text + "(Current Producer Location)";
    row2.Name = this._locationName;
    this.dsReqs.tblProducerContacts.AddtblProducerContactsRow(row2);
    DefaultDatabase.LoadDataSet((DataSet) this.dsReqs, new string[4]
    {
      "tblProducerContacts",
      "tblUsers",
      "lstProducerRequirements",
      "tblProducerRequirements"
    }, "spGetProducerRequirements", new object[4]
    {
      (object) "@producerGuid",
      (object) this._producerGUID,
      (object) "@producerLocationGUID",
      (object) this._producerLocationGUID
    });
    this.dbSave.UIState = this.dsReqs.tblProducerRequirements.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    this.AfterBaseFormLoad();
    this.bmb.PositionChanged += new EventHandler(this.bmb_PositionChanged);
  }

  protected virtual void AfterSave()
  {
  }

  protected virtual void ShowClientData(int ID)
  {
  }

  protected virtual void ClientSaveData(SqlTransaction trans, int ID)
  {
  }

  protected virtual void AfterBaseFormLoad()
  {
  }

  protected virtual void ClientClickNew()
  {
  }

  private void bmb_PositionChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    this.ShowClientData(this.dsReqs.tblProducerRequirements[this.bmb.Position].ProducerRequirementsID);
  }

  private dsProducerRequirements.tblProducerRequirementsRow GetDr()
  {
    dsProducerRequirements.tblProducerRequirementsRow producerRequirement = this.dsReqs.tblProducerRequirements[this.bmb.Position];
    producerRequirement.SetProducerLocationGUIDNull();
    producerRequirement.SetProducerGUIDNull();
    if (this.cboContacts.Value != DBNull.Value)
    {
      Guid guid = (Guid) this.cboContacts.Value;
      if (!guid.Equals(this._producerLocationGUID) && !guid.Equals(this._producerGUID))
        producerRequirement.ProducerContactGUID = guid;
      else
        producerRequirement.SetProducerContactGUIDNull();
    }
    else
      producerRequirement.SetProducerContactGUIDNull();
    producerRequirement.ProducerRequirementListID = Conversions.ToInteger(this.cboReqs.Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtCarrier).Text, string.Empty, false) != 0)
      producerRequirement.Carrier = ((TextEditorControlBase) this.txtCarrier).Text;
    else
      producerRequirement.SetCarrierNull();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtPolNum).Text, string.Empty, false) != 0)
      producerRequirement.PolicyNo = ((TextEditorControlBase) this.txtPolNum).Text;
    else
      producerRequirement.SetPolicyNoNull();
    if (Information.IsDate(RuntimeHelpers.GetObjectValue(this.dtValidThru.Value)))
      producerRequirement.ValidThrough = this.dtValidThru.DateTime;
    else
      producerRequirement.SetValidThroughNull();
    if (Information.IsDate(RuntimeHelpers.GetObjectValue(this.dtpSignedAsOf.Value)))
      producerRequirement.SignedAsOf = this.dtpSignedAsOf.DateTime;
    else
      producerRequirement.SetSignedAsOfNull();
    producerRequirement.OnFile = ((UltraToggleEditorBase) this.cbOnFile).Checked;
    if (producerRequirement.IsProducerContactGUIDNull())
    {
      if (this.cboContacts.Text.Equals(this._locationName))
        producerRequirement.ProducerLocationGUID = this._producerLocationGUID;
      else
        producerRequirement.ProducerGUID = this._producerGUID;
    }
    producerRequirement.NeededToBind = ((UltraToggleEditorBase) this.chkNeededtoBind).Checked;
    producerRequirement.NeededToClear = ((UltraToggleEditorBase) this.chkNeededToClear).Checked;
    producerRequirement.NeededToIssue = ((UltraToggleEditorBase) this.chkNeededtoIssue).Checked;
    producerRequirement.NeededToQuote = ((UltraToggleEditorBase) this.chkNeededtoQuote).Checked;
    return producerRequirement;
  }

  protected virtual bool ValidForm()
  {
    bool flag = true;
    if (((UltraDropDownBase) this.cboReqs).SelectedRow == null)
    {
      this.ep.SetError((Control) this.cboReqs, "Please select a requirement.");
      flag = false;
    }
    else
      this.ep.SetError((Control) this.cboReqs, string.Empty);
    if (this.cboContacts.Text.Length == 0)
    {
      this.ep.SetError((Control) this.cboContacts, "Please select an entry.");
      flag = false;
    }
    else
      this.ep.SetError((Control) this.cboContacts, string.Empty);
    return flag;
  }

  private void AssignTransaction(DbDataAdapter da, DbTransaction trans)
  {
    da.SelectCommand.Transaction = trans;
    da.InsertCommand.Transaction = trans;
    da.DeleteCommand.Transaction = trans;
    da.UpdateCommand.Transaction = trans;
  }

  private void SetActiveGridRow(int ID)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgView).Rows)
    {
      if (Conversions.ToInteger(row.Cells["ProducerRequirementsID"].Value) == ID)
      {
        ((UltraGridBase) this.dgView).ActiveRow = row;
        break;
      }
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      SqlTransaction trans = (SqlTransaction) null;
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        this.GetDr();
        this.bmb.EndCurrentEdit();
        this.cnSQL.Open();
        trans = this.cnSQL.BeginTransaction();
        this.AssignTransaction((DbDataAdapter) this.daProducerReqs, (DbTransaction) trans);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daProducerReqs, (DataTable) this.dsReqs.tblProducerRequirements);
        this.ClientSaveData(trans, this.dsReqs.tblProducerRequirements[this.bmb.Position].ProducerRequirementsID);
        trans.Commit();
        this.cnSQL.Close();
        this.AfterSave();
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (trans != null)
        {
          try
          {
            trans.Rollback();
          }
          catch (InvalidOperationException ex3)
          {
            ProjectData.SetProjectError((Exception) ex3);
            ProjectData.ClearProjectError();
          }
        }
        this.cnSQL.Close();
        ErrorHandler.HandleError((Exception) ex2);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex4)
      {
        ProjectData.SetProjectError(ex4);
        Exception ex5 = ex4;
        trans?.Rollback();
        this.cnSQL.Close();
        ErrorHandler.HandleError(ex5);
        ProjectData.ClearProjectError();
      }
      finally
      {
        trans?.Dispose();
        this.cnSQL.Close();
        this.Cursor = MgaCursors.Default;
      }
      this.SetActiveGridRow(this.dsReqs.tblProducerRequirements[this.bmb.Position].ProducerRequirementsID);
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    try
    {
      this.dsReqs.tblProducerRequirements[this.bmb.Position].Delete();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daProducerReqs, (DataTable) this.dsReqs.tblProducerRequirements);
      this.dbSave.UIState = this.dsReqs.tblProducerRequirements.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("The row could not be deleted.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    if (this.bmb.Position != -1)
      this.SetActiveGridRow(this.dsReqs.tblProducerRequirements[this.bmb.Position].ProducerRequirementsID);
    this.dgView_AfterRowActivate((object) null, (EventArgs) null);
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    dsProducerRequirements.tblProducerRequirementsRow row = this.dsReqs.tblProducerRequirements.NewtblProducerRequirementsRow();
    row.ValidThrough = DateAndTime.Now;
    this.dsReqs.tblProducerRequirements.AddtblProducerRequirementsRow(row);
    this.bmb.Position = this.dsReqs.tblProducerRequirements.Rows.Count - 1;
    try
    {
      foreach (Control control in ((Control) this.gbEntry).Controls)
      {
        if (control is MGASimpleComboBox)
          ((UltraDropDownBase) control).SelectedRow = (UltraGridRow) null;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.ClientClickNew();
  }

  protected virtual void dgView_AfterRowActivate(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1 || ((UltraGridBase) this.dgView).ActiveRow == null)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgView).ActiveRow.Cells["ProducerRequirementsID"].Value), this.dsReqs.tblProducerRequirements.ProducerRequirementsIDColumn.ColumnName, (DataTable) this.dsReqs.tblProducerRequirements, this.bmb);
    if (!this.dsReqs.tblProducerRequirements[this.bmb.Position].IsProducerRequirementListIDNull())
      this._CurrentRequirementID = this.dsReqs.tblProducerRequirements[this.bmb.Position].ProducerRequirementsID;
    if (!this.dsReqs.tblProducerRequirements[this.bmb.Position].IsProducerContactGUIDNull())
      this.cboContacts.Value = (object) this.dsReqs.tblProducerRequirements[this.bmb.Position].ProducerContactGUID;
    else if (!this.dsReqs.tblProducerRequirements[this.bmb.Position].IsProducerGUIDNull())
    {
      this.cboContacts.Value = (object) this.dsReqs.tblProducerRequirements[this.bmb.Position].ProducerGUID;
    }
    else
    {
      if (this.dsReqs.tblProducerRequirements[this.bmb.Position].IsProducerLocationGUIDNull())
        return;
      this.cboContacts.Value = (object) this.dsReqs.tblProducerRequirements[this.bmb.Position].ProducerLocationGUID;
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.dgView).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.gbEntry).Enabled = this.dbSave.UIState == UIState.Editing;
    if (this.dbSave.UIState == UIState.Editing)
      return;
    if (this.dsReqs.tblProducerRequirements.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.dsReqs.tblProducerRequirements.RejectChanges();
    try
    {
      foreach (Control control in ((Control) this.gbEntry).Controls)
        this.ep.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.dgView_AfterRowActivate((object) null, (EventArgs) null);
  }

  protected virtual void RequirementsValueChanged(object sender, EventArgs e)
  {
  }

  private void cboReqs_ValueChanged(object sender, EventArgs e)
  {
    this.RequirementsValueChanged(RuntimeHelpers.GetObjectValue(sender), e);
  }

  public bool DrawElement(DrawPhase drawPhase, ref UIElementDrawParams drawParams)
  {
    bool flag;
    if (drawPhase == 128 /*0x80*/)
    {
      if (((UIElementDrawParams) ref drawParams).Element is HeaderUIElement)
      {
        if (((HeaderBase) ((UIElementDrawParams) ref drawParams).Element.GetContext(typeof (HeaderBase))).Caption.Length > 0)
          ((UIElementDrawParams) ref drawParams).DrawBorders((UIElementBorderStyle) 4, Border3DSide.Right);
        flag = true;
      }
      else
        flag = false;
    }
    else
      flag = true;
    return flag;
  }

  public DrawPhase GetPhasesToFilter(ref UIElementDrawParams drawParams) => (DrawPhase) 32896;
}
