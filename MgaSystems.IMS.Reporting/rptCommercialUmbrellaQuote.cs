// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCommercialUmbrellaQuote
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

[AutomationReport("{DE9E6679-24BF-4cd0-B3C6-10E0DC4A52C9}", Enums.AutomationDocGroups.PolicyDoc, "IMS Commercial Umbrella Quote", "IMS quote document for commercial umbrella.")]
public class rptCommercialUmbrellaQuote : SectionReport, IQuoteDocument
{
  private Guid _QuoteOptionGuid;
  private rptCommonFooter1 _FooterReport;
  private rptCommonHeader1 _HeaderReport;
  private SubReport srHeader;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private TextBox TextBox14;
  private TextBox TextBox15;
  private TextBox TextBox16;
  private TextBox TextBox17;
  private SubReport srFooter;

  public rptCommercialUmbrellaQuote()
  {
    this.ReportStart += new EventHandler(this.rptCommercialUmbrellaQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  public rptCommercialUmbrellaQuote(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptCommercialUmbrellaQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCommercialUmbrellaQuote));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.srHeader = new SubReport();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox14 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    this.srFooter = new SubReport();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[17]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17
    });
    ((Section) this.Detail).Height = 1.375f;
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
    this.Label2.Text = "Schedule of Underlying:";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj3 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label3).Location = pointF3;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(1.875f, 3f / 16f);
    this.Label3.Text = "Limits of Insurance:";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj4 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label4).Location = pointF4;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1.875f, 3f / 16f);
    this.Label4.Text = "Insuring Agreements:";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj5 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label5).Location = pointF5;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1.875f, 3f / 16f);
    this.Label5.Text = "Self Insured Retention:";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj6 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label6).Location = pointF6;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(1.875f, 3f / 16f);
    this.Label6.Text = "Exposure Basis:";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj7 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label7).Location = pointF7;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(1.625f, 3f / 16f);
    this.Label7.Text = "Number of Units:";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 10f);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj8 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label8).Location = pointF8;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(1.625f, 3f / 16f);
    this.Label8.Text = "Commercial Square Feet:";
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 10f);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj9 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label9).Location = pointF9;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label9.Text = "Locations Covered:";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 10f);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj10 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label10).Location = pointF10;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label10.Text = "Number of Vehicles:";
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "ScheduleOfUnderlying";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 11f);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj11 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox10).Location = pointF11;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = (string) null;
    ((ARControl) this.TextBox10).Size = new SizeF(6f, 3f / 16f);
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "LimitsOfInsurance";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 11f);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj12 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox11).Location = pointF12;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = (string) null;
    ((ARControl) this.TextBox11).Size = new SizeF(6f, 3f / 16f);
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "InsuringAgreements";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 11f);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj13 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox12).Location = pointF13;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = (string) null;
    ((ARControl) this.TextBox12).Size = new SizeF(6f, 3f / 16f);
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "SelfInsuredRetention";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 11f);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj14 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox13).Location = pointF14;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = (string) null;
    ((ARControl) this.TextBox13).Size = new SizeF(6f, 3f / 16f);
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).DataField = "Exposure_NumberOfUnits";
    this.TextBox14.DistinctField = (string) null;
    this.TextBox14.Font = new Font("Arial", 10f);
    this.TextBox14.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox14 = this.TextBox14;
    object obj15 = componentResourceManager.GetObject("TextBox14.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox14).Location = pointF15;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = (string) null;
    ((ARControl) this.TextBox14).Size = new SizeF(1f, 3f / 16f);
    this.TextBox14.Text = " ";
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).DataField = "Exposure_CommercialSquareFeet";
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 10f);
    this.TextBox15.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox15 = this.TextBox15;
    object obj16 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox15).Location = pointF16;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = (string) null;
    ((ARControl) this.TextBox15).Size = new SizeF(1f, 3f / 16f);
    this.TextBox15.Text = " ";
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "Exposure_LocationsCovered";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 10f);
    this.TextBox16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox16 = this.TextBox16;
    object obj17 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox16).Location = pointF17;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = (string) null;
    ((ARControl) this.TextBox16).Size = new SizeF(1f, 3f / 16f);
    this.TextBox16.Text = " ";
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).DataField = "Exposure_NumberOfVehicles";
    this.TextBox17.DistinctField = (string) null;
    this.TextBox17.Font = new Font("Arial", 10f);
    this.TextBox17.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox17 = this.TextBox17;
    object obj18 = componentResourceManager.GetObject("TextBox17.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox17).Location = pointF18;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = (string) null;
    ((ARControl) this.TextBox17).Size = new SizeF(1f, 3f / 16f);
    this.TextBox17.Text = " ";
    ((ARControl) this.srFooter).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.TopStyle = (BorderLineStyle) 0;
    this.srFooter.CloseBorder = false;
    SubReport srFooter = this.srFooter;
    object obj19 = componentResourceManager.GetObject("srFooter.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) srFooter).Location = pointF19;
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
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
  }

  private void rptCommercialUmbrellaQuote_ReportStart(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.rptCommercialUmbrellaQuote", new object[2]
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

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
