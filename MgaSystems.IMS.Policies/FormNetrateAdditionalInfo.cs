// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormNetrateAdditionalInfo
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating.AutoSymbols;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.Tools;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
[SecureResource("{38181B55-03C8-4805-8583-DD7543518FA5}", "Test symbol automation access", "Allows access to a report that displays attempted symbol assignment", "Policies")]
[SecureResource("{8FDE1A5D-5144-406d-B782-88729DB5DE6B}", "Symbol automation access", "Allows access to auto-fill symbol assignments", "Policies")]
public class FormNetrateAdditionalInfo : Form
{
  private IContainer components;
  private Label Label10;
  private Label Label9;
  private Label Label8;
  private Label Label7;
  protected MGATextBox txtPIPSymbol;
  protected MGATextBox txtAddedPIPSymbol;
  protected MGATextBox txtPropertyProtectionSymbol;
  protected MGATextBox txtMedicalPaymentsSymbol;
  protected MGATextBox txtUninsuredMotoristSymbol;
  protected MGATextBox txtUnderinsuredMotoristSymbol;
  protected MGATextBox txtComprehensiveSymbol;
  protected MGATextBox txtCollisionSymbol;
  private Label Label5;
  private Label Label4;
  private Label Label3;
  protected MGATextBox txtLiabilitySymbol;
  private Label Label2;
  private Label Label1;
  private DbCommand DbCommand3;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private Label Label14;
  private Label Label13;
  private Label Label11;
  protected MGATextBox MgaTextBox3;
  private Label Label6;
  protected MGATextBox MgaTextBox2;
  private readonly Quote _quote;
  private DataTable tblExcludedStates;
  internal const string symbolTestSecurityGuid = "{38181B55-03C8-4805-8583-DD7543518FA5}";
  internal const string symbolSecurityGuid = "{8FDE1A5D-5144-406d-B782-88729DB5DE6B}";
  private BackgroundWorker bwAutoSymbol;
  private readonly bool _isBound;
  private readonly bool _isIssued;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormNetrateAdditionalInfo));
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance68 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance69 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance70 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance71 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance72 = new Appearance();
    this.tabAdditonalData = new UltraTabPageControl();
    this.lnkAutoFillSymbols = new LinkLabel();
    this.lnkTestSymbolAutomation = new LinkLabel();
    this.GroupBox3 = new GroupBox();
    this.Label34 = new Label();
    this.MgaNumericEditor3 = new MGANumericEditor();
    this.ds = new dsNetRateAdditionalInfo();
    this.Label33 = new Label();
    this.MgaNumericEditor2 = new MGANumericEditor();
    this.Label32 = new Label();
    this.MgaTextBox10 = new MGATextBox();
    this.Label31 = new Label();
    this.MgaTextBox9 = new MGATextBox();
    this.Label29 = new Label();
    this.MgaTextBox7 = new MGATextBox();
    this.Label30 = new Label();
    this.MgaTextBox8 = new MGATextBox();
    this.Label26 = new Label();
    this.txtTrailerSymbol = new MGATextBox();
    this.lblTowingSymbol = new Label();
    this.txtTowingSymbol = new MGATextBox();
    this.Label11 = new Label();
    this.MgaTextBox3 = new MGATextBox();
    this.Label6 = new Label();
    this.MgaTextBox2 = new MGATextBox();
    this.txtAddedPIPSymbol = new MGATextBox();
    this.Label1 = new Label();
    this.Label10 = new Label();
    this.Label2 = new Label();
    this.Label9 = new Label();
    this.txtLiabilitySymbol = new MGATextBox();
    this.Label8 = new Label();
    this.Label3 = new Label();
    this.Label7 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.txtPIPSymbol = new MGATextBox();
    this.txtCollisionSymbol = new MGATextBox();
    this.txtPropertyProtectionSymbol = new MGATextBox();
    this.txtComprehensiveSymbol = new MGATextBox();
    this.txtMedicalPaymentsSymbol = new MGATextBox();
    this.txtUnderinsuredMotoristSymbol = new MGATextBox();
    this.txtUninsuredMotoristSymbol = new MGATextBox();
    this.labelInformation = new Label();
    this.tabRejected = new UltraTabPageControl();
    this.Label14 = new Label();
    this.numTerrorism = new MGANumericEditor();
    this.Label13 = new Label();
    this.numRejectedTerrorism = new MGANumericEditor();
    this.btnSave = new MGAButton();
    this.tabGeneralLiability = new UltraTabPageControl();
    this.Label39 = new Label();
    this.numGL_Min_Premium = new MGANumericEditor();
    this.Label38 = new Label();
    this.numGL_Est_Premium = new MGANumericEditor();
    this.Label37 = new Label();
    this.numGL_Rate = new MGANumericEditor();
    this.Label36 = new Label();
    this.numNo_of_Empl = new MGANumericEditor();
    this.Label35 = new Label();
    this.numReceipts = new MGANumericEditor();
    this.MgaTextBox6 = new MGATextBox();
    this.MgaTextBox5 = new MGATextBox();
    this.MgaTextBox4 = new MGATextBox();
    this.Label24 = new Label();
    this.Label20 = new Label();
    this.Label19 = new Label();
    this.Label18 = new Label();
    this.Label17 = new Label();
    this.Label16 = new Label();
    this.Label12 = new Label();
    this.txtRetroDate = new MGATextBox();
    this.Label15 = new Label();
    this.cboCoverageType = new MGASimpleComboBox();
    this.tabAuto = new UltraTabPageControl();
    this.UltraLabel6 = new UltraLabel();
    this.numPoweredUnits = new MGANumericEditor();
    this.chkCompositeRated = new MGACheckBox();
    this.Label28 = new Label();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.MgaTextBox1 = new MGATextBox();
    this.UltraLabel9 = new UltraLabel();
    this.GroupBox2 = new GroupBox();
    this.UltraLabel1 = new UltraLabel();
    this.MgaCheckBox1 = new MGACheckBox();
    this.MgaCheckBox2 = new MGACheckBox();
    this.ultraLabel28 = new UltraLabel();
    this.UltraLabel2 = new UltraLabel();
    this.UltraLabel3 = new UltraLabel();
    this.MgaCheckBox9 = new MGACheckBox();
    this.MgaCheckBox11 = new MGACheckBox();
    this.MgaCheckBox12 = new MGACheckBox();
    this.MgaCheckBox10 = new MGACheckBox();
    this.MgaCheckBox18 = new MGACheckBox();
    this.MgaCheckBox13 = new MGACheckBox();
    this.MgaCheckBox17 = new MGACheckBox();
    this.MgaCheckBox14 = new MGACheckBox();
    this.MgaCheckBox16 = new MGACheckBox();
    this.MgaCheckBox15 = new MGACheckBox();
    this.GroupBox1 = new GroupBox();
    this.UltraLabel5 = new UltraLabel();
    this.MgaCheckBox6 = new MGACheckBox();
    this.MgaCheckBox3 = new MGACheckBox();
    this.MgaCheckBox4 = new MGACheckBox();
    this.MgaCheckBox5 = new MGACheckBox();
    this.MgaCheckBox7 = new MGACheckBox();
    this.MgaCheckBox8 = new MGACheckBox();
    this.UltraLabel4 = new UltraLabel();
    this.MgaCheckBox22 = new MGACheckBox();
    this.MgaCheckBox20 = new MGACheckBox();
    this.MgaCheckBox21 = new MGACheckBox();
    this.UltraLabel8 = new UltraLabel();
    this.MgaCheckBox19 = new MGACheckBox();
    this.Label25 = new Label();
    this.Label23 = new Label();
    this.Label22 = new Label();
    this.Label21 = new Label();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.MgaTxtStateUnEmp = new MGATextBox();
    this.Label40 = new Label();
    this.Label27 = new Label();
    this.MgaCheckedListBox1 = new MGACheckedListBox();
    this.daNRExtendedData = DefaultDatabase.CreateDataAdapter();
    this.DbCommand2 = DefaultDatabase.CreateCommand();
    this.cn = DefaultDatabase.CreateDbConnection();
    this.DbCommand3 = DefaultDatabase.CreateCommand();
    this.DbCommand4 = DefaultDatabase.CreateCommand();
    this.DbCommand5 = DefaultDatabase.CreateCommand();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.ErrorP = new ErrorProvider(this.components);
    ((Control) this.tabAdditonalData).SuspendLayout();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.MgaNumericEditor3).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor2).BeginInit();
    ((ISupportInitialize) this.MgaTextBox10).BeginInit();
    ((ISupportInitialize) this.MgaTextBox9).BeginInit();
    ((ISupportInitialize) this.MgaTextBox7).BeginInit();
    ((ISupportInitialize) this.MgaTextBox8).BeginInit();
    ((ISupportInitialize) this.txtTrailerSymbol).BeginInit();
    ((ISupportInitialize) this.txtTowingSymbol).BeginInit();
    ((ISupportInitialize) this.MgaTextBox3).BeginInit();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    ((ISupportInitialize) this.txtAddedPIPSymbol).BeginInit();
    ((ISupportInitialize) this.txtLiabilitySymbol).BeginInit();
    ((ISupportInitialize) this.txtPIPSymbol).BeginInit();
    ((ISupportInitialize) this.txtCollisionSymbol).BeginInit();
    ((ISupportInitialize) this.txtPropertyProtectionSymbol).BeginInit();
    ((ISupportInitialize) this.txtComprehensiveSymbol).BeginInit();
    ((ISupportInitialize) this.txtMedicalPaymentsSymbol).BeginInit();
    ((ISupportInitialize) this.txtUnderinsuredMotoristSymbol).BeginInit();
    ((ISupportInitialize) this.txtUninsuredMotoristSymbol).BeginInit();
    ((Control) this.tabRejected).SuspendLayout();
    ((ISupportInitialize) this.numTerrorism).BeginInit();
    ((ISupportInitialize) this.numRejectedTerrorism).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((Control) this.tabGeneralLiability).SuspendLayout();
    ((ISupportInitialize) this.numGL_Min_Premium).BeginInit();
    ((ISupportInitialize) this.numGL_Est_Premium).BeginInit();
    ((ISupportInitialize) this.numGL_Rate).BeginInit();
    ((ISupportInitialize) this.numNo_of_Empl).BeginInit();
    ((ISupportInitialize) this.numReceipts).BeginInit();
    ((ISupportInitialize) this.MgaTextBox6).BeginInit();
    ((ISupportInitialize) this.MgaTextBox5).BeginInit();
    ((ISupportInitialize) this.MgaTextBox4).BeginInit();
    ((ISupportInitialize) this.txtRetroDate).BeginInit();
    ((ISupportInitialize) this.cboCoverageType).BeginInit();
    ((Control) this.tabAuto).SuspendLayout();
    ((ISupportInitialize) this.numPoweredUnits).BeginInit();
    ((ISupportInitialize) this.chkCompositeRated).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox2).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox9).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox11).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox12).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox10).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox18).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox13).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox17).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox14).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox16).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox15).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.MgaCheckBox6).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox3).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox4).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox5).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox7).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox8).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox22).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox20).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox21).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox19).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.MgaTxtStateUnEmp).BeginInit();
    ((ISupportInitialize) this.MgaCheckedListBox1).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.ErrorP).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.lnkAutoFillSymbols);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.lnkTestSymbolAutomation);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.GroupBox3);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label29);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.MgaTextBox7);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label30);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.MgaTextBox8);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label26);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtTrailerSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.lblTowingSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtTowingSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label11);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.MgaTextBox3);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label6);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.MgaTextBox2);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtAddedPIPSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label1);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label10);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label2);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label9);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtLiabilitySymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label8);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label3);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label7);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label4);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.Label5);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtPIPSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtCollisionSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtPropertyProtectionSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtComprehensiveSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtMedicalPaymentsSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtUnderinsuredMotoristSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.txtUninsuredMotoristSymbol);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.labelInformation);
    ((Control) this.tabAdditonalData).Controls.Add((Control) this.btnSave);
    ((Control) this.tabAdditonalData).Location = new Point(1, 26);
    ((Control) this.tabAdditonalData).Name = "tabAdditonalData";
    ((Control) this.tabAdditonalData).Size = new Size(818, 280);
    this.lnkAutoFillSymbols.AutoSize = true;
    this.lnkAutoFillSymbols.BackColor = Color.Transparent;
    this.lnkAutoFillSymbols.Location = new Point(5, 192 /*0xC0*/);
    this.lnkAutoFillSymbols.Name = "lnkAutoFillSymbols";
    this.lnkAutoFillSymbols.Size = new Size(88, 13);
    this.lnkAutoFillSymbols.TabIndex = 35;
    this.lnkAutoFillSymbols.TabStop = true;
    this.lnkAutoFillSymbols.Text = "Auto-Fill Symbols";
    this.lnkTestSymbolAutomation.AutoSize = true;
    this.lnkTestSymbolAutomation.BackColor = Color.Transparent;
    this.lnkTestSymbolAutomation.Location = new Point(99, 192 /*0xC0*/);
    this.lnkTestSymbolAutomation.Name = "lnkTestSymbolAutomation";
    this.lnkTestSymbolAutomation.Size = new Size(123, 13);
    this.lnkTestSymbolAutomation.TabIndex = 34;
    this.lnkTestSymbolAutomation.TabStop = true;
    this.lnkTestSymbolAutomation.Text = "Test Symbol Automation";
    this.GroupBox3.BackColor = Color.Transparent;
    this.GroupBox3.Controls.Add((Control) this.Label34);
    this.GroupBox3.Controls.Add((Control) this.MgaNumericEditor3);
    this.GroupBox3.Controls.Add((Control) this.Label33);
    this.GroupBox3.Controls.Add((Control) this.MgaNumericEditor2);
    this.GroupBox3.Controls.Add((Control) this.Label32);
    this.GroupBox3.Controls.Add((Control) this.MgaTextBox10);
    this.GroupBox3.Controls.Add((Control) this.Label31);
    this.GroupBox3.Controls.Add((Control) this.MgaTextBox9);
    this.GroupBox3.Location = new Point(8, 209);
    this.GroupBox3.Name = "GroupBox3";
    this.GroupBox3.Size = new Size(752, 51);
    this.GroupBox3.TabIndex = 15;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Other Endorsement:";
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label34.Location = new Point(584, 24);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(57, 13);
    this.Label34.TabIndex = 400;
    this.Label34.Text = "Deductible";
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor3).Appearance = (AppearanceBase) appearance1;
    ((Control) this.MgaNumericEditor3).CausesValidation = false;
    ((Control) this.MgaNumericEditor3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.EndorseDeductible", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor3).FormatString = "c";
    ((Control) this.MgaNumericEditor3).Location = new Point(641, 20);
    this.MgaNumericEditor3.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor3).Name = "MgaNumericEditor3";
    ((UltraNumericEditor) this.MgaNumericEditor3).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor3).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor3).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor3).TabIndex = 2;
    ((UltraControlBase) this.MgaNumericEditor3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor3).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsNetRateAdditionalInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label33.Location = new Point(442, 24);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(28, 13);
    this.Label33.TabIndex = 398;
    this.Label33.Text = "Limit";
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor2).Appearance = (AppearanceBase) appearance2;
    ((Control) this.MgaNumericEditor2).CausesValidation = false;
    ((Control) this.MgaNumericEditor2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.EndorseLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor2).FormatString = "c";
    ((Control) this.MgaNumericEditor2).Location = new Point(471, 20);
    this.MgaNumericEditor2.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor2).Name = "MgaNumericEditor2";
    ((UltraNumericEditor) this.MgaNumericEditor2).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor2).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor2).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor2).TabIndex = 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(287, 24);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(41, 13);
    this.Label32.TabIndex = 37;
    this.Label32.Text = "Symbol";
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox10).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.MgaTextBox10).BackColor = Color.White;
    ((Control) this.MgaTextBox10).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.EndorseSymbol", true));
    ((Control) this.MgaTextBox10).Location = new Point(329, 20);
    ((TextEditorControlBase) this.MgaTextBox10).MaxLength = 20;
    this.MgaTextBox10.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox10).Name = "MgaTextBox10";
    ((Control) this.MgaTextBox10).Size = new Size(100, 20);
    ((Control) this.MgaTextBox10).TabIndex = 0;
    ((UltraControlBase) this.MgaTextBox10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox10).UseOsThemes = (DefaultableBoolean) 2;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(9, 24);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(34, 13);
    this.Label31.TabIndex = 35;
    this.Label31.Text = "Name";
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox9).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.MgaTextBox9).BackColor = Color.White;
    ((Control) this.MgaTextBox9).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.EndorseName", true));
    ((Control) this.MgaTextBox9).Location = new Point(43, 20);
    ((TextEditorControlBase) this.MgaTextBox9).MaxLength = 50;
    this.MgaTextBox9.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox9).Name = "MgaTextBox9";
    ((Control) this.MgaTextBox9).Size = new Size(233, 20);
    ((Control) this.MgaTextBox9).TabIndex = 34;
    ((UltraControlBase) this.MgaTextBox9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox9).UseOsThemes = (DefaultableBoolean) 2;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(426, 192 /*0xC0*/);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(99, 13);
    this.Label29.TabIndex = 33;
    this.Label29.Text = "Hired Auto. Symbol";
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox7).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.MgaTextBox7).BackColor = Color.White;
    ((Control) this.MgaTextBox7).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.HiredAutoSymbol", true));
    ((Control) this.MgaTextBox7).Location = new Point(536, 188);
    ((TextEditorControlBase) this.MgaTextBox7).MaxLength = 20;
    this.MgaTextBox7.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox7).Name = "MgaTextBox7";
    ((Control) this.MgaTextBox7).Size = new Size(100, 20);
    ((Control) this.MgaTextBox7).TabIndex = 14;
    ((UltraControlBase) this.MgaTextBox7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox7).UseOsThemes = (DefaultableBoolean) 2;
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(388, 166);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(137, 13);
    this.Label30.TabIndex = 31 /*0x1F*/;
    this.Label30.Text = "Non-owned Liability Symbol";
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox8).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.MgaTextBox8).BackColor = Color.White;
    ((Control) this.MgaTextBox8).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.NonownedLiabilitySymbol", true));
    ((Control) this.MgaTextBox8).Location = new Point(536, 162);
    ((TextEditorControlBase) this.MgaTextBox8).MaxLength = 20;
    this.MgaTextBox8.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox8).Name = "MgaTextBox8";
    ((Control) this.MgaTextBox8).Size = new Size(100, 20);
    ((Control) this.MgaTextBox8).TabIndex = 13;
    ((UltraControlBase) this.MgaTextBox8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox8).UseOsThemes = (DefaultableBoolean) 2;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(389, 141);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(136, 13);
    this.Label26.TabIndex = 29;
    this.Label26.Text = "Trailer Interchange Symbol";
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTrailerSymbol).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtTrailerSymbol).BackColor = Color.White;
    ((Control) this.txtTrailerSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.TrailerSymbol", true));
    ((Control) this.txtTrailerSymbol).Location = new Point(537, 137);
    ((TextEditorControlBase) this.txtTrailerSymbol).MaxLength = 20;
    this.txtTrailerSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtTrailerSymbol).Name = "txtTrailerSymbol";
    ((Control) this.txtTrailerSymbol).Size = new Size(100, 20);
    ((Control) this.txtTrailerSymbol).TabIndex = 12;
    ((UltraControlBase) this.txtTrailerSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTrailerSymbol).UseOsThemes = (DefaultableBoolean) 2;
    this.lblTowingSymbol.AutoSize = true;
    this.lblTowingSymbol.BackColor = Color.Transparent;
    this.lblTowingSymbol.Location = new Point(447, 115);
    this.lblTowingSymbol.Name = "lblTowingSymbol";
    this.lblTowingSymbol.Size = new Size(78, 13);
    this.lblTowingSymbol.TabIndex = 27;
    this.lblTowingSymbol.Text = "Towing Symbol";
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTowingSymbol).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtTowingSymbol).BackColor = Color.White;
    ((Control) this.txtTowingSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.TowingSymbol", true));
    ((Control) this.txtTowingSymbol).Location = new Point(537, 111);
    ((TextEditorControlBase) this.txtTowingSymbol).MaxLength = 20;
    this.txtTowingSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtTowingSymbol).Name = "txtTowingSymbol";
    ((Control) this.txtTowingSymbol).Size = new Size(100, 20);
    ((Control) this.txtTowingSymbol).TabIndex = 11;
    ((UltraControlBase) this.txtTowingSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTowingSymbol).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(360, 88);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(165, 13);
    this.Label11.TabIndex = 25;
    this.Label11.Text = "Physical Damage Collision Symbol";
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox3).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.MgaTextBox3).BackColor = Color.White;
    ((Control) this.MgaTextBox3).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.PhysDamCollSymbol", true));
    ((Control) this.MgaTextBox3).Location = new Point(537, 85);
    ((TextEditorControlBase) this.MgaTextBox3).MaxLength = 20;
    this.MgaTextBox3.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox3).Name = "MgaTextBox3";
    ((Control) this.MgaTextBox3).Size = new Size(100, 20);
    ((Control) this.MgaTextBox3).TabIndex = 10;
    ((UltraControlBase) this.MgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(285, 62);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(240 /*0xF0*/, 13);
    this.Label6.TabIndex = 23;
    this.Label6.Text = "Physical Damage Specified Cause of Loss Symbol";
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.PhysDamCOLSymbol", true));
    ((Control) this.MgaTextBox2).Location = new Point(537, 59);
    ((TextEditorControlBase) this.MgaTextBox2).MaxLength = 20;
    this.MgaTextBox2.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(100, 20);
    ((Control) this.MgaTextBox2).TabIndex = 9;
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAddedPIPSymbol).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtAddedPIPSymbol).BackColor = Color.White;
    ((Control) this.txtAddedPIPSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.AddnPIPSymbol", true));
    ((Control) this.txtAddedPIPSymbol).Location = new Point(167, 59);
    ((TextEditorControlBase) this.txtAddedPIPSymbol).MaxLength = 20;
    this.txtAddedPIPSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAddedPIPSymbol).Name = "txtAddedPIPSymbol";
    ((Control) this.txtAddedPIPSymbol).Size = new Size(100, 20);
    ((Control) this.txtAddedPIPSymbol).TabIndex = 2;
    ((UltraControlBase) this.txtAddedPIPSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAddedPIPSymbol).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(76, 10);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(79, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Liability Symbol";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(371, 36);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(154, 13);
    this.Label10.TabIndex = 21;
    this.Label10.Text = "Physical Damage Comp Symbol";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(95, 36);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(60, 13);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "PIP Symbol";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(414, 10);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(117, 13);
    this.Label9.TabIndex = 20;
    this.Label9.Text = "Garagekeepers Symbol";
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLiabilitySymbol).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtLiabilitySymbol).BackColor = Color.White;
    ((Control) this.txtLiabilitySymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.AutoliabSymbol", true));
    ((Control) this.txtLiabilitySymbol).Location = new Point(167, 7);
    ((TextEditorControlBase) this.txtLiabilitySymbol).MaxLength = 20;
    this.txtLiabilitySymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLiabilitySymbol).Name = "txtLiabilitySymbol";
    ((Control) this.txtLiabilitySymbol).Size = new Size(100, 20);
    ((Control) this.txtLiabilitySymbol).TabIndex = 0;
    ((UltraControlBase) this.txtLiabilitySymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLiabilitySymbol).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(5, 166);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(150, 13);
    this.Label8.TabIndex = 19;
    this.Label8.Text = "Underinsured Motorist Symbol";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(45, 62);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(110, 13);
    this.Label3.TabIndex = 3;
    this.Label3.Text = "Additional PIP Symbol";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(21, 140);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(134, 13);
    this.Label7.TabIndex = 18;
    this.Label7.Text = "Uninsured Motorist Symbol";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(17, 88);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(138, 13);
    this.Label4.TabIndex = 4;
    this.Label4.Text = "Property Protection Symbol";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(26, 114);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(129, 13);
    this.Label5.TabIndex = 5;
    this.Label5.Text = "Medical Payments Symbol";
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPIPSymbol).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtPIPSymbol).BackColor = Color.White;
    ((Control) this.txtPIPSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.PIPSymbol", true));
    ((Control) this.txtPIPSymbol).Location = new Point(167, 33);
    ((TextEditorControlBase) this.txtPIPSymbol).MaxLength = 20;
    this.txtPIPSymbol.MGAStyle = (MGAStyles) 0;
    ((Control) this.txtPIPSymbol).Name = "txtPIPSymbol";
    ((Control) this.txtPIPSymbol).Size = new Size(100, 20);
    ((Control) this.txtPIPSymbol).TabIndex = 1;
    ((UltraControlBase) this.txtPIPSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPIPSymbol).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCollisionSymbol).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtCollisionSymbol).BackColor = Color.White;
    ((Control) this.txtCollisionSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.PhysDamCompSymbol", true));
    ((Control) this.txtCollisionSymbol).Location = new Point(537, 33);
    ((TextEditorControlBase) this.txtCollisionSymbol).MaxLength = 20;
    this.txtCollisionSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtCollisionSymbol).Name = "txtCollisionSymbol";
    ((Control) this.txtCollisionSymbol).Size = new Size(100, 20);
    ((Control) this.txtCollisionSymbol).TabIndex = 8;
    ((UltraControlBase) this.txtCollisionSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCollisionSymbol).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPropertyProtectionSymbol).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.txtPropertyProtectionSymbol).BackColor = Color.White;
    ((Control) this.txtPropertyProtectionSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.PropProtectionSymbol", true));
    ((Control) this.txtPropertyProtectionSymbol).Location = new Point(167, 85);
    ((TextEditorControlBase) this.txtPropertyProtectionSymbol).MaxLength = 20;
    this.txtPropertyProtectionSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPropertyProtectionSymbol).Name = "txtPropertyProtectionSymbol";
    ((Control) this.txtPropertyProtectionSymbol).Size = new Size(100, 20);
    ((Control) this.txtPropertyProtectionSymbol).TabIndex = 3;
    ((UltraControlBase) this.txtPropertyProtectionSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPropertyProtectionSymbol).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComprehensiveSymbol).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtComprehensiveSymbol).BackColor = Color.White;
    ((Control) this.txtComprehensiveSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.GaragekeepersSymbol", true));
    ((Control) this.txtComprehensiveSymbol).Location = new Point(537, 7);
    ((TextEditorControlBase) this.txtComprehensiveSymbol).MaxLength = 20;
    this.txtComprehensiveSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtComprehensiveSymbol).Name = "txtComprehensiveSymbol";
    ((Control) this.txtComprehensiveSymbol).Size = new Size(100, 20);
    ((Control) this.txtComprehensiveSymbol).TabIndex = 7;
    ((UltraControlBase) this.txtComprehensiveSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComprehensiveSymbol).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMedicalPaymentsSymbol).Appearance = (AppearanceBase) appearance17;
    ((TextEditorControlBase) this.txtMedicalPaymentsSymbol).BackColor = Color.White;
    ((Control) this.txtMedicalPaymentsSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.MedPaySymbol", true));
    ((Control) this.txtMedicalPaymentsSymbol).Location = new Point(167, 111);
    ((TextEditorControlBase) this.txtMedicalPaymentsSymbol).MaxLength = 20;
    this.txtMedicalPaymentsSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtMedicalPaymentsSymbol).Name = "txtMedicalPaymentsSymbol";
    ((Control) this.txtMedicalPaymentsSymbol).Size = new Size(100, 20);
    ((Control) this.txtMedicalPaymentsSymbol).TabIndex = 4;
    ((UltraControlBase) this.txtMedicalPaymentsSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMedicalPaymentsSymbol).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUnderinsuredMotoristSymbol).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.txtUnderinsuredMotoristSymbol).BackColor = Color.White;
    ((Control) this.txtUnderinsuredMotoristSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.UnderInsSymbol", true));
    ((Control) this.txtUnderinsuredMotoristSymbol).Location = new Point(167, 163);
    ((TextEditorControlBase) this.txtUnderinsuredMotoristSymbol).MaxLength = 20;
    this.txtUnderinsuredMotoristSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtUnderinsuredMotoristSymbol).Name = "txtUnderinsuredMotoristSymbol";
    ((Control) this.txtUnderinsuredMotoristSymbol).Size = new Size(100, 20);
    ((Control) this.txtUnderinsuredMotoristSymbol).TabIndex = 6;
    ((UltraControlBase) this.txtUnderinsuredMotoristSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUnderinsuredMotoristSymbol).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUninsuredMotoristSymbol).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.txtUninsuredMotoristSymbol).BackColor = Color.White;
    ((Control) this.txtUninsuredMotoristSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.UnInsSymbol", true));
    ((Control) this.txtUninsuredMotoristSymbol).Location = new Point(167, 137);
    ((TextEditorControlBase) this.txtUninsuredMotoristSymbol).MaxLength = 20;
    this.txtUninsuredMotoristSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtUninsuredMotoristSymbol).Name = "txtUninsuredMotoristSymbol";
    ((Control) this.txtUninsuredMotoristSymbol).Size = new Size(100, 20);
    ((Control) this.txtUninsuredMotoristSymbol).TabIndex = 5;
    ((UltraControlBase) this.txtUninsuredMotoristSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUninsuredMotoristSymbol).UseOsThemes = (DefaultableBoolean) 2;
    this.labelInformation.AutoSize = true;
    this.labelInformation.BackColor = Color.Transparent;
    this.labelInformation.Font = new Font("Tahoma", 8.25f);
    this.labelInformation.ForeColor = Color.Red;
    this.labelInformation.Location = new Point(474, 262);
    this.labelInformation.Name = "labelInformation";
    this.labelInformation.Size = new Size(278, 13);
    this.labelInformation.TabIndex = 16 /*0x10*/;
    this.labelInformation.Text = "Note: Editing disabled because this transaction is bound.";
    this.labelInformation.Visible = false;
    ((Control) this.tabRejected).Controls.Add((Control) this.Label14);
    ((Control) this.tabRejected).Controls.Add((Control) this.numTerrorism);
    ((Control) this.tabRejected).Controls.Add((Control) this.Label13);
    ((Control) this.tabRejected).Controls.Add((Control) this.numRejectedTerrorism);
    ((Control) this.tabRejected).Location = new Point(-10000, -10000);
    ((Control) this.tabRejected).Name = "tabRejected";
    ((Control) this.tabRejected).Size = new Size(818, 280);
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(56, 49);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(52, 13);
    this.Label14.TabIndex = 45;
    this.Label14.Text = "Terrorism";
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTerrorism).Appearance = (AppearanceBase) appearance20;
    ((Control) this.numTerrorism).CausesValidation = false;
    ((Control) this.numTerrorism).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.Terrorism", true));
    ((UltraNumericEditorBase) this.numTerrorism).FormatString = "c";
    ((Control) this.numTerrorism).Location = new Point(123, 46);
    this.numTerrorism.MGAStyle = (MGAStyles) 2;
    ((Control) this.numTerrorism).Name = "numTerrorism";
    ((UltraNumericEditor) this.numTerrorism).NumericType = (NumericType) 1;
    ((Control) this.numTerrorism).Size = new Size(100, 20);
    ((Control) this.numTerrorism).TabIndex = 44;
    ((UltraControlBase) this.numTerrorism).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTerrorism).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(12, 21);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(98, 13);
    this.Label13.TabIndex = 43;
    this.Label13.Text = "Rejected Terrorism";
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numRejectedTerrorism).Appearance = (AppearanceBase) appearance21;
    ((Control) this.numRejectedTerrorism).CausesValidation = false;
    ((Control) this.numRejectedTerrorism).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.RejectedTerrorism", true));
    ((UltraNumericEditorBase) this.numRejectedTerrorism).FormatString = "c";
    ((Control) this.numRejectedTerrorism).Location = new Point(123, 21);
    this.numRejectedTerrorism.MGAStyle = (MGAStyles) 2;
    ((Control) this.numRejectedTerrorism).Name = "numRejectedTerrorism";
    ((UltraNumericEditor) this.numRejectedTerrorism).NumericType = (NumericType) 1;
    ((Control) this.numRejectedTerrorism).Size = new Size(100, 20);
    ((Control) this.numRejectedTerrorism).TabIndex = 42;
    ((UltraControlBase) this.numRejectedTerrorism).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numRejectedTerrorism).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance22.BackColor = Color.FromArgb(248, 248, 248);
    appearance22.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance22.BackGradientStyle = (GradientStyle) 2;
    appearance22.BorderColor = Color.DarkGray;
    appearance22.ImageHAlign = (HAlign) 2;
    appearance22.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance22;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(775, 237);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 17;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label39);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.numGL_Min_Premium);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label38);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.numGL_Est_Premium);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label37);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.numGL_Rate);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label36);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.numNo_of_Empl);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label35);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.numReceipts);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.MgaTextBox6);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.MgaTextBox5);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.MgaTextBox4);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label24);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label20);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label19);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label18);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label17);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label16);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label12);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.txtRetroDate);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.Label15);
    ((Control) this.tabGeneralLiability).Controls.Add((Control) this.cboCoverageType);
    ((Control) this.tabGeneralLiability).Location = new Point(-10000, -10000);
    ((Control) this.tabGeneralLiability).Name = "tabGeneralLiability";
    ((Control) this.tabGeneralLiability).Size = new Size(818, 280);
    this.Label39.AutoSize = true;
    this.Label39.BackColor = Color.Transparent;
    this.Label39.Location = new Point(421, 120);
    this.Label39.Name = "Label39";
    this.Label39.Size = new Size(94, 13);
    this.Label39.TabIndex = 67;
    this.Label39.Text = "Minimum Premium:";
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numGL_Min_Premium).Appearance = (AppearanceBase) appearance23;
    ((Control) this.numGL_Min_Premium).CausesValidation = false;
    ((Control) this.numGL_Min_Premium).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.GL_Min_Premium", true));
    ((UltraNumericEditorBase) this.numGL_Min_Premium).FormatString = "c";
    ((Control) this.numGL_Min_Premium).Location = new Point(523, 116);
    this.numGL_Min_Premium.MGAStyle = (MGAStyles) 2;
    ((Control) this.numGL_Min_Premium).Name = "numGL_Min_Premium";
    ((UltraNumericEditor) this.numGL_Min_Premium).Nullable = true;
    ((UltraNumericEditor) this.numGL_Min_Premium).NumericType = (NumericType) 1;
    ((Control) this.numGL_Min_Premium).Size = new Size(122, 20);
    ((Control) this.numGL_Min_Premium).TabIndex = 66;
    ((UltraWinEditorMaskedControlBase) this.numGL_Min_Premium).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numGL_Min_Premium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numGL_Min_Premium).UseOsThemes = (DefaultableBoolean) 2;
    this.Label38.AutoSize = true;
    this.Label38.BackColor = Color.Transparent;
    this.Label38.Location = new Point(414, 87);
    this.Label38.Name = "Label38";
    this.Label38.Size = new Size(101, 13);
    this.Label38.TabIndex = 65;
    this.Label38.Text = "Estimated Premium:";
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numGL_Est_Premium).Appearance = (AppearanceBase) appearance24;
    ((Control) this.numGL_Est_Premium).CausesValidation = false;
    ((Control) this.numGL_Est_Premium).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.GL_Est_Premium", true));
    ((UltraNumericEditorBase) this.numGL_Est_Premium).FormatString = "c";
    ((Control) this.numGL_Est_Premium).Location = new Point(523, 83);
    this.numGL_Est_Premium.MGAStyle = (MGAStyles) 2;
    ((Control) this.numGL_Est_Premium).Name = "numGL_Est_Premium";
    ((UltraNumericEditor) this.numGL_Est_Premium).Nullable = true;
    ((UltraNumericEditor) this.numGL_Est_Premium).NumericType = (NumericType) 1;
    ((Control) this.numGL_Est_Premium).Size = new Size(122, 20);
    ((Control) this.numGL_Est_Premium).TabIndex = 64 /*0x40*/;
    ((UltraWinEditorMaskedControlBase) this.numGL_Est_Premium).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numGL_Est_Premium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numGL_Est_Premium).UseOsThemes = (DefaultableBoolean) 2;
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Location = new Point(413, 54);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(102, 13);
    this.Label37.TabIndex = 63 /*0x3F*/;
    this.Label37.Text = "Rate Per Employee:";
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numGL_Rate).Appearance = (AppearanceBase) appearance25;
    ((Control) this.numGL_Rate).CausesValidation = false;
    ((Control) this.numGL_Rate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.GL_Rate", true));
    ((UltraNumericEditorBase) this.numGL_Rate).FormatString = "#0.0000";
    ((Control) this.numGL_Rate).Location = new Point(523, 50);
    ((UltraNumericEditor) this.numGL_Rate).MaskInput = "nnnnn.nnnn";
    this.numGL_Rate.MGAStyle = (MGAStyles) 2;
    ((Control) this.numGL_Rate).Name = "numGL_Rate";
    ((UltraNumericEditor) this.numGL_Rate).Nullable = true;
    ((UltraNumericEditor) this.numGL_Rate).NumericType = (NumericType) 2;
    ((Control) this.numGL_Rate).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.numGL_Rate).TabIndex = 62;
    ((UltraWinEditorMaskedControlBase) this.numGL_Rate).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numGL_Rate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numGL_Rate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(379, 24);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(136, 13);
    this.Label36.TabIndex = 61;
    this.Label36.Text = "Estimated # of Employees:";
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numNo_of_Empl).Appearance = (AppearanceBase) appearance26;
    ((Control) this.numNo_of_Empl).CausesValidation = false;
    ((Control) this.numNo_of_Empl).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.NO_of_Empl", true));
    ((UltraNumericEditorBase) this.numNo_of_Empl).FormatString = "";
    ((Control) this.numNo_of_Empl).Location = new Point(523, 20);
    ((UltraNumericEditor) this.numNo_of_Empl).MaskInput = "nnnn";
    this.numNo_of_Empl.MGAStyle = (MGAStyles) 2;
    ((Control) this.numNo_of_Empl).Name = "numNo_of_Empl";
    ((UltraNumericEditor) this.numNo_of_Empl).Nullable = true;
    ((Control) this.numNo_of_Empl).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.numNo_of_Empl).TabIndex = 60;
    ((UltraWinEditorMaskedControlBase) this.numNo_of_Empl).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numNo_of_Empl).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numNo_of_Empl).UseOsThemes = (DefaultableBoolean) 2;
    this.Label35.AutoSize = true;
    this.Label35.BackColor = Color.Transparent;
    this.Label35.Location = new Point(88, 189);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(52, 13);
    this.Label35.TabIndex = 59;
    this.Label35.Text = "Receipts:";
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numReceipts).Appearance = (AppearanceBase) appearance27;
    ((Control) this.numReceipts).CausesValidation = false;
    ((Control) this.numReceipts).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.Receipts", true));
    ((UltraNumericEditorBase) this.numReceipts).FormatString = "c";
    ((Control) this.numReceipts).Location = new Point(146, 185);
    this.numReceipts.MGAStyle = (MGAStyles) 2;
    ((Control) this.numReceipts).Name = "numReceipts";
    ((UltraNumericEditor) this.numReceipts).Nullable = true;
    ((UltraNumericEditor) this.numReceipts).NumericType = (NumericType) 1;
    ((Control) this.numReceipts).Size = new Size(134, 20);
    ((Control) this.numReceipts).TabIndex = 5;
    ((UltraWinEditorMaskedControlBase) this.numReceipts).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numReceipts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numReceipts).UseOsThemes = (DefaultableBoolean) 2;
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox6).Appearance = (AppearanceBase) appearance28;
    ((TextEditorControlBase) this.MgaTextBox6).BackColor = Color.White;
    ((Control) this.MgaTextBox6).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.BodilyInjEachAcc", true));
    ((Control) this.MgaTextBox6).Location = new Point(146, 86);
    ((TextEditorControlBase) this.MgaTextBox6).MaxLength = 20;
    this.MgaTextBox6.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox6).Name = "MgaTextBox6";
    ((Control) this.MgaTextBox6).Size = new Size(134, 20);
    ((Control) this.MgaTextBox6).TabIndex = 2;
    ((UltraControlBase) this.MgaTextBox6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox6).UseOsThemes = (DefaultableBoolean) 2;
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox5).Appearance = (AppearanceBase) appearance29;
    ((TextEditorControlBase) this.MgaTextBox5).BackColor = Color.White;
    ((Control) this.MgaTextBox5).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.BodilyInjDiseaseAggLimit", true));
    ((Control) this.MgaTextBox5).Location = new Point(146, 119);
    ((TextEditorControlBase) this.MgaTextBox5).MaxLength = 20;
    this.MgaTextBox5.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox5).Name = "MgaTextBox5";
    ((Control) this.MgaTextBox5).Size = new Size(134, 20);
    ((Control) this.MgaTextBox5).TabIndex = 3;
    ((UltraControlBase) this.MgaTextBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox5).UseOsThemes = (DefaultableBoolean) 2;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox4).Appearance = (AppearanceBase) appearance30;
    ((TextEditorControlBase) this.MgaTextBox4).BackColor = Color.White;
    ((Control) this.MgaTextBox4).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.BodilyInjDiseaseEachEmpl", true));
    ((Control) this.MgaTextBox4).Location = new Point(146, 152);
    ((TextEditorControlBase) this.MgaTextBox4).MaxLength = 20;
    this.MgaTextBox4.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox4).Name = "MgaTextBox4";
    ((Control) this.MgaTextBox4).Size = new Size(134, 20);
    ((Control) this.MgaTextBox4).TabIndex = 4;
    ((UltraControlBase) this.MgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(16 /*0x10*/, 123);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(126, 13);
    this.Label24.TabIndex = 54;
    this.Label24.Text = "Bodily Injury By Disease:";
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(16 /*0x10*/, 156);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(126, 13);
    this.Label20.TabIndex = 53;
    this.Label20.Text = "Bodily Injury By Disease:";
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(286, 90);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(74, 13);
    this.Label19.TabIndex = 52;
    this.Label19.Text = "Each Accident";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(286, 123);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(82, 13);
    this.Label18.TabIndex = 51;
    this.Label18.Text = "Aggregate Limit";
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(286, 156);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(79, 13);
    this.Label17.TabIndex = 50;
    this.Label17.Text = "Each Employee";
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(10, 90);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(130, 13);
    this.Label16.TabIndex = 49;
    this.Label16.Text = "Bodily Injury By Accident:";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(76, 57);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(64 /*0x40*/, 13);
    this.Label12.TabIndex = 48 /*0x30*/;
    this.Label12.Text = "Retro Date:";
    appearance31.BackColor = Color.White;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRetroDate).Appearance = (AppearanceBase) appearance31;
    ((TextEditorControlBase) this.txtRetroDate).BackColor = Color.White;
    ((Control) this.txtRetroDate).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.RetroDate", true));
    ((Control) this.txtRetroDate).Location = new Point(146, 53);
    ((TextEditorControlBase) this.txtRetroDate).MaxLength = 20;
    this.txtRetroDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtRetroDate).Name = "txtRetroDate";
    ((Control) this.txtRetroDate).Size = new Size(195, 20);
    ((Control) this.txtRetroDate).TabIndex = 1;
    ((UltraControlBase) this.txtRetroDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRetroDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(55, 23);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(85, 13);
    this.Label15.TabIndex = 46;
    this.Label15.Text = "Coverage Type:";
    ((Control) this.cboCoverageType).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraCombo) this.cboCoverageType).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCoverageType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.CoverageTypeID", true));
    ((UltraGridBase) this.cboCoverageType).DataMember = "lstGLCoverageType";
    ((UltraGridBase) this.cboCoverageType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCoverageType).DisplayMember = "CoverageType";
    ((UltraCombo) this.cboCoverageType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCoverageType).Location = new Point(146, 19);
    this.cboCoverageType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboCoverageType).Name = "cboCoverageType";
    ((Control) this.cboCoverageType).Size = new Size(195, 21);
    ((Control) this.cboCoverageType).TabIndex = 0;
    ((UltraControlBase) this.cboCoverageType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCoverageType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCoverageType).ValueMember = "ID";
    ((Control) this.tabAuto).Controls.Add((Control) this.UltraLabel6);
    ((Control) this.tabAuto).Controls.Add((Control) this.numPoweredUnits);
    ((Control) this.tabAuto).Controls.Add((Control) this.chkCompositeRated);
    ((Control) this.tabAuto).Controls.Add((Control) this.Label28);
    ((Control) this.tabAuto).Controls.Add((Control) this.MgaNumericEditor1);
    ((Control) this.tabAuto).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.tabAuto).Controls.Add((Control) this.UltraLabel9);
    ((Control) this.tabAuto).Controls.Add((Control) this.GroupBox2);
    ((Control) this.tabAuto).Controls.Add((Control) this.GroupBox1);
    ((Control) this.tabAuto).Controls.Add((Control) this.MgaCheckBox22);
    ((Control) this.tabAuto).Controls.Add((Control) this.MgaCheckBox20);
    ((Control) this.tabAuto).Controls.Add((Control) this.MgaCheckBox21);
    ((Control) this.tabAuto).Controls.Add((Control) this.UltraLabel8);
    ((Control) this.tabAuto).Controls.Add((Control) this.MgaCheckBox19);
    ((Control) this.tabAuto).Controls.Add((Control) this.Label25);
    ((Control) this.tabAuto).Controls.Add((Control) this.Label23);
    ((Control) this.tabAuto).Controls.Add((Control) this.Label22);
    ((Control) this.tabAuto).Controls.Add((Control) this.Label21);
    ((Control) this.tabAuto).Location = new Point(-10000, -10000);
    ((Control) this.tabAuto).Name = "tabAuto";
    ((Control) this.tabAuto).Size = new Size(818, 280);
    ((Control) this.UltraLabel6).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance32.BackColor = Color.Transparent;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Left";
    ((ControlBase) this.UltraLabel6).Appearance = (AppearanceBase) appearance32;
    ((Control) this.UltraLabel6).Location = new Point(542, 257);
    ((Control) this.UltraLabel6).Name = "UltraLabel6";
    ((Control) this.UltraLabel6).Size = new Size(115, 15);
    ((Control) this.UltraLabel6).TabIndex = 7;
    ((ControlBase) this.UltraLabel6).Text = "# of Powered Units:";
    ((Control) this.numPoweredUnits).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPoweredUnits).Appearance = (AppearanceBase) appearance33;
    ((Control) this.numPoweredUnits).CausesValidation = false;
    ((Control) this.numPoweredUnits).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.NumPoweredUnits", true));
    ((UltraNumericEditorBase) this.numPoweredUnits).FormatString = "";
    ((Control) this.numPoweredUnits).Location = new Point(663, 254);
    this.numPoweredUnits.MGAStyle = (MGAStyles) 2;
    ((Control) this.numPoweredUnits).Name = "numPoweredUnits";
    ((UltraNumericEditor) this.numPoweredUnits).Nullable = true;
    ((Control) this.numPoweredUnits).Size = new Size(70, 20);
    ((Control) this.numPoweredUnits).TabIndex = 8;
    ((UltraWinEditorMaskedControlBase) this.numPoweredUnits).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numPoweredUnits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPoweredUnits).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkCompositeRated).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance34.BorderColor = Color.Gray;
    appearance34.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCompositeRated).Appearance = (AppearanceBase) appearance34;
    ((UltraToggleEditorBase) this.chkCompositeRated).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCompositeRated).BackColorInternal = Color.Transparent;
    ((Control) this.chkCompositeRated).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.CompositeRated", true));
    ((UltraToggleEditorBase) this.chkCompositeRated).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCompositeRated).Location = new Point(390, 256 /*0x0100*/);
    ((Control) this.chkCompositeRated).Name = "chkCompositeRated";
    ((Control) this.chkCompositeRated).Size = new Size(118, 18);
    ((Control) this.chkCompositeRated).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkCompositeRated).Text = "Composite Rated";
    ((UltraControlBase) this.chkCompositeRated).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCompositeRated).UseOsThemes = (DefaultableBoolean) 2;
    this.Label28.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label28.Location = new Point(3, 257);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(254, 13);
    this.Label28.TabIndex = 396;
    this.Label28.Text = "Hired Auto Physical Damage Coverage Limit";
    ((Control) this.MgaNumericEditor1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance35;
    ((Control) this.MgaNumericEditor1).CausesValidation = false;
    ((Control) this.MgaNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblNetRateAdditionalData.HiredAutoLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor1).FormatString = "c";
    ((Control) this.MgaNumericEditor1).Location = new Point(260, 254);
    this.MgaNumericEditor1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    ((UltraNumericEditor) this.MgaNumericEditor1).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor1).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor1).TabIndex = 3;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance36.BackColor = Color.White;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance36;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.AutoComments", true));
    ((Control) this.MgaTextBox1).Location = new Point(542, 211);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 500;
    this.MgaTextBox1.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.MgaTextBox1).Multiline = true;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(191, 37);
    ((Control) this.MgaTextBox1).TabIndex = 6;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraLabel9).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance37.BackColor = Color.Transparent;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Left";
    ((ControlBase) this.UltraLabel9).Appearance = (AppearanceBase) appearance37;
    ((Control) this.UltraLabel9).Location = new Point(542, 190);
    ((Control) this.UltraLabel9).Name = "UltraLabel9";
    ((Control) this.UltraLabel9).Size = new Size(64 /*0x40*/, 15);
    ((Control) this.UltraLabel9).TabIndex = 5;
    ((ControlBase) this.UltraLabel9).Text = "Comments:";
    this.GroupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.GroupBox2.BackColor = Color.Transparent;
    this.GroupBox2.Controls.Add((Control) this.UltraLabel1);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox1);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox2);
    this.GroupBox2.Controls.Add((Control) this.ultraLabel28);
    this.GroupBox2.Controls.Add((Control) this.UltraLabel2);
    this.GroupBox2.Controls.Add((Control) this.UltraLabel3);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox9);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox11);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox12);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox10);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox18);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox13);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox17);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox14);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox16);
    this.GroupBox2.Controls.Add((Control) this.MgaCheckBox15);
    this.GroupBox2.Location = new Point(326, 3);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(489, 157);
    this.GroupBox2.TabIndex = 0;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Interests Covered ";
    appearance38.BackColor = Color.Transparent;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance38;
    ((Control) this.UltraLabel1).Location = new Point(205, 19);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(113, 53);
    ((Control) this.UltraLabel1).TabIndex = 369;
    ((ControlBase) this.UltraLabel1).Text = "Your Interest and the Interest of Any Creditor Named As a Loss Payee";
    appearance39.BorderColor = Color.Gray;
    appearance39.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance39;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoIntSpecCauseLoss", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(17, 103);
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox1).TabIndex = 1;
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance40.BorderColor = Color.Gray;
    appearance40.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox2).Appearance = (AppearanceBase) appearance40;
    ((UltraToggleEditorBase) this.MgaCheckBox2).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox2).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox2).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoIntComprehensive", true));
    ((UltraToggleEditorBase) this.MgaCheckBox2).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox2).Location = new Point(17, 77);
    ((Control) this.MgaCheckBox2).Name = "MgaCheckBox2";
    ((Control) this.MgaCheckBox2).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox2).TabIndex = 0;
    ((UltraControlBase) this.MgaCheckBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance41.BackColor = Color.Transparent;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Left";
    ((ControlBase) this.ultraLabel28).Appearance = (AppearanceBase) appearance41;
    ((Control) this.ultraLabel28).Location = new Point(324, 19);
    ((Control) this.ultraLabel28).Name = "ultraLabel28";
    ((Control) this.ultraLabel28).Size = new Size(159, 60);
    ((Control) this.ultraLabel28).TabIndex = 368;
    ((ControlBase) this.ultraLabel28).Text = "All Interests in Any \"Auto\" Not Owned By You Or Any Creditor While In Your Possession on Consignment For Sale";
    appearance42.BackColor = Color.Transparent;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Left";
    ((ControlBase) this.UltraLabel2).Appearance = (AppearanceBase) appearance42;
    ((Control) this.UltraLabel2).Location = new Point(109, 19);
    ((Control) this.UltraLabel2).Name = "UltraLabel2";
    ((Control) this.UltraLabel2).Size = new Size(90, 42);
    ((Control) this.UltraLabel2).TabIndex = 370;
    ((ControlBase) this.UltraLabel2).Text = "Your Interest Only in Financed Covered \"Autos\"";
    appearance43.BackColor = Color.Transparent;
    ((AppearanceBase) appearance43).TextHAlignAsString = "Left";
    ((ControlBase) this.UltraLabel3).Appearance = (AppearanceBase) appearance43;
    ((Control) this.UltraLabel3).Location = new Point(6, 19);
    ((Control) this.UltraLabel3).Name = "UltraLabel3";
    ((Control) this.UltraLabel3).Size = new Size(90, 42);
    ((Control) this.UltraLabel3).TabIndex = 371;
    ((ControlBase) this.UltraLabel3).Text = "Your interest in Covered \"Autos\" you Own";
    appearance44.BorderColor = Color.Gray;
    appearance44.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox9).Appearance = (AppearanceBase) appearance44;
    ((UltraToggleEditorBase) this.MgaCheckBox9).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox9).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox9).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoConsignComprehensive", true));
    ((UltraToggleEditorBase) this.MgaCheckBox9).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox9).Location = new Point(352, 77);
    ((Control) this.MgaCheckBox9).Name = "MgaCheckBox9";
    ((Control) this.MgaCheckBox9).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox9).TabIndex = 9;
    ((UltraControlBase) this.MgaCheckBox9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox9).UseOsThemes = (DefaultableBoolean) 2;
    appearance45.BorderColor = Color.Gray;
    appearance45.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox11).Appearance = (AppearanceBase) appearance45;
    ((UltraToggleEditorBase) this.MgaCheckBox11).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox11).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox11).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoFinanceCollision", true));
    ((UltraToggleEditorBase) this.MgaCheckBox11).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox11).Location = new Point(125, 133);
    ((Control) this.MgaCheckBox11).Name = "MgaCheckBox11";
    ((Control) this.MgaCheckBox11).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox11).TabIndex = 5;
    ((UltraControlBase) this.MgaCheckBox11).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox11).UseOsThemes = (DefaultableBoolean) 2;
    appearance46.BorderColor = Color.Gray;
    appearance46.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox12).Appearance = (AppearanceBase) appearance46;
    ((UltraToggleEditorBase) this.MgaCheckBox12).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox12).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox12).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoConsignCollision", true));
    ((UltraToggleEditorBase) this.MgaCheckBox12).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox12).Location = new Point(352, 133);
    ((Control) this.MgaCheckBox12).Name = "MgaCheckBox12";
    ((Control) this.MgaCheckBox12).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox12).TabIndex = 11;
    ((UltraControlBase) this.MgaCheckBox12).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox12).UseOsThemes = (DefaultableBoolean) 2;
    appearance47.BorderColor = Color.Gray;
    appearance47.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox10).Appearance = (AppearanceBase) appearance47;
    ((UltraToggleEditorBase) this.MgaCheckBox10).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox10).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox10).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoLossPayeeCollision", true));
    ((UltraToggleEditorBase) this.MgaCheckBox10).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox10).Location = new Point(235, 133);
    ((Control) this.MgaCheckBox10).Name = "MgaCheckBox10";
    ((Control) this.MgaCheckBox10).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox10).TabIndex = 8;
    ((UltraControlBase) this.MgaCheckBox10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox10).UseOsThemes = (DefaultableBoolean) 2;
    appearance48.BorderColor = Color.Gray;
    appearance48.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox18).Appearance = (AppearanceBase) appearance48;
    ((UltraToggleEditorBase) this.MgaCheckBox18).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox18).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox18).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoConsignSpecCauseLoss", true));
    ((UltraToggleEditorBase) this.MgaCheckBox18).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox18).Location = new Point(352, 107);
    ((Control) this.MgaCheckBox18).Name = "MgaCheckBox18";
    ((Control) this.MgaCheckBox18).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox18).TabIndex = 10;
    ((UltraControlBase) this.MgaCheckBox18).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox18).UseOsThemes = (DefaultableBoolean) 2;
    appearance49.BorderColor = Color.Gray;
    appearance49.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox13).Appearance = (AppearanceBase) appearance49;
    ((UltraToggleEditorBase) this.MgaCheckBox13).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox13).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox13).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoIntCollision", true));
    ((UltraToggleEditorBase) this.MgaCheckBox13).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox13).Location = new Point(17, 133);
    ((Control) this.MgaCheckBox13).Name = "MgaCheckBox13";
    ((Control) this.MgaCheckBox13).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox13).TabIndex = 2;
    ((UltraControlBase) this.MgaCheckBox13).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox13).UseOsThemes = (DefaultableBoolean) 2;
    appearance50.BorderColor = Color.Gray;
    appearance50.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox17).Appearance = (AppearanceBase) appearance50;
    ((UltraToggleEditorBase) this.MgaCheckBox17).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox17).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox17).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoFinanceComprehensive", true));
    ((UltraToggleEditorBase) this.MgaCheckBox17).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox17).Location = new Point(125, 77);
    ((Control) this.MgaCheckBox17).Name = "MgaCheckBox17";
    ((Control) this.MgaCheckBox17).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox17).TabIndex = 3;
    ((UltraControlBase) this.MgaCheckBox17).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox17).UseOsThemes = (DefaultableBoolean) 2;
    appearance51.BorderColor = Color.Gray;
    appearance51.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox14).Appearance = (AppearanceBase) appearance51;
    ((UltraToggleEditorBase) this.MgaCheckBox14).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox14).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox14).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoFinanceSpecCauseLoss", true));
    ((UltraToggleEditorBase) this.MgaCheckBox14).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox14).Location = new Point(125, 105);
    ((Control) this.MgaCheckBox14).Name = "MgaCheckBox14";
    ((Control) this.MgaCheckBox14).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox14).TabIndex = 4;
    ((UltraControlBase) this.MgaCheckBox14).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox14).UseOsThemes = (DefaultableBoolean) 2;
    appearance52.BorderColor = Color.Gray;
    appearance52.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox16).Appearance = (AppearanceBase) appearance52;
    ((UltraToggleEditorBase) this.MgaCheckBox16).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox16).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox16).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoLossPayeeComprehensive", true));
    ((UltraToggleEditorBase) this.MgaCheckBox16).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox16).Location = new Point(235, 77);
    ((Control) this.MgaCheckBox16).Name = "MgaCheckBox16";
    ((Control) this.MgaCheckBox16).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox16).TabIndex = 6;
    ((UltraControlBase) this.MgaCheckBox16).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox16).UseOsThemes = (DefaultableBoolean) 2;
    appearance53.BorderColor = Color.Gray;
    appearance53.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox15).Appearance = (AppearanceBase) appearance53;
    ((UltraToggleEditorBase) this.MgaCheckBox15).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox15).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox15).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoLossPayeeSpecCauseLoss", true));
    ((UltraToggleEditorBase) this.MgaCheckBox15).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox15).Location = new Point(235, 107);
    ((Control) this.MgaCheckBox15).Name = "MgaCheckBox15";
    ((Control) this.MgaCheckBox15).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox15).TabIndex = 7;
    ((UltraControlBase) this.MgaCheckBox15).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox15).UseOsThemes = (DefaultableBoolean) 2;
    this.GroupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.GroupBox1.BackColor = Color.Transparent;
    this.GroupBox1.Controls.Add((Control) this.UltraLabel5);
    this.GroupBox1.Controls.Add((Control) this.MgaCheckBox6);
    this.GroupBox1.Controls.Add((Control) this.MgaCheckBox3);
    this.GroupBox1.Controls.Add((Control) this.MgaCheckBox4);
    this.GroupBox1.Controls.Add((Control) this.MgaCheckBox5);
    this.GroupBox1.Controls.Add((Control) this.MgaCheckBox7);
    this.GroupBox1.Controls.Add((Control) this.MgaCheckBox8);
    this.GroupBox1.Controls.Add((Control) this.UltraLabel4);
    this.GroupBox1.Location = new Point(128 /*0x80*/, 10);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(188, 151);
    this.GroupBox1.TabIndex = 17;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Types of \"Autos\"";
    appearance54.BackColor = Color.Transparent;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Left";
    ((ControlBase) this.UltraLabel5).Appearance = (AppearanceBase) appearance54;
    ((Control) this.UltraLabel5).Location = new Point(78, 20);
    ((Control) this.UltraLabel5).Name = "UltraLabel5";
    ((Control) this.UltraLabel5).Size = new Size(104, 42);
    ((Control) this.UltraLabel5).TabIndex = 373;
    ((ControlBase) this.UltraLabel5).Text = "Used \"Autos\", Demonstrators and Service Vehicles";
    ((Control) this.MgaCheckBox6).Anchor = AnchorStyles.None;
    appearance55.BorderColor = Color.Gray;
    appearance55.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox6).Appearance = (AppearanceBase) appearance55;
    ((UltraToggleEditorBase) this.MgaCheckBox6).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox6).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox6).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoNewComprehensive", true));
    ((UltraToggleEditorBase) this.MgaCheckBox6).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox6).Location = new Point(40, 66);
    ((Control) this.MgaCheckBox6).Name = "MgaCheckBox6";
    ((Control) this.MgaCheckBox6).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox6).TabIndex = 0;
    ((UltraControlBase) this.MgaCheckBox6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox6).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaCheckBox3).Anchor = AnchorStyles.None;
    appearance56.BorderColor = Color.Gray;
    appearance56.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox3).Appearance = (AppearanceBase) appearance56;
    ((UltraToggleEditorBase) this.MgaCheckBox3).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox3).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox3).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoUsedCollision", true));
    ((UltraToggleEditorBase) this.MgaCheckBox3).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox3).Location = new Point(117, 126);
    ((Control) this.MgaCheckBox3).Name = "MgaCheckBox3";
    ((Control) this.MgaCheckBox3).Size = new Size(19, 19);
    ((Control) this.MgaCheckBox3).TabIndex = 5;
    ((UltraControlBase) this.MgaCheckBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox3).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaCheckBox4).Anchor = AnchorStyles.None;
    appearance57.BorderColor = Color.Gray;
    appearance57.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox4).Appearance = (AppearanceBase) appearance57;
    ((UltraToggleEditorBase) this.MgaCheckBox4).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox4).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox4).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoNewSpecCauseLoss", true));
    ((UltraToggleEditorBase) this.MgaCheckBox4).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox4).Location = new Point(40, 100);
    ((Control) this.MgaCheckBox4).Name = "MgaCheckBox4";
    ((Control) this.MgaCheckBox4).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox4).TabIndex = 1;
    ((UltraControlBase) this.MgaCheckBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox4).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaCheckBox5).Anchor = AnchorStyles.None;
    appearance58.BorderColor = Color.Gray;
    appearance58.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox5).Appearance = (AppearanceBase) appearance58;
    ((UltraToggleEditorBase) this.MgaCheckBox5).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox5).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox5).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoUsedSpecCauseLoss", true));
    ((UltraToggleEditorBase) this.MgaCheckBox5).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox5).Location = new Point(117, 100);
    ((Control) this.MgaCheckBox5).Name = "MgaCheckBox5";
    ((Control) this.MgaCheckBox5).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox5).TabIndex = 4;
    ((UltraControlBase) this.MgaCheckBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox5).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaCheckBox7).Anchor = AnchorStyles.None;
    appearance59.BorderColor = Color.Gray;
    appearance59.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox7).Appearance = (AppearanceBase) appearance59;
    ((UltraToggleEditorBase) this.MgaCheckBox7).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox7).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox7).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoUsedComprehensive", true));
    ((UltraToggleEditorBase) this.MgaCheckBox7).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox7).Location = new Point(117, 68);
    ((Control) this.MgaCheckBox7).Name = "MgaCheckBox7";
    ((Control) this.MgaCheckBox7).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox7).TabIndex = 3;
    ((UltraControlBase) this.MgaCheckBox7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox7).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaCheckBox8).Anchor = AnchorStyles.None;
    appearance60.BorderColor = Color.Gray;
    appearance60.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox8).Appearance = (AppearanceBase) appearance60;
    ((UltraToggleEditorBase) this.MgaCheckBox8).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox8).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox8).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoNewCollision", true));
    ((UltraToggleEditorBase) this.MgaCheckBox8).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox8).Location = new Point(40, 126);
    ((Control) this.MgaCheckBox8).Name = "MgaCheckBox8";
    ((Control) this.MgaCheckBox8).Size = new Size(19, 24);
    ((Control) this.MgaCheckBox8).TabIndex = 2;
    ((UltraControlBase) this.MgaCheckBox8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox8).UseOsThemes = (DefaultableBoolean) 2;
    appearance61.BackColor = Color.Transparent;
    ((AppearanceBase) appearance61).TextHAlignAsString = "Left";
    ((ControlBase) this.UltraLabel4).Appearance = (AppearanceBase) appearance61;
    ((Control) this.UltraLabel4).Location = new Point(6, 20);
    ((Control) this.UltraLabel4).Name = "UltraLabel4";
    ((Control) this.UltraLabel4).Size = new Size(72, 17);
    ((Control) this.UltraLabel4).TabIndex = 372;
    ((ControlBase) this.UltraLabel4).Text = "New \"Autos\"";
    ((Control) this.MgaCheckBox22).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance62.BorderColor = Color.Gray;
    appearance62.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox22).Appearance = (AppearanceBase) appearance62;
    ((UltraToggleEditorBase) this.MgaCheckBox22).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox22).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox22).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoNonReportingBasis", true));
    ((UltraToggleEditorBase) this.MgaCheckBox22).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox22).Location = new Point(390, 172);
    ((Control) this.MgaCheckBox22).Name = "MgaCheckBox22";
    ((Control) this.MgaCheckBox22).Size = new Size(374, 16 /*0x10*/);
    ((Control) this.MgaCheckBox22).TabIndex = 392;
    ((UltraToggleEditorBase) this.MgaCheckBox22).Text = "NONREPORTING BASIS Stated limit of insurance shown above applies";
    ((UltraControlBase) this.MgaCheckBox22).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox22).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaCheckBox20).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance63.BorderColor = Color.Gray;
    appearance63.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox20).Appearance = (AppearanceBase) appearance63;
    ((UltraToggleEditorBase) this.MgaCheckBox20).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox20).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox20).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoMonthlyBasis", true));
    ((UltraToggleEditorBase) this.MgaCheckBox20).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox20).Location = new Point(177, 228);
    ((Control) this.MgaCheckBox20).Name = "MgaCheckBox20";
    ((Control) this.MgaCheckBox20).Size = new Size(211, 18);
    ((Control) this.MgaCheckBox20).TabIndex = 2;
    ((UltraToggleEditorBase) this.MgaCheckBox20).Text = "MONTHLY(Fifteenth of every month)";
    ((UltraControlBase) this.MgaCheckBox20).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox20).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaCheckBox21).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance64.BorderColor = Color.Gray;
    appearance64.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox21).Appearance = (AppearanceBase) appearance64;
    ((UltraToggleEditorBase) this.MgaCheckBox21).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox21).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox21).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoQuarterlyBasis", true));
    ((UltraToggleEditorBase) this.MgaCheckBox21).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox21).Location = new Point(177, 194);
    ((Control) this.MgaCheckBox21).Name = "MgaCheckBox21";
    ((Control) this.MgaCheckBox21).Size = new Size(350, 18);
    ((Control) this.MgaCheckBox21).TabIndex = 1;
    ((UltraToggleEditorBase) this.MgaCheckBox21).Text = "QUARTERLY  (fifteenth of the fourth month after policy begins)";
    ((UltraControlBase) this.MgaCheckBox21).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox21).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraLabel8).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance65.BackColor = Color.Transparent;
    ((AppearanceBase) appearance65).TextHAlignAsString = "Left";
    ((ControlBase) this.UltraLabel8).Appearance = (AppearanceBase) appearance65;
    ((Control) this.UltraLabel8).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    ((Control) this.UltraLabel8).Location = new Point(2, 194);
    ((Control) this.UltraLabel8).Name = "UltraLabel8";
    ((Control) this.UltraLabel8).Size = new Size(169, 17);
    ((Control) this.UltraLabel8).TabIndex = 388;
    ((ControlBase) this.UltraLabel8).Text = "YOUR REPORTING BASIS IS:";
    ((Control) this.MgaCheckBox19).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance66.BorderColor = Color.Gray;
    appearance66.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox19).Appearance = (AppearanceBase) appearance66;
    ((UltraToggleEditorBase) this.MgaCheckBox19).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox19).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox19).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblNetRateAdditionalData.AutoReportingBasis", true));
    ((UltraToggleEditorBase) this.MgaCheckBox19).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox19).Location = new Point(0, 172);
    ((Control) this.MgaCheckBox19).Name = "MgaCheckBox19";
    ((Control) this.MgaCheckBox19).Size = new Size(335, 16 /*0x10*/);
    ((Control) this.MgaCheckBox19).TabIndex = 387;
    ((UltraToggleEditorBase) this.MgaCheckBox19).Text = "REPORTING BASIS (Quarterly or Monthly as indicated below)";
    ((UltraControlBase) this.MgaCheckBox19).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox19).UseOsThemes = (DefaultableBoolean) 2;
    this.Label25.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Location = new Point(1, 80 /*0x50*/);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(81, 13);
    this.Label25.TabIndex = 46;
    this.Label25.Text = "Comprehensive";
    this.Label23.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    this.Label23.Location = new Point(3, 10);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(67, 13);
    this.Label23.TabIndex = 44;
    this.Label23.Text = "Coverages";
    this.Label22.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(1, 106);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(125, 13);
    this.Label22.TabIndex = 43;
    this.Label22.Text = "Specified Causes of Loss";
    this.Label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(1, 138);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(45, 13);
    this.Label21.TabIndex = 42;
    this.Label21.Text = "Collision";
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTxtStateUnEmp);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label40);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label27);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaCheckedListBox1);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(818, 280);
    appearance67.BackColor = Color.White;
    appearance67.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance67.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTxtStateUnEmp).Appearance = (AppearanceBase) appearance67;
    ((TextEditorControlBase) this.MgaTxtStateUnEmp).BackColor = Color.White;
    ((Control) this.MgaTxtStateUnEmp).DataBindings.Add(new Binding("Text", (object) this.ds, "tblNetRateAdditionalData.StateUnEmployment", true));
    ((Control) this.MgaTxtStateUnEmp).Location = new Point(437, 16 /*0x10*/);
    ((TextEditorControlBase) this.MgaTxtStateUnEmp).MaxLength = 30;
    this.MgaTxtStateUnEmp.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTxtStateUnEmp).Name = "MgaTxtStateUnEmp";
    ((Control) this.MgaTxtStateUnEmp).Size = new Size(200, 20);
    ((Control) this.MgaTxtStateUnEmp).TabIndex = 54;
    ((UltraControlBase) this.MgaTxtStateUnEmp).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTxtStateUnEmp).UseOsThemes = (DefaultableBoolean) 2;
    this.Label40.AutoSize = true;
    this.Label40.BackColor = Color.Transparent;
    this.Label40.Location = new Point(307, 20);
    this.Label40.Name = "Label40";
    this.Label40.Size = new Size(121, 13);
    this.Label40.TabIndex = 55;
    this.Label40.Text = "State Unemployment # ";
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Location = new Point(3, 16 /*0x10*/);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(132, 13);
    this.Label27.TabIndex = 47;
    this.Label27.Text = "Exlude Following State(s):";
    ((ListControl) this.MgaCheckedListBox1).FormattingEnabled = true;
    ((Control) this.MgaCheckedListBox1).Location = new Point(141, 16 /*0x10*/);
    ((Control) this.MgaCheckedListBox1).Name = "MgaCheckedListBox1";
    ((Control) this.MgaCheckedListBox1).Size = new Size(153, 228);
    ((Control) this.MgaCheckedListBox1).TabIndex = 18;
    this.daNRExtendedData.AcceptChangesDuringUpdate = false;
    this.daNRExtendedData.DeleteCommand = this.DbCommand2;
    this.daNRExtendedData.InsertCommand = this.DbCommand3;
    this.daNRExtendedData.SelectCommand = this.DbCommand4;
    this.daNRExtendedData.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblNetRateAdditionalData", new DataColumnMapping[60]
      {
        new DataColumnMapping("AutoliabSymbol", "AutoliabSymbol"),
        new DataColumnMapping("PIPSymbol", "PIPSymbol"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("AddnPIPSymbol", "AddnPIPSymbol"),
        new DataColumnMapping("PropProtectionSymbol", "PropProtectionSymbol"),
        new DataColumnMapping("MedPaySymbol", "MedPaySymbol"),
        new DataColumnMapping("UnInsSymbol", "UnInsSymbol"),
        new DataColumnMapping("UnderInsSymbol", "UnderInsSymbol"),
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("RejectedTerrorism", "RejectedTerrorism"),
        new DataColumnMapping("Terrorism", "Terrorism"),
        new DataColumnMapping("CoverageTypeID", "CoverageTypeID"),
        new DataColumnMapping("AutoReportingBasis", "AutoReportingBasis"),
        new DataColumnMapping("AutoNonReportingBasis", "AutoNonReportingBasis"),
        new DataColumnMapping("AutoQuarterlyBasis", "AutoQuarterlyBasis"),
        new DataColumnMapping("AutoMonthlyBasis", "AutoMonthlyBasis"),
        new DataColumnMapping("AutoNewComprehensive", "AutoNewComprehensive"),
        new DataColumnMapping("AutoNewSpecCauseLoss", "AutoNewSpecCauseLoss"),
        new DataColumnMapping("AutoNewCollision", "AutoNewCollision"),
        new DataColumnMapping("AutoUsedComprehensive", "AutoUsedComprehensive"),
        new DataColumnMapping("AutoUsedSpecCauseLoss", "AutoUsedSpecCauseLoss"),
        new DataColumnMapping("AutoUsedCollision", "AutoUsedCollision"),
        new DataColumnMapping("AutoIntComprehensive", "AutoIntComprehensive"),
        new DataColumnMapping("AutoIntSpecCauseLoss", "AutoIntSpecCauseLoss"),
        new DataColumnMapping("AutoIntCollision", "AutoIntCollision"),
        new DataColumnMapping("AutoFinanceComprehensive", "AutoFinanceComprehensive"),
        new DataColumnMapping("AutoFinanceSpecCauseLoss", "AutoFinanceSpecCauseLoss"),
        new DataColumnMapping("AutoFinanceCollision", "AutoFinanceCollision"),
        new DataColumnMapping("AutoLossPayeeComprehensive", "AutoLossPayeeComprehensive"),
        new DataColumnMapping("AutoLossPayeeSpecCauseLoss", "AutoLossPayeeSpecCauseLoss"),
        new DataColumnMapping("AutoLossPayeeCollision", "AutoLossPayeeCollision"),
        new DataColumnMapping("AutoConsignComprehensive", "AutoConsignComprehensive"),
        new DataColumnMapping("AutoConsignSpecCauseLoss", "AutoConsignSpecCauseLoss"),
        new DataColumnMapping("AutoConsignCollision", "AutoConsignCollision"),
        new DataColumnMapping("AutoComments", "AutoComments"),
        new DataColumnMapping("GaragekeepersSymbol", "GaragekeepersSymbol"),
        new DataColumnMapping("PhysDamCompSymbol", "PhysDamCompSymbol"),
        new DataColumnMapping("PhysDamCOLSymbol", "PhysDamCOLSymbol"),
        new DataColumnMapping("PhysDamCollSymbol", "PhysDamCollSymbol"),
        new DataColumnMapping("RetroDate", "RetroDate"),
        new DataColumnMapping("BodilyInjEachAcc", "BodilyInjEachAcc"),
        new DataColumnMapping("BodilyInjDiseaseAggLimit", "BodilyInjDiseaseAggLimit"),
        new DataColumnMapping("BodilyInjDiseaseEachEmpl", "BodilyInjDiseaseEachEmpl"),
        new DataColumnMapping("TowingSymbol", "TowingSymbol"),
        new DataColumnMapping("TrailerSymbol", "TrailerSymbol"),
        new DataColumnMapping("HiredAutoLimit", "HiredAutoLimit"),
        new DataColumnMapping("NonownedLiabilitySymbol", "NonownedLiabilitySymbol"),
        new DataColumnMapping("HiredAutoSymbol", "HiredAutoSymbol"),
        new DataColumnMapping("EndorseName", "EndorseName"),
        new DataColumnMapping("EndorseSymbol", "EndorseSymbol"),
        new DataColumnMapping("EndorseLimit", "EndorseLimit"),
        new DataColumnMapping("EndorseDeductible", "EndorseDeductible"),
        new DataColumnMapping("Receipts", "Receipts"),
        new DataColumnMapping("No_of_Empl", "No_of_Empl"),
        new DataColumnMapping("GL_Rate", "GL_Rate"),
        new DataColumnMapping("GL_Est_Premium", "GL_Est_Premium"),
        new DataColumnMapping("GL_Min_Premium", "GL_Min_Premium"),
        new DataColumnMapping("CompositeRated", "CompositeRated"),
        new DataColumnMapping("NumPoweredUnits", "NumPoweredUnits"),
        new DataColumnMapping("StateUnEmployment", "StateUnEmployment")
      })
    });
    this.daNRExtendedData.UpdateCommand = this.DbCommand5;
    this.DbCommand2.CommandText = componentResourceManager.GetString("DbCommand2.CommandText");
    this.DbCommand2.Connection = this.cn;
    this.DbCommand2.Parameters.AddRange((Array) new DbParameter[95]
    {
      DefaultDatabase.CreateParameter("@IsNull_AutoliabSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AutoliabSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoliabSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoliabSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PIPSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIPSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PIPSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PIPSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_QuoteGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_AddnPIPSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AddnPIPSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AddnPIPSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AddnPIPSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PropProtectionSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PropProtectionSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PropProtectionSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PropProtectionSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_MedPaySymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MedPaySymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_MedPaySymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "MedPaySymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_UnInsSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UnInsSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_UnInsSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UnInsSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_UnderInsSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UnderInsSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_UnderInsSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UnderInsSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_RejectedTerrorism", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RejectedTerrorism", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_RejectedTerrorism", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RejectedTerrorism", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_Terrorism", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Terrorism", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_Terrorism", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Terrorism", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_CoverageTypeID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CoverageTypeID", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_CoverageTypeID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CoverageTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoReportingBasis", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoReportingBasis", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoNonReportingBasis", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoNonReportingBasis", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoQuarterlyBasis", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoQuarterlyBasis", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoMonthlyBasis", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoMonthlyBasis", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoNewComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoNewComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoNewSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoNewSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoNewCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoNewCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoUsedComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoUsedComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoUsedSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoUsedSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoUsedCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoUsedCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoIntComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoIntComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoIntSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoIntSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoIntCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoIntCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoFinanceComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoFinanceComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoFinanceSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoFinanceSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoFinanceCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoFinanceCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoLossPayeeComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoLossPayeeComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoLossPayeeSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoLossPayeeSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoLossPayeeCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoLossPayeeCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoConsignComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoConsignComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoConsignSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoConsignSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoConsignCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoConsignCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_AutoComments", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AutoComments", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoComments", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoComments", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_GaragekeepersSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GaragekeepersSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_GaragekeepersSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GaragekeepersSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PhysDamCompSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PhysDamCompSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PhysDamCompSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PhysDamCompSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PhysDamCOLSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PhysDamCOLSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PhysDamCOLSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PhysDamCOLSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PhysDamCollSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PhysDamCollSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PhysDamCollSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PhysDamCollSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_RetroDate", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RetroDate", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_RetroDate", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RetroDate", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_BodilyInjEachAcc", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BodilyInjEachAcc", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_BodilyInjEachAcc", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BodilyInjEachAcc", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_BodilyInjDiseaseAggLimit", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BodilyInjDiseaseAggLimit", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_BodilyInjDiseaseAggLimit", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BodilyInjDiseaseAggLimit", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_BodilyInjDiseaseEachEmpl", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BodilyInjDiseaseEachEmpl", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_BodilyInjDiseaseEachEmpl", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BodilyInjDiseaseEachEmpl", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_TowingSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TowingSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_TowingSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TowingSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_TrailerSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TrailerSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_TrailerSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TrailerSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_HiredAutoLimit", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HiredAutoLimit", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_HiredAutoLimit", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "HiredAutoLimit", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_NonownedLiabilitySymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NonownedLiabilitySymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_NonownedLiabilitySymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NonownedLiabilitySymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_HiredAutoSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HiredAutoSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_HiredAutoSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "HiredAutoSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_EndorseName", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EndorseName", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_EndorseName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EndorseName", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_EndorseSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EndorseSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_EndorseSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EndorseSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_EndorseLimit", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EndorseLimit", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_EndorseLimit", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EndorseLimit", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_EndorseDeductible", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EndorseDeductible", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_EndorseDeductible", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EndorseDeductible", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_Receipts", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Receipts", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_Receipts", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Receipts", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_No_of_Empl", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "No_of_Empl", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_No_of_Empl", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "No_of_Empl", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_GL_Rate", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GL_Rate", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_GL_Rate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 4, "GL_Rate", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_GL_Est_Premium", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GL_Est_Premium", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_GL_Est_Premium", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GL_Est_Premium", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_GL_Min_Premium", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GL_Min_Premium", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_GL_Min_Premium", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GL_Min_Premium", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompositeRated", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompositeRated", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_NumPoweredUnits", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NumPoweredUnits", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_NumPoweredUnits", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NumPoweredUnits", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_StateUnEmployment", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StateUnEmployment", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_StateUnEmployment", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateUnEmployment", DataRowVersion.Original, (object) null)
    });
    this.cn = DefaultDatabase.CreateDbConnection();
    this.DbCommand3.CommandText = componentResourceManager.GetString("DbCommand3.CommandText");
    this.DbCommand3.Connection = this.cn;
    this.DbCommand3.Parameters.AddRange((Array) new DbParameter[59]
    {
      DefaultDatabase.CreateParameter("@AutoliabSymbol", SqlDbType.VarChar, 0, "AutoliabSymbol"),
      DefaultDatabase.CreateParameter("@PIPSymbol", SqlDbType.VarChar, 0, "PIPSymbol"),
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@AddnPIPSymbol", SqlDbType.VarChar, 0, "AddnPIPSymbol"),
      DefaultDatabase.CreateParameter("@PropProtectionSymbol", SqlDbType.VarChar, 0, "PropProtectionSymbol"),
      DefaultDatabase.CreateParameter("@MedPaySymbol", SqlDbType.VarChar, 0, "MedPaySymbol"),
      DefaultDatabase.CreateParameter("@UnInsSymbol", SqlDbType.VarChar, 0, "UnInsSymbol"),
      DefaultDatabase.CreateParameter("@UnderInsSymbol", SqlDbType.VarChar, 0, "UnderInsSymbol"),
      DefaultDatabase.CreateParameter("@RejectedTerrorism", SqlDbType.Money, 0, "RejectedTerrorism"),
      DefaultDatabase.CreateParameter("@Terrorism", SqlDbType.Money, 0, "Terrorism"),
      DefaultDatabase.CreateParameter("@CoverageTypeID", SqlDbType.Int, 0, "CoverageTypeID"),
      DefaultDatabase.CreateParameter("@AutoReportingBasis", SqlDbType.Bit, 0, "AutoReportingBasis"),
      DefaultDatabase.CreateParameter("@AutoNonReportingBasis", SqlDbType.Bit, 0, "AutoNonReportingBasis"),
      DefaultDatabase.CreateParameter("@AutoQuarterlyBasis", SqlDbType.Bit, 0, "AutoQuarterlyBasis"),
      DefaultDatabase.CreateParameter("@AutoMonthlyBasis", SqlDbType.Bit, 0, "AutoMonthlyBasis"),
      DefaultDatabase.CreateParameter("@AutoNewComprehensive", SqlDbType.Bit, 0, "AutoNewComprehensive"),
      DefaultDatabase.CreateParameter("@AutoNewSpecCauseLoss", SqlDbType.Bit, 0, "AutoNewSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoNewCollision", SqlDbType.Bit, 0, "AutoNewCollision"),
      DefaultDatabase.CreateParameter("@AutoUsedComprehensive", SqlDbType.Bit, 0, "AutoUsedComprehensive"),
      DefaultDatabase.CreateParameter("@AutoUsedSpecCauseLoss", SqlDbType.Bit, 0, "AutoUsedSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoUsedCollision", SqlDbType.Bit, 0, "AutoUsedCollision"),
      DefaultDatabase.CreateParameter("@AutoIntComprehensive", SqlDbType.Bit, 0, "AutoIntComprehensive"),
      DefaultDatabase.CreateParameter("@AutoIntSpecCauseLoss", SqlDbType.Bit, 0, "AutoIntSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoIntCollision", SqlDbType.Bit, 0, "AutoIntCollision"),
      DefaultDatabase.CreateParameter("@AutoFinanceComprehensive", SqlDbType.Bit, 0, "AutoFinanceComprehensive"),
      DefaultDatabase.CreateParameter("@AutoFinanceSpecCauseLoss", SqlDbType.Bit, 0, "AutoFinanceSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoFinanceCollision", SqlDbType.Bit, 0, "AutoFinanceCollision"),
      DefaultDatabase.CreateParameter("@AutoLossPayeeComprehensive", SqlDbType.Bit, 0, "AutoLossPayeeComprehensive"),
      DefaultDatabase.CreateParameter("@AutoLossPayeeSpecCauseLoss", SqlDbType.Bit, 0, "AutoLossPayeeSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoLossPayeeCollision", SqlDbType.Bit, 0, "AutoLossPayeeCollision"),
      DefaultDatabase.CreateParameter("@AutoConsignComprehensive", SqlDbType.Bit, 0, "AutoConsignComprehensive"),
      DefaultDatabase.CreateParameter("@AutoConsignSpecCauseLoss", SqlDbType.Bit, 0, "AutoConsignSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoConsignCollision", SqlDbType.Bit, 0, "AutoConsignCollision"),
      DefaultDatabase.CreateParameter("@AutoComments", SqlDbType.VarChar, 0, "AutoComments"),
      DefaultDatabase.CreateParameter("@GaragekeepersSymbol", SqlDbType.VarChar, 0, "GaragekeepersSymbol"),
      DefaultDatabase.CreateParameter("@PhysDamCompSymbol", SqlDbType.VarChar, 0, "PhysDamCompSymbol"),
      DefaultDatabase.CreateParameter("@PhysDamCOLSymbol", SqlDbType.VarChar, 0, "PhysDamCOLSymbol"),
      DefaultDatabase.CreateParameter("@PhysDamCollSymbol", SqlDbType.VarChar, 0, "PhysDamCollSymbol"),
      DefaultDatabase.CreateParameter("@RetroDate", SqlDbType.VarChar, 0, "RetroDate"),
      DefaultDatabase.CreateParameter("@BodilyInjEachAcc", SqlDbType.VarChar, 0, "BodilyInjEachAcc"),
      DefaultDatabase.CreateParameter("@BodilyInjDiseaseAggLimit", SqlDbType.VarChar, 0, "BodilyInjDiseaseAggLimit"),
      DefaultDatabase.CreateParameter("@BodilyInjDiseaseEachEmpl", SqlDbType.VarChar, 0, "BodilyInjDiseaseEachEmpl"),
      DefaultDatabase.CreateParameter("@TowingSymbol", SqlDbType.VarChar, 0, "TowingSymbol"),
      DefaultDatabase.CreateParameter("@TrailerSymbol", SqlDbType.VarChar, 0, "TrailerSymbol"),
      DefaultDatabase.CreateParameter("@HiredAutoLimit", SqlDbType.Money, 0, "HiredAutoLimit"),
      DefaultDatabase.CreateParameter("@NonownedLiabilitySymbol", SqlDbType.VarChar, 0, "NonownedLiabilitySymbol"),
      DefaultDatabase.CreateParameter("@HiredAutoSymbol", SqlDbType.VarChar, 0, "HiredAutoSymbol"),
      DefaultDatabase.CreateParameter("@EndorseName", SqlDbType.VarChar, 0, "EndorseName"),
      DefaultDatabase.CreateParameter("@EndorseSymbol", SqlDbType.VarChar, 0, "EndorseSymbol"),
      DefaultDatabase.CreateParameter("@EndorseLimit", SqlDbType.Money, 0, "EndorseLimit"),
      DefaultDatabase.CreateParameter("@EndorseDeductible", SqlDbType.Money, 0, "EndorseDeductible"),
      DefaultDatabase.CreateParameter("@Receipts", SqlDbType.Money, 0, "Receipts"),
      DefaultDatabase.CreateParameter("@No_of_Empl", SqlDbType.Int, 0, "No_of_Empl"),
      DefaultDatabase.CreateParameter("@GL_Rate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 4, "GL_Rate", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@GL_Est_Premium", SqlDbType.Money, 0, "GL_Est_Premium"),
      DefaultDatabase.CreateParameter("@GL_Min_Premium", SqlDbType.Money, 0, "GL_Min_Premium"),
      DefaultDatabase.CreateParameter("@CompositeRated", SqlDbType.Bit, 0, "CompositeRated"),
      DefaultDatabase.CreateParameter("@NumPoweredUnits", SqlDbType.Int, 0, "NumPoweredUnits"),
      DefaultDatabase.CreateParameter("@StateUnEmployment", SqlDbType.VarChar, 0, "StateUnEmployment")
    });
    this.DbCommand4.CommandText = componentResourceManager.GetString("DbCommand4.CommandText");
    this.DbCommand4.Connection = this.cn;
    this.DbCommand4.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.DbCommand5.CommandText = componentResourceManager.GetString("DbCommand5.CommandText");
    this.DbCommand5.Connection = this.cn;
    this.DbCommand5.Parameters.AddRange((Array) new DbParameter[155]
    {
      DefaultDatabase.CreateParameter("@AutoliabSymbol", SqlDbType.VarChar, 0, "AutoliabSymbol"),
      DefaultDatabase.CreateParameter("@PIPSymbol", SqlDbType.VarChar, 0, "PIPSymbol"),
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@AddnPIPSymbol", SqlDbType.VarChar, 0, "AddnPIPSymbol"),
      DefaultDatabase.CreateParameter("@PropProtectionSymbol", SqlDbType.VarChar, 0, "PropProtectionSymbol"),
      DefaultDatabase.CreateParameter("@MedPaySymbol", SqlDbType.VarChar, 0, "MedPaySymbol"),
      DefaultDatabase.CreateParameter("@UnInsSymbol", SqlDbType.VarChar, 0, "UnInsSymbol"),
      DefaultDatabase.CreateParameter("@UnderInsSymbol", SqlDbType.VarChar, 0, "UnderInsSymbol"),
      DefaultDatabase.CreateParameter("@RejectedTerrorism", SqlDbType.Money, 0, "RejectedTerrorism"),
      DefaultDatabase.CreateParameter("@Terrorism", SqlDbType.Money, 0, "Terrorism"),
      DefaultDatabase.CreateParameter("@CoverageTypeID", SqlDbType.Int, 0, "CoverageTypeID"),
      DefaultDatabase.CreateParameter("@AutoReportingBasis", SqlDbType.Bit, 0, "AutoReportingBasis"),
      DefaultDatabase.CreateParameter("@AutoNonReportingBasis", SqlDbType.Bit, 0, "AutoNonReportingBasis"),
      DefaultDatabase.CreateParameter("@AutoQuarterlyBasis", SqlDbType.Bit, 0, "AutoQuarterlyBasis"),
      DefaultDatabase.CreateParameter("@AutoMonthlyBasis", SqlDbType.Bit, 0, "AutoMonthlyBasis"),
      DefaultDatabase.CreateParameter("@AutoNewComprehensive", SqlDbType.Bit, 0, "AutoNewComprehensive"),
      DefaultDatabase.CreateParameter("@AutoNewSpecCauseLoss", SqlDbType.Bit, 0, "AutoNewSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoNewCollision", SqlDbType.Bit, 0, "AutoNewCollision"),
      DefaultDatabase.CreateParameter("@AutoUsedComprehensive", SqlDbType.Bit, 0, "AutoUsedComprehensive"),
      DefaultDatabase.CreateParameter("@AutoUsedSpecCauseLoss", SqlDbType.Bit, 0, "AutoUsedSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoUsedCollision", SqlDbType.Bit, 0, "AutoUsedCollision"),
      DefaultDatabase.CreateParameter("@AutoIntComprehensive", SqlDbType.Bit, 0, "AutoIntComprehensive"),
      DefaultDatabase.CreateParameter("@AutoIntSpecCauseLoss", SqlDbType.Bit, 0, "AutoIntSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoIntCollision", SqlDbType.Bit, 0, "AutoIntCollision"),
      DefaultDatabase.CreateParameter("@AutoFinanceComprehensive", SqlDbType.Bit, 0, "AutoFinanceComprehensive"),
      DefaultDatabase.CreateParameter("@AutoFinanceSpecCauseLoss", SqlDbType.Bit, 0, "AutoFinanceSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoFinanceCollision", SqlDbType.Bit, 0, "AutoFinanceCollision"),
      DefaultDatabase.CreateParameter("@AutoLossPayeeComprehensive", SqlDbType.Bit, 0, "AutoLossPayeeComprehensive"),
      DefaultDatabase.CreateParameter("@AutoLossPayeeSpecCauseLoss", SqlDbType.Bit, 0, "AutoLossPayeeSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoLossPayeeCollision", SqlDbType.Bit, 0, "AutoLossPayeeCollision"),
      DefaultDatabase.CreateParameter("@AutoConsignComprehensive", SqlDbType.Bit, 0, "AutoConsignComprehensive"),
      DefaultDatabase.CreateParameter("@AutoConsignSpecCauseLoss", SqlDbType.Bit, 0, "AutoConsignSpecCauseLoss"),
      DefaultDatabase.CreateParameter("@AutoConsignCollision", SqlDbType.Bit, 0, "AutoConsignCollision"),
      DefaultDatabase.CreateParameter("@AutoComments", SqlDbType.VarChar, 0, "AutoComments"),
      DefaultDatabase.CreateParameter("@GaragekeepersSymbol", SqlDbType.VarChar, 0, "GaragekeepersSymbol"),
      DefaultDatabase.CreateParameter("@PhysDamCompSymbol", SqlDbType.VarChar, 0, "PhysDamCompSymbol"),
      DefaultDatabase.CreateParameter("@PhysDamCOLSymbol", SqlDbType.VarChar, 0, "PhysDamCOLSymbol"),
      DefaultDatabase.CreateParameter("@PhysDamCollSymbol", SqlDbType.VarChar, 0, "PhysDamCollSymbol"),
      DefaultDatabase.CreateParameter("@RetroDate", SqlDbType.VarChar, 0, "RetroDate"),
      DefaultDatabase.CreateParameter("@BodilyInjEachAcc", SqlDbType.VarChar, 0, "BodilyInjEachAcc"),
      DefaultDatabase.CreateParameter("@BodilyInjDiseaseAggLimit", SqlDbType.VarChar, 0, "BodilyInjDiseaseAggLimit"),
      DefaultDatabase.CreateParameter("@BodilyInjDiseaseEachEmpl", SqlDbType.VarChar, 0, "BodilyInjDiseaseEachEmpl"),
      DefaultDatabase.CreateParameter("@TowingSymbol", SqlDbType.VarChar, 0, "TowingSymbol"),
      DefaultDatabase.CreateParameter("@TrailerSymbol", SqlDbType.VarChar, 0, "TrailerSymbol"),
      DefaultDatabase.CreateParameter("@HiredAutoLimit", SqlDbType.Money, 0, "HiredAutoLimit"),
      DefaultDatabase.CreateParameter("@NonownedLiabilitySymbol", SqlDbType.VarChar, 0, "NonownedLiabilitySymbol"),
      DefaultDatabase.CreateParameter("@HiredAutoSymbol", SqlDbType.VarChar, 0, "HiredAutoSymbol"),
      DefaultDatabase.CreateParameter("@EndorseName", SqlDbType.VarChar, 0, "EndorseName"),
      DefaultDatabase.CreateParameter("@EndorseSymbol", SqlDbType.VarChar, 0, "EndorseSymbol"),
      DefaultDatabase.CreateParameter("@EndorseLimit", SqlDbType.Money, 0, "EndorseLimit"),
      DefaultDatabase.CreateParameter("@EndorseDeductible", SqlDbType.Money, 0, "EndorseDeductible"),
      DefaultDatabase.CreateParameter("@Receipts", SqlDbType.Money, 0, "Receipts"),
      DefaultDatabase.CreateParameter("@No_of_Empl", SqlDbType.Int, 0, "No_of_Empl"),
      DefaultDatabase.CreateParameter("@GL_Rate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 4, "GL_Rate", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@GL_Est_Premium", SqlDbType.Money, 0, "GL_Est_Premium"),
      DefaultDatabase.CreateParameter("@GL_Min_Premium", SqlDbType.Money, 0, "GL_Min_Premium"),
      DefaultDatabase.CreateParameter("@CompositeRated", SqlDbType.Bit, 0, "CompositeRated"),
      DefaultDatabase.CreateParameter("@NumPoweredUnits", SqlDbType.Int, 0, "NumPoweredUnits"),
      DefaultDatabase.CreateParameter("@StateUnEmployment", SqlDbType.VarChar, 0, "StateUnEmployment"),
      DefaultDatabase.CreateParameter("@IsNull_AutoliabSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AutoliabSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoliabSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoliabSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PIPSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIPSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PIPSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PIPSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_QuoteGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_AddnPIPSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AddnPIPSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AddnPIPSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AddnPIPSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PropProtectionSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PropProtectionSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PropProtectionSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PropProtectionSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_MedPaySymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MedPaySymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_MedPaySymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "MedPaySymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_UnInsSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UnInsSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_UnInsSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UnInsSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_UnderInsSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UnderInsSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_UnderInsSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UnderInsSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_RejectedTerrorism", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RejectedTerrorism", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_RejectedTerrorism", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RejectedTerrorism", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_Terrorism", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Terrorism", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_Terrorism", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Terrorism", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_CoverageTypeID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CoverageTypeID", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_CoverageTypeID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CoverageTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoReportingBasis", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoReportingBasis", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoNonReportingBasis", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoNonReportingBasis", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoQuarterlyBasis", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoQuarterlyBasis", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoMonthlyBasis", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoMonthlyBasis", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoNewComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoNewComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoNewSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoNewSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoNewCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoNewCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoUsedComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoUsedComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoUsedSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoUsedSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoUsedCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoUsedCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoIntComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoIntComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoIntSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoIntSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoIntCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoIntCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoFinanceComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoFinanceComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoFinanceSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoFinanceSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoFinanceCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoFinanceCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoLossPayeeComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoLossPayeeComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoLossPayeeSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoLossPayeeSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoLossPayeeCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoLossPayeeCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoConsignComprehensive", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoConsignComprehensive", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoConsignSpecCauseLoss", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoConsignSpecCauseLoss", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoConsignCollision", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoConsignCollision", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_AutoComments", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AutoComments", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AutoComments", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoComments", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_GaragekeepersSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GaragekeepersSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_GaragekeepersSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GaragekeepersSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PhysDamCompSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PhysDamCompSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PhysDamCompSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PhysDamCompSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PhysDamCOLSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PhysDamCOLSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PhysDamCOLSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PhysDamCOLSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_PhysDamCollSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PhysDamCollSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_PhysDamCollSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PhysDamCollSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_RetroDate", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RetroDate", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_RetroDate", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RetroDate", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_BodilyInjEachAcc", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BodilyInjEachAcc", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_BodilyInjEachAcc", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BodilyInjEachAcc", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_BodilyInjDiseaseAggLimit", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BodilyInjDiseaseAggLimit", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_BodilyInjDiseaseAggLimit", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BodilyInjDiseaseAggLimit", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_BodilyInjDiseaseEachEmpl", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BodilyInjDiseaseEachEmpl", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_BodilyInjDiseaseEachEmpl", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BodilyInjDiseaseEachEmpl", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_TowingSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TowingSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_TowingSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TowingSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_TrailerSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TrailerSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_TrailerSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TrailerSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_HiredAutoLimit", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HiredAutoLimit", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_HiredAutoLimit", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "HiredAutoLimit", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_NonownedLiabilitySymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NonownedLiabilitySymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_NonownedLiabilitySymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NonownedLiabilitySymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_HiredAutoSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HiredAutoSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_HiredAutoSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "HiredAutoSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_EndorseName", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EndorseName", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_EndorseName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EndorseName", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_EndorseSymbol", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EndorseSymbol", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_EndorseSymbol", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EndorseSymbol", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_EndorseLimit", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EndorseLimit", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_EndorseLimit", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EndorseLimit", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_EndorseDeductible", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EndorseDeductible", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_EndorseDeductible", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EndorseDeductible", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_Receipts", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Receipts", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_Receipts", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Receipts", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_No_of_Empl", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "No_of_Empl", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_No_of_Empl", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "No_of_Empl", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_GL_Rate", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GL_Rate", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_GL_Rate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 4, "GL_Rate", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_GL_Est_Premium", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GL_Est_Premium", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_GL_Est_Premium", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GL_Est_Premium", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_GL_Min_Premium", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GL_Min_Premium", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_GL_Min_Premium", SqlDbType.Money, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GL_Min_Premium", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompositeRated", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompositeRated", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_NumPoweredUnits", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NumPoweredUnits", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_NumPoweredUnits", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NumPoweredUnits", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_StateUnEmployment", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StateUnEmployment", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_StateUnEmployment", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateUnEmployment", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabAdditonalData);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabRejected);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabGeneralLiability);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabAuto);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Location = new Point(12, 12);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.btnSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(820, 307);
    ((Control) this.UltraTabControl1).TabIndex = 16 /*0x10*/;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    appearance68.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance68.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance68;
    ultraTab1.TabPage = this.tabAdditonalData;
    ultraTab1.Text = "NetRate Additional Information";
    appearance69.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance69.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance69;
    ultraTab2.TabPage = this.tabRejected;
    ultraTab2.Text = "Terrorism / Rejected Terrorism";
    appearance70.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance70.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance70;
    ultraTab3.FixedWidth = 150;
    ultraTab3.TabPage = this.tabGeneralLiability;
    ultraTab3.Text = "General Liability";
    appearance71.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance71.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance71;
    ultraTab4.FixedWidth = 150;
    ultraTab4.TabPage = this.tabAuto;
    ultraTab4.Text = "Auto";
    appearance72.Image = (object) strings.TrafficCone;
    ultraTab5.Appearance = (AppearanceBase) appearance72;
    ultraTab5.FixedWidth = 120;
    ultraTab5.TabPage = this.UltraTabPageControl1;
    ultraTab5.Text = "Worker's Comp";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[5]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(200, 25);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(818, 280);
    this.ErrorP.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(844, 328);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormNetrateAdditionalInfo);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Netrate Additional Information";
    ((Control) this.tabAdditonalData).ResumeLayout(false);
    ((Control) this.tabAdditonalData).PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    ((ISupportInitialize) this.MgaNumericEditor3).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgaNumericEditor2).EndInit();
    ((ISupportInitialize) this.MgaTextBox10).EndInit();
    ((ISupportInitialize) this.MgaTextBox9).EndInit();
    ((ISupportInitialize) this.MgaTextBox7).EndInit();
    ((ISupportInitialize) this.MgaTextBox8).EndInit();
    ((ISupportInitialize) this.txtTrailerSymbol).EndInit();
    ((ISupportInitialize) this.txtTowingSymbol).EndInit();
    ((ISupportInitialize) this.MgaTextBox3).EndInit();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    ((ISupportInitialize) this.txtAddedPIPSymbol).EndInit();
    ((ISupportInitialize) this.txtLiabilitySymbol).EndInit();
    ((ISupportInitialize) this.txtPIPSymbol).EndInit();
    ((ISupportInitialize) this.txtCollisionSymbol).EndInit();
    ((ISupportInitialize) this.txtPropertyProtectionSymbol).EndInit();
    ((ISupportInitialize) this.txtComprehensiveSymbol).EndInit();
    ((ISupportInitialize) this.txtMedicalPaymentsSymbol).EndInit();
    ((ISupportInitialize) this.txtUnderinsuredMotoristSymbol).EndInit();
    ((ISupportInitialize) this.txtUninsuredMotoristSymbol).EndInit();
    ((Control) this.tabRejected).ResumeLayout(false);
    ((Control) this.tabRejected).PerformLayout();
    ((ISupportInitialize) this.numTerrorism).EndInit();
    ((ISupportInitialize) this.numRejectedTerrorism).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((Control) this.tabGeneralLiability).ResumeLayout(false);
    ((Control) this.tabGeneralLiability).PerformLayout();
    ((ISupportInitialize) this.numGL_Min_Premium).EndInit();
    ((ISupportInitialize) this.numGL_Est_Premium).EndInit();
    ((ISupportInitialize) this.numGL_Rate).EndInit();
    ((ISupportInitialize) this.numNo_of_Empl).EndInit();
    ((ISupportInitialize) this.numReceipts).EndInit();
    ((ISupportInitialize) this.MgaTextBox6).EndInit();
    ((ISupportInitialize) this.MgaTextBox5).EndInit();
    ((ISupportInitialize) this.MgaTextBox4).EndInit();
    ((ISupportInitialize) this.txtRetroDate).EndInit();
    ((ISupportInitialize) this.cboCoverageType).EndInit();
    ((Control) this.tabAuto).ResumeLayout(false);
    ((Control) this.tabAuto).PerformLayout();
    ((ISupportInitialize) this.numPoweredUnits).EndInit();
    ((ISupportInitialize) this.chkCompositeRated).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    this.GroupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.MgaCheckBox2).EndInit();
    ((ISupportInitialize) this.MgaCheckBox9).EndInit();
    ((ISupportInitialize) this.MgaCheckBox11).EndInit();
    ((ISupportInitialize) this.MgaCheckBox12).EndInit();
    ((ISupportInitialize) this.MgaCheckBox10).EndInit();
    ((ISupportInitialize) this.MgaCheckBox18).EndInit();
    ((ISupportInitialize) this.MgaCheckBox13).EndInit();
    ((ISupportInitialize) this.MgaCheckBox17).EndInit();
    ((ISupportInitialize) this.MgaCheckBox14).EndInit();
    ((ISupportInitialize) this.MgaCheckBox16).EndInit();
    ((ISupportInitialize) this.MgaCheckBox15).EndInit();
    this.GroupBox1.ResumeLayout(false);
    ((ISupportInitialize) this.MgaCheckBox6).EndInit();
    ((ISupportInitialize) this.MgaCheckBox3).EndInit();
    ((ISupportInitialize) this.MgaCheckBox4).EndInit();
    ((ISupportInitialize) this.MgaCheckBox5).EndInit();
    ((ISupportInitialize) this.MgaCheckBox7).EndInit();
    ((ISupportInitialize) this.MgaCheckBox8).EndInit();
    ((ISupportInitialize) this.MgaCheckBox22).EndInit();
    ((ISupportInitialize) this.MgaCheckBox20).EndInit();
    ((ISupportInitialize) this.MgaCheckBox21).EndInit();
    ((ISupportInitialize) this.MgaCheckBox19).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.MgaTxtStateUnEmp).EndInit();
    ((ISupportInitialize) this.MgaCheckedListBox1).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.ErrorP).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("daNRExtendedData")]
  private virtual DbDataAdapter daNRExtendedData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand2")]
  private virtual DbCommand DbCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand4")]
  private virtual DbCommand DbCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand5")]
  private virtual DbCommand DbCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  private virtual DbConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsNetRateAdditionalInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numTerrorism")]
  private virtual MGANumericEditor numTerrorism { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numRejectedTerrorism")]
  private virtual MGANumericEditor numRejectedTerrorism { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabGeneralLiability")]
  protected virtual UltraTabPageControl tabGeneralLiability { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelInformation")]
  protected virtual Label labelInformation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox8")]
  private virtual MGACheckBox MgaCheckBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox7")]
  private virtual MGACheckBox MgaCheckBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox5")]
  private virtual MGACheckBox MgaCheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox4")]
  private virtual MGACheckBox MgaCheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox3")]
  private virtual MGACheckBox MgaCheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox2")]
  private virtual MGACheckBox MgaCheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  private virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox6")]
  private virtual MGACheckBox MgaCheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel5")]
  private virtual UltraLabel UltraLabel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel4")]
  private virtual UltraLabel UltraLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel3")]
  private virtual UltraLabel UltraLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel2")]
  private virtual UltraLabel UltraLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel1")]
  private virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox17")]
  private virtual MGACheckBox MgaCheckBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox16")]
  private virtual MGACheckBox MgaCheckBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox15")]
  private virtual MGACheckBox MgaCheckBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox14")]
  private virtual MGACheckBox MgaCheckBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox13")]
  private virtual MGACheckBox MgaCheckBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox11")]
  private virtual MGACheckBox MgaCheckBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox10")]
  private virtual MGACheckBox MgaCheckBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTowingSymbol")]
  private virtual Label lblTowingSymbol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTowingSymbol")]
  protected virtual MGATextBox txtTowingSymbol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabAdditonalData")]
  protected virtual UltraTabPageControl tabAdditonalData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTrailerSymbol")]
  protected virtual MGATextBox txtTrailerSymbol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  private virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckedListBox1")]
  internal virtual MGACheckedListBox MgaCheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  private virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox7")]
  protected virtual MGATextBox MgaTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  private virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox8")]
  protected virtual MGATextBox MgaTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox3")]
  protected virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label33")]
  private virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor2")]
  private virtual MGANumericEditor MgaNumericEditor2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  private virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox10")]
  private virtual MGATextBox MgaTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  private virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox9")]
  private virtual MGATextBox MgaTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  private virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor3")]
  private virtual MGANumericEditor MgaNumericEditor3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkTestSymbolAutomation
  {
    get => this._lnkTestSymbolAutomation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkTestSymbolAutomation_LinkClicked);
      LinkLabel symbolAutomation1 = this._lnkTestSymbolAutomation;
      if (symbolAutomation1 != null)
        symbolAutomation1.LinkClicked -= clickedEventHandler;
      this._lnkTestSymbolAutomation = value;
      LinkLabel symbolAutomation2 = this._lnkTestSymbolAutomation;
      if (symbolAutomation2 == null)
        return;
      symbolAutomation2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkAutoFillSymbols
  {
    get => this._lnkAutoFillSymbols;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAutoFillSymbols_LinkClicked);
      LinkLabel lnkAutoFillSymbols1 = this._lnkAutoFillSymbols;
      if (lnkAutoFillSymbols1 != null)
        lnkAutoFillSymbols1.LinkClicked -= clickedEventHandler;
      this._lnkAutoFillSymbols = value;
      LinkLabel lnkAutoFillSymbols2 = this._lnkAutoFillSymbols;
      if (lnkAutoFillSymbols2 == null)
        return;
      lnkAutoFillSymbols2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("numNo_of_Empl")]
  protected virtual MGANumericEditor numNo_of_Empl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
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

  [field: AccessedThroughProperty("ErrorP")]
  protected internal virtual ErrorProvider ErrorP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabRejected")]
  protected virtual UltraTabPageControl tabRejected { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  protected virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabAuto")]
  protected virtual UltraTabPageControl tabAuto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCoverageType")]
  protected virtual MGASimpleComboBox cboCoverageType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRetroDate")]
  protected virtual MGATextBox txtRetroDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox6")]
  protected virtual MGATextBox MgaTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox5")]
  protected virtual MGATextBox MgaTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox4")]
  protected virtual MGATextBox MgaTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  protected virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  protected virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  protected virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  protected virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  protected virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  protected virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numReceipts")]
  protected virtual MGANumericEditor numReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label35")]
  protected virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label39")]
  protected virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numGL_Min_Premium")]
  protected virtual MGANumericEditor numGL_Min_Premium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label38")]
  protected virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numGL_Est_Premium")]
  protected virtual MGANumericEditor numGL_Est_Premium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label37")]
  protected virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numGL_Rate")]
  protected virtual MGANumericEditor numGL_Rate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  protected virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  protected virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  protected virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  protected virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  protected virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox21")]
  protected virtual MGACheckBox MgaCheckBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel8")]
  protected virtual UltraLabel UltraLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox19")]
  protected virtual MGACheckBox MgaCheckBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox22")]
  protected virtual MGACheckBox MgaCheckBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox20")]
  protected virtual MGACheckBox MgaCheckBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  protected virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  protected virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  protected virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel9")]
  protected virtual UltraLabel UltraLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label28")]
  protected virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor1")]
  protected virtual MGANumericEditor MgaNumericEditor1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel6")]
  protected virtual UltraLabel UltraLabel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numPoweredUnits")]
  protected virtual MGANumericEditor numPoweredUnits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCompositeRated")]
  protected virtual MGACheckBox chkCompositeRated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTxtStateUnEmp")]
  protected virtual MGATextBox MgaTxtStateUnEmp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label40")]
  protected virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel28")]
  protected virtual UltraLabel ultraLabel28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox18")]
  protected virtual MGACheckBox MgaCheckBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox12")]
  protected virtual MGACheckBox MgaCheckBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox9")]
  protected virtual MGACheckBox MgaCheckBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_bmb")]
  private virtual BindingManagerBase _bmb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormNetrateAdditionalInfo(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormNetrateAdditionalInfo_Load);
    this.tblExcludedStates = new DataTable("ExcludedStates");
    this.InitializeComponent();
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    this._quote = new Quote(quoteGuid);
    this._isBound = this._quote.IsBound;
    this._isIssued = this._quote.IsIssued;
  }

  public FormNetrateAdditionalInfo()
  {
    this.Load += new EventHandler(this.FormNetrateAdditionalInfo_Load);
    this.tblExcludedStates = new DataTable("ExcludedStates");
    this.InitializeComponent();
  }

  protected virtual void EnableItems(bool value)
  {
    this.EnableItems(value, this.tabAdditonalData);
    ((Control) this.MgaTextBox9).Enabled = value;
    ((Control) this.MgaTextBox10).Enabled = value;
    ((Control) this.MgaNumericEditor2).Enabled = value;
    ((Control) this.MgaNumericEditor3).Enabled = value;
    this.EnableItems(value, this.tabRejected);
    this.EnableItems(value, this.tabGeneralLiability);
  }

  protected virtual void EnableItems(bool value, UltraTabPageControl pgCtrl)
  {
    try
    {
      foreach (Control control in ((Control) pgCtrl).Controls)
      {
        if (control is MGATextBox mgaTextBox)
          ((Control) mgaTextBox).Enabled = value;
        if (control is MGANumericEditor mgaNumericEditor)
          ((Control) mgaNumericEditor).Enabled = value;
        if (control is MGASimpleComboBox mgaSimpleComboBox)
          ((Control) mgaSimpleComboBox).Enabled = value;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void FormNetrateAdditionalInfo_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    if (!SystemSettings.GetBoolSetting("SymbolAutomation"))
    {
      this.lnkAutoFillSymbols.Visible = false;
      this.lnkTestSymbolAutomation.Visible = false;
    }
    if (!SecurityManager.Instance.AssertPermission("{8FDE1A5D-5144-406d-B782-88729DB5DE6B}"))
      this.lnkAutoFillSymbols.Visible = false;
    if (!SecurityManager.Instance.AssertPermission("{38181B55-03C8-4805-8583-DD7543518FA5}"))
      this.lnkTestSymbolAutomation.Visible = false;
    dsNetRateAdditionalInfo.lstGLCoverageTypeRow row = this.ds.lstGLCoverageType.NewlstGLCoverageTypeRow();
    row.CoverageType = string.Empty;
    this.ds.lstGLCoverageType.AddlstGLCoverageTypeRow(row);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstGLCoverageType"
    }, CommandType.Text, "SELECT ID, CoverageType FROM lstGLCoverageType ORDER BY CoverageType");
    this.daNRExtendedData.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    DefaultDatabase.DataAdapterFill(this.daNRExtendedData, (DataTable) this.ds.tblNetRateAdditionalData);
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblNetRateAdditionalData.TableName];
    this.SetUpForm();
    try
    {
      this._bmb.SuspendBinding();
      if (this.ds.tblNetRateAdditionalData.Rows.Count > 0)
      {
        RichTextBox richTextBox = new RichTextBox();
        try
        {
          richTextBox.Rtf = this.ds.tblNetRateAdditionalData.Rows[0]["AdditionalComments"].ToString();
          this.ds.tblNetRateAdditionalData.Rows[0]["AdditionalComments"] = (object) richTextBox.Text.Replace("\n", "\r\n");
        }
        catch (ArgumentException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        finally
        {
          richTextBox.Dispose();
        }
        if (this.ds.tblNetRateAdditionalData[0].IsRetroDateNull())
          this.ds.tblNetRateAdditionalData[0].RetroDate = "None";
      }
      else
      {
        dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow defaultRow = this.ds.tblNetRateAdditionalData.NewtblNetRateAdditionalDataRow();
        defaultRow.RetroDate = "None";
        defaultRow.QuoteGuid = this._quote.QuoteGuid;
        this.SetFormDefaults(ref defaultRow, this._quote.QuoteGuid);
        this.ds.tblNetRateAdditionalData.AddtblNetRateAdditionalDataRow(defaultRow);
      }
      if (this.EnableFormOnSystemSetting())
      {
        this.EnableItems(true, this.tabAdditonalData);
        this.EnableItems(true, this.tabRejected);
        this.EnableItems(true, this.tabGeneralLiability);
        this.EnableItems(true, this.tabAuto);
        this.EnableItems(true, this.UltraTabPageControl1);
        ((Control) this.MgaTextBox9).Enabled = true;
        ((Control) this.MgaTextBox10).Enabled = true;
        ((Control) this.MgaNumericEditor2).Enabled = true;
        ((Control) this.MgaNumericEditor3).Enabled = true;
        ((Control) this.btnSave).Enabled = true;
        this.labelInformation.Visible = false;
      }
      this.PopulateWCTab();
      this.AfterFormLoad();
    }
    finally
    {
      this._bmb.ResumeBinding();
    }
  }

  private bool EnableFormOnSystemSetting()
  {
    return SystemSettings.KeyExists("EnableAddlInfoFormOnBoundNotIssued") && SystemSettings.GetBoolSetting("EnableAddlInfoFormOnBoundNotIssued") && this._isBound && !this._isIssued || SystemSettings.KeyExists("EnableAddlInfoFormWhenBoundAndIssued") && SystemSettings.GetBoolSetting("EnableAddlInfoFormWhenBoundAndIssued") && this._isBound && this._isIssued || SystemSettings.KeyExists("EditPostBindNetRateAdditionalInfo") && SystemSettings.GetBoolSetting("EditPostBindNetRateAdditionalInfo") && this._isBound && !this._quote.PolicyIsIssued;
  }

  private void PopulateWCTab()
  {
    this.tblExcludedStates = DefaultDatabase.ExecuteDataTable("spGetNetRateAdditionalExcludedStates", new object[2]
    {
      (object) "@quoteGuid",
      (object) this._quote.QuoteGuid
    });
    int num = this.tblExcludedStates.Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.tblExcludedStates.Rows[index]["Checked"].ToString(), "0", false) == 0)
        ((CheckedListBox) this.MgaCheckedListBox1).Items.Add(RuntimeHelpers.GetObjectValue(this.tblExcludedStates.Rows[index]["State"]), false);
      else
        ((CheckedListBox) this.MgaCheckedListBox1).Items.Add(RuntimeHelpers.GetObjectValue(this.tblExcludedStates.Rows[index]["State"]), true);
    }
  }

  private void SaveWCData()
  {
    string Left = "";
    int num = ((CheckedListBox) this.MgaCheckedListBox1).CheckedItems.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0)
        Left += ", ";
      DataRow dataRow = this.tblExcludedStates.Select($"State='{((CheckedListBox) this.MgaCheckedListBox1).CheckedItems[index].ToString()}'")[0];
      Left += dataRow["StateID"].ToString();
    }
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblNetRateAdditionalData SET Excluded_States = @Excluded_States WHERE QuoteGuid = @QuoteGuid", new object[4]
    {
      (object) "@Excluded_States",
      (object) Left,
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
  }

  private void LogChanges(bool newRow)
  {
    if (newRow)
    {
      CurrentUser.Instance.LogAction("Create Netrate Additional Information for Control# " + this._quote.ControlNo.ToString(), this._quote.QuoteGuid);
    }
    else
    {
      Dictionary<string, string> dictColName = new Dictionary<string, string>();
      this.GetColNames(dictColName);
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow additionalDataRow = this.ds.tblNetRateAdditionalData[0];
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblNetRateAdditionalData.Columns)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(additionalDataRow[column.ColumnName, DataRowVersion.Original].ToString(), additionalDataRow[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
          {
            string str1 = additionalDataRow[column.ColumnName] == DBNull.Value ? "<>" : additionalDataRow[column.ColumnName, DataRowVersion.Current].ToString();
            string str2 = additionalDataRow[column.ColumnName, DataRowVersion.Original] == DBNull.Value ? string.Empty : additionalDataRow[column.ColumnName, DataRowVersion.Original].ToString();
            string str3 = !dictColName.ContainsKey(column.ColumnName) ? string.Empty : dictColName[column.ColumnName];
            string str4 = $"Change {str3} from ";
            string str5 = (!str2.Equals(string.Empty) ? str4 + str2 : str4 + "<blank>") + " to ";
            string str6 = !str1.Equals(string.Empty) ? str5 + str1 : str5 + "<blank>";
            if (!string.IsNullOrEmpty(str3))
              CurrentUser.Instance.LogAction(str6, this._quote.QuoteGuid);
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

  private void GetColNames(Dictionary<string, string> dictColName)
  {
    Dictionary<string, string> dictionary = dictColName;
    dictionary.Add("AdditionalComments", "Additional Comments");
    dictionary.Add("AutoliabSymbol", "Liability Symbol");
    dictionary.Add("PIPSymbol", "PIP Symbol");
    dictionary.Add("AddnPIPSymbol", "Added PIP Symbol");
    dictionary.Add("PropProtectionSymbol", "Property Protection Symbol");
    dictionary.Add("MedPaySymbol", "Medical Payments Symbol");
    dictionary.Add("GaragekeepersSymbol", "Garagekeepers Symbol");
    dictionary.Add("UnInsSymbol", "Uninsured Motorist Symbol");
    dictionary.Add("UnderInsSymbol", "UnderInsured Motorist Symbol");
    dictionary.Add("PhysDamCompSymbol", "Physical Damage Comprehensive Symbol");
    dictionary.Add("PhysDamCOLSymbol", "Physical Damage Specified Cause of Loss Symbol");
    dictionary.Add("PhysDamCollSymbol", "Physical Damage Collision Symbol");
    dictionary.Add("TowingSymbol", "Towing Symbol");
    dictionary.Add("RejectedTerrorism", "Rejected Terrorism");
    dictionary.Add("Terrorism", "Terrorism");
    dictionary.Add("BodilyInjEachAcc", "Bodily Injury By Accident (Each Accident)");
    dictionary.Add("BodilyInjDiseaseAggLimit", "Bodily Injury By Disease (Aggregate Limit)");
    dictionary.Add("BodilyInjDiseaseEachEmpl", "Bodily Injury By Disease (Each Employee)");
  }

  protected virtual bool ValidData()
  {
    bool flag = true;
    this.ErrorP.SetError((Control) this.numPoweredUnits, string.Empty);
    this.ErrorP.SetError((Control) this.chkCompositeRated, string.Empty);
    if (((UltraToggleEditorBase) this.chkCompositeRated).Checked && (((UltraNumericEditor) this.numPoweredUnits).Value == null || ((UltraNumericEditor) this.numPoweredUnits).Value == DBNull.Value))
    {
      flag = false;
      this.ErrorP.SetError((Control) this.numPoweredUnits, "Composite Rated checked. Please enter a #.");
      ((UltraTabControlBase) this.UltraTabControl1).Tabs[3].Selected = true;
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidData())
      return;
    ((Control) this.btnSave).Enabled = false;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this._bmb.EndCurrentEdit();
      if (this.ds.tblNetRateAdditionalData.Count > 0)
      {
        int rowState = (int) this.ds.tblNetRateAdditionalData[0].RowState;
      }
      if (this.ds.tblNetRateAdditionalData.GetChanges() != null)
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (tmpObject, transArgs) =>
        {
          DefaultDatabase.DataAdapterUpdate(this.daNRExtendedData, (DataTable) this.ds.tblNetRateAdditionalData);
          this.SaveClientData((SqlTransaction) transArgs.Transaction);
          transArgs.Transaction.Commit();
        }));
      this.SaveWCData();
      this.SaveClientData();
      this.ds.tblNetRateAdditionalData.AcceptChanges();
    }
    finally
    {
      ((Control) this.btnSave).Enabled = true;
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void AfterFormLoad()
  {
  }

  protected virtual void SetFormDefaults(
    ref dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow defaultRow,
    Guid quoteGUID)
  {
  }

  protected virtual void SaveClientData()
  {
  }

  protected virtual void SaveClientData(SqlTransaction trans)
  {
  }

  protected virtual void SaveClientData(DbTransaction trans)
  {
    if (!(trans is SqlTransaction))
      return;
    this.SaveClientData(trans as SqlTransaction);
  }

  private void SetUpForm()
  {
    this.EnableItems(!this._quote.IsBound);
    if (!this._quote.IsBound)
      return;
    ((Control) this.btnSave).Enabled = false;
    this.labelInformation.Visible = true;
  }

  private void lnkTestSymbolAutomation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    DataTable dataTable1 = new DataTable()
    {
      Columns = {
        {
          "RaterID",
          typeof (int)
        },
        {
          "CompanyLineGuid",
          typeof (Guid)
        }
      }
    };
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RaterID, CompanyLineGuid FROM tblQuoteDetails WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quote.QuoteGuid
    });
    isupportAutoSymbols = (ISupportAutoSymbols) null;
    try
    {
      foreach (DataRow row in dataTable2.Rows)
      {
        IRater rater = RaterFactory.GetRater((int) row["RaterID"]);
        if (rater is ISupportAutoSymbols isupportAutoSymbols)
        {
          rater.InitializeState(this._quote.QuoteGuid, (Guid) row["CompanyLineGuid"]);
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
    DataTable dt = new DataTable();
    dt.Columns.Add("Value", typeof (string));
    if (isupportAutoSymbols == null)
    {
      dt.Rows.Add((object) "No raters used on this policy support symbol automation");
    }
    else
    {
      dt.Rows.Add((object) ("Liability: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 1)));
      dt.Rows.Add((object) ("PIP: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 3)));
      dt.Rows.Add((object) ("Additional PIP: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 4)));
      dt.Rows.Add((object) ("PPI: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 5)));
      dt.Rows.Add((object) ("Medical Payments: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 2)));
      dt.Rows.Add((object) ("VA Medical Benefits: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 19)));
      dt.Rows.Add((object) ("UM: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 6)));
      dt.Rows.Add((object) ("UIM: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 7)));
      dt.Rows.Add((object) ("GKLL Comprehensive: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 9)));
      dt.Rows.Add((object) ("GKLL Specified Causes: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 10)));
      dt.Rows.Add((object) ("GKLL Collision: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 11)));
      dt.Rows.Add((object) ("Physical Damage Comp: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 12)));
      dt.Rows.Add((object) ("Physical Damage Specified Causes: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 13)));
      dt.Rows.Add((object) ("Physical Damage Collision: " + isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 14)));
    }
    SymbolAutomationTest symbolAutomationTest = new SymbolAutomationTest(this._quote.InsuredPolicyName, dt);
    symbolAutomationTest.Run();
    ((Control) new frmPrint((SectionReport) symbolAutomationTest)).Show();
  }

  private void lnkAutoFillSymbols_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("All currently assigned auto symbols on this transaction will be replaced. Do you want to proceed?", "Replace current symbols?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
      return;
    DataTable dataTable1 = new DataTable()
    {
      Columns = {
        {
          "RaterID",
          typeof (int)
        },
        {
          "CompanyLineGuid",
          typeof (Guid)
        }
      }
    };
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RaterID, CompanyLineGuid FROM tblQuoteDetails WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quote.QuoteGuid
    });
    isupportAutoSymbols = (ISupportAutoSymbols) null;
    try
    {
      foreach (DataRow row in dataTable2.Rows)
      {
        IRater rater = RaterFactory.GetRater((int) row["RaterID"]);
        if (rater is ISupportAutoSymbols isupportAutoSymbols)
        {
          rater.InitializeState(this._quote.QuoteGuid, (Guid) row["CompanyLineGuid"]);
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
    if (isupportAutoSymbols == null)
    {
      CurrentUser.Instance.LogAction("Symbol auto-fill initiated but no raters that support symbol automation found.", this._quote.QuoteGuid);
    }
    else
    {
      CurrentUser.Instance.LogAction("Symbol auto-fill initiated.", this._quote.QuoteGuid);
      this.DisableSymbolControls();
      this.bwAutoSymbol = new BackgroundWorker();
      this.bwAutoSymbol.DoWork += new DoWorkEventHandler(this.DoSymbolWork);
      this.bwAutoSymbol.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.SymbolWorkCompleted);
      this.bwAutoSymbol.RunWorkerAsync((object) isupportAutoSymbols);
    }
  }

  private void DisableSymbolControls()
  {
    ((Control) this.txtLiabilitySymbol).Enabled = false;
    ((Control) this.txtPIPSymbol).Enabled = false;
    ((Control) this.txtAddedPIPSymbol).Enabled = false;
    ((Control) this.txtPropertyProtectionSymbol).Enabled = false;
    ((Control) this.txtMedicalPaymentsSymbol).Enabled = false;
    ((Control) this.txtUninsuredMotoristSymbol).Enabled = false;
    ((Control) this.txtUnderinsuredMotoristSymbol).Enabled = false;
    ((Control) this.txtComprehensiveSymbol).Enabled = false;
    ((Control) this.txtCollisionSymbol).Enabled = false;
    ((Control) this.MgaTextBox2).Enabled = false;
    ((Control) this.MgaTextBox3).Enabled = false;
    ((Control) this.txtTowingSymbol).Enabled = false;
    ((Control) this.txtTrailerSymbol).Enabled = false;
    ((Control) this.MgaTextBox7).Enabled = false;
    ((Control) this.MgaTextBox8).Enabled = false;
  }

  private void EnableSymbolControls()
  {
    ((Control) this.txtLiabilitySymbol).Enabled = true;
    ((Control) this.txtPIPSymbol).Enabled = true;
    ((Control) this.txtAddedPIPSymbol).Enabled = true;
    ((Control) this.txtPropertyProtectionSymbol).Enabled = true;
    ((Control) this.txtMedicalPaymentsSymbol).Enabled = true;
    ((Control) this.txtUninsuredMotoristSymbol).Enabled = true;
    ((Control) this.txtUnderinsuredMotoristSymbol).Enabled = true;
    ((Control) this.txtComprehensiveSymbol).Enabled = true;
    ((Control) this.txtCollisionSymbol).Enabled = true;
    ((Control) this.MgaTextBox2).Enabled = true;
    ((Control) this.MgaTextBox3).Enabled = true;
    ((Control) this.txtTowingSymbol).Enabled = true;
    ((Control) this.txtTrailerSymbol).Enabled = true;
    ((Control) this.MgaTextBox7).Enabled = true;
    ((Control) this.MgaTextBox8).Enabled = true;
  }

  private void DoSymbolWork(object sender, DoWorkEventArgs e)
  {
    ISupportAutoSymbols isupportAutoSymbols = (ISupportAutoSymbols) e.Argument;
    Dictionary<int, string> dictionary = new Dictionary<int, string>()
    {
      {
        1,
        string.Empty
      },
      {
        3,
        string.Empty
      },
      {
        4,
        string.Empty
      },
      {
        5,
        string.Empty
      },
      {
        2,
        string.Empty
      },
      {
        6,
        string.Empty
      },
      {
        7,
        string.Empty
      },
      {
        9,
        string.Empty
      },
      {
        10,
        string.Empty
      },
      {
        11,
        string.Empty
      },
      {
        12,
        string.Empty
      },
      {
        13,
        string.Empty
      },
      {
        14,
        string.Empty
      },
      {
        15,
        string.Empty
      },
      {
        16 /*0x10*/,
        string.Empty
      },
      {
        17,
        string.Empty
      },
      {
        18,
        string.Empty
      }
    };
    dictionary[1] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 1);
    dictionary[3] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 3);
    dictionary[4] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 4);
    dictionary[5] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 5);
    dictionary[2] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 2);
    dictionary[6] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 6);
    dictionary[7] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 7);
    dictionary[9] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 9);
    dictionary[10] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 10);
    dictionary[11] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 11);
    dictionary[12] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 12);
    dictionary[13] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 13);
    dictionary[14] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 14);
    dictionary[15] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 15);
    dictionary[16 /*0x10*/] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 16 /*0x10*/);
    dictionary[17] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 17);
    dictionary[18] = isupportAutoSymbols.GetSymbol((Enums.SymbolCoverages) 18);
    e.Result = (object) dictionary;
  }

  private void SymbolWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    Dictionary<int, string> result = (Dictionary<int, string>) e.Result;
    ((TextEditorControlBase) this.txtLiabilitySymbol).Value = (object) result[1];
    ((TextEditorControlBase) this.txtPIPSymbol).Value = (object) result[3];
    ((TextEditorControlBase) this.txtAddedPIPSymbol).Value = (object) result[4];
    ((TextEditorControlBase) this.txtPropertyProtectionSymbol).Value = (object) result[5];
    ((TextEditorControlBase) this.txtMedicalPaymentsSymbol).Value = (object) result[2];
    ((TextEditorControlBase) this.txtUninsuredMotoristSymbol).Value = (object) result[6];
    ((TextEditorControlBase) this.txtUnderinsuredMotoristSymbol).Value = (object) result[7];
    string str1 = result[9];
    string str2 = result[10];
    string str3 = result[11];
    if (!string.IsNullOrEmpty(str1))
      ((TextEditorControlBase) this.txtComprehensiveSymbol).Value = (object) str1;
    else if (!string.IsNullOrEmpty(str2))
      ((TextEditorControlBase) this.txtComprehensiveSymbol).Value = (object) str2;
    else if (!string.IsNullOrEmpty(str3))
      ((TextEditorControlBase) this.txtComprehensiveSymbol).Value = (object) str3;
    ((TextEditorControlBase) this.txtCollisionSymbol).Value = (object) result[12];
    ((TextEditorControlBase) this.MgaTextBox2).Value = (object) result[13];
    ((TextEditorControlBase) this.MgaTextBox3).Value = (object) result[14];
    ((TextEditorControlBase) this.txtTowingSymbol).Value = (object) result[15];
    string str4 = result[16 /*0x10*/];
    string str5 = result[17];
    string str6 = result[18];
    if (!string.IsNullOrEmpty(str4))
      ((TextEditorControlBase) this.txtTrailerSymbol).Value = (object) str4;
    else if (!string.IsNullOrEmpty(str5))
      ((TextEditorControlBase) this.txtTrailerSymbol).Value = (object) str5;
    else if (!string.IsNullOrEmpty(str6))
      ((TextEditorControlBase) this.txtTrailerSymbol).Value = (object) str6;
    ((Component) sender).Dispose();
    this.EnableSymbolControls();
  }
}
