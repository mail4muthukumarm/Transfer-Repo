// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCertificateOfInsuranceACORD101
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
public class rptCertificateOfInsuranceACORD101 : SectionReport
{
  private DataTable _dt;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private virtual PageHeader PageHeader
  {
    get => this._PageHeader;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PageHeader_Format);
      PageHeader pageHeader1 = this._PageHeader;
      if (pageHeader1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) pageHeader1).Format -= eventHandler;
      this._PageHeader = value;
      PageHeader pageHeader2 = this._PageHeader;
      if (pageHeader2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) pageHeader2).Format += eventHandler;
    }
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

  private virtual PageFooter PageFooter
  {
    get => this._PageFooter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PageFooter_Format);
      PageFooter pageFooter1 = this._PageFooter;
      if (pageFooter1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) pageFooter1).Format -= eventHandler;
      this._PageFooter = value;
      PageFooter pageFooter2 = this._PageFooter;
      if (pageFooter2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) pageFooter2).Format += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCertificateOfInsuranceACORD101));
    this.PageHeader = new PageHeader();
    this.Label13 = new Label();
    this.Picture1 = new Picture();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.ReportInfo1 = new ReportInfo();
    this.ReportInfo2 = new ReportInfo();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.Label10 = new Label();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.CrossSectionBox1 = new CrossSectionBox();
    this.Line3 = new Line();
    this.Detail = new Detail();
    this.TextBox2 = new TextBox();
    this.PageFooter = new PageFooter();
    this.Label14 = new Label();
    this.Label39 = new Label();
    this.Label40 = new Label();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Picture1).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this.ReportInfo2).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label39).BeginInit();
    ((ISupportInitialize) this.Label40).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[27]
    {
      (ARControl) this.Label13,
      (ARControl) this.Picture1,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.ReportInfo1,
      (ARControl) this.ReportInfo2,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.Label10,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.CrossSectionBox1,
      (ARControl) this.Line3
    });
    this.PageHeader.Height = 2.49f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label13).Height = 0.1470001f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 0.062f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label13.Text = "FORM NUMBER: ACORD 25 (2016/03) FORM TITLE: CERTIFICATE OF LIABILITY INSURANCE";
    ((ARControl) this.Label13).Top = 2.187f;
    ((ARControl) this.Label13).Width = 7.812f;
    ((ARControl) this.Picture1).Height = 0.407f;
    this.Picture1.HyperLink = (string) null;
    this.Picture1.ImageData = (Stream) componentResourceManager.GetObject("Picture1.ImageData");
    ((ARControl) this.Picture1).Left = 0.0f;
    ((ARControl) this.Picture1).Name = "Picture1";
    this.Picture1.SizeMode = (SizeModes) 2;
    ((ARControl) this.Picture1).Top = 0.323f;
    ((ARControl) this.Picture1).Width = 0.95f;
    ((ARControl) this.Label1).Height = 0.2f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 3.563f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8.25pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label1.Text = "AGENCY CUSTOMER ID:";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 1.437f;
    ((ARControl) this.Label2).Height = 0.2f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.2395f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 14.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label2.Text = "ADDITIONAL REMARKS SCHEDULE";
    ((ARControl) this.Label2).Top = 0.48f;
    ((ARControl) this.Label2).Width = 3.521f;
    ((ARControl) this.Label3).Height = 0.2f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 4.542f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 8.25pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label3.Text = "LOC #:";
    ((ARControl) this.Label3).Top = 0.2f;
    ((ARControl) this.Label3).Width = 0.4580007f;
    ((ARControl) this.Label4).Height = 0.1580001f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 6.846f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label4.Text = "Page";
    ((ARControl) this.Label4).Top = 0.522f;
    ((ARControl) this.Label4).Width = 0.3330002f;
    ((ARControl) this.ReportInfo1).Border.BottomStyle = (BorderLineStyle) 1;
    this.ReportInfo1.FormatString = "{PageNumber}";
    ((ARControl) this.ReportInfo1).Height = 0.1580001f;
    ((ARControl) this.ReportInfo1).Left = 7.179f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "font-size: 8.25pt; font-weight: bold; text-align: center";
    ((ARControl) this.ReportInfo1).Top = 0.522f;
    ((ARControl) this.ReportInfo1).Width = 0.2909997f;
    ((ARControl) this.ReportInfo2).Border.BottomStyle = (BorderLineStyle) 1;
    this.ReportInfo2.FormatString = "{PageCount}";
    ((ARControl) this.ReportInfo2).Height = 0.1580001f;
    ((ARControl) this.ReportInfo2).Left = 7.637f;
    ((ARControl) this.ReportInfo2).Name = "ReportInfo2";
    this.ReportInfo2.Style = "font-size: 8.25pt; font-weight: bold; text-align: center";
    ((ARControl) this.ReportInfo2).Top = 0.522f;
    ((ARControl) this.ReportInfo2).Width = 0.3329997f;
    ((ARControl) this.Label5).Height = 0.1580001f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 7.47f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label5.Text = "of";
    ((ARControl) this.Label5).Top = 0.522f;
    ((ARControl) this.Label5).Width = 0.1669998f;
    ((ARControl) this.Label6).Height = 0.1162917f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.0f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 6pt; font-weight: bold; ddo-char-set: 0";
    this.Label6.Text = "AGENCY";
    ((ARControl) this.Label6).Top = 0.7500001f;
    ((ARControl) this.Label6).Width = 0.3855004f;
    ((ARControl) this.Label7).Height = 0.1162917f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 0.0f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 6pt; font-weight: bold; ddo-char-set: 0";
    this.Label7.Text = "POLICY NUMBER";
    ((ARControl) this.Label7).Top = 1.08f;
    ((ARControl) this.Label7).Width = 0.761f;
    ((ARControl) this.Label8).Height = 0.1162917f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.0f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 6pt; font-weight: bold; ddo-char-set: 0";
    this.Label8.Text = "CARRIER";
    ((ARControl) this.Label8).Top = 1.41f;
    ((ARControl) this.Label8).Width = 0.459f;
    ((ARControl) this.Label9).Height = 0.1162917f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 4f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 6pt; font-weight: bold; ddo-char-set: 0";
    this.Label9.Text = "NAMED INSURED";
    ((ARControl) this.Label9).Top = 0.7500001f;
    ((ARControl) this.Label9).Width = 0.761f;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox1).DataField = "AgencyName";
    ((ARControl) this.TextBox1).Height = 0.33f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Padding = new PaddingEx(5, 5, 0, 0);
    this.TextBox1.Style = "font-size: 9pt";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.7500001f;
    ((ARControl) this.TextBox1).Width = 4f;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "CERTIFICATE_NUMBER";
    ((ARControl) this.TextBox3).Height = 0.33f;
    ((ARControl) this.TextBox3).Left = 0.0f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Padding = new PaddingEx(5, 5, 0, 0);
    this.TextBox3.Style = "font-size: 9pt";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 1.08f;
    ((ARControl) this.TextBox3).Width = 4f;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "CARRIER";
    ((ARControl) this.TextBox4).Height = 0.33f;
    ((ARControl) this.TextBox4).Left = 0.0f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Padding = new PaddingEx(5, 5, 0, 0);
    this.TextBox4.Style = "font-size: 9pt";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 1.41f;
    ((ARControl) this.TextBox4).Width = 4f;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox5).DataField = "INSURED";
    ((ARControl) this.TextBox5).Height = 0.83f;
    ((ARControl) this.TextBox5).Left = 4f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Padding = new PaddingEx(5, 5, 0, 0);
    this.TextBox5.Style = "font-size: 9pt";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.7500001f;
    ((ARControl) this.TextBox5).Width = 4f;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "POLICY_EFF";
    ((ARControl) this.TextBox6).Height = 0.1600001f;
    ((ARControl) this.TextBox6).Left = 4.803f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 6pt; font-weight: bold; vertical-align: middle";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 1.58f;
    ((ARControl) this.TextBox6).Width = 3.197f;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Height = 0.1600001f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 4f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 6pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label10.Text = "EFFECTIVE DATE:";
    ((ARControl) this.Label10).Top = 1.58f;
    ((ARControl) this.Label10).Width = 0.8030003f;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "INSURED_ID";
    ((ARControl) this.TextBox7).Height = 0.2f;
    ((ARControl) this.TextBox7).Left = 5f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 9pt; vertical-align: bottom";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 7.450581E-09f;
    ((ARControl) this.TextBox7).Width = 3f;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "LOCATION_CODE";
    ((ARControl) this.TextBox8).Height = 0.2f;
    ((ARControl) this.TextBox8).Left = 5f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 9pt; vertical-align: bottom";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.2000001f;
    ((ARControl) this.TextBox8).Width = 1.2f;
    ((ARControl) this.Label11).Height = 0.147f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 0.0f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label11.Text = "ADDITIONAL REMARKS";
    ((ARControl) this.Label11).Top = 1.812f;
    ((ARControl) this.Label11).Width = 1.447f;
    ((ARControl) this.Label12).Height = 0.1470001f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 0.062f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label12.Text = "THIS ADDITIONAL REMARKS FORM IS A SCHEDULE TO ACORD FORM,";
    ((ARControl) this.Label12).Top = 2.042f;
    ((ARControl) this.Label12).Width = 4f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 1f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 2.367f;
    ((ARControl) this.Line1).Width = 1.104f;
    this.Line1.X1 = 1f;
    this.Line1.X2 = 2.104f;
    this.Line1.Y1 = 2.367f;
    this.Line1.Y2 = 2.367f;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 2.875f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 2.367f;
    ((ARControl) this.Line2).Width = 5.084001f;
    this.Line2.X1 = 2.875f;
    this.Line2.X2 = 7.959001f;
    this.Line2.Y1 = 2.367f;
    this.Line2.Y2 = 2.367f;
    ((CrossSectionControl) this.CrossSectionBox1).Bottom = 0.03125024f;
    ((CrossSectionControl) this.CrossSectionBox1).Left = 0.0f;
    ((CrossSectionControl) this.CrossSectionBox1).LineWeight = 2.5f;
    ((ARControl) this.CrossSectionBox1).Name = "CrossSectionBox1";
    this.CrossSectionBox1.Radius = new CornersRadius(new float?(0.0f), new float?(), new float?(), new float?(), new float?());
    ((CrossSectionControl) this.CrossSectionBox1).Right = 8f;
    ((CrossSectionControl) this.CrossSectionBox1).Top = 2f;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 0.0f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 2.437f;
    ((ARControl) this.Line3).Width = 8f;
    this.Line3.X1 = 0.0f;
    this.Line3.X2 = 8f;
    this.Line3.Y1 = 2.437f;
    this.Line3.Y2 = 2.437f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 1.333333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox2).DataField = "DESCRIPTION_OF_OPERATIONS";
    ((ARControl) this.TextBox2).Height = 1.312999f;
    ((ARControl) this.TextBox2).Left = 0.062f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Padding = new PaddingEx(1, 1, 1, 1);
    this.TextBox2.Style = "font-size: 9pt";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 7.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label14,
      (ARControl) this.Label39,
      (ARControl) this.Label40
    });
    this.PageFooter.Height = 17f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.Label14).Height = 0.147f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 0.03f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label14.Text = "ACORD 101 (2008/01)";
    ((ARControl) this.Label14).Top = 0.125f;
    ((ARControl) this.Label14).Width = 1.282f;
    ((ARControl) this.Label39).Height = 3f / 16f;
    this.Label39.HyperLink = (string) null;
    ((ARControl) this.Label39).Left = 2.223f;
    ((ARControl) this.Label39).Name = "Label39";
    this.Label39.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label39.Text = "The ACORD name and logo are registered marks of ACORD";
    ((ARControl) this.Label39).Top = 0.312f;
    ((ARControl) this.Label39).Width = 3.479f;
    ((ARControl) this.Label40).Height = 0.1354167f;
    this.Label40.HyperLink = (string) null;
    ((ARControl) this.Label40).Left = 4.584f;
    ((ARControl) this.Label40).Name = "Label40";
    this.Label40.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label40.Text = "© 2008 ACORD CORPORATION. All rights reserved.";
    ((ARControl) this.Label40).Top = 0.125f;
    ((ARControl) this.Label40).Width = 3.386f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.25f;
    this.PageSettings.Margins.Left = 0.25f;
    this.PageSettings.Margins.Right = 0.25f;
    this.PageSettings.Margins.Top = 0.25f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.041167f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Picture1).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this.ReportInfo2).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label39).EndInit();
    ((ISupportInitialize) this.Label40).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("Picture1")]
  private virtual Picture Picture1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  private virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo2")]
  private virtual ReportInfo ReportInfo2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line1")]
  private virtual Line Line1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line2")]
  private virtual Line Line2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label39")]
  private virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label40")]
  private virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CrossSectionBox1")]
  private virtual CrossSectionBox CrossSectionBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line3")]
  private virtual Line Line3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptCertificateOfInsuranceACORD101(DataTable dt)
  {
    this.ReportStart += new EventHandler(this.rptCertificateOfInsuranceACORD101_ReportStart);
    this.InitializeComponent();
    this._dt = dt;
  }

  private void rptCertificateOfInsuranceACORD101_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._dt;
  }

  private void PageFooter_Format(object sender, EventArgs e)
  {
  }

  private void Detail_Format(object sender, EventArgs e)
  {
  }

  private void PageHeader_Format(object sender, EventArgs e)
  {
  }
}
