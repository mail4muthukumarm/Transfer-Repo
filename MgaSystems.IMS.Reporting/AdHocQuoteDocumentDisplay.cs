// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.AdHocQuoteDocumentDisplay
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
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
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
public class AdHocQuoteDocumentDisplay : SectionReport, IQuoteDocument, IStateSpecific
{
  private readonly DataSet _ds;
  private readonly AdHocReport _report;
  private Guid _reportGuid;
  private readonly object[] _params;
  private string _QuoteOptionGUIDs;
  private Font _lblFont;
  private Font _txtFont;
  private SqlCommand command;
  private readonly bool _usingReportingServer;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (AdHocQuoteDocumentDisplay));
    this.PageHeader = new PageHeader();
    this.Detail = new Detail();
    this.PageFooter = new PageFooter();
    this.ReportHeader = new ReportHeader();
    this.lblTitle = new Label();
    this.lblSubTitle = new TextBox();
    this.ReportFooter = new ReportFooter();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.lblSubTitle).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.lblSubTitle
    });
    this.ReportHeader.Height = 0.4895833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.lblTitle).Height = 9f / 32f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 14.25pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.lblTitle.Text = "";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Visible = false;
    ((ARControl) this.lblTitle).Width = 8.75f;
    this.lblSubTitle.CanShrink = true;
    ((ARControl) this.lblSubTitle).Height = 5f / 32f;
    ((ARControl) this.lblSubTitle).Left = 0.0f;
    ((ARControl) this.lblSubTitle).Name = "lblSubTitle";
    this.lblSubTitle.Style = "font-size: 11.25pt; text-align: center; ddo-char-set: 0";
    ((ARControl) this.lblSubTitle).Top = 0.3333333f;
    ((ARControl) this.lblSubTitle).Visible = false;
    ((ARControl) this.lblSubTitle).Width = 8.75f;
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.75f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.lblSubTitle).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTitle")]
  private virtual Label lblTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSubTitle")]
  private virtual TextBox lblSubTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public AdHocQuoteDocumentDisplay()
  {
    this.ReportStart += new EventHandler(this.AdHocQuoteDocumentDisplay_ReportStart);
    this._ds = new DataSet();
    this._lblFont = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point);
    this._txtFont = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point);
    this.InitializeComponent();
  }

  public AdHocQuoteDocumentDisplay(params object[] @params)
  {
    this.ReportStart += new EventHandler(this.AdHocQuoteDocumentDisplay_ReportStart);
    this._ds = new DataSet();
    this._lblFont = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point);
    this._txtFont = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point);
    this.InitializeComponent();
    if (((IEnumerable<object>) @params).ElementAt<object>(Information.UBound((Array) @params)).ToString().Contains("UseReportingServer"))
    {
      this._usingReportingServer = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((IEnumerable<object>) @params).ElementAt<object>(@params.Length - 1).ToString(), "UseReportingServerTrue", false) == 0;
      @params = (object[]) Utils.CopyArray((Array) @params, (Array) new object[Information.UBound((Array) @params) - 1 + 1]);
    }
    this._params = @params;
    object obj = this._params[0];
    this._report = new AdHocReport(obj != null ? (Guid) obj : new Guid());
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

  private void AdHocQuoteDocumentDisplay_ReportStart(object sender, EventArgs e)
  {
    this._reportGuid = this._report.GUID;
    SqlConnection sqlConnection = this.CreateSqlConnection();
    this.command = new SqlCommand(this._report.SQL, sqlConnection);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.command);
    this.command.CommandType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Left(this._report.SQL, 6).ToUpper(), "SELECT", false) != 0 ? CommandType.StoredProcedure : CommandType.Text;
    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
    DataRow[] dataRowArray = this._report.Criteria.Select("", "LineNo ASC");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      DataRow dataRow = dataRowArray[index];
      int result;
      if (int.TryParse(dataRow["CriteriaID"].ToString(), out result))
      {
        switch (result)
        {
          case 200:
            this.command.Parameters.AddWithValue(dataRow["SQLParam1Name"].ToString(), RuntimeHelpers.GetObjectValue(this._params[1]));
            break;
          case 201:
            this.command.Parameters.AddWithValue(dataRow["SQLParam1Name"].ToString(), (object) this._QuoteOptionGUIDs);
            break;
          case 202:
            this.command.Parameters.AddWithValue(dataRow["SQLParam1Name"].ToString(), (object) this._reportGuid);
            break;
        }
      }
      checked { ++index; }
    }
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
    if (this._report.isLayoutDefined)
      this.LoadSavedLayout();
    else
      this.GenVisibleReport();
    this.DataSource = (object) this._ds.Tables[0];
  }

  public AdHocReport AdHocReport => this._report;

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
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.Add((ARControl) label);
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
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.Add((ARControl) textBox);
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
          foreach (TextBox control in (CollectionBase) ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls)
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
              ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.Add((ARControl) textBox);
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
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.Add((ARControl) label);
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

  private float CalcColWidth(int ColInd, string[] ColWidths)
  {
    return ColWidths.Length != 1 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ColWidths[0], "", false) != 0 ? (ColWidths.Length <= ColInd ? 2f : (!Versioned.IsNumeric((object) ColWidths[ColInd]) ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ColWidths[ColInd], "", false) != 0 ? 2f : 0.0f) : float.Parse(ColWidths[ColInd]))) : 2f;
  }

  private string CleanTheString(string theString)
  {
    string str1 = "";
    string str2 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_";
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
      }
    }
    return str1;
  }

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    this._QuoteOptionGUIDs = string.Join<Guid>(",", (IEnumerable<Guid>) quoteOptionGuids);
  }

  public bool RequiresQuoteOptionGuids() => this._report.QuoteOptionRequirement;

  public void PlacedByCompanyLineID(int companyLineID)
  {
  }
}
