// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptFinancials_TrialBalance_Record
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptFinancials_TrialBalance_Record : SectionReport
{
  private const float _SpaceSize = 0.2f;
  private int _Depth;
  private DataView _dv;
  private TextBox txtAmount;
  private TextBox Current_GlAcctID;
  private SubReport srNext;
  private TextBox txtAcct;

  public rptFinancials_TrialBalance_Record(DataView dv)
    : this(dv, 2)
  {
  }

  private rptFinancials_TrialBalance_Record(DataView dv, int depth)
  {
    this.InitializeComponent();
    this._Depth = depth;
    TextBox txtAcct1;
    double num1 = (double) ((ARControl) (txtAcct1 = this.txtAcct)).Left + (double) this._Depth * 0.20000000298023224;
    ((ARControl) txtAcct1).Left = (float) num1;
    TextBox txtAcct2;
    double num2 = (double) ((ARControl) (txtAcct2 = this.txtAcct)).Width - 0.20000000298023224;
    ((ARControl) txtAcct2).Width = (float) num2;
    this._dv = dv;
    this.DataSource = (object) this._dv;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptFinancials_TrialBalance_Record));
    this.Detail = new Detail();
    this.txtAmount = new TextBox();
    this.Current_GlAcctID = new TextBox();
    this.srNext = new SubReport();
    this.txtAcct = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.Current_GlAcctID).BeginInit();
    ((ISupportInitialize) this.txtAcct).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.Detail).CanShrink = true;
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.txtAmount,
      (ARControl) this.Current_GlAcctID,
      (ARControl) this.srNext,
      (ARControl) this.txtAcct,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2
    });
    ((Section) this.Detail).Height = 0.1979167f;
    this.Detail.KeepTogether = true;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtAmount).Border.BottomColor = Color.Black;
    ((ARControl) this.txtAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.LeftColor = Color.Black;
    ((ARControl) this.txtAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.RightColor = Color.Black;
    ((ARControl) this.txtAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.TopColor = Color.Black;
    ((ARControl) this.txtAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).DataField = "Amount";
    ((ARControl) this.txtAmount).Height = 3f / 16f;
    ((ARControl) this.txtAmount).Left = 5.25f;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = resourceManager.GetString("txtAmount.OutputFormat");
    this.txtAmount.Style = "ddo-char-set: 0; text-align: right; ";
    ((ARControl) this.txtAmount).Top = 0.0f;
    ((ARControl) this.txtAmount).Width = 21f / 16f;
    ((ARControl) this.Current_GlAcctID).Border.BottomColor = Color.Black;
    ((ARControl) this.Current_GlAcctID).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Current_GlAcctID).Border.LeftColor = Color.Black;
    ((ARControl) this.Current_GlAcctID).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Current_GlAcctID).Border.RightColor = Color.Black;
    ((ARControl) this.Current_GlAcctID).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Current_GlAcctID).Border.TopColor = Color.Black;
    ((ARControl) this.Current_GlAcctID).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Current_GlAcctID).DataField = "GlAcctId";
    ((ARControl) this.Current_GlAcctID).Height = 1f / 16f;
    ((ARControl) this.Current_GlAcctID).Left = 0.0f;
    ((ARControl) this.Current_GlAcctID).Name = "Current_GlAcctID";
    this.Current_GlAcctID.Style = "ddo-char-set: 0; background-color: Yellow; ";
    this.Current_GlAcctID.Text = (string) null;
    ((ARControl) this.Current_GlAcctID).Top = 0.0f;
    ((ARControl) this.Current_GlAcctID).Visible = false;
    ((ARControl) this.Current_GlAcctID).Width = 0.5f;
    ((ARControl) this.srNext).Border.BottomColor = Color.Black;
    ((ARControl) this.srNext).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srNext).Border.LeftColor = Color.Black;
    ((ARControl) this.srNext).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srNext).Border.RightColor = Color.Black;
    ((ARControl) this.srNext).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srNext).Border.TopColor = Color.Black;
    ((ARControl) this.srNext).Border.TopStyle = (BorderLineStyle) 0;
    this.srNext.CloseBorder = false;
    ((ARControl) this.srNext).Height = 0.0f;
    ((ARControl) this.srNext).Left = 0.0f;
    ((ARControl) this.srNext).Name = "srNext";
    this.srNext.Report = (SectionReport) null;
    ((ARControl) this.srNext).Top = 3f / 16f;
    ((ARControl) this.srNext).Width = 7.875f;
    ((ARControl) this.txtAcct).Border.BottomColor = Color.Black;
    ((ARControl) this.txtAcct).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcct).Border.LeftColor = Color.Black;
    ((ARControl) this.txtAcct).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcct).Border.RightColor = Color.Black;
    ((ARControl) this.txtAcct).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcct).Border.TopColor = Color.Black;
    ((ARControl) this.txtAcct).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcct).DataField = "FullName";
    ((ARControl) this.txtAcct).Height = 3f / 16f;
    ((ARControl) this.txtAcct).Left = 0.25f;
    ((ARControl) this.txtAcct).Name = "txtAcct";
    this.txtAcct.Style = "ddo-char-set: 0; ";
    this.txtAcct.Text = (string) null;
    ((ARControl) this.txtAcct).Top = 0.0f;
    ((ARControl) this.txtAcct).Width = 59f / 16f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Total";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 105f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "ddo-char-set: 0; text-align: right; ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 21f / 16f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "BalForward";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 63f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; text-align: right; ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 21f / 16f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 253f / 32f;
    this.Sections.Add((Section) this.Detail);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.Current_GlAcctID).EndInit();
    ((ISupportInitialize) this.txtAcct).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this.Current_GlAcctID.Text != null && this._dv.Table.Select($"RollUpTo={this.Current_GlAcctID.Text}").Length > 0)
    {
      this.srNext.Report = (SectionReport) new rptFinancials_TrialBalance_Record(new DataView(this._dv.Table, $"RollUpTo='{this.Current_GlAcctID.Text}'", "", DataViewRowState.CurrentRows), checked (this._Depth + 1));
    }
    else
    {
      this.srNext.Report = (SectionReport) null;
      ((ARControl) this.srNext).Height = 0.0f;
      ((Section) this.Detail).Height = 0.0f;
    }
  }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).Format += eventHandler;
    }
  }
}
