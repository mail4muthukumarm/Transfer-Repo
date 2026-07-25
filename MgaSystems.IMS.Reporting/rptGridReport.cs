// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptGridReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptGridReport : MGAReport
{
  private TextBox txtTitle;
  private readonly DataTable _dt;
  private readonly int _ColumnWidth;
  private Font _lblFont;
  private Font _txtFont;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptGridReport(DataTable Source, int ColumnWidth)
    : this(Source, ColumnWidth, "")
  {
  }

  public rptGridReport(DataTable Source, int ColumnWidth, string Title)
  {
    this.ReportStart += new EventHandler(this.rptGridReport_ReportStart);
    this.ReportEnd += new EventHandler(this.rptGridReport_ReportEnd);
    this._lblFont = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point);
    this._txtFont = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point);
    this.InitializeComponent();
    this._dt = Source;
    this._ColumnWidth = ColumnWidth;
    if (Title.Length <= 0)
      return;
    this.txtTitle.Text = Title;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Visible = true;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptGridReport));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.txtTitle = new TextBox();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtTitle
    });
    this.ReportHeader.Height = 0.2076389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Visible = false;
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.txtTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTitle.DistinctField = (string) null;
    this.txtTitle.Font = new Font("Arial", 12f);
    this.txtTitle.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTitle = this.txtTitle;
    object obj = componentResourceManager.GetObject("txtTitle.Location");
    PointF pointF = obj != null ? (PointF) obj : new PointF();
    ((ARControl) txtTitle).Location = pointF;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.OutputFormat = (string) null;
    ((ARControl) this.txtTitle).Size = new SizeF(6.5f, 3f / 16f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.txtTitle).EndInit();
  }

  private void rptGridReport_ReportStart(object sender, EventArgs e)
  {
    float num1 = 0.0f;
    float num2 = 0.0f;
    this._lblFont = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point);
    this._txtFont = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point);
    if (this._dt.Rows.Count > 0)
    {
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this._dt.Columns)
        {
          Label label = new Label();
          label.Font = this._lblFont;
          label.Text = column.ColumnName;
          ((ARControl) label).Width = (float) this._ColumnWidth;
          ((ARControl) label).Left = num1;
          ((ARControl) label).Top = num2;
          ((ARControl) label).Height = 0.75f;
          label.VerticalAlignment = (VerticalTextAlignment) 2;
          ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.Add((ARControl) label);
          TextBox textBox = new TextBox();
          textBox.Font = this._txtFont;
          ((ARControl) textBox).DataField = column.ColumnName;
          ((ARControl) textBox).Width = (float) this._ColumnWidth;
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
          string name = column.DataType.Name;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "DateTime", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Decimal", false) == 0)
              textBox.OutputFormat = "$#,##0.00";
          }
          else
            textBox.OutputFormat = "MM/dd/yyyy";
          ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.Add((ARControl) textBox);
          num1 += (float) this._ColumnWidth;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.PrintWidth = num1;
      this.PageSettings.PaperWidth = num1;
    }
    ((ARControl) this.txtTitle).Width = num1;
    this.DataSource = (object) this._dt;
  }

  private void rptGridReport_ReportEnd(object sender, EventArgs e)
  {
    if (this._lblFont != null)
      this._lblFont.Dispose();
    if (this._txtFont == null)
      return;
    this._txtFont.Dispose();
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();
}
