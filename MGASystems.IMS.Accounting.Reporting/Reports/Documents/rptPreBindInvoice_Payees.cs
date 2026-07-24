// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptPreBindInvoice_Payees
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

public sealed class rptPreBindInvoice_Payees : SectionReport
{
  private rptPreBindInvoice _MyParent;
  private DataTable _MyData;
  private Container components;
  private Detail detail;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private TextBox txtPercentRate;
  private TextBox txtPayeeAmount;
  private TextBox txtCompanyDesc;
  private Label lblTitle;
  private Label lblPayeePercent;
  private Label lblPayeeAmt;
  private GroupHeader groupHeader1;
  private TextBox txtPayee;
  private GroupFooter groupFooter1;

  public rptPreBindInvoice_Payees(DataTable MyData)
  {
    this.InitializeComponent();
    this._MyData = MyData;
    this.ReportStart += new EventHandler(this.rptPreBindInvoice_Payees_ReportStart);
  }

  private void rptPreBindInvoice_Payees_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._MyData;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptPreBindInvoice_Payees));
    this.detail = new Detail();
    this.txtPercentRate = new TextBox();
    this.txtPayeeAmount = new TextBox();
    this.txtCompanyDesc = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.lblTitle = new Label();
    this.lblPayeePercent = new Label();
    this.lblPayeeAmt = new Label();
    this.reportFooter1 = new ReportFooter();
    this.groupHeader1 = new GroupHeader();
    this.txtPayee = new TextBox();
    this.groupFooter1 = new GroupFooter();
    ((ISupportInitialize) this.txtPercentRate).BeginInit();
    ((ISupportInitialize) this.txtPayeeAmount).BeginInit();
    ((ISupportInitialize) this.txtCompanyDesc).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.lblPayeePercent).BeginInit();
    ((ISupportInitialize) this.lblPayeeAmt).BeginInit();
    ((ISupportInitialize) this.txtPayee).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.txtPercentRate,
      (ARControl) this.txtPayeeAmount,
      (ARControl) this.txtCompanyDesc
    });
    ((Section) this.detail).Height = 0.3229167f;
    ((Section) this.detail).Name = "detail";
    ((ARControl) this.txtPercentRate).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPercentRate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPercentRate).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPercentRate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPercentRate).Border.RightColor = Color.Black;
    ((ARControl) this.txtPercentRate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPercentRate).Border.TopColor = Color.Black;
    ((ARControl) this.txtPercentRate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPercentRate).DataField = "PAYEEPERCENTRATE";
    ((ARControl) this.txtPercentRate).Height = 3f / 16f;
    ((ARControl) this.txtPercentRate).Left = 5f;
    ((ARControl) this.txtPercentRate).Name = "txtPercentRate";
    this.txtPercentRate.OutputFormat = resourceManager.GetString("txtPercentRate.OutputFormat");
    this.txtPercentRate.Style = "ddo-char-set: 0; text-align: right; vertical-align: middle; ";
    this.txtPercentRate.Text = "Percent Rate";
    ((ARControl) this.txtPercentRate).Top = 0.125f;
    ((ARControl) this.txtPercentRate).Width = 13f / 16f;
    ((ARControl) this.txtPayeeAmount).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPayeeAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeAmount).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPayeeAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeAmount).Border.RightColor = Color.Black;
    ((ARControl) this.txtPayeeAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeAmount).Border.TopColor = Color.Black;
    ((ARControl) this.txtPayeeAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeAmount).DataField = "PayeeAmt";
    ((ARControl) this.txtPayeeAmount).Height = 3f / 16f;
    ((ARControl) this.txtPayeeAmount).Left = 93f / 16f;
    ((ARControl) this.txtPayeeAmount).Name = "txtPayeeAmount";
    this.txtPayeeAmount.OutputFormat = resourceManager.GetString("txtPayeeAmount.OutputFormat");
    this.txtPayeeAmount.Style = "ddo-char-set: 0; text-align: right; vertical-align: middle; ";
    this.txtPayeeAmount.SummaryRunning = (SummaryRunning) 1;
    this.txtPayeeAmount.Text = "Payee Amt";
    ((ARControl) this.txtPayeeAmount).Top = 0.125f;
    ((ARControl) this.txtPayeeAmount).Width = 19f / 16f;
    ((ARControl) this.txtCompanyDesc).Border.BottomColor = Color.Black;
    ((ARControl) this.txtCompanyDesc).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyDesc).Border.LeftColor = Color.Black;
    ((ARControl) this.txtCompanyDesc).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyDesc).Border.RightColor = Color.Black;
    ((ARControl) this.txtCompanyDesc).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyDesc).Border.TopColor = Color.Black;
    ((ARControl) this.txtCompanyDesc).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyDesc).DataField = "CompanyLinedesc";
    ((ARControl) this.txtCompanyDesc).Height = 3f / 16f;
    ((ARControl) this.txtCompanyDesc).Left = 1f;
    ((ARControl) this.txtCompanyDesc).Name = "txtCompanyDesc";
    this.txtCompanyDesc.Style = "ddo-char-set: 0; vertical-align: middle; ";
    this.txtCompanyDesc.Text = "CompanyDesc";
    ((ARControl) this.txtCompanyDesc).Top = 0.125f;
    ((ARControl) this.txtCompanyDesc).Width = 4f;
    ((Section) this.reportHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.lblPayeePercent,
      (ARControl) this.lblPayeeAmt
    });
    this.reportHeader1.Height = 0.2604167f;
    ((Section) this.reportHeader1).Name = "reportHeader1";
    ((ARControl) this.lblTitle).Border.BottomColor = Color.Black;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.lblTitle).Border.LeftColor = Color.Black;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightColor = Color.Black;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopColor = Color.Black;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Height = 0.25f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "ddo-char-set: 0; font-size: 14.25pt; ";
    this.lblTitle.Text = "Payees";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 7f;
    ((ARControl) this.lblPayeePercent).Border.BottomColor = Color.Black;
    ((ARControl) this.lblPayeePercent).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayeePercent).Border.LeftColor = Color.Black;
    ((ARControl) this.lblPayeePercent).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayeePercent).Border.RightColor = Color.Black;
    ((ARControl) this.lblPayeePercent).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayeePercent).Border.TopColor = Color.Black;
    ((ARControl) this.lblPayeePercent).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayeePercent).Height = 3f / 16f;
    this.lblPayeePercent.HyperLink = (string) null;
    ((ARControl) this.lblPayeePercent).Left = 5f;
    ((ARControl) this.lblPayeePercent).Name = "lblPayeePercent";
    this.lblPayeePercent.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; vertical-align: bottom; ";
    this.lblPayeePercent.Text = "%";
    ((ARControl) this.lblPayeePercent).Top = 1f / 16f;
    ((ARControl) this.lblPayeePercent).Width = 13f / 16f;
    ((ARControl) this.lblPayeeAmt).Border.BottomColor = Color.Black;
    ((ARControl) this.lblPayeeAmt).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayeeAmt).Border.LeftColor = Color.Black;
    ((ARControl) this.lblPayeeAmt).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayeeAmt).Border.RightColor = Color.Black;
    ((ARControl) this.lblPayeeAmt).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayeeAmt).Border.TopColor = Color.Black;
    ((ARControl) this.lblPayeeAmt).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayeeAmt).Height = 3f / 16f;
    this.lblPayeeAmt.HyperLink = (string) null;
    ((ARControl) this.lblPayeeAmt).Left = 93f / 16f;
    ((ARControl) this.lblPayeeAmt).Name = "lblPayeeAmt";
    this.lblPayeeAmt.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; vertical-align: bottom; ";
    this.lblPayeeAmt.Text = "Amt";
    ((ARControl) this.lblPayeeAmt).Top = 1f / 16f;
    ((ARControl) this.lblPayeeAmt).Width = 19f / 16f;
    this.reportFooter1.Height = 0.0f;
    ((Section) this.reportFooter1).Name = "reportFooter1";
    ((Section) this.groupHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtPayee
    });
    this.groupHeader1.DataField = "DisplayName";
    this.groupHeader1.Height = 0.1770833f;
    ((Section) this.groupHeader1).Name = "groupHeader1";
    ((ARControl) this.txtPayee).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPayee).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayee).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPayee).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayee).Border.RightColor = Color.Black;
    ((ARControl) this.txtPayee).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayee).Border.TopColor = Color.Black;
    ((ARControl) this.txtPayee).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayee).DataField = "DisplayName";
    ((ARControl) this.txtPayee).Height = 3f / 16f;
    ((ARControl) this.txtPayee).Left = 0.0f;
    ((ARControl) this.txtPayee).Name = "txtPayee";
    this.txtPayee.Style = "ddo-char-set: 0; vertical-align: middle; ";
    this.txtPayee.Text = "Payee";
    ((ARControl) this.txtPayee).Top = 0.0f;
    ((ARControl) this.txtPayee).Width = 4.25f;
    this.groupFooter1.Height = 0.0f;
    ((Section) this.groupFooter1).Name = "groupFooter1";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((Section) this.reportHeader1);
    this.Sections.Add((Section) this.groupHeader1);
    this.Sections.Add((Section) this.detail);
    this.Sections.Add((Section) this.groupFooter1);
    this.Sections.Add((Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtPercentRate).EndInit();
    ((ISupportInitialize) this.txtPayeeAmount).EndInit();
    ((ISupportInitialize) this.txtCompanyDesc).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.lblPayeePercent).EndInit();
    ((ISupportInitialize) this.lblPayeeAmt).EndInit();
    ((ISupportInitialize) this.txtPayee).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
