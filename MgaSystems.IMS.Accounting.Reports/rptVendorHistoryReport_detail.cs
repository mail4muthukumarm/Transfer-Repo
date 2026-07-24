// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptVendorHistoryReport_detail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[DesignerGenerated]
public class rptVendorHistoryReport_detail : MGAReport
{
  private DataView _dv;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private virtual Detail Detail1
  {
    get => this._Detail1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_BeforePrint);
      Detail detail1_1 = this._Detail1;
      if (detail1_1 != null)
        ((Section) detail1_1).BeforePrint -= eventHandler;
      this._Detail1 = value;
      Detail detail1_2 = this._Detail1;
      if (detail1_2 == null)
        return;
      ((Section) detail1_2).BeforePrint += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptVendorHistoryReport_detail));
    this.Detail1 = new Detail();
    this.txtTransactionNum = new TextBox();
    this.TxtCheckNum = new TextBox();
    ((ISupportInitialize) this.txtTransactionNum).BeginInit();
    ((ISupportInitialize) this.TxtCheckNum).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail1.ColumnSpacing = 0.0f;
    ((Section) this.Detail1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtTransactionNum,
      (ARControl) this.TxtCheckNum
    });
    ((Section) this.Detail1).Height = 3f / 16f;
    ((Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.txtTransactionNum).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.RightColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.TopColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).DataField = "TransactNum";
    ((ARControl) this.txtTransactionNum).Height = 0.125f;
    ((ARControl) this.txtTransactionNum).Left = 0.375f;
    ((ARControl) this.txtTransactionNum).Name = "txtTransactionNum";
    this.txtTransactionNum.OutputFormat = resourceManager.GetString("txtTransactionNum.OutputFormat");
    this.txtTransactionNum.Style = "ddo-char-set: 0; ";
    this.txtTransactionNum.Text = (string) null;
    ((ARControl) this.txtTransactionNum).Top = 0.0f;
    ((ARControl) this.txtTransactionNum).Visible = false;
    ((ARControl) this.txtTransactionNum).Width = 0.875f;
    ((ARControl) this.TxtCheckNum).Border.BottomColor = Color.Black;
    ((ARControl) this.TxtCheckNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TxtCheckNum).Border.LeftColor = Color.Black;
    ((ARControl) this.TxtCheckNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TxtCheckNum).Border.RightColor = Color.Black;
    ((ARControl) this.TxtCheckNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TxtCheckNum).Border.TopColor = Color.Black;
    ((ARControl) this.TxtCheckNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TxtCheckNum).DataField = "CheckNum";
    ((ARControl) this.TxtCheckNum).Height = 3f / 16f;
    ((ARControl) this.TxtCheckNum).Left = 23f / 16f;
    ((ARControl) this.TxtCheckNum).Name = "TxtCheckNum";
    this.TxtCheckNum.OutputFormat = resourceManager.GetString("TxtCheckNum.OutputFormat");
    this.TxtCheckNum.Style = "ddo-char-set: 0; ";
    ((ARControl) this.TxtCheckNum).Top = 0.0f;
    ((ARControl) this.TxtCheckNum).Width = 13f / 16f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 2.375f;
    this.Sections.Add((Section) this.Detail1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtTransactionNum).EndInit();
    ((ISupportInitialize) this.TxtCheckNum).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("txtTransactionNum")]
  private virtual TextBox txtTransactionNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TxtCheckNum")]
  private virtual TextBox TxtCheckNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptVendorHistoryReport_detail(DataView dv)
  {
    this.ReportStart += new EventHandler(this.rptVendorHistoryReport_ReportStart);
    this.InitializeComponent();
    this._dv = dv;
  }

  private void rptVendorHistoryReport_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._dv;
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TxtCheckNum.Text, string.Empty, false) == 0)
      this.TxtCheckNum.Text = "OffSet";
    this.TxtCheckNum.HyperLink = this.txtTransactionNum.Text.ToString();
  }

  public override bool IsThreaded => true;
}
