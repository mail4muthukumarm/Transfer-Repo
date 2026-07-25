// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptQuoteDocFees
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptQuoteDocFees : SectionReport
{
  private Label lblDollar;
  private TextBox txtAmount;
  private TextBox txtCharge;
  private readonly Guid _QuoteGuid;
  private readonly bool _ShowPremiums;

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

  public rptQuoteDocFees(Guid QuoteGuid, bool ShowPremiums)
  {
    this.ReportStart += new EventHandler(this.rptQuoteDocFees_ReportStart);
    this._ShowPremiums = false;
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
    this._ShowPremiums = ShowPremiums;
  }

  public rptQuoteDocFees(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptQuoteDocFees_ReportStart);
    this._ShowPremiums = false;
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
  }

  public rptQuoteDocFees(Guid QuoteGuid, bool ShowPremiums, float fontsize)
  {
    this.ReportStart += new EventHandler(this.rptQuoteDocFees_ReportStart);
    this._ShowPremiums = false;
    this.InitializeComponent();
    if ((double) fontsize == 12.0)
    {
      this.txtAmount.Font = new Font("Times New Roman", fontsize, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCharge.Font = new Font("Times New Roman", fontsize, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDollar.Font = new Font("Times New Roman", fontsize, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    }
    this._QuoteGuid = QuoteGuid;
    this._ShowPremiums = ShowPremiums;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptQuoteDocFees));
    this.Detail = new Detail();
    this.lblDollar = new Label();
    this.txtAmount = new TextBox();
    this.txtCharge = new TextBox();
    ((ISupportInitialize) this.lblDollar).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtCharge).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblDollar,
      (ARControl) this.txtAmount,
      (ARControl) this.txtCharge
    });
    ((Section) this.Detail).Height = 0.0f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.lblDollar).Border.BottomColor = Color.Black;
    ((ARControl) this.lblDollar).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.LeftColor = Color.Black;
    ((ARControl) this.lblDollar).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.RightColor = Color.Black;
    ((ARControl) this.lblDollar).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Border.TopColor = Color.Black;
    ((ARControl) this.lblDollar).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDollar).Height = 3f / 16f;
    this.lblDollar.HyperLink = (string) null;
    ((ARControl) this.lblDollar).Left = 0.0f;
    ((ARControl) this.lblDollar).Name = "lblDollar";
    this.lblDollar.Style = "font-size: 8pt; vertical-align: middle; ";
    this.lblDollar.Text = "$";
    ((ARControl) this.lblDollar).Top = 0.0f;
    ((ARControl) this.lblDollar).Width = 0.125f;
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
    ((ARControl) this.txtAmount).Left = 0.125f;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = resourceManager.GetString("txtAmount.OutputFormat");
    this.txtAmount.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: middle; ";
    this.txtAmount.Text = " ";
    ((ARControl) this.txtAmount).Top = 0.0f;
    ((ARControl) this.txtAmount).Width = 13f / 16f;
    ((ARControl) this.txtCharge).Border.BottomColor = Color.Black;
    ((ARControl) this.txtCharge).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCharge).Border.LeftColor = Color.Black;
    ((ARControl) this.txtCharge).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCharge).Border.RightColor = Color.Black;
    ((ARControl) this.txtCharge).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCharge).Border.TopColor = Color.Black;
    ((ARControl) this.txtCharge).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCharge).DataField = "ChargeName";
    ((ARControl) this.txtCharge).Height = 3f / 16f;
    ((ARControl) this.txtCharge).Left = 15f / 16f;
    ((ARControl) this.txtCharge).Name = "txtCharge";
    this.txtCharge.Style = "font-size: 8pt; vertical-align: middle; ";
    this.txtCharge.Text = (string) null;
    ((ARControl) this.txtCharge).Top = 0.0f;
    ((ARControl) this.txtCharge).Width = 63f / 16f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 5f;
    this.Sections.Add((Section) this.Detail);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.lblDollar).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtCharge).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptQuoteDocFees_ReportStart(object sender, EventArgs e)
  {
    if (this._ShowPremiums)
      this.DataSource = (object) DefaultDatabase.ExecuteDataTable("rptQuoteDocFees_WithPremiums", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._QuoteGuid
      });
    else
      this.DataSource = (object) DefaultDatabase.ExecuteDataTable(nameof (rptQuoteDocFees), new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._QuoteGuid
      });
  }

  private void Detail_Format(object sender, EventArgs e)
  {
  }
}
