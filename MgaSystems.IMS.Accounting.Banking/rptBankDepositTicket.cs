// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.rptBankDepositTicket
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[SecureResource("{F0B7BA7B-AB2D-4ac8-A7AE-DC57991D3E3B}", "View Deposit Detail", "Determines whether or not a user can view deposit detail.", "Accounting")]
public sealed class rptBankDepositTicket : SectionReport
{
  private DataTable headerTbl;
  private DataTable checkTbl;
  private DataTable detailTbl;
  private TextBox TextBox20;
  private Label Label7;
  private Label Label1;
  private Shape Shape1;
  private Shape Shape2;
  private Shape Shape3;
  private Shape Shape4;
  private Shape Shape5;
  private Shape Shape6;
  private Shape Shape7;
  private Shape Shape8;
  private Shape Shape9;
  private Shape Shape10;
  private Shape Shape11;
  private Shape Shape12;
  private Shape Shape13;
  private Shape Shape14;
  private Shape Shape15;
  private Shape Shape16;
  private Shape Shape17;
  private Shape Shape18;
  private Shape Shape19;
  private Shape Shape20;
  private Shape Shape21;
  private Line Line3;
  private Line Line4;
  private Line Line5;
  private Line Line6;
  private Line Line7;
  private Line Line8;
  private Line Line9;
  private Line Line10;
  private Line Line11;
  private Line Line12;
  private Line Line13;
  private Line Line14;
  private Line Line15;
  private Line Line16;
  private Line Line17;
  private Line Line18;
  private Line Line19;
  private Line Line20;
  private Line Line21;
  private Line Line22;
  private Line Line23;
  private Line Line24;
  private Line Line25;
  private Line Line26;
  private Line Line27;
  private Line Line28;
  private Line Line29;
  private Line Line30;
  private Line Line31;
  private Line Line32;
  private Line Line33;
  private Line Line34;
  private Line Line35;
  private Line Line36;
  private Line Line37;
  private Line Line38;
  private Line Line39;
  private Line Line40;
  private Line Line41;
  private Line Line42;
  private Label Label2;
  private Line Line43;
  private Label Label3;
  private Line Line44;
  private Label Label4;
  private TextBox txtCashAmount;
  private TextBox txtCheckAmount1;
  private TextBox txtCheckAmount2;
  private TextBox txtCheckAmount3;
  private TextBox txtCheckAmount4;
  private TextBox txtCheckAmount5;
  private TextBox txtCheckAmount6;
  private TextBox txtCheckAmount13;
  private TextBox txtCheckAmount12;
  private TextBox txtCheckAmount11;
  private TextBox txtCheckAmount10;
  private TextBox txtCheckAmount9;
  private TextBox txtCheckAmount8;
  private TextBox txtCheckAmount7;
  private TextBox txtSubTotal;
  private TextBox txtCheckAmount18;
  private TextBox txtCheckAmount17;
  private TextBox txtCheckAmount16;
  private TextBox txtCheckAmount15;
  private TextBox txtCheckAmount14;
  private TextBox txtOfficeLocation;
  private Label Label5;
  private TextBox txtMICRAccountNumber;
  private Label Label8;
  private Shape Shape22;
  private TextBox txtNumItems;
  private Shape Shape23;
  private TextBox txtTotal;
  private Label Label9;
  private TextBox txtBankAddress;
  private Line Line45;
  private TextBox TextBox18;
  private TextBox TextBox19;
  private Label Label12;
  private Label lblSeeAttached;
  private SubReport SubReport1;

  public rptBankDepositTicket()
  {
    this.ReportStart += new EventHandler(this.rptBankDepositTicket_ReportStart);
    this.InitializeComponent();
  }

