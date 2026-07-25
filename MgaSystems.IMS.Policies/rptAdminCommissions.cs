// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.rptAdminCommissions
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.IMS.Reporting;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class rptAdminCommissions : MGAReport
{
  private IContainer components;
  private Label Label1;
  private Label Label24;
  private Label Label25;
  private Label Label26;
  private Label Label41;
  private Label Label42;
  private Label Label43;
  private Label Label44;
  private Label Label45;
  private Label Label46;
  private Label Label47;
  private Label Label52;
  private DataTable _dt;
  private DataTable _expDt;
  private const int _reportFontSize = 10;
  private const int _reportHeaderFontSize = 13;
  private Workbook _wkb;
  private Worksheet _wks;
  private int _rowIndex;

  protected virtual void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._dt != null)
        this._dt.Dispose();
    }
    base.Dispose(disposing);
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptAdminCommissions));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.Label26 = new Label();
    this.Label41 = new Label();
    this.Label42 = new Label();
    this.Label43 = new Label();
    this.Label44 = new Label();
    this.Label45 = new Label();
    this.Label46 = new Label();
    this.Label47 = new Label();
    this.Label52 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Detail1 = new Detail();
    this.txtChargeName = new TextBox();
    this.txtPercentage = new TextBox();
    this.txtFlateAmount = new TextBox();
    this.txtEntity = new TextBox();
    this.txtCompany = new TextBox();
    this.txtProducer = new TextBox();
    this.txtEntityType = new TextBox();
    this.txtState = new TextBox();
    this.txtCommissionType = new TextBox();
    this.txtCommFromOperating = new TextBox();
    this.txtLine = new TextBox();
    this.txtEffectiveDate = new TextBox();
    this.txtDisabledDate = new TextBox();
    this.txtID = new TextBox();
    this.PageFooter1 = new PageFooter();
    this.Label5 = new Label();
    this.TextBox1 = new TextBox();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label24).BeginInit();
    ((ISupportInitialize) this.Label25).BeginInit();
    ((ISupportInitialize) this.Label26).BeginInit();
    ((ISupportInitialize) this.Label41).BeginInit();
    ((ISupportInitialize) this.Label42).BeginInit();
    ((ISupportInitialize) this.Label43).BeginInit();
    ((ISupportInitialize) this.Label44).BeginInit();
    ((ISupportInitialize) this.Label45).BeginInit();
    ((ISupportInitialize) this.Label46).BeginInit();
    ((ISupportInitialize) this.Label47).BeginInit();
    ((ISupportInitialize) this.Label52).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.txtChargeName).BeginInit();
    ((ISupportInitialize) this.txtPercentage).BeginInit();
    ((ISupportInitialize) this.txtFlateAmount).BeginInit();
    ((ISupportInitialize) this.txtEntity).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.txtProducer).BeginInit();
    ((ISupportInitialize) this.txtEntityType).BeginInit();
    ((ISupportInitialize) this.txtState).BeginInit();
    ((ISupportInitialize) this.txtCommissionType).BeginInit();
    ((ISupportInitialize) this.txtCommFromOperating).BeginInit();
    ((ISupportInitialize) this.txtLine).BeginInit();
    ((ISupportInitialize) this.txtEffectiveDate).BeginInit();
    ((ISupportInitialize) this.txtDisabledDate).BeginInit();
    ((ISupportInitialize) this.txtID).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[16 /*0x10*/]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label24,
      (ARControl) this.Label25,
      (ARControl) this.Label26,
      (ARControl) this.Label41,
      (ARControl) this.Label42,
      (ARControl) this.Label43,
      (ARControl) this.Label44,
      (ARControl) this.Label45,
      (ARControl) this.Label46,
      (ARControl) this.Label47,
      (ARControl) this.Label52,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5
    });
    this.PageHeader1.Height = 0.8229167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Height = 5f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 14pt; font-weight: bold; text-align: center";
    this.Label1.Text = "Admin Commissions Report";
    ((ARControl) this.Label1).Top = 1f / 16f;
    ((ARControl) this.Label1).Width = 13.375f;
    ((ARControl) this.Label24).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label24).Height = 3f / 16f;
    this.Label24.HyperLink = (string) null;
    ((ARControl) this.Label24).Left = 0.0f;
    ((ARControl) this.Label24).Name = "Label24";
    this.Label24.Style = "font-weight: bold; vertical-align: bottom";
    this.Label24.Text = "Charge Name";
    ((ARControl) this.Label24).Top = 0.625f;
    ((ARControl) this.Label24).Width = 19f / 16f;
    ((ARControl) this.Label25).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label25).Height = 3f / 16f;
    this.Label25.HyperLink = (string) null;
    ((ARControl) this.Label25).Left = 19f / 16f;
    ((ARControl) this.Label25).Name = "Label25";
    this.Label25.Style = "font-weight: bold; vertical-align: bottom";
    this.Label25.Text = "Percentage";
    ((ARControl) this.Label25).Top = 0.625f;
    ((ARControl) this.Label25).Width = 13f / 16f;
    ((ARControl) this.Label26).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label26).Height = 3f / 16f;
    this.Label26.HyperLink = (string) null;
    ((ARControl) this.Label26).Left = 2f;
    ((ARControl) this.Label26).Name = "Label26";
    this.Label26.Style = "font-weight: bold; vertical-align: bottom";
    this.Label26.Text = "Flat Amount";
    ((ARControl) this.Label26).Top = 0.625f;
    ((ARControl) this.Label26).Width = 0.8430002f;
    ((ARControl) this.Label41).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label41).Height = 3f / 16f;
    this.Label41.HyperLink = (string) null;
    ((ARControl) this.Label41).Left = 12.053f;
    ((ARControl) this.Label41).Name = "Label41";
    this.Label41.Style = "font-weight: bold; vertical-align: bottom";
    this.Label41.Text = "Op. Acc";
    ((ARControl) this.Label41).Top = 0.625f;
    ((ARControl) this.Label41).Width = 0.625f;
    ((ARControl) this.Label42).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label42).Height = 3f / 16f;
    this.Label42.HyperLink = (string) null;
    ((ARControl) this.Label42).Left = 10.98f;
    ((ARControl) this.Label42).Name = "Label42";
    this.Label42.Style = "font-weight: bold; vertical-align: bottom";
    this.Label42.Text = "Comm. Type";
    ((ARControl) this.Label42).Top = 0.625f;
    ((ARControl) this.Label42).Width = 1.073f;
    ((ARControl) this.Label43).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label43).Height = 3f / 16f;
    this.Label43.HyperLink = (string) null;
    ((ARControl) this.Label43).Left = 10.436f;
    ((ARControl) this.Label43).Name = "Label43";
    this.Label43.Style = "font-weight: bold; vertical-align: bottom";
    this.Label43.Text = "State";
    ((ARControl) this.Label43).Top = 0.625f;
    ((ARControl) this.Label43).Width = 0.5539998f;
    ((ARControl) this.Label44).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label44).Height = 3f / 16f;
    this.Label44.HyperLink = (string) null;
    ((ARControl) this.Label44).Left = 7.999001f;
    ((ARControl) this.Label44).Name = "Label44";
    this.Label44.Style = "font-weight: bold; vertical-align: bottom";
    this.Label44.Text = "Company";
    ((ARControl) this.Label44).Top = 0.625f;
    ((ARControl) this.Label44).Width = 23f / 16f;
    ((ARControl) this.Label45).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label45).Height = 3f / 16f;
    this.Label45.HyperLink = (string) null;
    ((ARControl) this.Label45).Left = 9.436001f;
    ((ARControl) this.Label45).Name = "Label45";
    this.Label45.Style = "font-weight: bold; vertical-align: bottom";
    this.Label45.Text = "Line";
    ((ARControl) this.Label45).Top = 0.625f;
    ((ARControl) this.Label45).Width = 1f;
    ((ARControl) this.Label46).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label46).Height = 3f / 16f;
    this.Label46.HyperLink = (string) null;
    ((ARControl) this.Label46).Left = 5.404f;
    ((ARControl) this.Label46).Name = "Label46";
    this.Label46.Style = "font-weight: bold; vertical-align: bottom";
    this.Label46.Text = "Producer";
    ((ARControl) this.Label46).Top = 0.625f;
    ((ARControl) this.Label46).Width = 1.416f;
    ((ARControl) this.Label47).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label47).Height = 3f / 16f;
    this.Label47.HyperLink = (string) null;
    ((ARControl) this.Label47).Left = 4.218f;
    ((ARControl) this.Label47).Name = "Label47";
    this.Label47.Style = "font-weight: bold; vertical-align: bottom";
    this.Label47.Text = "EntityType";
    ((ARControl) this.Label47).Top = 0.625f;
    ((ARControl) this.Label47).Width = 1.186f;
    ((ARControl) this.Label52).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label52).Height = 3f / 16f;
    this.Label52.HyperLink = (string) null;
    ((ARControl) this.Label52).Left = 2.843f;
    ((ARControl) this.Label52).Name = "Label52";
    this.Label52.Style = "font-weight: bold; vertical-align: bottom";
    this.Label52.Text = "Entity";
    ((ARControl) this.Label52).Top = 0.625f;
    ((ARControl) this.Label52).Width = 1.375f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 13.303f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-weight: bold; vertical-align: bottom";
    this.Label2.Text = "Disabled";
    ((ARControl) this.Label2).Top = 0.625f;
    ((ARControl) this.Label2).Width = 0.625f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 12.678f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold; vertical-align: bottom";
    this.Label3.Text = "Effective";
    ((ARControl) this.Label3).Top = 0.625f;
    ((ARControl) this.Label3).Width = 0.625f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 13.928f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-weight: bold; vertical-align: bottom";
    this.Label4.Text = "ID";
    ((ARControl) this.Label4).Top = 0.625f;
    ((ARControl) this.Label4).Width = 0.625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.txtChargeName,
      (ARControl) this.txtPercentage,
      (ARControl) this.txtFlateAmount,
      (ARControl) this.txtEntity,
      (ARControl) this.txtCompany,
      (ARControl) this.txtProducer,
      (ARControl) this.txtEntityType,
      (ARControl) this.txtState,
      (ARControl) this.txtCommissionType,
      (ARControl) this.txtCommFromOperating,
      (ARControl) this.txtLine,
      (ARControl) this.txtEffectiveDate,
      (ARControl) this.txtDisabledDate,
      (ARControl) this.txtID,
      (ARControl) this.TextBox1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.1461666f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.txtChargeName).DataField = "ChargeName";
    ((ARControl) this.txtChargeName).Height = 0.125f;
    ((ARControl) this.txtChargeName).Left = 0.0f;
    ((ARControl) this.txtChargeName).Name = "txtChargeName";
    this.txtChargeName.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtChargeName.Text = " ";
    ((ARControl) this.txtChargeName).Top = 0.0f;
    ((ARControl) this.txtChargeName).Width = 19f / 16f;
    ((ARControl) this.txtPercentage).DataField = "Percentage";
    ((ARControl) this.txtPercentage).Height = 0.125f;
    ((ARControl) this.txtPercentage).Left = 19f / 16f;
    ((ARControl) this.txtPercentage).Name = "txtPercentage";
    this.txtPercentage.OutputFormat = resourceManager.GetString("txtPercentage.OutputFormat");
    this.txtPercentage.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtPercentage.Text = " ";
    ((ARControl) this.txtPercentage).Top = 0.0f;
    ((ARControl) this.txtPercentage).Width = 13f / 16f;
    ((ARControl) this.txtFlateAmount).DataField = "FlatAmount";
    ((ARControl) this.txtFlateAmount).Height = 0.125f;
    ((ARControl) this.txtFlateAmount).Left = 2f;
    ((ARControl) this.txtFlateAmount).Name = "txtFlateAmount";
    this.txtFlateAmount.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtFlateAmount.Text = " ";
    ((ARControl) this.txtFlateAmount).Top = 0.0f;
    ((ARControl) this.txtFlateAmount).Width = 0.8430002f;
    ((ARControl) this.txtEntity).DataField = "Entity";
    ((ARControl) this.txtEntity).Height = 0.125f;
    ((ARControl) this.txtEntity).Left = 2.843f;
    ((ARControl) this.txtEntity).Name = "txtEntity";
    this.txtEntity.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtEntity.Text = " ";
    ((ARControl) this.txtEntity).Top = 0.0f;
    ((ARControl) this.txtEntity).Width = 1.375f;
    ((ARControl) this.txtCompany).DataField = "Company";
    ((ARControl) this.txtCompany).Height = 0.125f;
    ((ARControl) this.txtCompany).Left = 7.999001f;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtCompany.Text = " ";
    ((ARControl) this.txtCompany).Top = 11f / 1000f;
    ((ARControl) this.txtCompany).Width = 23f / 16f;
    ((ARControl) this.txtProducer).DataField = "Producer";
    ((ARControl) this.txtProducer).Height = 0.125f;
    ((ARControl) this.txtProducer).Left = 5.404f;
    ((ARControl) this.txtProducer).Name = "txtProducer";
    this.txtProducer.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtProducer.Text = " ";
    ((ARControl) this.txtProducer).Top = 11f / 1000f;
    ((ARControl) this.txtProducer).Width = 1.416f;
    ((ARControl) this.txtEntityType).DataField = "EntityType";
    ((ARControl) this.txtEntityType).Height = 0.125f;
    ((ARControl) this.txtEntityType).Left = 4.218f;
    ((ARControl) this.txtEntityType).Name = "txtEntityType";
    this.txtEntityType.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtEntityType.Text = " ";
    ((ARControl) this.txtEntityType).Top = 0.0f;
    ((ARControl) this.txtEntityType).Width = 1.186f;
    ((ARControl) this.txtState).DataField = "State";
    ((ARControl) this.txtState).Height = 0.125f;
    ((ARControl) this.txtState).Left = 10.436f;
    ((ARControl) this.txtState).Name = "txtState";
    this.txtState.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtState.Text = " ";
    ((ARControl) this.txtState).Top = 11f / 1000f;
    ((ARControl) this.txtState).Width = 0.5539998f;
    ((ARControl) this.txtCommissionType).DataField = "CommissionType";
    ((ARControl) this.txtCommissionType).Height = 0.125f;
    ((ARControl) this.txtCommissionType).Left = 10.99f;
    ((ARControl) this.txtCommissionType).Name = "txtCommissionType";
    this.txtCommissionType.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtCommissionType.Text = " ";
    ((ARControl) this.txtCommissionType).Top = 11f / 1000f;
    ((ARControl) this.txtCommissionType).Width = 1.073f;
    ((ARControl) this.txtCommFromOperating).DataField = "CommissionsFromOperatingAccount";
    ((ARControl) this.txtCommFromOperating).Height = 0.125f;
    ((ARControl) this.txtCommFromOperating).Left = 12.063f;
    ((ARControl) this.txtCommFromOperating).Name = "txtCommFromOperating";
    this.txtCommFromOperating.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtCommFromOperating.Text = " ";
    ((ARControl) this.txtCommFromOperating).Top = 11f / 1000f;
    ((ARControl) this.txtCommFromOperating).Width = 0.625f;
    ((ARControl) this.txtLine).DataField = "Line";
    ((ARControl) this.txtLine).Height = 0.125f;
    ((ARControl) this.txtLine).Left = 9.436001f;
    ((ARControl) this.txtLine).Name = "txtLine";
    this.txtLine.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtLine.Text = " ";
    ((ARControl) this.txtLine).Top = 11f / 1000f;
    ((ARControl) this.txtLine).Width = 1f;
    ((ARControl) this.txtEffectiveDate).DataField = "Effective";
    ((ARControl) this.txtEffectiveDate).Height = 0.125f;
    ((ARControl) this.txtEffectiveDate).Left = 12.688f;
    this.txtEffectiveDate.MultiLine = false;
    ((ARControl) this.txtEffectiveDate).Name = "txtEffectiveDate";
    this.txtEffectiveDate.Style = "font-size: 8.25pt; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.txtEffectiveDate.Text = " ";
    ((ARControl) this.txtEffectiveDate).Top = 11f / 1000f;
    ((ARControl) this.txtEffectiveDate).Width = 0.625f;
    ((ARControl) this.txtDisabledDate).DataField = "DisabledDate";
    ((ARControl) this.txtDisabledDate).Height = 0.125f;
    ((ARControl) this.txtDisabledDate).Left = 13.313f;
    this.txtDisabledDate.MultiLine = false;
    ((ARControl) this.txtDisabledDate).Name = "txtDisabledDate";
    this.txtDisabledDate.Style = "font-size: 8.25pt; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.txtDisabledDate.Text = " ";
    ((ARControl) this.txtDisabledDate).Top = 11f / 1000f;
    ((ARControl) this.txtDisabledDate).Width = 0.625f;
    ((ARControl) this.txtID).DataField = "ID";
    ((ARControl) this.txtID).Height = 0.125f;
    ((ARControl) this.txtID).Left = 13.938f;
    this.txtID.MultiLine = false;
    ((ARControl) this.txtID).Name = "txtID";
    this.txtID.Style = "font-size: 8.25pt; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.txtID.Text = (string) null;
    ((ARControl) this.txtID).Top = 11f / 1000f;
    ((ARControl) this.txtID).Width = 0.625f;
    this.PageFooter1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 6.82f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-weight: bold; vertical-align: bottom";
    this.Label5.Text = "Prod. Location";
    ((ARControl) this.Label5).Top = 0.625f;
    ((ARControl) this.Label5).Width = 1.179f;
    ((ARControl) this.TextBox1).DataField = "ProducerLocation";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 6.82f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 11f / 1000f;
    ((ARControl) this.TextBox1).Width = 1.179f;
    ((SectionReport) this).MasterReport = false;
    ((SectionReport) this).PageSettings.DefaultPaperSize = false;
    ((SectionReport) this).PageSettings.Margins.Bottom = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Left = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Right = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Top = 0.3f;
    ((SectionReport) this).PageSettings.Orientation = (PageOrientation) 2;
    ((SectionReport) this).PageSettings.PaperHeight = 14f;
    ((SectionReport) this).PageSettings.PaperKind = PaperKind.Legal;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 14.67083f;
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label24).EndInit();
    ((ISupportInitialize) this.Label25).EndInit();
    ((ISupportInitialize) this.Label26).EndInit();
    ((ISupportInitialize) this.Label41).EndInit();
    ((ISupportInitialize) this.Label42).EndInit();
    ((ISupportInitialize) this.Label43).EndInit();
    ((ISupportInitialize) this.Label44).EndInit();
    ((ISupportInitialize) this.Label45).EndInit();
    ((ISupportInitialize) this.Label46).EndInit();
    ((ISupportInitialize) this.Label47).EndInit();
    ((ISupportInitialize) this.Label52).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.txtChargeName).EndInit();
    ((ISupportInitialize) this.txtPercentage).EndInit();
    ((ISupportInitialize) this.txtFlateAmount).EndInit();
    ((ISupportInitialize) this.txtEntity).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.txtProducer).EndInit();
    ((ISupportInitialize) this.txtEntityType).EndInit();
    ((ISupportInitialize) this.txtState).EndInit();
    ((ISupportInitialize) this.txtCommissionType).EndInit();
    ((ISupportInitialize) this.txtCommFromOperating).EndInit();
    ((ISupportInitialize) this.txtLine).EndInit();
    ((ISupportInitialize) this.txtEffectiveDate).EndInit();
    ((ISupportInitialize) this.txtDisabledDate).EndInit();
    ((ISupportInitialize) this.txtID).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("txtChargeName")]
  private virtual TextBox txtChargeName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPercentage")]
  private virtual TextBox txtPercentage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFlateAmount")]
  private virtual TextBox txtFlateAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEntity")]
  private virtual TextBox txtEntity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCompany")]
  private virtual TextBox txtCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtProducer")]
  private virtual TextBox txtProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEntityType")]
  private virtual TextBox txtEntityType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtState")]
  private virtual TextBox txtState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCommissionType")]
  private virtual TextBox txtCommissionType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCommFromOperating")]
  private virtual TextBox txtCommFromOperating { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLine")]
  private virtual TextBox txtLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEffectiveDate")]
  private virtual TextBox txtEffectiveDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDisabledDate")]
  private virtual TextBox txtDisabledDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtID")]
  private virtual TextBox txtID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptAdminCommissions()
  {
    ((SectionReport) this).ReportStart += new EventHandler(this.rptAdminCommissions_ReportStart);
    this._dt = new DataTable();
    this._expDt = new DataTable();
    this._wkb = new Workbook();
    this._rowIndex = 0;
    this.InitializeComponent();
  }

  public rptAdminCommissions(DataTable dt)
  {
    ((SectionReport) this).ReportStart += new EventHandler(this.rptAdminCommissions_ReportStart);
    this._dt = new DataTable();
    this._expDt = new DataTable();
    this._wkb = new Workbook();
    this._rowIndex = 0;
    this.InitializeComponent();
    this._dt = dt;
  }

  private void rptAdminCommissions_ReportStart(object sender, EventArgs e)
  {
    if (this._dt.Rows.Count <= 0)
      return;
    ((SectionReport) this).DataSource = (object) this._dt;
  }

  private void Detail1_Format(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPercentage.Text, string.Empty, false) == 0)
      this.txtPercentage.Text = "0.0";
    DateTime date;
    if (!string.IsNullOrEmpty(this.txtEffectiveDate.Text))
    {
      TextBox txtEffectiveDate = this.txtEffectiveDate;
      date = Conversions.ToDate(this.txtEffectiveDate.Text);
      string shortDateString = date.ToShortDateString();
      txtEffectiveDate.Text = shortDateString;
    }
    if (string.IsNullOrEmpty(this.txtDisabledDate.Text))
      return;
    TextBox txtDisabledDate = this.txtDisabledDate;
    date = Conversions.ToDate(this.txtDisabledDate.Text);
    string shortDateString1 = date.ToShortDateString();
    txtDisabledDate.Text = shortDateString1;
  }

  public virtual bool IsThreaded => true;

  public virtual void ExportToExcel(string saveFileTo)
  {
    DataView dataView = new DataView();
    this._expDt = new DataView(this._dt).ToTable(false, "ID", "ChargeName", "Percentage", "FlatAmount", "Entity", "EntityGUID", "EntityType", "Producer", "ProducerGUID", "ProducerLocation", "ProducerLocationGUID", "Company", "CompanyGUID", "Line", "LineGUID", "State", "CommissionType", "CommissionsFromOperatingAccount", "Effective", "DisabledDate");
    this._wks = this._wkb.Worksheets[0];
    this._wks.Name = "Admin Comm";
    this._wks.Cells.StandardWidth = 14.0;
    this.PrintColumnHeaders();
    this.PrintDetailLines();
    this.PrintReportHeader();
    this._wkb.Save(saveFileTo);
    Process.Start(saveFileTo);
  }

  private void PrintColumnHeaders()
  {
    int num1 = 0;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this._expDt.Columns)
      {
        Cell cell = this._wks.Cells[this._rowIndex, num1];
        cell.SetStyle(this.GetStyle(cell.GetStyle(), rptAdminCommissions.FontStyle.ColumnHeader));
        cell.PutValue(column.ColumnName);
        ++num1;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num2 = ^(local = ref this._rowIndex) + 1;
    local = num2;
  }

  private void PrintDetailLines()
  {
    try
    {
      foreach (DataRow row in this._expDt.Rows)
      {
        int num1 = this._expDt.Columns.Count - 1;
        for (int columnIndex = 0; columnIndex <= num1; ++columnIndex)
        {
          Cell cell = this._wks.Cells[this._rowIndex, columnIndex];
          cell.SetStyle(this.GetStyle(cell.GetStyle(), rptAdminCommissions.FontStyle.DetailPlain));
          cell.PutValue(row[columnIndex].ToString());
        }
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num2 = ^(local = ref this._rowIndex) + 1;
        local = num2;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void PrintReportHeader()
  {
    this._wks.Cells.InsertRow(0);
    this._wks.Cells.InsertRow(0);
    Cell cell = this._wks.Cells[0, 0];
    cell.SetStyle(this.GetStyle(cell.GetStyle(), rptAdminCommissions.FontStyle.ReportHeader));
    cell.PutValue("Admin Commissions Report");
  }

  private Style GetStyle(Style style, rptAdminCommissions.FontStyle myFontStyle)
  {
    switch (myFontStyle)
    {
      case rptAdminCommissions.FontStyle.ColumnHeader:
        style.Font.IsBold = true;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptAdminCommissions.FontStyle.DetailPlain:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        break;
      case rptAdminCommissions.FontStyle.DetailMoneyValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 3;
        break;
      case rptAdminCommissions.FontStyle.DetailPctValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 9;
        break;
      case rptAdminCommissions.FontStyle.ReportHeader:
        style.Font.IsBold = true;
        style.Font.Size = 13;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
    }
    return style;
  }

  private enum FontStyle
  {
    ColumnHeader,
    DetailPlain,
    DetailMoneyValue,
    DetailPctValue,
    ReportHeader,
  }
}
