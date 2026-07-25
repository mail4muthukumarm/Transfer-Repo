// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptPremiumAndFeeBreakout
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptPremiumAndFeeBreakout : SectionReport
{
  private Guid _QuoteOptionGuid;
  private bool _ShowQuoted;
  private bool _ShowBound;
  private TextBox rowDescription;
  private TextBox rowAmount;
  private Label rowDollarSign;
  private TextBox ChargeType;

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPremiumAndFeeBreakout));
    this.Detail = new Detail();
    this.rowDescription = new TextBox();
    this.rowAmount = new TextBox();
    this.rowDollarSign = new Label();
    this.ChargeType = new TextBox();
    ((ISupportInitialize) this.rowDescription).BeginInit();
    ((ISupportInitialize) this.rowAmount).BeginInit();
    ((ISupportInitialize) this.rowDollarSign).BeginInit();
    ((ISupportInitialize) this.ChargeType).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.rowDescription,
      (ARControl) this.rowAmount,
      (ARControl) this.rowDollarSign,
      (ARControl) this.ChargeType
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.rowDescription).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowDescription).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowDescription).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowDescription).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowDescription).DataField = "Description";
    this.rowDescription.DistinctField = (string) null;
    this.rowDescription.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.rowDescription.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox rowDescription = this.rowDescription;
    object obj1 = componentResourceManager.GetObject("rowDescription.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) rowDescription).Location = pointF1;
    ((ARControl) this.rowDescription).Name = "rowDescription";
    this.rowDescription.OutputFormat = (string) null;
    ((ARControl) this.rowDescription).Size = new SizeF(2.625f, 3f / 16f);
    this.rowAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.rowAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowAmount).DataField = "Amount";
    this.rowAmount.DistinctField = (string) null;
    this.rowAmount.Font = new Font("Arial", 10f);
    this.rowAmount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox rowAmount = this.rowAmount;
    object obj2 = componentResourceManager.GetObject("rowAmount.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) rowAmount).Location = pointF2;
    ((ARControl) this.rowAmount).Name = "rowAmount";
    this.rowAmount.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.rowAmount).Size = new SizeF(1.375f, 3f / 16f);
    this.rowAmount.Text = " ";
    ((ARControl) this.rowDollarSign).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowDollarSign).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowDollarSign).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.rowDollarSign).Border.TopStyle = (BorderLineStyle) 0;
    this.rowDollarSign.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.rowDollarSign.ForeColor = Color.FromArgb(0, 0, 0);
    this.rowDollarSign.HyperLink = (string) null;
    Label rowDollarSign = this.rowDollarSign;
    object obj3 = componentResourceManager.GetObject("rowDollarSign.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) rowDollarSign).Location = pointF3;
    ((ARControl) this.rowDollarSign).Name = "rowDollarSign";
    ((ARControl) this.rowDollarSign).Size = new SizeF(0.125f, 3f / 16f);
    this.rowDollarSign.Text = "$";
    this.ChargeType.BackColor = Color.Yellow;
    ((ARControl) this.ChargeType).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.ChargeType).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.ChargeType).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.ChargeType).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.ChargeType).DataField = "ChargeType";
    this.ChargeType.DistinctField = (string) null;
    this.ChargeType.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ChargeType.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox chargeType = this.ChargeType;
    object obj4 = componentResourceManager.GetObject("ChargeType.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) chargeType).Location = pointF4;
    ((ARControl) this.ChargeType).Name = "ChargeType";
    this.ChargeType.OutputFormat = (string) null;
    ((ARControl) this.ChargeType).Size = new SizeF(5f / 16f, 1f / 16f);
    ((ARControl) this.ChargeType).Visible = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 4.115f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    ((ISupportInitialize) this.rowDescription).EndInit();
    ((ISupportInitialize) this.rowAmount).EndInit();
    ((ISupportInitialize) this.rowDollarSign).EndInit();
    ((ISupportInitialize) this.ChargeType).EndInit();
  }

  public rptPremiumAndFeeBreakout(Guid QuoteOptionGuid, bool ShowQuoted, bool ShowBound)
  {
    this.ReportStart += new EventHandler(this.rptPremiumAndFeeBreakout_ReportStart);
    this._QuoteOptionGuid = Guid.Empty;
    this._ShowQuoted = true;
    this._ShowBound = true;
    this.InitializeComponent();
    this._QuoteOptionGuid = QuoteOptionGuid;
    this._ShowQuoted = ShowQuoted;
    this._ShowBound = ShowBound;
  }

  public rptPremiumAndFeeBreakout(Guid QuoteOptionGuid)
  {
    this.ReportStart += new EventHandler(this.rptPremiumAndFeeBreakout_ReportStart);
    this._QuoteOptionGuid = Guid.Empty;
    this._ShowQuoted = true;
    this._ShowBound = true;
    this.InitializeComponent();
    this._QuoteOptionGuid = QuoteOptionGuid;
    this._ShowQuoted = true;
    this._ShowBound = true;
  }

  private void rptPremiumAndFeeBreakout_ReportStart(object sender, EventArgs e)
  {
    if (!this._QuoteOptionGuid.Equals(Guid.Empty))
      this.DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.rptPremiumAndFeeBreakout", new object[6]
      {
        (object) "@QuoteOptionGuid",
        (object) this._QuoteOptionGuid,
        (object) "@ShowQuoted",
        (object) this._ShowQuoted,
        (object) "@ShowBound",
        (object) this._ShowBound
      });
    else
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).BeforePrint -= new EventHandler(this.Detail_BeforePrint);
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    string text = this.ChargeType.Text;
    if (Operators.CompareString(text, "SUB_TOTAL", false) != 0)
    {
      if (Operators.CompareString(text, "GRAND_TOTAL", false) == 0)
      {
        ((ARControl) this.rowDollarSign).Border.TopStyle = (BorderLineStyle) 7;
        ((ARControl) this.rowAmount).Border.TopStyle = (BorderLineStyle) 7;
        ((ARControl) this.rowDescription).Border.TopStyle = (BorderLineStyle) 7;
      }
      else
      {
        ((ARControl) this.rowDollarSign).Border.TopStyle = (BorderLineStyle) 0;
        ((ARControl) this.rowAmount).Border.TopStyle = (BorderLineStyle) 0;
        ((ARControl) this.rowDescription).Border.TopStyle = (BorderLineStyle) 0;
      }
    }
    else
    {
      ((ARControl) this.rowDollarSign).Border.TopStyle = (BorderLineStyle) 1;
      ((ARControl) this.rowAmount).Border.TopStyle = (BorderLineStyle) 1;
      ((ARControl) this.rowDescription).Border.TopStyle = (BorderLineStyle) 1;
    }
  }

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
}
