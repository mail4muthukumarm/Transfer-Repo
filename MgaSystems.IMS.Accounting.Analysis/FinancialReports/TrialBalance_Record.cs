// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.FinancialReports.TrialBalance_Record
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.FinancialReports;

public class TrialBalance_Record : SectionReport
{
  private const float _SpaceSize = 0.2f;
  private int _Depth;
  private DataView _dv;
  private Detail detail;
  private TextBox txtAmount;
  private TextBox Current_GlAcctID;
  private SubReport srNext;
  private TextBox txtAcct;
  private TextBox TextBox2;
  private TextBox TextBox1;
  private TextBox txtDtl_AcctNum;

  public TrialBalance_Record(DataView dv)
    : this(dv, 2)
  {
  }

  public TrialBalance_Record(DataView dv, int depth)
  {
    this.InitializeComponent();
    this._Depth = depth;
    TextBox txtAcct1 = this.txtAcct;
    ((ARControl) txtAcct1).Left = ((ARControl) txtAcct1).Left + (float) this._Depth * 0.2f;
    TextBox txtAcct2 = this.txtAcct;
    ((ARControl) txtAcct2).Width = ((ARControl) txtAcct2).Width - 0.2f;
    this._dv = dv;
    this.DataSource = (object) this._dv;
  }

  private void detail_Format(object sender, EventArgs e)
  {
    if (this.Current_GlAcctID.Text != null && this._dv.Table.Select($"RollUpTo={this.Current_GlAcctID.Text}").Length != 0)
    {
      this.srNext.Report = (SectionReport) new TrialBalance_Record(new DataView(this._dv.Table, $"RollUpTo='{this.Current_GlAcctID.Text}'", "", DataViewRowState.CurrentRows), this._Depth + 1);
    }
    else
    {
      this.srNext.Report = (SectionReport) null;
      ((ARControl) this.srNext).Height = 0.0f;
      ((Section) this.detail).Height = 0.0f;
    }
    if (!(this.txtDtl_AcctNum.Text == "9999999"))
      return;
    this.txtDtl_AcctNum.Text = "";
  }

  private void detail_BeforePrint(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(this.txtDtl_AcctNum.Text) || !(this.txtDtl_AcctNum.Text != "9999999"))
      return;
    this.txtAcct.HyperLink = this.txtDtl_AcctNum.Text;
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (TrialBalance_Record));
    this.detail = new Detail();
    this.txtAmount = new TextBox();
    this.Current_GlAcctID = new TextBox();
    this.srNext = new SubReport();
    this.txtAcct = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox1 = new TextBox();
    this.txtDtl_AcctNum = new TextBox();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.Current_GlAcctID).BeginInit();
    ((ISupportInitialize) this.txtAcct).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtDtl_AcctNum).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.detail).CanShrink = true;
    ((Section) this.detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.txtAmount,
      (ARControl) this.Current_GlAcctID,
      (ARControl) this.srNext,
      (ARControl) this.txtAcct,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox1,
      (ARControl) this.txtDtl_AcctNum
    });
    ((Section) this.detail).Height = 3f / 16f;
    this.detail.KeepTogether = true;
    ((Section) this.detail).Name = "detail";
    ((Section) this.detail).Format += new EventHandler(this.detail_Format);
    ((Section) this.detail).BeforePrint += new EventHandler(this.detail_BeforePrint);
    ((ARControl) this.txtAmount).DataField = "Amount";
    ((ARControl) this.txtAmount).Height = 3f / 16f;
    ((ARControl) this.txtAmount).Left = 5.25f;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = resourceManager.GetString("txtAmount.OutputFormat");
    this.txtAmount.Style = "text-align: right; ddo-char-set: 0";
    this.txtAmount.Text = (string) null;
    ((ARControl) this.txtAmount).Top = 0.0f;
    ((ARControl) this.txtAmount).Width = 1.312f;
    ((ARControl) this.Current_GlAcctID).DataField = "GlAcctId";
    ((ARControl) this.Current_GlAcctID).Height = 1f / 16f;
    ((ARControl) this.Current_GlAcctID).Left = 0.0f;
    ((ARControl) this.Current_GlAcctID).Name = "Current_GlAcctID";
    this.Current_GlAcctID.Style = "background-color: Yellow; ddo-char-set: 0";
    this.Current_GlAcctID.Text = (string) null;
    ((ARControl) this.Current_GlAcctID).Top = 0.0f;
    ((ARControl) this.Current_GlAcctID).Visible = false;
    ((ARControl) this.Current_GlAcctID).Width = 0.5f;
    this.srNext.CloseBorder = false;
    ((ARControl) this.srNext).Height = 0.0f;
    ((ARControl) this.srNext).Left = 0.0f;
    ((ARControl) this.srNext).Name = "srNext";
    this.srNext.Report = (SectionReport) null;
    ((ARControl) this.srNext).Top = 3f / 16f;
    ((ARControl) this.srNext).Width = 7.875f;
    ((ARControl) this.txtAcct).DataField = "FullName";
    ((ARControl) this.txtAcct).Height = 3f / 16f;
    ((ARControl) this.txtAcct).Left = 0.25f;
    ((ARControl) this.txtAcct).Name = "txtAcct";
    this.txtAcct.Style = "ddo-char-set: 0";
    this.txtAcct.Text = (string) null;
    ((ARControl) this.txtAcct).Top = 0.0f;
    ((ARControl) this.txtAcct).Width = 3.614f;
    ((ARControl) this.TextBox2).DataField = "BalForward";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 3.938f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "text-align: right; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 21f / 16f;
    ((ARControl) this.TextBox1).DataField = "Total";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 6.562f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "text-align: right; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 21f / 16f;
    ((ARControl) this.txtDtl_AcctNum).DataField = "AcctNum";
    ((ARControl) this.txtDtl_AcctNum).Height = 0.09600007f;
    ((ARControl) this.txtDtl_AcctNum).Left = 0.5f;
    ((ARControl) this.txtDtl_AcctNum).Name = "txtDtl_AcctNum";
    this.txtDtl_AcctNum.Style = "background-color: Red";
    this.txtDtl_AcctNum.Text = (string) null;
    ((ARControl) this.txtDtl_AcctNum).Top = 0.0f;
    ((ARControl) this.txtDtl_AcctNum).Visible = false;
    ((ARControl) this.txtDtl_AcctNum).Width = 0.6249995f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.906f;
    this.Sections.Add((Section) this.detail);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.Current_GlAcctID).EndInit();
    ((ISupportInitialize) this.txtAcct).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtDtl_AcctNum).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
