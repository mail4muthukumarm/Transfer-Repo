// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Financial_Reports.Trial_Balances.rptTrialBalance
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Financial_Reports.Trial_Balances;

public class rptTrialBalance : SectionReport
{
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;

  public rptTrialBalance() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptTrialBalance));
    this.pageHeader = new PageHeader();
    this.detail = new Detail();
    this.pageFooter = new PageFooter();
    ((ISupportInitialize) this).BeginInit();
    this.pageHeader.Height = 0.4791667f;
    ((Section) this.pageHeader).Name = "pageHeader";
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Height = 2f;
    ((Section) this.detail).Name = "detail";
    this.pageFooter.Height = 0.25f;
    ((Section) this.pageFooter).Name = "pageFooter";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.989583f;
    this.Sections.Add((Section) this.pageHeader);
    this.Sections.Add((Section) this.detail);
    this.Sections.Add((Section) this.pageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this).EndInit();
  }
}
