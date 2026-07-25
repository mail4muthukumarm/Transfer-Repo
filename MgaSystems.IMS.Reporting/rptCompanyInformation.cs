// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCompanyInformation
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{17550040-BAC6-49fb-80A5-AB95E6EDDE56}", "Company Information Report", "Summary of company information.", "General")]
public class rptCompanyInformation : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{17550040-BAC6-49fb-80A5-AB95E6EDDE56}";
  private Label Label1;
  private Label Label2;
  private TextBox TextBox1;
  private Label Label3;
  private TextBox TextBox2;
  private Label Label4;
  private TextBox TextBox3;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private readonly Guid _CompanyLocationGuid;

  [field: AccessedThroughProperty("ghInfo")]
  private virtual GroupHeader ghInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfInfo")]
  private virtual GroupFooter gfInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptCompanyInformation()
  {
    this.ReportStart += new EventHandler(this.rptCompanyInformation_ReportStart);
  }

  public rptCompanyInformation(Guid CompanyLocationGuid)
  {
    this.ReportStart += new EventHandler(this.rptCompanyInformation_ReportStart);
    this.InitializeComponent();
    this._CompanyLocationGuid = CompanyLocationGuid;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCompanyInformation));
    this.Detail = new Detail();
    this.ghInfo = new GroupHeader();
    this.gfInfo = new GroupFooter();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.TextBox1 = new TextBox();
    this.Label3 = new Label();
    this.TextBox2 = new TextBox();
    this.Label4 = new Label();
    this.TextBox3 = new TextBox();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.Label2,
      (ARControl) this.TextBox1,
      (ARControl) this.Label3,
      (ARControl) this.TextBox2,
      (ARControl) this.Label4,
      (ARControl) this.TextBox3,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 1.302083f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInfo).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label1
    });
    this.ghInfo.Height = 0.3222222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInfo).Name = "ghInfo";
    this.gfInfo.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInfo).Name = "gfInfo";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(7f, 0.25f);
    this.Label1.Text = "Company Information Report";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj2 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label2).Location = pointF2;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.125f, 3f / 16f);
    this.Label2.Text = "Name:";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Name";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj3 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox1).Location = pointF3;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(5.875f, 3f / 16f);
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj4 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label3).Location = pointF4;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(1.125f, 3f / 16f);
    this.Label3.Text = "Location Name:";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "LocationName";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj5 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox2).Location = pointF5;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(5.875f, 3f / 16f);
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj6 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label4).Location = pointF6;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1.125f, 3f / 16f);
    this.Label4.Text = "Address:";
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "Address";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj7 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox3).Location = pointF7;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(5.875f, 3f / 16f);
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj8 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label5).Location = pointF8;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1.125f, 3f / 16f);
    this.Label5.Text = "Phone:";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj9 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label6).Location = pointF9;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(1.125f, 3f / 16f);
    this.Label6.Text = "Fax:";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj10 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label7).Location = pointF10;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(1.125f, 3f / 16f);
    this.Label7.Text = "Website:";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj11 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label8).Location = pointF11;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(1.125f, 3f / 16f);
    this.Label8.Text = "Email:";
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Phone";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj12 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox4).Location = pointF12;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(5.875f, 3f / 16f);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "Fax";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj13 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox5).Location = pointF13;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(5.875f, 3f / 16f);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "Website";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj14 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox6).Location = pointF14;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(5.875f, 3f / 16f);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "Email";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj15 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox7).Location = pointF15;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(5.875f, 3f / 16f);
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghInfo);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfInfo);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
  }

  private void rptCompanyInformation_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Name, LocationName, Phone,  Fax,  WebSite,  Email, Address1 + CASE WHEN Address2 IS NOT NULL THEN char(10) + char(13) + Address2 END + CHAR(10) + CHAR(13) + City + @C + State + CHAR(10) + CHAR(13) + ZipCode + CASE WHEN zipplus IS NOT NULL THEN @D + zipplus END AS Address FROM dbo.tblCompanyLocations WITH (NOLOCK) WHERE CompanyLocationGuid = @CLG", new object[6]
    {
      (object) "@CLG",
      (object) this._CompanyLocationGuid,
      (object) "@C",
      (object) ", ",
      (object) "@D",
      (object) "-"
    });
    this.SetStandardMargins();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[1]
      {
        (BaseReportControl) new CompanyLocations("Company Location", false)
      };
    }
  }
}
