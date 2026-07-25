// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptWeeklyPremiums
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{79CE3B26-3747-450e-936F-5B4EB016C5B2}", "Weekly Premium", "Displays premium for a specified date range.", "General")]
public class rptWeeklyPremiums : MGAReport, IReport
{
  private Label lblTitle;
  private TextBox txtCompany;
  private Label Label4;
  private Label Label3;
  private Label Label2;
  private Label Label1;
  private Line Line1;
  private Line Line2;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox Debits1;
  private TextBox Credits1;
  private TextBox Total1;
  private TextBox txtGrandTotal_Debit;
  private TextBox txtGrandTotal_Credit;
  private TextBox txtGrandTotal_Total;
  private Label Label5;
  private TextBox txtPriorYear_Debit;
  private TextBox txtPriorYear_Credit;
  private TextBox txtPriorYear_Total;
  private Label Label6;
  private TextBox txtDifference_Debit;
  private TextBox txtDifference_Credit;
  private TextBox txtDifference_Total;
  private Label Label7;
  private DateTime _DateBilledFrom;
  private DateTime _DateBilledTo;
  private Guid _OfficeGuid;
  private DataSet _ds;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual ReportFooter ReportFooter
  {
    get => this._ReportFooter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter_BeforePrint);
      ReportFooter reportFooter1 = this._ReportFooter;
      if (reportFooter1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1).BeforePrint -= eventHandler;
      this._ReportFooter = value;
      ReportFooter reportFooter2 = this._ReportFooter;
      if (reportFooter2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter2).BeforePrint += eventHandler;
    }
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptWeeklyPremiums));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.lblTitle = new Label();
    this.txtCompany = new TextBox();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.Debits1 = new TextBox();
    this.Credits1 = new TextBox();
    this.Total1 = new TextBox();
    this.txtGrandTotal_Debit = new TextBox();
    this.txtGrandTotal_Credit = new TextBox();
    this.txtGrandTotal_Total = new TextBox();
    this.Label5 = new Label();
    this.txtPriorYear_Debit = new TextBox();
    this.txtPriorYear_Credit = new TextBox();
    this.txtPriorYear_Total = new TextBox();
    this.Label6 = new Label();
    this.txtDifference_Debit = new TextBox();
    this.txtDifference_Credit = new TextBox();
    this.txtDifference_Total = new TextBox();
    this.Label7 = new Label();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Debits1).BeginInit();
    ((ISupportInitialize) this.Credits1).BeginInit();
    ((ISupportInitialize) this.Total1).BeginInit();
    ((ISupportInitialize) this.txtGrandTotal_Debit).BeginInit();
    ((ISupportInitialize) this.txtGrandTotal_Credit).BeginInit();
    ((ISupportInitialize) this.txtGrandTotal_Total).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtPriorYear_Debit).BeginInit();
    ((ISupportInitialize) this.txtPriorYear_Credit).BeginInit();
    ((ISupportInitialize) this.txtPriorYear_Total).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.txtDifference_Debit).BeginInit();
    ((ISupportInitialize) this.txtDifference_Credit).BeginInit();
    ((ISupportInitialize) this.txtDifference_Total).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.txtCompany
    });
    this.ReportHeader.Height = 0.5506945f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).BackColor = Color.FromArgb(169, 169, 169);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.txtGrandTotal_Debit,
      (ARControl) this.txtGrandTotal_Credit,
      (ARControl) this.txtGrandTotal_Total,
      (ARControl) this.Label5,
      (ARControl) this.txtPriorYear_Debit,
      (ARControl) this.txtPriorYear_Credit,
      (ARControl) this.txtPriorYear_Total,
      (ARControl) this.Label6,
      (ARControl) this.txtDifference_Debit,
      (ARControl) this.txtDifference_Credit,
      (ARControl) this.txtDifference_Total,
      (ARControl) this.Label7
    });
    this.ReportFooter.Height = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label4,
      (ARControl) this.Label3,
      (ARControl) this.Label2,
      (ARControl) this.Label1,
      (ARControl) this.Line1,
      (ARControl) this.Line2
    });
    this.PageHeader.Height = 0.3222222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.GroupHeader1.DataField = "Week";
    this.GroupHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).BackColor = Color.FromArgb(211, 211, 211);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Debits1,
      (ARControl) this.Credits1,
      (ARControl) this.Total1
    });
    this.GroupFooter1.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.lblTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTitle.Font = new Font("Arial", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblTitle.HyperLink = (string) null;
    Label lblTitle = this.lblTitle;
    object obj1 = componentResourceManager.GetObject("lblTitle.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblTitle).Location = pointF1;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    ((ARControl) this.lblTitle).Size = new SizeF(7.875f, 0.25f);
    this.lblTitle.Text = "Weekly Premiums";
    this.txtCompany.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtCompany).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCompany.DistinctField = (string) null;
    this.txtCompany.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCompany.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCompany = this.txtCompany;
    object obj2 = componentResourceManager.GetObject("txtCompany.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtCompany).Location = pointF2;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.OutputFormat = (string) null;
    ((ARControl) this.txtCompany).Size = new SizeF(7.875f, 3f / 16f);
    this.txtCompany.Text = "[Company]";
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj3 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label4).Location = pointF3;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1.5f, 3f / 16f);
    this.Label4.Text = "Total";
    this.Label3.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj4 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label3).Location = pointF4;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(1.5f, 3f / 16f);
    this.Label3.Text = "Credits";
    this.Label2.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj5 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label2).Location = pointF5;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.5f, 3f / 16f);
    this.Label2.Text = "Debits";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj6 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label1).Location = pointF6;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1.5f, 3f / 16f);
    this.Label1.Text = "Date Billed";
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = (float) sbyte.MaxValue / 16f;
    this.Line1.Y1 = 1f / 16f;
    this.Line1.Y2 = 1f / 16f;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    this.Line2.X1 = 0.0f;
    this.Line2.X2 = (float) sbyte.MaxValue / 16f;
    this.Line2.Y1 = 0.25f;
    this.Line2.Y2 = 0.25f;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "DateBilled";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj7 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox1).Location = pointF7;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(1.5f, 3f / 16f);
    this.TextBox1.Text = " ";
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "Debit";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj8 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox2).Location = pointF8;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(1.5f, 3f / 16f);
    this.TextBox2.Text = " ";
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "Credit";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj9 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox3).Location = pointF9;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(1.5f, 3f / 16f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Total";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj10 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox4).Location = pointF10;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(1.5f, 3f / 16f);
    this.TextBox4.Text = " ";
    this.Debits1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Debits1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Debits1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Debits1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Debits1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Debits1).DataField = "Debit";
    this.Debits1.DistinctField = (string) null;
    this.Debits1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Debits1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox debits1 = this.Debits1;
    object obj11 = componentResourceManager.GetObject("Debits1.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) debits1).Location = pointF11;
    ((ARControl) this.Debits1).Name = "Debits1";
    this.Debits1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.Debits1).Size = new SizeF(1.5f, 3f / 16f);
    this.Debits1.SummaryGroup = "GroupHeader1";
    this.Debits1.SummaryRunning = (SummaryRunning) 1;
    this.Debits1.SummaryType = (SummaryType) 3;
    this.Debits1.Text = " ";
    this.Credits1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Credits1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Credits1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Credits1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Credits1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Credits1).DataField = "Credit";
    this.Credits1.DistinctField = (string) null;
    this.Credits1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Credits1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox credits1 = this.Credits1;
    object obj12 = componentResourceManager.GetObject("Credits1.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) credits1).Location = pointF12;
    ((ARControl) this.Credits1).Name = "Credits1";
    this.Credits1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.Credits1).Size = new SizeF(1.5f, 3f / 16f);
    this.Credits1.SummaryGroup = "GroupHeader1";
    this.Credits1.SummaryRunning = (SummaryRunning) 1;
    this.Credits1.SummaryType = (SummaryType) 3;
    this.Credits1.Text = " ";
    this.Total1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Total1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Total1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Total1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Total1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Total1).DataField = "Total";
    this.Total1.DistinctField = (string) null;
    this.Total1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Total1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox total1 = this.Total1;
    object obj13 = componentResourceManager.GetObject("Total1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) total1).Location = pointF13;
    ((ARControl) this.Total1).Name = "Total1";
    this.Total1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.Total1).Size = new SizeF(1.5f, 3f / 16f);
    this.Total1.SummaryGroup = "GroupHeader1";
    this.Total1.SummaryRunning = (SummaryRunning) 1;
    this.Total1.SummaryType = (SummaryType) 3;
    this.Total1.Text = " ";
    this.txtGrandTotal_Debit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandTotal_Debit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Debit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Debit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Debit).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Debit).DataField = "Debit";
    this.txtGrandTotal_Debit.DistinctField = (string) null;
    this.txtGrandTotal_Debit.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtGrandTotal_Debit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtGrandTotalDebit = this.txtGrandTotal_Debit;
    object obj14 = componentResourceManager.GetObject("txtGrandTotal_Debit.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtGrandTotalDebit).Location = pointF14;
    ((ARControl) this.txtGrandTotal_Debit).Name = "txtGrandTotal_Debit";
    this.txtGrandTotal_Debit.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtGrandTotal_Debit).Size = new SizeF(1.5f, 3f / 16f);
    this.txtGrandTotal_Debit.SummaryRunning = (SummaryRunning) 2;
    this.txtGrandTotal_Debit.SummaryType = (SummaryType) 1;
    this.txtGrandTotal_Debit.Text = " ";
    this.txtGrandTotal_Credit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandTotal_Credit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Credit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Credit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Credit).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Credit).DataField = "Credit";
    this.txtGrandTotal_Credit.DistinctField = (string) null;
    this.txtGrandTotal_Credit.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtGrandTotal_Credit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox grandTotalCredit = this.txtGrandTotal_Credit;
    object obj15 = componentResourceManager.GetObject("txtGrandTotal_Credit.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) grandTotalCredit).Location = pointF15;
    ((ARControl) this.txtGrandTotal_Credit).Name = "txtGrandTotal_Credit";
    this.txtGrandTotal_Credit.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtGrandTotal_Credit).Size = new SizeF(1.5f, 3f / 16f);
    this.txtGrandTotal_Credit.SummaryRunning = (SummaryRunning) 2;
    this.txtGrandTotal_Credit.SummaryType = (SummaryType) 1;
    this.txtGrandTotal_Credit.Text = " ";
    this.txtGrandTotal_Total.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandTotal_Total).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Total).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal_Total).DataField = "Total";
    this.txtGrandTotal_Total.DistinctField = (string) null;
    this.txtGrandTotal_Total.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtGrandTotal_Total.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtGrandTotalTotal = this.txtGrandTotal_Total;
    object obj16 = componentResourceManager.GetObject("txtGrandTotal_Total.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) txtGrandTotalTotal).Location = pointF16;
    ((ARControl) this.txtGrandTotal_Total).Name = "txtGrandTotal_Total";
    this.txtGrandTotal_Total.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtGrandTotal_Total).Size = new SizeF(1.5f, 3f / 16f);
    this.txtGrandTotal_Total.SummaryRunning = (SummaryRunning) 2;
    this.txtGrandTotal_Total.SummaryType = (SummaryType) 1;
    this.txtGrandTotal_Total.Text = " ";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj17 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label5).Location = pointF17;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(41f / 16f, 3f / 16f);
    this.Label5.Text = "Grand Total";
    this.txtPriorYear_Debit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPriorYear_Debit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Debit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Debit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Debit).Border.TopStyle = (BorderLineStyle) 0;
    this.txtPriorYear_Debit.DistinctField = (string) null;
    this.txtPriorYear_Debit.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtPriorYear_Debit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPriorYearDebit = this.txtPriorYear_Debit;
    object obj18 = componentResourceManager.GetObject("txtPriorYear_Debit.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) txtPriorYearDebit).Location = pointF18;
    ((ARControl) this.txtPriorYear_Debit).Name = "txtPriorYear_Debit";
    this.txtPriorYear_Debit.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtPriorYear_Debit).Size = new SizeF(1.5f, 3f / 16f);
    this.txtPriorYear_Debit.Text = " ";
    this.txtPriorYear_Credit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPriorYear_Credit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Credit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Credit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Credit).Border.TopStyle = (BorderLineStyle) 0;
    this.txtPriorYear_Credit.DistinctField = (string) null;
    this.txtPriorYear_Credit.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtPriorYear_Credit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPriorYearCredit = this.txtPriorYear_Credit;
    object obj19 = componentResourceManager.GetObject("txtPriorYear_Credit.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) txtPriorYearCredit).Location = pointF19;
    ((ARControl) this.txtPriorYear_Credit).Name = "txtPriorYear_Credit";
    this.txtPriorYear_Credit.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtPriorYear_Credit).Size = new SizeF(1.5f, 3f / 16f);
    this.txtPriorYear_Credit.Text = " ";
    this.txtPriorYear_Total.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPriorYear_Total).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPriorYear_Total).Border.TopStyle = (BorderLineStyle) 0;
    this.txtPriorYear_Total.DistinctField = (string) null;
    this.txtPriorYear_Total.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtPriorYear_Total.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPriorYearTotal = this.txtPriorYear_Total;
    object obj20 = componentResourceManager.GetObject("txtPriorYear_Total.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) txtPriorYearTotal).Location = pointF20;
    ((ARControl) this.txtPriorYear_Total).Name = "txtPriorYear_Total";
    this.txtPriorYear_Total.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtPriorYear_Total).Size = new SizeF(1.5f, 3f / 16f);
    this.txtPriorYear_Total.Text = " ";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj21 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) label6).Location = pointF21;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(41f / 16f, 3f / 16f);
    this.Label6.Text = "Prior Year Range Total";
    this.txtDifference_Debit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDifference_Debit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Debit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Debit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Debit).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDifference_Debit.DistinctField = (string) null;
    this.txtDifference_Debit.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtDifference_Debit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDifferenceDebit = this.txtDifference_Debit;
    object obj22 = componentResourceManager.GetObject("txtDifference_Debit.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) txtDifferenceDebit).Location = pointF22;
    ((ARControl) this.txtDifference_Debit).Name = "txtDifference_Debit";
    this.txtDifference_Debit.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtDifference_Debit).Size = new SizeF(1.5f, 3f / 16f);
    this.txtDifference_Debit.Text = " ";
    this.txtDifference_Credit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDifference_Credit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Credit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Credit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Credit).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDifference_Credit.DistinctField = (string) null;
    this.txtDifference_Credit.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtDifference_Credit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox differenceCredit = this.txtDifference_Credit;
    object obj23 = componentResourceManager.GetObject("txtDifference_Credit.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) differenceCredit).Location = pointF23;
    ((ARControl) this.txtDifference_Credit).Name = "txtDifference_Credit";
    this.txtDifference_Credit.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtDifference_Credit).Size = new SizeF(1.5f, 3f / 16f);
    this.txtDifference_Credit.Text = " ";
    this.txtDifference_Total.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDifference_Total).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDifference_Total).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDifference_Total.DistinctField = (string) null;
    this.txtDifference_Total.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.txtDifference_Total.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDifferenceTotal = this.txtDifference_Total;
    object obj24 = componentResourceManager.GetObject("txtDifference_Total.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) txtDifferenceTotal).Location = pointF24;
    ((ARControl) this.txtDifference_Total).Name = "txtDifference_Total";
    this.txtDifference_Total.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtDifference_Total).Size = new SizeF(1.5f, 3f / 16f);
    this.txtDifference_Total.Text = " ";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj25 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label7).Location = pointF25;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(41f / 16f, 3f / 16f);
    this.Label7.Text = "Difference Monthly Total";
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Debits1).EndInit();
    ((ISupportInitialize) this.Credits1).EndInit();
    ((ISupportInitialize) this.Total1).EndInit();
    ((ISupportInitialize) this.txtGrandTotal_Debit).EndInit();
    ((ISupportInitialize) this.txtGrandTotal_Credit).EndInit();
    ((ISupportInitialize) this.txtGrandTotal_Total).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtPriorYear_Debit).EndInit();
    ((ISupportInitialize) this.txtPriorYear_Credit).EndInit();
    ((ISupportInitialize) this.txtPriorYear_Total).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.txtDifference_Debit).EndInit();
    ((ISupportInitialize) this.txtDifference_Credit).EndInit();
    ((ISupportInitialize) this.txtDifference_Total).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
  }

  public rptWeeklyPremiums()
  {
    this.ReportStart += new EventHandler(this.rptWeeklyPremiums_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
  }

  public rptWeeklyPremiums(Guid Office, DateTime BilledFrom, DateTime BilledTo)
  {
    this.ReportStart += new EventHandler(this.rptWeeklyPremiums_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
    this._OfficeGuid = Office;
    this._DateBilledFrom = BilledFrom;
    this._DateBilledTo = BilledTo;
  }

  private void rptWeeklyPremiums_ReportStart(object sender, EventArgs e)
  {
    List<object> objectList = new List<object>()
    {
      (object) "@DateBilledFrom",
      (object) this._DateBilledFrom,
      (object) "@DateBilledTo",
      (object) this._DateBilledTo
    };
    if (!this._OfficeGuid.Equals(Guid.Empty))
    {
      objectList.Add((object) "@OfficeGuid");
      objectList.Add((object) this._OfficeGuid);
    }
    if (SystemSettings.GetSetting<bool>("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals((object) string.Empty))
    {
      objectList.Add((object) "@CurrentUserGuid");
      objectList.Add((object) this.CurrentUserGuid);
    }
    this._ds = DefaultDatabase.ExecuteDataSet(nameof (rptWeeklyPremiums), objectList.ToArray());
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.txtCompany.Text = this._ds.Tables[0].Rows[0]["Office"].ToString();
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("DateBilled", typeof (DateTime));
    dataTable2.Columns.Add("Week", typeof (int));
    dataTable2.Columns.Add("Debit", typeof (Decimal));
    dataTable2.Columns.Add("Credit", typeof (Decimal));
    dataTable2.Columns.Add("Total", typeof (Decimal));
    dataTable2.Columns["Total"].Expression = "Credit + Debit";
    int num = 0;
    int days = this._DateBilledTo.Subtract(this._DateBilledFrom).Days;
    for (int index = 0; index <= days; ++index)
    {
      DateTime dateTime = this._DateBilledFrom.AddDays((double) index);
      if (dateTime.DayOfWeek != DayOfWeek.Saturday && dateTime.DayOfWeek != DayOfWeek.Sunday)
      {
        if (dateTime.DayOfWeek == DayOfWeek.Monday)
          ++num;
        dataTable1.Rows.Add((object) dateTime, (object) num, (object) Database.IsNull(RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Compute("SUM(AmtBilled)", $"(AmtBilled < 0) AND (DateBilled='{dateTime.ToString("MM/dd/yyyy")}')")), 0M), (object) Database.IsNull(RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Compute("SUM(AmtBilled)", $"(AmtBilled < 0) AND (DateBilled='{dateTime.ToString("MM/dd/yyyy")}')")), 0M));
      }
    }
    this.DataSource = (object) dataTable1;
  }

  private void ReportFooter_BeforePrint(object sender, EventArgs e)
  {
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.txtPriorYear_Credit.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[2].Rows[0]["PriorYearCredit"]);
    this.txtPriorYear_Debit.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[2].Rows[0]["PriorYearDebit"]);
    this.txtPriorYear_Total.Value = (object) Decimal.Add(Conversions.ToDecimal(this.txtPriorYear_Credit.Value), Conversions.ToDecimal(this.txtPriorYear_Debit.Value));
    this.txtDifference_Credit.Value = (object) Decimal.Subtract(Conversions.ToDecimal(this.txtGrandTotal_Credit.Value), Conversions.ToDecimal(this.txtPriorYear_Credit.Value));
    this.txtDifference_Debit.Value = (object) Decimal.Subtract(Conversions.ToDecimal(this.txtGrandTotal_Debit.Value), Conversions.ToDecimal(this.txtPriorYear_Debit.Value));
    this.txtDifference_Total.Value = (object) Decimal.Subtract(Conversions.ToDecimal(this.txtGrandTotal_Total.Value), Conversions.ToDecimal(this.txtPriorYear_Total.Value));
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new OfficeLocations("Office", true),
        (BaseReportControl) new DateRangePicker("Date Billed", false)
      };
    }
  }
}
