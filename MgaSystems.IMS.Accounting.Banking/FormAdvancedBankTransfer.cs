// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.FormAdvancedBankTransfer
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Banking.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[DesignerGenerated]
public class FormAdvancedBankTransfer : FormBase
{
  private IContainer components;
  protected string LoadBankAccount_ProcedureName;
  protected string LoadGLList_ProcedureName;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAdvancedBankTransfer));
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("", -1);
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
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance24 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("", -1);
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.comboSingleOffice_OfficeLocation = new MGASimpleComboBox();
    this.panelSingleOffice = new Panel();
    this.comboSingleOffice_CreditCostCenter = new MGASimpleComboBox();
    this.Label19 = new Label();
    this.comboSingleOffice_DebitCostCenter = new MGASimpleComboBox();
    this.Label20 = new Label();
    this.textSingleOffice_TransactionComments = new MGATextBox();
    this.Label16 = new Label();
    this.dateTimeSingleOffice_PostDate = new MGADateTimePicker();
    this.Label15 = new Label();
    this.buttonSingleOffice_Save = new MGAButton();
    this.buttonSingleOffice_Cancel = new MGAButton();
    this.Label5 = new Label();
    this.maskSingleOffice_Amount = new MGAMaskedEdit();
    this.comboSingleOffice_DestinationAccount = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.comboSingleOffice_SourceBank = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.panelMultipleOffices = new Panel();
    this.comboMultiOffice_DestinationCreditCostCenter = new MGASimpleComboBox();
    this.Label23 = new Label();
    this.comboMultiOffice_DestinationDebitCostCenter = new MGASimpleComboBox();
    this.Label24 = new Label();
    this.comboMultiOffice_SourceCreditCostCenter = new MGASimpleComboBox();
    this.Label21 = new Label();
    this.comboMultiOffice_SourceDebitCostCenter = new MGASimpleComboBox();
    this.Label22 = new Label();
    this.textMultiOffice_TransactionComment = new MGATextBox();
    this.Label17 = new Label();
    this.dateTimeMultiOffice_PostDate = new MGADateTimePicker();
    this.Label18 = new Label();
    this.comboMultiOffice_DestinationOffsetAccount = new MGAComboBox();
    this.comboMultiOffice_SourceOffsetAccount = new MGAComboBox();
    this.Label14 = new Label();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.comboMultiOffice_DestinationOfficeLocation = new MGASimpleComboBox();
    this.Label10 = new Label();
    this.buttonMultiOffice_Save = new MGAButton();
    this.buttonMultiOffice_Cancel = new MGAButton();
    this.Label6 = new Label();
    this.maskMultiOffice_Amount = new MGAMaskedEdit();
    this.comboMultiOffice_DestinationBank = new MGASimpleComboBox();
    this.Label7 = new Label();
    this.comboMultiOffice_SourceBank = new MGASimpleComboBox();
    this.Label8 = new Label();
    this.comboMultiOffice_SourceOfficeLocation = new MGASimpleComboBox();
    this.Label9 = new Label();
    this.checkSingleOffice = new MGACheckBox();
    ((ISupportInitialize) this.comboSingleOffice_OfficeLocation).BeginInit();
    this.panelSingleOffice.SuspendLayout();
    ((ISupportInitialize) this.comboSingleOffice_CreditCostCenter).BeginInit();
    ((ISupportInitialize) this.comboSingleOffice_DebitCostCenter).BeginInit();
    ((ISupportInitialize) this.textSingleOffice_TransactionComments).BeginInit();
    ((ISupportInitialize) this.dateTimeSingleOffice_PostDate).BeginInit();
    ((ISupportInitialize) this.buttonSingleOffice_Save).BeginInit();
    ((ISupportInitialize) this.buttonSingleOffice_Cancel).BeginInit();
    ((ISupportInitialize) this.maskSingleOffice_Amount).BeginInit();
    ((ISupportInitialize) this.comboSingleOffice_DestinationAccount).BeginInit();
    ((ISupportInitialize) this.comboSingleOffice_SourceBank).BeginInit();
    this.panelMultipleOffices.SuspendLayout();
    ((ISupportInitialize) this.comboMultiOffice_DestinationCreditCostCenter).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_DestinationDebitCostCenter).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceCreditCostCenter).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceDebitCostCenter).BeginInit();
    ((ISupportInitialize) this.textMultiOffice_TransactionComment).BeginInit();
    ((ISupportInitialize) this.dateTimeMultiOffice_PostDate).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_DestinationOffsetAccount).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceOffsetAccount).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_DestinationOfficeLocation).BeginInit();
    ((ISupportInitialize) this.buttonMultiOffice_Save).BeginInit();
    ((ISupportInitialize) this.buttonMultiOffice_Cancel).BeginInit();
    ((ISupportInitialize) this.maskMultiOffice_Amount).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_DestinationBank).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceBank).BeginInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceOfficeLocation).BeginInit();
    ((ISupportInitialize) this.checkSingleOffice).BeginInit();
    this.SuspendLayout();
    this.Label1.BackColor = Color.FromArgb(125, 165, 225);
    this.Label1.Dock = DockStyle.Top;
    this.Label1.Font = new Font("Tahoma", 16f, FontStyle.Bold);
    this.Label1.ForeColor = Color.White;
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(376, 28);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "BANK TRANSFER";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(7, 3);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(83, 13);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Office Location:";
    this.comboSingleOffice_OfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboSingleOffice_OfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSingleOffice_OfficeLocation).Location = new Point(120, 3);
    this.comboSingleOffice_OfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboSingleOffice_OfficeLocation).Name = "comboSingleOffice_OfficeLocation";
    ((Control) this.comboSingleOffice_OfficeLocation).Size = new Size(244, 21);
    ((Control) this.comboSingleOffice_OfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.comboSingleOffice_OfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboSingleOffice_OfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.panelSingleOffice.BackColor = Color.Transparent;
    this.panelSingleOffice.Controls.Add((Control) this.comboSingleOffice_CreditCostCenter);
    this.panelSingleOffice.Controls.Add((Control) this.Label19);
    this.panelSingleOffice.Controls.Add((Control) this.comboSingleOffice_DebitCostCenter);
    this.panelSingleOffice.Controls.Add((Control) this.Label20);
    this.panelSingleOffice.Controls.Add((Control) this.textSingleOffice_TransactionComments);
    this.panelSingleOffice.Controls.Add((Control) this.Label16);
    this.panelSingleOffice.Controls.Add((Control) this.dateTimeSingleOffice_PostDate);
    this.panelSingleOffice.Controls.Add((Control) this.Label15);
    this.panelSingleOffice.Controls.Add((Control) this.buttonSingleOffice_Save);
    this.panelSingleOffice.Controls.Add((Control) this.buttonSingleOffice_Cancel);
    this.panelSingleOffice.Controls.Add((Control) this.Label5);
    this.panelSingleOffice.Controls.Add((Control) this.maskSingleOffice_Amount);
    this.panelSingleOffice.Controls.Add((Control) this.comboSingleOffice_DestinationAccount);
    this.panelSingleOffice.Controls.Add((Control) this.Label4);
    this.panelSingleOffice.Controls.Add((Control) this.comboSingleOffice_SourceBank);
    this.panelSingleOffice.Controls.Add((Control) this.Label3);
    this.panelSingleOffice.Controls.Add((Control) this.comboSingleOffice_OfficeLocation);
    this.panelSingleOffice.Controls.Add((Control) this.Label2);
    this.panelSingleOffice.Location = new Point(5, 51);
    this.panelSingleOffice.Name = "panelSingleOffice";
    this.panelSingleOffice.Size = new Size(374, 351);
    this.panelSingleOffice.TabIndex = 2;
    this.comboSingleOffice_CreditCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboSingleOffice_CreditCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSingleOffice_CreditCostCenter).Location = new Point(120, 291);
    this.comboSingleOffice_CreditCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboSingleOffice_CreditCostCenter).Name = "comboSingleOffice_CreditCostCenter";
    ((Control) this.comboSingleOffice_CreditCostCenter).Size = new Size(244, 21);
    ((Control) this.comboSingleOffice_CreditCostCenter).TabIndex = 15;
    ((UltraControlBase) this.comboSingleOffice_CreditCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboSingleOffice_CreditCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label19.AutoSize = true;
    this.Label19.Location = new Point(7, 291);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(101, 13);
    this.Label19.TabIndex = 14;
    this.Label19.Text = "Credit Cost Center:";
    this.comboSingleOffice_DebitCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboSingleOffice_DebitCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSingleOffice_DebitCostCenter).Location = new Point(120, 268);
    this.comboSingleOffice_DebitCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboSingleOffice_DebitCostCenter).Name = "comboSingleOffice_DebitCostCenter";
    ((Control) this.comboSingleOffice_DebitCostCenter).Size = new Size(244, 21);
    ((Control) this.comboSingleOffice_DebitCostCenter).TabIndex = 13;
    ((UltraControlBase) this.comboSingleOffice_DebitCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboSingleOffice_DebitCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label20.AutoSize = true;
    this.Label20.Location = new Point(7, 268);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(97, 13);
    this.Label20.TabIndex = 12;
    this.Label20.Text = "Debit Cost Center:";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textSingleOffice_TransactionComments).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.textSingleOffice_TransactionComments).BackColor = Color.White;
    ((Control) this.textSingleOffice_TransactionComments).Location = new Point(120, 121);
    ((TextEditorControlBase) this.textSingleOffice_TransactionComments).MaxLength = 2500;
    this.textSingleOffice_TransactionComments.MGAStyle = MGAStyles.Blue;
    this.textSingleOffice_TransactionComments.Multiline = true;
    ((Control) this.textSingleOffice_TransactionComments).Name = "textSingleOffice_TransactionComments";
    ((Control) this.textSingleOffice_TransactionComments).Size = new Size(244, 145);
    ((Control) this.textSingleOffice_TransactionComments).TabIndex = 11;
    ((UltraControlBase) this.textSingleOffice_TransactionComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textSingleOffice_TransactionComments).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.AutoSize = true;
    this.Label16.Location = new Point(7, 121);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(77, 13);
    this.Label16.TabIndex = 10;
    this.Label16.Text = "Posting Memo:";
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeSingleOffice_PostDate.Appearance = (AppearanceBase) appearance2;
    appearance3.AlphaLevel = (short) 14;
    appearance3.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance3.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance3.BackColorAlpha = (Alpha) 2;
    appearance3.BackGradientAlignment = (GradientAlignment) 4;
    appearance3.BackGradientStyle = (GradientStyle) 5;
    appearance3.BorderAlpha = (Alpha) 1;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    appearance3.ForeColor = Color.FromArgb(49, 85, 153);
    appearance3.ForegroundAlpha = (Alpha) 2;
    this.dateTimeSingleOffice_PostDate.ButtonAppearance = (AppearanceBase) appearance3;
    ((Control) this.dateTimeSingleOffice_PostDate).Location = new Point(120, 97);
    this.dateTimeSingleOffice_PostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeSingleOffice_PostDate).Name = "dateTimeSingleOffice_PostDate";
    ((Control) this.dateTimeSingleOffice_PostDate).Size = new Size(100, 20);
    ((Control) this.dateTimeSingleOffice_PostDate).TabIndex = 9;
    ((UltraControlBase) this.dateTimeSingleOffice_PostDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeSingleOffice_PostDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.Location = new Point(7, 98);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(58, 13);
    this.Label15.TabIndex = 8;
    this.Label15.Text = "Post Date:";
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance4.Image"));
    appearance4.ImageHAlign = (HAlign) 1;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSingleOffice_Save).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonSingleOffice_Save).Location = new Point(194, 318);
    ((Control) this.buttonSingleOffice_Save).Name = "buttonSingleOffice_Save";
    ((Control) this.buttonSingleOffice_Save).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonSingleOffice_Save).TabIndex = 16 /*0x10*/;
    ((ControlBase) this.buttonSingleOffice_Save).Text = "Save";
    this.buttonSingleOffice_Save.UseOSThemes = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance5.Image"));
    appearance5.ImageHAlign = (HAlign) 1;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSingleOffice_Cancel).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonSingleOffice_Cancel).Location = new Point(284, 318);
    ((Control) this.buttonSingleOffice_Cancel).Name = "buttonSingleOffice_Cancel";
    ((Control) this.buttonSingleOffice_Cancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonSingleOffice_Cancel).TabIndex = 17;
    ((ControlBase) this.buttonSingleOffice_Cancel).Text = "Cancel";
    this.buttonSingleOffice_Cancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(7, 73);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(92, 13);
    this.Label5.TabIndex = 6;
    this.Label5.Text = "Transfer Amount:";
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.maskSingleOffice_Amount.Appearance = (AppearanceBase) appearance6;
    this.maskSingleOffice_Amount.EditAs = (EditAsType) 2;
    this.maskSingleOffice_Amount.InputMask = "{LOC}$ n,nnn,nnn,nnn.nn";
    ((Control) this.maskSingleOffice_Amount).Location = new Point(120, 73);
    this.maskSingleOffice_Amount.MGAStyle = MGAStyles.Blue;
    ((Control) this.maskSingleOffice_Amount).Name = "maskSingleOffice_Amount";
    ((Control) this.maskSingleOffice_Amount).Size = new Size(100, 21);
    ((Control) this.maskSingleOffice_Amount).TabIndex = 7;
    this.maskSingleOffice_Amount.Text = "$ ";
    ((UltraControlBase) this.maskSingleOffice_Amount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskSingleOffice_Amount).UseOsThemes = (DefaultableBoolean) 2;
    this.comboSingleOffice_DestinationAccount.BorderStyle = (UIElementBorderStyle) 4;
    this.comboSingleOffice_DestinationAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSingleOffice_DestinationAccount).Location = new Point(120, 49);
    this.comboSingleOffice_DestinationAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboSingleOffice_DestinationAccount).Name = "comboSingleOffice_DestinationAccount";
    ((Control) this.comboSingleOffice_DestinationAccount).Size = new Size(244, 21);
    ((Control) this.comboSingleOffice_DestinationAccount).TabIndex = 5;
    ((UltraControlBase) this.comboSingleOffice_DestinationAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboSingleOffice_DestinationAccount).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(7, 49);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(107, 13);
    this.Label4.TabIndex = 4;
    this.Label4.Text = "Destination Account:";
    this.comboSingleOffice_SourceBank.BorderStyle = (UIElementBorderStyle) 4;
    this.comboSingleOffice_SourceBank.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSingleOffice_SourceBank).Location = new Point(120, 26);
    this.comboSingleOffice_SourceBank.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboSingleOffice_SourceBank).Name = "comboSingleOffice_SourceBank";
    ((Control) this.comboSingleOffice_SourceBank).Size = new Size(244, 21);
    ((Control) this.comboSingleOffice_SourceBank).TabIndex = 3;
    ((UltraControlBase) this.comboSingleOffice_SourceBank).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboSingleOffice_SourceBank).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(7, 26);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(86, 13);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "Source Account:";
    this.panelMultipleOffices.BackColor = Color.Transparent;
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_DestinationCreditCostCenter);
    this.panelMultipleOffices.Controls.Add((Control) this.Label23);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_DestinationDebitCostCenter);
    this.panelMultipleOffices.Controls.Add((Control) this.Label24);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_SourceCreditCostCenter);
    this.panelMultipleOffices.Controls.Add((Control) this.Label21);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_SourceDebitCostCenter);
    this.panelMultipleOffices.Controls.Add((Control) this.Label22);
    this.panelMultipleOffices.Controls.Add((Control) this.textMultiOffice_TransactionComment);
    this.panelMultipleOffices.Controls.Add((Control) this.Label17);
    this.panelMultipleOffices.Controls.Add((Control) this.dateTimeMultiOffice_PostDate);
    this.panelMultipleOffices.Controls.Add((Control) this.Label18);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_DestinationOffsetAccount);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_SourceOffsetAccount);
    this.panelMultipleOffices.Controls.Add((Control) this.Label14);
    this.panelMultipleOffices.Controls.Add((Control) this.Label13);
    this.panelMultipleOffices.Controls.Add((Control) this.Label12);
    this.panelMultipleOffices.Controls.Add((Control) this.Label11);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_DestinationOfficeLocation);
    this.panelMultipleOffices.Controls.Add((Control) this.Label10);
    this.panelMultipleOffices.Controls.Add((Control) this.buttonMultiOffice_Save);
    this.panelMultipleOffices.Controls.Add((Control) this.buttonMultiOffice_Cancel);
    this.panelMultipleOffices.Controls.Add((Control) this.Label6);
    this.panelMultipleOffices.Controls.Add((Control) this.maskMultiOffice_Amount);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_DestinationBank);
    this.panelMultipleOffices.Controls.Add((Control) this.Label7);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_SourceBank);
    this.panelMultipleOffices.Controls.Add((Control) this.Label8);
    this.panelMultipleOffices.Controls.Add((Control) this.comboMultiOffice_SourceOfficeLocation);
    this.panelMultipleOffices.Controls.Add((Control) this.Label9);
    this.panelMultipleOffices.Location = new Point(5, 51);
    this.panelMultipleOffices.Name = "panelMultipleOffices";
    this.panelMultipleOffices.Size = new Size(402, 503);
    this.panelMultipleOffices.TabIndex = 3;
    this.panelMultipleOffices.Visible = false;
    this.comboMultiOffice_DestinationCreditCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_DestinationCreditCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_DestinationCreditCostCenter).Location = new Point(152, 234);
    this.comboMultiOffice_DestinationCreditCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_DestinationCreditCostCenter).Name = "comboMultiOffice_DestinationCreditCostCenter";
    ((Control) this.comboMultiOffice_DestinationCreditCostCenter).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_DestinationCreditCostCenter).TabIndex = 20;
    ((UltraControlBase) this.comboMultiOffice_DestinationCreditCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_DestinationCreditCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label23.AutoSize = true;
    this.Label23.Location = new Point(8, 234);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(101, 13);
    this.Label23.TabIndex = 19;
    this.Label23.Text = "Credit Cost Center:";
    this.comboMultiOffice_DestinationDebitCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_DestinationDebitCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_DestinationDebitCostCenter).Location = new Point(152, 211);
    this.comboMultiOffice_DestinationDebitCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_DestinationDebitCostCenter).Name = "comboMultiOffice_DestinationDebitCostCenter";
    ((Control) this.comboMultiOffice_DestinationDebitCostCenter).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_DestinationDebitCostCenter).TabIndex = 18;
    ((UltraControlBase) this.comboMultiOffice_DestinationDebitCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_DestinationDebitCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label24.AutoSize = true;
    this.Label24.Location = new Point(8, 211);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(97, 13);
    this.Label24.TabIndex = 17;
    this.Label24.Text = "Debit Cost Center:";
    this.comboMultiOffice_SourceCreditCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_SourceCreditCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_SourceCreditCostCenter).Location = new Point(151, 96 /*0x60*/);
    this.comboMultiOffice_SourceCreditCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_SourceCreditCostCenter).Name = "comboMultiOffice_SourceCreditCostCenter";
    ((Control) this.comboMultiOffice_SourceCreditCostCenter).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_SourceCreditCostCenter).TabIndex = 9;
    ((UltraControlBase) this.comboMultiOffice_SourceCreditCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_SourceCreditCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label21.AutoSize = true;
    this.Label21.Location = new Point(7, 96 /*0x60*/);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(101, 13);
    this.Label21.TabIndex = 8;
    this.Label21.Text = "Credit Cost Center:";
    this.comboMultiOffice_SourceDebitCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_SourceDebitCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_SourceDebitCostCenter).Location = new Point(151, 73);
    this.comboMultiOffice_SourceDebitCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_SourceDebitCostCenter).Name = "comboMultiOffice_SourceDebitCostCenter";
    ((Control) this.comboMultiOffice_SourceDebitCostCenter).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_SourceDebitCostCenter).TabIndex = 7;
    ((UltraControlBase) this.comboMultiOffice_SourceDebitCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_SourceDebitCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.AutoSize = true;
    this.Label22.Location = new Point(7, 73);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(97, 13);
    this.Label22.TabIndex = 6;
    this.Label22.Text = "Debit Cost Center:";
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textMultiOffice_TransactionComment).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.textMultiOffice_TransactionComment).BackColor = Color.White;
    ((Control) this.textMultiOffice_TransactionComment).Location = new Point(152, 320);
    ((TextEditorControlBase) this.textMultiOffice_TransactionComment).MaxLength = 2500;
    this.textMultiOffice_TransactionComment.MGAStyle = MGAStyles.Blue;
    this.textMultiOffice_TransactionComment.Multiline = true;
    ((Control) this.textMultiOffice_TransactionComment).Name = "textMultiOffice_TransactionComment";
    ((Control) this.textMultiOffice_TransactionComment).Size = new Size(244, 145);
    ((Control) this.textMultiOffice_TransactionComment).TabIndex = 27;
    ((UltraControlBase) this.textMultiOffice_TransactionComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textMultiOffice_TransactionComment).UseOsThemes = (DefaultableBoolean) 2;
    this.Label17.AutoSize = true;
    this.Label17.Location = new Point(8, 320);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(77, 13);
    this.Label17.TabIndex = 26;
    this.Label17.Text = "Posting Memo:";
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeMultiOffice_PostDate.Appearance = (AppearanceBase) appearance8;
    appearance9.AlphaLevel = (short) 14;
    appearance9.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance9.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance9.BackColorAlpha = (Alpha) 2;
    appearance9.BackGradientAlignment = (GradientAlignment) 4;
    appearance9.BackGradientStyle = (GradientStyle) 5;
    appearance9.BorderAlpha = (Alpha) 1;
    appearance9.BorderColor = Color.FromArgb(78, 122, 171);
    appearance9.ForeColor = Color.FromArgb(49, 85, 153);
    appearance9.ForegroundAlpha = (Alpha) 2;
    this.dateTimeMultiOffice_PostDate.ButtonAppearance = (AppearanceBase) appearance9;
    ((Control) this.dateTimeMultiOffice_PostDate).Location = new Point(151, 297);
    this.dateTimeMultiOffice_PostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeMultiOffice_PostDate).Name = "dateTimeMultiOffice_PostDate";
    ((Control) this.dateTimeMultiOffice_PostDate).Size = new Size(100, 20);
    ((Control) this.dateTimeMultiOffice_PostDate).TabIndex = 25;
    ((UltraControlBase) this.dateTimeMultiOffice_PostDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeMultiOffice_PostDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label18.AutoSize = true;
    this.Label18.Location = new Point(8, 297);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(58, 13);
    this.Label18.TabIndex = 24;
    this.Label18.Text = "Post Date:";
    this.comboMultiOffice_DestinationOffsetAccount.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Appearance = (AppearanceBase) appearance10;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance11.BackColor = SystemColors.ActiveBorder;
    appearance11.BackColor2 = SystemColors.ControlDark;
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance11;
    appearance12.ForeColor = SystemColors.GrayText;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance12;
    ((SpecialBoxBase) this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance13.BackColor = SystemColors.ControlLightLight;
    appearance13.BackColor2 = SystemColors.Control;
    appearance13.BackGradientStyle = (GradientStyle) 3;
    appearance13.ForeColor = SystemColors.GrayText;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance13;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.MaxColScrollRegions = 1;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.MaxRowScrollRegions = 1;
    appearance14.BackColor = SystemColors.Window;
    appearance14.ForeColor = SystemColors.ControlText;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = SystemColors.Highlight;
    appearance15.ForeColor = SystemColors.HighlightText;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance16.BackColor = SystemColors.Window;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance16;
    appearance17.BorderColor = Color.Silver;
    appearance17.TextTrimming = (TextTrimming) 3;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance17;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.CellPadding = 0;
    appearance18.BackColor = SystemColors.Control;
    appearance18.BackColor2 = SystemColors.ControlDark;
    appearance18.BackGradientAlignment = (GradientAlignment) 1;
    appearance18.BackGradientStyle = (GradientStyle) 3;
    appearance18.BorderColor = SystemColors.Window;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance20.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance20.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = SystemColors.Window;
    appearance21.BorderColor = Color.White;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance22.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance22.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance22.ForeColor = Color.Black;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = SystemColors.ControlLight;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance23;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboMultiOffice_DestinationOffsetAccount.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    this.comboMultiOffice_DestinationOffsetAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_DestinationOffsetAccount).Location = new Point(152, 187);
    this.comboMultiOffice_DestinationOffsetAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_DestinationOffsetAccount).Name = "comboMultiOffice_DestinationOffsetAccount";
    ((Control) this.comboMultiOffice_DestinationOffsetAccount).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_DestinationOffsetAccount).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.comboMultiOffice_DestinationOffsetAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_DestinationOffsetAccount).UseOsThemes = (DefaultableBoolean) 2;
    this.comboMultiOffice_SourceOffsetAccount.BorderStyle = (UIElementBorderStyle) 4;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Appearance = (AppearanceBase) appearance24;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance25.BackColor = SystemColors.ActiveBorder;
    appearance25.BackColor2 = SystemColors.ControlDark;
    appearance25.BackGradientStyle = (GradientStyle) 2;
    appearance25.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance25;
    appearance26.ForeColor = SystemColors.GrayText;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance26;
    ((SpecialBoxBase) this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance27.BackColor = SystemColors.ControlLightLight;
    appearance27.BackColor2 = SystemColors.Control;
    appearance27.BackGradientStyle = (GradientStyle) 3;
    appearance27.ForeColor = SystemColors.GrayText;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance27;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.MaxColScrollRegions = 1;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.MaxRowScrollRegions = 1;
    appearance28.BackColor = SystemColors.Window;
    appearance28.ForeColor = SystemColors.ControlText;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance28;
    appearance29.BackColor = SystemColors.Highlight;
    appearance29.ForeColor = SystemColors.HighlightText;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance29;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance30.BackColor = SystemColors.Window;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance30;
    appearance31.BorderColor = Color.Silver;
    appearance31.TextTrimming = (TextTrimming) 3;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance31;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.CellPadding = 0;
    appearance32.BackColor = SystemColors.Control;
    appearance32.BackColor2 = SystemColors.ControlDark;
    appearance32.BackGradientAlignment = (GradientAlignment) 1;
    appearance32.BackGradientStyle = (GradientStyle) 3;
    appearance32.BorderColor = SystemColors.Window;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Left";
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance33;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance34.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance34.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance34;
    appearance35.BackColor = SystemColors.Window;
    appearance35.BorderColor = Color.White;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance35;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance36.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance36.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance36.ForeColor = Color.Black;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance36;
    appearance37.BackColor = SystemColors.ControlLight;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance37;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboMultiOffice_SourceOffsetAccount.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    this.comboMultiOffice_SourceOffsetAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_SourceOffsetAccount).Location = new Point(151, 50);
    this.comboMultiOffice_SourceOffsetAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_SourceOffsetAccount).Name = "comboMultiOffice_SourceOffsetAccount";
    ((Control) this.comboMultiOffice_SourceOffsetAccount).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_SourceOffsetAccount).TabIndex = 5;
    ((UltraControlBase) this.comboMultiOffice_SourceOffsetAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_SourceOffsetAccount).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.BackColor = Color.DimGray;
    this.Label14.Location = new Point(25, 128 /*0x80*/);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(356, 1);
    this.Label14.TabIndex = 10;
    this.Label13.BackColor = Color.DimGray;
    this.Label13.Location = new Point(25, 263);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(356, 1);
    this.Label13.TabIndex = 21;
    this.Label12.AutoSize = true;
    this.Label12.Location = new Point(8, 187);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(141, 13);
    this.Label12.TabIndex = 15;
    this.Label12.Text = "Destination Offset Account:";
    this.Label11.AutoSize = true;
    this.Label11.Location = new Point(7, 50);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(120, 13);
    this.Label11.TabIndex = 4;
    this.Label11.Text = "Source Offset Account:";
    this.comboMultiOffice_DestinationOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_DestinationOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_DestinationOfficeLocation).Location = new Point(152, 139);
    this.comboMultiOffice_DestinationOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_DestinationOfficeLocation).Name = "comboMultiOffice_DestinationOfficeLocation";
    ((Control) this.comboMultiOffice_DestinationOfficeLocation).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_DestinationOfficeLocation).TabIndex = 12;
    ((UltraControlBase) this.comboMultiOffice_DestinationOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_DestinationOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.Location = new Point(8, 139);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(83, 13);
    this.Label10.TabIndex = 11;
    this.Label10.Text = "Office Location:";
    appearance38.BackColor = Color.FromArgb(248, 248, 248);
    appearance38.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance38.BackGradientStyle = (GradientStyle) 2;
    appearance38.BorderColor = Color.DarkGray;
    appearance38.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance38.Image"));
    appearance38.ImageHAlign = (HAlign) 1;
    appearance38.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonMultiOffice_Save).Appearance = (AppearanceBase) appearance38;
    ((Control) this.buttonMultiOffice_Save).Location = new Point(230, 471);
    ((Control) this.buttonMultiOffice_Save).Name = "buttonMultiOffice_Save";
    ((Control) this.buttonMultiOffice_Save).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonMultiOffice_Save).TabIndex = 28;
    ((ControlBase) this.buttonMultiOffice_Save).Text = "Save";
    this.buttonMultiOffice_Save.UseOSThemes = (DefaultableBoolean) 2;
    appearance39.BackColor = Color.FromArgb(248, 248, 248);
    appearance39.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance39.BackGradientStyle = (GradientStyle) 2;
    appearance39.BorderColor = Color.DarkGray;
    appearance39.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image"));
    appearance39.ImageHAlign = (HAlign) 1;
    appearance39.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonMultiOffice_Cancel).Appearance = (AppearanceBase) appearance39;
    ((Control) this.buttonMultiOffice_Cancel).Location = new Point(316, 471);
    ((Control) this.buttonMultiOffice_Cancel).Name = "buttonMultiOffice_Cancel";
    ((Control) this.buttonMultiOffice_Cancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonMultiOffice_Cancel).TabIndex = 29;
    ((ControlBase) this.buttonMultiOffice_Cancel).Text = "Cancel";
    this.buttonMultiOffice_Cancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(8, 273);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(92, 13);
    this.Label6.TabIndex = 22;
    this.Label6.Text = "Transfer Amount:";
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.maskMultiOffice_Amount.Appearance = (AppearanceBase) appearance40;
    this.maskMultiOffice_Amount.EditAs = (EditAsType) 2;
    this.maskMultiOffice_Amount.InputMask = "{LOC}$ n,nnn,nnn,nnn.nn";
    ((Control) this.maskMultiOffice_Amount).Location = new Point(152, 273);
    this.maskMultiOffice_Amount.MGAStyle = MGAStyles.Blue;
    ((Control) this.maskMultiOffice_Amount).Name = "maskMultiOffice_Amount";
    ((Control) this.maskMultiOffice_Amount).Size = new Size(100, 21);
    ((Control) this.maskMultiOffice_Amount).TabIndex = 23;
    this.maskMultiOffice_Amount.Text = "$ ";
    ((UltraControlBase) this.maskMultiOffice_Amount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskMultiOffice_Amount).UseOsThemes = (DefaultableBoolean) 2;
    this.comboMultiOffice_DestinationBank.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_DestinationBank.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_DestinationBank).Location = new Point(152, 163);
    this.comboMultiOffice_DestinationBank.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_DestinationBank).Name = "comboMultiOffice_DestinationBank";
    ((Control) this.comboMultiOffice_DestinationBank).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_DestinationBank).TabIndex = 14;
    ((UltraControlBase) this.comboMultiOffice_DestinationBank).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_DestinationBank).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(8, 163);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(107, 13);
    this.Label7.TabIndex = 13;
    this.Label7.Text = "Destination Account:";
    this.comboMultiOffice_SourceBank.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_SourceBank.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_SourceBank).Location = new Point(151, 27);
    this.comboMultiOffice_SourceBank.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_SourceBank).Name = "comboMultiOffice_SourceBank";
    ((Control) this.comboMultiOffice_SourceBank).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_SourceBank).TabIndex = 3;
    ((UltraControlBase) this.comboMultiOffice_SourceBank).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_SourceBank).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(7, 27);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(86, 13);
    this.Label8.TabIndex = 2;
    this.Label8.Text = "Source Account:";
    this.comboMultiOffice_SourceOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMultiOffice_SourceOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMultiOffice_SourceOfficeLocation).Location = new Point(151, 4);
    this.comboMultiOffice_SourceOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMultiOffice_SourceOfficeLocation).Name = "comboMultiOffice_SourceOfficeLocation";
    ((Control) this.comboMultiOffice_SourceOfficeLocation).Size = new Size(244, 21);
    ((Control) this.comboMultiOffice_SourceOfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.comboMultiOffice_SourceOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMultiOffice_SourceOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.Location = new Point(7, 4);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(83, 13);
    this.Label9.TabIndex = 0;
    this.Label9.Text = "Office Location:";
    appearance41.BorderColor = Color.Gray;
    appearance41.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkSingleOffice).Appearance = (AppearanceBase) appearance41;
    ((UltraToggleEditorBase) this.checkSingleOffice).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkSingleOffice).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkSingleOffice).Checked = true;
    ((UltraToggleEditorBase) this.checkSingleOffice).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.checkSingleOffice).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2010CheckBoxGlyphInfo;
    ((Control) this.checkSingleOffice).Location = new Point(15, 31 /*0x1F*/);
    ((Control) this.checkSingleOffice).Name = "checkSingleOffice";
    ((Control) this.checkSingleOffice).Size = new Size(120, 20);
    ((Control) this.checkSingleOffice).TabIndex = 1;
    ((UltraToggleEditorBase) this.checkSingleOffice).Text = "Single Office";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(376, 401);
    this.Controls.Add((Control) this.checkSingleOffice);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.panelSingleOffice);
    this.Controls.Add((Control) this.panelMultipleOffices);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormAdvancedBankTransfer);
    this.Text = "Bank Transfer";
    ((ISupportInitialize) this.comboSingleOffice_OfficeLocation).EndInit();
    this.panelSingleOffice.ResumeLayout(false);
    this.panelSingleOffice.PerformLayout();
    ((ISupportInitialize) this.comboSingleOffice_CreditCostCenter).EndInit();
    ((ISupportInitialize) this.comboSingleOffice_DebitCostCenter).EndInit();
    ((ISupportInitialize) this.textSingleOffice_TransactionComments).EndInit();
    ((ISupportInitialize) this.dateTimeSingleOffice_PostDate).EndInit();
    ((ISupportInitialize) this.buttonSingleOffice_Save).EndInit();
    ((ISupportInitialize) this.buttonSingleOffice_Cancel).EndInit();
    ((ISupportInitialize) this.maskSingleOffice_Amount).EndInit();
    ((ISupportInitialize) this.comboSingleOffice_DestinationAccount).EndInit();
    ((ISupportInitialize) this.comboSingleOffice_SourceBank).EndInit();
    this.panelMultipleOffices.ResumeLayout(false);
    this.panelMultipleOffices.PerformLayout();
    ((ISupportInitialize) this.comboMultiOffice_DestinationCreditCostCenter).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_DestinationDebitCostCenter).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceCreditCostCenter).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceDebitCostCenter).EndInit();
    ((ISupportInitialize) this.textMultiOffice_TransactionComment).EndInit();
    ((ISupportInitialize) this.dateTimeMultiOffice_PostDate).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_DestinationOffsetAccount).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceOffsetAccount).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_DestinationOfficeLocation).EndInit();
    ((ISupportInitialize) this.buttonMultiOffice_Save).EndInit();
    ((ISupportInitialize) this.buttonMultiOffice_Cancel).EndInit();
    ((ISupportInitialize) this.maskMultiOffice_Amount).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_DestinationBank).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceBank).EndInit();
    ((ISupportInitialize) this.comboMultiOffice_SourceOfficeLocation).EndInit();
    ((ISupportInitialize) this.checkSingleOffice).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboSingleOffice_OfficeLocation
  {
    get => this._comboSingleOffice_OfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboSingleOffice_OfficeLocation_RowSelected);
      MGASimpleComboBox officeOfficeLocation1 = this._comboSingleOffice_OfficeLocation;
      if (officeOfficeLocation1 != null)
        officeOfficeLocation1.RowSelected -= selectedEventHandler;
      this._comboSingleOffice_OfficeLocation = value;
      MGASimpleComboBox officeOfficeLocation2 = this._comboSingleOffice_OfficeLocation;
      if (officeOfficeLocation2 == null)
        return;
      officeOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelSingleOffice")]
  internal virtual Panel panelSingleOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("maskSingleOffice_Amount")]
  internal virtual MGAMaskedEdit maskSingleOffice_Amount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboSingleOffice_DestinationAccount")]
  internal virtual MGASimpleComboBox comboSingleOffice_DestinationAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboSingleOffice_SourceBank")]
  internal virtual MGASimpleComboBox comboSingleOffice_SourceBank { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonSingleOffice_Save
  {
    get => this._buttonSingleOffice_Save;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSingleOffice_Save_Click);
      MGAButton singleOfficeSave1 = this._buttonSingleOffice_Save;
      if (singleOfficeSave1 != null)
        ((Control) singleOfficeSave1).Click -= eventHandler;
      this._buttonSingleOffice_Save = value;
      MGAButton singleOfficeSave2 = this._buttonSingleOffice_Save;
      if (singleOfficeSave2 == null)
        return;
      ((Control) singleOfficeSave2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonSingleOffice_Cancel
  {
    get => this._buttonSingleOffice_Cancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelButtonClick_Click);
      MGAButton singleOfficeCancel1 = this._buttonSingleOffice_Cancel;
      if (singleOfficeCancel1 != null)
        ((Control) singleOfficeCancel1).Click -= eventHandler;
      this._buttonSingleOffice_Cancel = value;
      MGAButton singleOfficeCancel2 = this._buttonSingleOffice_Cancel;
      if (singleOfficeCancel2 == null)
        return;
      ((Control) singleOfficeCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelMultipleOffices")]
  internal virtual Panel panelMultipleOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboMultiOffice_DestinationOfficeLocation
  {
    get => this._comboMultiOffice_DestinationOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboMultiOffice_DestinationOfficeLocation_RowSelected);
      MGASimpleComboBox destinationOfficeLocation1 = this._comboMultiOffice_DestinationOfficeLocation;
      if (destinationOfficeLocation1 != null)
        destinationOfficeLocation1.RowSelected -= selectedEventHandler;
      this._comboMultiOffice_DestinationOfficeLocation = value;
      MGASimpleComboBox destinationOfficeLocation2 = this._comboMultiOffice_DestinationOfficeLocation;
      if (destinationOfficeLocation2 == null)
        return;
      destinationOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonMultiOffice_Save
  {
    get => this._buttonMultiOffice_Save;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonMultiOffice_Save_Click);
      MGAButton buttonMultiOfficeSave1 = this._buttonMultiOffice_Save;
      if (buttonMultiOfficeSave1 != null)
        ((Control) buttonMultiOfficeSave1).Click -= eventHandler;
      this._buttonMultiOffice_Save = value;
      MGAButton buttonMultiOfficeSave2 = this._buttonMultiOffice_Save;
      if (buttonMultiOfficeSave2 == null)
        return;
      ((Control) buttonMultiOfficeSave2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonMultiOffice_Cancel
  {
    get => this._buttonMultiOffice_Cancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelButtonClick_Click);
      MGAButton multiOfficeCancel1 = this._buttonMultiOffice_Cancel;
      if (multiOfficeCancel1 != null)
        ((Control) multiOfficeCancel1).Click -= eventHandler;
      this._buttonMultiOffice_Cancel = value;
      MGAButton multiOfficeCancel2 = this._buttonMultiOffice_Cancel;
      if (multiOfficeCancel2 == null)
        return;
      ((Control) multiOfficeCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("maskMultiOffice_Amount")]
  internal virtual MGAMaskedEdit maskMultiOffice_Amount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboMultiOffice_DestinationBank")]
  internal virtual MGASimpleComboBox comboMultiOffice_DestinationBank { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboMultiOffice_SourceBank")]
  internal virtual MGASimpleComboBox comboMultiOffice_SourceBank { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboMultiOffice_SourceOfficeLocation
  {
    get => this._comboMultiOffice_SourceOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboMultiOffice_SourceOfficeLocation_RowSelected);
      MGASimpleComboBox sourceOfficeLocation1 = this._comboMultiOffice_SourceOfficeLocation;
      if (sourceOfficeLocation1 != null)
        sourceOfficeLocation1.RowSelected -= selectedEventHandler;
      this._comboMultiOffice_SourceOfficeLocation = value;
      MGASimpleComboBox sourceOfficeLocation2 = this._comboMultiOffice_SourceOfficeLocation;
      if (sourceOfficeLocation2 == null)
        return;
      sourceOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox checkSingleOffice
  {
    get => this._checkSingleOffice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.checkSingleOffice_CheckedChanged);
      MGACheckBox checkSingleOffice1 = this._checkSingleOffice;
      if (checkSingleOffice1 != null)
        ((UltraToggleEditorBase) checkSingleOffice1).CheckedChanged -= eventHandler;
      this._checkSingleOffice = value;
      MGACheckBox checkSingleOffice2 = this._checkSingleOffice;
      if (checkSingleOffice2 == null)
        return;
      ((UltraToggleEditorBase) checkSingleOffice2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboMultiOffice_DestinationOffsetAccount")]
  internal virtual MGAComboBox comboMultiOffice_DestinationOffsetAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboMultiOffice_SourceOffsetAccount")]
  internal virtual MGAComboBox comboMultiOffice_SourceOffsetAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateTimeSingleOffice_PostDate")]
  internal virtual MGADateTimePicker dateTimeSingleOffice_PostDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textSingleOffice_TransactionComments")]
  internal virtual MGATextBox textSingleOffice_TransactionComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textMultiOffice_TransactionComment")]
  internal virtual MGATextBox textMultiOffice_TransactionComment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateTimeMultiOffice_PostDate")]
  internal virtual MGADateTimePicker dateTimeMultiOffice_PostDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboSingleOffice_CreditCostCenter")]
  internal virtual MGASimpleComboBox comboSingleOffice_CreditCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboSingleOffice_DebitCostCenter")]
  internal virtual MGASimpleComboBox comboSingleOffice_DebitCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboMultiOffice_DestinationCreditCostCenter")]
  internal virtual MGASimpleComboBox comboMultiOffice_DestinationCreditCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboMultiOffice_DestinationDebitCostCenter")]
  internal virtual MGASimpleComboBox comboMultiOffice_DestinationDebitCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboMultiOffice_SourceCreditCostCenter")]
  internal virtual MGASimpleComboBox comboMultiOffice_SourceCreditCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboMultiOffice_SourceDebitCostCenter")]
  internal virtual MGASimpleComboBox comboMultiOffice_SourceDebitCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormAdvancedBankTransfer()
  {
    this.Load += new EventHandler(this.FormAdvancedBankTransfer_Load);
    this.LoadBankAccount_ProcedureName = "spFin_GetBankAccounts";
    this.LoadGLList_ProcedureName = "spFin_GetGLAccountList";
    this.InitializeComponent();
  }

  private void checkSingleOffice_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkSingleOffice).Checked)
      this.ToggleSingleOffice(true);
    else
      this.ToggleSingleOffice(false);
  }

  private void FormAdvancedBankTransfer_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.ToggleSingleOffice(true);
    this.LoadOfficeLocationDropDowns();
  }

  private void ToggleSingleOffice(bool value)
  {
    if (value)
    {
      this.Size = new Size(394, 440);
      this.panelSingleOffice.Visible = true;
      this.panelMultipleOffices.Visible = false;
    }
    else
    {
      this.Size = new Size(424, 590);
      this.panelSingleOffice.Visible = false;
      this.panelMultipleOffices.Visible = true;
    }
  }

  private void LoadOfficeLocationDropDowns()
  {
    ((UltraGridBase) this.comboSingleOffice_OfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboSingleOffice_OfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboSingleOffice_OfficeLocation).ValueMember = "ID";
    if (((UltraGridBase) this.comboSingleOffice_OfficeLocation).Rows.Count == 1)
      this.comboSingleOffice_OfficeLocation.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.comboSingleOffice_OfficeLocation).Rows[0].Cells["ID"].Value);
    ((UltraGridBase) this.comboMultiOffice_SourceOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboMultiOffice_SourceOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboMultiOffice_SourceOfficeLocation).ValueMember = "ID";
    if (((UltraGridBase) this.comboMultiOffice_SourceOfficeLocation).Rows.Count == 1)
      this.comboMultiOffice_SourceOfficeLocation.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.comboMultiOffice_SourceOfficeLocation).Rows[0].Cells["ID"].Value);
    ((UltraGridBase) this.comboMultiOffice_DestinationOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboMultiOffice_DestinationOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboMultiOffice_DestinationOfficeLocation).ValueMember = "ID";
    if (((UltraGridBase) this.comboMultiOffice_DestinationOfficeLocation).Rows.Count != 1)
      return;
    this.comboMultiOffice_DestinationOfficeLocation.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.comboMultiOffice_DestinationOfficeLocation).Rows[0].Cells["ID"].Value);
  }

  private void comboSingleOffice_OfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboSingleOffice_OfficeLocation).SelectedRow == null)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      MGASimpleComboBox officeSourceBank = this.comboSingleOffice_SourceBank;
      this.LoadBankAccountDropDown(ref officeSourceBank, Conversions.ToInteger(this.comboSingleOffice_OfficeLocation.Value));
      this.comboSingleOffice_SourceBank = officeSourceBank;
      MGASimpleComboBox destinationAccount = this.comboSingleOffice_DestinationAccount;
      this.LoadBankAccountDropDown(ref destinationAccount, Conversions.ToInteger(this.comboSingleOffice_OfficeLocation.Value));
      this.comboSingleOffice_DestinationAccount = destinationAccount;
      MGASimpleComboBox officeDebitCostCenter = this.comboSingleOffice_DebitCostCenter;
      this.LoadCostCenters(ref officeDebitCostCenter, Conversions.ToInteger(this.comboSingleOffice_OfficeLocation.Value));
      this.comboSingleOffice_DebitCostCenter = officeDebitCostCenter;
      MGASimpleComboBox creditCostCenter = this.comboSingleOffice_CreditCostCenter;
      this.LoadCostCenters(ref creditCostCenter, Conversions.ToInteger(this.comboSingleOffice_OfficeLocation.Value));
      this.comboSingleOffice_CreditCostCenter = creditCostCenter;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void LoadBankAccountDropDown(ref MGASimpleComboBox combo, int glCompanyId)
  {
    ((UltraGridBase) combo).DataSource = (object) Utility.GetBankAccounts(this.LoadBankAccount_ProcedureName, glCompanyId);
    ((UltraDropDownBase) combo).DisplayMember = "bankname";
    ((UltraDropDownBase) combo).ValueMember = "glacctid";
    if (((UltraGridBase) combo).Rows.Count != 1)
      return;
    combo.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) combo).Rows[0].Cells["glacctid"].Value);
  }

  private void comboMultiOffice_SourceOfficeLocation_RowSelected(
    object sender,
    RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboMultiOffice_SourceOfficeLocation).SelectedRow == null)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      MGASimpleComboBox officeSourceBank = this.comboMultiOffice_SourceBank;
      this.LoadBankAccountDropDown(ref officeSourceBank, Conversions.ToInteger(this.comboMultiOffice_SourceOfficeLocation.Value));
      this.comboMultiOffice_SourceBank = officeSourceBank;
      MGAComboBox sourceOffsetAccount1 = this.comboMultiOffice_SourceOffsetAccount;
      this.LoadGLOffsetAccounts(ref sourceOffsetAccount1, Conversions.ToInteger(this.comboMultiOffice_SourceOfficeLocation.Value));
      this.comboMultiOffice_SourceOffsetAccount = sourceOffsetAccount1;
      MGAComboBox sourceOffsetAccount2 = this.comboMultiOffice_SourceOffsetAccount;
      this.FormatOffsetDropDown(ref sourceOffsetAccount2);
      this.comboMultiOffice_SourceOffsetAccount = sourceOffsetAccount2;
      MGASimpleComboBox sourceDebitCostCenter = this.comboMultiOffice_SourceDebitCostCenter;
      this.LoadCostCenters(ref sourceDebitCostCenter, Conversions.ToInteger(this.comboMultiOffice_SourceOfficeLocation.Value));
      this.comboMultiOffice_SourceDebitCostCenter = sourceDebitCostCenter;
      MGASimpleComboBox creditCostCenter = this.comboMultiOffice_SourceCreditCostCenter;
      this.LoadCostCenters(ref creditCostCenter, Conversions.ToInteger(this.comboMultiOffice_SourceOfficeLocation.Value));
      this.comboMultiOffice_SourceCreditCostCenter = creditCostCenter;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void comboMultiOffice_DestinationOfficeLocation_RowSelected(
    object sender,
    RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboMultiOffice_DestinationOfficeLocation).SelectedRow == null)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      MGASimpleComboBox officeDestinationBank = this.comboMultiOffice_DestinationBank;
      this.LoadBankAccountDropDown(ref officeDestinationBank, Conversions.ToInteger(this.comboMultiOffice_DestinationOfficeLocation.Value));
      this.comboMultiOffice_DestinationBank = officeDestinationBank;
      MGAComboBox destinationOffsetAccount1 = this.comboMultiOffice_DestinationOffsetAccount;
      this.LoadGLOffsetAccounts(ref destinationOffsetAccount1, Conversions.ToInteger(this.comboMultiOffice_DestinationOfficeLocation.Value));
      this.comboMultiOffice_DestinationOffsetAccount = destinationOffsetAccount1;
      MGAComboBox destinationOffsetAccount2 = this.comboMultiOffice_DestinationOffsetAccount;
      this.FormatOffsetDropDown(ref destinationOffsetAccount2);
      this.comboMultiOffice_DestinationOffsetAccount = destinationOffsetAccount2;
      MGASimpleComboBox destinationDebitCostCenter = this.comboMultiOffice_DestinationDebitCostCenter;
      this.LoadCostCenters(ref destinationDebitCostCenter, Conversions.ToInteger(this.comboMultiOffice_DestinationOfficeLocation.Value));
      this.comboMultiOffice_DestinationDebitCostCenter = destinationDebitCostCenter;
      MGASimpleComboBox creditCostCenter = this.comboMultiOffice_DestinationCreditCostCenter;
      this.LoadCostCenters(ref creditCostCenter, Conversions.ToInteger(this.comboMultiOffice_DestinationOfficeLocation.Value));
      this.comboMultiOffice_DestinationCreditCostCenter = creditCostCenter;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void LoadGLOffsetAccounts(ref MGAComboBox combo, int glCompanyId)
  {
    ((UltraGridBase) combo).DataSource = (object) DefaultDatabase.ExecuteDataTable(this.LoadGLList_ProcedureName, new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyId
    });
  }

  private void FormatOffsetDropDown(ref MGAComboBox cmb)
  {
    ((UltraDropDownBase) cmb).ValueMember = "glacctid";
    ((UltraDropDownBase) cmb).DisplayMember = "fullname";
    cmb.DisplayLayout.Bands[0].Columns["glacctid"].Hidden = true;
    cmb.DisplayLayout.Bands[0].Columns["fullname"].Width = 300;
    ((UltraDropDownBase) cmb).DropDownWidth = 500;
  }

  private void CancelButtonClick_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private bool ValidateSingleOfficeForm()
  {
    bool flag;
    if (((UltraDropDownBase) this.comboSingleOffice_OfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboSingleOffice_SourceBank).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a source bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboSingleOffice_DestinationAccount).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a destination bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboSingleOffice_CreditCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a credit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboSingleOffice_DebitCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a debit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.dateTimeSingleOffice_PostDate.Value == null || !Information.IsDate(RuntimeHelpers.GetObjectValue(this.dateTimeSingleOffice_PostDate.Value)))
    {
      int num = (int) MessageBox.Show("You must select a valid post date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.maskSingleOffice_Amount.Value == null || !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.maskSingleOffice_Amount.Value)))
    {
      int num = (int) MessageBox.Show("You must specify a amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool ValidateMultiOfficeForm()
  {
    bool flag;
    if (((UltraDropDownBase) this.comboMultiOffice_SourceOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a source office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_SourceBank).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a source bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_SourceOffsetAccount).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a source offset account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_DestinationOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a destination office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_DestinationBank).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a destination bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_DestinationOffsetAccount).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a destination offset account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_SourceCreditCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a source credit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_SourceDebitCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a source debit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_DestinationCreditCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a destination credit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboMultiOffice_DestinationDebitCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a destination debit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.dateTimeMultiOffice_PostDate.Value == null || !Information.IsDate(RuntimeHelpers.GetObjectValue(this.dateTimeMultiOffice_PostDate.Value)))
    {
      int num = (int) MessageBox.Show("You must select a valid post date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.maskMultiOffice_Amount.Value == null || !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.maskMultiOffice_Amount.Value)))
    {
      int num = (int) MessageBox.Show("You must specify a amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void buttonMultiOffice_Save_Click(object sender, EventArgs e)
  {
    if (!this.ValidateMultiOfficeForm())
      return;
    this.SaveMultiOfficeTransfer();
  }

  private void buttonSingleOffice_Save_Click(object sender, EventArgs e)
  {
    if (!this.ValidateSingleOfficeForm())
      return;
    this.SaveSingleOfficeTransfer();
  }

  protected virtual void LoadCostCenters(ref MGASimpleComboBox combo, int glCompanyId)
  {
    ((UltraGridBase) combo).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetCostCentersList", new object[2]
    {
      (object) "@glCompanyId",
      (object) glCompanyId
    });
    ((UltraDropDownBase) combo).DisplayMember = "Name";
    ((UltraDropDownBase) combo).ValueMember = "CostCenterId";
  }

  private void SaveSingleOfficeTransfer()
  {
    try
    {
      BankingServices.TransferFunds(Conversions.ToInteger(this.comboSingleOffice_SourceBank.Value), Conversions.ToInteger(this.comboSingleOffice_DestinationAccount.Value), this.dateTimeSingleOffice_PostDate.DateTime.Date, Conversions.ToDecimal(this.maskSingleOffice_Amount.Value), ((TextEditorControlBase) this.textSingleOffice_TransactionComments).Text, CurrentUser.Instance.UserGUID, Conversions.ToInteger(this.comboSingleOffice_CreditCostCenter.Value), Conversions.ToInteger(this.comboSingleOffice_DebitCostCenter.Value));
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
  }

  private void SaveMultiOfficeTransfer()
  {
    try
    {
      BankingServices.TransferFunds(Conversions.ToInteger(this.comboMultiOffice_SourceBank.Value), Conversions.ToInteger(this.comboMultiOffice_SourceOffsetAccount.Value), this.dateTimeMultiOffice_PostDate.DateTime.Date, Conversions.ToDecimal(this.maskMultiOffice_Amount.Value), ((TextEditorControlBase) this.textMultiOffice_TransactionComment).Text, CurrentUser.Instance.UserGUID, Conversions.ToInteger(this.comboMultiOffice_SourceCreditCostCenter.Value), Conversions.ToInteger(this.comboMultiOffice_SourceDebitCostCenter.Value));
      BankingServices.TransferFunds(Conversions.ToInteger(this.comboMultiOffice_DestinationOffsetAccount.Value), Conversions.ToInteger(this.comboMultiOffice_DestinationBank.Value), this.dateTimeMultiOffice_PostDate.DateTime.Date, Conversions.ToDecimal(this.maskMultiOffice_Amount.Value), ((TextEditorControlBase) this.textMultiOffice_TransactionComment).Text, CurrentUser.Instance.UserGUID, Conversions.ToInteger(this.comboMultiOffice_DestinationCreditCostCenter.Value), Conversions.ToInteger(this.comboMultiOffice_DestinationDebitCostCenter.Value));
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
  }
}
