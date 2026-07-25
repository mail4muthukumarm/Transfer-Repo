// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptMonoLineLiabilityQuote
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
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{E854E5B7-EACF-448d-BF85-0B8EE1240A6F}", Enums.AutomationDocGroups.PolicyDoc, "Mono-Line Liability", "Quote document for mono-line liability quotes.")]
public class rptMonoLineLiabilityQuote : SectionReport, IQuoteDocument
{
  private Label Label9;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private TextBox TextBox31;
  private TextBox TextBox32;
  private TextBox InspectionContactPhone;
  private TextBox txtCurrentCarrier;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private Label Label1;
  private Label Label2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private TextBox TextBox27;
  private TextBox TextBox28;
  private TextBox TextBox29;
  private TextBox TextBox30;
  private TextBox InsuredAddress;
  private SubReport srSingleLocation;
  private Label Label36;
  private Label Label38;
  private Label Label40;
  private Label Label41;
  private Label Label42;
  private Label Label43;
  private Label Label44;
  private Label Label45;
  private Label Label46;
  private Label Label47;
  private Label Label49;
  private Label Label50;
  private Label Label51;
  private Label Label52;
  private Label Label53;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox Carrier1;
  private TextBox Carrier2;
  private Label Label54;
  private TextBox TextBox48;
  private Label lblDollar;
  private TextBox txtAmount;
  private TextBox txtCharge;
  private Label Label56;
  private Label Label84;
  private TextBox Premium_LiabilityPremium1;
  private TextBox TextBox51;
  private Label Label85;
  private TextBox Premium_TerrorismPremium1;
  private TextBox TextBox52;
  private SubReport srPremiumsAndFees;
  private Label Label86;
  private TextBox Premium_TotalPremium1;
  private TextBox TextBox53;
  private Label Label76;
  private Label Label75;
  private TextBox TextBox21;
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
  private Label Label57;
  private TextBox TextBox20;
  private CheckBox CheckBox8;
  private readonly Guid _quoteGuid;
  private rptUnderwritingLocation _srSingleLocation;
  private rptQuoteDocFees _srPremiumsAndFees;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader3")]
  private virtual GroupHeader GroupHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader7")]
  private virtual GroupHeader GroupHeader7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader5")]
  private virtual GroupHeader GroupHeader5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader6")]
  private virtual GroupHeader GroupHeader6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader4")]
  private virtual GroupHeader GroupHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader2")]
  private virtual GroupHeader GroupHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter2")]
  private virtual GroupFooter GroupFooter2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter4")]
  private virtual GroupFooter GroupFooter4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter6")]
  private virtual GroupFooter GroupFooter6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter5")]
  private virtual GroupFooter GroupFooter5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter7")]
  private virtual GroupFooter GroupFooter7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter3")]
  private virtual GroupFooter GroupFooter3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptMonoLineLiabilityQuote()
  {
    this.ReportStart += new EventHandler(this.rptMonoLineLiabilityQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptMonoLineLiabilityQuote_ReportEnd);
    this.InitializeComponent();
  }

