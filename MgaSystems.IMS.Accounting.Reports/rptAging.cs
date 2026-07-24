// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptAging
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptAging : MGAReport, IReport
{
  private int _glCompanyId;
  private DateTime _agingDate;
  private string _reportFor;

  public rptAging()
  {
  }

  public rptAging(int GLCompanyID, DateTime AgingDate, string ReportFor)
  {
    this.InitializeComponent();
    this.DataSource = (object) Database.Instance.QuerySP.PerformTableQuery("spFin_AgingReport", (object) "@asof_date", (object) AgingDate, (object) "@rpt_type", (object) ReportFor, (object) "@glcompanyid", (object) GLCompanyID);
    string Left = ReportFor;
    if (Operators.CompareString(Left, "P", false) != 0)
    {
      if (Operators.CompareString(Left, "R", false) == 0)
        this._reportFor = " Accounts Receivable";
    }
    else
      this._reportFor = " Accounts Payable";
    this._agingDate = AgingDate;
    this._glCompanyId = GLCompanyID;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptAging));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label3 = new Label();
    this.lblPeriod1 = new Label();
    this.lblP2 = new Label();
    this.lblP4 = new Label();
    this.lblP3 = new Label();
    this.Label1 = new Label();
    this.lblReportFor = new Label();
    this.PageFooter = new PageFooter();
    this.groupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.lblPeriod1).BeginInit();
    ((ISupportInitialize) this.lblP2).BeginInit();
    ((ISupportInitialize) this.lblP4).BeginInit();
    ((ISupportInitialize) this.lblP3).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.lblReportFor).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.6979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "entityname";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj1 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox1).Location = pointF1;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(45f / 16f, 0.2f);
    this.TextBox1.Text = (string) null;
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "bucket1";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj2 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox2).Location = pointF2;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(21f / 16f, 0.2f);
    this.TextBox2.Text = " ";
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "bucket2";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj3 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox3).Location = pointF3;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(1.125f, 0.2f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "bucket3";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj4 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox4).Location = pointF4;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(21f / 16f, 0.2f);
    this.TextBox4.Text = " ";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "bucket4";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj5 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox5).Location = pointF5;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(21f / 16f, 0.2f);
    this.TextBox5.Text = " ";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label3,
      (ARControl) this.lblPeriod1,
      (ARControl) this.lblP2,
      (ARControl) this.lblP4,
      (ARControl) this.lblP3,
      (ARControl) this.Label1,
      (ARControl) this.lblReportFor
    });
    this.PageHeader.Height = 35f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj6 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label3).Location = pointF6;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(23f / 16f, 0.2f);
    this.Label3.Text = "Entity Name";
    this.lblPeriod1.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblPeriod1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPeriod1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPeriod1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPeriod1).Border.TopStyle = (BorderLineStyle) 0;
    this.lblPeriod1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblPeriod1.HyperLink = (string) null;
    Label lblPeriod1 = this.lblPeriod1;
    object obj7 = componentResourceManager.GetObject("lblPeriod1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) lblPeriod1).Location = pointF7;
    ((ARControl) this.lblPeriod1).Name = "lblPeriod1";
    ((ARControl) this.lblPeriod1).Size = new SizeF(21f / 16f, 0.2f);
    this.lblPeriod1.Text = "Period 1";
    this.lblP2.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblP2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP2).Border.TopStyle = (BorderLineStyle) 0;
    this.lblP2.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblP2.HyperLink = (string) null;
    Label lblP2 = this.lblP2;
    object obj8 = componentResourceManager.GetObject("lblP2.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) lblP2).Location = pointF8;
    ((ARControl) this.lblP2).Name = "lblP2";
    ((ARControl) this.lblP2).Size = new SizeF(1.125f, 0.2f);
    this.lblP2.Text = "Period 2";
    this.lblP4.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblP4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP4).Border.TopStyle = (BorderLineStyle) 0;
    this.lblP4.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblP4.HyperLink = (string) null;
    Label lblP4 = this.lblP4;
    object obj9 = componentResourceManager.GetObject("lblP4.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) lblP4).Location = pointF9;
    ((ARControl) this.lblP4).Name = "lblP4";
    ((ARControl) this.lblP4).Size = new SizeF(21f / 16f, 0.2f);
    this.lblP4.Text = "Period 4";
    this.lblP3.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblP3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP3).Border.TopStyle = (BorderLineStyle) 0;
    this.lblP3.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblP3.HyperLink = (string) null;
    Label lblP3 = this.lblP3;
    object obj10 = componentResourceManager.GetObject("lblP3.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) lblP3).Location = pointF10;
    ((ARControl) this.lblP3).Name = "lblP3";
    ((ARControl) this.lblP3).Size = new SizeF(21f / 16f, 0.2f);
    this.lblP3.Text = "Period 3";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj11 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label1).Location = pointF11;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(83f / 16f, 0.25f);
    this.Label1.Text = "IMS Accounting - Aging Report";
    this.lblReportFor.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblReportFor).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReportFor).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReportFor).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReportFor).Border.TopStyle = (BorderLineStyle) 0;
    this.lblReportFor.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblReportFor.HyperLink = (string) null;
    Label lblReportFor = this.lblReportFor;
    object obj12 = componentResourceManager.GetObject("lblReportFor.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) lblReportFor).Location = pointF12;
    ((ARControl) this.lblReportFor).Name = "lblReportFor";
    ((ARControl) this.lblReportFor).Size = new SizeF(31f / 16f, 0.2f);
    this.lblReportFor.Text = "Label4";
    this.PageFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.groupHeader1.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Name = "groupHeader1";
    this.GroupFooter1.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.354167f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.lblPeriod1).EndInit();
    ((ISupportInitialize) this.lblP2).EndInit();
    ((ISupportInitialize) this.lblP4).EndInit();
    ((ISupportInitialize) this.lblP3).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.lblReportFor).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new OfficeLocations("Office", false, true),
        (BaseReportControl) new DatePicker("Aging Period", DateAndTime.Now.Date, false),
        (BaseReportControl) new GenericComboBox("Aging For", 125, 125, typeof (string), new object[4]
        {
          (object) "Accounts Receivable",
          (object) "R",
          (object) "Account Payable",
          (object) "P"
        })
      };
    }
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("groupHeader1")]
  private virtual GroupHeader groupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPeriod1")]
  private virtual Label lblPeriod1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblP2")]
  private virtual Label lblP2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblP4")]
  private virtual Label lblP4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblP3")]
  private virtual Label lblP3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblReportFor")]
  private virtual Label lblReportFor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
