// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptBrokerStatement
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
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptBrokerStatement : MGAReport, IReport
{
  private Guid _ProducerLocationGuid;
  private Guid _CompanyGuid;
  private string _PolicyNumber;
  private string _ControlNo;
  private DateTime _BillingDateFrom;
  private DateTime _BillingDateTo;
  private DateTime _EffectiveDateFrom;
  private DateTime _EffectiveDateTo;
  private Decimal _Balance;
  private bool _UseBalance;
  private DataSet _ds;
  private TextBox txtHeader_Producer;
  private Label Label;
  private TextBox txtHeader_DateOfPrinting;
  private Label Label1;
  private TextBox txtHeader_ClientOfficeName;
  private TextBox txtHeader_ClientOfficeAddress;
  private Label Label2;
  private Label Label17;
  private Label Label18;
  private TextBox txtHeader_ProducerCode;
  private Line Line;
  private Label CurrentQuoteGuid;
  private TextBox txtHeader_AmountOfRemittance;
  private Label Label4;
  private Label Label22;
  private TextBox txtProducerName;
  private TextBox txtProducerCode;
  private Label CurrentProducerName;
  private Label CurrentProducerCode;
  private Label CurrentInsuredName;
  private Label CurrentInsuredGuid;
  private Label Label3;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label11;
  private TextBox TextBox2;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private TextBox TextBox;
  private TextBox TextBox11;
  private Label CurrentInvChkNum;
  private Label Label19;
  private Label CurrentProducerLocationGuid;
  private SubReport srDetails;
  private Label lblNoDetails;
  private TextBox txtInvoiceTotalNetPremium;
  private TextBox txtInsuredTotal;
  private TextBox txtFooter_ClientOfficeName;
  private TextBox txtFooter_ClientOfficeAddress;
  private Label Label20;
  private Label Label21;
  private TextBox txtFooter_Phone;
  private TextBox txtFooter_Fax;
  private TextBox txtFooter_Producer;

  public rptBrokerStatement(
    Guid ProducerLocationGuid,
    Guid CompanyGuid,
    string PolicyNumber,
    string ControlNo,
    DateTime BillingDateFrom,
    DateTime BillingDateTo,
    DateTime EffectiveDateFrom,
    DateTime EffectiveDateTo,
    object Balance)
  {
    this.ReportStart += new EventHandler(this.rptBrokerStatement_ReportStart);
    this._UseBalance = false;
    this._ds = new DataSet();
    this.InitializeComponent();
    this._ProducerLocationGuid = ProducerLocationGuid;
    this._CompanyGuid = CompanyGuid;
    this._PolicyNumber = PolicyNumber;
    this._ControlNo = ControlNo;
    this._BillingDateFrom = BillingDateFrom;
    this._BillingDateTo = BillingDateTo;
    this._EffectiveDateFrom = EffectiveDateFrom;
    this._EffectiveDateTo = EffectiveDateTo;
    if (Balance == null)
      return;
    this._Balance = Conversions.ToDecimal(Balance);
    this._UseBalance = true;
  }

  public rptBrokerStatement()
  {
    this.ReportStart += new EventHandler(this.rptBrokerStatement_ReportStart);
    this._UseBalance = false;
    this._ds = new DataSet();
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptBrokerStatement));
    this.Detail = new Detail();
    this.ghMainProducerGroup = new GroupHeader();
    this.gfMainProducerGroup = new GroupFooter();
    this.ghProducer = new GroupHeader();
    this.gfProducer = new GroupFooter();
    this.ghInsured = new GroupHeader();
    this.gfInsured = new GroupFooter();
    this.ghInvoiceOrCheck = new GroupHeader();
    this.gfInvoiceOrCheck = new GroupFooter();
    this.ghInvoiceOrCheckDetail = new GroupHeader();
    this.gfInvoiceOrCheckDetail = new GroupFooter();
    this.ghInvoiceOrCheckBreakdown = new GroupHeader();
    this.gfInvoiceOrCheckBreakdown = new GroupFooter();
    this.txtHeader_Producer = new TextBox();
    this.Label = new Label();
    this.txtHeader_DateOfPrinting = new TextBox();
    this.Label1 = new Label();
    this.txtHeader_ClientOfficeName = new TextBox();
    this.txtHeader_ClientOfficeAddress = new TextBox();
    this.Label2 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.txtHeader_ProducerCode = new TextBox();
    this.Line = new Line();
    this.CurrentQuoteGuid = new Label();
    this.txtHeader_AmountOfRemittance = new TextBox();
    this.Label4 = new Label();
    this.Label22 = new Label();
    this.txtProducerName = new TextBox();
    this.txtProducerCode = new TextBox();
    this.CurrentProducerName = new Label();
    this.CurrentProducerCode = new Label();
    this.CurrentInsuredName = new Label();
    this.CurrentInsuredGuid = new Label();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.TextBox2 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.TextBox = new TextBox();
    this.TextBox11 = new TextBox();
    this.CurrentInvChkNum = new Label();
    this.Label19 = new Label();
    this.CurrentProducerLocationGuid = new Label();
    this.srDetails = new SubReport();
    this.lblNoDetails = new Label();
    this.txtInvoiceTotalNetPremium = new TextBox();
    this.txtInsuredTotal = new TextBox();
    this.txtFooter_ClientOfficeName = new TextBox();
    this.txtFooter_ClientOfficeAddress = new TextBox();
    this.Label20 = new Label();
    this.Label21 = new Label();
    this.txtFooter_Phone = new TextBox();
    this.txtFooter_Fax = new TextBox();
    this.txtFooter_Producer = new TextBox();
    ((ISupportInitialize) this.txtHeader_Producer).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.txtHeader_DateOfPrinting).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtHeader_ClientOfficeName).BeginInit();
    ((ISupportInitialize) this.txtHeader_ClientOfficeAddress).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.txtHeader_ProducerCode).BeginInit();
    ((ISupportInitialize) this.CurrentQuoteGuid).BeginInit();
    ((ISupportInitialize) this.txtHeader_AmountOfRemittance).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.txtProducerName).BeginInit();
    ((ISupportInitialize) this.txtProducerCode).BeginInit();
    ((ISupportInitialize) this.CurrentProducerName).BeginInit();
    ((ISupportInitialize) this.CurrentProducerCode).BeginInit();
    ((ISupportInitialize) this.CurrentInsuredName).BeginInit();
    ((ISupportInitialize) this.CurrentInsuredGuid).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.CurrentInvChkNum).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.CurrentProducerLocationGuid).BeginInit();
    ((ISupportInitialize) this.lblNoDetails).BeginInit();
    ((ISupportInitialize) this.txtInvoiceTotalNetPremium).BeginInit();
    ((ISupportInitialize) this.txtInsuredTotal).BeginInit();
    ((ISupportInitialize) this.txtFooter_ClientOfficeName).BeginInit();
    ((ISupportInitialize) this.txtFooter_ClientOfficeAddress).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.Label21).BeginInit();
    ((ISupportInitialize) this.txtFooter_Phone).BeginInit();
    ((ISupportInitialize) this.txtFooter_Fax).BeginInit();
    ((ISupportInitialize) this.txtFooter_Producer).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).BackColor = Color.FromArgb(245, 245, 245);
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.srDetails,
      (ARControl) this.lblNoDetails
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMainProducerGroup).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.txtHeader_Producer,
      (ARControl) this.Label,
      (ARControl) this.txtHeader_DateOfPrinting,
      (ARControl) this.Label1,
      (ARControl) this.txtHeader_ClientOfficeName,
      (ARControl) this.txtHeader_ClientOfficeAddress,
      (ARControl) this.Label2,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.txtHeader_ProducerCode,
      (ARControl) this.Line,
      (ARControl) this.CurrentQuoteGuid,
      (ARControl) this.txtHeader_AmountOfRemittance,
      (ARControl) this.Label4,
      (ARControl) this.Label22
    });
    this.ghMainProducerGroup.DataField = "ProducerLocationGuid";
    this.ghMainProducerGroup.Height = 3f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMainProducerGroup).Name = "ghMainProducerGroup";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMainProducerGroup).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.txtFooter_ClientOfficeName,
      (ARControl) this.txtFooter_ClientOfficeAddress,
      (ARControl) this.Label20,
      (ARControl) this.Label21,
      (ARControl) this.txtFooter_Phone,
      (ARControl) this.txtFooter_Fax,
      (ARControl) this.txtFooter_Producer
    });
    this.gfMainProducerGroup.Height = 2.260417f;
    this.gfMainProducerGroup.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMainProducerGroup).Name = "gfMainProducerGroup";
    this.gfMainProducerGroup.PrintAtBottom = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghProducer).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.txtProducerName,
      (ARControl) this.txtProducerCode,
      (ARControl) this.CurrentProducerName,
      (ARControl) this.CurrentProducerCode
    });
    this.ghProducer.Height = 0.3222222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghProducer).Name = "ghProducer";
    this.gfProducer.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfProducer).Name = "gfProducer";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInsured).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.CurrentInsuredName,
      (ARControl) this.CurrentInsuredGuid
    });
    this.ghInsured.DataField = "InsuredGuid";
    this.ghInsured.Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInsured).Name = "ghInsured";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInsured).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtInvoiceTotalNetPremium,
      (ARControl) this.txtInsuredTotal
    });
    this.gfInsured.Height = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInsured).Name = "gfInsured";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheck).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.Label3,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11
    });
    this.ghInvoiceOrCheck.DataField = "InvChkNum";
    this.ghInvoiceOrCheck.Height = 0.1145833f;
    this.ghInvoiceOrCheck.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheck).Name = "ghInvoiceOrCheck";
    this.gfInvoiceOrCheck.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInvoiceOrCheck).Name = "gfInvoiceOrCheck";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheckDetail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10
    });
    this.ghInvoiceOrCheckDetail.Height = 0.1145833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheckDetail).Name = "ghInvoiceOrCheckDetail";
    this.gfInvoiceOrCheckDetail.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInvoiceOrCheckDetail).Name = "gfInvoiceOrCheckDetail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheckBreakdown).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox11,
      (ARControl) this.CurrentInvChkNum,
      (ARControl) this.Label19,
      (ARControl) this.CurrentProducerLocationGuid
    });
    this.ghInvoiceOrCheckBreakdown.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheckBreakdown).Name = "ghInvoiceOrCheckBreakdown";
    this.gfInvoiceOrCheckBreakdown.Height = 0.0f;
    this.gfInvoiceOrCheckBreakdown.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInvoiceOrCheckBreakdown).Name = "gfInvoiceOrCheckBreakdown";
    ((ARControl) this.txtHeader_Producer).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Producer).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Producer).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Producer).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_Producer.DistinctField = (string) null;
    this.txtHeader_Producer.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_Producer.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderProducer = this.txtHeader_Producer;
    object obj1 = componentResourceManager.GetObject("txtHeader_Producer.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtHeaderProducer).Location = pointF1;
    ((ARControl) this.txtHeader_Producer).Name = "txtHeader_Producer";
    this.txtHeader_Producer.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_Producer).Size = new SizeF(47f / 16f, 11f / 16f);
    this.Label.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj2 = componentResourceManager.GetObject("Label.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label).Location = pointF2;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(1f, 3f / 16f);
    this.Label.Text = "Date of Printing";
    ((ARControl) this.txtHeader_DateOfPrinting).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_DateOfPrinting).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_DateOfPrinting).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_DateOfPrinting).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_DateOfPrinting.DistinctField = (string) null;
    this.txtHeader_DateOfPrinting.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_DateOfPrinting.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerDateOfPrinting = this.txtHeader_DateOfPrinting;
    object obj3 = componentResourceManager.GetObject("txtHeader_DateOfPrinting.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) headerDateOfPrinting).Location = pointF3;
    ((ARControl) this.txtHeader_DateOfPrinting).Name = "txtHeader_DateOfPrinting";
    this.txtHeader_DateOfPrinting.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtHeader_DateOfPrinting).Size = new SizeF(19f / 16f, 3f / 16f);
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 15.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj4 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label1).Location = pointF4;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(2.375f, 0.25f);
    this.Label1.Text = "BROKER STATEMENT";
    ((ARControl) this.txtHeader_ClientOfficeName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ClientOfficeName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ClientOfficeName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ClientOfficeName).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_ClientOfficeName.DistinctField = (string) null;
    this.txtHeader_ClientOfficeName.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_ClientOfficeName.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox clientOfficeName1 = this.txtHeader_ClientOfficeName;
    object obj5 = componentResourceManager.GetObject("txtHeader_ClientOfficeName.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) clientOfficeName1).Location = pointF5;
    ((ARControl) this.txtHeader_ClientOfficeName).Name = "txtHeader_ClientOfficeName";
    this.txtHeader_ClientOfficeName.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_ClientOfficeName).Size = new SizeF(7.375f, 0.25f);
    ((ARControl) this.txtHeader_ClientOfficeAddress).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ClientOfficeAddress).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ClientOfficeAddress).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ClientOfficeAddress).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_ClientOfficeAddress.DistinctField = (string) null;
    this.txtHeader_ClientOfficeAddress.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_ClientOfficeAddress.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox clientOfficeAddress1 = this.txtHeader_ClientOfficeAddress;
    object obj6 = componentResourceManager.GetObject("txtHeader_ClientOfficeAddress.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) clientOfficeAddress1).Location = pointF6;
    ((ARControl) this.txtHeader_ClientOfficeAddress).Name = "txtHeader_ClientOfficeAddress";
    this.txtHeader_ClientOfficeAddress.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_ClientOfficeAddress).Size = new SizeF(7.375f, 11f / 16f);
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj7 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label2).Location = pointF7;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(39f / 16f, 3f / 16f);
    this.Label2.Text = "Please return this portion with payment";
    this.Label17.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    this.Label17.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
    this.Label17.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label17.HyperLink = (string) null;
    Label label17 = this.Label17;
    object obj8 = componentResourceManager.GetObject("Label17.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label17).Location = pointF8;
    ((ARControl) this.Label17).Name = "Label17";
    ((ARControl) this.Label17).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label17.Text = "Amount of remittance";
    this.Label18.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 0;
    this.Label18.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.Label18.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label18.HyperLink = (string) null;
    Label label18 = this.Label18;
    object obj9 = componentResourceManager.GetObject("Label18.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label18).Location = pointF9;
    ((ARControl) this.Label18).Name = "Label18";
    ((ARControl) this.Label18).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label18.Text = "Producer Code:";
    ((ARControl) this.txtHeader_ProducerCode).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerCode).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerCode).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerCode).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_ProducerCode.DistinctField = (string) null;
    this.txtHeader_ProducerCode.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_ProducerCode.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerProducerCode = this.txtHeader_ProducerCode;
    object obj10 = componentResourceManager.GetObject("txtHeader_ProducerCode.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) headerProducerCode).Location = pointF10;
    ((ARControl) this.txtHeader_ProducerCode).Name = "txtHeader_ProducerCode";
    this.txtHeader_ProducerCode.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_ProducerCode).Size = new SizeF(19f / 16f, 3f / 16f);
    this.txtHeader_ProducerCode.Text = " ";
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    this.Line.LineWeight = 3f;
    ((ARControl) this.Line).Name = "Line";
    this.Line.X1 = 0.0f;
    this.Line.X2 = 7.875f;
    this.Line.Y1 = 3f;
    this.Line.Y2 = 3f;
    this.CurrentQuoteGuid.BackColor = Color.Yellow;
    ((ARControl) this.CurrentQuoteGuid).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentQuoteGuid).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentQuoteGuid).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentQuoteGuid).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentQuoteGuid).DataField = "QuoteGuid";
    this.CurrentQuoteGuid.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrentQuoteGuid.ForeColor = Color.FromArgb(0, 0, 0);
    this.CurrentQuoteGuid.HyperLink = (string) null;
    Label currentQuoteGuid = this.CurrentQuoteGuid;
    object obj11 = componentResourceManager.GetObject("CurrentQuoteGuid.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) currentQuoteGuid).Location = pointF11;
    ((ARControl) this.CurrentQuoteGuid).Name = "CurrentQuoteGuid";
    ((ARControl) this.CurrentQuoteGuid).Size = new SizeF(5f / 16f, 1f / 16f);
    this.CurrentQuoteGuid.Text = "";
    ((ARControl) this.CurrentQuoteGuid).Visible = false;
    ((ARControl) this.txtHeader_AmountOfRemittance).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHeader_AmountOfRemittance).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_AmountOfRemittance).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_AmountOfRemittance).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_AmountOfRemittance.DistinctField = (string) null;
    this.txtHeader_AmountOfRemittance.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_AmountOfRemittance.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox amountOfRemittance = this.txtHeader_AmountOfRemittance;
    object obj12 = componentResourceManager.GetObject("txtHeader_AmountOfRemittance.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) amountOfRemittance).Location = pointF12;
    ((ARControl) this.txtHeader_AmountOfRemittance).Name = "txtHeader_AmountOfRemittance";
    this.txtHeader_AmountOfRemittance.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtHeader_AmountOfRemittance).Size = new SizeF(19f / 16f, 3f / 16f);
    this.txtHeader_AmountOfRemittance.Text = " ";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj13 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label4).Location = pointF13;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label4.Text = "Address:";
    ((ARControl) this.Label22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.TopStyle = (BorderLineStyle) 0;
    this.Label22.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.Label22.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label22.HyperLink = (string) null;
    Label label22 = this.Label22;
    object obj14 = componentResourceManager.GetObject("Label22.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label22).Location = pointF14;
    ((ARControl) this.Label22).Name = "Label22";
    ((ARControl) this.Label22).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label22.Text = "Remit To:";
    this.txtProducerName.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtProducerName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducerName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducerName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducerName).Border.TopStyle = (BorderLineStyle) 0;
    this.txtProducerName.DistinctField = (string) null;
    this.txtProducerName.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.txtProducerName.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtProducerName = this.txtProducerName;
    object obj15 = componentResourceManager.GetObject("txtProducerName.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) txtProducerName).Location = pointF15;
    ((ARControl) this.txtProducerName).Name = "txtProducerName";
    this.txtProducerName.OutputFormat = (string) null;
    ((ARControl) this.txtProducerName).Size = new SizeF(7.875f, 3f / 16f);
    this.txtProducerCode.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtProducerCode).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducerCode).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducerCode).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducerCode).Border.TopStyle = (BorderLineStyle) 0;
    this.txtProducerCode.DistinctField = (string) null;
    this.txtProducerCode.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.txtProducerCode.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtProducerCode = this.txtProducerCode;
    object obj16 = componentResourceManager.GetObject("txtProducerCode.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) txtProducerCode).Location = pointF16;
    ((ARControl) this.txtProducerCode).Name = "txtProducerCode";
    this.txtProducerCode.OutputFormat = (string) null;
    ((ARControl) this.txtProducerCode).Size = new SizeF(7.875f, 3f / 16f);
    this.CurrentProducerName.BackColor = Color.Yellow;
    ((ARControl) this.CurrentProducerName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerName).DataField = "ProducerName";
    this.CurrentProducerName.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrentProducerName.ForeColor = Color.FromArgb(0, 0, 0);
    this.CurrentProducerName.HyperLink = (string) null;
    Label currentProducerName = this.CurrentProducerName;
    object obj17 = componentResourceManager.GetObject("CurrentProducerName.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) currentProducerName).Location = pointF17;
    ((ARControl) this.CurrentProducerName).Name = "CurrentProducerName";
    ((ARControl) this.CurrentProducerName).Size = new SizeF(0.25f, 1f / 16f);
    this.CurrentProducerName.Text = " ";
    ((ARControl) this.CurrentProducerName).Visible = false;
    this.CurrentProducerCode.BackColor = Color.Yellow;
    ((ARControl) this.CurrentProducerCode).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerCode).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerCode).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerCode).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerCode).DataField = "ProducerCode";
    this.CurrentProducerCode.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrentProducerCode.ForeColor = Color.FromArgb(0, 0, 0);
    this.CurrentProducerCode.HyperLink = (string) null;
    Label currentProducerCode = this.CurrentProducerCode;
    object obj18 = componentResourceManager.GetObject("CurrentProducerCode.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) currentProducerCode).Location = pointF18;
    ((ARControl) this.CurrentProducerCode).Name = "CurrentProducerCode";
    ((ARControl) this.CurrentProducerCode).Size = new SizeF(0.25f, 1f / 16f);
    this.CurrentProducerCode.Text = " ";
    ((ARControl) this.CurrentProducerCode).Visible = false;
    this.CurrentInsuredName.BackColor = Color.Yellow;
    ((ARControl) this.CurrentInsuredName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInsuredName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInsuredName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInsuredName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInsuredName).DataField = "InsuredPolicyName";
    this.CurrentInsuredName.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrentInsuredName.ForeColor = Color.FromArgb(0, 0, 0);
    this.CurrentInsuredName.HyperLink = (string) null;
    Label currentInsuredName = this.CurrentInsuredName;
    object obj19 = componentResourceManager.GetObject("CurrentInsuredName.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) currentInsuredName).Location = pointF19;
    ((ARControl) this.CurrentInsuredName).Name = "CurrentInsuredName";
    ((ARControl) this.CurrentInsuredName).Size = new SizeF(0.25f, 1f / 16f);
    this.CurrentInsuredName.Text = " ";
    ((ARControl) this.CurrentInsuredName).Visible = false;
    this.CurrentInsuredGuid.BackColor = Color.Yellow;
    ((ARControl) this.CurrentInsuredGuid).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInsuredGuid).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInsuredGuid).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInsuredGuid).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInsuredGuid).DataField = "InsuredGuid";
    this.CurrentInsuredGuid.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrentInsuredGuid.ForeColor = Color.FromArgb(0, 0, 0);
    this.CurrentInsuredGuid.HyperLink = (string) null;
    Label currentInsuredGuid = this.CurrentInsuredGuid;
    object obj20 = componentResourceManager.GetObject("CurrentInsuredGuid.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) currentInsuredGuid).Location = pointF20;
    ((ARControl) this.CurrentInsuredGuid).Name = "CurrentInsuredGuid";
    ((ARControl) this.CurrentInsuredGuid).Size = new SizeF(0.25f, 1f / 16f);
    this.CurrentInsuredGuid.Text = " ";
    ((ARControl) this.CurrentInsuredGuid).Visible = false;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 7f);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj21 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) label3).Location = pointF21;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(17f / 16f, 0.125f);
    this.Label3.Text = "INV/CHK#";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 7f);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj22 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) label5).Location = pointF22;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(33f / 16f, 0.125f);
    this.Label5.Text = "NAME";
    this.Label6.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 7f);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj23 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label6).Location = pointF23;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(11f / 16f, 0.125f);
    this.Label6.Text = "COV. DATE";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 7f);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj24 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label7).Location = pointF24;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(1.25f, 0.125f);
    this.Label7.Text = "POL#";
    this.Label8.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 7f);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj25 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label8).Location = pointF25;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(9f / 16f, 0.125f);
    this.Label8.Text = "COMPANY";
    this.Label9.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 7f);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj26 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) label9).Location = pointF26;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.75f, 0.125f);
    this.Label9.Text = "AMOUNT PAID";
    this.Label10.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 7f);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj27 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) label10).Location = pointF27;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(0.75f, 0.125f);
    this.Label10.Text = "BALANCE";
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 7f);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj28 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) label11).Location = pointF28;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(0.75f, 0.125f);
    this.Label11.Text = "STATUS";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "OfficeInvoiceNum";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 7f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj29 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) textBox2).Location = pointF29;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(17f / 16f, 0.125f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "InsuredPolicyName";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 7f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj30 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) textBox4).Location = pointF30;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(33f / 16f, 0.125f);
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "PostDate";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 7f);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj31 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) textBox5).Location = pointF31;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox5).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "PolicyNumber";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 7f);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj32 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) textBox6).Location = pointF32;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(1.25f, 0.125f);
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "Status";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 7f);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj33 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) textBox7).Location = pointF33;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(0.75f, 0.125f);
    this.TextBox7.Text = " ";
    this.TextBox8.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "ClientID";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 7f);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj34 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) textBox8).Location = pointF34;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = (string) null;
    ((ARControl) this.TextBox8).Size = new SizeF(9f / 16f, 0.125f);
    this.TextBox8.Text = " ";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "AmountPaid";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 7f);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj35 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) textBox9).Location = pointF35;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(0.75f, 0.125f);
    this.TextBox9.Text = " ";
    this.TextBox10.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "Balance";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 7f);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj36 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) textBox10).Location = pointF36;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox10).Size = new SizeF(0.75f, 0.125f);
    this.TextBox10.Text = " ";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj37 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) label12).Location = pointF37;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(0.5f, 0.125f);
    this.Label12.Text = "CLIENT #:";
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj38 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) label13).Location = pointF38;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(11f / 16f, 0.125f);
    this.Label13.Text = "POST DATE:";
    this.Label14.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj39 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) label14).Location = pointF39;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(1.125f, 0.125f);
    this.Label14.Text = "Gross Prem";
    this.Label15.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj40 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) label15).Location = pointF40;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(0.75f, 0.125f);
    this.Label15.Text = "Comm %";
    this.Label16.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj41 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) label16).Location = pointF41;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(19f / 16f, 0.125f);
    this.Label16.Text = "Net Prem";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "ClientID";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 7f);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj42 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) textBox).Location = pointF42;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(11f / 16f, 0.125f);
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "PostDate";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 7f);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj43 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) textBox11).Location = pointF43;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = (string) null;
    ((ARControl) this.TextBox11).Size = new SizeF(0.625f, 0.125f);
    this.CurrentInvChkNum.BackColor = Color.Yellow;
    ((ARControl) this.CurrentInvChkNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInvChkNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInvChkNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInvChkNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentInvChkNum).DataField = "InvChkNum";
    this.CurrentInvChkNum.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrentInvChkNum.ForeColor = Color.FromArgb(0, 0, 0);
    this.CurrentInvChkNum.HyperLink = (string) null;
    Label currentInvChkNum = this.CurrentInvChkNum;
    object obj44 = componentResourceManager.GetObject("CurrentInvChkNum.Location");
    PointF pointF44 = obj44 != null ? (PointF) obj44 : new PointF();
    ((ARControl) currentInvChkNum).Location = pointF44;
    ((ARControl) this.CurrentInvChkNum).Name = "CurrentInvChkNum";
    ((ARControl) this.CurrentInvChkNum).Size = new SizeF(0.25f, 1f / 16f);
    this.CurrentInvChkNum.Text = " ";
    ((ARControl) this.CurrentInvChkNum).Visible = false;
    this.Label19.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 0;
    this.Label19.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Bold);
    this.Label19.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label19.HyperLink = (string) null;
    Label label19 = this.Label19;
    object obj45 = componentResourceManager.GetObject("Label19.Location");
    PointF pointF45 = obj45 != null ? (PointF) obj45 : new PointF();
    ((ARControl) label19).Location = pointF45;
    ((ARControl) this.Label19).Name = "Label19";
    ((ARControl) this.Label19).Size = new SizeF(17f / 16f, 0.125f);
    this.Label19.Text = "Comm";
    this.CurrentProducerLocationGuid.BackColor = Color.Yellow;
    ((ARControl) this.CurrentProducerLocationGuid).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerLocationGuid).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerLocationGuid).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerLocationGuid).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CurrentProducerLocationGuid).DataField = "ProducerLocationGuid";
    this.CurrentProducerLocationGuid.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrentProducerLocationGuid.ForeColor = Color.FromArgb(0, 0, 0);
    this.CurrentProducerLocationGuid.HyperLink = (string) null;
    Label producerLocationGuid = this.CurrentProducerLocationGuid;
    object obj46 = componentResourceManager.GetObject("CurrentProducerLocationGuid.Location");
    PointF pointF46 = obj46 != null ? (PointF) obj46 : new PointF();
    ((ARControl) producerLocationGuid).Location = pointF46;
    ((ARControl) this.CurrentProducerLocationGuid).Name = "CurrentProducerLocationGuid";
    ((ARControl) this.CurrentProducerLocationGuid).Size = new SizeF(0.25f, 1f / 16f);
    this.CurrentProducerLocationGuid.Text = " ";
    ((ARControl) this.CurrentProducerLocationGuid).Visible = false;
    ((ARControl) this.srDetails).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srDetails).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srDetails).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srDetails).Border.TopStyle = (BorderLineStyle) 0;
    this.srDetails.CloseBorder = false;
    SubReport srDetails = this.srDetails;
    object obj47 = componentResourceManager.GetObject("srDetails.Location");
    PointF pointF47 = obj47 != null ? (PointF) obj47 : new PointF();
    ((ARControl) srDetails).Location = pointF47;
    ((ARControl) this.srDetails).Name = "srDetails";
    this.srDetails.Report = (SectionReport) null;
    ((ARControl) this.srDetails).Size = new SizeF(7.875f, 1f / 16f);
    this.lblNoDetails.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblNoDetails).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNoDetails).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNoDetails).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNoDetails).Border.TopStyle = (BorderLineStyle) 0;
    this.lblNoDetails.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblNoDetails.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblNoDetails.HyperLink = (string) null;
    Label lblNoDetails = this.lblNoDetails;
    object obj48 = componentResourceManager.GetObject("lblNoDetails.Location");
    PointF pointF48 = obj48 != null ? (PointF) obj48 : new PointF();
    ((ARControl) lblNoDetails).Location = pointF48;
    ((ARControl) this.lblNoDetails).Name = "lblNoDetails";
    ((ARControl) this.lblNoDetails).Size = new SizeF(7.875f, 0.125f);
    this.lblNoDetails.Text = "No Details";
    ((ARControl) this.lblNoDetails).Visible = false;
    this.txtInvoiceTotalNetPremium.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtInvoiceTotalNetPremium).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtInvoiceTotalNetPremium).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceTotalNetPremium).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceTotalNetPremium).Border.TopStyle = (BorderLineStyle) 0;
    this.txtInvoiceTotalNetPremium.DistinctField = (string) null;
    this.txtInvoiceTotalNetPremium.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.txtInvoiceTotalNetPremium.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox invoiceTotalNetPremium = this.txtInvoiceTotalNetPremium;
    object obj49 = componentResourceManager.GetObject("txtInvoiceTotalNetPremium.Location");
    PointF pointF49 = obj49 != null ? (PointF) obj49 : new PointF();
    ((ARControl) invoiceTotalNetPremium).Location = pointF49;
    ((ARControl) this.txtInvoiceTotalNetPremium).Name = "txtInvoiceTotalNetPremium";
    this.txtInvoiceTotalNetPremium.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtInvoiceTotalNetPremium).Size = new SizeF(1.375f, 5f / 16f);
    this.txtInsuredTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtInsuredTotal).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtInsuredTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtInsuredTotal.DistinctField = (string) null;
    this.txtInsuredTotal.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.txtInsuredTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtInsuredTotal = this.txtInsuredTotal;
    object obj50 = componentResourceManager.GetObject("txtInsuredTotal.Location");
    PointF pointF50 = obj50 != null ? (PointF) obj50 : new PointF();
    ((ARControl) txtInsuredTotal).Location = pointF50;
    ((ARControl) this.txtInsuredTotal).Name = "txtInsuredTotal";
    this.txtInsuredTotal.OutputFormat = (string) null;
    ((ARControl) this.txtInsuredTotal).Size = new SizeF(6.5f, 5f / 16f);
    ((ARControl) this.txtFooter_ClientOfficeName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_ClientOfficeName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_ClientOfficeName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_ClientOfficeName).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_ClientOfficeName.DistinctField = (string) null;
    this.txtFooter_ClientOfficeName.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_ClientOfficeName.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox clientOfficeName2 = this.txtFooter_ClientOfficeName;
    object obj51 = componentResourceManager.GetObject("txtFooter_ClientOfficeName.Location");
    PointF pointF51 = obj51 != null ? (PointF) obj51 : new PointF();
    ((ARControl) clientOfficeName2).Location = pointF51;
    ((ARControl) this.txtFooter_ClientOfficeName).Name = "txtFooter_ClientOfficeName";
    this.txtFooter_ClientOfficeName.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_ClientOfficeName).Size = new SizeF(7f, 0.25f);
    this.txtFooter_ClientOfficeName.Text = " ";
    ((ARControl) this.txtFooter_ClientOfficeAddress).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_ClientOfficeAddress).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_ClientOfficeAddress).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_ClientOfficeAddress).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_ClientOfficeAddress.DistinctField = (string) null;
    this.txtFooter_ClientOfficeAddress.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_ClientOfficeAddress.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox clientOfficeAddress2 = this.txtFooter_ClientOfficeAddress;
    object obj52 = componentResourceManager.GetObject("txtFooter_ClientOfficeAddress.Location");
    PointF pointF52 = obj52 != null ? (PointF) obj52 : new PointF();
    ((ARControl) clientOfficeAddress2).Location = pointF52;
    ((ARControl) this.txtFooter_ClientOfficeAddress).Name = "txtFooter_ClientOfficeAddress";
    this.txtFooter_ClientOfficeAddress.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_ClientOfficeAddress).Size = new SizeF(7f, 0.75f);
    this.txtFooter_ClientOfficeAddress.Text = " ";
    ((ARControl) this.Label20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.TopStyle = (BorderLineStyle) 0;
    this.Label20.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label20.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label20.HyperLink = (string) null;
    Label label20 = this.Label20;
    object obj53 = componentResourceManager.GetObject("Label20.Location");
    PointF pointF53 = obj53 != null ? (PointF) obj53 : new PointF();
    ((ARControl) label20).Location = pointF53;
    ((ARControl) this.Label20).Name = "Label20";
    ((ARControl) this.Label20).Size = new SizeF(0.5f, 3f / 16f);
    this.Label20.Text = "Phone:";
    ((ARControl) this.Label21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.TopStyle = (BorderLineStyle) 0;
    this.Label21.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label21.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label21.HyperLink = (string) null;
    Label label21 = this.Label21;
    object obj54 = componentResourceManager.GetObject("Label21.Location");
    PointF pointF54 = obj54 != null ? (PointF) obj54 : new PointF();
    ((ARControl) label21).Location = pointF54;
    ((ARControl) this.Label21).Name = "Label21";
    ((ARControl) this.Label21).Size = new SizeF(0.5f, 3f / 16f);
    this.Label21.Text = "Fax:";
    ((ARControl) this.txtFooter_Phone).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Phone).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Phone).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Phone).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_Phone.DistinctField = (string) null;
    this.txtFooter_Phone.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_Phone.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtFooterPhone = this.txtFooter_Phone;
    object obj55 = componentResourceManager.GetObject("txtFooter_Phone.Location");
    PointF pointF55 = obj55 != null ? (PointF) obj55 : new PointF();
    ((ARControl) txtFooterPhone).Location = pointF55;
    ((ARControl) this.txtFooter_Phone).Name = "txtFooter_Phone";
    this.txtFooter_Phone.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_Phone).Size = new SizeF(17f / 16f, 3f / 16f);
    this.txtFooter_Phone.Text = " ";
    ((ARControl) this.txtFooter_Fax).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Fax).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Fax).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Fax).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_Fax.DistinctField = (string) null;
    this.txtFooter_Fax.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_Fax.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtFooterFax = this.txtFooter_Fax;
    object obj56 = componentResourceManager.GetObject("txtFooter_Fax.Location");
    PointF pointF56 = obj56 != null ? (PointF) obj56 : new PointF();
    ((ARControl) txtFooterFax).Location = pointF56;
    ((ARControl) this.txtFooter_Fax).Name = "txtFooter_Fax";
    this.txtFooter_Fax.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_Fax).Size = new SizeF(17f / 16f, 3f / 16f);
    this.txtFooter_Fax.Text = " ";
    ((ARControl) this.txtFooter_Producer).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Producer).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Producer).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Producer).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_Producer.DistinctField = (string) null;
    this.txtFooter_Producer.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_Producer.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtFooterProducer = this.txtFooter_Producer;
    object obj57 = componentResourceManager.GetObject("txtFooter_Producer.Location");
    PointF pointF57 = obj57 != null ? (PointF) obj57 : new PointF();
    ((ARControl) txtFooterProducer).Location = pointF57;
    ((ARControl) this.txtFooter_Producer).Name = "txtFooter_Producer";
    this.txtFooter_Producer.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_Producer).Size = new SizeF(5f, 13f / 16f);
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMainProducerGroup);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghProducer);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInsured);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheck);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheckDetail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheckBreakdown);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInvoiceOrCheckBreakdown);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInvoiceOrCheckDetail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInvoiceOrCheck);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInsured);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfProducer);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMainProducerGroup);
    ((ISupportInitialize) this.txtHeader_Producer).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.txtHeader_DateOfPrinting).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtHeader_ClientOfficeName).EndInit();
    ((ISupportInitialize) this.txtHeader_ClientOfficeAddress).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.txtHeader_ProducerCode).EndInit();
    ((ISupportInitialize) this.CurrentQuoteGuid).EndInit();
    ((ISupportInitialize) this.txtHeader_AmountOfRemittance).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.txtProducerName).EndInit();
    ((ISupportInitialize) this.txtProducerCode).EndInit();
    ((ISupportInitialize) this.CurrentProducerName).EndInit();
    ((ISupportInitialize) this.CurrentProducerCode).EndInit();
    ((ISupportInitialize) this.CurrentInsuredName).EndInit();
    ((ISupportInitialize) this.CurrentInsuredGuid).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.CurrentInvChkNum).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.CurrentProducerLocationGuid).EndInit();
    ((ISupportInitialize) this.lblNoDetails).EndInit();
    ((ISupportInitialize) this.txtInvoiceTotalNetPremium).EndInit();
    ((ISupportInitialize) this.txtInsuredTotal).EndInit();
    ((ISupportInitialize) this.txtFooter_ClientOfficeName).EndInit();
    ((ISupportInitialize) this.txtFooter_ClientOfficeAddress).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.Label21).EndInit();
    ((ISupportInitialize) this.txtFooter_Phone).EndInit();
    ((ISupportInitialize) this.txtFooter_Fax).EndInit();
    ((ISupportInitialize) this.txtFooter_Producer).EndInit();
  }

  private void rptBrokerStatement_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spfin_rptBrokerStatement", connection);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    selectCommand.CommandType = CommandType.StoredProcedure;
    if (!this._CompanyGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@CompanyGuid", (object) this._CompanyGuid);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._PolicyNumber, (string) null, false) != 0 && this._PolicyNumber.Trim().Length > 0)
      selectCommand.Parameters.AddWithValue("@PolicyNumber", (object) this._PolicyNumber);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._ControlNo, (string) null, false) != 0 && this._ControlNo.Trim().Length > 0)
      selectCommand.Parameters.AddWithValue("@ControlNo", (object) Conversions.ToInteger(this._ControlNo));
    if (DateTime.Compare(this._BillingDateFrom, DateTime.MinValue) != 0)
      selectCommand.Parameters.AddWithValue("@BillingDateFrom", (object) this._BillingDateFrom);
    if (DateTime.Compare(this._BillingDateTo, DateTime.MinValue) != 0)
      selectCommand.Parameters.AddWithValue("@BillingDateTo", (object) this._BillingDateTo);
    if (DateTime.Compare(this._EffectiveDateFrom, DateTime.MinValue) != 0)
      selectCommand.Parameters.AddWithValue("@EffectiveDateFrom", (object) this._EffectiveDateFrom);
    if (DateTime.Compare(this._EffectiveDateTo, DateTime.MinValue) != 0)
      selectCommand.Parameters.AddWithValue("@EffectiveDateTo", (object) this._EffectiveDateTo);
    if (this._UseBalance)
      selectCommand.Parameters.AddWithValue("@Balance", (object) this._Balance);
    selectCommand.Parameters.AddWithValue("@ProducerLocationGuid", (object) this._ProducerLocationGuid);
    try
    {
      sqlDataAdapter.Fill(this._ds);
    }
    finally
    {
      connection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
    this.DataSource = (object) this._ds.Tables[1];
    if (!this.HasRecords)
      return;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInvoiceOrCheckBreakdown).BeforePrint += new EventHandler(this.ghInvoiceOrCheckBreakdown_BeforePrint);
  }

  private void gfInsured_BeforePrint(object sender, EventArgs e)
  {
    this.txtInsuredTotal.Text = $"Total Amount for {RuntimeHelpers.GetObjectValue(this.CurrentInsuredName.Value)}";
    this.txtInvoiceTotalNetPremium.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(this._ds.Tables[2].Compute("SUM(NetPremium)", $"ProducerLocationGuid='{RuntimeHelpers.GetObjectValue(this.CurrentProducerLocationGuid.Value)}' AND InsuredGuid='{RuntimeHelpers.GetObjectValue(this.CurrentInsuredGuid.Value)}'")), 0M);
  }

  private void ghProducer_BeforePrint(object sender, EventArgs e)
  {
    this.txtProducerName.Text = $"Statement of Account for {RuntimeHelpers.GetObjectValue(this.CurrentProducerName.Value)}";
    this.txtProducerCode.Text = $"Producer Code: {RuntimeHelpers.GetObjectValue(this.CurrentProducerCode.Value)}";
  }

  private void ghMainProducerGroup_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Select($"QuoteGuid='{RuntimeHelpers.GetObjectValue(this.CurrentQuoteGuid.Value)}'").Length <= 0)
      return;
    DataRow dataRow = this._ds.Tables[0].Select($"QuoteGuid='{RuntimeHelpers.GetObjectValue(this.CurrentQuoteGuid.Value)}'")[0];
    this.txtHeader_Producer.Value = (object) $"{dataRow["ProducerName"].ToString()}\r\n{dataRow["ProducerAddress"].ToString()}";
    this.txtHeader_DateOfPrinting.Value = (object) dataRow["DateOfPrinting"].ToString();
    this.txtHeader_ClientOfficeName.Value = (object) dataRow["OfficeName"].ToString();
    this.txtHeader_ClientOfficeAddress.Value = (object) dataRow["OfficeAddress"].ToString();
    this.txtHeader_AmountOfRemittance.Value = (object) dataRow["AmountOfRemittance"].ToString();
    this.txtHeader_ProducerCode.Value = (object) dataRow["ProducerCode"].ToString();
    this.txtFooter_Producer.Value = (object) $"{dataRow["ProducerName"].ToString()}\r\n{dataRow["ProducerAddress"].ToString()}";
    this.txtFooter_ClientOfficeName.Value = (object) dataRow["OfficeName"].ToString();
    this.txtFooter_ClientOfficeAddress.Value = (object) dataRow["OfficeAddress"].ToString();
    this.txtFooter_Phone.Value = (object) dataRow["OfficePhone"].ToString();
    this.txtFooter_Fax.Value = (object) dataRow["OfficeFax"].ToString();
  }

  private void ghInvoiceOrCheckBreakdown_BeforePrint(object sender, EventArgs e)
  {
    DataView dv = new DataView(this._ds.Tables[2], $"InvoiceNum={RuntimeHelpers.GetObjectValue(this.CurrentInvChkNum.Value)}", "", DataViewRowState.CurrentRows);
    if (dv.Count == 0)
    {
      ((ARControl) this.lblNoDetails).Visible = true;
      ((ARControl) this.srDetails).Visible = false;
    }
    else
    {
      ((ARControl) this.lblNoDetails).Visible = false;
      ((ARControl) this.srDetails).Visible = true;
      this.srDetails.Report = (SectionReport) new rptBrokerStatement_Details(dv);
    }
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[7]
      {
        (BaseReportControl) new ProducerLocations("Producer", false),
        (BaseReportControl) new Companies("Company", true, new Guid[0]),
        (BaseReportControl) new TextInput("Policy", false, false),
        (BaseReportControl) new TextInput("Control #", false, true),
        (BaseReportControl) new DateRangePicker("Billing Date", true),
        (BaseReportControl) new DateRangePicker("Effective Date", true),
        (BaseReportControl) new TextInput("Balance Over", TextInput.ReturnType.Dec, false)
      };
    }
  }

  public override bool IsThreaded => true;

  private virtual GroupHeader ghMainProducerGroup
  {
    get => this._ghMainProducerGroup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ghMainProducerGroup_Format);
      GroupHeader mainProducerGroup1 = this._ghMainProducerGroup;
      if (mainProducerGroup1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) mainProducerGroup1).Format -= eventHandler;
      this._ghMainProducerGroup = value;
      GroupHeader mainProducerGroup2 = this._ghMainProducerGroup;
      if (mainProducerGroup2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) mainProducerGroup2).Format += eventHandler;
    }
  }

  private virtual GroupHeader ghProducer
  {
    get => this._ghProducer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ghProducer_BeforePrint);
      GroupHeader ghProducer1 = this._ghProducer;
      if (ghProducer1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) ghProducer1).BeforePrint -= eventHandler;
      this._ghProducer = value;
      GroupHeader ghProducer2 = this._ghProducer;
      if (ghProducer2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) ghProducer2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ghInsured")]
  private virtual GroupHeader ghInsured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghInvoiceOrCheck")]
  private virtual GroupHeader ghInvoiceOrCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghInvoiceOrCheckDetail")]
  private virtual GroupHeader ghInvoiceOrCheckDetail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghInvoiceOrCheckBreakdown")]
  private virtual GroupHeader ghInvoiceOrCheckBreakdown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfInvoiceOrCheckBreakdown")]
  private virtual GroupFooter gfInvoiceOrCheckBreakdown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfInvoiceOrCheckDetail")]
  private virtual GroupFooter gfInvoiceOrCheckDetail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfInvoiceOrCheck")]
  private virtual GroupFooter gfInvoiceOrCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual GroupFooter gfInsured
  {
    get => this._gfInsured;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfInsured_BeforePrint);
      GroupFooter gfInsured1 = this._gfInsured;
      if (gfInsured1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfInsured1).BeforePrint -= eventHandler;
      this._gfInsured = value;
      GroupFooter gfInsured2 = this._gfInsured;
      if (gfInsured2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfInsured2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gfProducer")]
  private virtual GroupFooter gfProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfMainProducerGroup")]
  private virtual GroupFooter gfMainProducerGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
