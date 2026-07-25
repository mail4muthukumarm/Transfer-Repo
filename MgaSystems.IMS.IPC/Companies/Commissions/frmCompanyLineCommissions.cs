// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.Commissions.frmCompanyLineCommissions
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolTip;
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
using System.Collections.Generic;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.Commissions;

public class frmCompanyLineCommissions : Form
{
  private IContainer components;
  private int _companyLineID;
  private string _stateID;
  private bool _saveSuccess;
  private static dsCompanyLineCommissions.tblCompanyLocationsDataTable _tblCompanyLocationsCache;
  private CompanyLine _companyLine;
  private bool _KeepExpiringCommissionsOnRenewal;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbAdditive")]
  internal virtual UltraGroupBox gbAdditive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAdditiveMax")]
  protected virtual MGANumericEditor txtAdditiveMax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAdditiveSpread")]
  protected virtual MGANumericEditor txtAdditiveSpread { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGANumericEditor txtAdditiveMin
  {
    get => this._txtAdditiveMin;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TxtAdditiveMin_ValueChanged);
      MGANumericEditor txtAdditiveMin1 = this._txtAdditiveMin;
      if (txtAdditiveMin1 != null)
        ((UltraNumericEditorBase) txtAdditiveMin1).ValueChanged -= eventHandler;
      this._txtAdditiveMin = value;
      MGANumericEditor txtAdditiveMin2 = this._txtAdditiveMin;
      if (txtAdditiveMin2 == null)
        return;
      ((UltraNumericEditorBase) txtAdditiveMin2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbStandard")]
  internal virtual RadioButton rbStandard { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual RadioButton rbAdditive
  {
    get => this._rbAdditive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbAdditive_CheckedChanged);
      RadioButton rbAdditive1 = this._rbAdditive;
      if (rbAdditive1 != null)
        rbAdditive1.CheckedChanged -= eventHandler;
      this._rbAdditive = value;
      RadioButton rbAdditive2 = this._rbAdditive;
      if (rbAdditive2 == null)
        return;
      rbAdditive2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gbStandard")]
  internal virtual UltraGroupBox gbStandard { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNewCommission")]
  internal virtual MGANumericEditor txtNewCommission { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRenewCommission")]
  internal virtual MGANumericEditor txtRenewCommission { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtProducerRenewCommissionMax")]
  internal virtual MGANumericEditor txtProducerRenewCommissionMax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtProducerNewCommissionMax")]
  internal virtual MGANumericEditor txtProducerNewCommissionMax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtProducerRenewCommission")]
  internal virtual MGANumericEditor txtProducerRenewCommission { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGANumericEditor txtProducerNewCommission
  {
    get => this._txtProducerNewCommission;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtProducerNewCommission_Validated);
      MGANumericEditor producerNewCommission1 = this._txtProducerNewCommission;
      if (producerNewCommission1 != null)
        ((Control) producerNewCommission1).Validated -= eventHandler;
      this._txtProducerNewCommission = value;
      MGANumericEditor producerNewCommission2 = this._txtProducerNewCommission;
      if (producerNewCommission2 == null)
        return;
      ((Control) producerNewCommission2).Validated += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label22")]
  internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  internal virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  internal virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UltraGrid1_AfterRowActivate);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
        ultraGrid1_1.AfterRowActivate -= eventHandler;
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.AfterRowActivate += eventHandler;
    }
  }

  internal virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedDelete);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickedDelete -= eventHandler1;
        dbSave1.ClickedCancel -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickedDelete += eventHandler1;
      dbSave2.ClickedCancel += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsCompanyLineCommissions ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("groupCompanyCommissions")]
  internal virtual MGAGroupBox groupCompanyCommissions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("groupProducerCommissions")]
  internal virtual MGAGroupBox groupProducerCommissions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("groupGeneralInfo")]
  internal virtual MGAGroupBox groupGeneralInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkLockedCommissions")]
  protected virtual MGACheckBox chkLockedCommissions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("toolTip")]
  internal virtual UltraToolTipManager toolTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboPolicyTypes")]
  internal virtual MGASimpleComboBox comboPolicyTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboExpiringCarrier")]
  internal virtual MGASimpleComboBox comboExpiringCarrier { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraButton buttonRefreshCompanies
  {
    get => this._buttonRefreshCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonRefreshCompanies_Click);
      UltraButton refreshCompanies1 = this._buttonRefreshCompanies;
      if (refreshCompanies1 != null)
        ((Control) refreshCompanies1).Click -= eventHandler;
      this._buttonRefreshCompanies = value;
      UltraButton refreshCompanies2 = this._buttonRefreshCompanies;
      if (refreshCompanies2 == null)
        return;
      ((Control) refreshCompanies2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProgramCode")]
  internal virtual MGASimpleComboBox cboProgramCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkKeepExpiringOnRenewal")]
  internal virtual MGACheckBox chkKeepExpiringOnRenewal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpEffective")]
  internal virtual MGADateTimePicker dtpEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyLineCommissions));
    UltraToolTipInfo ultraToolTipInfo = new UltraToolTipInfo("Refresh Company List", (ToolTipImage) 0, (string) null, (DefaultableBoolean) 0);
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblCompanyLineCommissions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CommissionID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyCommNew");
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyCommRenewal");
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerCommNew");
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProducerCommRenewal");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ProducerCommNewMax");
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerCommRenewalMax");
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("UsingAdditiveCommission");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AdditiveMinimum");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("AdditiveMaximum");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("AdditiveSpread");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LockedCommissions");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ExpiringCompanyLocationGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ProgramID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("KeepExpiringCommissionsOnRenewal");
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.groupCompanyCommissions = new MGAGroupBox();
    this.Label15 = new Label();
    this.rbStandard = new RadioButton();
    this.rbAdditive = new RadioButton();
    this.chkLockedCommissions = new MGACheckBox();
    this.ds = new dsCompanyLineCommissions();
    this.gbStandard = new UltraGroupBox();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.txtNewCommission = new MGANumericEditor();
    this.txtRenewCommission = new MGANumericEditor();
    this.gbAdditive = new UltraGroupBox();
    this.txtAdditiveMin = new MGANumericEditor();
    this.txtAdditiveMax = new MGANumericEditor();
    this.txtAdditiveSpread = new MGANumericEditor();
    this.Label8 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.groupProducerCommissions = new MGAGroupBox();
    this.txtProducerNewCommission = new MGANumericEditor();
    this.txtProducerNewCommissionMax = new MGANumericEditor();
    this.txtProducerRenewCommission = new MGANumericEditor();
    this.txtProducerRenewCommissionMax = new MGANumericEditor();
    this.Label22 = new Label();
    this.Label21 = new Label();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.groupGeneralInfo = new MGAGroupBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.dtpEffective = new MGADateTimePicker();
    this.comboExpiringCarrier = new MGASimpleComboBox();
    this.buttonRefreshCompanies = new UltraButton();
    this.comboPolicyTypes = new MGASimpleComboBox();
    this.cboProgramCode = new MGASimpleComboBox();
    this.chkKeepExpiringOnRenewal = new MGACheckBox();
    this.cn = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    this.toolTip = new UltraToolTipManager(this.components);
    this.UltraGrid1 = new UltraGrid();
    ((ISupportInitialize) this.groupCompanyCommissions).BeginInit();
    ((Control) this.groupCompanyCommissions).SuspendLayout();
    ((ISupportInitialize) this.chkLockedCommissions).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.gbStandard).BeginInit();
    ((Control) this.gbStandard).SuspendLayout();
    ((ISupportInitialize) this.txtNewCommission).BeginInit();
    ((ISupportInitialize) this.txtRenewCommission).BeginInit();
    ((ISupportInitialize) this.gbAdditive).BeginInit();
    ((Control) this.gbAdditive).SuspendLayout();
    ((ISupportInitialize) this.txtAdditiveMin).BeginInit();
    ((ISupportInitialize) this.txtAdditiveMax).BeginInit();
    ((ISupportInitialize) this.txtAdditiveSpread).BeginInit();
    ((ISupportInitialize) this.groupProducerCommissions).BeginInit();
    ((Control) this.groupProducerCommissions).SuspendLayout();
    ((ISupportInitialize) this.txtProducerNewCommission).BeginInit();
    ((ISupportInitialize) this.txtProducerNewCommissionMax).BeginInit();
    ((ISupportInitialize) this.txtProducerRenewCommission).BeginInit();
    ((ISupportInitialize) this.txtProducerRenewCommissionMax).BeginInit();
    ((ISupportInitialize) this.groupGeneralInfo).BeginInit();
    ((Control) this.groupGeneralInfo).SuspendLayout();
    ((ISupportInitialize) this.dtpEffective).BeginInit();
    ((ISupportInitialize) this.comboExpiringCarrier).BeginInit();
    ((ISupportInitialize) this.comboPolicyTypes).BeginInit();
    ((ISupportInitialize) this.cboProgramCode).BeginInit();
    ((ISupportInitialize) this.chkKeepExpiringOnRenewal).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.SuspendLayout();
    ((Control) this.groupCompanyCommissions).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupCompanyCommissions.Appearance = (AppearanceBase) appearance1;
    this.groupCompanyCommissions.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupCompanyCommissions.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.groupCompanyCommissions).Controls.Add((Control) this.Label15);
    ((Control) this.groupCompanyCommissions).Controls.Add((Control) this.rbStandard);
    ((Control) this.groupCompanyCommissions).Controls.Add((Control) this.rbAdditive);
    ((Control) this.groupCompanyCommissions).Controls.Add((Control) this.chkLockedCommissions);
    ((Control) this.groupCompanyCommissions).Controls.Add((Control) this.gbStandard);
    ((Control) this.groupCompanyCommissions).Controls.Add((Control) this.gbAdditive);
    ((Control) this.groupCompanyCommissions).Enabled = false;
    appearance3.ForeColor = Color.FromArgb(21, 66, 139);
    this.groupCompanyCommissions.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.groupCompanyCommissions).Location = new Point(8, 318);
    ((Control) this.groupCompanyCommissions).Name = "groupCompanyCommissions";
    ((Control) this.groupCompanyCommissions).Size = new Size(629, 141);
    ((Control) this.groupCompanyCommissions).TabIndex = 2;
    this.groupCompanyCommissions.Text = "Company Commissions";
    this.groupCompanyCommissions.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(13, 25);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(100, 23);
    this.Label15.TabIndex = 0;
    this.Label15.Text = "Commission Type:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.rbStandard.BackColor = Color.Transparent;
    this.rbStandard.Location = new Point(135, 24);
    this.rbStandard.Name = "rbStandard";
    this.rbStandard.Size = new Size(72, 24);
    this.rbStandard.TabIndex = 1;
    this.rbStandard.Text = "Standard";
    this.rbStandard.UseVisualStyleBackColor = false;
    this.rbAdditive.BackColor = Color.Transparent;
    this.rbAdditive.Location = new Point(222, 24);
    this.rbAdditive.Name = "rbAdditive";
    this.rbAdditive.Size = new Size(64 /*0x40*/, 24);
    this.rbAdditive.TabIndex = 2;
    this.rbAdditive.Text = "Additive";
    this.rbAdditive.UseVisualStyleBackColor = false;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkLockedCommissions).Appearance = (AppearanceBase) appearance4;
    ((Control) this.chkLockedCommissions).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineCommissions.LockedCommissions", true));
    ((UltraToggleEditorBase) this.chkLockedCommissions).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.chkLockedCommissions).Location = new Point(301, 26);
    this.chkLockedCommissions.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkLockedCommissions).Name = "chkLockedCommissions";
    ((Control) this.chkLockedCommissions).Size = new Size(136, 20);
    ((Control) this.chkLockedCommissions).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkLockedCommissions).Text = "Locked Commissions";
    ((UltraControlBase) this.chkLockedCommissions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkLockedCommissions).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyLineCommissions";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.gbStandard).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.gbStandard.BackColorInternal = Color.Transparent;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbStandard.ContentAreaAppearance = (AppearanceBase) appearance5;
    ((Control) this.gbStandard).Controls.Add((Control) this.Label6);
    ((Control) this.gbStandard).Controls.Add((Control) this.Label5);
    ((Control) this.gbStandard).Controls.Add((Control) this.txtNewCommission);
    ((Control) this.gbStandard).Controls.Add((Control) this.txtRenewCommission);
    appearance6.ForeColor = Color.Navy;
    this.gbStandard.HeaderAppearance = (AppearanceBase) appearance6;
    ((Control) this.gbStandard).Location = new Point(16 /*0x10*/, 51);
    ((Control) this.gbStandard).Name = "gbStandard";
    ((Control) this.gbStandard).Size = new Size(191, 84);
    ((Control) this.gbStandard).TabIndex = 4;
    this.gbStandard.Text = "Standard";
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(14, 53);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(52, 13);
    this.Label6.TabIndex = 0;
    this.Label6.Text = "Renewal:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(14, 25);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(32 /*0x20*/, 13);
    this.Label5.TabIndex = 1;
    this.Label5.Text = "New:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtNewCommission).Appearance = (AppearanceBase) appearance7;
    ((Control) this.txtNewCommission).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.CompanyCommNew", true));
    ((UltraNumericEditorBase) this.txtNewCommission).FormatString = "#.#########%";
    ((Control) this.txtNewCommission).Location = new Point(77, 21);
    this.txtNewCommission.MaskInput = "n.nnnnnnnnn";
    this.txtNewCommission.MaxValue = (object) 1;
    this.txtNewCommission.MGAStyle = MGAStyles.Blue;
    this.txtNewCommission.MinValue = (object) 0;
    ((Control) this.txtNewCommission).Name = "txtNewCommission";
    this.txtNewCommission.Nullable = true;
    this.txtNewCommission.NumericType = (NumericType) 1;
    ((UltraNumericEditorBase) this.txtNewCommission).PromptChar = ' ';
    ((Control) this.txtNewCommission).Size = new Size(88, 20);
    ((Control) this.txtNewCommission).TabIndex = 2;
    ((UltraControlBase) this.txtNewCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNewCommission).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtRenewCommission).Appearance = (AppearanceBase) appearance8;
    ((Control) this.txtRenewCommission).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.CompanyCommRenewal", true));
    ((UltraNumericEditorBase) this.txtRenewCommission).FormatString = "#.#########%";
    ((Control) this.txtRenewCommission).Location = new Point(77, 49);
    this.txtRenewCommission.MaskInput = "n.nnnnnnnnn";
    this.txtRenewCommission.MaxValue = (object) 1;
    this.txtRenewCommission.MGAStyle = MGAStyles.Blue;
    this.txtRenewCommission.MinValue = (object) 0;
    ((Control) this.txtRenewCommission).Name = "txtRenewCommission";
    this.txtRenewCommission.Nullable = true;
    this.txtRenewCommission.NumericType = (NumericType) 1;
    ((UltraNumericEditorBase) this.txtRenewCommission).PromptChar = ' ';
    ((Control) this.txtRenewCommission).Size = new Size(88, 20);
    ((Control) this.txtRenewCommission).TabIndex = 3;
    ((UltraControlBase) this.txtRenewCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRenewCommission).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gbAdditive).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.gbAdditive.BackColorInternal = Color.Transparent;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbAdditive.ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.gbAdditive).Controls.Add((Control) this.txtAdditiveMin);
    ((Control) this.gbAdditive).Controls.Add((Control) this.txtAdditiveMax);
    ((Control) this.gbAdditive).Controls.Add((Control) this.txtAdditiveSpread);
    ((Control) this.gbAdditive).Controls.Add((Control) this.Label8);
    ((Control) this.gbAdditive).Controls.Add((Control) this.Label10);
    ((Control) this.gbAdditive).Controls.Add((Control) this.Label9);
    appearance10.ForeColor = Color.Navy;
    this.gbAdditive.HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.gbAdditive).Location = new Point(213, 51);
    ((Control) this.gbAdditive).Name = "gbAdditive";
    ((Control) this.gbAdditive).Size = new Size(340, 84);
    ((Control) this.gbAdditive).TabIndex = 5;
    this.gbAdditive.Text = "Additive";
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtAdditiveMin).Appearance = (AppearanceBase) appearance11;
    ((UltraNumericEditorBase) this.txtAdditiveMin).BackColor = SystemColors.Window;
    ((Control) this.txtAdditiveMin).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.AdditiveMinimum", true));
    ((UltraNumericEditorBase) this.txtAdditiveMin).FormatString = ".####%";
    ((Control) this.txtAdditiveMin).Location = new Point(70, 21);
    this.txtAdditiveMin.MaskInput = ".nnnn";
    this.txtAdditiveMin.MaxValue = (object) 0.9999;
    this.txtAdditiveMin.MGAStyle = MGAStyles.Blue;
    this.txtAdditiveMin.MinValue = (object) 0;
    ((Control) this.txtAdditiveMin).Name = "txtAdditiveMin";
    this.txtAdditiveMin.Nullable = true;
    this.txtAdditiveMin.NumericType = (NumericType) 1;
    ((Control) this.txtAdditiveMin).Size = new Size(67, 20);
    ((Control) this.txtAdditiveMin).TabIndex = 0;
    ((UltraControlBase) this.txtAdditiveMin).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditiveMin).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.Window;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtAdditiveMax).Appearance = (AppearanceBase) appearance12;
    ((UltraNumericEditorBase) this.txtAdditiveMax).BackColor = SystemColors.Window;
    ((Control) this.txtAdditiveMax).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.AdditiveMaximum", true));
    ((UltraNumericEditorBase) this.txtAdditiveMax).FormatString = ".####%";
    ((Control) this.txtAdditiveMax).Location = new Point(166, 21);
    this.txtAdditiveMax.MaskInput = ".nnnn";
    this.txtAdditiveMax.MaxValue = (object) 0.9999;
    this.txtAdditiveMax.MGAStyle = MGAStyles.Blue;
    this.txtAdditiveMax.MinValue = (object) 0;
    ((Control) this.txtAdditiveMax).Name = "txtAdditiveMax";
    this.txtAdditiveMax.Nullable = true;
    this.txtAdditiveMax.NumericType = (NumericType) 1;
    ((Control) this.txtAdditiveMax).Size = new Size(67, 20);
    ((Control) this.txtAdditiveMax).TabIndex = 1;
    ((UltraControlBase) this.txtAdditiveMax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditiveMax).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtAdditiveSpread).Appearance = (AppearanceBase) appearance13;
    ((Control) this.txtAdditiveSpread).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.AdditiveSpread", true));
    ((UltraNumericEditorBase) this.txtAdditiveSpread).FormatString = ".####%";
    ((Control) this.txtAdditiveSpread).Location = new Point(70, 49);
    this.txtAdditiveSpread.MaskInput = ".nnnn";
    this.txtAdditiveSpread.MaxValue = (object) 0.9999;
    this.txtAdditiveSpread.MGAStyle = MGAStyles.Blue;
    this.txtAdditiveSpread.MinValue = (object) 0;
    ((Control) this.txtAdditiveSpread).Name = "txtAdditiveSpread";
    this.txtAdditiveSpread.Nullable = true;
    this.txtAdditiveSpread.NumericType = (NumericType) 1;
    ((Control) this.txtAdditiveSpread).Size = new Size(67, 20);
    ((Control) this.txtAdditiveSpread).TabIndex = 2;
    ((UltraControlBase) this.txtAdditiveSpread).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditiveSpread).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.Location = new Point(8, 25);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(56, 12);
    this.Label8.TabIndex = 3;
    this.Label8.Text = "Min/Max:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.Label10.AutoSize = true;
    this.Label10.Location = new Point(13, 53);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(45, 13);
    this.Label10.TabIndex = 4;
    this.Label10.Text = "Spread:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Tahoma", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(143, 20);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(17, 23);
    this.Label9.TabIndex = 5;
    this.Label9.Text = "-";
    this.Label9.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.groupProducerCommissions).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupProducerCommissions.Appearance = (AppearanceBase) appearance14;
    this.groupProducerCommissions.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance15.BackColor = Color.FromArgb(239, 247, 253);
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupProducerCommissions.ContentAreaAppearance = (AppearanceBase) appearance15;
    ((Control) this.groupProducerCommissions).Controls.Add((Control) this.txtProducerNewCommission);
    ((Control) this.groupProducerCommissions).Controls.Add((Control) this.txtProducerNewCommissionMax);
    ((Control) this.groupProducerCommissions).Controls.Add((Control) this.txtProducerRenewCommission);
    ((Control) this.groupProducerCommissions).Controls.Add((Control) this.txtProducerRenewCommissionMax);
    ((Control) this.groupProducerCommissions).Controls.Add((Control) this.Label22);
    ((Control) this.groupProducerCommissions).Controls.Add((Control) this.Label21);
    ((Control) this.groupProducerCommissions).Controls.Add((Control) this.Label12);
    ((Control) this.groupProducerCommissions).Controls.Add((Control) this.Label11);
    ((Control) this.groupProducerCommissions).Enabled = false;
    appearance16.ForeColor = Color.FromArgb(21, 66, 139);
    this.groupProducerCommissions.HeaderAppearance = (AppearanceBase) appearance16;
    ((Control) this.groupProducerCommissions).Location = new Point(8, 465);
    ((Control) this.groupProducerCommissions).Name = "groupProducerCommissions";
    ((Control) this.groupProducerCommissions).Size = new Size(629, 113);
    ((Control) this.groupProducerCommissions).TabIndex = 3;
    this.groupProducerCommissions.Text = "Producer Commissions";
    this.groupProducerCommissions.ViewStyle = (GroupBoxViewStyle) 2;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducerNewCommission).Appearance = (AppearanceBase) appearance17;
    ((Control) this.txtProducerNewCommission).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.ProducerCommNew", true));
    ((UltraNumericEditorBase) this.txtProducerNewCommission).FormatString = "#.#########%";
    ((Control) this.txtProducerNewCommission).Location = new Point(72, 48 /*0x30*/);
    this.txtProducerNewCommission.MaskInput = "n.nnnnnnnnn";
    this.txtProducerNewCommission.MaxValue = (object) 1;
    this.txtProducerNewCommission.MGAStyle = MGAStyles.Blue;
    this.txtProducerNewCommission.MinValue = (object) 0;
    ((Control) this.txtProducerNewCommission).Name = "txtProducerNewCommission";
    this.txtProducerNewCommission.Nullable = true;
    this.txtProducerNewCommission.NumericType = (NumericType) 2;
    ((UltraNumericEditorBase) this.txtProducerNewCommission).PromptChar = ' ';
    ((Control) this.txtProducerNewCommission).Size = new Size(88, 20);
    ((Control) this.txtProducerNewCommission).TabIndex = 0;
    ((UltraControlBase) this.txtProducerNewCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerNewCommission).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducerNewCommissionMax).Appearance = (AppearanceBase) appearance18;
    ((Control) this.txtProducerNewCommissionMax).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.ProducerCommNewMax", true));
    ((UltraNumericEditorBase) this.txtProducerNewCommissionMax).FormatString = "#.#########%";
    ((Control) this.txtProducerNewCommissionMax).Location = new Point(194, 48 /*0x30*/);
    this.txtProducerNewCommissionMax.MaskInput = "n.nnnnnnnnn";
    this.txtProducerNewCommissionMax.MaxValue = (object) 1;
    this.txtProducerNewCommissionMax.MGAStyle = MGAStyles.Blue;
    this.txtProducerNewCommissionMax.MinValue = (object) 0;
    ((Control) this.txtProducerNewCommissionMax).Name = "txtProducerNewCommissionMax";
    this.txtProducerNewCommissionMax.Nullable = true;
    this.txtProducerNewCommissionMax.NumericType = (NumericType) 1;
    ((UltraNumericEditorBase) this.txtProducerNewCommissionMax).PromptChar = ' ';
    ((Control) this.txtProducerNewCommissionMax).Size = new Size(88, 20);
    ((Control) this.txtProducerNewCommissionMax).TabIndex = 1;
    ((UltraControlBase) this.txtProducerNewCommissionMax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerNewCommissionMax).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducerRenewCommission).Appearance = (AppearanceBase) appearance19;
    ((Control) this.txtProducerRenewCommission).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.ProducerCommRenewal", true));
    ((UltraNumericEditorBase) this.txtProducerRenewCommission).FormatString = "#.#########%";
    ((Control) this.txtProducerRenewCommission).Location = new Point(72, 80 /*0x50*/);
    this.txtProducerRenewCommission.MaskInput = "n.nnnnnnnnn";
    this.txtProducerRenewCommission.MaxValue = (object) 1;
    this.txtProducerRenewCommission.MGAStyle = MGAStyles.Blue;
    this.txtProducerRenewCommission.MinValue = (object) 0;
    ((Control) this.txtProducerRenewCommission).Name = "txtProducerRenewCommission";
    this.txtProducerRenewCommission.Nullable = true;
    this.txtProducerRenewCommission.NumericType = (NumericType) 1;
    ((UltraNumericEditorBase) this.txtProducerRenewCommission).PromptChar = ' ';
    ((Control) this.txtProducerRenewCommission).Size = new Size(88, 20);
    ((Control) this.txtProducerRenewCommission).TabIndex = 2;
    ((UltraControlBase) this.txtProducerRenewCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerRenewCommission).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducerRenewCommissionMax).Appearance = (AppearanceBase) appearance20;
    ((Control) this.txtProducerRenewCommissionMax).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.ProducerCommRenewalMax", true));
    ((UltraNumericEditorBase) this.txtProducerRenewCommissionMax).FormatString = "#.######%";
    ((Control) this.txtProducerRenewCommissionMax).Location = new Point(194, 80 /*0x50*/);
    this.txtProducerRenewCommissionMax.MaskInput = "n.nnnnnnnnn";
    this.txtProducerRenewCommissionMax.MaxValue = (object) 1;
    this.txtProducerRenewCommissionMax.MGAStyle = MGAStyles.Blue;
    this.txtProducerRenewCommissionMax.MinValue = (object) 0;
    ((Control) this.txtProducerRenewCommissionMax).Name = "txtProducerRenewCommissionMax";
    this.txtProducerRenewCommissionMax.Nullable = true;
    this.txtProducerRenewCommissionMax.NumericType = (NumericType) 1;
    ((UltraNumericEditorBase) this.txtProducerRenewCommissionMax).PromptChar = ' ';
    ((Control) this.txtProducerRenewCommissionMax).Size = new Size(88, 20);
    ((Control) this.txtProducerRenewCommissionMax).TabIndex = 3;
    ((UltraControlBase) this.txtProducerRenewCommissionMax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerRenewCommissionMax).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(210, 24);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(42, 16 /*0x10*/);
    this.Label22.TabIndex = 4;
    this.Label22.Text = "Max";
    this.Label22.TextAlign = ContentAlignment.MiddleCenter;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(90, 24);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(42, 16 /*0x10*/);
    this.Label21.TabIndex = 5;
    this.Label21.Text = "Default";
    this.Label21.TextAlign = ContentAlignment.MiddleCenter;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(12, 52);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(32 /*0x20*/, 13);
    this.Label12.TabIndex = 6;
    this.Label12.Text = "New:";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(12, 84);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(52, 13);
    this.Label11.TabIndex = 7;
    this.Label11.Text = "Renewal:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.groupGeneralInfo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupGeneralInfo.Appearance = (AppearanceBase) appearance21;
    this.groupGeneralInfo.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance22.BackColor = Color.FromArgb(239, 247, 253);
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupGeneralInfo.ContentAreaAppearance = (AppearanceBase) appearance22;
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.Label1);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.Label2);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.Label4);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.Label3);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.dtpEffective);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.comboExpiringCarrier);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.buttonRefreshCompanies);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.comboPolicyTypes);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.cboProgramCode);
    ((Control) this.groupGeneralInfo).Controls.Add((Control) this.chkKeepExpiringOnRenewal);
    ((Control) this.groupGeneralInfo).Enabled = false;
    appearance23.ForeColor = Color.FromArgb(21, 66, 139);
    this.groupGeneralInfo.HeaderAppearance = (AppearanceBase) appearance23;
    ((Control) this.groupGeneralInfo).Location = new Point(8, 212);
    ((Control) this.groupGeneralInfo).Name = "groupGeneralInfo";
    ((Control) this.groupGeneralInfo).Size = new Size(629, 100);
    ((Control) this.groupGeneralInfo).TabIndex = 1;
    this.groupGeneralInfo.Text = "General Information";
    this.groupGeneralInfo.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(13, 26);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(54, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Effective:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(12, 53);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(65, 13);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Policy Type:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(244, 53);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(79, 13);
    this.Label4.TabIndex = 2;
    this.Label4.Text = "Program Code:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(244, 26);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(85, 13);
    this.Label3.TabIndex = 3;
    this.Label3.Text = "Expiring Carrier:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpEffective.Appearance = (AppearanceBase) appearance24;
    appearance25.AlphaLevel = (short) 14;
    appearance25.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance25.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance25.BackColorAlpha = (Alpha) 2;
    appearance25.BackGradientAlignment = (GradientAlignment) 4;
    appearance25.BackGradientStyle = (GradientStyle) 5;
    appearance25.BorderAlpha = (Alpha) 1;
    appearance25.BorderColor = Color.FromArgb(78, 122, 171);
    appearance25.ForeColor = Color.FromArgb(49, 85, 153);
    appearance25.ForegroundAlpha = (Alpha) 2;
    this.dtpEffective.ButtonAppearance = (AppearanceBase) appearance25;
    this.dtpEffective.DateTime = new DateTime(2017, 9, 11, 0, 0, 0, 0);
    ((Control) this.dtpEffective).Location = new Point(93, 22);
    this.dtpEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpEffective).Name = "dtpEffective";
    this.dtpEffective.Nullable = false;
    ((Control) this.dtpEffective).Size = new Size(88, 20);
    ((Control) this.dtpEffective).TabIndex = 4;
    ((UltraControlBase) this.dtpEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpEffective.Value = (object) new DateTime(2017, 9, 11, 0, 0, 0, 0);
    this.comboExpiringCarrier.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboExpiringCarrier).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.ExpiringCompanyLocationGuid", true));
    ((UltraGridBase) this.comboExpiringCarrier).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.comboExpiringCarrier).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboExpiringCarrier).DisplayMember = "LocationName";
    this.comboExpiringCarrier.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboExpiringCarrier).DropDownWidth = 450;
    ((Control) this.comboExpiringCarrier).Location = new Point(339, 22);
    this.comboExpiringCarrier.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboExpiringCarrier).Name = "comboExpiringCarrier";
    this.comboExpiringCarrier.NullText = "Any";
    ((Control) this.comboExpiringCarrier).Size = new Size(244, 21);
    ((Control) this.comboExpiringCarrier).TabIndex = 5;
    ((UltraControlBase) this.comboExpiringCarrier).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboExpiringCarrier).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboExpiringCarrier).ValueMember = "CompanyLocationGUID";
    appearance26.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance25.Image"));
    ((ControlBase) this.buttonRefreshCompanies).Appearance = (AppearanceBase) appearance26;
    ((AutoSizeControlBase) this.buttonRefreshCompanies).AutoSize = true;
    ((Control) this.buttonRefreshCompanies).Location = new Point(589, 20);
    ((Control) this.buttonRefreshCompanies).Name = "buttonRefreshCompanies";
    ((Control) this.buttonRefreshCompanies).Size = new Size(24, 24);
    ((Control) this.buttonRefreshCompanies).TabIndex = 6;
    ultraToolTipInfo.ToolTipText = "Refresh Company List";
    this.toolTip.SetUltraToolTip((Control) this.buttonRefreshCompanies, ultraToolTipInfo);
    ((UltraControlBase) this.buttonRefreshCompanies).UseFlatMode = (DefaultableBoolean) 1;
    this.comboPolicyTypes.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboPolicyTypes).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.PolicyTypeID", true));
    ((UltraGridBase) this.comboPolicyTypes).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.comboPolicyTypes).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboPolicyTypes).DisplayMember = "Description";
    this.comboPolicyTypes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboPolicyTypes).DropDownWidth = 300;
    ((Control) this.comboPolicyTypes).Location = new Point(91, 49);
    this.comboPolicyTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPolicyTypes).Name = "comboPolicyTypes";
    this.comboPolicyTypes.NullText = "Any";
    ((Control) this.comboPolicyTypes).Size = new Size(131, 21);
    ((Control) this.comboPolicyTypes).TabIndex = 7;
    ((UltraControlBase) this.comboPolicyTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPolicyTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboPolicyTypes).ValueMember = "PolicyTypeID";
    this.cboProgramCode.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProgramCode).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCommissions.ProgramID", true));
    ((UltraGridBase) this.cboProgramCode).DataMember = "tblCompanyProgramCodes";
    ((UltraGridBase) this.cboProgramCode).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboProgramCode).DisplayMember = "ProgCode";
    this.cboProgramCode.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProgramCode).DropDownWidth = 450;
    ((Control) this.cboProgramCode).Location = new Point(339, 49);
    this.cboProgramCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProgramCode).Name = "cboProgramCode";
    this.cboProgramCode.NullText = "Any";
    ((Control) this.cboProgramCode).Size = new Size(244, 21);
    ((Control) this.cboProgramCode).TabIndex = 8;
    ((UltraControlBase) this.cboProgramCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProgramCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProgramCode).ValueMember = "ProgramID";
    appearance27.BorderColor = Color.Gray;
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).BackColorInternal = Color.Transparent;
    ((Control) this.chkKeepExpiringOnRenewal).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineCommissions.KeepExpiringCommissionsOnRenewal", true));
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkKeepExpiringOnRenewal).Location = new Point(93, 77);
    ((Control) this.chkKeepExpiringOnRenewal).Name = "chkKeepExpiringOnRenewal";
    ((Control) this.chkKeepExpiringOnRenewal).Size = new Size(261, 15);
    ((Control) this.chkKeepExpiringOnRenewal).TabIndex = 9;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).Text = "Keep Expiring Policy Commissions on Renewal";
    ((UltraControlBase) this.chkKeepExpiringOnRenewal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkKeepExpiringOnRenewal).UseOsThemes = (DefaultableBoolean) 2;
    this.cn.ConnectionString = "Data Source=10.0.0.52;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.da.AcceptChangesDuringUpdate = false;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineCommissions", new DataColumnMapping[18]
      {
        new DataColumnMapping("CommissionID", "CommissionID"),
        new DataColumnMapping("Effective", "Effective"),
        new DataColumnMapping("CompanyCommNew", "CompanyCommNew"),
        new DataColumnMapping("CompanyCommRenewal", "CompanyCommRenewal"),
        new DataColumnMapping("ProducerCommNew", "ProducerCommNew"),
        new DataColumnMapping("ProducerCommRenewal", "ProducerCommRenewal"),
        new DataColumnMapping("ProducerCommNewMax", "ProducerCommNewMax"),
        new DataColumnMapping("ProducerCommRenewalMax", "ProducerCommRenewalMax"),
        new DataColumnMapping("UsingAdditiveCommission", "UsingAdditiveCommission"),
        new DataColumnMapping("AdditiveMinimum", "AdditiveMinimum"),
        new DataColumnMapping("AdditiveMaximum", "AdditiveMaximum"),
        new DataColumnMapping("AdditiveSpread", "AdditiveSpread"),
        new DataColumnMapping("LockedCommissions", "LockedCommissions"),
        new DataColumnMapping("CompanyLineID", "CompanyLineID"),
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("ExpiringCompanyLocationGuid", "ExpiringCompanyLocationGuid"),
        new DataColumnMapping("ProgramID", "ProgramID"),
        new DataColumnMapping("KeepExpiringCommissionsOnRenewal", "KeepExpiringCommissionsOnRenewal")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblCompanyLineCommissions] WHERE (([CommissionID] = @Original_CommissionID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_CommissionID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CommissionID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[17]
    {
      new SqlParameter("@Effective", SqlDbType.DateTime, 0, "Effective"),
      new SqlParameter("@CompanyCommNew", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "CompanyCommNew", DataRowVersion.Current, (object) null),
      new SqlParameter("@CompanyCommRenewal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "CompanyCommRenewal", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProducerCommNew", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommNew", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProducerCommRenewal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommRenewal", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProducerCommNewMax", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommNewMax", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProducerCommRenewalMax", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommRenewalMax", DataRowVersion.Current, (object) null),
      new SqlParameter("@UsingAdditiveCommission", SqlDbType.Bit, 0, "UsingAdditiveCommission"),
      new SqlParameter("@AdditiveMinimum", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "AdditiveMinimum", DataRowVersion.Current, (object) null),
      new SqlParameter("@AdditiveMaximum", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "AdditiveMaximum", DataRowVersion.Current, (object) null),
      new SqlParameter("@AdditiveSpread", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "AdditiveSpread", DataRowVersion.Current, (object) null),
      new SqlParameter("@LockedCommissions", SqlDbType.Bit, 0, "LockedCommissions"),
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 0, "CompanyLineID"),
      new SqlParameter("@PolicyTypeID", SqlDbType.TinyInt, 0, "PolicyTypeID"),
      new SqlParameter("@ExpiringCompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "ExpiringCompanyLocationGuid"),
      new SqlParameter("@ProgramID", SqlDbType.Int, 0, "ProgramID"),
      new SqlParameter("@KeepExpiringCommissionsOnRenewal", SqlDbType.Bit, 0, "KeepExpiringCommissionsOnRenewal")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[19]
    {
      new SqlParameter("@Effective", SqlDbType.DateTime, 0, "Effective"),
      new SqlParameter("@CompanyCommNew", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "CompanyCommNew", DataRowVersion.Current, (object) null),
      new SqlParameter("@CompanyCommRenewal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "CompanyCommRenewal", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProducerCommNew", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommNew", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProducerCommRenewal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommRenewal", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProducerCommNewMax", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommNewMax", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProducerCommRenewalMax", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommRenewalMax", DataRowVersion.Current, (object) null),
      new SqlParameter("@UsingAdditiveCommission", SqlDbType.Bit, 0, "UsingAdditiveCommission"),
      new SqlParameter("@AdditiveMinimum", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "AdditiveMinimum", DataRowVersion.Current, (object) null),
      new SqlParameter("@AdditiveMaximum", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "AdditiveMaximum", DataRowVersion.Current, (object) null),
      new SqlParameter("@AdditiveSpread", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 10, "AdditiveSpread", DataRowVersion.Current, (object) null),
      new SqlParameter("@LockedCommissions", SqlDbType.Bit, 0, "LockedCommissions"),
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 0, "CompanyLineID"),
      new SqlParameter("@PolicyTypeID", SqlDbType.TinyInt, 0, "PolicyTypeID"),
      new SqlParameter("@ExpiringCompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "ExpiringCompanyLocationGuid"),
      new SqlParameter("@ProgramID", SqlDbType.Int, 0, "ProgramID"),
      new SqlParameter("@KeepExpiringCommissionsOnRenewal", SqlDbType.Bit, 0, "KeepExpiringCommissionsOnRenewal"),
      new SqlParameter("@Original_CommissionID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CommissionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@CommissionID", SqlDbType.Int, 4, "CommissionID")
    });
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(525, 584);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 4;
    this.err.ContainerControl = (ContainerControl) this;
    this.toolTip.ContainingControl = (Control) this;
    this.toolTip.DisplayStyle = (ToolTipDisplayStyle) 4;
    ((Control) this.UltraGrid1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.tblCompanyLineCommissions;
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 18;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Format = "d";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.LockedWidth = true;
    ultraGridColumn2.Width = 78;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance29;
    ultraGridColumn3.Format = "p4";
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance30;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Comp New";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.LockedWidth = true;
    ultraGridColumn3.Width = 90;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance31;
    ultraGridColumn4.Format = "p4";
    ((AppearanceBase) appearance32).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance32;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Comp Renewal";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.LockedWidth = true;
    ultraGridColumn4.Width = 106;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance33;
    ultraGridColumn5.Format = "p4";
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance34;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Prod New";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.LockedWidth = true;
    ultraGridColumn5.Width = 86;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance35;
    ultraGridColumn6.Format = "p4";
    ((AppearanceBase) appearance36).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance36;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Prod Renewal";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.LockedWidth = true;
    ultraGridColumn6.Width = 98;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance38;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 43;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance40;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 49;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Additive";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.LockedWidth = true;
    ultraGridColumn9.Width = 72;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 33;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 34;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 29;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 67;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 29;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 72;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 137;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 65;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Keep On Renewal";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.LockedWidth = true;
    ultraGridColumn18.Width = 97;
    ultraGridBand.Columns.AddRange(new object[18]
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
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance41.BackColor = Color.LightSteelBlue;
    appearance41.FontData.SizeInPoints = 10f;
    appearance41.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance41;
    appearance42.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance42.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance43.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance44.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance45.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance45;
    appearance46.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance47.BackColor = Color.Transparent;
    appearance47.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance47;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Location = new Point(8, 8);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(629, 198);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((Control) this.UltraGrid1).Text = "Historical Commissions Setup";
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(647, 636);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Controls.Add((Control) this.groupGeneralInfo);
    this.Controls.Add((Control) this.groupCompanyCommissions);
    this.Controls.Add((Control) this.groupProducerCommissions);
    this.Controls.Add((Control) this.dbSave);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCompanyLineCommissions);
    this.Text = "Company/Line Commissions";
    ((ISupportInitialize) this.groupCompanyCommissions).EndInit();
    ((Control) this.groupCompanyCommissions).ResumeLayout(false);
    ((ISupportInitialize) this.chkLockedCommissions).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.gbStandard).EndInit();
    ((Control) this.gbStandard).ResumeLayout(false);
    ((Control) this.gbStandard).PerformLayout();
    ((ISupportInitialize) this.txtNewCommission).EndInit();
    ((ISupportInitialize) this.txtRenewCommission).EndInit();
    ((ISupportInitialize) this.gbAdditive).EndInit();
    ((Control) this.gbAdditive).ResumeLayout(false);
    ((Control) this.gbAdditive).PerformLayout();
    ((ISupportInitialize) this.txtAdditiveMin).EndInit();
    ((ISupportInitialize) this.txtAdditiveMax).EndInit();
    ((ISupportInitialize) this.txtAdditiveSpread).EndInit();
    ((ISupportInitialize) this.groupProducerCommissions).EndInit();
    ((Control) this.groupProducerCommissions).ResumeLayout(false);
    ((Control) this.groupProducerCommissions).PerformLayout();
    ((ISupportInitialize) this.txtProducerNewCommission).EndInit();
    ((ISupportInitialize) this.txtProducerNewCommissionMax).EndInit();
    ((ISupportInitialize) this.txtProducerRenewCommission).EndInit();
    ((ISupportInitialize) this.txtProducerRenewCommissionMax).EndInit();
    ((ISupportInitialize) this.groupGeneralInfo).EndInit();
    ((Control) this.groupGeneralInfo).ResumeLayout(false);
    ((Control) this.groupGeneralInfo).PerformLayout();
    ((ISupportInitialize) this.dtpEffective).EndInit();
    ((ISupportInitialize) this.comboExpiringCarrier).EndInit();
    ((ISupportInitialize) this.comboPolicyTypes).EndInit();
    ((ISupportInitialize) this.cboProgramCode).EndInit();
    ((ISupportInitialize) this.chkKeepExpiringOnRenewal).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ResumeLayout(false);
  }

  private virtual BindingManagerBase _bmb
  {
    get => this.__bmb;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this._bmb_PositionChanged);
      BindingManagerBase bmb1 = this.__bmb;
      if (bmb1 != null)
        bmb1.PositionChanged -= eventHandler;
      this.__bmb = value;
      BindingManagerBase bmb2 = this.__bmb;
      if (bmb2 == null)
        return;
      bmb2.PositionChanged += eventHandler;
    }
  }

  public frmCompanyLineCommissions(int companyLineID)
  {
    this.Load += new EventHandler(this.frmCompanyLineCommissions_Load);
    this._saveSuccess = true;
    this._KeepExpiringCommissionsOnRenewal = false;
    this.InitializeComponent();
    this._companyLineID = companyLineID;
    this._companyLine = new CompanyLine(companyLineID);
  }

  private void frmCompanyLineCommissions_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    try
    {
      foreach (Control control1 in this.Controls)
      {
        if (control1 is MGAGroupBox)
        {
          try
          {
            foreach (Control control2 in control1.Controls)
              control2.BindingContext = this.BindingContext;
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
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
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblCompanyLineCommissions.TableName];
    this.da.SelectCommand.Parameters["@CompanyLineID"].Value = (object) this._companyLineID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineCommissions);
    this.LoadData(frmCompanyLineCommissions._tblCompanyLocationsCache == null);
    if (frmCompanyLineCommissions._tblCompanyLocationsCache != null)
    {
      this.ds.tblCompanyLocations.Load((IDataReader) frmCompanyLineCommissions._tblCompanyLocationsCache.CreateDataReader());
    }
    else
    {
      frmCompanyLineCommissions._tblCompanyLocationsCache = new dsCompanyLineCommissions.tblCompanyLocationsDataTable();
      frmCompanyLineCommissions._tblCompanyLocationsCache.Load((IDataReader) this.ds.tblCompanyLocations.CreateDataReader());
    }
    if (SystemSettings.KeyExists("SetCompanyLineExpCommOnRenewal"))
      this._KeepExpiringCommissionsOnRenewal = SystemSettings.GetBoolSetting("SetCompanyLineExpCommOnRenewal");
    if (this.ds.tblCompanyLineCommissions.Rows.Count > 0)
    {
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    else
    {
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
      this.SetDefaultInputs();
    }
    this.OnFormLoad();
    this.dbSave.UIStateChanged += new EventHandler(this.dbSave_UIStateChanged);
  }

  private void LoadData(bool loadCompanies)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      this.ds.lstPolicyTypes.TableName,
      this.ds.tblCompanyLocations.TableName,
      this.ds.tblCompanyProgramCodes.TableName
    }, "dbo.GetCommissionsAdminData", new object[4]
    {
      (object) "@loadCompanies",
      (object) loadCompanies,
      (object) "@CompanyLineID",
      (object) this._companyLineID
    });
  }

  private void UltraGrid1_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.UltraGrid1).ActiveRow == null)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["CommissionID"].Value), "CommissionID", (DataTable) this.ds.tblCompanyLineCommissions, this._bmb);
    this.dtpEffective.DateTime = this.ds.tblCompanyLineCommissions[this._bmb.Position].Effective;
    this.SetAdditiveLayout();
  }

  private void txtProducerNewCommission_Validated(object sender, EventArgs e)
  {
    if (this.txtProducerNewCommission.Value == DBNull.Value || this.ds.tblCompanyLineCommissions[this._bmb.Position].RowState != DataRowState.Added)
      return;
    Decimal num = Conversions.ToDecimal(this.txtProducerNewCommission.Value);
    this.txtProducerNewCommissionMax.Value = (object) num;
    this.txtProducerRenewCommission.Value = (object) num;
    this.txtProducerRenewCommissionMax.Value = (object) num;
    dsCompanyLineCommissions.tblCompanyLineCommissionsRow companyLineCommission = this.ds.tblCompanyLineCommissions[this._bmb.Position];
    companyLineCommission.ProducerCommNewMax = num;
    companyLineCommission.ProducerCommRenewal = num;
    companyLineCommission.ProducerCommRenewalMax = num;
  }

  private void rbAdditive_CheckedChanged(object sender, EventArgs e)
  {
    if (((Control) this.UltraGrid1).Enabled)
      return;
    this.ds.tblCompanyLineCommissions[this._bmb.Position].UsingAdditiveCommission = this.rbAdditive.Checked;
    this.SetAdditiveLayout();
  }

  private void SetAdditiveLayout()
  {
    bool additiveCommission = this.ds.tblCompanyLineCommissions[this._bmb.Position].UsingAdditiveCommission;
    ((Control) this.txtNewCommission).Enabled = !additiveCommission;
    ((Control) this.txtRenewCommission).Enabled = !additiveCommission;
    ((Control) this.txtAdditiveMax).Enabled = additiveCommission;
    ((Control) this.txtAdditiveMin).Enabled = additiveCommission;
    ((Control) this.txtAdditiveSpread).Enabled = additiveCommission;
    dsCompanyLineCommissions.tblCompanyLineCommissionsRow companyLineCommission = this.ds.tblCompanyLineCommissions[this._bmb.Position];
    if (additiveCommission)
    {
      this.ClearCompanyCommissionStandardErrors();
      this.txtNewCommission.Value = (object) DBNull.Value;
      this.txtRenewCommission.Value = (object) DBNull.Value;
    }
    else
    {
      this.ClearCompanyCommissionAdditiveErrors();
      this.txtAdditiveMin.Value = (object) DBNull.Value;
      this.txtAdditiveMax.Value = (object) DBNull.Value;
      this.txtAdditiveSpread.Value = (object) DBNull.Value;
    }
  }

  private void _bmb_PositionChanged(object sender, EventArgs e)
  {
    if (this.ds.tblCompanyLineCommissions.Count <= 0 || this._bmb.Position == -1)
      return;
    if (this.ds.tblCompanyLineCommissions[this._bmb.Position].UsingAdditiveCommission)
      this.rbAdditive.Checked = true;
    else
      this.rbStandard.Checked = true;
  }

  private bool IsValidForm()
  {
    bool flag1 = true;
    bool flag2 = false;
    try
    {
      foreach (dsCompanyLineCommissions.tblCompanyLineCommissionsRow companyLineCommission in (TypedTableBase<dsCompanyLineCommissions.tblCompanyLineCommissionsRow>) this.ds.tblCompanyLineCommissions)
      {
        if (companyLineCommission.RowState != DataRowState.Deleted)
        {
          DateTime dateTime = companyLineCommission.Effective;
          DateTime date1 = dateTime.Date;
          dateTime = this.dtpEffective.DateTime;
          DateTime date2 = dateTime.Date;
          if (DateTime.Compare(date1, date2) == 0 && (companyLineCommission.IsPolicyTypeIDNull() && this.comboPolicyTypes.Value == null || !companyLineCommission.IsPolicyTypeIDNull() && companyLineCommission.PolicyTypeID == Conversions.ToInteger(this.comboPolicyTypes.Value)) && (companyLineCommission.IsProgramIDNull() && this.cboProgramCode.Value == null || !companyLineCommission.IsProgramIDNull() && companyLineCommission.ProgramID == Conversions.ToInteger(this.cboProgramCode.Value)) && (companyLineCommission.IsExpiringCompanyLocationGuidNull() && this.comboExpiringCarrier.Value == null || !companyLineCommission.IsExpiringCompanyLocationGuidNull() && companyLineCommission.ExpiringCompanyLocationGuid.Equals(new Guid(this.comboExpiringCarrier.Value.ToString()))) && companyLineCommission != this.ds.tblCompanyLineCommissions[this._bmb.Position])
          {
            flag2 = true;
            break;
          }
        }
      }
    }
    finally
    {
      IEnumerator<dsCompanyLineCommissions.tblCompanyLineCommissionsRow> enumerator;
      enumerator?.Dispose();
    }
    if (flag2)
    {
      this.err.SetError((Control) this.dtpEffective, "There is already a commission setup for this effective date.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.dtpEffective, string.Empty);
    if (this.txtProducerNewCommission.Value == DBNull.Value || Decimal.Compare(Conversions.ToDecimal(this.txtProducerNewCommission.Value), 0M) < 0 || Decimal.Compare(Conversions.ToDecimal(this.txtProducerNewCommission.Value), 1M) > 0)
    {
      this.err.SetError((Control) this.txtProducerNewCommission, "Please enter a commission value between 0 and 1.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.txtProducerNewCommission, string.Empty);
    if (this.txtProducerRenewCommission.Value == DBNull.Value || Decimal.Compare(Conversions.ToDecimal(this.txtProducerRenewCommission.Value), 0M) < 0 || Decimal.Compare(Conversions.ToDecimal(this.txtProducerRenewCommission.Value), 1M) > 0)
    {
      this.err.SetError((Control) this.txtProducerRenewCommission, "Please enter a commission value between 0 and 1.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.txtProducerRenewCommission, string.Empty);
    if (!this.rbAdditive.Checked)
    {
      if (this.txtNewCommission.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtNewCommission, "Please enter a valid new commission value.");
        flag1 = false;
      }
      else if ((double) Conversions.ToSingle(this.txtNewCommission.Value) > 1.0 || (double) Conversions.ToSingle(this.txtNewCommission.Value) < 0.0)
      {
        this.err.SetError((Control) this.txtNewCommission, "The valid commission range is 0.0 to 1.0, entered as a decimal.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtNewCommission, string.Empty);
      if (this.txtRenewCommission.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtRenewCommission, "Please enter a valid renewal commission value.");
        flag1 = false;
      }
      else if ((double) Conversions.ToSingle(this.txtRenewCommission.Value) > 1.0 || (double) Conversions.ToSingle(this.txtRenewCommission.Value) < 0.0)
      {
        this.err.SetError((Control) this.txtRenewCommission, "The valid commission range is 0.0 to 1.0, entered as a decimal.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtRenewCommission, string.Empty);
    }
    else
    {
      if (this.txtAdditiveMin.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtAdditiveMin, "Please enter the minimum additive commission.");
        flag1 = false;
      }
      else if (Conversions.ToDouble(this.txtAdditiveMin.Value) > 1.0 || Conversions.ToDouble(this.txtAdditiveMin.Value) < 0.0)
      {
        this.err.SetError((Control) this.txtAdditiveMin, "The valid commission range is 0.0 to 1.0, entered as a decimal.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtAdditiveMin, string.Empty);
      if (this.txtAdditiveMax.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtAdditiveMax, "Please enter the maximum additive commission.");
        flag1 = false;
      }
      else if (Conversions.ToDouble(this.txtAdditiveMax.Value) > 1.0 || Conversions.ToDouble(this.txtAdditiveMax.Value) < 0.0)
      {
        this.err.SetError((Control) this.txtAdditiveMax, "The valid commission range is 0.0 to 1.0, entered as a decimal.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtAdditiveMax, string.Empty);
      if (this.txtAdditiveSpread.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtAdditiveSpread, "Please enter the additive commission spread.");
        flag1 = false;
      }
      else if (Conversions.ToDouble(this.txtAdditiveSpread.Value) > 1.0 || Conversions.ToDouble(this.txtAdditiveSpread.Value) < 0.0)
      {
        this.err.SetError((Control) this.txtAdditiveSpread, "The valid commission range is 0.0 to 1.0, entered as a decimal.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtAdditiveSpread, string.Empty);
    }
    return flag1;
  }

  private void ClearAllErrors()
  {
    this.ClearProducerCommissionErrors();
    this.ClearCompanyCommissionStandardErrors();
    this.ClearCompanyCommissionAdditiveErrors();
  }

  private void ClearProducerCommissionErrors()
  {
    this.err.SetError((Control) this.txtProducerNewCommission, string.Empty);
    this.err.SetError((Control) this.txtProducerNewCommissionMax, string.Empty);
    this.err.SetError((Control) this.txtProducerRenewCommission, string.Empty);
    this.err.SetError((Control) this.txtProducerRenewCommissionMax, string.Empty);
  }

  private void ClearCompanyCommissionStandardErrors()
  {
    this.err.SetError((Control) this.txtNewCommission, string.Empty);
    this.err.SetError((Control) this.txtRenewCommission, string.Empty);
  }

  private void ClearCompanyCommissionAdditiveErrors()
  {
    this.err.SetError((Control) this.txtAdditiveMin, string.Empty);
    this.err.SetError((Control) this.txtAdditiveMax, string.Empty);
    this.err.SetError((Control) this.txtAdditiveSpread, string.Empty);
  }

  protected virtual void SetDefaultInputs()
  {
    this.dtpEffective.DateTime = DateAndTime.Now;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).Checked = this._KeepExpiringCommissionsOnRenewal;
    this.rbStandard.Checked = true;
    ((UltraToggleEditorBase) this.chkLockedCommissions).Checked = false;
    ((Control) this.txtNewCommission).Enabled = true;
    ((Control) this.txtRenewCommission).Enabled = true;
    ((Control) this.txtAdditiveMin).Enabled = false;
    ((Control) this.txtAdditiveMax).Enabled = false;
    ((Control) this.txtAdditiveSpread).Enabled = false;
    this.txtNewCommission.Value = (object) DBNull.Value;
    this.txtRenewCommission.Value = (object) DBNull.Value;
    this.txtAdditiveMin.Value = (object) DBNull.Value;
    this.txtAdditiveMax.Value = (object) DBNull.Value;
    this.txtAdditiveSpread.Value = (object) DBNull.Value;
    this.txtProducerNewCommission.Value = (object) DBNull.Value;
    this.txtProducerNewCommissionMax.Value = (object) DBNull.Value;
    this.txtProducerRenewCommission.Value = (object) DBNull.Value;
    this.txtProducerRenewCommissionMax.Value = (object) DBNull.Value;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsCompanyLineCommissions.tblCompanyLineCommissionsRow row = this.ds.tblCompanyLineCommissions.NewtblCompanyLineCommissionsRow();
    row.Effective = DateAndTime.Now;
    row.CompanyLineID = this._companyLineID;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).Checked = this._KeepExpiringCommissionsOnRenewal;
    row.KeepExpiringCommissionsOnRenewal = this._KeepExpiringCommissionsOnRenewal;
    this.ds.tblCompanyLineCommissions.AddtblCompanyLineCommissionsRow(row);
    this._bmb.Position = this.ds.tblCompanyLineCommissions.Count - 1;
    this.SetDefaultInputs();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    DateTime dateTime = this.ds.tblCompanyLineCommissions[this._bmb.Position].Effective;
    DateTime date1 = dateTime.Date;
    dateTime = this.dtpEffective.DateTime;
    DateTime date2 = dateTime.Date;
    if (DateTime.Compare(date1, date2) != 0)
      this.ds.tblCompanyLineCommissions[this._bmb.Position].Effective = this.dtpEffective.DateTime;
    if (!this.IsValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      dsCompanyLineCommissions.tblCompanyLineCommissionsRow companyLineCommission = this.ds.tblCompanyLineCommissions[this._bmb.Position];
      Cursor.Current = MgaCursors.WaitCursor;
      if (companyLineCommission.UsingAdditiveCommission != this.rbAdditive.Checked)
        companyLineCommission.UsingAdditiveCommission = this.rbAdditive.Checked;
      int num1 = -100;
      bool flag1 = this.ds.tblCompanyLineCommissions[this._bmb.Position].RowState == DataRowState.Added;
      if (this.ds.tblCompanyLineCommissions[this._bmb.Position].RowState == DataRowState.Modified)
        flag1 = DateTime.Compare(this.ds.tblCompanyLineCommissions[this._bmb.Position].Effective, Conversions.ToDate(this.ds.tblCompanyLineCommissions[this._bmb.Position][this.ds.tblCompanyLineCommissions.EffectiveColumn.ColumnName, DataRowVersion.Original])) != 0;
      if (flag1)
        this.ds.tblCompanyLineCommissions[this._bmb.Position].Effective = this.ds.tblCompanyLineCommissions[this._bmb.Position].Effective.Date;
      this._bmb.EndCurrentEdit();
      bool flag2 = companyLineCommission.RowState == DataRowState.Added;
      bool flag3 = companyLineCommission.RowState == DataRowState.Modified;
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineCommissions);
        this.ds.tblCompanyLineCommissions.EndLoadData();
        num1 = this.ds.tblCompanyLineCommissions[this._bmb.Position].CommissionID;
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        this._saveSuccess = false;
        if (ex2.Message.Contains("FK_tblCompanyLineCommissions_tblCompanyLines"))
        {
          int num2 = (int) MessageBox.Show("An error occured while trying to save the commission setup.\n\nThe company/line no longer exists.\n\nIf you feel you have received this message in error, please contact technical support.", "Invalid Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
      if (this._saveSuccess && num1 != -100 && MessageBox.Show("Would you like to apply this configuration to other states?", "Apply This Configuration To Other States.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        DefaultDatabase.ExecuteNonQuery("dbo.spUpdateCompanyLineCommissions", new object[2]
        {
          (object) "@commissionID",
          (object) num1
        });
      if (flag2)
        CurrentUser.Instance.LogAction($"Add new commission on the company/line:{this._companyLine.CompanyLineState}. Effective {this.dtpEffective.Value.ToString()}", this._companyLine.CompanyLineGuid, "Company/Line");
      else if (flag3)
      {
        Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
        List<frmCompanyLineCommissions.CommissionsStruct> changeList = new List<frmCompanyLineCommissions.CommissionsStruct>();
        Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
        this.MassageColumnNames(dictionary2);
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblCompanyLineCommissions.Columns)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(companyLineCommission[column.ColumnName, DataRowVersion.Original].ToString(), companyLineCommission[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
              this.GetRowChanges(companyLineCommission, column.ColumnName, changeList);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        this.LogChanges(companyLineCommission, changeList, dictionary2);
      }
      this.ds.AcceptChanges();
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid to be deleted.", "Select Row in Grid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this commission setup?", "Delete Commission Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      int commissionId = this.ds.tblCompanyLineCommissions[this._bmb.Position].CommissionID;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblCompanyLineCommissions WHERE CommissionID = @CI", new object[2]
      {
        (object) "@CI",
        (object) commissionId
      });
      this.ds.tblCompanyLineCommissions.RemovetblCompanyLineCommissionsRow(this.ds.tblCompanyLineCommissions.FindByCommissionID(commissionId));
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineCommissions);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
        return;
      }
      if (this.ds.tblCompanyLineCommissions.Rows.Count == 0)
        this.SetDefaultInputs();
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void dbSave_ClickedDelete(object sender, EventArgs e)
  {
    if (this.ds.tblCompanyLineCommissions.Rows.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblCompanyLineCommissions.RejectChanges();
    this._bmb.CancelCurrentEdit();
    this.ClearAllErrors();
    if (this.ds.tblCompanyLineCommissions.Rows.Count == 0)
    {
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
      this._bmb.Position = -1;
      this.SetDefaultInputs();
    }
    else
      this._bmb.Position = ((UltraGridBase) this.UltraGrid1).ActiveRow.Index;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.UltraGrid1).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.groupCompanyCommissions).Enabled = !((Control) this.UltraGrid1).Enabled;
    ((Control) this.groupGeneralInfo).Enabled = !((Control) this.UltraGrid1).Enabled;
    ((Control) this.groupProducerCommissions).Enabled = !((Control) this.UltraGrid1).Enabled;
  }

  private void MassageColumnNames(Dictionary<string, string> colDic)
  {
    colDic.Add("CompanyCommNew", "'New Company Commission'");
    colDic.Add("CompanyCommRenewal", "'Renewal Company Commission'");
    colDic.Add("ProducerCommNew", "'New Producer Commission'");
    colDic.Add("ProducerCommRenewal", "'Renewal Producer Commission'");
    colDic.Add("ProducerCommNewMax", "'New Producer Commission Max'");
    colDic.Add("ProducerCommRenewalMax", "'Renewal Producer Commission Max'");
    colDic.Add("UsingAdditiveCommission", "'Using Additive Commission'");
    colDic.Add("AdditiveMinimum", "'Additive Minimum'");
    colDic.Add("AdditiveMaximum", "'Additive Maximum'");
    colDic.Add("AdditiveSpread", "'Additive Spread'");
    colDic.Add("LockedCommissions", "'Locked Commissions'");
    colDic.Add("PolicyTypeID", "'Policy Type'");
    colDic.Add("ExpiringCompanyLocationGuid", "'Expiring CompanyLocation'");
  }

  private void LogChanges(
    dsCompanyLineCommissions.tblCompanyLineCommissionsRow row,
    List<frmCompanyLineCommissions.CommissionsStruct> changeList,
    Dictionary<string, string> colNames)
  {
    int num = changeList.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      frmCompanyLineCommissions.CommissionsStruct change = changeList[index];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(change.OrigValue, string.Empty, false) == 0)
        change.OrigValue = "<empty>";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(change.CurrValue, string.Empty, false) == 0)
        change.CurrValue = "<empty>";
      string str = change.ColumnName;
      if (colNames.ContainsKey(change.ColumnName))
        str = colNames[change.ColumnName];
      CurrentUser.Instance.LogAction($"Modify commissions on '{this._companyLine.CompanyLineState}'. Effective{this.dtpEffective.Value.ToString()}. Changed {str} from {change.OrigValue} to {change.CurrValue}", this._companyLine.CompanyLineGuid, "Company/Line");
    }
  }

  private void GetRowChanges(
    dsCompanyLineCommissions.tblCompanyLineCommissionsRow row,
    string colName,
    List<frmCompanyLineCommissions.CommissionsStruct> changeList)
  {
    changeList.Add(new frmCompanyLineCommissions.CommissionsStruct()
    {
      ColumnName = colName,
      CurrValue = row[colName] == DBNull.Value ? string.Empty : (colName.Equals("PolicyTypeID") || colName.Equals("ExpiringCompanyLocationGuid") ? this.GetListColumnValues(colName, RuntimeHelpers.GetObjectValue(row[colName])) : row[colName, DataRowVersion.Current].ToString()),
      OrigValue = row[colName, DataRowVersion.Original] == DBNull.Value ? string.Empty : (colName.Equals("PolicyTypeID") || colName.Equals("ExpiringCompanyLocationGuid") ? this.GetListColumnValues(colName, RuntimeHelpers.GetObjectValue(row[colName, DataRowVersion.Original])) : row[colName, DataRowVersion.Original].ToString())
    });
  }

  private string GetListColumnValues(string columnName, object rowColumnValue)
  {
    string listColumnValues = string.Empty;
    switch (columnName)
    {
      case "PolicyTypeID":
        dsCompanyLineCommissions.lstPolicyTypesRow byPolicyTypeId = this.ds.lstPolicyTypes.FindByPolicyTypeID(Conversions.ToByte(rowColumnValue));
        if (byPolicyTypeId != null)
        {
          listColumnValues = byPolicyTypeId.Description;
          break;
        }
        break;
      case "ExpiringCompanyLocationGuid":
        dsCompanyLineCommissions.tblCompanyLocationsRow companyLocationGuid = this.ds.tblCompanyLocations.FindByCompanyLocationGUID((Guid) rowColumnValue);
        if (companyLocationGuid != null)
        {
          listColumnValues = companyLocationGuid.LocationName;
          break;
        }
        break;
    }
    return listColumnValues;
  }

  private void buttonRefreshCompanies_Click(object sender, EventArgs e)
  {
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      this.ds.EnforceConstraints = false;
      this.ds.lstPolicyTypes.Clear();
      this.ds.tblCompanyLocations.Clear();
      this.LoadData(true);
      frmCompanyLineCommissions._tblCompanyLocationsCache.Clear();
      frmCompanyLineCommissions._tblCompanyLocationsCache.Load((IDataReader) this.ds.tblCompanyLocations.CreateDataReader());
      this.ds.EnforceConstraints = true;
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual void OnFormLoad()
  {
  }

  private void TxtAdditiveMin_ValueChanged(object sender, EventArgs e)
  {
  }

  private struct CommissionsStruct
  {
    public string ColumnName;
    public string OrigValue;
    public string CurrValue;
  }
}
