// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptTasks
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{A4207C18-E428-4926-81F0-711DE0F9CBEC}", "Task List", "Display tasks by user and due date.", "General")]
public class rptTasks : MGAReport, IReport
{
  private TextBox txtTitle;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox txtCompleted;
  private Guid _UserGuid;
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private Guid _assignedUser;
  private int _type;
  private int _Status;
  private DataTable _dt;
  private DataTable _dtCopy;

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptTasks));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.txtCompleted = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.PageHeader = new PageHeader();
    this.txtTitle = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.PageFooter = new PageFooter();
    this.Label9 = new Label();
    this.TextBox8 = new TextBox();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.txtCompleted).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.txtCompleted,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1458333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "DueDate";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj1 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox1).Location = pointF1;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox1.Text = (string) null;
    this.TextBox1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "Body";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj2 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox2).Location = pointF2;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(43f / 16f, 0.125f);
    this.TextBox2.Text = " ";
    this.TextBox2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "Insured";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj3 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox3).Location = pointF3;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(31f / 16f, 0.125f);
    this.TextBox3.Text = " ";
    this.TextBox3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "ControlNo";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj4 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox4).Location = pointF4;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(9f / 16f, 0.125f);
    this.TextBox4.Text = " ";
    this.TextBox4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.txtCompleted).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCompleted).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCompleted).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCompleted).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCompleted).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCompleted).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCompleted).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCompleted).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCompleted).DataField = "CompletedDate";
    this.txtCompleted.DistinctField = (string) null;
    this.txtCompleted.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCompleted = this.txtCompleted;
    object obj5 = componentResourceManager.GetObject("txtCompleted.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) txtCompleted).Location = pointF5;
    ((ARControl) this.txtCompleted).Name = "txtCompleted";
    this.txtCompleted.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtCompleted).Size = new SizeF(11f / 16f, 0.125f);
    this.txtCompleted.Text = (string) null;
    this.txtCompleted.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "PolicyNumber";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj6 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) textBox5).Location = pointF6;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox5.Text = (string) null;
    this.TextBox5.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "Type";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj7 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox6).Location = pointF7;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(17f / 16f, 0.125f);
    this.TextBox6.Text = (string) null;
    this.TextBox6.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "Subject";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox7 = this.TextBox7;
    object obj8 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox7).Location = pointF8;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(17f / 16f, 0.125f);
    this.TextBox7.Text = (string) null;
    this.TextBox7.VerticalAlignment = (VerticalTextAlignment) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.txtTitle,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9
    });
    this.PageHeader.Height = 17f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.txtTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTitle.DistinctField = (string) null;
    this.txtTitle.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtTitle = this.txtTitle;
    object obj9 = componentResourceManager.GetObject("txtTitle.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) txtTitle).Location = pointF9;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.OutputFormat = (string) null;
    ((ARControl) this.txtTitle).Size = new SizeF(165f / 16f, 5f / 16f);
    this.txtTitle.Text = "IMS Task Listing for {0}{1} ({2} diaries)";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj10 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label1).Location = pointF10;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label1.Text = "Due Date";
    this.Label1.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj11 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label2).Location = pointF11;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(43f / 16f, 3f / 16f);
    this.Label2.Text = "Body";
    this.Label2.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj12 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label3).Location = pointF12;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(31f / 16f, 3f / 16f);
    this.Label3.Text = "Insured";
    this.Label3.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj13 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label4).Location = pointF13;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label4.Text = "Control #";
    this.Label4.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj14 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label5).Location = pointF14;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label5.Text = "Completed";
    this.Label5.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj15 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label6).Location = pointF15;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label6.Text = "Policy Number";
    this.Label6.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj16 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label7).Location = pointF16;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(17f / 16f, 3f / 16f);
    this.Label7.Text = "Type";
    this.Label7.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj17 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label8).Location = pointF17;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(17f / 16f, 3f / 16f);
    this.Label8.Text = "Subject";
    this.Label8.VerticalAlignment = (VerticalTextAlignment) 2;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj18 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) label9).Location = pointF18;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.875f, 3f / 16f);
    this.Label9.Text = "Assigned To";
    this.Label9.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "UserName";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox8 = this.TextBox8;
    object obj19 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox8).Location = pointF19;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = (string) null;
    ((ARControl) this.TextBox8).Size = new SizeF(0.875f, 0.125f);
    this.TextBox8.Text = " ";
    this.TextBox8.VerticalAlignment = (VerticalTextAlignment) 1;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.txtCompleted).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
  }

  public rptTasks()
  {
    this.ReportStart += new EventHandler(this.rptTasks_ReportStart);
    this._dt = new DataTable();
    this._dtCopy = new DataTable();
  }

  public rptTasks(
    Guid UserGuid,
    DateTime DateFrom,
    DateTime DateTo,
    int Status,
    Guid assignedUser,
    int type)
  {
    this.ReportStart += new EventHandler(this.rptTasks_ReportStart);
    this._dt = new DataTable();
    this._dtCopy = new DataTable();
    this.InitializeComponent();
    this._UserGuid = UserGuid;
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._Status = Status;
    this._assignedUser = assignedUser;
    this._type = type;
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  private string StatusAsText()
  {
    string str;
    switch (this._Status)
    {
      case 0:
        str = "Open";
        break;
      case 1:
        str = "Closed";
        break;
      case 2:
        str = "Open/Closed";
        break;
      default:
        str = "";
        break;
    }
    return str;
  }

  private void rptTasks_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    string str = "";
    if (DateTime.Compare(this._DateFrom, DateTime.MinValue) == 0 && DateTime.Compare(this._DateTo, DateTime.MinValue) != 0)
      str = " before " + this._DateTo.ToString("MM/dd/yyyy");
    else if (DateTime.Compare(this._DateTo, DateTime.MinValue) == 0 && DateTime.Compare(this._DateFrom, DateTime.MinValue) != 0)
      str = " after " + this._DateFrom.ToString("MM/dd/yyyy");
    this.txtTitle.Text = string.Format(this.txtTitle.Text, (object) DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT LastName + @Comma + FirstName FROM tblUsers WHERE UserGuid = @UserGuid", new object[4]
    {
      (object) "@UserGuid",
      (object) this._UserGuid,
      (object) "@Comma",
      (object) ", "
    }), (object) str, (object) this.StatusAsText());
    if (!this._UserGuid.Equals(Guid.Empty))
    {
      if (!this.CurrentUserGuid.Equals((object) string.Empty) && SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid"))
        this._dt = DefaultDatabase.ExecuteDataTable("dbo.rptTasks", new object[16 /*0x10*/]
        {
          (object) "@UserGuid",
          (object) this._UserGuid,
          (object) "@DateFrom",
          Interaction.IIf(DateTime.Compare(this._DateFrom.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateFrom.Date),
          (object) "@DateTo",
          Interaction.IIf(DateTime.Compare(this._DateTo.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateTo.Date),
          (object) "@ShowOpen",
          Interaction.IIf(this._Status != 1, (object) true, (object) false),
          (object) "@ShowClosed",
          Interaction.IIf(this._Status != 0, (object) true, (object) false),
          (object) "@CurrentUserGuid",
          (object) this.CurrentUserGuid,
          (object) "@AssignedToUserGuid",
          Interaction.IIf(this._assignedUser.Equals(Guid.Empty), (object) DBNull.Value, (object) this._assignedUser),
          (object) "@Type",
          Interaction.IIf(this._type == 0, (object) DBNull.Value, (object) this._type)
        });
      else
        this._dt = DefaultDatabase.ExecuteDataTable("dbo.rptTasks", new object[14]
        {
          (object) "@UserGuid",
          (object) this._UserGuid,
          (object) "@DateFrom",
          Interaction.IIf(DateTime.Compare(this._DateFrom.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateFrom.Date),
          (object) "@DateTo",
          Interaction.IIf(DateTime.Compare(this._DateTo.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateTo.Date),
          (object) "@ShowOpen",
          Interaction.IIf(this._Status != 1, (object) true, (object) false),
          (object) "@ShowClosed",
          Interaction.IIf(this._Status != 0, (object) true, (object) false),
          (object) "@AssignedToUserGuid",
          Interaction.IIf(this._assignedUser.Equals(Guid.Empty), (object) DBNull.Value, (object) this._assignedUser),
          (object) "@Type",
          Interaction.IIf(this._type == 0, (object) DBNull.Value, (object) this._type)
        });
    }
    else if (!this.CurrentUserGuid.Equals((object) string.Empty) && SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid"))
      this._dt = DefaultDatabase.ExecuteDataTable("dbo.rptTasks", new object[14]
      {
        (object) "@DateFrom",
        Interaction.IIf(DateTime.Compare(this._DateFrom.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateFrom.Date),
        (object) "@DateTo",
        Interaction.IIf(DateTime.Compare(this._DateTo.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateTo.Date),
        (object) "@ShowOpen",
        Interaction.IIf(this._Status != 1, (object) true, (object) false),
        (object) "@ShowClosed",
        Interaction.IIf(this._Status != 0, (object) true, (object) false),
        (object) "@CurrentUserGuid",
        (object) this.CurrentUserGuid,
        (object) "@AssignedToUserGuid",
        Interaction.IIf(this._assignedUser.Equals(Guid.Empty), (object) DBNull.Value, (object) this._assignedUser),
        (object) "@Type",
        Interaction.IIf(this._type == 0, (object) DBNull.Value, (object) this._type)
      });
    else
      this._dt = DefaultDatabase.ExecuteDataTable("dbo.rptTasks", new object[12]
      {
        (object) "@DateFrom",
        Interaction.IIf(DateTime.Compare(this._DateFrom.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateFrom.Date),
        (object) "@DateTo",
        Interaction.IIf(DateTime.Compare(this._DateTo.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateTo.Date),
        (object) "@ShowOpen",
        Interaction.IIf(this._Status != 1, (object) true, (object) false),
        (object) "@ShowClosed",
        Interaction.IIf(this._Status != 0, (object) true, (object) false),
        (object) "@AssignedToUserGuid",
        Interaction.IIf(this._assignedUser.Equals(Guid.Empty), (object) DBNull.Value, (object) this._assignedUser),
        (object) "@Type",
        Interaction.IIf(this._type == 0, (object) DBNull.Value, (object) this._type)
      });
    this.DataSource = (object) this._dt;
    this._dtCopy = this._dt;
    this._dtCopy.Columns.Remove("AssociatedEntityGUID");
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      string SQLText1 = "(SELECT 1 As SortBy, (LastName + ', ' + FirstName) As Name, UserGuid from tblUsers) UNION " + $"(SELECT -1 As SortBy, 'All Underwriters' As Name, '{Guid.Empty}' As Useruid) ORDER BY SortBy, Name";
      string SQLText2 = "SELECT -1 AS SortBy, 'All Users' AS Name_LastFirst, '00000000-0000-0000-0000-000000000000' AS UserGUID UNION SELECT 1 AS SortBy, tblUsers.Name_LastFirst, tblusers.UserGUID FROM tblUsers ORDER BY SortBy, Name_LastFirst";
      string SQLText3 = "Select -1 As SortBy, 'All Types' AS description, 0 AS NoteTypeID UNION SELECT 1 AS SortBy, description, NoteTypeID FROM lstNoteTypes ORDER BY SortBy, description";
      BaseReportControl[] getReportControls = new BaseReportControl[5]
      {
        (BaseReportControl) new GenericComboBox("User", SQLText1, "UserGuid", "Name", typeof (Guid)),
        null,
        null,
        null,
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[1] = (BaseReportControl) new DateRangePicker("Due Date", date1, date2, true);
      getReportControls[2] = (BaseReportControl) new GenericComboBox("Diary Status", 125, 125, typeof (int), new object[6]
      {
        (object) "Both",
        (object) rptTasks.Status.Both,
        (object) "Open",
        (object) rptTasks.Status.Open,
        (object) "Closed",
        (object) rptTasks.Status.Closed
      });
      getReportControls[3] = (BaseReportControl) new GenericComboBox("Assigned User", SQLText2, "UserGuid", "Name_LastFirst", typeof (Guid));
      getReportControls[4] = (BaseReportControl) new GenericComboBox("Type", SQLText3, "NoteTypeID", "description", typeof (int));
      return getReportControls;
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dtCopy, SaveFileTo);
  }

  private enum Status
  {
    Open,
    Closed,
    Both,
  }
}
