// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Commissions.AddCommissionableEntity
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Commissions;

public sealed class AddCommissionableEntity : UserControl
{
  private IContainer components;
  private MGATextBox txtEntityType;
  private Label Label4;
  private MGATextBox txtEntity;
  public RadioButton rbGross;
  internal RadioButton rbNet;
  private Label Label9;
  private Label Label7;
  private ErrorProvider err;
  internal RadioButton rbNetAfter;
  private Label lblPremium;
  private Label lblAmount;
  internal MGASimpleComboBox cboChargeCodes;
  internal RadioButton rbGrossPremium;
  public MGACheckBox chkOperatingAccount;
  private Label Label1;
  internal MGANumericEditor txtAmount;
  internal MGANumericEditor txtFirmIncome;
  private Label Label2;
  private Label Label5;
  internal MGANumericEditor udIncomeStartDay;
  internal MGANumericEditor udIncomeEndDay;
  internal MGASimpleComboBox cboIncomeStartMonth;
  internal MGASimpleComboBox cboIncomeEndMonth;
  private UltraTabControl UltraTabControl1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private bool _internalOnly;
  public const int ALL_PREMIUM = -500;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  public virtual MGACheckBox chkFlat
  {
    get => this._chkFlat;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkFlat_CheckedChanged);
      MGACheckBox chkFlat1 = this._chkFlat;
      if (chkFlat1 != null)
        ((UltraToggleEditorBase) chkFlat1).CheckedChanged -= eventHandler;
      this._chkFlat = value;
      MGACheckBox chkFlat2 = this._chkFlat;
      if (chkFlat2 == null)
        return;
      ((UltraToggleEditorBase) chkFlat2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGAButton btnSelectEntity
  {
    get => this._btnSelectEntity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelectEntity_Click);
      MGAButton btnSelectEntity1 = this._btnSelectEntity;
      if (btnSelectEntity1 != null)
        ((Control) btnSelectEntity1).Click -= eventHandler;
      this._btnSelectEntity = value;
      MGAButton btnSelectEntity2 = this._btnSelectEntity;
      if (btnSelectEntity2 == null)
        return;
      ((Control) btnSelectEntity2).Click += eventHandler;
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
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddCommissionableEntity));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance11 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.chkOperatingAccount = new MGACheckBox();
    this.rbGrossPremium = new RadioButton();
    this.cboChargeCodes = new MGASimpleComboBox();
    this.lblPremium = new Label();
    this.rbNetAfter = new RadioButton();
    this.txtEntityType = new MGATextBox();
    this.Label4 = new Label();
    this.txtEntity = new MGATextBox();
    this.chkFlat = new MGACheckBox();
    this.lblAmount = new Label();
    this.rbGross = new RadioButton();
    this.rbNet = new RadioButton();
    this.Label9 = new Label();
    this.btnSelectEntity = new MGAButton();
    this.Label7 = new Label();
    this.txtAmount = new MGANumericEditor();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.txtFirmIncome = new MGANumericEditor();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.udIncomeStartDay = new MGANumericEditor();
    this.Label5 = new Label();
    this.udIncomeEndDay = new MGANumericEditor();
    this.cboIncomeStartMonth = new MGASimpleComboBox();
    this.cboIncomeEndMonth = new MGASimpleComboBox();
    this.err = new ErrorProvider(this.components);
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.chkOperatingAccount).BeginInit();
    ((ISupportInitialize) this.cboChargeCodes).BeginInit();
    ((ISupportInitialize) this.txtEntityType).BeginInit();
    ((ISupportInitialize) this.txtEntity).BeginInit();
    ((ISupportInitialize) this.chkFlat).BeginInit();
    ((ISupportInitialize) this.btnSelectEntity).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.txtFirmIncome).BeginInit();
    ((ISupportInitialize) this.udIncomeStartDay).BeginInit();
    ((ISupportInitialize) this.udIncomeEndDay).BeginInit();
    ((ISupportInitialize) this.cboIncomeStartMonth).BeginInit();
    ((ISupportInitialize) this.cboIncomeEndMonth).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkOperatingAccount);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbGrossPremium);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboChargeCodes);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblPremium);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbNetAfter);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtEntityType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtEntity);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkFlat);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblAmount);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbGross);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbNet);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnSelectEntity);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtAmount);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(369, 197);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOperatingAccount).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkOperatingAccount).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOperatingAccount).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOperatingAccount).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOperatingAccount).Location = new Point(70, 168);
    this.chkOperatingAccount.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkOperatingAccount).Name = "chkOperatingAccount";
    ((Control) this.chkOperatingAccount).Size = new Size(175, 24);
    ((Control) this.chkOperatingAccount).TabIndex = 23;
    ((UltraToggleEditorBase) this.chkOperatingAccount).Text = "Pay From Operating Account";
    ((UltraControlBase) this.chkOperatingAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOperatingAccount).UseOsThemes = (DefaultableBoolean) 2;
    this.rbGrossPremium.BackColor = Color.Transparent;
    this.rbGrossPremium.Location = new Point(70, 62);
    this.rbGrossPremium.Name = "rbGrossPremium";
    this.rbGrossPremium.Size = new Size(105, 24);
    this.rbGrossPremium.TabIndex = 22;
    this.rbGrossPremium.Text = "Gross Premium";
    this.rbGrossPremium.UseVisualStyleBackColor = false;
    ((UltraCombo) this.cboChargeCodes).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboChargeCodes).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboChargeCodes).Location = new Point(70, 118);
    this.cboChargeCodes.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboChargeCodes).Name = "cboChargeCodes";
    ((Control) this.cboChargeCodes).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboChargeCodes).TabIndex = 21;
    ((UltraControlBase) this.cboChargeCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboChargeCodes).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPremium.AutoSize = true;
    this.lblPremium.BackColor = Color.Transparent;
    this.lblPremium.Location = new Point(7, 120);
    this.lblPremium.Name = "lblPremium";
    this.lblPremium.Size = new Size(57, 13);
    this.lblPremium.TabIndex = 20;
    this.lblPremium.Text = "Prem/Fee:";
    this.lblPremium.TextAlign = ContentAlignment.MiddleRight;
    this.rbNetAfter.BackColor = Color.Transparent;
    this.rbNetAfter.Location = new Point(175, 90);
    this.rbNetAfter.Name = "rbNetAfter";
    this.rbNetAfter.Size = new Size(140, 24);
    this.rbNetAfter.TabIndex = 19;
    this.rbNetAfter.Text = "Net After Commissions";
    this.rbNetAfter.UseVisualStyleBackColor = false;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEntityType).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtEntityType).BackColor = Color.White;
    ((Control) this.txtEntityType).Location = new Point(70, 38);
    this.txtEntityType.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtEntityType).Name = "txtEntityType";
    ((EditorButtonControlBase) this.txtEntityType).ReadOnly = true;
    ((Control) this.txtEntityType).Size = new Size(252, 20);
    ((Control) this.txtEntityType).TabIndex = 17;
    ((UltraControlBase) this.txtEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEntityType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTextEditor) this.txtEntityType).WordWrap = false;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(35, 40);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(35, 13);
    this.Label4.TabIndex = 16 /*0x10*/;
    this.Label4.Text = "Type:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEntity).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtEntity).BackColor = Color.White;
    ((Control) this.txtEntity).Location = new Point(70, 14);
    this.txtEntity.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtEntity).Name = "txtEntity";
    ((EditorButtonControlBase) this.txtEntity).ReadOnly = true;
    ((Control) this.txtEntity).Size = new Size(189, 20);
    ((Control) this.txtEntity).TabIndex = 14;
    ((Control) this.txtEntity).Tag = (object) new Guid("00000000-0000-0000-0000-000000000000");
    ((UltraControlBase) this.txtEntity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEntity).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTextEditor) this.txtEntity).WordWrap = false;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFlat).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkFlat).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFlat).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFlat).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFlat).Location = new Point(175, 143);
    this.chkFlat.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkFlat).Name = "chkFlat";
    ((Control) this.chkFlat).Size = new Size(84, 21);
    ((Control) this.chkFlat).TabIndex = 13;
    ((UltraToggleEditorBase) this.chkFlat).Text = "Flat Amount";
    ((UltraControlBase) this.chkFlat).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFlat).UseOsThemes = (DefaultableBoolean) 2;
    this.lblAmount.AutoSize = true;
    this.lblAmount.BackColor = Color.Transparent;
    this.lblAmount.Location = new Point(18, 145);
    this.lblAmount.Name = "lblAmount";
    this.lblAmount.Size = new Size(48 /*0x30*/, 13);
    this.lblAmount.TabIndex = 7;
    this.lblAmount.Text = "Amount:";
    this.lblAmount.TextAlign = ContentAlignment.MiddleRight;
    this.rbGross.BackColor = Color.Transparent;
    this.rbGross.Location = new Point(175, 62);
    this.rbGross.Name = "rbGross";
    this.rbGross.Size = new Size(56, 24);
    this.rbGross.TabIndex = 5;
    this.rbGross.Text = "Gross";
    this.rbGross.UseVisualStyleBackColor = false;
    this.rbNet.BackColor = Color.Transparent;
    this.rbNet.Location = new Point(70, 90);
    this.rbNet.Name = "rbNet";
    this.rbNet.Size = new Size(42, 24);
    this.rbNet.TabIndex = 4;
    this.rbNet.Text = "Net";
    this.rbNet.UseVisualStyleBackColor = false;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(30, 66);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(35, 13);
    this.Label9.TabIndex = 3;
    this.Label9.Text = "From:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSelectEntity).Appearance = (AppearanceBase) appearance5;
    ((ControlBase) this.btnSelectEntity).BackColorInternal = SystemColors.Control;
    ((Control) this.btnSelectEntity).Location = new Point(266, 13);
    ((Control) this.btnSelectEntity).Name = "btnSelectEntity";
    ((Control) this.btnSelectEntity).Size = new Size(56, 20);
    ((Control) this.btnSelectEntity).TabIndex = 2;
    ((ControlBase) this.btnSelectEntity).Text = "Select ...";
    this.btnSelectEntity.UseOSThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(28, 16 /*0x10*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(39, 13);
    this.Label7.TabIndex = 0;
    this.Label7.Text = "Entity:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtAmount).Appearance = (AppearanceBase) appearance6;
    ((Control) this.txtAmount).CausesValidation = false;
    ((UltraNumericEditorBase) this.txtAmount).FormatString = "p";
    ((Control) this.txtAmount).Location = new Point(70, 143);
    ((UltraNumericEditor) this.txtAmount).MaskInput = "-nnnnnnn.nnnnnnnnnn";
    this.txtAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAmount).Name = "txtAmount";
    ((UltraNumericEditor) this.txtAmount).NumericType = (NumericType) 1;
    ((Control) this.txtAmount).Size = new Size(100, 20);
    ((Control) this.txtAmount).TabIndex = 26;
    ((UltraControlBase) this.txtAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtFirmIncome);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.udIncomeStartDay);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.udIncomeEndDay);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.cboIncomeStartMonth);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.cboIncomeEndMonth);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(369, 197);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtFirmIncome).Appearance = (AppearanceBase) appearance7;
    ((UltraNumericEditorBase) this.txtFirmIncome).FormatString = "c";
    ((Control) this.txtFirmIncome).Location = new Point(154, 14);
    this.txtFirmIncome.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFirmIncome).Name = "txtFirmIncome";
    ((UltraNumericEditor) this.txtFirmIncome).Nullable = true;
    ((Control) this.txtFirmIncome).Size = new Size(100, 20);
    ((Control) this.txtFirmIncome).TabIndex = 25;
    ((UltraControlBase) this.txtFirmIncome).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirmIncome).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(14, 14);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(125, 13);
    this.Label1.TabIndex = 24;
    this.Label1.Text = "Minimum Income to Firm:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(7, 42);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(134, 13);
    this.Label2.TabIndex = 27;
    this.Label2.Text = "Income Between (mm/dd):";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udIncomeStartDay).Appearance = (AppearanceBase) appearance8;
    ((Control) this.udIncomeStartDay).Location = new Point(301, 42);
    this.udIncomeStartDay.MGAStyle = (MGAStyles) 2;
    ((Control) this.udIncomeStartDay).Name = "udIncomeStartDay";
    ((Control) this.udIncomeStartDay).Size = new Size(42, 20);
    ((Control) this.udIncomeStartDay).TabIndex = 30;
    ((UltraControlBase) this.udIncomeStartDay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udIncomeStartDay).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.udIncomeStartDay).Value = (object) 1;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(133, 72);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(17, 13);
    this.Label5.TabIndex = 31 /*0x1F*/;
    this.Label5.Text = "to";
    this.Label5.TextAlign = ContentAlignment.MiddleCenter;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udIncomeEndDay).Appearance = (AppearanceBase) appearance9;
    ((Control) this.udIncomeEndDay).Location = new Point(301, 70);
    this.udIncomeEndDay.MGAStyle = (MGAStyles) 2;
    ((Control) this.udIncomeEndDay).Name = "udIncomeEndDay";
    ((Control) this.udIncomeEndDay).Size = new Size(42, 20);
    ((Control) this.udIncomeEndDay).TabIndex = 34;
    ((UltraControlBase) this.udIncomeEndDay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udIncomeEndDay).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.udIncomeEndDay).Value = (object) 1;
    ((UltraCombo) this.cboIncomeStartMonth).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboIncomeStartMonth).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboIncomeStartMonth).Location = new Point(154, 42);
    this.cboIncomeStartMonth.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboIncomeStartMonth).Name = "cboIncomeStartMonth";
    ((Control) this.cboIncomeStartMonth).Size = new Size(100, 21);
    ((Control) this.cboIncomeStartMonth).TabIndex = 35;
    ((UltraControlBase) this.cboIncomeStartMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIncomeStartMonth).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboIncomeEndMonth).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboIncomeEndMonth).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboIncomeEndMonth).Location = new Point(154, 70);
    this.cboIncomeEndMonth.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboIncomeEndMonth).Name = "cboIncomeEndMonth";
    ((Control) this.cboIncomeEndMonth).Size = new Size(100, 21);
    ((Control) this.cboIncomeEndMonth).TabIndex = 36;
    ((UltraControlBase) this.cboIncomeEndMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIncomeEndMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraTabControlBase) this.UltraTabControl1).BackColorInternal = Color.Gainsboro;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Dock = DockStyle.Fill;
    ((Control) this.UltraTabControl1).Location = new Point(0, 0);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(371, 224 /*0xE0*/);
    ((Control) this.UltraTabControl1).TabIndex = 37;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(6, 3);
    appearance10.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance10.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance10;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Commissions Info";
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance11;
    ultraTab2.Key = "tabMinimumIncome";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Minimum Income";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(135, 0);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(369, 197);
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.UltraTabControl1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (AddCommissionableEntity);
    this.Size = new Size(371, 224 /*0xE0*/);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.chkOperatingAccount).EndInit();
    ((ISupportInitialize) this.cboChargeCodes).EndInit();
    ((ISupportInitialize) this.txtEntityType).EndInit();
    ((ISupportInitialize) this.txtEntity).EndInit();
    ((ISupportInitialize) this.chkFlat).EndInit();
    ((ISupportInitialize) this.btnSelectEntity).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.txtFirmIncome).EndInit();
    ((ISupportInitialize) this.udIncomeStartDay).EndInit();
    ((ISupportInitialize) this.udIncomeEndDay).EndInit();
    ((ISupportInitialize) this.cboIncomeStartMonth).EndInit();
    ((ISupportInitialize) this.cboIncomeEndMonth).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public AddCommissionableEntity()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    this.BackColor = Color.Transparent;
    this.FillMonths();
  }

  public bool ShowMinimumIncomeTab
  {
    get => ((UltraTabControlBase) this.UltraTabControl1).Tabs["tabMinimumIncome"].Visible;
    set => ((UltraTabControlBase) this.UltraTabControl1).Tabs["tabMinimumIncome"].Visible = value;
  }

  public bool CommissionOnTotalPremium => this.ChargeCode == -500;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public int ChargeCode => Conversions.ToInteger(((UltraCombo) this.cboChargeCodes).Value);

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public bool InternalOnly
  {
    get => this._internalOnly;
    set => this._internalOnly = value;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public string EntityType
  {
    get => ((TextEditorControlBase) this.txtEntityType).Text;
    set => ((TextEditorControlBase) this.txtEntityType).Text = value;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public string EntityTypeID
  {
    get
    {
      return ((Control) this.txtEntityType).Tag != null ? ((Control) this.txtEntityType).Tag.ToString() : string.Empty;
    }
    set => ((Control) this.txtEntityType).Tag = (object) value;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public string Entity
  {
    get => ((TextEditorControlBase) this.txtEntity).Text;
    set => ((TextEditorControlBase) this.txtEntity).Text = value;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Guid EntityGuid
  {
    get => (Guid) ((Control) this.txtEntity).Tag;
    set => ((Control) this.txtEntity).Tag = (object) value;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public int SelectedPolicyChargeCodeID
  {
    get => (int) ((UltraDropDownBase) this.cboChargeCodes).SelectedRow.Cells["ID"].Value;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public AddCommissionableEntity.PolicyChargeTypes SelectedPolicyChargeType
  {
    get
    {
      object objectValue = RuntimeHelpers.GetObjectValue(((UltraDropDownBase) this.cboChargeCodes).SelectedRow.Cells["ChargeType"].Value);
      AddCommissionableEntity.PolicyChargeTypes policyChargeType;
      if (objectValue == DBNull.Value)
      {
        policyChargeType = AddCommissionableEntity.PolicyChargeTypes.TotalPremium;
      }
      else
      {
        string Left = (string) objectValue;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "F", false) == 0)
            policyChargeType = AddCommissionableEntity.PolicyChargeTypes.Fee;
        }
        else
          policyChargeType = AddCommissionableEntity.PolicyChargeTypes.Premium;
      }
      return policyChargeType;
    }
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public string CommissionTypeID
  {
    get
    {
      return !this.rbGross.Checked || !((UltraToggleEditorBase) this.chkFlat).Checked ? (!this.rbGrossPremium.Checked ? (!this.rbGross.Checked ? (!this.rbNet.Checked || !((UltraToggleEditorBase) this.chkFlat).Checked ? (!this.rbNet.Checked ? (!this.rbNetAfter.Checked || !((UltraToggleEditorBase) this.chkFlat).Checked ? "NA" : "FA") : "NT") : "FN") : "GR") : "GP") : "FG";
    }
  }

  private void FillMonths()
  {
    DataTable table = new DataTable();
    table.Columns.Add("MonthName", typeof (string));
    table.Rows.Add((object) "January");
    table.Rows.Add((object) "February");
    table.Rows.Add((object) "March");
    table.Rows.Add((object) "April");
    table.Rows.Add((object) "May");
    table.Rows.Add((object) "June");
    table.Rows.Add((object) "July");
    table.Rows.Add((object) "August");
    table.Rows.Add((object) "September");
    table.Rows.Add((object) "October");
    table.Rows.Add((object) "November");
    table.Rows.Add((object) "December");
    DataView dataView1 = new DataView(table);
    DataView dataView2 = new DataView(table);
    MGASimpleComboBox incomeStartMonth = this.cboIncomeStartMonth;
    ((UltraGridBase) incomeStartMonth).DataSource = (object) dataView1;
    ((UltraDropDownBase) incomeStartMonth).DisplayMember = table.Columns[0].ColumnName;
    MGASimpleComboBox cboIncomeEndMonth = this.cboIncomeEndMonth;
    ((UltraGridBase) cboIncomeEndMonth).DataSource = (object) dataView2;
    ((UltraDropDownBase) cboIncomeEndMonth).DisplayMember = table.Columns[0].ColumnName;
  }

  private void btnSelectEntity_Click(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    using (frmSelectEntity formEx = (frmSelectEntity) ObjectFactory.Instance.CreateFormEX(typeof (frmSelectEntity), new object[0]))
    {
      formEx.InternalOnly = this._internalOnly;
      int num = (int) ((Form) formEx).ShowDialog();
      if (!formEx.EntityGuid.Equals(Guid.Empty))
      {
        ((TextEditorControlBase) this.txtEntity).Text = formEx.EntityName;
        ((Control) this.txtEntity).Tag = (object) formEx.EntityGuid;
        this.EntityType = formEx.EntityType;
        this.EntityTypeID = formEx.EntityTypeID;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(formEx.EntityTypeID, "U", false) == 0)
          ((UltraToggleEditorBase) this.chkOperatingAccount).Checked = new User(formEx.EntityGuid).CommissionsFromOperatingAccount;
        else
          ((UltraToggleEditorBase) this.chkOperatingAccount).Checked = false;
      }
    }
    Cursor.Current = MgaCursors.Default;
  }

  private void chkFlat_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkFlat).Checked)
    {
      if (this.rbGrossPremium.Checked)
        this.rbGrossPremium.Checked = false;
      ((UltraNumericEditorBase) this.txtAmount).FormatString = "c";
    }
    else
      ((UltraNumericEditorBase) this.txtAmount).FormatString = "p";
  }

  public void FillPremiumsFees()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ISNULL(StateID + @D,@S) + ChargeName AS ChargeName, ChargeCode, ChargeType FROM tblFin_PolicyCharges ORDER BY ChargeName", new object[4]
    {
      (object) "@D",
      (object) " - ",
      (object) "@S",
      (object) ""
    });
    DataRow row = dataTable.NewRow();
    row["ChargeName"] = (object) "Total Premium";
    row["ChargeCode"] = (object) -500;
    dataTable.Rows.Add(row);
    MGASimpleComboBox cboChargeCodes = this.cboChargeCodes;
    ((UltraGridBase) cboChargeCodes).DataSource = (object) dataTable;
    ((UltraDropDownBase) cboChargeCodes).DisplayMember = "ChargeName";
    ((UltraDropDownBase) cboChargeCodes).ValueMember = "ChargeCode";
  }

  public void FillPremiumsFees(Guid quoteOptionGuid)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ChargeName, ChargeCode, ID, ChargeType FROM dbo.GetPremiumsAndCommissionableFeesOnOption(@QOG) ORDER BY ChargeName", new object[2]
    {
      (object) "@QOG",
      (object) quoteOptionGuid
    });
    DataRow row = dataTable.NewRow();
    row["ChargeName"] = (object) "Total Premium";
    row["ChargeCode"] = (object) -500;
    dataTable.Rows.Add(row);
    MGASimpleComboBox cboChargeCodes = this.cboChargeCodes;
    ((UltraGridBase) cboChargeCodes).DataSource = (object) dataTable;
    ((UltraDropDownBase) cboChargeCodes).DisplayMember = "ChargeName";
    ((UltraDropDownBase) cboChargeCodes).ValueMember = "ChargeCode";
  }

  public void ClearErrors()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          this.err.SetError(control, string.Empty);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  public void ClearInput()
  {
    ((UltraNumericEditor) this.txtAmount).Value = (object) DBNull.Value;
    ((UltraNumericEditor) this.txtFirmIncome).Value = (object) DBNull.Value;
    ((TextEditorControlBase) this.txtEntity).Text = string.Empty;
    ((Control) this.txtEntity).Tag = (object) Guid.Empty;
    ((TextEditorControlBase) this.txtEntityType).Text = string.Empty;
    ((Control) this.txtEntityType).Tag = (object) null;
    this.rbGross.Checked = false;
    this.rbGrossPremium.Checked = false;
    this.rbNet.Checked = false;
    this.rbNetAfter.Checked = false;
    ((UltraToggleEditorBase) this.chkFlat).Checked = false;
  }

  private bool ValidateAmount(bool valid)
  {
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.txtAmount).Value)) || Decimal.Compare(Conversions.ToDecimal(((UltraNumericEditor) this.txtAmount).Value), 0M) <= 0)
    {
      this.err.SetError((Control) this.txtAmount, "Please enter a valid amount.");
      valid = false;
    }
    else if (!((UltraToggleEditorBase) this.chkFlat).Checked && Conversions.ToDouble(((UltraNumericEditor) this.txtAmount).Value) > 1.0)
    {
      this.err.SetError((Control) this.txtAmount, "Please enter percentages as a value between 0 and 1.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.txtAmount, string.Empty);
    return valid;
  }

  public bool IsValid()
  {
    bool valid1 = true;
    if (!this.rbGross.Checked && !this.rbNet.Checked && !this.rbNetAfter.Checked && !this.rbGrossPremium.Checked)
    {
      this.err.SetError((Control) this.rbGross, "Please choose a commission type.");
      valid1 = false;
    }
    else
      this.err.SetError((Control) this.rbGross, string.Empty);
    if (this.EntityGuid.Equals(Guid.Empty))
    {
      this.err.SetError((Control) this.txtEntity, "Please select a participant.");
      valid1 = false;
    }
    else
      this.err.SetError((Control) this.txtEntity, string.Empty);
    bool valid2 = this.ValidateAmount(valid1);
    if (((UltraDropDownBase) this.cboChargeCodes).SelectedRow == null)
    {
      this.err.SetError((Control) this.cboChargeCodes, "Please select a premium or fee.");
      valid2 = false;
    }
    else
      this.err.SetError((Control) this.cboChargeCodes, string.Empty);
    if (((UltraToggleEditorBase) this.chkFlat).Checked && this.rbGrossPremium.Checked)
    {
      this.err.SetError((Control) this.chkFlat, "For flat gross amounts, please select Gross as the commission type");
      valid2 = false;
    }
    else
      this.err.SetError((Control) this.chkFlat, string.Empty);
    if (this.ShowMinimumIncomeTab && ((UltraNumericEditor) this.txtFirmIncome).Value != DBNull.Value)
      valid2 = this.ValidateMinimumIncomeTab(valid2);
    return valid2;
  }

  private bool ValidateMinimumIncomeTab(bool valid)
  {
    if (this.cboIncomeEndMonth.SelectedIndex < this.cboIncomeStartMonth.SelectedIndex)
    {
      this.err.SetError((Control) this.cboIncomeStartMonth, "Must be less than or equal to the end month.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.cboIncomeStartMonth, string.Empty);
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.udIncomeStartDay).Value)) || Conversions.ToInteger(((UltraNumericEditor) this.udIncomeStartDay).Value) == 0)
    {
      this.err.SetError((Control) this.udIncomeStartDay, "Value required when income for the firm is entered.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.udIncomeStartDay, string.Empty);
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.udIncomeEndDay).Value)) || Conversions.ToInteger(((UltraNumericEditor) this.udIncomeEndDay).Value) == 0)
    {
      this.err.SetError((Control) this.udIncomeEndDay, "Value required when income for the firm is entered.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.udIncomeEndDay, string.Empty);
    if (string.IsNullOrEmpty(this.err.GetError((Control) this.cboIncomeStartMonth)))
    {
      if (string.IsNullOrEmpty(((UltraCombo) this.cboIncomeStartMonth).Text))
      {
        this.err.SetError((Control) this.cboIncomeStartMonth, "Value required when income for the firm is entered.");
        valid = false;
      }
      else
        this.err.SetError((Control) this.cboIncomeStartMonth, string.Empty);
    }
    if (string.IsNullOrEmpty(((UltraCombo) this.cboIncomeEndMonth).Text))
    {
      this.err.SetError((Control) this.cboIncomeEndMonth, "Value required when income for the firm is entered.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.cboIncomeEndMonth, string.Empty);
    return valid;
  }

  public void SelectAllPremiumItem() => ((UltraCombo) this.cboChargeCodes).Value = (object) -500;

  public enum PolicyChargeTypes
  {
    Fee,
    Premium,
    TotalPremium,
  }
}
