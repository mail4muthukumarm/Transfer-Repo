// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptPolicyInquiry_Sub
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting.ReportControls;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptPolicyInquiry_Sub : MGAReport, IReport
{
  private Label Label3;
  private Label Label4;
  private Label Label2;
  private Label Label1;
  private Label Label;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;

  public rptPolicyInquiry_Sub(DataView dv)
  {
    this.GroupHeader1 = (GroupHeader) null;
    this.Detail = (Detail) null;
    this.GroupFooter1 = (GroupFooter) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.Label2 = (Label) null;
    this.Label1 = (Label) null;
    this.Label = (Label) null;
    this.TextBox = (TextBox) null;
    this.TextBox1 = (TextBox) null;
    this.TextBox3 = (TextBox) null;
    this.TextBox4 = (TextBox) null;
    this.TextBox5 = (TextBox) null;
    this.InitializeComponent();
    this.DataSource = (object) dv;
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptPolicyInquiry_Sub));
    this.Detail = new Detail();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox6 = new TextBox();
    this.GroupHeader1 = new GroupHeader();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Label = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.GroupFooter1 = new GroupFooter();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox6
    });
    ((Section) this.Detail).Height = 0.2083333f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "TransactNum";
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 0.0f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 0.875f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "PostDate";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.875f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 13f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "IncomeApplied";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 4.875f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 13f / 16f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "User";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 3f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.875f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "TransDescription";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 27f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 21f / 16f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "CashApplied";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 91f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 15f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "Check Number";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 6.625f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 9f / 16f;
    ((Section) this.GroupHeader1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label2,
      (ARControl) this.Label1,
      (ARControl) this.Label,
      (ARControl) this.Label5,
      (ARControl) this.Label6
    });
    this.GroupHeader1.Height = 0.2f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
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
    ((ARControl) this.Label3).Left = 3f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; ";
    this.Label3.Text = "User Name";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 29f / 16f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 4.875f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; ";
    this.Label4.Text = "Income Appl.";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 13f / 16f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 0.2f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 27f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; ";
    this.Label2.Text = "Description";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 21f / 16f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.875f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; ";
    this.Label1.Text = "Post Date";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 13f / 16f;
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; ";
    this.Label.Text = "Transact #";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 0.875f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 91f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; ";
    this.Label5.Text = "Cash Applied";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 15f / 16f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 6.625f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; ";
    this.Label6.Text = "Check #";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 9f / 16f;
    this.GroupFooter1.Height = 3f / 32f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.854167f;
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;
}
