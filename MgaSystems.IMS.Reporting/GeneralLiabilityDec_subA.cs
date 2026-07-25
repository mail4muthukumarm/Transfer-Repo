// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.GeneralLiabilityDec_subA
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public sealed class GeneralLiabilityDec_subA : MGAReport
{
  public GeneralLiabilityDec_subA() => this.InitializeComponent();

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label71")]
  private virtual Label label71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label73")]
  private virtual Label label73 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label1")]
  private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox3")]
  private virtual TextBox textBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox1")]
  private virtual TextBox textBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line2")]
  internal virtual Line Line2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line3")]
  internal virtual Line Line3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line4")]
  internal virtual Line Line4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line5")]
  internal virtual Line Line5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label70")]
  private virtual Label label70 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line6")]
  internal virtual Line Line6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line7")]
  internal virtual Line Line7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public GeneralLiabilityDec_subA(DataTable dt)
  {
    this.InitializeComponent();
    if (dt.Rows.Count < 1)
    {
      DataRow row = dt.NewRow();
      dt.Rows.Add(row);
    }
    this.DataSource = (object) dt;
  }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Detail_Format);
      EventHandler eventHandler2 = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
      {
        ((Section) detail1).Format -= eventHandler1;
        ((Section) detail1).BeforePrint -= eventHandler2;
      }
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).Format += eventHandler1;
      ((Section) detail2).BeforePrint += eventHandler2;
    }
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (GeneralLiabilityDec_subA));
    this.Detail = new Detail();
    this.textBox3 = new TextBox();
    this.textBox1 = new TextBox();
    this.GroupHeader1 = new GroupHeader();
    this.label71 = new Label();
    this.label73 = new Label();
    this.label1 = new Label();
    this.Label3 = new Label();
    this.Line2 = new Line();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line5 = new Line();
    this.Line6 = new Line();
    this.Line7 = new Line();
    this.GroupFooter1 = new GroupFooter();
    this.label70 = new Label();
    this.Label2 = new Label();
    this.TextBox2 = new TextBox();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.label71).BeginInit();
    ((ISupportInitialize) this.label73).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.label70).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnDirection = (ColumnDirection) 1;
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.textBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.textBox3
    });
    ((Section) this.Detail).Height = 3f / 16f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.textBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox3).Border.RightColor = Color.Black;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.TopColor = Color.Black;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 0.0f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 3f / 16f;
    ((ARControl) this.textBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox1).Border.RightColor = Color.Black;
    ((ARControl) this.textBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox1).Border.TopColor = Color.Black;
    ((ARControl) this.textBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).DataField = "Address";
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 1.25f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 103f / 16f;
    ((Section) this.GroupHeader1).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.label71,
      (ARControl) this.label73,
      (ARControl) this.label1,
      (ARControl) this.Label3,
      (ARControl) this.Line2,
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.Line5,
      (ARControl) this.Line6,
      (ARControl) this.Line7
    });
    this.GroupHeader1.Height = 0.3854167f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.label71).Border.BottomColor = Color.Black;
    ((ARControl) this.label71).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label71).Border.LeftColor = Color.Black;
    ((ARControl) this.label71).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label71).Border.RightColor = Color.Black;
    ((ARControl) this.label71).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label71).Border.TopColor = Color.Black;
    ((ARControl) this.label71).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label71).Height = 3f / 16f;
    this.label71.HyperLink = (string) null;
    ((ARControl) this.label71).Left = 0.0f;
    ((ARControl) this.label71).Name = "label71";
    this.label71.Style = "font-size: 11pt; font-family: Times New Roman; ";
    this.label71.Text = " ";
    ((ARControl) this.label71).Top = 3f / 16f;
    ((ARControl) this.label71).Width = 7.75f;
    ((ARControl) this.label73).Border.BottomColor = Color.Black;
    ((ARControl) this.label73).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label73).Border.LeftColor = Color.Black;
    ((ARControl) this.label73).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label73).Border.RightColor = Color.Black;
    ((ARControl) this.label73).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label73).Border.TopColor = Color.Black;
    ((ARControl) this.label73).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label73).Height = 3f / 16f;
    this.label73.HyperLink = (string) null;
    ((ARControl) this.label73).Left = 0.0f;
    ((ARControl) this.label73).Name = "label73";
    this.label73.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label73.Text = "ALL PREMISES YOU OWN, RENT OR OCCUPY";
    ((ARControl) this.label73).Top = 0.0f;
    ((ARControl) this.label73).Width = 7.75f;
    ((ARControl) this.label1).Border.BottomColor = Color.Black;
    ((ARControl) this.label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.LeftColor = Color.Black;
    ((ARControl) this.label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.RightColor = Color.Black;
    ((ARControl) this.label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.TopColor = Color.Black;
    ((ARControl) this.label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 29f / 16f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-weight: normal; font-size: 11pt; font-family: Times New Roman; ";
    this.label1.Text = "ADDRESS OF ALL PREMISES YOU OWN, RENT OR OCCUPY";
    ((ARControl) this.label1).Top = 3f / 16f;
    ((ARControl) this.label1).Width = 5.75f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 1f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: normal; font-size: 11pt; font-family: Times New Roman; ";
    this.Label3.Text = "LOCATION NO.";
    ((ARControl) this.Label3).Top = 3f / 16f;
    ((ARControl) this.Label3).Width = 1.125f;
    this.Line2.Border.BottomColor = Color.Black;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftColor = Color.Black;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightColor = Color.Black;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopColor = Color.Black;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 0.0f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 0.0f;
    ((ARControl) this.Line2).Width = 123f / 16f;
    this.Line2.X1 = 123f / 16f;
    this.Line2.X2 = 0.0f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.0f;
    this.Line3.Border.BottomColor = Color.Black;
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftColor = Color.Black;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightColor = Color.Black;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopColor = Color.Black;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 0.0f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 3f / 16f;
    ((ARControl) this.Line3).Width = 123f / 16f;
    this.Line3.X1 = 123f / 16f;
    this.Line3.X2 = 0.0f;
    this.Line3.Y1 = 3f / 16f;
    this.Line3.Y2 = 3f / 16f;
    this.Line4.Border.BottomColor = Color.Black;
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftColor = Color.Black;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightColor = Color.Black;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopColor = Color.Black;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line4).Height = 0.0f;
    ((ARControl) this.Line4).Left = 0.0f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 0.375f;
    ((ARControl) this.Line4).Width = 123f / 16f;
    this.Line4.X1 = 123f / 16f;
    this.Line4.X2 = 0.0f;
    this.Line4.Y1 = 0.375f;
    this.Line4.Y2 = 0.375f;
    this.Line5.Border.BottomColor = Color.Black;
    this.Line5.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line5.Border.LeftColor = Color.Black;
    this.Line5.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line5.Border.RightColor = Color.Black;
    this.Line5.Border.RightStyle = (BorderLineStyle) 0;
    this.Line5.Border.TopColor = Color.Black;
    this.Line5.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line5).Height = 0.375f;
    ((ARControl) this.Line5).Left = 123f / 16f;
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    ((ARControl) this.Line5).Top = 0.0f;
    ((ARControl) this.Line5).Width = 0.0f;
    this.Line5.X1 = 123f / 16f;
    this.Line5.X2 = 123f / 16f;
    this.Line5.Y1 = 0.375f;
    this.Line5.Y2 = 0.0f;
    this.Line6.Border.BottomColor = Color.Black;
    this.Line6.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line6.Border.LeftColor = Color.Black;
    this.Line6.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line6.Border.RightColor = Color.Black;
    this.Line6.Border.RightStyle = (BorderLineStyle) 0;
    this.Line6.Border.TopColor = Color.Black;
    this.Line6.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line6).Height = 0.375f;
    ((ARControl) this.Line6).Left = 0.0f;
    this.Line6.LineWeight = 1f;
    ((ARControl) this.Line6).Name = "Line6";
    ((ARControl) this.Line6).Top = 0.0f;
    ((ARControl) this.Line6).Width = 0.0f;
    this.Line6.X1 = 0.0f;
    this.Line6.X2 = 0.0f;
    this.Line6.Y1 = 0.375f;
    this.Line6.Y2 = 0.0f;
    this.Line7.Border.BottomColor = Color.Black;
    this.Line7.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line7.Border.LeftColor = Color.Black;
    this.Line7.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line7.Border.RightColor = Color.Black;
    this.Line7.Border.RightStyle = (BorderLineStyle) 0;
    this.Line7.Border.TopColor = Color.Black;
    this.Line7.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line7).Height = 3f / 16f;
    ((ARControl) this.Line7).Left = 1.25f;
    this.Line7.LineWeight = 1f;
    ((ARControl) this.Line7).Name = "Line7";
    ((ARControl) this.Line7).Top = 3f / 16f;
    ((ARControl) this.Line7).Width = 0.0f;
    this.Line7.X1 = 1.25f;
    this.Line7.X2 = 1.25f;
    this.Line7.Y1 = 0.375f;
    this.Line7.Y2 = 3f / 16f;
    ((Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.label70,
      (ARControl) this.Label2
    });
    this.GroupFooter1.Height = 0.05208333f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.label70).Border.BottomColor = Color.Black;
    ((ARControl) this.label70).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label70).Border.LeftColor = Color.Black;
    ((ARControl) this.label70).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label70).Border.RightColor = Color.Black;
    ((ARControl) this.label70).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label70).Border.TopColor = Color.Black;
    ((ARControl) this.label70).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label70).Height = 0.03f;
    this.label70.HyperLink = (string) null;
    ((ARControl) this.label70).Left = 0.0f;
    ((ARControl) this.label70).Name = "label70";
    this.label70.Style = "text-align: left; font-size: 11pt; font-family: Times New Roman; ";
    this.label70.Text = " ";
    ((ARControl) this.label70).Top = 0.0f;
    ((ARControl) this.label70).Width = 1.25f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 0.03f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 1.25f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "text-align: left; font-size: 11pt; font-family: Times New Roman; ";
    this.Label2.Text = " ";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 6.438f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "UnitNumber";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 0.375f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 9f / 16f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.label71).EndInit();
    ((ISupportInitialize) this.label73).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.label70).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();
}
