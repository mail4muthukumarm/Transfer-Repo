// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptPreBindInvoice_Details
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Reports.Documents;

public sealed class rptPreBindInvoice_Details : SectionReport
{
  private string _strRemitter;
  private DataTable _MyData;
  private rptPreBindInvoice _MyParent;
  private Container components;
  private Detail detail;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private TextBox txtDescription;
  private TextBox txtRemitterPercent;
  private TextBox txtGrossBilled;
  private TextBox txtRemitterAmount;
  private TextBox txtDue;
  private GroupHeader ghNetSum;
  private Label lblDescription;
  private Label lblRemitterPrecent;
  private Label lblGrossBilled;
  private Label lblRemitterAmount;
  private Label lblNetDue;
  private GroupFooter gfNetSum;
  private Label lblTotals;
  private TextBox txtTotalDue;
  private TextBox txtGrossBilledTotal;
  private TextBox txtRemitterAmountTotal;
  private Line Line7;

  public rptPreBindInvoice_Details(string Remitter, rptPreBindInvoice MyParent, DataTable data)
  {
    this.InitializeComponent();
    this._strRemitter = Remitter;
    this._MyData = data;
    this._MyParent = MyParent;
    this.ReportStart += new EventHandler(this.rptPreBindInvoice_Details_ReportStart);
    ((Section) this.gfNetSum).Format += new EventHandler(this.gfNetSum_Format);
    ((Section) this.detail).BeforePrint += new EventHandler(this.detail_BeforePrint);
  }

  private void detail_BeforePrint(object sender, EventArgs e)
  {
    ((ARControl) this.txtGrossBilled).Height = ((Section) this.detail).Height;
    ((ARControl) this.txtRemitterAmount).Height = ((Section) this.detail).Height;
    ((ARControl) this.txtRemitterPercent).Height = ((Section) this.detail).Height;
    ((ARControl) this.txtDue).Height = ((Section) this.detail).Height;
  }

  private void gfNetSum_Format(object sender, EventArgs e)
  {
    this._MyParent.TotalGrossBilled = this.txtGrossBilledTotal == null ? 0M : (this.txtGrossBilledTotal.Value == null ? 0M : Decimal.Parse(this.txtGrossBilledTotal.Value.ToString()));
    if (this.txtRemitterAmountTotal != null)
    {
      if (this.txtRemitterAmountTotal.Value != null)
        this._MyParent.TotalRemitterAmount = Decimal.Parse(this.txtRemitterAmountTotal.Value.ToString());
      else
        this._MyParent.TotalRemitterAmount = 0M;
    }
    else
      this._MyParent.TotalRemitterAmount = 0M;
  }

  private void rptPreBindInvoice_Details_ReportStart(object sender, EventArgs e)
  {
    this.lblRemitterAmount.Text = this._strRemitter + " Amt";
    this.lblRemitterPrecent.Text = this._strRemitter + " %";
    this.DataSource = (object) this._MyData;
  }

