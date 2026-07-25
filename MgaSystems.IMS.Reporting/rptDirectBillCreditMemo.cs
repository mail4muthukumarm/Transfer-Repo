// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptDirectBillCreditMemo
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptDirectBillCreditMemo : SectionReport
{
  private Label Label;
  private TextBox txtHeader_ToAddress;
  private TextBox txtHeader_PolicyNumber;
  private TextBox txtHeader_Copy;
  private Label Label2;
  private Label Label5;
  private Label Label6;
  private Label Label1;
  private Label Label3;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox5;
  private Label Label7;
  private Label txtFooter_Copy;
  private TextBox txtFooter_MailingAddress;
  private Guid _QuoteGuid;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptDirectBillCreditMemo()
  {
    this.ReportStart += new EventHandler(this.rptDirectBillCreditMemo_ReportStart);
    this.InitializeComponent();
  }

  public rptDirectBillCreditMemo(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptDirectBillCreditMemo_ReportStart);
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
  }

  private void rptDirectBillCreditMemo_ReportStart(object sender, EventArgs e)
  {
    DataSet dataSet = new DataSet();
    using (SqlConnection connection = DefaultDatabase.CreateConnection())
    {
      using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
      {
        sqlDataAdapter.SelectCommand = new SqlCommand();
        SqlCommand selectCommand = sqlDataAdapter.SelectCommand;
        selectCommand.CommandText = "[rptDirectBillCreditMemo]";
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Connection = connection;
        selectCommand.Parameters.AddWithValue("@QuoteGuid", (object) this._QuoteGuid);
        DefaultDatabase.DataAdapterFill((DbDataAdapter) sqlDataAdapter, dataSet);
      }
    }
    if (dataSet.Tables.Count != 2)
      return;
    if (dataSet.Tables[0].Rows.Count > 0)
    {
      DataRow row = dataSet.Tables[0].Rows[0];
      this.txtHeader_PolicyNumber.Text = string.Format(this.txtHeader_PolicyNumber.Text, RuntimeHelpers.GetObjectValue(row["PolicyNumber"]));
      this.txtHeader_ToAddress.Text = row["LocationAddress"].ToString();
      TextBox txtHeaderCopy = this.txtHeader_Copy;
      string text1 = this.txtHeader_Copy.Text;
      Decimal num = Conversions.ToDecimal(row["TotalCommission"]);
      string str1 = num.ToString("$#,##0.00");
      object objectValue = RuntimeHelpers.GetObjectValue(row["Location"]);
      string str2 = string.Format(text1, (object) str1, objectValue);
      txtHeaderCopy.Text = str2;
      Label txtFooterCopy = this.txtFooter_Copy;
      string text2 = this.txtFooter_Copy.Text;
      num = Conversions.ToDecimal(row["TotalCommission"]);
      string str3 = num.ToString("$#,##0.00");
      string str4 = string.Format(text2, (object) str3);
      txtFooterCopy.Text = str4;
      this.txtFooter_MailingAddress.Text = row["CompanyAddress"].ToString();
    }
    this.DataSource = (object) dataSet.Tables[1];
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptDirectBillCreditMemo));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label = new Label();
    this.txtHeader_ToAddress = new TextBox();
    this.txtHeader_PolicyNumber = new TextBox();
    this.txtHeader_Copy = new TextBox();
    this.Label2 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox5 = new TextBox();
    this.Label7 = new Label();
    this.txtFooter_Copy = new Label();
    this.txtFooter_MailingAddress = new TextBox();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.txtHeader_ToAddress).BeginInit();
    ((ISupportInitialize) this.txtHeader_PolicyNumber).BeginInit();
    ((ISupportInitialize) this.txtHeader_Copy).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtFooter_Copy).BeginInit();
    ((ISupportInitialize) this.txtFooter_MailingAddress).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label,
      (ARControl) this.txtHeader_ToAddress,
      (ARControl) this.txtHeader_PolicyNumber,
      (ARControl) this.txtHeader_Copy
    });
    this.ReportHeader.Height = 101f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtFooter_Copy,
      (ARControl) this.txtFooter_MailingAddress
    });
    this.ReportFooter.Height = 29f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label1,
      (ARControl) this.Label3
    });
    this.GroupHeader1.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.TextBox5,
      (ARControl) this.Label7
    });
    this.GroupFooter1.Height = 15f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.Label.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 18f);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj1 = componentResourceManager.GetObject("Label.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label).Location = pointF1;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(7.875f, 5f / 16f);
    this.Label.Text = "Direct Bill Credit Memo";
    ((ARControl) this.txtHeader_ToAddress).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ToAddress).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ToAddress).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_ToAddress).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_ToAddress.DistinctField = (string) null;
    this.txtHeader_ToAddress.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_ToAddress.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderToAddress = this.txtHeader_ToAddress;
    object obj2 = componentResourceManager.GetObject("txtHeader_ToAddress.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtHeaderToAddress).Location = pointF2;
    ((ARControl) this.txtHeader_ToAddress).Name = "txtHeader_ToAddress";
    this.txtHeader_ToAddress.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_ToAddress).Size = new SizeF(7f, 13f / 16f);
    this.txtHeader_PolicyNumber.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtHeader_PolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_PolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_PolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_PolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_PolicyNumber.DistinctField = (string) null;
    this.txtHeader_PolicyNumber.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_PolicyNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerPolicyNumber = this.txtHeader_PolicyNumber;
    object obj3 = componentResourceManager.GetObject("txtHeader_PolicyNumber.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) headerPolicyNumber).Location = pointF3;
    ((ARControl) this.txtHeader_PolicyNumber).Name = "txtHeader_PolicyNumber";
    this.txtHeader_PolicyNumber.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_PolicyNumber).Size = new SizeF(7.875f, 5f / 16f);
    this.txtHeader_PolicyNumber.Text = "Policy {0}";
    ((ARControl) this.txtHeader_Copy).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Copy).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Copy).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Copy).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_Copy.DistinctField = (string) null;
    this.txtHeader_Copy.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_Copy.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderCopy = this.txtHeader_Copy;
    object obj4 = componentResourceManager.GetObject("txtHeader_Copy.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) txtHeaderCopy).Location = pointF4;
    ((ARControl) this.txtHeader_Copy).Name = "txtHeader_Copy";
    this.txtHeader_Copy.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_Copy).Size = new SizeF(7f, 7f / 16f);
    this.txtHeader_Copy.Text = "This direct bill credit memo applies to the invoices listed below.  A total of {0} in commission is due back to {1}.";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj5 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label2).Location = pointF5;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1f, 3f / 16f);
    this.Label2.Text = "Invoice #";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj6 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label5).Location = pointF6;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(39f / 16f, 3f / 16f);
    this.Label5.Text = "Insured";
    this.Label6.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj7 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label6).Location = pointF7;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(0.875f, 3f / 16f);
    this.Label6.Text = "Commission";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj8 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label1).Location = pointF8;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(47f / 16f, 3f / 16f);
    this.Label1.Text = "Description";
    this.Label3.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj9 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label3).Location = pointF9;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.625f, 3f / 16f);
    this.Label3.Text = "Comm %";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "InvoiceNum";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 9f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj10 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox2).Location = pointF10;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(1f, 0.125f);
    this.TextBox2.Text = " ";
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
    this.TextBox3.Font = new Font("Arial", 9f);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj11 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox3).Location = pointF11;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(39f / 16f, 0.125f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "BrokerCommissionAmount";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 9f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj12 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox4).Location = pointF12;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(0.875f, 0.125f);
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "Description";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 9f);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj13 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox).Location = pointF13;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(47f / 16f, 0.125f);
    this.TextBox.Text = " ";
    this.TextBox1.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "BrokerCommissionPercent";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 9f);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj14 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox1).Location = pointF14;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "0.00%";
    ((ARControl) this.TextBox1).Size = new SizeF(0.625f, 0.125f);
    this.TextBox1.Text = " ";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "BrokerCommissionAmount";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 9f);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj15 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox5).Location = pointF15;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox5.SummaryRunning = (SummaryRunning) 2;
    this.TextBox5.SummaryType = (SummaryType) 1;
    this.TextBox5.Text = " ";
    this.Label7.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj16 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label7).Location = pointF16;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(0.625f, 3f / 16f);
    this.Label7.Text = "Total:";
    ((ARControl) this.txtFooter_Copy).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Copy).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Copy).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_Copy).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_Copy.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_Copy.ForeColor = Color.FromArgb(0, 0, 0);
    this.txtFooter_Copy.HyperLink = (string) null;
    Label txtFooterCopy = this.txtFooter_Copy;
    object obj17 = componentResourceManager.GetObject("txtFooter_Copy.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) txtFooterCopy).Location = pointF17;
    ((ARControl) this.txtFooter_Copy).Name = "txtFooter_Copy";
    ((ARControl) this.txtFooter_Copy).Size = new SizeF(7.875f, 0.25f);
    this.txtFooter_Copy.Text = "Please mail a check for the amount of {0} to:";
    ((ARControl) this.txtFooter_MailingAddress).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_MailingAddress).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_MailingAddress).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFooter_MailingAddress).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFooter_MailingAddress.DistinctField = (string) null;
    this.txtFooter_MailingAddress.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFooter_MailingAddress.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox footerMailingAddress = this.txtFooter_MailingAddress;
    object obj18 = componentResourceManager.GetObject("txtFooter_MailingAddress.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) footerMailingAddress).Location = pointF18;
    ((ARControl) this.txtFooter_MailingAddress).Name = "txtFooter_MailingAddress";
    this.txtFooter_MailingAddress.OutputFormat = (string) null;
    ((ARControl) this.txtFooter_MailingAddress).Size = new SizeF(7.875f, 0.625f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.txtHeader_ToAddress).EndInit();
    ((ISupportInitialize) this.txtHeader_PolicyNumber).EndInit();
    ((ISupportInitialize) this.txtHeader_Copy).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtFooter_Copy).EndInit();
    ((ISupportInitialize) this.txtFooter_MailingAddress).EndInit();
  }
}
