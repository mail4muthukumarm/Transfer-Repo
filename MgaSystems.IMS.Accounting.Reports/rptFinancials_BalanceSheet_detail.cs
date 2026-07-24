// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptFinancials_BalanceSheet_detail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptFinancials_BalanceSheet_detail : SectionReport
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

  public rptFinancials_BalanceSheet_detail(DataView dv, float indent)
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

  public rptFinancials_BalanceSheet_detail(DataView dv)
  {
    this.InitializeComponent();
    this._Indent = ((ARControl) this.txtFullName).Left;
    this._dv = dv;
    this.DataSource = (object) this._dv;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptFinancials_BalanceSheet_detail));
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
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "Amount";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj1 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox2).Location = pointF1;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(1.875f, 0.125f);
    this.TextBox2.Text = " ";
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "CompareAmount";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8f);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj2 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox3).Location = pointF2;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(1.875f, 0.125f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "ChangeAmount";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj3 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox4).Location = pointF3;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(1.875f, 0.125f);
    this.TextBox4.Text = " ";
    ((ARControl) this.txtFullName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).DataField = "FullName";
    this.txtFullName.DistinctField = (string) null;
    this.txtFullName.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.txtFullName.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtFullName = this.txtFullName;
    object obj4 = componentResourceManager.GetObject("txtFullName.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) txtFullName).Location = pointF4;
    ((ARControl) this.txtFullName).Name = "txtFullName";
    this.txtFullName.OutputFormat = (string) null;
    ((ARControl) this.txtFullName).Size = new SizeF(4.125f, 0.125f);
    this.GLAcctID.BackColor = Color.Yellow;
    ((ARControl) this.GLAcctID).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.GLAcctID).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.GLAcctID).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.GLAcctID).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.GLAcctID).DataField = "GLAcctID";
    this.GLAcctID.DistinctField = (string) null;
    this.GLAcctID.Font = new Font("Arial", 1f);
    this.GLAcctID.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox glAcctId = this.GLAcctID;
    object obj5 = componentResourceManager.GetObject("GLAcctID.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) glAcctId).Location = pointF5;
    ((ARControl) this.GLAcctID).Name = "GLAcctID";
    this.GLAcctID.OutputFormat = (string) null;
    ((ARControl) this.GLAcctID).Size = new SizeF(0.375f, 1f / 16f);
    ((ARControl) this.GLAcctID).Visible = false;
    ((ARControl) this.srChildren).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srChildren).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srChildren).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srChildren).Border.TopStyle = (BorderLineStyle) 0;
    this.srChildren.CloseBorder = false;
    SubReport srChildren = this.srChildren;
    object obj6 = componentResourceManager.GetObject("srChildren.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) srChildren).Location = pointF6;
    ((ARControl) this.srChildren).Name = "srChildren";
    this.srChildren.Report = (SectionReport) null;
    ((ARControl) this.srChildren).Size = new SizeF(10.375f, 1f / 16f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.txtFullName).EndInit();
    ((ISupportInitialize) this.GLAcctID).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this.GLAcctID.Value == null)
      return;
    DataView dv = new DataView(this._dv.Table, $"RollUpTo = {RuntimeHelpers.GetObjectValue(this.GLAcctID.Value)}", "", DataViewRowState.CurrentRows);
    if (dv.Count > 0)
    {
      ((ARControl) this.srChildren).Visible = true;
      this.srChildren.Report = (SectionReport) new rptFinancials_BalanceSheet_detail(dv, this._Indent + 0.5f);
    }
    else
    {
      ((ARControl) this.srChildren).Visible = false;
      ((ARControl) this.srChildren).Height = 0.0f;
    }
  }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler;
    }
  }
}
