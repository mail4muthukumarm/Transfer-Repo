// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.Check_Standard
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class Check_Standard : SectionReport
{
  private DataTable dataTbl;
  private int _transactionNumber;
  private bool _isOperating;
  private Label Label14;
  private TextBox txtCheckDate2;
  private Label Label7;
  private TextBox txtCheckDate;
  private Label Label1;
  private Label Label2;
  private TextBox txtPayee;
  private Label Label6;
  private TextBox txtMemo;
  private TextBox txtSignature;
  private TextBox txtAmountEnglish;
  private Label Label5;
  private Label Label4;
  private Line Line1;
  private Label Label3;
  private Shape Shape1;
  private Line Line2;
  private Line Line3;
  private Line Line4;
  private Line Line7;
  private TextBox txtCheckNumber;
  private TextBox txtAmountCurrency;
  private TextBox txtE13BCheckNumber;
  private Label Label8;
  private Label Label9;
  private TextBox txtPayee2;
  private Line Line8;
  private Label Label13;
  private Shape Shape2;
  private Line Line12;
  private TextBox txtCheckNumber2;
  private TextBox txtAmountCurrency2;
  private Label lblBankName;
  private Label lblBankAddress;
  private Label Label15;
  private Label Label16;
  private Label lblFractionalTransitNum;
  private SubReport SubReport1;
  private Label transactNum;
  private Label Label17;
  private Label Label18;
  private Label Label19;
  private Line Line14;
  private TextBox txtE13BRoutingNumber;
  private TextBox txtE13BAccountNumber;
  private TextBox txtE13BAmount;

  public Check_Standard(DataTable datTable)
  {
    this.ReportStart += new EventHandler(this.Check_Standard_ReportStart);
    this.dataTbl = new DataTable();
    this.InitializeComponent();
    this.dataTbl = datTable;
    this.SetDataFields();
  }

  public Check_Standard(DataView datView)
  {
    this.ReportStart += new EventHandler(this.Check_Standard_ReportStart);
    this.dataTbl = new DataTable();
    this.InitializeComponent();
    this.DataSource = (object) datView;
    this.SetDataFields();
  }

  public Check_Standard(int transactionNumber, bool isOperating)
  {
    this.ReportStart += new EventHandler(this.Check_Standard_ReportStart);
    this.dataTbl = new DataTable();
    this.InitializeComponent();
    this._transactionNumber = transactionNumber;
    this._isOperating = isOperating;
    this.SetDataFields();
    this.GetCheckHeader();
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (Check_Standard));
    this.Detail = new Detail();
    this.Label14 = new Label();
    this.txtCheckDate2 = new TextBox();
    this.Label7 = new Label();
    this.txtCheckDate = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.txtPayee = new TextBox();
    this.Label6 = new Label();
    this.txtMemo = new TextBox();
    this.txtSignature = new TextBox();
    this.txtAmountEnglish = new TextBox();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Line1 = new Line();
    this.Label3 = new Label();
    this.Shape1 = new Shape();
    this.Line2 = new Line();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line7 = new Line();
    this.txtCheckNumber = new TextBox();
    this.txtAmountCurrency = new TextBox();
    this.txtE13BCheckNumber = new TextBox();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.txtPayee2 = new TextBox();
    this.Line8 = new Line();
    this.Label13 = new Label();
    this.Shape2 = new Shape();
    this.Line12 = new Line();
    this.txtCheckNumber2 = new TextBox();
    this.txtAmountCurrency2 = new TextBox();
    this.lblBankName = new Label();
    this.lblBankAddress = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.lblFractionalTransitNum = new Label();
    this.SubReport1 = new SubReport();
    this.transactNum = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label19 = new Label();
    this.Line14 = new Line();
    this.txtE13BRoutingNumber = new TextBox();
    this.txtE13BAccountNumber = new TextBox();
    this.txtE13BAmount = new TextBox();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.txtCheckDate2).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtCheckDate).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.txtPayee).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.txtMemo).BeginInit();
    ((ISupportInitialize) this.txtSignature).BeginInit();
    ((ISupportInitialize) this.txtAmountEnglish).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.txtCheckNumber).BeginInit();
    ((ISupportInitialize) this.txtAmountCurrency).BeginInit();
    ((ISupportInitialize) this.txtE13BCheckNumber).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtPayee2).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.txtCheckNumber2).BeginInit();
    ((ISupportInitialize) this.txtAmountCurrency2).BeginInit();
    ((ISupportInitialize) this.lblBankName).BeginInit();
    ((ISupportInitialize) this.lblBankAddress).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.lblFractionalTransitNum).BeginInit();
    ((ISupportInitialize) this.transactNum).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.txtE13BRoutingNumber).BeginInit();
    ((ISupportInitialize) this.txtE13BAccountNumber).BeginInit();
    ((ISupportInitialize) this.txtE13BAmount).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[46]
    {
      (ARControl) this.Label14,
      (ARControl) this.txtCheckDate2,
      (ARControl) this.Label7,
      (ARControl) this.txtCheckDate,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.txtPayee,
      (ARControl) this.Label6,
      (ARControl) this.txtMemo,
      (ARControl) this.txtSignature,
      (ARControl) this.txtAmountEnglish,
      (ARControl) this.Label5,
      (ARControl) this.Label4,
      (ARControl) this.Line1,
      (ARControl) this.Label3,
      (ARControl) this.Shape1,
      (ARControl) this.Line2,
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.Line7,
      (ARControl) this.txtCheckNumber,
      (ARControl) this.txtAmountCurrency,
      (ARControl) this.txtE13BCheckNumber,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.txtPayee2,
      (ARControl) this.Line8,
      (ARControl) this.Label13,
      (ARControl) this.Shape2,
      (ARControl) this.Line12,
      (ARControl) this.txtCheckNumber2,
      (ARControl) this.txtAmountCurrency2,
      (ARControl) this.lblBankName,
      (ARControl) this.lblBankAddress,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.lblFractionalTransitNum,
      (ARControl) this.SubReport1,
      (ARControl) this.transactNum,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.Label19,
      (ARControl) this.Line14,
      (ARControl) this.txtE13BRoutingNumber,
      (ARControl) this.txtE13BAccountNumber,
      (ARControl) this.txtE13BAmount
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 10.385f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 97f / 16f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 0";
    this.Label14.Text = "DATE";
    ((ARControl) this.Label14).Top = 7.625f;
    ((ARControl) this.Label14).Width = 7f / 16f;
    ((ARControl) this.txtCheckDate2).DataField = "CheckDate";
    ((ARControl) this.txtCheckDate2).Height = 3f / 16f;
    ((ARControl) this.txtCheckDate2).Left = 6.5f;
    ((ARControl) this.txtCheckDate2).Name = "txtCheckDate2";
    this.txtCheckDate2.OutputFormat = resourceManager.GetString("txtCheckDate2.OutputFormat");
    this.txtCheckDate2.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; ddo-char-set: 0";
    this.txtCheckDate2.Text = (string) null;
    ((ARControl) this.txtCheckDate2).Top = 7.625f;
    ((ARControl) this.txtCheckDate2).Width = 1.125f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 6.112f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label7.Text = "DATE";
    ((ARControl) this.Label7).Top = 0.645f;
    ((ARControl) this.Label7).Width = 7f / 16f;
    ((ARControl) this.txtCheckDate).DataField = "CheckDate";
    ((ARControl) this.txtCheckDate).Height = 3f / 16f;
    ((ARControl) this.txtCheckDate).Left = 6.438f;
    ((ARControl) this.txtCheckDate).Name = "txtCheckDate";
    this.txtCheckDate.OutputFormat = resourceManager.GetString("txtCheckDate.OutputFormat");
    this.txtCheckDate.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; ddo-char-set: 0";
    this.txtCheckDate.Text = (string) null;
    ((ARControl) this.txtCheckDate).Top = 0.645f;
    ((ARControl) this.txtCheckDate).Width = 1.25f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.187f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-weight: bold; ddo-char-set: 0";
    this.Label1.Text = "P";
    ((ARControl) this.Label1).Top = 1.166f;
    ((ARControl) this.Label1).Width = 0.125f;
    ((ARControl) this.Label2).Height = 0.125f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.28f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 7pt";
    this.Label2.Text = "AY TO THE ORDER OF";
    ((ARControl) this.Label2).Top = 1.222f;
    ((ARControl) this.Label2).Width = 1.375f;
    ((ARControl) this.txtPayee).DataField = "Payee";
    ((ARControl) this.txtPayee).Height = 3f / 16f;
    ((ARControl) this.txtPayee).Left = 1.437f;
    ((ARControl) this.txtPayee).Name = "txtPayee";
    this.txtPayee.Style = "font-size: 9pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.txtPayee.Text = (string) null;
    ((ARControl) this.txtPayee).Top = 1.159f;
    ((ARControl) this.txtPayee).Width = 3.9875f;
    ((ARControl) this.Label6).Height = 0.125f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.25f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 6pt; ddo-char-set: 0";
    this.Label6.Text = "FOR";
    ((ARControl) this.Label6).Top = 2.5f;
    ((ARControl) this.Label6).Width = 0.625f;
    ((ARControl) this.txtMemo).DataField = "CHECKMEMO";
    ((ARControl) this.txtMemo).Height = 0.1770003f;
    ((ARControl) this.txtMemo).Left = 0.562f;
    ((ARControl) this.txtMemo).Name = "txtMemo";
    this.txtMemo.Style = "font-size: 9pt; vertical-align: bottom; ddo-char-set: 0";
    ((ARControl) this.txtMemo).Top = 2.448f;
    ((ARControl) this.txtMemo).Width = 3.446f;
    ((ARControl) this.txtSignature).Height = 7f / 16f;
    ((ARControl) this.txtSignature).Left = 4.702f;
    ((ARControl) this.txtSignature).Name = "txtSignature";
    this.txtSignature.Style = "font-weight: bold; text-align: center; vertical-align: bottom; ddo-char-set: 0";
    this.txtSignature.Text = (string) null;
    ((ARControl) this.txtSignature).Top = 2.188f;
    ((ARControl) this.txtSignature).Width = 2.993056f;
    ((ARControl) this.txtAmountEnglish).DataField = "Amountenglish";
    ((ARControl) this.txtAmountEnglish).Height = 3f / 16f;
    ((ARControl) this.txtAmountEnglish).Left = 0.1995f;
    this.txtAmountEnglish.MultiLine = false;
    ((ARControl) this.txtAmountEnglish).Name = "txtAmountEnglish";
    this.txtAmountEnglish.Style = "font-size: 9pt; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.txtAmountEnglish.Text = "Thiry-Five Thousand and 20 dollars and 70/100";
    ((ARControl) this.txtAmountEnglish).Top = 1.4865f;
    ((ARControl) this.txtAmountEnglish).Width = 7.443056f;
    ((ARControl) this.Label5).Height = 0.1240001f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 6.076f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 6pt; text-align: right; ddo-char-set: 0";
    this.Label5.Text = "AUTHORIZED SIGNATURE";
    ((ARControl) this.Label5).Top = 2.626f;
    ((ARControl) this.Label5).Width = 1.611111f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 7.068945f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label4.Text = "Dollars";
    ((ARControl) this.Label4).Top = 1.479f;
    ((ARControl) this.Label4).Visible = false;
    ((ARControl) this.Label4).Width = 9f / 16f;
    ((ARControl) this.Line1).Height = 0.0004439354f;
    ((ARControl) this.Line1).Left = 1.362f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 1.353f;
    ((ARControl) this.Line1).Width = 77f / 16f;
    this.Line1.X1 = 1.362f;
    this.Line1.X2 = 6.1745f;
    this.Line1.Y1 = 1.353f;
    this.Line1.Y2 = 1.353444f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 5.4245f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold; ddo-char-set: 0";
    this.Label3.Text = "$";
    ((ARControl) this.Label3).Top = 1.159f;
    ((ARControl) this.Label3).Width = 3f / 16f;
    ((ARControl) this.Shape1).Height = 0.25f;
    ((ARControl) this.Shape1).Left = 5.5495f;
    ((ARControl) this.Shape1).Name = "Shape1";
    this.Shape1.RoundingRadius = new CornersRadius(new float?(9.999999f));
    ((ARControl) this.Shape1).Top = 1.104f;
    ((ARControl) this.Shape1).Width = 2.125f;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 0.1939444f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 1.6665f;
    ((ARControl) this.Line2).Width = 7.430555f;
    this.Line2.X1 = 7.6245f;
    this.Line2.X2 = 0.1939444f;
    this.Line2.Y1 = 1.6665f;
    this.Line2.Y2 = 1.6665f;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 4.694056f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 2.626f;
    ((ARControl) this.Line3).Width = 2.993054f;
    this.Line3.X1 = 4.694056f;
    this.Line3.X2 = 7.68711f;
    this.Line3.Y1 = 2.626f;
    this.Line3.Y2 = 2.626f;
    ((ARControl) this.Line4).Height = 0.0009999275f;
    ((ARControl) this.Line4).Left = 0.4995005f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 2.625f;
    ((ARControl) this.Line4).Width = 3.5085f;
    this.Line4.X1 = 4.008f;
    this.Line4.X2 = 0.4995005f;
    this.Line4.Y1 = 2.626f;
    this.Line4.Y2 = 2.625f;
    ((ARControl) this.Line7).Height = 0.0f;
    ((ARControl) this.Line7).Left = 6.438f;
    this.Line7.LineWeight = 1f;
    ((ARControl) this.Line7).Name = "Line7";
    ((ARControl) this.Line7).Top = 0.8330001f;
    ((ARControl) this.Line7).Width = 1.25f;
    this.Line7.X1 = 6.438f;
    this.Line7.X2 = 7.688f;
    this.Line7.Y1 = 0.8330001f;
    this.Line7.Y2 = 0.8330001f;
    ((ARControl) this.txtCheckNumber).DataField = "CheckNum";
    ((ARControl) this.txtCheckNumber).Height = 0.25f;
    ((ARControl) this.txtCheckNumber).Left = 5.875f;
    ((ARControl) this.txtCheckNumber).Name = "txtCheckNumber";
    this.txtCheckNumber.Style = "font-size: 11pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    ((ARControl) this.txtCheckNumber).Top = 0.083f;
    ((ARControl) this.txtCheckNumber).Width = 29f / 16f;
    ((ARControl) this.txtAmountCurrency).Height = 3f / 16f;
    ((ARControl) this.txtAmountCurrency).Left = 5.612f;
    ((ARControl) this.txtAmountCurrency).Name = "txtAmountCurrency";
    this.txtAmountCurrency.OutputFormat = resourceManager.GetString("txtAmountCurrency.OutputFormat");
    this.txtAmountCurrency.Style = "font-size: 9pt; text-align: right; ddo-char-set: 0";
    this.txtAmountCurrency.Text = (string) null;
    ((ARControl) this.txtAmountCurrency).Top = 1.139f;
    ((ARControl) this.txtAmountCurrency).Width = 2f;
    ((ARControl) this.txtE13BCheckNumber).Height = 0.25f;
    ((ARControl) this.txtE13BCheckNumber).Left = 0.28f;
    ((ARControl) this.txtE13BCheckNumber).Name = "txtE13BCheckNumber";
    this.txtE13BCheckNumber.Style = "font-family: Microsoft Sans Serif; font-size: 12pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtE13BCheckNumber.Text = "TextBox1";
    ((ARControl) this.txtE13BCheckNumber).Top = 3f;
    ((ARControl) this.txtE13BCheckNumber).Width = 37f / 16f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.125f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-weight: bold; ddo-char-set: 0";
    this.Label8.Text = "P";
    ((ARControl) this.Label8).Top = 129f / 16f;
    ((ARControl) this.Label8).Width = 0.125f;
    ((ARControl) this.Label9).Height = 0.125f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.205f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 7pt";
    this.Label9.Text = "AY TO THE ORDER OF";
    ((ARControl) this.Label9).Top = 8.1175f;
    ((ARControl) this.Label9).Width = 1.375f;
    ((ARControl) this.txtPayee2).DataField = "Payee";
    ((ARControl) this.txtPayee2).Height = 3f / 16f;
    ((ARControl) this.txtPayee2).Left = 23f / 16f;
    ((ARControl) this.txtPayee2).Name = "txtPayee2";
    this.txtPayee2.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.txtPayee2.Text = (string) null;
    ((ARControl) this.txtPayee2).Top = 129f / 16f;
    ((ARControl) this.txtPayee2).Width = 63f / 16f;
    ((ARControl) this.Line8).Height = 0.0004453659f;
    ((ARControl) this.Line8).Left = 1.3f;
    this.Line8.LineWeight = 1f;
    ((ARControl) this.Line8).Name = "Line8";
    ((ARControl) this.Line8).Top = 8.249f;
    ((ARControl) this.Line8).Width = 77f / 16f;
    this.Line8.X1 = 1.3f;
    this.Line8.X2 = 6.1125f;
    this.Line8.Y1 = 8.249f;
    this.Line8.Y2 = 8.249445f;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 5.3625f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-weight: bold; ddo-char-set: 0";
    this.Label13.Text = "$";
    ((ARControl) this.Label13).Top = 8.055f;
    ((ARControl) this.Label13).Width = 3f / 16f;
    ((ARControl) this.Shape2).Height = 0.25f;
    ((ARControl) this.Shape2).Left = 5.4875f;
    ((ARControl) this.Shape2).Name = "Shape2";
    this.Shape2.RoundingRadius = new CornersRadius(new float?(9.999999f));
    ((ARControl) this.Shape2).Top = 8f;
    ((ARControl) this.Shape2).Width = 2.125f;
    ((ARControl) this.Line12).Height = 0.0f;
    ((ARControl) this.Line12).Left = 6.375f;
    this.Line12.LineWeight = 1f;
    ((ARControl) this.Line12).Name = "Line12";
    ((ARControl) this.Line12).Top = 125f / 16f;
    ((ARControl) this.Line12).Width = 1.25f;
    this.Line12.X1 = 6.375f;
    this.Line12.X2 = 7.625f;
    this.Line12.Y1 = 125f / 16f;
    this.Line12.Y2 = 125f / 16f;
    ((ARControl) this.txtCheckNumber2).DataField = "CheckNum";
    ((ARControl) this.txtCheckNumber2).Height = 0.25f;
    ((ARControl) this.txtCheckNumber2).Left = 93f / 16f;
    ((ARControl) this.txtCheckNumber2).Name = "txtCheckNumber2";
    this.txtCheckNumber2.Style = "font-size: 11pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtCheckNumber2.Text = (string) null;
    ((ARControl) this.txtCheckNumber2).Top = 7.25f;
    ((ARControl) this.txtCheckNumber2).Width = 29f / 16f;
    ((ARControl) this.txtAmountCurrency2).Height = 3f / 16f;
    ((ARControl) this.txtAmountCurrency2).Left = 5.55f;
    ((ARControl) this.txtAmountCurrency2).Name = "txtAmountCurrency2";
    this.txtAmountCurrency2.OutputFormat = resourceManager.GetString("txtAmountCurrency2.OutputFormat");
    this.txtAmountCurrency2.Style = "font-size: 9pt; text-align: right; ddo-char-set: 0";
    this.txtAmountCurrency2.Text = (string) null;
    ((ARControl) this.txtAmountCurrency2).Top = 8.035f;
    ((ARControl) this.txtAmountCurrency2).Width = 2f;
    ((ARControl) this.lblBankName).Height = 0.2079999f;
    this.lblBankName.HyperLink = (string) null;
    ((ARControl) this.lblBankName).Left = 0.7495f;
    ((ARControl) this.lblBankName).Name = "lblBankName";
    this.lblBankName.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.lblBankName.Text = "";
    ((ARControl) this.lblBankName).Top = 1.729f;
    ((ARControl) this.lblBankName).Width = 4.625f;
    ((ARControl) this.lblBankAddress).Height = 0.5105002f;
    this.lblBankAddress.HyperLink = (string) null;
    ((ARControl) this.lblBankAddress).Left = 0.75f;
    ((ARControl) this.lblBankAddress).Name = "lblBankAddress";
    this.lblBankAddress.Style = "font-size: 8pt; ddo-char-set: 0";
    this.lblBankAddress.Text = "";
    ((ARControl) this.lblBankAddress).Top = 31f / 16f;
    ((ARControl) this.lblBankAddress).Width = 3.258f;
    ((ARControl) this.Label15).DataField = "MGANAME";
    ((ARControl) this.Label15).Height = 0.25f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 0.7500001f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label15.Text = "";
    ((ARControl) this.Label15).Top = 0.177f;
    ((ARControl) this.Label15).Width = 3.75f;
    ((ARControl) this.Label16).DataField = "MGAADDRESS";
    ((ARControl) this.Label16).Height = 0.625f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 0.7550001f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 9pt; ddo-char-set: 0";
    this.Label16.Text = "";
    ((ARControl) this.Label16).Top = 0.427f;
    ((ARControl) this.Label16).Width = 3.125f;
    ((ARControl) this.lblFractionalTransitNum).DataField = "ABAFractionalTransitNum";
    ((ARControl) this.lblFractionalTransitNum).Height = 3f / 16f;
    this.lblFractionalTransitNum.HyperLink = (string) null;
    ((ARControl) this.lblFractionalTransitNum).Left = 6.487f;
    ((ARControl) this.lblFractionalTransitNum).Name = "lblFractionalTransitNum";
    this.lblFractionalTransitNum.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.lblFractionalTransitNum.Text = "";
    ((ARControl) this.lblFractionalTransitNum).Top = 0.333f;
    ((ARControl) this.lblFractionalTransitNum).Width = 19f / 16f;
    this.SubReport1.CanGrow = false;
    this.SubReport1.CanShrink = false;
    this.SubReport1.CloseBorder = false;
    this.SubReport1.DataField = "transactnum";
    ((ARControl) this.SubReport1).Height = 3.375f;
    ((ARControl) this.SubReport1).Left = 0.125f;
    ((ARControl) this.SubReport1).Name = "SubReport1";
    this.SubReport1.Report = (SectionReport) null;
    ((ARControl) this.SubReport1).Top = 3.625f;
    ((ARControl) this.SubReport1).Width = 125f / 16f;
    ((ARControl) this.transactNum).DataField = "transactnum";
    ((ARControl) this.transactNum).Height = 0.0f;
    this.transactNum.HyperLink = (string) null;
    ((ARControl) this.transactNum).Left = 0.375f;
    ((ARControl) this.transactNum).Name = "transactNum";
    this.transactNum.Style = "ddo-char-set: 0";
    this.transactNum.Text = "";
    ((ARControl) this.transactNum).Top = 53f / 16f;
    ((ARControl) this.transactNum).Visible = false;
    ((ARControl) this.transactNum).Width = 9f / 16f;
    ((ARControl) this.Label17).DataField = "MGANAME";
    ((ARControl) this.Label17).Height = 0.25f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 11f / 16f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label17.Text = "";
    ((ARControl) this.Label17).Top = 7.125f;
    ((ARControl) this.Label17).Width = 3.75f;
    ((ARControl) this.Label18).DataField = "MGAADDRESS";
    ((ARControl) this.Label18).Height = 0.6174995f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 0.6925f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 9pt; ddo-char-set: 0";
    this.Label18.Text = "";
    ((ARControl) this.Label18).Top = 7.375f;
    ((ARControl) this.Label18).Width = 3.125f;
    ((ARControl) this.Label19).Height = 5f / 16f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 0.125f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "color: Gray; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label19.Text = "Non-Transferable. This Is Not A Check.";
    ((ARControl) this.Label19).Top = 9.5f;
    ((ARControl) this.Label19).Width = 121f / 16f;
    ((ARControl) this.Line14).Height = 0.0f;
    ((ARControl) this.Line14).Left = 0.125f;
    this.Line14.LineColor = Color.FromArgb(105, 105, 105);
    this.Line14.LineStyle = (LineStyle) 2;
    this.Line14.LineWeight = 1f;
    ((ARControl) this.Line14).Name = "Line14";
    ((ARControl) this.Line14).Top = 57f / 16f;
    ((ARControl) this.Line14).Width = 121f / 16f;
    this.Line14.X1 = 123f / 16f;
    this.Line14.X2 = 0.125f;
    this.Line14.Y1 = 57f / 16f;
    this.Line14.Y2 = 57f / 16f;
    ((ARControl) this.txtE13BRoutingNumber).Height = 0.25f;
    ((ARControl) this.txtE13BRoutingNumber).Left = 2.69f;
    ((ARControl) this.txtE13BRoutingNumber).Name = "txtE13BRoutingNumber";
    this.txtE13BRoutingNumber.Style = "font-family: Microsoft Sans Serif; font-size: 12pt; vertical-align: middle; ddo-char-set: 0";
    this.txtE13BRoutingNumber.Text = "TextBox1";
    ((ARControl) this.txtE13BRoutingNumber).Top = 3f;
    ((ARControl) this.txtE13BRoutingNumber).Width = 1.438f;
    ((ARControl) this.txtE13BAccountNumber).Height = 0.25f;
    ((ARControl) this.txtE13BAccountNumber).Left = 4.2f;
    ((ARControl) this.txtE13BAccountNumber).Name = "txtE13BAccountNumber";
    this.txtE13BAccountNumber.Style = "font-family: Microsoft Sans Serif; font-size: 12pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtE13BAccountNumber.Text = "TextBox1";
    ((ARControl) this.txtE13BAccountNumber).Top = 3f;
    ((ARControl) this.txtE13BAccountNumber).Width = 1.75f;
    ((ARControl) this.txtE13BAmount).Height = 0.25f;
    ((ARControl) this.txtE13BAmount).Left = 6.313f;
    ((ARControl) this.txtE13BAmount).Name = "txtE13BAmount";
    this.txtE13BAmount.Style = "font-family: Microsoft Sans Serif; font-size: 12pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtE13BAmount.Text = "TextBox1";
    ((ARControl) this.txtE13BAmount).Top = 3f;
    ((ARControl) this.txtE13BAmount).Visible = false;
    ((ARControl) this.txtE13BAmount).Width = 1.375f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.1f;
    this.PageSettings.Margins.Left = 0.1f;
    this.PageSettings.Margins.Right = 0.1f;
    this.PageSettings.Margins.Top = 0.1f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.145833f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.txtCheckDate2).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtCheckDate).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.txtPayee).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.txtMemo).EndInit();
    ((ISupportInitialize) this.txtSignature).EndInit();
    ((ISupportInitialize) this.txtAmountEnglish).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.txtCheckNumber).EndInit();
    ((ISupportInitialize) this.txtAmountCurrency).EndInit();
    ((ISupportInitialize) this.txtE13BCheckNumber).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtPayee2).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.txtCheckNumber2).EndInit();
    ((ISupportInitialize) this.txtAmountCurrency2).EndInit();
    ((ISupportInitialize) this.lblBankName).EndInit();
    ((ISupportInitialize) this.lblBankAddress).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.lblFractionalTransitNum).EndInit();
    ((ISupportInitialize) this.transactNum).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.txtE13BRoutingNumber).EndInit();
    ((ISupportInitialize) this.txtE13BAccountNumber).EndInit();
    ((ISupportInitialize) this.txtE13BAmount).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void SetDataFields()
  {
    ((ARControl) this.txtPayee).DataField = "Payee";
    ((ARControl) this.txtCheckNumber).DataField = "CheckNum";
    ((ARControl) this.txtCheckDate).DataField = "CheckDate";
    ((ARControl) this.txtAmountEnglish).DataField = "AmountEnglish";
    ((ARControl) this.txtAmountCurrency).DataField = "AmountCurrency";
    ((ARControl) this.txtPayee2).DataField = "Payee";
    ((ARControl) this.txtCheckNumber2).DataField = "CheckNum";
    ((ARControl) this.txtCheckDate2).DataField = "CheckDate";
    ((ARControl) this.txtAmountCurrency2).DataField = "AmountCurrency";
    ((ARControl) this.lblBankName).DataField = "BankName";
    ((ARControl) this.lblBankAddress).DataField = "BankAddress";
    ((ARControl) this.txtE13BCheckNumber).DataField = "E13BCheck";
    ((ARControl) this.txtE13BRoutingNumber).DataField = "E13BRouting";
    ((ARControl) this.txtE13BAccountNumber).DataField = "E13BAccount";
    ((ARControl) this.txtE13BAmount).DataField = "E13BAmount";
  }

  private void Check_Standard_ReportStart(object sender, EventArgs e)
  {
    this.txtE13BCheckNumber.Font = new Font("MICR E13B 2.1", 12f);
    this.txtE13BRoutingNumber.Font = new Font("MICR E13B 2.1", 12f);
    this.txtE13BAccountNumber.Font = new Font("MICR E13B 2.1", 12f);
    this.txtE13BAmount.Font = new Font("MICR E13B 2.1", 12f);
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this._isOperating)
      this.SubReport1.Report = (SectionReport) new CheckDetail_Operating(this._transactionNumber);
    else
      this.SubReport1.Report = (SectionReport) new CheckDetail(this._transactionNumber);
  }

  private void GetCheckHeader()
  {
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetCheckHeader", (object) "@transactionNumber", (object) this._transactionNumber);
    dataTable.Rows[0]["AmountEnglish"] = (object) CheckPrintingServices.ConvertNumericToEnglish(Decimal.Parse(dataTable.Rows[0]["AmountCurrency"].ToString()));
    dataTable.Rows[0]["E13BCheck"] = (object) CheckPrintingServices.CreateE13BCheckNumber(dataTable.Rows[0]["CheckNum"].ToString());
    dataTable.Rows[0]["E13BRouting"] = (object) CheckPrintingServices.CreateE13BRoutingNumber(dataTable.Rows[0]["E13BRouting"].ToString());
    dataTable.Rows[0]["E13BAccount"] = (object) CheckPrintingServices.CreateE13BAccountNumber(dataTable.Rows[0]["E13BAccount"].ToString());
    dataTable.Rows[0]["E13BAmount"] = (object) CheckPrintingServices.CreateE13BAmount(dataTable.Rows[0]["AmountCurrency"].ToString());
    this.DataSource = (object) dataTable;
  }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler;
    }
  }
}
