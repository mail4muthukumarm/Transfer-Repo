// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_Renewal_Utility.rptRenewalSelections
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;

public class rptRenewalSelections : SectionReport
{
  private DataTable source;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label7;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox9;
  private Label label8;
  private Label label9;
  private Label label11;
  private Line line1;
  private Label label10;
  private Label label12;
  private TextBox textBox10;
  private TextBox textBox11;
  private Label label13;
  private Label label14;
  private Label label15;
  private Label label16;
  private TextBox textBox12;
  private TextBox textBox13;
  private TextBox textBox14;
  private TextBox textBox15;
  private Label label17;
  private Label label18;
  private TextBox textBox16;
  private TextBox textBox17;

  public rptRenewalSelections(DataTable selectionData)
  {
    this.InitializeComponent();
    this.DataSource = (object) selectionData.DefaultView;
  }

  private void detail_Format(object sender, EventArgs e)
  {
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptRenewalSelections));
    this.pageHeader = new PageHeader();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label11 = new Label();
    this.detail = new Detail();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.line1 = new Line();
    this.pageFooter = new PageFooter();
    this.label10 = new Label();
    this.textBox10 = new TextBox();
    this.label12 = new Label();
    this.textBox11 = new TextBox();
    this.label13 = new Label();
    this.label14 = new Label();
    this.label15 = new Label();
    this.label16 = new Label();
    this.textBox12 = new TextBox();
    this.textBox13 = new TextBox();
    this.textBox14 = new TextBox();
    this.textBox15 = new TextBox();
    this.label17 = new Label();
    this.label18 = new Label();
    this.textBox16 = new TextBox();
    this.textBox17 = new TextBox();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.label14).BeginInit();
    ((ISupportInitialize) this.label15).BeginInit();
    ((ISupportInitialize) this.label16).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.label17).BeginInit();
    ((ISupportInitialize) this.label18).BeginInit();
    ((ISupportInitialize) this.textBox16).BeginInit();
    ((ISupportInitialize) this.textBox17).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Controls.AddRange(new ARControl[18]
    {
      (ARControl) this.label1,
      (ARControl) this.label2,
      (ARControl) this.label3,
      (ARControl) this.label4,
      (ARControl) this.label5,
      (ARControl) this.label6,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.label11,
      (ARControl) this.label10,
      (ARControl) this.label12,
      (ARControl) this.label13,
      (ARControl) this.label14,
      (ARControl) this.label15,
      (ARControl) this.label16,
      (ARControl) this.label17,
      (ARControl) this.label18
    });
    this.pageHeader.Height = 0.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.062f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label1.Text = "Control No";
    ((ARControl) this.label1).Top = 0.677f;
    ((ARControl) this.label1).Width = 0.6875001f;
    ((ARControl) this.label2).Height = 3f / 16f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.7495f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label2.Text = "Expiration Date";
    ((ARControl) this.label2).Top = 0.6765001f;
    ((ARControl) this.label2).Width = 0.875f;
    ((ARControl) this.label3).Height = 3f / 16f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 1.6245f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label3.Text = "Insured";
    ((ARControl) this.label3).Top = 0.6765001f;
    ((ARControl) this.label3).Width = 1.25f;
    ((ARControl) this.label4).Height = 0.1979167f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 2.8745f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label4.Text = "Company";
    ((ARControl) this.label4).Top = 0.6765001f;
    ((ARControl) this.label4).Width = 1f;
    ((ARControl) this.label5).Height = 0.1979167f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 5.2915f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label5.Text = "Broker";
    ((ARControl) this.label5).Top = 0.677f;
    ((ARControl) this.label5).Width = 1f;
    ((ARControl) this.label6).Height = 0.1979167f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 6.2915f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label6.Text = "Policy Number";
    ((ARControl) this.label6).Top = 0.677f;
    ((ARControl) this.label6).Width = 1f;
    ((ARControl) this.label7).Height = 0.1979167f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 7.2915f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label7.Text = "Premium";
    ((ARControl) this.label7).Top = 0.677f;
    ((ARControl) this.label7).Width = 1f;
    ((ARControl) this.label8).Height = 0.1979167f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 8.291501f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label8.Text = "Lines";
    ((ARControl) this.label8).Top = 0.677f;
    ((ARControl) this.label8).Width = 1f;
    ((ARControl) this.label9).Height = 3f / 16f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 9.291501f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label9.Text = "State";
    ((ARControl) this.label9).Top = 0.677f;
    ((ARControl) this.label9).Width = 9f / 16f;
    ((ARControl) this.label11).Height = 0.375f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 0.0f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "font-size: 14pt";
    this.label11.Text = "Bulk Renewal Selection Report";
    ((ARControl) this.label11).Top = 0.0f;
    ((ARControl) this.label11).Width = 3.5f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[18]
    {
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9,
      (ARControl) this.line1,
      (ARControl) this.textBox10,
      (ARControl) this.textBox11,
      (ARControl) this.textBox12,
      (ARControl) this.textBox13,
      (ARControl) this.textBox14,
      (ARControl) this.textBox15,
      (ARControl) this.textBox16,
      (ARControl) this.textBox17
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Format += new EventHandler(this.detail_Format);
    ((ARControl) this.textBox1).DataField = "ControlNo";
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 1f / 16f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox1.Text = "ControlNo";
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 0.6875001f;
    ((ARControl) this.textBox2).DataField = "ExpirationDate";
    ((ARControl) this.textBox2).Height = 0.1979167f;
    ((ARControl) this.textBox2).Left = 0.75f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.OutputFormat = resourceManager.GetString("textBox2.OutputFormat");
    this.textBox2.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox2.Text = "ExpirationDate";
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 0.8750001f;
    ((ARControl) this.textBox3).DataField = "Insured";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 1.687f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox3.Text = "textBox3";
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 19f / 16f;
    ((ARControl) this.textBox4).DataField = "Company";
    ((ARControl) this.textBox4).Height = 0.1979167f;
    ((ARControl) this.textBox4).Left = 2.875f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox4.Text = "textBox3";
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 1f;
    ((ARControl) this.textBox5).DataField = "Broker";
    ((ARControl) this.textBox5).Height = 0.1979167f;
    ((ARControl) this.textBox5).Left = 5.292f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox5.Text = "textBox5";
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1f;
    ((ARControl) this.textBox6).DataField = "PolicyNumber";
    ((ARControl) this.textBox6).Height = 0.1979167f;
    ((ARControl) this.textBox6).Left = 6.292f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox6.Text = "textBox5";
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 1f;
    ((ARControl) this.textBox7).DataField = "Premium";
    ((ARControl) this.textBox7).Height = 0.1979167f;
    ((ARControl) this.textBox7).Left = 7.292f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox7.Text = "textBox7";
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 1f;
    ((ARControl) this.textBox8).DataField = "Lines";
    ((ARControl) this.textBox8).Height = 0.1979167f;
    ((ARControl) this.textBox8).Left = 8.292001f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox8.Text = "textBox8";
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 1f;
    ((ARControl) this.textBox9).DataField = "State";
    ((ARControl) this.textBox9).Height = 3f / 16f;
    ((ARControl) this.textBox9).Left = 9.292001f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox9.Text = "textBox9";
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 9f / 16f;
    ((ARControl) this.line1).Height = 0.01000002f;
    ((ARControl) this.line1).Left = 0.0f;
    this.line1.LineWeight = 1f;
    ((ARControl) this.line1).Name = "line1";
    ((ARControl) this.line1).Top = 0.25f;
    ((ARControl) this.line1).Width = 13.671f;
    this.line1.X1 = 0.0f;
    this.line1.X2 = 13.671f;
    this.line1.Y1 = 0.25f;
    this.line1.Y2 = 0.26f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    ((ARControl) this.label10).Height = 0.1979167f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 3.8745f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label10.Text = "Billing";
    ((ARControl) this.label10).Top = 0.6765001f;
    ((ARControl) this.label10).Width = 0.677f;
    ((ARControl) this.textBox10).Height = 0.1979167f;
    ((ARControl) this.textBox10).Left = 3.875f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    ((ARControl) this.textBox10).Top = 0.0f;
    ((ARControl) this.textBox10).Width = 0.677f;
    ((ARControl) this.label12).Height = 0.1979167f;
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Left = 4.5515f;
    ((ARControl) this.label12).Name = "label12";
    this.label12.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label12.Text = "Underwriter";
    ((ARControl) this.label12).Top = 0.6765001f;
    ((ARControl) this.label12).Width = 0.7400002f;
    ((ARControl) this.textBox11).DataField = "Und";
    ((ARControl) this.textBox11).Height = 0.1979167f;
    ((ARControl) this.textBox11).Left = 4.552f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox11.Text = "Underwriter";
    ((ARControl) this.textBox11).Top = 0.0f;
    ((ARControl) this.textBox11).Width = 0.7400002f;
    ((ARControl) this.label13).Height = 3f / 16f;
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Left = 9.854501f;
    ((ARControl) this.label13).Name = "label13";
    this.label13.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label13.Text = "Status";
    ((ARControl) this.label13).Top = 0.6765001f;
    ((ARControl) this.label13).Width = 9f / 16f;
    ((ARControl) this.label14).Height = 0.3015f;
    this.label14.HyperLink = (string) null;
    ((ARControl) this.label14).Left = 10.4175f;
    ((ARControl) this.label14).Name = "label14";
    this.label14.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label14.Text = "Claim Count";
    ((ARControl) this.label14).Top = 0.5625001f;
    ((ARControl) this.label14).Width = 0.4470005f;
    ((ARControl) this.label15).Height = 3f / 16f;
    this.label15.HyperLink = (string) null;
    ((ARControl) this.label15).Left = 10.865f;
    ((ARControl) this.label15).Name = "label15";
    this.label15.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label15.Text = "Total Paid";
    ((ARControl) this.label15).Top = 0.677f;
    ((ARControl) this.label15).Width = 0.7270002f;
    ((ARControl) this.label16).Height = 0.5825f;
    this.label16.HyperLink = (string) null;
    ((ARControl) this.label16).Left = 11.592f;
    ((ARControl) this.label16).Name = "label16";
    this.label16.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label16.Text = "Claims Exist on Last 36 Months";
    ((ARControl) this.label16).Top = 0.292f;
    ((ARControl) this.label16).Width = 0.625f;
    ((ARControl) this.textBox12).DataField = "Status";
    ((ARControl) this.textBox12).Height = 3f / 16f;
    ((ARControl) this.textBox12).Left = 9.855f;
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox12.Text = "textBox9";
    ((ARControl) this.textBox12).Top = 0.0f;
    ((ARControl) this.textBox12).Width = 9f / 16f;
    ((ARControl) this.textBox13).DataField = "ClaimCount";
    ((ARControl) this.textBox13).Height = 3f / 16f;
    ((ARControl) this.textBox13).Left = 10.416f;
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox13.Text = "textBox9";
    ((ARControl) this.textBox13).Top = 0.0f;
    ((ARControl) this.textBox13).Width = 0.4490004f;
    ((ARControl) this.textBox14).DataField = "TotalPaid";
    ((ARControl) this.textBox14).Height = 3f / 16f;
    ((ARControl) this.textBox14).Left = 10.865f;
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = resourceManager.GetString("textBox14.OutputFormat");
    this.textBox14.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox14.Text = "textBox9";
    ((ARControl) this.textBox14).Top = 0.0f;
    ((ARControl) this.textBox14).Width = 0.7270002f;
    ((ARControl) this.textBox15).DataField = "Claims Exist on Last 36 Months";
    ((ARControl) this.textBox15).Height = 3f / 16f;
    ((ARControl) this.textBox15).Left = 11.592f;
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox15.Text = "textBox9";
    ((ARControl) this.textBox15).Top = 0.0f;
    ((ARControl) this.textBox15).Width = 0.625f;
    ((ARControl) this.label17).Height = 3f / 16f;
    this.label17.HyperLink = (string) null;
    ((ARControl) this.label17).Left = 12.217f;
    ((ARControl) this.label17).Name = "label17";
    this.label17.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label17.Text = "Loss Ratio";
    ((ARControl) this.label17).Top = 0.677f;
    ((ARControl) this.label17).Width = 0.727f;
    ((ARControl) this.label18).Height = 0.3015f;
    this.label18.HyperLink = (string) null;
    ((ARControl) this.label18).Left = 12.944f;
    ((ARControl) this.label18).Name = "label18";
    this.label18.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.label18.Text = "Renewal Control";
    ((ARControl) this.label18).Top = 0.563f;
    ((ARControl) this.label18).Width = 0.7270002f;
    ((ARControl) this.textBox16).DataField = "LossRatio";
    ((ARControl) this.textBox16).Height = 3f / 16f;
    ((ARControl) this.textBox16).Left = 12.217f;
    ((ARControl) this.textBox16).Name = "textBox16";
    this.textBox16.OutputFormat = resourceManager.GetString("textBox16.OutputFormat");
    this.textBox16.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    this.textBox16.Text = "textBox9";
    ((ARControl) this.textBox16).Top = 0.01f;
    ((ARControl) this.textBox16).Width = 0.727f;
    ((ARControl) this.textBox17).Height = 3f / 16f;
    ((ARControl) this.textBox17).Left = 12.944f;
    ((ARControl) this.textBox17).Name = "textBox17";
    this.textBox17.Style = "font-family: Tahoma; font-size: 8.25pt; ddo-char-set: 0";
    ((ARControl) this.textBox17).Top = 0.01f;
    ((ARControl) this.textBox17).Width = 0.6875001f;
    this.MasterReport = false;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 14.05209f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.label14).EndInit();
    ((ISupportInitialize) this.label15).EndInit();
    ((ISupportInitialize) this.label16).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.label17).EndInit();
    ((ISupportInitialize) this.label18).EndInit();
    ((ISupportInitialize) this.textBox16).EndInit();
    ((ISupportInitialize) this.textBox17).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
