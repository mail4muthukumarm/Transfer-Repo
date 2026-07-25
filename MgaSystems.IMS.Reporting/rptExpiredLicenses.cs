// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptExpiredLicenses
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{B00D62C2-322B-4c60-8C4C-017F8A5A943F}", "Expired Licenses", "List of Expired Licenses.", "General")]
public class rptExpiredLicenses : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{B00D62C2-322B-4c60-8C4C-017F8A5A943F}";
  private TextBox txtTitle;
  private Label lblLicenseType;
  private Label lblProducerLocation;
  private Label lblLicenseNumber;
  private Label lblExpires;
  private Label lblProducerContact;
  private TextBox txtProducerLocation;
  private TextBox txtLicenseType;
  private TextBox txtProducerContact;
  private TextBox txtLicenseNumber;
  private TextBox txtExpires;
  private readonly DateTime _priorTo;
  private readonly int _licenseType;
  private int _totalRecords;
  private DataTable _dt;
  private bool _stop;
  private readonly bool _isActiveOnly;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((Section) detail1).BeforePrint -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptExpiredLicenses()
  {
    this.ReportStart += new EventHandler(this.rptExpiredLicenses_ReportStart);
    this._dt = new DataTable();
    this._stop = false;
    this._isActiveOnly = false;
  }

  public rptExpiredLicenses(DateTime priorTo, int licenseType, bool isActiveOnly)
  {
    this.ReportStart += new EventHandler(this.rptExpiredLicenses_ReportStart);
    this._dt = new DataTable();
    this._stop = false;
    this._isActiveOnly = false;
    this.InitializeComponent();
    this._priorTo = priorTo;
    this._licenseType = licenseType;
    this._isActiveOnly = isActiveOnly;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptExpiredLicenses));
    this.Detail = new Detail();
    this.txtProducerLocation = new TextBox();
    this.txtLicenseType = new TextBox();
    this.txtProducerContact = new TextBox();
    this.txtLicenseNumber = new TextBox();
    this.txtExpires = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.txtTitle = new TextBox();
    this.lblLicenseType = new Label();
    this.lblProducerLocation = new Label();
    this.lblLicenseNumber = new Label();
    this.lblExpires = new Label();
    this.lblProducerContact = new Label();
    this.ReportFooter = new ReportFooter();
    ((ISupportInitialize) this.txtProducerLocation).BeginInit();
    ((ISupportInitialize) this.txtLicenseType).BeginInit();
    ((ISupportInitialize) this.txtProducerContact).BeginInit();
    ((ISupportInitialize) this.txtLicenseNumber).BeginInit();
    ((ISupportInitialize) this.txtExpires).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.lblLicenseType).BeginInit();
    ((ISupportInitialize) this.lblProducerLocation).BeginInit();
    ((ISupportInitialize) this.lblLicenseNumber).BeginInit();
    ((ISupportInitialize) this.lblExpires).BeginInit();
    ((ISupportInitialize) this.lblProducerContact).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.txtProducerLocation,
      (ARControl) this.txtLicenseType,
      (ARControl) this.txtProducerContact,
      (ARControl) this.txtLicenseNumber,
      (ARControl) this.txtExpires
    });
    ((Section) this.Detail).Height = 0.125f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtProducerLocation).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducerLocation).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducerLocation).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducerLocation).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducerLocation).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducerLocation).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducerLocation).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducerLocation).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducerLocation).DataField = "ProducerLocation";
    ((ARControl) this.txtProducerLocation).Height = 0.125f;
    ((ARControl) this.txtProducerLocation).Left = 0.0f;
    ((ARControl) this.txtProducerLocation).Name = "txtProducerLocation";
    this.txtProducerLocation.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtProducerLocation.Text = " ";
    ((ARControl) this.txtProducerLocation).Top = 0.0f;
    ((ARControl) this.txtProducerLocation).Width = 29f / 16f;
    ((ARControl) this.txtLicenseType).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLicenseType).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLicenseType).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLicenseType).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLicenseType).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLicenseType).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLicenseType).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLicenseType).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLicenseType).DataField = "LicenseType";
    ((ARControl) this.txtLicenseType).Height = 0.125f;
    ((ARControl) this.txtLicenseType).Left = 29f / 16f;
    ((ARControl) this.txtLicenseType).Name = "txtLicenseType";
    this.txtLicenseType.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtLicenseType.Text = " ";
    ((ARControl) this.txtLicenseType).Top = 0.0f;
    ((ARControl) this.txtLicenseType).Width = 27f / 16f;
    ((ARControl) this.txtProducerContact).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducerContact).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducerContact).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducerContact).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducerContact).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducerContact).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducerContact).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducerContact).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducerContact).DataField = "ProducerContact";
    ((ARControl) this.txtProducerContact).Height = 0.125f;
    ((ARControl) this.txtProducerContact).Left = 3.5f;
    ((ARControl) this.txtProducerContact).Name = "txtProducerContact";
    this.txtProducerContact.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtProducerContact.Text = " ";
    ((ARControl) this.txtProducerContact).Top = 0.0f;
    ((ARControl) this.txtProducerContact).Width = 1.5f;
    ((ARControl) this.txtLicenseNumber).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLicenseNumber).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLicenseNumber).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLicenseNumber).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLicenseNumber).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLicenseNumber).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLicenseNumber).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLicenseNumber).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLicenseNumber).DataField = "LicenseNumber";
    ((ARControl) this.txtLicenseNumber).Height = 0.125f;
    ((ARControl) this.txtLicenseNumber).Left = 5f;
    ((ARControl) this.txtLicenseNumber).Name = "txtLicenseNumber";
    this.txtLicenseNumber.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtLicenseNumber.Text = " ";
    ((ARControl) this.txtLicenseNumber).Top = 0.0f;
    ((ARControl) this.txtLicenseNumber).Width = 21f / 16f;
    ((ARControl) this.txtExpires).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpires).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpires).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpires).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpires).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpires).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpires).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpires).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpires).DataField = "Expires";
    ((ARControl) this.txtExpires).Height = 0.125f;
    ((ARControl) this.txtExpires).Left = 101f / 16f;
    ((ARControl) this.txtExpires).Name = "txtExpires";
    this.txtExpires.OutputFormat = resourceManager.GetString("txtExpires.OutputFormat");
    this.txtExpires.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtExpires.Text = " ";
    ((ARControl) this.txtExpires).Top = 0.0f;
    ((ARControl) this.txtExpires).Width = 11f / 16f;
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.txtTitle,
      (ARControl) this.lblLicenseType,
      (ARControl) this.lblProducerLocation,
      (ARControl) this.lblLicenseNumber,
      (ARControl) this.lblExpires,
      (ARControl) this.lblProducerContact
    });
    this.ReportHeader.Height = 0.4895833f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.txtTitle).Height = 3f / 16f;
    ((ARControl) this.txtTitle).Left = 0.0f;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.Style = "text-align: center; ddo-char-set: 0";
    this.txtTitle.Text = "Expired Licenses";
    ((ARControl) this.txtTitle).Top = 0.0f;
    ((ARControl) this.txtTitle).Width = 7f;
    ((ARControl) this.lblLicenseType).Height = 3f / 16f;
    this.lblLicenseType.HyperLink = (string) null;
    ((ARControl) this.lblLicenseType).Left = 29f / 16f;
    ((ARControl) this.lblLicenseType).Name = "lblLicenseType";
    this.lblLicenseType.Style = "font-size: 8pt; font-weight: bold";
    this.lblLicenseType.Text = "License Type";
    ((ARControl) this.lblLicenseType).Top = 5f / 16f;
    ((ARControl) this.lblLicenseType).Width = 27f / 16f;
    ((ARControl) this.lblProducerLocation).Height = 3f / 16f;
    this.lblProducerLocation.HyperLink = (string) null;
    ((ARControl) this.lblProducerLocation).Left = 0.0f;
    ((ARControl) this.lblProducerLocation).Name = "lblProducerLocation";
    this.lblProducerLocation.Style = "font-size: 8pt; font-weight: bold";
    this.lblProducerLocation.Text = "Producer  Location";
    ((ARControl) this.lblProducerLocation).Top = 5f / 16f;
    ((ARControl) this.lblProducerLocation).Width = 29f / 16f;
    ((ARControl) this.lblLicenseNumber).Height = 3f / 16f;
    this.lblLicenseNumber.HyperLink = (string) null;
    ((ARControl) this.lblLicenseNumber).Left = 5f;
    ((ARControl) this.lblLicenseNumber).Name = "lblLicenseNumber";
    this.lblLicenseNumber.Style = "font-size: 8pt; font-weight: bold";
    this.lblLicenseNumber.Text = "License Number";
    ((ARControl) this.lblLicenseNumber).Top = 5f / 16f;
    ((ARControl) this.lblLicenseNumber).Width = 21f / 16f;
    ((ARControl) this.lblExpires).Height = 3f / 16f;
    this.lblExpires.HyperLink = (string) null;
    ((ARControl) this.lblExpires).Left = 101f / 16f;
    ((ARControl) this.lblExpires).Name = "lblExpires";
    this.lblExpires.Style = "font-size: 8pt; font-weight: bold";
    this.lblExpires.Text = "Expires";
    ((ARControl) this.lblExpires).Top = 5f / 16f;
    ((ARControl) this.lblExpires).Width = 11f / 16f;
    ((ARControl) this.lblProducerContact).Height = 3f / 16f;
    this.lblProducerContact.HyperLink = (string) null;
    ((ARControl) this.lblProducerContact).Left = 3.5f;
    ((ARControl) this.lblProducerContact).Name = "lblProducerContact";
    this.lblProducerContact.Style = "font-size: 8pt; font-weight: bold";
    this.lblProducerContact.Text = "Producer  Contact";
    ((ARControl) this.lblProducerContact).Top = 5f / 16f;
    ((ARControl) this.lblProducerContact).Width = 1.5f;
    this.ReportFooter.Height = 0.0f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; text-align: left; vertical-align: top; ddo-char-set: 1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: bold", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtProducerLocation).EndInit();
    ((ISupportInitialize) this.txtLicenseType).EndInit();
    ((ISupportInitialize) this.txtProducerContact).EndInit();
    ((ISupportInitialize) this.txtLicenseNumber).EndInit();
    ((ISupportInitialize) this.txtExpires).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.lblLicenseType).EndInit();
    ((ISupportInitialize) this.lblProducerLocation).EndInit();
    ((ISupportInitialize) this.lblLicenseNumber).EndInit();
    ((ISupportInitialize) this.lblExpires).EndInit();
    ((ISupportInitialize) this.lblProducerContact).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void queryComplete(object sender, TableQueryMultithreadEventArgs e) => this._stop = true;

  private void queryProgress(object sender, TableFillingEventArgs e)
  {
    if (this._dt.Rows.Count == 0)
    {
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) e.Row.Table.Columns)
          this._dt.Columns.Add(column.Caption, column.DataType);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.IncreaseProgressbar(1);
    this._dt.ImportRow(e.Row);
    this.SetStatusText($"Getting info on License Number {e.Row["LicenseNumber"].ToString()}...");
  }

  private void rptExpiredLicenses_ReportStart(object sender, EventArgs e)
  {
    ArrayList arrayList = new ArrayList();
    arrayList.Add((object) "@priorTo");
    arrayList.Add((object) this._priorTo);
    arrayList.Add((object) "@ActiveProducersOnly");
    arrayList.Add((object) this._isActiveOnly);
    if (this._licenseType != -1)
    {
      arrayList.Add((object) "@licenseType");
      arrayList.Add((object) this._licenseType);
      this.txtTitle.Text = $"Expired License Report for {DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 LicenseType FROM lstLicenseTypes WHERE LicenseTypeID = @ID", new object[2]
      {
        (object) "@ID",
        (object) this._licenseType
      })} prior to {this._priorTo.ToString("MM/dd/yyyy")}";
      arrayList.Add((object) "@getCount");
      arrayList.Add((object) 1);
      this._totalRecords = DefaultDatabase.ExecuteScalar<int>(nameof (rptExpiredLicenses), arrayList.ToArray());
      arrayList.RemoveRange(arrayList.Count - 2, 2);
      this.SetProgressbarMaximum(this._totalRecords);
      Database.Instance.QueryMultithreadedSP.PerformTableQueryBG(new TableQueryMultithreadEventHandler(this.queryComplete), new TableFillingEventHandler(this.queryProgress), (object) "Expired Licenses Report", nameof (rptExpiredLicenses), arrayList.ToArray());
    }
    else
    {
      arrayList.Add((object) "@getCount");
      arrayList.Add((object) 1);
      this._totalRecords = DefaultDatabase.ExecuteScalar<int>(nameof (rptExpiredLicenses), arrayList.ToArray());
      arrayList.RemoveRange(arrayList.Count - 2, 2);
      this.SetProgressbarMaximum(this._totalRecords);
      Database.Instance.QueryMultithreadedSP.PerformTableQueryBG(new TableQueryMultithreadEventHandler(this.queryComplete), new TableFillingEventHandler(this.queryProgress), (object) "Expired Licenses Report", nameof (rptExpiredLicenses), arrayList.ToArray());
    }
    while (!this._stop)
      Thread.Sleep(1000);
    this.SetStatusText("Formatting...");
    this.DataSource = (object) this._dt;
    this.SetStandardMargins();
    this.ShowPageNumbers();
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new DatePicker("Prior To", DateAndTime.Now.Date, false),
        (BaseReportControl) new LicenseTypes("License Type", true),
        (BaseReportControl) new GenericCheckBox("", "Active Producers Only", false)
      };
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    Workbook workbook = new Workbook();
    workbook.Worksheets.Clear();
    Worksheet worksheet = workbook.Worksheets.Add("Expired Licenses");
    Style style = worksheet.Cells[0, 0].GetStyle();
    StyleFlag styleFlag = new StyleFlag();
    styleFlag.All = true;
    Font font = style.Font;
    font.Name = "Arial";
    font.Size = 12;
    font.Color = Color.Black;
    font.IsBold = true;
    font.IsItalic = false;
    worksheet.Cells["A1"].PutValue("Expired Licenses");
    worksheet.Cells["A1"].SetStyle(style);
    worksheet.Cells.ImportDataTable(this._dt, true, 2, 0);
    font.Size = 10;
    worksheet.Cells.CreateRange("A3:E3").ApplyStyle(style, styleFlag);
    worksheet.AutoFitColumns();
    workbook.Save(SaveFileTo);
  }
}
