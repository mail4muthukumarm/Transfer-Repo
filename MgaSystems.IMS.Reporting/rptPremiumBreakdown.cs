// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptPremiumBreakdown
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptPremiumBreakdown : SectionReport
{
  private Guid _QuoteOptionGuid;
  private Label Label39;
  private TextBox TextBox1;
  private TextBox TextBox;

  public rptPremiumBreakdown(Guid QuoteOptionGuid)
  {
    this.InitializeComponent();
    this._QuoteOptionGuid = QuoteOptionGuid;
    this.ReportStart += new EventHandler(this.rptPremiumBreakdown_ReportStart);
  }

  public rptPremiumBreakdown(DataTable Info)
  {
    this.InitializeComponent();
    this.DataSource = (object) Info;
  }

  private void rptPremiumBreakdown_ReportStart(object sender, EventArgs e)
  {
    DataSet ds = new DataSet();
    using (SqlConnection sqlConnection = new SqlConnection(Database.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand())
      {
        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand))
        {
          SqlCommand sqlCommand = selectCommand;
          sqlCommand.CommandText = "[rptPremiumBreakdown]";
          sqlCommand.CommandType = CommandType.StoredProcedure;
          sqlCommand.Connection = sqlConnection;
          sqlCommand.Parameters.AddWithValue("@QuoteOptionGuid", (object) this._QuoteOptionGuid);
          Database.SafeDataAdapterFill(dataAdapter, ds);
        }
      }
    }
    this.DataSource = (object) ds.Tables[0];
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPremiumBreakdown));
    this.Detail = new Detail();
    this.Label39 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox = new TextBox();
    ((ISupportInitialize) this.Label39).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label39,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.Label39).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label39).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label39).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label39).Border.TopStyle = (BorderLineStyle) 0;
    this.Label39.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label39.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label39.HyperLink = (string) null;
    Label label39 = this.Label39;
    object obj1 = componentResourceManager.GetObject("Label39.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label39).Location = pointF1;
    ((ARControl) this.Label39).Name = "Label39";
    ((ARControl) this.Label39).Size = new SizeF(0.125f, 3f / 16f);
    this.Label39.Text = "$";
    this.TextBox1.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Amount";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 10f);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj2 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox1).Location = pointF2;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox1).Size = new SizeF(1.375f, 3f / 16f);
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "Description";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj3 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox).Location = pointF3;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(2.625f, 3f / 16f);
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 4.114583f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    ((ISupportInitialize) this.Label39).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
  }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
