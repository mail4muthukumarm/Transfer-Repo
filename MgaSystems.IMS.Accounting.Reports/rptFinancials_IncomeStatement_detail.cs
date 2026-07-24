// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptFinancials_IncomeStatement_detail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptFinancials_IncomeStatement_detail : MGAReport
{
  private const float IndentIncrease = 0.5f;
  private float _Indent;
  private DataView _dv;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox txtFullName;
  private TextBox GLAcctID;
  private SubReport srChildren;

  public rptFinancials_IncomeStatement_detail(DataView dv, float indent)
  {
    this.InitializeComponent();
    this._Indent = indent;
    ((ARControl) this.txtFullName).Left = this._Indent;
    TextBox txtFullName;
    double num = (double) ((ARControl) (txtFullName = this.txtFullName)).Width - (double) this._Indent;
    ((ARControl) txtFullName).Width = (float) num;
    this._dv = dv;
    this.DataSource = (object) this._dv;
  }

  public rptFinancials_IncomeStatement_detail(DataView dv)
  {
    this.InitializeComponent();
    this._Indent = ((ARControl) this.txtFullName).Left;
    this._dv = dv;
    this.DataSource = (object) this._dv;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptFinancials_IncomeStatement_detail));
    this.Detail = new Detail();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.txtFullName = new TextBox();
    this.GLAcctID = new TextBox();
    this.srChildren = new SubReport();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.txtFullName).BeginInit();
    ((ISupportInitialize) this.GLAcctID).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.txtFullName,
      (ARControl) this.GLAcctID,
      (ARControl) this.srChildren
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1145833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox2).DataField = "Amount";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 4.625f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 8pt; text-align: right";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 1.875f;
    ((ARControl) this.TextBox3).DataField = "CompareAmount";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 105f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 8pt; text-align: right";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 1.875f;
    ((ARControl) this.TextBox4).DataField = "ChangeAmount";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 8.5f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 8pt; text-align: right";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.875f;
    ((ARControl) this.txtFullName).DataField = "FullName";
    ((ARControl) this.txtFullName).Height = 0.125f;
    ((ARControl) this.txtFullName).Left = 0.5f;
    ((ARControl) this.txtFullName).Name = "txtFullName";
    this.txtFullName.Style = "font-size: 8pt; font-weight: bold";
    this.txtFullName.Text = (string) null;
    ((ARControl) this.txtFullName).Top = 0.0f;
    ((ARControl) this.txtFullName).Width = 4.125f;
    ((ARControl) this.GLAcctID).DataField = "GLAcctID";
    ((ARControl) this.GLAcctID).Height = 1f / 16f;
    ((ARControl) this.GLAcctID).Left = 0.0f;
    ((ARControl) this.GLAcctID).Name = "GLAcctID";
    this.GLAcctID.Style = "background-color: Yellow; font-size: 1pt";
    this.GLAcctID.Text = (string) null;
    ((ARControl) this.GLAcctID).Top = 0.0f;
    ((ARControl) this.GLAcctID).Visible = false;
    ((ARControl) this.GLAcctID).Width = 0.375f;
    this.srChildren.CloseBorder = false;
    ((ARControl) this.srChildren).Height = 1f / 16f;
    ((ARControl) this.srChildren).Left = 0.0f;
    ((ARControl) this.srChildren).Name = "srChildren";
    this.srChildren.Report = (SectionReport) null;
    ((ARControl) this.srChildren).Top = 0.125f;
    ((ARControl) this.srChildren).Width = 10.375f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; text-align: left; vertical-align: top; ddo-char-set: 1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: bold", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.txtFullName).EndInit();
    ((ISupportInitialize) this.GLAcctID).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this.GLAcctID.Value == null)
      return;
    DataView dv = new DataView(this._dv.Table, $"RollUpTo = {RuntimeHelpers.GetObjectValue(this.GLAcctID.Value)}", "", DataViewRowState.CurrentRows);
    if (dv.Count > 0)
    {
      ((ARControl) this.srChildren).Visible = true;
      this.srChildren.Report = (SectionReport) new rptFinancials_IncomeStatement_detail(dv, this._Indent + 0.5f);
    }
    else
    {
      ((ARControl) this.srChildren).Visible = false;
      ((ARControl) this.srChildren).Height = 0.0f;
    }
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtFullName.Text, string.Empty, false) == 0)
      return;
    this.txtFullName.HyperLink = this.GLAcctID.Text.ToString();
  }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Detail_Format);
      EventHandler eventHandler2 = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
      {
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler1;
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler2;
      }
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler1;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler2;
    }
  }
}
