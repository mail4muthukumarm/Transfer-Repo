// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Endorsements.frmEndorsementInfo
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.Tools;
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
using System.Security.Cryptography;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Endorsements;

public class frmEndorsementInfo : Form
{
  private IContainer components;
  private MGACheckBox chkPolicyIs;
  private MGATextBox MgaTextBox1;
  private MGACheckBox MgaCheckBox1;
  private MGATextBox MgaTextBox2;
  private Label Label1;
  private MGACheckBox MgaCheckBox2;
  private MGACheckBox MgaCheckBox3;
  private Label lblPolicyTerm;
  private MGACheckBox MgaCheckBox4;
  private MGATextBox MgaTextBox3;
  private Label Label2;
  private MGACheckBox MgaCheckBox5;
  private MGACheckBox MgaCheckBox6;
  private MGACheckBox MgaCheckBox7;
  private DbDataAdapter da;
  private dsEndorsementInfo ds;
  private MGACheckBox MgaCheckBox8;
  private MGACheckBox MgaCheckBox9;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private UltraGroupBox UltraGroupBox1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private int _quoteID;
  private bool _saved;
  private Quote _quote;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("txtEndorsementInfo")]
  protected virtual RichTextBox txtEndorsementInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkEdit
  {
    get => this._lnkEdit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEdit_LinkClicked);
      LinkLabel lnkEdit1 = this._lnkEdit;
      if (lnkEdit1 != null)
        lnkEdit1.LinkClicked -= clickedEventHandler;
      this._lnkEdit = value;
      LinkLabel lnkEdit2 = this._lnkEdit;
      if (lnkEdit2 == null)
        return;
      lnkEdit2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  protected virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox2")]
  protected virtual MGAGroupBox MgaGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  private virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnBindEndorsement
  {
    get => this._btnBindEndorsement;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBindEndorsement_Click);
      MGAButton btnBindEndorsement1 = this._btnBindEndorsement;
      if (btnBindEndorsement1 != null)
        ((Control) btnBindEndorsement1).Click -= eventHandler;
      this._btnBindEndorsement = value;
      MGAButton btnBindEndorsement2 = this._btnBindEndorsement;
      if (btnBindEndorsement2 == null)
        return;
      ((Control) btnBindEndorsement2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaCheckBox11")]
  private virtual MGACheckBox MgaCheckBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox13")]
  private virtual MGACheckBox MgaCheckBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox14")]
  private virtual MGACheckBox MgaCheckBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox15")]
  private virtual MGACheckBox MgaCheckBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox17")]
  private virtual MGACheckBox MgaCheckBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox18")]
  private virtual MGACheckBox MgaCheckBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox19")]
  private virtual MGACheckBox MgaCheckBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox4")]
  protected virtual MGATextBox MgaTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkShowRater
  {
    get => this._lnkShowRater;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkShowRater_LinkClicked);
      LinkLabel lnkShowRater1 = this._lnkShowRater;
      if (lnkShowRater1 != null)
        lnkShowRater1.LinkClicked -= clickedEventHandler;
      this._lnkShowRater = value;
      LinkLabel lnkShowRater2 = this._lnkShowRater;
      if (lnkShowRater2 == null)
        return;
      lnkShowRater2.LinkClicked += clickedEventHandler;
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
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEndorsementInfo));
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance29 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance30 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.MgaTextBox2 = new MGATextBox();
    this.ds = new dsEndorsementInfo();
    this.MgaTextBox1 = new MGATextBox();
    this.MgaCheckBox1 = new MGACheckBox();
    this.Label1 = new Label();
    this.MgaCheckBox8 = new MGACheckBox();
    this.MgaCheckBox9 = new MGACheckBox();
    this.lblPolicyTerm = new Label();
    this.MgaCheckBox4 = new MGACheckBox();
    this.MgaTextBox3 = new MGATextBox();
    this.Label2 = new Label();
    this.MgaCheckBox5 = new MGACheckBox();
    this.MgaCheckBox6 = new MGACheckBox();
    this.MgaCheckBox7 = new MGACheckBox();
    this.chkPolicyIs = new MGACheckBox();
    this.MgaCheckBox2 = new MGACheckBox();
    this.MgaCheckBox3 = new MGACheckBox();
    this.MgaGroupBox2 = new MGAGroupBox();
    this.lnkShowRater = new LinkLabel();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.txtEndorsementInfo = new RichTextBox();
    this.lnkEdit = new LinkLabel();
    this.btnCancel = new MGAButton();
    this.btnBindEndorsement = new MGAButton();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.Label3 = new Label();
    this.MgaTextBox4 = new MGATextBox();
    this.MgaCheckBox11 = new MGACheckBox();
    this.MgaCheckBox13 = new MGACheckBox();
    this.MgaCheckBox17 = new MGACheckBox();
    this.MgaCheckBox14 = new MGACheckBox();
    this.MgaCheckBox19 = new MGACheckBox();
    this.MgaCheckBox15 = new MGACheckBox();
    this.MgaCheckBox18 = new MGACheckBox();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox8).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox9).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox4).BeginInit();
    ((ISupportInitialize) this.MgaTextBox3).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox5).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox6).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox7).BeginInit();
    ((ISupportInitialize) this.chkPolicyIs).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox2).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox3).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox2).BeginInit();
    ((Control) this.MgaGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnBindEndorsement).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.MgaTextBox4).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox11).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox13).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox17).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox14).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox19).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox15).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox18).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaGroupBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaGroupBox2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnCancel);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnBindEndorsement);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(498, 526);
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.Transparent;
    ((UltraGroupBox) this.MgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaTextBox2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox8);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox9);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lblPolicyTerm);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox4);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaTextBox3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox5);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox6);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox7);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkPolicyIs);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox3);
    appearance2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.MgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 15);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(476, 276);
    ((Control) this.MgaGroupBox1).TabIndex = 21;
    ((UltraGroupBox) this.MgaGroupBox1).Text = "Endorsement Information";
    ((UltraGroupBox) this.MgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 3;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).DataBindings.Add(new Binding("Text", (object) this.ds, "tblEndorsementInfo.PolicyScheduleText", true));
    ((Control) this.MgaTextBox2).Location = new Point(152, 56);
    ((TextEditorControlBase) this.MgaTextBox2).MaxLength = 50;
    this.MgaTextBox2.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(136, 20);
    ((Control) this.MgaTextBox2).TabIndex = 3;
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsEndorsementInfo";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblEndorsementInfo.PolicyIsText", true));
    ((Control) this.MgaTextBox1).Location = new Point(88, 32 /*0x20*/);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 50;
    this.MgaTextBox1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(136, 20);
    ((Control) this.MgaTextBox1).TabIndex = 1;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.PolicySchedule", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(16 /*0x10*/, 56);
    this.MgaCheckBox1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.MgaCheckBox1).TabIndex = 2;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Item(s) list below are";
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(296, 55);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(100, 20);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "the policy schedule.";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox8).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.MgaCheckBox8).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox8).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox8).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.InsuredMailingAddress", true));
    ((UltraToggleEditorBase) this.MgaCheckBox8).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox8).Location = new Point(16 /*0x10*/, 104);
    this.MgaCheckBox8.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox8).Name = "MgaCheckBox8";
    ((Control) this.MgaCheckBox8).Size = new Size(288, 20);
    ((Control) this.MgaCheckBox8).TabIndex = 19;
    ((UltraToggleEditorBase) this.MgaCheckBox8).Text = "Insured mailing address is amended as shown below";
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox9).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.MgaCheckBox9).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox9).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox9).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.PolicyReinstated", true));
    ((UltraToggleEditorBase) this.MgaCheckBox9).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox9).Location = new Point(16 /*0x10*/, 224 /*0xE0*/);
    this.MgaCheckBox9.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox9).Name = "MgaCheckBox9";
    ((Control) this.MgaCheckBox9).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.MgaCheckBox9).TabIndex = 20;
    ((UltraToggleEditorBase) this.MgaCheckBox9).Text = "Policy Reinstated";
    this.lblPolicyTerm.BackColor = Color.Transparent;
    this.lblPolicyTerm.Location = new Point(176 /*0xB0*/, (int) sbyte.MaxValue);
    this.lblPolicyTerm.Name = "lblPolicyTerm";
    this.lblPolicyTerm.Size = new Size(100, 23);
    this.lblPolicyTerm.TabIndex = 7;
    this.lblPolicyTerm.Text = "(policy term)";
    this.lblPolicyTerm.TextAlign = ContentAlignment.MiddleLeft;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox4).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.MgaCheckBox4).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox4).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox4).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.EndorsementVoid", true));
    ((UltraToggleEditorBase) this.MgaCheckBox4).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox4).Location = new Point(16 /*0x10*/, 152);
    this.MgaCheckBox4.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox4).Name = "MgaCheckBox4";
    ((Control) this.MgaCheckBox4).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.MgaCheckBox4).TabIndex = 8;
    ((UltraToggleEditorBase) this.MgaCheckBox4).Text = "Endorsement No";
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox3).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.MgaTextBox3).BackColor = Color.White;
    ((Control) this.MgaTextBox3).DataBindings.Add(new Binding("Text", (object) this.ds, "tblEndorsementInfo.EndorsementVoidNum", true));
    ((Control) this.MgaTextBox3).Location = new Point(134, 153);
    ((TextEditorControlBase) this.MgaTextBox3).MaxLength = 10;
    this.MgaTextBox3.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox3).Name = "MgaTextBox3";
    ((Control) this.MgaTextBox3).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.MgaTextBox3).TabIndex = 9;
    ((UltraControlBase) this.MgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(220, 151);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(88, 23);
    this.Label2.TabIndex = 10;
    this.Label2.Text = "is null and void.";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox5).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.MgaCheckBox5).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox5).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox5).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.DescriptionOfItems", true));
    ((UltraToggleEditorBase) this.MgaCheckBox5).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox5).Location = new Point(16 /*0x10*/, 176 /*0xB0*/);
    this.MgaCheckBox5.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox5).Name = "MgaCheckBox5";
    ((Control) this.MgaCheckBox5).Size = new Size(272, 20);
    ((Control) this.MgaCheckBox5).TabIndex = 11;
    ((UltraToggleEditorBase) this.MgaCheckBox5).Text = "Description of item(s) is amended as shown below";
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox6).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.MgaCheckBox6).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox6).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox6).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.LimitsChanged", true));
    ((UltraToggleEditorBase) this.MgaCheckBox6).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox6).Location = new Point(16 /*0x10*/, 200);
    this.MgaCheckBox6.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox6).Name = "MgaCheckBox6";
    ((Control) this.MgaCheckBox6).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.MgaCheckBox6).TabIndex = 12;
    ((UltraToggleEditorBase) this.MgaCheckBox6).Text = "Limit of Liability is as shown below";
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox7).Appearance = (AppearanceBase) appearance12;
    ((UltraToggleEditorBase) this.MgaCheckBox7).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox7).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox7).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.Other", true));
    ((UltraToggleEditorBase) this.MgaCheckBox7).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox7).Location = new Point(16 /*0x10*/, 248);
    this.MgaCheckBox7.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox7).Name = "MgaCheckBox7";
    ((Control) this.MgaCheckBox7).Size = new Size(136, 20);
    ((Control) this.MgaCheckBox7).TabIndex = 13;
    ((UltraToggleEditorBase) this.MgaCheckBox7).Text = "Other, as shown below";
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPolicyIs).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkPolicyIs).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPolicyIs).BackColorInternal = Color.Transparent;
    ((Control) this.chkPolicyIs).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.PolicyIs", true));
    ((UltraToggleEditorBase) this.chkPolicyIs).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPolicyIs).Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.chkPolicyIs.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkPolicyIs).Name = "chkPolicyIs";
    ((Control) this.chkPolicyIs).Size = new Size(72, 20);
    ((Control) this.chkPolicyIs).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkPolicyIs).Text = "Policy Is";
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox2).Appearance = (AppearanceBase) appearance14;
    ((UltraToggleEditorBase) this.MgaCheckBox2).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox2).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox2).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.NamedInsuredAmended", true));
    ((UltraToggleEditorBase) this.MgaCheckBox2).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox2).Location = new Point(16 /*0x10*/, 80 /*0x50*/);
    this.MgaCheckBox2.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox2).Name = "MgaCheckBox2";
    ((Control) this.MgaCheckBox2).Size = new Size(248, 20);
    ((Control) this.MgaCheckBox2).TabIndex = 5;
    ((UltraToggleEditorBase) this.MgaCheckBox2).Text = "Name of insured is amended as shown below";
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox3).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.MgaCheckBox3).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox3).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox3).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.PolicyTermAmended", true));
    ((UltraToggleEditorBase) this.MgaCheckBox3).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox3).Location = new Point(16 /*0x10*/, 128 /*0x80*/);
    this.MgaCheckBox3.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox3).Name = "MgaCheckBox3";
    ((Control) this.MgaCheckBox3).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.MgaCheckBox3).TabIndex = 6;
    ((UltraToggleEditorBase) this.MgaCheckBox3).Text = "Policy term is amended to:";
    ((Control) this.MgaGroupBox2).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance16.BackColor = Color.Transparent;
    ((UltraGroupBox) this.MgaGroupBox2).ContentAreaAppearance = (AppearanceBase) appearance16;
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.lnkShowRater);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.lnkEdit);
    appearance17.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.MgaGroupBox2).HeaderAppearance = (AppearanceBase) appearance17;
    ((Control) this.MgaGroupBox2).Location = new Point(8, 297);
    ((Control) this.MgaGroupBox2).Name = "MgaGroupBox2";
    ((Control) this.MgaGroupBox2).Size = new Size(476, 170);
    ((Control) this.MgaGroupBox2).TabIndex = 22;
    ((UltraGroupBox) this.MgaGroupBox2).Text = "Other Information";
    ((UltraGroupBox) this.MgaGroupBox2).ViewStyle = (GroupBoxViewStyle) 3;
    this.lnkShowRater.BackColor = Color.Transparent;
    this.lnkShowRater.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.lnkShowRater.Name = "lnkShowRater";
    this.lnkShowRater.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.lnkShowRater.TabIndex = 19;
    this.lnkShowRater.TabStop = true;
    this.lnkShowRater.Text = "Show Rater";
    ((Control) this.UltraGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraGroupBox1.BackColorInternal = Color.Transparent;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance18;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtEndorsementInfo);
    ((Control) this.UltraGroupBox1).Location = new Point(9, 52);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(458, 109);
    ((Control) this.UltraGroupBox1).TabIndex = 18;
    this.txtEndorsementInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtEndorsementInfo.BackColor = Color.White;
    this.txtEndorsementInfo.BorderStyle = BorderStyle.None;
    this.txtEndorsementInfo.ForeColor = Color.Black;
    this.txtEndorsementInfo.Location = new Point(3, 16 /*0x10*/);
    this.txtEndorsementInfo.MaxLength = 8000;
    this.txtEndorsementInfo.Name = "txtEndorsementInfo";
    this.txtEndorsementInfo.ReadOnly = true;
    this.txtEndorsementInfo.Size = new Size(452, 85);
    this.txtEndorsementInfo.TabIndex = 0;
    this.txtEndorsementInfo.Text = "";
    this.lnkEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkEdit.AutoSize = true;
    this.lnkEdit.BackColor = Color.Transparent;
    this.lnkEdit.Location = new Point(347, 28);
    this.lnkEdit.Name = "lnkEdit";
    this.lnkEdit.Size = new Size(116, 13);
    this.lnkEdit.TabIndex = 17;
    this.lnkEdit.TabStop = true;
    this.lnkEdit.Text = "Edit Endorsement Text";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance19.BackColor = Color.Gainsboro;
    appearance19.BackColor2 = Color.White;
    appearance19.BackGradientStyle = (GradientStyle) 2;
    appearance19.BorderColor = Color.Gray;
    appearance19.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance19.Image"));
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance19;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Font = new Font("Tahoma", 8f);
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(455, 483);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((ControlBase) this.btnCancel).Padding = new Size(5, 0);
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 18;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnBindEndorsement).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance20.BackColor = Color.Gainsboro;
    appearance20.BackColor2 = Color.White;
    appearance20.BackGradientStyle = (GradientStyle) 2;
    appearance20.BorderColor = Color.Gray;
    appearance20.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance20.Image"));
    ((ControlBase) this.btnBindEndorsement).Appearance = (AppearanceBase) appearance20;
    ((Control) this.btnBindEndorsement).Font = new Font("Tahoma", 8f);
    ((ControlBase) this.btnBindEndorsement).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnBindEndorsement).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnBindEndorsement).Location = new Point(407, 483);
    ((Control) this.btnBindEndorsement).Name = "btnBindEndorsement";
    ((ControlBase) this.btnBindEndorsement).Padding = new Size(5, 0);
    ((Control) this.btnBindEndorsement).Size = new Size(40, 40);
    ((Control) this.btnBindEndorsement).TabIndex = 17;
    this.btnBindEndorsement.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox4);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaCheckBox11);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaCheckBox13);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaCheckBox17);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaCheckBox14);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaCheckBox19);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaCheckBox15);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaCheckBox18);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(498, 526);
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(11, 227);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(144 /*0x90*/, 18);
    this.Label3.TabIndex = 21;
    this.Label3.Text = "Coverage Parts Affected:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    appearance21.BackColor = Color.White;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox4).Appearance = (AppearanceBase) appearance21;
    ((TextEditorControlBase) this.MgaTextBox4).BackColor = Color.White;
    ((Control) this.MgaTextBox4).DataBindings.Add(new Binding("Text", (object) this.ds, "tblEndorsementInfo.CoveragePartsAffected", true));
    ((Control) this.MgaTextBox4).Location = new Point(14, 248);
    ((TextEditorControlBase) this.MgaTextBox4).MaxLength = 300;
    this.MgaTextBox4.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.MgaTextBox4).Multiline = true;
    ((Control) this.MgaTextBox4).Name = "MgaTextBox4";
    ((Control) this.MgaTextBox4).Size = new Size(455, 123);
    ((Control) this.MgaTextBox4).TabIndex = 20;
    ((UltraControlBase) this.MgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox11).Appearance = (AppearanceBase) appearance22;
    ((UltraToggleEditorBase) this.MgaCheckBox11).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox11).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox11).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.AdditionalInterestedParties", true));
    ((UltraToggleEditorBase) this.MgaCheckBox11).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox11).Location = new Point(11, 74);
    this.MgaCheckBox11.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox11).Name = "MgaCheckBox11";
    ((Control) this.MgaCheckBox11).Size = new Size(182, 20);
    ((Control) this.MgaCheckBox11).TabIndex = 19;
    ((UltraToggleEditorBase) this.MgaCheckBox11).Text = "Additional Interested Parties";
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox13).Appearance = (AppearanceBase) appearance23;
    ((UltraToggleEditorBase) this.MgaCheckBox13).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox13).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox13).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.LimitsExposures", true));
    ((UltraToggleEditorBase) this.MgaCheckBox13).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox13).Location = new Point(11, 126);
    this.MgaCheckBox13.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox13).Name = "MgaCheckBox13";
    ((Control) this.MgaCheckBox13).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.MgaCheckBox13).TabIndex = 8;
    ((UltraToggleEditorBase) this.MgaCheckBox13).Text = "Limits/Exposures";
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox17).Appearance = (AppearanceBase) appearance24;
    ((UltraToggleEditorBase) this.MgaCheckBox17).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox17).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox17).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.InsuredName", true));
    ((UltraToggleEditorBase) this.MgaCheckBox17).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox17).Location = new Point(11, 22);
    this.MgaCheckBox17.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox17).Name = "MgaCheckBox17";
    ((Control) this.MgaCheckBox17).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.MgaCheckBox17).TabIndex = 0;
    ((UltraToggleEditorBase) this.MgaCheckBox17).Text = "Insured's Name";
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox14).Appearance = (AppearanceBase) appearance25;
    ((UltraToggleEditorBase) this.MgaCheckBox14).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox14).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox14).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.Deductibles", true));
    ((UltraToggleEditorBase) this.MgaCheckBox14).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox14).Location = new Point(11, 152);
    this.MgaCheckBox14.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox14).Name = "MgaCheckBox14";
    ((Control) this.MgaCheckBox14).Size = new Size(100, 20);
    ((Control) this.MgaCheckBox14).TabIndex = 11;
    ((UltraToggleEditorBase) this.MgaCheckBox14).Text = "Deductibles";
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox19).Appearance = (AppearanceBase) appearance26;
    ((UltraToggleEditorBase) this.MgaCheckBox19).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox19).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox19).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.CoverageFormsAndEndorsements", true));
    ((UltraToggleEditorBase) this.MgaCheckBox19).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox19).Location = new Point(11, 100);
    this.MgaCheckBox19.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox19).Name = "MgaCheckBox19";
    ((Control) this.MgaCheckBox19).Size = new Size(221, 20);
    ((Control) this.MgaCheckBox19).TabIndex = 6;
    ((UltraToggleEditorBase) this.MgaCheckBox19).Text = "Coverage Forms and Endorsements";
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox15).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.MgaCheckBox15).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox15).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox15).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.CoveredPropertyLocationDesc", true));
    ((UltraToggleEditorBase) this.MgaCheckBox15).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox15).Location = new Point(11, 178);
    this.MgaCheckBox15.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox15).Name = "MgaCheckBox15";
    ((Control) this.MgaCheckBox15).Size = new Size(221, 20);
    ((Control) this.MgaCheckBox15).TabIndex = 12;
    ((UltraToggleEditorBase) this.MgaCheckBox15).Text = "Covered Property / Location Description";
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox18).Appearance = (AppearanceBase) appearance28;
    ((UltraToggleEditorBase) this.MgaCheckBox18).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox18).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox18).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEndorsementInfo.InsuredLegalStatus", true));
    ((UltraToggleEditorBase) this.MgaCheckBox18).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox18).Location = new Point(11, 48 /*0x30*/);
    this.MgaCheckBox18.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox18).Name = "MgaCheckBox18";
    ((Control) this.MgaCheckBox18).Size = new Size(248, 20);
    ((Control) this.MgaCheckBox18).TabIndex = 5;
    ((UltraToggleEditorBase) this.MgaCheckBox18).Text = "Insured' Legal Status/Business of Insured";
    this.da.DeleteCommand = this.DbDeleteCommand1;
    this.da.InsertCommand = this.DbInsertCommand1;
    this.da.SelectCommand = this.DbSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblEndorsementInfo", new DataColumnMapping[23]
      {
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("PolicyIs", "PolicyIs"),
        new DataColumnMapping("PolicyIsText", "PolicyIsText"),
        new DataColumnMapping("PolicySchedule", "PolicySchedule"),
        new DataColumnMapping("PolicyScheduleText", "PolicyScheduleText"),
        new DataColumnMapping("NamedInsuredAmended", "NamedInsuredAmended"),
        new DataColumnMapping("PolicyTermAmended", "PolicyTermAmended"),
        new DataColumnMapping("EndorsementVoid", "EndorsementVoid"),
        new DataColumnMapping("EndorsementVoidNum", "EndorsementVoidNum"),
        new DataColumnMapping("DescriptionOfItems", "DescriptionOfItems"),
        new DataColumnMapping("LimitsChanged", "LimitsChanged"),
        new DataColumnMapping("Other", "Other"),
        new DataColumnMapping("EndorsementText", "EndorsementText"),
        new DataColumnMapping("InsuredMailingAddress", "InsuredMailingAddress"),
        new DataColumnMapping("PolicyReinstated", "PolicyReinstated"),
        new DataColumnMapping("InsuredName", "InsuredName"),
        new DataColumnMapping("InsuredLegalStatus", "InsuredLegalStatus"),
        new DataColumnMapping("AdditionalInterestedParties", "AdditionalInterestedParties"),
        new DataColumnMapping("CoverageFormsAndEndorsements", "CoverageFormsAndEndorsements"),
        new DataColumnMapping("LimitsExposures", "LimitsExposures"),
        new DataColumnMapping("Deductibles", "Deductibles"),
        new DataColumnMapping("CoveredPropertyLocationDesc", "CoveredPropertyLocationDesc"),
        new DataColumnMapping("CoveragePartsAffected", "CoveragePartsAffected")
      })
    });
    this.da.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblEndorsementInfo] WHERE (([QuoteID] = @Original_QuoteID))";
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_QuoteID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[23]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      DefaultDatabase.CreateParameter("@PolicyIs", SqlDbType.Bit, 0, "PolicyIs"),
      DefaultDatabase.CreateParameter("@PolicyIsText", SqlDbType.VarChar, 0, "PolicyIsText"),
      DefaultDatabase.CreateParameter("@PolicySchedule", SqlDbType.Bit, 0, "PolicySchedule"),
      DefaultDatabase.CreateParameter("@PolicyScheduleText", SqlDbType.VarChar, 0, "PolicyScheduleText"),
      DefaultDatabase.CreateParameter("@NamedInsuredAmended", SqlDbType.Bit, 0, "NamedInsuredAmended"),
      DefaultDatabase.CreateParameter("@PolicyTermAmended", SqlDbType.Bit, 0, "PolicyTermAmended"),
      DefaultDatabase.CreateParameter("@EndorsementVoid", SqlDbType.Bit, 0, "EndorsementVoid"),
      DefaultDatabase.CreateParameter("@EndorsementVoidNum", SqlDbType.VarChar, 0, "EndorsementVoidNum"),
      DefaultDatabase.CreateParameter("@DescriptionOfItems", SqlDbType.Bit, 0, "DescriptionOfItems"),
      DefaultDatabase.CreateParameter("@LimitsChanged", SqlDbType.Bit, 0, "LimitsChanged"),
      DefaultDatabase.CreateParameter("@Other", SqlDbType.Bit, 0, "Other"),
      DefaultDatabase.CreateParameter("@EndorsementText", SqlDbType.VarChar, 0, "EndorsementText"),
      DefaultDatabase.CreateParameter("@InsuredMailingAddress", SqlDbType.Bit, 0, "InsuredMailingAddress"),
      DefaultDatabase.CreateParameter("@PolicyReinstated", SqlDbType.Bit, 0, "PolicyReinstated"),
      DefaultDatabase.CreateParameter("@InsuredName", SqlDbType.Bit, 0, "InsuredName"),
      DefaultDatabase.CreateParameter("@InsuredLegalStatus", SqlDbType.Bit, 0, "InsuredLegalStatus"),
      DefaultDatabase.CreateParameter("@AdditionalInterestedParties", SqlDbType.Bit, 0, "AdditionalInterestedParties"),
      DefaultDatabase.CreateParameter("@CoverageFormsAndEndorsements", SqlDbType.Bit, 0, "CoverageFormsAndEndorsements"),
      DefaultDatabase.CreateParameter("@LimitsExposures", SqlDbType.Bit, 0, "LimitsExposures"),
      DefaultDatabase.CreateParameter("@Deductibles", SqlDbType.Bit, 0, "Deductibles"),
      DefaultDatabase.CreateParameter("@CoveredPropertyLocationDesc", SqlDbType.Bit, 0, "CoveredPropertyLocationDesc"),
      DefaultDatabase.CreateParameter("@CoveragePartsAffected", SqlDbType.VarChar, 0, "CoveragePartsAffected")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[24]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      DefaultDatabase.CreateParameter("@PolicyIs", SqlDbType.Bit, 0, "PolicyIs"),
      DefaultDatabase.CreateParameter("@PolicyIsText", SqlDbType.VarChar, 0, "PolicyIsText"),
      DefaultDatabase.CreateParameter("@PolicySchedule", SqlDbType.Bit, 0, "PolicySchedule"),
      DefaultDatabase.CreateParameter("@PolicyScheduleText", SqlDbType.VarChar, 0, "PolicyScheduleText"),
      DefaultDatabase.CreateParameter("@NamedInsuredAmended", SqlDbType.Bit, 0, "NamedInsuredAmended"),
      DefaultDatabase.CreateParameter("@PolicyTermAmended", SqlDbType.Bit, 0, "PolicyTermAmended"),
      DefaultDatabase.CreateParameter("@EndorsementVoid", SqlDbType.Bit, 0, "EndorsementVoid"),
      DefaultDatabase.CreateParameter("@EndorsementVoidNum", SqlDbType.VarChar, 0, "EndorsementVoidNum"),
      DefaultDatabase.CreateParameter("@DescriptionOfItems", SqlDbType.Bit, 0, "DescriptionOfItems"),
      DefaultDatabase.CreateParameter("@LimitsChanged", SqlDbType.Bit, 0, "LimitsChanged"),
      DefaultDatabase.CreateParameter("@Other", SqlDbType.Bit, 0, "Other"),
      DefaultDatabase.CreateParameter("@EndorsementText", SqlDbType.VarChar, 0, "EndorsementText"),
      DefaultDatabase.CreateParameter("@InsuredMailingAddress", SqlDbType.Bit, 0, "InsuredMailingAddress"),
      DefaultDatabase.CreateParameter("@PolicyReinstated", SqlDbType.Bit, 0, "PolicyReinstated"),
      DefaultDatabase.CreateParameter("@InsuredName", SqlDbType.Bit, 0, "InsuredName"),
      DefaultDatabase.CreateParameter("@InsuredLegalStatus", SqlDbType.Bit, 0, "InsuredLegalStatus"),
      DefaultDatabase.CreateParameter("@AdditionalInterestedParties", SqlDbType.Bit, 0, "AdditionalInterestedParties"),
      DefaultDatabase.CreateParameter("@CoverageFormsAndEndorsements", SqlDbType.Bit, 0, "CoverageFormsAndEndorsements"),
      DefaultDatabase.CreateParameter("@LimitsExposures", SqlDbType.Bit, 0, "LimitsExposures"),
      DefaultDatabase.CreateParameter("@Deductibles", SqlDbType.Bit, 0, "Deductibles"),
      DefaultDatabase.CreateParameter("@CoveredPropertyLocationDesc", SqlDbType.Bit, 0, "CoveredPropertyLocationDesc"),
      DefaultDatabase.CreateParameter("@CoveragePartsAffected", SqlDbType.VarChar, 0, "CoveragePartsAffected"),
      DefaultDatabase.CreateParameter("@Original_QuoteID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Location = new Point(0, 0);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[2]
    {
      (Control) this.btnCancel,
      (Control) this.btnBindEndorsement
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(500, 553);
    ((Control) this.UltraTabControl1).TabIndex = 23;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 2;
    appearance29.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance29;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Endorsement Information ";
    appearance30.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance30;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Additional Information ";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(0, 25);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnCancel);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnBindEndorsement);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(498, 526);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(500, 553);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmEndorsementInfo);
    this.Text = "Endorsement Information";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.MgaCheckBox8).EndInit();
    ((ISupportInitialize) this.MgaCheckBox9).EndInit();
    ((ISupportInitialize) this.MgaCheckBox4).EndInit();
    ((ISupportInitialize) this.MgaTextBox3).EndInit();
    ((ISupportInitialize) this.MgaCheckBox5).EndInit();
    ((ISupportInitialize) this.MgaCheckBox6).EndInit();
    ((ISupportInitialize) this.MgaCheckBox7).EndInit();
    ((ISupportInitialize) this.chkPolicyIs).EndInit();
    ((ISupportInitialize) this.MgaCheckBox2).EndInit();
    ((ISupportInitialize) this.MgaCheckBox3).EndInit();
    ((ISupportInitialize) this.MgaGroupBox2).EndInit();
    ((Control) this.MgaGroupBox2).ResumeLayout(false);
    ((Control) this.MgaGroupBox2).PerformLayout();
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnBindEndorsement).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.MgaTextBox4).EndInit();
    ((ISupportInitialize) this.MgaCheckBox11).EndInit();
    ((ISupportInitialize) this.MgaCheckBox13).EndInit();
    ((ISupportInitialize) this.MgaCheckBox17).EndInit();
    ((ISupportInitialize) this.MgaCheckBox14).EndInit();
    ((ISupportInitialize) this.MgaCheckBox19).EndInit();
    ((ISupportInitialize) this.MgaCheckBox15).EndInit();
    ((ISupportInitialize) this.MgaCheckBox18).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private virtual WordTemplate wordTmpl
  {
    get => this._wordTmpl;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.wordTmpl_WordAppClosed);
      WordTemplate wordTmpl1 = this._wordTmpl;
      if (wordTmpl1 != null)
        wordTmpl1.WordAppClosed -= eventHandler;
      this._wordTmpl = value;
      WordTemplate wordTmpl2 = this._wordTmpl;
      if (wordTmpl2 == null)
        return;
      wordTmpl2.WordAppClosed += eventHandler;
    }
  }

  public frmEndorsementInfo()
  {
    this.Load += new EventHandler(this.frmEndorsementInfo_Load);
    this.InitializeComponent();
    int num = this.DesignMode ? 1 : 0;
  }

  public frmEndorsementInfo(int quoteID)
  {
    this.Load += new EventHandler(this.frmEndorsementInfo_Load);
    this.InitializeComponent();
    if (this.DesignMode)
      return;
    this._quoteID = quoteID;
  }

  private void frmEndorsementInfo_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Utility.SetDataAdapterConnections(this.da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    this.da.SelectCommand.Parameters["@quoteID"].Value = (object) this._quoteID;
    DefaultDatabase.DataAdapterFill(this.da, (DataTable) this.ds.tblEndorsementInfo);
    if (this.ds.tblEndorsementInfo.Count == 0)
    {
      dsEndorsementInfo.tblEndorsementInfoRow row = this.ds.tblEndorsementInfo.NewtblEndorsementInfoRow();
      row.QuoteID = this._quoteID;
      this.ds.tblEndorsementInfo.AddtblEndorsementInfoRow(row);
    }
    else if (!this.ds.tblEndorsementInfo[0].IsEndorsementTextNull())
      this.txtEndorsementInfo.Rtf = this.ds.tblEndorsementInfo[0].EndorsementText;
    this.txtEndorsementInfo.Enabled = true;
    this._quote = new Quote(this._quoteID);
    if (this._quote.IsBound)
    {
      this.lnkEdit.Text = "View Endorsement Text";
      try
      {
        foreach (Control control in ((Control) this.MgaGroupBox1).Controls)
        {
          if (control != null)
            control.Enabled = false;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.txtEndorsementInfo.Enabled = false;
    }
    this.LoadOnClient();
  }

  protected virtual void LoadOnClient()
  {
  }

  protected virtual void SaveOnClient()
  {
  }

  public bool Saved => this._saved;

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnBindEndorsement_Click(object sender, EventArgs e)
  {
    this.BindingContext[(object) this.ds, this.ds.tblEndorsementInfo.TableName].EndCurrentEdit();
    DefaultDatabase.DataAdapterUpdate(this.da, (DataTable) this.ds.tblEndorsementInfo);
    this._saved = true;
    this.SaveOnClient();
    this.Close();
  }

  private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    string path = $"{Path.GetTempPath()}{Guid.NewGuid().ToString()}.rtf";
    byte[] numArray = (byte[]) null;
    using (FileStream inputStream = new FileStream(path, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.None))
    {
      numArray = new MD5CryptoServiceProvider().ComputeHash((Stream) inputStream);
      inputStream.Close();
    }
    if (!this.ds.tblEndorsementInfo[0].IsEndorsementTextNull())
    {
      using (StreamWriter streamWriter = new StreamWriter(path, true))
        streamWriter.Write(this.ds.tblEndorsementInfo[0].EndorsementText);
    }
    ((Control) this.btnBindEndorsement).Enabled = false;
    this.wordTmpl = new WordTemplate(path, (Form) null, (object) new TemplateHash(0, numArray));
  }

  private void wordTmpl_WordAppClosed(object sender, EventArgs e)
  {
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) ([SpecialName] () => ((Control) this.btnBindEndorsement).Enabled = true), new object[0]);
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) ([SpecialName] () =>
    {
      if (!this.wordTmpl.FileChanged || this._quote.IsBound || !this.txtEndorsementInfo.IsHandleCreated || this.txtEndorsementInfo.Disposing || this.txtEndorsementInfo.IsDisposed)
        return;
      bool flag = true;
      if (!WordTemplate.UseWordWithEvents() && MessageBox.Show("Set endorsement text?", "Endorsement Text?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        flag = false;
      if (!flag)
        return;
      try
      {
        this.txtEndorsementInfo.LoadFile(this.wordTmpl.FileName);
        this.ds.tblEndorsementInfo[0].EndorsementText = this.txtEndorsementInfo.Rtf;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtEndorsementInfo.Text = string.Empty;
        this.ds.tblEndorsementInfo[0].EndorsementText = string.Empty;
        ProjectData.ClearProjectError();
      }
    }), new object[0]);
  }

  private void WordDocumentSaved(object sender, WordDocumentSavedEventArgs e)
  {
    if (this._quote.IsBound || !this.txtEndorsementInfo.IsHandleCreated || this.txtEndorsementInfo.Disposing)
      return;
    if (this.txtEndorsementInfo.IsDisposed)
      return;
    try
    {
      this.txtEndorsementInfo.LoadFile(e.FileName);
      this.ds.tblEndorsementInfo[0].EndorsementText = this.txtEndorsementInfo.Rtf;
    }
    catch (ArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.txtEndorsementInfo.Text = string.Empty;
      this.ds.tblEndorsementInfo[0].EndorsementText = string.Empty;
      ProjectData.ClearProjectError();
    }
  }

  private void lnkShowRater_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Quote.FromQuoteGuid(this._quote.QuoteGuid).ShowRater();
  }
}
