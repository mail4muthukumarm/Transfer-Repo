// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.ClaimsTransactionSubReport
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Claims.Reports;

public class ClaimsTransactionSubReport : SectionReport
{
  private DataView _dv;
  private Container components;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private TextBox textBox10;
  private TextBox textBox11;
  private TextBox textBox12;
  private TextBox textBox13;
  private TextBox textBox15;
  private TextBox textBox18;
  private TextBox textBox20;
  private TextBox textBox21;
  private TextBox textBox22;
  private TextBox textBox24;
  private ReportHeader reportHeader1;
  private TextBox textBox14;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox9;
  private TextBox textBox6;
  private TextBox textBox16;
  private TextBox textBox19;
  private TextBox textBox23;
  private ReportFooter reportFooter1;
  private GroupHeader groupHeader1;
  private GroupFooter groupFooter1;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox17;
  private TextBox textBox25;
  private TextBox textBox28;
  private TextBox textBox3;

  public ClaimsTransactionSubReport() => this.InitializeComponent();

  public ClaimsTransactionSubReport(DataView dv)
  {
    this.InitializeComponent();
    this._dv = dv;
  }

  private void ClaimsTransactionSubReport_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._dv;
  }

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ClaimsTransactionSubReport));
    this.pageHeader = new PageHeader();
    this.detail = new Detail();
    this.textBox10 = new TextBox();
    this.textBox11 = new TextBox();
    this.textBox12 = new TextBox();
    this.textBox13 = new TextBox();
    this.textBox15 = new TextBox();
    this.textBox18 = new TextBox();
    this.textBox20 = new TextBox();
    this.textBox21 = new TextBox();
    this.textBox22 = new TextBox();
    this.textBox24 = new TextBox();
    this.pageFooter = new PageFooter();
    this.reportHeader1 = new ReportHeader();
    this.textBox14 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox16 = new TextBox();
    this.textBox19 = new TextBox();
    this.textBox23 = new TextBox();
    this.reportFooter1 = new ReportFooter();
    this.groupHeader1 = new GroupHeader();
    this.groupFooter1 = new GroupFooter();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox17 = new TextBox();
    this.textBox25 = new TextBox();
    this.textBox28 = new TextBox();
    this.textBox3 = new TextBox();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.textBox18).BeginInit();
    ((ISupportInitialize) this.textBox20).BeginInit();
    ((ISupportInitialize) this.textBox21).BeginInit();
    ((ISupportInitialize) this.textBox22).BeginInit();
    ((ISupportInitialize) this.textBox24).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox16).BeginInit();
    ((ISupportInitialize) this.textBox19).BeginInit();
    ((ISupportInitialize) this.textBox23).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox17).BeginInit();
    ((ISupportInitialize) this.textBox25).BeginInit();
    ((ISupportInitialize) this.textBox28).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    this.pageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.textBox10,
      (ARControl) this.textBox11,
      (ARControl) this.textBox12,
      (ARControl) this.textBox13,
      (ARControl) this.textBox15,
      (ARControl) this.textBox18,
      (ARControl) this.textBox20,
      (ARControl) this.textBox21,
      (ARControl) this.textBox22,
      (ARControl) this.textBox24
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).DataField = "DateEntered";
    this.textBox10.DistinctField = (string) null;
    this.textBox10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox10).Location = (PointF) componentResourceManager.GetObject("textBox10.Location");
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.textBox10).Size = new SizeF(0.75f, 0.125f);
    this.textBox10.Text = (string) null;
    this.textBox10.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).DataField = "Expense";
    this.textBox11.DistinctField = (string) null;
    this.textBox11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox11).Location = (PointF) componentResourceManager.GetObject("textBox11.Location");
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.OutputFormat = (string) null;
    ((ARControl) this.textBox11).Size = new SizeF(25f / 16f, 0.125f);
    this.textBox11.Text = (string) null;
    this.textBox11.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).DataField = "User";
    this.textBox12.DistinctField = (string) null;
    this.textBox12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox12).Location = (PointF) componentResourceManager.GetObject("textBox12.Location");
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = (string) null;
    ((ARControl) this.textBox12).Size = new SizeF(39f / 16f, 0.125f);
    this.textBox12.Text = (string) null;
    this.textBox12.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).DataField = "Hours";
    this.textBox13.DistinctField = (string) null;
    this.textBox13.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox13).Location = (PointF) componentResourceManager.GetObject("textBox13.Location");
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.textBox13).Size = new SizeF(13f / 16f, 0.125f);
    this.textBox13.Text = (string) null;
    this.textBox13.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox15.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).DataField = "EquipmentCharges";
    this.textBox15.DistinctField = (string) null;
    this.textBox15.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox15).Location = (PointF) componentResourceManager.GetObject("textBox15.Location");
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox15).Size = new SizeF(15f / 16f, 0.125f);
    this.textBox15.Text = (string) null;
    this.textBox15.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox18.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox18).DataField = "OtherCharges";
    this.textBox18.DistinctField = (string) null;
    this.textBox18.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox18).Location = (PointF) componentResourceManager.GetObject("textBox18.Location");
    ((ARControl) this.textBox18).Name = "textBox18";
    this.textBox18.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox18).Size = new SizeF(1.125f, 0.125f);
    this.textBox18.Text = (string) null;
    this.textBox18.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox20.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox20).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox20).DataField = "Total";
    this.textBox20.DistinctField = (string) null;
    this.textBox20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox20).Location = (PointF) componentResourceManager.GetObject("textBox20.Location");
    ((ARControl) this.textBox20).Name = "textBox20";
    this.textBox20.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox20).Size = new SizeF(15f / 16f, 0.125f);
    this.textBox20.Text = (string) null;
    this.textBox20.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox21).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox21.DistinctField = (string) null;
    this.textBox21.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox21).Location = (PointF) componentResourceManager.GetObject("textBox21.Location");
    ((ARControl) this.textBox21).Name = "textBox21";
    this.textBox21.OutputFormat = (string) null;
    ((ARControl) this.textBox21).Size = new SizeF(0.75f, 0.125f);
    this.textBox21.Text = "Comments:";
    this.textBox21.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox22).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox22).DataField = "comments";
    this.textBox22.DistinctField = (string) null;
    this.textBox22.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox22).Location = (PointF) componentResourceManager.GetObject("textBox22.Location");
    ((ARControl) this.textBox22).Name = "textBox22";
    this.textBox22.OutputFormat = (string) null;
    ((ARControl) this.textBox22).Size = new SizeF(8.625f, 0.125f);
    this.textBox22.Text = (string) null;
    this.textBox22.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox24.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox24).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox24).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox24).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox24).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox24).DataField = "HourlyCharges";
    this.textBox24.DistinctField = (string) null;
    this.textBox24.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox24).Location = (PointF) componentResourceManager.GetObject("textBox24.Location");
    ((ARControl) this.textBox24).Name = "textBox24";
    this.textBox24.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox24).Size = new SizeF(13f / 16f, 0.125f);
    this.textBox24.Text = (string) null;
    this.textBox24.VerticalAlignment = (VerticalTextAlignment) 1;
    this.pageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.textBox14,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9,
      (ARControl) this.textBox6,
      (ARControl) this.textBox16,
      (ARControl) this.textBox19,
      (ARControl) this.textBox23
    });
    this.reportHeader1.Height = 0.1458333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    this.textBox14.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox14.DistinctField = (string) null;
    this.textBox14.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox14).Location = (PointF) componentResourceManager.GetObject("textBox14.Location");
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = (string) null;
    ((ARControl) this.textBox14).Size = new SizeF(15f / 16f, 0.125f);
    this.textBox14.Text = "Equipments";
    this.textBox14.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox7.DistinctField = (string) null;
    this.textBox7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox7).Location = (PointF) componentResourceManager.GetObject("textBox7.Location");
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = (string) null;
    ((ARControl) this.textBox7).Size = new SizeF(25f / 16f, 0.125f);
    this.textBox7.Text = "Expense";
    this.textBox7.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox8.DistinctField = (string) null;
    this.textBox8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox8).Location = (PointF) componentResourceManager.GetObject("textBox8.Location");
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = (string) null;
    ((ARControl) this.textBox8).Size = new SizeF(39f / 16f, 0.125f);
    this.textBox8.Text = "User";
    this.textBox8.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox9.DistinctField = (string) null;
    this.textBox9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox9).Location = (PointF) componentResourceManager.GetObject("textBox9.Location");
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = (string) null;
    ((ARControl) this.textBox9).Size = new SizeF(13f / 16f, 0.125f);
    this.textBox9.Text = "Hours";
    this.textBox9.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox6.DistinctField = (string) null;
    this.textBox6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox6).Location = (PointF) componentResourceManager.GetObject("textBox6.Location");
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = (string) null;
    ((ARControl) this.textBox6).Size = new SizeF(0.75f, 0.125f);
    this.textBox6.Text = "Date Entered";
    this.textBox6.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox16.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox16.DistinctField = (string) null;
    this.textBox16.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox16).Location = (PointF) componentResourceManager.GetObject("textBox16.Location");
    ((ARControl) this.textBox16).Name = "textBox16";
    this.textBox16.OutputFormat = (string) null;
    ((ARControl) this.textBox16).Size = new SizeF(1.125f, 0.125f);
    this.textBox16.Text = "Other Charges";
    this.textBox16.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox19.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox19).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox19.DistinctField = (string) null;
    this.textBox19.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox19).Location = (PointF) componentResourceManager.GetObject("textBox19.Location");
    ((ARControl) this.textBox19).Name = "textBox19";
    this.textBox19.OutputFormat = (string) null;
    ((ARControl) this.textBox19).Size = new SizeF(15f / 16f, 0.125f);
    this.textBox19.Text = "Amount";
    this.textBox19.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox23.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox23).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox23).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox23.DistinctField = (string) null;
    this.textBox23.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox23).Location = (PointF) componentResourceManager.GetObject("textBox23.Location");
    ((ARControl) this.textBox23).Name = "textBox23";
    this.textBox23.OutputFormat = (string) null;
    ((ARControl) this.textBox23).Size = new SizeF(13f / 16f, 0.125f);
    this.textBox23.Text = "Hourly Charges";
    this.textBox23.VerticalAlignment = (VerticalTextAlignment) 1;
    this.reportFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    this.groupHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Name = "groupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox17,
      (ARControl) this.textBox25,
      (ARControl) this.textBox28,
      (ARControl) this.textBox3
    });
    this.groupFooter1.Height = 0.4270833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Name = "groupFooter1";
    this.textBox1.BackColor = Color.LightGray;
    ((ARControl) this.textBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox1.DistinctField = (string) null;
    this.textBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox1).Location = (PointF) componentResourceManager.GetObject("textBox1.Location");
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = (string) null;
    ((ARControl) this.textBox1).Size = new SizeF(0.75f, 3f / 16f);
    this.textBox1.Text = "Total";
    this.textBox1.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox2.BackColor = Color.LightGray;
    ((ARControl) this.textBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox2.DistinctField = (string) null;
    this.textBox2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox2).Location = (PointF) componentResourceManager.GetObject("textBox2.Location");
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.OutputFormat = (string) null;
    ((ARControl) this.textBox2).Size = new SizeF(25f / 16f, 3f / 16f);
    this.textBox2.Text = (string) null;
    this.textBox2.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox4.BackColor = Color.LightGray;
    ((ARControl) this.textBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).DataField = "Hours";
    this.textBox4.DistinctField = (string) null;
    this.textBox4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox4).Location = (PointF) componentResourceManager.GetObject("textBox4.Location");
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.textBox4).Size = new SizeF(13f / 16f, 3f / 16f);
    this.textBox4.SummaryGroup = "groupHeader1";
    this.textBox4.SummaryRunning = (SummaryRunning) 1;
    this.textBox4.SummaryType = (SummaryType) 3;
    this.textBox4.Text = (string) null;
    this.textBox4.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox5.Alignment = (TextAlignment) 2;
    this.textBox5.BackColor = Color.LightGray;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).DataField = "EquipmentCharges";
    this.textBox5.DistinctField = (string) null;
    this.textBox5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox5).Location = (PointF) componentResourceManager.GetObject("textBox5.Location");
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox5).Size = new SizeF(15f / 16f, 3f / 16f);
    this.textBox5.SummaryGroup = "groupHeader1";
    this.textBox5.SummaryRunning = (SummaryRunning) 1;
    this.textBox5.SummaryType = (SummaryType) 3;
    this.textBox5.Text = (string) null;
    this.textBox5.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox17.Alignment = (TextAlignment) 2;
    this.textBox17.BackColor = Color.LightGray;
    ((ARControl) this.textBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).DataField = "OtherCharges";
    this.textBox17.DistinctField = (string) null;
    this.textBox17.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox17).Location = (PointF) componentResourceManager.GetObject("textBox17.Location");
    ((ARControl) this.textBox17).Name = "textBox17";
    this.textBox17.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox17).Size = new SizeF(1.125f, 3f / 16f);
    this.textBox17.SummaryGroup = "groupHeader1";
    this.textBox17.SummaryRunning = (SummaryRunning) 1;
    this.textBox17.SummaryType = (SummaryType) 3;
    this.textBox17.Text = (string) null;
    this.textBox17.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox25.Alignment = (TextAlignment) 2;
    this.textBox25.BackColor = Color.LightGray;
    ((ARControl) this.textBox25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox25).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox25).DataField = "Total";
    this.textBox25.DistinctField = (string) null;
    this.textBox25.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox25).Location = (PointF) componentResourceManager.GetObject("textBox25.Location");
    ((ARControl) this.textBox25).Name = "textBox25";
    this.textBox25.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox25).Size = new SizeF(15f / 16f, 3f / 16f);
    this.textBox25.SummaryGroup = "groupHeader1";
    this.textBox25.SummaryRunning = (SummaryRunning) 1;
    this.textBox25.SummaryType = (SummaryType) 3;
    this.textBox25.Text = (string) null;
    this.textBox25.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox28.Alignment = (TextAlignment) 2;
    this.textBox28.BackColor = Color.LightGray;
    ((ARControl) this.textBox28).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox28).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox28).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox28).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox28).DataField = "HourlyCharges";
    this.textBox28.DistinctField = (string) null;
    this.textBox28.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox28).Location = (PointF) componentResourceManager.GetObject("textBox28.Location");
    ((ARControl) this.textBox28).Name = "textBox28";
    this.textBox28.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox28).Size = new SizeF(13f / 16f, 3f / 16f);
    this.textBox28.SummaryGroup = "groupHeader1";
    this.textBox28.SummaryRunning = (SummaryRunning) 1;
    this.textBox28.SummaryType = (SummaryType) 3;
    this.textBox28.Text = (string) null;
    this.textBox28.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox3.BackColor = Color.LightGray;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox3.DistinctField = (string) null;
    this.textBox3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox3).Location = (PointF) componentResourceManager.GetObject("textBox3.Location");
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = (string) null;
    ((ARControl) this.textBox3).Size = new SizeF(39f / 16f, 3f / 16f);
    this.textBox3.Text = (string) null;
    this.textBox3.VerticalAlignment = (VerticalTextAlignment) 1;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 9.375f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    this.ReportStart += new EventHandler(this.ClaimsTransactionSubReport_ReportStart);
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.textBox18).EndInit();
    ((ISupportInitialize) this.textBox20).EndInit();
    ((ISupportInitialize) this.textBox21).EndInit();
    ((ISupportInitialize) this.textBox22).EndInit();
    ((ISupportInitialize) this.textBox24).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox16).EndInit();
    ((ISupportInitialize) this.textBox19).EndInit();
    ((ISupportInitialize) this.textBox23).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox17).EndInit();
    ((ISupportInitialize) this.textBox25).EndInit();
    ((ISupportInitialize) this.textBox28).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
  }
}
