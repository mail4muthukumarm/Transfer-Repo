// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.CheckDetail_Operating
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.IMS.Accounting.CheckPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class CheckDetail_Operating : SectionReport
{
  private int Transactnum;
  private Label Label7;
  private Label Label;
  private Label Label1;
  private Label lblSeeCheckDetail;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;

  public CheckDetail_Operating()
  {
    this.ReportStart += new EventHandler(this.CheckDetail_ReportStart);
    this.InitializeComponent();
  }

  public CheckDetail_Operating(int trx)
  {
    this.ReportStart += new EventHandler(this.CheckDetail_ReportStart);
    this.InitializeComponent();
    this.Transactnum = trx;
  }

  private void CheckDetail_ReportStart(object sender, EventArgs e)
  {
    this.ShowParameterUI = false;
    SqlCommand selectCommand = new SqlCommand(string.Format("spFin_GetCheckDetails_Operating", (object) this.Transactnum), new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    try
    {
      sqlDataAdapter.SelectCommand.Parameters.Clear();
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@transactnum", (object) this.Transactnum);
      sqlDataAdapter.Fill(dataSet);
      if (dataSet.Tables[0].Rows.Count <= new CheckPrintingSettings().CheckDetailMax())
      {
        ((ARControl) this.lblSeeCheckDetail).Visible = false;
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Visible = true;
        this.DataSource = (object) dataSet.Tables[0];
      }
      else
      {
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Visible = false;
        ((ARControl) this.lblSeeCheckDetail).Visible = true;
      }
    }
    finally
    {
      selectCommand.Connection.Close();
      selectCommand.Connection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CheckDetail_Operating));
    this.Detail = new Detail();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label7 = new Label();
    this.Label = new Label();
    this.Label1 = new Label();
    this.lblSeeCheckDetail = new Label();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.lblSeeCheckDetail).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.lblSeeCheckDetail,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1451389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label7,
      (ARControl) this.Label,
      (ARControl) this.Label1
    });
    this.GroupHeader1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox3
    });
    this.GroupFooter1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj1 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label7).Location = pointF1;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(3.625f, 0.125f);
    this.Label7.Text = "Description";
    this.Label7.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj2 = componentResourceManager.GetObject("Label.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label).Location = pointF2;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(15f / 16f, 0.125f);
    this.Label.Text = "Date";
    this.Label.VerticalAlignment = (VerticalTextAlignment) 1;
    this.Label1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj3 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label1).Location = pointF3;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(15f / 16f, 0.125f);
    this.Label1.Text = "Amount";
    this.Label1.VerticalAlignment = (VerticalTextAlignment) 1;
    this.lblSeeCheckDetail.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblSeeCheckDetail).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeCheckDetail).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeCheckDetail).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeCheckDetail).Border.TopStyle = (BorderLineStyle) 0;
    this.lblSeeCheckDetail.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblSeeCheckDetail.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblSeeCheckDetail.HyperLink = (string) null;
    Label lblSeeCheckDetail = this.lblSeeCheckDetail;
    object obj4 = componentResourceManager.GetObject("lblSeeCheckDetail.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) lblSeeCheckDetail).Location = pointF4;
    ((ARControl) this.lblSeeCheckDetail).Name = "lblSeeCheckDetail";
    ((ARControl) this.lblSeeCheckDetail).Size = new SizeF((float) sbyte.MaxValue / 16f, 61f / 16f);
    this.lblSeeCheckDetail.Text = "Please see check detail page..";
    this.lblSeeCheckDetail.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "ExpenseDate";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj5 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox).Location = pointF5;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox).Size = new SizeF(15f / 16f, 0.125f);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "ExpenseName";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj6 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) textBox1).Location = pointF6;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(3.614583f, 0.125f);
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "Amount";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj7 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox2).Location = pointF7;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0.00";
    ((ARControl) this.TextBox2).Size = new SizeF(15f / 16f, 0.125f);
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "Amount";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj8 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox3).Location = pointF8;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "$#,##0.00";
    ((ARControl) this.TextBox3).Size = new SizeF(15f / 16f, 0.125f);
    this.TextBox3.SummaryGroup = "GroupHeader1";
    this.TextBox3.SummaryRunning = (SummaryRunning) 2;
    this.TextBox3.SummaryType = (SummaryType) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.729f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.lblSeeCheckDetail).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
