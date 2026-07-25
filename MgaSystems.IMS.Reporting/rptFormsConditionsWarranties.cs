// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptFormsConditionsWarranties
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
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{603E928A-1A3B-4bbf-9156-CE967F655ACC}", Enums.AutomationDocGroups.PolicyDoc, "Forms/Conditions/Warranties", "Displays forms, conditions and warranties.")]
public class rptFormsConditionsWarranties : SectionReport, IQuoteDocument
{
  private Label Label91;
  private Label Label92;
  private Label Label93;
  private TextBox Forms;
  private TextBox Conditions;
  private TextBox Warranties;
  private Guid _QuoteGuid;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptFormsConditionsWarranties()
  {
    this.ReportStart += new EventHandler(this.rptFormsConditionsWarranties_ReportStart);
    this.InitializeComponent();
  }

  public rptFormsConditionsWarranties(Guid quoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptFormsConditionsWarranties_ReportStart);
    this.InitializeComponent();
    this._QuoteGuid = quoteGuid;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptFormsConditionsWarranties));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.Label91 = new Label();
    this.Label92 = new Label();
    this.Label93 = new Label();
    this.Forms = new TextBox();
    this.Conditions = new TextBox();
    this.Warranties = new TextBox();
    ((ISupportInitialize) this.Label91).BeginInit();
    ((ISupportInitialize) this.Label92).BeginInit();
    ((ISupportInitialize) this.Label93).BeginInit();
    ((ISupportInitialize) this.Forms).BeginInit();
    ((ISupportInitialize) this.Conditions).BeginInit();
    ((ISupportInitialize) this.Warranties).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Forms,
      (ARControl) this.Conditions,
      (ARControl) this.Warranties
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1451389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label91,
      (ARControl) this.Label92,
      (ARControl) this.Label93
    });
    this.ReportHeader.Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.Label91.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label91).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label91).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label91).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label91).Border.TopStyle = (BorderLineStyle) 0;
    this.Label91.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label91.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label91.HyperLink = (string) null;
    Label label91 = this.Label91;
    object obj1 = componentResourceManager.GetObject("Label91.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label91).Location = pointF1;
    ((ARControl) this.Label91).Name = "Label91";
    ((ARControl) this.Label91).Size = new SizeF(2.625f, 3f / 16f);
    this.Label91.Text = "Forms";
    this.Label92.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label92).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label92).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label92).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label92).Border.TopStyle = (BorderLineStyle) 0;
    this.Label92.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label92.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label92.HyperLink = (string) null;
    Label label92 = this.Label92;
    object obj2 = componentResourceManager.GetObject("Label92.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label92).Location = pointF2;
    ((ARControl) this.Label92).Name = "Label92";
    ((ARControl) this.Label92).Size = new SizeF(2.625f, 3f / 16f);
    this.Label92.Text = "Conditions";
    this.Label93.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label93).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label93).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label93).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label93).Border.TopStyle = (BorderLineStyle) 0;
    this.Label93.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label93.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label93.HyperLink = (string) null;
    Label label93 = this.Label93;
    object obj3 = componentResourceManager.GetObject("Label93.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label93).Location = pointF3;
    ((ARControl) this.Label93).Name = "Label93";
    ((ARControl) this.Label93).Size = new SizeF(2.625f, 3f / 16f);
    this.Label93.Text = "Warranties";
    ((ARControl) this.Forms).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Forms).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Forms).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Forms).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Forms).DataField = "Forms";
    this.Forms.DistinctField = (string) null;
    this.Forms.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Forms.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox forms = this.Forms;
    object obj4 = componentResourceManager.GetObject("Forms.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) forms).Location = pointF4;
    ((ARControl) this.Forms).Name = "Forms";
    this.Forms.OutputFormat = (string) null;
    ((ARControl) this.Forms).Size = new SizeF(2.625f, 3f / 16f);
    ((ARControl) this.Conditions).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Conditions).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Conditions).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Conditions).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Conditions).DataField = "Conditions";
    this.Conditions.DistinctField = (string) null;
    this.Conditions.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Conditions.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox conditions = this.Conditions;
    object obj5 = componentResourceManager.GetObject("Conditions.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) conditions).Location = pointF5;
    ((ARControl) this.Conditions).Name = "Conditions";
    this.Conditions.OutputFormat = (string) null;
    ((ARControl) this.Conditions).Size = new SizeF(2.625f, 3f / 16f);
    ((ARControl) this.Warranties).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Warranties).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Warranties).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Warranties).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Warranties).DataField = "Warranties";
    this.Warranties.DistinctField = (string) null;
    this.Warranties.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Warranties.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox warranties = this.Warranties;
    object obj6 = componentResourceManager.GetObject("Warranties.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) warranties).Location = pointF6;
    ((ARControl) this.Warranties).Name = "Warranties";
    this.Warranties.OutputFormat = (string) null;
    ((ARControl) this.Warranties).Size = new SizeF(2.625f, 3f / 16f);
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label91).EndInit();
    ((ISupportInitialize) this.Label92).EndInit();
    ((ISupportInitialize) this.Label93).EndInit();
    ((ISupportInitialize) this.Forms).EndInit();
    ((ISupportInitialize) this.Conditions).EndInit();
    ((ISupportInitialize) this.Warranties).EndInit();
  }

  public bool RequiresQuoteOptionGuids() => false;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
  }

  private void rptFormsConditionsWarranties_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable(nameof (rptFormsConditionsWarranties), new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._QuoteGuid
    });
  }
}
