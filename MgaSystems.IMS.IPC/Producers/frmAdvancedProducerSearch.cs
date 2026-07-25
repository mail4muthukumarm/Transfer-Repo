// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmAdvancedProducerSearch
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
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
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

public class frmAdvancedProducerSearch : Form
{
  private IContainer components;

  public frmAdvancedProducerSearch()
  {
    this.Load += new EventHandler(this.frmAdvancedProducerSearch_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducerType")]
  protected internal virtual MGAComboBox cboProducerType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducerState")]
  protected internal virtual MGAComboBox cboProducerState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCompanyLocations")]
  protected internal virtual MGAComboBox cboCompanyLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected internal virtual dsAdvancedProducerSearch ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual UltraGrid ugAdvancedSearch
  {
    get => this._ugAdvancedSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugAdvancedSearch_DoubleClick);
      UltraGrid ugAdvancedSearch1 = this._ugAdvancedSearch;
      if (ugAdvancedSearch1 != null)
        ((Control) ugAdvancedSearch1).DoubleClick -= eventHandler;
      this._ugAdvancedSearch = value;
      UltraGrid ugAdvancedSearch2 = this._ugAdvancedSearch;
      if (ugAdvancedSearch2 == null)
        return;
      ((Control) ugAdvancedSearch2).DoubleClick += eventHandler;
    }
  }

