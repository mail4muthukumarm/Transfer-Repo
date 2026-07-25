// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptPropertyBreakdown
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptPropertyBreakdown : SectionReport
{
  private Label Label85;
  private Label Label86;
  private Label Label88;
  private Label Label90;
  private Label Label91;
  private Label Label87;
  private TextBox TextBox35;
  private TextBox TextBox34;
  private TextBox TextBox33;
  private TextBox TextBox32;
  private TextBox TextBox31;
  private Label Label95;
  private TextBox TextBox36;

  public rptPropertyBreakdown(DataTable PropertyBreakdown)
  {
    this.InitializeComponent();
    if (PropertyBreakdown.Rows.Count == 0)
    {
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Visible = false;
      this.GroupHeader1.Height = 0.0f;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Visible = false;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.0f;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Visible = false;
      this.GroupFooter1.Height = 0.0f;
    }
    else
      this.DataSource = (object) PropertyBreakdown;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPropertyBreakdown));
    this.Detail = new Detail();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label85 = new Label();
    this.Label86 = new Label();
    this.Label88 = new Label();
    this.Label90 = new Label();
    this.Label91 = new Label();
    this.Label87 = new Label();
    this.TextBox35 = new TextBox();
    this.TextBox34 = new TextBox();
    this.TextBox33 = new TextBox();
    this.TextBox32 = new TextBox();
    this.TextBox31 = new TextBox();
    this.Label95 = new Label();
    this.TextBox36 = new TextBox();
    ((ISupportInitialize) this.Label85).BeginInit();
    ((ISupportInitialize) this.Label86).BeginInit();
    ((ISupportInitialize) this.Label88).BeginInit();
    ((ISupportInitialize) this.Label90).BeginInit();
    ((ISupportInitialize) this.Label91).BeginInit();
    ((ISupportInitialize) this.Label87).BeginInit();
    ((ISupportInitialize) this.TextBox35).BeginInit();
    ((ISupportInitialize) this.TextBox34).BeginInit();
    ((ISupportInitialize) this.TextBox33).BeginInit();
    ((ISupportInitialize) this.TextBox32).BeginInit();
    ((ISupportInitialize) this.TextBox31).BeginInit();
    ((ISupportInitialize) this.Label95).BeginInit();
    ((ISupportInitialize) this.TextBox36).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.TextBox35,
      (ARControl) this.TextBox34,
      (ARControl) this.TextBox33,
      (ARControl) this.TextBox32,
      (ARControl) this.TextBox31,
      (ARControl) this.Label95,
      (ARControl) this.TextBox36
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label85,
      (ARControl) this.Label86,
      (ARControl) this.Label88,
      (ARControl) this.Label90,
      (ARControl) this.Label91,
      (ARControl) this.Label87
    });
    this.GroupHeader1.Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label85).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label85).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label85).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label85).Border.TopStyle = (BorderLineStyle) 0;
    this.Label85.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label85.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label85.HyperLink = (string) null;
    Label label85 = this.Label85;
    object obj1 = componentResourceManager.GetObject("Label85.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label85).Location = pointF1;
    ((ARControl) this.Label85).Name = "Label85";
    ((ARControl) this.Label85).Size = new SizeF(35f / 16f, 3f / 16f);
    this.Label85.Text = "PROPERTY";
    this.Label86.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label86).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label86).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label86).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label86).Border.TopStyle = (BorderLineStyle) 0;
    this.Label86.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label86.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label86.HyperLink = (string) null;
    Label label86 = this.Label86;
    object obj2 = componentResourceManager.GetObject("Label86.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label86).Location = pointF2;
    ((ARControl) this.Label86).Name = "Label86";
    ((ARControl) this.Label86).Size = new SizeF(1f, 3f / 16f);
    this.Label86.Text = "LIMIT";
    this.Label88.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label88).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label88).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label88).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label88).Border.TopStyle = (BorderLineStyle) 0;
    this.Label88.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label88.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label88.HyperLink = (string) null;
    Label label88 = this.Label88;
    object obj3 = componentResourceManager.GetObject("Label88.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label88).Location = pointF3;
    ((ARControl) this.Label88).Name = "Label88";
    ((ARControl) this.Label88).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label88.Text = "VALUATION";
    this.Label90.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label90).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label90).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label90).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label90).Border.TopStyle = (BorderLineStyle) 0;
    this.Label90.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label90.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label90.HyperLink = (string) null;
    Label label90 = this.Label90;
    object obj4 = componentResourceManager.GetObject("Label90.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label90).Location = pointF4;
    ((ARControl) this.Label90).Name = "Label90";
    ((ARControl) this.Label90).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label90.Text = "CAUSE OF LOSS";
    this.Label91.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label91).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label91).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label91).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label91).Border.TopStyle = (BorderLineStyle) 0;
    this.Label91.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label91.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label91.HyperLink = (string) null;
    Label label91 = this.Label91;
    object obj5 = componentResourceManager.GetObject("Label91.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label91).Location = pointF5;
    ((ARControl) this.Label91).Name = "Label91";
    ((ARControl) this.Label91).Size = new SizeF(1f, 3f / 16f);
    this.Label91.Text = "DEDUCTIBLE";
    this.Label87.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label87).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label87).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label87).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label87).Border.TopStyle = (BorderLineStyle) 0;
    this.Label87.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label87.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label87.HyperLink = (string) null;
    Label label87 = this.Label87;
    object obj6 = componentResourceManager.GetObject("Label87.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label87).Location = pointF6;
    ((ARControl) this.Label87).Name = "Label87";
    ((ARControl) this.Label87).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label87.Text = "CO-INS";
    this.TextBox35.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox35).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox35).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox35).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox35).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox35).DataField = "Deductible";
    this.TextBox35.DistinctField = (string) null;
    this.TextBox35.Font = new Font("Arial", 8f);
    this.TextBox35.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox35 = this.TextBox35;
    object obj7 = componentResourceManager.GetObject("TextBox35.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox35).Location = pointF7;
    ((ARControl) this.TextBox35).Name = "TextBox35";
    this.TextBox35.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox35).Size = new SizeF(1f, 3f / 16f);
    this.TextBox35.Text = " ";
    this.TextBox34.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox34).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox34).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox34).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox34).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox34).DataField = "Peril";
    this.TextBox34.DistinctField = (string) null;
    this.TextBox34.Font = new Font("Arial", 8f);
    this.TextBox34.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox34 = this.TextBox34;
    object obj8 = componentResourceManager.GetObject("TextBox34.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox34).Location = pointF8;
    ((ARControl) this.TextBox34).Name = "TextBox34";
    this.TextBox34.OutputFormat = (string) null;
    ((ARControl) this.TextBox34).Size = new SizeF(23f / 16f, 3f / 16f);
    this.TextBox34.Text = " ";
    this.TextBox33.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox33).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).DataField = "Valuation";
    this.TextBox33.DistinctField = (string) null;
    this.TextBox33.Font = new Font("Arial", 8f);
    this.TextBox33.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox33 = this.TextBox33;
    object obj9 = componentResourceManager.GetObject("TextBox33.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox33).Location = pointF9;
    ((ARControl) this.TextBox33).Name = "TextBox33";
    this.TextBox33.OutputFormat = (string) null;
    ((ARControl) this.TextBox33).Size = new SizeF(21f / 16f, 3f / 16f);
    this.TextBox33.Text = " ";
    this.TextBox32.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox32).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).DataField = "CoIns";
    this.TextBox32.DistinctField = (string) null;
    this.TextBox32.Font = new Font("Arial", 8f);
    this.TextBox32.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox32 = this.TextBox32;
    object obj10 = componentResourceManager.GetObject("TextBox32.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox32).Location = pointF10;
    ((ARControl) this.TextBox32).Name = "TextBox32";
    this.TextBox32.OutputFormat = (string) null;
    ((ARControl) this.TextBox32).Size = new SizeF(15f / 16f, 3f / 16f);
    this.TextBox32.Text = " ";
    this.TextBox31.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox31).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).DataField = "Limit";
    this.TextBox31.DistinctField = (string) null;
    this.TextBox31.Font = new Font("Arial", 8f);
    this.TextBox31.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox31 = this.TextBox31;
    object obj11 = componentResourceManager.GetObject("TextBox31.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox31).Location = pointF11;
    ((ARControl) this.TextBox31).Name = "TextBox31";
    this.TextBox31.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox31).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox31.Text = " ";
    ((ARControl) this.Label95).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label95).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label95).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label95).Border.TopStyle = (BorderLineStyle) 0;
    this.Label95.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label95.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label95.HyperLink = (string) null;
    Label label95 = this.Label95;
    object obj12 = componentResourceManager.GetObject("Label95.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label95).Location = pointF12;
    ((ARControl) this.Label95).Name = "Label95";
    ((ARControl) this.Label95).Size = new SizeF(0.125f, 3f / 16f);
    this.Label95.Text = "$";
    ((ARControl) this.TextBox36).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox36).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox36).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox36).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox36).DataField = "Coverage";
    this.TextBox36.DistinctField = (string) null;
    this.TextBox36.Font = new Font("Arial", 8f);
    this.TextBox36.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox36 = this.TextBox36;
    object obj13 = componentResourceManager.GetObject("TextBox36.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox36).Location = pointF13;
    ((ARControl) this.TextBox36).Name = "TextBox36";
    this.TextBox36.OutputFormat = (string) null;
    ((ARControl) this.TextBox36).Size = new SizeF(35f / 16f, 3f / 16f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    ((ISupportInitialize) this.Label85).EndInit();
    ((ISupportInitialize) this.Label86).EndInit();
    ((ISupportInitialize) this.Label88).EndInit();
    ((ISupportInitialize) this.Label90).EndInit();
    ((ISupportInitialize) this.Label91).EndInit();
    ((ISupportInitialize) this.Label87).EndInit();
    ((ISupportInitialize) this.TextBox35).EndInit();
    ((ISupportInitialize) this.TextBox34).EndInit();
    ((ISupportInitialize) this.TextBox33).EndInit();
    ((ISupportInitialize) this.TextBox32).EndInit();
    ((ISupportInitialize) this.TextBox31).EndInit();
    ((ISupportInitialize) this.Label95).EndInit();
    ((ISupportInitialize) this.TextBox36).EndInit();
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
