// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.TermsOfPayment.frmCompanyLineTermsOfPayment
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.TermsOfPayment;

public class frmCompanyLineTermsOfPayment : Form
{
  private IContainer components;
  private UltraGroupBox UltraGroupBox3;
  private UltraGroupBox UltraGroupBox1;
  private RadioButton rbProducerDay;
  private MGANumericEditor txtProducerDays;
  private RadioButton rbProducerDateBilled;
  private RadioButton rbProducerEndOfMonth;
  private Label Label36;
  private RadioButton rbProducerEffectiveDate;
  private MGANumericEditor txtProducerTermsOfPayment;
  private Label lblProducerTermsOfPayment;
  private RadioButton rbDateBilled;
  private MGANumericEditor txtDay;
  private MGANumericEditor txtTermsOfPayment;
  private MGACheckBox chkCreditsTakenImmediatly;
  private Label Label17;
  private RadioButton rbDay;
  private RadioButton rbCompanyEndOfMonth;
  private Label Label7;
  private RadioButton rbCompanyEffective;
  private Label Label18;
  private MGACheckBox chkAcctCurrent;
  private MGASimpleComboBox cboPaymentMethods;
  private ErrorProvider err;
  private SqlConnection cn;
  private SqlDataAdapter da;
  private dsCompanyLineTermsOfPayment ds;
  private int _companyLineID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

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

