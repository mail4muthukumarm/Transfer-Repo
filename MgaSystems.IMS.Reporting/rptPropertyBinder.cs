// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptPropertyBinder
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{179C013E-B974-4416-8E46-078F5B3E39B0}", Enums.AutomationDocGroups.PolicyDoc, "Property Binder", "Binder document for property quotes.")]
public class rptPropertyBinder : SectionReport, IQuoteDocument
{
  private Label Label9;
  private TextBox InsuredName1;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private Label Label1;
  private Label Label2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private Label lblTitle;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private TextBox TextBox27;
  private TextBox TextBox28;
  private TextBox TextBox29;
  private TextBox TextBox30;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private TextBox InsuredAddress;
  private TextBox InspectionContactName1;
  private TextBox InspectionContactPhone;
  private TextBox txtCurrentCarrier;
  private SubReport srSingleLocation;
  private SubReport srPropertyBreakdown;
  private Label Label36;
  private Label Label38;
  private TextBox TextBox48;
  private TextBox Carrier1;
  private Label Label54;
  private TextBox TextBox49;
  private Label Label84;
  private Label lblDollar;
  private TextBox txtAmount;
  private TextBox txtCharge;
  private Label Label85;
  private TextBox Premium_LiabilityPremium1;
  private TextBox TextBox51;
  private Label Label86;
  private TextBox Premium_TerrorismPremium1;
  private TextBox TextBox52;
  private SubReport srPremiumsAndFees;
  private Label Label87;
  private TextBox Premium_TotalPremium1;
  private TextBox TextBox53;
  private Label Label57;
  private TextBox TextBox20;
  private Label Label76;
  private Label Label75;
  private TextBox TextBox22;
  private Label Label78;
  private CheckBox CheckBox6;
  private CheckBox CheckBox7;
  private Label Label82;
  private TextBox TextBox25;
  private Label Label83;
  private TextBox TextBox26;
  private Line Line3;
  private TextBox TextBox47;
  private TextBox TextBox50;
  private CheckBox CheckBox8;
  private Picture picUnderwriterSignature;
  private SubReport srMultipleLocations;
  private readonly Guid _quoteGuid;
  private rptUnderwritingLocation _srSingleLocation;
  private rptUnderwritingLocation _srMultipleLocations;
  private rptQuoteDocFees _srPremiumsAndFees;
  private rptPropertyBreakdown _srPropertyBreakdown;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader6")]
  private virtual GroupHeader GroupHeader6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader5")]
  private virtual GroupHeader GroupHeader5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader4")]
  private virtual GroupHeader GroupHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader2")]
  private virtual GroupHeader GroupHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader3")]
  private virtual GroupHeader GroupHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader7")]
  private virtual GroupHeader GroupHeader7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter7")]
  private virtual GroupFooter GroupFooter7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter3")]
  private virtual GroupFooter GroupFooter3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter2")]
  private virtual GroupFooter GroupFooter2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter4")]
  private virtual GroupFooter GroupFooter4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter5")]
  private virtual GroupFooter GroupFooter5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter6")]
  private virtual GroupFooter GroupFooter6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptPropertyBinder()
  {
    this.ReportStart += new EventHandler(this.rptPropertyQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  public rptPropertyBinder(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptPropertyQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
    this._quoteGuid = QuoteGuid;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPropertyBinder));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.GroupHeader6 = new GroupHeader();
    this.GroupFooter6 = new GroupFooter();
    this.GroupHeader5 = new GroupHeader();
    this.GroupFooter5 = new GroupFooter();
    this.GroupHeader4 = new GroupHeader();
    this.GroupFooter4 = new GroupFooter();
    this.GroupHeader2 = new GroupHeader();
    this.GroupFooter2 = new GroupFooter();
    this.GroupHeader3 = new GroupHeader();
    this.GroupFooter3 = new GroupFooter();
    this.GroupHeader7 = new GroupHeader();
    this.GroupFooter7 = new GroupFooter();
    this.Label9 = new Label();
    this.InsuredName1 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.lblTitle = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.TextBox27 = new TextBox();
    this.TextBox28 = new TextBox();
    this.TextBox29 = new TextBox();
    this.TextBox30 = new TextBox();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.InsuredAddress = new TextBox();
    this.InspectionContactName1 = new TextBox();
    this.InspectionContactPhone = new TextBox();
    this.txtCurrentCarrier = new TextBox();
    this.srSingleLocation = new SubReport();
    this.srPropertyBreakdown = new SubReport();
    this.Label36 = new Label();
    this.Label38 = new Label();
    this.TextBox48 = new TextBox();
    this.Carrier1 = new TextBox();
    this.Label54 = new Label();
    this.TextBox49 = new TextBox();
    this.Label84 = new Label();
    this.lblDollar = new Label();
    this.txtAmount = new TextBox();
    this.txtCharge = new TextBox();
    this.Label85 = new Label();
    this.Premium_LiabilityPremium1 = new TextBox();
    this.TextBox51 = new TextBox();
    this.Label86 = new Label();
    this.Premium_TerrorismPremium1 = new TextBox();
    this.TextBox52 = new TextBox();
    this.srPremiumsAndFees = new SubReport();
    this.Label87 = new Label();
    this.Premium_TotalPremium1 = new TextBox();
    this.TextBox53 = new TextBox();
    this.Label57 = new Label();
    this.TextBox20 = new TextBox();
    this.Label76 = new Label();
    this.Label75 = new Label();
    this.TextBox22 = new TextBox();
    this.Label78 = new Label();
    this.CheckBox6 = new CheckBox();
    this.CheckBox7 = new CheckBox();
    this.Label82 = new Label();
    this.TextBox25 = new TextBox();
    this.Label83 = new Label();
    this.TextBox26 = new TextBox();
    this.Line3 = new Line();
    this.TextBox47 = new TextBox();
    this.TextBox50 = new TextBox();
    this.CheckBox8 = new CheckBox();
    this.picUnderwriterSignature = new Picture();
    this.srMultipleLocations = new SubReport();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.InsuredName1).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.TextBox27).BeginInit();
    ((ISupportInitialize) this.TextBox28).BeginInit();
    ((ISupportInitialize) this.TextBox29).BeginInit();
    ((ISupportInitialize) this.TextBox30).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.InsuredAddress).BeginInit();
    ((ISupportInitialize) this.InspectionContactName1).BeginInit();
    ((ISupportInitialize) this.InspectionContactPhone).BeginInit();
    ((ISupportInitialize) this.txtCurrentCarrier).BeginInit();
    ((ISupportInitialize) this.Label36).BeginInit();
    ((ISupportInitialize) this.Label38).BeginInit();
    ((ISupportInitialize) this.TextBox48).BeginInit();
    ((ISupportInitialize) this.Carrier1).BeginInit();
    ((ISupportInitialize) this.Label54).BeginInit();
    ((ISupportInitialize) this.TextBox49).BeginInit();
    ((ISupportInitialize) this.Label84).BeginInit();
    ((ISupportInitialize) this.lblDollar).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtCharge).BeginInit();
    ((ISupportInitialize) this.Label85).BeginInit();
    ((ISupportInitialize) this.Premium_LiabilityPremium1).BeginInit();
    ((ISupportInitialize) this.TextBox51).BeginInit();
    ((ISupportInitialize) this.Label86).BeginInit();
    ((ISupportInitialize) this.Premium_TerrorismPremium1).BeginInit();
    ((ISupportInitialize) this.TextBox52).BeginInit();
    ((ISupportInitialize) this.Label87).BeginInit();
    ((ISupportInitialize) this.Premium_TotalPremium1).BeginInit();
    ((ISupportInitialize) this.TextBox53).BeginInit();
    ((ISupportInitialize) this.Label57).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.Label76).BeginInit();
    ((ISupportInitialize) this.Label75).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.Label78).BeginInit();
    ((ISupportInitialize) this.CheckBox6).BeginInit();
    ((ISupportInitialize) this.CheckBox7).BeginInit();
    ((ISupportInitialize) this.Label82).BeginInit();
    ((ISupportInitialize) this.TextBox25).BeginInit();
    ((ISupportInitialize) this.Label83).BeginInit();
    ((ISupportInitialize) this.TextBox26).BeginInit();
    ((ISupportInitialize) this.TextBox47).BeginInit();
    ((ISupportInitialize) this.TextBox50).BeginInit();
    ((ISupportInitialize) this.CheckBox8).BeginInit();
    ((ISupportInitialize) this.picUnderwriterSignature).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srSingleLocation
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.07222223f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srMultipleLocations
    });
    this.ReportFooter.Height = 0.07222223f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[18]
    {
      (ARControl) this.Label9,
      (ARControl) this.InsuredName1,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.lblTitle,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.TextBox27,
      (ARControl) this.TextBox28,
      (ARControl) this.TextBox29,
      (ARControl) this.TextBox30
    });
    this.PageHeader.Height = 29f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.InsuredAddress,
      (ARControl) this.InspectionContactName1,
      (ARControl) this.InspectionContactPhone,
      (ARControl) this.txtCurrentCarrier
    });
    this.GroupHeader1.Height = 17f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[17]
    {
      (ARControl) this.Label57,
      (ARControl) this.TextBox20,
      (ARControl) this.Label76,
      (ARControl) this.Label75,
      (ARControl) this.TextBox22,
      (ARControl) this.Label78,
      (ARControl) this.CheckBox6,
      (ARControl) this.CheckBox7,
      (ARControl) this.Label82,
      (ARControl) this.TextBox25,
      (ARControl) this.Label83,
      (ARControl) this.TextBox26,
      (ARControl) this.Line3,
      (ARControl) this.TextBox47,
      (ARControl) this.TextBox50,
      (ARControl) this.CheckBox8,
      (ARControl) this.picUnderwriterSignature
    });
    this.GroupFooter1.Height = 2.322917f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.GroupHeader6.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader6).Name = "GroupHeader6";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter6).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label87,
      (ARControl) this.Premium_TotalPremium1,
      (ARControl) this.TextBox53
    });
    this.GroupFooter6.Height = 0.3020833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter6).Name = "GroupFooter6";
    this.GroupHeader5.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader5).Name = "GroupHeader5";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter5).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srPremiumsAndFees
    });
    this.GroupFooter5.Height = 1f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter5).Name = "GroupFooter5";
    this.GroupHeader4.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader4).Name = "GroupHeader4";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter4).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Label84,
      (ARControl) this.lblDollar,
      (ARControl) this.txtAmount,
      (ARControl) this.txtCharge,
      (ARControl) this.Label85,
      (ARControl) this.Premium_LiabilityPremium1,
      (ARControl) this.TextBox51,
      (ARControl) this.Label86,
      (ARControl) this.Premium_TerrorismPremium1,
      (ARControl) this.TextBox52
    });
    this.GroupFooter4.Height = 0.5416667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter4).Name = "GroupFooter4";
    this.GroupHeader2.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2).Name = "GroupHeader2";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label54,
      (ARControl) this.TextBox49
    });
    this.GroupFooter2.Height = 0.3243056f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Name = "GroupFooter2";
    this.GroupHeader3.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader3).Name = "GroupHeader3";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter3).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label36,
      (ARControl) this.Label38,
      (ARControl) this.TextBox48,
      (ARControl) this.Carrier1
    });
    this.GroupFooter3.Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter3).Name = "GroupFooter3";
    this.GroupHeader7.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader7).Name = "GroupHeader7";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter7).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srPropertyBreakdown
    });
    this.GroupFooter7.Height = 0.05138889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter7).Name = "GroupFooter7";
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj1 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label9).Location = pointF1;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label9.Text = "NAMED INSURED:";
    ((ARControl) this.InsuredName1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredName1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredName1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredName1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredName1).DataField = "InsuredName";
    this.InsuredName1.DistinctField = (string) null;
    this.InsuredName1.Font = new Font("Arial", 8f);
    this.InsuredName1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox insuredName1 = this.InsuredName1;
    object obj2 = componentResourceManager.GetObject("InsuredName1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) insuredName1).Location = pointF2;
    ((ARControl) this.InsuredName1).Name = "InsuredName1";
    this.InsuredName1.OutputFormat = (string) null;
    ((ARControl) this.InsuredName1).Size = new SizeF(99f / 16f, 3f / 16f);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "CompanyName";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj3 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox1).Location = pointF3;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(3f, 3f / 16f);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "CompanyMailingAddress";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 10f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj4 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox2).Location = pointF4;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(3f, 0.375f);
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj5 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label1).Location = pointF5;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(0.5f, 3f / 16f);
    this.Label1.Text = "TEL #:";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj6 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label2).Location = pointF6;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.5f, 3f / 16f);
    this.Label2.Text = "Fax #:";
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "CompanyPhone";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj7 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox3).Location = pointF7;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(1.5f, 3f / 16f);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "CompanyFax";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj8 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox4).Location = pointF8;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(1.5f, 3f / 16f);
    this.lblTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTitle.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblTitle.HyperLink = (string) null;
    Label lblTitle = this.lblTitle;
    object obj9 = componentResourceManager.GetObject("lblTitle.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) lblTitle).Location = pointF9;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    ((ARControl) this.lblTitle).Size = new SizeF(7.75f, 0.25f);
    this.lblTitle.Text = "Property Binder";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 12;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 12;
    this.Label4.Font = new Font("Arial", 9f);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj10 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label4).Location = pointF10;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF((float) sbyte.MaxValue / 16f, 9f / 16f);
    this.Label4.Text = "";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj11 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label5).Location = pointF11;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1f, 3f / 16f);
    this.Label5.Text = "BROKER:";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj12 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label6).Location = pointF12;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(1f, 3f / 16f);
    this.Label6.Text = "ATTN:";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 9f);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj13 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label7).Location = pointF13;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(1f, 3f / 16f);
    this.Label7.Text = "PHONE #:";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 9f);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj14 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label8).Location = pointF14;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(1f, 3f / 16f);
    this.Label8.Text = "FAX #:";
    ((ARControl) this.TextBox27).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).DataField = "BrokerName";
    this.TextBox27.DistinctField = (string) null;
    this.TextBox27.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.TextBox27.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox27 = this.TextBox27;
    object obj15 = componentResourceManager.GetObject("TextBox27.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox27).Location = pointF15;
    ((ARControl) this.TextBox27).Name = "TextBox27";
    this.TextBox27.OutputFormat = (string) null;
    ((ARControl) this.TextBox27).Size = new SizeF(53f / 16f, 3f / 16f);
    ((ARControl) this.TextBox28).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).DataField = "ProducerContact";
    this.TextBox28.DistinctField = (string) null;
    this.TextBox28.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.TextBox28.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox28 = this.TextBox28;
    object obj16 = componentResourceManager.GetObject("TextBox28.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox28).Location = pointF16;
    ((ARControl) this.TextBox28).Name = "TextBox28";
    this.TextBox28.OutputFormat = (string) null;
    ((ARControl) this.TextBox28).Size = new SizeF(53f / 16f, 3f / 16f);
    ((ARControl) this.TextBox29).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).DataField = "BrokerPhone";
    this.TextBox29.DistinctField = (string) null;
    this.TextBox29.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox29.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox29 = this.TextBox29;
    object obj17 = componentResourceManager.GetObject("TextBox29.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox29).Location = pointF17;
    ((ARControl) this.TextBox29).Name = "TextBox29";
    this.TextBox29.OutputFormat = (string) null;
    ((ARControl) this.TextBox29).Size = new SizeF(2.375f, 3f / 16f);
    ((ARControl) this.TextBox30).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).DataField = "BrokerFax";
    this.TextBox30.DistinctField = (string) null;
    this.TextBox30.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox30.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox30 = this.TextBox30;
    object obj18 = componentResourceManager.GetObject("TextBox30.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox30).Location = pointF18;
    ((ARControl) this.TextBox30).Name = "TextBox30";
    this.TextBox30.OutputFormat = (string) null;
    ((ARControl) this.TextBox30).Size = new SizeF(2.375f, 3f / 16f);
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8f);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj19 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label10).Location = pointF19;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(25f / 16f, 0.125f);
    this.Label10.Text = "MAILING:";
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 8f);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj20 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label11).Location = pointF20;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label11.Text = "CURRENT CARRIER:";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 8f);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj21 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) label12).Location = pointF21;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label12.Text = "INSPECTION CONTACT:";
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 8f);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj22 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) label13).Location = pointF22;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label13.Text = "LOSS HISTORY 5 YRS:";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 8f);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj23 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label14).Location = pointF23;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label14.Text = "TELEPHONE:";
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj24 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label15).Location = pointF24;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label15.Text = "BUSINESS DESCRIPTION:";
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).DataField = "BusinessDescription";
    this.Label16.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj25 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label16).Location = pointF25;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(99f / 16f, 3f / 16f);
    this.Label16.Text = "";
    ((ARControl) this.InsuredAddress).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredAddress).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredAddress).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredAddress).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredAddress).DataField = "InsuredAddress";
    this.InsuredAddress.DistinctField = (string) null;
    this.InsuredAddress.Font = new Font("Arial", 8f);
    this.InsuredAddress.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox insuredAddress = this.InsuredAddress;
    object obj26 = componentResourceManager.GetObject("InsuredAddress.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) insuredAddress).Location = pointF26;
    ((ARControl) this.InsuredAddress).Name = "InsuredAddress";
    this.InsuredAddress.OutputFormat = (string) null;
    ((ARControl) this.InsuredAddress).Size = new SizeF(3.125f, 0.5f);
    ((ARControl) this.InspectionContactName1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactName1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactName1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactName1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactName1).DataField = "InspectionContactName";
    this.InspectionContactName1.DistinctField = (string) null;
    this.InspectionContactName1.Font = new Font("Arial", 8f);
    this.InspectionContactName1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox inspectionContactName1 = this.InspectionContactName1;
    object obj27 = componentResourceManager.GetObject("InspectionContactName1.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) inspectionContactName1).Location = pointF27;
    ((ARControl) this.InspectionContactName1).Name = "InspectionContactName1";
    this.InspectionContactName1.OutputFormat = (string) null;
    ((ARControl) this.InspectionContactName1).Size = new SizeF(99f / 16f, 3f / 16f);
    ((ARControl) this.InspectionContactPhone).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactPhone).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactPhone).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactPhone).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactPhone).DataField = "InsuredPhone";
    this.InspectionContactPhone.DistinctField = (string) null;
    this.InspectionContactPhone.Font = new Font("Arial", 8f);
    this.InspectionContactPhone.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox inspectionContactPhone = this.InspectionContactPhone;
    object obj28 = componentResourceManager.GetObject("InspectionContactPhone.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) inspectionContactPhone).Location = pointF28;
    ((ARControl) this.InspectionContactPhone).Name = "InspectionContactPhone";
    this.InspectionContactPhone.OutputFormat = (string) null;
    ((ARControl) this.InspectionContactPhone).Size = new SizeF(19f / 16f, 3f / 16f);
    ((ARControl) this.txtCurrentCarrier).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCurrentCarrier).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCurrentCarrier).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCurrentCarrier).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCurrentCarrier).DataField = "Carrier";
    this.txtCurrentCarrier.DistinctField = (string) null;
    this.txtCurrentCarrier.Font = new Font("Arial", 8f);
    this.txtCurrentCarrier.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCurrentCarrier = this.txtCurrentCarrier;
    object obj29 = componentResourceManager.GetObject("txtCurrentCarrier.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) txtCurrentCarrier).Location = pointF29;
    ((ARControl) this.txtCurrentCarrier).Name = "txtCurrentCarrier";
    this.txtCurrentCarrier.OutputFormat = (string) null;
    ((ARControl) this.txtCurrentCarrier).Size = new SizeF(99f / 16f, 3f / 16f);
    ((ARControl) this.srSingleLocation).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srSingleLocation).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srSingleLocation).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srSingleLocation).Border.TopStyle = (BorderLineStyle) 0;
    this.srSingleLocation.CloseBorder = false;
    SubReport srSingleLocation = this.srSingleLocation;
    object obj30 = componentResourceManager.GetObject("srSingleLocation.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) srSingleLocation).Location = pointF30;
    ((ARControl) this.srSingleLocation).Name = "srSingleLocation";
    this.srSingleLocation.Report = (SectionReport) null;
    ((ARControl) this.srSingleLocation).Size = new SizeF(7.875f, 1f / 16f);
    ((ARControl) this.srPropertyBreakdown).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPropertyBreakdown).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPropertyBreakdown).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPropertyBreakdown).Border.TopStyle = (BorderLineStyle) 0;
    this.srPropertyBreakdown.CloseBorder = false;
    SubReport propertyBreakdown = this.srPropertyBreakdown;
    object obj31 = componentResourceManager.GetObject("srPropertyBreakdown.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) propertyBreakdown).Location = pointF31;
    ((ARControl) this.srPropertyBreakdown).Name = "srPropertyBreakdown";
    this.srPropertyBreakdown.Report = (SectionReport) null;
    ((ARControl) this.srPropertyBreakdown).Size = new SizeF(7.875f, 1f / 16f);
    ((ARControl) this.Label36).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label36).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label36).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label36).Border.TopStyle = (BorderLineStyle) 0;
    this.Label36.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label36.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label36.HyperLink = (string) null;
    Label label36 = this.Label36;
    object obj32 = componentResourceManager.GetObject("Label36.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) label36).Location = pointF32;
    ((ARControl) this.Label36).Name = "Label36";
    ((ARControl) this.Label36).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label36.Text = "CARRIER:";
    ((ARControl) this.Label38).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label38).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label38).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label38).Border.TopStyle = (BorderLineStyle) 0;
    this.Label38.Font = new Font("Arial", 8f);
    this.Label38.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label38.HyperLink = (string) null;
    Label label38 = this.Label38;
    object obj33 = componentResourceManager.GetObject("Label38.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) label38).Location = pointF33;
    ((ARControl) this.Label38).Name = "Label38";
    ((ARControl) this.Label38).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label38.Text = "TYPE OF COVERAGE:";
    ((ARControl) this.TextBox48).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).DataField = "Carrier";
    this.TextBox48.DistinctField = (string) null;
    this.TextBox48.Font = new Font("Arial", 8f);
    this.TextBox48.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox48 = this.TextBox48;
    object obj34 = componentResourceManager.GetObject("TextBox48.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) textBox48).Location = pointF34;
    ((ARControl) this.TextBox48).Name = "TextBox48";
    this.TextBox48.OutputFormat = (string) null;
    ((ARControl) this.TextBox48).Size = new SizeF(99f / 16f, 3f / 16f);
    ((ARControl) this.Carrier1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier1).DataField = "TypeOfCoverage";
    this.Carrier1.DistinctField = (string) null;
    this.Carrier1.Font = new Font("Arial", 8f);
    this.Carrier1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox carrier1 = this.Carrier1;
    object obj35 = componentResourceManager.GetObject("Carrier1.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) carrier1).Location = pointF35;
    ((ARControl) this.Carrier1).Name = "Carrier1";
    this.Carrier1.OutputFormat = (string) null;
    ((ARControl) this.Carrier1).Size = new SizeF(99f / 16f, 3f / 16f);
    ((ARControl) this.Label54).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label54).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label54).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label54).Border.TopStyle = (BorderLineStyle) 0;
    this.Label54.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label54.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label54.HyperLink = (string) null;
    Label label54 = this.Label54;
    object obj36 = componentResourceManager.GetObject("Label54.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) label54).Location = pointF36;
    ((ARControl) this.Label54).Name = "Label54";
    ((ARControl) this.Label54).Size = new SizeF(25f / 16f, 5f / 16f);
    this.Label54.Text = "TERMS, CONDITIONS & EXCLUSIONS:";
    this.Label54.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox49).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox49).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox49).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox49).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox49).DataField = "TermsAndConditions";
    this.TextBox49.DistinctField = (string) null;
    this.TextBox49.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox49.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox49 = this.TextBox49;
    object obj37 = componentResourceManager.GetObject("TextBox49.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) textBox49).Location = pointF37;
    ((ARControl) this.TextBox49).Name = "TextBox49";
    this.TextBox49.OutputFormat = (string) null;
    ((ARControl) this.TextBox49).Size = new SizeF(99f / 16f, 5f / 16f);
    ((ARControl) this.Label84).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label84).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label84).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label84).Border.TopStyle = (BorderLineStyle) 0;
    this.Label84.Font = new Font("Arial", 8f);
    this.Label84.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label84.HyperLink = (string) null;
    Label label84 = this.Label84;
    object obj38 = componentResourceManager.GetObject("Label84.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) label84).Location = pointF38;
    ((ARControl) this.Label84).Name = "Label84";
    ((ARControl) this.Label84).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label84.Text = "PREMIUM:";
    ((ARControl) this.lblDollar).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDollar.Font = new Font("Arial", 8f);
    this.lblDollar.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblDollar.HyperLink = (string) null;
    Label lblDollar = this.lblDollar;
    object obj39 = componentResourceManager.GetObject("lblDollar.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) lblDollar).Location = pointF39;
    ((ARControl) this.lblDollar).Name = "lblDollar";
    ((ARControl) this.lblDollar).Size = new SizeF(0.125f, 3f / 16f);
    this.lblDollar.Text = "$";
    this.txtAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).DataField = "Premium_PropertyPremium";
    this.txtAmount.DistinctField = (string) null;
    this.txtAmount.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.txtAmount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAmount = this.txtAmount;
    object obj40 = componentResourceManager.GetObject("txtAmount.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) txtAmount).Location = pointF40;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtAmount).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtAmount.Text = " ";
    ((ARControl) this.txtCharge).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCharge).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCharge).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCharge).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCharge.DistinctField = (string) null;
    this.txtCharge.Font = new Font("Arial", 8f);
    this.txtCharge.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCharge = this.txtCharge;
    object obj41 = componentResourceManager.GetObject("txtCharge.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) txtCharge).Location = pointF41;
    ((ARControl) this.txtCharge).Name = "txtCharge";
    this.txtCharge.OutputFormat = (string) null;
    ((ARControl) this.txtCharge).Size = new SizeF(63f / 16f, 3f / 16f);
    this.txtCharge.Text = "PropertyPremium";
    ((ARControl) this.Label85).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label85).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label85).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label85).Border.TopStyle = (BorderLineStyle) 0;
    this.Label85.Font = new Font("Arial", 8f);
    this.Label85.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label85.HyperLink = (string) null;
    Label label85 = this.Label85;
    object obj42 = componentResourceManager.GetObject("Label85.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) label85).Location = pointF42;
    ((ARControl) this.Label85).Name = "Label85";
    ((ARControl) this.Label85).Size = new SizeF(0.125f, 3f / 16f);
    this.Label85.Text = "$";
    this.Premium_LiabilityPremium1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Premium_LiabilityPremium1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_LiabilityPremium1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_LiabilityPremium1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_LiabilityPremium1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_LiabilityPremium1).DataField = "Premium_TerrorismPremium";
    this.Premium_LiabilityPremium1.DistinctField = (string) null;
    this.Premium_LiabilityPremium1.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Premium_LiabilityPremium1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox liabilityPremium1 = this.Premium_LiabilityPremium1;
    object obj43 = componentResourceManager.GetObject("Premium_LiabilityPremium1.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) liabilityPremium1).Location = pointF43;
    ((ARControl) this.Premium_LiabilityPremium1).Name = "Premium_LiabilityPremium1";
    this.Premium_LiabilityPremium1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.Premium_LiabilityPremium1).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Premium_LiabilityPremium1.Text = " ";
    ((ARControl) this.TextBox51).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox51).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox51).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox51).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox51.DistinctField = (string) null;
    this.TextBox51.Font = new Font("Arial", 8f);
    this.TextBox51.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox51 = this.TextBox51;
    object obj44 = componentResourceManager.GetObject("TextBox51.Location");
    PointF pointF44 = obj44 != null ? (PointF) obj44 : new PointF();
    ((ARControl) textBox51).Location = pointF44;
    ((ARControl) this.TextBox51).Name = "TextBox51";
    this.TextBox51.OutputFormat = (string) null;
    ((ARControl) this.TextBox51).Size = new SizeF(63f / 16f, 3f / 16f);
    this.TextBox51.Text = "Terrorism Premium (Optional)";
    ((ARControl) this.Label86).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label86).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label86).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label86).Border.TopStyle = (BorderLineStyle) 1;
    this.Label86.Font = new Font("Arial", 8f);
    this.Label86.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label86.HyperLink = (string) null;
    Label label86 = this.Label86;
    object obj45 = componentResourceManager.GetObject("Label86.Location");
    PointF pointF45 = obj45 != null ? (PointF) obj45 : new PointF();
    ((ARControl) label86).Location = pointF45;
    ((ARControl) this.Label86).Name = "Label86";
    ((ARControl) this.Label86).Size = new SizeF(0.125f, 3f / 16f);
    this.Label86.Text = "$";
    this.Premium_TerrorismPremium1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Premium_TerrorismPremium1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_TerrorismPremium1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_TerrorismPremium1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_TerrorismPremium1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Premium_TerrorismPremium1).DataField = "Premium_TotalPremium";
    this.Premium_TerrorismPremium1.DistinctField = (string) null;
    this.Premium_TerrorismPremium1.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Premium_TerrorismPremium1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox terrorismPremium1 = this.Premium_TerrorismPremium1;
    object obj46 = componentResourceManager.GetObject("Premium_TerrorismPremium1.Location");
    PointF pointF46 = obj46 != null ? (PointF) obj46 : new PointF();
    ((ARControl) terrorismPremium1).Location = pointF46;
    ((ARControl) this.Premium_TerrorismPremium1).Name = "Premium_TerrorismPremium1";
    this.Premium_TerrorismPremium1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.Premium_TerrorismPremium1).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Premium_TerrorismPremium1.Text = " ";
    ((ARControl) this.TextBox52).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox52).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox52).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox52).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox52.DistinctField = (string) null;
    this.TextBox52.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox52.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox52 = this.TextBox52;
    object obj47 = componentResourceManager.GetObject("TextBox52.Location");
    PointF pointF47 = obj47 != null ? (PointF) obj47 : new PointF();
    ((ARControl) textBox52).Location = pointF47;
    ((ARControl) this.TextBox52).Name = "TextBox52";
    this.TextBox52.OutputFormat = (string) null;
    ((ARControl) this.TextBox52).Size = new SizeF(63f / 16f, 3f / 16f);
    this.TextBox52.Text = "Total Premium";
    ((ARControl) this.srPremiumsAndFees).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPremiumsAndFees).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPremiumsAndFees).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPremiumsAndFees).Border.TopStyle = (BorderLineStyle) 0;
    this.srPremiumsAndFees.CloseBorder = false;
    SubReport srPremiumsAndFees = this.srPremiumsAndFees;
    object obj48 = componentResourceManager.GetObject("srPremiumsAndFees.Location");
    PointF pointF48 = obj48 != null ? (PointF) obj48 : new PointF();
    ((ARControl) srPremiumsAndFees).Location = pointF48;
    ((ARControl) this.srPremiumsAndFees).Name = "srPremiumsAndFees";
    this.srPremiumsAndFees.Report = (SectionReport) null;
    ((ARControl) this.srPremiumsAndFees).Size = new SizeF(5f, 1f / 16f);
    ((ARControl) this.Label87).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label87).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label87).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label87).Border.TopStyle = (BorderLineStyle) 1;
    this.Label87.Font = new Font("Arial", 8f);
    this.Label87.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label87.HyperLink = (string) null;
    Label label87 = this.Label87;
    object obj49 = componentResourceManager.GetObject("Label87.Location");
    PointF pointF49 = obj49 != null ? (PointF) obj49 : new PointF();
    ((ARControl) label87).Location = pointF49;
    ((ARControl) this.Label87).Name = "Label87";
    ((ARControl) this.Label87).Size = new SizeF(0.125f, 3f / 16f);
    this.Label87.Text = "$";
    this.Premium_TotalPremium1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Premium_TotalPremium1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_TotalPremium1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_TotalPremium1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium_TotalPremium1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Premium_TotalPremium1).DataField = "Premium_GrandTotal";
    this.Premium_TotalPremium1.DistinctField = (string) null;
    this.Premium_TotalPremium1.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Premium_TotalPremium1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox premiumTotalPremium1 = this.Premium_TotalPremium1;
    object obj50 = componentResourceManager.GetObject("Premium_TotalPremium1.Location");
    PointF pointF50 = obj50 != null ? (PointF) obj50 : new PointF();
    ((ARControl) premiumTotalPremium1).Location = pointF50;
    ((ARControl) this.Premium_TotalPremium1).Name = "Premium_TotalPremium1";
    this.Premium_TotalPremium1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.Premium_TotalPremium1).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Premium_TotalPremium1.Text = " ";
    ((ARControl) this.TextBox53).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox53).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox53).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox53).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox53).DataField = "GrandTotalText";
    this.TextBox53.DistinctField = (string) null;
    this.TextBox53.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox53.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox53 = this.TextBox53;
    object obj51 = componentResourceManager.GetObject("TextBox53.Location");
    PointF pointF51 = obj51 != null ? (PointF) obj51 : new PointF();
    ((ARControl) textBox53).Location = pointF51;
    ((ARControl) this.TextBox53).Name = "TextBox53";
    this.TextBox53.OutputFormat = (string) null;
    ((ARControl) this.TextBox53).Size = new SizeF(63f / 16f, 3f / 16f);
    ((ARControl) this.Label57).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label57).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label57).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label57).Border.TopStyle = (BorderLineStyle) 0;
    this.Label57.Font = new Font("Arial", 8f);
    this.Label57.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label57.HyperLink = (string) null;
    Label label57 = this.Label57;
    object obj52 = componentResourceManager.GetObject("Label57.Location");
    PointF pointF52 = obj52 != null ? (PointF) obj52 : new PointF();
    ((ARControl) label57).Location = pointF52;
    ((ARControl) this.Label57).Name = "Label57";
    ((ARControl) this.Label57).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label57.Text = "POLICY PERIOD:";
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).DataField = "PolicyPeriod";
    this.TextBox20.DistinctField = (string) null;
    this.TextBox20.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox20.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox20 = this.TextBox20;
    object obj53 = componentResourceManager.GetObject("TextBox20.Location");
    PointF pointF53 = obj53 != null ? (PointF) obj53 : new PointF();
    ((ARControl) textBox20).Location = pointF53;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = (string) null;
    ((ARControl) this.TextBox20).Size = new SizeF(2.375f, 3f / 16f);
    this.TextBox20.Text = "TBD";
    this.Label76.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label76).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label76).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label76).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label76).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label76).DataField = "CompanyName";
    this.Label76.Font = new Font("Arial", 8f, FontStyle.Italic);
    this.Label76.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label76.HyperLink = (string) null;
    Label label76 = this.Label76;
    object obj54 = componentResourceManager.GetObject("Label76.Location");
    PointF pointF54 = obj54 != null ? (PointF) obj54 : new PointF();
    ((ARControl) label76).Location = pointF54;
    ((ARControl) this.Label76).Name = "Label76";
    ((ARControl) this.Label76).Size = new SizeF(93f / 16f, 3f / 16f);
    this.Label76.Text = "";
    ((ARControl) this.Label75).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label75).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label75).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label75).Border.TopStyle = (BorderLineStyle) 0;
    this.Label75.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label75.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label75.HyperLink = (string) null;
    Label label75 = this.Label75;
    object obj55 = componentResourceManager.GetObject("Label75.Location");
    PointF pointF55 = obj55 != null ? (PointF) obj55 : new PointF();
    ((ARControl) label75).Location = pointF55;
    ((ARControl) this.Label75).Name = "Label75";
    ((ARControl) this.Label75).Size = new SizeF(31f / 16f, 3f / 16f);
    this.Label75.Text = "UNDERWRITER'S APPROVAL:";
    this.TextBox22.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox22.DistinctField = (string) null;
    this.TextBox22.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox22.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox22 = this.TextBox22;
    object obj56 = componentResourceManager.GetObject("TextBox22.Location");
    PointF pointF56 = obj56 != null ? (PointF) obj56 : new PointF();
    ((ARControl) textBox22).Location = pointF56;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = "MM/dd/yy";
    ((ARControl) this.TextBox22).Size = new SizeF(29f / 16f, 3f / 16f);
    ((ARControl) this.Label78).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label78).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label78).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label78).Border.TopStyle = (BorderLineStyle) 0;
    this.Label78.Font = new Font("Arial", 8f);
    this.Label78.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label78.HyperLink = (string) null;
    Label label78 = this.Label78;
    object obj57 = componentResourceManager.GetObject("Label78.Location");
    PointF pointF57 = obj57 != null ? (PointF) obj57 : new PointF();
    ((ARControl) label78).Location = pointF57;
    ((ARControl) this.Label78).Name = "Label78";
    ((ARControl) this.Label78).Size = new SizeF(35f / 16f, 3f / 16f);
    this.Label78.Text = "PLEASE BIND AS QUOTED EFF:";
    ((ARControl) this.CheckBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox6).DataField = "BindWithTerrorism";
    this.CheckBox6.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.CheckBox6.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox6 = this.CheckBox6;
    object obj58 = componentResourceManager.GetObject("CheckBox6.Location");
    PointF pointF58 = obj58 != null ? (PointF) obj58 : new PointF();
    ((ARControl) checkBox6).Location = pointF58;
    ((ARControl) this.CheckBox6).Name = "CheckBox6";
    ((ARControl) this.CheckBox6).Size = new SizeF(35f / 16f, 0.125f);
    this.CheckBox6.Text = "BIND WITH TERRORISM";
    ((ARControl) this.CheckBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox7).DataField = "BindWithOutTerrorism";
    this.CheckBox7.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.CheckBox7.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox7 = this.CheckBox7;
    object obj59 = componentResourceManager.GetObject("CheckBox7.Location");
    PointF pointF59 = obj59 != null ? (PointF) obj59 : new PointF();
    ((ARControl) checkBox7).Location = pointF59;
    ((ARControl) this.CheckBox7).Name = "CheckBox7";
    ((ARControl) this.CheckBox7).Size = new SizeF(35f / 16f, 0.125f);
    this.CheckBox7.Text = "BIND WITHOUT TERRORISM";
    ((ARControl) this.Label82).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label82).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label82).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label82).Border.TopStyle = (BorderLineStyle) 0;
    this.Label82.Font = new Font("Arial", 8f);
    this.Label82.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label82.HyperLink = (string) null;
    Label label82 = this.Label82;
    object obj60 = componentResourceManager.GetObject("Label82.Location");
    PointF pointF60 = obj60 != null ? (PointF) obj60 : new PointF();
    ((ARControl) label82).Location = pointF60;
    ((ARControl) this.Label82).Name = "Label82";
    ((ARControl) this.Label82).Size = new SizeF(1.625f, 0.125f);
    this.Label82.Text = "BROKER'S SIGNATURE:";
    ((ARControl) this.TextBox25).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox25.DistinctField = (string) null;
    this.TextBox25.Font = new Font("Arial", 8f);
    this.TextBox25.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox25 = this.TextBox25;
    object obj61 = componentResourceManager.GetObject("TextBox25.Location");
    PointF pointF61 = obj61 != null ? (PointF) obj61 : new PointF();
    ((ARControl) textBox25).Location = pointF61;
    ((ARControl) this.TextBox25).Name = "TextBox25";
    this.TextBox25.OutputFormat = (string) null;
    ((ARControl) this.TextBox25).Size = new SizeF(1.625f, 0.125f);
    ((ARControl) this.Label83).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label83).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label83).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label83).Border.TopStyle = (BorderLineStyle) 0;
    this.Label83.Font = new Font("Arial", 8f);
    this.Label83.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label83.HyperLink = (string) null;
    Label label83 = this.Label83;
    object obj62 = componentResourceManager.GetObject("Label83.Location");
    PointF pointF62 = obj62 != null ? (PointF) obj62 : new PointF();
    ((ARControl) label83).Location = pointF62;
    ((ARControl) this.Label83).Name = "Label83";
    ((ARControl) this.Label83).Size = new SizeF(0.75f, 0.125f);
    this.Label83.Text = "POLICY #:";
    ((ARControl) this.TextBox26).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).DataField = "PolicyNumber";
    this.TextBox26.DistinctField = (string) null;
    this.TextBox26.Font = new Font("Arial", 8f);
    this.TextBox26.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox26 = this.TextBox26;
    object obj63 = componentResourceManager.GetObject("TextBox26.Location");
    PointF pointF63 = obj63 != null ? (PointF) obj63 : new PointF();
    ((ARControl) textBox26).Location = pointF63;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.OutputFormat = (string) null;
    ((ARControl) this.TextBox26).Size = new SizeF(2.375f, 0.125f);
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    this.Line3.X1 = 0.52f;
    this.Line3.X2 = 17f / 16f;
    this.Line3.Y1 = 33f / 16f;
    this.Line3.Y2 = 33f / 16f;
    ((ARControl) this.TextBox47).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox47).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).DataField = "PolicyEffectiveDate";
    this.TextBox47.DistinctField = (string) null;
    this.TextBox47.Font = new Font("Arial", 8f);
    this.TextBox47.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox47 = this.TextBox47;
    object obj64 = componentResourceManager.GetObject("TextBox47.Location");
    PointF pointF64 = obj64 != null ? (PointF) obj64 : new PointF();
    ((ARControl) textBox47).Location = pointF64;
    ((ARControl) this.TextBox47).Name = "TextBox47";
    this.TextBox47.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox47).Size = new SizeF(23f / 16f, 3f / 16f);
    ((ARControl) this.TextBox50).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox50).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox50).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox50).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox50).DataField = "FooterCopy";
    this.TextBox50.DistinctField = (string) null;
    this.TextBox50.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox50.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox50 = this.TextBox50;
    object obj65 = componentResourceManager.GetObject("TextBox50.Location");
    PointF pointF65 = obj65 != null ? (PointF) obj65 : new PointF();
    ((ARControl) textBox50).Location = pointF65;
    ((ARControl) this.TextBox50).Name = "TextBox50";
    this.TextBox50.OutputFormat = (string) null;
    ((ARControl) this.TextBox50).Size = new SizeF(7.75f, 0.375f);
    ((ARControl) this.CheckBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox8).DataField = "BrokerIsResponsible";
    this.CheckBox8.Font = new Font("Arial", 8f);
    this.CheckBox8.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox8 = this.CheckBox8;
    object obj66 = componentResourceManager.GetObject("CheckBox8.Location");
    PointF pointF66 = obj66 != null ? (PointF) obj66 : new PointF();
    ((ARControl) checkBox8).Location = pointF66;
    ((ARControl) this.CheckBox8).Name = "CheckBox8";
    ((ARControl) this.CheckBox8).Size = new SizeF(7.75f, 3f / 16f);
    this.CheckBox8.Text = "Broker is Responsible for surplus lines filings and fees.";
    ((ARControl) this.picUnderwriterSignature).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.picUnderwriterSignature).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.picUnderwriterSignature).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.picUnderwriterSignature).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.picUnderwriterSignature).DataField = "UnderwriterSignature";
    this.picUnderwriterSignature.Image = (Image) null;
    this.picUnderwriterSignature.ImageData = (Stream) null;
    this.picUnderwriterSignature.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    this.picUnderwriterSignature.LineWeight = 0.0f;
    Picture underwriterSignature = this.picUnderwriterSignature;
    object obj67 = componentResourceManager.GetObject("picUnderwriterSignature.Location");
    PointF pointF67 = obj67 != null ? (PointF) obj67 : new PointF();
    ((ARControl) underwriterSignature).Location = pointF67;
    ((ARControl) this.picUnderwriterSignature).Name = "picUnderwriterSignature";
    this.picUnderwriterSignature.PictureAlignment = (PictureAlignment) 3;
    ((ARControl) this.picUnderwriterSignature).Size = new SizeF(2f, 0.563f);
    this.picUnderwriterSignature.SizeMode = (SizeModes) 1;
    ((ARControl) this.srMultipleLocations).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srMultipleLocations).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srMultipleLocations).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srMultipleLocations).Border.TopStyle = (BorderLineStyle) 0;
    this.srMultipleLocations.CloseBorder = false;
    SubReport multipleLocations = this.srMultipleLocations;
    object obj68 = componentResourceManager.GetObject("srMultipleLocations.Location");
    PointF pointF68 = obj68 != null ? (PointF) obj68 : new PointF();
    ((ARControl) multipleLocations).Location = pointF68;
    ((ARControl) this.srMultipleLocations).Name = "srMultipleLocations";
    this.srMultipleLocations.Report = (SectionReport) null;
    ((ARControl) this.srMultipleLocations).Size = new SizeF(7.875f, 1f / 16f);
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader6);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader5);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader4);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader3);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader7);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter7);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter3);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter4);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter5);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter6);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.InsuredName1).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.TextBox27).EndInit();
    ((ISupportInitialize) this.TextBox28).EndInit();
    ((ISupportInitialize) this.TextBox29).EndInit();
    ((ISupportInitialize) this.TextBox30).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.InsuredAddress).EndInit();
    ((ISupportInitialize) this.InspectionContactName1).EndInit();
    ((ISupportInitialize) this.InspectionContactPhone).EndInit();
    ((ISupportInitialize) this.txtCurrentCarrier).EndInit();
    ((ISupportInitialize) this.Label36).EndInit();
    ((ISupportInitialize) this.Label38).EndInit();
    ((ISupportInitialize) this.TextBox48).EndInit();
    ((ISupportInitialize) this.Carrier1).EndInit();
    ((ISupportInitialize) this.Label54).EndInit();
    ((ISupportInitialize) this.TextBox49).EndInit();
    ((ISupportInitialize) this.Label84).EndInit();
    ((ISupportInitialize) this.lblDollar).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtCharge).EndInit();
    ((ISupportInitialize) this.Label85).EndInit();
    ((ISupportInitialize) this.Premium_LiabilityPremium1).EndInit();
    ((ISupportInitialize) this.TextBox51).EndInit();
    ((ISupportInitialize) this.Label86).EndInit();
    ((ISupportInitialize) this.Premium_TerrorismPremium1).EndInit();
    ((ISupportInitialize) this.TextBox52).EndInit();
    ((ISupportInitialize) this.Label87).EndInit();
    ((ISupportInitialize) this.Premium_TotalPremium1).EndInit();
    ((ISupportInitialize) this.TextBox53).EndInit();
    ((ISupportInitialize) this.Label57).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.Label76).EndInit();
    ((ISupportInitialize) this.Label75).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.Label78).EndInit();
    ((ISupportInitialize) this.CheckBox6).EndInit();
    ((ISupportInitialize) this.CheckBox7).EndInit();
    ((ISupportInitialize) this.Label82).EndInit();
    ((ISupportInitialize) this.TextBox25).EndInit();
    ((ISupportInitialize) this.Label83).EndInit();
    ((ISupportInitialize) this.TextBox26).EndInit();
    ((ISupportInitialize) this.TextBox47).EndInit();
    ((ISupportInitialize) this.TextBox50).EndInit();
    ((ISupportInitialize) this.CheckBox8).EndInit();
    ((ISupportInitialize) this.picUnderwriterSignature).EndInit();
  }

  private void rptPropertyQuote_ReportStart(object sender, EventArgs e)
  {
    DataSet dataSet = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, nameof (rptPropertyBinder), 0, (CommandArgumentType) 0, new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    if (dataSet.Tables.Count != 3 || dataSet.Tables[0].Rows.Count != 1)
      return;
    this.DataSource = (object) dataSet.Tables[0];
    this._srPropertyBreakdown = new rptPropertyBreakdown(dataSet.Tables[2]);
    this.srPropertyBreakdown.Report = (SectionReport) this._srPropertyBreakdown;
    dataSet.Tables[1].Columns.Add("LocID", typeof (int));
    int num = dataSet.Tables[1].Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
      dataSet.Tables[1].Rows[index]["LocID"] = (object) index;
    if (dataSet.Tables[1].Rows.Count >= 1)
    {
      this._srSingleLocation = new rptUnderwritingLocation(new DataView(dataSet.Tables[1], "LocID = '0'", "", DataViewRowState.CurrentRows), false);
      this.srSingleLocation.Report = (SectionReport) this._srSingleLocation;
    }
    else
      ((ARControl) this.srSingleLocation).Visible = false;
    if (dataSet.Tables[1].Rows.Count > 1)
    {
      Label lblTitle;
      string str = (lblTitle = this.lblTitle).Text + " - Additional Locations";
      lblTitle.Text = str;
      this._srMultipleLocations = new rptUnderwritingLocation(new DataView(dataSet.Tables[1], "LocID <> '0'", "", DataViewRowState.CurrentRows), true);
      this.srMultipleLocations.Report = (SectionReport) this._srMultipleLocations;
    }
    this._srPremiumsAndFees = new rptQuoteDocFees(this._quoteGuid);
    this.srPremiumsAndFees.Report = (SectionReport) this._srPremiumsAndFees;
  }

  private void rptPropertyQuote_ReportEnd(object sender, EventArgs e)
  {
    if (this._srSingleLocation != null)
      this._srSingleLocation.Dispose();
    if (this._srMultipleLocations != null)
      this._srMultipleLocations.Dispose();
    if (this._srPremiumsAndFees != null)
      this._srPremiumsAndFees.Dispose();
    if (this._srPropertyBreakdown == null)
      return;
    this._srPropertyBreakdown.Dispose();
  }

  public bool RequiresQuoteOptionGuids() => false;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
  }
}
