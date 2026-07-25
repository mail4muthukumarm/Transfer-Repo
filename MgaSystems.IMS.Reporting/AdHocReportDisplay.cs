// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.AdHocReportDisplay
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MgaSystems.LargeDataExcelExport;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
public class AdHocReportDisplay : MGAReport, IReport
{
  private DataSet _ds;
  private AdHocReport _report;
  private Guid _reportGuid;
  private readonly object[] _params;
  private Font _lblFont;
  private Font _txtFont;
  private readonly Dictionary<string, string> _ClientSelectedCriteria;
  private readonly Dictionary<string, string> _CommonReportData;
  private SqlCommand command;
  private bool _isLayoutDefined;
  private MgaSystems.LargeDataExcelExport.ExcelExport _xcl;
  private LargeDataExcelExportOptions _xclOpt;
  private int _recordsWritten;
  private readonly bool _usingReportingServer;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    this.command.Dispose();
    base.Dispose(disposing);
  }

  private virtual Detail Detail1
  {
    get => this._Detail1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail1_BeforePrint);
      Detail detail1_1 = this._Detail1;
      if (detail1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1_1).BeforePrint -= eventHandler;
      this._Detail1 = value;
      Detail detail1_2 = this._Detail1;
      if (detail1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1_2).BeforePrint += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (AdHocReportDisplay));
    this.Detail1 = new Detail();
    this.ReportHeader1 = new ReportHeader();
    this.lblExport2Excel = new Label();
    this.lblTitle = new Label();
    this.lblSubTitle = new TextBox();
    this.ReportFooter1 = new ReportFooter();
    this.PageHeader1 = new PageHeader();
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this.lblExport2Excel).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.lblSubTitle).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.0f;
    this.Detail1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblExport2Excel,
      (ARControl) this.lblTitle,
      (ARControl) this.lblSubTitle
    });
    this.ReportHeader1.Height = 0.5208333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Name = "ReportHeader1";
    ((ARControl) this.lblExport2Excel).Height = 0.4895833f;
    this.lblExport2Excel.HyperLink = (string) null;
    ((ARControl) this.lblExport2Excel).Left = 0.0f;
    ((ARControl) this.lblExport2Excel).Name = "lblExport2Excel";
    this.lblExport2Excel.Style = "font-size: 26.25pt; text-align: center; ddo-char-set: 0";
    this.lblExport2Excel.Text = "EXPORT TO EXCEL";
    ((ARControl) this.lblExport2Excel).Top = 0.0f;
    ((ARControl) this.lblExport2Excel).Visible = false;
    ((ARControl) this.lblExport2Excel).Width = 8.75f;
    ((ARControl) this.lblTitle).Height = 9f / 32f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 14.25pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.lblTitle.Text = "title";
    ((ARControl) this.lblTitle).Top = 0.04374997f;
    ((ARControl) this.lblTitle).Visible = false;
    ((ARControl) this.lblTitle).Width = 8.75f;
    ((ARControl) this.lblSubTitle).Height = 5f / 32f;
    ((ARControl) this.lblSubTitle).Left = 0.0f;
    ((ARControl) this.lblSubTitle).Name = "lblSubTitle";
    this.lblSubTitle.Style = "font-size: 11.25pt; text-align: center; ddo-char-set: 0";
    this.lblSubTitle.Text = "SubTitle";
    ((ARControl) this.lblSubTitle).Top = 0.3333333f;
    ((ARControl) this.lblSubTitle).Visible = false;
    ((ARControl) this.lblSubTitle).Width = 8.75f;
    this.ReportFooter1.Height = 0.02083333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Name = "ReportFooter1";
    this.PageHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.75f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.lblExport2Excel).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.lblSubTitle).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  internal virtual ReportHeader ReportHeader1
  {
    get => this._ReportHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportHeader1_Format);
      ReportHeader reportHeader1_1 = this._ReportHeader1;
      if (reportHeader1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportHeader1_1).Format -= eventHandler;
      this._ReportHeader1 = value;
      ReportHeader reportHeader1_2 = this._ReportHeader1;
      if (reportHeader1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportHeader1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblExport2Excel")]
  internal virtual Label lblExport2Excel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter1")]
  internal virtual ReportFooter ReportFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTitle")]
  internal virtual Label lblTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader1")]
  internal virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  internal virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSubTitle")]
  internal virtual TextBox lblSubTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public Guid ReportGuid
  {
    get => this._reportGuid;
    set => this._reportGuid = value;
  }

  public SqlCommand SQLCommand => this.command;

  public AdHocReportDisplay()
  {
    this.ReportStart += new EventHandler(this.AdHocReportDisplay_ReportStart);
    this._ds = new DataSet();
    this._lblFont = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point);
    this._txtFont = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point);
    this._ClientSelectedCriteria = new Dictionary<string, string>();
    this._CommonReportData = new Dictionary<string, string>();
    this._isLayoutDefined = false;
    this._recordsWritten = 0;
    this.InitializeComponent();
  }

  public AdHocReportDisplay(params object[] @params)
  {
    this.ReportStart += new EventHandler(this.AdHocReportDisplay_ReportStart);
    this._ds = new DataSet();
    this._lblFont = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point);
    this._txtFont = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point);
    this._ClientSelectedCriteria = new Dictionary<string, string>();
    this._CommonReportData = new Dictionary<string, string>();
    this._isLayoutDefined = false;
    this._recordsWritten = 0;
    this.InitializeComponent();
    if (((IEnumerable<object>) @params).ElementAt<object>(Information.UBound((Array) @params)).ToString().Contains("UseReportingServer"))
    {
      this._usingReportingServer = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((IEnumerable<object>) @params).ElementAt<object>(@params.Length - 1).ToString(), "UseReportingServerTrue", false) == 0;
      @params = (object[]) Utils.CopyArray((Array) @params, (Array) new object[Information.UBound((Array) @params) - 1 + 1]);
    }
    this._params = @params;
  }

  private SqlConnection CreateSqlConnection()
  {
    SqlConnection sqlConnection;
    try
    {
      if (this._usingReportingServer)
      {
        string setting = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("ReportingConfiguration", "");
        if (!string.IsNullOrWhiteSpace(setting))
        {
          string connectionString = new Encryption().DecryptTripleDes(setting);
          CurrentUser.Instance.LogAction("Creating Reporting DB Connection", "AdHoc Reporting");
          sqlConnection = new SqlConnection(connectionString);
          goto label_5;
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
    CurrentUser.Instance.LogAction("Creating Default Connection", "AdHoc Reporting");
    sqlConnection = DefaultDatabase.CreateConnection();
label_5:
    return sqlConnection;
  }

  private void AdHocReportDisplay_ReportStart(object sender, EventArgs e)
  {
    object obj = this._params[0];
    this._report = new AdHocReport(obj != null ? (Guid) obj : new Guid());
    this._reportGuid = this._report.GUID;
    SqlConnection sqlConnection = this.CreateSqlConnection();
    this.command = new SqlCommand(this._report.SQL, sqlConnection);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.command);
    this.command.CommandType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Left(this._report.SQL, 6).ToUpper(), "SELECT", false) != 0 ? CommandType.StoredProcedure : CommandType.Text;
    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
    DataRow[] dataRowArray1 = this._report.Criteria.Select("", "LineNo ASC");
    int index1 = 1;
    DataRow[] dataRowArray2 = dataRowArray1;
    int index2 = 0;
    while (index2 < dataRowArray2.Length)
    {
      DataRow dr = dataRowArray2[index2];
      if (this.ParamWorthToAdd(RuntimeHelpers.GetObjectValue(this._params[index1])))
      {
        this.command.Parameters.AddWithValue(dr["SQLParam1Name"].ToString(), RuntimeHelpers.GetObjectValue(this._params[index1]));
        this._ClientSelectedCriteria.Add(dr["SQLParam1Name"].ToString(), this.GetReadableParamValue(dr, RuntimeHelpers.GetObjectValue(this._params[index1]), 1));
      }
      else
        this._ClientSelectedCriteria.Add(dr["SQLParam1Name"].ToString(), "All");
      ++index1;
      if (!dr["SQLParam2Name"].Equals((object) DBNull.Value) && !dr["SQLParam2Name"].Equals((object) string.Empty))
      {
        if (this._params[index1] != null)
        {
          this.command.Parameters.AddWithValue(dr["SQLParam2Name"].ToString(), RuntimeHelpers.GetObjectValue(this._params[index1]));
          this._ClientSelectedCriteria.Add(dr["SQLParam2Name"].ToString(), this.GetReadableParamValue(dr, RuntimeHelpers.GetObjectValue(this._params[index1]), 2));
        }
        ++index1;
      }
      checked { ++index2; }
    }
    if (this.command.CommandType == CommandType.Text)
    {
      int index3 = 1;
      DataRow[] dataRowArray3 = dataRowArray1;
      int index4 = 0;
      while (index4 < dataRowArray3.Length)
      {
        DataRow dataRow = dataRowArray3[index4];
        if (!this.ParamWorthToAdd(RuntimeHelpers.GetObjectValue(this._params[index3])))
          this.command.CommandText = Strings.Replace(this.command.CommandText, dataRow["SQLParam1Name"].ToString(), "NULL");
        ++index3;
        if (!dataRow["SQLParam2Name"].Equals((object) DBNull.Value))
        {
          if (this._params[index3] == null)
            this.command.CommandText = Strings.Replace(this.command.CommandText, dataRow["SQLParam2Name"].ToString(), "NULL");
          ++index3;
        }
        checked { ++index4; }
      }
    }
    if (!this._ClientSelectedCriteria.ContainsKey("@ReportRunDate"))
      this._CommonReportData.Add("@ReportRunDate", DateTime.Now.ToShortDateString());
    if (this._report.isThreaded)
      this.AddCommandToCancelList(this.command);
    if (this._report.isLargeExport)
    {
      this._report.AllowPrint = false;
      if (this._report.TableNames.Trim().Length > 0)
      {
        this._xclOpt = new LargeDataExcelExportOptions();
        this._xclOpt.TableNames = new List<string>((IEnumerable<string>) this._report.TableNames.Trim().Split(';'));
        this._xcl = new MgaSystems.LargeDataExcelExport.ExcelExport(this._xclOpt);
      }
      else
        this._xcl = new MgaSystems.LargeDataExcelExport.ExcelExport();
      try
      {
        this._recordsWritten = this._xcl.RetrieveData(this.command, MGATempFolder.MGATempPath);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection.Close();
        sqlConnection.Dispose();
      }
    }
    else
    {
      try
      {
        sqlDataAdapter.Fill(this._ds);
      }
      finally
      {
        sqlConnection.Close();
        sqlDataAdapter.Dispose();
        sqlConnection.Dispose();
      }
      if (this._report.TableNames.Trim().Length > 0)
      {
        string[] strArray = this._report.TableNames.Trim().Split(';');
        for (int index5 = 0; index5 < strArray.Length && index5 < this._ds.Tables.Count; ++index5)
          this._ds.Tables[index5].TableName = strArray[index5];
      }
    }
    if (this._report.AllowPrint)
    {
      this.HidePrintDateAndTime();
      if (this._report.isLayoutDefined)
        this.LoadSavedLayout();
      else
        this.GenVisibleReport();
    }
    else
    {
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Format -= new EventHandler(this.ReportHeader1_Format);
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).BeforePrint -= new EventHandler(this.Detail1_BeforePrint);
    }
    this._isLayoutDefined = this._report.isLayoutDefined;
    if (this._report.isLargeExport)
      return;
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void LoadSavedLayout()
  {
    this.LoadLayout((XmlReader) new XmlTextReader((TextReader) new StringReader(this._report.Layout)));
  }

  private void GenVisibleReport()
  {
    float num1 = 0.0f;
    float num2 = 0.0f;
    DataTable table = this._ds.Tables[0];
    string[] ColWidths = Strings.Split(this._report.ColumnWidth, ";");
    this._lblFont = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point);
    this._txtFont = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point);
    if (table.Rows.Count <= 0)
      return;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
      {
        Label label = new Label();
        label.Font = this._lblFont;
        label.Text = column.ColumnName;
        ((ARControl) label).Width = this.CalcColWidth(column.Ordinal, ColWidths);
        ((ARControl) label).Left = num1;
        ((ARControl) label).Top = num2;
        ((ARControl) label).Height = 0.75f;
        label.VerticalAlignment = (VerticalTextAlignment) 2;
        if ((double) ((ARControl) label).Width == 0.0)
          ((ARControl) label).Visible = false;
        ((ARControl) label).Name = "lbl_hr_" + this.CleanTheString(column.ColumnName);
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.Add((ARControl) label);
        TextBox textBox = new TextBox();
        textBox.Font = this._txtFont;
        ((ARControl) textBox).DataField = column.ColumnName;
        ((ARControl) textBox).Width = ((ARControl) label).Width;
        ((ARControl) textBox).Left = num1;
        ((ARControl) textBox).Top = num2;
        ((ARControl) textBox).Border.TopStyle = (BorderLineStyle) 1;
        ((ARControl) textBox).Border.BottomStyle = (BorderLineStyle) 1;
        ((ARControl) textBox).Border.LeftStyle = (BorderLineStyle) 1;
        ((ARControl) textBox).Border.RightStyle = (BorderLineStyle) 1;
        ((ARControl) textBox).Border.TopColor = Color.LightGray;
        ((ARControl) textBox).Border.BottomColor = Color.LightGray;
        ((ARControl) textBox).Border.LeftColor = Color.LightGray;
        ((ARControl) textBox).Border.RightColor = Color.LightGray;
        ((ARControl) textBox).Name = "txt_dt_" + this.CleanTheString(column.ColumnName);
        string name = column.DataType.Name;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "DateTime", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Decimal", false) == 0)
            textBox.OutputFormat = "$#,##0.00";
        }
        else
          textBox.OutputFormat = "MM/dd/yyyy";
        if ((double) ((ARControl) textBox).Width == 0.0)
          ((ARControl) textBox).Visible = false;
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.Add((ARControl) textBox);
        num1 += ((ARControl) label).Width;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (Strings.Trim(this._report.SummaryFields).Length > 0)
    {
      float TruePart = 10000f;
      this._txtFont = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point);
      string[] strArray = Strings.Split(this._report.SummaryFields, ";");
      int index = 0;
      while (index < strArray.Length)
      {
        string str = strArray[index];
        try
        {
          foreach (TextBox control in (CollectionBase) ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ARControl) control).DataField, str, false) == 0)
            {
              TextBox textBox = new TextBox();
              textBox.Font = this._txtFont;
              ((ARControl) textBox).DataField = ((ARControl) control).DataField;
              ((ARControl) textBox).Width = ((ARControl) control).Width;
              ((ARControl) textBox).Left = ((ARControl) control).Left;
              ((ARControl) textBox).Top = num2;
              textBox.SummaryFunc = (SummaryFunc) 0;
              textBox.SummaryRunning = (SummaryRunning) 2;
              textBox.SummaryType = (SummaryType) 1;
              ((ARControl) textBox).Border.TopStyle = (BorderLineStyle) 1;
              ((ARControl) textBox).Border.BottomStyle = (BorderLineStyle) 1;
              ((ARControl) textBox).Border.LeftStyle = (BorderLineStyle) 1;
              ((ARControl) textBox).Border.RightStyle = (BorderLineStyle) 1;
              ((ARControl) textBox).Border.TopColor = Color.DarkGray;
              ((ARControl) textBox).Border.BottomColor = Color.DarkGray;
              ((ARControl) textBox).Border.LeftColor = Color.DarkGray;
              ((ARControl) textBox).Border.RightColor = Color.DarkGray;
              ((ARControl) textBox).Name = "txt_rf_" + this.CleanTheString(str);
              textBox.OutputFormat = control.OutputFormat;
              ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Controls.Add((ARControl) textBox);
              TruePart = Conversions.ToSingle(Interaction.IIf((double) TruePart < (double) ((ARControl) textBox).Left, (object) TruePart, (object) ((ARControl) textBox).Left));
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        checked { ++index; }
      }
      Label label = new Label();
      label.Font = this._lblFont;
      label.Text = "Total:";
      ((ARControl) label).Width = 2f;
      ((ARControl) label).Left = TruePart - 0.5f;
      ((ARControl) label).Top = num2;
      ((ARControl) label).Height = 0.2f;
      label.VerticalAlignment = (VerticalTextAlignment) 0;
      ((ARControl) label).Name = "lbl_rf_GarndTotal";
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Controls.Add((ARControl) label);
    }
    if (this._report.isPaperOrientationPortrait)
      this.PageSettings.Orientation = (PageOrientation) 1;
    else
      this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.Margins.Bottom = Convert.ToSingle(this._report.MarginBottom);
    this.PageSettings.Margins.Left = Convert.ToSingle(this._report.MarginLeft);
    this.PageSettings.Margins.Right = Convert.ToSingle(this._report.MarginRight);
    this.PageSettings.Margins.Top = Convert.ToSingle(this._report.MarginTop);
    this.PrintWidth = num1;
    this.PageSettings.PaperWidth = num1;
    ((ARControl) this.lblTitle).Width = num1;
    ((ARControl) this.lblSubTitle).Width = num1;
  }

  private void ReportHeader1_Format(object sender, EventArgs e)
  {
    if (this._report.AllowPrint)
    {
      this.lblTitle.Text = this._report.Title;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._report.SubTitle, "", false) != 0)
      {
        ((ARControl) this.lblSubTitle).Visible = true;
        this.lblSubTitle.Text = this.ProcessSubTitle(this._report.SubTitle);
      }
      ((ARControl) this.lblTitle).Visible = true;
    }
    else
      ((ARControl) this.lblExport2Excel).Visible = true;
  }

  private void Detail1_BeforePrint(object sender, EventArgs e)
  {
    if (this._isLayoutDefined)
      return;
    this.SetDetailControlsHeight();
  }

  private Workbook ToExcel(DataSet source, FileFormatType exportFormat)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    Workbook excel = new Workbook();
    excel.Worksheets.RemoveAt(0);
    excel.FileFormat = exportFormat;
    int index1 = 0;
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) source.Tables)
      {
        excel.Worksheets.Add();
        bool flag = false;
        excel.Worksheets[index1].Name = !source.Tables[index1].TableName.Substring(0, 5).Equals("Table") ? source.Tables[index1].TableName : "Sheet " + (index1 + 1).ToString();
        Style style1 = excel.CreateStyle();
        style1.Font.IsBold = true;
        int num1 = table.Columns.Count - 1;
        for (int index2 = 0; index2 <= num1; ++index2)
        {
          Cell cell = excel.Worksheets[index1].Cells[0, index2];
          cell.PutValue(table.Columns[index2].ColumnName);
          cell.SetStyle(style1);
          int num2 = table.Rows.Count - 1;
          for (int index3 = 0; index3 <= num2; ++index3)
          {
            try
            {
              string str = table.Rows[index3][index2].GetType().ToString();
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
              {
                case 347085918:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Boolean", false) == 0)
                    break;
                  goto default;
                case 531277785:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.DBNull", false) == 0)
                  {
                    excel.Worksheets[index1].Cells[index3 + 1, index2].PutValue(string.Empty);
                    goto label_26;
                  }
                  goto default;
                case 848225627:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Double", false) == 0)
                  {
                    excel.Worksheets[index1].Cells[index3 + 1, index2].PutValue((double) table.Rows[index3][index2]);
                    goto label_26;
                  }
                  goto default;
                case 1541528931:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.DateTime", false) == 0)
                  {
                    excel.Worksheets[index1].Cells[index3 + 1, index2].PutValue(Conversions.ToDate(table.Rows[index3][index2]).ToOADate());
                    Style style2 = excel.Worksheets[index1].Cells[index3 + 1, index2].GetStyle();
                    style2.Number = 14;
                    excel.Worksheets[index1].Cells[index3 + 1, index2].SetStyle(style2);
                    goto label_26;
                  }
                  goto default;
                case 1697786220:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Int16", false) == 0)
                  {
                    excel.Worksheets[index1].Cells[index3 + 1, index2].PutValue((int) (short) table.Rows[index3][index2]);
                    goto label_26;
                  }
                  goto default;
                case 1741144581:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Decimal", false) == 0)
                  {
                    excel.Worksheets[index1].Cells[index3 + 1, index2].PutValue((Decimal) table.Rows[index3][index2]);
                    goto label_26;
                  }
                  goto default;
                case 2736390927:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Guid", false) == 0)
                    break;
                  goto default;
                case 3079944380:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Byte", false) == 0)
                    break;
                  goto default;
                case 3552946656:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Integer", false) == 0)
                    goto label_21;
                  goto default;
                case 4180476474:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Int32", false) == 0)
                    goto label_21;
                  goto default;
                case 4201364391:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.String", false) == 0)
                    break;
                  goto default;
                default:
                  excel.Worksheets[index1].Cells[index3 + 1, index2].PutValue(table.Rows[index3][index2].ToString());
                  goto label_26;
              }
              excel.Worksheets[index1].Cells[index3 + 1, index2].PutValue(table.Rows[index3][index2].ToString());
              goto label_26;
label_21:
              excel.Worksheets[index1].Cells[index3 + 1, index2].PutValue((int) table.Rows[index3][index2]);
label_26:
              excel.Worksheets[index1].Cells[index3 + 1, index2].GetStyle();
            }
            catch (ArgumentOutOfRangeException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              int num3 = (int) MessageBox.Show("The maximum number of columns for an Excel spreadsheet has been exceeded for this sheet.\n\nAdditional columns will not be exported.", "Maximum Columns Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag = true;
              ProjectData.ClearProjectError();
              break;
            }
          }
          if (flag)
            break;
        }
        ++index1;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return excel;
  }

  private string ProcessSubTitle(string subtitle)
  {
    try
    {
      foreach (string key in this._ClientSelectedCriteria.Keys)
        subtitle = Strings.Replace(subtitle, key, this._ClientSelectedCriteria[key]);
    }
    finally
    {
      Dictionary<string, string>.KeyCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (string key in this._CommonReportData.Keys)
        subtitle = Strings.Replace(subtitle, key, this._CommonReportData[key]);
    }
    finally
    {
      Dictionary<string, string>.KeyCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
    return subtitle;
  }

  private float CalcColWidth(int ColInd, string[] ColWidths)
  {
    return ColWidths.Length != 1 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ColWidths[0], "", false) != 0 ? (ColWidths.Length <= ColInd ? 2f : (!Versioned.IsNumeric((object) ColWidths[ColInd]) ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ColWidths[ColInd], "", false) != 0 ? 2f : 0.0f) : float.Parse(ColWidths[ColInd]))) : 2f;
  }

  private bool ParamWorthToAdd(object param)
  {
    bool add;
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(param)))
    {
      add = false;
    }
    else
    {
      string Left = Versioned.TypeName(RuntimeHelpers.GetObjectValue(param));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "DateTime", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Date", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Guid", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "String", false) == 0 && param == (object) "")
          {
            add = false;
            goto label_11;
          }
        }
        else if (param.Equals((object) Guid.Empty))
        {
          add = false;
          goto label_11;
        }
      }
      else if (param.Equals((object) DateTime.MinValue) || param.Equals((object) DateTime.MinValue))
      {
        add = false;
        goto label_11;
      }
      add = true;
    }
