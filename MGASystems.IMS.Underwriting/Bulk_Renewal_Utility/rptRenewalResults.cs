// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_Renewal_Utility.rptRenewalResults
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;

public class rptRenewalResults : SectionReport
{
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Label label1;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private Label label2;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label7;
  private Line line1;

  public rptRenewalResults(DataTable resultsData)
  {
    this.InitializeComponent();
    resultsData.DefaultView.RowFilter = "Selected = 1";
    this.DataSource = (object) resultsData.DefaultView;
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptRenewalResults));
    this.pageHeader = new PageHeader();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.detail = new Detail();
    this.label1 = new Label();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.line1 = new Line();
    this.pageFooter = new PageFooter();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.label2,
      (ARControl) this.label3,
      (ARControl) this.label4,
      (ARControl) this.label5,
      (ARControl) this.label6,
      (ARControl) this.label7
    });
    this.pageHeader.Height = 0.6354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    ((ARControl) this.label2).Border.BottomColor = Color.Black;
    ((ARControl) this.label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.LeftColor = Color.Black;
    ((ARControl) this.label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.RightColor = Color.Black;
    ((ARControl) this.label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.TopColor = Color.Black;
    ((ARControl) this.label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Height = 0.1979167f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.0f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Tahoma; ";
    this.label2.Text = "Control Number";
    ((ARControl) this.label2).Top = 7f / 16f;
    ((ARControl) this.label2).Width = 1f;
    ((ARControl) this.label3).Border.BottomColor = Color.Black;
    ((ARControl) this.label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.LeftColor = Color.Black;
    ((ARControl) this.label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.RightColor = Color.Black;
    ((ARControl) this.label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.TopColor = Color.Black;
    ((ARControl) this.label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Height = 3f / 16f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 19f / 16f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Tahoma; ";
    this.label3.Text = "Policy Number";
    ((ARControl) this.label3).Top = 7f / 16f;
    ((ARControl) this.label3).Width = 1.25f;
    ((ARControl) this.label4).Border.BottomColor = Color.Black;
    ((ARControl) this.label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.LeftColor = Color.Black;
    ((ARControl) this.label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.RightColor = Color.Black;
    ((ARControl) this.label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.TopColor = Color.Black;
    ((ARControl) this.label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Height = 0.1979167f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 41f / 16f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Tahoma; ";
    this.label4.Text = "Insured";
    ((ARControl) this.label4).Top = 7f / 16f;
    ((ARControl) this.label4).Width = 1f;
    ((ARControl) this.label5).Border.BottomColor = Color.Black;
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.LeftColor = Color.Black;
    ((ARControl) this.label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.RightColor = Color.Black;
    ((ARControl) this.label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.TopColor = Color.Black;
    ((ARControl) this.label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 4.75f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Tahoma; ";
    this.label5.Text = "Renewal Control Number";
    ((ARControl) this.label5).Top = 7f / 16f;
    ((ARControl) this.label5).Width = 1.5f;
    ((ARControl) this.label6).Border.BottomColor = Color.Black;
    ((ARControl) this.label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.LeftColor = Color.Black;
    ((ARControl) this.label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.RightColor = Color.Black;
    ((ARControl) this.label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.TopColor = Color.Black;
    ((ARControl) this.label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 105f / 16f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Tahoma; ";
    this.label6.Text = "Renewal Status";
    ((ARControl) this.label6).Top = 7f / 16f;
    ((ARControl) this.label6).Width = 1.25f;
    ((ARControl) this.label7).Border.BottomColor = Color.Black;
    ((ARControl) this.label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.LeftColor = Color.Black;
    ((ARControl) this.label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.RightColor = Color.Black;
    ((ARControl) this.label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.TopColor = Color.Black;
    ((ARControl) this.label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Height = 0.375f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 0.0f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-size: 14pt; ";
    this.label7.Text = "Bulk Renewal Status Report";
    ((ARControl) this.label7).Top = 0.0f;
    ((ARControl) this.label7).Width = 3.5f;
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.label1,
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.line1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.label1).Border.BottomColor = Color.Black;
    ((ARControl) this.label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.LeftColor = Color.Black;
    ((ARControl) this.label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.RightColor = Color.Black;
    ((ARControl) this.label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.TopColor = Color.Black;
    ((ARControl) this.label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).DataField = "ControlNo";
    ((ARControl) this.label1).Height = 0.1979167f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; ";
    this.label1.Text = "label1";
    ((ARControl) this.label1).Top = 0.0f;
    ((ARControl) this.label1).Width = 1f;
    ((ARControl) this.textBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.RightColor = Color.Black;
    ((ARControl) this.textBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.TopColor = Color.Black;
    ((ARControl) this.textBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).DataField = "PolicyNumber";
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 19f / 16f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; ";
    this.textBox1.Text = "textBox1";
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 19f / 16f;
    ((ARControl) this.textBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.RightColor = Color.Black;
    ((ARControl) this.textBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.TopColor = Color.Black;
    ((ARControl) this.textBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).DataField = "Insured";
    ((ARControl) this.textBox2).Height = 3f / 16f;
    ((ARControl) this.textBox2).Left = 41f / 16f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; ";
    this.textBox2.Text = "textBox2";
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 35f / 16f;
    ((ARControl) this.textBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.RightColor = Color.Black;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.TopColor = Color.Black;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).DataField = "RenewalControlNo";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 4.75f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; ";
    this.textBox3.Text = "textBox3";
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 1.5f;
    ((ARControl) this.textBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.RightColor = Color.Black;
    ((ARControl) this.textBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.TopColor = Color.Black;
    ((ARControl) this.textBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).DataField = "=Status == System.DBNull.Value ? \"Queued for Renewal\" : Status";
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 105f / 16f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; ";
    this.textBox4.Text = "textBox4";
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 39f / 16f;
    ((ARControl) this.line1).Border.BottomColor = Color.Black;
    ((ARControl) this.line1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.line1).Border.LeftColor = Color.Black;
    ((ARControl) this.line1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.line1).Border.RightColor = Color.Black;
    ((ARControl) this.line1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.line1).Border.TopColor = Color.Black;
    ((ARControl) this.line1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.line1).Height = 0.0f;
    ((ARControl) this.line1).Left = 0.0f;
    this.line1.LineWeight = 1f;
    ((ARControl) this.line1).Name = "line1";
    ((ARControl) this.line1).Top = 0.25f;
    ((ARControl) this.line1).Width = 8.375f;
    this.line1.X1 = 8.375f;
    this.line1.X2 = 0.0f;
    this.line1.Y1 = 0.25f;
    this.line1.Y2 = 0.25f;
    this.pageFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    this.MasterReport = false;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 9.177079f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
