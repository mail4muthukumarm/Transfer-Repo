// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.BalanceSheet
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class BalanceSheet : SectionReport
{
  private Label Label1;
  private SubReport subAssets;
  private Label Label2;
  private SubReport subLiabilityEquity;
  private PageBreak PageBreak1;

  public BalanceSheet() => this.InitializeComponent();

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BalanceSheet));
    this.Detail = new Detail();
    this.Label1 = new Label();
    this.subAssets = new SubReport();
    this.Label2 = new Label();
    this.subLiabilityEquity = new SubReport();
    this.PageBreak1 = new PageBreak();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label1,
      (ARControl) this.subAssets,
      (ARControl) this.Label2,
      (ARControl) this.subLiabilityEquity,
      (ARControl) this.PageBreak1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 1.040972f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(8.125f, 0.2f);
    this.Label1.Text = "ASSETS";
    ((ARControl) this.subAssets).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.subAssets).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.subAssets).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.subAssets).Border.TopStyle = (BorderLineStyle) 0;
    this.subAssets.CloseBorder = false;
    SubReport subAssets = this.subAssets;
    object obj2 = componentResourceManager.GetObject("subAssets.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) subAssets).Location = pointF2;
    ((ARControl) this.subAssets).Name = "subAssets";
    this.subAssets.Report = (SectionReport) null;
    ((ARControl) this.subAssets).Size = new SizeF(8.125f, 3f / 16f);
    this.Label2.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj3 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label2).Location = pointF3;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(8.125f, 0.2f);
    this.Label2.Text = "LIABILITIES AND EQUITY";
    ((ARControl) this.subLiabilityEquity).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.subLiabilityEquity).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.subLiabilityEquity).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.subLiabilityEquity).Border.TopStyle = (BorderLineStyle) 0;
    this.subLiabilityEquity.CloseBorder = false;
    SubReport subLiabilityEquity = this.subLiabilityEquity;
    object obj4 = componentResourceManager.GetObject("subLiabilityEquity.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) subLiabilityEquity).Location = pointF4;
    ((ARControl) this.subLiabilityEquity).Name = "subLiabilityEquity";
    this.subLiabilityEquity.Report = (SectionReport) null;
    ((ARControl) this.subLiabilityEquity).Size = new SizeF(8.125f, 3f / 16f);
    this.PageBreak1.Border.BottomStyle = (BorderLineStyle) 0;
    this.PageBreak1.Border.LeftStyle = (BorderLineStyle) 0;
    this.PageBreak1.Border.RightStyle = (BorderLineStyle) 0;
    this.PageBreak1.Border.TopStyle = (BorderLineStyle) 0;
    PageBreak pageBreak1 = this.PageBreak1;
    object obj5 = componentResourceManager.GetObject("PageBreak1.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    pageBreak1.Location = pointF5;
    ((ARControl) this.PageBreak1).Name = "PageBreak1";
    this.PageBreak1.Size = new SizeF(10f, 0.05555556f);
    this.PageHeader.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 263f / 32f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
