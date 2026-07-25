// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCommonFooter1
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptCommonFooter1 : SectionReport
{
  private Label Label37;
  private TextBox txtBody_ProducerCommission;
  private Label Label41;
  private SubReport srpRemiumAndFees;
  private CheckBox chkAgentResponsible;
  private Label Label46;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private Label lblUnderwriterApproval;
  private Label lblDateApproved;
  private TextBox txtUnderwriterApproval;
  private TextBox txtDateApproved;
  private Guid _QuoteOptionGuid;
  private readonly bool _IsQuote;
  private readonly bool _ShowAgentResponsible;

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptCommonFooter1(Guid QuoteOptionGuid, bool IsQuote)
  {
    this.ReportStart += new EventHandler(this.rptCommonFooter1_ReportStart);
    this.InitializeComponent();
    this._QuoteOptionGuid = QuoteOptionGuid;
    this._IsQuote = IsQuote;
    this._ShowAgentResponsible = false;
  }

  public rptCommonFooter1(Guid QuoteOptionGuid, bool IsQuote, bool ShowAgentResponsible)
  {
    this.ReportStart += new EventHandler(this.rptCommonFooter1_ReportStart);
    this.InitializeComponent();
    this._QuoteOptionGuid = QuoteOptionGuid;
    this._IsQuote = IsQuote;
    this._ShowAgentResponsible = ShowAgentResponsible;
  }

  private void rptCommonFooter1_ReportStart(object sender, EventArgs e)
  {
    ((ARControl) this.chkAgentResponsible).Visible = this._ShowAgentResponsible;
    this.srpRemiumAndFees.Report = (SectionReport) new rptPremiumAndFeeBreakout(this._QuoteOptionGuid);
    ((ARControl) this.lblDateApproved).Visible = !this._IsQuote;
    ((ARControl) this.txtDateApproved).Visible = !this._IsQuote;
    ((ARControl) this.lblUnderwriterApproval).Visible = !this._IsQuote;
    ((ARControl) this.txtUnderwriterApproval).Visible = !this._IsQuote;
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable(nameof (rptCommonFooter1), new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) this._QuoteOptionGuid
    });
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCommonFooter1));
    this.Detail = new Detail();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label37 = new Label();
    this.txtBody_ProducerCommission = new TextBox();
    this.Label41 = new Label();
    this.srpRemiumAndFees = new SubReport();
    this.chkAgentResponsible = new CheckBox();
    this.Label46 = new Label();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.lblUnderwriterApproval = new Label();
    this.lblDateApproved = new Label();
    this.txtUnderwriterApproval = new TextBox();
    this.txtDateApproved = new TextBox();
    ((ISupportInitialize) this.Label37).BeginInit();
    ((ISupportInitialize) this.txtBody_ProducerCommission).BeginInit();
    ((ISupportInitialize) this.Label41).BeginInit();
    ((ISupportInitialize) this.chkAgentResponsible).BeginInit();
    ((ISupportInitialize) this.Label46).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.lblUnderwriterApproval).BeginInit();
    ((ISupportInitialize) this.lblDateApproved).BeginInit();
    ((ISupportInitialize) this.txtUnderwriterApproval).BeginInit();
    ((ISupportInitialize) this.txtDateApproved).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label41,
      (ARControl) this.srpRemiumAndFees
    });
    ((Section) this.Detail).Height = 0.1763889f;
    ((Section) this.Detail).Name = "Detail";
    ((Section) this.GroupHeader1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label37,
      (ARControl) this.txtBody_ProducerCommission
    });
    this.GroupHeader1.Height = 0.2909722f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((Section) this.GroupFooter1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.chkAgentResponsible,
      (ARControl) this.Label46,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.lblUnderwriterApproval,
      (ARControl) this.lblDateApproved,
      (ARControl) this.txtUnderwriterApproval,
      (ARControl) this.txtDateApproved
    });
    this.GroupFooter1.Height = 2.854167f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label37).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label37).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label37).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label37).Border.TopStyle = (BorderLineStyle) 0;
    this.Label37.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label37.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label37.HyperLink = (string) null;
    Label label37 = this.Label37;
    object obj1 = componentResourceManager.GetObject("Label37.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label37).Location = pointF1;
    ((ARControl) this.Label37).Name = "Label37";
    ((ARControl) this.Label37).Size = new SizeF(1.75f, 3f / 16f);
    this.Label37.Text = "Producer Commission:";
    ((ARControl) this.txtBody_ProducerCommission).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_ProducerCommission).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_ProducerCommission).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_ProducerCommission).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody_ProducerCommission).DataField = "ProducerCommission";
    this.txtBody_ProducerCommission.DistinctField = (string) null;
    this.txtBody_ProducerCommission.Font = new Font("Arial", 11f);
    this.txtBody_ProducerCommission.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox producerCommission = this.txtBody_ProducerCommission;
    object obj2 = componentResourceManager.GetObject("txtBody_ProducerCommission.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) producerCommission).Location = pointF2;
    ((ARControl) this.txtBody_ProducerCommission).Name = "txtBody_ProducerCommission";
    this.txtBody_ProducerCommission.OutputFormat = (string) null;
    ((ARControl) this.txtBody_ProducerCommission).Size = new SizeF(15f / 16f, 3f / 16f);
    ((ARControl) this.Label41).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label41).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label41).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label41).Border.TopStyle = (BorderLineStyle) 0;
    this.Label41.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label41.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label41.HyperLink = (string) null;
    Label label41 = this.Label41;
    object obj3 = componentResourceManager.GetObject("Label41.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label41).Location = pointF3;
    ((ARControl) this.Label41).Name = "Label41";
    ((ARControl) this.Label41).Size = new SizeF(0.875f, 3f / 16f);
    this.Label41.Text = "Premium:";
    ((ARControl) this.srpRemiumAndFees).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srpRemiumAndFees).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srpRemiumAndFees).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srpRemiumAndFees).Border.TopStyle = (BorderLineStyle) 0;
    this.srpRemiumAndFees.CloseBorder = false;
    SubReport srpRemiumAndFees = this.srpRemiumAndFees;
    object obj4 = componentResourceManager.GetObject("srpRemiumAndFees.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) srpRemiumAndFees).Location = pointF4;
    ((ARControl) this.srpRemiumAndFees).Name = "srpRemiumAndFees";
    this.srpRemiumAndFees.Report = (SectionReport) null;
    ((ARControl) this.srpRemiumAndFees).Size = new SizeF(5.25f, 3f / 16f);
    ((ARControl) this.chkAgentResponsible).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.chkAgentResponsible).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.chkAgentResponsible).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.chkAgentResponsible).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.chkAgentResponsible).DataField = "AgentResponsible";
    this.chkAgentResponsible.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.chkAgentResponsible.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox agentResponsible = this.chkAgentResponsible;
    object obj5 = componentResourceManager.GetObject("chkAgentResponsible.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) agentResponsible).Location = pointF5;
    ((ARControl) this.chkAgentResponsible).Name = "chkAgentResponsible";
    ((ARControl) this.chkAgentResponsible).Size = new SizeF(89f / 16f, 3f / 16f);
    this.chkAgentResponsible.Text = "Agent responsible for surplus lines filings and fees.";
    ((ARControl) this.Label46).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label46).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label46).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label46).Border.TopStyle = (BorderLineStyle) 0;
    this.Label46.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label46.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label46.HyperLink = (string) null;
    Label label46 = this.Label46;
    object obj6 = componentResourceManager.GetObject("Label46.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label46).Location = pointF6;
    ((ARControl) this.Label46).Name = "Label46";
    ((ARControl) this.Label46).Size = new SizeF(0.875f, 3f / 16f);
    this.Label46.Text = "Comments:";
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "QuoteComments";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj7 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox4).Location = pointF7;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(7f, 0.688f);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "FooterText";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 10f, FontStyle.Bold);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj8 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox5).Location = pointF8;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(7.875f, 0.688f);
    ((ARControl) this.lblUnderwriterApproval).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblUnderwriterApproval).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblUnderwriterApproval).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblUnderwriterApproval).Border.TopStyle = (BorderLineStyle) 0;
    this.lblUnderwriterApproval.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblUnderwriterApproval.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblUnderwriterApproval.HyperLink = (string) null;
    Label underwriterApproval1 = this.lblUnderwriterApproval;
    object obj9 = componentResourceManager.GetObject("lblUnderwriterApproval.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) underwriterApproval1).Location = pointF9;
    ((ARControl) this.lblUnderwriterApproval).Name = "lblUnderwriterApproval";
    ((ARControl) this.lblUnderwriterApproval).Size = new SizeF(1.625f, 3f / 16f);
    this.lblUnderwriterApproval.Text = "Underwriter's Approval:";
    ((ARControl) this.lblDateApproved).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDateApproved).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDateApproved).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDateApproved).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDateApproved.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblDateApproved.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblDateApproved.HyperLink = (string) null;
    Label lblDateApproved = this.lblDateApproved;
    object obj10 = componentResourceManager.GetObject("lblDateApproved.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) lblDateApproved).Location = pointF10;
    ((ARControl) this.lblDateApproved).Name = "lblDateApproved";
    ((ARControl) this.lblDateApproved).Size = new SizeF(7f / 16f, 3f / 16f);
    this.lblDateApproved.Text = "Date:";
    ((ARControl) this.txtUnderwriterApproval).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderwriterApproval).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderwriterApproval).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderwriterApproval).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderwriterApproval).DataField = "Underwriter";
    this.txtUnderwriterApproval.DistinctField = (string) null;
    this.txtUnderwriterApproval.Font = new Font("Arial", 11f);
    this.txtUnderwriterApproval.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox underwriterApproval2 = this.txtUnderwriterApproval;
    object obj11 = componentResourceManager.GetObject("txtUnderwriterApproval.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) underwriterApproval2).Location = pointF11;
    ((ARControl) this.txtUnderwriterApproval).Name = "txtUnderwriterApproval";
    this.txtUnderwriterApproval.OutputFormat = (string) null;
    ((ARControl) this.txtUnderwriterApproval).Size = new SizeF(6.25f, 3f / 16f);
    ((ARControl) this.txtDateApproved).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateApproved).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateApproved).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateApproved).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateApproved).DataField = "ApprovedDate";
    this.txtDateApproved.DistinctField = (string) null;
    this.txtDateApproved.Font = new Font("Arial", 11f);
    this.txtDateApproved.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDateApproved = this.txtDateApproved;
    object obj12 = componentResourceManager.GetObject("txtDateApproved.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtDateApproved).Location = pointF12;
    ((ARControl) this.txtDateApproved).Name = "txtDateApproved";
    this.txtDateApproved.OutputFormat = (string) null;
    ((ARControl) this.txtDateApproved).Size = new SizeF(19f / 16f, 3f / 16f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter1);
    ((ISupportInitialize) this.Label37).EndInit();
    ((ISupportInitialize) this.txtBody_ProducerCommission).EndInit();
    ((ISupportInitialize) this.Label41).EndInit();
    ((ISupportInitialize) this.chkAgentResponsible).EndInit();
    ((ISupportInitialize) this.Label46).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.lblUnderwriterApproval).EndInit();
    ((ISupportInitialize) this.lblDateApproved).EndInit();
    ((ISupportInitialize) this.txtUnderwriterApproval).EndInit();
    ((ISupportInitialize) this.txtDateApproved).EndInit();
  }
}
