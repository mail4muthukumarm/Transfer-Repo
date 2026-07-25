// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormTransDateInstallment
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.Tools;
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

[DesignerGenerated]
public class FormTransDateInstallment : Form
{
  private IContainer components;
  private int _InstallmentID;
  private dsCompanyInstallments.tblCompanyBillingTypesDataTable _dtBillingType;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

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
    Appearance appearance27 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormTransDateInstallment));
    this.GroupBox1 = new MGAGroupBox();
    this.lblRecordCount = new Label();
    this.cLabelOn = new CurrencyLabel();
    this.numDownPaymentDayofMonth = new MGANumericEditor();
    this.ds = new dsTransDateInstallment();
    this.cLabelDayOfMonth = new CurrencyLabel();
    this.btnDelete = new MGAButton();
    this.btnSave = new MGAButton();
    this.MgaCheckBox1 = new MGACheckBox();
    this.chkUseEffectiveDateForBilling = new MGACheckBox();
    this.CurrencyLabel11 = new CurrencyLabel();
    this.numBillingDateDaysFromDueDate = new MGANumericEditor();
    this.GroupBox2 = new GroupBox();
    this.numExpirationAltFirstInstallDays = new MGANumericEditor();
    this.CurrencyLabel13 = new CurrencyLabel();
    this.chkFollowingDownPayment_Exp = new MGACheckBox();
    this.CurrencyLabel12 = new CurrencyLabel();
    this.NumPolicyExpirationInstallmentTerm = new MGANumericEditor();
    this.Label9 = new Label();
    this.chkUseMonthForAltFirstInstallment = new MGACheckBox();
    this.numDayOfMonthAltFirstInstallDays = new MGANumericEditor();
    this.CurrencyLabel10 = new CurrencyLabel();
    this.chkUseMonth = new MGACheckBox();
    this.chkFollowingDownPayment_Eff_DateBilled = new MGACheckBox();
    this.chkFollowingDownPayment_Eff = new MGACheckBox();
    this.CurrencyLabel9 = new CurrencyLabel();
    this.chkFollowingDownPayment_DayOfMonth = new MGACheckBox();
    this.CurrencyLabel7 = new CurrencyLabel();
    this.CurrencyLabel8 = new CurrencyLabel();
    this.numEffectiveAltFirstInstallDays = new MGANumericEditor();
    this.txtInstallmentTerms = new MGANumericEditor();
    this.numDayOfMonthInstallmentTerm = new MGANumericEditor();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.numEffDateBilledAltFirstInstallDays = new MGANumericEditor();
    this.rbInstallmentEffective = new RadioButton();
    this.CurrencyLabel6 = new CurrencyLabel();
    this.rbInstallmentDateBilled = new RadioButton();
    this.NumPolicyEffectiveInstallmentTerm = new MGANumericEditor();
    this.CurrencyLabel4 = new CurrencyLabel();
    this.Label3 = new Label();
    this.numDayofMonth = new MGANumericEditor();
    this.CurrencyLabel5 = new CurrencyLabel();
    this.grpInstallment = new GroupBox();
    this.rbPolicyExpiration = new RadioButton();
    this.rbEffectiveDateBilled = new RadioButton();
    this.rbDayOfMonth = new RadioButton();
    this.rbPolicyEffective = new RadioButton();
    this.chkDateBilled = new MGACheckBox();
    this.numDownPaymentTerm = new MGANumericEditor();
    this.cboDownpaymentBillingType = new MGASimpleComboBox();
    this.CurrencyLabel3 = new CurrencyLabel();
    this.Label5 = new Label();
    this.txtName = new MGATextBox();
    this.Label1 = new Label();
    this.Label7 = new Label();
    this.Panel1 = new Panel();
    this.rbDownPaymentFromEffEndMonth = new RadioButton();
    this.rbDownpaymentExpiration = new RadioButton();
    this.rbDownPaymentGAAP = new RadioButton();
    this.rbDownpaymentDateBilled = new RadioButton();
    this.rbDownpaymentEffective = new RadioButton();
    this.err = new ErrorProvider(this.components);
    this.cn = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    ((ISupportInitialize) this.GroupBox1).BeginInit();
    ((Control) this.GroupBox1).SuspendLayout();
    ((ISupportInitialize) this.numDownPaymentDayofMonth).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnDelete).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.chkUseEffectiveDateForBilling).BeginInit();
    ((ISupportInitialize) this.numBillingDateDaysFromDueDate).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.numExpirationAltFirstInstallDays).BeginInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Exp).BeginInit();
    ((ISupportInitialize) this.NumPolicyExpirationInstallmentTerm).BeginInit();
    ((ISupportInitialize) this.chkUseMonthForAltFirstInstallment).BeginInit();
    ((ISupportInitialize) this.numDayOfMonthAltFirstInstallDays).BeginInit();
    ((ISupportInitialize) this.chkUseMonth).BeginInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Eff_DateBilled).BeginInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Eff).BeginInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_DayOfMonth).BeginInit();
    ((ISupportInitialize) this.numEffectiveAltFirstInstallDays).BeginInit();
    ((ISupportInitialize) this.txtInstallmentTerms).BeginInit();
    ((ISupportInitialize) this.numDayOfMonthInstallmentTerm).BeginInit();
    ((ISupportInitialize) this.numEffDateBilledAltFirstInstallDays).BeginInit();
    ((ISupportInitialize) this.NumPolicyEffectiveInstallmentTerm).BeginInit();
    ((ISupportInitialize) this.numDayofMonth).BeginInit();
    this.grpInstallment.SuspendLayout();
    ((ISupportInitialize) this.chkDateBilled).BeginInit();
    ((ISupportInitialize) this.numDownPaymentTerm).BeginInit();
    ((ISupportInitialize) this.cboDownpaymentBillingType).BeginInit();
    ((ISupportInitialize) this.txtName).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox1.Appearance = (AppearanceBase) appearance1;
    this.GroupBox1.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.GroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.GroupBox1).Controls.Add((Control) this.lblRecordCount);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cLabelOn);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numDownPaymentDayofMonth);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cLabelDayOfMonth);
    ((Control) this.GroupBox1).Controls.Add((Control) this.btnDelete);
    ((Control) this.GroupBox1).Controls.Add((Control) this.btnSave);
    ((Control) this.GroupBox1).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkUseEffectiveDateForBilling);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CurrencyLabel11);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numBillingDateDaysFromDueDate);
    ((Control) this.GroupBox1).Controls.Add((Control) this.GroupBox2);
    ((Control) this.GroupBox1).Controls.Add((Control) this.grpInstallment);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkDateBilled);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numDownPaymentTerm);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cboDownpaymentBillingType);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CurrencyLabel3);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label5);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtName);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label7);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Panel1);
    this.GroupBox1.Dock = DockStyle.Fill;
    ((Control) this.GroupBox1).Enabled = false;
    appearance3.AlphaLevel = (short) 230;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.White;
    appearance3.ForegroundAlpha = (Alpha) 2;
    appearance3.ImageBackgroundAlpha = (Alpha) 1;
    appearance3.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.GroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.GroupBox1).Location = new Point(0, 0);
    ((Control) this.GroupBox1).Name = "GroupBox1";
    ((Control) this.GroupBox1).Size = new Size(829, 388);
    ((Control) this.GroupBox1).TabIndex = 2;
    this.GroupBox1.Text = "Details";
    this.GroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.lblRecordCount.AutoSize = true;
    this.lblRecordCount.BackColor = Color.Transparent;
    this.lblRecordCount.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblRecordCount.Location = new Point(668, 29);
    this.lblRecordCount.Name = "lblRecordCount";
    this.lblRecordCount.Size = new Size(93, 15);
    this.lblRecordCount.TabIndex = 17;
    this.lblRecordCount.Text = "0 of 0 Record";
    this.cLabelOn.AutoSize = true;
    this.cLabelOn.BackColor = Color.Transparent;
    this.cLabelOn.Location = new Point(642, 97);
    this.cLabelOn.Name = "cLabelOn";
    this.cLabelOn.Size = new Size(19, 13);
    this.cLabelOn.TabIndex = 6;
    this.cLabelOn.Text = "on";
    appearance4.BackColorDisabled = Color.Gainsboro;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDownPaymentDayofMonth).Appearance = (AppearanceBase) appearance4;
    ((Control) this.numDownPaymentDayofMonth).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallmentsTransDate.DownPaymentDayofMonth", true));
    ((Control) this.numDownPaymentDayofMonth).Location = new Point(671, 94);
    this.numDownPaymentDayofMonth.MaskInput = "nn";
    this.numDownPaymentDayofMonth.MaxValue = (object) 31 /*0x1F*/;
    this.numDownPaymentDayofMonth.MGAStyle = MGAStyles.Blue;
    this.numDownPaymentDayofMonth.MinValue = (object) 0;
    ((Control) this.numDownPaymentDayofMonth).Name = "numDownPaymentDayofMonth";
    this.numDownPaymentDayofMonth.Nullable = true;
    ((Control) this.numDownPaymentDayofMonth).Size = new Size(21, 19);
    ((Control) this.numDownPaymentDayofMonth).TabIndex = 7;
    ((UltraControlBase) this.numDownPaymentDayofMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDownPaymentDayofMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsTransDateInstallment";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cLabelDayOfMonth.AutoSize = true;
    this.cLabelDayOfMonth.BackColor = Color.Transparent;
    this.cLabelDayOfMonth.Location = new Point(702, 97);
    this.cLabelDayOfMonth.Name = "cLabelDayOfMonth";
    this.cLabelDayOfMonth.Size = new Size(89, 13);
    this.cLabelDayOfMonth.TabIndex = 8;
    this.cLabelDayOfMonth.Text = "day of the month.";
    ((Control) this.btnDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.Gray;
    appearance5.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnDelete).Font = new Font("Tahoma", 8f);
    ((ControlBase) this.btnDelete).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnDelete).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnDelete).Location = new Point(742, 338);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new Size(40, 40);
    ((Control) this.btnDelete).TabIndex = 16 /*0x10*/;
    this.btnDelete.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.BackColor = Color.Gainsboro;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.Gray;
    appearance6.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance6;
    ((Control) this.btnSave).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(682, 338);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 15;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.DownPaymentUsingBusinessDays", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(420, 91);
    this.MgaCheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(215, 24);
    ((Control) this.MgaCheckBox1).TabIndex = 5;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Downpayment Using Business Days";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).BackColorInternal = Color.Transparent;
    ((Control) this.chkUseEffectiveDateForBilling).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.UseEffectiveDateForBilling", true));
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseEffectiveDateForBilling).Location = new Point(420, 350);
    this.chkUseEffectiveDateForBilling.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseEffectiveDateForBilling).Name = "chkUseEffectiveDateForBilling";
    ((Control) this.chkUseEffectiveDateForBilling).Size = new Size(155, 24);
    ((Control) this.chkUseEffectiveDateForBilling).TabIndex = 14;
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).Text = "using policy effective day.";
    ((UltraControlBase) this.chkUseEffectiveDateForBilling).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseEffectiveDateForBilling).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel11.AutoSize = true;
    this.CurrencyLabel11.BackColor = Color.Transparent;
    this.CurrencyLabel11.Location = new Point(264, 356);
    this.CurrencyLabel11.Name = "CurrencyLabel11";
    this.CurrencyLabel11.Size = new Size(146, 13);
    this.CurrencyLabel11.TabIndex = 13;
    this.CurrencyLabel11.Text = "days/months before due date";
    appearance9.BackColorDisabled = Color.Gainsboro;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numBillingDateDaysFromDueDate).Appearance = (AppearanceBase) appearance9;
    ((Control) this.numBillingDateDaysFromDueDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallmentsTransDate.BillingDateDaysFromDueDate", true));
    ((Control) this.numBillingDateDaysFromDueDate).Location = new Point(206, 352);
    this.numBillingDateDaysFromDueDate.MaskInput = "-nnn";
    this.numBillingDateDaysFromDueDate.MaxValue = (object) 999;
    this.numBillingDateDaysFromDueDate.MGAStyle = MGAStyles.Blue;
    this.numBillingDateDaysFromDueDate.MinValue = (object) -999;
    ((Control) this.numBillingDateDaysFromDueDate).Name = "numBillingDateDaysFromDueDate";
    this.numBillingDateDaysFromDueDate.Nullable = true;
    ((Control) this.numBillingDateDaysFromDueDate).Size = new Size(45, 19);
    ((Control) this.numBillingDateDaysFromDueDate).TabIndex = 12;
    ((UltraWinEditorMaskedControlBase) this.numBillingDateDaysFromDueDate).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numBillingDateDaysFromDueDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numBillingDateDaysFromDueDate).UseOsThemes = (DefaultableBoolean) 2;
    this.numBillingDateDaysFromDueDate.Value = (object) null;
    this.GroupBox2.Controls.Add((Control) this.numExpirationAltFirstInstallDays);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel13);
    this.GroupBox2.Controls.Add((Control) this.chkFollowingDownPayment_Exp);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel12);
    this.GroupBox2.Controls.Add((Control) this.NumPolicyExpirationInstallmentTerm);
    this.GroupBox2.Controls.Add((Control) this.Label9);
    this.GroupBox2.Controls.Add((Control) this.chkUseMonthForAltFirstInstallment);
    this.GroupBox2.Controls.Add((Control) this.numDayOfMonthAltFirstInstallDays);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel10);
    this.GroupBox2.Controls.Add((Control) this.chkUseMonth);
    this.GroupBox2.Controls.Add((Control) this.chkFollowingDownPayment_Eff_DateBilled);
    this.GroupBox2.Controls.Add((Control) this.chkFollowingDownPayment_Eff);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel9);
    this.GroupBox2.Controls.Add((Control) this.chkFollowingDownPayment_DayOfMonth);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel7);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel8);
    this.GroupBox2.Controls.Add((Control) this.numEffectiveAltFirstInstallDays);
    this.GroupBox2.Controls.Add((Control) this.txtInstallmentTerms);
    this.GroupBox2.Controls.Add((Control) this.numDayOfMonthInstallmentTerm);
    this.GroupBox2.Controls.Add((Control) this.Label6);
    this.GroupBox2.Controls.Add((Control) this.Label8);
    this.GroupBox2.Controls.Add((Control) this.numEffDateBilledAltFirstInstallDays);
    this.GroupBox2.Controls.Add((Control) this.rbInstallmentEffective);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel6);
    this.GroupBox2.Controls.Add((Control) this.rbInstallmentDateBilled);
    this.GroupBox2.Controls.Add((Control) this.NumPolicyEffectiveInstallmentTerm);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel4);
    this.GroupBox2.Controls.Add((Control) this.Label3);
    this.GroupBox2.Controls.Add((Control) this.numDayofMonth);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel5);
    this.GroupBox2.Location = new Point(39, 175);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(727, 148);
    this.GroupBox2.TabIndex = 10;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Installment Term Details";
    appearance10.BackColorDisabled = Color.Gainsboro;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExpirationAltFirstInstallDays).Appearance = (AppearanceBase) appearance10;
    ((Control) this.numExpirationAltFirstInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallmentsTransDate.ExpirationAltFirstInstallDays", true));
    ((Control) this.numExpirationAltFirstInstallDays).Location = new Point(544, 69);
    this.numExpirationAltFirstInstallDays.MaskInput = "nnn";
    this.numExpirationAltFirstInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numExpirationAltFirstInstallDays).Name = "numExpirationAltFirstInstallDays";
    this.numExpirationAltFirstInstallDays.Nullable = true;
    ((Control) this.numExpirationAltFirstInstallDays).Size = new Size(27, 19);
    ((Control) this.numExpirationAltFirstInstallDays).TabIndex = 19;
    ((UltraControlBase) this.numExpirationAltFirstInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExpirationAltFirstInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel13.AutoSize = true;
    this.CurrencyLabel13.BackColor = Color.Transparent;
    this.CurrencyLabel13.Location = new Point(577, 73);
    this.CurrencyLabel13.Name = "CurrencyLabel13";
    this.CurrencyLabel13.Size = new Size(136, 13);
    this.CurrencyLabel13.TabIndex = 20;
    this.CurrencyLabel13.Text = "alt.  days for 1st  installment";
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).BackColorInternal = Color.Transparent;
    ((Control) this.chkFollowingDownPayment_Exp).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_Exp", true));
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFollowingDownPayment_Exp).Location = new Point(404, 69);
    this.chkFollowingDownPayment_Exp.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFollowingDownPayment_Exp).Name = "chkFollowingDownPayment_Exp";
    ((Control) this.chkFollowingDownPayment_Exp).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkFollowingDownPayment_Exp).TabIndex = 17;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Text = "Following DownPymt";
    ((UltraControlBase) this.chkFollowingDownPayment_Exp).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFollowingDownPayment_Exp).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel12.AutoSize = true;
    this.CurrencyLabel12.BackColor = Color.Transparent;
    this.CurrencyLabel12.Location = new Point(154, 73);
    this.CurrencyLabel12.Name = "CurrencyLabel12";
    this.CurrencyLabel12.Size = new Size(169, 13);
    this.CurrencyLabel12.TabIndex = 16 /*0x10*/;
    this.CurrencyLabel12.Text = "days from expiration date of policy.";
    appearance12.BackColorDisabled = Color.Gainsboro;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.NumPolicyExpirationInstallmentTerm).Appearance = (AppearanceBase) appearance12;
    ((Control) this.NumPolicyExpirationInstallmentTerm).Location = new Point(117, 69);
    this.NumPolicyExpirationInstallmentTerm.MaskInput = "nnn";
    this.NumPolicyExpirationInstallmentTerm.MGAStyle = MGAStyles.Blue;
    ((Control) this.NumPolicyExpirationInstallmentTerm).Name = "NumPolicyExpirationInstallmentTerm";
    this.NumPolicyExpirationInstallmentTerm.Nullable = true;
    ((Control) this.NumPolicyExpirationInstallmentTerm).Size = new Size(27, 19);
    ((Control) this.NumPolicyExpirationInstallmentTerm).TabIndex = 15;
    ((UltraControlBase) this.NumPolicyExpirationInstallmentTerm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.NumPolicyExpirationInstallmentTerm).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(22, 74);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(87, 13);
    this.Label9.TabIndex = 14;
    this.Label9.Text = "Policy Expiration:";
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).BackColorInternal = Color.Transparent;
    ((Control) this.chkUseMonthForAltFirstInstallment).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.UseMonthForAltFirstInstallment", true));
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseMonthForAltFirstInstallment).Location = new Point(403, 118);
    this.chkUseMonthForAltFirstInstallment.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseMonthForAltFirstInstallment).Name = "chkUseMonthForAltFirstInstallment";
    ((Control) this.chkUseMonthForAltFirstInstallment).Size = new Size(280, 24);
    ((Control) this.chkUseMonthForAltFirstInstallment).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).Text = "Use Months in lieu of Days for Alt. 1st Installment";
    ((UltraControlBase) this.chkUseMonthForAltFirstInstallment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseMonthForAltFirstInstallment).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BackColorDisabled = Color.Gainsboro;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDayOfMonthAltFirstInstallDays).Appearance = (AppearanceBase) appearance14;
    ((Control) this.numDayOfMonthAltFirstInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallmentsTransDate.DayOfMonthAltFirstInstallDays", true));
    ((Control) this.numDayOfMonthAltFirstInstallDays).Location = new Point(544, 95);
    this.numDayOfMonthAltFirstInstallDays.MaskInput = "nnn";
    this.numDayOfMonthAltFirstInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDayOfMonthAltFirstInstallDays).Name = "numDayOfMonthAltFirstInstallDays";
    this.numDayOfMonthAltFirstInstallDays.Nullable = true;
    ((Control) this.numDayOfMonthAltFirstInstallDays).Size = new Size(27, 19);
    ((Control) this.numDayOfMonthAltFirstInstallDays).TabIndex = 28;
    ((UltraControlBase) this.numDayOfMonthAltFirstInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDayOfMonthAltFirstInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel10.AutoSize = true;
    this.CurrencyLabel10.BackColor = Color.Transparent;
    this.CurrencyLabel10.Location = new Point(577, 99);
    this.CurrencyLabel10.Name = "CurrencyLabel10";
    this.CurrencyLabel10.Size = new Size(136, 13);
    this.CurrencyLabel10.TabIndex = 29;
    this.CurrencyLabel10.Text = "alt.  days for 1st  installment";
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseMonth).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.chkUseMonth).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseMonth).BackColorInternal = Color.Transparent;
    ((Control) this.chkUseMonth).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.UseMonth", true));
    ((UltraToggleEditorBase) this.chkUseMonth).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseMonth).Location = new Point(117, 121);
    this.chkUseMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseMonth).Name = "chkUseMonth";
    ((Control) this.chkUseMonth).Size = new Size(167, 24);
    ((Control) this.chkUseMonth).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkUseMonth).Text = "Use Months in lieu of Days";
    ((UltraControlBase) this.chkUseMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseMonth).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Appearance = (AppearanceBase) appearance16;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).BackColorInternal = Color.Transparent;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_Eff_DateBilled", true));
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Location = new Point(404, 17);
    this.chkFollowingDownPayment_Eff_DateBilled.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Name = "chkFollowingDownPayment_Eff_DateBilled";
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).TabIndex = 5;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Text = "Following DownPymt";
    ((UltraControlBase) this.chkFollowingDownPayment_Eff_DateBilled).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFollowingDownPayment_Eff_DateBilled).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).BackColorInternal = Color.Transparent;
    ((Control) this.chkFollowingDownPayment_Eff).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_Eff", true));
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFollowingDownPayment_Eff).Location = new Point(404, 43);
    this.chkFollowingDownPayment_Eff.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFollowingDownPayment_Eff).Name = "chkFollowingDownPayment_Eff";
    ((Control) this.chkFollowingDownPayment_Eff).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkFollowingDownPayment_Eff).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Text = "Following DownPymt";
    ((UltraControlBase) this.chkFollowingDownPayment_Eff).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFollowingDownPayment_Eff).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel9.AutoSize = true;
    this.CurrencyLabel9.BackColor = Color.Transparent;
    this.CurrencyLabel9.Location = new Point(577, 47);
    this.CurrencyLabel9.Name = "CurrencyLabel9";
    this.CurrencyLabel9.Size = new Size(136, 13);
    this.CurrencyLabel9.TabIndex = 13;
    this.CurrencyLabel9.Text = "alt.  days for 1st  installment";
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Appearance = (AppearanceBase) appearance18;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).BackColorInternal = Color.Transparent;
    ((Control) this.chkFollowingDownPayment_DayOfMonth).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment", true));
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFollowingDownPayment_DayOfMonth).Location = new Point(404, 95);
    this.chkFollowingDownPayment_DayOfMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFollowingDownPayment_DayOfMonth).Name = "chkFollowingDownPayment_DayOfMonth";
    ((Control) this.chkFollowingDownPayment_DayOfMonth).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkFollowingDownPayment_DayOfMonth).TabIndex = 26;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Text = "Following DownPymt";
    ((UltraControlBase) this.chkFollowingDownPayment_DayOfMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFollowingDownPayment_DayOfMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel7.AutoSize = true;
    this.CurrencyLabel7.BackColor = Color.Transparent;
    this.CurrencyLabel7.Location = new Point(153, 47);
    this.CurrencyLabel7.Name = "CurrencyLabel7";
    this.CurrencyLabel7.Size = new Size(165, 13);
    this.CurrencyLabel7.TabIndex = 10;
    this.CurrencyLabel7.Text = "days from effective date of policy.";
    this.CurrencyLabel8.AutoSize = true;
    this.CurrencyLabel8.BackColor = Color.Transparent;
    this.CurrencyLabel8.Location = new Point(577, 21);
    this.CurrencyLabel8.Name = "CurrencyLabel8";
    this.CurrencyLabel8.Size = new Size(136, 13);
    this.CurrencyLabel8.TabIndex = 7;
    this.CurrencyLabel8.Text = "alt.  days for 1st  installment";
    appearance19.BackColorDisabled = Color.Gainsboro;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numEffectiveAltFirstInstallDays).Appearance = (AppearanceBase) appearance19;
    ((Control) this.numEffectiveAltFirstInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallmentsTransDate.EffectiveAltFirstInstallDays", true));
    ((Control) this.numEffectiveAltFirstInstallDays).Location = new Point(544, 43);
    this.numEffectiveAltFirstInstallDays.MaskInput = "nnn";
    this.numEffectiveAltFirstInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numEffectiveAltFirstInstallDays).Name = "numEffectiveAltFirstInstallDays";
    this.numEffectiveAltFirstInstallDays.Nullable = true;
    ((Control) this.numEffectiveAltFirstInstallDays).Size = new Size(27, 19);
    ((Control) this.numEffectiveAltFirstInstallDays).TabIndex = 12;
    ((UltraControlBase) this.numEffectiveAltFirstInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numEffectiveAltFirstInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BackColorDisabled = Color.Gainsboro;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtInstallmentTerms).Appearance = (AppearanceBase) appearance20;
    ((Control) this.txtInstallmentTerms).Location = new Point(117, 17);
    this.txtInstallmentTerms.MaskInput = "nnn";
    this.txtInstallmentTerms.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtInstallmentTerms).Name = "txtInstallmentTerms";
    this.txtInstallmentTerms.Nullable = true;
    ((Control) this.txtInstallmentTerms).Size = new Size(27, 19);
    ((Control) this.txtInstallmentTerms).TabIndex = 1;
    ((UltraControlBase) this.txtInstallmentTerms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInstallmentTerms).UseOsThemes = (DefaultableBoolean) 2;
    appearance21.BackColorDisabled = Color.Gainsboro;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDayOfMonthInstallmentTerm).Appearance = (AppearanceBase) appearance21;
    ((Control) this.numDayOfMonthInstallmentTerm).Location = new Point(117, 95);
    this.numDayOfMonthInstallmentTerm.MaskInput = "nnn";
    this.numDayOfMonthInstallmentTerm.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDayOfMonthInstallmentTerm).Name = "numDayOfMonthInstallmentTerm";
    this.numDayOfMonthInstallmentTerm.Nullable = true;
    ((Control) this.numDayOfMonthInstallmentTerm).Size = new Size(27, 19);
    ((Control) this.numDayOfMonthInstallmentTerm).TabIndex = 22;
    ((UltraControlBase) this.numDayOfMonthInstallmentTerm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDayOfMonthInstallmentTerm).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(6, 21);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(105, 13);
    this.Label6.TabIndex = 0;
    this.Label6.Text = "Effective/DateBilled:";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(35, 99);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(74, 13);
    this.Label8.TabIndex = 21;
    this.Label8.Text = "Day of Month:";
    appearance22.BackColorDisabled = Color.Gainsboro;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numEffDateBilledAltFirstInstallDays).Appearance = (AppearanceBase) appearance22;
    ((Control) this.numEffDateBilledAltFirstInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallmentsTransDate.EffDateBilledAltFirstInstallDays", true));
    ((Control) this.numEffDateBilledAltFirstInstallDays).Location = new Point(544, 17);
    this.numEffDateBilledAltFirstInstallDays.MaskInput = "nnn";
    this.numEffDateBilledAltFirstInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numEffDateBilledAltFirstInstallDays).Name = "numEffDateBilledAltFirstInstallDays";
    this.numEffDateBilledAltFirstInstallDays.Nullable = true;
    ((Control) this.numEffDateBilledAltFirstInstallDays).Size = new Size(27, 19);
    ((Control) this.numEffDateBilledAltFirstInstallDays).TabIndex = 6;
    ((UltraControlBase) this.numEffDateBilledAltFirstInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numEffDateBilledAltFirstInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    this.rbInstallmentEffective.BackColor = Color.Transparent;
    this.rbInstallmentEffective.Location = new Point(214, 18);
    this.rbInstallmentEffective.Name = "rbInstallmentEffective";
    this.rbInstallmentEffective.Size = new Size(98, 18);
    this.rbInstallmentEffective.TabIndex = 2;
    this.rbInstallmentEffective.Text = "Effective Date";
    this.rbInstallmentEffective.UseVisualStyleBackColor = false;
    this.CurrencyLabel6.AutoSize = true;
    this.CurrencyLabel6.BackColor = Color.Transparent;
    this.CurrencyLabel6.Location = new Point(154, 99);
    this.CurrencyLabel6.Name = "CurrencyLabel6";
    this.CurrencyLabel6.Size = new Size(44, 13);
    this.CurrencyLabel6.TabIndex = 23;
    this.CurrencyLabel6.Text = "days on";
    this.rbInstallmentDateBilled.BackColor = Color.Transparent;
    this.rbInstallmentDateBilled.Location = new Point(318, 19);
    this.rbInstallmentDateBilled.Name = "rbInstallmentDateBilled";
    this.rbInstallmentDateBilled.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.rbInstallmentDateBilled.TabIndex = 4;
    this.rbInstallmentDateBilled.Text = "Date Billed";
    this.rbInstallmentDateBilled.UseVisualStyleBackColor = false;
    appearance23.BackColorDisabled = Color.Gainsboro;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.NumPolicyEffectiveInstallmentTerm).Appearance = (AppearanceBase) appearance23;
    ((Control) this.NumPolicyEffectiveInstallmentTerm).Location = new Point(117, 43);
    this.NumPolicyEffectiveInstallmentTerm.MaskInput = "nnn";
    this.NumPolicyEffectiveInstallmentTerm.MGAStyle = MGAStyles.Blue;
    ((Control) this.NumPolicyEffectiveInstallmentTerm).Name = "NumPolicyEffectiveInstallmentTerm";
    this.NumPolicyEffectiveInstallmentTerm.Nullable = true;
    ((Control) this.NumPolicyEffectiveInstallmentTerm).Size = new Size(27, 19);
    ((Control) this.NumPolicyEffectiveInstallmentTerm).TabIndex = 9;
    ((UltraControlBase) this.NumPolicyEffectiveInstallmentTerm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.NumPolicyEffectiveInstallmentTerm).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel4.AutoSize = true;
    this.CurrencyLabel4.BackColor = Color.Transparent;
    this.CurrencyLabel4.Location = new Point(153, 21);
    this.CurrencyLabel4.Name = "CurrencyLabel4";
    this.CurrencyLabel4.Size = new Size(52, 13);
    this.CurrencyLabel4.TabIndex = 3;
    this.CurrencyLabel4.Text = "days from";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(27, 47);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(83, 13);
    this.Label3.TabIndex = 8;
    this.Label3.Text = "Policy Effective:";
    appearance24.BackColorDisabled = Color.Gainsboro;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDayofMonth).Appearance = (AppearanceBase) appearance24;
    ((Control) this.numDayofMonth).Location = new Point(214, 95);
    this.numDayofMonth.MaskInput = "nn";
    this.numDayofMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDayofMonth).Name = "numDayofMonth";
    this.numDayofMonth.Nullable = true;
    ((Control) this.numDayofMonth).Size = new Size(21, 19);
    ((Control) this.numDayofMonth).TabIndex = 24;
    ((UltraControlBase) this.numDayofMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDayofMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel5.AutoSize = true;
    this.CurrencyLabel5.BackColor = Color.Transparent;
    this.CurrencyLabel5.Location = new Point(247, 99);
    this.CurrencyLabel5.Name = "CurrencyLabel5";
    this.CurrencyLabel5.Size = new Size(89, 13);
    this.CurrencyLabel5.TabIndex = 25;
    this.CurrencyLabel5.Text = "day of the month.";
    this.grpInstallment.Controls.Add((Control) this.rbPolicyExpiration);
    this.grpInstallment.Controls.Add((Control) this.rbEffectiveDateBilled);
    this.grpInstallment.Controls.Add((Control) this.rbDayOfMonth);
    this.grpInstallment.Controls.Add((Control) this.rbPolicyEffective);
    this.grpInstallment.Location = new Point(56, 116);
    this.grpInstallment.Name = "grpInstallment";
    this.grpInstallment.Size = new Size(602, 43);
    this.grpInstallment.TabIndex = 9;
    this.grpInstallment.TabStop = false;
    this.grpInstallment.Text = "Installment Terms";
    this.rbPolicyExpiration.BackColor = Color.Transparent;
    this.rbPolicyExpiration.Location = new Point(346, 14);
    this.rbPolicyExpiration.Name = "rbPolicyExpiration";
    this.rbPolicyExpiration.Size = new Size(112 /*0x70*/, 22);
    this.rbPolicyExpiration.TabIndex = 2;
    this.rbPolicyExpiration.Text = "Policy Expiration";
    this.rbPolicyExpiration.UseVisualStyleBackColor = false;
    this.rbEffectiveDateBilled.BackColor = Color.Transparent;
    this.rbEffectiveDateBilled.Location = new Point(38, 13);
    this.rbEffectiveDateBilled.Name = "rbEffectiveDateBilled";
    this.rbEffectiveDateBilled.Size = new Size(128 /*0x80*/, 24);
    this.rbEffectiveDateBilled.TabIndex = 0;
    this.rbEffectiveDateBilled.Text = "Effective / DateBilled";
    this.rbEffectiveDateBilled.UseVisualStyleBackColor = false;
    this.rbDayOfMonth.BackColor = Color.Transparent;
    this.rbDayOfMonth.Location = new Point(497, 13);
    this.rbDayOfMonth.Name = "rbDayOfMonth";
    this.rbDayOfMonth.Size = new Size(98, 24);
    this.rbDayOfMonth.TabIndex = 3;
    this.rbDayOfMonth.Text = "Day of Month";
    this.rbDayOfMonth.UseVisualStyleBackColor = false;
    this.rbPolicyEffective.BackColor = Color.Transparent;
    this.rbPolicyEffective.Location = new Point(205, 14);
    this.rbPolicyEffective.Name = "rbPolicyEffective";
    this.rbPolicyEffective.Size = new Size(102, 22);
    this.rbPolicyEffective.TabIndex = 1;
    this.rbPolicyEffective.Text = "Policy Effective";
    this.rbPolicyEffective.UseVisualStyleBackColor = false;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDateBilled).Appearance = (AppearanceBase) appearance25;
    ((UltraToggleEditorBase) this.chkDateBilled).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDateBilled).BackColorInternal = Color.Transparent;
    ((Control) this.chkDateBilled).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallmentsTransDate.DateBilledEqualToDueDate", true));
    ((UltraToggleEditorBase) this.chkDateBilled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDateBilled).Location = new Point(11, 350);
    this.chkDateBilled.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDateBilled).Name = "chkDateBilled";
    ((Control) this.chkDateBilled).Size = new Size(189, 24);
    ((Control) this.chkDateBilled).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkDateBilled).Text = "Set date billed equal to due date";
    ((UltraControlBase) this.chkDateBilled).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDateBilled).UseOsThemes = (DefaultableBoolean) 2;
    appearance26.BackColorDisabled = Color.Gainsboro;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDownPaymentTerm).Appearance = (AppearanceBase) appearance26;
    ((Control) this.numDownPaymentTerm).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallmentsTransDate.DownpaymentTerm", true));
    ((Control) this.numDownPaymentTerm).Location = new Point(164, 62);
    this.numDownPaymentTerm.MaskInput = "nnn";
    this.numDownPaymentTerm.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDownPaymentTerm).Name = "numDownPaymentTerm";
    this.numDownPaymentTerm.Nullable = true;
    ((Control) this.numDownPaymentTerm).Size = new Size(51, 19);
    ((Control) this.numDownPaymentTerm).TabIndex = 1;
    ((UltraControlBase) this.numDownPaymentTerm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDownPaymentTerm).UseOsThemes = (DefaultableBoolean) 2;
    this.cboDownpaymentBillingType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDownpaymentBillingType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallmentsTransDate.DownpaymentBillingTypeID", true));
    ((UltraGridBase) this.cboDownpaymentBillingType).DataMember = "tblCompanyBillingTypes";
    ((UltraGridBase) this.cboDownpaymentBillingType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboDownpaymentBillingType).DisplayMember = "BillingType";
    this.cboDownpaymentBillingType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDownpaymentBillingType).Location = new Point(164, 93);
    this.cboDownpaymentBillingType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDownpaymentBillingType).Name = "cboDownpaymentBillingType";
    ((Control) this.cboDownpaymentBillingType).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cboDownpaymentBillingType).TabIndex = 4;
    ((UltraControlBase) this.cboDownpaymentBillingType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDownpaymentBillingType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDownpaymentBillingType).ValueMember = "BillingTypeID";
    this.CurrencyLabel3.AutoSize = true;
    this.CurrencyLabel3.BackColor = Color.Transparent;
    this.CurrencyLabel3.Location = new Point(227, 66);
    this.CurrencyLabel3.Name = "CurrencyLabel3";
    this.CurrencyLabel3.Size = new Size(52, 13);
    this.CurrencyLabel3.TabIndex = 2;
    this.CurrencyLabel3.Text = "days from";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(53, 66);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(105, 13);
    this.Label5.TabIndex = 5;
    this.Label5.Text = "Downpayment Term:";
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtName).Appearance = (AppearanceBase) appearance27;
    ((TextEditorControlBase) this.txtName).BackColor = Color.White;
    ((Control) this.txtName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblCompanyLineInstallmentsTransDate.OptionName", true));
    ((Control) this.txtName).Location = new Point(164, 25);
    ((TextEditorControlBase) this.txtName).MaxLength = 100;
    this.txtName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtName).Name = "txtName";
    ((Control) this.txtName).Size = new Size(471, 19);
    ((Control) this.txtName).TabIndex = 0;
    ((UltraControlBase) this.txtName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(59, 28);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(97, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Transaction Name:";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(21, 97);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(135, 13);
    this.Label7.TabIndex = 3;
    this.Label7.Text = "Downpayment Billing Type:";
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.rbDownPaymentFromEffEndMonth);
    this.Panel1.Controls.Add((Control) this.rbDownpaymentExpiration);
    this.Panel1.Controls.Add((Control) this.rbDownPaymentGAAP);
    this.Panel1.Controls.Add((Control) this.rbDownpaymentDateBilled);
    this.Panel1.Controls.Add((Control) this.rbDownpaymentEffective);
    this.Panel1.Location = new Point(288, 59);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(523, 27);
    this.Panel1.TabIndex = 3;
    this.rbDownPaymentFromEffEndMonth.BackColor = Color.Transparent;
    this.rbDownPaymentFromEffEndMonth.Location = new Point(369, 5);
    this.rbDownPaymentFromEffEndMonth.Name = "rbDownPaymentFromEffEndMonth";
    this.rbDownPaymentFromEffEndMonth.Size = new Size(134, 20);
    this.rbDownPaymentFromEffEndMonth.TabIndex = 4;
    this.rbDownPaymentFromEffEndMonth.Text = "End Month of Eff Date";
    this.rbDownPaymentFromEffEndMonth.UseVisualStyleBackColor = false;
    this.rbDownpaymentExpiration.BackColor = Color.Transparent;
    this.rbDownpaymentExpiration.Location = new Point(264, 5);
    this.rbDownpaymentExpiration.Name = "rbDownpaymentExpiration";
    this.rbDownpaymentExpiration.Size = new Size(99, 20);
    this.rbDownpaymentExpiration.TabIndex = 3;
    this.rbDownpaymentExpiration.Text = "Expiration Date";
    this.rbDownpaymentExpiration.UseVisualStyleBackColor = false;
    this.rbDownPaymentGAAP.BackColor = Color.Transparent;
    this.rbDownPaymentGAAP.Location = new Point(198, 5);
    this.rbDownPaymentGAAP.Name = "rbDownPaymentGAAP";
    this.rbDownPaymentGAAP.Size = new Size(60, 20);
    this.rbDownPaymentGAAP.TabIndex = 2;
    this.rbDownPaymentGAAP.Text = "GAAP";
    this.rbDownPaymentGAAP.UseVisualStyleBackColor = false;
    this.rbDownpaymentDateBilled.BackColor = Color.Transparent;
    this.rbDownpaymentDateBilled.Location = new Point(112 /*0x70*/, 5);
    this.rbDownpaymentDateBilled.Name = "rbDownpaymentDateBilled";
    this.rbDownpaymentDateBilled.Size = new Size(80 /*0x50*/, 20);
    this.rbDownpaymentDateBilled.TabIndex = 1;
    this.rbDownpaymentDateBilled.Text = "Date Billed";
    this.rbDownpaymentDateBilled.UseVisualStyleBackColor = false;
    this.rbDownpaymentEffective.BackColor = Color.Transparent;
    this.rbDownpaymentEffective.Location = new Point(8, 5);
    this.rbDownpaymentEffective.Name = "rbDownpaymentEffective";
    this.rbDownpaymentEffective.Size = new Size(98, 20);
    this.rbDownpaymentEffective.TabIndex = 0;
    this.rbDownpaymentEffective.Text = "Effective Date";
    this.rbDownpaymentEffective.UseVisualStyleBackColor = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.cn.ConnectionString = "Data Source=mgasystems2012.ny.mgasystems.com;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineInstallmentsTransDate", new DataColumnMapping[42]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("OptionName", "OptionName"),
        new DataColumnMapping("DownpaymentTerm", "DownpaymentTerm"),
        new DataColumnMapping("NumPayments", "NumPayments"),
        new DataColumnMapping("InstallmentTerms", "InstallmentTerms"),
        new DataColumnMapping("DownpaymentBillingTypeID", "DownpaymentBillingTypeID"),
        new DataColumnMapping("InstallmentFromEffectiveDate", "InstallmentFromEffectiveDate"),
        new DataColumnMapping("InstallmentFromDateBilled", "InstallmentFromDateBilled"),
        new DataColumnMapping("Financed", "Financed"),
        new DataColumnMapping("DownpaymentFromEffectiveDate", "DownpaymentFromEffectiveDate"),
        new DataColumnMapping("DownpaymentFromDateBilled", "DownpaymentFromDateBilled"),
        new DataColumnMapping("DisallowAutomatedPrinting", "DisallowAutomatedPrinting"),
        new DataColumnMapping("DisallowAutomatedNOC", "DisallowAutomatedNOC"),
        new DataColumnMapping("Disabled", "Disabled"),
        new DataColumnMapping("DateBilledEqualToDueDate", "DateBilledEqualToDueDate"),
        new DataColumnMapping("EffectiveDateBilled", "EffectiveDateBilled"),
        new DataColumnMapping("PolicyEffective", "PolicyEffective"),
        new DataColumnMapping("DayOfMonth", "DayOfMonth"),
        new DataColumnMapping("DayOfMonthNumber", "DayOfMonthNumber"),
        new DataColumnMapping("PolicyEffectiveInstallmentTerm", "PolicyEffectiveInstallmentTerm"),
        new DataColumnMapping("DayOfMonthInstallmentTerm", "DayOfMonthInstallmentTerm"),
        new DataColumnMapping("MonthFollowingDownPayment", "MonthFollowingDownPayment"),
        new DataColumnMapping("MonthFollowingDownPayment_Eff", "MonthFollowingDownPayment_Eff"),
        new DataColumnMapping("MonthFollowingDownPayment_Eff_DateBilled", "MonthFollowingDownPayment_Eff_DateBilled"),
        new DataColumnMapping("EffectiveAltFirstInstallDays", "EffectiveAltFirstInstallDays"),
        new DataColumnMapping("EffDateBilledAltFirstInstallDays", "EffDateBilledAltFirstInstallDays"),
        new DataColumnMapping("UseMonth", "UseMonth"),
        new DataColumnMapping("DayOfMonthAltFirstInstallDays", "DayOfMonthAltFirstInstallDays"),
        new DataColumnMapping("SinglePay", "SinglePay"),
        new DataColumnMapping("BillingDateDaysFromDueDate", "BillingDateDaysFromDueDate"),
        new DataColumnMapping("UseEffectiveDateForBilling", "UseEffectiveDateForBilling"),
        new DataColumnMapping("DownPaymentGAAP", "DownPaymentGAAP"),
        new DataColumnMapping("UseMonthForAltFirstInstallment", "UseMonthForAltFirstInstallment"),
        new DataColumnMapping("DownPaymentUsingBusinessDays", "DownPaymentUsingBusinessDays"),
        new DataColumnMapping("PolicyExpiration", "PolicyExpiration"),
        new DataColumnMapping("ExpirationAltFirstInstallDays", "ExpirationAltFirstInstallDays"),
        new DataColumnMapping("MonthFollowingDownPayment_Exp", "MonthFollowingDownPayment_Exp"),
        new DataColumnMapping("PolicyExpirationInstallmentTerm", "PolicyExpirationInstallmentTerm"),
        new DataColumnMapping("DownpaymentFromExpirationDate", "DownpaymentFromExpirationDate"),
        new DataColumnMapping("DownPaymentFromEffEndMonth", "DownPaymentFromEffEndMonth"),
        new DataColumnMapping("InstallmentID", "InstallmentID"),
        new DataColumnMapping("DownPaymentDayofMonth", "DownPaymentDayofMonth")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblCompanyLineInstallmentsTransDate] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[41]
    {
      new SqlParameter("@OptionName", SqlDbType.VarChar, 0, "OptionName"),
      new SqlParameter("@DownpaymentTerm", SqlDbType.SmallInt, 0, "DownpaymentTerm"),
      new SqlParameter("@NumPayments", SqlDbType.TinyInt, 0, "NumPayments"),
      new SqlParameter("@InstallmentTerms", SqlDbType.SmallInt, 0, "InstallmentTerms"),
      new SqlParameter("@DownpaymentBillingTypeID", SqlDbType.TinyInt, 0, "DownpaymentBillingTypeID"),
      new SqlParameter("@InstallmentFromEffectiveDate", SqlDbType.Bit, 0, "InstallmentFromEffectiveDate"),
      new SqlParameter("@InstallmentFromDateBilled", SqlDbType.Bit, 0, "InstallmentFromDateBilled"),
      new SqlParameter("@Financed", SqlDbType.Bit, 0, "Financed"),
      new SqlParameter("@DownpaymentFromEffectiveDate", SqlDbType.Bit, 0, "DownpaymentFromEffectiveDate"),
      new SqlParameter("@DownpaymentFromDateBilled", SqlDbType.Bit, 0, "DownpaymentFromDateBilled"),
      new SqlParameter("@DisallowAutomatedPrinting", SqlDbType.Bit, 0, "DisallowAutomatedPrinting"),
      new SqlParameter("@DisallowAutomatedNOC", SqlDbType.Bit, 0, "DisallowAutomatedNOC"),
      new SqlParameter("@Disabled", SqlDbType.Bit, 0, "Disabled"),
      new SqlParameter("@DateBilledEqualToDueDate", SqlDbType.Bit, 0, "DateBilledEqualToDueDate"),
      new SqlParameter("@EffectiveDateBilled", SqlDbType.Bit, 0, "EffectiveDateBilled"),
      new SqlParameter("@PolicyEffective", SqlDbType.Bit, 0, "PolicyEffective"),
      new SqlParameter("@DayOfMonth", SqlDbType.Bit, 0, "DayOfMonth"),
      new SqlParameter("@DayOfMonthNumber", SqlDbType.TinyInt, 0, "DayOfMonthNumber"),
      new SqlParameter("@PolicyEffectiveInstallmentTerm", SqlDbType.SmallInt, 0, "PolicyEffectiveInstallmentTerm"),
      new SqlParameter("@DayOfMonthInstallmentTerm", SqlDbType.SmallInt, 0, "DayOfMonthInstallmentTerm"),
      new SqlParameter("@MonthFollowingDownPayment", SqlDbType.Bit, 0, "MonthFollowingDownPayment"),
      new SqlParameter("@MonthFollowingDownPayment_Eff", SqlDbType.Bit, 0, "MonthFollowingDownPayment_Eff"),
      new SqlParameter("@MonthFollowingDownPayment_Eff_DateBilled", SqlDbType.Bit, 0, "MonthFollowingDownPayment_Eff_DateBilled"),
      new SqlParameter("@EffectiveAltFirstInstallDays", SqlDbType.SmallInt, 0, "EffectiveAltFirstInstallDays"),
      new SqlParameter("@EffDateBilledAltFirstInstallDays", SqlDbType.SmallInt, 0, "EffDateBilledAltFirstInstallDays"),
      new SqlParameter("@UseMonth", SqlDbType.Bit, 0, "UseMonth"),
      new SqlParameter("@DayOfMonthAltFirstInstallDays", SqlDbType.SmallInt, 0, "DayOfMonthAltFirstInstallDays"),
      new SqlParameter("@SinglePay", SqlDbType.Bit, 0, "SinglePay"),
      new SqlParameter("@BillingDateDaysFromDueDate", SqlDbType.SmallInt, 0, "BillingDateDaysFromDueDate"),
      new SqlParameter("@UseEffectiveDateForBilling", SqlDbType.Bit, 0, "UseEffectiveDateForBilling"),
      new SqlParameter("@DownPaymentGAAP", SqlDbType.Bit, 0, "DownPaymentGAAP"),
      new SqlParameter("@UseMonthForAltFirstInstallment", SqlDbType.Bit, 0, "UseMonthForAltFirstInstallment"),
      new SqlParameter("@DownPaymentUsingBusinessDays", SqlDbType.Bit, 0, "DownPaymentUsingBusinessDays"),
      new SqlParameter("@PolicyExpiration", SqlDbType.Bit, 0, "PolicyExpiration"),
      new SqlParameter("@ExpirationAltFirstInstallDays", SqlDbType.SmallInt, 0, "ExpirationAltFirstInstallDays"),
      new SqlParameter("@MonthFollowingDownPayment_Exp", SqlDbType.Bit, 0, "MonthFollowingDownPayment_Exp"),
      new SqlParameter("@PolicyExpirationInstallmentTerm", SqlDbType.SmallInt, 0, "PolicyExpirationInstallmentTerm"),
      new SqlParameter("@DownpaymentFromExpirationDate", SqlDbType.Bit, 0, "DownpaymentFromExpirationDate"),
      new SqlParameter("@DownPaymentFromEffEndMonth", SqlDbType.Bit, 0, "DownPaymentFromEffEndMonth"),
      new SqlParameter("@InstallmentID", SqlDbType.Int, 0, "InstallmentID"),
      new SqlParameter("@DownPaymentDayofMonth", SqlDbType.Int, 0, "DownPaymentDayofMonth")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@InstallmentID", SqlDbType.Int, 4, "InstallmentID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[43]
    {
      new SqlParameter("@OptionName", SqlDbType.VarChar, 0, "OptionName"),
      new SqlParameter("@DownpaymentTerm", SqlDbType.SmallInt, 0, "DownpaymentTerm"),
      new SqlParameter("@NumPayments", SqlDbType.TinyInt, 0, "NumPayments"),
      new SqlParameter("@InstallmentTerms", SqlDbType.SmallInt, 0, "InstallmentTerms"),
      new SqlParameter("@DownpaymentBillingTypeID", SqlDbType.TinyInt, 0, "DownpaymentBillingTypeID"),
      new SqlParameter("@InstallmentFromEffectiveDate", SqlDbType.Bit, 0, "InstallmentFromEffectiveDate"),
      new SqlParameter("@InstallmentFromDateBilled", SqlDbType.Bit, 0, "InstallmentFromDateBilled"),
      new SqlParameter("@Financed", SqlDbType.Bit, 0, "Financed"),
      new SqlParameter("@DownpaymentFromEffectiveDate", SqlDbType.Bit, 0, "DownpaymentFromEffectiveDate"),
      new SqlParameter("@DownpaymentFromDateBilled", SqlDbType.Bit, 0, "DownpaymentFromDateBilled"),
      new SqlParameter("@DisallowAutomatedPrinting", SqlDbType.Bit, 0, "DisallowAutomatedPrinting"),
      new SqlParameter("@DisallowAutomatedNOC", SqlDbType.Bit, 0, "DisallowAutomatedNOC"),
      new SqlParameter("@Disabled", SqlDbType.Bit, 0, "Disabled"),
      new SqlParameter("@DateBilledEqualToDueDate", SqlDbType.Bit, 0, "DateBilledEqualToDueDate"),
      new SqlParameter("@EffectiveDateBilled", SqlDbType.Bit, 0, "EffectiveDateBilled"),
      new SqlParameter("@PolicyEffective", SqlDbType.Bit, 0, "PolicyEffective"),
      new SqlParameter("@DayOfMonth", SqlDbType.Bit, 0, "DayOfMonth"),
      new SqlParameter("@DayOfMonthNumber", SqlDbType.TinyInt, 0, "DayOfMonthNumber"),
      new SqlParameter("@PolicyEffectiveInstallmentTerm", SqlDbType.SmallInt, 0, "PolicyEffectiveInstallmentTerm"),
      new SqlParameter("@DayOfMonthInstallmentTerm", SqlDbType.SmallInt, 0, "DayOfMonthInstallmentTerm"),
      new SqlParameter("@MonthFollowingDownPayment", SqlDbType.Bit, 0, "MonthFollowingDownPayment"),
      new SqlParameter("@MonthFollowingDownPayment_Eff", SqlDbType.Bit, 0, "MonthFollowingDownPayment_Eff"),
      new SqlParameter("@MonthFollowingDownPayment_Eff_DateBilled", SqlDbType.Bit, 0, "MonthFollowingDownPayment_Eff_DateBilled"),
      new SqlParameter("@EffectiveAltFirstInstallDays", SqlDbType.SmallInt, 0, "EffectiveAltFirstInstallDays"),
      new SqlParameter("@EffDateBilledAltFirstInstallDays", SqlDbType.SmallInt, 0, "EffDateBilledAltFirstInstallDays"),
      new SqlParameter("@UseMonth", SqlDbType.Bit, 0, "UseMonth"),
      new SqlParameter("@DayOfMonthAltFirstInstallDays", SqlDbType.SmallInt, 0, "DayOfMonthAltFirstInstallDays"),
      new SqlParameter("@SinglePay", SqlDbType.Bit, 0, "SinglePay"),
      new SqlParameter("@BillingDateDaysFromDueDate", SqlDbType.SmallInt, 0, "BillingDateDaysFromDueDate"),
      new SqlParameter("@UseEffectiveDateForBilling", SqlDbType.Bit, 0, "UseEffectiveDateForBilling"),
      new SqlParameter("@DownPaymentGAAP", SqlDbType.Bit, 0, "DownPaymentGAAP"),
      new SqlParameter("@UseMonthForAltFirstInstallment", SqlDbType.Bit, 0, "UseMonthForAltFirstInstallment"),
      new SqlParameter("@DownPaymentUsingBusinessDays", SqlDbType.Bit, 0, "DownPaymentUsingBusinessDays"),
      new SqlParameter("@PolicyExpiration", SqlDbType.Bit, 0, "PolicyExpiration"),
      new SqlParameter("@ExpirationAltFirstInstallDays", SqlDbType.SmallInt, 0, "ExpirationAltFirstInstallDays"),
      new SqlParameter("@MonthFollowingDownPayment_Exp", SqlDbType.Bit, 0, "MonthFollowingDownPayment_Exp"),
      new SqlParameter("@PolicyExpirationInstallmentTerm", SqlDbType.SmallInt, 0, "PolicyExpirationInstallmentTerm"),
      new SqlParameter("@DownpaymentFromExpirationDate", SqlDbType.Bit, 0, "DownpaymentFromExpirationDate"),
      new SqlParameter("@DownPaymentFromEffEndMonth", SqlDbType.Bit, 0, "DownPaymentFromEffEndMonth"),
      new SqlParameter("@InstallmentID", SqlDbType.Int, 0, "InstallmentID"),
      new SqlParameter("@DownPaymentDayofMonth", SqlDbType.Int, 0, "DownPaymentDayofMonth"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(829, 388);
    this.Controls.Add((Control) this.GroupBox1);
    this.Name = nameof (FormTransDateInstallment);
    this.Text = "Transaction Date Installment";
    ((ISupportInitialize) this.GroupBox1).EndInit();
    ((Control) this.GroupBox1).ResumeLayout(false);
    ((Control) this.GroupBox1).PerformLayout();
    ((ISupportInitialize) this.numDownPaymentDayofMonth).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnDelete).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.chkUseEffectiveDateForBilling).EndInit();
    ((ISupportInitialize) this.numBillingDateDaysFromDueDate).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.numExpirationAltFirstInstallDays).EndInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Exp).EndInit();
    ((ISupportInitialize) this.NumPolicyExpirationInstallmentTerm).EndInit();
    ((ISupportInitialize) this.chkUseMonthForAltFirstInstallment).EndInit();
    ((ISupportInitialize) this.numDayOfMonthAltFirstInstallDays).EndInit();
    ((ISupportInitialize) this.chkUseMonth).EndInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Eff_DateBilled).EndInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Eff).EndInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_DayOfMonth).EndInit();
    ((ISupportInitialize) this.numEffectiveAltFirstInstallDays).EndInit();
    ((ISupportInitialize) this.txtInstallmentTerms).EndInit();
    ((ISupportInitialize) this.numDayOfMonthInstallmentTerm).EndInit();
    ((ISupportInitialize) this.numEffDateBilledAltFirstInstallDays).EndInit();
    ((ISupportInitialize) this.NumPolicyEffectiveInstallmentTerm).EndInit();
    ((ISupportInitialize) this.numDayofMonth).EndInit();
    this.grpInstallment.ResumeLayout(false);
    ((ISupportInitialize) this.chkDateBilled).EndInit();
    ((ISupportInitialize) this.numDownPaymentTerm).EndInit();
    ((ISupportInitialize) this.cboDownpaymentBillingType).EndInit();
    ((ISupportInitialize) this.txtName).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("GroupBox1")]
  protected virtual MGAGroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  private virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkUseEffectiveDateForBilling")]
  protected virtual MGACheckBox chkUseEffectiveDateForBilling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel11")]
  protected virtual CurrencyLabel CurrencyLabel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numBillingDateDaysFromDueDate")]
  protected virtual MGANumericEditor numBillingDateDaysFromDueDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numExpirationAltFirstInstallDays")]
  private virtual MGANumericEditor numExpirationAltFirstInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel13")]
  private virtual CurrencyLabel CurrencyLabel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFollowingDownPayment_Exp")]
  private virtual MGACheckBox chkFollowingDownPayment_Exp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel12")]
  private virtual CurrencyLabel CurrencyLabel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("NumPolicyExpirationInstallmentTerm")]
  private virtual MGANumericEditor NumPolicyExpirationInstallmentTerm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkUseMonthForAltFirstInstallment")]
  private virtual MGACheckBox chkUseMonthForAltFirstInstallment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDayOfMonthAltFirstInstallDays")]
  private virtual MGANumericEditor numDayOfMonthAltFirstInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel10")]
  private virtual CurrencyLabel CurrencyLabel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkUseMonth")]
  private virtual MGACheckBox chkUseMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFollowingDownPayment_Eff_DateBilled")]
  private virtual MGACheckBox chkFollowingDownPayment_Eff_DateBilled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFollowingDownPayment_Eff")]
  private virtual MGACheckBox chkFollowingDownPayment_Eff { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel9")]
  private virtual CurrencyLabel CurrencyLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFollowingDownPayment_DayOfMonth")]
  private virtual MGACheckBox chkFollowingDownPayment_DayOfMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel7")]
  private virtual CurrencyLabel CurrencyLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel8")]
  private virtual CurrencyLabel CurrencyLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numEffectiveAltFirstInstallDays")]
  private virtual MGANumericEditor numEffectiveAltFirstInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInstallmentTerms")]
  private virtual MGANumericEditor txtInstallmentTerms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDayOfMonthInstallmentTerm")]
  private virtual MGANumericEditor numDayOfMonthInstallmentTerm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numEffDateBilledAltFirstInstallDays")]
  private virtual MGANumericEditor numEffDateBilledAltFirstInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbInstallmentEffective")]
  private virtual RadioButton rbInstallmentEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel6")]
  private virtual CurrencyLabel CurrencyLabel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbInstallmentDateBilled")]
  private virtual RadioButton rbInstallmentDateBilled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("NumPolicyEffectiveInstallmentTerm")]
  private virtual MGANumericEditor NumPolicyEffectiveInstallmentTerm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel4")]
  private virtual CurrencyLabel CurrencyLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDayofMonth")]
  private virtual MGANumericEditor numDayofMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel5")]
  private virtual CurrencyLabel CurrencyLabel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpInstallment")]
  internal virtual GroupBox grpInstallment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rbPolicyExpiration
  {
    get => this._rbPolicyExpiration;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PolicyTerms_CheckedChanged);
      RadioButton policyExpiration1 = this._rbPolicyExpiration;
      if (policyExpiration1 != null)
        policyExpiration1.CheckedChanged -= eventHandler;
      this._rbPolicyExpiration = value;
      RadioButton policyExpiration2 = this._rbPolicyExpiration;
      if (policyExpiration2 == null)
        return;
      policyExpiration2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbEffectiveDateBilled
  {
    get => this._rbEffectiveDateBilled;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PolicyTerms_CheckedChanged);
      RadioButton effectiveDateBilled1 = this._rbEffectiveDateBilled;
      if (effectiveDateBilled1 != null)
        effectiveDateBilled1.CheckedChanged -= eventHandler;
      this._rbEffectiveDateBilled = value;
      RadioButton effectiveDateBilled2 = this._rbEffectiveDateBilled;
      if (effectiveDateBilled2 == null)
        return;
      effectiveDateBilled2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbDayOfMonth
  {
    get => this._rbDayOfMonth;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PolicyTerms_CheckedChanged);
      RadioButton rbDayOfMonth1 = this._rbDayOfMonth;
      if (rbDayOfMonth1 != null)
        rbDayOfMonth1.CheckedChanged -= eventHandler;
      this._rbDayOfMonth = value;
      RadioButton rbDayOfMonth2 = this._rbDayOfMonth;
      if (rbDayOfMonth2 == null)
        return;
      rbDayOfMonth2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbPolicyEffective
  {
    get => this._rbPolicyEffective;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PolicyTerms_CheckedChanged);
      RadioButton rbPolicyEffective1 = this._rbPolicyEffective;
      if (rbPolicyEffective1 != null)
        rbPolicyEffective1.CheckedChanged -= eventHandler;
      this._rbPolicyEffective = value;
      RadioButton rbPolicyEffective2 = this._rbPolicyEffective;
      if (rbPolicyEffective2 == null)
        return;
      rbPolicyEffective2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkDateBilled")]
  private virtual MGACheckBox chkDateBilled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDownPaymentTerm")]
  private virtual MGANumericEditor numDownPaymentTerm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDownpaymentBillingType")]
  private virtual MGASimpleComboBox cboDownpaymentBillingType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel3")]
  private virtual CurrencyLabel CurrencyLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtName")]
  private virtual MGATextBox txtName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  private virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDownPaymentFromEffEndMonth")]
  private virtual RadioButton rbDownPaymentFromEffEndMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDownpaymentExpiration")]
  private virtual RadioButton rbDownpaymentExpiration { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDownPaymentGAAP")]
  private virtual RadioButton rbDownPaymentGAAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDownpaymentDateBilled")]
  private virtual RadioButton rbDownpaymentDateBilled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDownpaymentEffective")]
  private virtual RadioButton rbDownpaymentEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnDelete
  {
    get => this._btnDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnDelete_Click);
      MGAButton btnDelete1 = this._btnDelete;
      if (btnDelete1 != null)
        ((Control) btnDelete1).Click -= eventHandler;
      this._btnDelete = value;
      MGAButton btnDelete2 = this._btnDelete;
      if (btnDelete2 == null)
        return;
      ((Control) btnDelete2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsTransDateInstallment ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  private virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  private virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  private virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  private virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  private virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cLabelOn")]
  private virtual CurrencyLabel cLabelOn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDownPaymentDayofMonth")]
  private virtual MGANumericEditor numDownPaymentDayofMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cLabelDayOfMonth")]
  private virtual CurrencyLabel cLabelDayOfMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRecordCount")]
  private virtual Label lblRecordCount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public FormTransDateInstallment()
  {
    this.Load += new EventHandler(this.FormTransDateInstallment_Load);
    this.InitializeComponent();
  }

  public FormTransDateInstallment(
    int InstallmentID,
    dsCompanyInstallments.tblCompanyBillingTypesDataTable dtBillingType)
  {
    this.Load += new EventHandler(this.FormTransDateInstallment_Load);
    this.InitializeComponent();
    this._InstallmentID = InstallmentID;
    this._dtBillingType = dtBillingType;
  }

  private bool ValidForm
  {
    get
    {
      bool validForm = true;
      this.err.SetError((Control) this.txtName, string.Empty);
      this.err.SetError((Control) this.cboDownpaymentBillingType, string.Empty);
      this.err.SetError((Control) this.numDownPaymentTerm, string.Empty);
      this.err.SetError((Control) this.numDayofMonth, string.Empty);
      this.err.SetError((Control) this.numDayOfMonthInstallmentTerm, string.Empty);
      this.err.SetError((Control) this.NumPolicyEffectiveInstallmentTerm, string.Empty);
      this.err.SetError((Control) this.chkUseEffectiveDateForBilling, string.Empty);
      this.err.SetError((Control) this.numBillingDateDaysFromDueDate, string.Empty);
      if (!((UltraToggleEditorBase) this.chkDateBilled).Checked && ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).Checked)
      {
        this.err.SetError((Control) this.chkUseEffectiveDateForBilling, "Required if Billed Date equals to Due Date is checked.");
        validForm = false;
      }
      if (!((UltraToggleEditorBase) this.chkDateBilled).Checked && this.numBillingDateDaysFromDueDate.Value != null && this.numBillingDateDaysFromDueDate.Value != DBNull.Value)
      {
        this.err.SetError((Control) this.numBillingDateDaysFromDueDate, "Required if Billed Date equals to Due Date is checked.");
        validForm = false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtName).Text, string.Empty, false) == 0)
      {
        this.err.SetError((Control) this.txtName, "Please enter a name for this option.");
        validForm = false;
      }
      if (!this.rbDayOfMonth.Checked && !this.rbEffectiveDateBilled.Checked && !this.rbPolicyEffective.Checked && !this.rbPolicyExpiration.Checked)
      {
        validForm = false;
        int num = (int) MessageBox.Show("At least one installment term must be chosen.", "No Installment Term Chosen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      if (this.numDownPaymentTerm.Value == null || this.numDownPaymentTerm.Value == DBNull.Value)
      {
        validForm = false;
        this.err.SetError((Control) this.numDownPaymentTerm, "Please enter a value.");
      }
      if (this.rbEffectiveDateBilled.Checked && this.txtInstallmentTerms.Value == DBNull.Value | this.txtInstallmentTerms.Value == null)
      {
        validForm = false;
        this.err.SetError((Control) this.txtInstallmentTerms, "Please enter a value.");
      }
      if (this.rbDayOfMonth.Checked)
      {
        if (this.numDayofMonth.Value == DBNull.Value || this.numDayofMonth.Value == null)
        {
          validForm = false;
          this.err.SetError((Control) this.numDayofMonth, "'Day of Month' is checked.  Please enter a value.");
        }
        if (this.numDayOfMonthInstallmentTerm.Value == DBNull.Value || this.numDayOfMonthInstallmentTerm.Value == null)
        {
          validForm = false;
          this.err.SetError((Control) this.numDayOfMonthInstallmentTerm, "'Day of Month' is checked.  Please enter a value.");
        }
      }
      if (this.rbPolicyEffective.Checked && (this.NumPolicyEffectiveInstallmentTerm.Value == DBNull.Value || this.NumPolicyEffectiveInstallmentTerm.Value == null))
      {
        validForm = false;
        this.err.SetError((Control) this.NumPolicyEffectiveInstallmentTerm, "'Policy Effective' is checked.  Please enter a value.");
      }
      if (this.rbPolicyExpiration.Checked && (this.NumPolicyExpirationInstallmentTerm.Value == DBNull.Value || this.NumPolicyExpirationInstallmentTerm.Value == null))
      {
        validForm = false;
        this.err.SetError((Control) this.NumPolicyExpirationInstallmentTerm, "'Policy Expiration' is checked.  Please enter a value.");
      }
      return validForm;
    }
  }

  protected BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.ds, this.ds.tblCompanyLineInstallmentsTransDate.TableName];
    }
  }

  private void FormTransDateInstallment_Load(object sender, EventArgs e)
  {
    ((Control) this.GroupBox1).Enabled = true;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnDelete).Appearance.Image = (object) ImageCache.Instance.Delete;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    try
    {
      foreach (dsCompanyInstallments.tblCompanyBillingTypesRow row in this._dtBillingType.Rows)
        this.ds.tblCompanyBillingTypes.AddtblCompanyBillingTypesRow(row.BillingTypeID, row.BillingType);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      this.da.SelectCommand.Parameters["@InstallmentID"].Value = (object) this._InstallmentID;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineInstallmentsTransDate);
      if (this.ds.tblCompanyLineInstallmentsTransDate.Count > 0)
        this.lblRecordCount.Text = $"1 of {this.ds.tblCompanyLineInstallmentsTransDate.Count:D1} records";
      this.OnFill();
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.SetRadioButtons();
  }

  private void OnFill()
  {
    if (this.ds.tblCompanyLineInstallmentsTransDate.Count > 0)
      return;
    dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow row = this.ds.tblCompanyLineInstallmentsTransDate.NewtblCompanyLineInstallmentsTransDateRow();
    if (this.ds.tblCompanyBillingTypes.Count == 2)
    {
      row.DownpaymentBillingTypeID = this.ds.tblCompanyBillingTypes[1].BillingTypeID;
      this.cboDownpaymentBillingType.Value = (object) row.DownpaymentBillingTypeID;
    }
    else
      row.SetDownpaymentBillingTypeIDNull();
    row.InstallmentID = this._InstallmentID;
    row.OptionName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select OptionName from tblCompanyLineInstallments with (nolock) where ID = @ID", new object[2]
    {
      (object) "@ID",
      (object) this._InstallmentID
    });
    this.txtInstallmentTerms.Value = (object) 30;
    this.rbEffectiveDateBilled.Checked = true;
    this.rbInstallmentEffective.Checked = true;
    row.NumPayments = 1;
    ((UltraToggleEditorBase) this.chkDateBilled).Checked = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
    this.ds.tblCompanyLineInstallmentsTransDate.AddtblCompanyLineInstallmentsTransDateRow(row);
    this.bmb.Position = this.ds.tblCompanyLineInstallmentsTransDate.Rows.Count - 1;
  }

  private void BtnDelete_Click(object sender, EventArgs e)
  {
    if (this.ds.tblCompanyLineInstallmentsTransDate[0].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Current can not be deleted because it is not yet saved.", "Can not Delete New Row", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this transaction date setup?", "Delete Transaction Date Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.ds.tblCompanyLineInstallmentsTransDate[0].Delete();
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineInstallmentsTransDate);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      this.Close();
    }
  }

  private void BtnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidForm)
      return;
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      this.bmb.EndCurrentEdit();
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow installmentsTransDateRow = this.ds.tblCompanyLineInstallmentsTransDate[this.bmb.Position];
      installmentsTransDateRow.InstallmentFromEffectiveDate = this.rbInstallmentEffective.Checked;
      installmentsTransDateRow.InstallmentFromDateBilled = this.rbInstallmentDateBilled.Checked;
      installmentsTransDateRow.DownpaymentFromEffectiveDate = this.rbDownpaymentEffective.Checked;
      installmentsTransDateRow.DownpaymentFromDateBilled = this.rbDownpaymentDateBilled.Checked;
      installmentsTransDateRow.DownPaymentGAAP = this.rbDownPaymentGAAP.Checked;
      installmentsTransDateRow.DownPaymentFromEffEndMonth = this.rbDownPaymentFromEffEndMonth.Checked;
      installmentsTransDateRow.EffectiveDateBilled = this.rbEffectiveDateBilled.Checked;
      installmentsTransDateRow.PolicyEffective = this.rbPolicyEffective.Checked;
      installmentsTransDateRow.PolicyExpiration = this.rbPolicyExpiration.Checked;
      installmentsTransDateRow.DayOfMonth = this.rbDayOfMonth.Checked;
      if (this.txtInstallmentTerms.Value != null && this.txtInstallmentTerms.Value != DBNull.Value)
        installmentsTransDateRow.InstallmentTerms = Conversions.ToInteger(this.txtInstallmentTerms.Value);
      else
        installmentsTransDateRow.SetInstallmentTermsNull();
      if (this.numDayofMonth.Value != null && this.numDayofMonth.Value != DBNull.Value)
        installmentsTransDateRow.DayOfMonthNumber = (byte) Conversions.ToInteger(this.numDayofMonth.Value);
      else
        installmentsTransDateRow.SetDayOfMonthNumberNull();
      if (this.numDayOfMonthInstallmentTerm.Value != null && this.numDayOfMonthInstallmentTerm.Value != DBNull.Value)
        installmentsTransDateRow.DayOfMonthInstallmentTerm = Conversions.ToInteger(this.numDayOfMonthInstallmentTerm.Value);
      else
        installmentsTransDateRow.SetDayOfMonthInstallmentTermNull();
      if (this.NumPolicyEffectiveInstallmentTerm.Value != null && this.NumPolicyEffectiveInstallmentTerm.Value != DBNull.Value)
        installmentsTransDateRow.PolicyEffectiveInstallmentTerm = Conversions.ToInteger(this.NumPolicyEffectiveInstallmentTerm.Value);
      else
        installmentsTransDateRow.SetPolicyEffectiveInstallmentTermNull();
      if (this.NumPolicyExpirationInstallmentTerm.Value != null && this.NumPolicyExpirationInstallmentTerm.Value != DBNull.Value)
        installmentsTransDateRow.PolicyExpirationInstallmentTerm = Conversions.ToInteger(this.NumPolicyExpirationInstallmentTerm.Value);
      else
        installmentsTransDateRow.SetPolicyExpirationInstallmentTermNull();
      installmentsTransDateRow.MonthFollowingDownPayment = ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked;
      installmentsTransDateRow.MonthFollowingDownPayment_Eff = ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked;
      installmentsTransDateRow.MonthFollowingDownPayment_Eff_DateBilled = ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked;
      installmentsTransDateRow.UseMonth = ((UltraToggleEditorBase) this.chkUseMonth).Checked;
      installmentsTransDateRow.UseMonthForAltFirstInstallment = ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).Checked;
      installmentsTransDateRow.MonthFollowingDownPayment_Exp = ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked;
      installmentsTransDateRow.DownpaymentFromExpirationDate = this.rbDownpaymentExpiration.Checked;
      installmentsTransDateRow.DateBilledEqualToDueDate = ((UltraToggleEditorBase) this.chkDateBilled).Checked;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineInstallmentsTransDate);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
    this.Close();
  }

  private void SetRadioButtons()
  {
    if (this.bmb.Position < 0)
      return;
    dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow installmentsTransDateRow = this.ds.tblCompanyLineInstallmentsTransDate[this.bmb.Position];
    this.rbDownpaymentDateBilled.Checked = installmentsTransDateRow.DownpaymentFromDateBilled;
    this.rbDownpaymentEffective.Checked = installmentsTransDateRow.DownpaymentFromEffectiveDate;
    this.rbInstallmentDateBilled.Checked = installmentsTransDateRow.InstallmentFromDateBilled;
    this.rbInstallmentEffective.Checked = installmentsTransDateRow.InstallmentFromEffectiveDate;
    this.rbDownPaymentGAAP.Checked = installmentsTransDateRow.DownPaymentGAAP;
    this.rbDownPaymentFromEffEndMonth.Checked = installmentsTransDateRow.DownPaymentFromEffEndMonth;
    this.rbEffectiveDateBilled.Checked = installmentsTransDateRow.EffectiveDateBilled;
    this.rbPolicyEffective.Checked = installmentsTransDateRow.PolicyEffective;
    this.rbPolicyExpiration.Checked = installmentsTransDateRow.PolicyExpiration;
    this.rbDayOfMonth.Checked = installmentsTransDateRow.DayOfMonth;
    if (!installmentsTransDateRow.IsInstallmentTermsNull())
      this.txtInstallmentTerms.Value = (object) installmentsTransDateRow.InstallmentTerms;
    if (!installmentsTransDateRow.IsDayOfMonthNumberNull())
      this.numDayofMonth.Value = (object) installmentsTransDateRow.DayOfMonthNumber;
    if (!installmentsTransDateRow.IsPolicyEffectiveInstallmentTermNull())
      this.NumPolicyEffectiveInstallmentTerm.Value = (object) installmentsTransDateRow.PolicyEffectiveInstallmentTerm;
    if (!installmentsTransDateRow.IsDayOfMonthInstallmentTermNull())
      this.numDayOfMonthInstallmentTerm.Value = (object) installmentsTransDateRow.DayOfMonthInstallmentTerm;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = false;
    if (!installmentsTransDateRow.IsMonthFollowingDownPaymentNull())
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = installmentsTransDateRow.MonthFollowingDownPayment;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
    if (!installmentsTransDateRow.IsMonthFollowingDownPayment_EffNull())
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = installmentsTransDateRow.MonthFollowingDownPayment_Eff;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
    if (!installmentsTransDateRow.IsMonthFollowingDownPayment_Eff_DateBilledNull())
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = installmentsTransDateRow.MonthFollowingDownPayment_Eff_DateBilled;
    if (!installmentsTransDateRow.IsPolicyExpirationInstallmentTermNull())
      this.NumPolicyExpirationInstallmentTerm.Value = (object) installmentsTransDateRow.PolicyExpirationInstallmentTerm;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
    if (!installmentsTransDateRow.IsMonthFollowingDownPayment_ExpNull())
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = installmentsTransDateRow.MonthFollowingDownPayment_Exp;
    this.rbDownpaymentExpiration.Checked = installmentsTransDateRow.DownpaymentFromExpirationDate;
    if (!installmentsTransDateRow.IsEffDateBilledAltFirstInstallDaysNull())
      this.numEffDateBilledAltFirstInstallDays.Value = (object) installmentsTransDateRow.EffDateBilledAltFirstInstallDays;
    else
      this.numEffDateBilledAltFirstInstallDays.Value = (object) null;
    if (!installmentsTransDateRow.IsEffectiveAltFirstInstallDaysNull())
      this.numEffectiveAltFirstInstallDays.Value = (object) installmentsTransDateRow.EffectiveAltFirstInstallDays;
    else
      this.numEffectiveAltFirstInstallDays.Value = (object) null;
    if (!installmentsTransDateRow.IsExpirationAltFirstInstallDaysNull())
      this.numExpirationAltFirstInstallDays.Value = (object) installmentsTransDateRow.ExpirationAltFirstInstallDays;
    else
      this.numExpirationAltFirstInstallDays.Value = (object) null;
    if (!installmentsTransDateRow.IsDayOfMonthAltFirstInstallDaysNull())
      this.numDayOfMonthAltFirstInstallDays.Value = (object) installmentsTransDateRow.DayOfMonthAltFirstInstallDays;
    else
      this.numDayOfMonthAltFirstInstallDays.Value = (object) null;
  }

  private void PolicyTerms_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rbEffectiveDateBilled.Checked)
    {
      this.rbInstallmentDateBilled.Enabled = true;
      this.rbInstallmentEffective.Enabled = true;
      ((Control) this.txtInstallmentTerms).Enabled = true;
      this.numDayofMonth.Value = (object) null;
      ((Control) this.numDayofMonth).Enabled = false;
      ((Control) this.NumPolicyEffectiveInstallmentTerm).Enabled = false;
      ((Control) this.numDayOfMonthInstallmentTerm).Enabled = false;
      this.NumPolicyEffectiveInstallmentTerm.Value = (object) null;
      this.numDayOfMonthInstallmentTerm.Value = (object) null;
      ((Control) this.numDayOfMonthAltFirstInstallDays).Enabled = false;
      this.numDayOfMonthAltFirstInstallDays.Value = (object) null;
      ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = false;
      this.NumPolicyExpirationInstallmentTerm.Value = (object) null;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = false;
      ((Control) this.chkFollowingDownPayment_DayOfMonth).Enabled = false;
      ((Control) this.chkFollowingDownPayment_Eff).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
      ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = true;
      ((Control) this.numEffDateBilledAltFirstInstallDays).Enabled = true;
      ((Control) this.numEffectiveAltFirstInstallDays).Enabled = false;
      this.numEffectiveAltFirstInstallDays.Value = (object) null;
      ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = false;
      this.NumPolicyExpirationInstallmentTerm.Value = (object) null;
      ((Control) this.numExpirationAltFirstInstallDays).Enabled = false;
      this.numExpirationAltFirstInstallDays.Value = (object) null;
      ((Control) this.chkFollowingDownPayment_Exp).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
    }
    if (this.rbDayOfMonth.Checked)
    {
      this.rbInstallmentDateBilled.Enabled = false;
      this.rbInstallmentEffective.Enabled = false;
      ((Control) this.txtInstallmentTerms).Enabled = false;
      this.txtInstallmentTerms.Value = (object) null;
      this.rbInstallmentEffective.Checked = false;
      this.rbInstallmentDateBilled.Checked = false;
      ((Control) this.NumPolicyEffectiveInstallmentTerm).Enabled = false;
      this.NumPolicyEffectiveInstallmentTerm.Value = (object) null;
      ((Control) this.numDayOfMonthInstallmentTerm).Enabled = true;
      ((Control) this.numDayofMonth).Enabled = true;
      ((Control) this.chkFollowingDownPayment_DayOfMonth).Enabled = true;
      ((Control) this.numDayOfMonthAltFirstInstallDays).Enabled = true;
      ((Control) this.chkFollowingDownPayment_Eff).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
      ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
      this.numEffectiveAltFirstInstallDays.Value = (object) null;
      this.numEffDateBilledAltFirstInstallDays.Value = (object) null;
      ((Control) this.numEffectiveAltFirstInstallDays).Enabled = false;
      ((Control) this.numEffDateBilledAltFirstInstallDays).Enabled = false;
      ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = false;
      this.NumPolicyExpirationInstallmentTerm.Value = (object) null;
      ((Control) this.numExpirationAltFirstInstallDays).Enabled = false;
      this.numExpirationAltFirstInstallDays.Value = (object) null;
      ((Control) this.chkFollowingDownPayment_Exp).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
    }
    if (this.rbPolicyEffective.Checked)
    {
      this.txtInstallmentTerms.Value = (object) null;
      this.rbInstallmentDateBilled.Enabled = false;
      this.rbInstallmentEffective.Enabled = false;
      ((Control) this.txtInstallmentTerms).Enabled = false;
      this.rbInstallmentEffective.Checked = false;
      this.rbInstallmentDateBilled.Checked = false;
      this.numDayofMonth.Value = (object) null;
      ((Control) this.numDayofMonth).Enabled = false;
      ((Control) this.numDayOfMonthInstallmentTerm).Enabled = false;
      this.numDayOfMonthInstallmentTerm.Value = (object) null;
      ((Control) this.numDayOfMonthAltFirstInstallDays).Enabled = false;
      this.numDayOfMonthAltFirstInstallDays.Value = (object) null;
      ((Control) this.chkFollowingDownPayment_DayOfMonth).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = false;
      ((Control) this.NumPolicyEffectiveInstallmentTerm).Enabled = true;
      ((Control) this.chkFollowingDownPayment_Eff).Enabled = true;
      ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
      ((Control) this.numEffectiveAltFirstInstallDays).Enabled = true;
      ((Control) this.numEffDateBilledAltFirstInstallDays).Enabled = false;
      this.numEffDateBilledAltFirstInstallDays.Value = (object) null;
      ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = false;
      this.NumPolicyExpirationInstallmentTerm.Value = (object) null;
      ((Control) this.numExpirationAltFirstInstallDays).Enabled = false;
      this.numExpirationAltFirstInstallDays.Value = (object) null;
      ((Control) this.chkFollowingDownPayment_Exp).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
    }
    if (!this.rbPolicyExpiration.Checked)
      return;
    this.txtInstallmentTerms.Value = (object) null;
    this.rbInstallmentDateBilled.Enabled = false;
    this.rbInstallmentEffective.Enabled = false;
    ((Control) this.txtInstallmentTerms).Enabled = false;
    this.rbInstallmentEffective.Checked = false;
    this.rbInstallmentDateBilled.Checked = false;
    this.numDayofMonth.Value = (object) null;
    ((Control) this.numDayofMonth).Enabled = false;
    ((Control) this.numDayOfMonthInstallmentTerm).Enabled = false;
    this.numDayOfMonthInstallmentTerm.Value = (object) null;
    ((Control) this.numDayOfMonthAltFirstInstallDays).Enabled = false;
    this.numDayOfMonthAltFirstInstallDays.Value = (object) null;
    ((Control) this.chkFollowingDownPayment_DayOfMonth).Enabled = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = false;
    ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = true;
    ((Control) this.chkFollowingDownPayment_Exp).Enabled = true;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
    ((Control) this.chkFollowingDownPayment_Eff).Enabled = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
    ((Control) this.numExpirationAltFirstInstallDays).Enabled = true;
    ((Control) this.numEffDateBilledAltFirstInstallDays).Enabled = false;
    this.numEffDateBilledAltFirstInstallDays.Value = (object) null;
    ((Control) this.NumPolicyEffectiveInstallmentTerm).Enabled = false;
    this.NumPolicyEffectiveInstallmentTerm.Value = (object) null;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
    ((Control) this.numEffectiveAltFirstInstallDays).Enabled = false;
    this.numEffectiveAltFirstInstallDays.Value = (object) null;
  }
}
