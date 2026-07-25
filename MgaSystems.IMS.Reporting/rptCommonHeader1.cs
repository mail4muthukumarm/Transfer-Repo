// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCommonHeader1
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptCommonHeader1 : SectionReport
{
  private Guid _QuoteOptionGuid;
  private readonly bool _IsQuote;
  private readonly bool _ShowOfficeName;
  private Label lblLOB;
  private TextBox txtHeader_OfficeName;
  private TextBox txtHeader_OfficeAddress;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private TextBox txtHeader_OfficePhone;
  private TextBox txtHeader_OfficeFax;
  private TextBox txtHeader_Date;
  private Line Line;
  private Line Line1;
  private Label Label4;
  private Label Label5;
  private TextBox txtHeader_Copy;
  private Label Label6;
  private Label Label7;
  private TextBox txtHeader_ProducerPhone;
  private TextBox txtHeader_ProducerFax;
  private Label Label8;
  private TextBox txtBody_Carrier;
  private Label Label9;
  private TextBox txtBody_CoverageType;
  private Label Label10;
  private TextBox txtBody_NamedInsured;
  private Label Label11;
  private Label Label12;
  private TextBox txtBody_EffectiveDate;
  private TextBox txtBody_ExpirationDate;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox LOB;
  private Label lblPolicyNumber;
  private TextBox txtPolicyNumber;

  public rptCommonHeader1(Guid QuoteOptionGuid, bool IsQuote, bool ShowOfficeName)
  {
    this._ShowOfficeName = true;
    this.InitializeComponent();
    this._QuoteOptionGuid = QuoteOptionGuid;
    this._IsQuote = IsQuote;
    this._ShowOfficeName = ShowOfficeName;
    this.ReportStart += new EventHandler(this.rptCommonHeader1_ReportStart);
  }

  public rptCommonHeader1(Guid QuoteOptionGuid, bool IsQuote)
  {
    this._ShowOfficeName = true;
    this.InitializeComponent();
    this._QuoteOptionGuid = QuoteOptionGuid;
    this._IsQuote = IsQuote;
    this.ReportStart += new EventHandler(this.rptCommonHeader1_ReportStart);
  }

  public rptCommonHeader1(DataTable Info, bool IsQuote)
  {
    this._ShowOfficeName = true;
    this.InitializeComponent();
    this.DataSource = (object) Info;
    this._IsQuote = IsQuote;
  }

  private void rptCommonHeader1_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable(nameof (rptCommonHeader1), new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) this._QuoteOptionGuid
    });
    ((ARControl) this.lblPolicyNumber).Visible = !this._IsQuote;
    ((ARControl) this.txtPolicyNumber).Visible = !this._IsQuote;
    if (this._ShowOfficeName)
      return;
    ((ARControl) this.txtHeader_OfficeName).Visible = false;
    ((ARControl) this.txtHeader_OfficeAddress).Top = ((ARControl) this.txtHeader_OfficeName).Top;
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (this._IsQuote)
      this.lblLOB.Text = string.Format(this.lblLOB.Text, (object) this.LOB.Text, (object) "Quote");
    else
      this.lblLOB.Text = string.Format(this.lblLOB.Text, (object) this.LOB.Text, (object) "Binder");
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCommonHeader1));
    this.Detail = new Detail();
    this.lblLOB = new Label();
    this.txtHeader_OfficeName = new TextBox();
    this.txtHeader_OfficeAddress = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.txtHeader_OfficePhone = new TextBox();
    this.txtHeader_OfficeFax = new TextBox();
    this.txtHeader_Date = new TextBox();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.txtHeader_Copy = new TextBox();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.txtHeader_ProducerPhone = new TextBox();
    this.txtHeader_ProducerFax = new TextBox();
    this.Label8 = new Label();
    this.txtBody_Carrier = new TextBox();
    this.Label9 = new Label();
    this.txtBody_CoverageType = new TextBox();
    this.Label10 = new Label();
    this.txtBody_NamedInsured = new TextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.txtBody_EffectiveDate = new TextBox();
    this.txtBody_ExpirationDate = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.LOB = new TextBox();
    this.lblPolicyNumber = new Label();
    this.txtPolicyNumber = new TextBox();
    ((ISupportInitialize) this.lblLOB).BeginInit();
    ((ISupportInitialize) this.txtHeader_OfficeName).BeginInit();
    ((ISupportInitialize) this.txtHeader_OfficeAddress).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.txtHeader_OfficePhone).BeginInit();
    ((ISupportInitialize) this.txtHeader_OfficeFax).BeginInit();
    ((ISupportInitialize) this.txtHeader_Date).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtHeader_Copy).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtHeader_ProducerPhone).BeginInit();
    ((ISupportInitialize) this.txtHeader_ProducerFax).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.txtBody_Carrier).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtBody_CoverageType).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.txtBody_NamedInsured).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.txtBody_EffectiveDate).BeginInit();
    ((ISupportInitialize) this.txtBody_ExpirationDate).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.LOB).BeginInit();
    ((ISupportInitialize) this.lblPolicyNumber).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[33]
    {
      (ARControl) this.lblLOB,
      (ARControl) this.txtHeader_OfficeName,
      (ARControl) this.txtHeader_OfficeAddress,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.txtHeader_OfficePhone,
      (ARControl) this.txtHeader_OfficeFax,
      (ARControl) this.txtHeader_Date,
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.txtHeader_Copy,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.txtHeader_ProducerPhone,
      (ARControl) this.txtHeader_ProducerFax,
      (ARControl) this.Label8,
      (ARControl) this.txtBody_Carrier,
      (ARControl) this.Label9,
      (ARControl) this.txtBody_CoverageType,
      (ARControl) this.Label10,
      (ARControl) this.txtBody_NamedInsured,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.txtBody_EffectiveDate,
      (ARControl) this.txtBody_ExpirationDate,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.LOB,
      (ARControl) this.lblPolicyNumber,
      (ARControl) this.txtPolicyNumber
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 91f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.lblLOB.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblLOB).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblLOB).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblLOB).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblLOB).Border.TopStyle = (BorderLineStyle) 0;
    this.lblLOB.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblLOB.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblLOB.HyperLink = (string) null;
    Label lblLob = this.lblLOB;
    object obj1 = componentResourceManager.GetObject("lblLOB.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblLob).Location = pointF1;
    ((ARControl) this.lblLOB).Name = "lblLOB";
    ((ARControl) this.lblLOB).Size = new SizeF(7.875f, 0.25f);
    this.lblLOB.Text = "{0} {1}";
    ((ARControl) this.txtHeader_OfficeName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeName).DataField = "Office";
    this.txtHeader_OfficeName.DistinctField = (string) null;
    this.txtHeader_OfficeName.Font = new Font("Arial", 11f);
    this.txtHeader_OfficeName.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerOfficeName = this.txtHeader_OfficeName;
    object obj2 = componentResourceManager.GetObject("txtHeader_OfficeName.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) headerOfficeName).Location = pointF2;
    ((ARControl) this.txtHeader_OfficeName).Name = "txtHeader_OfficeName";
    this.txtHeader_OfficeName.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_OfficeName).Size = new SizeF(4f, 3f / 16f);
    ((ARControl) this.txtHeader_OfficeAddress).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeAddress).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeAddress).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeAddress).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeAddress).DataField = "OfficeAddress";
    this.txtHeader_OfficeAddress.DistinctField = (string) null;
    this.txtHeader_OfficeAddress.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_OfficeAddress.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerOfficeAddress = this.txtHeader_OfficeAddress;
    object obj3 = componentResourceManager.GetObject("txtHeader_OfficeAddress.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) headerOfficeAddress).Location = pointF3;
    ((ARControl) this.txtHeader_OfficeAddress).Name = "txtHeader_OfficeAddress";
    this.txtHeader_OfficeAddress.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_OfficeAddress).Size = new SizeF(4f, 9f / 16f);
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj4 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label1).Location = pointF4;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(0.75f, 3f / 16f);
    this.Label1.Text = "Phone:";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj5 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label2).Location = pointF5;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.75f, 3f / 16f);
    this.Label2.Text = "Fax:";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj6 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label3).Location = pointF6;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.75f, 3f / 16f);
    this.Label3.Text = "Date:";
    ((ARControl) this.txtHeader_OfficePhone).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficePhone).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficePhone).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficePhone).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficePhone).DataField = "OfficePhone";
    this.txtHeader_OfficePhone.DistinctField = (string) null;
    this.txtHeader_OfficePhone.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_OfficePhone.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerOfficePhone = this.txtHeader_OfficePhone;
    object obj7 = componentResourceManager.GetObject("txtHeader_OfficePhone.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) headerOfficePhone).Location = pointF7;
    ((ARControl) this.txtHeader_OfficePhone).Name = "txtHeader_OfficePhone";
    this.txtHeader_OfficePhone.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_OfficePhone).Size = new SizeF(1.125f, 3f / 16f);
    this.txtHeader_OfficePhone.Text = " ";
    ((ARControl) this.txtHeader_OfficeFax).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeFax).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeFax).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeFax).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_OfficeFax).DataField = "OfficeFax";
    this.txtHeader_OfficeFax.DistinctField = (string) null;
    this.txtHeader_OfficeFax.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_OfficeFax.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderOfficeFax = this.txtHeader_OfficeFax;
    object obj8 = componentResourceManager.GetObject("txtHeader_OfficeFax.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) txtHeaderOfficeFax).Location = pointF8;
    ((ARControl) this.txtHeader_OfficeFax).Name = "txtHeader_OfficeFax";
    this.txtHeader_OfficeFax.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_OfficeFax).Size = new SizeF(1.125f, 3f / 16f);
    this.txtHeader_OfficeFax.Text = " ";
    ((ARControl) this.txtHeader_Date).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Date).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Date).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Date).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Date).DataField = "CurrentDate";
    this.txtHeader_Date.DistinctField = (string) null;
    this.txtHeader_Date.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_Date.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderDate = this.txtHeader_Date;
    object obj9 = componentResourceManager.GetObject("txtHeader_Date.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) txtHeaderDate).Location = pointF9;
    ((ARControl) this.txtHeader_Date).Name = "txtHeader_Date";
    this.txtHeader_Date.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_Date).Size = new SizeF(1.125f, 3f / 16f);
    this.txtHeader_Date.Text = " ";
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    this.Line.X1 = 0.0f;
    this.Line.X2 = 7.875f;
    this.Line.Y1 = 19f / 16f;
    this.Line.Y2 = 19f / 16f;
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 7.875f;
    this.Line1.Y1 = 1.885417f;
    this.Line1.Y2 = 1.885417f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj10 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label4).Location = pointF10;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1f, 3f / 16f);
    this.Label4.Text = "Producer:";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj11 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label5).Location = pointF11;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1f, 3f / 16f);
    this.Label5.Text = "Attn:";
    ((ARControl) this.txtHeader_Copy).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Copy).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Copy).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Copy).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_Copy.DistinctField = (string) null;
    this.txtHeader_Copy.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_Copy.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderCopy = this.txtHeader_Copy;
    object obj12 = componentResourceManager.GetObject("txtHeader_Copy.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtHeaderCopy).Location = pointF12;
    ((ARControl) this.txtHeader_Copy).Name = "txtHeader_Copy";
    this.txtHeader_Copy.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_Copy).Size = new SizeF(7.875f, 3f / 16f);
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj13 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label6).Location = pointF13;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(0.75f, 3f / 16f);
    this.Label6.Text = "Phone:";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj14 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label7).Location = pointF14;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(0.75f, 3f / 16f);
    this.Label7.Text = "Fax:";
    ((ARControl) this.txtHeader_ProducerPhone).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerPhone).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerPhone).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerPhone).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerPhone).DataField = "ProducerPhone";
    this.txtHeader_ProducerPhone.DistinctField = (string) null;
    this.txtHeader_ProducerPhone.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_ProducerPhone.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerProducerPhone = this.txtHeader_ProducerPhone;
    object obj15 = componentResourceManager.GetObject("txtHeader_ProducerPhone.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) headerProducerPhone).Location = pointF15;
    ((ARControl) this.txtHeader_ProducerPhone).Name = "txtHeader_ProducerPhone";
    this.txtHeader_ProducerPhone.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_ProducerPhone).Size = new SizeF(1.125f, 3f / 16f);
    this.txtHeader_ProducerPhone.Text = " ";
    ((ARControl) this.txtHeader_ProducerFax).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerFax).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerFax).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerFax).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ProducerFax).DataField = "ProducerFax";
    this.txtHeader_ProducerFax.DistinctField = (string) null;
    this.txtHeader_ProducerFax.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_ProducerFax.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerProducerFax = this.txtHeader_ProducerFax;
    object obj16 = componentResourceManager.GetObject("txtHeader_ProducerFax.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) headerProducerFax).Location = pointF16;
    ((ARControl) this.txtHeader_ProducerFax).Name = "txtHeader_ProducerFax";
    this.txtHeader_ProducerFax.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_ProducerFax).Size = new SizeF(1.125f, 3f / 16f);
    this.txtHeader_ProducerFax.Text = " ";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj17 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label8).Location = pointF17;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.625f, 3f / 16f);
    this.Label8.Text = "Carrier:";
    ((ARControl) this.txtBody_Carrier).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_Carrier).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_Carrier).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_Carrier).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_Carrier).DataField = "CompanyName";
    this.txtBody_Carrier.DistinctField = (string) null;
    this.txtBody_Carrier.Font = new Font("Arial", 11f);
    this.txtBody_Carrier.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtBodyCarrier = this.txtBody_Carrier;
    object obj18 = componentResourceManager.GetObject("txtBody_Carrier.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) txtBodyCarrier).Location = pointF18;
    ((ARControl) this.txtBody_Carrier).Name = "txtBody_Carrier";
    this.txtBody_Carrier.OutputFormat = (string) null;
    ((ARControl) this.txtBody_Carrier).Size = new SizeF(3.625f, 3f / 16f);
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj19 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label9).Location = pointF19;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(1.25f, 3f / 16f);
    this.Label9.Text = "Coverage Type:";
    ((ARControl) this.txtBody_CoverageType).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_CoverageType).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_CoverageType).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_CoverageType).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_CoverageType).DataField = "LineName";
    this.txtBody_CoverageType.DistinctField = (string) null;
    this.txtBody_CoverageType.Font = new Font("Arial", 10f);
    this.txtBody_CoverageType.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox bodyCoverageType = this.txtBody_CoverageType;
    object obj20 = componentResourceManager.GetObject("txtBody_CoverageType.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) bodyCoverageType).Location = pointF20;
    ((ARControl) this.txtBody_CoverageType).Name = "txtBody_CoverageType";
    this.txtBody_CoverageType.OutputFormat = (string) null;
    ((ARControl) this.txtBody_CoverageType).Size = new SizeF(37f / 16f, 3f / 16f);
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj21 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) label10).Location = pointF21;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(1.25f, 3f / 16f);
    this.Label10.Text = "Named Insured:";
    ((ARControl) this.txtBody_NamedInsured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_NamedInsured).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_NamedInsured).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_NamedInsured).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_NamedInsured).DataField = "InsuredName";
    this.txtBody_NamedInsured.DistinctField = (string) null;
    this.txtBody_NamedInsured.Font = new Font("Arial", 11f);
    this.txtBody_NamedInsured.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox bodyNamedInsured = this.txtBody_NamedInsured;
    object obj22 = componentResourceManager.GetObject("txtBody_NamedInsured.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) bodyNamedInsured).Location = pointF22;
    ((ARControl) this.txtBody_NamedInsured).Name = "txtBody_NamedInsured";
    this.txtBody_NamedInsured.OutputFormat = (string) null;
    ((ARControl) this.txtBody_NamedInsured).Size = new SizeF(3f, 3f / 16f);
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj23 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label11).Location = pointF23;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(1.25f, 3f / 16f);
    this.Label11.Text = "Effective Date:";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj24 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label12).Location = pointF24;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(1.25f, 3f / 16f);
    this.Label12.Text = "Expiration Date:";
    ((ARControl) this.txtBody_EffectiveDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_EffectiveDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_EffectiveDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_EffectiveDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_EffectiveDate).DataField = "EffectiveDate";
    this.txtBody_EffectiveDate.DistinctField = (string) null;
    this.txtBody_EffectiveDate.Font = new Font("Arial", 11f);
    this.txtBody_EffectiveDate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox bodyEffectiveDate = this.txtBody_EffectiveDate;
    object obj25 = componentResourceManager.GetObject("txtBody_EffectiveDate.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) bodyEffectiveDate).Location = pointF25;
    ((ARControl) this.txtBody_EffectiveDate).Name = "txtBody_EffectiveDate";
    this.txtBody_EffectiveDate.OutputFormat = (string) null;
    ((ARControl) this.txtBody_EffectiveDate).Size = new SizeF(15f / 16f, 3f / 16f);
    ((ARControl) this.txtBody_ExpirationDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_ExpirationDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_ExpirationDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_ExpirationDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_ExpirationDate).DataField = "ExpirationDate";
    this.txtBody_ExpirationDate.DistinctField = (string) null;
    this.txtBody_ExpirationDate.Font = new Font("Arial", 11f);
    this.txtBody_ExpirationDate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox bodyExpirationDate = this.txtBody_ExpirationDate;
    object obj26 = componentResourceManager.GetObject("txtBody_ExpirationDate.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) bodyExpirationDate).Location = pointF26;
    ((ARControl) this.txtBody_ExpirationDate).Name = "txtBody_ExpirationDate";
    this.txtBody_ExpirationDate.OutputFormat = (string) null;
    ((ARControl) this.txtBody_ExpirationDate).Size = new SizeF(15f / 16f, 3f / 16f);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "ProducerName";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj27 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox6).Location = pointF27;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(79f / 16f, 3f / 16f);
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "ProducerContact";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj28 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) textBox7).Location = pointF28;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(79f / 16f, 3f / 16f);
    this.TextBox7.Text = " ";
    this.LOB.BackColor = Color.Yellow;
    ((ARControl) this.LOB).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.LOB).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.LOB).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.LOB).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.LOB).DataField = "LineName";
    this.LOB.DistinctField = (string) null;
    this.LOB.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.LOB.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox lob = this.LOB;
    object obj29 = componentResourceManager.GetObject("LOB.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) lob).Location = pointF29;
    ((ARControl) this.LOB).Name = "LOB";
    this.LOB.OutputFormat = (string) null;
    ((ARControl) this.LOB).Size = new SizeF(5f / 16f, 1f / 16f);
    ((ARControl) this.LOB).Visible = false;
    ((ARControl) this.lblPolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.lblPolicyNumber.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.lblPolicyNumber.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblPolicyNumber.HyperLink = (string) null;
    Label lblPolicyNumber = this.lblPolicyNumber;
    object obj30 = componentResourceManager.GetObject("lblPolicyNumber.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) lblPolicyNumber).Location = pointF30;
    ((ARControl) this.lblPolicyNumber).Name = "lblPolicyNumber";
    ((ARControl) this.lblPolicyNumber).Size = new SizeF(1.25f, 3f / 16f);
    this.lblPolicyNumber.Text = "Policy Number:";
    ((ARControl) this.txtPolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).DataField = "PolicyNumber";
    this.txtPolicyNumber.DistinctField = (string) null;
    this.txtPolicyNumber.Font = new Font("Arial", 11f);
    this.txtPolicyNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPolicyNumber = this.txtPolicyNumber;
    object obj31 = componentResourceManager.GetObject("txtPolicyNumber.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) txtPolicyNumber).Location = pointF31;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.OutputFormat = (string) null;
    ((ARControl) this.txtPolicyNumber).Size = new SizeF(37f / 16f, 3f / 16f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    ((ISupportInitialize) this.lblLOB).EndInit();
    ((ISupportInitialize) this.txtHeader_OfficeName).EndInit();
    ((ISupportInitialize) this.txtHeader_OfficeAddress).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.txtHeader_OfficePhone).EndInit();
    ((ISupportInitialize) this.txtHeader_OfficeFax).EndInit();
    ((ISupportInitialize) this.txtHeader_Date).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtHeader_Copy).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtHeader_ProducerPhone).EndInit();
    ((ISupportInitialize) this.txtHeader_ProducerFax).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.txtBody_Carrier).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtBody_CoverageType).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.txtBody_NamedInsured).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.txtBody_EffectiveDate).EndInit();
    ((ISupportInitialize) this.txtBody_ExpirationDate).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.LOB).EndInit();
    ((ISupportInitialize) this.lblPolicyNumber).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
  }

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
}
