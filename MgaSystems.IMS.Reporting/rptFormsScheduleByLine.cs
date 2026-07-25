// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptFormsScheduleByLine
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{CDDEDBA2-AE6A-44ca-A1AD-543E488B817B}", Enums.AutomationDocGroups.PolicyDoc, "Forms Schedule By Line", "Lists PolicyForms by Associated Line")]
public class rptFormsScheduleByLine : SectionReport, IQuoteDocument
{
  private Label Label1;
  private Label Label2;
  private TextBox txtInsuredPolicyName;
  private Label Label3;
  private TextBox txtPolicyNumber;
  private TextBox txtLocationName;
  private Label Label4;
  private Label Label5;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private Guid _QuoteOptionGuid;
  private Guid _QuoteGuid;

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptFormsScheduleByLine));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.txtInsuredPolicyName = new TextBox();
    this.Label3 = new Label();
    this.txtPolicyNumber = new TextBox();
    this.txtLocationName = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.GroupHeader1 = new GroupHeader();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.TextBox = new TextBox();
    this.GroupFooter1 = new GroupFooter();
    this.PageHeader1 = new PageHeader();
    this.PageFooter1 = new PageFooter();
    this.ReportInfo1 = new ReportInfo();
    this.txtFormNumber = new TextBox();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.txtInsuredPolicyName).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.txtLocationName).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this.txtFormNumber).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2
    });
    ((Section) this.Detail).Height = 3f / 16f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).DataField = "FormName";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 87f / 16f;
    ((ARControl) this.TextBox2).DataField = "FormNumber";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 5.625f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "text-align: left; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 35f / 16f;
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.txtInsuredPolicyName,
      (ARControl) this.Label3,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.txtLocationName
    });
    this.ReportHeader.Height = 35f / 32f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label1).DataField = " ";
    ((ARControl) this.Label1).Height = 5f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-family: Times New Roman; font-size: 20pt; font-weight: bold; text-align: center";
    this.Label1.Text = "Schedule of Forms";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 7.875f;
    ((ARControl) this.Label2).DataField = " ";
    ((ARControl) this.Label2).Height = 0.2495f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 12pt";
    this.Label2.Text = "Named Insured:";
    ((ARControl) this.Label2).Top = 7f / 16f;
    ((ARControl) this.Label2).Width = 1.25f;
    ((ARControl) this.txtInsuredPolicyName).DataField = " ";
    ((ARControl) this.txtInsuredPolicyName).Height = 0.2495f;
    ((ARControl) this.txtInsuredPolicyName).Left = 1.25f;
    ((ARControl) this.txtInsuredPolicyName).Name = "txtInsuredPolicyName";
    this.txtInsuredPolicyName.Style = "font-size: 12pt";
    this.txtInsuredPolicyName.Text = (string) null;
    ((ARControl) this.txtInsuredPolicyName).Top = 7f / 16f;
    ((ARControl) this.txtInsuredPolicyName).Width = 6.625f;
    ((ARControl) this.Label3).DataField = " ";
    ((ARControl) this.Label3).Height = 0.3745f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.0f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 12pt";
    this.Label3.Text = "Policy No:";
    ((ARControl) this.Label3).Top = 11f / 16f;
    ((ARControl) this.Label3).Width = 1f;
    ((ARControl) this.txtPolicyNumber).DataField = " ";
    ((ARControl) this.txtPolicyNumber).Height = 0.3745f;
    ((ARControl) this.txtPolicyNumber).Left = 1f;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.Style = "font-size: 12pt";
    this.txtPolicyNumber.Text = (string) null;
    ((ARControl) this.txtPolicyNumber).Top = 11f / 16f;
    ((ARControl) this.txtPolicyNumber).Width = 2f;
    ((ARControl) this.txtLocationName).DataField = " ";
    ((ARControl) this.txtLocationName).Height = 0.375f;
    ((ARControl) this.txtLocationName).Left = 3f;
    ((ARControl) this.txtLocationName).Name = "txtLocationName";
    this.txtLocationName.Style = "font-size: 12pt";
    this.txtLocationName.Text = (string) null;
    ((ARControl) this.txtLocationName).Top = 11f / 16f;
    ((ARControl) this.txtLocationName).Width = 4.875f;
    this.ReportFooter.Height = 0.0f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((Section) this.GroupHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.TextBox
    });
    this.GroupHeader1.DataField = "PackageOrder";
    this.GroupHeader1.GroupKeepTogether = (GroupKeepTogether) 1;
    this.GroupHeader1.Height = 0.6458333f;
    this.GroupHeader1.KeepTogether = true;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label4).Height = 0.25f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 0.0f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 12pt; font-weight: bold; text-align: center";
    this.Label4.Text = "Form Name";
    ((ARControl) this.Label4).Top = 0.375f;
    ((ARControl) this.Label4).Width = 5.625f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label5).Height = 0.25f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 5.625f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 12pt; font-weight: bold; text-align: left";
    this.Label5.Text = "Form Number";
    ((ARControl) this.Label5).Top = 0.375f;
    ((ARControl) this.Label5).Width = 35f / 16f;
    ((ARControl) this.TextBox).DataField = "LineName";
    ((ARControl) this.TextBox).Height = 0.25f;
    ((ARControl) this.TextBox).Left = 0.0f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 14.25pt; font-weight: bold; ddo-char-set: 0";
    this.TextBox.Text = (string) null;
    ((ARControl) this.TextBox).Top = 0.125f;
    ((ARControl) this.TextBox).Width = 7.875f;
    this.GroupFooter1.Height = 0.0f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    this.PageHeader1.Height = 0.0f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
    ((Section) this.PageFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.ReportInfo1,
      (ARControl) this.txtFormNumber
    });
    this.PageFooter1.Height = 9f / 32f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    this.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
    ((ARControl) this.ReportInfo1).Height = 3f / 16f;
    ((ARControl) this.ReportInfo1).Left = 5.5f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "text-align: right";
    ((ARControl) this.ReportInfo1).Top = 1f / 16f;
    ((ARControl) this.ReportInfo1).Width = 37f / 16f;
    ((ARControl) this.txtFormNumber).Height = 3f / 16f;
    ((ARControl) this.txtFormNumber).Left = 0.0f;
    ((ARControl) this.txtFormNumber).Name = "txtFormNumber";
    this.txtFormNumber.Style = "font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.txtFormNumber.Text = (string) null;
    ((ARControl) this.txtFormNumber).Top = 1f / 16f;
    ((ARControl) this.txtFormNumber).Width = 47f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter1);
    this.Sections.Add((Section) this.PageFooter1);
    this.Sections.Add((Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.txtInsuredPolicyName).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.txtLocationName).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this.txtFormNumber).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  internal virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  internal virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  internal virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFormNumber")]
  private virtual TextBox txtFormNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptFormsScheduleByLine()
  {
    this.ReportStart += new EventHandler(this.rptFormsScheduleByLine_ReportStart);
    this.InitializeComponent();
  }

  public rptFormsScheduleByLine(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptFormsScheduleByLine_ReportStart);
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
  }

  private void rptFormsScheduleByLine_ReportStart(object sender, EventArgs e)
  {
    DataSet dataSet = new DataSet();
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter())
      {
        dataAdapter.SelectCommand = DefaultDatabase.CreateCommand();
        DbCommand selectCommand = dataAdapter.SelectCommand;
        selectCommand.CommandText = "[rptFormsScheduleByLine_v1]";
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Connection = dbConnection;
        DbParameterCollectionExtensions.AddWithValue(selectCommand.Parameters, "@QuoteGuid", (object) this._QuoteGuid);
        selectCommand.CommandTimeout = 0;
        DefaultDatabase.DataAdapterFill(dataAdapter, dataSet);
      }
    }
    if (dataSet.Tables[0].Rows.Count <= 0)
      return;
    this.txtInsuredPolicyName.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0]["InsuredPolicyName"]);
    this.txtPolicyNumber.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0]["PolicyNumber"]);
    this.txtLocationName.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0]["LocationName"]);
    this.txtFormNumber.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0]["FormNumber"]);
    this.DataSource = (object) dataSet.Tables[1];
  }

  public bool RequiresQuoteOptionGuids() => true;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    this._QuoteOptionGuid = quoteOptionGuids[0];
  }
}
