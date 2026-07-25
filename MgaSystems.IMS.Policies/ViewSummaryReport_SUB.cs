// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ViewSummaryReport_SUB
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class ViewSummaryReport_SUB : SectionReport
{
  private IContainer components;
  private Label lblState;
  private Label lblItem;
  private Label lblOffice;
  private TextBox TextBox1;
  private DataView _dv;
  private object _currCode;
  private CultureInfo _cInfo;
  private dsPolicyDetail_Premiums _ds;

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (ViewSummaryReport_SUB));
    this.PageHeader1 = new PageHeader();
    this.Detail1 = new Detail();
    this.lblState = new Label();
    this.lblItem = new Label();
    this.lblOffice = new Label();
    this.TextBox1 = new TextBox();
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this.lblState).BeginInit();
    ((ISupportInitialize) this.lblItem).BeginInit();
    ((ISupportInitialize) this.lblOffice).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.PageHeader1.Height = 3f / 16f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
    ((Section) this.Detail1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.lblState,
      (ARControl) this.lblItem,
      (ARControl) this.lblOffice,
      (ARControl) this.TextBox1
    });
    ((Section) this.Detail1).Height = 3f / 16f;
    ((Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.lblState).DataField = "StateID";
    ((ARControl) this.lblState).Height = 3f / 16f;
    this.lblState.HyperLink = (string) null;
    ((ARControl) this.lblState).Left = 0.0f;
    ((ARControl) this.lblState).Name = "lblState";
    this.lblState.Style = "";
    this.lblState.Text = "State";
    ((ARControl) this.lblState).Top = 0.0f;
    ((ARControl) this.lblState).Width = 0.625f;
    ((ARControl) this.lblItem).DataField = "ChargeName";
    ((ARControl) this.lblItem).Height = 3f / 16f;
    this.lblItem.HyperLink = (string) null;
    ((ARControl) this.lblItem).Left = 11f / 16f;
    ((ARControl) this.lblItem).Name = "lblItem";
    this.lblItem.Style = "";
    this.lblItem.Text = "Item";
    ((ARControl) this.lblItem).Top = 0.0f;
    ((ARControl) this.lblItem).Width = 2.125f;
    ((ARControl) this.lblOffice).DataField = "Location";
    ((ARControl) this.lblOffice).Height = 3f / 16f;
    this.lblOffice.HyperLink = (string) null;
    ((ARControl) this.lblOffice).Left = 65f / 16f;
    ((ARControl) this.lblOffice).Name = "lblOffice";
    this.lblOffice.Style = "";
    this.lblOffice.Text = "Office";
    ((ARControl) this.lblOffice).Top = 0.0f;
    ((ARControl) this.lblOffice).Width = 2.375f;
    ((ARControl) this.TextBox1).DataField = "Premium";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 45f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Text = "Amount";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 19f / 16f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.Detail1);
    this.Sections.Add((Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; text-align: left; vertical-align: top; ddo-char-set: 1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: bold", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.lblState).EndInit();
    ((ISupportInitialize) this.lblItem).EndInit();
    ((ISupportInitialize) this.lblOffice).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail1
  {
    get => this._Detail1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail1_Format);
      Detail detail1_1 = this._Detail1;
      if (detail1_1 != null)
        ((Section) detail1_1).Format -= eventHandler;
      this._Detail1 = value;
      Detail detail1_2 = this._Detail1;
      if (detail1_2 == null)
        return;
      ((Section) detail1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public ViewSummaryReport_SUB()
  {
    this.ReportStart += new EventHandler(this.ViewSummaryReport_SUB_ReportStart);
    this._dv = new DataView();
    this._currCode = (object) null;
    this._cInfo = (CultureInfo) null;
    this._ds = new dsPolicyDetail_Premiums();
    this.InitializeComponent();
  }

  public ViewSummaryReport_SUB(DataView dv)
  {
    this.ReportStart += new EventHandler(this.ViewSummaryReport_SUB_ReportStart);
    this._dv = new DataView();
    this._currCode = (object) null;
    this._cInfo = (CultureInfo) null;
    this._ds = new dsPolicyDetail_Premiums();
    this.InitializeComponent();
    this._dv = dv;
  }

  private object CurrencyCode
  {
    get
    {
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(this._currCode)))
        this._currCode = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select dbo.GetQuoteCurrencyCode(@quoteId)", new object[2]
        {
          (object) "@QuoteId",
          (object) new Quote(new QuoteOption(this._dv.Table.Rows[0].Field<Guid>("quoteoptionguid")).QuoteGuid).QuoteID
        }));
      return this._currCode;
    }
  }

  private object CurrencyCultureInfo
  {
    get
    {
      if (Utility.IsNull((object) this._cInfo) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.CurrencyCode)))
        this._cInfo = MultiCurrencyUtilities.GetCultureInfo(this.CurrencyCode.ToString());
      return (object) this._cInfo;
    }
  }

  private void Detail1_Format(object sender, EventArgs e)
  {
    Decimal num = 0M;
    if (!string.IsNullOrEmpty(this.TextBox1.Text))
      num = Convert.ToDecimal(this.TextBox1.Text);
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.CurrencyCultureInfo)))
      this.TextBox1.Text = num.ToString("c", (IFormatProvider) this.CurrencyCultureInfo);
    else
      this.TextBox1.Text = num.ToString("c");
  }

  private void ViewSummaryReport_SUB_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._dv;
  }
}