  public rptMonoLineLiabilityQuote(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptMonoLineLiabilityQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptMonoLineLiabilityQuote_ReportEnd);
    this.InitializeComponent();
    this._quoteGuid = QuoteGuid;
  }

  private void rptMonoLineLiabilityQuote_ReportStart(object sender, EventArgs e)
  {
    DataSet dataSet = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, nameof (rptMonoLineLiabilityQuote), 0, (CommandArgumentType) 0, new object[2]
    {
      (object) "@QUOTEGUID",
      (object) this._quoteGuid
    });
    if (dataSet.Tables.Count == 2 && dataSet.Tables[0].Rows.Count == 1)
    {
      this.DataSource = (object) dataSet.Tables[0];
      this._srSingleLocation = new rptUnderwritingLocation(new DataView(dataSet.Tables[1]), false);
      this.srSingleLocation.Report = (SectionReport) this._srSingleLocation;
    }
    this._srPremiumsAndFees = new rptQuoteDocFees(this._quoteGuid);
    this.srPremiumsAndFees.Report = (SectionReport) this._srPremiumsAndFees;
  }

  private void rptMonoLineLiabilityQuote_ReportEnd(object sender, EventArgs e)
  {
    if (this._srSingleLocation != null)
      this._srSingleLocation.Dispose();
    if (this._srPremiumsAndFees == null)
      return;
    this._srPremiumsAndFees.Dispose();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptMonoLineLiabilityQuote));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.GroupHeader3 = new GroupHeader();
    this.GroupFooter3 = new GroupFooter();
    this.GroupHeader7 = new GroupHeader();
    this.GroupFooter7 = new GroupFooter();
    this.GroupHeader5 = new GroupHeader();
    this.GroupFooter5 = new GroupFooter();
    this.GroupHeader6 = new GroupHeader();
    this.GroupFooter6 = new GroupFooter();
    this.GroupHeader4 = new GroupHeader();
    this.GroupFooter4 = new GroupFooter();
    this.GroupHeader2 = new GroupHeader();
    this.GroupFooter2 = new GroupFooter();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.TextBox31 = new TextBox();
    this.TextBox32 = new TextBox();
    this.InspectionContactPhone = new TextBox();
    this.txtCurrentCarrier = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.TextBox27 = new TextBox();
    this.TextBox28 = new TextBox();
    this.TextBox29 = new TextBox();
    this.TextBox30 = new TextBox();
    this.InsuredAddress = new TextBox();
    this.srSingleLocation = new SubReport();
    this.Label36 = new Label();
    this.Label38 = new Label();
    this.Label40 = new Label();
    this.Label41 = new Label();
    this.Label42 = new Label();
    this.Label43 = new Label();
    this.Label44 = new Label();
    this.Label45 = new Label();
    this.Label46 = new Label();
    this.Label47 = new Label();
    this.Label49 = new Label();
    this.Label50 = new Label();
    this.Label51 = new Label();
    this.Label52 = new Label();
    this.Label53 = new Label();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.Carrier1 = new TextBox();
    this.Carrier2 = new TextBox();
    this.Label54 = new Label();
    this.TextBox48 = new TextBox();
    this.lblDollar = new Label();
    this.txtAmount = new TextBox();
    this.txtCharge = new TextBox();
    this.Label56 = new Label();
    this.Label84 = new Label();
    this.Premium_LiabilityPremium1 = new TextBox();
    this.TextBox51 = new TextBox();
    this.Label85 = new Label();
    this.Premium_TerrorismPremium1 = new TextBox();
    this.TextBox52 = new TextBox();
    this.srPremiumsAndFees = new SubReport();
    this.Label86 = new Label();
    this.Premium_TotalPremium1 = new TextBox();
    this.TextBox53 = new TextBox();
    this.Label76 = new Label();
    this.Label75 = new Label();
    this.TextBox21 = new TextBox();
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
    this.Label57 = new Label();
    this.TextBox20 = new TextBox();
    this.CheckBox8 = new CheckBox();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.TextBox31).BeginInit();
    ((ISupportInitialize) this.TextBox32).BeginInit();
    ((ISupportInitialize) this.InspectionContactPhone).BeginInit();
    ((ISupportInitialize) this.txtCurrentCarrier).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.TextBox27).BeginInit();
    ((ISupportInitialize) this.TextBox28).BeginInit();
    ((ISupportInitialize) this.TextBox29).BeginInit();
    ((ISupportInitialize) this.TextBox30).BeginInit();
    ((ISupportInitialize) this.InsuredAddress).BeginInit();
    ((ISupportInitialize) this.Label36).BeginInit();
    ((ISupportInitialize) this.Label38).BeginInit();
    ((ISupportInitialize) this.Label40).BeginInit();
    ((ISupportInitialize) this.Label41).BeginInit();
    ((ISupportInitialize) this.Label42).BeginInit();
    ((ISupportInitialize) this.Label43).BeginInit();
    ((ISupportInitialize) this.Label44).BeginInit();
    ((ISupportInitialize) this.Label45).BeginInit();
    ((ISupportInitialize) this.Label46).BeginInit();
    ((ISupportInitialize) this.Label47).BeginInit();
    ((ISupportInitialize) this.Label49).BeginInit();
    ((ISupportInitialize) this.Label50).BeginInit();
    ((ISupportInitialize) this.Label51).BeginInit();
    ((ISupportInitialize) this.Label52).BeginInit();
    ((ISupportInitialize) this.Label53).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.Carrier1).BeginInit();
    ((ISupportInitialize) this.Carrier2).BeginInit();
    ((ISupportInitialize) this.Label54).BeginInit();
    ((ISupportInitialize) this.TextBox48).BeginInit();
    ((ISupportInitialize) this.lblDollar).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtCharge).BeginInit();
    ((ISupportInitialize) this.Label56).BeginInit();
    ((ISupportInitialize) this.Label84).BeginInit();
    ((ISupportInitialize) this.Premium_LiabilityPremium1).BeginInit();
    ((ISupportInitialize) this.TextBox51).BeginInit();
    ((ISupportInitialize) this.Label85).BeginInit();
    ((ISupportInitialize) this.Premium_TerrorismPremium1).BeginInit();
    ((ISupportInitialize) this.TextBox52).BeginInit();
    ((ISupportInitialize) this.Label86).BeginInit();
    ((ISupportInitialize) this.Premium_TotalPremium1).BeginInit();
    ((ISupportInitialize) this.TextBox53).BeginInit();
    ((ISupportInitialize) this.Label76).BeginInit();
    ((ISupportInitialize) this.Label75).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
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
    ((ISupportInitialize) this.Label57).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.CheckBox8).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srSingleLocation
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.05138889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[29]
    {
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.TextBox31,
      (ARControl) this.TextBox32,
      (ARControl) this.InspectionContactPhone,
      (ARControl) this.txtCurrentCarrier,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.TextBox27,
      (ARControl) this.TextBox28,
      (ARControl) this.TextBox29,
      (ARControl) this.TextBox30,
      (ARControl) this.InsuredAddress
    });
    this.ReportHeader.Height = 2.926389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.GroupHeader3.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader3).Name = "GroupHeader3";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter3).Controls.AddRange(new ARControl[17]
    {
      (ARControl) this.Label76,
      (ARControl) this.Label75,
      (ARControl) this.TextBox21,
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
      (ARControl) this.Label57,
      (ARControl) this.TextBox20,
      (ARControl) this.CheckBox8
    });
    this.GroupFooter3.Height = 1.947222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter3).Name = "GroupFooter3";
    this.GroupFooter3.PrintAtBottom = true;
    this.GroupHeader7.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader7).Name = "GroupHeader7";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter7).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label86,
      (ARControl) this.Premium_TotalPremium1,
      (ARControl) this.TextBox53
    });
    this.GroupFooter7.Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter7).Name = "GroupFooter7";
    this.GroupHeader5.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader5).Name = "GroupHeader5";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter5).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srPremiumsAndFees
    });
    this.GroupFooter5.Height = 1f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter5).Name = "GroupFooter5";
    this.GroupHeader6.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader6).Name = "GroupHeader6";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter6).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.lblDollar,
      (ARControl) this.txtAmount,
      (ARControl) this.txtCharge,
      (ARControl) this.Label56,
      (ARControl) this.Label84,
      (ARControl) this.Premium_LiabilityPremium1,
      (ARControl) this.TextBox51,
      (ARControl) this.Label85,
      (ARControl) this.Premium_TerrorismPremium1,
      (ARControl) this.TextBox52
    });
    this.GroupFooter6.Height = 0.625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter6).Name = "GroupFooter6";
    this.GroupHeader4.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader4).Name = "GroupHeader4";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter4).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label54,
      (ARControl) this.TextBox48
    });
    this.GroupFooter4.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter4).Name = "GroupFooter4";
    this.GroupHeader2.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2).Name = "GroupHeader2";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Controls.AddRange(new ARControl[23]
    {
      (ARControl) this.Label36,
      (ARControl) this.Label38,
      (ARControl) this.Label40,
      (ARControl) this.Label41,
      (ARControl) this.Label42,
      (ARControl) this.Label43,
      (ARControl) this.Label44,
      (ARControl) this.Label45,
      (ARControl) this.Label46,
      (ARControl) this.Label47,
      (ARControl) this.Label49,
      (ARControl) this.Label50,
      (ARControl) this.Label51,
      (ARControl) this.Label52,
      (ARControl) this.Label53,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.Carrier1,
      (ARControl) this.Carrier2
    });
    this.GroupFooter2.Height = 1.177083f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Name = "GroupFooter2";
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
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8f);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj2 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label10).Location = pointF2;
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
    object obj3 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label11).Location = pointF3;
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
    object obj4 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label12).Location = pointF4;
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
    object obj5 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label13).Location = pointF5;
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
    object obj6 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label14).Location = pointF6;
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
    object obj7 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label15).Location = pointF7;
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
    object obj8 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label16).Location = pointF8;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(99f / 16f, 3f / 16f);
    this.Label16.Text = "";
    ((ARControl) this.TextBox31).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).DataField = "InsuredName";
    this.TextBox31.DistinctField = (string) null;
    this.TextBox31.Font = new Font("Arial", 8f);
    this.TextBox31.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox31 = this.TextBox31;
    object obj9 = componentResourceManager.GetObject("TextBox31.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox31).Location = pointF9;
    ((ARControl) this.TextBox31).Name = "TextBox31";
    this.TextBox31.OutputFormat = (string) null;
    ((ARControl) this.TextBox31).Size = new SizeF(99f / 16f, 3f / 16f);
    ((ARControl) this.TextBox32).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).DataField = "InspectionContactName";
    this.TextBox32.DistinctField = (string) null;
    this.TextBox32.Font = new Font("Arial", 8f);
    this.TextBox32.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox32 = this.TextBox32;
    object obj10 = componentResourceManager.GetObject("TextBox32.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox32).Location = pointF10;
    ((ARControl) this.TextBox32).Name = "TextBox32";
    this.TextBox32.OutputFormat = (string) null;
    ((ARControl) this.TextBox32).Size = new SizeF(99f / 16f, 3f / 16f);
    ((ARControl) this.InspectionContactPhone).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactPhone).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactPhone).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactPhone).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.InspectionContactPhone).DataField = "InspectionContactTelephone";
    this.InspectionContactPhone.DistinctField = (string) null;
    this.InspectionContactPhone.Font = new Font("Arial", 8f);
    this.InspectionContactPhone.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox inspectionContactPhone = this.InspectionContactPhone;
    object obj11 = componentResourceManager.GetObject("InspectionContactPhone.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) inspectionContactPhone).Location = pointF11;
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
    object obj12 = componentResourceManager.GetObject("txtCurrentCarrier.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtCurrentCarrier).Location = pointF12;
    ((ARControl) this.txtCurrentCarrier).Name = "txtCurrentCarrier";
    this.txtCurrentCarrier.OutputFormat = (string) null;
    ((ARControl) this.txtCurrentCarrier).Size = new SizeF(99f / 16f, 3f / 16f);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "CompanyName";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj13 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox1).Location = pointF13;
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
    object obj14 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox2).Location = pointF14;
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
    object obj15 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label1).Location = pointF15;
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
    object obj16 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label2).Location = pointF16;
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
    object obj17 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox3).Location = pointF17;
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
    object obj18 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox4).Location = pointF18;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(1.5f, 3f / 16f);
    this.Label3.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj19 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label3).Location = pointF19;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(7.75f, 0.25f);
    this.Label3.Text = "Mono-Line Liability Quote";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 12;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 12;
    this.Label4.Font = new Font("Arial", 9f);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj20 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label4).Location = pointF20;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(7.875f, 9f / 16f);
    this.Label4.Text = "";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj21 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) label5).Location = pointF21;
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
    object obj22 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) label6).Location = pointF22;
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
    object obj23 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label7).Location = pointF23;
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
    object obj24 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label8).Location = pointF24;
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
    object obj25 = componentResourceManager.GetObject("TextBox27.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) textBox27).Location = pointF25;
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
    object obj26 = componentResourceManager.GetObject("TextBox28.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox28).Location = pointF26;
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
    object obj27 = componentResourceManager.GetObject("TextBox29.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox29).Location = pointF27;
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
    object obj28 = componentResourceManager.GetObject("TextBox30.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) textBox30).Location = pointF28;
    ((ARControl) this.TextBox30).Name = "TextBox30";
    this.TextBox30.OutputFormat = (string) null;
    ((ARControl) this.TextBox30).Size = new SizeF(2.375f, 3f / 16f);
    ((ARControl) this.InsuredAddress).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredAddress).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredAddress).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredAddress).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.InsuredAddress).DataField = "InsuredAddress";
    this.InsuredAddress.DistinctField = (string) null;
    this.InsuredAddress.Font = new Font("Arial", 8f);
    this.InsuredAddress.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox insuredAddress = this.InsuredAddress;
    object obj29 = componentResourceManager.GetObject("InsuredAddress.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) insuredAddress).Location = pointF29;
    ((ARControl) this.InsuredAddress).Name = "InsuredAddress";
    this.InsuredAddress.OutputFormat = (string) null;
    ((ARControl) this.InsuredAddress).Size = new SizeF(3.5f, 0.5f);
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
    ((ARControl) this.Label36).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label36).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label36).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label36).Border.TopStyle = (BorderLineStyle) 0;
    this.Label36.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label36.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label36.HyperLink = (string) null;
    Label label36 = this.Label36;
    object obj31 = componentResourceManager.GetObject("Label36.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) label36).Location = pointF31;
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
    object obj32 = componentResourceManager.GetObject("Label38.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) label38).Location = pointF32;
    ((ARControl) this.Label38).Name = "Label38";
    ((ARControl) this.Label38).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label38.Text = "TYPE OF COVERAGE:";
    ((ARControl) this.Label40).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label40).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label40).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label40).Border.TopStyle = (BorderLineStyle) 0;
    this.Label40.Font = new Font("Arial", 8f);
    this.Label40.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label40.HyperLink = (string) null;
    Label label40 = this.Label40;
    object obj33 = componentResourceManager.GetObject("Label40.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) label40).Location = pointF33;
    ((ARControl) this.Label40).Name = "Label40";
    ((ARControl) this.Label40).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label40.Text = "LIMITS:";
    ((ARControl) this.Label41).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label41).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label41).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label41).Border.TopStyle = (BorderLineStyle) 0;
    this.Label41.Font = new Font("Arial", 8f);
    this.Label41.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label41.HyperLink = (string) null;
    Label label41 = this.Label41;
    object obj34 = componentResourceManager.GetObject("Label41.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) label41).Location = pointF34;
    ((ARControl) this.Label41).Name = "Label41";
    ((ARControl) this.Label41).Size = new SizeF(0.125f, 0.125f);
    this.Label41.Text = "$";
    ((ARControl) this.Label42).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label42).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label42).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label42).Border.TopStyle = (BorderLineStyle) 0;
    this.Label42.Font = new Font("Arial", 8f);
    this.Label42.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label42.HyperLink = (string) null;
    Label label42 = this.Label42;
    object obj35 = componentResourceManager.GetObject("Label42.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) label42).Location = pointF35;
    ((ARControl) this.Label42).Name = "Label42";
    ((ARControl) this.Label42).Size = new SizeF(0.125f, 0.125f);
    this.Label42.Text = "$";
    ((ARControl) this.Label43).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label43).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label43).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label43).Border.TopStyle = (BorderLineStyle) 0;
    this.Label43.Font = new Font("Arial", 8f);
    this.Label43.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label43.HyperLink = (string) null;
    Label label43 = this.Label43;
    object obj36 = componentResourceManager.GetObject("Label43.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) label43).Location = pointF36;
    ((ARControl) this.Label43).Name = "Label43";
    ((ARControl) this.Label43).Size = new SizeF(83f / 16f, 0.125f);
    this.Label43.Text = "- MEDICAL EXPENSE LIMIT (ANY ONE PERSON)";
    ((ARControl) this.Label44).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label44).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label44).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label44).Border.TopStyle = (BorderLineStyle) 0;
    this.Label44.Font = new Font("Arial", 8f);
    this.Label44.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label44.HyperLink = (string) null;
    Label label44 = this.Label44;
    object obj37 = componentResourceManager.GetObject("Label44.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) label44).Location = pointF37;
    ((ARControl) this.Label44).Name = "Label44";
    ((ARControl) this.Label44).Size = new SizeF(0.125f, 0.125f);
    this.Label44.Text = "$";
    ((ARControl) this.Label45).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label45).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label45).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label45).Border.TopStyle = (BorderLineStyle) 0;
    this.Label45.Font = new Font("Arial", 8f);
    this.Label45.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label45.HyperLink = (string) null;
    Label label45 = this.Label45;
    object obj38 = componentResourceManager.GetObject("Label45.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) label45).Location = pointF38;
    ((ARControl) this.Label45).Name = "Label45";
    ((ARControl) this.Label45).Size = new SizeF(83f / 16f, 0.125f);
    this.Label45.Text = "- PRODUCTS / COMPLETED OPERATIONS AGGREGATE LIMIT";
    ((ARControl) this.Label46).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label46).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label46).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label46).Border.TopStyle = (BorderLineStyle) 0;
    this.Label46.Font = new Font("Arial", 8f);
    this.Label46.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label46.HyperLink = (string) null;
    Label label46 = this.Label46;
    object obj39 = componentResourceManager.GetObject("Label46.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) label46).Location = pointF39;
    ((ARControl) this.Label46).Name = "Label46";
    ((ARControl) this.Label46).Size = new SizeF(83f / 16f, 0.125f);
    this.Label46.Text = "- GENERAL AGGREGATE LIMIT";
    ((ARControl) this.Label47).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label47).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label47).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label47).Border.TopStyle = (BorderLineStyle) 0;
    this.Label47.Font = new Font("Arial", 8f);
    this.Label47.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label47.HyperLink = (string) null;
    Label label47 = this.Label47;
    object obj40 = componentResourceManager.GetObject("Label47.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) label47).Location = pointF40;
    ((ARControl) this.Label47).Name = "Label47";
    ((ARControl) this.Label47).Size = new SizeF(83f / 16f, 0.125f);
    this.Label47.Text = "- PERSONAL & ADVERTISING INJURY LIMIT";
    ((ARControl) this.Label49).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label49).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label49).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label49).Border.TopStyle = (BorderLineStyle) 0;
    this.Label49.Font = new Font("Arial", 8f);
    this.Label49.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label49.HyperLink = (string) null;
    Label label49 = this.Label49;
    object obj41 = componentResourceManager.GetObject("Label49.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) label49).Location = pointF41;
    ((ARControl) this.Label49).Name = "Label49";
    ((ARControl) this.Label49).Size = new SizeF(0.125f, 0.125f);
    this.Label49.Text = "$";
    ((ARControl) this.Label50).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label50).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label50).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label50).Border.TopStyle = (BorderLineStyle) 0;
    this.Label50.Font = new Font("Arial", 8f);
    this.Label50.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label50.HyperLink = (string) null;
    Label label50 = this.Label50;
    object obj42 = componentResourceManager.GetObject("Label50.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) label50).Location = pointF42;
    ((ARControl) this.Label50).Name = "Label50";
    ((ARControl) this.Label50).Size = new SizeF(0.125f, 0.125f);
    this.Label50.Text = "$";
    ((ARControl) this.Label51).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label51).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label51).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label51).Border.TopStyle = (BorderLineStyle) 0;
    this.Label51.Font = new Font("Arial", 8f);
    this.Label51.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label51.HyperLink = (string) null;
    Label label51 = this.Label51;
    object obj43 = componentResourceManager.GetObject("Label51.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) label51).Location = pointF43;
    ((ARControl) this.Label51).Name = "Label51";
    ((ARControl) this.Label51).Size = new SizeF(0.125f, 0.125f);
    this.Label51.Text = "$";
    ((ARControl) this.Label52).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label52).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label52).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label52).Border.TopStyle = (BorderLineStyle) 0;
    this.Label52.Font = new Font("Arial", 8f);
    this.Label52.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label52.HyperLink = (string) null;
    Label label52 = this.Label52;
    object obj44 = componentResourceManager.GetObject("Label52.Location");
    PointF pointF44 = obj44 != null ? (PointF) obj44 : new PointF();
    ((ARControl) label52).Location = pointF44;
    ((ARControl) this.Label52).Name = "Label52";
    ((ARControl) this.Label52).Size = new SizeF(83f / 16f, 0.125f);
    this.Label52.Text = "- FIRE DAMAGE LIMIT (ANY ONE FIRE)";
    ((ARControl) this.Label53).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label53).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label53).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label53).Border.TopStyle = (BorderLineStyle) 0;
    this.Label53.Font = new Font("Arial", 8f);
    this.Label53.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label53.HyperLink = (string) null;
    Label label53 = this.Label53;
    object obj45 = componentResourceManager.GetObject("Label53.Location");
    PointF pointF45 = obj45 != null ? (PointF) obj45 : new PointF();
    ((ARControl) label53).Location = pointF45;
    ((ARControl) this.Label53).Name = "Label53";
    ((ARControl) this.Label53).Size = new SizeF(83f / 16f, 0.125f);
    this.Label53.Text = "- EACH OCCURRENCE LIMIT";
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "LimitPCO";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj46 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF46 = obj46 != null ? (PointF) obj46 : new PointF();
    ((ARControl) textBox6).Location = pointF46;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox6.Text = " ";
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "LimitPAI";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj47 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF47 = obj47 != null ? (PointF) obj47 : new PointF();
    ((ARControl) textBox7).Location = pointF47;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox7).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox7.Text = " ";
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "LimitAgg";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj48 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF48 = obj48 != null ? (PointF) obj48 : new PointF();
    ((ARControl) textBox8).Location = pointF48;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox8.Text = " ";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "LimitOCC";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj49 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF49 = obj49 != null ? (PointF) obj49 : new PointF();
    ((ARControl) textBox9).Location = pointF49;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox9.Text = " ";
    this.TextBox10.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "LimitFDL";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj50 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF50 = obj50 != null ? (PointF) obj50 : new PointF();
    ((ARControl) textBox10).Location = pointF50;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox10).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox10.Text = " ";
    this.TextBox11.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "LimitMED";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj51 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF51 = obj51 != null ? (PointF) obj51 : new PointF();
    ((ARControl) textBox11).Location = pointF51;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox11).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox11.Text = " ";
    ((ARControl) this.Carrier1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier1).DataField = "Carrier";
    this.Carrier1.DistinctField = (string) null;
    this.Carrier1.Font = new Font("Arial", 8f);
    this.Carrier1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox carrier1 = this.Carrier1;
    object obj52 = componentResourceManager.GetObject("Carrier1.Location");
    PointF pointF52 = obj52 != null ? (PointF) obj52 : new PointF();
    ((ARControl) carrier1).Location = pointF52;
    ((ARControl) this.Carrier1).Name = "Carrier1";
    this.Carrier1.OutputFormat = (string) null;
    ((ARControl) this.Carrier1).Size = new SizeF(95f / 16f, 3f / 16f);
    ((ARControl) this.Carrier2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Carrier2).DataField = "TypeOfCoverage";
    this.Carrier2.DistinctField = (string) null;
    this.Carrier2.Font = new Font("Arial", 8f);
    this.Carrier2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox carrier2 = this.Carrier2;
    object obj53 = componentResourceManager.GetObject("Carrier2.Location");
    PointF pointF53 = obj53 != null ? (PointF) obj53 : new PointF();
    ((ARControl) carrier2).Location = pointF53;
    ((ARControl) this.Carrier2).Name = "Carrier2";
    this.Carrier2.OutputFormat = (string) null;
    ((ARControl) this.Carrier2).Size = new SizeF(95f / 16f, 3f / 16f);
    ((ARControl) this.Label54).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label54).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label54).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label54).Border.TopStyle = (BorderLineStyle) 0;
    this.Label54.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label54.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label54.HyperLink = (string) null;
    Label label54 = this.Label54;
    object obj54 = componentResourceManager.GetObject("Label54.Location");
    PointF pointF54 = obj54 != null ? (PointF) obj54 : new PointF();
    ((ARControl) label54).Location = pointF54;
    ((ARControl) this.Label54).Name = "Label54";
    ((ARControl) this.Label54).Size = new SizeF(25f / 16f, 0.25f);
    this.Label54.Text = "TERMS, CONDITIONS & EXCLUSIONS:";
    this.Label54.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox48).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).DataField = "TermsAndConditions";
    this.TextBox48.DistinctField = (string) null;
    this.TextBox48.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox48.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox48 = this.TextBox48;
    object obj55 = componentResourceManager.GetObject("TextBox48.Location");
    PointF pointF55 = obj55 != null ? (PointF) obj55 : new PointF();
    ((ARControl) textBox48).Location = pointF55;
    ((ARControl) this.TextBox48).Name = "TextBox48";
    this.TextBox48.OutputFormat = (string) null;
    ((ARControl) this.TextBox48).Size = new SizeF(99f / 16f, 0.25f);
    ((ARControl) this.lblDollar).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDollar.Font = new Font("Arial", 8f);
    this.lblDollar.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblDollar.HyperLink = (string) null;
    Label lblDollar = this.lblDollar;
    object obj56 = componentResourceManager.GetObject("lblDollar.Location");
    PointF pointF56 = obj56 != null ? (PointF) obj56 : new PointF();
    ((ARControl) lblDollar).Location = pointF56;
    ((ARControl) this.lblDollar).Name = "lblDollar";
    ((ARControl) this.lblDollar).Size = new SizeF(0.125f, 3f / 16f);
    this.lblDollar.Text = "$";
    this.txtAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).DataField = "Premium_LiabilityPremium";
    this.txtAmount.DistinctField = (string) null;
    this.txtAmount.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.txtAmount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAmount = this.txtAmount;
    object obj57 = componentResourceManager.GetObject("txtAmount.Location");
    PointF pointF57 = obj57 != null ? (PointF) obj57 : new PointF();
    ((ARControl) txtAmount).Location = pointF57;
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
    object obj58 = componentResourceManager.GetObject("txtCharge.Location");
    PointF pointF58 = obj58 != null ? (PointF) obj58 : new PointF();
    ((ARControl) txtCharge).Location = pointF58;
    ((ARControl) this.txtCharge).Name = "txtCharge";
    this.txtCharge.OutputFormat = (string) null;
    ((ARControl) this.txtCharge).Size = new SizeF(63f / 16f, 3f / 16f);
    this.txtCharge.Text = "Liability Premium";
    ((ARControl) this.Label56).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label56).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label56).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label56).Border.TopStyle = (BorderLineStyle) 0;
    this.Label56.Font = new Font("Arial", 8f);
    this.Label56.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label56.HyperLink = (string) null;
    Label label56 = this.Label56;
    object obj59 = componentResourceManager.GetObject("Label56.Location");
    PointF pointF59 = obj59 != null ? (PointF) obj59 : new PointF();
    ((ARControl) label56).Location = pointF59;
    ((ARControl) this.Label56).Name = "Label56";
    ((ARControl) this.Label56).Size = new SizeF(1f, 3f / 16f);
    this.Label56.Text = "PREMIUM:";
    ((ARControl) this.Label84).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label84).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label84).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label84).Border.TopStyle = (BorderLineStyle) 0;
    this.Label84.Font = new Font("Arial", 8f);
    this.Label84.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label84.HyperLink = (string) null;
    Label label84 = this.Label84;
    object obj60 = componentResourceManager.GetObject("Label84.Location");
    PointF pointF60 = obj60 != null ? (PointF) obj60 : new PointF();
    ((ARControl) label84).Location = pointF60;
    ((ARControl) this.Label84).Name = "Label84";
    ((ARControl) this.Label84).Size = new SizeF(0.125f, 3f / 16f);
    this.Label84.Text = "$";
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
    object obj61 = componentResourceManager.GetObject("Premium_LiabilityPremium1.Location");
    PointF pointF61 = obj61 != null ? (PointF) obj61 : new PointF();
    ((ARControl) liabilityPremium1).Location = pointF61;
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
    object obj62 = componentResourceManager.GetObject("TextBox51.Location");
    PointF pointF62 = obj62 != null ? (PointF) obj62 : new PointF();
    ((ARControl) textBox51).Location = pointF62;
    ((ARControl) this.TextBox51).Name = "TextBox51";
    this.TextBox51.OutputFormat = (string) null;
    ((ARControl) this.TextBox51).Size = new SizeF(63f / 16f, 3f / 16f);
    this.TextBox51.Text = "Terrorism Premium (Optional)";
    ((ARControl) this.Label85).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label85).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label85).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label85).Border.TopStyle = (BorderLineStyle) 1;
    this.Label85.Font = new Font("Arial", 8f);
    this.Label85.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label85.HyperLink = (string) null;
    Label label85 = this.Label85;
    object obj63 = componentResourceManager.GetObject("Label85.Location");
    PointF pointF63 = obj63 != null ? (PointF) obj63 : new PointF();
    ((ARControl) label85).Location = pointF63;
    ((ARControl) this.Label85).Name = "Label85";
    ((ARControl) this.Label85).Size = new SizeF(0.125f, 3f / 16f);
    this.Label85.Text = "$";
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
    object obj64 = componentResourceManager.GetObject("Premium_TerrorismPremium1.Location");
    PointF pointF64 = obj64 != null ? (PointF) obj64 : new PointF();
    ((ARControl) terrorismPremium1).Location = pointF64;
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
    object obj65 = componentResourceManager.GetObject("TextBox52.Location");
    PointF pointF65 = obj65 != null ? (PointF) obj65 : new PointF();
    ((ARControl) textBox52).Location = pointF65;
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
    object obj66 = componentResourceManager.GetObject("srPremiumsAndFees.Location");
    PointF pointF66 = obj66 != null ? (PointF) obj66 : new PointF();
    ((ARControl) srPremiumsAndFees).Location = pointF66;
    ((ARControl) this.srPremiumsAndFees).Name = "srPremiumsAndFees";
    this.srPremiumsAndFees.Report = (SectionReport) null;
    ((ARControl) this.srPremiumsAndFees).Size = new SizeF(5f, 1f / 16f);
    ((ARControl) this.Label86).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label86).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label86).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label86).Border.TopStyle = (BorderLineStyle) 1;
    this.Label86.Font = new Font("Arial", 8f);
    this.Label86.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label86.HyperLink = (string) null;
    Label label86 = this.Label86;
    object obj67 = componentResourceManager.GetObject("Label86.Location");
    PointF pointF67 = obj67 != null ? (PointF) obj67 : new PointF();
    ((ARControl) label86).Location = pointF67;
    ((ARControl) this.Label86).Name = "Label86";
    ((ARControl) this.Label86).Size = new SizeF(0.125f, 3f / 16f);
    this.Label86.Text = "$";
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
    object obj68 = componentResourceManager.GetObject("Premium_TotalPremium1.Location");
    PointF pointF68 = obj68 != null ? (PointF) obj68 : new PointF();
    ((ARControl) premiumTotalPremium1).Location = pointF68;
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
    object obj69 = componentResourceManager.GetObject("TextBox53.Location");
    PointF pointF69 = obj69 != null ? (PointF) obj69 : new PointF();
    ((ARControl) textBox53).Location = pointF69;
    ((ARControl) this.TextBox53).Name = "TextBox53";
    this.TextBox53.OutputFormat = (string) null;
    ((ARControl) this.TextBox53).Size = new SizeF(63f / 16f, 3f / 16f);
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
    object obj70 = componentResourceManager.GetObject("Label76.Location");
    PointF pointF70 = obj70 != null ? (PointF) obj70 : new PointF();
    ((ARControl) label76).Location = pointF70;
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
    object obj71 = componentResourceManager.GetObject("Label75.Location");
    PointF pointF71 = obj71 != null ? (PointF) obj71 : new PointF();
    ((ARControl) label75).Location = pointF71;
    ((ARControl) this.Label75).Name = "Label75";
    ((ARControl) this.Label75).Size = new SizeF(1.875f, 3f / 16f);
    this.Label75.Text = "UNDERWRITER'S APPROVAL:";
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox21.DistinctField = (string) null;
    this.TextBox21.Font = new Font("Arial", 8f);
    this.TextBox21.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox21 = this.TextBox21;
    object obj72 = componentResourceManager.GetObject("TextBox21.Location");
    PointF pointF72 = obj72 != null ? (PointF) obj72 : new PointF();
    ((ARControl) textBox21).Location = pointF72;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.OutputFormat = (string) null;
    ((ARControl) this.TextBox21).Size = new SizeF(4f, 3f / 16f);
    this.TextBox22.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox22.DistinctField = (string) null;
    this.TextBox22.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.TextBox22.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox22 = this.TextBox22;
    object obj73 = componentResourceManager.GetObject("TextBox22.Location");
    PointF pointF73 = obj73 != null ? (PointF) obj73 : new PointF();
    ((ARControl) textBox22).Location = pointF73;
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
    object obj74 = componentResourceManager.GetObject("Label78.Location");
    PointF pointF74 = obj74 != null ? (PointF) obj74 : new PointF();
    ((ARControl) label78).Location = pointF74;
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
    object obj75 = componentResourceManager.GetObject("CheckBox6.Location");
    PointF pointF75 = obj75 != null ? (PointF) obj75 : new PointF();
    ((ARControl) checkBox6).Location = pointF75;
    ((ARControl) this.CheckBox6).Name = "CheckBox6";
    ((ARControl) this.CheckBox6).Size = new SizeF(35f / 16f, 0.125f);
    this.CheckBox6.Text = "BIND WITH TERRORISM";
    ((ARControl) this.CheckBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox7).DataField = "BindWithoutTerrorism";
    this.CheckBox7.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.CheckBox7.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox7 = this.CheckBox7;
    object obj76 = componentResourceManager.GetObject("CheckBox7.Location");
    PointF pointF76 = obj76 != null ? (PointF) obj76 : new PointF();
    ((ARControl) checkBox7).Location = pointF76;
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
    object obj77 = componentResourceManager.GetObject("Label82.Location");
    PointF pointF77 = obj77 != null ? (PointF) obj77 : new PointF();
    ((ARControl) label82).Location = pointF77;
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
    object obj78 = componentResourceManager.GetObject("TextBox25.Location");
    PointF pointF78 = obj78 != null ? (PointF) obj78 : new PointF();
    ((ARControl) textBox25).Location = pointF78;
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
    object obj79 = componentResourceManager.GetObject("Label83.Location");
    PointF pointF79 = obj79 != null ? (PointF) obj79 : new PointF();
    ((ARControl) label83).Location = pointF79;
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
    object obj80 = componentResourceManager.GetObject("TextBox26.Location");
    PointF pointF80 = obj80 != null ? (PointF) obj80 : new PointF();
    ((ARControl) textBox26).Location = pointF80;
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
    this.Line3.Y1 = 27f / 16f;
    this.Line3.Y2 = 27f / 16f;
    ((ARControl) this.TextBox47).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox47).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).DataField = "PolicyEffectiveDate";
    this.TextBox47.DistinctField = (string) null;
    this.TextBox47.Font = new Font("Arial", 8f);
    this.TextBox47.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox47 = this.TextBox47;
    object obj81 = componentResourceManager.GetObject("TextBox47.Location");
    PointF pointF81 = obj81 != null ? (PointF) obj81 : new PointF();
    ((ARControl) textBox47).Location = pointF81;
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
    object obj82 = componentResourceManager.GetObject("TextBox50.Location");
    PointF pointF82 = obj82 != null ? (PointF) obj82 : new PointF();
    ((ARControl) textBox50).Location = pointF82;
    ((ARControl) this.TextBox50).Name = "TextBox50";
    this.TextBox50.OutputFormat = (string) null;
    ((ARControl) this.TextBox50).Size = new SizeF(7.75f, 0.375f);
    ((ARControl) this.Label57).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label57).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label57).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label57).Border.TopStyle = (BorderLineStyle) 0;
    this.Label57.Font = new Font("Arial", 8f);
    this.Label57.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label57.HyperLink = (string) null;
    Label label57 = this.Label57;
    object obj83 = componentResourceManager.GetObject("Label57.Location");
    PointF pointF83 = obj83 != null ? (PointF) obj83 : new PointF();
    ((ARControl) label57).Location = pointF83;
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
    object obj84 = componentResourceManager.GetObject("TextBox20.Location");
    PointF pointF84 = obj84 != null ? (PointF) obj84 : new PointF();
    ((ARControl) textBox20).Location = pointF84;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = (string) null;
    ((ARControl) this.TextBox20).Size = new SizeF(99f / 16f, 3f / 16f);
    this.TextBox20.Text = "TBD";
    ((ARControl) this.CheckBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox8).DataField = "BrokerIsResponsible";
    this.CheckBox8.Font = new Font("Arial", 8f);
    this.CheckBox8.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox8 = this.CheckBox8;
    object obj85 = componentResourceManager.GetObject("CheckBox8.Location");
    PointF pointF85 = obj85 != null ? (PointF) obj85 : new PointF();
    ((ARControl) checkBox8).Location = pointF85;
    ((ARControl) this.CheckBox8).Name = "CheckBox8";
    ((ARControl) this.CheckBox8).Size = new SizeF(7.75f, 3f / 16f);
    this.CheckBox8.Text = "Broker is Responsible for surplus lines filings and fees.";
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader3);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader7);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader5);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader6);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader4);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter4);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter6);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter5);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter7);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter3);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.TextBox31).EndInit();
    ((ISupportInitialize) this.TextBox32).EndInit();
    ((ISupportInitialize) this.InspectionContactPhone).EndInit();
    ((ISupportInitialize) this.txtCurrentCarrier).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.TextBox27).EndInit();
    ((ISupportInitialize) this.TextBox28).EndInit();
    ((ISupportInitialize) this.TextBox29).EndInit();
    ((ISupportInitialize) this.TextBox30).EndInit();
    ((ISupportInitialize) this.InsuredAddress).EndInit();
    ((ISupportInitialize) this.Label36).EndInit();
    ((ISupportInitialize) this.Label38).EndInit();
    ((ISupportInitialize) this.Label40).EndInit();
    ((ISupportInitialize) this.Label41).EndInit();
    ((ISupportInitialize) this.Label42).EndInit();
    ((ISupportInitialize) this.Label43).EndInit();
    ((ISupportInitialize) this.Label44).EndInit();
    ((ISupportInitialize) this.Label45).EndInit();
    ((ISupportInitialize) this.Label46).EndInit();
    ((ISupportInitialize) this.Label47).EndInit();
    ((ISupportInitialize) this.Label49).EndInit();
    ((ISupportInitialize) this.Label50).EndInit();
    ((ISupportInitialize) this.Label51).EndInit();
    ((ISupportInitialize) this.Label52).EndInit();
    ((ISupportInitialize) this.Label53).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.Carrier1).EndInit();
    ((ISupportInitialize) this.Carrier2).EndInit();
    ((ISupportInitialize) this.Label54).EndInit();
    ((ISupportInitialize) this.TextBox48).EndInit();
    ((ISupportInitialize) this.lblDollar).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtCharge).EndInit();
    ((ISupportInitialize) this.Label56).EndInit();
    ((ISupportInitialize) this.Label84).EndInit();
    ((ISupportInitialize) this.Premium_LiabilityPremium1).EndInit();
    ((ISupportInitialize) this.TextBox51).EndInit();
    ((ISupportInitialize) this.Label85).EndInit();
    ((ISupportInitialize) this.Premium_TerrorismPremium1).EndInit();
    ((ISupportInitialize) this.TextBox52).EndInit();
    ((ISupportInitialize) this.Label86).EndInit();
    ((ISupportInitialize) this.Premium_TotalPremium1).EndInit();
    ((ISupportInitialize) this.TextBox53).EndInit();
    ((ISupportInitialize) this.Label76).EndInit();
    ((ISupportInitialize) this.Label75).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
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
    ((ISupportInitialize) this.Label57).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.CheckBox8).EndInit();
  }

  public bool RequiresQuoteOptionGuids() => false;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
  }
}
