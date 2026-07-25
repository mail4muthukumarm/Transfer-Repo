// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.Claim_OFAC
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{EA76AA28-6860-48c0-A8B4-79879F496FCF}", "Claim OFAC report", "Claim OFAC report", "Claims")]
public class Claim_OFAC : MGAReport, IReport
{
  private Guid _OfficeGuid;
  private bool _ShowIndividualContacts;
  private DataSet _ds;
  private int _StatusID;
  private string _ProducerLocationGuid;
  private int _ProducerTypeID;
  private DataTable _ExcelDT;
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private int _rowCount;

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  internal virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  internal virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  internal virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  internal virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  internal virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  internal virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  internal virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line1")]
  internal virtual Line Line1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line2")]
  internal virtual Line Line2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  internal virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (Claim_OFAC));
    this.Detail = new Detail();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.PageHeader = new PageHeader();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.Line1 = new Line();
    this.PageFooter = new PageFooter();
    this.Line2 = new Line();
    this.ReportInfo1 = new ReportInfo();
    this.TextBox14 = new TextBox();
    this.TextBox15 = new TextBox();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox15
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.2604167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox8).DataField = "PayeeName";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 5.937f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.062f;
    ((ARControl) this.TextBox8).Width = 1.5f;
    ((ARControl) this.TextBox9).DataField = "InsuredPolicyName";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 1.125f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 1f / 16f;
    ((ARControl) this.TextBox9).Width = 1.625f;
    ((ARControl) this.TextBox10).DataField = "OFACValidated";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 2.812f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.TextBox10.Text = " 02/12/2012";
    ((ARControl) this.TextBox10).Top = 0.062f;
    ((ARControl) this.TextBox10).Width = 15f / 16f;
    ((ARControl) this.TextBox11).DataField = "OFACResponse";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 3.812f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.062f;
    ((ARControl) this.TextBox11).Width = 2.063f;
    ((ARControl) this.TextBox12).DataField = "PolicyNumber";
    ((ARControl) this.TextBox12).Height = 0.1979167f;
    ((ARControl) this.TextBox12).Left = 1f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 1f / 16f;
    ((ARControl) this.TextBox12).Width = 1f;
    ((ARControl) this.TextBox13).DataField = "ClaimPayees_Address";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 7.5f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 0.062f;
    ((ARControl) this.TextBox13).Width = 1.562f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.Line1,
      (ARControl) this.TextBox14
    });
    this.PageHeader.Height = 19f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.TextBox1).Height = 0.25f;
    ((ARControl) this.TextBox1).Left = 1f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 12pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.TextBox1.Text = "Claim OFAC Report";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 10f;
    ((ARControl) this.TextBox2).Height = 0.1979167f;
    ((ARControl) this.TextBox2).Left = 1f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.TextBox2.Text = "Policy Number";
    ((ARControl) this.TextBox2).Top = 5f / 16f;
    ((ARControl) this.TextBox2).Width = 1f;
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 1.125f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.TextBox3.Text = "Insured Name";
    ((ARControl) this.TextBox3).Top = 5f / 16f;
    ((ARControl) this.TextBox3).Width = 1.625f;
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 2.812f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.TextBox4.Text = "OFAC Validated";
    ((ARControl) this.TextBox4).Top = 0.312f;
    ((ARControl) this.TextBox4).Width = 15f / 16f;
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 3.812f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.TextBox5.Text = "OFAC Response";
    ((ARControl) this.TextBox5).Top = 0.312f;
    ((ARControl) this.TextBox5).Width = 2.063f;
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 5.937f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.TextBox6.Text = "Payee Name";
    ((ARControl) this.TextBox6).Top = 0.312f;
    ((ARControl) this.TextBox6).Width = 1.5f;
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 7.5f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.TextBox7.Text = "Payee Address";
    ((ARControl) this.TextBox7).Top = 0.312f;
    ((ARControl) this.TextBox7).Width = 1.562f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 1f / 16f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 9f / 16f;
    ((ARControl) this.Line1).Width = 161f / 16f;
    this.Line1.X1 = 1f / 16f;
    this.Line1.X2 = 10.125f;
    this.Line1.Y1 = 9f / 16f;
    this.Line1.Y2 = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Line2,
      (ARControl) this.ReportInfo1
    });
    this.PageFooter.Height = 0.2708333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 0.0f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 0.0f;
    ((ARControl) this.Line2).Width = 161f / 16f;
    this.Line2.X1 = 0.0f;
    this.Line2.X2 = 161f / 16f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.0f;
    this.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
    ((ARControl) this.ReportInfo1).Height = 3f / 16f;
    ((ARControl) this.ReportInfo1).Left = 8.125f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "text-align: right";
    ((ARControl) this.ReportInfo1).Top = 1f / 16f;
    ((ARControl) this.ReportInfo1).Width = 31f / 16f;
    ((ARControl) this.TextBox14).Height = 3f / 16f;
    ((ARControl) this.TextBox14).Left = 9.125f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.TextBox14.Text = "Check Number";
    ((ARControl) this.TextBox14).Top = 0.312f;
    ((ARControl) this.TextBox14).Width = 0.9370003f;
    ((ARControl) this.TextBox15).DataField = "checknum";
    ((ARControl) this.TextBox15).Height = 3f / 16f;
    ((ARControl) this.TextBox15).Left = 9.125f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox15.Text = " ";
    ((ARControl) this.TextBox15).Top = 0.062f;
    ((ARControl) this.TextBox15).Width = 0.937f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("TextBox15")]
  private virtual TextBox TextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  private virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public Claim_OFAC()
  {
    this.ReportStart += new EventHandler(this.Claim_OFAC_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
  }

  public Claim_OFAC(DateTime DateFrom, DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.Claim_OFAC_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
  }

  private void Claim_OFAC_ReportStart(object sender, EventArgs e)
  {
    this.HidePrintDateAndTime();
    this.BouncingProgress(true);
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(nameof (Claim_OFAC), dbConnection))
      {
        command.CommandType = CommandType.StoredProcedure;
        if (!this._DateFrom.Equals(DateTime.MinValue))
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@DateFrom", (object) this._DateFrom);
        if (!this._DateTo.Equals(DateTime.MinValue))
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@DateTo", (object) this._DateTo);
        using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command))
          DefaultDatabase.DataAdapterFill(dataAdapter, this._ds);
      }
    }
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void Detail_Format(object sender, EventArgs e)
  {
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string FileName)
  {
    ExcelExport.ToExcel(this._ds.Tables[0], FileName);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[1];
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[0] = (BaseReportControl) new DateRangePicker("Validation  Date", date1, date2, true);
      return getReportControls;
    }
  }
}
