// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptActivityLog
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{2D420233-B30C-4dec-9337-F912B05393D3}", "Activity Log report", "Shows activity logged by the system for a specific user in a specified date range", "General")]
public class rptActivityLog : MGAReport, IReport
{
  private readonly string _userIDs;
  private readonly DateTime _DateFrom;
  private readonly DateTime _DateTo;
  private DataSet _ds;
  private Label Label;
  private TextBox TextBox;
  private TextBox TextBox1;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptActivityLog()
  {
    this.ReportStart += new EventHandler(this.rptActivityLog_ReportStart);
    this.ReportHeader = (ReportHeader) null;
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.ReportFooter = (ReportFooter) null;
    this.Label = (Label) null;
    this.TextBox = (TextBox) null;
    this.TextBox1 = (TextBox) null;
    this.Label1 = (Label) null;
    this.Label2 = (Label) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.TextBox2 = (TextBox) null;
    this.TextBox3 = (TextBox) null;
    this.TextBox4 = (TextBox) null;
    this.TextBox5 = (TextBox) null;
    this.InitializeComponent();
  }

  public rptActivityLog(DateTime DateFrom, DateTime DateTo, string UserGuid)
  {
    this.ReportStart += new EventHandler(this.rptActivityLog_ReportStart);
    this.ReportHeader = (ReportHeader) null;
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.ReportFooter = (ReportFooter) null;
    this.Label = (Label) null;
    this.TextBox = (TextBox) null;
    this.TextBox1 = (TextBox) null;
    this.Label1 = (Label) null;
    this.Label2 = (Label) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.TextBox2 = (TextBox) null;
    this.TextBox3 = (TextBox) null;
    this.TextBox4 = (TextBox) null;
    this.TextBox5 = (TextBox) null;
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._userIDs = UserGuid;
  }

  private void rptActivityLog_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = new DataSet();
    object dateFrom = (object) DBNull.Value;
    object dateTo = (object) DBNull.Value;
    object userIds = (object) DBNull.Value;
    object currentUserGuid = (object) DBNull.Value;
    if (!this._DateFrom.Equals(DateTime.MinValue))
      dateFrom = (object) this._DateFrom;
    if (!this._DateTo.Equals(DateTime.MinValue))
      dateTo = (object) this._DateTo;
    if (!this._userIDs.Equals(string.Empty))
      userIds = (object) this._userIDs;
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals(Guid.Empty))
      currentUserGuid = (object) this.CurrentUserGuid;
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, nameof (rptActivityLog), 0, (CommandArgumentType) 0, new object[8]
    {
      (object) "@DateFrom",
      dateFrom,
      (object) "@DateTo",
      dateTo,
      (object) "@UserIDs",
      userIds,
      (object) "@CurrentUserGuid",
      currentUserGuid
    });
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void ReportHeader_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.TextBox.Text = string.Format(this.TextBox.Text, RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["UserName"]));
    TextBox textBox1 = this.TextBox1;
    string text = this.TextBox1.Text;
    DateTime dateTime = this._DateFrom;
    string shortDateString1 = dateTime.ToShortDateString();
    dateTime = this._DateTo;
    string shortDateString2 = dateTime.ToShortDateString();
    string str = string.Format(text, (object) shortDateString1, (object) shortDateString2);
    textBox1.Text = str;
  }

  private virtual ReportHeader ReportHeader
  {
    get => this._ReportHeader;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportHeader_Format);
      ReportHeader reportHeader1 = this._ReportHeader;
      if (reportHeader1 != null)
        ((Section) reportHeader1).Format -= eventHandler;
      this._ReportHeader = value;
      ReportHeader reportHeader2 = this._ReportHeader;
      if (reportHeader2 == null)
        return;
      ((Section) reportHeader2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptActivityLog));
    this.Detail = new Detail();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label = new Label();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7
    });
    ((Section) this.Detail).Height = 0.2083333f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox2).DataField = "Username";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 0.0f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.7291667f;
    ((ARControl) this.TextBox3).DataField = "ControlNo";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 0.7291667f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 25f / 32f;
    ((ARControl) this.TextBox4).DataField = "Action";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 4.208333f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 2.603667f;
    ((ARControl) this.TextBox5).DataField = "ActionDate";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 6.812f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 1.094f;
    ((ARControl) this.TextBox6).DataField = "InsuredPolicyName";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 1.510417f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 1.760417f;
    ((ARControl) this.TextBox7).DataField = "LOB";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 3.270833f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 15f / 16f;
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1
    });
    this.ReportHeader.Height = 0.8229167f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 12pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label.Text = "Activity Log";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 7.875f;
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 0.0f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox.Text = "User: {0}";
    ((ARControl) this.TextBox).Top = 0.25f;
    ((ARControl) this.TextBox).Width = 7.875f;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox1.Text = "From: {0} To: {1}";
    ((ARControl) this.TextBox1).Top = 0.5f;
    ((ARControl) this.TextBox1).Width = 7.875f;
    this.ReportFooter.Height = 0.0f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6
    });
    this.PageHeader.Height = 0.25f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 0.25f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "Username";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 0.7291667f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 0.25f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.7291667f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label2.Text = "Control #";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 25f / 32f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 0.25f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 4.208333f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label3.Text = "Action";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 2.603667f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 0.25f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 6.812f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label4.Text = "Action Date";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 1.094f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 0.25f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 1.510417f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label5.Text = "Insured";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 1.760417f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 0.25f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 3.270833f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label6.Text = "LOB";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 15f / 16f;
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter);
    this.Sections.Add((Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DateRangePicker("Activity Date Range", true),
        (BaseReportControl) new GenericListBox("Users", string.Format("SELECT FirstName + ' ' + LastName As Display, UserID As Value FROM tblUsers ORDER BY Display", (object) Guid.Empty), "Value", "Display", true, typeof (int), true, false, 160 /*0xA0*/)
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    DataTable dataTable1 = new DataTable();
    DataSet source = new DataSet();
    int index = 0;
    double num1 = (double) (this._ds.Tables[0].Rows.Count - 1);
    double num2 = Math.Ceiling(num1 / 65000.0) - 1.0;
    for (double num3 = 0.0; num3 <= num2; ++num3)
    {
      DataTable dataTable2 = new DataTable();
      DataTable table = this._ds.Tables[0].Clone();
      for (; ((double) index - 65000.0 * (double) (index / 65000) != 0.0 || index < 65000) && (double) index < num1 - 1.0; ++index)
        table.ImportRow(this._ds.Tables[0].Rows[index]);
      table.ImportRow(this._ds.Tables[0].Rows[index]);
      ++index;
      table.TableName = "Table" + Convert.ToString(index);
      source.Tables.Add(table);
    }
    ExcelExport.ToExcel(source, SaveFileTo);
  }
}
