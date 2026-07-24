// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptReturnPremiumCommissionAutomation
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[DesignerGenerated]
public class rptReturnPremiumCommissionAutomation : SectionReport
{
  private IContainer components;
  private string _entityGuids;
  private int _glCompanyId;
  private DateTime _asOfDate;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptReturnPremiumCommissionAutomation));
    this.PageHeader1 = new PageHeader();
    this.txtCompanyInfo = new TextBox();
    this.TextBox7 = new TextBox();
    this.Detail1 = new Detail();
    this.txtInsuredName = new TextBox();
    this.txtPolicyNumber = new TextBox();
    this.TextBox1 = new TextBox();
    this.txtCommissionPercent = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox4 = new TextBox();
    this.PageFooter1 = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label10 = new Label();
    this.TextBox8 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox11 = new TextBox();
    this.Label3 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label4 = new Label();
    this.Label1 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label2 = new Label();
    this.Label7 = new Label();
    ((ISupportInitialize) this.txtCompanyInfo).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.txtInsuredName).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtCommissionPercent).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.txtCompanyInfo,
      (ARControl) this.TextBox7,
      (ARControl) this.Label3,
      (ARControl) this.Label9,
      (ARControl) this.Label8,
      (ARControl) this.Label4,
      (ARControl) this.Label1,
      (ARControl) this.Label6,
      (ARControl) this.Label5,
      (ARControl) this.Label2,
      (ARControl) this.Label7
    });
    this.PageHeader1.Height = 1.354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.txtCompanyInfo).DataField = "PayeeMailingAddress";
    ((ARControl) this.txtCompanyInfo).Height = 11f / 16f;
    ((ARControl) this.txtCompanyInfo).Left = 23f / 500f;
    ((ARControl) this.txtCompanyInfo).Name = "txtCompanyInfo";
    this.txtCompanyInfo.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.txtCompanyInfo.Text = (string) null;
    ((ARControl) this.txtCompanyInfo).Top = 0.315f;
    ((ARControl) this.txtCompanyInfo).Width = 53f / 16f;
    ((ARControl) this.TextBox7).Height = 0.231f;
    ((ARControl) this.TextBox7).Left = 0.0f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 12pt; font-weight: bold; text-align: center";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 7.9f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.txtInsuredName,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.TextBox1,
      (ARControl) this.txtCommissionPercent,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox4
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    this.txtInsuredName.CanGrow = false;
    ((ARControl) this.txtInsuredName).DataField = "insuredname";
    ((ARControl) this.txtInsuredName).Height = 0.125f;
    ((ARControl) this.txtInsuredName).Left = 23f / 500f;
    ((ARControl) this.txtInsuredName).Name = "txtInsuredName";
    this.txtInsuredName.Style = "font-size: 7pt; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.txtInsuredName.Text = (string) null;
    ((ARControl) this.txtInsuredName).Top = 0.0f;
    ((ARControl) this.txtInsuredName).Width = 1.063f;
    this.txtPolicyNumber.CanGrow = false;
    ((ARControl) this.txtPolicyNumber).DataField = "policynumber";
    ((ARControl) this.txtPolicyNumber).Height = 0.125f;
    ((ARControl) this.txtPolicyNumber).Left = 1.171f;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.Style = "font-size: 7pt";
    this.txtPolicyNumber.Text = " ";
    ((ARControl) this.txtPolicyNumber).Top = 0.0f;
    ((ARControl) this.txtPolicyNumber).Width = 1.104f;
    this.TextBox1.CanGrow = false;
    ((ARControl) this.TextBox1).DataField = "PolicyDescription";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 2.338f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 7pt; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.6880002f;
    ((ARControl) this.txtCommissionPercent).DataField = "CommissionPercentage";
    ((ARControl) this.txtCommissionPercent).Height = 0.125f;
    ((ARControl) this.txtCommissionPercent).Left = 4.827f;
    ((ARControl) this.txtCommissionPercent).Name = "txtCommissionPercent";
    this.txtCommissionPercent.OutputFormat = resourceManager.GetString("txtCommissionPercent.OutputFormat");
    this.txtCommissionPercent.Style = "font-size: 7pt; text-align: right";
    this.txtCommissionPercent.Text = " ";
    ((ARControl) this.txtCommissionPercent).Top = 0.0f;
    ((ARControl) this.txtCommissionPercent).Width = 9f / 16f;
    this.TextBox2.CanGrow = false;
    ((ARControl) this.TextBox2).DataField = "grossPremium";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 3.077f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 7pt; text-align: right; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.9374998f;
    this.TextBox3.CanGrow = false;
    ((ARControl) this.TextBox3).DataField = "GrossCommission";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 4.015f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 7pt; text-align: right; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.8120003f;
    this.TextBox5.CanGrow = false;
    ((ARControl) this.TextBox5).DataField = "balance";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 6.2645f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-size: 7pt; text-align: right; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.75f;
    ((ARControl) this.TextBox6).DataField = "paidPrevious";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 5.3895f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "font-size: 7pt; text-align: right";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.875f;
    this.TextBox4.CanGrow = false;
    ((ARControl) this.TextBox4).DataField = "propamtdue";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 7.0145f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 7pt; text-align: right; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.875f;
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    this.GroupHeader1.DataField = "PayeeName";
    this.GroupHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.NewPage = (NewPage) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label10,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox11
    });
    this.GroupFooter1.Height = 0.5416667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 1.327f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label10.Text = "Total : ";
    ((ARControl) this.Label10).Top = 0.187f;
    ((ARControl) this.Label10).Width = 9f / 16f;
    this.TextBox8.CanGrow = false;
    ((ARControl) this.TextBox8).DataField = "GrossCommission";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 4.0145f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-size: 7pt; font-weight: bold; text-align: right; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.TextBox8.SummaryGroup = "GroupHeader1";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.187f;
    ((ARControl) this.TextBox8).Width = 13f / 16f;
    ((ARControl) this.TextBox10).DataField = "paidPrevious";
    ((ARControl) this.TextBox10).Height = 0.125f;
    ((ARControl) this.TextBox10).Left = 5.3895f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.TextBox10.SummaryGroup = "GroupHeader1";
    this.TextBox10.SummaryRunning = (SummaryRunning) 1;
    this.TextBox10.SummaryType = (SummaryType) 3;
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox10).Top = 0.187f;
    ((ARControl) this.TextBox10).Width = 0.875f;
    this.TextBox12.CanGrow = false;
    ((ARControl) this.TextBox12).DataField = "balance";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 6.2645f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "font-size: 7pt; font-weight: bold; text-align: right; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.TextBox12.SummaryGroup = "GroupHeader1";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 3;
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.187f;
    ((ARControl) this.TextBox12).Width = 0.75f;
    this.TextBox9.CanGrow = false;
    ((ARControl) this.TextBox9).DataField = "propamtdue";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 7.0145f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 7pt; font-weight: bold; text-align: right; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.TextBox9.SummaryGroup = "GroupHeader1";
    this.TextBox9.SummaryRunning = (SummaryRunning) 1;
    this.TextBox9.SummaryType = (SummaryType) 3;
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.187f;
    ((ARControl) this.TextBox9).Width = 0.875f;
    this.TextBox11.CanGrow = false;
    ((ARControl) this.TextBox11).DataField = "grossPremium";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 3.077f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "font-size: 7pt; font-weight: bold; text-align: right; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.TextBox11.SummaryGroup = "GroupHeader1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 3;
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.187f;
    ((ARControl) this.TextBox11).Width = 15f / 16f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 3.077f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label3.Text = "Gross Premium";
    ((ARControl) this.Label3).Top = 1.146f;
    ((ARControl) this.Label3).Width = 15f / 16f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 4.014f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label9.Text = "Gross Comm.";
    ((ARControl) this.Label9).Top = 1.146f;
    ((ARControl) this.Label9).Width = 13f / 16f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 4.8265f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label8.Text = "Comm %";
    ((ARControl) this.Label8).Top = 1.146f;
    ((ARControl) this.Label8).Width = 9f / 16f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 5.389f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label4.Text = "Paid Previous";
    ((ARControl) this.Label4).Top = 1.146f;
    ((ARControl) this.Label4).Width = 0.875f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 23f / 500f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label1.Text = "Insured Name";
    ((ARControl) this.Label1).Top = 1.146f;
    ((ARControl) this.Label1).Width = 17f / 16f;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 6.264f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label6.Text = "Balance";
    ((ARControl) this.Label6).Top = 1.146f;
    ((ARControl) this.Label6).Width = 0.75f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 7.014f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label5.Text = "Pay Now";
    ((ARControl) this.Label5).Top = 1.146f;
    ((ARControl) this.Label5).Width = 0.875f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 1.171f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label2.Text = "Policy Number";
    ((ARControl) this.Label2).Top = 1.146f;
    ((ARControl) this.Label2).Width = 1.104f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 2.338f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label7.Text = "Description";
    ((ARControl) this.Label7).Top = 1.146f;
    ((ARControl) this.Label7).Width = 11f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    ((ISupportInitialize) this.txtCompanyInfo).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.txtInsuredName).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtCommissionPercent).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private virtual PageHeader PageHeader1
  {
    get => this._PageHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PageHeader1_Format);
      PageHeader pageHeader1_1 = this._PageHeader1;
      if (pageHeader1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) pageHeader1_1).Format -= eventHandler;
      this._PageHeader1 = value;
      PageHeader pageHeader1_2 = this._PageHeader1;
      if (pageHeader1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) pageHeader1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInsuredName")]
  private virtual TextBox txtInsuredName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyNumber")]
  private virtual TextBox txtPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCommissionPercent")]
  private virtual TextBox txtCommissionPercent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCompanyInfo")]
  private virtual TextBox txtCompanyInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  internal virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptReturnPremiumCommissionAutomation()
  {
    this.ReportStart += new EventHandler(this.rptReturnPremiumCommissionAutomation_ReportStart);
    this.InitializeComponent();
  }

  public rptReturnPremiumCommissionAutomation(int glCompanyId, string entityGuids)
  {
    this.ReportStart += new EventHandler(this.rptReturnPremiumCommissionAutomation_ReportStart);
    this.InitializeComponent();
    this._entityGuids = entityGuids;
    this._glCompanyId = glCompanyId;
  }

  public rptReturnPremiumCommissionAutomation(
    int glCompanyId,
    string entityGuids,
    DateTime asOfDate)
  {
    this.ReportStart += new EventHandler(this.rptReturnPremiumCommissionAutomation_ReportStart);
    this.InitializeComponent();
    this._entityGuids = entityGuids;
    this._glCompanyId = glCompanyId;
    this._asOfDate = asOfDate;
  }

  public rptReturnPremiumCommissionAutomation(int glCompanyId, DateTime asOfDate)
  {
    this.ReportStart += new EventHandler(this.rptReturnPremiumCommissionAutomation_ReportStart);
    this.InitializeComponent();
    this._entityGuids = string.Empty;
    this._glCompanyId = glCompanyId;
    this._asOfDate = asOfDate;
  }

  private void rptReturnPremiumCommissionAutomation_ReportStart(object sender, EventArgs e)
  {
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    try
    {
      selectCommand.CommandText = "[spfin_rptReturnPremiumCommissionAutomation]";
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Connection = sqlConnection;
      if (string.IsNullOrEmpty(this._entityGuids))
        selectCommand.Parameters.AddWithValue("@PayeeGuids", (object) DBNull.Value);
      else
        selectCommand.Parameters.AddWithValue("@PayeeGuids", (object) this._entityGuids);
      selectCommand.Parameters.AddWithValue("@glCompanyId", (object) this._glCompanyId);
      if (!this._asOfDate.Equals(DateTime.MinValue))
        selectCommand.Parameters.AddWithValue("@asOfDate", (object) this._asOfDate);
      else
        selectCommand.Parameters.AddWithValue("@asOfDate", (object) DateAndTime.Now.Date);
      selectCommand.CommandTimeout = 0;
      sqlDataAdapter.Fill(dataSet);
      this.DataSource = (object) dataSet.Tables[0];
    }
    finally
    {
      sqlConnection.Dispose();
      sqlDataAdapter.Dispose();
      selectCommand.Dispose();
    }
  }

  private void PageHeader1_Format(object sender, EventArgs e)
  {
    if (!SystemSettings.KeyExists("CreditStatementHeader"))
      return;
    DateTime dateTime = DateTime.Compare(this._asOfDate, DateTime.MinValue) != 0 ? this._asOfDate : DateTime.Now;
    this.TextBox7.Text = $"{SystemSettings.GetStringSetting("CreditStatementHeader")}\r\nAs of {dateTime.ToShortDateString()}";
  }
}
