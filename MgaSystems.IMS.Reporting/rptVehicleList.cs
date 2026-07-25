// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptVehicleList
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[ClearanceContextMenu("Vehicle List", "Reports", ClearanceContextMenuLevelEnum.Quote)]
public class rptVehicleList : MGAReport, IReport
{
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private DataSet _ds;
  private string _QuoteGuid;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private TextBox TextBox4;

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label")]
  private virtual Label Label { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  private virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  private virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptVehicleList()
  {
    this.ReportStart += new EventHandler(this.rptVehicleList_ReportStart);
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.Label1 = (Label) null;
    this.Label2 = (Label) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.TextBox4 = (TextBox) null;
    this.InitializeComponent();
  }

  public rptVehicleList(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptVehicleList_ReportStart);
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.Label1 = (Label) null;
    this.Label2 = (Label) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.TextBox4 = (TextBox) null;
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid.ToString();
  }

  private void rptVehicleList_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = DefaultDatabase.ExecuteDataSet("dbo.rptVehicleList", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._QuoteGuid
    });
    this.DataSource = (object) this._ds.Tables[0];
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

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptVehicleList));
    this.Detail = new Detail();
    this.TextBox4 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox14 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label = new Label();
    this.TextBox1 = new TextBox();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox14
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox4).DataField = "Model";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 1.896063f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.875f;
    ((ARControl) this.TextBox6).DataField = "ModelYear";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 0.7188976f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.5f;
    ((ARControl) this.TextBox2).DataField = "VIN";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 3.583071f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 1.385039f;
    ((ARControl) this.TextBox3).DataField = "CostNew";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 5.47874f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.6456695f;
    ((ARControl) this.TextBox9).DataField = "TransactionDate";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 8.885434f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 0.6665353f;
    ((ARControl) this.TextBox11).DataField = "UnitNumber";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 6.12441f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.4165354f;
    ((ARControl) this.TextBox7).DataField = "VehicleUnitNumber";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 0.07283461f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.646063f;
    ((ARControl) this.TextBox8).DataField = "Make";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 1.218898f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 0.6771654f;
    ((ARControl) this.TextBox12).DataField = "VehicleTypeDesc";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 2.770866f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 0.8122053f;
    ((ARControl) this.TextBox13).DataField = "SymbolAge";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 4.968504f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox13.Text = (string) null;
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 0.5102362f;
    ((ARControl) this.TextBox5).DataField = "State";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 6.540946f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.3543305f;
    ((ARControl) this.TextBox10).DataField = "Use";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 6.895276f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 1.291733f;
    ((ARControl) this.TextBox14).DataField = "Transaction";
    ((ARControl) this.TextBox14).Height = 3f / 16f;
    ((ARControl) this.TextBox14).Left = 8.187009f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox14.Text = (string) null;
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 0.6984258f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label,
      (ARControl) this.TextBox1,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13
    });
    this.PageHeader.Height = 0.979249f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 0.4271653f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.07244095f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "Vehicle Unit Number #";
    ((ARControl) this.Label1).Top = 0.5728347f;
    ((ARControl) this.Label1).Width = 0.646063f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 0.427067f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.718504f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label2.Text = "Year";
    ((ARControl) this.Label2).Top = 0.5728347f;
    ((ARControl) this.Label2).Width = 0.5000001f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 0.4271654f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 1.895669f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label3.Text = "Model";
    ((ARControl) this.Label3).Top = 0.5728347f;
    ((ARControl) this.Label3).Width = 0.8749999f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 0.4271654f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 2.770473f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label4.Text = "Vehicle Type";
    ((ARControl) this.Label4).Top = 0.5728347f;
    ((ARControl) this.Label4).Width = 13f / 16f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 0.4271654f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 1.218504f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label5.Text = "Make";
    ((ARControl) this.Label5).Top = 0.5728347f;
    ((ARControl) this.Label5).Width = 0.6771654f;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 12pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label.Text = "Vehicle List";
    ((ARControl) this.Label).Top = 1f / 16f;
    ((ARControl) this.Label).Width = 141f / 16f;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 9.75pt; font-weight: normal; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox1.Text = "Policy #";
    ((ARControl) this.TextBox1).Top = 5f / 16f;
    ((ARControl) this.TextBox1).Width = 141f / 16f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 0.4271654f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 3.583071f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label6.Text = "VIN";
    ((ARControl) this.Label6).Top = 0.5728347f;
    ((ARControl) this.Label6).Width = 1.385039f;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 0.4271654f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 5.478347f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label7.Text = "Cost New";
    ((ARControl) this.Label7).Top = 0.5728347f;
    ((ARControl) this.Label7).Width = 0.6456695f;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 0.4271654f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 6.124016f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label8.Text = "Unit #";
    ((ARControl) this.Label8).Top = 0.5728347f;
    ((ARControl) this.Label8).Width = 0.4165354f;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Height = 0.4271654f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 6.540552f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label9.Text = "State";
    ((ARControl) this.Label9).Top = 0.5728347f;
    ((ARControl) this.Label9).Width = 0.3543305f;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Height = 0.4273622f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 8.88504f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 9pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label10.Text = "Trans. Date";
    ((ARControl) this.Label10).Top = 0.5728347f;
    ((ARControl) this.Label10).Width = 0.6669293f;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 0.4271654f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 6.894882f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label11.Text = "Use";
    ((ARControl) this.Label11).Top = 0.5728347f;
    ((ARControl) this.Label11).Width = 1.291733f;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Height = 0.4271654f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 8.186615f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label12.Text = "Trans.";
    ((ARControl) this.Label12).Top = 0.5728347f;
    ((ARControl) this.Label12).Width = 0.6984248f;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Height = 0.4271654f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 4.968111f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label13.Text = "Symbol Age";
    ((ARControl) this.Label13).Top = 0.5728347f;
    ((ARControl) this.Label13).Width = 0.5102362f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 9.55184f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[1]
      {
        (BaseReportControl) new PolicySelection("Policy", PolicySelection.EntityTypes.Insured, PolicySelection.PolicyTypes.Bound)
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds.Tables[0], SaveFileTo);
  }

  private void PageHeader_Format(object sender, EventArgs e)
  {
    string str;
    if (this._ds.Tables[0].Rows.Count == 0)
      str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT PolicyNumber FROM dbo.tblQuotes WITH(NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._QuoteGuid
      }) ?? "TBD";
    else
      str = "Policy:" + this._ds.Tables[0].Rows[0].Field<string>("PolicyNumber");
    this.TextBox1.Text = str;
  }
}
