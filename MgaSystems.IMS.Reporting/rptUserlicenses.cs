// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptUserlicenses
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{B35F887D-74AE-45b0-8790-5933A46ED9CB}", "User Licenses Report", "User Licenses Report", "General")]
public class rptUserlicenses : MGAReport, IReport
{
  private TextBox txtTitle;
  private TextBox TextBox1;
  internal const string SecurityIDReportGuid = "{B35F887D-74AE-45b0-8790-5933A46ED9CB}";

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader1")]
  internal virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  internal virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblState")]
  private virtual Label lblState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProducer")]
  private virtual Label lblProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAddress2")]
  private virtual Label lblAddress2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCity")]
  private virtual Label lblCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblStatus")]
  private virtual Label lblStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptUserlicenses));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.txtTitle = new TextBox();
    this.PageHeader1 = new PageHeader();
    this.lblState = new Label();
    this.lblProducer = new Label();
    this.lblAddress2 = new Label();
    this.lblCity = new Label();
    this.lblStatus = new Label();
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.lblState).BeginInit();
    ((ISupportInitialize) this.lblProducer).BeginInit();
    ((ISupportInitialize) this.lblAddress2).BeginInit();
    ((ISupportInitialize) this.lblCity).BeginInit();
    ((ISupportInitialize) this.lblStatus).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5
    });
    ((Section) this.Detail).Height = 0.2291667f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Name_LastFirst";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 11f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 19f / 16f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "StateID";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 2f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.563f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "LicenseType";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 43f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 25f / 16f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "LicenseNumber";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 4.375f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "Expires";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 5.625f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 15f / 16f;
    ((ARControl) this.txtTitle).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightColor = Color.Black;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopColor = Color.Black;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Height = 3f / 16f;
    ((ARControl) this.txtTitle).Left = 0.0f;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; ";
    this.txtTitle.Text = "User licenses Report";
    ((ARControl) this.txtTitle).Top = 1f / 16f;
    ((ARControl) this.txtTitle).Width = 123f / 16f;
    ((Section) this.PageHeader1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.txtTitle,
      (ARControl) this.lblState,
      (ARControl) this.lblProducer,
      (ARControl) this.lblAddress2,
      (ARControl) this.lblCity,
      (ARControl) this.lblStatus
    });
    this.PageHeader1.Height = 21f / 32f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.lblState).Border.BottomColor = Color.Black;
    ((ARControl) this.lblState).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblState).Border.LeftColor = Color.Black;
    ((ARControl) this.lblState).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblState).Border.RightColor = Color.Black;
    ((ARControl) this.lblState).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblState).Border.TopColor = Color.Black;
    ((ARControl) this.lblState).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblState).Height = 3f / 16f;
    this.lblState.HyperLink = (string) null;
    ((ARControl) this.lblState).Left = 5.5f;
    ((ARControl) this.lblState).Name = "lblState";
    this.lblState.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; ";
    this.lblState.Text = "Expires Date";
    ((ARControl) this.lblState).Top = 7f / 16f;
    ((ARControl) this.lblState).Width = 17f / 16f;
    ((ARControl) this.lblProducer).Border.BottomColor = Color.Black;
    ((ARControl) this.lblProducer).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblProducer).Border.LeftColor = Color.Black;
    ((ARControl) this.lblProducer).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Border.RightColor = Color.Black;
    ((ARControl) this.lblProducer).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Border.TopColor = Color.Black;
    ((ARControl) this.lblProducer).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Height = 3f / 16f;
    this.lblProducer.HyperLink = (string) null;
    ((ARControl) this.lblProducer).Left = 11f / 16f;
    ((ARControl) this.lblProducer).Name = "lblProducer";
    this.lblProducer.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; ";
    this.lblProducer.Text = "User Name";
    ((ARControl) this.lblProducer).Top = 7f / 16f;
    ((ARControl) this.lblProducer).Width = 19f / 16f;
    ((ARControl) this.lblAddress2).Border.BottomColor = Color.Black;
    ((ARControl) this.lblAddress2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblAddress2).Border.LeftColor = Color.Black;
    ((ARControl) this.lblAddress2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAddress2).Border.RightColor = Color.Black;
    ((ARControl) this.lblAddress2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAddress2).Border.TopColor = Color.Black;
    ((ARControl) this.lblAddress2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAddress2).Height = 3f / 16f;
    this.lblAddress2.HyperLink = (string) null;
    ((ARControl) this.lblAddress2).Left = 43f / 16f;
    ((ARControl) this.lblAddress2).Name = "lblAddress2";
    this.lblAddress2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; ";
    this.lblAddress2.Text = "License Type";
    ((ARControl) this.lblAddress2).Top = 7f / 16f;
    ((ARControl) this.lblAddress2).Width = 25f / 16f;
    ((ARControl) this.lblCity).Border.BottomColor = Color.Black;
    ((ARControl) this.lblCity).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblCity).Border.LeftColor = Color.Black;
    ((ARControl) this.lblCity).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCity).Border.RightColor = Color.Black;
    ((ARControl) this.lblCity).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCity).Border.TopColor = Color.Black;
    ((ARControl) this.lblCity).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCity).Height = 3f / 16f;
    this.lblCity.HyperLink = (string) null;
    ((ARControl) this.lblCity).Left = 4.375f;
    ((ARControl) this.lblCity).Name = "lblCity";
    this.lblCity.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; ";
    this.lblCity.Text = "License #";
    ((ARControl) this.lblCity).Top = 7f / 16f;
    ((ARControl) this.lblCity).Width = 1f;
    ((ARControl) this.lblStatus).Border.BottomColor = Color.Black;
    ((ARControl) this.lblStatus).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblStatus).Border.LeftColor = Color.Black;
    ((ARControl) this.lblStatus).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblStatus).Border.RightColor = Color.Black;
    ((ARControl) this.lblStatus).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblStatus).Border.TopColor = Color.Black;
    ((ARControl) this.lblStatus).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblStatus).Height = 0.188f;
    this.lblStatus.HyperLink = (string) null;
    ((ARControl) this.lblStatus).Left = 2f;
    ((ARControl) this.lblStatus).Name = "lblStatus";
    this.lblStatus.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; ";
    this.lblStatus.Text = "State";
    ((ARControl) this.lblStatus).Top = 7f / 16f;
    ((ARControl) this.lblStatus).Width = 0.563f;
    this.PageFooter1.Height = 0.0f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.lblState).EndInit();
    ((ISupportInitialize) this.lblProducer).EndInit();
    ((ISupportInitialize) this.lblAddress2).EndInit();
    ((ISupportInitialize) this.lblCity).EndInit();
    ((ISupportInitialize) this.lblStatus).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public rptUserlicenses()
  {
    this.InitializeComponent();
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT dbo.tblUsers.Name_LastFirst, dbo.tblUserLicenses.LicenseTypeID, dbo.tblUserLicenses.LicenseNumber,        dbo.tblUserLicenses.Expires, dbo.tblUserLicenses.StateID, dbo.lstLicenseTypes.LicenseType FROM  dbo.tblUserLicenses INNER JOIN dbo.tblUsers ON dbo.tblUserLicenses.UserGUID = dbo.tblUsers.UserGUID       INNER JOIN dbo.lstLicenseTypes ON dbo.tblUserLicenses.LicenseTypeID = dbo.lstLicenseTypes.LicenseTypeID");
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;
}
