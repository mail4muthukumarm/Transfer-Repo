// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ITVReport
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class ITVReport : MGAReport
{
  private IContainer components;
  private Label Label1;
  private Label Label9;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label10;
  private Label Label8;
  private TextBox TextBox42;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox txtClassCode;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox txtLocationID;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private TextBox TextBox14;
  private TextBox TextBox15;
  private TextBox TextBox16;
  private TextBox TextBox17;
  private TextBox TextBox18;
  private TextBox txtOccupancy;
  private TextBox TextBox22;
  private TextBox TextBox23;
  private DataSet _ds;
  private DataTable _exportTable;
  private bool _isUsingNetRate;
  private Dictionary<int, string> _dicConst;
  private Dictionary<int, string> _dicClassCode;

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ITVReport));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Label9 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label10 = new Label();
    this.Label8 = new Label();
    this.Detail1 = new Detail();
    this.TextBox42 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.txtClassCode = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.txtLocationID = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox14 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox18 = new TextBox();
    this.txtOccupancy = new TextBox();
    this.TextBox22 = new TextBox();
    this.TextBox23 = new TextBox();
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.TextBox42).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.txtClassCode).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.txtLocationID).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.txtOccupancy).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.TextBox23).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label9,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label10,
      (ARControl) this.Label8
    });
    this.PageHeader1.Height = 0.5f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 12.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(7.875f, 3f / 16f);
    this.Label1.Text = "ITV Report";
    this.Label1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 10f);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj2 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label9).Location = pointF2;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(1.25f, 3f / 16f);
    this.Label9.Text = "Address";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 10f);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj3 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label2).Location = pointF3;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.75f, 3f / 16f);
    this.Label2.Text = "City";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 10f);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj4 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label3).Location = pointF4;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(7f / 16f, 3f / 16f);
    this.Label3.Text = "State";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 10f);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj5 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label4).Location = pointF5;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label4.Text = "Zip";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 10f);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj6 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label5).Location = pointF6;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1.25f, 3f / 16f);
    this.Label5.Text = "Occupancy";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 10f);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj7 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label6).Location = pointF7;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(0.875f, 3f / 16f);
    this.Label6.Text = "Const Class";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj8 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label7).Location = pointF8;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label7.Text = "Base Rate";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 10f);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj9 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label10).Location = pointF9;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label10.Text = "RepLCost";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 10f);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj10 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label8).Location = pointF10;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.875f, 3f / 16f);
    this.Label8.Text = "ACV";
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[21]
    {
      (ARControl) this.TextBox42,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.txtClassCode,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.txtLocationID,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox22,
      (ARControl) this.TextBox23,
      (ARControl) this.txtOccupancy
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.TextBox42).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox42).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox42).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox42).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox42).DataField = "Address1";
    this.TextBox42.DistinctField = (string) null;
    this.TextBox42.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox42 = this.TextBox42;
    object obj11 = componentResourceManager.GetObject("TextBox42.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox42).Location = pointF11;
    ((ARControl) this.TextBox42).Name = "TextBox42";
    this.TextBox42.OutputFormat = (string) null;
    ((ARControl) this.TextBox42).Size = new SizeF(1.25f, 0.125f);
    this.TextBox42.Text = (string) null;
    this.TextBox42.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "City";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj12 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox1).Location = pointF12;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(0.75f, 0.125f);
    this.TextBox1.Text = (string) null;
    this.TextBox1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "Zip";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj13 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox2).Location = pointF13;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(9f / 16f, 0.125f);
    this.TextBox2.Text = (string) null;
    this.TextBox2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "State";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj14 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox3).Location = pointF14;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(7f / 16f, 0.125f);
    this.TextBox3.Text = (string) null;
    this.TextBox3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.txtClassCode).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClassCode).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClassCode).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClassCode).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClassCode).DataField = "ConstructionID";
    this.txtClassCode.DistinctField = (string) null;
    this.txtClassCode.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtClassCode = this.txtClassCode;
    object obj15 = componentResourceManager.GetObject("txtClassCode.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) txtClassCode).Location = pointF15;
    ((ARControl) this.txtClassCode).Name = "txtClassCode";
    this.txtClassCode.OutputFormat = (string) null;
    ((ARControl) this.txtClassCode).Size = new SizeF(0.875f, 0.125f);
    this.txtClassCode.Text = (string) null;
    this.txtClassCode.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "BaseRate";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj16 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox6).Location = pointF16;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox6.Text = (string) null;
    this.TextBox6.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "RepLCost";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox7 = this.TextBox7;
    object obj17 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox7).Location = pointF17;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(15f / 16f, 0.125f);
    this.TextBox7.Text = (string) null;
    this.TextBox7.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "ACV";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox8 = this.TextBox8;
    object obj18 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox8).Location = pointF18;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = (string) null;
    ((ARControl) this.TextBox8).Size = new SizeF(0.875f, 0.125f);
    this.TextBox8.Text = (string) null;
    this.TextBox8.VerticalAlignment = (VerticalTextAlignment) 1;
    this.txtLocationID.Alignment = (TextAlignment) 1;
    this.txtLocationID.BackColor = Color.Gold;
    ((ARControl) this.txtLocationID).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLocationID).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLocationID).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLocationID).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLocationID).DataField = "LocationID";
    this.txtLocationID.DistinctField = (string) null;
    this.txtLocationID.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtLocationId = this.txtLocationID;
    object obj19 = componentResourceManager.GetObject("txtLocationID.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) txtLocationId).Location = pointF19;
    ((ARControl) this.txtLocationID).Name = "txtLocationID";
    this.txtLocationID.OutputFormat = (string) null;
    ((ARControl) this.txtLocationID).Size = new SizeF(3f / 16f, 0.125f);
    this.txtLocationID.Text = "LL";
    this.txtLocationID.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.txtLocationID).Visible = false;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Address1";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj20 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox4).Location = pointF20;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(1.25f, 0.125f);
    this.TextBox4.Text = (string) null;
    this.TextBox4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "City";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj21 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox5).Location = pointF21;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(0.75f, 0.125f);
    this.TextBox5.Text = (string) null;
    this.TextBox5.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "State";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox9 = this.TextBox9;
    object obj22 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox9).Location = pointF22;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = (string) null;
    ((ARControl) this.TextBox9).Size = new SizeF(7f / 16f, 0.125f);
    this.TextBox9.Text = (string) null;
    this.TextBox9.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "Zip";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox10 = this.TextBox10;
    object obj23 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox10).Location = pointF23;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = (string) null;
    ((ARControl) this.TextBox10).Size = new SizeF(9f / 16f, 0.125f);
    this.TextBox10.Text = (string) null;
    this.TextBox10.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).DataField = "BaseRate";
    this.TextBox14.DistinctField = (string) null;
    this.TextBox14.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox14 = this.TextBox14;
    object obj24 = componentResourceManager.GetObject("TextBox14.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox14).Location = pointF24;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = (string) null;
    ((ARControl) this.TextBox14).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox14.Text = (string) null;
    this.TextBox14.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).DataField = "Address1";
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox15 = this.TextBox15;
    object obj25 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) textBox15).Location = pointF25;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = (string) null;
    ((ARControl) this.TextBox15).Size = new SizeF(1.25f, 0.125f);
    this.TextBox15.Text = (string) null;
    this.TextBox15.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "City";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox16 = this.TextBox16;
    object obj26 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox16).Location = pointF26;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = (string) null;
    ((ARControl) this.TextBox16).Size = new SizeF(0.75f, 0.125f);
    this.TextBox16.Text = (string) null;
    this.TextBox16.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).DataField = "State";
    this.TextBox17.DistinctField = (string) null;
    this.TextBox17.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox17 = this.TextBox17;
    object obj27 = componentResourceManager.GetObject("TextBox17.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox17).Location = pointF27;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = (string) null;
    ((ARControl) this.TextBox17).Size = new SizeF(7f / 16f, 0.125f);
    this.TextBox17.Text = (string) null;
    this.TextBox17.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).DataField = "Zip";
    this.TextBox18.DistinctField = (string) null;
    this.TextBox18.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox18 = this.TextBox18;
    object obj28 = componentResourceManager.GetObject("TextBox18.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) textBox18).Location = pointF28;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = (string) null;
    ((ARControl) this.TextBox18).Size = new SizeF(9f / 16f, 0.125f);
    this.TextBox18.Text = (string) null;
    this.TextBox18.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.txtOccupancy).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOccupancy).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOccupancy).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOccupancy).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOccupancy).DataField = "ClassCodeID";
    this.txtOccupancy.DistinctField = (string) null;
    this.txtOccupancy.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOccupancy = this.txtOccupancy;
    object obj29 = componentResourceManager.GetObject("txtOccupancy.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) txtOccupancy).Location = pointF29;
    ((ARControl) this.txtOccupancy).Name = "txtOccupancy";
    this.txtOccupancy.OutputFormat = (string) null;
    ((ARControl) this.txtOccupancy).Size = new SizeF(21f / 16f, 0.125f);
    this.txtOccupancy.Text = (string) null;
    this.txtOccupancy.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).DataField = "BaseRate";
    this.TextBox22.DistinctField = (string) null;
    this.TextBox22.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox22 = this.TextBox22;
    object obj30 = componentResourceManager.GetObject("TextBox22.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) textBox22).Location = pointF30;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = (string) null;
    ((ARControl) this.TextBox22).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox22.Text = (string) null;
    this.TextBox22.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).DataField = "RepLCost";
    this.TextBox23.DistinctField = (string) null;
    this.TextBox23.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox23 = this.TextBox23;
    object obj31 = componentResourceManager.GetObject("TextBox23.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) textBox23).Location = pointF31;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.OutputFormat = (string) null;
    ((ARControl) this.TextBox23).Size = new SizeF(15f / 16f, 0.125f);
    this.TextBox23.Text = (string) null;
    this.TextBox23.VerticalAlignment = (VerticalTextAlignment) 1;
    this.PageFooter1.Height = 1f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 7.947917f;
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.TextBox42).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.txtClassCode).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.txtLocationID).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.txtOccupancy).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.TextBox23).EndInit();
  }

  public ITVReport()
  {
    ((SectionReport) this).ReportStart += new EventHandler(this.ITVReport_ReportStart);
    this.InitializeComponent();
  }

  public ITVReport(
    dsITVCalculator ds,
    bool isUsingNetrate,
    Dictionary<int, string> dicConst,
    Dictionary<int, string> dicClassCode)
  {
    ((SectionReport) this).ReportStart += new EventHandler(this.ITVReport_ReportStart);
    this.InitializeComponent();
    this._isUsingNetRate = isUsingNetrate;
    this._dicClassCode = dicClassCode;
    this._dicConst = dicConst;
    this._ds = new DataSet();
    this._ds = (DataSet) ds;
    this._exportTable = new DataTable();
    if (this._isUsingNetRate)
      this._exportTable = this._ds.Tables["NetRateUnderwritingLocations"].Copy();
    else
      this._exportTable = this._ds.Tables["tblUnderwritingLocations"].Copy();
  }

  private void ITVReport_ReportStart(object sender, EventArgs e)
  {
    this._exportTable.Columns.Add("Occupancy");
    this._exportTable.Columns.Add("ConstructionClass");
    if (this._isUsingNetRate)
      ((SectionReport) this).DataSource = (object) this._ds.Tables["NetRateUnderwritingLocations"];
    else
      ((SectionReport) this).DataSource = (object) this._ds.Tables["tblUnderwritingLocations"];
  }

  private void Detail1_Format(object sender, EventArgs e)
  {
    this.txtOccupancy.Text = !this._dicClassCode.ContainsKey(Conversions.ToInteger(this.txtLocationID.Text)) ? string.Empty : this._dicClassCode[Conversions.ToInteger(this.txtLocationID.Text)];
    this.txtClassCode.Text = !this._dicConst.ContainsKey(Conversions.ToInteger(this.txtLocationID.Text)) ? string.Empty : this._dicConst[Conversions.ToInteger(this.txtLocationID.Text)];
    if (this._dicClassCode.ContainsKey(Conversions.ToInteger(this.txtLocationID.Text)))
    {
      try
      {
        foreach (DataRow row in this._exportTable.Rows)
        {
          if (row["LocationID"].Equals((object) Conversions.ToInteger(this.txtLocationID.Text)))
            row["Occupancy"] = (object) this._dicClassCode[Conversions.ToInteger(this.txtLocationID.Text)];
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (this._dicConst.ContainsKey(Conversions.ToInteger(this.txtLocationID.Text)))
    {
      try
      {
        foreach (DataRow row in this._exportTable.Rows)
        {
          if (row["LocationID"].Equals((object) Conversions.ToInteger(this.txtLocationID.Text)))
            row["ConstructionClass"] = (object) this._dicConst[Conversions.ToInteger(this.txtLocationID.Text)];
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.txtLocationID.Text = string.Empty;
  }

  public virtual void ExportToExcel(string SaveFileTo)
  {
    if (this._exportTable.Columns.Contains("Stories"))
      this._exportTable.Columns.Remove("Stories");
    if (this._exportTable.Columns.Contains("ClassCodeID"))
      this._exportTable.Columns.Remove("ClassCodeID");
    if (this._exportTable.Columns.Contains("SqFootage"))
      this._exportTable.Columns.Remove("SqFootage");
    if (this._exportTable.Columns.Contains("YearBuilt"))
      this._exportTable.Columns.Remove("YearBuilt");
    if (this._exportTable.Columns.Contains("ConstructionID"))
      this._exportTable.Columns.Remove("ConstructionID");
    if (this._exportTable.Columns.Contains("SprinklerTypeID"))
      this._exportTable.Columns.Remove("SprinklerTypeID");
    if (this._exportTable.Columns.Contains("Elevators"))
      this._exportTable.Columns.Remove("Elevators");
    if (this._exportTable.Columns.Contains("LocationID"))
      this._exportTable.Columns.Remove("LocationID");
    if (this._exportTable.Columns.Contains("ClassCode"))
      this._exportTable.Columns.Remove("ClassCode");
    if (this._exportTable.Columns.Contains("AgeOfBuilding"))
      this._exportTable.Columns.Remove("AgeOfBuilding");
    ExcelExport.ToExcel(this._exportTable, SaveFileTo);
  }
}
