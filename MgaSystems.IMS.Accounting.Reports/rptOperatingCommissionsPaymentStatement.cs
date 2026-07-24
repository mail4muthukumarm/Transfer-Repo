// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptOperatingCommissionsPaymentStatement
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[DesignerGenerated]
public class rptOperatingCommissionsPaymentStatement : MGAReport, IReport
{
  private IContainer components;
  private DataTable _dt;
  private DateTime _DateFrom;
  private Guid _PayeeGuid;
  private int _OfficeID;
  private bool _ShowAll;
  private int _detailCounter;
  private string _PayeeName;
  private DataSet _dataset;
  private Decimal _AgencyGross;
  private Decimal _AgencyComm;
  private Decimal _PBComm;
  private Decimal _PayAmount;
  private string _Location;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptOperatingCommissionsPaymentStatement));
    this.PageHeader1 = new PageHeader();
    this.Detail1 = new Detail();
    this.PageFooter1 = new PageFooter();
    this.ReportHeader1 = new ReportHeader();
    this.ReportFooter1 = new ReportFooter();
    this.txtPayeeName = new TextBox();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.Line3 = new Line();
    this.txtCompanyName = new TextBox();
    this.Label9 = new Label();
    this.textPrintDate = new TextBox();
    this.txtStatementDate = new TextBox();
    this.txtInsuredName = new Label();
    this.txtPolicyNum = new Label();
    this.txtInvNum = new Label();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.txtInsured = new TextBox();
    this.txtPolNum = new TextBox();
    this.txtInvoiceNum = new TextBox();
    this.txtInvoiceDate = new TextBox();
    this.txtEffective = new TextBox();
    this.SubReport = new SubReport();
    this.Label10 = new Label();
    this.txtAgencyGross = new TextBox();
    this.txtAgencyComm = new TextBox();
    this.txtPBComm = new TextBox();
    this.txtPayAmount = new TextBox();
    ((ISupportInitialize) this.txtPayeeName).BeginInit();
    ((ISupportInitialize) this.txtCompanyName).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.textPrintDate).BeginInit();
    ((ISupportInitialize) this.txtStatementDate).BeginInit();
    ((ISupportInitialize) this.txtInsuredName).BeginInit();
    ((ISupportInitialize) this.txtPolicyNum).BeginInit();
    ((ISupportInitialize) this.txtInvNum).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtInsured).BeginInit();
    ((ISupportInitialize) this.txtPolNum).BeginInit();
    ((ISupportInitialize) this.txtInvoiceNum).BeginInit();
    ((ISupportInitialize) this.txtInvoiceDate).BeginInit();
    ((ISupportInitialize) this.txtEffective).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.txtAgencyGross).BeginInit();
    ((ISupportInitialize) this.txtAgencyComm).BeginInit();
    ((ISupportInitialize) this.txtPBComm).BeginInit();
    ((ISupportInitialize) this.txtPayAmount).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.txtInsuredName,
      (ARControl) this.txtPolicyNum,
      (ARControl) this.txtInvNum,
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label8,
      (ARControl) this.Label7
    });
    this.PageHeader1.Height = 0.1770833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.txtInsured,
      (ARControl) this.txtPolNum,
      (ARControl) this.txtInvoiceNum,
      (ARControl) this.txtInvoiceDate,
      (ARControl) this.txtEffective,
      (ARControl) this.SubReport
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.txtPayeeName,
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.Line3,
      (ARControl) this.txtCompanyName,
      (ARControl) this.Label9,
      (ARControl) this.textPrintDate,
      (ARControl) this.txtStatementDate
    });
    this.ReportHeader1.Height = 1.072917f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Name = "ReportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label10,
      (ARControl) this.txtAgencyGross,
      (ARControl) this.txtAgencyComm,
      (ARControl) this.txtPBComm,
      (ARControl) this.txtPayAmount
    });
    this.ReportFooter1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Name = "ReportFooter1";
    this.txtPayeeName.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtPayeeName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayeeName).DataField = "PayeeName";
    this.txtPayeeName.DistinctField = (string) null;
    this.txtPayeeName.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtPayeeName = this.txtPayeeName;
    object obj1 = componentResourceManager.GetObject("txtPayeeName.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtPayeeName).Location = pointF1;
    ((ARControl) this.txtPayeeName).Name = "txtPayeeName";
    this.txtPayeeName.OutputFormat = (string) null;
    ((ARControl) this.txtPayeeName).Size = new SizeF(165f / 16f, 3f / 16f);
    this.txtPayeeName.Text = "txtPayeeName";
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    this.Line.X1 = 0.0f;
    this.Line.X2 = 10.375f;
    this.Line.Y1 = 0.75f;
    this.Line.Y2 = 0.75f;
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 10.375f;
    this.Line1.Y1 = 13f / 16f;
    this.Line1.Y2 = 13f / 16f;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    this.Line2.X1 = 0.0f;
    this.Line2.X2 = 10.375f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.0f;
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    this.Line3.X1 = 0.0f;
    this.Line3.X2 = 10.375f;
    this.Line3.Y1 = 1f / 16f;
    this.Line3.Y2 = 1f / 16f;
    ((ARControl) this.txtCompanyName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyName).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCompanyName.DistinctField = (string) null;
    this.txtCompanyName.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtCompanyName = this.txtCompanyName;
    object obj2 = componentResourceManager.GetObject("txtCompanyName.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtCompanyName).Location = pointF2;
    ((ARControl) this.txtCompanyName).Name = "txtCompanyName";
    this.txtCompanyName.OutputFormat = (string) null;
    ((ARControl) this.txtCompanyName).Size = new SizeF(4f, 3f / 16f);
    this.txtCompanyName.Text = (string) null;
    this.Label9.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj3 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label9).Location = pointF3;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(10.375f, 3f / 16f);
    this.Label9.Text = "Commission Payable Statements";
    this.textPrintDate.Alignment = (TextAlignment) 2;
    ((ARControl) this.textPrintDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPrintDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPrintDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPrintDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPrintDate).DataField = "printdate";
    this.textPrintDate.DistinctField = (string) null;
    this.textPrintDate.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textPrintDate = this.textPrintDate;
    object obj4 = componentResourceManager.GetObject("textPrintDate.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textPrintDate).Location = pointF4;
    ((ARControl) this.textPrintDate).Name = "textPrintDate";
    this.textPrintDate.OutputFormat = (string) null;
    ((ARControl) this.textPrintDate).Size = new SizeF(4f, 3f / 16f);
    this.textPrintDate.Text = (string) null;
    ((ARControl) this.txtStatementDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStatementDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStatementDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStatementDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStatementDate).DataField = "StatementDate";
    this.txtStatementDate.DistinctField = (string) null;
    this.txtStatementDate.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtStatementDate = this.txtStatementDate;
    object obj5 = componentResourceManager.GetObject("txtStatementDate.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) txtStatementDate).Location = pointF5;
    ((ARControl) this.txtStatementDate).Name = "txtStatementDate";
    this.txtStatementDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtStatementDate).Size = new SizeF(37f / 16f, 0.125f);
    this.txtStatementDate.Text = (string) null;
    ((ARControl) this.txtInsuredName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredName).Border.TopStyle = (BorderLineStyle) 0;
    this.txtInsuredName.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtInsuredName.HyperLink = (string) null;
    Label txtInsuredName = this.txtInsuredName;
    object obj6 = componentResourceManager.GetObject("txtInsuredName.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) txtInsuredName).Location = pointF6;
    ((ARControl) this.txtInsuredName).Name = "txtInsuredName";
    ((ARControl) this.txtInsuredName).Size = new SizeF(1f, 3f / 16f);
    this.txtInsuredName.Text = "Insured Name";
    ((ARControl) this.txtPolicyNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNum).Border.TopStyle = (BorderLineStyle) 0;
    this.txtPolicyNum.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtPolicyNum.HyperLink = (string) null;
    Label txtPolicyNum = this.txtPolicyNum;
    object obj7 = componentResourceManager.GetObject("txtPolicyNum.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) txtPolicyNum).Location = pointF7;
    ((ARControl) this.txtPolicyNum).Name = "txtPolicyNum";
    ((ARControl) this.txtPolicyNum).Size = new SizeF(0.875f, 3f / 16f);
    this.txtPolicyNum.Text = "Policy #";
    ((ARControl) this.txtInvNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvNum).Border.TopStyle = (BorderLineStyle) 0;
    this.txtInvNum.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtInvNum.HyperLink = (string) null;
    Label txtInvNum = this.txtInvNum;
    object obj8 = componentResourceManager.GetObject("txtInvNum.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) txtInvNum).Location = pointF8;
    ((ARControl) this.txtInvNum).Name = "txtInvNum";
    ((ARControl) this.txtInvNum).Size = new SizeF(9f / 16f, 3f / 16f);
    this.txtInvNum.Text = "Invoice #";
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj9 = componentResourceManager.GetObject("Label.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label).Location = pointF9;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label.Text = "Inv Date";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj10 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label1).Location = pointF10;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(0.5f, 3f / 16f);
    this.Label1.Text = "Eff Date";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj11 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label2).Location = pointF11;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label2.Text = "LOB/Chg";
    this.Label3.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj12 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label3).Location = pointF12;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(7f / 16f, 3f / 16f);
    this.Label3.Text = "Tran";
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj13 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label4).Location = pointF13;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label4.Text = "Agency Gross";
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj14 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label5).Location = pointF14;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.75f, 3f / 16f);
    this.Label5.Text = "Agency Net";
    this.Label6.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj15 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label6).Location = pointF15;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(7f / 16f, 3f / 16f);
    this.Label6.Text = "Rate";
    this.Label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj16 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label8).Location = pointF16;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.75f, 3f / 16f);
    this.Label8.Text = "Pay Amount";
    this.Label7.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj17 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label7).Location = pointF17;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label7.Text = "P/B Comm";
    ((ARControl) this.txtInsured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).DataField = "InsuredName";
    this.txtInsured.DistinctField = (string) null;
    this.txtInsured.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtInsured = this.txtInsured;
    object obj18 = componentResourceManager.GetObject("txtInsured.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) txtInsured).Location = pointF18;
    ((ARControl) this.txtInsured).Name = "txtInsured";
    this.txtInsured.OutputFormat = (string) null;
    ((ARControl) this.txtInsured).Size = new SizeF(1.375f, 0.125f);
    this.txtInsured.Text = "txtInsured";
    ((ARControl) this.txtPolNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolNum).DataField = "PolicyNumber";
    this.txtPolNum.DistinctField = (string) null;
    this.txtPolNum.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPolNum = this.txtPolNum;
    object obj19 = componentResourceManager.GetObject("txtPolNum.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) txtPolNum).Location = pointF19;
    ((ARControl) this.txtPolNum).Name = "txtPolNum";
    this.txtPolNum.OutputFormat = (string) null;
    ((ARControl) this.txtPolNum).Size = new SizeF(15f / 16f, 0.125f);
    this.txtPolNum.Text = "txtPolNum";
    ((ARControl) this.txtInvoiceNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).DataField = "OfficeInvoiceNum";
    this.txtInvoiceNum.DistinctField = (string) null;
    this.txtInvoiceNum.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtInvoiceNum = this.txtInvoiceNum;
    object obj20 = componentResourceManager.GetObject("txtInvoiceNum.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) txtInvoiceNum).Location = pointF20;
    ((ARControl) this.txtInvoiceNum).Name = "txtInvoiceNum";
    this.txtInvoiceNum.OutputFormat = (string) null;
    ((ARControl) this.txtInvoiceNum).Size = new SizeF(9f / 16f, 0.125f);
    this.txtInvoiceNum.Text = "txtInvoiceNum";
    ((ARControl) this.txtInvoiceDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceDate).DataField = "Invoicedate";
    this.txtInvoiceDate.DistinctField = (string) null;
    this.txtInvoiceDate.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtInvoiceDate = this.txtInvoiceDate;
    object obj21 = componentResourceManager.GetObject("txtInvoiceDate.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) txtInvoiceDate).Location = pointF21;
    ((ARControl) this.txtInvoiceDate).Name = "txtInvoiceDate";
    this.txtInvoiceDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtInvoiceDate).Size = new SizeF(0.625f, 0.125f);
    this.txtInvoiceDate.Text = "txtInvoiceDate";
    ((ARControl) this.txtEffective).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtEffective).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtEffective).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtEffective).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtEffective).DataField = "Effectivedate";
    this.txtEffective.DistinctField = (string) null;
    this.txtEffective.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtEffective = this.txtEffective;
    object obj22 = componentResourceManager.GetObject("txtEffective.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) txtEffective).Location = pointF22;
    ((ARControl) this.txtEffective).Name = "txtEffective";
    this.txtEffective.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtEffective).Size = new SizeF(0.625f, 0.125f);
    this.txtEffective.Text = "txtEffective";
    ((ARControl) this.SubReport).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport).Border.TopStyle = (BorderLineStyle) 0;
    this.SubReport.CloseBorder = false;
    SubReport subReport = this.SubReport;
    object obj23 = componentResourceManager.GetObject("SubReport.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) subReport).Location = pointF23;
    ((ARControl) this.SubReport).Name = "SubReport";
    this.SubReport.Report = (SectionReport) null;
    ((ARControl) this.SubReport).Size = new SizeF(97f / 16f, 0.125f);
    this.Label10.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj24 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label10).Location = pointF24;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(95f / 16f, 0.125f);
    this.Label10.Text = "Totals";
    this.txtAgencyGross.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAgencyGross).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyGross).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyGross).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyGross).Border.TopStyle = (BorderLineStyle) 0;
    this.txtAgencyGross.DistinctField = (string) null;
    this.txtAgencyGross.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtAgencyGross = this.txtAgencyGross;
    object obj25 = componentResourceManager.GetObject("txtAgencyGross.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) txtAgencyGross).Location = pointF25;
    ((ARControl) this.txtAgencyGross).Name = "txtAgencyGross";
    this.txtAgencyGross.OutputFormat = "#,##0.00";
    ((ARControl) this.txtAgencyGross).Size = new SizeF(1f, 0.125f);
    this.txtAgencyGross.Text = "0.00";
    this.txtAgencyComm.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAgencyComm).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyComm).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyComm).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgencyComm).Border.TopStyle = (BorderLineStyle) 0;
    this.txtAgencyComm.DistinctField = (string) null;
    this.txtAgencyComm.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtAgencyComm = this.txtAgencyComm;
    object obj26 = componentResourceManager.GetObject("txtAgencyComm.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) txtAgencyComm).Location = pointF26;
    ((ARControl) this.txtAgencyComm).Name = "txtAgencyComm";
    this.txtAgencyComm.OutputFormat = "#,##0.00";
    ((ARControl) this.txtAgencyComm).Size = new SizeF(11f / 16f, 0.125f);
    this.txtAgencyComm.Text = (string) null;
    this.txtPBComm.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPBComm).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPBComm).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPBComm).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPBComm).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPBComm).DataField = "Balance";
    this.txtPBComm.DistinctField = (string) null;
    this.txtPBComm.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtPbComm = this.txtPBComm;
    object obj27 = componentResourceManager.GetObject("txtPBComm.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) txtPbComm).Location = pointF27;
    ((ARControl) this.txtPBComm).Name = "txtPBComm";
    this.txtPBComm.OutputFormat = "#,##0.00";
    ((ARControl) this.txtPBComm).Size = new SizeF(1.25f, 0.125f);
    this.txtPBComm.Text = "0.00";
    this.txtPayAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPayAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayAmount).DataField = "PayeeAMT";
    this.txtPayAmount.DistinctField = (string) null;
    this.txtPayAmount.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtPayAmount = this.txtPayAmount;
    object obj28 = componentResourceManager.GetObject("txtPayAmount.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) txtPayAmount).Location = pointF28;
    ((ARControl) this.txtPayAmount).Name = "txtPayAmount";
    this.txtPayAmount.OutputFormat = "#,##0.00";
    ((ARControl) this.txtPayAmount).Size = new SizeF(0.875f, 0.125f);
    this.txtPayAmount.Text = "0.00";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1);
    ((ISupportInitialize) this.txtPayeeName).EndInit();
    ((ISupportInitialize) this.txtCompanyName).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.textPrintDate).EndInit();
    ((ISupportInitialize) this.txtStatementDate).EndInit();
    ((ISupportInitialize) this.txtInsuredName).EndInit();
    ((ISupportInitialize) this.txtPolicyNum).EndInit();
    ((ISupportInitialize) this.txtInvNum).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtInsured).EndInit();
    ((ISupportInitialize) this.txtPolNum).EndInit();
    ((ISupportInitialize) this.txtInvoiceNum).EndInit();
    ((ISupportInitialize) this.txtInvoiceDate).EndInit();
    ((ISupportInitialize) this.txtEffective).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.txtAgencyGross).EndInit();
    ((ISupportInitialize) this.txtAgencyComm).EndInit();
    ((ISupportInitialize) this.txtPBComm).EndInit();
    ((ISupportInitialize) this.txtPayAmount).EndInit();
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
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1_1).Format -= eventHandler;
      this._Detail1 = value;
      Detail detail1_2 = this._Detail1;
      if (detail1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader1")]
  internal virtual ReportHeader ReportHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPayeeName")]
  private virtual TextBox txtPayeeName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line")]
  private virtual Line Line { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line1")]
  private virtual Line Line1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line2")]
  private virtual Line Line2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line3")]
  private virtual Line Line3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCompanyName")]
  private virtual TextBox txtCompanyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textPrintDate")]
  private virtual TextBox textPrintDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStatementDate")]
  private virtual TextBox txtStatementDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ReportFooter ReportFooter1
  {
    get => this._ReportFooter1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter1_Format);
      ReportFooter reportFooter1_1 = this._ReportFooter1;
      if (reportFooter1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1_1).Format -= eventHandler;
      this._ReportFooter1 = value;
      ReportFooter reportFooter1_2 = this._ReportFooter1;
      if (reportFooter1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtInsuredName")]
  private virtual Label txtInsuredName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyNum")]
  private virtual Label txtPolicyNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInvNum")]
  private virtual Label txtInvNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label")]
  private virtual Label Label { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInsured")]
  private virtual TextBox txtInsured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolNum")]
  private virtual TextBox txtPolNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInvoiceNum")]
  private virtual TextBox txtInvoiceNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInvoiceDate")]
  private virtual TextBox txtInvoiceDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEffective")]
  private virtual TextBox txtEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SubReport")]
  private virtual SubReport SubReport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAgencyGross")]
  private virtual TextBox txtAgencyGross { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAgencyComm")]
  private virtual TextBox txtAgencyComm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPBComm")]
  private virtual TextBox txtPBComm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPayAmount")]
  private virtual TextBox txtPayAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptOperatingCommissionsPaymentStatement()
  {
    this.ReportStart += new EventHandler(this.rptOperatingCommissionsPaymentStatement_ReportStart);
    this._dataset = new DataSet();
    this.InitializeComponent();
  }

  public rptOperatingCommissionsPaymentStatement(
    int OfficeID,
    Guid PayeeGuid,
    DateTime DateFrom,
    bool PaidInFullOnly)
  {
    this.ReportStart += new EventHandler(this.rptOperatingCommissionsPaymentStatement_ReportStart);
    this._dataset = new DataSet();
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._PayeeGuid = PayeeGuid;
    this._OfficeID = OfficeID;
    this._detailCounter = 0;
    this._AgencyGross = 0M;
    this._AgencyComm = 0M;
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spFin_rptExpenseCommissionsStatement", connection);
    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
    try
    {
      SqlCommand sqlCommand = selectCommand;
      sqlCommand.CommandType = CommandType.StoredProcedure;
      if (OfficeID != -1)
        sqlCommand.Parameters.AddWithValue("@glcompanyid", (object) OfficeID);
      sqlCommand.Parameters.AddWithValue("@entityGuid", (object) PayeeGuid);
      sqlCommand.Parameters.AddWithValue("@cutoff", (object) DateFrom);
      sqlCommand.Parameters.AddWithValue("@PaidInFullOnly", (object) PaidInFullOnly);
      Database.SafeDataAdapterFill(dataAdapter, this._dataset);
    }
    finally
    {
      if (connection != null)
      {
        if (connection.State != ConnectionState.Closed)
          connection.Close();
        connection.Dispose();
      }
      selectCommand?.Dispose();
      dataAdapter?.Dispose();
    }
    this.DataSource = (object) this._dataset.Tables[0];
    this.textPrintDate.Text = "Print Date: " + Strings.Format((object) this._dataset.Tables[2].Rows[0]["PrintDate"].ToString(), "Short Date");
    this.txtStatementDate.Text = "Statement Date: " + Strings.Format((object) this._dataset.Tables[2].Rows[0]["Statementdate"].ToString(), "Short Date");
    this._PayeeName = Conversions.ToString(this._dataset.Tables[2].Rows[0]["PayeeName"]);
    this._Location = Conversions.ToString(this._dataset.Tables[2].Rows[0]["Location"]);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new OfficeLocations("Office", false, true),
        (BaseReportControl) new EntitySelection("Payee", true),
        (BaseReportControl) new DatePicker("CutOff Date", DateAndTime.Now, true),
        (BaseReportControl) new GenericCheckBox("", "Show Paid In Full Only")
      };
    }
  }

  private void rptOperatingCommissionsPaymentStatement_ReportStart(object sender, EventArgs e)
  {
    this.txtPayeeName.Text = this._PayeeName;
    this.txtPayeeName.Text = this._PayeeName;
    this.txtCompanyName.Text = this._Location;
  }

  private void Detail1_Format(object sender, EventArgs e)
  {
    if (this._dataset.Tables[0].Rows.Count != 0)
      this.SubReport.Report = (SectionReport) new rptExpenseCommissionsStatement_Detail(new DataView(this._dataset.Tables[1], "InvoiceNum =" + this._dataset.Tables[0].Rows[this._detailCounter]["InvoiceNum"].ToString(), "", DataViewRowState.CurrentRows));
    checked { ++this._detailCounter; }
  }

  private void ReportFooter1_Format(object sender, EventArgs e)
  {
    this.txtAgencyGross.Value = RuntimeHelpers.GetObjectValue(this._dataset.Tables[1].Compute("SUM(AgencyGross)", ""));
    this.txtAgencyComm.Value = RuntimeHelpers.GetObjectValue(this._dataset.Tables[1].Compute("SUM(AgencyCommission)", ""));
    this.txtPBComm.Value = RuntimeHelpers.GetObjectValue(this._dataset.Tables[1].Compute("SUM(Balance)", ""));
    this.txtPayAmount.Value = RuntimeHelpers.GetObjectValue(this._dataset.Tables[1].Compute("SUM(PayeeAMT)", ""));
  }
}
