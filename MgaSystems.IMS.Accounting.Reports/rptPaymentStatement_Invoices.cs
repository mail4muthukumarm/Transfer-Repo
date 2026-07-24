// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptPaymentStatement_Invoices
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptPaymentStatement_Invoices : SectionReport
{
  private DataTable _data;
  private DataTable _details;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox txtInvoiceNum;
  private SubReport SubReport2;

  public rptPaymentStatement_Invoices() => this.InitializeComponent();

  public rptPaymentStatement_Invoices(DataTable data, DataTable details)
  {
    this.InitializeComponent();
    this._data = data;
    this._details = details;
    this.DataSource = (object) this._data;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPaymentStatement_Invoices));
    this.Detail = new Detail();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.txtInvoiceNum = new TextBox();
    this.SubReport2 = new SubReport();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.txtInvoiceNum).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.txtInvoiceNum,
      (ARControl) this.SubReport2
    });
    ((Section) this.Detail).Height = 0.125f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "officeinvoicenum";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox = this.TextBox;
    object obj1 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox).Location = pointF1;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(0.625f, 0.125f);
    this.TextBox.Text = "TextBox";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "insuredpolicyname";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj2 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox1).Location = pointF2;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(1.25f, 0.125f);
    this.TextBox1.Text = "TextBox1";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "policynumber";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj3 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox2).Location = pointF3;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(0.8645833f, 0.125f);
    this.TextBox2.Text = "TextBox2";
    this.txtInvoiceNum.BackColor = Color.Gold;
    ((ARControl) this.txtInvoiceNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).DataField = "invoicenum";
    this.txtInvoiceNum.DistinctField = (string) null;
    this.txtInvoiceNum.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtInvoiceNum = this.txtInvoiceNum;
    object obj4 = componentResourceManager.GetObject("txtInvoiceNum.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) txtInvoiceNum).Location = pointF4;
    ((ARControl) this.txtInvoiceNum).Name = "txtInvoiceNum";
    this.txtInvoiceNum.OutputFormat = (string) null;
    ((ARControl) this.txtInvoiceNum).Size = new SizeF(0.25f, 0.075f);
    this.txtInvoiceNum.Text = (string) null;
    ((ARControl) this.txtInvoiceNum).Visible = false;
    ((ARControl) this.SubReport2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport2).Border.TopStyle = (BorderLineStyle) 0;
    this.SubReport2.CloseBorder = false;
    SubReport subReport2 = this.SubReport2;
    object obj5 = componentResourceManager.GetObject("SubReport2.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) subReport2).Location = pointF5;
    ((ARControl) this.SubReport2).Name = "SubReport2";
    this.SubReport2.Report = (SectionReport) null;
    ((ARControl) this.SubReport2).Size = new SizeF(5.125f, 0.125f);
    this.PageHeader.Height = 0.0f;
    ((Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter);
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.txtInvoiceNum).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    this.SubReport2.Report = (SectionReport) new rptPaymentStatement_InvoiceDetail(new DataView(this._details, $"InvoiceNum = '{RuntimeHelpers.GetObjectValue(this.txtInvoiceNum.Value)}'", "", DataViewRowState.CurrentRows));
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