  protected internal virtual MGAButton btnGo
  {
    get => this._btnGo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGo_Click);
      MGAButton btnGo1 = this._btnGo;
      if (btnGo1 != null)
        ((Control) btnGo1).Click -= eventHandler;
      this._btnGo = value;
      MGAButton btnGo2 = this._btnGo;
      if (btnGo2 == null)
        return;
      ((Control) btnGo2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCity")]
  protected internal virtual MGATextBox txtCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtName")]
  protected internal virtual MGATextBox txtName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("maskFax")]
  protected internal virtual MGAMaskedEdit maskFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraPictureBox1")]
  internal virtual UltraPictureBox UltraPictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textContactLast")]
  protected internal virtual MGATextBox textContactLast { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textContactFirst")]
  protected internal virtual MGATextBox textContactFirst { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numProducerLocationID")]
  protected internal virtual MGANumericEditor numProducerLocationID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEmail")]
  protected internal virtual MGATextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label Label11
  {
    get => this._Label11;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Label11_Click);
      Label label11_1 = this._Label11;
      if (label11_1 != null)
        label11_1.Click -= eventHandler;
      this._Label11 = value;
      Label label11_2 = this._Label11;
      if (label11_2 == null)
        return;
      label11_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("maskPhone")]
  protected internal virtual MGAMaskedEdit maskPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFEIN")]
  protected internal virtual MGAMaskedEdit txtFEIN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtProducerLocationCode")]
  protected internal virtual MGATextBox txtProducerLocationCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkResetSearch
  {
    get => this._lnkResetSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkResetSearch_LinkClicked);
      LinkLabel lnkResetSearch1 = this._lnkResetSearch;
      if (lnkResetSearch1 != null)
        lnkResetSearch1.LinkClicked -= clickedEventHandler;
      this._lnkResetSearch = value;
      LinkLabel lnkResetSearch2 = this._lnkResetSearch;
      if (lnkResetSearch2 == null)
        return;
      lnkResetSearch2.LinkClicked += clickedEventHandler;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdvancedProducerSearch));
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("spAdvancedProducerSearch", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("State", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerLocationID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PriorYearPremium");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("LocationCode");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LocationName");
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
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance35 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("lstStates_spAdvancedProducerSearch");
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstStates_spAdvancedProducerSearch", 0);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ProducerLocationID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("PriorYearPremium");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("LocationCode");
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
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance49 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstProducerTypes", -1);
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("ProducerTypeID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Description");
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
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance63 = new Appearance();
    this.btnSearch = new MGAButton();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.btnGo = new MGAButton();
    this.lnkResetSearch = new LinkLabel();
    this.Label4 = new Label();
    this.txtCity = new MGATextBox();
    this.txtName = new MGATextBox();
    this.Label5 = new Label();
    this.maskFax = new MGAMaskedEdit();
    this.Label6 = new Label();
    this.UltraPictureBox1 = new UltraPictureBox();
    this.textContactLast = new MGATextBox();
    this.Label7 = new Label();
    this.textContactFirst = new MGATextBox();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.numProducerLocationID = new MGANumericEditor();
    this.Label10 = new Label();
    this.txtEmail = new MGATextBox();
    this.Label11 = new Label();
    this.maskPhone = new MGAMaskedEdit();
    this.txtFEIN = new MGAMaskedEdit();
    this.Label13 = new Label();
    this.ugAdvancedSearch = new UltraGrid();
    this.ds = new dsAdvancedProducerSearch();
    this.cboCompanyLocations = new MGAComboBox();
    this.cboProducerState = new MGAComboBox();
    this.cboProducerType = new MGAComboBox();
    this.txtProducerLocationCode = new MGATextBox();
    this.Label12 = new Label();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.txtCity).BeginInit();
    ((ISupportInitialize) this.txtName).BeginInit();
    ((ISupportInitialize) this.maskFax).BeginInit();
    ((ISupportInitialize) this.textContactLast).BeginInit();
    ((ISupportInitialize) this.textContactFirst).BeginInit();
    ((ISupportInitialize) this.numProducerLocationID).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.maskPhone).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.ugAdvancedSearch).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboCompanyLocations).BeginInit();
    ((ISupportInitialize) this.cboProducerState).BeginInit();
    ((ISupportInitialize) this.cboProducerType).BeginInit();
    ((ISupportInitialize) this.txtProducerLocationCode).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSearch).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSearch).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(808, 479);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 5;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(415, 14);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Type";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.Location = new Point(415, 39);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "Producer State";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.Location = new Point(8, 89);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Company Line";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnGo).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.btnGo).Enabled = false;
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((Control) this.btnGo).Location = new Point(864, 479);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 6;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkResetSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkResetSearch.Location = new Point(8, 503);
    this.lnkResetSearch.Name = "lnkResetSearch";
    this.lnkResetSearch.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.lnkResetSearch.TabIndex = 9;
    this.lnkResetSearch.TabStop = true;
    this.lnkResetSearch.Text = "Reset Search";
    this.Label4.Location = new Point(8, 64 /*0x40*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label4.TabIndex = 10;
    this.Label4.Text = "City";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCity).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtCity).BackColor = Color.White;
    ((Control) this.txtCity).Location = new Point(94, 62);
    this.txtCity.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCity).Name = "txtCity";
    ((Control) this.txtCity).Size = new Size(312, 20);
    ((Control) this.txtCity).TabIndex = 11;
    ((UltraControlBase) this.txtCity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCity).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtName).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtName).BackColor = Color.White;
    ((Control) this.txtName).Location = new Point(94, 12);
    ((TextEditorControlBase) this.txtName).MaxLength = 250;
    this.txtName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtName).Name = "txtName";
    ((Control) this.txtName).Size = new Size(312, 20);
    ((Control) this.txtName).TabIndex = 13;
    ((UltraControlBase) this.txtName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.Location = new Point(8, 14);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label5.TabIndex = 12;
    this.Label5.Text = "Name";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.maskFax.Appearance = (AppearanceBase) appearance5;
    this.maskFax.EditAs = (EditAsType) 1;
    this.maskFax.InputMask = "(###) ###-####";
    ((Control) this.maskFax).Location = new Point(524, 66);
    this.maskFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.maskFax).Name = "maskFax";
    this.maskFax.NonAutoSizeHeight = 20;
    this.maskFax.PromptChar = '#';
    ((Control) this.maskFax).Size = new Size(133, 21);
    ((Control) this.maskFax).TabIndex = 14;
    this.maskFax.Text = "() -";
    ((UltraControlBase) this.maskFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskFax).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.Location = new Point(415, 66);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label6.TabIndex = 15;
    this.Label6.Text = "Fax";
    this.Label6.TextAlign = ContentAlignment.MiddleLeft;
    this.UltraPictureBox1.AutoSize = true;
    this.UltraPictureBox1.BorderShadowColor = Color.Empty;
    this.UltraPictureBox1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraPictureBox1.Image"));
    ((Control) this.UltraPictureBox1).Location = new Point(853, 10);
    ((Control) this.UltraPictureBox1).Name = "UltraPictureBox1";
    ((Control) this.UltraPictureBox1).Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    ((Control) this.UltraPictureBox1).TabIndex = 16 /*0x10*/;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textContactLast).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.textContactLast).BackColor = Color.White;
    ((Control) this.textContactLast).Location = new Point(94, 37);
    ((TextEditorControlBase) this.textContactLast).MaxLength = 100;
    this.textContactLast.MGAStyle = MGAStyles.Blue;
    ((Control) this.textContactLast).Name = "textContactLast";
    ((Control) this.textContactLast).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.textContactLast).TabIndex = 18;
    ((UltraControlBase) this.textContactLast).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textContactLast).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.Location = new Point(8, 39);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label7.TabIndex = 17;
    this.Label7.Text = "Contact Last";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textContactFirst).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.textContactFirst).BackColor = Color.White;
    ((Control) this.textContactFirst).Location = new Point(278, 38);
    ((TextEditorControlBase) this.textContactFirst).MaxLength = 100;
    this.textContactFirst.MGAStyle = MGAStyles.Blue;
    ((Control) this.textContactFirst).Name = "textContactFirst";
    ((Control) this.textContactFirst).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.textContactFirst).TabIndex = 20;
    ((UltraControlBase) this.textContactFirst).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textContactFirst).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.Location = new Point(243, 39);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(47, 16 /*0x10*/);
    this.Label8.TabIndex = 19;
    this.Label8.Text = "First";
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    this.Label9.Location = new Point(415, 120);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(117, 16 /*0x10*/);
    this.Label9.TabIndex = 21;
    this.Label9.Text = "Producer Location ID";
    this.Label9.TextAlign = ContentAlignment.MiddleLeft;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numProducerLocationID).Appearance = (AppearanceBase) appearance8;
    ((UltraNumericEditorBase) this.numProducerLocationID).BackColor = Color.White;
    ((UltraNumericEditorBase) this.numProducerLocationID).FormatString = "";
    ((Control) this.numProducerLocationID).Location = new Point(524, 120);
    this.numProducerLocationID.MaskInput = "nnnnnnnnnn";
    this.numProducerLocationID.MGAStyle = MGAStyles.Blue;
    ((Control) this.numProducerLocationID).Name = "numProducerLocationID";
    this.numProducerLocationID.Nullable = true;
    this.numProducerLocationID.NumericType = (NumericType) 1;
    ((Control) this.numProducerLocationID).Size = new Size(133, 20);
    ((Control) this.numProducerLocationID).TabIndex = 22;
    ((UltraControlBase) this.numProducerLocationID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numProducerLocationID).UseOsThemes = (DefaultableBoolean) 2;
    this.numProducerLocationID.Value = (object) null;
    this.Label10.Location = new Point(8, 116);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label10.TabIndex = 23;
    this.Label10.Text = "Email";
    this.Label10.TextAlign = ContentAlignment.MiddleLeft;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).Location = new Point(94, 114);
    ((TextEditorControlBase) this.txtEmail).MaxLength = 50;
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtEmail).TabIndex = 24;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.Location = new Point(415, 93);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label11.TabIndex = 26;
    this.Label11.Text = "Phone";
    this.Label11.TextAlign = ContentAlignment.MiddleLeft;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.maskPhone.Appearance = (AppearanceBase) appearance10;
    this.maskPhone.EditAs = (EditAsType) 1;
    this.maskPhone.InputMask = "(###) ###-####";
    ((Control) this.maskPhone).Location = new Point(524, 93);
    this.maskPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.maskPhone).Name = "maskPhone";
    this.maskPhone.NonAutoSizeHeight = 20;
    this.maskPhone.PromptChar = '#';
    ((Control) this.maskPhone).Size = new Size(133, 21);
    ((Control) this.maskPhone).TabIndex = 25;
    this.maskPhone.Text = "() -";
    ((UltraControlBase) this.maskPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskPhone).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BackColorDisabled = Color.Gainsboro;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFEIN.Appearance = (AppearanceBase) appearance11;
    this.txtFEIN.EditAs = (EditAsType) 1;
    this.txtFEIN.InputMask = "##-#######";
    ((Control) this.txtFEIN).Location = new Point(736, 14);
    this.txtFEIN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    this.txtFEIN.NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN).Size = new Size(72, 21);
    ((Control) this.txtFEIN).TabIndex = 27;
    this.txtFEIN.Text = "-";
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(694, 18);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(34, 13);
    this.Label13.TabIndex = 28;
    this.Label13.Text = "FEIN:";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.ugAdvancedSearch).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugAdvancedSearch).DataSource = (object) this.ds.spAdvancedProducerSearch;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 130;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 118;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 88;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Width = 87;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 80 /*0x50*/;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 74;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Contact";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Width = 109;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 109;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 88;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Width = 88;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn11.Format = "c";
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Prior Year Premium";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Width = 110;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Width = 90;
    ultraGridBand1.Columns.AddRange(new object[12]
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
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance14.BackColor = Color.LightSteelBlue;
    appearance14.FontData.SizeInPoints = 10f;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance18.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    appearance19.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance20.BackColor = Color.Transparent;
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAdvancedSearch).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugAdvancedSearch).Location = new Point(8, 142);
    ((Control) this.ugAdvancedSearch).Name = "ugAdvancedSearch";
    ((Control) this.ugAdvancedSearch).Size = new Size(896, 329);
    ((Control) this.ugAdvancedSearch).TabIndex = 7;
    ((Control) this.ugAdvancedSearch).Text = "Producers";
    ((UltraControlBase) this.ugAdvancedSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAdvancedSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdvancedProducerSearch";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboCompanyLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboCompanyLocations).DataSource = (object) this.ds.tblCompanyLocations;
    appearance21.BackColor = Color.White;
    appearance21.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboCompanyLocations.DisplayLayout.Appearance = (AppearanceBase) appearance21;
    this.cboCompanyLocations.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 95;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Width = 381;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    this.cboCompanyLocations.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboCompanyLocations.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCompanyLocations.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboCompanyLocations.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance22.BackColor = SystemColors.ActiveBorder;
    appearance22.BackColor2 = SystemColors.ControlDark;
    appearance22.BackGradientStyle = (GradientStyle) 2;
    appearance22.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboCompanyLocations.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance22;
    appearance23.ForeColor = SystemColors.GrayText;
    this.cboCompanyLocations.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance23;
    ((SpecialBoxBase) this.cboCompanyLocations.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance24.BackColor = SystemColors.ControlLightLight;
    appearance24.BackColor2 = SystemColors.Control;
    appearance24.BackGradientStyle = (GradientStyle) 3;
    appearance24.ForeColor = SystemColors.GrayText;
    this.cboCompanyLocations.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance24;
    this.cboCompanyLocations.DisplayLayout.MaxColScrollRegions = 1;
    this.cboCompanyLocations.DisplayLayout.MaxRowScrollRegions = 1;
    appearance25.BackColor = SystemColors.Window;
    appearance25.ForeColor = SystemColors.ControlText;
    this.cboCompanyLocations.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance25;
    appearance26.BackColor = SystemColors.Highlight;
    appearance26.ForeColor = SystemColors.HighlightText;
    this.cboCompanyLocations.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance26;
    this.cboCompanyLocations.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboCompanyLocations.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboCompanyLocations.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboCompanyLocations.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboCompanyLocations.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboCompanyLocations.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboCompanyLocations.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboCompanyLocations.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance27.BackColor = SystemColors.Window;
    this.cboCompanyLocations.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance27;
    appearance28.BorderColor = Color.Silver;
    appearance28.TextTrimming = (TextTrimming) 3;
    this.cboCompanyLocations.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance28;
    this.cboCompanyLocations.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboCompanyLocations.DisplayLayout.Override.CellPadding = 0;
    appearance29.BackColor = SystemColors.Control;
    appearance29.BackColor2 = SystemColors.ControlDark;
    appearance29.BackGradientAlignment = (GradientAlignment) 1;
    appearance29.BackGradientStyle = (GradientStyle) 3;
    appearance29.BorderColor = SystemColors.Window;
    this.cboCompanyLocations.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Left";
    this.cboCompanyLocations.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance30;
    this.cboCompanyLocations.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboCompanyLocations.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance31.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance31.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboCompanyLocations.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance31;
    appearance32.BackColor = SystemColors.Window;
    appearance32.BorderColor = Color.White;
    this.cboCompanyLocations.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance32;
    this.cboCompanyLocations.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboCompanyLocations.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance33.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance33.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance33.ForeColor = Color.Black;
    this.cboCompanyLocations.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = SystemColors.ControlLight;
    this.cboCompanyLocations.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance34;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboCompanyLocations.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.cboCompanyLocations.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboCompanyLocations.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboCompanyLocations.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboCompanyLocations).DisplayMember = "LocationName";
    this.cboCompanyLocations.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLocations).DropDownWidth = 400;
    ((Control) this.cboCompanyLocations).Location = new Point(94, 87);
    this.cboCompanyLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyLocations).Name = "cboCompanyLocations";
    ((Control) this.cboCompanyLocations).Size = new Size(312, 21);
    ((Control) this.cboCompanyLocations).TabIndex = 4;
    ((UltraControlBase) this.cboCompanyLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyLocations).ValueMember = "CompanyLocationGUID";
    this.cboProducerState.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboProducerState).DataSource = (object) this.ds.lstStates;
    appearance35.BackColor = Color.White;
    appearance35.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProducerState.DisplayLayout.Appearance = (AppearanceBase) appearance35;
    this.cboProducerState.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn16.Width = 114;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 2;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 3;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 4;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 5;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 6;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 7;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 8;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 9;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 11;
    ultraGridBand4.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29
    });
    this.cboProducerState.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboProducerState.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.cboProducerState.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducerState.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProducerState.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance36.BackColor = SystemColors.ActiveBorder;
    appearance36.BackColor2 = SystemColors.ControlDark;
    appearance36.BackGradientStyle = (GradientStyle) 2;
    appearance36.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboProducerState.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance36;
    appearance37.ForeColor = SystemColors.GrayText;
    this.cboProducerState.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance37;
    ((SpecialBoxBase) this.cboProducerState.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance38.BackColor = SystemColors.ControlLightLight;
    appearance38.BackColor2 = SystemColors.Control;
    appearance38.BackGradientStyle = (GradientStyle) 3;
    appearance38.ForeColor = SystemColors.GrayText;
    this.cboProducerState.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance38;
    this.cboProducerState.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProducerState.DisplayLayout.MaxRowScrollRegions = 1;
    appearance39.BackColor = SystemColors.Window;
    appearance39.ForeColor = SystemColors.ControlText;
    this.cboProducerState.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance39;
    appearance40.BackColor = SystemColors.Highlight;
    appearance40.ForeColor = SystemColors.HighlightText;
    this.cboProducerState.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance40;
    this.cboProducerState.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProducerState.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProducerState.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProducerState.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProducerState.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProducerState.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProducerState.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProducerState.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance41.BackColor = SystemColors.Window;
    this.cboProducerState.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance41;
    appearance42.BorderColor = Color.Silver;
    appearance42.TextTrimming = (TextTrimming) 3;
    this.cboProducerState.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance42;
    this.cboProducerState.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProducerState.DisplayLayout.Override.CellPadding = 0;
    appearance43.BackColor = SystemColors.Control;
    appearance43.BackColor2 = SystemColors.ControlDark;
    appearance43.BackGradientAlignment = (GradientAlignment) 1;
    appearance43.BackGradientStyle = (GradientStyle) 3;
    appearance43.BorderColor = SystemColors.Window;
    this.cboProducerState.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Left";
    this.cboProducerState.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance44;
    this.cboProducerState.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProducerState.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance45.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance45.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducerState.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance45;
    appearance46.BackColor = SystemColors.Window;
    appearance46.BorderColor = Color.White;
    this.cboProducerState.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance46;
    this.cboProducerState.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProducerState.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance47.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance47.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance47.ForeColor = Color.Black;
    this.cboProducerState.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance47;
    appearance48.BackColor = SystemColors.ControlLight;
    this.cboProducerState.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance48;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducerState.DisplayLayout.ScrollBarLook = scrollBarLook3;
    this.cboProducerState.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProducerState.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProducerState.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProducerState).DisplayMember = "State";
    this.cboProducerState.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerState).Location = new Point(524, 39);
    this.cboProducerState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerState).Name = "cboProducerState";
    ((Control) this.cboProducerState).Size = new Size(133, 21);
    ((Control) this.cboProducerState).TabIndex = 2;
    ((UltraControlBase) this.cboProducerState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerState).ValueMember = "StateID";
    this.cboProducerType.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboProducerType).DataSource = (object) this.ds.lstProducerTypes;
    appearance49.BackColor = Color.White;
    appearance49.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProducerType.DisplayLayout.Appearance = (AppearanceBase) appearance49;
    this.cboProducerType.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 0;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 1;
    ultraGridColumn31.Width = 114;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn30,
      (object) ultraGridColumn31
    });
    this.cboProducerType.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.cboProducerType.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducerType.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance50.BackColor = SystemColors.ActiveBorder;
    appearance50.BackColor2 = SystemColors.ControlDark;
    appearance50.BackGradientStyle = (GradientStyle) 2;
    appearance50.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboProducerType.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance50;
    appearance51.ForeColor = SystemColors.GrayText;
    this.cboProducerType.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance51;
    ((SpecialBoxBase) this.cboProducerType.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance52.BackColor = SystemColors.ControlLightLight;
    appearance52.BackColor2 = SystemColors.Control;
    appearance52.BackGradientStyle = (GradientStyle) 3;
    appearance52.ForeColor = SystemColors.GrayText;
    this.cboProducerType.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance52;
    this.cboProducerType.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProducerType.DisplayLayout.MaxRowScrollRegions = 1;
    appearance53.BackColor = SystemColors.Window;
    appearance53.ForeColor = SystemColors.ControlText;
    this.cboProducerType.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance53;
    appearance54.BackColor = SystemColors.Highlight;
    appearance54.ForeColor = SystemColors.HighlightText;
    this.cboProducerType.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance54;
    this.cboProducerType.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance55.BackColor = SystemColors.Window;
    this.cboProducerType.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance55;
    appearance56.BorderColor = Color.Silver;
    appearance56.TextTrimming = (TextTrimming) 3;
    this.cboProducerType.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance56;
    this.cboProducerType.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProducerType.DisplayLayout.Override.CellPadding = 0;
    appearance57.BackColor = SystemColors.Control;
    appearance57.BackColor2 = SystemColors.ControlDark;
    appearance57.BackGradientAlignment = (GradientAlignment) 1;
    appearance57.BackGradientStyle = (GradientStyle) 3;
    appearance57.BorderColor = SystemColors.Window;
    this.cboProducerType.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance57;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Left";
    this.cboProducerType.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance58;
    this.cboProducerType.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProducerType.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance59.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance59.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducerType.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance59;
    appearance60.BackColor = SystemColors.Window;
    appearance60.BorderColor = Color.White;
    this.cboProducerType.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance60;
    this.cboProducerType.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProducerType.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance61.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance61.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance61.ForeColor = Color.Black;
    this.cboProducerType.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance61;
    appearance62.BackColor = SystemColors.ControlLight;
    this.cboProducerType.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance62;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducerType.DisplayLayout.ScrollBarLook = scrollBarLook4;
    this.cboProducerType.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProducerType.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProducerType.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProducerType).DisplayMember = "Description";
    this.cboProducerType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerType).Location = new Point(524, 14);
    this.cboProducerType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerType).Name = "cboProducerType";
    ((Control) this.cboProducerType).Size = new Size(133, 21);
    ((Control) this.cboProducerType).TabIndex = 1;
    ((UltraControlBase) this.cboProducerType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerType).ValueMember = "ProducerTypeID";
    appearance63.BackColor = Color.White;
    appearance63.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance63.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProducerLocationCode).Appearance = (AppearanceBase) appearance63;
    ((TextEditorControlBase) this.txtProducerLocationCode).BackColor = Color.White;
    ((Control) this.txtProducerLocationCode).Location = new Point(788, 118);
    ((TextEditorControlBase) this.txtProducerLocationCode).MaxLength = 100;
    this.txtProducerLocationCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtProducerLocationCode).Name = "txtProducerLocationCode";
    ((Control) this.txtProducerLocationCode).Size = new Size(116, 20);
    ((Control) this.txtProducerLocationCode).TabIndex = 30;
    ((UltraControlBase) this.txtProducerLocationCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerLocationCode).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.Location = new Point(663, 119);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(128 /*0x80*/, 16 /*0x10*/);
    this.Label12.TabIndex = 29;
    this.Label12.Text = "Producer Location Code";
    this.Label12.TextAlign = ContentAlignment.MiddleLeft;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(912, 525);
    this.Controls.Add((Control) this.txtProducerLocationCode);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.txtFEIN);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.maskPhone);
    this.Controls.Add((Control) this.txtEmail);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.numProducerLocationID);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.textContactFirst);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.textContactLast);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.UltraPictureBox1);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.maskFax);
    this.Controls.Add((Control) this.txtName);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtCity);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lnkResetSearch);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.ugAdvancedSearch);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.cboCompanyLocations);
    this.Controls.Add((Control) this.cboProducerState);
    this.Controls.Add((Control) this.cboProducerType);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdvancedProducerSearch);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Advanced Producer Search";
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.txtCity).EndInit();
    ((ISupportInitialize) this.txtName).EndInit();
    ((ISupportInitialize) this.maskFax).EndInit();
    ((ISupportInitialize) this.textContactLast).EndInit();
    ((ISupportInitialize) this.textContactFirst).EndInit();
    ((ISupportInitialize) this.numProducerLocationID).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.maskPhone).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.ugAdvancedSearch).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboCompanyLocations).EndInit();
    ((ISupportInitialize) this.cboProducerState).EndInit();
    ((ISupportInitialize) this.cboProducerType).EndInit();
    ((ISupportInitialize) this.txtProducerLocationCode).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmAdvancedProducerSearch_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Forward;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "lstProducerTypes",
      "tblCompanyLocations",
      "lstStates"
    }, "dbo.AdvancedProducerSearchData");
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    ((Control) this.btnSearch).Enabled = false;
    this.ds.spAdvancedProducerSearch.Clear();
    Cursor.Current = MgaCursors.WaitCursor;
    this.RunSearch();
    DataTable contactStatusIds = this.GetProducerContactStatusIds(new DataTable());
    contactStatusIds.PrimaryKey = new DataColumn[1]
    {
      contactStatusIds.Columns["ProducerContactID"]
    };
    foreach (UltraGridRow row in ((UltraGridBase) this.ugAdvancedSearch).Rows)
    {
      if (row.Cells["ProducerContactID"].Value == DBNull.Value)
        row.Cells["ProducerContact"].Appearance.ForeColor = Color.Red;
      DataRow dataRow = contactStatusIds.Rows.Find(RuntimeHelpers.GetObjectValue(row.Cells["ProducerContactID"].Value));
      if (dataRow != null && Conversions.ToInteger(dataRow["StatusID"]) != 1)
      {
        row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        row.Appearance.ForeColor = Color.Red;
      }
      switch (Conversions.ToInteger(row.Cells["StatusID"].Value))
      {
        case 2:
        case 3:
        case 4:
          row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
          row.Appearance.ForeColor = Color.Red;
          break;
      }
      this.CheckProducerInfoOnClient(row);
    }
    ((Control) this.btnGo).Enabled = this.ds.spAdvancedProducerSearch.Rows.Count > 0;
  }

  private DataTable GetProducerContactStatusIds(DataTable dt_ProducerContactID)
  {
    if (this.ds.spAdvancedProducerSearch.Count != 0)
    {
      StringBuilder stringBuilder = new StringBuilder();
      try
      {
        foreach (DataRow row in this.ds.spAdvancedProducerSearch.Rows)
        {
          stringBuilder.Append(row["ProducerContactID"].ToString());
          stringBuilder.Append(",");
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      dt_ProducerContactID.PrimaryKey = new DataColumn[1]
      {
        dt_ProducerContactID.Columns["ProducerContactID"]
      };
      dt_ProducerContactID = DefaultDatabase.ExecuteDataTable("GetProducerContactIDs", new object[2]
      {
        (object) "@ProducerContactIDString",
        (object) stringBuilder.ToString()
      });
    }
    return dt_ProducerContactID;
  }

  private void ugAdvancedSearch_DoubleClick(object sender, EventArgs e)
  {
    this.btnGo_Click(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void btnGo_Click(object sender, EventArgs e)
  {
    ((Control) this.btnGo).Enabled = false;
    if (((UltraGridBase) this.ugAdvancedSearch).Rows.Count < 1 || ((UltraGridBase) this.ugAdvancedSearch).ActiveRow.Cells == null || ((UltraGridBase) this.ugAdvancedSearch).ActiveRow.Cells.Count < 1)
      return;
    if (((UltraGridBase) this.ugAdvancedSearch).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an item from the list before continuing.", "Select An Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (((UltraGridBase) this.ugAdvancedSearch).ActiveRow.Cells["ProducerContactID"].Value == DBNull.Value && !this.AllowSelectionOfProducersWithoutContacts())
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        int producerContactID = -1;
        if (((UltraGridBase) this.ugAdvancedSearch).ActiveRow.Cells["ProducerContactID"].Value != DBNull.Value)
          producerContactID = (int) ((UltraGridBase) this.ugAdvancedSearch).ActiveRow.Cells["ProducerContactID"].Value;
        this.ProducerSelected((Guid) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ProducerLocationGuid FROM tblProducerLocations WHERE ProducerLocationID=@ID", new object[2]
        {
          (object) "@ID",
          (object) (int) ((UltraGridBase) this.ugAdvancedSearch).ActiveRow.Cells["ProducerLocationID"].Value
        }), producerContactID);
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
        ((Control) this.btnGo).Enabled = true;
      }
    }
  }

  public virtual bool AllowSelectionOfProducersWithoutContacts() => true;

  private void lnkResetSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        switch (control)
        {
          case MGAComboBox mgaComboBox:
            mgaComboBox.Value = (object) null;
            continue;
          case MGATextBox mgaTextBox:
            ((TextEditorControlBase) mgaTextBox).Text = string.Empty;
            continue;
          case MGAMaskedEdit mgaMaskedEdit:
            mgaMaskedEdit.Value = (object) null;
            continue;
          case MGANumericEditor mgaNumericEditor:
            mgaNumericEditor.Value = (object) null;
            continue;
          default:
            continue;
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

  public virtual void ProducerSelected(Guid producerLocationGuid, int producerContactID)
  {
    ProducerLocation producerLocation = new ProducerLocation(producerLocationGuid);
    Form formEx = ObjectFactory.Instance.CreateFormEX(typeof (frmProducers), typeof (frmProducers), (object) producerLocation.ProducerGuid, (object) producerLocation.ProducerLocationGuid);
    if (formEx == null)
      return;
    formEx.MdiParent = MDIControls.Instance.MDIParent;
    formEx.Show();
  }

  public virtual void CheckProducerInfoOnClient(UltraGridRow row)
  {
  }

  public virtual void RunSearch()
  {
    try
    {
      string empty = string.Empty;
      if (SystemSettings.KeyExists("spAdvancedProducerSearch"))
        DefaultDatabase.LoadDataTable((DataTable) this.ds.spAdvancedProducerSearch, SystemSettings.GetStringSetting("spAdvancedProducerSearch"), new object[26]
        {
          (object) "@UserGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@Name",
          (object) ((TextEditorControlBase) this.txtName).Text,
          (object) "@ContactLast",
          (object) ((TextEditorControlBase) this.textContactLast).Text,
          (object) "@ContactFirst",
          (object) ((TextEditorControlBase) this.textContactFirst).Text,
          (object) "@Fax",
          this.maskFax.Value,
          (object) "@Phone",
          this.maskPhone.Value,
          (object) "@FEIN",
          this.txtFEIN.Value,
          (object) "@ProducerTypeID",
          this.cboProducerType.Value,
          (object) "@ProducerStateID",
          this.cboProducerState.Value,
          (object) "@CompanyLocationGuid",
          this.cboCompanyLocations.Value,
          (object) "@City",
          (object) ((TextEditorControlBase) this.txtCity).Text,
          (object) "@ProducerLocationID",
          this.numProducerLocationID.Value,
          (object) "@Email",
          (object) ((TextEditorControlBase) this.txtEmail).Text
        });
      else
        DefaultDatabase.LoadDataTable((DataTable) this.ds.spAdvancedProducerSearch, "dbo.[spAdvancedProducerSearch]", new object[26]
        {
          (object) "@Name",
          (object) ((TextEditorControlBase) this.txtName).Text,
          (object) "@ContactLast",
          (object) ((TextEditorControlBase) this.textContactLast).Text,
          (object) "@ContactFirst",
          (object) ((TextEditorControlBase) this.textContactFirst).Text,
          (object) "@Fax",
          this.maskFax.Value,
          (object) "@Phone",
          this.maskPhone.Value,
          (object) "@FEIN",
          this.txtFEIN.Value,
          (object) "@ProducerTypeID",
          this.cboProducerType.Value,
          (object) "@ProducerStateID",
          this.cboProducerState.Value,
          (object) "@CompanyLocationGuid",
          this.cboCompanyLocations.Value,
          (object) "@City",
          (object) ((TextEditorControlBase) this.txtCity).Text,
          (object) "@ProducerLocationID",
          this.numProducerLocationID.Value,
          (object) "@Email",
          (object) ((TextEditorControlBase) this.txtEmail).Text,
          (object) "@ProducerLocationCode",
          (object) ((TextEditorControlBase) this.txtProducerLocationCode).Text
        });
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      ((Control) this.btnSearch).Enabled = true;
    }
  }

  private void Label11_Click(object sender, EventArgs e)
  {
  }

  private enum ProducerStatus
  {
    Active = 1,
    Inactive = 2,
    Closed = 3,
    Suspended = 4,
  }

  private enum Status
  {
    Active = 1,
    Inactive = 2,
    Closed = 3,
    Suspended = 4,
  }
}
