// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptARReport_PayablesRefunds
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptARReport_PayablesRefunds : SectionReport
{
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label lblPayablesRefunds;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox amount1;
  private Label Label5;

  public rptARReport_PayablesRefunds(DataTable dt)
  {
    this.InitializeComponent();
    this.DataSource = (object) dt;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptARReport_PayablesRefunds));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.GroupHeader1 = new GroupHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.lblPayablesRefunds = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.amount1 = new TextBox();
    this.Label5 = new Label();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.lblPayablesRefunds).BeginInit();
    ((ISupportInitialize) this.amount1).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1034722f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Entity";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8f);
    TextBox textBox1 = this.TextBox1;
    object obj1 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox1).Location = pointF1;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(2.875f, 0.125f);
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "checknumber";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8f);
    TextBox textBox2 = this.TextBox2;
    object obj2 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox2).Location = pointF2;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(1.125f, 0.125f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "comments";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8f);
    TextBox textBox3 = this.TextBox3;
    object obj3 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox3).Location = pointF3;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(89f / 16f, 0.125f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "amount";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8f);
    TextBox textBox4 = this.TextBox4;
    object obj4 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox4).Location = pointF4;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox4.Text = " ";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.lblPayablesRefunds
    });
    this.GroupHeader1.Height = 0.2916667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj5 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label1).Location = pointF5;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(2.875f, 0.1255f);
    this.Label1.Text = "Entity";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj6 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label2).Location = pointF6;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.125f, 0.125f);
    this.Label2.Text = "Check #";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj7 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label3).Location = pointF7;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(89f / 16f, 0.125f);
    this.Label3.Text = "Comments";
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj8 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label4).Location = pointF8;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.813f, 0.1255f);
    this.Label4.Text = "Amount";
    ((ARControl) this.lblPayablesRefunds).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayablesRefunds).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayablesRefunds).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayablesRefunds).Border.TopStyle = (BorderLineStyle) 0;
    this.lblPayablesRefunds.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblPayablesRefunds.HyperLink = (string) null;
    Label lblPayablesRefunds = this.lblPayablesRefunds;
    object obj9 = componentResourceManager.GetObject("lblPayablesRefunds.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) lblPayablesRefunds).Location = pointF9;
    ((ARControl) this.lblPayablesRefunds).Name = "lblPayablesRefunds";
    ((ARControl) this.lblPayablesRefunds).Size = new SizeF(1.75f, 0.125f);
    this.lblPayablesRefunds.Text = "Payables Refunds";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.amount1,
      (ARControl) this.Label5
    });
    this.GroupFooter1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.amount1.Alignment = (TextAlignment) 2;
    ((ARControl) this.amount1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount1).DataField = "amount";
    this.amount1.DistinctField = (string) null;
    this.amount1.Font = new Font("Arial", 8f);
    TextBox amount1 = this.amount1;
    object obj10 = componentResourceManager.GetObject("amount1.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) amount1).Location = pointF10;
    ((ARControl) this.amount1).Name = "amount1";
    this.amount1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.amount1).Size = new SizeF(13f / 16f, 0.125f);
    this.amount1.SummaryGroup = "GroupHeader1";
    this.amount1.SummaryRunning = (SummaryRunning) 2;
    this.amount1.SummaryType = (SummaryType) 1;
    this.amount1.Text = " ";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj11 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label5).Location = pointF11;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(89f / 16f, 0.125f);
    this.Label5.Text = "Payables Refunds Total:";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.375f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.lblPayablesRefunds).EndInit();
    ((ISupportInitialize) this.amount1).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
