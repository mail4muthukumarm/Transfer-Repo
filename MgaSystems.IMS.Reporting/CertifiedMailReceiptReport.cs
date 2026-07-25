// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.CertifiedMailReceiptReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
public class CertifiedMailReceiptReport : MGAReport
{
  private IContainer components;
  private DataSet _ds;
  private Guid _quoteGuid;
  private int _interestID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CertifiedMailReceiptReport));
    this.Detail1 = new Detail();
    this.TextBox2 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox1 = new TextBox();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 3.020833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    this.Detail1.NewPage = (NewPage) 2;
    this.TextBox2.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "PostageFee";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj1 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox2).Location = pointF1;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(13f / 16f, 0.25f);
    this.TextBox2.Text = (string) null;
    this.TextBox6.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "TotalFee";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj2 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox6).Location = pointF2;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(13f / 16f, 0.25f);
    this.TextBox6.Text = (string) null;
    this.TextBox3.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "CertifiedFee";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj3 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox3).Location = pointF3;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(13f / 16f, 0.25f);
    this.TextBox3.Text = (string) null;
    this.TextBox4.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "ReturnReceipFee";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj4 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox4).Location = pointF4;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(13f / 16f, 0.25f);
    this.TextBox4.Text = (string) null;
    this.TextBox5.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "RestrictedDeliveryFee";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj5 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox5).Location = pointF5;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(13f / 16f, 0.25f);
    this.TextBox5.Text = (string) null;
    this.TextBox7.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "PolicyNumber";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox7 = this.TextBox7;
    object obj6 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) textBox7).Location = pointF6;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(17f / 16f, 0.25f);
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox8.CanGrow = false;
    ((ARControl) this.TextBox8).DataField = "InterestName";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox8 = this.TextBox8;
    object obj7 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox8).Location = pointF7;
    this.TextBox8.MultiLine = false;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = (string) null;
    ((ARControl) this.TextBox8).Size = new SizeF(51f / 16f, 3f / 16f);
    this.TextBox8.Text = (string) null;
    this.TextBox8.VerticalAlignment = (VerticalTextAlignment) 1;
    this.TextBox8.WordWrap = false;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox9.CanGrow = false;
    ((ARControl) this.TextBox9).DataField = "InterestNameAddress1";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox9 = this.TextBox9;
    object obj8 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox9).Location = pointF8;
    this.TextBox9.MultiLine = false;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = (string) null;
    ((ARControl) this.TextBox9).Size = new SizeF(41f / 16f, 3f / 16f);
    this.TextBox9.Text = (string) null;
    this.TextBox9.VerticalAlignment = (VerticalTextAlignment) 1;
    this.TextBox9.WordWrap = false;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox10.CanGrow = false;
    ((ARControl) this.TextBox10).DataField = "InterestNameAddress2";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox10 = this.TextBox10;
    object obj9 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox10).Location = pointF9;
    this.TextBox10.MultiLine = false;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = (string) null;
    ((ARControl) this.TextBox10).Size = new SizeF(41f / 16f, 3f / 16f);
    this.TextBox10.Text = (string) null;
    this.TextBox10.VerticalAlignment = (VerticalTextAlignment) 1;
    this.TextBox10.WordWrap = false;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox1.CanGrow = false;
    ((ARControl) this.TextBox1).DataField = "InterestName";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj10 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox1).Location = pointF10;
    this.TextBox1.MultiLine = false;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(55f / 16f, 3f / 16f);
    this.TextBox1.Text = (string) null;
    this.TextBox1.VerticalAlignment = (VerticalTextAlignment) 1;
    this.TextBox1.WordWrap = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.0f;
    this.PageSettings.Margins.Left = 0.0f;
    this.PageSettings.Margins.Right = 0.0f;
    this.PageSettings.Margins.Top = 0.0f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 3.1f;
    this.PageSettings.PaperKind = PaperKind.Custom;
    this.PageSettings.PaperName = "Custom paper";
    this.PageSettings.PaperWidth = 5.59f;
    this.PrintWidth = 5.427f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
  }

  [field: AccessedThroughProperty("TextBox2")]
  internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  internal virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  internal virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  internal virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  internal virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public CertifiedMailReceiptReport()
  {
    this.ReportStart += new EventHandler(this.CertifiedMailReceiptReport_ReportStart);
    this.InitializeComponent();
  }

  public CertifiedMailReceiptReport(Guid quoteguid)
  {
    this.ReportStart += new EventHandler(this.CertifiedMailReceiptReport_ReportStart);
    this.InitializeComponent();
    this._quoteGuid = quoteguid;
  }

  public CertifiedMailReceiptReport(int interstID)
  {
    this.ReportStart += new EventHandler(this.CertifiedMailReceiptReport_ReportStart);
    this.InitializeComponent();
    this._interestID = interstID;
  }

  private void CertifiedMailReceiptReport_ReportStart(object sender, EventArgs e)
  {
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand(nameof (CertifiedMailReceiptReport), connection);
    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
    this._ds = new DataSet();
    this.HidePrintDateAndTime();
    selectCommand.CommandType = CommandType.StoredProcedure;
    if (!this._quoteGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@QuoteGuid", (object) this._quoteGuid);
    selectCommand.Parameters.AddWithValue("@InterestID", (object) this._interestID);
    try
    {
      Database.SafeDataAdapterFill(dataAdapter, this._ds);
    }
    finally
    {
      connection.Close();
      dataAdapter.Dispose();
      selectCommand.Dispose();
      connection.Dispose();
    }
    this.DataSource = (object) this._ds.Tables[0];
  }
}
