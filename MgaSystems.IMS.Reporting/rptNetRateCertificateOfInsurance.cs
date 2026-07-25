// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptNetRateCertificateOfInsurance
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{13B19AE8-C546-4ce5-BE8C-BB7AF5154CAE}", Enums.AutomationDocGroups.PolicyDoc, "NetRate Certificate of Insurance", "Certificate of Insurance for NetRate-related policies")]
public class rptNetRateCertificateOfInsurance : SectionReport, IQuoteDocument
{
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private TextBox txtHeader_NamedInsured;
  private TextBox txtHeader_Producer;
  private Label Label5;
  private Label Label11;
  private Line Line1;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label17;
  private TextBox txtHeader_IssueDate;
  private SubReport sr_Limits;
  private TextBox TextBox3;
  private TextBox TextBox2;
  private TextBox TextBox1;
  private TextBox TextBox;
  private CheckBox CheckBox;
  private Label Label;
  private Line Line2;
  private Label Label12;
  private Label Label13;
  private TextBox txtFooter_Description;
  private Label Label14;
  private TextBox txtFooter_CertificateHolder;
  private TextBox txtFooter_Cancellation;
  private Label Label15;
  private Label Label16;
  private Picture Picture;
  private readonly Guid _QuoteGuid;
  private DataSet _ds;
  private readonly string _Description;
  private readonly string _Cancellation;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptNetRateCertificateOfInsurance()
  {
    this.ReportStart += new EventHandler(this.rptCertificateOfInsurance_ReportStart);
    this._Description = "";
    this._Cancellation = "";
    this.InitializeComponent();
  }

