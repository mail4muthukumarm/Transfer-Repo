// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Commissions.frmAdminCommissions
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.Policies.Commissions;

[SecureResource("{D16801AA-6657-49B9-9E8B-D24F265F719D}", "Allow Edit of Global Commissions", "Allows users to edit global commissions.", "Commissions")]
[SecureResource("{B22FFF0D-C146-453D-AC26-FA29557D10B6}", "Allow Addition of Global Commissions", "Allows users to add global commissions.", "Commissions")]
[SecureResource("{6109BC05-9041-4F46-9915-12E4B7942E81}", "Allow Deletion of Global Commissions", "Allows users to delete global commissions.", "Commissions")]
public class frmAdminCommissions : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private MGASimpleComboBox cboCompany;
  private MGASimpleComboBox cboProducerLocation;
  private MGASimpleComboBox cboState;
  private MGASimpleComboBox cboLine;
  private dsAdminCommissions ds;
  private DbDataAdapter daComm;
  private DbConnection cnDB;
  private ErrorProvider err;
  private DbDataAdapter daView;
  private DbCommand DbSelectCommand2;
  private MGASimpleComboBox cboOffices;
  private Label Label5;
  private MGASimpleComboBox cboInHouseProducers;
  private Label Label6;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private ToolTip ToolTip1;
  private DbDataAdapter daLoadData;
  private DbCommand DbSelectCommand3;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private MGASimpleComboBox cboUnderwriter;
  private MGASimpleComboBox cboIssuingOffice;
  private MGASimpleComboBox cboPolicyType;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private Label Label10;
  private DataView dvOffices;
  private DataView dvIssuingOffices;
  private DataView dvUsers;
  private DataView dvUnderwriters;
  private MGACheckBox chkRenewals;
  private MGADateTimePicker dtEffective;
  private MemoryStream _gridLayout;
  private bool _canEdit;
  private bool _canAdd;
  private bool _canDelete;
  public const string EditCommissions = "{D16801AA-6657-49B9-9E8B-D24F265F719D}";
  public const string AddCommissions = "{B22FFF0D-C146-453D-AC26-FA29557D10B6}";
  public const string DeleteCommissions = "{6109BC05-9041-4F46-9915-12E4B7942E81}";

  public frmAdminCommissions()
  {
    this.Load += new EventHandler(this.frmAdminCommissions_Load);
    this._gridLayout = new MemoryStream();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.ClickingEdit -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.ClickingEdit += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("dgComm")]
  protected virtual UltraGrid dgComm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ctlEntity")]
  private virtual AddCommissionableEntity ctlEntity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnDown
  {
    get => this._btnDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDown_Click);
      MGAButton btnDown1 = this._btnDown;
      if (btnDown1 != null)
        ((Control) btnDown1).Click -= eventHandler;
      this._btnDown = value;
      MGAButton btnDown2 = this._btnDown;
      if (btnDown2 == null)
        return;
      ((Control) btnDown2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnUp
  {
    get => this._btnUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUp_Click);
      MGAButton btnUp1 = this._btnUp;
      if (btnUp1 != null)
        ((Control) btnUp1).Click -= eventHandler;
      this._btnUp = value;
      MGAButton btnUp2 = this._btnUp;
      if (btnUp2 == null)
        return;
      ((Control) btnUp2).Click += eventHandler;
    }
  }

  protected virtual LinkLabel lnkAdminCommissionsReport
  {
    get => this._lnkAdminCommissionsReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAdminCommissionsReport_LinkClicked);
      LinkLabel commissionsReport1 = this._lnkAdminCommissionsReport;
      if (commissionsReport1 != null)
        commissionsReport1.LinkClicked -= clickedEventHandler;
      this._lnkAdminCommissionsReport = value;
      LinkLabel commissionsReport2 = this._lnkAdminCommissionsReport;
      if (commissionsReport2 == null)
        return;
      commissionsReport2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDisabled")]
  private virtual MGADateTimePicker dtDisabled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducer")]
  private virtual MGASimpleComboBox cboProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numApplyPremiumEqualOrLess")]
  private virtual MGANumericEditor numApplyPremiumEqualOrLess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numApplyPremiumEqualOrOver")]
  private virtual MGANumericEditor numApplyPremiumEqualOrOver { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPremiumLessThanEqualTo")]
  private virtual Label lblPremiumLessThanEqualTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPremiumGreaterEqualTo")]
  private virtual Label lblPremiumGreaterEqualTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    UltraGridBand ultraGridBand = new UltraGridBand("viewAdminCommissions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Producer", -1, (object) null, 104460157, 3, 0);
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Line", -1, (object) null, 104460157, 2, 0);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("State", -1, (object) null, 104460157, 1, 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Company", -1, (object) null, 104460157, 0, 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Entity", -1, (object) null, 104460157, 5, 1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("EntityType", -1, (object) null, 104460157, 6, 1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CommissionType", -1, (object) null, 104460157, 7, 1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Percentage", -1, (object) null, 104460157, 8, 1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("FlatAmount", -1, (object) null, 104460157, 9, 1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ChargeName", -1, (object) null, 104460157, 4, 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CommissionsFromOperatingAccount");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Hierarchy");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Effective", -1, (object) null, 104460157, 10, 1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("DisabledDate", -1, (object) null, 104460157, 11, 1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("CompanyGUID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("LineGUID");
    UltraGridGroup ultraGridGroup = new UltraGridGroup("NewGroup0", 104460157);
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminCommissions));
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance11 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.cboProducer = new MGASimpleComboBox();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.dtDisabled = new MGADateTimePicker();
    this.chkRenewals = new MGACheckBox();
    this.Label10 = new Label();
    this.dtEffective = new MGADateTimePicker();
    this.Label7 = new Label();
    this.cboUnderwriter = new MGASimpleComboBox();
    this.Label8 = new Label();
    this.cboIssuingOffice = new MGASimpleComboBox();
    this.Label9 = new Label();
    this.cboPolicyType = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.cboCompany = new MGASimpleComboBox();
    this.cboProducerLocation = new MGASimpleComboBox();
    this.cboState = new MGASimpleComboBox();
    this.cboLine = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.cboOffices = new MGASimpleComboBox();
    this.Label6 = new Label();
    this.cboInHouseProducers = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.ctlEntity = new AddCommissionableEntity();
    this.lnkAdminCommissionsReport = new LinkLabel();
    this.dgComm = new UltraGrid();
    this.ds = new dsAdminCommissions();
    this.daComm = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.cnDB = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.err = new ErrorProvider(this.components);
    this.daView = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.ToolTip1 = new ToolTip(this.components);
    this.btnUp = new MGAButton();
    this.btnDown = new MGAButton();
    this.daLoadData = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.dvOffices = new DataView();
    this.dvIssuingOffices = new DataView();
    this.dvUsers = new DataView();
    this.dvUnderwriters = new DataView();
    this.lblPremiumLessThanEqualTo = new Label();
    this.lblPremiumGreaterEqualTo = new Label();
    this.numApplyPremiumEqualOrLess = new MGANumericEditor();
    this.numApplyPremiumEqualOrOver = new MGANumericEditor();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.cboProducer).BeginInit();
    ((ISupportInitialize) this.dtDisabled).BeginInit();
    ((ISupportInitialize) this.chkRenewals).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.cboUnderwriter).BeginInit();
    ((ISupportInitialize) this.cboIssuingOffice).BeginInit();
    ((ISupportInitialize) this.cboPolicyType).BeginInit();
    ((ISupportInitialize) this.cboCompany).BeginInit();
    ((ISupportInitialize) this.cboProducerLocation).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((ISupportInitialize) this.cboOffices).BeginInit();
    ((ISupportInitialize) this.cboInHouseProducers).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.dgComm).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.btnUp).BeginInit();
    ((ISupportInitialize) this.btnDown).BeginInit();
    this.dvOffices.BeginInit();
    this.dvIssuingOffices.BeginInit();
    this.dvUsers.BeginInit();
    this.dvUnderwriters.BeginInit();
    ((ISupportInitialize) this.numApplyPremiumEqualOrLess).BeginInit();
    ((ISupportInitialize) this.numApplyPremiumEqualOrOver).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboProducer);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtDisabled);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkRenewals);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtEffective);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboUnderwriter);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboIssuingOffice);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboPolicyType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboCompany);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboProducerLocation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboState);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboLine);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboOffices);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboInHouseProducers);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(495, 365);
    ((UltraCombo) this.cboProducer).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboProducer).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducer).Location = new Point(119, 34);
    this.cboProducer.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboProducer).Name = "cboProducer";
    ((Control) this.cboProducer).Size = new Size(336, 21);
    ((Control) this.cboProducer).TabIndex = 1;
    ((UltraControlBase) this.cboProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducer).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(53, 36);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(54, 13);
    this.Label12.TabIndex = 23;
    this.Label12.Text = "Producer:";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(30, 305);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(77, 13);
    this.Label11.TabIndex = 22;
    this.Label11.Text = "Disabled Date:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtDisabled).Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtDisabled).ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtDisabled).Location = new Point(119, 302);
    this.dtDisabled.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtDisabled).Name = "dtDisabled";
    ((Control) this.dtDisabled).Size = new Size(91, 20);
    ((Control) this.dtDisabled).TabIndex = 11;
    ((UltraControlBase) this.dtDisabled).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDisabled).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRenewals).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkRenewals).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRenewals).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRenewals).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRenewals).Location = new Point(119, 328);
    this.chkRenewals.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkRenewals).Name = "chkRenewals";
    ((Control) this.chkRenewals).Size = new Size(238, 20);
    ((Control) this.chkRenewals).TabIndex = 12;
    ((UltraToggleEditorBase) this.chkRenewals).Text = "Renewals Only When Previously Applied";
    this.ToolTip1.SetToolTip((Control) this.chkRenewals, "Limit application of commission on renewal to accounts where the entity was previously commissioned.");
    ((UltraControlBase) this.chkRenewals).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRenewals).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(55, 278);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(54, 13);
    this.Label10.TabIndex = 19;
    this.Label10.Text = "Effective:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEffective).Appearance = (AppearanceBase) appearance4;
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
    ((UltraDateTimeEditor) this.dtEffective).ButtonAppearance = (AppearanceBase) appearance5;
    ((Control) this.dtEffective).Location = new Point(119, 276);
    this.dtEffective.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(91, 20);
    ((Control) this.dtEffective).TabIndex = 10;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(39, 192 /*0xC0*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(68, 13);
    this.Label7.TabIndex = 12;
    this.Label7.Text = "Underwriter:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboUnderwriter).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboUnderwriter).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUnderwriter).Location = new Point(119, 192 /*0xC0*/);
    this.cboUnderwriter.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboUnderwriter).Name = "cboUnderwriter";
    ((Control) this.cboUnderwriter).Size = new Size(336, 21);
    ((Control) this.cboUnderwriter).TabIndex = 7;
    ((UltraControlBase) this.cboUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(29, 220);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(77, 13);
    this.Label8.TabIndex = 14;
    this.Label8.Text = "Issuing Office:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboIssuingOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboIssuingOffice).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboIssuingOffice).Location = new Point(119, 220);
    this.cboIssuingOffice.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboIssuingOffice).Name = "cboIssuingOffice";
    ((Control) this.cboIssuingOffice).Size = new Size(336, 21);
    ((Control) this.cboIssuingOffice).TabIndex = 8;
    ((UltraControlBase) this.cboIssuingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIssuingOffice).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(41, 248);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(65, 13);
    this.Label9.TabIndex = 16 /*0x10*/;
    this.Label9.Text = "Policy Type:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboPolicyType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboPolicyType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPolicyType).Location = new Point(119, 248);
    this.cboPolicyType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboPolicyType).Name = "cboPolicyType";
    ((Control) this.cboPolicyType).Size = new Size(336, 21);
    ((Control) this.cboPolicyType).TabIndex = 9;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(77, 111);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(30, 13);
    this.Label4.TabIndex = 3;
    this.Label4.Text = "Line:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboCompany).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboCompany).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompany).Location = new Point(119, 7);
    this.cboCompany.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboCompany).Name = "cboCompany";
    ((Control) this.cboCompany).Size = new Size(336, 21);
    ((Control) this.cboCompany).TabIndex = 0;
    ((UltraControlBase) this.cboCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboProducerLocation).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboProducerLocation).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerLocation).Location = new Point(119, 56);
    this.cboProducerLocation.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboProducerLocation).Name = "cboProducerLocation";
    ((Control) this.cboProducerLocation).Size = new Size(336, 21);
    ((Control) this.cboProducerLocation).TabIndex = 2;
    ((UltraControlBase) this.cboProducerLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboState).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboState).Location = new Point(119, 83);
    this.cboState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(336, 21);
    ((Control) this.cboState).TabIndex = 3;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboLine).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboLine).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLine).Location = new Point(119, 109);
    this.cboLine.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(336, 21);
    ((Control) this.cboLine).TabIndex = 4;
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(69, 137);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(40, 13);
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Office:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboOffices).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboOffices).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOffices).Location = new Point(119, 135);
    this.cboOffices.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboOffices).Name = "cboOffices";
    ((Control) this.cboOffices).Size = new Size(336, 21);
    ((Control) this.cboOffices).TabIndex = 5;
    ((UltraControlBase) this.cboOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffices).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(4, 163);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(101, 13);
    this.Label6.TabIndex = 10;
    this.Label6.Text = "In-House Producer:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboInHouseProducers).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboInHouseProducers).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInHouseProducers).Location = new Point(119, 161);
    this.cboInHouseProducers.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInHouseProducers).Name = "cboInHouseProducers";
    ((Control) this.cboInHouseProducers).Size = new Size(336, 21);
    ((Control) this.cboInHouseProducers).TabIndex = 6;
    ((UltraControlBase) this.cboInHouseProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInHouseProducers).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(50, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Company:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(97, 13);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Producer Location:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(72, 85);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(37, 13);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "State:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(363, 332);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 39);
    ((Control) this.dbSave).TabIndex = 13;
    this.dbSave.UIState = (UIState) 1;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.ctlEntity);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(495, 365);
    this.ctlEntity.BackColor = Color.Transparent;
    this.ctlEntity.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ctlEntity.Location = new Point(7, 7);
    this.ctlEntity.Name = "ctlEntity";
    this.ctlEntity.ShowMinimumIncomeTab = true;
    this.ctlEntity.Size = new Size(357, 224 /*0xE0*/);
    this.ctlEntity.TabIndex = 4;
    this.lnkAdminCommissionsReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAdminCommissionsReport.BackColor = Color.Transparent;
    this.lnkAdminCommissionsReport.Location = new Point(5, 608);
    this.lnkAdminCommissionsReport.Name = "lnkAdminCommissionsReport";
    this.lnkAdminCommissionsReport.Size = new Size(67, 16 /*0x10*/);
    this.lnkAdminCommissionsReport.TabIndex = 21;
    this.lnkAdminCommissionsReport.TabStop = true;
    this.lnkAdminCommissionsReport.Text = "View Report";
    ((Control) this.dgComm).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgComm).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgComm).DataSource = (object) this.ds.viewAdminCommissions;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgComm).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgComm).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Width = 105;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Width = 91;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Width = 71;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Width = 347;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Width = 185;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Width = 46;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Width = 68;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Format = "#,##0.00## %";
    ultraGridColumn8.Width = 95;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Format = "c";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Flat";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Width = 184;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 12;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Prem/Fee";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Width = 172;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 13;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 14;
    ultraGridColumn14.Width = 73;
    ultraGridColumn15.Width = 135;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridBand.Columns.AddRange(new object[19]
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
      (object) ultraGridColumn19
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup).Key = "NewGroup0";
    ultraGridBand.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup
    });
    ultraGridBand.LevelCount = 2;
    ((UltraGridBase) this.dgComm).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgComm).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowSpacingAfter = 5;
    appearance10.BackColor = Color.White;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((Control) this.dgComm).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgComm).Location = new Point(7, 7);
    ((Control) this.dgComm).Name = "dgComm";
    ((Control) this.dgComm).Size = new Size(788, 198);
    ((Control) this.dgComm).TabIndex = 2;
    ((UltraControlBase) this.dgComm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgComm).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminCommissions";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daComm.DeleteCommand = this.DbDeleteCommand1;
    this.daComm.InsertCommand = this.DbInsertCommand1;
    this.daComm.SelectCommand = this.DbSelectCommand1;
    this.daComm.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblAdminCommissions", new DataColumnMapping[29]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("EntityGuid", "EntityGuid"),
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("EntityTypeID", "EntityTypeID"),
        new DataColumnMapping("CommissionTypeID", "CommissionTypeID"),
        new DataColumnMapping("Percentage", "Percentage"),
        new DataColumnMapping("FlatAmount", "FlatAmount"),
        new DataColumnMapping("CommissionsFromOperatingAccount", "CommissionsFromOperatingAccount"),
        new DataColumnMapping("AddedByUserID", "AddedByUserID"),
        new DataColumnMapping("InHouseProducerGuid", "InHouseProducerGuid"),
        new DataColumnMapping("OfficeLocationGuid", "OfficeLocationGuid"),
        new DataColumnMapping("CommissionOnTotalPremium", "CommissionOnTotalPremium"),
        new DataColumnMapping("MinimumFirmIncome", "MinimumFirmIncome"),
        new DataColumnMapping("IncomeBetweenStartMonth", "IncomeBetweenStartMonth"),
        new DataColumnMapping("IncomeBetweenStartDay", "IncomeBetweenStartDay"),
        new DataColumnMapping("IncomeBetweenEndMonth", "IncomeBetweenEndMonth"),
        new DataColumnMapping("IncomeBetweenEndDay", "IncomeBetweenEndDay"),
        new DataColumnMapping("Hierarchy", "Hierarchy"),
        new DataColumnMapping("UnderwriterGuid", "UnderwriterGuid"),
        new DataColumnMapping("IssuingOfficeGuid", "IssuingOfficeGuid"),
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("Effective", "Effective"),
        new DataColumnMapping("RenewalOnlyIfPreviouslyCommissioned", "RenewalOnlyIfPreviouslyCommissioned"),
        new DataColumnMapping("DisabledDate", "DisabledDate"),
        new DataColumnMapping("ProducerGUID", "ProducerGUID")
      })
    });
    this.daComm.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblAdminCommissions] WHERE (([ID] = @Original_ID))";
    this.DbDeleteCommand1.Connection = this.cnDB;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.cnDB = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cnDB;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[30]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      DefaultDatabase.CreateParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGuid"),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      DefaultDatabase.CreateParameter("@EntityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EntityGuid"),
      DefaultDatabase.CreateParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      DefaultDatabase.CreateParameter("@EntityTypeID", SqlDbType.VarChar, 2, "EntityTypeID"),
      DefaultDatabase.CreateParameter("@CommissionTypeID", SqlDbType.Char, 2, "CommissionTypeID"),
      DefaultDatabase.CreateParameter("@Percentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 9, (byte) 8, "Percentage", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@FlatAmount", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "FlatAmount", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@CommissionsFromOperatingAccount", SqlDbType.Bit, 1, "CommissionsFromOperatingAccount"),
      DefaultDatabase.CreateParameter("@AddedByUserID", SqlDbType.SmallInt, 2, "AddedByUserID"),
      DefaultDatabase.CreateParameter("@InHouseProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InHouseProducerGuid"),
      DefaultDatabase.CreateParameter("@OfficeLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeLocationGuid"),
      DefaultDatabase.CreateParameter("@CommissionOnTotalPremium", SqlDbType.Bit, 1, "CommissionOnTotalPremium"),
      DefaultDatabase.CreateParameter("@MinimumFirmIncome", SqlDbType.Int, 4, "MinimumFirmIncome"),
      DefaultDatabase.CreateParameter("@IncomeBetweenStartMonth", SqlDbType.TinyInt, 1, "IncomeBetweenStartMonth"),
      DefaultDatabase.CreateParameter("@IncomeBetweenStartDay", SqlDbType.TinyInt, 1, "IncomeBetweenStartDay"),
      DefaultDatabase.CreateParameter("@IncomeBetweenEndMonth", SqlDbType.TinyInt, 1, "IncomeBetweenEndMonth"),
      DefaultDatabase.CreateParameter("@IncomeBetweenEndDay", SqlDbType.TinyInt, 1, "IncomeBetweenEndDay"),
      DefaultDatabase.CreateParameter("@Hierarchy", SqlDbType.SmallInt, 2, "Hierarchy"),
      DefaultDatabase.CreateParameter("@UnderwriterGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UnderwriterGuid"),
      DefaultDatabase.CreateParameter("@IssuingOfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IssuingOfficeGuid"),
      DefaultDatabase.CreateParameter("@PolicyTypeID", SqlDbType.TinyInt, 1, "PolicyTypeID"),
      DefaultDatabase.CreateParameter("@Effective", SqlDbType.SmallDateTime, 4, "Effective"),
      DefaultDatabase.CreateParameter("@RenewalOnlyIfPreviouslyCommissioned", SqlDbType.Bit, 1, "RenewalOnlyIfPreviouslyCommissioned"),
      DefaultDatabase.CreateParameter("@DisabledDate", SqlDbType.DateTime, 8, "DisabledDate"),
      DefaultDatabase.CreateParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID"),
      DefaultDatabase.CreateParameter("@ApplyPremiumEqualOrOver", SqlDbType.Money, 8, "ApplyPremiumEqualOrOver"),
      DefaultDatabase.CreateParameter("@ApplyPremiumEqualOrLess", SqlDbType.Money, 8, "ApplyPremiumEqualOrLess")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Connection = this.cnDB;
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cnDB;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[32 /*0x20*/]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      DefaultDatabase.CreateParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGuid"),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      DefaultDatabase.CreateParameter("@EntityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EntityGuid"),
      DefaultDatabase.CreateParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      DefaultDatabase.CreateParameter("@EntityTypeID", SqlDbType.VarChar, 2, "EntityTypeID"),
      DefaultDatabase.CreateParameter("@CommissionTypeID", SqlDbType.Char, 2, "CommissionTypeID"),
      DefaultDatabase.CreateParameter("@Percentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 9, (byte) 8, "Percentage", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@FlatAmount", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "FlatAmount", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@CommissionsFromOperatingAccount", SqlDbType.Bit, 1, "CommissionsFromOperatingAccount"),
      DefaultDatabase.CreateParameter("@AddedByUserID", SqlDbType.SmallInt, 2, "AddedByUserID"),
      DefaultDatabase.CreateParameter("@InHouseProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InHouseProducerGuid"),
      DefaultDatabase.CreateParameter("@OfficeLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeLocationGuid"),
      DefaultDatabase.CreateParameter("@CommissionOnTotalPremium", SqlDbType.Bit, 1, "CommissionOnTotalPremium"),
      DefaultDatabase.CreateParameter("@MinimumFirmIncome", SqlDbType.Int, 4, "MinimumFirmIncome"),
      DefaultDatabase.CreateParameter("@IncomeBetweenStartMonth", SqlDbType.TinyInt, 1, "IncomeBetweenStartMonth"),
      DefaultDatabase.CreateParameter("@IncomeBetweenStartDay", SqlDbType.TinyInt, 1, "IncomeBetweenStartDay"),
      DefaultDatabase.CreateParameter("@IncomeBetweenEndMonth", SqlDbType.TinyInt, 1, "IncomeBetweenEndMonth"),
      DefaultDatabase.CreateParameter("@IncomeBetweenEndDay", SqlDbType.TinyInt, 1, "IncomeBetweenEndDay"),
      DefaultDatabase.CreateParameter("@Hierarchy", SqlDbType.SmallInt, 2, "Hierarchy"),
      DefaultDatabase.CreateParameter("@UnderwriterGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UnderwriterGuid"),
      DefaultDatabase.CreateParameter("@IssuingOfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IssuingOfficeGuid"),
      DefaultDatabase.CreateParameter("@PolicyTypeID", SqlDbType.TinyInt, 1, "PolicyTypeID"),
      DefaultDatabase.CreateParameter("@Effective", SqlDbType.SmallDateTime, 4, "Effective"),
      DefaultDatabase.CreateParameter("@RenewalOnlyIfPreviouslyCommissioned", SqlDbType.Bit, 1, "RenewalOnlyIfPreviouslyCommissioned"),
      DefaultDatabase.CreateParameter("@DisabledDate", SqlDbType.DateTime, 8, "DisabledDate"),
      DefaultDatabase.CreateParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID"),
      DefaultDatabase.CreateParameter("@ApplyPremiumEqualOrOver", SqlDbType.Money, 8, "ApplyPremiumEqualOrOver"),
      DefaultDatabase.CreateParameter("@ApplyPremiumEqualOrLess", SqlDbType.Money, 8, "ApplyPremiumEqualOrLess"),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.daView.SelectCommand = this.DbSelectCommand2;
    this.daView.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "viewAdminCommissions", new DataColumnMapping[10]
      {
        new DataColumnMapping("Producer", "Producer"),
        new DataColumnMapping("Line", "Line"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Company", "Company"),
        new DataColumnMapping("Entity", "Entity"),
        new DataColumnMapping("EntityType", "EntityType"),
        new DataColumnMapping("CommissionType", "CommissionType"),
        new DataColumnMapping("Percentage", "Percentage"),
        new DataColumnMapping("FlatAmount", "FlatAmount"),
        new DataColumnMapping("ID", "ID")
      })
    });
    this.DbSelectCommand2.CommandText = componentResourceManager.GetString("DbSelectCommand2.CommandText");
    this.DbSelectCommand2.Connection = this.cnDB;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraTabControlBase) this.UltraTabControl1).BackColorInternal = Color.White;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Location = new Point(7, 211);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(497, 392);
    ((Control) this.UltraTabControl1).TabIndex = 4;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance15.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance11;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Policy Info";
    appearance12.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance16.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance12;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Commissions";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(125, 0);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(495, 365);
    ((Control) this.btnUp).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance13.BackColor = Color.Gainsboro;
    appearance13.BackColor2 = Color.White;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    appearance13.BorderColor = Color.Gray;
    appearance13.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance13.Image"));
    appearance13.ImageHAlign = (HAlign) 2;
    appearance13.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUp).Appearance = (AppearanceBase) appearance13;
    ((ControlBase) this.btnUp).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnUp).Location = new Point(802, 49);
    ((Control) this.btnUp).Name = "btnUp";
    ((Control) this.btnUp).Size = new Size(21, 42);
    ((Control) this.btnUp).TabIndex = 6;
    this.ToolTip1.SetToolTip((Control) this.btnUp, "Increase Rank");
    this.btnUp.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnDown).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance14.BackColor = Color.Gainsboro;
    appearance14.BackColor2 = Color.White;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = Color.Gray;
    appearance14.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance14.Image"));
    appearance14.ImageHAlign = (HAlign) 2;
    appearance14.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDown).Appearance = (AppearanceBase) appearance14;
    ((ControlBase) this.btnDown).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnDown).Location = new Point(802, 98);
    ((Control) this.btnDown).Name = "btnDown";
    ((Control) this.btnDown).Size = new Size(21, 42);
    ((Control) this.btnDown).TabIndex = 5;
    this.ToolTip1.SetToolTip((Control) this.btnDown, "Decrease Rank");
    this.btnDown.UseOSThemes = (DefaultableBoolean) 2;
    this.daLoadData.SelectCommand = this.DbSelectCommand3;
    this.daLoadData.TableMappings.AddRange(new DataTableMapping[6]
    {
      new DataTableMapping("Table", "spAdminCommissionsData", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("Name", "Name")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("Name", "Name")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("State", "State")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("LineName", "LineName")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("OfficeGuid", "OfficeGuid"),
        new DataColumnMapping("Location", "Location")
      }),
      new DataTableMapping("Table5", "Table5", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGuid", "UserGuid"),
        new DataColumnMapping("UserName", "UserName")
      })
    });
    this.DbSelectCommand3.CommandText = "[spAdminCommissionsData]";
    this.DbSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand3.Connection = this.cnDB;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.dvOffices.Table = (DataTable) this.ds.tblClientOffices;
    this.dvIssuingOffices.Table = (DataTable) this.ds.tblClientOffices;
    this.dvUsers.Table = (DataTable) this.ds.tblUsers;
    this.dvUnderwriters.RowFilter = "IsUnderwriter = 1";
    this.dvUnderwriters.Table = (DataTable) this.ds.tblUsers;
    this.lblPremiumLessThanEqualTo.AutoSize = true;
    this.lblPremiumLessThanEqualTo.BackColor = Color.Transparent;
    this.lblPremiumLessThanEqualTo.Location = new Point(510, 283);
    this.lblPremiumLessThanEqualTo.Name = "lblPremiumLessThanEqualTo";
    this.lblPremiumLessThanEqualTo.Size = new Size((int) byte.MaxValue, 13);
    this.lblPremiumLessThanEqualTo.TabIndex = 23;
    this.lblPremiumLessThanEqualTo.Text = "Apply when carrier premium is less than or equal to:";
    this.lblPremiumLessThanEqualTo.TextAlign = ContentAlignment.MiddleRight;
    this.lblPremiumGreaterEqualTo.AutoSize = true;
    this.lblPremiumGreaterEqualTo.BackColor = Color.Transparent;
    this.lblPremiumGreaterEqualTo.Location = new Point(509, 244);
    this.lblPremiumGreaterEqualTo.Name = "lblPremiumGreaterEqualTo";
    this.lblPremiumGreaterEqualTo.Size = new Size(273, 13);
    this.lblPremiumGreaterEqualTo.TabIndex = 22;
    this.lblPremiumGreaterEqualTo.Text = "Apply when carrier premium is greater than or equal to:";
    this.lblPremiumGreaterEqualTo.TextAlign = ContentAlignment.MiddleRight;
    appearance15.BackColorDisabled = Color.Gainsboro;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numApplyPremiumEqualOrLess).Appearance = (AppearanceBase) appearance15;
    ((UltraNumericEditorBase) this.numApplyPremiumEqualOrLess).FormatString = "c";
    ((Control) this.numApplyPremiumEqualOrLess).Location = new Point(512 /*0x0200*/, 299);
    ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).MaskInput = "nnnnnnnnnnn.nn";
    ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).MaxValue = (object) 99999999999.99;
    this.numApplyPremiumEqualOrLess.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).MinValue = (object) 0;
    ((Control) this.numApplyPremiumEqualOrLess).Name = "numApplyPremiumEqualOrLess";
    ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).Nullable = true;
    ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).NumericType = (NumericType) 2;
    ((Control) this.numApplyPremiumEqualOrLess).Size = new Size(103, 20);
    ((Control) this.numApplyPremiumEqualOrLess).TabIndex = 25;
    ((UltraWinEditorMaskedControlBase) this.numApplyPremiumEqualOrLess).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numApplyPremiumEqualOrLess).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numApplyPremiumEqualOrLess).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).Value = (object) null;
    appearance16.BackColorDisabled = Color.Gainsboro;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numApplyPremiumEqualOrOver).Appearance = (AppearanceBase) appearance16;
    ((UltraNumericEditorBase) this.numApplyPremiumEqualOrOver).FormatString = "c";
    ((Control) this.numApplyPremiumEqualOrOver).Location = new Point(512 /*0x0200*/, 260);
    ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).MaskInput = "nnnnnnnnnnn.nn";
    ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).MaxValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      131072 /*0x020000*/
    });
    this.numApplyPremiumEqualOrOver.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).MinValue = (object) 0;
    ((Control) this.numApplyPremiumEqualOrOver).Name = "numApplyPremiumEqualOrOver";
    ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).Nullable = true;
    ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).NumericType = (NumericType) 2;
    ((Control) this.numApplyPremiumEqualOrOver).Size = new Size(103, 20);
    ((Control) this.numApplyPremiumEqualOrOver).TabIndex = 24;
    ((UltraWinEditorMaskedControlBase) this.numApplyPremiumEqualOrOver).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numApplyPremiumEqualOrOver).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numApplyPremiumEqualOrOver).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).Value = (object) null;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(829, 633);
    this.Controls.Add((Control) this.numApplyPremiumEqualOrLess);
    this.Controls.Add((Control) this.numApplyPremiumEqualOrOver);
    this.Controls.Add((Control) this.lblPremiumLessThanEqualTo);
    this.Controls.Add((Control) this.lblPremiumGreaterEqualTo);
    this.Controls.Add((Control) this.lnkAdminCommissionsReport);
    this.Controls.Add((Control) this.btnUp);
    this.Controls.Add((Control) this.btnDown);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.dgComm);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdminCommissions);
    this.Text = "Admin Commissions";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.cboProducer).EndInit();
    ((ISupportInitialize) this.dtDisabled).EndInit();
    ((ISupportInitialize) this.chkRenewals).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.cboUnderwriter).EndInit();
    ((ISupportInitialize) this.cboIssuingOffice).EndInit();
    ((ISupportInitialize) this.cboPolicyType).EndInit();
    ((ISupportInitialize) this.cboCompany).EndInit();
    ((ISupportInitialize) this.cboProducerLocation).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((ISupportInitialize) this.cboOffices).EndInit();
    ((ISupportInitialize) this.cboInHouseProducers).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.dgComm).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.btnUp).EndInit();
    ((ISupportInitialize) this.btnDown).EndInit();
    this.dvOffices.EndInit();
    this.dvIssuingOffices.EndInit();
    this.dvUsers.EndInit();
    this.dvUnderwriters.EndInit();
    ((ISupportInitialize) this.numApplyPremiumEqualOrLess).EndInit();
    ((ISupportInitialize) this.numApplyPremiumEqualOrOver).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmAdminCommissions_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((Control) this.dbSave).Enabled = false;
    this.SetTabControlsEnabled(false);
    this._canEdit = SecurityManager.Instance.AssertPermission("{D16801AA-6657-49B9-9E8B-D24F265F719D}");
    this._canAdd = SecurityManager.Instance.AssertPermission("{B22FFF0D-C146-453D-AC26-FA29557D10B6}");
    this._canDelete = SecurityManager.Instance.AssertPermission("{6109BC05-9041-4F46-9915-12E4B7942E81}");
    ((UltraGridBase) this.dgComm).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.dgComm).DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
    this.ctlEntity.FillPremiumsFees();
  }

  private void ThreadedFill(object state)
  {
    Thread.Sleep(250);
    DbConnection dbConnection = DefaultDatabase.CreateDbConnection();
    try
    {
      this.daLoadData.SelectCommand.Connection = dbConnection;
      DataTableMappingCollection tableMappings = this.daLoadData.TableMappings;
      tableMappings.Clear();
      tableMappings.Add("Table", this.ds.tblCompanyLocations.TableName);
      tableMappings.Add("Table1", this.ds.tblProducerLocations.TableName);
      tableMappings.Add("Table2", this.ds.lstStates.TableName);
      tableMappings.Add("Table3", this.ds.lstLines.TableName);
      tableMappings.Add("Table4", this.ds.tblClientOffices.TableName);
      tableMappings.Add("Table5", this.ds.tblUsers.TableName);
      tableMappings.Add("Table6", this.ds.lstPolicyTypes.TableName);
      tableMappings.Add("Table7", this.ds.tblProducers.TableName);
      DefaultDatabase.DataAdapterFill(this.daLoadData, (DataSet) this.ds);
      this.daComm.SelectCommand.Connection = dbConnection;
      this.daView.SelectCommand.Connection = dbConnection;
      this.daComm.SelectCommand.CommandText += " ORDER BY Hierarchy";
      DefaultDatabase.DataAdapterFill(this.daComm, (DataTable) this.ds.tblAdminCommissions);
      DefaultDatabase.DataAdapterFill(this.daView, (DataTable) this.ds.viewAdminCommissions);
      this.daComm.SelectCommand.Connection = this.cnDB;
      this.daView.SelectCommand.Connection = this.cnDB;
    }
    finally
    {
      dbConnection.Dispose();
    }
    MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new frmAdminCommissions.ThreadCompleteHandler(this.ThreadComplete), (object) this, (object) EventArgs.Empty);
  }

  private void btnDown_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgComm).ActiveRow == null)
      return;
    int ID = (int) ((UltraGridBase) this.dgComm).ActiveRow.Cells["ID"].Value;
    int hierarchy = this.ds.tblAdminCommissions.FindByID(ID).Hierarchy;
    if (hierarchy == ((UltraGridBase) this.dgComm).Rows.Count || this.ds.tblAdminCommissions.Select("Hierarchy=" + (hierarchy + 1).ToString()).Length <= 0)
      return;
    dsAdminCommissions.tblAdminCommissionsDataTable adminCommissions = this.ds.tblAdminCommissions;
    string filterExpression = "Hierarchy=" + (hierarchy + 1).ToString();
    dsAdminCommissions.tblAdminCommissionsRow adminCommissionsRow;
    int num1 = (adminCommissionsRow = (dsAdminCommissions.tblAdminCommissionsRow) adminCommissions.Select(filterExpression)[0]).Hierarchy - 1;
    adminCommissionsRow.Hierarchy = num1;
    dsAdminCommissions.tblAdminCommissionsRow byId;
    int num2 = (byId = this.ds.tblAdminCommissions.FindByID(ID)).Hierarchy + 1;
    byId.Hierarchy = num2;
    this.AfterSort(ID);
  }

  private void AfterSort(int ID)
  {
    this.UpdateHierarchies();
    this.FillView();
    foreach (UltraGridRow row in ((UltraGridBase) this.dgComm).Rows)
    {
      if ((int) row.Cells[nameof (ID)].Value == ID)
      {
        row.Selected = true;
        row.Activate();
        break;
      }
    }
  }

  private void btnUp_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgComm).ActiveRow == null)
      return;
    int ID = (int) ((UltraGridBase) this.dgComm).ActiveRow.Cells["ID"].Value;
    int hierarchy = this.ds.tblAdminCommissions.FindByID(ID).Hierarchy;
    if (hierarchy == 1 || this.ds.tblAdminCommissions.Select("Hierarchy=" + (hierarchy - 1).ToString()).Length <= 0)
      return;
    dsAdminCommissions.tblAdminCommissionsDataTable adminCommissions = this.ds.tblAdminCommissions;
    string filterExpression = "Hierarchy=" + (hierarchy - 1).ToString();
    dsAdminCommissions.tblAdminCommissionsRow adminCommissionsRow;
    int num1 = (adminCommissionsRow = (dsAdminCommissions.tblAdminCommissionsRow) adminCommissions.Select(filterExpression)[0]).Hierarchy + 1;
    adminCommissionsRow.Hierarchy = num1;
    dsAdminCommissions.tblAdminCommissionsRow byId;
    int num2 = (byId = this.ds.tblAdminCommissions.FindByID(ID)).Hierarchy - 1;
    byId.Hierarchy = num2;
    this.AfterSort(ID);
  }

  private void ThreadComplete(object sender, EventArgs e)
  {
    ((UltraGridBase) this.dgComm).DataSource = (object) this.ds.viewAdminCommissions;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.dgComm).DisplayLayout.Load((Stream) this._gridLayout);
    ((UltraGridBase) this.dgComm).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    MGASimpleComboBox cboCompany = this.cboCompany;
    ((UltraGridBase) cboCompany).DataSource = (object) this.ds.tblCompanyLocations;
    ((UltraDropDownBase) cboCompany).DisplayMember = "Name";
    ((UltraDropDownBase) cboCompany).ValueMember = "CompanyLocationGuid";
    MGASimpleComboBox producerLocation = this.cboProducerLocation;
    ((UltraGridBase) producerLocation).DataSource = (object) this.ds.tblProducerLocations;
    ((UltraDropDownBase) producerLocation).DisplayMember = "Name";
    ((UltraDropDownBase) producerLocation).ValueMember = "ProducerLocationGuid";
    MGASimpleComboBox cboProducer = this.cboProducer;
    ((UltraGridBase) cboProducer).DataSource = (object) this.ds.tblProducers;
    ((UltraDropDownBase) cboProducer).DisplayMember = this.ds.tblProducers.ProducerNameColumn.ColumnName;
    ((UltraDropDownBase) cboProducer).ValueMember = this.ds.tblProducers.ProducerGUIDColumn.ColumnName;
    MGASimpleComboBox cboState = this.cboState;
    ((UltraGridBase) cboState).DataSource = (object) this.ds.lstStates;
    ((UltraDropDownBase) cboState).DisplayMember = "State";
    ((UltraDropDownBase) cboState).ValueMember = "StateID";
    MGASimpleComboBox cboLine = this.cboLine;
    ((UltraGridBase) cboLine).DataSource = (object) this.ds.lstLines;
    ((UltraDropDownBase) cboLine).DisplayMember = "LineName";
    ((UltraDropDownBase) cboLine).ValueMember = "LineGuid";
    MGASimpleComboBox cboOffices = this.cboOffices;
    ((UltraGridBase) cboOffices).DataSource = (object) this.dvOffices;
    ((UltraDropDownBase) cboOffices).DisplayMember = "Location";
    ((UltraDropDownBase) cboOffices).ValueMember = "OfficeGuid";
    MGASimpleComboBox inHouseProducers = this.cboInHouseProducers;
    ((UltraGridBase) inHouseProducers).DataSource = (object) this.ds.tblUsers;
    ((UltraDropDownBase) inHouseProducers).DisplayMember = "UserName";
    ((UltraDropDownBase) inHouseProducers).ValueMember = "UserGuid";
    MGASimpleComboBox cboUnderwriter = this.cboUnderwriter;
    ((UltraGridBase) cboUnderwriter).DataSource = (object) this.dvUnderwriters;
    ((UltraDropDownBase) cboUnderwriter).DisplayMember = "UserName";
    ((UltraDropDownBase) cboUnderwriter).ValueMember = "UserGuid";
    MGASimpleComboBox cboIssuingOffice = this.cboIssuingOffice;
    ((UltraGridBase) cboIssuingOffice).DataSource = (object) this.dvIssuingOffices;
    ((UltraDropDownBase) cboIssuingOffice).DisplayMember = "Location";
    ((UltraDropDownBase) cboIssuingOffice).ValueMember = "OfficeGuid";
    MGASimpleComboBox cboPolicyType = this.cboPolicyType;
    ((UltraGridBase) cboPolicyType).DataSource = (object) this.ds.lstPolicyTypes;
    ((UltraDropDownBase) cboPolicyType).DisplayMember = this.ds.lstPolicyTypes.DescriptionColumn.ColumnName;
    ((UltraDropDownBase) cboPolicyType).ValueMember = this.ds.lstPolicyTypes.PolicyTypeIDColumn.ColumnName;
    this.ColorOutDatedRows();
    this.dgComm.AfterRowActivate += new EventHandler(this.dgComm_AfterRowActivate);
    ((Control) this.dbSave).Enabled = true;
    if (SystemSettings.KeyExists("Admin.Commissions.Percentage.Format"))
      ((UltraGridBase) this.dgComm).DisplayLayout.Bands[0].Columns["Percentage"].Format = SystemSettings.GetStringSetting("Admin.Commissions.Percentage.Format");
    if (!SystemSettings.KeyExists("Admin.Commissions.ShowCarrierPremiumBand") || !SystemSettings.GetBoolSetting("Admin.Commissions.ShowCarrierPremiumBand"))
    {
      ((Control) this.numApplyPremiumEqualOrLess).Visible = false;
      ((Control) this.numApplyPremiumEqualOrOver).Visible = false;
      this.lblPremiumGreaterEqualTo.Visible = false;
      this.lblPremiumLessThanEqualTo.Visible = false;
    }
    this.OnFormLoadComplete();
  }

  private void SetTabControlsEnabled(bool Enabled)
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control != this.dbSave)
            control.Enabled = Enabled;
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

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.dgComm).Enabled = this.dbSave.UIState != 2;
    this.SetTabControlsEnabled(this.dbSave.UIState == 2);
    this.EnabledOnClient(this.dbSave.UIState == 2);
  }

  private void SetOffice(int ID)
  {
    dsAdminCommissions.tblAdminCommissionsRow byId = this.ds.tblAdminCommissions.FindByID(ID);
    if (byId.IsOfficeLocationGuidNull())
    {
      this.cboOffices.SelectedIndex = -1;
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.cboOffices).Rows)
      {
        if (row.Cells["OfficeGuid"].Value.Equals((object) byId.OfficeLocationGuid))
        {
          ((UltraDropDownBase) this.cboOffices).SelectedRow = row;
          break;
        }
      }
    }
  }

  private void dgComm_AfterRowActivate(object sender, EventArgs e)
  {
    if (this.ds.tblAdminCommissions.Rows.Count == 0 || ((UltraGridBase) this.dgComm).ActiveRow == null)
      return;
    int ID = (int) ((UltraGridBase) this.dgComm).ActiveRow.Cells["ID"].Value;
    dsAdminCommissions.tblAdminCommissionsRow byId1 = this.ds.tblAdminCommissions.FindByID(ID);
    if (byId1.IsCompanyLocationGuidNull())
      this.cboCompany.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboCompany).Value = (object) byId1.CompanyLocationGuid;
    if (byId1.IsLineGuidNull())
      this.cboLine.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboLine).Value = (object) byId1.LineGuid;
    if (byId1.IsProducerLocationGuidNull())
      this.cboProducerLocation.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboProducerLocation).Value = (object) byId1.ProducerLocationGuid;
    if (byId1.IsProducerGUIDNull())
      this.cboProducer.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboProducer).Value = (object) byId1.ProducerGUID;
    if (byId1.IsStateIDNull())
      this.cboState.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboState).Value = (object) byId1.StateID;
    this.SetOffice(ID);
    if (byId1.IsInHouseProducerGuidNull())
      this.cboInHouseProducers.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboInHouseProducers).Value = (object) byId1.InHouseProducerGuid;
    if (byId1.IsUnderwriterGuidNull())
      this.cboUnderwriter.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboUnderwriter).Value = (object) byId1.UnderwriterGuid;
    if (byId1.IsIssuingOfficeGuidNull())
      this.cboIssuingOffice.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboIssuingOffice).Value = (object) byId1.IssuingOfficeGuid;
    if (byId1.IsPolicyTypeIDNull())
      this.cboPolicyType.SelectedIndex = -1;
    else
      ((UltraCombo) this.cboPolicyType).Value = (object) byId1.PolicyTypeID;
    if (byId1.IsEffectiveNull())
      ((UltraDateTimeEditor) this.dtEffective).Value = (object) null;
    else
      ((UltraDateTimeEditor) this.dtEffective).Value = (object) byId1.Effective;
    if (!byId1.IsDisabledDateNull())
      ((UltraDateTimeEditor) this.dtDisabled).Value = (object) byId1.DisabledDate;
    else
      ((UltraDateTimeEditor) this.dtDisabled).Value = (object) null;
    ((UltraToggleEditorBase) this.chkRenewals).Checked = byId1.RenewalOnlyIfPreviouslyCommissioned;
    if (byId1.IsMinimumFirmIncomeNull())
      ((UltraNumericEditor) this.ctlEntity.txtFirmIncome).Value = (object) DBNull.Value;
    else
      ((UltraNumericEditor) this.ctlEntity.txtFirmIncome).Value = (object) byId1.MinimumFirmIncome;
    dsAdminCommissions.viewAdminCommissionsRow byId2 = this.ds.viewAdminCommissions.FindByID(byId1.ID);
    this.ctlEntity.Entity = byId2.Entity;
    this.ctlEntity.EntityGuid = byId1.EntityGuid;
    this.ctlEntity.EntityType = byId2.EntityType;
    this.ctlEntity.EntityTypeID = byId1.EntityTypeID;
    if (byId1.IsIncomeBetweenEndDayNull())
      ((UltraNumericEditor) this.ctlEntity.udIncomeEndDay).Value = (object) 0;
    else
      ((UltraNumericEditor) this.ctlEntity.udIncomeEndDay).Value = (object) byId1.IncomeBetweenEndDay;
    if (byId1.IsIncomeBetweenEndMonthNull())
    {
      ((UltraCombo) this.ctlEntity.cboIncomeEndMonth).Value = (object) -1;
      ((UltraCombo) this.ctlEntity.cboIncomeEndMonth).Value = (object) -1;
    }
    else
      this.ctlEntity.cboIncomeEndMonth.SelectedIndex = byId1.IncomeBetweenEndMonth - 1;
    if (byId1.IsIncomeBetweenStartDayNull())
      ((UltraNumericEditor) this.ctlEntity.udIncomeStartDay).Value = (object) 0;
    else
      ((UltraNumericEditor) this.ctlEntity.udIncomeStartDay).Value = (object) byId1.IncomeBetweenStartDay;
    if (byId1.IsIncomeBetweenStartMonthNull())
    {
      ((UltraCombo) this.ctlEntity.cboIncomeStartMonth).Value = (object) -1;
      ((UltraCombo) this.ctlEntity.cboIncomeEndMonth).Value = (object) -1;
    }
    else
      this.ctlEntity.cboIncomeStartMonth.SelectedIndex = byId1.IncomeBetweenStartMonth - 1;
    if (byId1.IsChargeCodeNull())
      this.ctlEntity.SelectAllPremiumItem();
    else
      ((UltraCombo) this.ctlEntity.cboChargeCodes).Value = (object) byId1.ChargeCode;
    ((UltraToggleEditorBase) this.ctlEntity.chkOperatingAccount).Checked = byId1.CommissionsFromOperatingAccount;
    if (!byId1.IsApplyPremiumEqualOrOverNull())
      ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).Value = (object) byId1.ApplyPremiumEqualOrOver;
    else
      ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).Value = (object) DBNull.Value;
    if (!byId1.IsApplyPremiumEqualOrLessNull())
      ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).Value = (object) byId1.ApplyPremiumEqualOrLess;
    else
      ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).Value = (object) DBNull.Value;
    this.SetCommissionSelection(ID, byId2);
    this.AfterRowActivateOnClient(ID);
    if (this.dbSave.UIState == 2)
      return;
    this.dbSave.UIState = (UIState) 1;
  }

  private void SetCommissionSelection(int ID, dsAdminCommissions.viewAdminCommissionsRow drView)
  {
    string commissionTypeId = this.ds.tblAdminCommissions.FindByID(ID).CommissionTypeID;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(commissionTypeId))
    {
      case 686187615:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "NT", false) == 0)
        {
          AddCommissionableEntity ctlEntity = this.ctlEntity;
          ctlEntity.rbNet.Checked = true;
          ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
          ((UltraNumericEditor) ctlEntity.txtAmount).Value = (object) drView.Percentage;
          break;
        }
        break;
      case 870741424:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "NA", false) == 0)
        {
          AddCommissionableEntity ctlEntity = this.ctlEntity;
          ctlEntity.rbNetAfter.Checked = true;
          ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
          ((UltraNumericEditor) ctlEntity.txtAmount).Value = (object) drView.Percentage;
          break;
        }
        break;
      case 1825638684:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "GR", false) == 0)
        {
          AddCommissionableEntity ctlEntity = this.ctlEntity;
          ctlEntity.rbGross.Checked = true;
          ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
          ((UltraNumericEditor) ctlEntity.txtAmount).Value = (object) drView.Percentage;
          break;
        }
        break;
      case 1859193922:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "GP", false) == 0)
        {
          AddCommissionableEntity ctlEntity = this.ctlEntity;
          ctlEntity.rbGrossPremium.Checked = true;
          ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
          ((UltraNumericEditor) ctlEntity.txtAmount).Value = (object) drView.Percentage;
          break;
        }
        break;
      case 2194893397:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "FN", false) == 0)
        {
          AddCommissionableEntity ctlEntity = this.ctlEntity;
          ctlEntity.rbNet.Checked = true;
          ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = true;
          ((UltraNumericEditor) ctlEntity.txtAmount).Value = (object) drView.FlatAmount;
          break;
        }
        break;
      case 2211671016:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "FA", false) == 0)
        {
          AddCommissionableEntity ctlEntity = this.ctlEntity;
          ctlEntity.rbNetAfter.Checked = true;
          ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
          ((UltraNumericEditor) ctlEntity.txtAmount).Value = (object) drView.Percentage;
          break;
        }
        break;
      case 2312336730:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "FG", false) == 0)
        {
          AddCommissionableEntity ctlEntity = this.ctlEntity;
          ctlEntity.rbGross.Checked = true;
          ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = true;
          ((UltraNumericEditor) ctlEntity.txtAmount).Value = (object) drView.FlatAmount;
          break;
        }
        break;
    }
  }

  private bool ValidForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboCompany, string.Empty);
    this.err.SetError((Control) this.ctlEntity.chkFlat, string.Empty);
    this.err.SetError((Control) this.cboProducer, string.Empty);
    this.err.SetError((Control) this.cboProducerLocation, string.Empty);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboCompany).Text, string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboLine).Text, string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducer).Text, string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducerLocation).Text, string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboState).Text, string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboUnderwriter).Text, string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboInHouseProducers).Text, string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboOffices).Text, string.Empty, false) == 0)
    {
      flag = false;
      this.err.SetError((Control) this.cboCompany, "Please select criteria for this commission setup.");
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
    }
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboProducer).Text) && !string.IsNullOrEmpty(((UltraCombo) this.cboProducerLocation).Text))
    {
      flag = false;
      this.err.SetError((Control) this.cboProducer, "Cannot select both 'Producer' and 'Producer Location'.");
      this.err.SetError((Control) this.cboProducerLocation, "Cannot select both 'Producer' and 'Producer Location'.");
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
    }
    if (this.ctlEntity.CommissionTypeID.Equals("FA") && ((UltraToggleEditorBase) this.ctlEntity.chkFlat).Checked)
    {
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[1];
      this.err.SetError((Control) this.ctlEntity.chkFlat, "This cannot be checked when 'Net After Commissions' is selected.");
      flag = false;
    }
    if (flag)
    {
      flag = this.ctlEntity.IsValid();
      if (!flag)
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[1];
    }
    return flag;
  }

  private void UpdateHierarchies()
  {
    DbTransaction t = (DbTransaction) null;
    try
    {
      this.cnDB.Open();
      t = this.cnDB.BeginTransaction();
      this.UpdateHierarchies(t);
      t.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      t.Rollback();
      throw;
    }
    finally
    {
      this.cnDB.Close();
      t.Dispose();
    }
  }

  private void UpdateHierarchies(DbTransaction t)
  {
    DbCommand command = DefaultDatabase.CreateCommand(string.Empty, this.cnDB);
    try
    {
      XElement xelement = new XElement((XName) "Root", (object) "");
      command.Transaction = t;
      int num1 = ((UltraGridBase) this.dgComm).Rows.Count - 1;
      for (int index = 0; index <= num1; ++index)
      {
        int num2 = (int) ((UltraGridBase) this.dgComm).Rows[index].Cells["ID"].Value;
        if (this.ds.tblAdminCommissions.FindByID(num2).Hierarchy != index)
          xelement.Add((object) new XElement((XName) "Commission", new object[2]
          {
            (object) new XElement((XName) "ID", (object) num2),
            (object) new XElement((XName) "Hierarchy", (object) this.ds.tblAdminCommissions.FindByID(num2).Hierarchy.ToString())
          }));
      }
      command.CommandText = "sp_UpdateAdminCommissionsHierarchy";
      command.CommandType = CommandType.StoredProcedure;
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@Hierarchy", (object) xelement.ToString());
      command.ExecuteNonQuery();
    }
    finally
    {
      command.Dispose();
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
      Cursor.Current = MgaCursors.WaitCursor;
      bool flag1 = this.ds.tblAdminCommissions[this.ds.tblAdminCommissions.Count - 1].RowState == DataRowState.Added;
      dsAdminCommissions.tblAdminCommissionsRow adminCommissionsRow = !flag1 ? this.ds.tblAdminCommissions.FindByID((int) ((UltraGridBase) this.dgComm).ActiveRow.Cells["ID"].Value) : this.ds.tblAdminCommissions[this.ds.tblAdminCommissions.Count - 1];
      if (this.ctlEntity.CommissionOnTotalPremium)
      {
        adminCommissionsRow.CommissionOnTotalPremium = true;
        adminCommissionsRow.SetChargeCodeNull();
      }
      else
      {
        adminCommissionsRow.CommissionOnTotalPremium = false;
        adminCommissionsRow.ChargeCode = this.ctlEntity.ChargeCode;
      }
      adminCommissionsRow.CommissionTypeID = this.ctlEntity.CommissionTypeID;
      if (string.IsNullOrEmpty(((UltraCombo) this.cboCompany).Text))
        adminCommissionsRow.SetCompanyLocationGuidNull();
      else
        adminCommissionsRow.CompanyLocationGuid = (Guid) ((UltraCombo) this.cboCompany).Value;
      adminCommissionsRow.EntityGuid = this.ctlEntity.EntityGuid;
      adminCommissionsRow.EntityTypeID = this.ctlEntity.EntityTypeID;
      adminCommissionsRow.AddedByUserID = CurrentUser.Instance.UserID;
      adminCommissionsRow.CommissionsFromOperatingAccount = ((UltraToggleEditorBase) this.ctlEntity.chkOperatingAccount).Checked;
      adminCommissionsRow.AddedByUserID = CurrentUser.Instance.UserID;
      if (((UltraNumericEditor) this.ctlEntity.txtFirmIncome).Value == DBNull.Value)
      {
        adminCommissionsRow.SetMinimumFirmIncomeNull();
        adminCommissionsRow.SetIncomeBetweenEndDayNull();
        adminCommissionsRow.SetIncomeBetweenStartDayNull();
        adminCommissionsRow.SetIncomeBetweenEndMonthNull();
        adminCommissionsRow.SetIncomeBetweenStartMonthNull();
      }
      else
      {
        adminCommissionsRow.MinimumFirmIncome = Conversions.ToInteger(((UltraNumericEditor) this.ctlEntity.txtFirmIncome).Value);
        adminCommissionsRow.IncomeBetweenEndDay = Conversions.ToInteger(((UltraNumericEditor) this.ctlEntity.udIncomeEndDay).Value);
        adminCommissionsRow.IncomeBetweenStartDay = Conversions.ToInteger(((UltraNumericEditor) this.ctlEntity.udIncomeStartDay).Value);
        adminCommissionsRow.IncomeBetweenEndMonth = this.ctlEntity.cboIncomeEndMonth.SelectedIndex + 1;
        adminCommissionsRow.IncomeBetweenStartMonth = this.ctlEntity.cboIncomeStartMonth.SelectedIndex + 1;
      }
      if (string.IsNullOrEmpty(((UltraCombo) this.cboLine).Text))
        adminCommissionsRow.SetLineGuidNull();
      else
        adminCommissionsRow.LineGuid = (Guid) ((UltraCombo) this.cboLine).Value;
      if (((UltraToggleEditorBase) this.ctlEntity.chkFlat).Checked)
      {
        adminCommissionsRow.FlatAmount = Conversions.ToDecimal(((UltraNumericEditor) this.ctlEntity.txtAmount).Value);
        adminCommissionsRow.SetPercentageNull();
      }
      else
      {
        adminCommissionsRow.Percentage = Conversions.ToDecimal(((UltraNumericEditor) this.ctlEntity.txtAmount).Value);
        adminCommissionsRow.SetFlatAmountNull();
      }
      if (string.IsNullOrEmpty(((UltraCombo) this.cboProducerLocation).Text))
        adminCommissionsRow.SetProducerLocationGuidNull();
      else
        adminCommissionsRow.ProducerLocationGuid = (Guid) ((UltraCombo) this.cboProducerLocation).Value;
      if (string.IsNullOrEmpty(((UltraCombo) this.cboProducer).Text))
        adminCommissionsRow.SetProducerGUIDNull();
      else
        adminCommissionsRow.ProducerGUID = (Guid) ((UltraCombo) this.cboProducer).Value;
      if (string.IsNullOrEmpty(((UltraCombo) this.cboState).Text))
        adminCommissionsRow.SetStateIDNull();
      else
        adminCommissionsRow.StateID = ((UltraCombo) this.cboState).Value.ToString();
      if (string.IsNullOrEmpty(((UltraCombo) this.cboInHouseProducers).Text))
        adminCommissionsRow.SetInHouseProducerGuidNull();
      else
        adminCommissionsRow.InHouseProducerGuid = (Guid) ((UltraCombo) this.cboInHouseProducers).Value;
      if (string.IsNullOrEmpty(((UltraCombo) this.cboOffices).Text))
        adminCommissionsRow.SetOfficeLocationGuidNull();
      else
        adminCommissionsRow.OfficeLocationGuid = (Guid) ((UltraCombo) this.cboOffices).Value;
      if (string.IsNullOrEmpty(((UltraCombo) this.cboUnderwriter).Text))
        adminCommissionsRow.SetUnderwriterGuidNull();
      else
        adminCommissionsRow.UnderwriterGuid = (Guid) ((UltraCombo) this.cboUnderwriter).Value;
      if (string.IsNullOrEmpty(((UltraCombo) this.cboIssuingOffice).Text))
        adminCommissionsRow.SetIssuingOfficeGuidNull();
      else
        adminCommissionsRow.IssuingOfficeGuid = (Guid) ((UltraCombo) this.cboIssuingOffice).Value;
      if (string.IsNullOrEmpty(((UltraCombo) this.cboPolicyType).Text))
        adminCommissionsRow.SetPolicyTypeIDNull();
      else
        adminCommissionsRow.PolicyTypeID = Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value);
      if (string.IsNullOrEmpty(((UltraWinEditorMaskedControlBase) this.dtEffective).Text))
        adminCommissionsRow.SetEffectiveNull();
      else
        adminCommissionsRow.Effective = (DateTime) ((UltraDateTimeEditor) this.dtEffective).Value;
      if (((UltraDateTimeEditor) this.dtDisabled).Value != null)
        adminCommissionsRow.DisabledDate = (DateTime) ((UltraDateTimeEditor) this.dtDisabled).Value;
      else
        adminCommissionsRow.SetDisabledDateNull();
      adminCommissionsRow.RenewalOnlyIfPreviouslyCommissioned = ((UltraToggleEditorBase) this.chkRenewals).Checked;
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numApplyPremiumEqualOrOver).Value)))
        adminCommissionsRow.ApplyPremiumEqualOrOver = (Decimal) ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).Value;
      else
        adminCommissionsRow.SetApplyPremiumEqualOrOverNull();
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numApplyPremiumEqualOrLess).Value)))
        adminCommissionsRow.ApplyPremiumEqualOrLess = (Decimal) ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).Value;
      else
        adminCommissionsRow.SetApplyPremiumEqualOrLessNull();
      DbTransaction t = (DbTransaction) null;
      this.dgComm.AfterRowActivate -= new EventHandler(this.dgComm_AfterRowActivate);
      bool flag2;
      try
      {
        Cursor.Current = MgaCursors.WaitCursor;
        this.cnDB.Open();
        t = this.cnDB.BeginTransaction();
        DbDataAdapter daComm = this.daComm;
        daComm.SelectCommand.Transaction = t;
        daComm.UpdateCommand.Transaction = t;
        daComm.DeleteCommand.Transaction = t;
        daComm.InsertCommand.Transaction = t;
        DefaultDatabase.DataAdapterUpdate(this.daComm, (DataTable) this.ds.tblAdminCommissions);
        if (!flag1)
          this.UpdateHierarchies(t);
        t.Commit();
        flag2 = true;
        this.cnDB.Close();
        this.FillView();
        this.SaveOnClient(adminCommissionsRow.ID);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        if (t != null && !flag2)
          t.Rollback();
        this.cnDB.Close();
        ErrorHandler.HandleError(exception);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        t?.Dispose();
        this.dgComm.AfterRowActivate += new EventHandler(this.dgComm_AfterRowActivate);
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  private void FillView()
  {
    this.ds.viewAdminCommissions.Clear();
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      MDIControls.Instance.StatusBarText = "Getting existing commission setup...";
      DefaultDatabase.DataAdapterFill(this.daView, (DataTable) this.ds.viewAdminCommissions);
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!this._canDelete)
    {
      int num = (int) MessageBox.Show("You do not have the required security to delete commissions", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (((UltraGridBase) this.dgComm).ActiveRow == null || MessageBox.Show("Are you sure you want to delete this commission setup?", "Delete Commission Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      int ID = (int) ((UltraGridBase) this.dgComm).ActiveRow.Cells["ID"].Value;
      if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblAdminCommissions WHERE ID=@ID", new object[2]
      {
        (object) "@ID",
        (object) ID
      }) != 1)
        throw new IncorrectNumberOfRowsAffectedException();
      this.ds.viewAdminCommissions.RemoveviewAdminCommissionsRow(this.ds.viewAdminCommissions.FindByID(ID));
      this.DeleteOnClient(ID);
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!this._canAdd)
    {
      int num = (int) MessageBox.Show("You do not have the required security to add commissions", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      dsAdminCommissions.tblAdminCommissionsRow row = this.ds.tblAdminCommissions.NewtblAdminCommissionsRow();
      row.Hierarchy = this.ds.tblAdminCommissions.Count + 1;
      row.AddedByUserID = CurrentUser.Instance.UserID;
      this.ds.tblAdminCommissions.AddtblAdminCommissionsRow(row);
      foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (control is MGASimpleComboBox mgaSimpleComboBox)
              ((UltraDropDownBase) mgaSimpleComboBox).SelectedRow = (UltraGridRow) null;
            if (control is MGADateTimePicker mgaDateTimePicker)
              ((UltraDateTimeEditor) mgaDateTimePicker).Value = (object) null;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      ((UltraNumericEditor) this.numApplyPremiumEqualOrLess).Value = (object) DBNull.Value;
      ((UltraNumericEditor) this.numApplyPremiumEqualOrOver).Value = (object) DBNull.Value;
      this.ctlEntity.ClearInput();
      this.NewOnClient(row.ID);
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblAdminCommissions.RejectChanges();
    this.CancelOnClient();
    this.dgComm_AfterRowActivate((object) null, (EventArgs) null);
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this._canEdit)
      return;
    int num = (int) MessageBox.Show("You do not have the required security to edit commissions", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    e.Cancel = true;
  }

  private void lnkAdminCommissionsReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    SectionReport sectionReport = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptAdminCommissions), new object[1]
    {
      (object) this.ds.viewAdminCommissions
    });
    try
    {
      sectionReport.Run();
      ReportFactory.Instance.ShowReport(sectionReport);
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (ex.Message.Contains("used by another process"))
      {
        int num = (int) MessageBox.Show("Cannot execute this request at the momemt because it is being used by another process", "Report Being Used By Another Process", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ProjectData.ClearProjectError();
      }
      else
        throw;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void ColorOutDatedRows()
  {
    DateTime date = CurrentUser.ServerTime.Date;
    foreach (UltraGridRow row in ((UltraGridBase) this.dgComm).Rows)
    {
      dsAdminCommissions.tblAdminCommissionsRow byId = this.ds.tblAdminCommissions.FindByID(Conversions.ToInteger(row.Cells["ID"].Value));
      if (byId != null && !byId.IsDisabledDateNull() && DateTime.Compare(date, byId.DisabledDate) > 0)
        row.Appearance.ForeColor = Color.Red;
    }
  }

  protected virtual void OnFormLoadComplete()
  {
  }

  protected virtual void AfterRowActivateOnClient(int ID)
  {
  }

  protected virtual void DeleteOnClient(int ID)
  {
  }

  protected virtual void NewOnClient(int ID)
  {
  }

  protected virtual void CancelOnClient()
  {
  }

  protected virtual void SaveOnClient(int ID)
  {
  }

  protected virtual void EnabledOnClient(bool enable)
  {
  }

  private delegate void ThreadCompleteHandler(object sender, EventArgs e);
}
