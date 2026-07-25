// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptDifferenceInConditionsQuote
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
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

[AutomationReport("{4E8B58DA-71DC-4d06-8430-F582C7AC16F0}", Enums.AutomationDocGroups.PolicyDoc, "IMS Difference In Conditions Quote", "IMS quote document for difference in conditions.")]
public class rptDifferenceInConditionsQuote : SectionReport, IQuoteDocument
{
  private SubReport srHeader;
  private Label Label2;
  private TextBox TextBox10;
  private Label Label1;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private Label Label;
  private TextBox TextBox;
  private SubReport srFooter;
  private Guid _QuoteOptionGuid;
  private rptCommonFooter1 _FooterReport;
  private rptCommonHeader1 _HeaderReport;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptDifferenceInConditionsQuote()
  {
    this.ReportStart += new EventHandler(this.rptDifferenceInConditionsQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  public rptDifferenceInConditionsQuote(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptDifferenceInConditionsQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptDifferenceInConditionsQuote));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.srHeader = new SubReport();
    this.Label2 = new Label();
    this.TextBox10 = new TextBox();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.Label = new Label();
    this.TextBox = new TextBox();
    this.srFooter = new SubReport();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.Label2,
      (ARControl) this.TextBox10,
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.Label,
      (ARControl) this.TextBox
    });
    ((Section) this.Detail).Height = 1.770833f;
    ((Section) this.Detail).Name = "Detail";
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srHeader
    });
    this.ReportHeader.Height = 0.05138889f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((Section) this.ReportFooter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srFooter
    });
    this.ReportFooter.Height = 0.04166667f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.srHeader).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srHeader).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srHeader).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srHeader).Border.TopStyle = (BorderLineStyle) 0;
    this.srHeader.CloseBorder = false;
    SubReport srHeader = this.srHeader;
    object obj1 = componentResourceManager.GetObject("srHeader.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) srHeader).Location = pointF1;
    ((ARControl) this.srHeader).Name = "srHeader";
    this.srHeader.Report = (SectionReport) null;
    ((ARControl) this.srHeader).Size = new SizeF(7.875f, 1f / 16f);
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj2 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label2).Location = pointF2;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.875f, 3f / 16f);
    this.Label2.Text = "Covered Location(s):";
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "CoveredLocations";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 11f);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj3 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox10).Location = pointF3;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = (string) null;
    ((ARControl) this.TextBox10).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj4 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label1).Location = pointF4;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1.875f, 3f / 16f);
    this.Label1.Text = "Limits of Liability:";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj5 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label3).Location = pointF5;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(1.875f, 3f / 16f);
    this.Label3.Text = "Property Covered:";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj6 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label4).Location = pointF6;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1.875f, 3f / 16f);
    this.Label4.Text = "Perils Insured:";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj7 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label5).Location = pointF7;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1.875f, 3f / 16f);
    this.Label5.Text = "Deductibles:";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "LimitsOfLiabilityText";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 11f);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj8 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox1).Location = pointF8;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(4.875f, 3f / 16f);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "PropertyCovered";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 11f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj9 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox2).Location = pointF9;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "PerilsInsured";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 11f);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj10 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox3).Location = pointF10;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Deductibles";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 11f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj11 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox4).Location = pointF11;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(6f, 7f / 16f);
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 11f);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj12 = componentResourceManager.GetObject("Label.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label).Location = pointF12;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(0.125f, 3f / 16f);
    this.Label.Text = "$";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "LimitsOfLiability";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 11f);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj13 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox).Location = pointF13;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(1f, 3f / 16f);
    ((ARControl) this.srFooter).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.TopStyle = (BorderLineStyle) 0;
    this.srFooter.CloseBorder = false;
    SubReport srFooter = this.srFooter;
    object obj14 = componentResourceManager.GetObject("srFooter.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) srFooter).Location = pointF14;
    ((ARControl) this.srFooter).Name = "srFooter";
    this.srFooter.Report = (SectionReport) null;
    ((ARControl) this.srFooter).Size = new SizeF(7.875f, 1f / 16f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.ReportFooter);
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
  }

  private void rptDifferenceInConditionsQuote_ReportStart(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(nameof (rptDifferenceInConditionsQuote), new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) this._QuoteOptionGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    this.DataSource = (object) dataTable;
    this._HeaderReport = new rptCommonHeader1(this._QuoteOptionGuid, true);
    this.srHeader.Report = (SectionReport) this._HeaderReport;
    this._FooterReport = new rptCommonFooter1(this._QuoteOptionGuid, true);
    this.srFooter.Report = (SectionReport) this._FooterReport;
  }

  private void rptPropertyQuote_ReportEnd(object sender, EventArgs e)
  {
    if (this._FooterReport != null)
      this._FooterReport.Dispose();
    if (this._HeaderReport == null)
      return;
    this._HeaderReport.Dispose();
  }

  public bool RequiresQuoteOptionGuids() => true;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    this._QuoteOptionGuid = quoteOptionGuids[0];
  }
}
