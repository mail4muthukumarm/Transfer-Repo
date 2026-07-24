// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.FinancialReports.BalanceSheet_Detail
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.FinancialReports;

public class BalanceSheet_Detail : SectionReport
{
  private const float IndentIncrease = 0.5f;
  private float _Indent;
  private DataView _dv;
  private Detail Detail;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox txtFullName;
  private TextBox GLAcctID;
  private SubReport srChildren;

  public BalanceSheet_Detail(DataView dv, float indent)
  {
    this.InitializeComponent();
    this._Indent = indent;
    ((ARControl) this.txtFullName).Left = this._Indent;
    TextBox txtFullName = this.txtFullName;
    ((ARControl) txtFullName).Width = ((ARControl) txtFullName).Width - this._Indent;
    this._dv = dv;
    this.DataSource = (object) this._dv;
  }

  public BalanceSheet_Detail(DataView dv)
  {
    this.InitializeComponent();
    this._Indent = ((ARControl) this.txtFullName).Left;
    this._dv = dv;
    this.DataSource = (object) this._dv;
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this.GLAcctID.Value == null)
      return;
    DataView dv = new DataView(this._dv.Table, $"RollUpTo = {this.GLAcctID.Value}", "", DataViewRowState.CurrentRows);
    if (dv.Count > 0)
    {
      ((ARControl) this.srChildren).Visible = true;
      this.srChildren.Report = (SectionReport) new BalanceSheet_Detail(dv, this._Indent + 0.5f);
    }
    else
    {
      ((ARControl) this.srChildren).Visible = false;
      ((ARControl) this.srChildren).Height = 0.0f;
    }
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (BalanceSheet_Detail));
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
    this.Detail.ColumnSpacing = 0.0f;
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
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Format += new EventHandler(this.Detail_Format);
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "Amount";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 4.625f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "text-align: right; font-size: 8pt; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 1.875f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "CompareAmount";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 105f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "text-align: right; font-size: 8pt; ";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 1.875f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "ChangeAmount";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 8.5f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "text-align: right; font-size: 8pt; ";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.875f;
    ((ARControl) this.txtFullName).Border.BottomColor = Color.Black;
    ((ARControl) this.txtFullName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.LeftColor = Color.Black;
    ((ARControl) this.txtFullName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.RightColor = Color.Black;
    ((ARControl) this.txtFullName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.TopColor = Color.Black;
    ((ARControl) this.txtFullName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).DataField = "FullName";
    ((ARControl) this.txtFullName).Height = 0.125f;
    ((ARControl) this.txtFullName).Left = 0.5f;
    ((ARControl) this.txtFullName).Name = "txtFullName";
    this.txtFullName.Style = "font-weight: bold; font-size: 8pt; ";
    this.txtFullName.Text = (string) null;
    ((ARControl) this.txtFullName).Top = 0.0f;
    ((ARControl) this.txtFullName).Width = 4.125f;
    ((ARControl) this.GLAcctID).Border.BottomColor = Color.Black;
    ((ARControl) this.GLAcctID).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.GLAcctID).Border.LeftColor = Color.Black;
    ((ARControl) this.GLAcctID).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.GLAcctID).Border.RightColor = Color.Black;
    ((ARControl) this.GLAcctID).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.GLAcctID).Border.TopColor = Color.Black;
    ((ARControl) this.GLAcctID).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.GLAcctID).DataField = "GLAcctID";
    ((ARControl) this.GLAcctID).Height = 1f / 16f;
    ((ARControl) this.GLAcctID).Left = 0.0f;
    ((ARControl) this.GLAcctID).Name = "GLAcctID";
    this.GLAcctID.Style = "background-color: Yellow; font-size: 1pt; ";
    this.GLAcctID.Text = (string) null;
    ((ARControl) this.GLAcctID).Top = 0.0f;
    ((ARControl) this.GLAcctID).Visible = false;
    ((ARControl) this.GLAcctID).Width = 0.375f;
    ((ARControl) this.srChildren).Border.BottomColor = Color.Black;
    ((ARControl) this.srChildren).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srChildren).Border.LeftColor = Color.Black;
    ((ARControl) this.srChildren).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srChildren).Border.RightColor = Color.Black;
    ((ARControl) this.srChildren).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srChildren).Border.TopColor = Color.Black;
    ((ARControl) this.srChildren).Border.TopStyle = (BorderLineStyle) 0;
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
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.txtFullName).EndInit();
    ((ISupportInitialize) this.GLAcctID).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
