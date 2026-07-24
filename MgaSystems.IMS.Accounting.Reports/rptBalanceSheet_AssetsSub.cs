// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptBalanceSheet_AssetsSub
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

public sealed class rptBalanceSheet_AssetsSub : SectionReport
{
  private DataView dv;
  private Label Label1;
  private TextBox txtAmount;
  private TextBox txtAccountName;
  private TextBox txtAmountSum;
  private Label Label2;

  private rptBalanceSheet_AssetsSub() => this.InitializeComponent();

  public rptBalanceSheet_AssetsSub(DataView balanceSheetAssetsData)
  {
    this.InitializeComponent();
    this.dv = balanceSheetAssetsData;
    this.DataSource = (object) this.dv;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptBalanceSheet_AssetsSub));
    this.Detail = new Detail();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label1 = new Label();
    this.txtAmount = new TextBox();
    this.txtAccountName = new TextBox();
    this.txtAmountSum = new TextBox();
    this.Label2 = new Label();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtAccountName).BeginInit();
    ((ISupportInitialize) this.txtAmountSum).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtAmount,
      (ARControl) this.txtAccountName
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.2076389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label1
    });
    this.GroupHeader1.Height = 0.2076389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtAmountSum,
      (ARControl) this.Label2
    });
    this.GroupFooter1.Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(3f, 0.2f);
    this.Label1.Text = "Assets";
    this.txtAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).DataField = "amount";
    this.txtAmount.DistinctField = (string) null;
    this.txtAmount.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAmount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAmount = this.txtAmount;
    object obj2 = componentResourceManager.GetObject("txtAmount.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtAmount).Location = pointF2;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtAmount).Size = new SizeF(1.5f, 0.2f);
    ((ARControl) this.txtAccountName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAccountName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAccountName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAccountName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAccountName).DataField = "fullname";
    this.txtAccountName.DistinctField = (string) null;
    this.txtAccountName.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAccountName.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAccountName = this.txtAccountName;
    object obj3 = componentResourceManager.GetObject("txtAccountName.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtAccountName).Location = pointF3;
    ((ARControl) this.txtAccountName).Name = "txtAccountName";
    this.txtAccountName.OutputFormat = (string) null;
    ((ARControl) this.txtAccountName).Size = new SizeF(23f / 16f, 0.2f);
    this.txtAmountSum.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAmountSum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmountSum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmountSum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmountSum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmountSum).DataField = "amount";
    this.txtAmountSum.DistinctField = (string) null;
    this.txtAmountSum.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtAmountSum.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAmountSum = this.txtAmountSum;
    object obj4 = componentResourceManager.GetObject("txtAmountSum.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) txtAmountSum).Location = pointF4;
    ((ARControl) this.txtAmountSum).Name = "txtAmountSum";
    this.txtAmountSum.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtAmountSum).Size = new SizeF(1.75f, 0.2f);
    this.txtAmountSum.SummaryGroup = "GroupHeader1";
    this.txtAmountSum.SummaryRunning = (SummaryRunning) 2;
    this.txtAmountSum.SummaryType = (SummaryType) 1;
    this.Label2.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj5 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label2).Location = pointF5;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.25f, 3f / 16f);
    this.Label2.Text = "Total Assets:";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 3.052083f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtAccountName).EndInit();
    ((ISupportInitialize) this.txtAmountSum).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
