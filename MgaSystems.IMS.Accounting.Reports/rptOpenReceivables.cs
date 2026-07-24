// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptOpenReceivables
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptOpenReceivables : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{295605D7-0122-463d-8076-AC2A55A78F2B}";
  private int _OfficeID;
  private Guid _EntityGuid;
  private Guid _CarrierGuid;
  private DateTime _datFrom;
  private DateTime _datTo;
  private string _ClientOfficeName;
  private bool _sortByPolicyNumber;
  private int _progressCount;
  private bool _finished;
  private Label lblTitle;
  private TextBox txtCompany;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label8;
  private Label Label10;
  private TextBox txtGrouping;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox14;
  private TextBox TextBox16;
  private TextBox txtDueDate;
  private TextBox TextBox8;
  private Label Label9;
  private Label Label;
  private TextBox TextBox9;
  private Label txtGroupingTotal;
  private TextBox TextBox13;
  private TextBox TextBox15;
  private TextBox AmountPaid1;
  private Label Label16;
  private TextBox Premium1;
  private TextBox GrossPremium1;
  private TextBox Balance1;

  public rptOpenReceivables()
  {
    this.ReportStart += new EventHandler(this.rptBoundAccounts_ReportStart);
    this._finished = false;
  }

  public rptOpenReceivables(
    Guid OfficeGUID,
    Guid EntityGuid,
    DateTime datFrom,
    DateTime datTo,
    Guid CarrierGuid,
    bool sortByPolicyNum)
  {
    this.ReportStart += new EventHandler(this.rptBoundAccounts_ReportStart);
    this._finished = false;
    this.InitializeComponent();
    DataRow dataRow = Database.Instance.QueryText.PerformRowQuery($"SELECT Location, OfficeID FROM tblClientOffices WHERE OfficeGUID = '{OfficeGUID.ToString()}'");
    this._ClientOfficeName = dataRow[0].ToString();
    this._OfficeID = Conversions.ToInteger(dataRow[1]);
    this._EntityGuid = EntityGuid;
    this._CarrierGuid = CarrierGuid;
    this._datFrom = datFrom;
    this._datTo = datTo;
    this._sortByPolicyNumber = sortByPolicyNum;
    if (this._sortByPolicyNumber)
      this.GroupFooter1.NewPage = (NewPage) 0;
    this.SetStatusText("Getting Monthly Data..");
    this.SetProgressbarMaximum(100);
    ArrayList arrayList = new ArrayList();
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@GLCoId",
      (object) this._OfficeID
    });
    if (DateTime.Compare(this._datFrom, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@StartDate",
        (object) this._datFrom.Date
      });
    if (DateTime.Compare(this._datTo, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@EndDate",
        (object) this._datTo.Date
      });
    if (!this._EntityGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@RemitterGUID",
        (object) EntityGuid
      });
    if (!this._CarrierGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@CarrierGUID",
        (object) CarrierGuid
      });
    Database.Instance.QueryMultithreadedSP.PerformTableQueryBG(new TableQueryMultithreadEventHandler(this.queryComplete), new TableFillingEventHandler(this.queryProgress), (object) "Open Receivables Report Report", nameof (rptOpenReceivables), arrayList.ToArray());
  }

  private void queryComplete(object sender, TableQueryMultithreadEventArgs e)
  {
    if (this._sortByPolicyNumber)
    {
      this.DataSource = (object) new DataView(e.Table, "", "PolicyNum, EffectiveDate, Insured", DataViewRowState.CurrentRows);
      ((ARControl) this.txtGrouping).DataField = "PolicyNum";
      ((ARControl) this.txtGroupingTotal).DataField = "PolicyNum";
    }
    else
    {
      this.DataSource = (object) new DataView(e.Table, "", "EffectiveDate, Insured", DataViewRowState.CurrentRows);
      ((ARControl) this.txtGrouping).DataField = "Month";
      ((ARControl) this.txtGroupingTotal).DataField = "Month";
    }
    this._finished = true;
  }

  private void queryProgress(object sender, TableFillingEventArgs e)
  {
    this.IncreaseProgressbar(1);
    // ISSUE: variable of a reference type
    int& local1;
    // ISSUE: explicit reference operation
    int num1 = checked (^(local1 = ref this._progressCount) + 1);
    local1 = num1;
    if (this._progressCount != 99)
      return;
    this.IncreaseProgressbar(-25);
    // ISSUE: variable of a reference type
    int& local2;
    // ISSUE: explicit reference operation
    int num2 = checked (^(local2 = ref this._progressCount) - 25);
    local2 = num2;
  }

  private void rptBoundAccounts_ReportStart(object sender, EventArgs e)
  {
    do
      ;
    while (!this._finished);
    this.lblTitle.Text = DateTime.Compare(this._datFrom, DateTime.MinValue) != 0 || DateTime.Compare(this._datTo, DateTime.MinValue) != 0 ? $"Open Receivables ({this._datFrom.ToString("MM/dd/yyyy")} - {this._datTo.ToString("MM/dd/yyyy")})" : (DateTime.Compare(this._datFrom, DateTime.MinValue) == 0 ? (DateTime.Compare(this._datTo, DateTime.MinValue) == 0 ? "Open Receivables" : $"Open Receivables (Before {this._datTo.ToString("MM/dd/yyyy")})") : $"Open Receivables (After {this._datFrom.ToString("MM/dd/yyyy")})");
    this.Document.Name = "Open Receivables Report";
    this.txtCompany.Text = this._ClientOfficeName;
    this.SetStandardMargins();
    this.ShowPageNumbers();
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public override bool IsThreaded => true;

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptOpenReceivables));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.lblTitle = new Label();
    this.txtCompany = new TextBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.Label10 = new Label();
    this.txtGrouping = new TextBox();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox14 = new TextBox();
    this.TextBox16 = new TextBox();
    this.txtDueDate = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox8 = new TextBox();
    this.Label9 = new Label();
    this.TextBox9 = new TextBox();
    this.txtGroupingTotal = new Label();
    this.TextBox13 = new TextBox();
    this.TextBox15 = new TextBox();
    this.AmountPaid1 = new TextBox();
    this.Label16 = new Label();
    this.Premium1 = new TextBox();
    this.GrossPremium1 = new TextBox();
    this.Balance1 = new TextBox();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.txtGrouping).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.txtDueDate).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.txtGroupingTotal).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.AmountPaid1).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Premium1).BeginInit();
    ((ISupportInitialize) this.GrossPremium1).BeginInit();
    ((ISupportInitialize) this.Balance1).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox16,
      (ARControl) this.txtDueDate,
      (ARControl) this.TextBox
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.2076389f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.txtCompany
    });
    this.ReportHeader.Height = 0.4895833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.AmountPaid1,
      (ARControl) this.Label16,
      (ARControl) this.Premium1,
      (ARControl) this.GrossPremium1,
      (ARControl) this.Balance1,
      (ARControl) this.TextBox11
    });
    this.ReportFooter.Height = 0.3333333f;
    this.ReportFooter.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label8,
      (ARControl) this.Label10,
      (ARControl) this.txtGrouping,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label
    });
    this.GroupHeader1.DataField = "Month";
    this.GroupHeader1.Height = 29f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.TextBox8,
      (ARControl) this.Label9,
      (ARControl) this.TextBox9,
      (ARControl) this.txtGroupingTotal,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox6
    });
    this.GroupFooter1.Height = 0.4270833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.GroupFooter1.NewPage = (NewPage) 2;
    this.lblTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTitle.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblTitle.HyperLink = (string) null;
    Label lblTitle = this.lblTitle;
    object obj1 = componentResourceManager.GetObject("lblTitle.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblTitle).Location = pointF1;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    ((ARControl) this.lblTitle).Size = new SizeF(9.5f, 0.25f);
    this.lblTitle.Text = "Open Receivables";
    this.txtCompany.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtCompany).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCompany.DistinctField = (string) null;
    this.txtCompany.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCompany.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCompany = this.txtCompany;
    object obj2 = componentResourceManager.GetObject("txtCompany.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtCompany).Location = pointF2;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.OutputFormat = (string) null;
    ((ARControl) this.txtCompany).Size = new SizeF(9.5f, 0.25f);
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj3 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label2).Location = pointF3;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(19f / 16f, 3f / 16f);
    this.Label2.Text = "Insured";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj4 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label3).Location = pointF4;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(1.375f, 3f / 16f);
    this.Label3.Text = "Contact";
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj5 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label4).Location = pointF5;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.75f, 5f / 16f);
    this.Label4.Text = "Net Amt. Due";
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj6 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label5).Location = pointF6;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.625f, 5f / 16f);
    this.Label5.Text = "Bound Eff Date";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj7 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label6).Location = pointF7;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label6.Text = "Policy #";
    this.Label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj8 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label8).Location = pointF8;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label8.Text = "Rec'd";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj9 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label10).Location = pointF9;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(9f / 16f, 5f / 16f);
    this.Label10.Text = "Invoice Date";
    ((ARControl) this.txtGrouping).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrouping).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrouping).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrouping).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGrouping.DistinctField = (string) null;
    this.txtGrouping.Font = new Font("Arial", 14.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtGrouping.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtGrouping = this.txtGrouping;
    object obj10 = componentResourceManager.GetObject("txtGrouping.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) txtGrouping).Location = pointF10;
    ((ARControl) this.txtGrouping).Name = "txtGrouping";
    this.txtGrouping.OutputFormat = (string) null;
    ((ARControl) this.txtGrouping).Size = new SizeF(7f, 0.25f);
    this.Label12.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj11 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label12).Location = pointF11;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(13f / 16f, 5f / 16f);
    this.Label12.Text = "Gross Premium";
    this.Label13.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj12 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label13).Location = pointF12;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label13.Text = "Balance";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj13 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label14).Location = pointF13;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label14.Text = "Invoice #";
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj14 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label15).Location = pointF14;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(0.625f, 3f / 16f);
    this.Label15.Text = "Due Date";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "Insured";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj15 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox1).Location = pointF15;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(19f / 16f, 3f / 16f);
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "Contact";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj16 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox2).Location = pointF16;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(1.375f, 3f / 16f);
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "Premium";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj17 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox3).Location = pointF17;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox4.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "EffectiveDate";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj18 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox4).Location = pointF18;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox4).Size = new SizeF(0.625f, 3f / 16f);
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "PolicyNum";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj19 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox5).Location = pointF19;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(15f / 16f, 3f / 16f);
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "AmountPaid";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj20 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox7).Location = pointF20;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox7).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox10.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "InvoiceDate";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj21 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox10).Location = pointF21;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox10).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox12.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).DataField = "GrossPremium";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj22 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox12).Location = pointF22;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox12).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox12.Text = " ";
    this.TextBox14.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).DataField = "Balance";
    this.TextBox14.DistinctField = (string) null;
    this.TextBox14.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox14.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox14 = this.TextBox14;
    object obj23 = componentResourceManager.GetObject("TextBox14.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox14).Location = pointF23;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox14).Size = new SizeF(11f / 16f, 3f / 16f);
    ((ARControl) this.TextBox16).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).DataField = "OfficeInvoiceNum";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox16 = this.TextBox16;
    object obj24 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox16).Location = pointF24;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = (string) null;
    ((ARControl) this.TextBox16).Size = new SizeF(11f / 16f, 3f / 16f);
    this.txtDueDate.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtDueDate).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDueDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDueDate).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDueDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDueDate).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDueDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDueDate).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDueDate).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDueDate).DataField = "DueDate";
    this.txtDueDate.DistinctField = (string) null;
    this.txtDueDate.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDueDate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDueDate = this.txtDueDate;
    object obj25 = componentResourceManager.GetObject("txtDueDate.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) txtDueDate).Location = pointF25;
    ((ARControl) this.txtDueDate).Name = "txtDueDate";
    this.txtDueDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtDueDate).Size = new SizeF(0.625f, 3f / 16f);
    this.TextBox.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "Fees";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj26 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox).Location = pointF26;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "AmountPaid";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj27 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox8).Location = pointF27;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox8.SummaryGroup = "GroupHeader1";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.Label9.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj28 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) label9).Location = pointF28;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(7f / 16f, 3f / 16f);
    this.Label9.Text = "Totals:";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "Premium";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj29 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) textBox9).Location = pointF29;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox9.SummaryGroup = "GroupHeader1";
    this.TextBox9.SummaryRunning = (SummaryRunning) 1;
    this.TextBox9.SummaryType = (SummaryType) 3;
    this.txtGroupingTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGroupingTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGroupingTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGroupingTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGroupingTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGroupingTotal.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtGroupingTotal.ForeColor = Color.FromArgb(0, 0, 0);
    this.txtGroupingTotal.HyperLink = (string) null;
    Label txtGroupingTotal = this.txtGroupingTotal;
    object obj30 = componentResourceManager.GetObject("txtGroupingTotal.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) txtGroupingTotal).Location = pointF30;
    ((ARControl) this.txtGroupingTotal).Name = "txtGroupingTotal";
    ((ARControl) this.txtGroupingTotal).Size = new SizeF(3.625f, 3f / 16f);
    this.txtGroupingTotal.Text = "";
    this.TextBox13.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "GrossPremium";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj31 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) textBox13).Location = pointF31;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox13).Size = new SizeF(1f, 3f / 16f);
    this.TextBox13.SummaryGroup = "GroupHeader1";
    this.TextBox13.SummaryRunning = (SummaryRunning) 1;
    this.TextBox13.SummaryType = (SummaryType) 3;
    this.TextBox13.Text = " ";
    this.TextBox15.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).DataField = "Balance";
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox15.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox15 = this.TextBox15;
    object obj32 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) textBox15).Location = pointF32;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox15).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox15.SummaryGroup = "GroupHeader1";
    this.TextBox15.SummaryRunning = (SummaryRunning) 1;
    this.TextBox15.SummaryType = (SummaryType) 3;
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "Fees";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj33 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) textBox6).Location = pointF33;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox6.SummaryGroup = "GroupHeader1";
    this.TextBox6.SummaryRunning = (SummaryRunning) 1;
    this.TextBox6.SummaryType = (SummaryType) 3;
    this.AmountPaid1.Alignment = (TextAlignment) 2;
    ((ARControl) this.AmountPaid1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.AmountPaid1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.AmountPaid1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.AmountPaid1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.AmountPaid1).DataField = "AmountPaid";
    this.AmountPaid1.DistinctField = (string) null;
    this.AmountPaid1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.AmountPaid1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox amountPaid1 = this.AmountPaid1;
    object obj34 = componentResourceManager.GetObject("AmountPaid1.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) amountPaid1).Location = pointF34;
    ((ARControl) this.AmountPaid1).Name = "AmountPaid1";
    this.AmountPaid1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.AmountPaid1).Size = new SizeF(11f / 16f, 3f / 16f);
    this.AmountPaid1.SummaryRunning = (SummaryRunning) 2;
    this.AmountPaid1.SummaryType = (SummaryType) 1;
    this.Label16.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj35 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) label16).Location = pointF35;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label16.Text = "Grand Totals:";
    this.Premium1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Premium1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Premium1).DataField = "Premium";
    this.Premium1.DistinctField = (string) null;
    this.Premium1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Premium1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox premium1 = this.Premium1;
    object obj36 = componentResourceManager.GetObject("Premium1.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) premium1).Location = pointF36;
    ((ARControl) this.Premium1).Name = "Premium1";
    this.Premium1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.Premium1).Size = new SizeF(0.75f, 3f / 16f);
    this.Premium1.SummaryRunning = (SummaryRunning) 2;
    this.Premium1.SummaryType = (SummaryType) 1;
    this.GrossPremium1.Alignment = (TextAlignment) 2;
    ((ARControl) this.GrossPremium1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.GrossPremium1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.GrossPremium1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.GrossPremium1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.GrossPremium1).DataField = "GrossPremium";
    this.GrossPremium1.DistinctField = (string) null;
    this.GrossPremium1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.GrossPremium1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox grossPremium1 = this.GrossPremium1;
    object obj37 = componentResourceManager.GetObject("GrossPremium1.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) grossPremium1).Location = pointF37;
    ((ARControl) this.GrossPremium1).Name = "GrossPremium1";
    this.GrossPremium1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.GrossPremium1).Size = new SizeF(1f, 3f / 16f);
    this.GrossPremium1.SummaryRunning = (SummaryRunning) 2;
    this.GrossPremium1.SummaryType = (SummaryType) 1;
    this.GrossPremium1.Text = " ";
    this.Balance1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Balance1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Balance1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Balance1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Balance1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Balance1).DataField = "Balance";
    this.Balance1.DistinctField = (string) null;
    this.Balance1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Balance1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox balance1 = this.Balance1;
    object obj38 = componentResourceManager.GetObject("Balance1.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) balance1).Location = pointF38;
    ((ARControl) this.Balance1).Name = "Balance1";
    this.Balance1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.Balance1).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Balance1.SummaryRunning = (SummaryRunning) 2;
    this.Balance1.SummaryType = (SummaryType) 1;
    this.TextBox11.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "Fees";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj39 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) textBox11).Location = pointF39;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox11).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox11.SummaryRunning = (SummaryRunning) 2;
    this.TextBox11.SummaryType = (SummaryType) 1;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 9.5f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.txtGrouping).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.txtDueDate).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.txtGroupingTotal).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.AmountPaid1).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Premium1).EndInit();
    ((ISupportInitialize) this.GrossPremium1).EndInit();
    ((ISupportInitialize) this.Balance1).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
  }

  public Type getLaunchForm => typeof (frmBoundAccounts);

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
