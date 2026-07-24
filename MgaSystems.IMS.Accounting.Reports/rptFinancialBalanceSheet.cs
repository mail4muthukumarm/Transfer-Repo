// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptFinancialBalanceSheet
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptFinancialBalanceSheet : SectionReport
{
  private Detail Detail;
  private PageHeader PageHeader;
  private PageFooter PageFooter;

  public rptFinancialBalanceSheet() => this.InitializeComponent();

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptFinancialBalanceSheet));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.Detail).Name = "Detail";
    ((Section) this.PageHeader).Name = "PageHeader";
    ((Section) this.PageFooter).Name = "PageFooter";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule(componentResourceManager.GetString("$this.StyleSheet"), "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-weight: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
    ((ISupportInitialize) this).EndInit();
  }
}