  private void detail_Format(object sender, EventArgs e)
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptPreBindInvoice_Details));
    this.detail = new Detail();
    this.txtDescription = new TextBox();
    this.txtRemitterPercent = new TextBox();
    this.txtGrossBilled = new TextBox();
    this.txtRemitterAmount = new TextBox();
    this.txtDue = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.reportFooter1 = new ReportFooter();
    this.ghNetSum = new GroupHeader();
    this.lblDescription = new Label();
    this.lblRemitterPrecent = new Label();
    this.lblGrossBilled = new Label();
    this.lblRemitterAmount = new Label();
    this.lblNetDue = new Label();
    this.gfNetSum = new GroupFooter();
    this.lblTotals = new Label();
    this.txtTotalDue = new TextBox();
    this.txtGrossBilledTotal = new TextBox();
    this.txtRemitterAmountTotal = new TextBox();
    this.Line7 = new Line();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.txtRemitterPercent).BeginInit();
    ((ISupportInitialize) this.txtGrossBilled).BeginInit();
    ((ISupportInitialize) this.txtRemitterAmount).BeginInit();
    ((ISupportInitialize) this.txtDue).BeginInit();
    ((ISupportInitialize) this.lblDescription).BeginInit();
    ((ISupportInitialize) this.lblRemitterPrecent).BeginInit();
    ((ISupportInitialize) this.lblGrossBilled).BeginInit();
    ((ISupportInitialize) this.lblRemitterAmount).BeginInit();
    ((ISupportInitialize) this.lblNetDue).BeginInit();
    ((ISupportInitialize) this.lblTotals).BeginInit();
    ((ISupportInitialize) this.txtTotalDue).BeginInit();
    ((ISupportInitialize) this.txtGrossBilledTotal).BeginInit();
    ((ISupportInitialize) this.txtRemitterAmountTotal).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.txtDescription,
      (ARControl) this.txtRemitterPercent,
      (ARControl) this.txtGrossBilled,
      (ARControl) this.txtRemitterAmount,
      (ARControl) this.txtDue
    });
    ((Section) this.detail).Height = 0.1770833f;
    ((Section) this.detail).Name = "detail";
    ((Section) this.detail).Format += new EventHandler(this.detail_Format);
    ((ARControl) this.txtDescription).Border.BottomColor = Color.Black;
    ((ARControl) this.txtDescription).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDescription).Border.LeftColor = Color.Black;
    ((ARControl) this.txtDescription).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDescription).Border.RightColor = Color.Black;
    ((ARControl) this.txtDescription).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDescription).Border.TopColor = Color.Black;
    ((ARControl) this.txtDescription).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).DataField = "Description";
    ((ARControl) this.txtDescription).Height = 3f / 16f;
    ((ARControl) this.txtDescription).Left = 0.0f;
    ((ARControl) this.txtDescription).Name = "txtDescription";
    this.txtDescription.Style = "ddo-char-set: 0; ";
    this.txtDescription.Text = "Description";
    ((ARControl) this.txtDescription).Top = 0.0f;
    ((ARControl) this.txtDescription).Width = 2.625f;
    ((ARControl) this.txtRemitterPercent).Border.BottomColor = Color.Black;
    ((ARControl) this.txtRemitterPercent).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterPercent).Border.LeftColor = Color.Black;
    ((ARControl) this.txtRemitterPercent).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRemitterPercent).Border.RightColor = Color.Black;
    ((ARControl) this.txtRemitterPercent).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterPercent).Border.TopColor = Color.Black;
    ((ARControl) this.txtRemitterPercent).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRemitterPercent).DataField = "REMITTERPERCENTRATE";
    ((ARControl) this.txtRemitterPercent).Height = 3f / 16f;
    ((ARControl) this.txtRemitterPercent).Left = 59f / 16f;
    ((ARControl) this.txtRemitterPercent).Name = "txtRemitterPercent";
    this.txtRemitterPercent.OutputFormat = resourceManager.GetString("txtRemitterPercent.OutputFormat");
    this.txtRemitterPercent.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtRemitterPercent.Text = "Percent";
    ((ARControl) this.txtRemitterPercent).Top = 0.0f;
    ((ARControl) this.txtRemitterPercent).Width = 0.875f;
    ((ARControl) this.txtGrossBilled).Border.BottomColor = Color.Black;
    ((ARControl) this.txtGrossBilled).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossBilled).Border.LeftColor = Color.Black;
    ((ARControl) this.txtGrossBilled).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGrossBilled).Border.RightColor = Color.Black;
    ((ARControl) this.txtGrossBilled).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossBilled).Border.TopColor = Color.Black;
    ((ARControl) this.txtGrossBilled).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGrossBilled).DataField = "AmtBilled";
    ((ARControl) this.txtGrossBilled).Height = 3f / 16f;
    ((ARControl) this.txtGrossBilled).Left = 2.625f;
    ((ARControl) this.txtGrossBilled).Name = "txtGrossBilled";
    this.txtGrossBilled.OutputFormat = resourceManager.GetString("txtGrossBilled.OutputFormat");
    this.txtGrossBilled.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtGrossBilled.Text = "Gross Billed";
    ((ARControl) this.txtGrossBilled).Top = 0.0f;
    ((ARControl) this.txtGrossBilled).Width = 17f / 16f;
    ((ARControl) this.txtRemitterAmount).Border.BottomColor = Color.Black;
    ((ARControl) this.txtRemitterAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAmount).Border.LeftColor = Color.Black;
    ((ARControl) this.txtRemitterAmount).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRemitterAmount).Border.RightColor = Color.Black;
    ((ARControl) this.txtRemitterAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAmount).Border.TopColor = Color.Black;
    ((ARControl) this.txtRemitterAmount).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRemitterAmount).DataField = "RemitterAmt";
    ((ARControl) this.txtRemitterAmount).Height = 3f / 16f;
    ((ARControl) this.txtRemitterAmount).Left = 73f / 16f;
    ((ARControl) this.txtRemitterAmount).Name = "txtRemitterAmount";
    this.txtRemitterAmount.OutputFormat = resourceManager.GetString("txtRemitterAmount.OutputFormat");
    this.txtRemitterAmount.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtRemitterAmount.Text = "Remitter Amt";
    ((ARControl) this.txtRemitterAmount).Top = 0.0f;
    ((ARControl) this.txtRemitterAmount).Width = 1.125f;
    ((ARControl) this.txtDue).Border.BottomColor = Color.Black;
    ((ARControl) this.txtDue).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDue).Border.LeftColor = Color.Black;
    ((ARControl) this.txtDue).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDue).Border.RightColor = Color.Black;
    ((ARControl) this.txtDue).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDue).Border.TopColor = Color.Black;
    ((ARControl) this.txtDue).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDue).DataField = "NetDue";
    ((ARControl) this.txtDue).Height = 3f / 16f;
    ((ARControl) this.txtDue).Left = 91f / 16f;
    ((ARControl) this.txtDue).Name = "txtDue";
    this.txtDue.OutputFormat = resourceManager.GetString("txtDue.OutputFormat");
    this.txtDue.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtDue.Text = "Net Due";
    ((ARControl) this.txtDue).Top = 0.0f;
    ((ARControl) this.txtDue).Width = 21f / 16f;
    this.reportHeader1.Height = 0.0f;
    ((Section) this.reportHeader1).Name = "reportHeader1";
    this.reportFooter1.Height = 0.0f;
    ((Section) this.reportFooter1).Name = "reportFooter1";
    ((Section) this.ghNetSum).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.lblDescription,
      (ARControl) this.lblRemitterPrecent,
      (ARControl) this.lblGrossBilled,
      (ARControl) this.lblRemitterAmount,
      (ARControl) this.lblNetDue
    });
    this.ghNetSum.Height = 0.1770833f;
    ((Section) this.ghNetSum).Name = "ghNetSum";
    ((ARControl) this.lblDescription).Border.BottomColor = Color.Black;
    ((ARControl) this.lblDescription).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblDescription).Border.LeftColor = Color.Black;
    ((ARControl) this.lblDescription).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDescription).Border.RightColor = Color.Black;
    ((ARControl) this.lblDescription).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDescription).Border.TopColor = Color.Black;
    ((ARControl) this.lblDescription).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDescription).Height = 3f / 16f;
    this.lblDescription.HyperLink = (string) null;
    ((ARControl) this.lblDescription).Left = 0.0f;
    ((ARControl) this.lblDescription).Name = "lblDescription";
    this.lblDescription.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.lblDescription.Text = "Description";
    ((ARControl) this.lblDescription).Top = 0.0f;
    ((ARControl) this.lblDescription).Width = 2.625f;
    ((ARControl) this.lblRemitterPrecent).Border.BottomColor = Color.Black;
    ((ARControl) this.lblRemitterPrecent).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRemitterPrecent).Border.LeftColor = Color.Black;
    ((ARControl) this.lblRemitterPrecent).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemitterPrecent).Border.RightColor = Color.Black;
    ((ARControl) this.lblRemitterPrecent).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemitterPrecent).Border.TopColor = Color.Black;
    ((ARControl) this.lblRemitterPrecent).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemitterPrecent).Height = 3f / 16f;
    this.lblRemitterPrecent.HyperLink = (string) null;
    ((ARControl) this.lblRemitterPrecent).Left = 59f / 16f;
    ((ARControl) this.lblRemitterPrecent).Name = "lblRemitterPrecent";
    this.lblRemitterPrecent.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.lblRemitterPrecent.Text = "Remitter %";
    ((ARControl) this.lblRemitterPrecent).Top = 0.0f;
    ((ARControl) this.lblRemitterPrecent).Width = 0.875f;
    ((ARControl) this.lblGrossBilled).Border.BottomColor = Color.Black;
    ((ARControl) this.lblGrossBilled).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblGrossBilled).Border.LeftColor = Color.Black;
    ((ARControl) this.lblGrossBilled).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGrossBilled).Border.RightColor = Color.Black;
    ((ARControl) this.lblGrossBilled).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGrossBilled).Border.TopColor = Color.Black;
    ((ARControl) this.lblGrossBilled).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGrossBilled).Height = 3f / 16f;
    this.lblGrossBilled.HyperLink = (string) null;
    ((ARControl) this.lblGrossBilled).Left = 2.625f;
    ((ARControl) this.lblGrossBilled).Name = "lblGrossBilled";
    this.lblGrossBilled.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.lblGrossBilled.Text = "Gross Billed";
    ((ARControl) this.lblGrossBilled).Top = 0.0f;
    ((ARControl) this.lblGrossBilled).Width = 17f / 16f;
    ((ARControl) this.lblRemitterAmount).Border.BottomColor = Color.Black;
    ((ARControl) this.lblRemitterAmount).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRemitterAmount).Border.LeftColor = Color.Black;
    ((ARControl) this.lblRemitterAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemitterAmount).Border.RightColor = Color.Black;
    ((ARControl) this.lblRemitterAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemitterAmount).Border.TopColor = Color.Black;
    ((ARControl) this.lblRemitterAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemitterAmount).Height = 3f / 16f;
    this.lblRemitterAmount.HyperLink = (string) null;
    ((ARControl) this.lblRemitterAmount).Left = 73f / 16f;
    ((ARControl) this.lblRemitterAmount).Name = "lblRemitterAmount";
    this.lblRemitterAmount.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.lblRemitterAmount.Text = "Remitter Amt.";
    ((ARControl) this.lblRemitterAmount).Top = 0.0f;
    ((ARControl) this.lblRemitterAmount).Width = 1.125f;
    ((ARControl) this.lblNetDue).Border.BottomColor = Color.Black;
    ((ARControl) this.lblNetDue).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblNetDue).Border.LeftColor = Color.Black;
    ((ARControl) this.lblNetDue).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNetDue).Border.RightColor = Color.Black;
    ((ARControl) this.lblNetDue).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNetDue).Border.TopColor = Color.Black;
    ((ARControl) this.lblNetDue).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNetDue).Height = 3f / 16f;
    this.lblNetDue.HyperLink = (string) null;
    ((ARControl) this.lblNetDue).Left = 91f / 16f;
    ((ARControl) this.lblNetDue).Name = "lblNetDue";
    this.lblNetDue.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.lblNetDue.Text = "Net Due";
    ((ARControl) this.lblNetDue).Top = 0.0f;
    ((ARControl) this.lblNetDue).Width = 21f / 16f;
    ((Section) this.gfNetSum).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.lblTotals,
      (ARControl) this.txtTotalDue,
      (ARControl) this.txtGrossBilledTotal,
      (ARControl) this.txtRemitterAmountTotal,
      (ARControl) this.Line7
    });
    this.gfNetSum.Height = 7f / 32f;
    ((Section) this.gfNetSum).Name = "gfNetSum";
    ((ARControl) this.lblTotals).Border.BottomColor = Color.Black;
    ((ARControl) this.lblTotals).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotals).Border.LeftColor = Color.Black;
    ((ARControl) this.lblTotals).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotals).Border.RightColor = Color.Black;
    ((ARControl) this.lblTotals).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotals).Border.TopColor = Color.Black;
    ((ARControl) this.lblTotals).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotals).Height = 3f / 16f;
    this.lblTotals.HyperLink = (string) null;
    ((ARControl) this.lblTotals).Left = 0.0f;
    ((ARControl) this.lblTotals).Name = "lblTotals";
    this.lblTotals.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.lblTotals.Text = "Totals:";
    ((ARControl) this.lblTotals).Top = 0.0f;
    ((ARControl) this.lblTotals).Width = 0.75f;
    ((ARControl) this.txtTotalDue).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTotalDue).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalDue).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTotalDue).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalDue).Border.RightColor = Color.Black;
    ((ARControl) this.txtTotalDue).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalDue).Border.TopColor = Color.Black;
    ((ARControl) this.txtTotalDue).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalDue).DataField = "NetDue";
    ((ARControl) this.txtTotalDue).Height = 3f / 16f;
    ((ARControl) this.txtTotalDue).Left = 91f / 16f;
    ((ARControl) this.txtTotalDue).Name = "txtTotalDue";
    this.txtTotalDue.OutputFormat = resourceManager.GetString("txtTotalDue.OutputFormat");
    this.txtTotalDue.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtTotalDue.SummaryGroup = "ghNetSum";
    this.txtTotalDue.SummaryRunning = (SummaryRunning) 1;
    this.txtTotalDue.SummaryType = (SummaryType) 1;
    this.txtTotalDue.Text = "0";
    ((ARControl) this.txtTotalDue).Top = 0.0f;
    ((ARControl) this.txtTotalDue).Width = 21f / 16f;
    ((ARControl) this.txtGrossBilledTotal).Border.BottomColor = Color.Black;
    ((ARControl) this.txtGrossBilledTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossBilledTotal).Border.LeftColor = Color.Black;
    ((ARControl) this.txtGrossBilledTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossBilledTotal).Border.RightColor = Color.Black;
    ((ARControl) this.txtGrossBilledTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossBilledTotal).Border.TopColor = Color.Black;
    ((ARControl) this.txtGrossBilledTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossBilledTotal).DataField = "AmtBilled";
    ((ARControl) this.txtGrossBilledTotal).Height = 3f / 16f;
    ((ARControl) this.txtGrossBilledTotal).Left = 2.625f;
    ((ARControl) this.txtGrossBilledTotal).Name = "txtGrossBilledTotal";
    this.txtGrossBilledTotal.OutputFormat = resourceManager.GetString("txtGrossBilledTotal.OutputFormat");
    this.txtGrossBilledTotal.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtGrossBilledTotal.SummaryGroup = "ghNetSum";
    this.txtGrossBilledTotal.SummaryRunning = (SummaryRunning) 1;
    this.txtGrossBilledTotal.SummaryType = (SummaryType) 1;
    this.txtGrossBilledTotal.Text = "0";
    ((ARControl) this.txtGrossBilledTotal).Top = 0.0f;
    ((ARControl) this.txtGrossBilledTotal).Width = 17f / 16f;
    ((ARControl) this.txtRemitterAmountTotal).Border.BottomColor = Color.Black;
    ((ARControl) this.txtRemitterAmountTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAmountTotal).Border.LeftColor = Color.Black;
    ((ARControl) this.txtRemitterAmountTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAmountTotal).Border.RightColor = Color.Black;
    ((ARControl) this.txtRemitterAmountTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAmountTotal).Border.TopColor = Color.Black;
    ((ARControl) this.txtRemitterAmountTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAmountTotal).DataField = "RemitterAmt";
    ((ARControl) this.txtRemitterAmountTotal).Height = 3f / 16f;
    ((ARControl) this.txtRemitterAmountTotal).Left = 73f / 16f;
    ((ARControl) this.txtRemitterAmountTotal).Name = "txtRemitterAmountTotal";
    this.txtRemitterAmountTotal.OutputFormat = resourceManager.GetString("txtRemitterAmountTotal.OutputFormat");
    this.txtRemitterAmountTotal.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtRemitterAmountTotal.SummaryGroup = "ghNetSum";
    this.txtRemitterAmountTotal.SummaryRunning = (SummaryRunning) 1;
    this.txtRemitterAmountTotal.SummaryType = (SummaryType) 1;
    this.txtRemitterAmountTotal.Text = "0";
    ((ARControl) this.txtRemitterAmountTotal).Top = 0.0f;
    ((ARControl) this.txtRemitterAmountTotal).Width = 1.125f;
    ((ARControl) this.Line7).Border.BottomColor = Color.Black;
    ((ARControl) this.Line7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line7).Border.LeftColor = Color.Black;
    ((ARControl) this.Line7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line7).Border.RightColor = Color.Black;
    ((ARControl) this.Line7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line7).Border.TopColor = Color.Black;
    ((ARControl) this.Line7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line7).Height = 0.0f;
    ((ARControl) this.Line7).Left = 0.006944444f;
    this.Line7.LineWeight = 1f;
    ((ARControl) this.Line7).Name = "Line7";
    ((ARControl) this.Line7).Top = 0.006944444f;
    ((ARControl) this.Line7).Width = 7f;
    this.Line7.X1 = 7.006945f;
    this.Line7.X2 = 0.006944444f;
    this.Line7.Y1 = 0.006944444f;
    this.Line7.Y2 = 0.006944444f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((Section) this.reportHeader1);
    this.Sections.Add((Section) this.ghNetSum);
    this.Sections.Add((Section) this.detail);
    this.Sections.Add((Section) this.gfNetSum);
    this.Sections.Add((Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.txtRemitterPercent).EndInit();
    ((ISupportInitialize) this.txtGrossBilled).EndInit();
    ((ISupportInitialize) this.txtRemitterAmount).EndInit();
    ((ISupportInitialize) this.txtDue).EndInit();
    ((ISupportInitialize) this.lblDescription).EndInit();
    ((ISupportInitialize) this.lblRemitterPrecent).EndInit();
    ((ISupportInitialize) this.lblGrossBilled).EndInit();
    ((ISupportInitialize) this.lblRemitterAmount).EndInit();
    ((ISupportInitialize) this.lblNetDue).EndInit();
    ((ISupportInitialize) this.lblTotals).EndInit();
    ((ISupportInitialize) this.txtTotalDue).EndInit();
    ((ISupportInitialize) this.txtGrossBilledTotal).EndInit();
    ((ISupportInitialize) this.txtRemitterAmountTotal).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