  public rptBankDepositTicket(DataTable HeaderTable, DataTable CheckTable, DataTable DetailTable)
  {
    this.ReportStart += new EventHandler(this.rptBankDepositTicket_ReportStart);
    this.InitializeComponent();
    this.headerTbl = HeaderTable;
    this.checkTbl = CheckTable;
    this.detailTbl = DetailTable;
    this.DataSource = (object) this.headerTbl;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptBankDepositTicket));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.TextBox20 = new TextBox();
    this.Label7 = new Label();
    this.Label1 = new Label();
    this.Shape1 = new Shape();
    this.Shape2 = new Shape();
    this.Shape3 = new Shape();
    this.Shape4 = new Shape();
    this.Shape5 = new Shape();
    this.Shape6 = new Shape();
    this.Shape7 = new Shape();
    this.Shape8 = new Shape();
    this.Shape9 = new Shape();
    this.Shape10 = new Shape();
    this.Shape11 = new Shape();
    this.Shape12 = new Shape();
    this.Shape13 = new Shape();
    this.Shape14 = new Shape();
    this.Shape15 = new Shape();
    this.Shape16 = new Shape();
    this.Shape17 = new Shape();
    this.Shape18 = new Shape();
    this.Shape19 = new Shape();
    this.Shape20 = new Shape();
    this.Shape21 = new Shape();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line5 = new Line();
    this.Line6 = new Line();
    this.Line7 = new Line();
    this.Line8 = new Line();
    this.Line9 = new Line();
    this.Line10 = new Line();
    this.Line11 = new Line();
    this.Line12 = new Line();
    this.Line13 = new Line();
    this.Line14 = new Line();
    this.Line15 = new Line();
    this.Line16 = new Line();
    this.Line17 = new Line();
    this.Line18 = new Line();
    this.Line19 = new Line();
    this.Line20 = new Line();
    this.Line21 = new Line();
    this.Line22 = new Line();
    this.Line23 = new Line();
    this.Line24 = new Line();
    this.Line25 = new Line();
    this.Line26 = new Line();
    this.Line27 = new Line();
    this.Line28 = new Line();
    this.Line29 = new Line();
    this.Line30 = new Line();
    this.Line31 = new Line();
    this.Line32 = new Line();
    this.Line33 = new Line();
    this.Line34 = new Line();
    this.Line35 = new Line();
    this.Line36 = new Line();
    this.Line37 = new Line();
    this.Line38 = new Line();
    this.Line39 = new Line();
    this.Line40 = new Line();
    this.Line41 = new Line();
    this.Line42 = new Line();
    this.Label2 = new Label();
    this.Line43 = new Line();
    this.Label3 = new Label();
    this.Line44 = new Line();
    this.Label4 = new Label();
    this.txtCashAmount = new TextBox();
    this.txtCheckAmount1 = new TextBox();
    this.txtCheckAmount2 = new TextBox();
    this.txtCheckAmount3 = new TextBox();
    this.txtCheckAmount4 = new TextBox();
    this.txtCheckAmount5 = new TextBox();
    this.txtCheckAmount6 = new TextBox();
    this.txtCheckAmount13 = new TextBox();
    this.txtCheckAmount12 = new TextBox();
    this.txtCheckAmount11 = new TextBox();
    this.txtCheckAmount10 = new TextBox();
    this.txtCheckAmount9 = new TextBox();
    this.txtCheckAmount8 = new TextBox();
    this.txtCheckAmount7 = new TextBox();
    this.txtSubTotal = new TextBox();
    this.txtCheckAmount18 = new TextBox();
    this.txtCheckAmount17 = new TextBox();
    this.txtCheckAmount16 = new TextBox();
    this.txtCheckAmount15 = new TextBox();
    this.txtCheckAmount14 = new TextBox();
    this.txtOfficeLocation = new TextBox();
    this.Label5 = new Label();
    this.txtMICRAccountNumber = new TextBox();
    this.Label8 = new Label();
    this.Shape22 = new Shape();
    this.txtNumItems = new TextBox();
    this.Shape23 = new Shape();
    this.txtTotal = new TextBox();
    this.Label9 = new Label();
    this.txtBankAddress = new TextBox();
    this.Line45 = new Line();
    this.TextBox18 = new TextBox();
    this.TextBox19 = new TextBox();
    this.Label12 = new Label();
    this.lblSeeAttached = new Label();
    this.SubReport1 = new SubReport();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.txtCashAmount).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount1).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount2).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount3).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount4).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount5).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount6).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount13).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount12).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount11).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount10).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount9).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount8).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount7).BeginInit();
    ((ISupportInitialize) this.txtSubTotal).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount18).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount17).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount16).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount15).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount14).BeginInit();
    ((ISupportInitialize) this.txtOfficeLocation).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtMICRAccountNumber).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.txtNumItems).BeginInit();
    ((ISupportInitialize) this.txtTotal).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtBankAddress).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.lblSeeAttached).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.SubReport1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[104]
    {
      (ARControl) this.TextBox20,
      (ARControl) this.Label7,
      (ARControl) this.Label1,
      (ARControl) this.Shape1,
      (ARControl) this.Shape2,
      (ARControl) this.Shape3,
      (ARControl) this.Shape4,
      (ARControl) this.Shape5,
      (ARControl) this.Shape6,
      (ARControl) this.Shape7,
      (ARControl) this.Shape8,
      (ARControl) this.Shape9,
      (ARControl) this.Shape10,
      (ARControl) this.Shape11,
      (ARControl) this.Shape12,
      (ARControl) this.Shape13,
      (ARControl) this.Shape14,
      (ARControl) this.Shape15,
      (ARControl) this.Shape16,
      (ARControl) this.Shape17,
      (ARControl) this.Shape18,
      (ARControl) this.Shape19,
      (ARControl) this.Shape20,
      (ARControl) this.Shape21,
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.Line5,
      (ARControl) this.Line6,
      (ARControl) this.Line7,
      (ARControl) this.Line8,
      (ARControl) this.Line9,
      (ARControl) this.Line10,
      (ARControl) this.Line11,
      (ARControl) this.Line12,
      (ARControl) this.Line13,
      (ARControl) this.Line14,
      (ARControl) this.Line15,
      (ARControl) this.Line16,
      (ARControl) this.Line17,
      (ARControl) this.Line18,
      (ARControl) this.Line19,
      (ARControl) this.Line20,
      (ARControl) this.Line21,
      (ARControl) this.Line22,
      (ARControl) this.Line23,
      (ARControl) this.Line24,
      (ARControl) this.Line25,
      (ARControl) this.Line26,
      (ARControl) this.Line27,
      (ARControl) this.Line28,
      (ARControl) this.Line29,
      (ARControl) this.Line30,
      (ARControl) this.Line31,
      (ARControl) this.Line32,
      (ARControl) this.Line33,
      (ARControl) this.Line34,
      (ARControl) this.Line35,
      (ARControl) this.Line36,
      (ARControl) this.Line37,
      (ARControl) this.Line38,
      (ARControl) this.Line39,
      (ARControl) this.Line40,
      (ARControl) this.Line41,
      (ARControl) this.Line42,
      (ARControl) this.Label2,
      (ARControl) this.Line43,
      (ARControl) this.Label3,
      (ARControl) this.Line44,
      (ARControl) this.Label4,
      (ARControl) this.txtCashAmount,
      (ARControl) this.txtCheckAmount1,
      (ARControl) this.txtCheckAmount2,
      (ARControl) this.txtCheckAmount3,
      (ARControl) this.txtCheckAmount4,
      (ARControl) this.txtCheckAmount5,
      (ARControl) this.txtCheckAmount6,
      (ARControl) this.txtCheckAmount13,
      (ARControl) this.txtCheckAmount12,
      (ARControl) this.txtCheckAmount11,
      (ARControl) this.txtCheckAmount10,
      (ARControl) this.txtCheckAmount9,
      (ARControl) this.txtCheckAmount8,
      (ARControl) this.txtCheckAmount7,
      (ARControl) this.txtSubTotal,
      (ARControl) this.txtCheckAmount18,
      (ARControl) this.txtCheckAmount17,
      (ARControl) this.txtCheckAmount16,
      (ARControl) this.txtCheckAmount15,
      (ARControl) this.txtCheckAmount14,
      (ARControl) this.txtOfficeLocation,
      (ARControl) this.Label5,
      (ARControl) this.txtMICRAccountNumber,
      (ARControl) this.Label8,
      (ARControl) this.Shape22,
      (ARControl) this.txtNumItems,
      (ARControl) this.Shape23,
      (ARControl) this.txtTotal,
      (ARControl) this.Label9,
      (ARControl) this.txtBankAddress,
      (ARControl) this.Line45,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox19,
      (ARControl) this.Label12,
      (ARControl) this.lblSeeAttached
    });
    this.PageHeader.Height = 3f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.TextBox20.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).DataField = "depositdate";
    this.TextBox20.DistinctField = (string) null;
    this.TextBox20.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox20.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox20 = this.TextBox20;
    object obj1 = componentResourceManager.GetObject("TextBox20.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox20).Location = pointF1;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox20).Size = new SizeF(1.625f, 0.1374999f);
    this.Label7.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 6f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.Silver;
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj2 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label7).Location = pointF2;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(9f / 16f, 0.265f);
    this.Label7.Text = "LESS CASH RECEIVED";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.LightSteelBlue;
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj3 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label1).Location = pointF3;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1.625f, 5f / 16f);
    this.Label1.Text = "deposit ticket";
    ((ARControl) this.Shape1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape1).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape1.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape1.LineWeight = 8f;
    Shape shape1 = this.Shape1;
    object obj4 = componentResourceManager.GetObject("Shape1.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) shape1).Location = pointF4;
    ((ARControl) this.Shape1).Name = "Shape1";
    ((ARControl) this.Shape1).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape2).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape2.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape2.LineWeight = 8f;
    Shape shape2 = this.Shape2;
    object obj5 = componentResourceManager.GetObject("Shape2.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) shape2).Location = pointF5;
    ((ARControl) this.Shape2).Name = "Shape2";
    ((ARControl) this.Shape2).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape3).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape3.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape3.LineWeight = 8f;
    Shape shape3 = this.Shape3;
    object obj6 = componentResourceManager.GetObject("Shape3.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) shape3).Location = pointF6;
    ((ARControl) this.Shape3).Name = "Shape3";
    ((ARControl) this.Shape3).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape4).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape4.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape4.LineWeight = 8f;
    Shape shape4 = this.Shape4;
    object obj7 = componentResourceManager.GetObject("Shape4.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) shape4).Location = pointF7;
    ((ARControl) this.Shape4).Name = "Shape4";
    ((ARControl) this.Shape4).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape5).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape5.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape5.LineWeight = 8f;
    Shape shape5 = this.Shape5;
    object obj8 = componentResourceManager.GetObject("Shape5.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) shape5).Location = pointF8;
    ((ARControl) this.Shape5).Name = "Shape5";
    ((ARControl) this.Shape5).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape6).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape6.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape6.LineWeight = 8f;
    Shape shape6 = this.Shape6;
    object obj9 = componentResourceManager.GetObject("Shape6.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) shape6).Location = pointF9;
    ((ARControl) this.Shape6).Name = "Shape6";
    ((ARControl) this.Shape6).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape7).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape7.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape7.LineWeight = 8f;
    Shape shape7 = this.Shape7;
    object obj10 = componentResourceManager.GetObject("Shape7.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) shape7).Location = pointF10;
    ((ARControl) this.Shape7).Name = "Shape7";
    ((ARControl) this.Shape7).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape8).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape8.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape8.LineWeight = 8f;
    Shape shape8 = this.Shape8;
    object obj11 = componentResourceManager.GetObject("Shape8.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) shape8).Location = pointF11;
    ((ARControl) this.Shape8).Name = "Shape8";
    ((ARControl) this.Shape8).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape9).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape9.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape9.LineWeight = 8f;
    Shape shape9 = this.Shape9;
    object obj12 = componentResourceManager.GetObject("Shape9.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) shape9).Location = pointF12;
    ((ARControl) this.Shape9).Name = "Shape9";
    ((ARControl) this.Shape9).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape10).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape10.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape10.LineWeight = 8f;
    Shape shape10 = this.Shape10;
    object obj13 = componentResourceManager.GetObject("Shape10.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) shape10).Location = pointF13;
    ((ARControl) this.Shape10).Name = "Shape10";
    ((ARControl) this.Shape10).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape11).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape11.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape11.LineWeight = 8f;
    Shape shape11 = this.Shape11;
    object obj14 = componentResourceManager.GetObject("Shape11.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) shape11).Location = pointF14;
    ((ARControl) this.Shape11).Name = "Shape11";
    ((ARControl) this.Shape11).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape12).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape12.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape12.LineWeight = 8f;
    Shape shape12 = this.Shape12;
    object obj15 = componentResourceManager.GetObject("Shape12.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) shape12).Location = pointF15;
    ((ARControl) this.Shape12).Name = "Shape12";
    ((ARControl) this.Shape12).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape13).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape13.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape13.LineWeight = 8f;
    Shape shape13 = this.Shape13;
    object obj16 = componentResourceManager.GetObject("Shape13.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) shape13).Location = pointF16;
    ((ARControl) this.Shape13).Name = "Shape13";
    ((ARControl) this.Shape13).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape14).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape14.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape14.LineWeight = 8f;
    Shape shape14 = this.Shape14;
    object obj17 = componentResourceManager.GetObject("Shape14.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) shape14).Location = pointF17;
    ((ARControl) this.Shape14).Name = "Shape14";
    ((ARControl) this.Shape14).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape15).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape15.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape15.LineWeight = 8f;
    Shape shape15 = this.Shape15;
    object obj18 = componentResourceManager.GetObject("Shape15.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) shape15).Location = pointF18;
    ((ARControl) this.Shape15).Name = "Shape15";
    ((ARControl) this.Shape15).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape16).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape16.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape16.LineWeight = 8f;
    Shape shape16 = this.Shape16;
    object obj19 = componentResourceManager.GetObject("Shape16.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) shape16).Location = pointF19;
    ((ARControl) this.Shape16).Name = "Shape16";
    ((ARControl) this.Shape16).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape17).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape17.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape17.LineWeight = 8f;
    Shape shape17 = this.Shape17;
    object obj20 = componentResourceManager.GetObject("Shape17.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) shape17).Location = pointF20;
    ((ARControl) this.Shape17).Name = "Shape17";
    ((ARControl) this.Shape17).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape18).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape18.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape18.LineWeight = 8f;
    Shape shape18 = this.Shape18;
    object obj21 = componentResourceManager.GetObject("Shape18.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) shape18).Location = pointF21;
    ((ARControl) this.Shape18).Name = "Shape18";
    ((ARControl) this.Shape18).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape19).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape19.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape19.LineWeight = 8f;
    Shape shape19 = this.Shape19;
    object obj22 = componentResourceManager.GetObject("Shape19.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) shape19).Location = pointF22;
    ((ARControl) this.Shape19).Name = "Shape19";
    ((ARControl) this.Shape19).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape20).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape20.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape20.LineWeight = 8f;
    Shape shape20 = this.Shape20;
    object obj23 = componentResourceManager.GetObject("Shape20.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) shape20).Location = pointF23;
    ((ARControl) this.Shape20).Name = "Shape20";
    ((ARControl) this.Shape20).Size = new SizeF(1.375f, 5f / 16f);
    ((ARControl) this.Shape21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape21).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape21.LineColor = Color.FromArgb(176 /*0xB0*/, 196, 222);
    this.Shape21.LineWeight = 8f;
    Shape shape21 = this.Shape21;
    object obj24 = componentResourceManager.GetObject("Shape21.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) shape21).Location = pointF24;
    ((ARControl) this.Shape21).Name = "Shape21";
    ((ARControl) this.Shape21).Size = new SizeF(1.375f, 5f / 16f);
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    this.Line3.LineColor = Color.FromArgb(169, 169, 169);
    this.Line3.LineWeight = 3f;
    ((ARControl) this.Line3).Name = "Line3";
    this.Line3.X1 = 37f / 16f;
    this.Line3.X2 = 43f / 16f;
    this.Line3.Y1 = 0.585f;
    this.Line3.Y2 = 0.585f;
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    this.Line4.LineColor = Color.FromArgb(105, 105, 105);
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    this.Line4.X1 = 43f / 16f;
    this.Line4.X2 = 43f / 16f;
    this.Line4.Y1 = 0.625f;
    this.Line4.Y2 = 0.375f;
    this.Line5.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line5.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line5.Border.RightStyle = (BorderLineStyle) 0;
    this.Line5.Border.TopStyle = (BorderLineStyle) 0;
    this.Line5.LineColor = Color.FromArgb(169, 169, 169);
    this.Line5.LineWeight = 3f;
    ((ARControl) this.Line5).Name = "Line5";
    this.Line5.X1 = 37f / 16f;
    this.Line5.X2 = 43f / 16f;
    this.Line5.Y1 = 0.84f;
    this.Line5.Y2 = 0.84f;
    this.Line6.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line6.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line6.Border.RightStyle = (BorderLineStyle) 0;
    this.Line6.Border.TopStyle = (BorderLineStyle) 0;
    this.Line6.LineColor = Color.FromArgb(105, 105, 105);
    this.Line6.LineWeight = 1f;
    ((ARControl) this.Line6).Name = "Line6";
    this.Line6.X1 = 43f / 16f;
    this.Line6.X2 = 43f / 16f;
    this.Line6.Y1 = 0.875f;
    this.Line6.Y2 = 0.625f;
    this.Line7.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line7.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line7.Border.RightStyle = (BorderLineStyle) 0;
    this.Line7.Border.TopStyle = (BorderLineStyle) 0;
    this.Line7.LineColor = Color.FromArgb(169, 169, 169);
    this.Line7.LineWeight = 3f;
    ((ARControl) this.Line7).Name = "Line7";
    this.Line7.X1 = 37f / 16f;
    this.Line7.X2 = 43f / 16f;
    this.Line7.Y1 = 1.075f;
    this.Line7.Y2 = 1.075f;
    this.Line8.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line8.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line8.Border.RightStyle = (BorderLineStyle) 0;
    this.Line8.Border.TopStyle = (BorderLineStyle) 0;
    this.Line8.LineColor = Color.FromArgb(105, 105, 105);
    this.Line8.LineWeight = 1f;
    ((ARControl) this.Line8).Name = "Line8";
    this.Line8.X1 = 43f / 16f;
    this.Line8.X2 = 43f / 16f;
    this.Line8.Y1 = 1.125f;
    this.Line8.Y2 = 0.875f;
    this.Line9.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line9.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line9.Border.RightStyle = (BorderLineStyle) 0;
    this.Line9.Border.TopStyle = (BorderLineStyle) 0;
    this.Line9.LineColor = Color.FromArgb(169, 169, 169);
    this.Line9.LineWeight = 3f;
    ((ARControl) this.Line9).Name = "Line9";
    this.Line9.X1 = 37f / 16f;
    this.Line9.X2 = 43f / 16f;
    this.Line9.Y1 = 1.33f;
    this.Line9.Y2 = 1.33f;
    this.Line10.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line10.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line10.Border.RightStyle = (BorderLineStyle) 0;
    this.Line10.Border.TopStyle = (BorderLineStyle) 0;
    this.Line10.LineColor = Color.FromArgb(105, 105, 105);
    this.Line10.LineWeight = 1f;
    ((ARControl) this.Line10).Name = "Line10";
    this.Line10.X1 = 43f / 16f;
    this.Line10.X2 = 43f / 16f;
    this.Line10.Y1 = 1.375f;
    this.Line10.Y2 = 1.125f;
    this.Line11.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line11.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line11.Border.RightStyle = (BorderLineStyle) 0;
    this.Line11.Border.TopStyle = (BorderLineStyle) 0;
    this.Line11.LineColor = Color.FromArgb(169, 169, 169);
    this.Line11.LineWeight = 3f;
    ((ARControl) this.Line11).Name = "Line11";
    this.Line11.X1 = 37f / 16f;
    this.Line11.X2 = 43f / 16f;
    this.Line11.Y1 = 1.585f;
    this.Line11.Y2 = 1.585f;
    this.Line12.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line12.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line12.Border.RightStyle = (BorderLineStyle) 0;
    this.Line12.Border.TopStyle = (BorderLineStyle) 0;
    this.Line12.LineColor = Color.FromArgb(105, 105, 105);
    this.Line12.LineWeight = 1f;
    ((ARControl) this.Line12).Name = "Line12";
    this.Line12.X1 = 43f / 16f;
    this.Line12.X2 = 43f / 16f;
    this.Line12.Y1 = 1.625f;
    this.Line12.Y2 = 1.375f;
    this.Line13.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line13.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line13.Border.RightStyle = (BorderLineStyle) 0;
    this.Line13.Border.TopStyle = (BorderLineStyle) 0;
    this.Line13.LineColor = Color.FromArgb(169, 169, 169);
    this.Line13.LineWeight = 3f;
    ((ARControl) this.Line13).Name = "Line13";
    this.Line13.X1 = 37f / 16f;
    this.Line13.X2 = 43f / 16f;
    this.Line13.Y1 = 1.83f;
    this.Line13.Y2 = 1.83f;
    this.Line14.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line14.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line14.Border.RightStyle = (BorderLineStyle) 0;
    this.Line14.Border.TopStyle = (BorderLineStyle) 0;
    this.Line14.LineColor = Color.FromArgb(105, 105, 105);
    this.Line14.LineWeight = 1f;
    ((ARControl) this.Line14).Name = "Line14";
    this.Line14.X1 = 43f / 16f;
    this.Line14.X2 = 43f / 16f;
    this.Line14.Y1 = 1.875f;
    this.Line14.Y2 = 1.625f;
    this.Line15.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line15.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line15.Border.RightStyle = (BorderLineStyle) 0;
    this.Line15.Border.TopStyle = (BorderLineStyle) 0;
    this.Line15.LineColor = Color.FromArgb(169, 169, 169);
    this.Line15.LineWeight = 3f;
    ((ARControl) this.Line15).Name = "Line15";
    this.Line15.X1 = 4.25f;
    this.Line15.X2 = 4.625f;
    this.Line15.Y1 = 0.34f;
    this.Line15.Y2 = 0.34f;
    this.Line16.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line16.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line16.Border.RightStyle = (BorderLineStyle) 0;
    this.Line16.Border.TopStyle = (BorderLineStyle) 0;
    this.Line16.LineColor = Color.FromArgb(105, 105, 105);
    this.Line16.LineWeight = 1f;
    ((ARControl) this.Line16).Name = "Line16";
    this.Line16.X1 = 4.625f;
    this.Line16.X2 = 4.625f;
    this.Line16.Y1 = 0.375f;
    this.Line16.Y2 = 0.125f;
    this.Line17.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line17.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line17.Border.RightStyle = (BorderLineStyle) 0;
    this.Line17.Border.TopStyle = (BorderLineStyle) 0;
    this.Line17.LineColor = Color.FromArgb(169, 169, 169);
    this.Line17.LineWeight = 3f;
    ((ARControl) this.Line17).Name = "Line17";
    this.Line17.X1 = 4.25f;
    this.Line17.X2 = 4.625f;
    this.Line17.Y1 = 0.585f;
    this.Line17.Y2 = 0.585f;
    this.Line18.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line18.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line18.Border.RightStyle = (BorderLineStyle) 0;
    this.Line18.Border.TopStyle = (BorderLineStyle) 0;
    this.Line18.LineColor = Color.FromArgb(105, 105, 105);
    this.Line18.LineWeight = 1f;
    ((ARControl) this.Line18).Name = "Line18";
    this.Line18.X1 = 4.625f;
    this.Line18.X2 = 4.625f;
    this.Line18.Y1 = 0.625f;
    this.Line18.Y2 = 0.375f;
    this.Line19.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line19.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line19.Border.RightStyle = (BorderLineStyle) 0;
    this.Line19.Border.TopStyle = (BorderLineStyle) 0;
    this.Line19.LineColor = Color.FromArgb(169, 169, 169);
    this.Line19.LineWeight = 3f;
    ((ARControl) this.Line19).Name = "Line19";
    this.Line19.X1 = 4.25f;
    this.Line19.X2 = 4.625f;
    this.Line19.Y1 = 0.84f;
    this.Line19.Y2 = 0.84f;
    this.Line20.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line20.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line20.Border.RightStyle = (BorderLineStyle) 0;
    this.Line20.Border.TopStyle = (BorderLineStyle) 0;
    this.Line20.LineColor = Color.FromArgb(105, 105, 105);
    this.Line20.LineWeight = 1f;
    ((ARControl) this.Line20).Name = "Line20";
    this.Line20.X1 = 4.625f;
    this.Line20.X2 = 4.625f;
    this.Line20.Y1 = 0.875f;
    this.Line20.Y2 = 0.625f;
    this.Line21.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line21.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line21.Border.RightStyle = (BorderLineStyle) 0;
    this.Line21.Border.TopStyle = (BorderLineStyle) 0;
    this.Line21.LineColor = Color.FromArgb(169, 169, 169);
    this.Line21.LineWeight = 3f;
    ((ARControl) this.Line21).Name = "Line21";
    this.Line21.X1 = 4.25f;
    this.Line21.X2 = 4.625f;
    this.Line21.Y1 = 1.075f;
    this.Line21.Y2 = 1.075f;
    this.Line22.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line22.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line22.Border.RightStyle = (BorderLineStyle) 0;
    this.Line22.Border.TopStyle = (BorderLineStyle) 0;
    this.Line22.LineColor = Color.FromArgb(105, 105, 105);
    this.Line22.LineWeight = 1f;
    ((ARControl) this.Line22).Name = "Line22";
    this.Line22.X1 = 4.625f;
    this.Line22.X2 = 4.625f;
    this.Line22.Y1 = 1.125f;
    this.Line22.Y2 = 0.875f;
    this.Line23.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line23.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line23.Border.RightStyle = (BorderLineStyle) 0;
    this.Line23.Border.TopStyle = (BorderLineStyle) 0;
    this.Line23.LineColor = Color.FromArgb(169, 169, 169);
    this.Line23.LineWeight = 3f;
    ((ARControl) this.Line23).Name = "Line23";
    this.Line23.X1 = 4.25f;
    this.Line23.X2 = 4.625f;
    this.Line23.Y1 = 1.33f;
    this.Line23.Y2 = 1.33f;
    this.Line24.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line24.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line24.Border.RightStyle = (BorderLineStyle) 0;
    this.Line24.Border.TopStyle = (BorderLineStyle) 0;
    this.Line24.LineColor = Color.FromArgb(105, 105, 105);
    this.Line24.LineWeight = 1f;
    ((ARControl) this.Line24).Name = "Line24";
    this.Line24.X1 = 4.625f;
    this.Line24.X2 = 4.625f;
    this.Line24.Y1 = 1.375f;
    this.Line24.Y2 = 1.125f;
    this.Line25.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line25.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line25.Border.RightStyle = (BorderLineStyle) 0;
    this.Line25.Border.TopStyle = (BorderLineStyle) 0;
    this.Line25.LineColor = Color.FromArgb(169, 169, 169);
    this.Line25.LineWeight = 3f;
    ((ARControl) this.Line25).Name = "Line25";
    this.Line25.X1 = 4.25f;
    this.Line25.X2 = 4.625f;
    this.Line25.Y1 = 1.585f;
    this.Line25.Y2 = 1.585f;
    this.Line26.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line26.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line26.Border.RightStyle = (BorderLineStyle) 0;
    this.Line26.Border.TopStyle = (BorderLineStyle) 0;
    this.Line26.LineColor = Color.FromArgb(105, 105, 105);
    this.Line26.LineWeight = 1f;
    ((ARControl) this.Line26).Name = "Line26";
    this.Line26.X1 = 4.625f;
    this.Line26.X2 = 4.625f;
    this.Line26.Y1 = 1.625f;
    this.Line26.Y2 = 1.375f;
    this.Line27.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line27.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line27.Border.RightStyle = (BorderLineStyle) 0;
    this.Line27.Border.TopStyle = (BorderLineStyle) 0;
    this.Line27.LineColor = Color.FromArgb(169, 169, 169);
    this.Line27.LineWeight = 3f;
    ((ARControl) this.Line27).Name = "Line27";
    this.Line27.X1 = 4.25f;
    this.Line27.X2 = 4.625f;
    this.Line27.Y1 = 1.83f;
    this.Line27.Y2 = 1.83f;
    this.Line28.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line28.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line28.Border.RightStyle = (BorderLineStyle) 0;
    this.Line28.Border.TopStyle = (BorderLineStyle) 0;
    this.Line28.LineColor = Color.FromArgb(105, 105, 105);
    this.Line28.LineWeight = 1f;
    ((ARControl) this.Line28).Name = "Line28";
    this.Line28.X1 = 4.625f;
    this.Line28.X2 = 4.625f;
    this.Line28.Y1 = 1.875f;
    this.Line28.Y2 = 1.625f;
    this.Line29.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line29.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line29.Border.RightStyle = (BorderLineStyle) 0;
    this.Line29.Border.TopStyle = (BorderLineStyle) 0;
    this.Line29.LineColor = Color.FromArgb(169, 169, 169);
    this.Line29.LineWeight = 3f;
    ((ARControl) this.Line29).Name = "Line29";
    this.Line29.X1 = 6.25f;
    this.Line29.X2 = 6.625f;
    this.Line29.Y1 = 0.375f;
    this.Line29.Y2 = 0.375f;
    this.Line30.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line30.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line30.Border.RightStyle = (BorderLineStyle) 0;
    this.Line30.Border.TopStyle = (BorderLineStyle) 0;
    this.Line30.LineColor = Color.FromArgb(105, 105, 105);
    this.Line30.LineWeight = 1f;
    ((ARControl) this.Line30).Name = "Line30";
    this.Line30.X1 = 6.625f;
    this.Line30.X2 = 6.625f;
    this.Line30.Y1 = 0.375f;
    this.Line30.Y2 = 0.125f;
    this.Line31.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line31.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line31.Border.RightStyle = (BorderLineStyle) 0;
    this.Line31.Border.TopStyle = (BorderLineStyle) 0;
    this.Line31.LineColor = Color.FromArgb(169, 169, 169);
    this.Line31.LineWeight = 3f;
    ((ARControl) this.Line31).Name = "Line31";
    this.Line31.X1 = 6.25f;
    this.Line31.X2 = 6.625f;
    this.Line31.Y1 = 0.625f;
    this.Line31.Y2 = 0.625f;
    this.Line32.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line32.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line32.Border.RightStyle = (BorderLineStyle) 0;
    this.Line32.Border.TopStyle = (BorderLineStyle) 0;
    this.Line32.LineColor = Color.FromArgb(105, 105, 105);
    this.Line32.LineWeight = 1f;
    ((ARControl) this.Line32).Name = "Line32";
    this.Line32.X1 = 6.625f;
    this.Line32.X2 = 6.625f;
    this.Line32.Y1 = 0.625f;
    this.Line32.Y2 = 0.375f;
    this.Line33.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line33.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line33.Border.RightStyle = (BorderLineStyle) 0;
    this.Line33.Border.TopStyle = (BorderLineStyle) 0;
    this.Line33.LineColor = Color.FromArgb(169, 169, 169);
    this.Line33.LineWeight = 3f;
    ((ARControl) this.Line33).Name = "Line33";
    this.Line33.X1 = 6.25f;
    this.Line33.X2 = 6.625f;
    this.Line33.Y1 = 0.84f;
    this.Line33.Y2 = 0.84f;
    this.Line34.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line34.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line34.Border.RightStyle = (BorderLineStyle) 0;
    this.Line34.Border.TopStyle = (BorderLineStyle) 0;
    this.Line34.LineColor = Color.FromArgb(105, 105, 105);
    this.Line34.LineWeight = 1f;
    ((ARControl) this.Line34).Name = "Line34";
    this.Line34.X1 = 6.625f;
    this.Line34.X2 = 6.625f;
    this.Line34.Y1 = 0.875f;
    this.Line34.Y2 = 0.625f;
    this.Line35.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line35.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line35.Border.RightStyle = (BorderLineStyle) 0;
    this.Line35.Border.TopStyle = (BorderLineStyle) 0;
    this.Line35.LineColor = Color.FromArgb(169, 169, 169);
    this.Line35.LineWeight = 3f;
    ((ARControl) this.Line35).Name = "Line35";
    this.Line35.X1 = 6.25f;
    this.Line35.X2 = 6.625f;
    this.Line35.Y1 = 1.075f;
    this.Line35.Y2 = 1.075f;
    this.Line36.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line36.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line36.Border.RightStyle = (BorderLineStyle) 0;
    this.Line36.Border.TopStyle = (BorderLineStyle) 0;
    this.Line36.LineColor = Color.FromArgb(105, 105, 105);
    this.Line36.LineWeight = 1f;
    ((ARControl) this.Line36).Name = "Line36";
    this.Line36.X1 = 6.625f;
    this.Line36.X2 = 6.625f;
    this.Line36.Y1 = 1.125f;
    this.Line36.Y2 = 0.875f;
    this.Line37.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line37.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line37.Border.RightStyle = (BorderLineStyle) 0;
    this.Line37.Border.TopStyle = (BorderLineStyle) 0;
    this.Line37.LineColor = Color.FromArgb(169, 169, 169);
    this.Line37.LineWeight = 3f;
    ((ARControl) this.Line37).Name = "Line37";
    this.Line37.X1 = 6.25f;
    this.Line37.X2 = 6.625f;
    this.Line37.Y1 = 1.33f;
    this.Line37.Y2 = 1.33f;
    this.Line38.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line38.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line38.Border.RightStyle = (BorderLineStyle) 0;
    this.Line38.Border.TopStyle = (BorderLineStyle) 0;
    this.Line38.LineColor = Color.FromArgb(105, 105, 105);
    this.Line38.LineWeight = 1f;
    ((ARControl) this.Line38).Name = "Line38";
    this.Line38.X1 = 6.625f;
    this.Line38.X2 = 6.625f;
    this.Line38.Y1 = 1.375f;
    this.Line38.Y2 = 1.125f;
    this.Line39.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line39.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line39.Border.RightStyle = (BorderLineStyle) 0;
    this.Line39.Border.TopStyle = (BorderLineStyle) 0;
    this.Line39.LineColor = Color.FromArgb(169, 169, 169);
    this.Line39.LineWeight = 3f;
    ((ARControl) this.Line39).Name = "Line39";
    this.Line39.X1 = 6.25f;
    this.Line39.X2 = 6.625f;
    this.Line39.Y1 = 1.585f;
    this.Line39.Y2 = 1.585f;
    this.Line40.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line40.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line40.Border.RightStyle = (BorderLineStyle) 0;
    this.Line40.Border.TopStyle = (BorderLineStyle) 0;
    this.Line40.LineColor = Color.FromArgb(105, 105, 105);
    this.Line40.LineWeight = 1f;
    ((ARControl) this.Line40).Name = "Line40";
    this.Line40.X1 = 6.625f;
    this.Line40.X2 = 6.625f;
    this.Line40.Y1 = 1.625f;
    this.Line40.Y2 = 1.375f;
    this.Line41.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line41.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line41.Border.RightStyle = (BorderLineStyle) 0;
    this.Line41.Border.TopStyle = (BorderLineStyle) 0;
    this.Line41.LineColor = Color.FromArgb(169, 169, 169);
    this.Line41.LineWeight = 3f;
    ((ARControl) this.Line41).Name = "Line41";
    this.Line41.X1 = 6.25f;
    this.Line41.X2 = 6.625f;
    this.Line41.Y1 = 1.83f;
    this.Line41.Y2 = 1.83f;
    this.Line42.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line42.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line42.Border.RightStyle = (BorderLineStyle) 0;
    this.Line42.Border.TopStyle = (BorderLineStyle) 0;
    this.Line42.LineColor = Color.FromArgb(105, 105, 105);
    this.Line42.LineWeight = 1f;
    ((ARControl) this.Line42).Name = "Line42";
    this.Line42.X1 = 6.625f;
    this.Line42.X2 = 6.625f;
    this.Line42.Y1 = 1.875f;
    this.Line42.Y2 = 1.625f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.LightSteelBlue;
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj25 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label2).Location = pointF25;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.375f, 3f / 16f);
    this.Label2.Text = "Date:";
    this.Line43.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line43.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line43.Border.RightStyle = (BorderLineStyle) 0;
    this.Line43.Border.TopStyle = (BorderLineStyle) 0;
    this.Line43.LineWeight = 1f;
    ((ARControl) this.Line43).Name = "Line43";
    this.Line43.X1 = 9f / 16f;
    this.Line43.X2 = 35f / 16f;
    this.Line43.Y1 = 25f / 16f;
    this.Line43.Y2 = 25f / 16f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.LightSteelBlue;
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj26 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) label3).Location = pointF26;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.5f, 3f / 16f);
    this.Label3.Text = "Signed:";
    ((ARControl) this.Label3).Visible = false;
    this.Line44.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line44.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line44.Border.RightStyle = (BorderLineStyle) 0;
    this.Line44.Border.TopStyle = (BorderLineStyle) 0;
    this.Line44.LineWeight = 1f;
    ((ARControl) this.Line44).Name = "Line44";
    ((ARControl) this.Line44).Visible = false;
    this.Line44.X1 = 9f / 16f;
    this.Line44.X2 = 35f / 16f;
    this.Line44.Y1 = 1.5875f;
    this.Line44.Y2 = 1.5875f;
    this.Label4.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 6f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.LightSteelBlue;
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj27 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) label4).Location = pointF27;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1.625f, 3f / 16f);
    this.Label4.Text = "Authorized Signature";
    ((ARControl) this.Label4).Visible = false;
    this.txtCashAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCashAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCashAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCashAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCashAmount).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCashAmount.DistinctField = (string) null;
    this.txtCashAmount.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCashAmount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCashAmount = this.txtCashAmount;
    object obj28 = componentResourceManager.GetObject("txtCashAmount.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) txtCashAmount).Location = pointF28;
    ((ARControl) this.txtCashAmount).Name = "txtCashAmount";
    this.txtCashAmount.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCashAmount).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount1.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount1).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount1.DistinctField = (string) null;
    this.txtCheckAmount1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount1 = this.txtCheckAmount1;
    object obj29 = componentResourceManager.GetObject("txtCheckAmount1.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) txtCheckAmount1).Location = pointF29;
    ((ARControl) this.txtCheckAmount1).Name = "txtCheckAmount1";
    this.txtCheckAmount1.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount1).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount2.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount2).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount2.DistinctField = (string) null;
    this.txtCheckAmount2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount2 = this.txtCheckAmount2;
    object obj30 = componentResourceManager.GetObject("txtCheckAmount2.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) txtCheckAmount2).Location = pointF30;
    ((ARControl) this.txtCheckAmount2).Name = "txtCheckAmount2";
    this.txtCheckAmount2.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount2).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount3.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount3).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount3.DistinctField = (string) null;
    this.txtCheckAmount3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount3 = this.txtCheckAmount3;
    object obj31 = componentResourceManager.GetObject("txtCheckAmount3.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) txtCheckAmount3).Location = pointF31;
    ((ARControl) this.txtCheckAmount3).Name = "txtCheckAmount3";
    this.txtCheckAmount3.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount3).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount4.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount4).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount4.DistinctField = (string) null;
    this.txtCheckAmount4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount4 = this.txtCheckAmount4;
    object obj32 = componentResourceManager.GetObject("txtCheckAmount4.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) txtCheckAmount4).Location = pointF32;
    ((ARControl) this.txtCheckAmount4).Name = "txtCheckAmount4";
    this.txtCheckAmount4.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount4).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount5.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount5).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount5.DistinctField = (string) null;
    this.txtCheckAmount5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount5 = this.txtCheckAmount5;
    object obj33 = componentResourceManager.GetObject("txtCheckAmount5.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) txtCheckAmount5).Location = pointF33;
    ((ARControl) this.txtCheckAmount5).Name = "txtCheckAmount5";
    this.txtCheckAmount5.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount5).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount6.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount6).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount6.DistinctField = (string) null;
    this.txtCheckAmount6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount6 = this.txtCheckAmount6;
    object obj34 = componentResourceManager.GetObject("txtCheckAmount6.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) txtCheckAmount6).Location = pointF34;
    ((ARControl) this.txtCheckAmount6).Name = "txtCheckAmount6";
    this.txtCheckAmount6.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount6).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount13.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount13).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount13.DistinctField = (string) null;
    this.txtCheckAmount13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount13 = this.txtCheckAmount13;
    object obj35 = componentResourceManager.GetObject("txtCheckAmount13.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) txtCheckAmount13).Location = pointF35;
    ((ARControl) this.txtCheckAmount13).Name = "txtCheckAmount13";
    this.txtCheckAmount13.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount13).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount12.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount12).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount12.DistinctField = (string) null;
    this.txtCheckAmount12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount12 = this.txtCheckAmount12;
    object obj36 = componentResourceManager.GetObject("txtCheckAmount12.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) txtCheckAmount12).Location = pointF36;
    ((ARControl) this.txtCheckAmount12).Name = "txtCheckAmount12";
    this.txtCheckAmount12.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount12).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount11.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount11).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount11.DistinctField = (string) null;
    this.txtCheckAmount11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount11 = this.txtCheckAmount11;
    object obj37 = componentResourceManager.GetObject("txtCheckAmount11.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) txtCheckAmount11).Location = pointF37;
    ((ARControl) this.txtCheckAmount11).Name = "txtCheckAmount11";
    this.txtCheckAmount11.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount11).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount10.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount10).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount10.DistinctField = (string) null;
    this.txtCheckAmount10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount10 = this.txtCheckAmount10;
    object obj38 = componentResourceManager.GetObject("txtCheckAmount10.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) txtCheckAmount10).Location = pointF38;
    ((ARControl) this.txtCheckAmount10).Name = "txtCheckAmount10";
    this.txtCheckAmount10.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount10).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount9.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount9).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount9.DistinctField = (string) null;
    this.txtCheckAmount9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount9 = this.txtCheckAmount9;
    object obj39 = componentResourceManager.GetObject("txtCheckAmount9.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) txtCheckAmount9).Location = pointF39;
    ((ARControl) this.txtCheckAmount9).Name = "txtCheckAmount9";
    this.txtCheckAmount9.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount9).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount8.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount8).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount8.DistinctField = (string) null;
    this.txtCheckAmount8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount8 = this.txtCheckAmount8;
    object obj40 = componentResourceManager.GetObject("txtCheckAmount8.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) txtCheckAmount8).Location = pointF40;
    ((ARControl) this.txtCheckAmount8).Name = "txtCheckAmount8";
    this.txtCheckAmount8.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount8).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount7.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount7).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount7.DistinctField = (string) null;
    this.txtCheckAmount7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount7 = this.txtCheckAmount7;
    object obj41 = componentResourceManager.GetObject("txtCheckAmount7.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) txtCheckAmount7).Location = pointF41;
    ((ARControl) this.txtCheckAmount7).Name = "txtCheckAmount7";
    this.txtCheckAmount7.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount7).Size = new SizeF(1.25f, 0.2f);
    this.txtSubTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtSubTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotal).DataField = "checkstotal";
    this.txtSubTotal.DistinctField = (string) null;
    this.txtSubTotal.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtSubTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtSubTotal = this.txtSubTotal;
    object obj42 = componentResourceManager.GetObject("txtSubTotal.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) txtSubTotal).Location = pointF42;
    ((ARControl) this.txtSubTotal).Name = "txtSubTotal";
    this.txtSubTotal.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtSubTotal).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount18.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount18).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount18.DistinctField = (string) null;
    this.txtCheckAmount18.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount18.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount18 = this.txtCheckAmount18;
    object obj43 = componentResourceManager.GetObject("txtCheckAmount18.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) txtCheckAmount18).Location = pointF43;
    ((ARControl) this.txtCheckAmount18).Name = "txtCheckAmount18";
    this.txtCheckAmount18.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount18).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount17.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount17).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount17.DistinctField = (string) null;
    this.txtCheckAmount17.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount17.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount17 = this.txtCheckAmount17;
    object obj44 = componentResourceManager.GetObject("txtCheckAmount17.Location");
    PointF pointF44 = obj44 != null ? (PointF) obj44 : new PointF();
    ((ARControl) txtCheckAmount17).Location = pointF44;
    ((ARControl) this.txtCheckAmount17).Name = "txtCheckAmount17";
    this.txtCheckAmount17.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount17).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount16.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount16).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount16.DistinctField = (string) null;
    this.txtCheckAmount16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount16 = this.txtCheckAmount16;
    object obj45 = componentResourceManager.GetObject("txtCheckAmount16.Location");
    PointF pointF45 = obj45 != null ? (PointF) obj45 : new PointF();
    ((ARControl) txtCheckAmount16).Location = pointF45;
    ((ARControl) this.txtCheckAmount16).Name = "txtCheckAmount16";
    this.txtCheckAmount16.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount16).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount15.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount15).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount15.DistinctField = (string) null;
    this.txtCheckAmount15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount15.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount15 = this.txtCheckAmount15;
    object obj46 = componentResourceManager.GetObject("txtCheckAmount15.Location");
    PointF pointF46 = obj46 != null ? (PointF) obj46 : new PointF();
    ((ARControl) txtCheckAmount15).Location = pointF46;
    ((ARControl) this.txtCheckAmount15).Name = "txtCheckAmount15";
    this.txtCheckAmount15.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount15).Size = new SizeF(1.25f, 0.2f);
    this.txtCheckAmount14.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmount14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmount14).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmount14.DistinctField = (string) null;
    this.txtCheckAmount14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmount14.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheckAmount14 = this.txtCheckAmount14;
    object obj47 = componentResourceManager.GetObject("txtCheckAmount14.Location");
    PointF pointF47 = obj47 != null ? (PointF) obj47 : new PointF();
    ((ARControl) txtCheckAmount14).Location = pointF47;
    ((ARControl) this.txtCheckAmount14).Name = "txtCheckAmount14";
    this.txtCheckAmount14.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtCheckAmount14).Size = new SizeF(1.25f, 0.2f);
    this.txtOfficeLocation.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtOfficeLocation).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOfficeLocation).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOfficeLocation).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOfficeLocation).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOfficeLocation).DataField = "locationaddress";
    this.txtOfficeLocation.DistinctField = (string) null;
    this.txtOfficeLocation.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtOfficeLocation.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtOfficeLocation = this.txtOfficeLocation;
    object obj48 = componentResourceManager.GetObject("txtOfficeLocation.Location");
    PointF pointF48 = obj48 != null ? (PointF) obj48 : new PointF();
    ((ARControl) txtOfficeLocation).Location = pointF48;
    ((ARControl) this.txtOfficeLocation).Name = "txtOfficeLocation";
    this.txtOfficeLocation.OutputFormat = (string) null;
    ((ARControl) this.txtOfficeLocation).Size = new SizeF(35f / 16f, 7f / 16f);
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 6f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.Silver;
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj49 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF49 = obj49 != null ? (PointF) obj49 : new PointF();
    ((ARControl) label5).Location = pointF49;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(9f / 16f, 0.125f);
    this.Label5.Text = "SUBTOTAL";
    this.txtMICRAccountNumber.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtMICRAccountNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMICRAccountNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMICRAccountNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMICRAccountNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.txtMICRAccountNumber.DistinctField = (string) null;
    this.txtMICRAccountNumber.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtMICRAccountNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox micrAccountNumber = this.txtMICRAccountNumber;
    object obj50 = componentResourceManager.GetObject("txtMICRAccountNumber.Location");
    PointF pointF50 = obj50 != null ? (PointF) obj50 : new PointF();
    ((ARControl) micrAccountNumber).Location = pointF50;
    ((ARControl) this.txtMICRAccountNumber).Name = "txtMICRAccountNumber";
    this.txtMICRAccountNumber.OutputFormat = (string) null;
    ((ARControl) this.txtMICRAccountNumber).Size = new SizeF(7.625f, 0.2f);
    this.txtMICRAccountNumber.Text = "TextBox16";
    this.Label8.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.Gray;
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj51 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF51 = obj51 != null ? (PointF) obj51 : new PointF();
    ((ARControl) label8).Location = pointF51;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.75f, 7f / 16f);
    this.Label8.Text = "TOTAL NUMBER OF DEPOSITED ITEMS";
    this.Label8.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Shape22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape22).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape22.LineColor = Color.FromArgb(169, 169, 169);
    this.Shape22.LineWeight = 14f;
    Shape shape22 = this.Shape22;
    object obj52 = componentResourceManager.GetObject("Shape22.Location");
    PointF pointF52 = obj52 != null ? (PointF) obj52 : new PointF();
    ((ARControl) shape22).Location = pointF52;
    ((ARControl) this.Shape22).Name = "Shape22";
    ((ARControl) this.Shape22).Size = new SizeF(0.625f, 7f / 16f);
    this.txtNumItems.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtNumItems).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtNumItems).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtNumItems).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtNumItems).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtNumItems).DataField = "numberofchecks";
    this.txtNumItems.DistinctField = (string) null;
    this.txtNumItems.Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtNumItems.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtNumItems = this.txtNumItems;
    object obj53 = componentResourceManager.GetObject("txtNumItems.Location");
    PointF pointF53 = obj53 != null ? (PointF) obj53 : new PointF();
    ((ARControl) txtNumItems).Location = pointF53;
    ((ARControl) this.txtNumItems).Name = "txtNumItems";
    this.txtNumItems.OutputFormat = (string) null;
    ((ARControl) this.txtNumItems).Size = new SizeF(0.5f, 5f / 16f);
    this.txtNumItems.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Shape23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape23).Border.TopStyle = (BorderLineStyle) 0;
    this.Shape23.LineColor = Color.FromArgb(169, 169, 169);
    this.Shape23.LineWeight = 14f;
    Shape shape23 = this.Shape23;
    object obj54 = componentResourceManager.GetObject("Shape23.Location");
    PointF pointF54 = obj54 != null ? (PointF) obj54 : new PointF();
    ((ARControl) shape23).Location = pointF54;
    ((ARControl) this.Shape23).Name = "Shape23";
    ((ARControl) this.Shape23).Size = new SizeF(2f, 7f / 16f);
    this.txtTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal).DataField = "checkstotal";
    this.txtTotal.DistinctField = (string) null;
    this.txtTotal.Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTotal = this.txtTotal;
    object obj55 = componentResourceManager.GetObject("txtTotal.Location");
    PointF pointF55 = obj55 != null ? (PointF) obj55 : new PointF();
    ((ARControl) txtTotal).Location = pointF55;
    ((ARControl) this.txtTotal).Name = "txtTotal";
    this.txtTotal.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtTotal).Size = new SizeF(29f / 16f, 5f / 16f);
    this.txtTotal.VerticalAlignment = (VerticalTextAlignment) 1;
    this.Label9.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Gray;
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj56 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF56 = obj56 != null ? (PointF) obj56 : new PointF();
    ((ARControl) label9).Location = pointF56;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.375f, 0.2f);
    this.Label9.Text = "CASH";
    this.txtBankAddress.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtBankAddress).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBankAddress).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBankAddress).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBankAddress).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBankAddress).DataField = "bankaddress";
    this.txtBankAddress.DistinctField = (string) null;
    this.txtBankAddress.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtBankAddress.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtBankAddress = this.txtBankAddress;
    object obj57 = componentResourceManager.GetObject("txtBankAddress.Location");
    PointF pointF57 = obj57 != null ? (PointF) obj57 : new PointF();
    ((ARControl) txtBankAddress).Location = pointF57;
    ((ARControl) this.txtBankAddress).Name = "txtBankAddress";
    this.txtBankAddress.OutputFormat = (string) null;
    ((ARControl) this.txtBankAddress).Size = new SizeF(2.25f, 7f / 16f);
    this.Line45.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line45.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line45.Border.RightStyle = (BorderLineStyle) 0;
    this.Line45.Border.TopStyle = (BorderLineStyle) 0;
    this.Line45.LineStyle = (LineStyle) 2;
    this.Line45.LineWeight = 1f;
    ((ARControl) this.Line45).Name = "Line45";
    this.Line45.X1 = 8.125f;
    this.Line45.X2 = 0.0f;
    this.Line45.Y1 = 47f / 16f;
    this.Line45.Y2 = 47f / 16f;
    this.TextBox18.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).DataField = "officelocation";
    this.TextBox18.DistinctField = (string) null;
    this.TextBox18.Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox18.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox18 = this.TextBox18;
    object obj58 = componentResourceManager.GetObject("TextBox18.Location");
    PointF pointF58 = obj58 != null ? (PointF) obj58 : new PointF();
    ((ARControl) textBox18).Location = pointF58;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = (string) null;
    ((ARControl) this.TextBox18).Size = new SizeF(35f / 16f, 0.2f);
    this.TextBox18.VerticalAlignment = (VerticalTextAlignment) 2;
    this.TextBox19.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).DataField = "bankname";
    this.TextBox19.DistinctField = (string) null;
    this.TextBox19.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox19.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox19 = this.TextBox19;
    object obj59 = componentResourceManager.GetObject("TextBox19.Location");
    PointF pointF59 = obj59 != null ? (PointF) obj59 : new PointF();
    ((ARControl) textBox19).Location = pointF59;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = (string) null;
    ((ARControl) this.TextBox19).Size = new SizeF(2.25f, 3f / 16f);
    this.TextBox19.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label12.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj60 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF60 = obj60 != null ? (PointF) obj60 : new PointF();
    ((ARControl) label12).Location = pointF60;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(1.25f, 3f / 16f);
    this.Label12.Text = "$0.00";
    this.lblSeeAttached.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblSeeAttached).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeAttached).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeAttached).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeAttached).Border.TopStyle = (BorderLineStyle) 0;
    this.lblSeeAttached.Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblSeeAttached.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblSeeAttached.HyperLink = (string) null;
    Label lblSeeAttached = this.lblSeeAttached;
    object obj61 = componentResourceManager.GetObject("lblSeeAttached.Location");
    PointF pointF61 = obj61 != null ? (PointF) obj61 : new PointF();
    ((ARControl) lblSeeAttached).Location = pointF61;
    ((ARControl) this.lblSeeAttached).Name = "lblSeeAttached";
    ((ARControl) this.lblSeeAttached).Size = new SizeF(91f / 16f, 29f / 16f);
    this.lblSeeAttached.Text = "See Attached";
    this.lblSeeAttached.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.SubReport1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport1).Border.TopStyle = (BorderLineStyle) 0;
    this.SubReport1.CloseBorder = false;
    SubReport subReport1 = this.SubReport1;
    object obj62 = componentResourceManager.GetObject("SubReport1.Location");
    PointF pointF62 = obj62 != null ? (PointF) obj62 : new PointF();
    ((ARControl) subReport1).Location = pointF62;
    ((ARControl) this.SubReport1).Name = "SubReport1";
    this.SubReport1.Report = (SectionReport) null;
    ((ARControl) this.SubReport1).Size = new SizeF(8f, 0.125f);
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.2f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.041667f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.txtCashAmount).EndInit();
    ((ISupportInitialize) this.txtCheckAmount1).EndInit();
    ((ISupportInitialize) this.txtCheckAmount2).EndInit();
    ((ISupportInitialize) this.txtCheckAmount3).EndInit();
    ((ISupportInitialize) this.txtCheckAmount4).EndInit();
    ((ISupportInitialize) this.txtCheckAmount5).EndInit();
    ((ISupportInitialize) this.txtCheckAmount6).EndInit();
    ((ISupportInitialize) this.txtCheckAmount13).EndInit();
    ((ISupportInitialize) this.txtCheckAmount12).EndInit();
    ((ISupportInitialize) this.txtCheckAmount11).EndInit();
    ((ISupportInitialize) this.txtCheckAmount10).EndInit();
    ((ISupportInitialize) this.txtCheckAmount9).EndInit();
    ((ISupportInitialize) this.txtCheckAmount8).EndInit();
    ((ISupportInitialize) this.txtCheckAmount7).EndInit();
    ((ISupportInitialize) this.txtSubTotal).EndInit();
    ((ISupportInitialize) this.txtCheckAmount18).EndInit();
    ((ISupportInitialize) this.txtCheckAmount17).EndInit();
    ((ISupportInitialize) this.txtCheckAmount16).EndInit();
    ((ISupportInitialize) this.txtCheckAmount15).EndInit();
    ((ISupportInitialize) this.txtCheckAmount14).EndInit();
    ((ISupportInitialize) this.txtOfficeLocation).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtMICRAccountNumber).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.txtNumItems).EndInit();
    ((ISupportInitialize) this.txtTotal).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtBankAddress).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.lblSeeAttached).EndInit();
  }

  private void BuildCheckAmountMatrix()
  {
    int num = 1;
    if (this.checkTbl.Rows.Count <= 18)
    {
      ((ARControl) this.lblSeeAttached).Visible = false;
      try
      {
        foreach (DataRow row in this.checkTbl.Rows)
        {
          switch (num)
          {
            case 1:
              this.txtCheckAmount1.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 2:
              this.txtCheckAmount2.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 3:
              this.txtCheckAmount3.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 4:
              this.txtCheckAmount4.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 5:
              this.txtCheckAmount5.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 6:
              this.txtCheckAmount6.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 7:
              this.txtCheckAmount7.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 8:
              this.txtCheckAmount8.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 9:
              this.txtCheckAmount9.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 10:
              this.txtCheckAmount10.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 11:
              this.txtCheckAmount11.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 12:
              this.txtCheckAmount12.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 13:
              this.txtCheckAmount13.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 14:
              this.txtCheckAmount14.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 15:
              this.txtCheckAmount15.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 16 /*0x10*/:
              this.txtCheckAmount16.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 17:
              this.txtCheckAmount17.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
            case 18:
              this.txtCheckAmount18.Text = Strings.Format((object) Conversions.ToDecimal(row["amount"]), "Currency");
              break;
          }
          ++num;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
      ((ARControl) this.lblSeeAttached).Visible = true;
  }

  private void rptBankDepositTicket_ReportStart(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{F0B7BA7B-AB2D-4ac8-A7AE-DC57991D3E3B}"))
    {
      Utility.DenyAccess();
      this.Cancel();
    }
    rptBankDepositTicketDetail depositTicketDetail = new rptBankDepositTicketDetail();
    depositTicketDetail.DataSource = (object) this.detailTbl;
    this.SubReport1.Report = (SectionReport) depositTicketDetail;
    this.BuildMICR13AccountInformation();
    this.BuildCheckAmountMatrix();
  }

  private void BuildMICR13AccountInformation()
  {
    this.txtMICRAccountNumber.Text = $"A{this.headerTbl.Rows[0]["abaroutenum"].ToString()}A{Strings.Space(4)}C{this.headerTbl.Rows[0]["bankacctnum"].ToString().Replace("-", "D")}C{Strings.Space(4)}{this.headerTbl.Rows[0]["depositslipsuffix"].ToString()}";
    this.txtMICRAccountNumber.Font = new Font("MICR E13B 2.1", 12f);
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
