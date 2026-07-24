// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptPayablesSummaryReport_checks
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptPayablesSummaryReport_checks : MGAReport
{
  private Label Label8;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private Label Label15;
  private Label Label16;
  private TextBox TextBox17;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox20;
  private TextBox TextBox21;
  private TextBox TextBox22;
  private Line strikeOut;
  private TextBox txtVoid;
  private TextBox TextBox13;
  private TextBox TextBox16;
  private Label Label14;
  private TextBox TextBox19;

  public rptPayablesSummaryReport_checks(DataView dv)
  {
    this.InitializeComponent();
    this.DataSource = (object) dv;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPayablesSummaryReport_checks));
    this.Detail = new Detail();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label8 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.TextBox17 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox20 = new TextBox();
    this.TextBox21 = new TextBox();
    this.TextBox22 = new TextBox();
    this.strikeOut = new Line();
    this.txtVoid = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox16 = new TextBox();
    this.Label14 = new Label();
    this.TextBox19 = new TextBox();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.txtVoid).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox20,
      (ARControl) this.TextBox21,
      (ARControl) this.TextBox22,
      (ARControl) this.strikeOut,
      (ARControl) this.txtVoid
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label8,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label15,
      (ARControl) this.Label16
    });
    this.GroupHeader1.Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox16,
      (ARControl) this.Label14,
      (ARControl) this.TextBox19
    });
    this.GroupFooter1.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.Label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj1 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label8).Location = pointF1;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.875f, 3f / 16f);
    this.Label8.Text = "Net Billed";
    this.Label8.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label10.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj2 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label10).Location = pointF2;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label10.Text = "Commission";
    this.Label10.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj3 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label11).Location = pointF3;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(5f, 3f / 16f);
    this.Label11.Text = "Payee";
    this.Label11.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj4 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label12).Location = pointF4;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label12.Text = "Check #";
    this.Label12.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label13.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj5 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label13).Location = pointF5;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label13.Text = "Check Amount";
    this.Label13.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj6 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label15).Location = pointF6;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(0.98f, 0.188f);
    this.Label15.Text = "Check Date";
    this.Label15.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label16.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj7 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label16).Location = pointF7;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(5f / 16f, 3f / 16f);
    this.Label16.Text = "Void";
    this.Label16.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox17).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).DataField = "checkdate";
    this.TextBox17.DistinctField = (string) null;
    this.TextBox17.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox17.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox17 = this.TextBox17;
    object obj8 = componentResourceManager.GetObject("TextBox17.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox17).Location = pointF8;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox17).Size = new SizeF(0.98f, 0.125f);
    this.TextBox17.Text = " ";
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "Payee";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj9 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox7).Location = pointF9;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(5f, 0.125f);
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "checknum";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj10 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox8).Location = pointF10;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = (string) null;
    ((ARControl) this.TextBox8).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox8.Text = " ";
    this.TextBox20.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox20).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).DataField = "Check Amount";
    this.TextBox20.DistinctField = (string) null;
    this.TextBox20.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox20.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox20 = this.TextBox20;
    object obj11 = componentResourceManager.GetObject("TextBox20.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox20).Location = pointF11;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = "#,##0.00";
    ((ARControl) this.TextBox20).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox20.Text = " ";
    this.TextBox21.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).DataField = "Gross Commission";
    this.TextBox21.DistinctField = (string) null;
    this.TextBox21.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox21.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox21 = this.TextBox21;
    object obj12 = componentResourceManager.GetObject("TextBox21.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox21).Location = pointF12;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.OutputFormat = "#,##0.00";
    ((ARControl) this.TextBox21).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox21.Text = " ";
    this.TextBox22.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox22).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).DataField = "Net";
    this.TextBox22.DistinctField = (string) null;
    this.TextBox22.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox22.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox22 = this.TextBox22;
    object obj13 = componentResourceManager.GetObject("TextBox22.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox22).Location = pointF13;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = "#,##0.00";
    ((ARControl) this.TextBox22).Size = new SizeF(0.875f, 0.125f);
    this.TextBox22.Text = " ";
    this.strikeOut.Border.BottomStyle = (BorderLineStyle) 0;
    this.strikeOut.Border.LeftStyle = (BorderLineStyle) 0;
    this.strikeOut.Border.RightStyle = (BorderLineStyle) 0;
    this.strikeOut.Border.TopStyle = (BorderLineStyle) 0;
    this.strikeOut.LineColor = Color.FromArgb((int) byte.MaxValue, 0, 0);
    this.strikeOut.LineWeight = 1f;
    ((ARControl) this.strikeOut).Name = "strikeOut";
    ((ARControl) this.strikeOut).Visible = false;
    this.strikeOut.X1 = 1f / 32f;
    this.strikeOut.X2 = 9.5f;
    this.strikeOut.Y1 = 1f / 16f;
    this.strikeOut.Y2 = 1f / 16f;
    this.txtVoid.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtVoid).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtVoid).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtVoid).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtVoid).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtVoid).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtVoid).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtVoid).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtVoid).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtVoid).DataField = "Void";
    this.txtVoid.DistinctField = (string) null;
    this.txtVoid.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtVoid.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtVoid = this.txtVoid;
    object obj14 = componentResourceManager.GetObject("txtVoid.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtVoid).Location = pointF14;
    ((ARControl) this.txtVoid).Name = "txtVoid";
    this.txtVoid.OutputFormat = (string) null;
    ((ARControl) this.txtVoid).Size = new SizeF(5f / 16f, 0.125f);
    this.txtVoid.Text = " ";
    this.TextBox13.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "Check Amount";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj15 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox13).Location = pointF15;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = "#,##0.00";
    ((ARControl) this.TextBox13).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox13.SummaryRunning = (SummaryRunning) 2;
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = " ";
    this.TextBox16.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "Gross Commission";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox16 = this.TextBox16;
    object obj16 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox16).Location = pointF16;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = "#,##0.00";
    ((ARControl) this.TextBox16).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox16.SummaryRunning = (SummaryRunning) 2;
    this.TextBox16.SummaryType = (SummaryType) 1;
    this.TextBox16.Text = " ";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj17 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label14).Location = pointF17;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(0.5f, 3f / 16f);
    this.Label14.Text = "Totals:";
    this.TextBox19.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).DataField = "Net";
    this.TextBox19.DistinctField = (string) null;
    this.TextBox19.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox19.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox19 = this.TextBox19;
    object obj18 = componentResourceManager.GetObject("TextBox19.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox19).Location = pointF18;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = "#,##0.00";
    ((ARControl) this.TextBox19).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox19.SummaryRunning = (SummaryRunning) 2;
    this.TextBox19.SummaryType = (SummaryType) 1;
    this.TextBox19.Text = " ";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 9.5f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.txtVoid).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    this.SetDetailControlsHeight();
    ((ARControl) this.strikeOut).Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtVoid.Text, "X", false) == 0;
    this.strikeOut.Y2 = this.strikeOut.Y1;
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
