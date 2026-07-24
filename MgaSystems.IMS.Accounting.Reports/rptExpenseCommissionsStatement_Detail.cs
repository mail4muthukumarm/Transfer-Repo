// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptExpenseCommissionsStatement_Detail
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

public class rptExpenseCommissionsStatement_Detail : SectionReport
{
  private DataView _dv;
  private DataTable _dt;
  private TextBox txtLOBChg;
  private TextBox txtTran;
  private TextBox txtAgency;
  private TextBox txtAgencyComm;
  private TextBox txtRate;
  private TextBox txtPBComm;
  private TextBox txtPayAmt;

  public rptExpenseCommissionsStatement_Detail()
  {
    this.ReportStart += new EventHandler(this.rptExpenseCommissionsStatement_Detail_ReportStart);
    this.InitializeComponent();
  }

  public rptExpenseCommissionsStatement_Detail(DataView dataView)
  {
    this.ReportStart += new EventHandler(this.rptExpenseCommissionsStatement_Detail_ReportStart);
    this.InitializeComponent();
    this._dv = dataView;
    this.DataSource = (object) this._dv;
  }

  public rptExpenseCommissionsStatement_Detail(DataTable dataTable)
  {
    this.ReportStart += new EventHandler(this.rptExpenseCommissionsStatement_Detail_ReportStart);
    this.InitializeComponent();
    this._dt = dataTable;
    this.DataSource = (object) this._dt;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptExpenseCommissionsStatement_Detail));
    this.Detail = new Detail();
    this.txtLOBChg = new TextBox();
    this.txtTran = new TextBox();
    this.txtAgency = new TextBox();
    this.txtAgencyComm = new TextBox();
    this.txtRate = new TextBox();
    this.txtPBComm = new TextBox();
    this.txtPayAmt = new TextBox();
    ((ISupportInitialize) this.txtLOBChg).BeginInit();
    ((ISupportInitialize) this.txtTran).BeginInit();
    ((ISupportInitialize) this.txtAgency).BeginInit();
    ((ISupportInitialize) this.txtAgencyComm).BeginInit();
    ((ISupportInitialize) this.txtRate).BeginInit();
    ((ISupportInitialize) this.txtPBComm).BeginInit();
    ((ISupportInitialize) this.txtPayAmt).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.txtLOBChg,
      (ARControl) this.txtTran,
      (ARControl) this.txtAgency,
      (ARControl) this.txtAgencyComm,
      (ARControl) this.txtRate,
      (ARControl) this.txtPBComm,
      (ARControl) this.txtPayAmt
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtLOBChg).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLOBChg).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLOBChg).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLOBChg).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLOBChg).DataField = "Description";
    this.txtLOBChg.DistinctField = (string) null;
    this.txtLOBChg.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtLOBChg.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtLobChg = this.txtLOBChg;
    object obj1 = componentResourceManager.GetObject("txtLOBChg.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtLobChg).Location = pointF1;
    ((ARControl) this.txtLOBChg).Name = "txtLOBChg";
    this.txtLOBChg.OutputFormat = (string) null;
    ((ARControl) this.txtLOBChg).Size = new SizeF(29f / 16f, 0.125f);
    this.txtLOBChg.Text = "txtLOBChg";
    ((ARControl) this.txtTran).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTran).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTran).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTran).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTran).DataField = "TransactionType";
    this.txtTran.DistinctField = (string) null;
    this.txtTran.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTran.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTran = this.txtTran;
    object obj2 = componentResourceManager.GetObject("txtTran.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtTran).Location = pointF2;
    ((ARControl) this.txtTran).Name = "txtTran";
    ((ARControl) this.txtTran).Size = new SizeF(7f / 16f, 0.125f);
    this.txtTran.Text = "txtTran";
    this.txtAgency.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAgency).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgency).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgency).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgency).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgency).DataField = "AgencyGross";
    this.txtAgency.DistinctField = (string) null;
    this.txtAgency.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAgency.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAgency = this.txtAgency;
    object obj3 = componentResourceManager.GetObject("txtAgency.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtAgency).Location = pointF3;
    ((ARControl) this.txtAgency).Name = "txtAgency";
    this.txtAgency.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtAgency).Size = new SizeF(0.75f, 0.125f);
    this.txtAgency.Text = "0.00";
    this.txtAgencyComm.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAgencyComm).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyComm).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyComm).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyComm).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyComm).DataField = "AgencyCommission";
    this.txtAgencyComm.DistinctField = (string) null;
    this.txtAgencyComm.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAgencyComm.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAgencyComm = this.txtAgencyComm;
    object obj4 = componentResourceManager.GetObject("txtAgencyComm.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) txtAgencyComm).Location = pointF4;
    ((ARControl) this.txtAgencyComm).Name = "txtAgencyComm";
    this.txtAgencyComm.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtAgencyComm).Size = new SizeF(0.75f, 0.125f);
    this.txtRate.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtRate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRate).DataField = "PayeePercentRate";
    this.txtRate.DistinctField = (string) null;
    this.txtRate.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtRate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtRate = this.txtRate;
    object obj5 = componentResourceManager.GetObject("txtRate.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) txtRate).Location = pointF5;
    ((ARControl) this.txtRate).Name = "txtRate";
    this.txtRate.OutputFormat = "0.00";
    ((ARControl) this.txtRate).Size = new SizeF(7f / 16f, 0.125f);
    this.txtPBComm.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPBComm).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPBComm).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPBComm).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPBComm).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPBComm).DataField = "Balance";
    this.txtPBComm.DistinctField = (string) null;
    this.txtPBComm.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtPBComm.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPbComm = this.txtPBComm;
    object obj6 = componentResourceManager.GetObject("txtPBComm.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) txtPbComm).Location = pointF6;
    ((ARControl) this.txtPBComm).Name = "txtPBComm";
    this.txtPBComm.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtPBComm).Size = new SizeF(0.75f, 0.125f);
    this.txtPayAmt.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPayAmt).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayAmt).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayAmt).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayAmt).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayAmt).DataField = "PayeeAMT";
    this.txtPayAmt.DistinctField = (string) null;
    this.txtPayAmt.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtPayAmt.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPayAmt = this.txtPayAmt;
    object obj7 = componentResourceManager.GetObject("txtPayAmt.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) txtPayAmt).Location = pointF7;
    ((ARControl) this.txtPayAmt).Name = "txtPayAmt";
    this.txtPayAmt.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtPayAmt).Size = new SizeF(0.75f, 0.125f);
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 6.114583f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    ((ISupportInitialize) this.txtLOBChg).EndInit();
    ((ISupportInitialize) this.txtTran).EndInit();
    ((ISupportInitialize) this.txtAgency).EndInit();
    ((ISupportInitialize) this.txtAgencyComm).EndInit();
    ((ISupportInitialize) this.txtRate).EndInit();
    ((ISupportInitialize) this.txtPBComm).EndInit();
    ((ISupportInitialize) this.txtPayAmt).EndInit();
  }

  private void rptExpenseCommissionsStatement_Detail_ReportStart(object sender, EventArgs e)
  {
  }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