  [field: AccessedThroughProperty("UltraGroupBox2")]
  internal virtual UltraGroupBox UltraGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEffective")]
  internal virtual MGADateTimePicker dtEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox4")]
  internal virtual UltraGroupBox UltraGroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtProducerEndTermsOfPayment")]
  internal virtual MGANumericEditor txtProducerEndTermsOfPayment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProducerEndDay")]
  internal virtual RadioButton rbProducerEndDay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProducerEndDateBilled")]
  internal virtual RadioButton rbProducerEndDateBilled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProducerEndorsementEndMonth")]
  internal virtual RadioButton rbProducerEndorsementEndMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProducerEndEffectiveDate")]
  internal virtual RadioButton rbProducerEndEffectiveDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtProducerEndDays")]
  internal virtual MGANumericEditor txtProducerEndDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDueDate")]
  private virtual RadioButton rbDueDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProducerGAAP")]
  private virtual RadioButton rbProducerGAAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProducerEndorsementGAAP")]
  internal virtual RadioButton rbProducerEndorsementGAAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbEndOfEffectiveMonth")]
  private virtual RadioButton rbEndOfEffectiveMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbCompanyGAAP")]
  private virtual RadioButton rbCompanyGAAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbEndOfEffectiveMonthGAAP")]
  private virtual RadioButton rbEndOfEffectiveMonthGAAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProdEndOfMonthEffective")]
  private virtual RadioButton rbProdEndOfMonthEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProdEndOfMonthEffective_Endorsement")]
  private virtual RadioButton rbProdEndOfMonthEffective_Endorsement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProdEffDateBoundDate")]
  private virtual RadioButton rbProdEffDateBoundDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProducerEndEffDateBoundDate")]
  private virtual RadioButton rbProducerEndEffDateBoundDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyLineTermsOfPayment));
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblCompanyLineTermsOfPayment", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PaymentTermsID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Effective");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TermsOfPayment");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PaymentMethodID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PaymentMeasuredFrom");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PaymentDayOfMonth");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerPaymentMeasuredFrom");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ProducerPaymentDayOfMonth");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DefaultProducerTermsOfPayment");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProducerPaymentMeasuredFrom_Endorsement");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ProducerPaymentDayOfMonth_Endorsement");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DefaultProducerTermsOfPayment_Endorsement");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CreditsTakenImmediatly");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("AcctCurrent");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    this.UltraGroupBox3 = new UltraGroupBox();
    this.rbEndOfEffectiveMonthGAAP = new RadioButton();
    this.rbCompanyGAAP = new RadioButton();
    this.rbEndOfEffectiveMonth = new RadioButton();
    this.rbDueDate = new RadioButton();
    this.rbDateBilled = new RadioButton();
    this.txtDay = new MGANumericEditor();
    this.ds = new dsCompanyLineTermsOfPayment();
    this.txtTermsOfPayment = new MGANumericEditor();
    this.chkCreditsTakenImmediatly = new MGACheckBox();
    this.Label17 = new Label();
    this.rbDay = new RadioButton();
    this.rbCompanyEndOfMonth = new RadioButton();
    this.Label7 = new Label();
    this.rbCompanyEffective = new RadioButton();
    this.Label18 = new Label();
    this.chkAcctCurrent = new MGACheckBox();
    this.cboPaymentMethods = new MGASimpleComboBox();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.rbProdEffDateBoundDate = new RadioButton();
    this.rbProdEndOfMonthEffective = new RadioButton();
    this.rbProducerGAAP = new RadioButton();
    this.txtProducerDays = new MGANumericEditor();
    this.rbProducerDay = new RadioButton();
    this.rbProducerDateBilled = new RadioButton();
    this.rbProducerEndOfMonth = new RadioButton();
    this.Label36 = new Label();
    this.rbProducerEffectiveDate = new RadioButton();
    this.txtProducerTermsOfPayment = new MGANumericEditor();
    this.lblProducerTermsOfPayment = new Label();
    this.err = new ErrorProvider(this.components);
    this.cn = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraGrid1 = new UltraGrid();
    this.UltraGroupBox2 = new UltraGroupBox();
    this.dtEffective = new MGADateTimePicker();
    this.Label1 = new Label();
    this.UltraGroupBox4 = new UltraGroupBox();
    this.rbProducerEndEffDateBoundDate = new RadioButton();
    this.rbProdEndOfMonthEffective_Endorsement = new RadioButton();
    this.rbProducerEndorsementGAAP = new RadioButton();
    this.txtProducerEndDays = new MGANumericEditor();
    this.rbProducerEndDay = new RadioButton();
    this.rbProducerEndDateBilled = new RadioButton();
    this.rbProducerEndorsementEndMonth = new RadioButton();
    this.Label2 = new Label();
    this.rbProducerEndEffectiveDate = new RadioButton();
    this.txtProducerEndTermsOfPayment = new MGANumericEditor();
    this.Label3 = new Label();
    ((ISupportInitialize) this.UltraGroupBox3).BeginInit();
    ((Control) this.UltraGroupBox3).SuspendLayout();
    ((ISupportInitialize) this.txtDay).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtTermsOfPayment).BeginInit();
    ((ISupportInitialize) this.chkCreditsTakenImmediatly).BeginInit();
    ((ISupportInitialize) this.chkAcctCurrent).BeginInit();
    ((ISupportInitialize) this.cboPaymentMethods).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtProducerDays).BeginInit();
    ((ISupportInitialize) this.txtProducerTermsOfPayment).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox2).BeginInit();
    ((Control) this.UltraGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox4).BeginInit();
    ((Control) this.UltraGroupBox4).SuspendLayout();
    ((ISupportInitialize) this.txtProducerEndDays).BeginInit();
    ((ISupportInitialize) this.txtProducerEndTermsOfPayment).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraGroupBox3).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox3.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.rbEndOfEffectiveMonthGAAP);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.rbCompanyGAAP);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.rbEndOfEffectiveMonth);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.rbDueDate);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.rbDateBilled);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.txtDay);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.txtTermsOfPayment);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.chkCreditsTakenImmediatly);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.Label17);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.rbDay);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.rbCompanyEndOfMonth);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.Label7);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.rbCompanyEffective);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.Label18);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.chkAcctCurrent);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.cboPaymentMethods);
    ((Control) this.UltraGroupBox3).Enabled = false;
    appearance2.ForeColor = Color.Navy;
    this.UltraGroupBox3.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.UltraGroupBox3).Location = new Point(14, 286);
    ((Control) this.UltraGroupBox3).Name = "UltraGroupBox3";
    ((Control) this.UltraGroupBox3).Size = new Size(784, 124);
    ((Control) this.UltraGroupBox3).TabIndex = 1;
    this.UltraGroupBox3.Text = "Company Terms of Payment";
    this.rbEndOfEffectiveMonthGAAP.BackColor = Color.Transparent;
    this.rbEndOfEffectiveMonthGAAP.Location = new Point(570, 88);
    this.rbEndOfEffectiveMonthGAAP.Name = "rbEndOfEffectiveMonthGAAP";
    this.rbEndOfEffectiveMonthGAAP.Size = new Size(187, 24);
    this.rbEndOfEffectiveMonthGAAP.TabIndex = 163;
    this.rbEndOfEffectiveMonthGAAP.Text = "End of Effective Month (GAAP)";
    this.rbEndOfEffectiveMonthGAAP.UseVisualStyleBackColor = false;
    this.rbCompanyGAAP.BackColor = Color.Transparent;
    this.rbCompanyGAAP.Location = new Point(570, 56);
    this.rbCompanyGAAP.Name = "rbCompanyGAAP";
    this.rbCompanyGAAP.Size = new Size(58, 24);
    this.rbCompanyGAAP.TabIndex = 8;
    this.rbCompanyGAAP.Text = "GAAP";
    this.rbCompanyGAAP.UseVisualStyleBackColor = false;
    this.rbEndOfEffectiveMonth.BackColor = Color.Transparent;
    this.rbEndOfEffectiveMonth.Location = new Point(248, 88);
    this.rbEndOfEffectiveMonth.Name = "rbEndOfEffectiveMonth";
    this.rbEndOfEffectiveMonth.Size = new Size(138, 24);
    this.rbEndOfEffectiveMonth.TabIndex = 10;
    this.rbEndOfEffectiveMonth.Text = "End of Effective Month";
    this.rbEndOfEffectiveMonth.UseVisualStyleBackColor = false;
    this.rbDueDate.BackColor = Color.Transparent;
    this.rbDueDate.Location = new Point(64 /*0x40*/, 88);
    this.rbDueDate.Name = "rbDueDate";
    this.rbDueDate.Size = new Size(70, 24);
    this.rbDueDate.TabIndex = 9;
    this.rbDueDate.Text = "Due Date";
    this.rbDueDate.UseVisualStyleBackColor = false;
    this.rbDateBilled.BackColor = Color.Transparent;
    this.rbDateBilled.Location = new Point(425, 56);
    this.rbDateBilled.Name = "rbDateBilled";
    this.rbDateBilled.Size = new Size(80 /*0x50*/, 24);
    this.rbDateBilled.TabIndex = 7;
    this.rbDateBilled.Text = "Date Billed";
    this.rbDateBilled.UseVisualStyleBackColor = false;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtDay).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtDay).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineTermsOfPayment.PaymentDayOfMonth", true));
    ((UltraNumericEditorBase) this.txtDay).FormatString = "";
    ((Control) this.txtDay).Location = new Point(480, 91);
    this.txtDay.MaskInput = "nnn";
    this.txtDay.MaxValue = (object) 999;
    this.txtDay.MGAStyle = MGAStyles.Blue;
    this.txtDay.MinValue = (object) 1;
    ((Control) this.txtDay).Name = "txtDay";
    this.txtDay.Nullable = true;
    ((UltraNumericEditorBase) this.txtDay).PromptChar = ' ';
    ((Control) this.txtDay).Size = new Size(42, 20);
    ((Control) this.txtDay).TabIndex = 12;
    ((UltraControlBase) this.txtDay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDay).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyLineTermsOfPayment";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtTermsOfPayment).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtTermsOfPayment).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineTermsOfPayment.TermsOfPayment", true));
    ((UltraNumericEditorBase) this.txtTermsOfPayment).FormatString = "";
    ((Control) this.txtTermsOfPayment).Location = new Point(400, 24);
    this.txtTermsOfPayment.MaskInput = "nnn";
    this.txtTermsOfPayment.MaxValue = (object) 999;
    this.txtTermsOfPayment.MGAStyle = MGAStyles.Blue;
    this.txtTermsOfPayment.MinValue = (object) 1;
    ((Control) this.txtTermsOfPayment).Name = "txtTermsOfPayment";
    this.txtTermsOfPayment.Nullable = true;
    ((UltraNumericEditorBase) this.txtTermsOfPayment).PromptChar = ' ';
    ((Control) this.txtTermsOfPayment).Size = new Size(54, 20);
    ((Control) this.txtTermsOfPayment).TabIndex = 2;
    ((UltraControlBase) this.txtTermsOfPayment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTermsOfPayment).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCreditsTakenImmediatly).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkCreditsTakenImmediatly).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCreditsTakenImmediatly).BackColorInternal = Color.Transparent;
    ((Control) this.chkCreditsTakenImmediatly).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineTermsOfPayment.CreditsTakenImmediatly", true));
    ((UltraToggleEditorBase) this.chkCreditsTakenImmediatly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.chkCreditsTakenImmediatly).Location = new Point(591, 22);
    this.chkCreditsTakenImmediatly.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCreditsTakenImmediatly).Name = "chkCreditsTakenImmediatly";
    ((Control) this.chkCreditsTakenImmediatly).Size = new Size(154, 24);
    ((Control) this.chkCreditsTakenImmediatly).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkCreditsTakenImmediatly).Text = "Credits Taken Immediatly";
    ((UltraControlBase) this.chkCreditsTakenImmediatly).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCreditsTakenImmediatly).UseOsThemes = (DefaultableBoolean) 2;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.ForeColor = Color.Black;
    this.Label17.Location = new Point(8, 27);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(96 /*0x60*/, 14);
    this.Label17.TabIndex = 161;
    this.Label17.Text = "Payment Method:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    this.rbDay.BackColor = Color.Transparent;
    this.rbDay.Location = new Point(425, 88);
    this.rbDay.Name = "rbDay";
    this.rbDay.Size = new Size(49, 24);
    this.rbDay.TabIndex = 11;
    this.rbDay.Text = "Day:";
    this.rbDay.UseVisualStyleBackColor = false;
    this.rbCompanyEndOfMonth.BackColor = Color.Transparent;
    this.rbCompanyEndOfMonth.Location = new Point(248, 56);
    this.rbCompanyEndOfMonth.Name = "rbCompanyEndOfMonth";
    this.rbCompanyEndOfMonth.Size = new Size(91, 24);
    this.rbCompanyEndOfMonth.TabIndex = 6;
    this.rbCompanyEndOfMonth.Text = "End of Month";
    this.rbCompanyEndOfMonth.UseVisualStyleBackColor = false;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(8, 62);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(35, 13);
    this.Label7.TabIndex = 162;
    this.Label7.Text = "From:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.rbCompanyEffective.BackColor = Color.Transparent;
    this.rbCompanyEffective.Location = new Point(64 /*0x40*/, 56);
    this.rbCompanyEffective.Name = "rbCompanyEffective";
    this.rbCompanyEffective.Size = new Size(98, 24);
    this.rbCompanyEffective.TabIndex = 5;
    this.rbCompanyEffective.Text = "Effective Date";
    this.rbCompanyEffective.UseVisualStyleBackColor = false;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(292, 28);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(98, 13);
    this.Label18.TabIndex = 1;
    this.Label18.Text = "Terms of Payment:";
    this.Label18.TextAlign = ContentAlignment.MiddleRight;
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAcctCurrent).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkAcctCurrent).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAcctCurrent).BackColorInternal = Color.Transparent;
    ((Control) this.chkAcctCurrent).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineTermsOfPayment.AcctCurrent", true));
    ((UltraToggleEditorBase) this.chkAcctCurrent).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.chkAcctCurrent).Location = new Point(476, 22);
    ((Control) this.chkAcctCurrent).Name = "chkAcctCurrent";
    ((Control) this.chkAcctCurrent).Size = new Size(93, 24);
    ((Control) this.chkAcctCurrent).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkAcctCurrent).Text = "Acct. Current";
    ((UltraControlBase) this.chkAcctCurrent).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAcctCurrent).UseOsThemes = (DefaultableBoolean) 2;
    this.cboPaymentMethods.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboPaymentMethods).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineTermsOfPayment.PaymentMethodID", true));
    ((UltraGridBase) this.cboPaymentMethods).DataSource = (object) this.ds.lstPaymentMethods;
    ((UltraDropDownBase) this.cboPaymentMethods).DisplayMember = "PaymentMethod";
    this.cboPaymentMethods.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPaymentMethods).Location = new Point(110, 24);
    this.cboPaymentMethods.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPaymentMethods).Name = "cboPaymentMethods";
    ((Control) this.cboPaymentMethods).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboPaymentMethods).TabIndex = 0;
    ((UltraControlBase) this.cboPaymentMethods).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPaymentMethods).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPaymentMethods).ValueMember = "ID";
    ((Control) this.UltraGroupBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance7.BackColor = Color.FromArgb(239, 247, 253);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance7;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbProdEffDateBoundDate);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbProdEndOfMonthEffective);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbProducerGAAP);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtProducerDays);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbProducerDay);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbProducerDateBilled);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbProducerEndOfMonth);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.Label36);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbProducerEffectiveDate);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtProducerTermsOfPayment);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblProducerTermsOfPayment);
    ((Control) this.UltraGroupBox1).Enabled = false;
    appearance8.ForeColor = Color.Navy;
    this.UltraGroupBox1.HeaderAppearance = (AppearanceBase) appearance8;
    ((Control) this.UltraGroupBox1).Location = new Point(12, 416);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(384, 144 /*0x90*/);
    ((Control) this.UltraGroupBox1).TabIndex = 2;
    this.UltraGroupBox1.Text = "Producer Terms of Payment";
    this.rbProdEffDateBoundDate.BackColor = Color.Transparent;
    this.rbProdEffDateBoundDate.Location = new Point(220, 113);
    this.rbProdEffDateBoundDate.Name = "rbProdEffDateBoundDate";
    this.rbProdEffDateBoundDate.Size = new Size(156, 24);
    this.rbProdEffDateBoundDate.TabIndex = 184;
    this.rbProdEffDateBoundDate.Text = "Effective Date/Date Bound";
    this.rbProdEffDateBoundDate.UseVisualStyleBackColor = false;
    this.rbProdEndOfMonthEffective.BackColor = Color.Transparent;
    this.rbProdEndOfMonthEffective.Location = new Point(66, 113);
    this.rbProdEndOfMonthEffective.Name = "rbProdEndOfMonthEffective";
    this.rbProdEndOfMonthEffective.Size = new Size(138, 24);
    this.rbProdEndOfMonthEffective.TabIndex = 183;
    this.rbProdEndOfMonthEffective.Text = "End of Effective Month";
    this.rbProdEndOfMonthEffective.UseVisualStyleBackColor = false;
    this.rbProducerGAAP.BackColor = Color.Transparent;
    this.rbProducerGAAP.Location = new Point(66, 82);
    this.rbProducerGAAP.Name = "rbProducerGAAP";
    this.rbProducerGAAP.Size = new Size(67, 24);
    this.rbProducerGAAP.TabIndex = 4;
    this.rbProducerGAAP.Text = "GAAP";
    this.rbProducerGAAP.UseVisualStyleBackColor = false;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducerDays).Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtProducerDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth", true));
    ((UltraNumericEditorBase) this.txtProducerDays).FormatString = "";
    ((Control) this.txtProducerDays).Location = new Point(228, 84);
    this.txtProducerDays.MaskInput = "nnn";
    this.txtProducerDays.MaxValue = (object) 999;
    this.txtProducerDays.MGAStyle = MGAStyles.Blue;
    this.txtProducerDays.MinValue = (object) 1;
    ((Control) this.txtProducerDays).Name = "txtProducerDays";
    this.txtProducerDays.Nullable = true;
    ((UltraNumericEditorBase) this.txtProducerDays).PromptChar = ' ';
    ((Control) this.txtProducerDays).Size = new Size(42, 20);
    ((Control) this.txtProducerDays).TabIndex = 6;
    ((UltraControlBase) this.txtProducerDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerDays).UseOsThemes = (DefaultableBoolean) 2;
    this.rbProducerDay.BackColor = Color.Transparent;
    this.rbProducerDay.Location = new Point(168, 82);
    this.rbProducerDay.Name = "rbProducerDay";
    this.rbProducerDay.Size = new Size(54, 24);
    this.rbProducerDay.TabIndex = 5;
    this.rbProducerDay.Text = "Day:";
    this.rbProducerDay.UseVisualStyleBackColor = false;
    this.rbProducerDateBilled.BackColor = Color.Transparent;
    this.rbProducerDateBilled.Location = new Point(168, 53);
    this.rbProducerDateBilled.Name = "rbProducerDateBilled";
    this.rbProducerDateBilled.Size = new Size(91, 24);
    this.rbProducerDateBilled.TabIndex = 2;
    this.rbProducerDateBilled.Text = "Date Billed";
    this.rbProducerDateBilled.UseVisualStyleBackColor = false;
    this.rbProducerEndOfMonth.BackColor = Color.Transparent;
    this.rbProducerEndOfMonth.Location = new Point(270, 53);
    this.rbProducerEndOfMonth.Name = "rbProducerEndOfMonth";
    this.rbProducerEndOfMonth.Size = new Size(91, 24);
    this.rbProducerEndOfMonth.TabIndex = 3;
    this.rbProducerEndOfMonth.Text = "End of Month";
    this.rbProducerEndOfMonth.UseVisualStyleBackColor = false;
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(16 /*0x10*/, 59);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(35, 13);
    this.Label36.TabIndex = 182;
    this.Label36.Text = "From:";
    this.Label36.TextAlign = ContentAlignment.MiddleRight;
    this.rbProducerEffectiveDate.BackColor = Color.Transparent;
    this.rbProducerEffectiveDate.Location = new Point(66, 56);
    this.rbProducerEffectiveDate.Name = "rbProducerEffectiveDate";
    this.rbProducerEffectiveDate.Size = new Size(98, 19);
    this.rbProducerEffectiveDate.TabIndex = 1;
    this.rbProducerEffectiveDate.Text = "Effective Date";
    this.rbProducerEffectiveDate.UseVisualStyleBackColor = false;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducerTermsOfPayment).Appearance = (AppearanceBase) appearance10;
    ((Control) this.txtProducerTermsOfPayment).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment", true));
    ((UltraNumericEditorBase) this.txtProducerTermsOfPayment).FormatString = "";
    ((Control) this.txtProducerTermsOfPayment).Location = new Point(128 /*0x80*/, 22);
    this.txtProducerTermsOfPayment.MaskInput = "nnn";
    this.txtProducerTermsOfPayment.MaxValue = (object) 999;
    this.txtProducerTermsOfPayment.MGAStyle = MGAStyles.Blue;
    this.txtProducerTermsOfPayment.MinValue = (object) 0;
    ((Control) this.txtProducerTermsOfPayment).Name = "txtProducerTermsOfPayment";
    this.txtProducerTermsOfPayment.Nullable = true;
    ((UltraNumericEditorBase) this.txtProducerTermsOfPayment).PromptChar = ' ';
    ((Control) this.txtProducerTermsOfPayment).Size = new Size(56, 20);
    ((Control) this.txtProducerTermsOfPayment).TabIndex = 0;
    ((UltraControlBase) this.txtProducerTermsOfPayment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerTermsOfPayment).UseOsThemes = (DefaultableBoolean) 2;
    this.lblProducerTermsOfPayment.AutoSize = true;
    this.lblProducerTermsOfPayment.BackColor = Color.Transparent;
    this.lblProducerTermsOfPayment.Location = new Point(16 /*0x10*/, 26);
    this.lblProducerTermsOfPayment.Name = "lblProducerTermsOfPayment";
    this.lblProducerTermsOfPayment.Size = new Size(100, 13);
    this.lblProducerTermsOfPayment.TabIndex = 177;
    this.lblProducerTermsOfPayment.Text = "Terms Of Payment:";
    this.lblProducerTermsOfPayment.TextAlign = ContentAlignment.MiddleRight;
    this.err.ContainerControl = (ContainerControl) this;
    this.cn.ConnectionString = "Data Source=mgasystems2012.ny.mgasystems.com;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineTermsOfPayment", new DataColumnMapping[15]
      {
        new DataColumnMapping("PaymentTermsID", "PaymentTermsID"),
        new DataColumnMapping("CompanyLineID", "CompanyLineID"),
        new DataColumnMapping("Effective", "Effective"),
        new DataColumnMapping("TermsOfPayment", "TermsOfPayment"),
        new DataColumnMapping("PaymentMethodID", "PaymentMethodID"),
        new DataColumnMapping("PaymentMeasuredFrom", "PaymentMeasuredFrom"),
        new DataColumnMapping("PaymentDayOfMonth", "PaymentDayOfMonth"),
        new DataColumnMapping("ProducerPaymentMeasuredFrom", "ProducerPaymentMeasuredFrom"),
        new DataColumnMapping("ProducerPaymentDayOfMonth", "ProducerPaymentDayOfMonth"),
        new DataColumnMapping("DefaultProducerTermsOfPayment", "DefaultProducerTermsOfPayment"),
        new DataColumnMapping("CreditsTakenImmediatly", "CreditsTakenImmediatly"),
        new DataColumnMapping("AcctCurrent", "AcctCurrent"),
        new DataColumnMapping("ProducerPaymentMeasuredFrom_Endorsement", "ProducerPaymentMeasuredFrom_Endorsement"),
        new DataColumnMapping("ProducerPaymentDayOfMonth_Endorsement", "ProducerPaymentDayOfMonth_Endorsement"),
        new DataColumnMapping("DefaultProducerTermsOfPayment_Endorsement", "DefaultProducerTermsOfPayment_Endorsement")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblCompanyLineTermsOfPayment WHERE (PaymentTermsID = @Original_PaymentTermsID)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_PaymentTermsID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PaymentTermsID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[14]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      new SqlParameter("@Effective", SqlDbType.DateTime, 8, "Effective"),
      new SqlParameter("@TermsOfPayment", SqlDbType.SmallInt, 2, "TermsOfPayment"),
      new SqlParameter("@PaymentMethodID", SqlDbType.TinyInt, 1, "PaymentMethodID"),
      new SqlParameter("@PaymentMeasuredFrom", SqlDbType.VarChar, 1, "PaymentMeasuredFrom"),
      new SqlParameter("@PaymentDayOfMonth", SqlDbType.TinyInt, 1, "PaymentDayOfMonth"),
      new SqlParameter("@ProducerPaymentMeasuredFrom", SqlDbType.VarChar, 1, "ProducerPaymentMeasuredFrom"),
      new SqlParameter("@ProducerPaymentDayOfMonth", SqlDbType.TinyInt, 1, "ProducerPaymentDayOfMonth"),
      new SqlParameter("@DefaultProducerTermsOfPayment", SqlDbType.SmallInt, 2, "DefaultProducerTermsOfPayment"),
      new SqlParameter("@CreditsTakenImmediatly", SqlDbType.Bit, 1, "CreditsTakenImmediatly"),
      new SqlParameter("@AcctCurrent", SqlDbType.Bit, 1, "AcctCurrent"),
      new SqlParameter("@ProducerPaymentMeasuredFrom_Endorsement", SqlDbType.VarChar, 1, "ProducerPaymentMeasuredFrom_Endorsement"),
      new SqlParameter("@ProducerPaymentDayOfMonth_Endorsement", SqlDbType.TinyInt, 1, "ProducerPaymentDayOfMonth_Endorsement"),
      new SqlParameter("@DefaultProducerTermsOfPayment_Endorsement", SqlDbType.SmallInt, 2, "DefaultProducerTermsOfPayment_Endorsement")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[16 /*0x10*/]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      new SqlParameter("@Effective", SqlDbType.DateTime, 8, "Effective"),
      new SqlParameter("@TermsOfPayment", SqlDbType.SmallInt, 2, "TermsOfPayment"),
      new SqlParameter("@PaymentMethodID", SqlDbType.TinyInt, 1, "PaymentMethodID"),
      new SqlParameter("@PaymentMeasuredFrom", SqlDbType.VarChar, 1, "PaymentMeasuredFrom"),
      new SqlParameter("@PaymentDayOfMonth", SqlDbType.TinyInt, 1, "PaymentDayOfMonth"),
      new SqlParameter("@ProducerPaymentMeasuredFrom", SqlDbType.VarChar, 1, "ProducerPaymentMeasuredFrom"),
      new SqlParameter("@ProducerPaymentDayOfMonth", SqlDbType.TinyInt, 1, "ProducerPaymentDayOfMonth"),
      new SqlParameter("@DefaultProducerTermsOfPayment", SqlDbType.SmallInt, 2, "DefaultProducerTermsOfPayment"),
      new SqlParameter("@CreditsTakenImmediatly", SqlDbType.Bit, 1, "CreditsTakenImmediatly"),
      new SqlParameter("@AcctCurrent", SqlDbType.Bit, 1, "AcctCurrent"),
      new SqlParameter("@ProducerPaymentMeasuredFrom_Endorsement", SqlDbType.VarChar, 1, "ProducerPaymentMeasuredFrom_Endorsement"),
      new SqlParameter("@ProducerPaymentDayOfMonth_Endorsement", SqlDbType.TinyInt, 1, "ProducerPaymentDayOfMonth_Endorsement"),
      new SqlParameter("@DefaultProducerTermsOfPayment_Endorsement", SqlDbType.SmallInt, 2, "DefaultProducerTermsOfPayment_Endorsement"),
      new SqlParameter("@Original_PaymentTermsID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PaymentTermsID", DataRowVersion.Original, (object) null),
      new SqlParameter("@PaymentTermsID", SqlDbType.Int, 4, "PaymentTermsID")
    });
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(686, 567);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 4;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    ((Control) this.UltraGrid1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.tblCompanyLineTermsOfPayment;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 39;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 10;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 29;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Center";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn3.Format = "d";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 206;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Center";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Company Terms";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 157;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 49;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 63 /*0x3F*/;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 5;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 66;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 6;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 90;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 7;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 84;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Center";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Producer Terms";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 8;
    ultraGridColumn10.Width = 157;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 11;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 102;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 12;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 121;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 14;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 171;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "CTI";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn14.Width = 139;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Acct Current";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 13;
    ultraGridColumn15.Width = 129;
    ultraGridBand.Columns.AddRange(new object[15]
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
      (object) ultraGridColumn15
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance15.BackColor = Color.LightSteelBlue;
    appearance15.FontData.SizeInPoints = 10f;
    appearance15.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance15;
    appearance16.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance19.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance19;
    appearance20.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance21.BackColor = Color.Transparent;
    appearance21.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance21;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Location = new Point(8, 8);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(790, 215);
    ((Control) this.UltraGrid1).TabIndex = 6;
    ((Control) this.UltraGrid1).Text = "Historical Terms of Payment Setup";
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraGroupBox2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance22.BackColor = Color.FromArgb(239, 247, 253);
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance22;
    ((Control) this.UltraGroupBox2).Controls.Add((Control) this.dtEffective);
    ((Control) this.UltraGroupBox2).Controls.Add((Control) this.Label1);
    ((Control) this.UltraGroupBox2).Enabled = false;
    appearance23.ForeColor = Color.Navy;
    this.UltraGroupBox2.HeaderAppearance = (AppearanceBase) appearance23;
    ((Control) this.UltraGroupBox2).Location = new Point(10, 229);
    ((Control) this.UltraGroupBox2).Name = "UltraGroupBox2";
    ((Control) this.UltraGroupBox2).Size = new Size(788, 51);
    ((Control) this.UltraGroupBox2).TabIndex = 0;
    this.UltraGroupBox2.Text = "General";
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance24;
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
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance25;
    ((Control) this.dtEffective).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineTermsOfPayment.Effective", true));
    this.dtEffective.DateTime = new DateTime(2019, 11, 20, 0, 0, 0, 0);
    ((Control) this.dtEffective).Location = new Point(112 /*0x70*/, 21);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtEffective).TabIndex = 163;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEffective.Value = (object) new DateTime(2019, 11, 20, 0, 0, 0, 0);
    this.Label1.BackColor = Color.Transparent;
    this.Label1.ForeColor = Color.Black;
    this.Label1.Location = new Point(8, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(96 /*0x60*/, 14);
    this.Label1.TabIndex = 162;
    this.Label1.Text = "Effective:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraGroupBox4).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance26.BackColor = Color.FromArgb(239, 247, 253);
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox4.ContentAreaAppearance = (AppearanceBase) appearance26;
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.rbProducerEndEffDateBoundDate);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.rbProdEndOfMonthEffective_Endorsement);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.rbProducerEndorsementGAAP);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.txtProducerEndDays);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.rbProducerEndDay);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.rbProducerEndDateBilled);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.rbProducerEndorsementEndMonth);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.Label2);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.rbProducerEndEffectiveDate);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.txtProducerEndTermsOfPayment);
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.Label3);
    ((Control) this.UltraGroupBox4).Enabled = false;
    appearance27.ForeColor = Color.Navy;
    this.UltraGroupBox4.HeaderAppearance = (AppearanceBase) appearance27;
    ((Control) this.UltraGroupBox4).Location = new Point(414, 416);
    ((Control) this.UltraGroupBox4).Name = "UltraGroupBox4";
    ((Control) this.UltraGroupBox4).Size = new Size(384, 144 /*0x90*/);
    ((Control) this.UltraGroupBox4).TabIndex = 3;
    this.UltraGroupBox4.Text = "Producer Terms of Payment - Endorsement";
    this.rbProducerEndEffDateBoundDate.BackColor = Color.Transparent;
    this.rbProducerEndEffDateBoundDate.Location = new Point(216, 112 /*0x70*/);
    this.rbProducerEndEffDateBoundDate.Name = "rbProducerEndEffDateBoundDate";
    this.rbProducerEndEffDateBoundDate.Size = new Size(159, 24);
    this.rbProducerEndEffDateBoundDate.TabIndex = 185;
    this.rbProducerEndEffDateBoundDate.Text = "Effective Date/Date Bound";
    this.rbProducerEndEffDateBoundDate.UseVisualStyleBackColor = false;
    this.rbProdEndOfMonthEffective_Endorsement.BackColor = Color.Transparent;
    this.rbProdEndOfMonthEffective_Endorsement.Location = new Point(66, 112 /*0x70*/);
    this.rbProdEndOfMonthEffective_Endorsement.Name = "rbProdEndOfMonthEffective_Endorsement";
    this.rbProdEndOfMonthEffective_Endorsement.Size = new Size(138, 24);
    this.rbProdEndOfMonthEffective_Endorsement.TabIndex = 184;
    this.rbProdEndOfMonthEffective_Endorsement.Text = "End of Effective Month";
    this.rbProdEndOfMonthEffective_Endorsement.UseVisualStyleBackColor = false;
    this.rbProducerEndorsementGAAP.BackColor = Color.Transparent;
    this.rbProducerEndorsementGAAP.Location = new Point(66, 80 /*0x50*/);
    this.rbProducerEndorsementGAAP.Name = "rbProducerEndorsementGAAP";
    this.rbProducerEndorsementGAAP.Size = new Size(67, 24);
    this.rbProducerEndorsementGAAP.TabIndex = 4;
    this.rbProducerEndorsementGAAP.Text = "GAAP";
    this.rbProducerEndorsementGAAP.UseVisualStyleBackColor = false;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducerEndDays).Appearance = (AppearanceBase) appearance28;
    ((Control) this.txtProducerEndDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_Endorsement", true));
    ((UltraNumericEditorBase) this.txtProducerEndDays).FormatString = "";
    ((Control) this.txtProducerEndDays).Location = new Point(225, 82);
    this.txtProducerEndDays.MaskInput = "nnn";
    this.txtProducerEndDays.MaxValue = (object) 999;
    this.txtProducerEndDays.MGAStyle = MGAStyles.Blue;
    this.txtProducerEndDays.MinValue = (object) 1;
    ((Control) this.txtProducerEndDays).Name = "txtProducerEndDays";
    this.txtProducerEndDays.Nullable = true;
    ((UltraNumericEditorBase) this.txtProducerEndDays).PromptChar = ' ';
    ((Control) this.txtProducerEndDays).Size = new Size(42, 20);
    ((Control) this.txtProducerEndDays).TabIndex = 6;
    ((UltraControlBase) this.txtProducerEndDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerEndDays).UseOsThemes = (DefaultableBoolean) 2;
    this.rbProducerEndDay.BackColor = Color.Transparent;
    this.rbProducerEndDay.Location = new Point(170, 80 /*0x50*/);
    this.rbProducerEndDay.Name = "rbProducerEndDay";
    this.rbProducerEndDay.Size = new Size(49, 24);
    this.rbProducerEndDay.TabIndex = 5;
    this.rbProducerEndDay.Text = "Day:";
    this.rbProducerEndDay.UseVisualStyleBackColor = false;
    this.rbProducerEndDateBilled.BackColor = Color.Transparent;
    this.rbProducerEndDateBilled.Location = new Point(170, 48 /*0x30*/);
    this.rbProducerEndDateBilled.Name = "rbProducerEndDateBilled";
    this.rbProducerEndDateBilled.Size = new Size(91, 24);
    this.rbProducerEndDateBilled.TabIndex = 2;
    this.rbProducerEndDateBilled.Text = "Date Billed";
    this.rbProducerEndDateBilled.UseVisualStyleBackColor = false;
    this.rbProducerEndorsementEndMonth.BackColor = Color.Transparent;
    this.rbProducerEndorsementEndMonth.Location = new Point(269, 48 /*0x30*/);
    this.rbProducerEndorsementEndMonth.Name = "rbProducerEndorsementEndMonth";
    this.rbProducerEndorsementEndMonth.Size = new Size(91, 24);
    this.rbProducerEndorsementEndMonth.TabIndex = 3;
    this.rbProducerEndorsementEndMonth.Text = "End of Month";
    this.rbProducerEndorsementEndMonth.UseVisualStyleBackColor = false;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(16 /*0x10*/, 54);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(35, 13);
    this.Label2.TabIndex = 182;
    this.Label2.Text = "From:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.rbProducerEndEffectiveDate.BackColor = Color.Transparent;
    this.rbProducerEndEffectiveDate.Location = new Point(66, 48 /*0x30*/);
    this.rbProducerEndEffectiveDate.Name = "rbProducerEndEffectiveDate";
    this.rbProducerEndEffectiveDate.Size = new Size(98, 24);
    this.rbProducerEndEffectiveDate.TabIndex = 1;
    this.rbProducerEndEffectiveDate.Text = "Effective Date";
    this.rbProducerEndEffectiveDate.UseVisualStyleBackColor = false;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducerEndTermsOfPayment).Appearance = (AppearanceBase) appearance29;
    ((Control) this.txtProducerEndTermsOfPayment).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_Endorsement", true));
    ((UltraNumericEditorBase) this.txtProducerEndTermsOfPayment).FormatString = "";
    ((Control) this.txtProducerEndTermsOfPayment).Location = new Point(128 /*0x80*/, 22);
    this.txtProducerEndTermsOfPayment.MaskInput = "nnn";
    this.txtProducerEndTermsOfPayment.MaxValue = (object) 999;
    this.txtProducerEndTermsOfPayment.MGAStyle = MGAStyles.Blue;
    this.txtProducerEndTermsOfPayment.MinValue = (object) 0;
    ((Control) this.txtProducerEndTermsOfPayment).Name = "txtProducerEndTermsOfPayment";
    this.txtProducerEndTermsOfPayment.Nullable = true;
    ((UltraNumericEditorBase) this.txtProducerEndTermsOfPayment).PromptChar = ' ';
    ((Control) this.txtProducerEndTermsOfPayment).Size = new Size(56, 20);
    ((Control) this.txtProducerEndTermsOfPayment).TabIndex = 0;
    ((UltraControlBase) this.txtProducerEndTermsOfPayment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerEndTermsOfPayment).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(16 /*0x10*/, 26);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(100, 13);
    this.Label3.TabIndex = 177;
    this.Label3.Text = "Terms Of Payment:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(806, 619);
    this.Controls.Add((Control) this.UltraGroupBox4);
    this.Controls.Add((Control) this.UltraGroupBox2);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.Controls.Add((Control) this.UltraGroupBox3);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Controls.Add((Control) this.dbSave);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCompanyLineTermsOfPayment);
    this.Text = "Company / Line - Terms of Payment";
    ((ISupportInitialize) this.UltraGroupBox3).EndInit();
    ((Control) this.UltraGroupBox3).ResumeLayout(false);
    ((Control) this.UltraGroupBox3).PerformLayout();
    ((ISupportInitialize) this.txtDay).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtTermsOfPayment).EndInit();
    ((ISupportInitialize) this.chkCreditsTakenImmediatly).EndInit();
    ((ISupportInitialize) this.chkAcctCurrent).EndInit();
    ((ISupportInitialize) this.cboPaymentMethods).EndInit();
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((Control) this.UltraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtProducerDays).EndInit();
    ((ISupportInitialize) this.txtProducerTermsOfPayment).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    ((ISupportInitialize) this.UltraGroupBox2).EndInit();
    ((Control) this.UltraGroupBox2).ResumeLayout(false);
    ((Control) this.UltraGroupBox2).PerformLayout();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.UltraGroupBox4).EndInit();
    ((Control) this.UltraGroupBox4).ResumeLayout(false);
    ((Control) this.UltraGroupBox4).PerformLayout();
    ((ISupportInitialize) this.txtProducerEndDays).EndInit();
    ((ISupportInitialize) this.txtProducerEndTermsOfPayment).EndInit();
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

  public frmCompanyLineTermsOfPayment(int companyLineID)
  {
    this.Load += new EventHandler(this.frmCompanyLineTermsOfPayment_Load);
    this.InitializeComponent();
    this._companyLineID = companyLineID;
  }

  private void frmCompanyLineTermsOfPayment_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblCompanyLineTermsOfPayment.TableName];
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstPaymentMethods"
    }, CommandType.Text, "SELECT ID, PaymentMethod FROM lstPaymentMethods ORDER BY PaymentMethod");
    this.da.SelectCommand.Parameters["@companyLineID"].Value = (object) this._companyLineID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineTermsOfPayment);
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("TermsOfPaymentBound"))
    {
      this.rbProdEffDateBoundDate.Visible = true;
      this.rbProducerEndEffDateBoundDate.Visible = true;
    }
    else
    {
      this.rbProdEffDateBoundDate.Visible = false;
      this.rbProducerEndEffDateBoundDate.Visible = false;
    }
  }

  private void UltraGrid1_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.UltraGrid1).ActiveRow == null)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["PaymentTermsID"].Value), "PaymentTermsID", (DataTable) this.ds.tblCompanyLineTermsOfPayment, this._bmb);
  }

  private bool IsValidForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.rbCompanyEffective, string.Empty);
    this.err.SetError((Control) this.cboPaymentMethods, string.Empty);
    this.err.SetError((Control) this.rbProducerEffectiveDate, string.Empty);
    this.err.SetError((Control) this.rbProdEffDateBoundDate, string.Empty);
    this.err.SetError((Control) this.txtTermsOfPayment, string.Empty);
    this.err.SetError((Control) this.rbDay, string.Empty);
    this.err.SetError((Control) this.txtProducerTermsOfPayment, string.Empty);
    this.err.SetError((Control) this.txtProducerEndTermsOfPayment, string.Empty);
    if (!this.rbProducerDay.Checked && !this.rbProducerEndOfMonth.Checked && !this.rbProducerEffectiveDate.Checked && !this.rbProdEffDateBoundDate.Checked && !this.rbProducerDateBilled.Checked && !this.rbProducerGAAP.Checked && !this.rbProdEndOfMonthEffective.Checked)
    {
      this.err.SetError((Control) this.rbProducerEffectiveDate, "Please select a payment term.");
      flag = false;
    }
    if (this.txtTermsOfPayment.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.txtTermsOfPayment, "Please enter the terms of payment.");
      flag = false;
    }
    if (!this.rbDay.Checked && !this.rbCompanyEndOfMonth.Checked && !this.rbCompanyEffective.Checked && !this.rbDateBilled.Checked && !this.rbDueDate.Checked && !this.rbEndOfEffectiveMonth.Checked && !this.rbCompanyGAAP.Checked && !this.rbEndOfEffectiveMonthGAAP.Checked)
    {
      this.err.SetError((Control) this.rbCompanyEffective, "Please select a payment term.");
      flag = false;
    }
    if (this.NoItemSelected(this.cboPaymentMethods))
    {
      this.err.SetError((Control) this.cboPaymentMethods, "Please select a valid payment method.");
      flag = false;
    }
    if (this.rbDay.Checked && this.txtDay.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.rbDay, "Please enter the number of days.");
      flag = false;
    }
    if (this.txtProducerTermsOfPayment.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.txtProducerTermsOfPayment, "Please enter a term of payment.");
      flag = false;
    }
    else if (Conversions.ToInteger(this.txtProducerTermsOfPayment.Value) < 0 || Conversions.ToInteger(this.txtProducerTermsOfPayment.Value) > 256 /*0x0100*/)
    {
      this.err.SetError((Control) this.txtProducerTermsOfPayment, "Must be between 0-256");
      flag = false;
    }
    if (this.txtProducerEndTermsOfPayment.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.txtProducerEndTermsOfPayment, "Please enter a term of payment.");
      flag = false;
    }
    else if (Conversions.ToInteger(this.txtProducerEndTermsOfPayment.Value) < 0 || Conversions.ToInteger(this.txtProducerEndTermsOfPayment.Value) > 256 /*0x0100*/)
    {
      this.err.SetError((Control) this.txtProducerEndTermsOfPayment, "Must be between 0-256");
      flag = false;
    }
    return flag;
  }

  private bool NoItemSelected(MGASimpleComboBox cbo)
  {
    return ((Control) cbo).Enabled && (((UltraDropDownBase) cbo).SelectedRow == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraDropDownBase) cbo).SelectedRow.Cells[((UltraDropDownBase) cbo).DisplayMember].Value.ToString(), string.Empty, false) == 0);
  }

  private void _bmb_PositionChanged(object sender, EventArgs e)
  {
    if (this._bmb.Position == -1 || this.ds.tblCompanyLineTermsOfPayment.Count == 0)
      return;
    string paymentMeasuredFrom1 = this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position].PaymentMeasuredFrom;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(paymentMeasuredFrom1))
    {
      case 3222007936:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom1, "E", false) == 0)
        {
          this.rbCompanyEffective.Checked = true;
          break;
        }
        break;
      case 3238785555:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom1, "D", false) == 0)
        {
          this.rbDay.Checked = true;
          break;
        }
        break;
      case 3255563174:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom1, "G", false) == 0)
        {
          this.rbCompanyGAAP.Checked = true;
          break;
        }
        break;
      case 3339451269:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom1, "B", false) == 0)
        {
          this.rbDateBilled.Checked = true;
          break;
        }
        break;
      case 3356228888:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom1, "M", false) == 0)
        {
          this.rbCompanyEndOfMonth.Checked = true;
          break;
        }
        break;
      case 3406561745:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom1, "N", false) == 0)
        {
          this.rbEndOfEffectiveMonth.Checked = true;
          break;
        }
        break;
      case 3490449840:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom1, "U", false) == 0)
        {
          this.rbDueDate.Checked = true;
          break;
        }
        break;
      case 3557560316:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom1, "Q", false) == 0)
        {
          this.rbEndOfEffectiveMonthGAAP.Checked = true;
          break;
        }
        break;
    }
    string paymentMeasuredFrom2 = this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position].ProducerPaymentMeasuredFrom;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(paymentMeasuredFrom2))
    {
      case 3222007936:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom2, "E", false) == 0)
        {
          this.rbProducerEffectiveDate.Checked = true;
          break;
        }
        break;
      case 3238785555:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom2, "D", false) == 0)
        {
          this.rbProducerDay.Checked = true;
          break;
        }
        break;
      case 3255563174:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom2, "G", false) == 0)
        {
          this.rbProducerGAAP.Checked = true;
          break;
        }
        break;
      case 3339451269:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom2, "B", false) == 0)
        {
          this.rbProducerDateBilled.Checked = true;
          break;
        }
        break;
      case 3356228888:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom2, "M", false) == 0)
        {
          this.rbProducerEndOfMonth.Checked = true;
          break;
        }
        break;
      case 3389784126:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom2, "O", false) == 0)
        {
          this.rbProdEffDateBoundDate.Checked = true;
          break;
        }
        break;
      case 3406561745:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentMeasuredFrom2, "N", false) == 0)
        {
          this.rbProdEndOfMonthEffective.Checked = true;
          break;
        }
        break;
    }
    string measuredFromEndorsement = this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position].ProducerPaymentMeasuredFrom_Endorsement;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(measuredFromEndorsement))
    {
      case 3222007936:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(measuredFromEndorsement, "E", false) != 0)
          break;
        this.rbProducerEndEffectiveDate.Checked = true;
        break;
      case 3238785555:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(measuredFromEndorsement, "D", false) != 0)
          break;
        this.rbProducerEndDay.Checked = true;
        break;
      case 3255563174:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(measuredFromEndorsement, "G", false) != 0)
          break;
        this.rbProducerEndorsementGAAP.Checked = true;
        break;
      case 3339451269:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(measuredFromEndorsement, "B", false) != 0)
          break;
        this.rbProducerEndDateBilled.Checked = true;
        break;
      case 3356228888:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(measuredFromEndorsement, "M", false) != 0)
          break;
        this.rbProducerEndorsementEndMonth.Checked = true;
        break;
      case 3389784126:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(measuredFromEndorsement, "O", false) != 0)
          break;
        this.rbProducerEndEffDateBoundDate.Checked = true;
        break;
      case 3406561745:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(measuredFromEndorsement, "N", false) != 0)
          break;
        this.rbProdEndOfMonthEffective_Endorsement.Checked = true;
        break;
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow row = this.ds.tblCompanyLineTermsOfPayment.NewtblCompanyLineTermsOfPaymentRow();
    row.CompanyLineID = this._companyLineID;
    row.Effective = DateAndTime.Now;
    this.ds.tblCompanyLineTermsOfPayment.AddtblCompanyLineTermsOfPaymentRow(row);
    this._bmb.Position = this.ds.tblCompanyLineTermsOfPayment.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    this._bmb.EndCurrentEdit();
    if (!this.IsValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow termsOfPaymentRow = this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position];
      bool isNewRecord = this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position].RowState == DataRowState.Added;
      bool flag = this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position].RowState == DataRowState.Modified;
      int position = this._bmb.Position;
      string paymentMeasuredFrom1 = termsOfPaymentRow.PaymentMeasuredFrom;
      string paymentMeasuredFrom2 = termsOfPaymentRow.ProducerPaymentMeasuredFrom;
      string measuredFromEndorsement = termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement;
      if (this.rbDay.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.PaymentMeasuredFrom, "D", false) != 0)
        termsOfPaymentRow.PaymentMeasuredFrom = "D";
      else if (this.rbCompanyEndOfMonth.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.PaymentMeasuredFrom, "M", false) != 0)
      {
        termsOfPaymentRow.PaymentMeasuredFrom = "M";
        termsOfPaymentRow.SetPaymentDayOfMonthNull();
      }
      else if (this.rbCompanyEffective.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.PaymentMeasuredFrom, "E", false) != 0)
      {
        termsOfPaymentRow.PaymentMeasuredFrom = "E";
        termsOfPaymentRow.SetPaymentDayOfMonthNull();
      }
      else if (this.rbDateBilled.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.PaymentMeasuredFrom, "B", false) != 0)
      {
        termsOfPaymentRow.PaymentMeasuredFrom = "B";
        termsOfPaymentRow.SetPaymentDayOfMonthNull();
      }
      else if (this.rbDueDate.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.PaymentMeasuredFrom, "U", false) != 0)
      {
        termsOfPaymentRow.PaymentMeasuredFrom = "U";
        termsOfPaymentRow.SetPaymentDayOfMonthNull();
      }
      else if (this.rbEndOfEffectiveMonth.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.PaymentMeasuredFrom, "N", false) != 0)
      {
        termsOfPaymentRow.PaymentMeasuredFrom = "N";
        termsOfPaymentRow.SetPaymentDayOfMonthNull();
      }
      else if (this.rbCompanyGAAP.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.PaymentMeasuredFrom, "G", false) != 0)
      {
        termsOfPaymentRow.PaymentMeasuredFrom = "G";
        termsOfPaymentRow.SetPaymentDayOfMonthNull();
      }
      else if (this.rbEndOfEffectiveMonthGAAP.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.PaymentMeasuredFrom, "Q", false) != 0)
      {
        termsOfPaymentRow.PaymentMeasuredFrom = "Q";
        termsOfPaymentRow.SetPaymentDayOfMonthNull();
      }
      if (this.rbProducerDay.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom, "D", false) != 0)
        termsOfPaymentRow.ProducerPaymentMeasuredFrom = "D";
      else if (this.rbProducerEndOfMonth.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom, "M", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom = "M";
        termsOfPaymentRow.SetProducerPaymentDayOfMonthNull();
      }
      else if (this.rbProducerEffectiveDate.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom, "E", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom = "E";
        termsOfPaymentRow.SetProducerPaymentDayOfMonthNull();
      }
      else if (this.rbProdEffDateBoundDate.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom, "O", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom = "O";
        termsOfPaymentRow.SetProducerPaymentDayOfMonthNull();
      }
      else if (this.rbProducerDateBilled.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom, "B", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom = "B";
        termsOfPaymentRow.SetProducerPaymentDayOfMonthNull();
      }
      else if (this.rbProducerGAAP.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom, "G", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom = "G";
        termsOfPaymentRow.SetProducerPaymentDayOfMonthNull();
      }
      else if (this.rbProdEndOfMonthEffective.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom, "N", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom = "N";
        termsOfPaymentRow.SetProducerPaymentDayOfMonthNull();
      }
      if (this.rbProducerEndDay.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement, "D", false) != 0)
        termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement = "D";
      else if (this.rbProducerEndorsementEndMonth.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement, "M", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement = "M";
        termsOfPaymentRow.SetProducerPaymentDayOfMonth_EndorsementNull();
      }
      else if (this.rbProducerEndEffectiveDate.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement, "E", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement = "E";
        termsOfPaymentRow.SetProducerPaymentDayOfMonth_EndorsementNull();
      }
      else if (this.rbProducerEndEffDateBoundDate.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement, "O", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement = "O";
        termsOfPaymentRow.SetProducerPaymentDayOfMonth_EndorsementNull();
      }
      else if (this.rbProducerEndDateBilled.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement, "B", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement = "B";
        termsOfPaymentRow.SetProducerPaymentDayOfMonth_EndorsementNull();
      }
      else if (this.rbProducerEndorsementGAAP.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement, "G", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement = "G";
        termsOfPaymentRow.SetProducerPaymentDayOfMonth_EndorsementNull();
      }
      else if (this.rbProdEndOfMonthEffective_Endorsement.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement, "N", false) != 0)
      {
        termsOfPaymentRow.ProducerPaymentMeasuredFrom_Endorsement = "N";
        termsOfPaymentRow.SetProducerPaymentDayOfMonth_EndorsementNull();
      }
      List<string> logList = new List<string>();
      this.LogChanges(isNewRecord, position, logList);
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineTermsOfPayment);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
        return;
      }
      Guid companyLineGuid = new CompanyLine(this._companyLineID).CompanyLineGuid;
      try
      {
        foreach (string action in logList)
          CurrentUser.Instance.LogAction(action, companyLineGuid, "Company/Line");
      }
      finally
      {
        List<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (!flag && !isNewRecord)
        return;
      this.CopyModifiedData(position);
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position == -1 || MessageBox.Show("Are you sure you want to delete this setup?", "Delete Terms of Payment Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    CompanyLine companyLine = new CompanyLine(this._companyLineID);
    string companyLineState = companyLine.CompanyLineState;
    DateTime dateTime = this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position].Effective;
    dateTime = dateTime.Date;
    string action = $"Deleted Terms of Payment - Effective {dateTime.ToShortDateString()} TermsOfPayment {(int) this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position].TermsOfPayment} on Company/Line {companyLineState}";
    this.ds.tblCompanyLineTermsOfPayment[this._bmb.Position].Delete();
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineTermsOfPayment);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    CurrentUser.Instance.LogAction(action, companyLine.CompanyLineGuid, "Company/Line");
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblCompanyLineTermsOfPayment.RejectChanges();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.UltraGrid1).Enabled = this.dbSave.UIState != UIState.Editing;
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control is UltraGroupBox)
          control.Enabled = this.dbSave.UIState == UIState.Editing;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.dbSave.UIState == UIState.Editing)
      return;
    if (this.ds.tblCompanyLineTermsOfPayment.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void CopyModifiedData(int bmbManangerID)
  {
    CompanyLine companyLine = new CompanyLine(this._companyLineID);
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLocationGuid=@CL AND LineGuid =@LG AND StateID <> @ST", new object[6]
    {
      (object) "@CL",
      (object) companyLine.CompanyLocationGuid,
      (object) "@LG",
      (object) companyLine.LineGuid,
      (object) "@ST",
      (object) companyLine.StateID
    }) <= 0 || MessageBox.Show("Changes have been made to the current payment terms.\n\nCopy the current payment terms configuration to states with this company/line ?", "Copy Payment Terms Configuration to Other Company / Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    int paymentTermsId = this.ds.tblCompanyLineTermsOfPayment[bmbManangerID].PaymentTermsID;
    DefaultDatabase.ExecuteNonQuery("UpdateCompanyLinePaymentTerms", new object[10]
    {
      (object) "@companyLocationGuid",
      (object) companyLine.CompanyLocationGuid,
      (object) "@lineGuid",
      (object) companyLine.LineGuid,
      (object) "@companyLineID",
      (object) this._companyLineID,
      (object) "@PaymentTermsID",
      (object) paymentTermsId,
      (object) "@stateID",
      (object) companyLine.StateID
    });
  }

  private string GetMeasuredFrom(string measuredFrom)
  {
    string empty = string.Empty;
    string str = measuredFrom;
    string measuredFrom1;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
    {
      case 3222007936:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E", false) == 0)
        {
          measuredFrom1 = "Company Effective";
          break;
        }
        goto default;
      case 3238785555:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "D", false) == 0)
        {
          measuredFrom1 = "Day";
          break;
        }
        goto default;
      case 3255563174:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "G", false) == 0)
        {
          measuredFrom1 = "Company GAAP ";
          break;
        }
        goto default;
      case 3339451269:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "B", false) == 0)
        {
          measuredFrom1 = "Date Billed";
          break;
        }
        goto default;
      case 3356228888:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "M", false) == 0)
        {
          measuredFrom1 = "Company End of Month";
          break;
        }
        goto default;
      case 3406561745:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "N", false) == 0)
        {
          measuredFrom1 = "End of Effective Month";
          break;
        }
        goto default;
      case 3490449840:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "U", false) == 0)
        {
          measuredFrom1 = "Due";
          break;
        }
        goto default;
      case 3557560316:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Q", false) == 0)
        {
          measuredFrom1 = "End of Month Effective GAAP";
          break;
        }
        goto default;
      default:
        measuredFrom1 = measuredFrom;
        break;
    }
    return measuredFrom1;
  }

  private void LogChanges(bool isNewRecord, int bmbManangerID, List<string> logList)
  {
    string companyLineState = new CompanyLine(this._companyLineID).CompanyLineState;
    DateTime dateTime = this.ds.tblCompanyLineTermsOfPayment[bmbManangerID].Effective;
    dateTime = dateTime.Date;
    string shortDateString = dateTime.ToShortDateString();
    int termsOfPayment = (int) this.ds.tblCompanyLineTermsOfPayment[bmbManangerID].TermsOfPayment;
    if (isNewRecord)
    {
      logList.Add($"Added Terms of Payment - Effective {shortDateString} TermsOfPayment {termsOfPayment} on Company/Line {companyLineState}");
    }
    else
    {
      string empty1 = string.Empty;
      string empty2 = string.Empty;
      string empty3 = string.Empty;
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblCompanyLineTermsOfPayment.Columns)
        {
          if (!column.ColumnName.Equals("PaymentTermsID") && !column.ColumnName.Equals("CompanyLineID"))
          {
            string measuredFrom1 = "<null>";
            string measuredFrom2 = "<null>";
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.ds.tblCompanyLineTermsOfPayment[bmbManangerID][column.ColumnName, DataRowVersion.Original])))
              measuredFrom1 = this.ds.tblCompanyLineTermsOfPayment[bmbManangerID][column.ColumnName, DataRowVersion.Original].ToString();
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.ds.tblCompanyLineTermsOfPayment[bmbManangerID][column.ColumnName, DataRowVersion.Current])))
              measuredFrom2 = this.ds.tblCompanyLineTermsOfPayment[bmbManangerID][column.ColumnName, DataRowVersion.Current].ToString();
            string str = column.ColumnName;
            switch (str)
            {
              case "PaymentMethodID":
                str = "Payment Method";
                if (!measuredFrom1.Equals(measuredFrom2))
                {
                  if (!measuredFrom1.Equals("<null>"))
                    measuredFrom1 = this.ds.lstPaymentMethods.FindByID(Conversions.ToInteger(measuredFrom1)).PaymentMethod;
                  if (!measuredFrom2.Equals("<null>"))
                  {
                    measuredFrom2 = this.ds.lstPaymentMethods.FindByID(Conversions.ToInteger(measuredFrom2)).PaymentMethod;
                    break;
                  }
                  break;
                }
                break;
              case "PaymentMeasuredFrom":
              case "ProducerPaymentMeasuredFrom":
              case "ProducerPaymentMeasuredFrom_Endorsement":
                switch (str)
                {
                  case "PaymentMeasuredFrom":
                    str = "Company Payment Measured From";
                    break;
                  case "ProducerPaymentMeasuredFrom":
                    str = "Producer Payment Measured From";
                    break;
                  case "ProducerPaymentMeasuredFrom_Endorsement":
                    str = "Producer Payment Measured From On Endorsement";
                    break;
                }
                if (!measuredFrom1.Equals(measuredFrom2))
                {
                  if (!measuredFrom1.Equals("<null>"))
                    measuredFrom1 = this.GetMeasuredFrom(measuredFrom1);
                  if (!measuredFrom2.Equals("<null>"))
                  {
                    measuredFrom2 = this.GetMeasuredFrom(measuredFrom2);
                    break;
                  }
                  break;
                }
                break;
            }
            if (!measuredFrom1.Equals(measuredFrom2))
              logList.Add($"Modified Terms of Payment - Effective {shortDateString}  Changed '{str}' from {measuredFrom1}  to {measuredFrom2} on Company/Line {companyLineState}");
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
}