label_11:
    return add;
  }

  private string GetReadableParamValue(DataRow dr, object val, int ParamNo)
  {
    string str1 = "";
    string pattern = "(order)\\s+(by)\\s+.+($)";
    RegexOptions options = RegexOptions.IgnoreCase;
    string readableParamValue;
    switch (Conversions.ToInteger(dr["CriteriaID"]))
    {
      case 2:
        readableParamValue = this.TableToString($"SELECT DisplayMember FROM ((SELECT -1 As Sort, -1 As ValueMember, 'All Billing Types' As DisplayMember) UNION (SELECT 1 As Sort, BillingTypeID As ValueMember, BillingType As DisplayMember FROM lstBillingTypes)) i WHERE ValueMember in ({val.ToString()}) ORDER BY DisplayMember", "DisplayMember");
        break;
      case 3:
        readableParamValue = this.TableToString($"SELECT BusinessType FROM (SELECT BusinessType, CAST(BusinessTypeID AS INT) AS BusinessTypeID FROM lstBusinessTypes WHERE (Hidden = 0)) i WHERE BusinessTypeID in ({val.ToString()}) ORDER BY BusinessType", "BusinessType");
        break;
      case 4:
        readableParamValue = this.TableToString($"SELECT CompanyName FROM (SELECT CompanyName, CompanyGUID FROM tblCompanies) i WHERE CompanyGUID in ('{Strings.Replace(val.ToString(), ",", "','")}') ORDER BY CompanyName", "CompanyName");
        break;
      case 5:
      case 6:
        readableParamValue = this.TableToString($"SELECT dbo.GetEntityName('{val.ToString()}') as Name", "Name");
        break;
      case 7:
        readableParamValue = this.TableToString($"SELECT LineName FROM (SELECT LineName, LineGUID FROM lstLines) i WHERE LineGUID in ('{val.ToString()}')", "LineName");
        break;
      case 8:
        readableParamValue = this.TableToString($"SELECT DisplayMember FROM (SELECT Name as DisplayMember, CompanyLocationGUID as ValueMember FROM tblCompanyLocations) i WHERE ValueMember ='{val.ToString()}' ORDER BY DisplayMember", "DisplayMember");
        break;
      case 10:
        readableParamValue = this.TableToString($"SELECT GroupName FROM (SELECT GroupName, GroupCode FROM lstLineGroups) i WHERE GroupCode in ({val.ToString()})", "GroupName");
        break;
      case 11:
      case 12:
      case 13:
      case 14:
      case 15:
      case 39:
      case 61:
      case 62:
      case 63 /*0x3F*/:
      case 64 /*0x40*/:
      case 65:
      case 66:
      case 67:
      case 68:
      case 69:
        readableParamValue = !Information.IsDate(RuntimeHelpers.GetObjectValue(val)) ? "Any" : DateTime.Parse(val.ToString()).ToShortDateString();
        break;
      case 16 /*0x10*/:
      case 17:
        readableParamValue = this.TableToString($"SELECT dbo.GetEntityName('{val.ToString()}') AS EntityName", "EntityName");
        break;
      case 18:
      case 19:
        readableParamValue = !Conversions.ToBoolean(val.ToString()) ? "Not " + dr["Parameter01"].ToString() : dr["Parameter01"].ToString();
        break;
      case 20:
      case 21:
        string str2 = Regex.Replace(dr["Parameter01"].ToString(), pattern, "", options);
        readableParamValue = this.TableToString($"SELECT {dr["Parameter03"].ToString()} FROM ({str2}) i WHERE {dr["Parameter02"].ToString()} = '{val.ToString()}' ORDER BY {dr["Parameter03"].ToString()}", dr["Parameter03"].ToString());
        break;
      case 22:
      case 23:
      case 24:
      case 25:
      case 26:
      case 27:
        string str3 = Regex.Replace(dr["Parameter01"].ToString(), pattern, "", options);
        readableParamValue = this.TableToString($"SELECT {dr["Parameter03"].ToString()} FROM ({str3}) i WHERE {dr["Parameter02"].ToString()} in ('{Strings.Replace(val.ToString(), ",", "','")}') ORDER BY {dr["Parameter03"].ToString()}", dr["Parameter03"].ToString());
        break;
      case 28:
        readableParamValue = this.TableToString($"SELECT PolicyName, Insuredguid FROM tblInsureds WHERE Insuredguid ='{val.ToString()}'", "PolicyName");
        break;
      case 29:
        readableParamValue = this.TableToString("SELECT LicenseType FROM lstLicenseTypes WHERE CAST(LicenseTypeID AS INT) =" + val.ToString(), "LicenseType");
        break;
      case 30:
      case 31 /*0x1F*/:
        readableParamValue = val.ToString();
        break;
      case 32 /*0x20*/:
        readableParamValue = this.TableToString("SELECT NoteTypeID, Description FROM lstNoteTypes WHERE NoteTypeID=" + val.ToString(), "Description");
        break;
      case 33:
        readableParamValue = this.TableToString("SELECT SIC_Description FROM lstSIC_Codes WHERE SIC_Code=" + val.ToString(), "SIC_Description");
        break;
      case 34:
      case 35:
        readableParamValue = this.TableToString($"SELECT DisplayMember FROM (SELECT Location As DisplayMember, OfficeGuid as ValueMember FROM tblClientOffices) i WHERE ValueMember ='{val.ToString()}' ORDER BY DisplayMember", "DisplayMember");
        break;
      case 38:
        readableParamValue = this.TableToString(ParamNo != 1 ? $"SELECT Name as DisplayValue from tblProducerLocations WHERE ProducerLocationGUID in ('{Strings.Replace(val.ToString(), ",", "','")}') Order BY DisplayValue" : $"select Location as DisplayValue from tblClientOffices WHERE OfficeGuid='{val.ToString()}'", "DisplayValue");
        break;
      case 41:
      case 42:
        readableParamValue = this.TableToString($"SELECT Name  FROM tblProducerLocations WHERE ProducerLocationGuid in ('{Strings.Replace(val.ToString(), ",", "','")}')", "Name");
        break;
      case 43:
      case 44:
      case 45:
        readableParamValue = this.TableToString($"SELECT ProducerName from tblProducers WHERE ProducerGUID in ('{Strings.Replace(val.ToString(), ",", "','")}')", "ProducerName");
        break;
      case 46:
        readableParamValue = this.TableToString("SELECT Description FROM lstQuoteStatus WHERE CAST(QuoteStatusID AS INTEGER)=" + val.ToString(), "Description");
        break;
      case 48 /*0x30*/:
        readableParamValue = this.TableToString($"SELECT State FROM lstStates WHERE StateID='{val.ToString()}'", "State");
        break;
      case 49:
      case 50:
        readableParamValue = val.ToString();
        break;
      case 52:
      case 59:
      case 60:
        readableParamValue = this.TableToString($"SELECT DisplayMember FROM (SELECT (LastName + ', ' + FirstName) As DisplayMember, UserGuid as ValueMember from tblUsers) i WHERE ValueMember ='{val.ToString()}' ORDER BY DisplayMember", "DisplayMember");
        break;
      case 70:
      case 71:
      case 72:
      case 73:
        readableParamValue = this.TableToString($"SELECT IsNull(FName, '') + IsNull(' ' + LName, '') as ProducerContactName FROM tblProducerContacts WHERE ProducerContactGUID in ({$"'{val.ToString().Replace(",", "','")}'"}) ORDER BY tblProducerContacts.LName", "ProducerContactName");
        break;
      case 77:
        readableParamValue = CurrentUser.Instance.DisplayName;
        break;
      default:
        readableParamValue = str1;
        break;
    }
    return readableParamValue;
  }

  private string TableToString(string sql, string datafield)
  {
    string Left = "";
    SqlConnection sqlConnection = this.CreateSqlConnection();
    SqlCommand selectCommand = new SqlCommand(sql, sqlConnection);
    selectCommand.CommandType = CommandType.Text;
    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
    DataSet ds = new DataSet();
    string str;
    try
    {
      Database.SafeDataAdapterFill(dataAdapter, ds);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      str = "";
      ProjectData.ClearProjectError();
      goto label_14;
    }
    finally
    {
      sqlConnection.Close();
      dataAdapter.Dispose();
      selectCommand.Dispose();
      sqlConnection.Dispose();
    }
    DataTable table = ds.Tables[0];
    try
    {
      foreach (DataRow row in table.Rows)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0)
          Left += ", ";
        Left += row[datafield].ToString();
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    str = Left;
label_14:
    return str;
  }

  private string CleanTheString(string theString)
  {
    string str1 = "";
    string str2 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_";
    int num = theString.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (str2.IndexOf(theString[index]) >= 0)
      {
        str1 += Conversions.ToString(theString[index]);
      }
      else
      {
        char ch = theString[index];
        if ((int) ch == (int) "@".ToCharArray()[0])
          str1 += "At";
        else if ((int) ch == (int) "/".ToCharArray()[0])
          str1 += "Slash";
        else if ((int) ch == (int) "#".ToCharArray()[0])
          str1 += "No";
        else if ((int) ch == (int) "%".ToCharArray()[0])
          str1 += "Pct";
        else if ((int) ch == (int) ".".ToCharArray()[0])
          str1 += "_";
        else if ((int) ch == (int) ",".ToCharArray()[0])
          str1 += "Comma";
        else if ((int) ch == (int) "-".ToCharArray()[0])
          str1 += "Dash";
      }
    }
    return str1;
  }

  public AdHocReport AdHocReport => this._report;

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  public override bool IsThreaded
  {
    get
    {
      return !Information.IsNothing((object) this._report) ? this._report.isThreaded : base.IsThreaded;
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    if (this._report.isLargeExport)
      this._xcl.WriteExcel(SaveFileTo);
    else if (Strings.Trim(this._report.SummaryFields).Length > 0)
    {
      Workbook excel = this.ToExcel(this._ds, !(SaveFileTo.Contains(".xls") & SaveFileTo.LastIndexOf(".xls") == SaveFileTo.Length - 4) ? (FileFormatType) 6 : (FileFormatType) 5);
      ref DataSet local1 = ref this._ds;
      ref Workbook local2 = ref excel;
      AdHocReport report;
      string summaryFields = (report = this._report).SummaryFields;
      ref string local3 = ref summaryFields;
      this.AddSummaryFieldsExcel(ref local1, ref local2, ref local3);
      report.SummaryFields = summaryFields;
      excel.Save(SaveFileTo);
    }
    else
      MGASystems.Tools.ExcelExport.ToExcel(this._ds, SaveFileTo);
  }

  private void AddSummaryFieldsExcel(ref DataSet ds, ref Workbook wb, ref string sfields)
  {
    string[] array = Strings.Split(this._report.SummaryFields, ";");
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) ds.Tables)
      {
        string str = table.TableName;
        if (str.Substring(0, 5).Equals("Table"))
          str = "Sheet " + (ds.Tables.IndexOf(table) + 1).ToString();
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          {
            string columnName = column.ColumnName;
            int ordinal = column.Ordinal;
            if (Array.IndexOf<string>(array, columnName) >= 0)
              wb.Worksheets[str].Cells[table.Rows.Count + 1, ordinal].R1C1Formula = $"=SUM(R[-{table.Rows.Count.ToString()}]C:R[-1]C)";
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public override bool HasRecords
  {
    get
    {
      return this._ds.Tables.Count <= 0 ? this._recordsWritten > 0 : this._ds.Tables[0].Rows.Count > 0;
    }
  }

  public override void Email() => this.Email(MGAReport.EmailAttachmentFormat.XLS);

  public override bool ExcelOnly => !this._report.AllowPrint;
}
