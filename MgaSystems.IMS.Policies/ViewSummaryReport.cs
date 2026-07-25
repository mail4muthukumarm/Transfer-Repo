// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ViewSummaryReport
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class ViewSummaryReport : SectionReport
{
  private IContainer components;
  private Label Label1;
  private GroupFooter GroupFooter1;
  private GroupFooter GroupFooter2;
  private CheckBox CheckBox1;
  private CheckBox CheckBox2;
  private Label Label9;
  private Label Label3;
  private Label Label4;
  private Label Label6;
  private Label lblPremium;
  private Label lblFees;
  private TextBox txtLine;
  private Label Label10;
  private TextBox txtLineName;
  private TextBox txtLineGuid2;
  private Label Label2;
  private Label Label5;
  private TextBox txtOptionGuid2;
  private TextBox TextBox1;
  private Label Label7;
  private Label Label8;
  private Label Label11;
  private Label Label12;
  private SubReport viewSummarySub;
  private TextBox txtOptionGuid;
  private Label Label13;
  private Label Label14;
  private dsPolicyDetail_Premiums _ds;
  private object _currCode;
  private CultureInfo _cInfo;

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (ViewSummaryReport));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Detail1 = new Detail();
    this.txtOptionGuid = new TextBox();
    this.viewSummarySub = new SubReport();
    this.PageFooter1 = new PageFooter();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.GroupHeader1 = new GroupHeader();
    this.txtLine = new TextBox();
    this.txtLineName = new TextBox();
    this.Label2 = new Label();
    this.Label5 = new Label();
    this.TextBox1 = new TextBox();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.TextBox4 = new TextBox();
    this.Label15 = new Label();
    this.TextBox5 = new TextBox();
    this.Label16 = new Label();
    this.txtCompanyLocationID = new TextBox();
    this.GroupFooter1 = new GroupFooter();
    this.GroupHeader2 = new GroupHeader();
    this.CheckBox1 = new CheckBox();
    this.CheckBox2 = new CheckBox();
    this.Label9 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label6 = new Label();
    this.lblPremium = new Label();
    this.lblFees = new Label();
    this.Label10 = new Label();
    this.txtLineGuid2 = new TextBox();
    this.txtOptionGuid2 = new TextBox();
    this.GroupFooter2 = new GroupFooter();
    this.Label17 = new Label();
    this.Label18 = new Label();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtOptionGuid).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.txtLine).BeginInit();
    ((ISupportInitialize) this.txtLineName).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.txtCompanyLocationID).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.CheckBox2).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.lblPremium).BeginInit();
    ((ISupportInitialize) this.lblFees).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.txtLineGuid2).BeginInit();
    ((ISupportInitialize) this.txtOptionGuid2).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.PageHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label1
    });
    ((Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 12.75pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "View Summary Report";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = (float) sbyte.MaxValue / 16f;
    ((Section) this.Detail1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtOptionGuid,
      (ARControl) this.viewSummarySub
    });
    ((Section) this.Detail1).Height = 0.1666667f;
    ((Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.txtOptionGuid).DataField = "QuoteOptionGuid";
    ((ARControl) this.txtOptionGuid).Height = 3f / 16f;
    ((ARControl) this.txtOptionGuid).Left = 113f / 16f;
    ((ARControl) this.txtOptionGuid).Name = "txtOptionGuid";
    this.txtOptionGuid.Style = "color: Red";
    this.txtOptionGuid.Text = "optionGuid";
    ((ARControl) this.txtOptionGuid).Top = 0.0f;
    ((ARControl) this.txtOptionGuid).Visible = false;
    ((ARControl) this.txtOptionGuid).Width = 0.75f;
    this.viewSummarySub.CloseBorder = false;
    ((ARControl) this.viewSummarySub).Height = 0.125f;
    ((ARControl) this.viewSummarySub).Left = 1f;
    ((ARControl) this.viewSummarySub).Name = "viewSummarySub";
    this.viewSummarySub.Report = (SectionReport) null;
    this.viewSummarySub.ReportName = "SubReport1";
    ((ARControl) this.viewSummarySub).Top = 0.0f;
    ((ARControl) this.viewSummarySub).Width = 95f / 16f;
    ((Section) this.PageFooter1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label17,
      (ARControl) this.Label18
    });
    this.PageFooter1.Height = 7f / 16f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 0.0f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "text-align: right";
    this.Label13.Text = "Total Premium:";
    ((ARControl) this.Label13).Top = 0.0f;
    ((ARControl) this.Label13).Width = 1f;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 0.0f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "text-align: right";
    this.Label14.Text = "Total Fees:";
    ((ARControl) this.Label14).Top = 0.25f;
    ((ARControl) this.Label14).Width = 1f;
    ((Section) this.GroupHeader1).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.txtLine,
      (ARControl) this.txtLineName,
      (ARControl) this.Label2,
      (ARControl) this.Label5,
      (ARControl) this.TextBox1,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.TextBox4,
      (ARControl) this.Label15,
      (ARControl) this.TextBox5,
      (ARControl) this.Label16,
      (ARControl) this.txtCompanyLocationID
    });
    this.GroupHeader1.DataField = "QuoteOptionGuid";
    this.GroupHeader1.Height = 1.135417f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.txtLine).DataField = "LineGuid";
    ((ARControl) this.txtLine).Height = 3f / 16f;
    ((ARControl) this.txtLine).Left = 113f / 16f;
    ((ARControl) this.txtLine).Name = "txtLine";
    this.txtLine.Style = "background-color: Red";
    this.txtLine.Text = "LineGuid";
    ((ARControl) this.txtLine).Top = 0.875f;
    ((ARControl) this.txtLine).Visible = false;
    ((ARControl) this.txtLine).Width = 0.625f;
    ((ARControl) this.txtLineName).Height = 3f / 16f;
    ((ARControl) this.txtLineName).Left = 19f / 16f;
    ((ARControl) this.txtLineName).Name = "txtLineName";
    this.txtLineName.Text = "LineName";
    ((ARControl) this.txtLineName).Top = 0.0f;
    ((ARControl) this.txtLineName).Width = 2f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-weight: bold; text-align: right";
    this.Label2.Text = "Fees";
    ((ARControl) this.Label2).Top = 0.875f;
    ((ARControl) this.Label2).Width = 1f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 1f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-weight: bold";
    this.Label5.Text = "Line:";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 1.125f;
    ((ARControl) this.TextBox1).DataField = "QuoteOptionGuid";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 99f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "background-color: Red";
    this.TextBox1.Text = "OptionGuid";
    ((ARControl) this.TextBox1).Top = 0.875f;
    ((ARControl) this.TextBox1).Visible = false;
    ((ARControl) this.TextBox1).Width = 0.625f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 1f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-weight: bold; text-align: right";
    this.Label7.Text = "Premium";
    ((ARControl) this.Label7).Top = 0.875f;
    ((ARControl) this.Label7).Width = 1f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 3f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-weight: bold; text-align: right";
    this.Label8.Text = "Created";
    ((ARControl) this.Label8).Top = 0.875f;
    ((ARControl) this.Label8).Width = 1f;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 4f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-weight: bold; text-align: center";
    this.Label11.Text = "Bind";
    ((ARControl) this.Label11).Top = 0.875f;
    ((ARControl) this.Label11).Width = 15f / 16f;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 5f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-weight: bold; text-align: center";
    this.Label12.Text = "Quoted";
    ((ARControl) this.Label12).Top = 0.875f;
    ((ARControl) this.Label12).Width = 1f;
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 19f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 3f / 16f;
    ((ARControl) this.TextBox4).Width = 2f;
    ((ARControl) this.Label15).Height = 3f / 16f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 1f / 16f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-weight: bold";
    this.Label15.Text = "Insured Name:";
    ((ARControl) this.Label15).Top = 3f / 16f;
    ((ARControl) this.Label15).Width = 1.125f;
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 19f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.375f;
    ((ARControl) this.TextBox5).Width = 2f;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 1f / 16f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-weight: bold";
    this.Label16.Text = "Policy Number:";
    ((ARControl) this.Label16).Top = 0.375f;
    ((ARControl) this.Label16).Width = 1.125f;
    ((ARControl) this.txtCompanyLocationID).DataField = "CompanyLocationID";
    ((ARControl) this.txtCompanyLocationID).Height = 3f / 16f;
    ((ARControl) this.txtCompanyLocationID).Left = 7.062f;
    ((ARControl) this.txtCompanyLocationID).Name = "txtCompanyLocationID";
    this.txtCompanyLocationID.Style = "background-color: Red";
    this.txtCompanyLocationID.Text = "CompanyLocationID";
    ((ARControl) this.txtCompanyLocationID).Top = 0.615f;
    ((ARControl) this.txtCompanyLocationID).Visible = false;
    ((ARControl) this.txtCompanyLocationID).Width = 0.625f;
    this.GroupFooter1.Height = 1f / 16f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((Section) this.GroupHeader2).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.CheckBox1,
      (ARControl) this.CheckBox2,
      (ARControl) this.Label9,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label6,
      (ARControl) this.lblPremium,
      (ARControl) this.lblFees,
      (ARControl) this.Label10,
      (ARControl) this.txtLineGuid2,
      (ARControl) this.txtOptionGuid2
    });
    this.GroupHeader2.Height = 0.5729167f;
    ((Section) this.GroupHeader2).Name = "GroupHeader2";
    ((ARControl) this.CheckBox1).DataField = "Bound";
    ((ARControl) this.CheckBox1).Height = 0.125f;
    ((ARControl) this.CheckBox1).Left = 71f / 16f;
    ((ARControl) this.CheckBox1).Name = "CheckBox1";
    this.CheckBox1.Style = "";
    this.CheckBox1.Text = "";
    ((ARControl) this.CheckBox1).Top = 1f / 16f;
    ((ARControl) this.CheckBox1).Width = 0.125f;
    ((ARControl) this.CheckBox2).DataField = "Quote";
    ((ARControl) this.CheckBox2).Height = 0.125f;
    ((ARControl) this.CheckBox2).Left = 87f / 16f;
    ((ARControl) this.CheckBox2).Name = "CheckBox2";
    this.CheckBox2.Style = "";
    this.CheckBox2.Text = "";
    ((ARControl) this.CheckBox2).Top = 1f / 16f;
    ((ARControl) this.CheckBox2).Width = 0.125f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 1f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-weight: bold";
    this.Label9.Text = "State";
    ((ARControl) this.Label9).Top = 0.375f;
    ((ARControl) this.Label9).Width = 11f / 16f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 61f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold";
    this.Label3.Text = "Amount";
    ((ARControl) this.Label3).Top = 0.375f;
    ((ARControl) this.Label3).Width = 1f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 5f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-weight: bold";
    this.Label4.Text = "Office";
    ((ARControl) this.Label4).Top = 0.375f;
    ((ARControl) this.Label4).Width = 1f;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 27f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-weight: bold";
    this.Label6.Text = "Item";
    ((ARControl) this.Label6).Top = 0.375f;
    ((ARControl) this.Label6).Width = 17f / 16f;
    ((ARControl) this.lblPremium).Height = 3f / 16f;
    this.lblPremium.HyperLink = (string) null;
    ((ARControl) this.lblPremium).Left = 1f;
    ((ARControl) this.lblPremium).Name = "lblPremium";
    this.lblPremium.Style = "text-align: right";
    this.lblPremium.Text = "Premium";
    ((ARControl) this.lblPremium).Top = 0.0f;
    ((ARControl) this.lblPremium).Width = 1f;
    ((ARControl) this.lblFees).Height = 3f / 16f;
    this.lblFees.HyperLink = (string) null;
    ((ARControl) this.lblFees).Left = 2f;
    ((ARControl) this.lblFees).Name = "lblFees";
    this.lblFees.Style = "text-align: right";
    this.lblFees.Text = "Fees";
    ((ARControl) this.lblFees).Top = 0.0f;
    ((ARControl) this.lblFees).Width = 1f;
    ((ARControl) this.Label10).DataField = "DateCreated";
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 3f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "text-align: right";
    this.Label10.Text = "Created";
    ((ARControl) this.Label10).Top = 0.0f;
    ((ARControl) this.Label10).Width = 1f;
    ((ARControl) this.txtLineGuid2).DataField = "LineGuid";
    ((ARControl) this.txtLineGuid2).Height = 3f / 16f;
    ((ARControl) this.txtLineGuid2).Left = 97f / 16f;
    ((ARControl) this.txtLineGuid2).Name = "txtLineGuid2";
    this.txtLineGuid2.Style = "color: Red";
    this.txtLineGuid2.Text = "LineGuid";
    ((ARControl) this.txtLineGuid2).Top = 0.0f;
    ((ARControl) this.txtLineGuid2).Visible = false;
    ((ARControl) this.txtLineGuid2).Width = 0.625f;
    ((ARControl) this.txtOptionGuid2).DataField = "QuoteOptionGuid";
    ((ARControl) this.txtOptionGuid2).Height = 3f / 16f;
    ((ARControl) this.txtOptionGuid2).Left = 6.75f;
    ((ARControl) this.txtOptionGuid2).Name = "txtOptionGuid2";
    this.txtOptionGuid2.Style = "color: Red";
    this.txtOptionGuid2.Text = "optionGuid";
    ((ARControl) this.txtOptionGuid2).Top = 0.0f;
    ((ARControl) this.txtOptionGuid2).Visible = false;
    ((ARControl) this.txtOptionGuid2).Width = 0.75f;
    this.GroupFooter2.Height = 0.05208333f;
    ((Section) this.GroupFooter2).Name = "GroupFooter2";
    ((ARControl) this.Label17).Height = 3f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 1f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "text-align: right";
    this.Label17.Text = "TotalPremium";
    ((ARControl) this.Label17).Top = 0.0f;
    ((ARControl) this.Label17).Width = 1f;
    ((ARControl) this.Label18).Height = 3f / 16f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 1f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "text-align: right";
    this.Label18.Text = "TotalFees";
    ((ARControl) this.Label18).Top = 0.25f;
    ((ARControl) this.Label18).Width = 1f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.03f;
    this.PageSettings.Margins.Left = 0.03f;
    this.PageSettings.Margins.Right = 0.03f;
    this.PageSettings.Margins.Top = 0.03f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.989583f;
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.GroupHeader2);
    this.Sections.Add((Section) this.Detail1);
    this.Sections.Add((Section) this.GroupFooter2);
    this.Sections.Add((Section) this.GroupFooter1);
    this.Sections.Add((Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtOptionGuid).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.txtLine).EndInit();
    ((ISupportInitialize) this.txtLineName).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.txtCompanyLocationID).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.CheckBox2).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.lblPremium).EndInit();
    ((ISupportInitialize) this.lblFees).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.txtLineGuid2).EndInit();
    ((ISupportInitialize) this.txtOptionGuid2).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail1
  {
    get => this._Detail1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail1_Format);
      Detail detail1_1 = this._Detail1;
      if (detail1_1 != null)
        ((Section) detail1_1).Format -= eventHandler;
      this._Detail1 = value;
      Detail detail1_2 = this._Detail1;
      if (detail1_2 == null)
        return;
      ((Section) detail1_2).Format += eventHandler;
    }
  }

  private virtual PageFooter PageFooter1
  {
    get => this._PageFooter1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PageFooter1_Format);
      PageFooter pageFooter1_1 = this._PageFooter1;
      if (pageFooter1_1 != null)
        ((Section) pageFooter1_1).Format -= eventHandler;
      this._PageFooter1 = value;
      PageFooter pageFooter1_2 = this._PageFooter1;
      if (pageFooter1_2 == null)
        return;
      ((Section) pageFooter1_2).Format += eventHandler;
    }
  }

  private virtual GroupHeader GroupHeader1
  {
    get => this._GroupHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupHeader1_Format);
      GroupHeader groupHeader1_1 = this._GroupHeader1;
      if (groupHeader1_1 != null)
        ((Section) groupHeader1_1).Format -= eventHandler;
      this._GroupHeader1 = value;
      GroupHeader groupHeader1_2 = this._GroupHeader1;
      if (groupHeader1_2 == null)
        return;
      ((Section) groupHeader1_2).Format += eventHandler;
    }
  }

  private virtual GroupHeader GroupHeader2
  {
    get => this._GroupHeader2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupHeader2_Format);
      GroupHeader groupHeader2_1 = this._GroupHeader2;
      if (groupHeader2_1 != null)
        ((Section) groupHeader2_1).Format -= eventHandler;
      this._GroupHeader2 = value;
      GroupHeader groupHeader2_2 = this._GroupHeader2;
      if (groupHeader2_2 == null)
        return;
      ((Section) groupHeader2_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  private virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  private virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCompanyLocationID")]
  private virtual TextBox txtCompanyLocationID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public ViewSummaryReport()
  {
    this.ReportStart += new EventHandler(this.ViewSummaryReport_ReportStart);
    this._ds = new dsPolicyDetail_Premiums();
    this._currCode = (object) null;
    this._cInfo = (CultureInfo) null;
    this.InitializeComponent();
  }

  public ViewSummaryReport(dsPolicyDetail_Premiums ds)
  {
    this.ReportStart += new EventHandler(this.ViewSummaryReport_ReportStart);
    this._ds = new dsPolicyDetail_Premiums();
    this._currCode = (object) null;
    this._cInfo = (CultureInfo) null;
    this.InitializeComponent();
    this._ds = ds;
  }

  private void ViewSummaryReport_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._ds.tblQuoteOptions;
  }

  private object CurrencyCode
  {
    get
    {
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(this._currCode)))
        this._currCode = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select dbo.GetQuoteCurrencyCode(@quoteId)", new object[2]
        {
          (object) "@QuoteId",
          (object) new Quote(new QuoteOption((Guid) this.txtOptionGuid2.Value).QuoteGuid).QuoteID
        }));
      return this._currCode;
    }
  }

  private object CurrencyCultureInfo
  {
    get
    {
      if (Utility.IsNull((object) this._cInfo) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.CurrencyCode)))
        this._cInfo = MultiCurrencyUtilities.GetCultureInfo(this.CurrencyCode.ToString());
      return (object) this._cInfo;
    }
  }

  private void GroupHeader2_Format(object sender, EventArgs e)
  {
    Guid optionGuid = (Guid) this.txtOptionGuid2.Value;
    Guid lineGuid = (Guid) this.txtLineGuid2.Value;
    Decimal linePremium = this.GetLinePremium(lineGuid, optionGuid);
    Decimal lineFees = this.GetLineFees(lineGuid, optionGuid);
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.CurrencyCultureInfo)))
    {
      this.lblPremium.Text = linePremium.ToString("c", (IFormatProvider) this.CurrencyCultureInfo);
      this.lblFees.Text = lineFees.ToString("c", (IFormatProvider) this.CurrencyCultureInfo);
    }
    else
    {
      this.lblPremium.Text = linePremium.ToString("c");
      this.lblFees.Text = lineFees.ToString("c");
    }
  }

  private void GroupHeader1_Format(object sender, EventArgs e)
  {
    this.txtLineName.Text = ((dsPolicyDetail_Premiums.LinesOptionsRow) this._ds.LinesOptions.Select($"LineGuid = '{this.txtLine.Value.ToString()}' AND CompanyLocationID= {this.txtCompanyLocationID.Value.ToString()}")[0]).LineName;
    object obj = this._ds.tblQuoteOptions.Rows[0]["QuoteOptionGUID"];
    DataTable additionalInfo = this.GetAdditionalInfo(obj != null ? (Guid) obj : new Guid());
    this.TextBox4.Text = additionalInfo.Rows[0]["InsuredPolicyName"].ToString();
    this.TextBox5.Text = additionalInfo.Rows[0]["PolicyNumber"].ToString();
  }

  private void PageFooter1_Format(object sender, EventArgs e)
  {
    Decimal num1 = Conversions.ToDecimal(this._ds.tblQuoteOptions.Compute("SUM(Premium)", ""));
    Decimal num2 = Conversions.ToDecimal(this._ds.tblQuoteOptions.Compute("SUM(fees)", ""));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.CurrencyCultureInfo)))
    {
      this.Label17.Text = num1.ToString("c", (IFormatProvider) this.CurrencyCultureInfo);
      this.Label18.Text = num2.ToString("c", (IFormatProvider) this.CurrencyCultureInfo);
    }
    else
    {
      this.Label17.Text = num1.ToString("c");
      this.Label18.Text = num2.ToString("c");
    }
  }

  private DataTable GetAdditionalInfo(Guid QuoteOptionGUID)
  {
    return DefaultDatabase.ExecuteDataTable("GetInfoUsingQuoteOptionGUID", new object[2]
    {
      (object) "@QuoteOptionGUID",
      (object) QuoteOptionGUID
    });
  }

  private void Detail1_Format(object sender, EventArgs e)
  {
    this.viewSummarySub.Report = (SectionReport) new ViewSummaryReport_SUB(new DataView((DataTable) this._ds.viewOptionPremiums, $"QuoteOptionGuid='{(Guid) this.txtOptionGuid.Value}'", "StateID", DataViewRowState.CurrentRows));
  }

  private Decimal GetLinePremium(Guid lineGuid, Guid optionGuid)
  {
    Decimal d1 = 0M;
    try
    {
      foreach (dsPolicyDetail_Premiums.tblQuoteOptionsRow row in this._ds.tblQuoteOptions.Rows)
      {
        Guid guid = row.QuoteOptionGuid;
        if (guid.Equals(optionGuid))
        {
          guid = row.LineGuid;
          if (guid.Equals(lineGuid))
            d1 = Decimal.Add(d1, row.Premium);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return d1;
  }

  private Decimal GetLineFees(Guid lineGuid, Guid optionGuid)
  {
    Decimal d1 = 0M;
    try
    {
      foreach (dsPolicyDetail_Premiums.tblQuoteOptionsRow row in this._ds.tblQuoteOptions.Rows)
      {
        if (row.QuoteOptionGuid.Equals(optionGuid) && lineGuid.Equals(lineGuid))
          d1 = Decimal.Add(d1, row.Fees);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return d1;
  }
}
