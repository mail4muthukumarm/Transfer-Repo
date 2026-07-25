// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProductionReportWithoutMGAComm
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{6BB9B2DA-9AC9-4396-846F-9846E039A8C5}", "Producer Production Report", "Production Report without MGA Commission.", "General")]
[SecureResource("{73B68203-E6EC-483f-B6AD-51B856DBC89E}", "Production Report User Access", "Allows user to run report for any/all users.", "Reports")]
[SecureResource("{07E94EBD-A35F-4449-B650-DB54B8DD73A3}", "Production Report Issuing Office Access", "Allows user to run report for any/all issuing offices.", "Reports")]
public sealed class rptProductionReportWithoutMGAComm : MGAReport, IReport
{
  private Label Label1;
  private TextBox txtSubTitle;
  private Label lblCriteria1Title;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label8;
  private Label Label9;
  private Label lblCriteria2Title;
  private Label Label18;
  private Label Label22;
  private Label Label23;
  private Label Label24;
  private Label Label25;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox19;
  private TextBox txtQuoteControlNum;
  private TextBox Producer1;
  private TextBox Insured1;
  private TextBox NetBilled1;
  private TextBox TextBox15;
  private TextBox TextBox16;
  private Label Label16;
  private Label lblCriteria2FooterText;
  private TextBox txtUnderWriterItemCount;
  private TextBox NetBilled2;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private Label Label12;
  private Label lblCriteria1FooterText;
  private TextBox txtMonthItemCount;
  private TextBox NetBilled3;
  private Label Label21;
  private TextBox TextBox27;
  private TextBox TextBox26;
  private TextBox txtTotalItems;
  private TextBox NetBilled4;
  internal const string SecurityIDReportGuid = "{6BB9B2DA-9AC9-4396-846F-9846E039A8C5}";
  internal const string SecurityIDAllUsers = "{73B68203-E6EC-483f-B6AD-51B856DBC89E}";
  internal const string SecurityIDAllOffices = "{07E94EBD-A35F-4449-B650-DB54B8DD73A3}";
  private DateTime _billingDateFrom;
  private DateTime _billingDateTo;
  private DateTime _effectiveDateFrom;
  private DateTime _effectiveDateTo;
  private Guid _underwriterGuid;
  private Guid _producerGuid;
  private int _policyTypeID;
  private int _UnderWriterItemCount;
  private int _MonthlyItemCount;
  private int _TotalItemCount;
  private Guid _inhouseProducerGuid;
  private Guid _companyGuid;
  private Guid _companyLocationGuid;
  private Guid _lineGuid;
  private int _issuingOfficeID;
  private Guid _ProducerLocationGuid;
  private string _SortBy;
  private DataView _dv;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghTotal")]
  private virtual GroupHeader ghTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghCriteria1")]
  private virtual GroupHeader ghCriteria1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghCriteria2")]
  private virtual GroupHeader ghCriteria2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual GroupFooter gfCriteria2
  {
    get => this._gfCriteria2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfCriteria2_BeforePrint);
      GroupFooter gfCriteria2_1 = this._gfCriteria2;
      if (gfCriteria2_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCriteria2_1).BeforePrint -= eventHandler;
      this._gfCriteria2 = value;
      GroupFooter gfCriteria2_2 = this._gfCriteria2;
      if (gfCriteria2_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCriteria2_2).BeforePrint += eventHandler;
    }
  }

  private virtual GroupFooter gfCriteria1
  {
    get => this._gfCriteria1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfCriteria1_BeforePrint);
      GroupFooter gfCriteria1_1 = this._gfCriteria1;
      if (gfCriteria1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCriteria1_1).BeforePrint -= eventHandler;
      this._gfCriteria1 = value;
      GroupFooter gfCriteria1_2 = this._gfCriteria1;
      if (gfCriteria1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCriteria1_2).BeforePrint += eventHandler;
    }
  }

  private virtual GroupFooter gfTotal
  {
    get => this._gfTotal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfTotal_BeforePrint);
      GroupFooter gfTotal1 = this._gfTotal;
      if (gfTotal1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfTotal1).BeforePrint -= eventHandler;
      this._gfTotal = value;
      GroupFooter gfTotal2 = this._gfTotal;
      if (gfTotal2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfTotal2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptProductionReportWithoutMGAComm));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.ghTotal = new GroupHeader();
    this.gfTotal = new GroupFooter();
    this.ghCriteria1 = new GroupHeader();
    this.gfCriteria1 = new GroupFooter();
    this.ghCriteria2 = new GroupHeader();
    this.gfCriteria2 = new GroupFooter();
    this.Label1 = new Label();
    this.txtSubTitle = new TextBox();
    this.lblCriteria1Title = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.lblCriteria2Title = new Label();
    this.Label18 = new Label();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox19 = new TextBox();
    this.txtQuoteControlNum = new TextBox();
    this.Producer1 = new TextBox();
    this.Insured1 = new TextBox();
    this.NetBilled1 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.Label16 = new Label();
    this.lblCriteria2FooterText = new Label();
    this.txtUnderWriterItemCount = new TextBox();
    this.NetBilled2 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.Label12 = new Label();
    this.lblCriteria1FooterText = new Label();
    this.txtMonthItemCount = new TextBox();
    this.NetBilled3 = new TextBox();
    this.Label21 = new Label();
    this.TextBox27 = new TextBox();
    this.TextBox26 = new TextBox();
    this.txtTotalItems = new TextBox();
    this.NetBilled4 = new TextBox();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtSubTitle).BeginInit();
    ((ISupportInitialize) this.lblCriteria1Title).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.lblCriteria2Title).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.Label23).BeginInit();
    ((ISupportInitialize) this.Label24).BeginInit();
    ((ISupportInitialize) this.Label25).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.txtQuoteControlNum).BeginInit();
    ((ISupportInitialize) this.Producer1).BeginInit();
    ((ISupportInitialize) this.Insured1).BeginInit();
    ((ISupportInitialize) this.NetBilled1).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.lblCriteria2FooterText).BeginInit();
    ((ISupportInitialize) this.txtUnderWriterItemCount).BeginInit();
    ((ISupportInitialize) this.NetBilled2).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.lblCriteria1FooterText).BeginInit();
    ((ISupportInitialize) this.txtMonthItemCount).BeginInit();
    ((ISupportInitialize) this.NetBilled3).BeginInit();
    ((ISupportInitialize) this.Label21).BeginInit();
    ((ISupportInitialize) this.TextBox27).BeginInit();
    ((ISupportInitialize) this.TextBox26).BeginInit();
    ((ISupportInitialize) this.txtTotalItems).BeginInit();
    ((ISupportInitialize) this.NetBilled4).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox19,
      (ARControl) this.txtQuoteControlNum,
      (ARControl) this.Producer1,
      (ARControl) this.Insured1,
      (ARControl) this.NetBilled1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtSubTitle
    });
    this.ReportHeader.Height = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.ReportFooter.PrintAtBottom = true;
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.ghTotal.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTotal).Name = "ghTotal";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotal).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label21,
      (ARControl) this.TextBox27,
      (ARControl) this.TextBox26,
      (ARControl) this.txtTotalItems,
      (ARControl) this.NetBilled4
    });
    this.gfTotal.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotal).Name = "gfTotal";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.lblCriteria1Title
    });
    this.ghCriteria1.Height = 7f / 16f;
    this.ghCriteria1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria1).Name = "ghCriteria1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.Label12,
      (ARControl) this.lblCriteria1FooterText,
      (ARControl) this.txtMonthItemCount,
      (ARControl) this.NetBilled3
    });
    this.gfCriteria1.Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria1).Name = "gfCriteria1";
    this.gfCriteria1.NewPage = (NewPage) 2;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria2).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.lblCriteria2Title,
      (ARControl) this.Label18,
      (ARControl) this.Label22,
      (ARControl) this.Label23,
      (ARControl) this.Label24,
      (ARControl) this.Label25
    });
    this.ghCriteria2.Height = 0.5506945f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria2).Name = "ghCriteria2";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria2).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.Label16,
      (ARControl) this.lblCriteria2FooterText,
      (ARControl) this.txtUnderWriterItemCount,
      (ARControl) this.NetBilled2
    });
    this.gfCriteria2.Height = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria2).Name = "gfCriteria2";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(10.375f, 0.25f);
    this.Label1.Text = "Producer Production Report";
    this.txtSubTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtSubTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.txtSubTitle.DistinctField = (string) null;
    this.txtSubTitle.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtSubTitle.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtSubTitle = this.txtSubTitle;
    object obj2 = componentResourceManager.GetObject("txtSubTitle.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtSubTitle).Location = pointF2;
    ((ARControl) this.txtSubTitle).Name = "txtSubTitle";
    this.txtSubTitle.OutputFormat = (string) null;
    ((ARControl) this.txtSubTitle).Size = new SizeF(10.375f, 3f / 16f);
    ((ARControl) this.lblCriteria1Title).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1Title).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1Title).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1Title).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCriteria1Title.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCriteria1Title.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCriteria1Title.HyperLink = (string) null;
    Label lblCriteria1Title = this.lblCriteria1Title;
    object obj3 = componentResourceManager.GetObject("lblCriteria1Title.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) lblCriteria1Title).Location = pointF3;
    ((ARControl) this.lblCriteria1Title).Name = "lblCriteria1Title";
    ((ARControl) this.lblCriteria1Title).Size = new SizeF(10.375f, 0.25f);
    this.lblCriteria1Title.Text = "";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj4 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label2).Location = pointF4;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label2.Text = "Date Billed";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj5 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label3).Location = pointF5;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label3.Text = "Effective";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj6 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label4).Location = pointF6;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label4.Text = "Expiration";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj7 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label5).Location = pointF7;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label5.Text = "Insured";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj8 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label6).Location = pointF8;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(1.375f, 3f / 16f);
    this.Label6.Text = "Producer";
    this.Label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj9 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label8).Location = pointF9;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label8.Text = "Premium";
    this.Label9.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj10 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label9).Location = pointF10;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label9.Text = "Net Billed";
    ((ARControl) this.lblCriteria2Title).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2Title).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2Title).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2Title).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCriteria2Title.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCriteria2Title.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCriteria2Title.HyperLink = (string) null;
    Label lblCriteria2Title = this.lblCriteria2Title;
    object obj11 = componentResourceManager.GetObject("lblCriteria2Title.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) lblCriteria2Title).Location = pointF11;
    ((ARControl) this.lblCriteria2Title).Name = "lblCriteria2Title";
    ((ARControl) this.lblCriteria2Title).Size = new SizeF(10.375f, 3f / 16f);
    this.lblCriteria2Title.Text = "";
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 0;
    this.Label18.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label18.HyperLink = (string) null;
    Label label18 = this.Label18;
    object obj12 = componentResourceManager.GetObject("Label18.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label18).Location = pointF12;
    ((ARControl) this.Label18).Name = "Label18";
    ((ARControl) this.Label18).Size = new SizeF(0.75f, 3f / 16f);
    this.Label18.Text = "Policy Type";
    ((ARControl) this.Label22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.TopStyle = (BorderLineStyle) 0;
    this.Label22.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label22.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label22.HyperLink = (string) null;
    Label label22 = this.Label22;
    object obj13 = componentResourceManager.GetObject("Label22.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label22).Location = pointF13;
    ((ARControl) this.Label22).Name = "Label22";
    ((ARControl) this.Label22).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label22.Text = "Control No";
    ((ARControl) this.Label23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label23).Border.TopStyle = (BorderLineStyle) 0;
    this.Label23.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label23.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label23.HyperLink = (string) null;
    Label label23 = this.Label23;
    object obj14 = componentResourceManager.GetObject("Label23.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label23).Location = pointF14;
    ((ARControl) this.Label23).Name = "Label23";
    ((ARControl) this.Label23).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label23.Text = "Carrier";
    ((ARControl) this.Label24).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label24).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label24).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label24).Border.TopStyle = (BorderLineStyle) 0;
    this.Label24.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label24.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label24.HyperLink = (string) null;
    Label label24 = this.Label24;
    object obj15 = componentResourceManager.GetObject("Label24.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label24).Location = pointF15;
    ((ARControl) this.Label24).Name = "Label24";
    ((ARControl) this.Label24).Size = new SizeF(17f / 16f, 3f / 16f);
    this.Label24.Text = "Policy";
    this.Label25.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label25).Border.TopStyle = (BorderLineStyle) 0;
    this.Label25.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label25.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label25.HyperLink = (string) null;
    Label label25 = this.Label25;
    object obj16 = componentResourceManager.GetObject("Label25.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label25).Location = pointF16;
    ((ARControl) this.Label25).Name = "Label25";
    ((ARControl) this.Label25).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label25.Text = "Remitter Comm";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "InvoiceDate";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj17 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox1).Location = pointF17;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(9f / 16f, 3f / 16f);
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "EffectiveDate";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj18 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox2).Location = pointF18;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox2).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "ExpirationDate";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj19 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox3).Location = pointF19;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox3).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "Insured";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj20 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox4).Location = pointF20;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(23f / 16f, 3f / 16f);
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "Producer";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj21 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox5).Location = pointF21;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(1.375f, 3f / 16f);
    this.TextBox5.Text = " ";
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "Premium";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj22 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox7).Location = pointF22;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox7).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox7.Text = " ";
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "NetBilled";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj23 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox8).Location = pointF23;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox19).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).DataField = "PolicyType";
    this.TextBox19.DistinctField = (string) null;
    this.TextBox19.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox19.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox19 = this.TextBox19;
    object obj24 = componentResourceManager.GetObject("TextBox19.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox19).Location = pointF24;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = (string) null;
    ((ARControl) this.TextBox19).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox19.Text = " ";
    ((ARControl) this.txtQuoteControlNum).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).DataField = "QuoteControlNum";
    this.txtQuoteControlNum.DistinctField = (string) null;
    this.txtQuoteControlNum.Font = new Font("Arial", 6.75f, FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.txtQuoteControlNum.ForeColor = Color.Blue;
    TextBox txtQuoteControlNum = this.txtQuoteControlNum;
    object obj25 = componentResourceManager.GetObject("txtQuoteControlNum.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) txtQuoteControlNum).Location = pointF25;
    ((ARControl) this.txtQuoteControlNum).Name = "txtQuoteControlNum";
    this.txtQuoteControlNum.OutputFormat = (string) null;
    ((ARControl) this.txtQuoteControlNum).Size = new SizeF(9f / 16f, 3f / 16f);
    ((ARControl) this.Producer1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).DataField = "Carrier";
    this.Producer1.DistinctField = (string) null;
    this.Producer1.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Producer1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox producer1 = this.Producer1;
    object obj26 = componentResourceManager.GetObject("Producer1.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) producer1).Location = pointF26;
    ((ARControl) this.Producer1).Name = "Producer1";
    this.Producer1.OutputFormat = (string) null;
    ((ARControl) this.Producer1).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Producer1.Text = " ";
    ((ARControl) this.Insured1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).DataField = "PolicyNumber";
    this.Insured1.DistinctField = (string) null;
    this.Insured1.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Insured1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox insured1 = this.Insured1;
    object obj27 = componentResourceManager.GetObject("Insured1.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) insured1).Location = pointF27;
    ((ARControl) this.Insured1).Name = "Insured1";
    this.Insured1.OutputFormat = (string) null;
    ((ARControl) this.Insured1).Size = new SizeF(17f / 16f, 3f / 16f);
    this.Insured1.Text = " ";
    this.NetBilled1.Alignment = (TextAlignment) 2;
    ((ARControl) this.NetBilled1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).DataField = "RemitterCommission";
    this.NetBilled1.DistinctField = (string) null;
    this.NetBilled1.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.NetBilled1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox netBilled1 = this.NetBilled1;
    object obj28 = componentResourceManager.GetObject("NetBilled1.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) netBilled1).Location = pointF28;
    ((ARControl) this.NetBilled1).Name = "NetBilled1";
    this.NetBilled1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.NetBilled1).Size = new SizeF(13f / 16f, 3f / 16f);
    this.NetBilled1.Text = " ";
    this.TextBox15.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).DataField = "Premium";
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox15.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox15 = this.TextBox15;
    object obj29 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) textBox15).Location = pointF29;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox15).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox15.SummaryGroup = "ghCriteria2";
    this.TextBox15.SummaryRunning = (SummaryRunning) 1;
    this.TextBox15.SummaryType = (SummaryType) 3;
    this.TextBox15.Text = " ";
    this.TextBox16.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "NetBilled";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox16 = this.TextBox16;
    object obj30 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) textBox16).Location = pointF30;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox16).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox16.SummaryGroup = "ghCriteria2";
    this.TextBox16.SummaryRunning = (SummaryRunning) 1;
    this.TextBox16.SummaryType = (SummaryType) 3;
    this.TextBox16.Text = " ";
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 6.75f, FontStyle.Bold);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj31 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) label16).Location = pointF31;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label16.Text = "Totals:";
    this.lblCriteria2FooterText.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblCriteria2FooterText).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2FooterText).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2FooterText).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2FooterText).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCriteria2FooterText.Font = new Font("Arial", 6.75f, FontStyle.Bold);
    this.lblCriteria2FooterText.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCriteria2FooterText.HyperLink = (string) null;
    Label criteria2FooterText = this.lblCriteria2FooterText;
    object obj32 = componentResourceManager.GetObject("lblCriteria2FooterText.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) criteria2FooterText).Location = pointF32;
    ((ARControl) this.lblCriteria2FooterText).Name = "lblCriteria2FooterText";
    ((ARControl) this.lblCriteria2FooterText).Size = new SizeF(6.125f, 3f / 16f);
    this.lblCriteria2FooterText.Text = "";
    ((ARControl) this.txtUnderWriterItemCount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderWriterItemCount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderWriterItemCount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderWriterItemCount).Border.TopStyle = (BorderLineStyle) 0;
    this.txtUnderWriterItemCount.DistinctField = (string) null;
    this.txtUnderWriterItemCount.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtUnderWriterItemCount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox underWriterItemCount = this.txtUnderWriterItemCount;
    object obj33 = componentResourceManager.GetObject("txtUnderWriterItemCount.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) underWriterItemCount).Location = pointF33;
    ((ARControl) this.txtUnderWriterItemCount).Name = "txtUnderWriterItemCount";
    this.txtUnderWriterItemCount.OutputFormat = (string) null;
    ((ARControl) this.txtUnderWriterItemCount).Size = new SizeF(1f, 3f / 16f);
    this.NetBilled2.Alignment = (TextAlignment) 2;
    ((ARControl) this.NetBilled2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled2).DataField = "RemitterCommission";
    this.NetBilled2.DistinctField = (string) null;
    this.NetBilled2.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.NetBilled2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox netBilled2 = this.NetBilled2;
    object obj34 = componentResourceManager.GetObject("NetBilled2.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) netBilled2).Location = pointF34;
    ((ARControl) this.NetBilled2).Name = "NetBilled2";
    this.NetBilled2.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.NetBilled2).Size = new SizeF(13f / 16f, 3f / 16f);
    this.NetBilled2.SummaryGroup = "ghCriteria2";
    this.NetBilled2.SummaryRunning = (SummaryRunning) 1;
    this.NetBilled2.SummaryType = (SummaryType) 3;
    this.NetBilled2.Text = " ";
    this.TextBox11.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "Premium";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj35 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) textBox11).Location = pointF35;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox11).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox11.SummaryGroup = "ghCriteria1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 3;
    this.TextBox11.Text = " ";
    this.TextBox12.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "NetBilled";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj36 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) textBox12).Location = pointF36;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox12).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox12.SummaryGroup = "ghCriteria1";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 3;
    this.TextBox12.Text = " ";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj37 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) label12).Location = pointF37;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label12.Text = "Totals:";
    this.lblCriteria1FooterText.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblCriteria1FooterText).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1FooterText).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1FooterText).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1FooterText).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCriteria1FooterText.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCriteria1FooterText.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCriteria1FooterText.HyperLink = (string) null;
    Label criteria1FooterText = this.lblCriteria1FooterText;
    object obj38 = componentResourceManager.GetObject("lblCriteria1FooterText.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) criteria1FooterText).Location = pointF38;
    ((ARControl) this.lblCriteria1FooterText).Name = "lblCriteria1FooterText";
    ((ARControl) this.lblCriteria1FooterText).Size = new SizeF(6.125f, 3f / 16f);
    this.lblCriteria1FooterText.Text = "";
    ((ARControl) this.txtMonthItemCount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMonthItemCount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMonthItemCount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMonthItemCount).Border.TopStyle = (BorderLineStyle) 0;
    this.txtMonthItemCount.DistinctField = (string) null;
    this.txtMonthItemCount.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtMonthItemCount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtMonthItemCount = this.txtMonthItemCount;
    object obj39 = componentResourceManager.GetObject("txtMonthItemCount.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) txtMonthItemCount).Location = pointF39;
    ((ARControl) this.txtMonthItemCount).Name = "txtMonthItemCount";
    this.txtMonthItemCount.OutputFormat = (string) null;
    ((ARControl) this.txtMonthItemCount).Size = new SizeF(1f, 3f / 16f);
    this.NetBilled3.Alignment = (TextAlignment) 2;
    ((ARControl) this.NetBilled3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled3).DataField = "RemitterCommission";
    this.NetBilled3.DistinctField = (string) null;
    this.NetBilled3.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.NetBilled3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox netBilled3 = this.NetBilled3;
    object obj40 = componentResourceManager.GetObject("NetBilled3.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) netBilled3).Location = pointF40;
    ((ARControl) this.NetBilled3).Name = "NetBilled3";
    this.NetBilled3.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.NetBilled3).Size = new SizeF(13f / 16f, 3f / 16f);
    this.NetBilled3.SummaryGroup = "ghCriteria1";
    this.NetBilled3.SummaryRunning = (SummaryRunning) 1;
    this.NetBilled3.SummaryType = (SummaryType) 3;
    this.NetBilled3.Text = " ";
    ((ARControl) this.Label21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.TopStyle = (BorderLineStyle) 0;
    this.Label21.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label21.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label21.HyperLink = (string) null;
    Label label21 = this.Label21;
    object obj41 = componentResourceManager.GetObject("Label21.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) label21).Location = pointF41;
    ((ARControl) this.Label21).Name = "Label21";
    ((ARControl) this.Label21).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label21.Text = "Totals:";
    this.TextBox27.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox27).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).DataField = "NetBilled";
    this.TextBox27.DistinctField = (string) null;
    this.TextBox27.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox27.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox27 = this.TextBox27;
    object obj42 = componentResourceManager.GetObject("TextBox27.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) textBox27).Location = pointF42;
    ((ARControl) this.TextBox27).Name = "TextBox27";
    this.TextBox27.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox27).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox27.SummaryGroup = "ghTotal";
    this.TextBox27.SummaryRunning = (SummaryRunning) 2;
    this.TextBox27.SummaryType = (SummaryType) 1;
    this.TextBox27.Text = " ";
    this.TextBox26.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox26).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).DataField = "Premium";
    this.TextBox26.DistinctField = (string) null;
    this.TextBox26.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox26.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox26 = this.TextBox26;
    object obj43 = componentResourceManager.GetObject("TextBox26.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) textBox26).Location = pointF43;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox26).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox26.SummaryGroup = "ghTotal";
    this.TextBox26.SummaryRunning = (SummaryRunning) 2;
    this.TextBox26.SummaryType = (SummaryType) 1;
    this.TextBox26.Text = " ";
    ((ARControl) this.txtTotalItems).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalItems).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalItems).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalItems).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTotalItems.DistinctField = (string) null;
    this.txtTotalItems.Font = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtTotalItems.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTotalItems = this.txtTotalItems;
    object obj44 = componentResourceManager.GetObject("txtTotalItems.Location");
    PointF pointF44 = obj44 != null ? (PointF) obj44 : new PointF();
    ((ARControl) txtTotalItems).Location = pointF44;
    ((ARControl) this.txtTotalItems).Name = "txtTotalItems";
    this.txtTotalItems.OutputFormat = (string) null;
    ((ARControl) this.txtTotalItems).Size = new SizeF(1f, 3f / 16f);
    this.NetBilled4.Alignment = (TextAlignment) 2;
    ((ARControl) this.NetBilled4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled4).DataField = "RemitterCommission";
    this.NetBilled4.DistinctField = (string) null;
    this.NetBilled4.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.NetBilled4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox netBilled4 = this.NetBilled4;
    object obj45 = componentResourceManager.GetObject("NetBilled4.Location");
    PointF pointF45 = obj45 != null ? (PointF) obj45 : new PointF();
    ((ARControl) netBilled4).Location = pointF45;
    ((ARControl) this.NetBilled4).Name = "NetBilled4";
    this.NetBilled4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.NetBilled4).Size = new SizeF(13f / 16f, 3f / 16f);
    this.NetBilled4.SummaryGroup = "ghTotal";
    this.NetBilled4.SummaryRunning = (SummaryRunning) 2;
    this.NetBilled4.SummaryType = (SummaryType) 1;
    this.NetBilled4.Text = " ";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperName = "";
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTotal);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotal);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtSubTitle).EndInit();
    ((ISupportInitialize) this.lblCriteria1Title).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.lblCriteria2Title).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.Label23).EndInit();
    ((ISupportInitialize) this.Label24).EndInit();
    ((ISupportInitialize) this.Label25).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.txtQuoteControlNum).EndInit();
    ((ISupportInitialize) this.Producer1).EndInit();
    ((ISupportInitialize) this.Insured1).EndInit();
    ((ISupportInitialize) this.NetBilled1).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.lblCriteria2FooterText).EndInit();
    ((ISupportInitialize) this.txtUnderWriterItemCount).EndInit();
    ((ISupportInitialize) this.NetBilled2).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.lblCriteria1FooterText).EndInit();
    ((ISupportInitialize) this.txtMonthItemCount).EndInit();
    ((ISupportInitialize) this.NetBilled3).EndInit();
    ((ISupportInitialize) this.Label21).EndInit();
    ((ISupportInitialize) this.TextBox27).EndInit();
    ((ISupportInitialize) this.TextBox26).EndInit();
    ((ISupportInitialize) this.txtTotalItems).EndInit();
    ((ISupportInitialize) this.NetBilled4).EndInit();
  }

  public rptProductionReportWithoutMGAComm()
  {
    this.ReportStart += new EventHandler(this.rptProductionReportWithoutMGAComm_ReportStart);
    this._UnderWriterItemCount = 0;
    this._MonthlyItemCount = 0;
    this._TotalItemCount = 0;
  }

  public rptProductionReportWithoutMGAComm(
    DateTime billingDateFrom,
    DateTime billingDateTo,
    DateTime effectiveDateFrom,
    DateTime effectiveDateTo,
    Guid underwriterGuid,
    Guid inhouseProducerGuid,
    Guid producerGuid,
    int PolicyTypeID,
    Guid companyGuid,
    Guid companyLocationGuid,
    Guid LineGuid,
    int IssuingOfficeID,
    Guid ProducerLocationGuid,
    string SortBy)
  {
    this.ReportStart += new EventHandler(this.rptProductionReportWithoutMGAComm_ReportStart);
    this._UnderWriterItemCount = 0;
    this._MonthlyItemCount = 0;
    this._TotalItemCount = 0;
    this.InitializeComponent();
    this._billingDateFrom = billingDateFrom;
    this._billingDateTo = billingDateTo;
    this._effectiveDateFrom = effectiveDateFrom;
    this._effectiveDateTo = effectiveDateTo;
    this._underwriterGuid = underwriterGuid;
    this._producerGuid = producerGuid;
    this._policyTypeID = PolicyTypeID;
    this._inhouseProducerGuid = inhouseProducerGuid;
    this._companyGuid = companyGuid;
    this._companyLocationGuid = companyLocationGuid;
    this._lineGuid = LineGuid;
    this._issuingOfficeID = IssuingOfficeID;
    this._ProducerLocationGuid = ProducerLocationGuid;
    this._SortBy = SortBy;
    string[] strArray = Strings.Split(SortBy, ",");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray[0], "MonthNumeric", false) == 0)
    {
      this.ghCriteria1.DataField = "MonthNumeric";
      ((ARControl) this.lblCriteria1Title).DataField = "Month";
      ((ARControl) this.lblCriteria1FooterText).DataField = "Month";
    }
    else
    {
      this.ghCriteria1.DataField = strArray[0];
      ((ARControl) this.lblCriteria1Title).DataField = strArray[0];
      ((ARControl) this.lblCriteria1FooterText).DataField = strArray[0];
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray[1], "MonthNumeric", false) == 0)
    {
      this.ghCriteria2.DataField = "MonthNumeric";
      ((ARControl) this.lblCriteria2Title).DataField = "Month";
      ((ARControl) this.lblCriteria2FooterText).DataField = "Month";
    }
    else
    {
      this.ghCriteria2.DataField = strArray[1];
      ((ARControl) this.lblCriteria2Title).DataField = strArray[1];
      ((ARControl) this.lblCriteria2FooterText).DataField = strArray[1];
    }
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = ^(local = ref this._UnderWriterItemCount) + 1;
    local = num;
    if (this.txtQuoteControlNum.Text != null)
      this.txtQuoteControlNum.HyperLink = this.txtQuoteControlNum.Text.ToString();
    this.SetDetailControlsHeight();
  }

  private void gfCriteria2_BeforePrint(object sender, EventArgs e)
  {
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = ^(local = ref this._MonthlyItemCount) + this._UnderWriterItemCount;
    local = num;
    this.txtUnderWriterItemCount.Text = this._UnderWriterItemCount.ToString() + " ITEMS";
    this._UnderWriterItemCount = 0;
  }

  private void gfCriteria1_BeforePrint(object sender, EventArgs e)
  {
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = ^(local = ref this._TotalItemCount) + this._MonthlyItemCount;
    local = num;
    this.txtMonthItemCount.Text = this._MonthlyItemCount.ToString() + " ITEMS";
    this._MonthlyItemCount = 0;
  }

  private void gfTotal_BeforePrint(object sender, EventArgs e)
  {
    this.txtTotalItems.Value = (object) this._TotalItemCount;
    this.txtTotalItems.Text = this._TotalItemCount.ToString() + " ITEMS";
  }

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.LaunchPolicyDetailScreen, (object) Conversions.ToInteger(e.HyperLink));
  }

  private void rptProductionReportWithoutMGAComm_ReportStart(object sender, EventArgs e)
  {
    ArrayList arrayList = new ArrayList();
    DateTime date;
    if (DateTime.Compare(this._billingDateFrom, DateTime.MinValue) != 0)
    {
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@billingDateFrom",
        (object) this._billingDateFrom.Date
      });
      TextBox txtSubTitle;
      string text = (txtSubTitle = this.txtSubTitle).Text;
      date = this._billingDateFrom.Date;
      string str1 = date.ToString("MM/dd/yyyy");
      string str2 = $"{text} Billing Date After {str1}";
      txtSubTitle.Text = str2;
    }
    if (DateTime.Compare(this._billingDateTo, DateTime.MinValue) != 0)
    {
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@billingDateTo",
        (object) this._billingDateTo.Date
      });
      TextBox txtSubTitle;
      string text = (txtSubTitle = this.txtSubTitle).Text;
      date = this._billingDateTo.Date;
      string str3 = date.ToString("MM/dd/yyyy");
      string str4 = $"{text} Billing Date To {str3}";
      txtSubTitle.Text = str4;
    }
    if (DateTime.Compare(this._effectiveDateFrom, DateTime.MinValue) != 0)
    {
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@effectiveDateFrom",
        (object) this._effectiveDateFrom.Date
      });
      TextBox txtSubTitle;
      string text = (txtSubTitle = this.txtSubTitle).Text;
      date = this._effectiveDateFrom.Date;
      string str5 = date.ToString("MM/dd/yyyy");
      string str6 = $"{text} Effective Date From {str5}";
      txtSubTitle.Text = str6;
    }
    if (DateTime.Compare(this._effectiveDateTo, DateTime.MinValue) != 0)
    {
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@effectiveDateTo",
        (object) this._effectiveDateTo.Date
      });
      TextBox txtSubTitle;
      string text = (txtSubTitle = this.txtSubTitle).Text;
      date = this._effectiveDateTo.Date;
      string str7 = date.ToString("MM/dd/yyyy");
      string str8 = $"{text} Effective Date To {str7}";
      txtSubTitle.Text = str8;
    }
    if (!this._underwriterGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@underwriterGuid",
        (object) this._underwriterGuid
      });
    if (!this._inhouseProducerGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@inHouseProducerGuid",
        (object) this._inhouseProducerGuid
      });
    if (!this._producerGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@producerGuid",
        (object) this._producerGuid
      });
    if (this._policyTypeID != -1)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@policyTypeID",
        (object) this._policyTypeID
      });
    if (!this._companyGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@companyGuid",
        (object) this._companyGuid
      });
    if (!this._companyLocationGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@companyLocationGuid",
        (object) this._companyLocationGuid
      });
    if (!this._lineGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@lineGuid",
        (object) this._lineGuid
      });
    if (this._issuingOfficeID != -1)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@IssuingOfficeID",
        (object) this._issuingOfficeID
      });
    if (!this._ProducerLocationGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@ProducerLocationGuid",
        (object) this._ProducerLocationGuid
      });
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals((object) string.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@CurrentUserGuid",
        (object) this.CurrentUserGuid
      });
    DataTable table = DefaultDatabase.ExecuteDataTable("dbo.spFin_rptProductionReportWithoutMGAComm", arrayList.ToArray());
    if (table.Rows.Count > 0)
    {
      table.Columns.Add("Month", typeof (string));
      table.Columns.Add("MonthNumeric", typeof (string));
      try
      {
        foreach (DataRow row in table.Rows)
        {
          DataRow dataRow1 = row;
          date = Conversions.ToDate(row["InvoiceDate"]);
          string str9 = date.ToString("MMMM");
          dataRow1["Month"] = (object) str9;
          DataRow dataRow2 = row;
          date = Conversions.ToDate(row["InvoiceDate"]);
          string str10 = date.ToString("MM");
          dataRow2["MonthNumeric"] = (object) str10;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this._dv = new DataView(table, "", this._SortBy, DataViewRowState.CurrentRows);
      this.DataSource = (object) this._dv;
    }
    this.ShowPageNumbers();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[12]
      {
        (BaseReportControl) new DateRangePicker("Billing Date", true),
        (BaseReportControl) new DateRangePicker("Effective Date", true),
        (BaseReportControl) (!SecurityManager.Instance.AssertPermission("{73B68203-E6EC-483f-B6AD-51B856DBC89E}") ? new Underwriters("Underwriter", CurrentUser.Instance.UserGUID) : new Underwriters("Underwriter", true)),
        (BaseReportControl) new InHouseProducers("Inhouse Producer", true),
        (BaseReportControl) new Producers("Producer", true),
        (BaseReportControl) new GenericComboBox("Policy Type", "(SELECT -1 AS PolicyTypeID, 'All Types' AS Description, -1 AS SORT) UNION (SELECT PolicyTypeID, Description, 0 AS SORT FROM lstPolicyTypes) ORDER BY SORT, Description", "PolicyTypeID", "Description", typeof (int)),
        (BaseReportControl) new Companies("Company", true, new Guid[0]),
        (BaseReportControl) new CompanyLocations("Company Location", true),
        (BaseReportControl) new CompanyLines("Line", true),
        (BaseReportControl) (!SecurityManager.Instance.AssertPermission("{07E94EBD-A35F-4449-B650-DB54B8DD73A3}") ? new OfficeLocations("Issuing Office", CurrentUser.Instance.UserGUID, true) : new OfficeLocations("Issuing Office", true, true)),
        (BaseReportControl) new ProducerLocations("Producer Location", true),
        (BaseReportControl) new OrderBy(new string[14]
        {
          "Month",
          "MonthNumeric",
          "In House Producer",
          "InHouseProducer",
          "Invoice Date",
          "InvoiceDate",
          "Insured",
          "Insured",
          "Control Number",
          "QuoteControlNum",
          "Producer",
          "Producer",
          "Underwriter",
          "Underwriter"
        })
      };
    }
  }

  public override void ExportToExcel(string FileName)
  {
    if (this.DataSource == null)
      return;
    DataTable source = new DataTable();
    DataColumnCollection columns = source.Columns;
    columns.Add("Month", typeof (string));
    columns.Add("Underwriter", typeof (string));
    columns.Add("Date Billed", typeof (DateTime));
    columns.Add("Effective Date", typeof (DateTime));
    columns.Add("Expiration Date", typeof (DateTime));
    columns.Add("Policy #", typeof (string));
    columns.Add("Insured", typeof (string));
    columns.Add("Producer", typeof (string));
    columns.Add("Carrier", typeof (string));
    columns.Add("Control No", typeof (int));
    columns.Add("Policy Type", typeof (string));
    columns.Add("Premium", typeof (Decimal));
    columns.Add("NetBilled", typeof (Decimal));
    columns.Add("Remitter Comm", typeof (Decimal));
    try
    {
      foreach (DataRow row1 in this._dv.Table.Rows)
      {
        DataRow row2 = source.NewRow();
        row2["Month"] = (object) Conversions.ToDate(row1["InvoiceDate"]).ToString("MMMM");
        row2["Underwriter"] = RuntimeHelpers.GetObjectValue(row1["Underwriter"]);
        row2["Date Billed"] = RuntimeHelpers.GetObjectValue(row1["InvoiceDate"]);
        row2["Effective Date"] = RuntimeHelpers.GetObjectValue(row1["EffectiveDate"]);
        row2["Expiration Date"] = RuntimeHelpers.GetObjectValue(row1["ExpirationDate"]);
        row2["Policy #"] = RuntimeHelpers.GetObjectValue(row1["PolicyNumber"]);
        row2["Insured"] = RuntimeHelpers.GetObjectValue(row1["Insured"]);
        row2["Producer"] = RuntimeHelpers.GetObjectValue(row1["Producer"]);
        row2["Carrier"] = RuntimeHelpers.GetObjectValue(row1["Carrier"]);
        row2["Control No"] = RuntimeHelpers.GetObjectValue(row1["QuoteControlNum"]);
        row2["Policy Type"] = RuntimeHelpers.GetObjectValue(row1["PolicyType"]);
        row2["Premium"] = RuntimeHelpers.GetObjectValue(row1["Premium"]);
        row2["NetBilled"] = RuntimeHelpers.GetObjectValue(row1["NetBilled"]);
        row2["Remitter Comm"] = RuntimeHelpers.GetObjectValue(row1["RemitterCommission"]);
        source.Rows.Add(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ExcelExport.ToExcel(source, FileName);
    source.Dispose();
  }
}
