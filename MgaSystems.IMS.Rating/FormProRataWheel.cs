// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormProRataWheel
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
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
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormProRataWheel : Form, IComparer
{
  private IContainer components;
  private readonly bool _hideShortRate;

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
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.dtpCancelDate = new MGADateTimePicker();
    this.dtpExpirationDate = new MGADateTimePicker();
    this.dtpEffectiveDate = new MGADateTimePicker();
    this.txtMonths = new MGATextBox();
    this.txtDaysInEffect = new MGATextBox();
    this.txtRemainingDays = new MGATextBox();
    this.numPremium = new MGANumericEditor();
    this.cboRatingMethod = new MGASimpleComboBox();
    this.ds = new dsProRating();
    this.txtEarnedFactor = new MGATextBox();
    this.txtUnearnedFactor = new MGATextBox();
    this.txtReturnPremium = new MGATextBox();
    this.txtEarnedPremium = new MGATextBox();
    this.Label13 = new Label();
    this.cboDecimalPrecision = new MGASimpleComboBox();
    this.chkLeapYear = new CheckBox();
    ((ISupportInitialize) this.dtpCancelDate).BeginInit();
    ((ISupportInitialize) this.dtpExpirationDate).BeginInit();
    ((ISupportInitialize) this.dtpEffectiveDate).BeginInit();
    ((ISupportInitialize) this.txtMonths).BeginInit();
    ((ISupportInitialize) this.txtDaysInEffect).BeginInit();
    ((ISupportInitialize) this.txtRemainingDays).BeginInit();
    ((ISupportInitialize) this.numPremium).BeginInit();
    ((ISupportInitialize) this.cboRatingMethod).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtEarnedFactor).BeginInit();
    ((ISupportInitialize) this.txtUnearnedFactor).BeginInit();
    ((ISupportInitialize) this.txtReturnPremium).BeginInit();
    ((ISupportInitialize) this.txtEarnedPremium).BeginInit();
    ((ISupportInitialize) this.cboDecimalPrecision).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(15, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(98, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Endorsement Date:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(15, 46);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(78, 13);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Effective Date:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(15, 74);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(82, 13);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "Expiration Date:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(15, 102);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(83, 13);
    this.Label4.TabIndex = 3;
    this.Label4.Text = "Term in Months:";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(17, 130);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(76, 13);
    this.Label5.TabIndex = 4;
    this.Label5.Text = "Days in Effect:";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(15, 158);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(87, 13);
    this.Label6.TabIndex = 5;
    this.Label6.Text = "Remaining Days:";
    this.Label6.TextAlign = ContentAlignment.MiddleLeft;
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(15, 186);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(80 /*0x50*/, 13);
    this.Label7.TabIndex = 6;
    this.Label7.Text = "Rating Method:";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(15, 242);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(77, 13);
    this.Label8.TabIndex = 7;
    this.Label8.Text = "Earned Factor:";
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    this.Label9.AutoSize = true;
    this.Label9.Location = new Point(15, 270);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(90, 13);
    this.Label9.TabIndex = 8;
    this.Label9.Text = "Unearned Factor:";
    this.Label9.TextAlign = ContentAlignment.MiddleLeft;
    this.Label10.AutoSize = true;
    this.Label10.Location = new Point(15, 298);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(50, 13);
    this.Label10.TabIndex = 9;
    this.Label10.Text = "Premium:";
    this.Label10.TextAlign = ContentAlignment.MiddleLeft;
    this.Label11.AutoSize = true;
    this.Label11.Location = new Point(15, 326);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(87, 13);
    this.Label11.TabIndex = 10;
    this.Label11.Text = "Earned Premium:";
    this.Label11.TextAlign = ContentAlignment.MiddleLeft;
    this.Label12.AutoSize = true;
    this.Label12.Location = new Point(15, 354);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(85, 13);
    this.Label12.TabIndex = 11;
    this.Label12.Text = "Return Premium:";
    this.Label12.TextAlign = ContentAlignment.MiddleLeft;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpCancelDate.Appearance = (AppearanceBase) appearance1;
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
    this.dtpCancelDate.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtpCancelDate).Location = new Point(119, 15);
    this.dtpCancelDate.MaskInput = "{LOC}mm/dd/yyyy";
    this.dtpCancelDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpCancelDate).Name = "dtpCancelDate";
    ((Control) this.dtpCancelDate).Size = new Size(105, 19);
    ((Control) this.dtpCancelDate).TabIndex = 0;
    ((UltraControlBase) this.dtpCancelDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpCancelDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpCancelDate.Value = (object) null;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpExpirationDate.Appearance = (AppearanceBase) appearance3;
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
    this.dtpExpirationDate.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dtpExpirationDate).Location = new Point(119, 71);
    this.dtpExpirationDate.MaskInput = "{LOC}mm/dd/yyyy";
    this.dtpExpirationDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpExpirationDate).Name = "dtpExpirationDate";
    ((Control) this.dtpExpirationDate).Size = new Size(105, 19);
    ((Control) this.dtpExpirationDate).TabIndex = 2;
    ((UltraControlBase) this.dtpExpirationDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpExpirationDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpExpirationDate.Value = (object) null;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpEffectiveDate.Appearance = (AppearanceBase) appearance5;
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
    this.dtpEffectiveDate.ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.dtpEffectiveDate).Location = new Point(119, 43);
    this.dtpEffectiveDate.MaskInput = "{LOC}mm/dd/yyyy";
    this.dtpEffectiveDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpEffectiveDate).Name = "dtpEffectiveDate";
    ((Control) this.dtpEffectiveDate).Size = new Size(105, 19);
    ((Control) this.dtpEffectiveDate).TabIndex = 1;
    ((UltraControlBase) this.dtpEffectiveDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpEffectiveDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpEffectiveDate.Value = (object) null;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMonths).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtMonths).BackColor = Color.White;
    ((Control) this.txtMonths).Location = new Point(119, 99);
    this.txtMonths.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtMonths).Name = "txtMonths";
    ((EditorButtonControlBase) this.txtMonths).ReadOnly = true;
    ((Control) this.txtMonths).Size = new Size(105, 19);
    ((Control) this.txtMonths).TabIndex = 18;
    ((UltraControlBase) this.txtMonths).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMonths).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDaysInEffect).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtDaysInEffect).BackColor = Color.White;
    ((Control) this.txtDaysInEffect).Location = new Point(119, (int) sbyte.MaxValue);
    this.txtDaysInEffect.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDaysInEffect).Name = "txtDaysInEffect";
    ((EditorButtonControlBase) this.txtDaysInEffect).ReadOnly = true;
    ((Control) this.txtDaysInEffect).Size = new Size(105, 19);
    ((Control) this.txtDaysInEffect).TabIndex = 19;
    ((UltraControlBase) this.txtDaysInEffect).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDaysInEffect).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRemainingDays).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtRemainingDays).BackColor = Color.White;
    ((Control) this.txtRemainingDays).Location = new Point(119, 155);
    this.txtRemainingDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtRemainingDays).Name = "txtRemainingDays";
    ((EditorButtonControlBase) this.txtRemainingDays).ReadOnly = true;
    ((Control) this.txtRemainingDays).Size = new Size(105, 19);
    ((Control) this.txtRemainingDays).TabIndex = 20;
    ((UltraControlBase) this.txtRemainingDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRemainingDays).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPremium).Appearance = (AppearanceBase) appearance10;
    ((Control) this.numPremium).Location = new Point(119, 295);
    this.numPremium.MaskInput = "-nnnnnnnnnnnnnnn.nn";
    this.numPremium.MaxValue = (object) new Decimal(new int[4]
    {
      -1981284353,
      -1966660860,
      0,
      131072 /*0x020000*/
    });
    this.numPremium.MGAStyle = MGAStyles.Blue;
    this.numPremium.MinValue = (object) new Decimal(new int[4]
    {
      -1981284353,
      -1966660860,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.numPremium).Name = "numPremium";
    this.numPremium.Nullable = true;
    this.numPremium.NumericType = (NumericType) 2;
    ((Control) this.numPremium).Size = new Size(188, 19);
    ((Control) this.numPremium).TabIndex = 4;
    ((UltraControlBase) this.numPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPremium).UseOsThemes = (DefaultableBoolean) 2;
    this.cboRatingMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboRatingMethod).DataMember = "lstEndorsementCalculationTypes";
    ((UltraGridBase) this.cboRatingMethod).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboRatingMethod).DisplayMember = "EndorsementCalcType";
    this.cboRatingMethod.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRatingMethod).DropDownWidth = 300;
    ((Control) this.cboRatingMethod).Location = new Point(119, 182);
    this.cboRatingMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRatingMethod).Name = "cboRatingMethod";
    ((Control) this.cboRatingMethod).Size = new Size(188, 20);
    ((Control) this.cboRatingMethod).TabIndex = 3;
    ((UltraControlBase) this.cboRatingMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRatingMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRatingMethod).ValueMember = "ID";
    this.ds.DataSetName = "dsProRating";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEarnedFactor).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtEarnedFactor).BackColor = Color.White;
    ((Control) this.txtEarnedFactor).Location = new Point(119, 239);
    this.txtEarnedFactor.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEarnedFactor).Name = "txtEarnedFactor";
    ((EditorButtonControlBase) this.txtEarnedFactor).ReadOnly = true;
    ((Control) this.txtEarnedFactor).Size = new Size(188, 19);
    ((Control) this.txtEarnedFactor).TabIndex = 42;
    ((UltraControlBase) this.txtEarnedFactor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEarnedFactor).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUnearnedFactor).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtUnearnedFactor).BackColor = Color.White;
    ((Control) this.txtUnearnedFactor).Location = new Point(119, 267);
    this.txtUnearnedFactor.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtUnearnedFactor).Name = "txtUnearnedFactor";
    ((EditorButtonControlBase) this.txtUnearnedFactor).ReadOnly = true;
    ((Control) this.txtUnearnedFactor).Size = new Size(188, 19);
    ((Control) this.txtUnearnedFactor).TabIndex = 43;
    ((UltraControlBase) this.txtUnearnedFactor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUnearnedFactor).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtReturnPremium).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtReturnPremium).BackColor = Color.White;
    ((Control) this.txtReturnPremium).Location = new Point(119, 351);
    this.txtReturnPremium.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtReturnPremium).Name = "txtReturnPremium";
    ((EditorButtonControlBase) this.txtReturnPremium).ReadOnly = true;
    ((Control) this.txtReturnPremium).Size = new Size(188, 19);
    ((Control) this.txtReturnPremium).TabIndex = 44;
    ((UltraControlBase) this.txtReturnPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtReturnPremium).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEarnedPremium).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtEarnedPremium).BackColor = Color.White;
    ((Control) this.txtEarnedPremium).Location = new Point(119, 323);
    this.txtEarnedPremium.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEarnedPremium).Name = "txtEarnedPremium";
    ((EditorButtonControlBase) this.txtEarnedPremium).ReadOnly = true;
    ((Control) this.txtEarnedPremium).Size = new Size(188, 19);
    ((Control) this.txtEarnedPremium).TabIndex = 45;
    ((UltraControlBase) this.txtEarnedPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEarnedPremium).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.Location = new Point(15, 214);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(94, 13);
    this.Label13.TabIndex = 47;
    this.Label13.Text = "Decimal Precision:";
    this.Label13.TextAlign = ContentAlignment.MiddleLeft;
    this.cboDecimalPrecision.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboDecimalPrecision).DataSource = (object) true;
    this.cboDecimalPrecision.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboDecimalPrecision).DropDownWidth = 50;
    ((Control) this.cboDecimalPrecision).Location = new Point(119, 210);
    this.cboDecimalPrecision.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDecimalPrecision).Name = "cboDecimalPrecision";
    ((Control) this.cboDecimalPrecision).Size = new Size(50, 20);
    ((Control) this.cboDecimalPrecision).TabIndex = 48 /*0x30*/;
    ((UltraControlBase) this.cboDecimalPrecision).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDecimalPrecision).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDecimalPrecision).ValueMember = "ID";
    this.chkLeapYear.AutoSize = true;
    this.chkLeapYear.Checked = true;
    this.chkLeapYear.CheckState = CheckState.Checked;
    this.chkLeapYear.Location = new Point(230, 16 /*0x10*/);
    this.chkLeapYear.Name = "chkLeapYear";
    this.chkLeapYear.Size = new Size(113, 17);
    this.chkLeapYear.TabIndex = 49;
    this.chkLeapYear.Text = "Include Leap Year";
    this.chkLeapYear.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(349, 387);
    this.Controls.Add((Control) this.chkLeapYear);
    this.Controls.Add((Control) this.cboDecimalPrecision);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.txtEarnedPremium);
    this.Controls.Add((Control) this.txtReturnPremium);
    this.Controls.Add((Control) this.txtUnearnedFactor);
    this.Controls.Add((Control) this.txtEarnedFactor);
    this.Controls.Add((Control) this.cboRatingMethod);
    this.Controls.Add((Control) this.numPremium);
    this.Controls.Add((Control) this.txtRemainingDays);
    this.Controls.Add((Control) this.txtDaysInEffect);
    this.Controls.Add((Control) this.txtMonths);
    this.Controls.Add((Control) this.dtpEffectiveDate);
    this.Controls.Add((Control) this.dtpExpirationDate);
    this.Controls.Add((Control) this.dtpCancelDate);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormProRataWheel);
    this.Text = "Pro-Rata Wheel";
    ((ISupportInitialize) this.dtpCancelDate).EndInit();
    ((ISupportInitialize) this.dtpExpirationDate).EndInit();
    ((ISupportInitialize) this.dtpEffectiveDate).EndInit();
    ((ISupportInitialize) this.txtMonths).EndInit();
    ((ISupportInitialize) this.txtDaysInEffect).EndInit();
    ((ISupportInitialize) this.txtRemainingDays).EndInit();
    ((ISupportInitialize) this.numPremium).EndInit();
    ((ISupportInitialize) this.cboRatingMethod).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtEarnedFactor).EndInit();
    ((ISupportInitialize) this.txtUnearnedFactor).EndInit();
    ((ISupportInitialize) this.txtReturnPremium).EndInit();
    ((ISupportInitialize) this.txtEarnedPremium).EndInit();
    ((ISupportInitialize) this.cboDecimalPrecision).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGADateTimePicker dtpCancelDate
  {
    get => this._dtpCancelDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dtpCancelDate_ValueChanged);
      MGADateTimePicker dtpCancelDate1 = this._dtpCancelDate;
      if (dtpCancelDate1 != null)
        dtpCancelDate1.ValueChanged -= eventHandler;
      this._dtpCancelDate = value;
      MGADateTimePicker dtpCancelDate2 = this._dtpCancelDate;
      if (dtpCancelDate2 == null)
        return;
      dtpCancelDate2.ValueChanged += eventHandler;
    }
  }

  private virtual MGADateTimePicker dtpExpirationDate
  {
    get => this._dtpExpirationDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dtpExpirationDate_ValueChanged);
      MGADateTimePicker dtpExpirationDate1 = this._dtpExpirationDate;
      if (dtpExpirationDate1 != null)
        dtpExpirationDate1.ValueChanged -= eventHandler;
      this._dtpExpirationDate = value;
      MGADateTimePicker dtpExpirationDate2 = this._dtpExpirationDate;
      if (dtpExpirationDate2 == null)
        return;
      dtpExpirationDate2.ValueChanged += eventHandler;
    }
  }

  private virtual MGADateTimePicker dtpEffectiveDate
  {
    get => this._dtpEffectiveDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dtpEffectiveDate_ValueChanged);
      MGADateTimePicker dtpEffectiveDate1 = this._dtpEffectiveDate;
      if (dtpEffectiveDate1 != null)
        dtpEffectiveDate1.ValueChanged -= eventHandler;
      this._dtpEffectiveDate = value;
      MGADateTimePicker dtpEffectiveDate2 = this._dtpEffectiveDate;
      if (dtpEffectiveDate2 == null)
        return;
      dtpEffectiveDate2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtMonths")]
  private virtual MGATextBox txtMonths { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDaysInEffect")]
  private virtual MGATextBox txtDaysInEffect { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRemainingDays")]
  private virtual MGATextBox txtRemainingDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGANumericEditor numPremium
  {
    get => this._numPremium;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboRatingMethod_ValueChanged);
      MGANumericEditor numPremium1 = this._numPremium;
      if (numPremium1 != null)
        ((UltraNumericEditorBase) numPremium1).ValueChanged -= eventHandler;
      this._numPremium = value;
      MGANumericEditor numPremium2 = this._numPremium;
      if (numPremium2 == null)
        return;
      ((UltraNumericEditorBase) numPremium2).ValueChanged += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cboRatingMethod
  {
    get => this._cboRatingMethod;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboRatingMethod_ValueChanged);
      MGASimpleComboBox cboRatingMethod1 = this._cboRatingMethod;
      if (cboRatingMethod1 != null)
        cboRatingMethod1.ValueChanged -= eventHandler;
      this._cboRatingMethod = value;
      MGASimpleComboBox cboRatingMethod2 = this._cboRatingMethod;
      if (cboRatingMethod2 == null)
        return;
      cboRatingMethod2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtEarnedFactor")]
  private virtual MGATextBox txtEarnedFactor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUnearnedFactor")]
  private virtual MGATextBox txtUnearnedFactor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtReturnPremium")]
  private virtual MGATextBox txtReturnPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEarnedPremium")]
  private virtual MGATextBox txtEarnedPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsProRating ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboDecimalPrecision
  {
    get => this._cboDecimalPrecision;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.cboDecimalPrecision_ValueChanged);
      MGASimpleComboBox decimalPrecision1 = this._cboDecimalPrecision;
      if (decimalPrecision1 != null)
        decimalPrecision1.RowSelected -= selectedEventHandler;
      this._cboDecimalPrecision = value;
      MGASimpleComboBox decimalPrecision2 = this._cboDecimalPrecision;
      if (decimalPrecision2 == null)
        return;
      decimalPrecision2.RowSelected += selectedEventHandler;
    }
  }

  internal virtual CheckBox chkLeapYear
  {
    get => this._chkLeapYear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkLeapYear_CheckedChanged);
      CheckBox chkLeapYear1 = this._chkLeapYear;
      if (chkLeapYear1 != null)
        chkLeapYear1.CheckedChanged -= eventHandler;
      this._chkLeapYear = value;
      CheckBox chkLeapYear2 = this._chkLeapYear;
      if (chkLeapYear2 == null)
        return;
      chkLeapYear2.CheckedChanged += eventHandler;
    }
  }

  public FormProRataWheel()
  {
    this.Load += new EventHandler(this.FormProRataWheel_Load);
    this._hideShortRate = false;
    this.InitializeComponent();
    if (!SystemSettings.KeyExists("HideShortRateOnProrataWheel") || !SystemSettings.GetBoolSetting("HideShortRateOnProrataWheel"))
      return;
    this._hideShortRate = true;
  }

  private void FormProRataWheel_Load(object sender, EventArgs e)
  {
    this.dtpCancelDate.Value = (object) DateAndTime.Now;
    string empty = string.Empty;
    if (!this._hideShortRate)
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "lstEndorsementCalculationTypes"
      }, CommandType.Text, "SELECT EndorsementCalcType, ID FROM lstEndorsementCalculationTypes WHERE (ID <> @F AND ID <> @M)", new object[4]
      {
        (object) "@F",
        (object) "F",
        (object) "@M",
        (object) "M"
      });
    else
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "lstEndorsementCalculationTypes"
      }, CommandType.Text, "SELECT EndorsementCalcType, ID FROM lstEndorsementCalculationTypes WHERE (ID <> @F AND ID <> @M AND ID <> @R)", new object[6]
      {
        (object) "@F",
        (object) "F",
        (object) "@M",
        (object) "M",
        (object) "@R",
        (object) "R"
      });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstShortRates"
    }, CommandType.Text, "SELECT DaysInEffect, Factor, Percentage FROM lstShortRates");
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add("Precision", typeof (int));
    object[] objArray = new object[1];
    int num1 = 2;
    do
    {
      objArray[0] = (object) num1;
      dataTable.Rows.Add((object) num1);
      ++num1;
    }
    while (num1 <= 7);
    ((UltraDropDownBase) this.cboDecimalPrecision).DisplayMember = "Precision";
    ((UltraDropDownBase) this.cboDecimalPrecision).ValueMember = "Precision";
    ((UltraGridBase) this.cboDecimalPrecision).DataSource = (object) dataTable;
    string str1 = "SELECT SettingValueNumeric FROM tblSystemSettings WHERE Setting = @PR";
    int num2 = 3;
    object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str1, new object[2]
    {
      (object) "@PR",
      (object) "SetProRataWheelPrecision"
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      num2 = Conversions.ToInteger(objectValue1);
    string str2 = "SELECT SettingValueBool FROM tblSystemSettings WHERE Setting = @PR";
    bool flag = true;
    object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str2, new object[2]
    {
      (object) "@PR",
      (object) "DefaultProRataWheelLeapYear"
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      flag = Conversions.ToBoolean(objectValue2);
    this.cboDecimalPrecision.Value = (object) num2;
    this.chkLeapYear.Checked = flag;
    this.cboRatingMethod.Value = (object) "P";
  }

  private void GetMonths()
  {
    if (this.dtpEffectiveDate.Value == null || this.dtpEffectiveDate.Value == DBNull.Value || this.dtpExpirationDate.Value == null || this.dtpExpirationDate.Value == DBNull.Value)
      return;
    MGATextBox txtMonths = this.txtMonths;
    DateTime date = Conversions.ToDate(this.dtpExpirationDate.Value);
    int year1 = date.Year;
    date = Conversions.ToDate(this.dtpEffectiveDate.Value);
    int year2 = date.Year;
    int num1 = 12 * (year1 - year2);
    date = Conversions.ToDate(this.dtpExpirationDate.Value);
    int month1 = date.Month;
    int num2 = num1 + month1;
    date = Conversions.ToDate(this.dtpEffectiveDate.Value);
    int month2 = date.Month;
    string str = (num2 - month2).ToString();
    ((TextEditorControlBase) txtMonths).Text = str;
  }

  private void FillValues()
  {
    ((TextEditorControlBase) this.txtDaysInEffect).Text = string.Empty;
    ((TextEditorControlBase) this.txtMonths).Text = string.Empty;
    ((TextEditorControlBase) this.txtRemainingDays).Text = string.Empty;
    int days;
    if (this.dtpCancelDate.Value != null && this.dtpCancelDate.Value != DBNull.Value)
    {
      if (this.dtpEffectiveDate.Value != null && this.dtpEffectiveDate.Value != DBNull.Value && this.Compare(RuntimeHelpers.GetObjectValue(this.dtpCancelDate.Value), RuntimeHelpers.GetObjectValue(this.dtpEffectiveDate.Value)) > 0)
        ((TextEditorControlBase) this.txtDaysInEffect).Text = (Conversions.ToDate(this.dtpCancelDate.Value).Date - Conversions.ToDate(this.dtpEffectiveDate.Value).Date).Days.ToString();
    }
    else if (this.dtpExpirationDate.Value != null && this.dtpExpirationDate.Value != DBNull.Value && this.dtpEffectiveDate.Value != null && this.dtpEffectiveDate.Value != DBNull.Value && this.Compare(RuntimeHelpers.GetObjectValue(this.dtpExpirationDate.Value), RuntimeHelpers.GetObjectValue(this.dtpEffectiveDate.Value)) > 0)
    {
      TimeSpan timeSpan = Conversions.ToDate(this.dtpExpirationDate.Value).Date - Conversions.ToDate(this.dtpEffectiveDate.Value).Date;
      MGATextBox txtDaysInEffect = this.txtDaysInEffect;
      days = timeSpan.Days;
      string str = days.ToString();
      ((TextEditorControlBase) txtDaysInEffect).Text = str;
    }
    if (this.dtpCancelDate.Value != null && this.dtpCancelDate.Value != DBNull.Value)
    {
      if (this.dtpExpirationDate.Value == null || this.dtpExpirationDate.Value == DBNull.Value || this.Compare(RuntimeHelpers.GetObjectValue(this.dtpExpirationDate.Value), RuntimeHelpers.GetObjectValue(this.dtpCancelDate.Value)) <= 0)
        return;
      TimeSpan timeSpan = Conversions.ToDate(this.dtpExpirationDate.Value).Date - Conversions.ToDate(this.dtpCancelDate.Value).Date;
      MGATextBox txtRemainingDays = this.txtRemainingDays;
      days = timeSpan.Days;
      string str = days.ToString();
      ((TextEditorControlBase) txtRemainingDays).Text = str;
    }
    else
    {
      if (this.dtpEffectiveDate.Value == null || this.dtpEffectiveDate.Value == DBNull.Value || this.dtpExpirationDate.Value == null || this.dtpExpirationDate.Value == DBNull.Value || this.Compare(RuntimeHelpers.GetObjectValue(this.dtpExpirationDate.Value), RuntimeHelpers.GetObjectValue(this.dtpEffectiveDate.Value)) <= 0)
        return;
      TimeSpan timeSpan = Conversions.ToDate(this.dtpExpirationDate.Value).Date - Conversions.ToDate(this.dtpEffectiveDate.Value).Date;
      MGATextBox txtRemainingDays = this.txtRemainingDays;
      days = timeSpan.Days;
      string str = days.ToString();
      ((TextEditorControlBase) txtRemainingDays).Text = str;
    }
  }

  int IComparer.Compare(object x, object y) => DateTime.Compare((DateTime) x, (DateTime) y);

  private void RecalculateFactors()
  {
    ((TextEditorControlBase) this.txtEarnedFactor).Text = string.Empty;
    ((TextEditorControlBase) this.txtUnearnedFactor).Text = string.Empty;
    ((TextEditorControlBase) this.txtEarnedPremium).Text = string.Empty;
    if (this.cboRatingMethod.Value == DBNull.Value || this.cboRatingMethod.Value == null || this.dtpCancelDate.Value == null || this.dtpCancelDate.Value == DBNull.Value || this.dtpExpirationDate.Value == null || this.dtpExpirationDate.Value == DBNull.Value || this.dtpEffectiveDate.Value == null)
      return;
    if (this.dtpEffectiveDate.Value == DBNull.Value)
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      TimeSpan timeSpan = Conversions.ToDate(this.dtpExpirationDate.Value).Date - Conversions.ToDate(this.dtpEffectiveDate.Value).Date;
      DateTime date1 = Conversions.ToDate(this.dtpExpirationDate.Value);
      DateTime date2 = date1.Date;
      date1 = Conversions.ToDate(this.dtpCancelDate.Value);
      DateTime date3 = date1.Date;
      int days1 = (date2 - date3).Days;
      int days2 = timeSpan.Days;
      if (!this.chkLeapYear.Checked)
      {
        int leapDays1 = this.GetLeapDays(Conversions.ToDate(this.dtpEffectiveDate.Value), Conversions.ToDate(this.dtpExpirationDate.Value));
        int leapDays2 = this.GetLeapDays(Conversions.ToDate(this.dtpCancelDate.Value), Conversions.ToDate(this.dtpExpirationDate.Value));
        days1 -= leapDays2;
        days2 -= leapDays1;
      }
      ((TextEditorControlBase) this.txtDaysInEffect).Text = days2.ToString();
      ((TextEditorControlBase) this.txtRemainingDays).Text = days1.ToString();
      this.CalculateFactors(this.cboRatingMethod.Value.ToString());
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void cboRatingMethod_ValueChanged(object sender, EventArgs e)
  {
    this.FillValues();
    this.RecalculateFactors();
    this.GetMonths();
  }

  private void CalculateFactors(string factor)
  {
    DateTime date1 = Conversions.ToDate(this.dtpExpirationDate.Value);
    DateTime date2 = date1.Date;
    date1 = Conversions.ToDate(this.dtpEffectiveDate.Value);
    DateTime date3 = date1.Date;
    TimeSpan timeSpan1 = date2 - date3;
    DateTime date4 = Conversions.ToDate(this.dtpCancelDate.Value);
    DateTime date5 = date4.Date;
    date4 = Conversions.ToDate(this.dtpEffectiveDate.Value);
    DateTime date6 = date4.Date;
    TimeSpan timeSpan2 = date5 - date6;
    Decimal d = 0M;
    Decimal d1 = 0M;
    if (this.numPremium.Value != null && this.numPremium.Value != DBNull.Value)
      d1 = Conversions.ToDecimal(this.numPremium.Value);
    int integer1 = Conversions.ToInteger(((TextEditorControlBase) this.txtRemainingDays).Text);
    int integer2 = Conversions.ToInteger(((TextEditorControlBase) this.txtDaysInEffect).Text);
    string Left = factor;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "F", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "M", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "S", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "R", false) != 0)
            throw new InvalidOperationException("Wrong Factor Passed!!");
          if (integer2 != 0)
          {
            dsProRating.lstShortRatesRow byDaysInEffect = this.ds.lstShortRates.FindByDaysInEffect(timeSpan2.Days);
            if (byDaysInEffect != null)
              d = Decimal.Subtract(1M, Decimal.Multiply(byDaysInEffect.Percentage, Convert.ToDecimal(0.01)));
          }
        }
        else if (integer2 != 0)
          d = Conversions.ToDecimal(new Decimal((double) integer1 / (double) integer2 * 0.9).ToString());
      }
      else if (integer2 != 0)
        d = Conversions.ToDecimal(new Decimal((double) integer1 / (double) integer2).ToString());
    }
    else
      d = 1M;
    Decimal d2_1 = Math.Round(d, this.cboDecimalPrecision.SelectedIndex + 2);
    ((TextEditorControlBase) this.txtUnearnedFactor).Text = d2_1.ToString();
    ((TextEditorControlBase) this.txtEarnedFactor).Text = Decimal.Subtract(1M, d2_1).ToString();
    Decimal d2_2 = Math.Round(Decimal.Multiply(d1, d2_1), 2, MidpointRounding.AwayFromZero);
    ((TextEditorControlBase) this.txtReturnPremium).Text = d2_2.ToString("c");
    ((TextEditorControlBase) this.txtEarnedPremium).Text = Decimal.Subtract(d1, d2_2).ToString("c");
  }

  private int GetLeapDays(DateTime startDate, DateTime endDate)
  {
    Dictionary<string, DbParameter> dictionary = DefaultDatabase.DiscoverParameters("dbo.CalculateLeapDaysInRange");
    dictionary["@StartDate"].Value = (object) startDate;
    dictionary["@EndDate"].Value = (object) endDate;
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.CalculateLeapDaysInRange", 150, (CommandArgumentType) 2, new object[1]
    {
      (object) dictionary
    });
    DbParameter dbParameter = dictionary["@LeapDays"];
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(dbParameter.Value)) ? 0 : Conversions.ToInteger(dbParameter.Value);
  }

  private void dtpExpirationDate_ValueChanged(object sender, EventArgs e)
  {
    this.FillValues();
    this.RecalculateFactors();
    this.GetMonths();
  }

  private void dtpCancelDate_ValueChanged(object sender, EventArgs e)
  {
    this.FillValues();
    this.RecalculateFactors();
    this.GetMonths();
  }

  private void dtpEffectiveDate_ValueChanged(object sender, EventArgs e)
  {
    if (this.dtpEffectiveDate.Value != null && this.dtpEffectiveDate.Value != DBNull.Value)
    {
      DateTime dateTime = Conversions.ToDate(this.dtpEffectiveDate.Value);
      int year1 = dateTime.Year;
      dateTime = DateTime.MaxValue;
      int year2 = dateTime.Year;
      if (year1 < year2)
      {
        dateTime = Conversions.ToDate(this.dtpEffectiveDate.Value);
        int year3 = dateTime.Year;
        dateTime = DateTime.MinValue;
        int year4 = dateTime.Year;
        if (year3 > year4)
        {
          MGADateTimePicker dtpExpirationDate = this.dtpExpirationDate;
          dateTime = Conversions.ToDate(this.dtpEffectiveDate.Value);
          // ISSUE: variable of a boxed type
          __Boxed<DateTime> local = (System.ValueType) dateTime.AddYears(1);
          dtpExpirationDate.Value = (object) local;
        }
      }
    }
    this.FillValues();
    this.RecalculateFactors();
    this.GetMonths();
  }

  private void cboDecimalPrecision_ValueChanged(object sender, RowSelectedEventArgs e)
  {
    this.FillValues();
    this.RecalculateFactors();
    this.GetMonths();
  }

  private void chkLeapYear_CheckedChanged(object sender, EventArgs e)
  {
    this.FillValues();
    this.RecalculateFactors();
    this.GetMonths();
  }
}
