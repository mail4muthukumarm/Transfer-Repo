// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptPreBindInvoice_Summary
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

public sealed class rptPreBindInvoice_Summary : SectionReport
{
  private rptPreBindInvoice _MyParent;
  private DataTable _MyData;
  private Container components;
  private Detail detail;
  private Line Line1;
  private TextBox txtRemainingGross;
  private Line Line2;
  private ReportHeader reportHeader1;
  private Label lblGrossBilled;
  private TextBox txtInitialGrossBilled;
  private Label lblTitle;
  private Label Label1;
  private TextBox txtBrokerAmount;
  private ReportFooter reportFooter1;
  private Label lblRemainingGross;
  private TextBox txtRemitterRemainingGross;
  private Line Line3;
  private GroupHeader groupHeader1;
  private GroupFooter groupFooter1;
  private TextBox txtPayee;
  private TextBox txtPayeeTotal;

  public rptPreBindInvoice_Summary() => this.InitializeComponent();

  public rptPreBindInvoice_Summary(rptPreBindInvoice MyParent, DataTable MyData)
  {
    this.InitializeComponent();
    this._MyParent = MyParent;
    this._MyData = MyData;
    this.ReportStart += new EventHandler(this.rptPreBindInvoice_Summary_ReportStart);
  }

  private void rptPreBindInvoice_Summary_ReportStart(object sender, EventArgs e)
  {
    this.txtInitialGrossBilled.Value = (object) this._MyParent.TotalGrossBilled.ToString();
    this.txtBrokerAmount.Value = (object) this._MyParent.TotalRemitterAmount;
    Decimal num = Decimal.Parse(this.txtInitialGrossBilled.Value.ToString());
    foreach (DataRow row in (InternalDataCollectionBase) this._MyData.Rows)
      num -= Decimal.Parse(row["PAYEEAMT"].ToString());
    this.txtRemitterRemainingGross.Value = (object) (num - this._MyParent.TotalRemitterAmount);
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
    ResourceManager resourceManager = new ResourceManager(typeof (rptPreBindInvoice_Summary));
    this.detail = new Detail();
    this.Line1 = new Line();
    this.txtRemainingGross = new TextBox();
    this.Line2 = new Line();
    this.reportHeader1 = new ReportHeader();
    this.lblGrossBilled = new Label();
    this.txtInitialGrossBilled = new TextBox();
    this.lblTitle = new Label();
    this.Label1 = new Label();
    this.txtBrokerAmount = new TextBox();
    this.reportFooter1 = new ReportFooter();
    this.lblRemainingGross = new Label();
    this.txtRemitterRemainingGross = new TextBox();
    this.Line3 = new Line();
    this.groupHeader1 = new GroupHeader();
    this.groupFooter1 = new GroupFooter();
    this.txtPayee = new TextBox();
    this.txtPayeeTotal = new TextBox();
    ((ISupportInitialize) this.txtRemainingGross).BeginInit();
    ((ISupportInitialize) this.lblGrossBilled).BeginInit();
    ((ISupportInitialize) this.txtInitialGrossBilled).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtBrokerAmount).BeginInit();
    ((ISupportInitialize) this.lblRemainingGross).BeginInit();
    ((ISupportInitialize) this.txtRemitterRemainingGross).BeginInit();
    ((ISupportInitialize) this.txtPayee).BeginInit();
    ((ISupportInitialize) this.txtPayeeTotal).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Line1,
      (ARControl) this.txtRemainingGross,
      (ARControl) this.Line2
    });
    ((Section) this.detail).Height = 0.0f;
    ((Section) this.detail).Name = "detail";
    ((ARControl) this.Line1).Border.BottomColor = Color.Black;
    ((ARControl) this.Line1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Border.LeftColor = Color.Black;
    ((ARControl) this.Line1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Border.RightColor = Color.Black;
    ((ARControl) this.Line1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Border.TopColor = Color.Black;
    ((ARControl) this.Line1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 2.375f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 19f / 16f;
    ((ARControl) this.Line1).Width = 25f / 16f;
    this.Line1.X1 = 2.375f;
    this.Line1.X2 = 63f / 16f;
    this.Line1.Y1 = 19f / 16f;
    this.Line1.Y2 = 19f / 16f;
    ((ARControl) this.txtRemainingGross).Border.BottomColor = Color.Black;
    ((ARControl) this.txtRemainingGross).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemainingGross).Border.LeftColor = Color.Black;
    ((ARControl) this.txtRemainingGross).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemainingGross).Border.RightColor = Color.Black;
    ((ARControl) this.txtRemainingGross).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemainingGross).Border.TopColor = Color.Black;
    ((ARControl) this.txtRemainingGross).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemainingGross).DataField = "GrossBilledTotal";
    ((ARControl) this.txtRemainingGross).Height = 3f / 16f;
    ((ARControl) this.txtRemainingGross).Left = 0.0f;
    ((ARControl) this.txtRemainingGross).Name = "txtRemainingGross";
    this.txtRemainingGross.OutputFormat = resourceManager.GetString("txtRemainingGross.OutputFormat");
    this.txtRemainingGross.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtRemainingGross.SummaryType = (SummaryType) 3;
    this.txtRemainingGross.Text = "RemainingGross";
    ((ARControl) this.txtRemainingGross).Top = 1.375f;
    ((ARControl) this.txtRemainingGross).Width = 3.5f;
    ((ARControl) this.Line2).Border.BottomColor = Color.Black;
    ((ARControl) this.Line2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Border.LeftColor = Color.Black;
    ((ARControl) this.Line2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Border.RightColor = Color.Black;
    ((ARControl) this.Line2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Border.TopColor = Color.Black;
    ((ARControl) this.Line2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 17f / 16f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 1.125f;
    ((ARControl) this.Line2).Width = 25f / 16f;
    this.Line2.X1 = 17f / 16f;
    this.Line2.X2 = 2.625f;
    this.Line2.Y1 = 1.125f;
    this.Line2.Y2 = 1.125f;
    ((Section) this.reportHeader1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.lblGrossBilled,
      (ARControl) this.txtInitialGrossBilled,
      (ARControl) this.lblTitle,
      (ARControl) this.Label1,
      (ARControl) this.txtBrokerAmount
    });
    this.reportHeader1.Height = 0.6979167f;
    ((Section) this.reportHeader1).Name = "reportHeader1";
    ((ARControl) this.lblGrossBilled).Border.BottomColor = Color.Black;
    ((ARControl) this.lblGrossBilled).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGrossBilled).Border.LeftColor = Color.Black;
    ((ARControl) this.lblGrossBilled).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGrossBilled).Border.RightColor = Color.Black;
    ((ARControl) this.lblGrossBilled).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGrossBilled).Border.TopColor = Color.Black;
    ((ARControl) this.lblGrossBilled).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGrossBilled).Height = 3f / 16f;
    this.lblGrossBilled.HyperLink = (string) null;
    ((ARControl) this.lblGrossBilled).Left = 1f / 16f;
    ((ARControl) this.lblGrossBilled).Name = "lblGrossBilled";
    this.lblGrossBilled.Style = "ddo-char-set: 0; font-weight: bold; ";
    this.lblGrossBilled.Text = "Initial Gross Billed";
    ((ARControl) this.lblGrossBilled).Top = 5f / 16f;
    ((ARControl) this.lblGrossBilled).Width = 27f / 16f;
    ((ARControl) this.txtInitialGrossBilled).Border.BottomColor = Color.Black;
    ((ARControl) this.txtInitialGrossBilled).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInitialGrossBilled).Border.LeftColor = Color.Black;
    ((ARControl) this.txtInitialGrossBilled).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInitialGrossBilled).Border.RightColor = Color.Black;
    ((ARControl) this.txtInitialGrossBilled).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInitialGrossBilled).Border.TopColor = Color.Black;
    ((ARControl) this.txtInitialGrossBilled).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInitialGrossBilled).Height = 3f / 16f;
    ((ARControl) this.txtInitialGrossBilled).Left = 55f / 16f;
    ((ARControl) this.txtInitialGrossBilled).Name = "txtInitialGrossBilled";
    this.txtInitialGrossBilled.OutputFormat = resourceManager.GetString("txtInitialGrossBilled.OutputFormat");
    this.txtInitialGrossBilled.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; ";
    this.txtInitialGrossBilled.Text = "GrossBilled";
    ((ARControl) this.txtInitialGrossBilled).Top = 5f / 16f;
    ((ARControl) this.txtInitialGrossBilled).Width = 57f / 16f;
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
    this.lblTitle.Text = "Summary";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 7.375f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 1f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; ";
    this.Label1.Text = "Broker Amount";
    ((ARControl) this.Label1).Top = 0.5f;
    ((ARControl) this.Label1).Width = 27f / 16f;
    ((ARControl) this.txtBrokerAmount).Border.BottomColor = Color.Black;
    ((ARControl) this.txtBrokerAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBrokerAmount).Border.LeftColor = Color.Black;
    ((ARControl) this.txtBrokerAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBrokerAmount).Border.RightColor = Color.Black;
    ((ARControl) this.txtBrokerAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBrokerAmount).Border.TopColor = Color.Black;
    ((ARControl) this.txtBrokerAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBrokerAmount).Height = 3f / 16f;
    ((ARControl) this.txtBrokerAmount).Left = 55f / 16f;
    ((ARControl) this.txtBrokerAmount).Name = "txtBrokerAmount";
    this.txtBrokerAmount.OutputFormat = resourceManager.GetString("txtBrokerAmount.OutputFormat");
    this.txtBrokerAmount.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtBrokerAmount.Text = "Broker";
    ((ARControl) this.txtBrokerAmount).Top = 0.5f;
    ((ARControl) this.txtBrokerAmount).Width = 57f / 16f;
    ((Section) this.reportFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblRemainingGross,
      (ARControl) this.txtRemitterRemainingGross,
      (ARControl) this.Line3
    });
    this.reportFooter1.Height = 0.2083333f;
    ((Section) this.reportFooter1).Name = "reportFooter1";
    ((ARControl) this.lblRemainingGross).Border.BottomColor = Color.Black;
    ((ARControl) this.lblRemainingGross).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemainingGross).Border.LeftColor = Color.Black;
    ((ARControl) this.lblRemainingGross).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemainingGross).Border.RightColor = Color.Black;
    ((ARControl) this.lblRemainingGross).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemainingGross).Border.TopColor = Color.Black;
    ((ARControl) this.lblRemainingGross).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRemainingGross).Height = 3f / 16f;
    this.lblRemainingGross.HyperLink = (string) null;
    ((ARControl) this.lblRemainingGross).Left = 0.0f;
    ((ARControl) this.lblRemainingGross).Name = "lblRemainingGross";
    this.lblRemainingGross.Style = "ddo-char-set: 0; font-weight: bold; ";
    this.lblRemainingGross.Text = "Total MGA Amount:";
    ((ARControl) this.lblRemainingGross).Top = 0.0f;
    ((ARControl) this.lblRemainingGross).Width = 53f / 16f;
    ((ARControl) this.txtRemitterRemainingGross).Border.BottomColor = Color.Black;
    ((ARControl) this.txtRemitterRemainingGross).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterRemainingGross).Border.LeftColor = Color.Black;
    ((ARControl) this.txtRemitterRemainingGross).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterRemainingGross).Border.RightColor = Color.Black;
    ((ARControl) this.txtRemitterRemainingGross).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterRemainingGross).Border.TopColor = Color.Black;
    ((ARControl) this.txtRemitterRemainingGross).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterRemainingGross).Height = 3f / 16f;
    ((ARControl) this.txtRemitterRemainingGross).Left = 3.458333f;
    ((ARControl) this.txtRemitterRemainingGross).Name = "txtRemitterRemainingGross";
    this.txtRemitterRemainingGross.OutputFormat = resourceManager.GetString("txtRemitterRemainingGross.OutputFormat");
    this.txtRemitterRemainingGross.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; ";
    this.txtRemitterRemainingGross.Text = "RemainingGross";
    ((ARControl) this.txtRemitterRemainingGross).Top = 0.0f;
    ((ARControl) this.txtRemitterRemainingGross).Width = 3.541667f;
    ((ARControl) this.Line3).Border.BottomColor = Color.Black;
    ((ARControl) this.Line3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Border.LeftColor = Color.Black;
    ((ARControl) this.Line3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Border.RightColor = Color.Black;
    ((ARControl) this.Line3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Border.TopColor = Color.Black;
    ((ARControl) this.Line3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 5.381945f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 0.006944444f;
    ((ARControl) this.Line3).Width = 25f / 16f;
    this.Line3.X1 = 5.381945f;
    this.Line3.X2 = 6.944445f;
    this.Line3.Y1 = 0.006944444f;
    this.Line3.Y2 = 0.006944444f;
    this.groupHeader1.DataField = "DisplayName";
    this.groupHeader1.Height = 0.0f;
    ((Section) this.groupHeader1).Name = "groupHeader1";
    ((Section) this.groupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtPayee,
      (ARControl) this.txtPayeeTotal
    });
    this.groupFooter1.Height = 0.1979167f;
    ((Section) this.groupFooter1).Name = "groupFooter1";
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
    ((ARControl) this.txtPayee).Left = 1f / 16f;
    ((ARControl) this.txtPayee).Name = "txtPayee";
    this.txtPayee.Style = "ddo-char-set: 0; ";
    this.txtPayee.Text = "Payee";
    ((ARControl) this.txtPayee).Top = 0.0f;
    ((ARControl) this.txtPayee).Width = 79f / 16f;
    ((ARControl) this.txtPayeeTotal).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPayeeTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeTotal).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPayeeTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeTotal).Border.RightColor = Color.Black;
    ((ARControl) this.txtPayeeTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeTotal).Border.TopColor = Color.Black;
    ((ARControl) this.txtPayeeTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeTotal).DataField = "PAYEEAMT";
    ((ARControl) this.txtPayeeTotal).Height = 3f / 16f;
    ((ARControl) this.txtPayeeTotal).Left = 5f;
    ((ARControl) this.txtPayeeTotal).Name = "txtPayeeTotal";
    this.txtPayeeTotal.OutputFormat = resourceManager.GetString("txtPayeeTotal.OutputFormat");
    this.txtPayeeTotal.Style = "ddo-char-set: 0; text-align: right; ";
    this.txtPayeeTotal.SummaryGroup = "groupHeader1";
    this.txtPayeeTotal.SummaryRunning = (SummaryRunning) 1;
    this.txtPayeeTotal.SummaryType = (SummaryType) 3;
    this.txtPayeeTotal.Text = "Payee Total";
    ((ARControl) this.txtPayeeTotal).Top = 0.0f;
    ((ARControl) this.txtPayeeTotal).Width = 2f;
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
    ((ISupportInitialize) this.txtRemainingGross).EndInit();
    ((ISupportInitialize) this.lblGrossBilled).EndInit();
    ((ISupportInitialize) this.txtInitialGrossBilled).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtBrokerAmount).EndInit();
    ((ISupportInitialize) this.lblRemainingGross).EndInit();
    ((ISupportInitialize) this.txtRemitterRemainingGross).EndInit();
    ((ISupportInitialize) this.txtPayee).EndInit();
    ((ISupportInitialize) this.txtPayeeTotal).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
