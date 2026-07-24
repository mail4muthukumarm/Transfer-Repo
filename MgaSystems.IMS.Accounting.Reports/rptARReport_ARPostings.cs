// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptARReport_ARPostings
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

public sealed class rptARReport_ARPostings : SectionReport
{
  private Label lblDeposit;
  private Label lblRCI;
  private Label lblUnaccounted;
  private Label lblExchange;
  private Label lblReceived;
  private Label lblInvoice;
  private Label lblPolicy;
  private Label lblInsured;
  private Label Label11;
  private Label Label13;
  private TextBox txtPolicy;
  private TextBox txtInvoice;
  private TextBox txtPremium;
  private TextBox txtRCI;
  private TextBox txtSurplus;
  private TextBox txtExchange;
  private TextBox txtDeposit;
  private TextBox txtInsured;
  private TextBox Amt2;
  private TextBox Amt1;
  private TextBox XAmt1;
  private TextBox UnacctAmt1;
  private TextBox IncAmt1;
  private TextBox DepositAmt1;
  private Label Label12;
  private TextBox Amt3;

  public rptARReport_ARPostings(DataView dv)
  {
    this.InitializeComponent();
    this.DataSource = (object) dv;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptARReport_ARPostings));
    this.Detail = new Detail();
    this.txtPolicy = new TextBox();
    this.txtInvoice = new TextBox();
    this.txtPremium = new TextBox();
    this.txtRCI = new TextBox();
    this.txtSurplus = new TextBox();
    this.txtExchange = new TextBox();
    this.txtDeposit = new TextBox();
    this.txtInsured = new TextBox();
    this.Amt2 = new TextBox();
    this.GroupHeader1 = new GroupHeader();
    this.lblDeposit = new Label();
    this.lblRCI = new Label();
    this.lblUnaccounted = new Label();
    this.lblExchange = new Label();
    this.lblReceived = new Label();
    this.lblInvoice = new Label();
    this.lblPolicy = new Label();
    this.lblInsured = new Label();
    this.Label11 = new Label();
    this.Label13 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.Amt1 = new TextBox();
    this.XAmt1 = new TextBox();
    this.UnacctAmt1 = new TextBox();
    this.IncAmt1 = new TextBox();
    this.DepositAmt1 = new TextBox();
    this.Label12 = new Label();
    this.Amt3 = new TextBox();
    ((ISupportInitialize) this.txtPolicy).BeginInit();
    ((ISupportInitialize) this.txtInvoice).BeginInit();
    ((ISupportInitialize) this.txtPremium).BeginInit();
    ((ISupportInitialize) this.txtRCI).BeginInit();
    ((ISupportInitialize) this.txtSurplus).BeginInit();
    ((ISupportInitialize) this.txtExchange).BeginInit();
    ((ISupportInitialize) this.txtDeposit).BeginInit();
    ((ISupportInitialize) this.txtInsured).BeginInit();
    ((ISupportInitialize) this.Amt2).BeginInit();
    ((ISupportInitialize) this.lblDeposit).BeginInit();
    ((ISupportInitialize) this.lblRCI).BeginInit();
    ((ISupportInitialize) this.lblUnaccounted).BeginInit();
    ((ISupportInitialize) this.lblExchange).BeginInit();
    ((ISupportInitialize) this.lblReceived).BeginInit();
    ((ISupportInitialize) this.lblInvoice).BeginInit();
    ((ISupportInitialize) this.lblPolicy).BeginInit();
    ((ISupportInitialize) this.lblInsured).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Amt1).BeginInit();
    ((ISupportInitialize) this.XAmt1).BeginInit();
    ((ISupportInitialize) this.UnacctAmt1).BeginInit();
    ((ISupportInitialize) this.IncAmt1).BeginInit();
    ((ISupportInitialize) this.DepositAmt1).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Amt3).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.txtPolicy,
      (ARControl) this.txtInvoice,
      (ARControl) this.txtPremium,
      (ARControl) this.txtRCI,
      (ARControl) this.txtSurplus,
      (ARControl) this.txtExchange,
      (ARControl) this.txtDeposit,
      (ARControl) this.txtInsured,
      (ARControl) this.Amt2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtPolicy).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicy).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicy).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicy).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicy).DataField = "PolicyNum";
    this.txtPolicy.DistinctField = (string) null;
    this.txtPolicy.Font = new Font("Arial", 8f);
    TextBox txtPolicy = this.txtPolicy;
    object obj1 = componentResourceManager.GetObject("txtPolicy.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtPolicy).Location = pointF1;
    ((ARControl) this.txtPolicy).Name = "txtPolicy";
    this.txtPolicy.OutputFormat = (string) null;
    ((ARControl) this.txtPolicy).Size = new SizeF(23f / 16f, 0.125f);
    this.txtPolicy.Text = "Policy #";
    ((ARControl) this.txtInvoice).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoice).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoice).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoice).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoice).DataField = "OfficeInvoiceNum";
    this.txtInvoice.DistinctField = (string) null;
    this.txtInvoice.Font = new Font("Arial", 8f);
    TextBox txtInvoice = this.txtInvoice;
    object obj2 = componentResourceManager.GetObject("txtInvoice.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtInvoice).Location = pointF2;
    ((ARControl) this.txtInvoice).Name = "txtInvoice";
    this.txtInvoice.OutputFormat = (string) null;
    ((ARControl) this.txtInvoice).Size = new SizeF(11f / 16f, 0.125f);
    this.txtInvoice.Text = "Invoice #";
    this.txtPremium.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPremium).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPremium).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPremium).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPremium).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPremium).DataField = "ARAmt";
    this.txtPremium.DistinctField = (string) null;
    this.txtPremium.Font = new Font("Arial", 8f);
    TextBox txtPremium = this.txtPremium;
    object obj3 = componentResourceManager.GetObject("txtPremium.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtPremium).Location = pointF3;
    ((ARControl) this.txtPremium).Name = "txtPremium";
    this.txtPremium.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtPremium).Size = new SizeF(13f / 16f, 0.125f);
    this.txtPremium.Text = "Premium";
    this.txtRCI.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtRCI).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRCI).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRCI).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRCI).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRCI).DataField = "IncAmt";
    this.txtRCI.DistinctField = (string) null;
    this.txtRCI.Font = new Font("Arial", 8f);
    TextBox txtRci = this.txtRCI;
    object obj4 = componentResourceManager.GetObject("txtRCI.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) txtRci).Location = pointF4;
    ((ARControl) this.txtRCI).Name = "txtRCI";
    this.txtRCI.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtRCI).Size = new SizeF(13f / 16f, 0.125f);
    this.txtRCI.Text = "MGA Comm";
    this.txtSurplus.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtSurplus).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSurplus).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSurplus).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSurplus).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSurplus).DataField = "UnacctAmt";
    this.txtSurplus.DistinctField = (string) null;
    this.txtSurplus.Font = new Font("Arial", 8f);
    TextBox txtSurplus = this.txtSurplus;
    object obj5 = componentResourceManager.GetObject("txtSurplus.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) txtSurplus).Location = pointF5;
    ((ARControl) this.txtSurplus).Name = "txtSurplus";
    this.txtSurplus.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtSurplus).Size = new SizeF(13f / 16f, 0.125f);
    this.txtSurplus.Text = "Un-Accounted";
    this.txtExchange.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtExchange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchange).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchange).DataField = "XAmt";
    this.txtExchange.DistinctField = (string) null;
    this.txtExchange.Font = new Font("Arial", 8f);
    TextBox txtExchange = this.txtExchange;
    object obj6 = componentResourceManager.GetObject("txtExchange.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) txtExchange).Location = pointF6;
    ((ARControl) this.txtExchange).Name = "txtExchange";
    this.txtExchange.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtExchange).Size = new SizeF(13f / 16f, 0.125f);
    this.txtExchange.Text = "Exchange";
    this.txtDeposit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDeposit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDeposit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDeposit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDeposit).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDeposit).DataField = "DepositAmt";
    this.txtDeposit.DistinctField = (string) null;
    this.txtDeposit.Font = new Font("Arial", 8f);
    TextBox txtDeposit = this.txtDeposit;
    object obj7 = componentResourceManager.GetObject("txtDeposit.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) txtDeposit).Location = pointF7;
    ((ARControl) this.txtDeposit).Name = "txtDeposit";
    this.txtDeposit.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtDeposit).Size = new SizeF(13f / 16f, 0.125f);
    this.txtDeposit.Text = "DepositAmt";
    ((ARControl) this.txtInsured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).DataField = "InsuredName";
    this.txtInsured.DistinctField = (string) null;
    this.txtInsured.Font = new Font("Arial", 8f);
    TextBox txtInsured = this.txtInsured;
    object obj8 = componentResourceManager.GetObject("txtInsured.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) txtInsured).Location = pointF8;
    ((ARControl) this.txtInsured).Name = "txtInsured";
    this.txtInsured.OutputFormat = (string) null;
    ((ARControl) this.txtInsured).Size = new SizeF(3.375f, 0.125f);
    this.txtInsured.Text = "Insured";
    this.Amt2.Alignment = (TextAlignment) 2;
    ((ARControl) this.Amt2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt2).DataField = "APAmount";
    this.Amt2.DistinctField = (string) null;
    this.Amt2.Font = new Font("Arial", 8f);
    TextBox amt2 = this.Amt2;
    object obj9 = componentResourceManager.GetObject("Amt2.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) amt2).Location = pointF9;
    ((ARControl) this.Amt2).Name = "Amt2";
    this.Amt2.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.Amt2).Size = new SizeF(13f / 16f, 0.125f);
    this.Amt2.Text = "A/P";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.lblDeposit,
      (ARControl) this.lblRCI,
      (ARControl) this.lblUnaccounted,
      (ARControl) this.lblExchange,
      (ARControl) this.lblReceived,
      (ARControl) this.lblInvoice,
      (ARControl) this.lblPolicy,
      (ARControl) this.lblInsured,
      (ARControl) this.Label11,
      (ARControl) this.Label13
    });
    this.GroupHeader1.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.lblDeposit.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblDeposit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDeposit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDeposit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDeposit).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDeposit.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblDeposit.HyperLink = (string) null;
    Label lblDeposit = this.lblDeposit;
    object obj10 = componentResourceManager.GetObject("lblDeposit.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) lblDeposit).Location = pointF10;
    ((ARControl) this.lblDeposit).Name = "lblDeposit";
    ((ARControl) this.lblDeposit).Size = new SizeF(13f / 16f, 0.125f);
    this.lblDeposit.Text = "Deposit";
    this.lblRCI.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblRCI).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRCI).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRCI).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblRCI).Border.TopStyle = (BorderLineStyle) 0;
    this.lblRCI.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblRCI.HyperLink = (string) null;
    Label lblRci = this.lblRCI;
    object obj11 = componentResourceManager.GetObject("lblRCI.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) lblRci).Location = pointF11;
    ((ARControl) this.lblRCI).Name = "lblRCI";
    ((ARControl) this.lblRCI).Size = new SizeF(13f / 16f, 0.125f);
    this.lblRCI.Text = "MGA Comm.";
    this.lblUnaccounted.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblUnaccounted).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblUnaccounted).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblUnaccounted).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblUnaccounted).Border.TopStyle = (BorderLineStyle) 0;
    this.lblUnaccounted.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblUnaccounted.HyperLink = (string) null;
    Label lblUnaccounted = this.lblUnaccounted;
    object obj12 = componentResourceManager.GetObject("lblUnaccounted.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) lblUnaccounted).Location = pointF12;
    ((ARControl) this.lblUnaccounted).Name = "lblUnaccounted";
    ((ARControl) this.lblUnaccounted).Size = new SizeF(0.8124993f, 0.125f);
    this.lblUnaccounted.Text = "Un-Accounted";
    this.lblExchange.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblExchange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblExchange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblExchange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblExchange).Border.TopStyle = (BorderLineStyle) 0;
    this.lblExchange.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblExchange.HyperLink = (string) null;
    Label lblExchange = this.lblExchange;
    object obj13 = componentResourceManager.GetObject("lblExchange.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) lblExchange).Location = pointF13;
    ((ARControl) this.lblExchange).Name = "lblExchange";
    ((ARControl) this.lblExchange).Size = new SizeF(0.8124993f, 0.125f);
    this.lblExchange.Text = "Exchange";
    this.lblReceived.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblReceived).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReceived).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReceived).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReceived).Border.TopStyle = (BorderLineStyle) 0;
    this.lblReceived.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblReceived.HyperLink = (string) null;
    Label lblReceived = this.lblReceived;
    object obj14 = componentResourceManager.GetObject("lblReceived.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) lblReceived).Location = pointF14;
    ((ARControl) this.lblReceived).Name = "lblReceived";
    ((ARControl) this.lblReceived).Size = new SizeF(13f / 16f, 0.125f);
    this.lblReceived.Text = "A/R";
    ((ARControl) this.lblInvoice).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblInvoice).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblInvoice).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblInvoice).Border.TopStyle = (BorderLineStyle) 0;
    this.lblInvoice.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblInvoice.HyperLink = (string) null;
    Label lblInvoice = this.lblInvoice;
    object obj15 = componentResourceManager.GetObject("lblInvoice.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) lblInvoice).Location = pointF15;
    ((ARControl) this.lblInvoice).Name = "lblInvoice";
    ((ARControl) this.lblInvoice).Size = new SizeF(11f / 16f, 0.125f);
    this.lblInvoice.Text = "Invoice #";
    ((ARControl) this.lblPolicy).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPolicy).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPolicy).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPolicy).Border.TopStyle = (BorderLineStyle) 0;
    this.lblPolicy.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblPolicy.HyperLink = (string) null;
    Label lblPolicy = this.lblPolicy;
    object obj16 = componentResourceManager.GetObject("lblPolicy.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) lblPolicy).Location = pointF16;
    ((ARControl) this.lblPolicy).Name = "lblPolicy";
    ((ARControl) this.lblPolicy).Size = new SizeF(23f / 16f, 0.125f);
    this.lblPolicy.Text = "Policy #";
    ((ARControl) this.lblInsured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblInsured).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblInsured).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblInsured).Border.TopStyle = (BorderLineStyle) 0;
    this.lblInsured.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblInsured.HyperLink = (string) null;
    Label lblInsured = this.lblInsured;
    object obj17 = componentResourceManager.GetObject("lblInsured.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) lblInsured).Location = pointF17;
    ((ARControl) this.lblInsured).Name = "lblInsured";
    ((ARControl) this.lblInsured).Size = new SizeF(3.375f, 0.125f);
    this.lblInsured.Text = "Insured";
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj18 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) label11).Location = pointF18;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(0.75f, 0.125f);
    this.Label11.Text = "AR Postings";
    this.Label13.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj19 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label13).Location = pointF19;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(13f / 16f, 0.125f);
    this.Label13.Text = "A/P";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Amt1,
      (ARControl) this.XAmt1,
      (ARControl) this.UnacctAmt1,
      (ARControl) this.IncAmt1,
      (ARControl) this.DepositAmt1,
      (ARControl) this.Label12,
      (ARControl) this.Amt3
    });
    this.GroupFooter1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.Amt1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Amt1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt1).DataField = "ARAmt";
    this.Amt1.DistinctField = (string) null;
    this.Amt1.Font = new Font("Arial", 8f);
    TextBox amt1 = this.Amt1;
    object obj20 = componentResourceManager.GetObject("Amt1.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) amt1).Location = pointF20;
    ((ARControl) this.Amt1).Name = "Amt1";
    this.Amt1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.Amt1).Size = new SizeF(13f / 16f, 0.125f);
    this.Amt1.SummaryGroup = "GroupHeader1";
    this.Amt1.SummaryRunning = (SummaryRunning) 2;
    this.Amt1.SummaryType = (SummaryType) 1;
    this.Amt1.Text = "Premium";
    this.XAmt1.Alignment = (TextAlignment) 2;
    ((ARControl) this.XAmt1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.XAmt1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.XAmt1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.XAmt1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.XAmt1).DataField = "XAmt";
    this.XAmt1.DistinctField = (string) null;
    this.XAmt1.Font = new Font("Arial", 8f);
    TextBox xamt1 = this.XAmt1;
    object obj21 = componentResourceManager.GetObject("XAmt1.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) xamt1).Location = pointF21;
    ((ARControl) this.XAmt1).Name = "XAmt1";
    this.XAmt1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.XAmt1).Size = new SizeF(13f / 16f, 0.125f);
    this.XAmt1.SummaryGroup = "GroupHeader1";
    this.XAmt1.SummaryRunning = (SummaryRunning) 2;
    this.XAmt1.SummaryType = (SummaryType) 1;
    this.XAmt1.Text = "Exchange";
    this.UnacctAmt1.Alignment = (TextAlignment) 2;
    ((ARControl) this.UnacctAmt1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.UnacctAmt1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.UnacctAmt1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.UnacctAmt1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.UnacctAmt1).DataField = "UnacctAmt";
    this.UnacctAmt1.DistinctField = (string) null;
    this.UnacctAmt1.Font = new Font("Arial", 8f);
    TextBox unacctAmt1 = this.UnacctAmt1;
    object obj22 = componentResourceManager.GetObject("UnacctAmt1.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) unacctAmt1).Location = pointF22;
    ((ARControl) this.UnacctAmt1).Name = "UnacctAmt1";
    this.UnacctAmt1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.UnacctAmt1).Size = new SizeF(13f / 16f, 0.125f);
    this.UnacctAmt1.SummaryGroup = "GroupHeader1";
    this.UnacctAmt1.SummaryRunning = (SummaryRunning) 2;
    this.UnacctAmt1.SummaryType = (SummaryType) 1;
    this.UnacctAmt1.Text = "Un-Accounted";
    this.IncAmt1.Alignment = (TextAlignment) 2;
    ((ARControl) this.IncAmt1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.IncAmt1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.IncAmt1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.IncAmt1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.IncAmt1).DataField = "IncAmt";
    this.IncAmt1.DistinctField = (string) null;
    this.IncAmt1.Font = new Font("Arial", 8f);
    TextBox incAmt1 = this.IncAmt1;
    object obj23 = componentResourceManager.GetObject("IncAmt1.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) incAmt1).Location = pointF23;
    ((ARControl) this.IncAmt1).Name = "IncAmt1";
    this.IncAmt1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.IncAmt1).Size = new SizeF(13f / 16f, 0.125f);
    this.IncAmt1.SummaryGroup = "GroupHeader1";
    this.IncAmt1.SummaryRunning = (SummaryRunning) 2;
    this.IncAmt1.SummaryType = (SummaryType) 1;
    this.IncAmt1.Text = "MGA Comm";
    this.DepositAmt1.Alignment = (TextAlignment) 2;
    ((ARControl) this.DepositAmt1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.DepositAmt1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.DepositAmt1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.DepositAmt1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.DepositAmt1).DataField = "DepositAmt";
    this.DepositAmt1.DistinctField = (string) null;
    this.DepositAmt1.Font = new Font("Arial", 8f);
    TextBox depositAmt1 = this.DepositAmt1;
    object obj24 = componentResourceManager.GetObject("DepositAmt1.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) depositAmt1).Location = pointF24;
    ((ARControl) this.DepositAmt1).Name = "DepositAmt1";
    this.DepositAmt1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.DepositAmt1).Size = new SizeF(13f / 16f, 0.125f);
    this.DepositAmt1.SummaryGroup = "GroupHeader1";
    this.DepositAmt1.SummaryRunning = (SummaryRunning) 2;
    this.DepositAmt1.SummaryType = (SummaryType) 1;
    this.DepositAmt1.Text = "DepositAmt";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj25 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label12).Location = pointF25;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(1.5f, 0.125f);
    this.Label12.Text = "AR Postings Total:";
    this.Amt3.Alignment = (TextAlignment) 2;
    ((ARControl) this.Amt3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Amt3).DataField = "APAmount";
    this.Amt3.DistinctField = (string) null;
    this.Amt3.Font = new Font("Arial", 8f);
    TextBox amt3 = this.Amt3;
    object obj26 = componentResourceManager.GetObject("Amt3.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) amt3).Location = pointF26;
    ((ARControl) this.Amt3).Name = "Amt3";
    this.Amt3.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.Amt3).Size = new SizeF(13f / 16f, 0.125f);
    this.Amt3.SummaryGroup = "GroupHeader1";
    this.Amt3.SummaryRunning = (SummaryRunning) 2;
    this.Amt3.SummaryType = (SummaryType) 1;
    this.Amt3.Text = "A/P";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.375f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    ((ISupportInitialize) this.txtPolicy).EndInit();
    ((ISupportInitialize) this.txtInvoice).EndInit();
    ((ISupportInitialize) this.txtPremium).EndInit();
    ((ISupportInitialize) this.txtRCI).EndInit();
    ((ISupportInitialize) this.txtSurplus).EndInit();
    ((ISupportInitialize) this.txtExchange).EndInit();
    ((ISupportInitialize) this.txtDeposit).EndInit();
    ((ISupportInitialize) this.txtInsured).EndInit();
    ((ISupportInitialize) this.Amt2).EndInit();
    ((ISupportInitialize) this.lblDeposit).EndInit();
    ((ISupportInitialize) this.lblRCI).EndInit();
    ((ISupportInitialize) this.lblUnaccounted).EndInit();
    ((ISupportInitialize) this.lblExchange).EndInit();
    ((ISupportInitialize) this.lblReceived).EndInit();
    ((ISupportInitialize) this.lblInvoice).EndInit();
    ((ISupportInitialize) this.lblPolicy).EndInit();
    ((ISupportInitialize) this.lblInsured).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Amt1).EndInit();
    ((ISupportInitialize) this.XAmt1).EndInit();
    ((ISupportInitialize) this.UnacctAmt1).EndInit();
    ((ISupportInitialize) this.IncAmt1).EndInit();
    ((ISupportInitialize) this.DepositAmt1).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Amt3).EndInit();
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
