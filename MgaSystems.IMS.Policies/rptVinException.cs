// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.rptVinException
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class rptVinException : MGAReport
{
  protected virtual void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptVinException));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label11 = new Label();
    this.Detail1 = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.PageHeader1).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label11
    });
    this.PageHeader1.Height = 1.134917f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 0.3329167f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "";
    this.Label1.Text = "Decode  Date";
    ((ARControl) this.Label1).Top = 0.802f;
    ((ARControl) this.Label1).Width = 0.9170001f;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 0.3329167f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 0.9170001f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "";
    this.Label7.Text = "Vin Number";
    ((ARControl) this.Label7).Top = 0.802f;
    ((ARControl) this.Label7).Width = 2.074f;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 0.3329167f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 2.991f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "";
    this.Label8.Text = "Policy Number";
    ((ARControl) this.Label8).Top = 0.802f;
    ((ARControl) this.Label8).Width = 1.583f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.125f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-weight: bold";
    this.Label2.Text = "VIN Decoding Exception Report for :";
    ((ARControl) this.Label2).Top = 0.25f;
    ((ARControl) this.Label2).Width = 39f / 16f;
    ((ARControl) this.Label3).DataField = "InsuredPolicyName";
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 2.625f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "";
    this.Label3.Text = "Insured";
    ((ARControl) this.Label3).Top = 0.25f;
    ((ARControl) this.Label3).Width = 3.25f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 29f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-weight: bold";
    this.Label9.Text = "Control No";
    ((ARControl) this.Label9).Top = 0.5f;
    ((ARControl) this.Label9).Width = 0.75f;
    ((ARControl) this.Label10).DataField = "ControlNo";
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 2.625f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "";
    this.Label10.Text = "controlno";
    ((ARControl) this.Label10).Top = 0.5f;
    ((ARControl) this.Label10).Width = 1.125f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 0.3329167f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 4.574f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "";
    this.Label4.Text = "Vehicle Number";
    ((ARControl) this.Label4).Top = 0.802f;
    ((ARControl) this.Label4).Width = 0.5730002f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 0.3329167f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 5.147f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "";
    this.Label5.Text = "Vehicle Make";
    ((ARControl) this.Label5).Top = 0.802f;
    ((ARControl) this.Label5).Width = 0.6359997f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 0.3329167f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 5.783f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "";
    this.Label6.Text = "Vehicle Model";
    ((ARControl) this.Label6).Top = 0.802f;
    ((ARControl) this.Label6).Width = 0.6360002f;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 0.3329167f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 6.419f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "";
    this.Label11.Text = "Vehicle Year";
    ((ARControl) this.Label11).Top = 0.802f;
    ((ARControl) this.Label11).Width = 0.5290003f;
    this.Detail1.ColumnSpacing = 0.0f;
    ((Section) this.Detail1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7
    });
    ((Section) this.Detail1).Height = 3f / 16f;
    ((Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "DecodeDate";
    ((ARControl) this.TextBox1).Height = 0.2f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Text = "Decode Date";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.9170001f;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "VinNumber";
    ((ARControl) this.TextBox2).Height = 0.2f;
    ((ARControl) this.TextBox2).Left = 0.9170001f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Text = "TextBox2";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 2.074f;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "PolicyNumber";
    ((ARControl) this.TextBox3).Height = 0.2f;
    ((ARControl) this.TextBox3).Left = 2.991f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Text = "TextBox2";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 1.583f;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "VehicleNumber";
    ((ARControl) this.TextBox4).Height = 0.2f;
    ((ARControl) this.TextBox4).Left = 4.574f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Text = "TextBox2";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.5730002f;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "Make";
    ((ARControl) this.TextBox5).Height = 0.2f;
    ((ARControl) this.TextBox5).Left = 5.147f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Text = "TextBox2";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.6359997f;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "Model";
    ((ARControl) this.TextBox6).Height = 0.2f;
    ((ARControl) this.TextBox6).Left = 5.783f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Text = "TextBox2";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.6360002f;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "Year";
    ((ARControl) this.TextBox7).Height = 0.2f;
    ((ARControl) this.TextBox7).Left = 6.419f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Text = "TextBox2";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.5290003f;
    this.PageFooter1.Height = 0.25f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    ((SectionReport) this).MasterReport = false;
    ((SectionReport) this).PageSettings.Margins.Left = 0.5f;
    ((SectionReport) this).PageSettings.Margins.Right = 0.5f;
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 7f;
    ((SectionReport) this).Sections.Add((Section) this.PageHeader1);
    ((SectionReport) this).Sections.Add((Section) this.Detail1);
    ((SectionReport) this).Sections.Add((Section) this.PageFooter1);
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail1
  {
    get => this._Detail1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail1_BeforePrint);
      Detail detail1_1 = this._Detail1;
      if (detail1_1 != null)
        ((Section) detail1_1).BeforePrint -= eventHandler;
      this._Detail1 = value;
      Detail detail1_2 = this._Detail1;
      if (detail1_2 == null)
        return;
      ((Section) detail1_2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptVinException(DataTable dt)
  {
    this.InitializeComponent();
    ((SectionReport) this).DataSource = (object) dt;
    ((SectionReport) this).Run();
  }

  private void Detail1_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();
}
