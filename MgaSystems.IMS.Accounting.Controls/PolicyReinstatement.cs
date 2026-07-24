// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.PolicyReinstatement
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class PolicyReinstatement : UserControl
{
  private IContainer components;
  private string _policyNumber;
  private string _insuredName;
  private string _producer;
  private string _companyName;
  private int _invoiceNumber;
  private int _quoteId;
  private DateTime _issuanceDate;
  private int _transactNum;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  public virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  public virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  public virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  public virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public virtual MGAButton buttonReinstatePolicy
  {
    get => this._buttonReinstatePolicy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonReinstatePolicy_Click);
      MGAButton buttonReinstatePolicy1 = this._buttonReinstatePolicy;
      if (buttonReinstatePolicy1 != null)
        ((Control) buttonReinstatePolicy1).Click -= eventHandler;
      this._buttonReinstatePolicy = value;
      MGAButton buttonReinstatePolicy2 = this._buttonReinstatePolicy;
      if (buttonReinstatePolicy2 == null)
        return;
      ((Control) buttonReinstatePolicy2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabControl1")]
  public virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  internal virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  internal virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public virtual UltraGrid gridPastDueUponNotice
  {
    get => this._gridPastDueUponNotice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.gridPastDueUponNotice_InitializeLayout);
      UltraGrid pastDueUponNotice1 = this._gridPastDueUponNotice;
      if (pastDueUponNotice1 != null)
        pastDueUponNotice1.InitializeLayout -= layoutEventHandler;
      this._gridPastDueUponNotice = value;
      UltraGrid pastDueUponNotice2 = this._gridPastDueUponNotice;
      if (pastDueUponNotice2 == null)
        return;
      pastDueUponNotice2.InitializeLayout += layoutEventHandler;
    }
  }

  public virtual UltraGrid gridOtherInvoices
  {
    get => this._gridOtherInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.gridOtherInvoices_InitializeLayout);
      UltraGrid gridOtherInvoices1 = this._gridOtherInvoices;
      if (gridOtherInvoices1 != null)
        gridOtherInvoices1.InitializeLayout -= layoutEventHandler;
      this._gridOtherInvoices = value;
      UltraGrid gridOtherInvoices2 = this._gridOtherInvoices;
      if (gridOtherInvoices2 == null)
        return;
      gridOtherInvoices2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblDateIssued")]
  public virtual Label lblDateIssued { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  public virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelInsuredName")]
  public virtual Label labelInsuredName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelProducerName")]
  public virtual Label labelProducerName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelCompanyName")]
  public virtual Label labelCompanyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblReInstatementProgess")]
  public virtual Label lblReInstatementProgess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance22 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PolicyReinstatement));
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.gridPastDueUponNotice = new UltraGrid();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.gridOtherInvoices = new UltraGrid();
    this.Panel1 = new Panel();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.lblReInstatementProgess = new Label();
    this.lblDateIssued = new Label();
    this.Label6 = new Label();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.buttonReinstatePolicy = new MGAButton();
    this.labelInsuredName = new Label();
    this.labelProducerName = new Label();
    this.labelCompanyName = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.gridPastDueUponNotice).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.gridOtherInvoices).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.buttonReinstatePolicy).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.gridPastDueUponNotice);
    ((Control) this.UltraTabPageControl1).Location = new Point(3, 22);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(530, 95);
    ((UltraControlBase) this.gridPastDueUponNotice).Cursor = Cursors.Default;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.WhiteSmoke;
    appearance8.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridPastDueUponNotice).Dock = DockStyle.Fill;
    ((Control) this.gridPastDueUponNotice).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridPastDueUponNotice).Location = new Point(0, 0);
    ((Control) this.gridPastDueUponNotice).Name = "gridPastDueUponNotice";
    ((Control) this.gridPastDueUponNotice).Size = new Size(530, 95);
    ((Control) this.gridPastDueUponNotice).TabIndex = 12;
    ((UltraControlBase) this.gridPastDueUponNotice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPastDueUponNotice).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.gridOtherInvoices);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(530, 95);
    ((UltraControlBase) this.gridOtherInvoices).Cursor = Cursors.Default;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.WhiteSmoke;
    appearance17.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridOtherInvoices).Dock = DockStyle.Fill;
    ((Control) this.gridOtherInvoices).Location = new Point(0, 0);
    ((Control) this.gridOtherInvoices).Name = "gridOtherInvoices";
    ((Control) this.gridOtherInvoices).Size = new Size(530, 95);
    ((Control) this.gridOtherInvoices).TabIndex = 13;
    ((UltraControlBase) this.gridOtherInvoices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOtherInvoices).UseOsThemes = (DefaultableBoolean) 2;
    this.Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Panel1.BackColor = Color.White;
    this.Panel1.Controls.Add((Control) this.MgaGroupBox1);
    this.Panel1.Font = new Font("Tahoma", 8f);
    this.Panel1.ForeColor = Color.Black;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(568, 224 /*0xE0*/);
    this.Panel1.TabIndex = 0;
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.Appearance = (AppearanceBase) appearance19;
    this.MgaGroupBox1.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance20.BackColor = Color.FromArgb(239, 247, 253);
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance20;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lblReInstatementProgess);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lblDateIssued);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label6);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.UltraTabControl1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.buttonReinstatePolicy);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.labelInsuredName);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.labelProducerName);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.labelCompanyName);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    appearance21.AlphaLevel = (short) 230;
    appearance21.FontData.SizeInPoints = 10f;
    appearance21.ForeColor = Color.White;
    appearance21.ImageAlpha = (Alpha) 2;
    appearance21.ImageBackground = (Image) componentResourceManager.GetObject("Appearance22.ImageBackground");
    appearance21.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance21;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(552, 208 /*0xD0*/);
    ((Control) this.MgaGroupBox1).TabIndex = 1;
    this.MgaGroupBox1.Text = "MgaGroupBox1";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.lblReInstatementProgess.Location = new Point(384, 56);
    this.lblReInstatementProgess.Name = "lblReInstatementProgess";
    this.lblReInstatementProgess.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.lblReInstatementProgess.TabIndex = 19;
    this.lblReInstatementProgess.TextAlign = ContentAlignment.MiddleRight;
    this.lblReInstatementProgess.Visible = false;
    this.lblDateIssued.AutoSize = true;
    this.lblDateIssued.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblDateIssued.Location = new Point(464, 80 /*0x50*/);
    this.lblDateIssued.Name = "lblDateIssued";
    this.lblDateIssued.Size = new Size(85, 13);
    this.lblDateIssued.TabIndex = 17;
    this.lblDateIssued.Text = "[Date Issued]";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(392, 80 /*0x50*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(73, 13);
    this.Label6.TabIndex = 16 /*0x10*/;
    this.Label6.Text = "NOC Issued:";
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Location = new Point(8, 80 /*0x50*/);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(536, 120);
    ((UltraTabControlBase) this.UltraTabControl1).Style = (UltraTabControlStyle) 12;
    ((Control) this.UltraTabControl1).TabIndex = 7;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 3;
    ((UltraTabControlBase) this.UltraTabControl1).TabPageMargins.Bottom = 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPageMargins.Left = 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPageMargins.Right = 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPageMargins.Top = 2;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Past Due When NOC Issued";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Other Invoices";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraControlBase) this.UltraTabControl1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(530, 95);
    appearance22.BackColor = Color.FromArgb(248, 248, 248);
    appearance22.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance22.BackGradientStyle = (GradientStyle) 2;
    appearance22.BorderColor = Color.DarkGray;
    appearance22.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance21.Image"));
    appearance22.ImageHAlign = (HAlign) 1;
    appearance22.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonReinstatePolicy).Appearance = (AppearanceBase) appearance22;
    ((Control) this.buttonReinstatePolicy).Location = new Point(408, 32 /*0x20*/);
    ((Control) this.buttonReinstatePolicy).Name = "buttonReinstatePolicy";
    ((Control) this.buttonReinstatePolicy).Size = new Size(136, 24);
    ((Control) this.buttonReinstatePolicy).TabIndex = 6;
    ((ControlBase) this.buttonReinstatePolicy).Text = "Issue Reinstatement";
    this.buttonReinstatePolicy.UseOSThemes = (DefaultableBoolean) 2;
    this.labelInsuredName.AutoSize = true;
    this.labelInsuredName.Location = new Point(64 /*0x40*/, 56);
    this.labelInsuredName.Name = "labelInsuredName";
    this.labelInsuredName.Size = new Size(52, 13);
    this.labelInsuredName.TabIndex = 5;
    this.labelInsuredName.Text = "[Insured]";
    this.labelProducerName.AutoSize = true;
    this.labelProducerName.Location = new Point(64 /*0x40*/, 40);
    this.labelProducerName.Name = "labelProducerName";
    this.labelProducerName.Size = new Size(58, 13);
    this.labelProducerName.TabIndex = 4;
    this.labelProducerName.Text = "[Producer]";
    this.labelCompanyName.AutoSize = true;
    this.labelCompanyName.Location = new Point(64 /*0x40*/, 24);
    this.labelCompanyName.Name = "labelCompanyName";
    this.labelCompanyName.Size = new Size(60, 13);
    this.labelCompanyName.TabIndex = 3;
    this.labelCompanyName.Text = "[Company]";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 56);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(48 /*0x30*/, 13);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "Insured:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 40);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(54, 13);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Producer:";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Company:";
    this.Controls.Add((Control) this.Panel1);
    this.Name = nameof (PolicyReinstatement);
    this.Size = new Size(568, 224 /*0xE0*/);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.gridPastDueUponNotice).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridOtherInvoices).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.buttonReinstatePolicy).EndInit();
    this.ResumeLayout(false);
  }

  internal string PolicyNumber => this._policyNumber;

  internal string InsuredName => this._insuredName;

  internal string ProducerName => this._producer;

  internal string Company => this._companyName;

  protected int InvoiceNumber => this._invoiceNumber;

  protected int QuoteId => this._quoteId;

  protected DateTime IssuanceDate => this._issuanceDate;

  protected int TransactionNumber => this._transactNum;

  private PolicyReinstatement() => this.InitializeComponent();

  public PolicyReinstatement(int InvoiceNumber, int TransactionNumber)
  {
    this.InitializeComponent();
    this._invoiceNumber = InvoiceNumber;
    this._transactNum = TransactionNumber;
    this.GetQuoteId(InvoiceNumber);
    this.GetControlHeader(this._quoteId);
    this.GetNOCIssuanceDate();
    this.LoadInvoices();
  }

  private void GetQuoteId(int InvoiceNumber)
  {
    this._quoteId = Database.Instance.QueryText.PerformScalarQueryInt($"select quoteId from tblfin_invoices where invoiceNum = {InvoiceNumber}");
  }

  private void GetControlHeader(int QuoteId)
  {
    Quote quote = new Quote(QuoteId);
    this.MgaGroupBox1.Text = "Policy # " + quote.PolicyNumber;
    this._policyNumber = quote.PolicyNumber;
    this.labelCompanyName.Text = quote.Company;
    this._companyName = quote.Company;
    this.labelProducerName.Text = quote.ProducerName;
    this._producer = quote.ProducerName;
    this.labelInsuredName.Text = quote.SubmissionGroup.InsuredLocation.Insured.Name;
  }

  private void GetNOCIssuanceDate()
  {
    this._issuanceDate = Database.Instance.QueryText.PerformScalarQueryDate($"select dbo.GetInvoiceNOCIssuanceDate({this._invoiceNumber})");
    this.lblDateIssued.Text = this._issuanceDate.ToShortDateString();
  }

  private void LoadInvoices()
  {
    ((UltraGridBase) this.gridPastDueUponNotice).DataSource = (object) PolicyServices.GetPolicyReinstatementInvoicesNOC(this._quoteId, this._issuanceDate, this._transactNum);
    ((UltraGridBase) this.gridOtherInvoices).DataSource = (object) PolicyServices.GetPolicyReinstatementInvoices(this._quoteId, this._issuanceDate, this._transactNum);
  }

  public virtual void ReinstatePolicy()
  {
    bool flag = false;
    try
    {
      this.lblReInstatementProgess.Visible = true;
      this.lblReInstatementProgess.Text = "Printing Reinstatement Notice..";
      this.lblReInstatementProgess.ForeColor = Color.Black;
      this.lblReInstatementProgess.Refresh();
      PolicyServices.ReinstatePolicy(this._quoteId);
      this.lblReInstatementProgess.Text = "Creating PDF Document..";
      this.lblReInstatementProgess.Refresh();
      this.lblReInstatementProgess.Text = "Saving To Document Manager..";
      this.lblReInstatementProgess.Refresh();
      this.lblReInstatementProgess.Text = "Setting Reinstatement Status..";
      this.lblReInstatementProgess.Refresh();
      this.lblReInstatementProgess.Text = "Policy Reinstated!";
      this.lblReInstatementProgess.ForeColor = Color.LightSteelBlue;
      this.lblReInstatementProgess.Refresh();
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.lblReInstatementProgess.Text = "Could Not Reinstate Policy!";
      this.lblReInstatementProgess.ForeColor = Color.Red;
      this.lblReInstatementProgess.Refresh();
      throw;
    }
    finally
    {
      ((Control) this.buttonReinstatePolicy).Enabled = !flag;
    }
  }

  private void buttonReinstatePolicy_Click(object sender, EventArgs e) => this.ReinstatePolicy();

  private void gridPastDueUponNotice_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = ((UltraGridBase) this.gridPastDueUponNotice).DisplayLayout.Bands[0];
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    band.Columns["invoicenum"].Hidden = true;
    band.Columns["status"].Hidden = true;
    ((HeaderBase) band.Columns["officeinvoicenum"].Header).Caption = "Invoice #";
    ((HeaderBase) band.Columns["duedate"].Header).Caption = "Due Date";
    ((HeaderBase) band.Columns["amtdue"].Header).Caption = "Amt. Past Due";
    ((HeaderBase) band.Columns["amtdue"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["amtdue"].CellAppearance.TextHAlign = (HAlign) 3;
    band.Columns["amtdue"].Format = "c";
    ((HeaderBase) band.Columns["amtpaidnow"].Header).Caption = "Amt. Paid";
    ((HeaderBase) band.Columns["amtpaidnow"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["amtpaidnow"].CellAppearance.TextHAlign = (HAlign) 3;
    band.Columns["amtpaidnow"].Format = "c";
  }

  private void gridOtherInvoices_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = ((UltraGridBase) this.gridOtherInvoices).DisplayLayout.Bands[0];
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    band.Columns["invoicenum"].Hidden = true;
    ((HeaderBase) band.Columns["officeinvoicenum"].Header).Caption = "Invoice #";
    ((HeaderBase) band.Columns["duedate"].Header).Caption = "Due Date";
    ((HeaderBase) band.Columns["amtdue"].Header).Caption = "Amt. Past Due";
    ((HeaderBase) band.Columns["amtdue"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["amtdue"].CellAppearance.TextHAlign = (HAlign) 3;
    band.Columns["amtdue"].Format = "c";
    ((HeaderBase) band.Columns["amtpaidnow"].Header).Caption = "Amt. Paid";
    ((HeaderBase) band.Columns["amtpaidnow"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["amtpaidnow"].CellAppearance.TextHAlign = (HAlign) 3;
    band.Columns["amtpaidnow"].Format = "c";
    ((HeaderBase) band.Columns["status"].Header).Caption = "Status";
  }
}
