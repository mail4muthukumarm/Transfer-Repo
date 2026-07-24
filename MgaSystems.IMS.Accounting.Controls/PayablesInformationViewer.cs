// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.PayablesInformationViewer
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class PayablesInformationViewer : UserControl
{
  private IContainer components;
  private Point MouseLocationBuffer;
  private UltraGridRow Row;
  private int GlCompanyId;
  private int ControlNumber;
  private int InvoiceNumber;

  public PayablesInformationViewer() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGAButton buttonClose
  {
    get => this._buttonClose;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonClose_Click);
      MGAButton buttonClose1 = this._buttonClose;
      if (buttonClose1 != null)
        ((Control) buttonClose1).Click -= eventHandler;
      this._buttonClose = value;
      MGAButton buttonClose2 = this._buttonClose;
      if (buttonClose2 == null)
        return;
      ((Control) buttonClose2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("labelLoading")]
  internal virtual Label labelLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelInvoiceNumber")]
  internal virtual Label labelInvoiceNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkViewPolicyInquiry
  {
    get => this._linkViewPolicyInquiry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.linkViewPolicyInquiry_Click);
      LinkLabel viewPolicyInquiry1 = this._linkViewPolicyInquiry;
      if (viewPolicyInquiry1 != null)
        viewPolicyInquiry1.Click -= eventHandler;
      this._linkViewPolicyInquiry = value;
      LinkLabel viewPolicyInquiry2 = this._linkViewPolicyInquiry;
      if (viewPolicyInquiry2 == null)
        return;
      viewPolicyInquiry2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelUnAccountedApplied")]
  internal virtual Label labelUnAccountedApplied { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelExchangeApplied")]
  internal virtual Label labelExchangeApplied { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelInsuredName")]
  internal virtual Label labelInsuredName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelPolicyNumber")]
  internal virtual Label labelPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelControlNumber")]
  internal virtual Label labelControlNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelPolicyNumberLabel")]
  internal virtual Label labelPolicyNumberLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox2")]
  internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelFinanceCompany")]
  internal virtual Label labelFinanceCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("linkAssignFinanceCompany")]
  internal virtual LinkLabel linkAssignFinanceCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelAPApplied")]
  internal virtual Label labelAPApplied { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkwriteOffPayable
  {
    get => this._linkwriteOffPayable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkwriteOffPayable_LinkClicked);
      LinkLabel linkwriteOffPayable1 = this._linkwriteOffPayable;
      if (linkwriteOffPayable1 != null)
        linkwriteOffPayable1.LinkClicked -= clickedEventHandler;
      this._linkwriteOffPayable = value;
      LinkLabel linkwriteOffPayable2 = this._linkwriteOffPayable;
      if (linkwriteOffPayable2 == null)
        return;
      linkwriteOffPayable2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel linkViewUnderwritingInfo
  {
    get => this._linkViewUnderwritingInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkViewUnderwritingInfo_LinkClicked);
      LinkLabel underwritingInfo1 = this._linkViewUnderwritingInfo;
      if (underwritingInfo1 != null)
        underwritingInfo1.LinkClicked -= clickedEventHandler;
      this._linkViewUnderwritingInfo = value;
      LinkLabel underwritingInfo2 = this._linkViewUnderwritingInfo;
      if (underwritingInfo2 == null)
        return;
      underwritingInfo2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (PayablesInformationViewer));
    this.buttonClose = new MGAButton();
    this.labelLoading = new Label();
    this.labelInvoiceNumber = new Label();
    this.Label17 = new Label();
    this.linkwriteOffPayable = new LinkLabel();
    this.linkViewPolicyInquiry = new LinkLabel();
    this.Label15 = new Label();
    this.labelUnAccountedApplied = new Label();
    this.labelExchangeApplied = new Label();
    this.labelAPApplied = new Label();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label6 = new Label();
    this.Label4 = new Label();
    this.labelInsuredName = new Label();
    this.Label7 = new Label();
    this.labelPolicyNumber = new Label();
    this.Label5 = new Label();
    this.labelControlNumber = new Label();
    this.labelPolicyNumberLabel = new Label();
    this.Label3 = new Label();
    this.PictureBox2 = new PictureBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.labelFinanceCompany = new Label();
    this.linkAssignFinanceCompany = new LinkLabel();
    this.linkViewUnderwritingInfo = new LinkLabel();
    ((ISupportInitialize) this.buttonClose).BeginInit();
    this.SuspendLayout();
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.FontData.BoldAsString = "True";
    appearance.FontData.Name = "Kartika";
    appearance.TextHAlign = (HAlign) 2;
    appearance.TextTrimming = (TextTrimming) 2;
    appearance.TextVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClose).Appearance = (AppearanceBase) appearance;
    ((Control) this.buttonClose).Location = new Point(447, 2);
    ((Control) this.buttonClose).Name = "buttonClose";
    ((Control) this.buttonClose).Size = new Size(20, 20);
    ((Control) this.buttonClose).TabIndex = 56;
    ((ControlBase) this.buttonClose).Text = "X";
    this.labelLoading.BackColor = Color.White;
    this.labelLoading.Font = new Font("Tahoma", 10f);
    this.labelLoading.ForeColor = Color.SlateGray;
    this.labelLoading.Location = new Point(7, 24);
    this.labelLoading.Name = "labelLoading";
    this.labelLoading.Size = new Size(456, 232);
    this.labelLoading.TabIndex = 53;
    this.labelLoading.Text = "Loading Payables Information....";
    this.labelLoading.TextAlign = ContentAlignment.MiddleCenter;
    this.labelInvoiceNumber.BackColor = Color.White;
    this.labelInvoiceNumber.ForeColor = Color.DimGray;
    this.labelInvoiceNumber.Location = new Point(103, 80 /*0x50*/);
    this.labelInvoiceNumber.Name = "labelInvoiceNumber";
    this.labelInvoiceNumber.Size = new Size(256 /*0x0100*/, 16 /*0x10*/);
    this.labelInvoiceNumber.TabIndex = 55;
    this.labelInvoiceNumber.Text = "[Invoice Number]";
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.White;
    this.Label17.ForeColor = Color.DimGray;
    this.Label17.Location = new Point(15, 80 /*0x50*/);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(54, 16 /*0x10*/);
    this.Label17.TabIndex = 54;
    this.Label17.Text = "Invoice #:";
    this.linkwriteOffPayable.AutoSize = true;
    this.linkwriteOffPayable.BackColor = Color.White;
    this.linkwriteOffPayable.Location = new Point(335, 224 /*0xE0*/);
    this.linkwriteOffPayable.Name = "linkwriteOffPayable";
    this.linkwriteOffPayable.Size = new Size(90, 16 /*0x10*/);
    this.linkwriteOffPayable.TabIndex = 52;
    this.linkwriteOffPayable.TabStop = true;
    this.linkwriteOffPayable.Text = "Write-Off Payable";
    this.linkViewPolicyInquiry.AutoSize = true;
    this.linkViewPolicyInquiry.BackColor = Color.White;
    this.linkViewPolicyInquiry.Location = new Point(335, 208 /*0xD0*/);
    this.linkViewPolicyInquiry.Name = "linkViewPolicyInquiry";
    this.linkViewPolicyInquiry.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.linkViewPolicyInquiry.TabIndex = 51;
    this.linkViewPolicyInquiry.TabStop = true;
    this.linkViewPolicyInquiry.Text = "View Policy Inquiry";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.White;
    this.Label15.ForeColor = Color.DimGray;
    this.Label15.Location = new Point(335, 192 /*0xC0*/);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(45, 16 /*0x10*/);
    this.Label15.TabIndex = 50;
    this.Label15.Text = "Options:";
    this.labelUnAccountedApplied.BackColor = Color.White;
    this.labelUnAccountedApplied.ForeColor = Color.DimGray;
    this.labelUnAccountedApplied.Location = new Point(135, 144 /*0x90*/);
    this.labelUnAccountedApplied.Name = "labelUnAccountedApplied";
    this.labelUnAccountedApplied.Size = new Size(125, 16 /*0x10*/);
    this.labelUnAccountedApplied.TabIndex = 49;
    this.labelUnAccountedApplied.Text = "$0.00";
    this.labelUnAccountedApplied.TextAlign = ContentAlignment.TopRight;
    this.labelUnAccountedApplied.Visible = false;
    this.labelExchangeApplied.BackColor = Color.White;
    this.labelExchangeApplied.ForeColor = Color.DimGray;
    this.labelExchangeApplied.Location = new Point(135, 128 /*0x80*/);
    this.labelExchangeApplied.Name = "labelExchangeApplied";
    this.labelExchangeApplied.Size = new Size(125, 16 /*0x10*/);
    this.labelExchangeApplied.TabIndex = 48 /*0x30*/;
    this.labelExchangeApplied.Text = "$0.00";
    this.labelExchangeApplied.TextAlign = ContentAlignment.TopRight;
    this.labelExchangeApplied.Visible = false;
    this.labelAPApplied.BackColor = Color.White;
    this.labelAPApplied.ForeColor = Color.DimGray;
    this.labelAPApplied.Location = new Point(135, 112 /*0x70*/);
    this.labelAPApplied.Name = "labelAPApplied";
    this.labelAPApplied.Size = new Size(125, 16 /*0x10*/);
    this.labelAPApplied.TabIndex = 47;
    this.labelAPApplied.Text = "$0.00";
    this.labelAPApplied.TextAlign = ContentAlignment.TopRight;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.White;
    this.Label11.ForeColor = Color.DarkSlateGray;
    this.Label11.Location = new Point(15, 192 /*0xC0*/);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(94, 16 /*0x10*/);
    this.Label11.TabIndex = 44;
    this.Label11.Text = "Finance Company:";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.White;
    this.Label10.ForeColor = Color.DimGray;
    this.Label10.Location = new Point(15, 128 /*0x80*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(94, 16 /*0x10*/);
    this.Label10.TabIndex = 43;
    this.Label10.Text = "Exchange Applied:";
    this.Label10.Visible = false;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.White;
    this.Label9.ForeColor = Color.DimGray;
    this.Label9.Location = new Point(15, 144 /*0x90*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(115, 16 /*0x10*/);
    this.Label9.TabIndex = 42;
    this.Label9.Text = "Un-Accounted Applied:";
    this.Label9.Visible = false;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.White;
    this.Label8.ForeColor = Color.DimGray;
    this.Label8.Location = new Point(15, 112 /*0x70*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(60, 16 /*0x10*/);
    this.Label8.TabIndex = 41;
    this.Label8.Text = "AP Applied:";
    this.Label6.BackColor = Color.Gainsboro;
    this.Label6.Location = new Point(470, 0);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(1, 265);
    this.Label6.TabIndex = 40;
    this.Label6.Text = "Label6";
    this.Label4.BackColor = Color.Gainsboro;
    this.Label4.Location = new Point(-2, 263);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(473, 1);
    this.Label4.TabIndex = 39;
    this.Label4.Text = "Label4";
    this.labelInsuredName.BackColor = Color.White;
    this.labelInsuredName.ForeColor = Color.DimGray;
    this.labelInsuredName.Location = new Point(103, 64 /*0x40*/);
    this.labelInsuredName.Name = "labelInsuredName";
    this.labelInsuredName.Size = new Size(256 /*0x0100*/, 16 /*0x10*/);
    this.labelInsuredName.TabIndex = 38;
    this.labelInsuredName.Text = "[Insured Name]";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.White;
    this.Label7.ForeColor = Color.DimGray;
    this.Label7.Location = new Point(15, 64 /*0x40*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(77, 16 /*0x10*/);
    this.Label7.TabIndex = 37;
    this.Label7.Text = "Insured Name:";
    this.labelPolicyNumber.BackColor = Color.White;
    this.labelPolicyNumber.ForeColor = Color.DimGray;
    this.labelPolicyNumber.Location = new Point(103, 32 /*0x20*/);
    this.labelPolicyNumber.Name = "labelPolicyNumber";
    this.labelPolicyNumber.Size = new Size(248, 16 /*0x10*/);
    this.labelPolicyNumber.TabIndex = 36;
    this.labelPolicyNumber.Text = "[Policy Number]";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.White;
    this.Label5.ForeColor = Color.DimGray;
    this.Label5.Location = new Point(15, 48 /*0x30*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(85, 16 /*0x10*/);
    this.Label5.TabIndex = 35;
    this.Label5.Text = "Control Number:";
    this.labelControlNumber.BackColor = Color.White;
    this.labelControlNumber.ForeColor = Color.DimGray;
    this.labelControlNumber.Location = new Point(103, 48 /*0x30*/);
    this.labelControlNumber.Name = "labelControlNumber";
    this.labelControlNumber.Size = new Size(264, 16 /*0x10*/);
    this.labelControlNumber.TabIndex = 34;
    this.labelControlNumber.Text = "[Control Number]";
    this.labelPolicyNumberLabel.AutoSize = true;
    this.labelPolicyNumberLabel.BackColor = Color.White;
    this.labelPolicyNumberLabel.ForeColor = Color.DimGray;
    this.labelPolicyNumberLabel.Location = new Point(15, 32 /*0x20*/);
    this.labelPolicyNumberLabel.Name = "labelPolicyNumberLabel";
    this.labelPolicyNumberLabel.Size = new Size(77, 16 /*0x10*/);
    this.labelPolicyNumberLabel.TabIndex = 33;
    this.labelPolicyNumberLabel.Text = "Policy Number:";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.White;
    this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline);
    this.Label3.Location = new Point(7, 8);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(247, 18);
    this.Label3.TabIndex = 32 /*0x20*/;
    this.Label3.Text = "Payables Extended Information Viewer";
    this.PictureBox2.BackColor = Color.White;
    this.PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
    this.PictureBox2.Location = new Point(359, 24);
    this.PictureBox2.Name = "PictureBox2";
    this.PictureBox2.Size = new Size(104, 88);
    this.PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
    this.PictureBox2.TabIndex = 31 /*0x1F*/;
    this.PictureBox2.TabStop = false;
    this.Label2.BackColor = Color.Gainsboro;
    this.Label2.Location = new Point(1, 0);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(1, 265);
    this.Label2.TabIndex = 30;
    this.Label2.Text = "Label2";
    this.Label1.BackColor = Color.Gainsboro;
    this.Label1.Location = new Point(-1, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(473, 1);
    this.Label1.TabIndex = 29;
    this.Label1.Text = "Label1";
    this.labelFinanceCompany.BackColor = Color.White;
    this.labelFinanceCompany.ForeColor = Color.DimGray;
    this.labelFinanceCompany.Location = new Point(111, 192 /*0xC0*/);
    this.labelFinanceCompany.Name = "labelFinanceCompany";
    this.labelFinanceCompany.Size = new Size(216, 16 /*0x10*/);
    this.labelFinanceCompany.TabIndex = 46;
    this.labelFinanceCompany.Text = "[Finance Company]";
    this.linkAssignFinanceCompany.AutoSize = true;
    this.linkAssignFinanceCompany.BackColor = Color.White;
    this.linkAssignFinanceCompany.Location = new Point(335, 240 /*0xF0*/);
    this.linkAssignFinanceCompany.Name = "linkAssignFinanceCompany";
    this.linkAssignFinanceCompany.Size = new Size(124, 16 /*0x10*/);
    this.linkAssignFinanceCompany.TabIndex = 45;
    this.linkAssignFinanceCompany.TabStop = true;
    this.linkAssignFinanceCompany.Text = "Assign Finance Company";
    this.linkAssignFinanceCompany.Visible = false;
    this.linkViewUnderwritingInfo.AutoSize = true;
    this.linkViewUnderwritingInfo.BackColor = Color.White;
    this.linkViewUnderwritingInfo.Location = new Point(16 /*0x10*/, 232);
    this.linkViewUnderwritingInfo.Name = "linkViewUnderwritingInfo";
    this.linkViewUnderwritingInfo.Size = new Size(155, 16 /*0x10*/);
    this.linkViewUnderwritingInfo.TabIndex = 57;
    this.linkViewUnderwritingInfo.TabStop = true;
    this.linkViewUnderwritingInfo.Text = "View Underwriting Policy Detail";
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.linkViewUnderwritingInfo);
    this.Controls.Add((Control) this.buttonClose);
    this.Controls.Add((Control) this.labelInvoiceNumber);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.linkwriteOffPayable);
    this.Controls.Add((Control) this.linkViewPolicyInquiry);
    this.Controls.Add((Control) this.Label15);
    this.Controls.Add((Control) this.labelUnAccountedApplied);
    this.Controls.Add((Control) this.labelExchangeApplied);
    this.Controls.Add((Control) this.labelAPApplied);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.labelInsuredName);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.labelPolicyNumber);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.labelControlNumber);
    this.Controls.Add((Control) this.labelPolicyNumberLabel);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.PictureBox2);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.labelFinanceCompany);
    this.Controls.Add((Control) this.linkAssignFinanceCompany);
    this.Controls.Add((Control) this.labelLoading);
    this.Font = new Font("Tahoma", 8f);
    this.Name = nameof (PayablesInformationViewer);
    this.Size = new Size(472, 264);
    ((ISupportInitialize) this.buttonClose).EndInit();
    this.ResumeLayout(false);
  }

  public void ShowInformation(UltraGridRow Row, int glCompanyId)
  {
    this.Row = Row;
    this.labelLoading.Visible = true;
    this.labelLoading.BringToFront();
    this.GlCompanyId = glCompanyId;
    this.ControlNumber = Conversions.ToInteger(this.Row.Cells["QuoteControlNum"].Value);
    this.InvoiceNumber = Conversions.ToInteger(this.Row.Cells["InvoiceNum"].Value);
    this.LoadData();
  }

  private void LoadData() => new Thread(new ThreadStart(this.DoLoadData)).Start();

  private void DoLoadData()
  {
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetReceivablesExtendedInformation", (object) "@controlnumber", (object) Conversions.ToInteger(this.Row.Cells["QuoteControlNum"].Value), (object) "@invoicenum", (object) Conversions.ToInteger(this.Row.Cells["InvoiceNum"].Value));
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new PayablesInformationViewer.LoadDataCompletedHandler(this.LoadDataCompleted), (object) dataTable);
  }

  private void LoadDataCompleted(DataTable TableObject)
  {
    if (TableObject.Rows.Count == 0)
      return;
    this.labelPolicyNumber.Text = TableObject.Rows[0]["PolicyNumber"].ToString();
    this.labelControlNumber.Text = TableObject.Rows[0]["ControlNumber"].ToString();
    this.labelInsuredName.Text = TableObject.Rows[0]["InsuredName"].ToString();
    this.labelInvoiceNumber.Text = TableObject.Rows[0]["InvoiceNumber"].ToString();
    this.labelFinanceCompany.Text = TableObject.Rows[0]["FinanceCompany"].ToString();
    this.labelAPApplied.Text = Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.Row.Cells["APAPPLIED"].Value)) || this.Row.Cells["APAPPLIED"].Value == null ? "$0.00" : Microsoft.VisualBasic.Strings.Format((object) this.Row.Cells["APAPPLIED"].Value.ToString(), "Currency");
    this.labelLoading.Visible = false;
  }

  public event PayablesInformationViewer.ViewPolicyDetailClickedEventHandler ViewPolicyDetailClicked;

  public event PayablesInformationViewer.WriteOffPayableClickedEventHandler WriteOffPayableClicked;

  private void buttonClose_Click(object sender, EventArgs e) => this.Visible = false;

  private void linkViewPolicyInquiry_Click(object sender, EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    PayablesInformationViewer.ViewPolicyDetailClickedEventHandler detailClickedEvent = this.ViewPolicyDetailClickedEvent;
    if (detailClickedEvent == null)
      return;
    detailClickedEvent((object) this, new ViewPolicyClickedEventArgs(this.GlCompanyId, this.ControlNumber));
  }

  private void linkwriteOffPayable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    PayablesInformationViewer.WriteOffPayableClickedEventHandler payableClickedEvent = this.WriteOffPayableClickedEvent;
    if (payableClickedEvent == null)
      return;
    payableClickedEvent((object) this, new WriteOffPayableClickedEventArgs(this.GlCompanyId, this.ControlNumber, this.Row));
  }

  private void linkViewUnderwritingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    PolicyServices.LaunchFormPolicyDetails(this.ControlNumber);
  }

  private delegate void LoadDataCompletedHandler(DataTable TableObject);

  public delegate void ViewPolicyDetailClickedEventHandler(
    object sender,
    ViewPolicyClickedEventArgs e);

  public delegate void WriteOffPayableClickedEventHandler(
    object sender,
    WriteOffPayableClickedEventArgs e);
}
