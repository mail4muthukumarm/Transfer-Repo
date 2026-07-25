// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.MissingDocumentReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[SecureReportResource("{6A589C07-6318-487C-B6A9-F8F56250BA53}", "Missing Document Report", "Lists policies that are missing documents in the specified folder", "General")]
public class MissingDocumentReport : MGAReport, IReport
{
  private IContainer components;
  private readonly int _folderID;
  private readonly DateTime _dateFrom;
  private readonly DateTime _dateTo;
  private readonly string _companyLocationGuids;
  private DataSet _ds;
  private SqlCommand _command;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MissingDocumentReport));
    this.PageHeader1 = new PageHeader();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Detail1 = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.PageFooter1 = new PageFooter();
    this.ReportHeader1 = new ReportHeader();
    this.Label1 = new Label();
    this.txtDateRange = new TextBox();
    this.txtFolderName = new TextBox();
    this.ReportFooter1 = new ReportFooter();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtDateRange).BeginInit();
    ((ISupportInitialize) this.txtFolderName).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7
    });
    this.PageHeader1.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj1 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label2).Location = pointF1;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(11f / 16f, 0.125f);
    this.Label2.Text = "ControlNo";
    this.Label2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj2 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label3).Location = pointF2;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(21f / 16f, 0.125f);
    this.Label3.Text = "Policy Number";
    this.Label3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj3 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label4).Location = pointF3;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(41f / 16f, 0.125f);
    this.Label4.Text = "Insured";
    this.Label4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj4 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label5).Location = pointF4;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1.625f, 0.125f);
    this.Label5.Text = "Line";
    this.Label5.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj5 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label6).Location = pointF5;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(2.875f, 0.125f);
    this.Label6.Text = "Carrier";
    this.Label6.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj6 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label7).Location = pointF6;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(21f / 16f, 0.125f);
    this.Label7.Text = "Underwriter";
    this.Label7.VerticalAlignment = (VerticalTextAlignment) 1;
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "ControlNo";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj7 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox1).Location = pointF7;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox1.Text = (string) null;
    this.TextBox1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "PolicyNumber";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj8 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox2).Location = pointF8;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(21f / 16f, 0.125f);
    this.TextBox2.Text = (string) null;
    this.TextBox2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "Underwriter";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj9 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox3).Location = pointF9;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(21f / 16f, 0.125f);
    this.TextBox3.Text = (string) null;
    this.TextBox3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Insured";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj10 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox4).Location = pointF10;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(41f / 16f, 0.125f);
    this.TextBox4.Text = (string) null;
    this.TextBox4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "LineName";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj11 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox5).Location = pointF11;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(1.625f, 0.125f);
    this.TextBox5.Text = (string) null;
    this.TextBox5.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "LocationName";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj12 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox6).Location = pointF12;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(2.875f, 0.125f);
    this.TextBox6.Text = (string) null;
    this.TextBox6.VerticalAlignment = (VerticalTextAlignment) 1;
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtDateRange,
      (ARControl) this.txtFolderName
    });
    this.ReportHeader1.Height = 0.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Name = "ReportHeader1";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj13 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label1).Location = pointF13;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(10.375f, 0.25f);
    this.Label1.Text = "Missing Document Report";
    this.Label1.VerticalAlignment = (VerticalTextAlignment) 1;
    this.txtDateRange.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtDateRange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDateRange.DistinctField = (string) null;
    this.txtDateRange.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtDateRange = this.txtDateRange;
    object obj14 = componentResourceManager.GetObject("txtDateRange.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtDateRange).Location = pointF14;
    ((ARControl) this.txtDateRange).Name = "txtDateRange";
    this.txtDateRange.OutputFormat = (string) null;
    ((ARControl) this.txtDateRange).Size = new SizeF(10.375f, 3f / 16f);
    this.txtDateRange.Text = "From {0} to {1}";
    this.txtDateRange.VerticalAlignment = (VerticalTextAlignment) 1;
    this.txtFolderName.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtFolderName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFolderName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFolderName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFolderName).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFolderName.DistinctField = (string) null;
    this.txtFolderName.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFolderName = this.txtFolderName;
    object obj15 = componentResourceManager.GetObject("txtFolderName.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) txtFolderName).Location = pointF15;
    ((ARControl) this.txtFolderName).Name = "txtFolderName";
    this.txtFolderName.OutputFormat = (string) null;
    ((ARControl) this.txtFolderName).Size = new SizeF(10.375f, 3f / 16f);
    this.txtFolderName.Text = (string) null;
    this.txtFolderName.VerticalAlignment = (VerticalTextAlignment) 1;
    this.ReportFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Name = "ReportFooter1";
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1);
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtDateRange).EndInit();
    ((ISupportInitialize) this.txtFolderName).EndInit();
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ReportHeader ReportHeader1
  {
    get => this._ReportHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportHeader1_Format);
      ReportHeader reportHeader1_1 = this._ReportHeader1;
      if (reportHeader1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportHeader1_1).Format -= eventHandler;
      this._ReportHeader1 = value;
      ReportHeader reportHeader1_2 = this._ReportHeader1;
      if (reportHeader1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportHeader1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDateRange")]
  internal virtual TextBox txtDateRange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFolderName")]
  internal virtual TextBox txtFolderName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter1")]
  internal virtual ReportFooter ReportFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public MissingDocumentReport()
  {
    this.ReportStart += new EventHandler(this.MissingDocumentReport_ReportStart);
    this.InitializeComponent();
  }

  public MissingDocumentReport(int folderID, DateTime dateFrom, DateTime dateto)
  {
    this.ReportStart += new EventHandler(this.MissingDocumentReport_ReportStart);
    this.InitializeComponent();
    this._folderID = folderID;
    this._dateFrom = dateFrom;
    this._dateTo = dateto;
  }

  public MissingDocumentReport(
    int folderID,
    DateTime dateFrom,
    DateTime dateto,
    string companyLocationGuids)
  {
    this.ReportStart += new EventHandler(this.MissingDocumentReport_ReportStart);
    this.InitializeComponent();
    this._folderID = folderID;
    this._dateFrom = dateFrom;
    this._dateTo = dateto;
    this._companyLocationGuids = companyLocationGuids;
  }

  private void MissingDocumentReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    if (!string.IsNullOrEmpty(this._companyLocationGuids))
      this._ds = DefaultDatabase.ExecuteDataSet(nameof (MissingDocumentReport), new object[8]
      {
        (object) "@FolderID",
        (object) this._folderID,
        (object) "@DateFrom",
        (object) this._dateFrom,
        (object) "@DateTo",
        (object) this._dateTo,
        (object) "@CompanyLocationGuids",
        (object) this._companyLocationGuids
      });
    else
      this._ds = DefaultDatabase.ExecuteDataSet(nameof (MissingDocumentReport), new object[8]
      {
        (object) "@FolderID",
        (object) this._folderID,
        (object) "@DateFrom",
        (object) this._dateFrom,
        (object) "@DateTo",
        (object) this._dateTo,
        (object) "@CompanyLocationGuids",
        (object) DBNull.Value
      });
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void ReportHeader1_Format(object sender, EventArgs e)
  {
    TextBox txtDateRange = this.txtDateRange;
    string text = this.txtDateRange.Text;
    DateTime dateTime = this._dateFrom;
    string shortDateString1 = dateTime.ToShortDateString();
    dateTime = this._dateTo;
    string shortDateString2 = dateTime.ToShortDateString();
    string str = string.Format(text, (object) shortDateString1, (object) shortDateString2);
    txtDateRange.Value = (object) str;
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.txtFolderName.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["FolderName"]);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new GenericComboBox("Folder", "SELECT FolderID As Value, CASE WHEN ParentFolderID IS NULL THEN FolderName ELSE (SELECT T.FolderName FROM tblDocumentFolders T WHERE T.FolderID = tblDocumentFolders.ParentFolderID) + ' - ' + FolderName END As Display FROM tblDocumentFolders ORDER BY CASE WHEN ParentFolderID IS NULL THEN FolderName ELSE (SELECT T.FolderName FROM tblDocumentFolders T WHERE T.FolderID = tblDocumentFolders.ParentFolderID) + ' - ' + FolderName END", "Value", "Display", typeof (int)),
        (BaseReportControl) new DateRangePicker("Policy Eff Date", false),
        (BaseReportControl) new GenericListBox("Company Location(s)", "SELECT Left(tblCompanies.CompanyName + '-' + tblCompanyLocations.Name,100) As Display, tblCompanyLocations.CompanyLocationGUID  As Value                   \r\n            From tblCompanyLocations INNER Join tblCompanies On tblCompanyLocations.CompanyGUID = tblCompanies.CompanyGUID                   \r\n            Order By tblCompanies.CompanyName, tblCompanyLocations.LocationName", "Value", "Display", true, typeof (Guid), true, false, 120)
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds.Tables[0], SaveFileTo);
  }
}
