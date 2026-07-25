// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.rptAllocationReport
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.BusinessObjects;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class rptAllocationReport : MGAReport
{
  private DataSet _ds;
  private Quote _quote;
  private TextBox txtQuotingOffice;
  private TextBox txtTIV;
  private TextBox txtTotalTIV;
  private Label Label6;

  public rptAllocationReport()
  {
    this.ReportStart += new EventHandler(this.rptAllocationReport_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptAllocationReport));
    this.Detail = new Detail();
    this.txtQuotingOffice = new TextBox();
    this.txtTIV = new TextBox();
    this.GroupHeader1 = new GroupHeader();
    this.txtState = new TextBox();
    this.GroupFooter1 = new GroupFooter();
    this.txtTotalTIV = new TextBox();
    this.Label6 = new Label();
    this.ReportHeader1 = new ReportHeader();
    this.ReportFooter1 = new ReportFooter();
    this.Label7 = new Label();
    this.TextBox1 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label = new Label();
    this.txtInsuredPolicyName = new TextBox();
    this.txtCompany = new TextBox();
    this.Label8 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.label33 = new Label();
    this.txtLine = new TextBox();
    this.txtStateID = new TextBox();
    this.Label5 = new Label();
    this.PageFooter = new PageFooter();
    this.txtPercentTIV = new TextBox();
    this.Label10 = new Label();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.Label9 = new Label();
    this.txtPolicyNo = new TextBox();
    ((ISupportInitialize) this.txtQuotingOffice).BeginInit();
    ((ISupportInitialize) this.txtTIV).BeginInit();
    ((ISupportInitialize) this.txtState).BeginInit();
    ((ISupportInitialize) this.txtTotalTIV).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.txtInsuredPolicyName).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.label33).BeginInit();
    ((ISupportInitialize) this.txtLine).BeginInit();
    ((ISupportInitialize) this.txtStateID).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtPercentTIV).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtPolicyNo).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.txtQuotingOffice,
      (ARControl) this.txtTIV,
      (ARControl) this.txtPercentTIV
    });
    ((Section) this.Detail).Height = 0.125f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtQuotingOffice).Border.BottomColor = Color.Black;
    ((ARControl) this.txtQuotingOffice).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtQuotingOffice).Border.LeftColor = Color.Black;
    ((ARControl) this.txtQuotingOffice).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtQuotingOffice).Border.RightColor = Color.Black;
    ((ARControl) this.txtQuotingOffice).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtQuotingOffice).Border.TopColor = Color.Black;
    ((ARControl) this.txtQuotingOffice).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtQuotingOffice).DataField = "QuotingLocationID";
    ((ARControl) this.txtQuotingOffice).Height = 0.125f;
    ((ARControl) this.txtQuotingOffice).Left = 21f / 16f;
    ((ARControl) this.txtQuotingOffice).Name = "txtQuotingOffice";
    this.txtQuotingOffice.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.txtQuotingOffice.Text = " ";
    ((ARControl) this.txtQuotingOffice).Top = 0.0f;
    ((ARControl) this.txtQuotingOffice).Width = 43f / 16f;
    ((ARControl) this.txtTIV).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTIV).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTIV).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTIV).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTIV).Border.RightColor = Color.Black;
    ((ARControl) this.txtTIV).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTIV).Border.TopColor = Color.Black;
    ((ARControl) this.txtTIV).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTIV).DataField = "TIV";
    ((ARControl) this.txtTIV).Height = 0.125f;
    ((ARControl) this.txtTIV).Left = 4.375f;
    ((ARControl) this.txtTIV).Name = "txtTIV";
    this.txtTIV.OutputFormat = resourceManager.GetString("txtTIV.OutputFormat");
    this.txtTIV.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.txtTIV.Text = " ";
    ((ARControl) this.txtTIV).Top = 0.0f;
    ((ARControl) this.txtTIV).Width = 1.75f;
    ((Section) this.GroupHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtState
    });
    this.GroupHeader1.DataField = "StateID";
    this.GroupHeader1.Height = 0.1458333f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.txtState).Border.BottomColor = Color.Black;
    ((ARControl) this.txtState).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtState).Border.LeftColor = Color.Black;
    ((ARControl) this.txtState).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtState).Border.RightColor = Color.Black;
    ((ARControl) this.txtState).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtState).Border.TopColor = Color.Black;
    ((ARControl) this.txtState).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtState).DataField = "StateID";
    ((ARControl) this.txtState).Height = 0.125f;
    ((ARControl) this.txtState).Left = 1f / 16f;
    ((ARControl) this.txtState).Name = "txtState";
    this.txtState.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.txtState.Text = " ";
    ((ARControl) this.txtState).Top = 0.0f;
    ((ARControl) this.txtState).Width = 1f;
    ((Section) this.GroupFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.txtTotalTIV,
      (ARControl) this.Label6,
      (ARControl) this.TextBox2
    });
    this.GroupFooter1.Height = 0.229f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.txtTotalTIV).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTotalTIV).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalTIV).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTotalTIV).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalTIV).Border.RightColor = Color.Black;
    ((ARControl) this.txtTotalTIV).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalTIV).Border.TopColor = Color.Black;
    ((ARControl) this.txtTotalTIV).Border.TopStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotalTIV).DataField = "TIV";
    ((ARControl) this.txtTotalTIV).Height = 0.125f;
    ((ARControl) this.txtTotalTIV).Left = 4.375f;
    ((ARControl) this.txtTotalTIV).Name = "txtTotalTIV";
    this.txtTotalTIV.OutputFormat = resourceManager.GetString("txtTotalTIV.OutputFormat");
    this.txtTotalTIV.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.txtTotalTIV.SummaryGroup = "GroupHeader1";
    this.txtTotalTIV.SummaryRunning = (SummaryRunning) 1;
    this.txtTotalTIV.SummaryType = (SummaryType) 3;
    this.txtTotalTIV.Text = " ";
    ((ARControl) this.txtTotalTIV).Top = 0.0f;
    ((ARControl) this.txtTotalTIV).Width = 1.75f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 61f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; ";
    this.Label6.Text = "Total:";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 7f / 16f;
    this.ReportHeader1.Height = 0.25f;
    ((Section) this.ReportHeader1).Name = "ReportHeader1";
    ((Section) this.ReportFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label7,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox3
    });
    this.ReportFooter1.Height = 0.4583333f;
    ((Section) this.ReportFooter1).Name = "ReportFooter1";
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 3.25f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-family: Microsoft Sans Serif; ";
    this.Label7.Text = "Grand Total:";
    ((ARControl) this.Label7).Top = 0.25f;
    ((ARControl) this.Label7).Width = 1f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "TIV";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 4.375f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-family: Microsoft Sans Serif; ";
    this.TextBox1.SummaryGroup = "GroupHeader1";
    this.TextBox1.SummaryRunning = (SummaryRunning) 1;
    this.TextBox1.SummaryType = (SummaryType) 1;
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.25f;
    ((ARControl) this.TextBox1).Width = 1.75f;
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label,
      (ARControl) this.txtInsuredPolicyName,
      (ARControl) this.txtCompany,
      (ARControl) this.Label8,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.label33,
      (ARControl) this.txtLine,
      (ARControl) this.txtStateID,
      (ARControl) this.Label5,
      (ARControl) this.Label10,
      (ARControl) this.Label9,
      (ARControl) this.txtPolicyNo
    });
    this.PageHeader.Height = 2.322917f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 0.25f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "text-align: center; font-size: 14pt; ";
    this.Label1.Text = "Allocation Report";
    ((ARControl) this.Label1).Top = 1f / 16f;
    ((ARControl) this.Label1).Width = 7.875f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 1f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; text-align: right; ";
    this.Label2.Text = "Named Insured:";
    ((ARControl) this.Label2).Top = 13f / 16f;
    ((ARControl) this.Label2).Width = 25f / 16f;
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 1f / 16f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "ddo-char-set: 0; text-align: right; ";
    this.Label.Text = "Company:";
    ((ARControl) this.Label).Top = 1.125f;
    ((ARControl) this.Label).Width = 25f / 16f;
    ((ARControl) this.txtInsuredPolicyName).Border.BottomColor = Color.Black;
    ((ARControl) this.txtInsuredPolicyName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredPolicyName).Border.LeftColor = Color.Black;
    ((ARControl) this.txtInsuredPolicyName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredPolicyName).Border.RightColor = Color.Black;
    ((ARControl) this.txtInsuredPolicyName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredPolicyName).Border.TopColor = Color.Black;
    ((ARControl) this.txtInsuredPolicyName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredPolicyName).Height = 3f / 16f;
    ((ARControl) this.txtInsuredPolicyName).Left = 27f / 16f;
    ((ARControl) this.txtInsuredPolicyName).Name = "txtInsuredPolicyName";
    this.txtInsuredPolicyName.Style = "ddo-char-set: 0; ";
    this.txtInsuredPolicyName.Text = (string) null;
    ((ARControl) this.txtInsuredPolicyName).Top = 13f / 16f;
    ((ARControl) this.txtInsuredPolicyName).Width = 4.625f;
    ((ARControl) this.txtCompany).Border.BottomColor = Color.Black;
    ((ARControl) this.txtCompany).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.LeftColor = Color.Black;
    ((ARControl) this.txtCompany).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.RightColor = Color.Black;
    ((ARControl) this.txtCompany).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.TopColor = Color.Black;
    ((ARControl) this.txtCompany).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Height = 3f / 16f;
    ((ARControl) this.txtCompany).Left = 27f / 16f;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.Style = "ddo-char-set: 0; ";
    this.txtCompany.Text = (string) null;
    ((ARControl) this.txtCompany).Top = 1.125f;
    ((ARControl) this.txtCompany).Width = 2.25f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 21f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-weight: bold; vertical-align: bottom; ";
    this.Label8.Text = "Quoting Office";
    ((ARControl) this.Label8).Top = 2.125f;
    ((ARControl) this.Label8).Width = 3f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 1f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold; vertical-align: bottom; ";
    this.Label3.Text = "State";
    ((ARControl) this.Label3).Top = 2.125f;
    ((ARControl) this.Label3).Width = 1.25f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 4.375f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "text-align: center; font-weight: bold; vertical-align: bottom; ";
    this.Label4.Text = "TIV";
    ((ARControl) this.Label4).Top = 2.125f;
    ((ARControl) this.Label4).Width = 1.75f;
    ((ARControl) this.label33).Border.BottomColor = Color.Black;
    ((ARControl) this.label33).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label33).Border.LeftColor = Color.Black;
    ((ARControl) this.label33).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label33).Border.RightColor = Color.Black;
    ((ARControl) this.label33).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label33).Border.TopColor = Color.Black;
    ((ARControl) this.label33).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label33).Height = 3f / 16f;
    this.label33.HyperLink = (string) null;
    ((ARControl) this.label33).Left = 1f / 16f;
    ((ARControl) this.label33).Name = "label33";
    this.label33.Style = "ddo-char-set: 0; text-align: right; ";
    this.label33.Text = "Line:";
    ((ARControl) this.label33).Top = 23f / 16f;
    ((ARControl) this.label33).Width = 25f / 16f;
    ((ARControl) this.txtLine).Border.BottomColor = Color.Black;
    ((ARControl) this.txtLine).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLine).Border.LeftColor = Color.Black;
    ((ARControl) this.txtLine).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLine).Border.RightColor = Color.Black;
    ((ARControl) this.txtLine).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLine).Border.TopColor = Color.Black;
    ((ARControl) this.txtLine).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLine).Height = 3f / 16f;
    ((ARControl) this.txtLine).Left = 27f / 16f;
    ((ARControl) this.txtLine).Name = "txtLine";
    this.txtLine.Style = "ddo-char-set: 0; ";
    this.txtLine.Text = (string) null;
    ((ARControl) this.txtLine).Top = 23f / 16f;
    ((ARControl) this.txtLine).Width = 2.25f;
    ((ARControl) this.txtStateID).Border.BottomColor = Color.Black;
    ((ARControl) this.txtStateID).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStateID).Border.LeftColor = Color.Black;
    ((ARControl) this.txtStateID).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStateID).Border.RightColor = Color.Black;
    ((ARControl) this.txtStateID).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStateID).Border.TopColor = Color.Black;
    ((ARControl) this.txtStateID).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStateID).Height = 3f / 16f;
    ((ARControl) this.txtStateID).Left = 27f / 16f;
    ((ARControl) this.txtStateID).Name = "txtStateID";
    this.txtStateID.Style = "ddo-char-set: 0; ";
    this.txtStateID.Text = (string) null;
    ((ARControl) this.txtStateID).Top = 1.75f;
    ((ARControl) this.txtStateID).Width = 2.25f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 1f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; text-align: right; ";
    this.Label5.Text = "State:";
    ((ARControl) this.Label5).Top = 1.75f;
    ((ARControl) this.Label5).Width = 25f / 16f;
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.txtPercentTIV).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPercentTIV).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPercentTIV).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPercentTIV).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPercentTIV).Border.RightColor = Color.Black;
    ((ARControl) this.txtPercentTIV).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPercentTIV).Border.TopColor = Color.Black;
    ((ARControl) this.txtPercentTIV).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPercentTIV).DataField = "PercentTIV";
    ((ARControl) this.txtPercentTIV).Height = 0.125f;
    ((ARControl) this.txtPercentTIV).Left = 6.125f;
    ((ARControl) this.txtPercentTIV).Name = "txtPercentTIV";
    this.txtPercentTIV.OutputFormat = resourceManager.GetString("txtPercentTIV.OutputFormat");
    this.txtPercentTIV.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.txtPercentTIV.Text = " ";
    ((ARControl) this.txtPercentTIV).Top = 0.0f;
    ((ARControl) this.txtPercentTIV).Width = 1.75f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 6.125f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "text-align: right; font-weight: bold; vertical-align: bottom; ";
    this.Label10.Text = "% of TIV";
    ((ARControl) this.Label10).Top = 2.125f;
    ((ARControl) this.Label10).Width = 1.75f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox2).DataField = "PercentTIV";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 6.125f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.TextBox2.SummaryGroup = "GroupHeader1";
    this.TextBox2.SummaryRunning = (SummaryRunning) 1;
    this.TextBox2.SummaryType = (SummaryType) 3;
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 1.75f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "PercentTIV";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 6.125f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-family: Microsoft Sans Serif; ";
    this.TextBox3.SummaryGroup = "GroupHeader1";
    this.TextBox3.SummaryRunning = (SummaryRunning) 1;
    this.TextBox3.SummaryType = (SummaryType) 1;
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.25f;
    ((ARControl) this.TextBox3).Width = 1.75f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 1f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "ddo-char-set: 0; text-align: right; ";
    this.Label9.Text = "Policy No:";
    ((ARControl) this.Label9).Top = 0.5f;
    ((ARControl) this.Label9).Width = 25f / 16f;
    ((ARControl) this.txtPolicyNo).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPolicyNo).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNo).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPolicyNo).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNo).Border.RightColor = Color.Black;
    ((ARControl) this.txtPolicyNo).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNo).Border.TopColor = Color.Black;
    ((ARControl) this.txtPolicyNo).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNo).Height = 3f / 16f;
    ((ARControl) this.txtPolicyNo).Left = 27f / 16f;
    ((ARControl) this.txtPolicyNo).Name = "txtPolicyNo";
    this.txtPolicyNo.Style = "ddo-char-set: 0; ";
    this.txtPolicyNo.Text = (string) null;
    ((ARControl) this.txtPolicyNo).Top = 0.5f;
    ((ARControl) this.txtPolicyNo).Width = 4.625f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.MirrorMargins = true;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.875f;
    this.Sections.Add((Section) this.ReportHeader1);
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter1);
    this.Sections.Add((Section) this.PageFooter);
    this.Sections.Add((Section) this.ReportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtQuotingOffice).EndInit();
    ((ISupportInitialize) this.txtTIV).EndInit();
    ((ISupportInitialize) this.txtState).EndInit();
    ((ISupportInitialize) this.txtTotalTIV).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.txtInsuredPolicyName).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.label33).EndInit();
    ((ISupportInitialize) this.txtLine).EndInit();
    ((ISupportInitialize) this.txtStateID).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtPercentTIV).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtPolicyNo).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public rptAllocationReport(DataSet ds, Quote quote)
  {
    this.ReportStart += new EventHandler(this.rptAllocationReport_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
    this._ds = ds;
    this._quote = quote;
  }

  private void rptAllocationReport_ReportStart(object sender, EventArgs e)
  {
    this.txtPolicyNo.Text = !this._quote.HasPolicyNumber ? "N/A" : this._quote.PolicyNumber;
    this.txtInsuredPolicyName.Text = this._quote.InsuredPolicyName;
    this.txtCompany.Text = this._quote.Company;
    this.txtLine.Text = this._quote.LineName;
    this.txtStateID.Text = this._quote.StateID;
    double num = 0.0;
    DataColumn column = new DataColumn("PercentTIV", Type.GetType("System.Double"));
    if (this._ds.Tables["tblPremiumAllocationStates"].Rows.Count > 0)
    {
      try
      {
        foreach (DataRow row in this._ds.Tables["tblPremiumAllocationStates"].Rows)
        {
          if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row["TIV"])))
            num += Conversion.Val(RuntimeHelpers.GetObjectValue(row["TIV"]));
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (this._ds.Tables["tblPremiumAllocationStates"].Columns.IndexOf("tblPremiumAllocationStates") < 0)
        this._ds.Tables["tblPremiumAllocationStates"].Columns.Add(column);
      try
      {
        foreach (DataRow row in this._ds.Tables["tblPremiumAllocationStates"].Rows)
        {
          if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row["TIV"])))
            row["PercentTIV"] = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(row["TIV"])) / num);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (this._ds.Tables["tblPremiumAllocationStates"].Rows.Count <= 0)
      return;
    DataView defaultView = this._ds.Tables["tblPremiumAllocationStates"].DefaultView;
    defaultView.Sort = "StateID ASC";
    this.DataSource = (object) defaultView;
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtQuotingOffice.Text, string.Empty, false) == 0 || this.txtQuotingOffice.Text.Replace(" ", string.Empty).Length == 0)
      this.txtQuotingOffice.Text = string.Empty;
    else
      this.txtQuotingOffice.Text = ((dsPremiumAllocation.tblClientOfficesRow) this._ds.Tables["tblClientOffices"].Select("OfficeID = " + Conversions.ToString(Conversions.ToInteger(this.txtQuotingOffice.Text)))[0]).Location;
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string FileName)
  {
    ExcelExport.ToExcel(this._ds.Tables["tblPremiumAllocationStates"], FileName);
  }

  public override bool HasRecords => this._ds.Tables["tblPremiumAllocationStates"].Rows.Count > 0;

  private void ReportFooter1_Format(object sender, EventArgs e)
  {
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtState")]
  private virtual TextBox txtState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader1")]
  internal virtual ReportHeader ReportHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ReportFooter ReportFooter1
  {
    get => this._ReportFooter1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter1_Format);
      ReportFooter reportFooter1_1 = this._ReportFooter1;
      if (reportFooter1_1 != null)
        ((Section) reportFooter1_1).Format -= eventHandler;
      this._ReportFooter1 = value;
      ReportFooter reportFooter1_2 = this._ReportFooter1;
      if (reportFooter1_2 == null)
        return;
      ((Section) reportFooter1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label")]
  private virtual Label Label { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInsuredPolicyName")]
  private virtual TextBox txtInsuredPolicyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCompany")]
  private virtual TextBox txtCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label33")]
  private virtual Label label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLine")]
  private virtual TextBox txtLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStateID")]
  private virtual TextBox txtStateID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPercentTIV")]
  private virtual TextBox txtPercentTIV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyNo")]
  private virtual TextBox txtPolicyNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
