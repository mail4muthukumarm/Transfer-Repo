// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptARReport_PostedToExchange
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptARReport_PostedToExchange : SectionReport
{
  private Label lblExchangeAcct;
  private Label lblComments;
  private Label lblAmount;
  private Label lblPostedToExchange;
  private Label Label2;
  private TextBox txtExchangeAccount;
  private TextBox txtComments;
  private TextBox txtAmount;
  private TextBox amount2;
  private Label Label1;
  private TextBox amount1;

  public rptARReport_PostedToExchange(DataView dv)
  {
    this.InitializeComponent();
    this.DataSource = (object) dv;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptARReport_PostedToExchange));
    this.Detail = new Detail();
    this.txtExchangeAccount = new TextBox();
    this.txtComments = new TextBox();
    this.txtAmount = new TextBox();
    this.amount2 = new TextBox();
    this.GroupHeader1 = new GroupHeader();
    this.lblExchangeAcct = new Label();
    this.lblComments = new Label();
    this.lblAmount = new Label();
    this.lblPostedToExchange = new Label();
    this.Label2 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.Label1 = new Label();
    this.amount1 = new TextBox();
    ((ISupportInitialize) this.txtExchangeAccount).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.amount2).BeginInit();
    ((ISupportInitialize) this.lblExchangeAcct).BeginInit();
    ((ISupportInitialize) this.lblComments).BeginInit();
    ((ISupportInitialize) this.lblAmount).BeginInit();
    ((ISupportInitialize) this.lblPostedToExchange).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.amount1).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.txtExchangeAccount,
      (ARControl) this.txtComments,
      (ARControl) this.txtAmount,
      (ARControl) this.amount2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtExchangeAccount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchangeAccount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchangeAccount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchangeAccount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchangeAccount).DataField = "fullname";
    this.txtExchangeAccount.DistinctField = (string) null;
    this.txtExchangeAccount.Font = new Font("Arial", 8f);
    TextBox txtExchangeAccount = this.txtExchangeAccount;
    object obj1 = componentResourceManager.GetObject("txtExchangeAccount.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtExchangeAccount).Location = pointF1;
    ((ARControl) this.txtExchangeAccount).Name = "txtExchangeAccount";
    this.txtExchangeAccount.OutputFormat = (string) null;
    ((ARControl) this.txtExchangeAccount).Size = new SizeF(37f / 16f, 0.125f);
    this.txtExchangeAccount.Text = " ";
    ((ARControl) this.txtComments).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtComments).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtComments).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtComments).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtComments).DataField = "comments";
    this.txtComments.DistinctField = (string) null;
    this.txtComments.Font = new Font("Arial", 8f);
    TextBox txtComments = this.txtComments;
    object obj2 = componentResourceManager.GetObject("txtComments.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtComments).Location = pointF2;
    ((ARControl) this.txtComments).Name = "txtComments";
    this.txtComments.OutputFormat = (string) null;
    ((ARControl) this.txtComments).Size = new SizeF(77f / 16f, 0.125f);
    this.txtComments.Text = " ";
    this.txtAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).DataField = "amount";
    this.txtAmount.DistinctField = (string) null;
    this.txtAmount.Font = new Font("Arial", 8f);
    TextBox txtAmount = this.txtAmount;
    object obj3 = componentResourceManager.GetObject("txtAmount.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtAmount).Location = pointF3;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtAmount).Size = new SizeF(13f / 16f, 0.125f);
    this.txtAmount.Text = " ";
    this.amount2.Alignment = (TextAlignment) 2;
    ((ARControl) this.amount2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount2).DataField = "amount";
    this.amount2.DistinctField = (string) null;
    this.amount2.Font = new Font("Arial", 8f);
    TextBox amount2 = this.amount2;
    object obj4 = componentResourceManager.GetObject("amount2.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) amount2).Location = pointF4;
    ((ARControl) this.amount2).Name = "amount2";
    this.amount2.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.amount2).Size = new SizeF(13f / 16f, 0.125f);
    this.amount2.Text = " ";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.lblExchangeAcct,
      (ARControl) this.lblComments,
      (ARControl) this.lblAmount,
      (ARControl) this.lblPostedToExchange,
      (ARControl) this.Label2
    });
    this.GroupHeader1.Height = 0.3020833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.lblExchangeAcct).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblExchangeAcct).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblExchangeAcct).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblExchangeAcct).Border.TopStyle = (BorderLineStyle) 0;
    this.lblExchangeAcct.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblExchangeAcct.HyperLink = (string) null;
    Label lblExchangeAcct = this.lblExchangeAcct;
    object obj5 = componentResourceManager.GetObject("lblExchangeAcct.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) lblExchangeAcct).Location = pointF5;
    ((ARControl) this.lblExchangeAcct).Name = "lblExchangeAcct";
    ((ARControl) this.lblExchangeAcct).Size = new SizeF(37f / 16f, 0.1255f);
    this.lblExchangeAcct.Text = "Exchange Acct";
    ((ARControl) this.lblComments).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblComments).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblComments).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblComments).Border.TopStyle = (BorderLineStyle) 0;
    this.lblComments.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblComments.HyperLink = (string) null;
    Label lblComments = this.lblComments;
    object obj6 = componentResourceManager.GetObject("lblComments.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) lblComments).Location = pointF6;
    ((ARControl) this.lblComments).Name = "lblComments";
    ((ARControl) this.lblComments).Size = new SizeF(77f / 16f, 0.125f);
    this.lblComments.Text = "Comments";
    this.lblAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAmount).Border.TopStyle = (BorderLineStyle) 0;
    this.lblAmount.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblAmount.HyperLink = (string) null;
    Label lblAmount = this.lblAmount;
    object obj7 = componentResourceManager.GetObject("lblAmount.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) lblAmount).Location = pointF7;
    ((ARControl) this.lblAmount).Name = "lblAmount";
    ((ARControl) this.lblAmount).Size = new SizeF(0.813f, 0.1255f);
    this.lblAmount.Text = "Exch Amount";
    ((ARControl) this.lblAmount).Visible = false;
    ((ARControl) this.lblPostedToExchange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPostedToExchange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPostedToExchange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPostedToExchange).Border.TopStyle = (BorderLineStyle) 0;
    this.lblPostedToExchange.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblPostedToExchange.HyperLink = (string) null;
    Label postedToExchange = this.lblPostedToExchange;
    object obj8 = componentResourceManager.GetObject("lblPostedToExchange.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) postedToExchange).Location = pointF8;
    ((ARControl) this.lblPostedToExchange).Name = "lblPostedToExchange";
    ((ARControl) this.lblPostedToExchange).Size = new SizeF(1.75f, 0.125f);
    this.lblPostedToExchange.Text = "Posted To Exchange";
    this.Label2.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj9 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label2).Location = pointF9;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.813f, 0.1255f);
    this.Label2.Text = "Deposit";
    ((ARControl) this.Label2).Visible = false;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label1,
      (ARControl) this.amount1
    });
    this.GroupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj10 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label1).Location = pointF10;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(89f / 16f, 0.125f);
    this.Label1.Text = "Posted To Exchange Total:";
    ((ARControl) this.Label1).Visible = false;
    this.amount1.Alignment = (TextAlignment) 2;
    ((ARControl) this.amount1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.amount1).DataField = "amount";
    this.amount1.DistinctField = (string) null;
    this.amount1.Font = new Font("Arial", 8f);
    TextBox amount1 = this.amount1;
    object obj11 = componentResourceManager.GetObject("amount1.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) amount1).Location = pointF11;
    ((ARControl) this.amount1).Name = "amount1";
    this.amount1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.amount1).Size = new SizeF(13f / 16f, 0.125f);
    this.amount1.SummaryGroup = "GroupHeader1";
    this.amount1.SummaryRunning = (SummaryRunning) 1;
    this.amount1.SummaryType = (SummaryType) 1;
    this.amount1.Text = " ";
    ((ARControl) this.amount1).Visible = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.375f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    ((ISupportInitialize) this.txtExchangeAccount).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.amount2).EndInit();
    ((ISupportInitialize) this.lblExchangeAcct).EndInit();
    ((ISupportInitialize) this.lblComments).EndInit();
    ((ISupportInitialize) this.lblAmount).EndInit();
    ((ISupportInitialize) this.lblPostedToExchange).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.amount1).EndInit();
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