  public rptNetRateCertificateOfInsurance(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptCertificateOfInsurance_ReportStart);
    this._Description = "";
    this._Cancellation = "";
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
  }

  public rptNetRateCertificateOfInsurance(Guid QuoteGuid, string Description, string Cancellation)
  {
    this.ReportStart += new EventHandler(this.rptCertificateOfInsurance_ReportStart);
    this._Description = "";
    this._Cancellation = "";
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
    this._Description = Description;
    this._Cancellation = Cancellation;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptNetRateCertificateOfInsurance));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.txtHeader_NamedInsured = new TextBox();
    this.txtHeader_Producer = new TextBox();
    this.Label5 = new Label();
    this.Label11 = new Label();
    this.Line1 = new Line();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label17 = new Label();
    this.txtHeader_IssueDate = new TextBox();
    this.sr_Limits = new SubReport();
    this.TextBox3 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox = new TextBox();
    this.CheckBox = new CheckBox();
    this.Label = new Label();
    this.Line2 = new Line();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.txtFooter_Description = new TextBox();
    this.Label14 = new Label();
    this.txtFooter_CertificateHolder = new TextBox();
    this.txtFooter_Cancellation = new TextBox();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Picture = new Picture();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.txtHeader_NamedInsured).BeginInit();
    ((ISupportInitialize) this.txtHeader_Producer).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.txtHeader_IssueDate).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.CheckBox).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.txtFooter_Description).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.txtFooter_CertificateHolder).BeginInit();
    ((ISupportInitialize) this.txtFooter_Cancellation).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Picture).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.sr_Limits,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox,
      (ARControl) this.CheckBox,
      (ARControl) this.Label
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[16 /*0x10*/]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.txtHeader_NamedInsured,
      (ARControl) this.txtHeader_Producer,
      (ARControl) this.Label5,
      (ARControl) this.Label11,
      (ARControl) this.Line1,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label17,
      (ARControl) this.txtHeader_IssueDate
    });
    this.ReportHeader.Height = 3.260417f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Line2,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.txtFooter_Description,
      (ARControl) this.Label14,
      (ARControl) this.txtFooter_CertificateHolder,
      (ARControl) this.txtFooter_Cancellation,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Picture
    });
    this.ReportFooter.Height = 2.072917f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 16f, FontStyle.Bold | FontStyle.Underline);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(4.375f, 0.25f);
    this.Label1.Text = "CERTIFICATE OF LIABILITY INSURANCE";
    this.Label2.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj2 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label2).Location = pointF2;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(8f, 5f / 16f);
    this.Label2.Text = "THIS CERTIFICATE IS ISUED AS A MATTER OF INFORMATION ONLY AND CONFERS NO RIGHTS UPON THE CERTIFICATE HOLDER.  THIS CERTIFICATE DOES NOT AMEND, EXTEND OR ALTER COVERAGE AFFORDED BY THE POLICIES BELOW.";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj3 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label3).Location = pointF3;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label3.Text = "NAMED INSURED:";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj4 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label4).Location = pointF4;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1f, 3f / 16f);
    this.Label4.Text = "PRODUCER:";
    ((ARControl) this.txtHeader_NamedInsured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_NamedInsured).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_NamedInsured).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_NamedInsured).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_NamedInsured).DataField = "InsuredNameAndAddress";
    this.txtHeader_NamedInsured.DistinctField = (string) null;
    this.txtHeader_NamedInsured.Font = new Font("Arial", 10f);
    this.txtHeader_NamedInsured.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerNamedInsured = this.txtHeader_NamedInsured;
    object obj5 = componentResourceManager.GetObject("txtHeader_NamedInsured.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) headerNamedInsured).Location = pointF5;
    ((ARControl) this.txtHeader_NamedInsured).Name = "txtHeader_NamedInsured";
    this.txtHeader_NamedInsured.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_NamedInsured).Size = new SizeF(2.875f, 11f / 16f);
    ((ARControl) this.txtHeader_Producer).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Producer).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Producer).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Producer).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Producer).DataField = "ProducerNameAndAddress";
    this.txtHeader_Producer.DistinctField = (string) null;
    this.txtHeader_Producer.Font = new Font("Arial", 10f);
    this.txtHeader_Producer.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderProducer = this.txtHeader_Producer;
    object obj6 = componentResourceManager.GetObject("txtHeader_Producer.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) txtHeaderProducer).Location = pointF6;
    ((ARControl) this.txtHeader_Producer).Name = "txtHeader_Producer";
    this.txtHeader_Producer.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_Producer).Size = new SizeF(2.875f, 11f / 16f);
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8f);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj7 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label5).Location = pointF7;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(7.25f, 11f / 16f);
    this.Label5.Text = componentResourceManager.GetString("Label5.Text");
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj8 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label11).Location = pointF8;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(1f, 0.2f);
    this.Label11.Text = "COVERAGES:";
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 7.875f;
    this.Line1.Y1 = 1.75f;
    this.Line1.Y2 = 1.75f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8f, FontStyle.Bold | FontStyle.Underline);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj9 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label6).Location = pointF9;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(25f / 16f, 5f / 16f);
    this.Label6.Text = "TYPE OF POLICY";
    this.Label7.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 8f, FontStyle.Bold | FontStyle.Underline);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj10 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label7).Location = pointF10;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(1.25f, 5f / 16f);
    this.Label7.Text = "CARRIER/ POLICY NUMBER";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 8f, FontStyle.Bold | FontStyle.Underline);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj11 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label8).Location = pointF11;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(17f / 16f, 5f / 16f);
    this.Label8.Text = "EFFECTIVE DATE";
    this.Label9.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 8f, FontStyle.Bold | FontStyle.Underline);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj12 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label9).Location = pointF12;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(17f / 16f, 5f / 16f);
    this.Label9.Text = "EXPIRATION DATE";
    this.Label10.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8f, FontStyle.Bold | FontStyle.Underline);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj13 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label10).Location = pointF13;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(2.625f, 5f / 16f);
    this.Label10.Text = "LIMITS";
    this.Label17.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    this.Label17.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label17.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label17.HyperLink = (string) null;
    Label label17 = this.Label17;
    object obj14 = componentResourceManager.GetObject("Label17.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label17).Location = pointF14;
    ((ARControl) this.Label17).Name = "Label17";
    ((ARControl) this.Label17).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label17.Text = "Issue Date:";
    ((ARControl) this.txtHeader_IssueDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_IssueDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_IssueDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_IssueDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_IssueDate).DataField = "DateCertIssued";
    this.txtHeader_IssueDate.DistinctField = (string) null;
    this.txtHeader_IssueDate.Font = new Font("Arial", 8f);
    this.txtHeader_IssueDate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderIssueDate = this.txtHeader_IssueDate;
    object obj15 = componentResourceManager.GetObject("txtHeader_IssueDate.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) txtHeaderIssueDate).Location = pointF15;
    ((ARControl) this.txtHeader_IssueDate).Name = "txtHeader_IssueDate";
    this.txtHeader_IssueDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtHeader_IssueDate).Size = new SizeF(19f / 16f, 3f / 16f);
    ((ARControl) this.sr_Limits).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.sr_Limits).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.sr_Limits).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.sr_Limits).Border.TopStyle = (BorderLineStyle) 0;
    this.sr_Limits.CloseBorder = false;
    SubReport srLimits = this.sr_Limits;
    object obj16 = componentResourceManager.GetObject("sr_Limits.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) srLimits).Location = pointF16;
    ((ARControl) this.sr_Limits).Name = "sr_Limits";
    this.sr_Limits.Report = (SectionReport) null;
    this.sr_Limits.ReportName = "";
    ((ARControl) this.sr_Limits).Size = new SizeF(2.625f, 3f / 16f);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "ExpirationDate";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj17 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox3).Location = pointF17;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(17f / 16f, 3f / 16f);
    this.TextBox3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "EffectiveDate";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj18 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox2).Location = pointF18;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(17f / 16f, 3f / 16f);
    this.TextBox2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "PolicyNumber";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj19 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox1).Location = pointF19;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "PolicyType";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj20 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox).Location = pointF20;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(1.375f, 3f / 16f);
    this.TextBox.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.CheckBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox).Border.TopStyle = (BorderLineStyle) 0;
    this.CheckBox.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CheckBox.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox = this.CheckBox;
    object obj21 = componentResourceManager.GetObject("CheckBox.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) checkBox).Location = pointF21;
    ((ARControl) this.CheckBox).Name = "CheckBox";
    ((ARControl) this.CheckBox).Size = new SizeF(3f / 16f, 3f / 16f);
    this.CheckBox.Text = "";
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).DataField = "Coverage";
    this.Label.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj22 = componentResourceManager.GetObject("Label.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) label).Location = pointF22;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(121f / 16f, 3f / 16f);
    this.Label.Text = "";
    this.Label.VerticalAlignment = (VerticalTextAlignment) 1;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    this.Line2.X1 = 0.0f;
    this.Line2.X2 = 7.875f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.0f;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj23 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label12).Location = pointF23;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(7.875f, 3f / 16f);
    this.Label12.Text = "DESCRIPTION";
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 1;
    this.Label13.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj24 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label13).Location = pointF24;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(63f / 16f, 3f / 16f);
    this.Label13.Text = "CERTIFICATE HOLDER";
    ((ARControl) this.txtFooter_Description).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Description).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Description).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Description).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_Description.DistinctField = (string) null;
    this.txtFooter_Description.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_Description.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox footerDescription = this.txtFooter_Description;
    object obj25 = componentResourceManager.GetObject("txtFooter_Description.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) footerDescription).Location = pointF25;
    ((ARControl) this.txtFooter_Description).Name = "txtFooter_Description";
    this.txtFooter_Description.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_Description).Size = new SizeF(7.875f, 0.5f);
    this.txtFooter_Description.Text = " ";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 1;
    this.Label14.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj26 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) label14).Location = pointF26;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(63f / 16f, 3f / 16f);
    this.Label14.Text = "CANCELLATION";
    ((ARControl) this.txtFooter_CertificateHolder).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_CertificateHolder).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_CertificateHolder).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_CertificateHolder).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_CertificateHolder.DistinctField = (string) null;
    this.txtFooter_CertificateHolder.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_CertificateHolder.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox certificateHolder = this.txtFooter_CertificateHolder;
    object obj27 = componentResourceManager.GetObject("txtFooter_CertificateHolder.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) certificateHolder).Location = pointF27;
    ((ARControl) this.txtFooter_CertificateHolder).Name = "txtFooter_CertificateHolder";
    this.txtFooter_CertificateHolder.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_CertificateHolder).Size = new SizeF(63f / 16f, 0.5f);
    this.txtFooter_CertificateHolder.Text = " ";
    ((ARControl) this.txtFooter_Cancellation).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Cancellation).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Cancellation).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Cancellation).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_Cancellation.DistinctField = (string) null;
    this.txtFooter_Cancellation.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_Cancellation.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox footerCancellation = this.txtFooter_Cancellation;
    object obj28 = componentResourceManager.GetObject("txtFooter_Cancellation.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) footerCancellation).Location = pointF28;
    ((ARControl) this.txtFooter_Cancellation).Name = "txtFooter_Cancellation";
    this.txtFooter_Cancellation.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_Cancellation).Size = new SizeF(63f / 16f, 0.5f);
    this.txtFooter_Cancellation.Text = " ";
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj29 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) label15).Location = pointF29;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(1.25f, 3f / 16f);
    this.Label15.Text = "Authorized Signature";
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj30 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) label16).Location = pointF30;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(3.875f, 3f / 16f);
    this.Label16.Text = "";
    ((ARControl) this.Picture).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture).Border.TopStyle = (BorderLineStyle) 0;
    this.Picture.Image = (Image) null;
    this.Picture.ImageData = (Stream) null;
    this.Picture.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    this.Picture.LineWeight = 0.0f;
    Picture picture = this.Picture;
    object obj31 = componentResourceManager.GetObject("Picture.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) picture).Location = pointF31;
    ((ARControl) this.Picture).Name = "Picture";
    ((ARControl) this.Picture).Size = new SizeF(3.875f, 0.5f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.txtHeader_NamedInsured).EndInit();
    ((ISupportInitialize) this.txtHeader_Producer).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.txtHeader_IssueDate).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.CheckBox).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.txtFooter_Description).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.txtFooter_CertificateHolder).EndInit();
    ((ISupportInitialize) this.txtFooter_Cancellation).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Picture).EndInit();
  }

  public bool RequiresQuoteOptionGuids() => false;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
  }

  private void rptCertificateOfInsurance_ReportStart(object sender, EventArgs e)
  {
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, nameof (rptNetRateCertificateOfInsurance), 0, (CommandArgumentType) 0, new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._QuoteGuid
    });
    if (this._ds.Tables[1].Rows.Count > 0)
    {
      this.txtHeader_IssueDate.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["DateIssued"]);
      this.txtHeader_NamedInsured.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["InsuredAddress"]);
      this.txtHeader_Producer.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["ProducerAddress"]);
      this.txtFooter_CertificateHolder.Text = $"{RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["FullAddress"])}";
    }
    this.txtFooter_Description.Text = this._Description;
    this.txtFooter_Cancellation.Text = this._Cancellation;
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    this.sr_Limits.Report = (SectionReport) new rptCertificateOfInsurance_Limits(new DataView(this._ds.Tables[2], $"Type = '{this.Label.Text}'", "", DataViewRowState.CurrentRows));
    if (this._ds.Tables[2].Rows.Count > 5 && this._ds.Tables[2].Rows[6][3].ToString().IndexOf("/") > 0)
    {
      this._ds.Tables[2].Rows[7][3] = (object) (Conversions.ToInteger(this._ds.Tables[2].Rows[6][3].ToString().Split('/')[0]) * 1000);
      this._ds.Tables[2].Rows[8][3] = (object) (Conversions.ToInteger(this._ds.Tables[2].Rows[6][3].ToString().Split('/')[1]) * 1000);
      this._ds.Tables[2].Rows[9][3] = (object) (Conversions.ToInteger(this._ds.Tables[2].Rows[6][3].ToString().Split('/')[2]) * 1000);
      this._ds.Tables[2].Rows[6][3] = (object) 0;
    }
    bool flag = false;
    DataRow[] dataRowArray = this._ds.Tables[2].Select($"Type = '{this.Label.Text}'");
    int num = dataRowArray.Length - 1;
    for (int index = 0; index <= num; ++index)
      flag |= !dataRowArray[index][3].ToString().Equals("0");
    if (flag)
    {
      this.CheckBox.Checked = true;
    }
    else
    {
      this.TextBox.Value = (object) "";
      this.TextBox.Text = "";
      this.TextBox1.Value = (object) "";
      this.TextBox1.Text = "";
      this.TextBox2.Value = (object) "";
      this.TextBox2.Text = "";
      this.TextBox3.Value = (object) "";
      this.TextBox3.Text = "";
      this.CheckBox.Checked = false;
    }
  }
}
