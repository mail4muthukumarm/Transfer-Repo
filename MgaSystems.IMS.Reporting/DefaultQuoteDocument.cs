// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.DefaultQuoteDocument
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{B474F503-F020-47ff-A602-208722368DE8}", Enums.AutomationDocGroups.PolicyDoc, "Default Quote Document", "This is a generic quote document for generic premium capture.")]
public class DefaultQuoteDocument : SectionReport, IQuoteDocument
{
  private Guid _quoteOptionGuid;
  private Label Label1;
  private TextBox txtPremium;

  public DefaultQuoteDocument()
  {
    this.ReportStart += new EventHandler(this.DefaultQuoteDocument_ReportStart);
    this.InitializeComponent();
  }

  public DefaultQuoteDocument(Guid quoteGuid)
  {
    this.ReportStart += new EventHandler(this.DefaultQuoteDocument_ReportStart);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DefaultQuoteDocument));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.Label1 = new Label();
    this.txtPremium = new TextBox();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtPremium).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtPremium
    });
    ((Section) this.Detail).Height = 15f / 32f;
    ((Section) this.Detail).Name = "Detail";
    this.PageHeader.Height = 0.25f;
    ((Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.25f;
    ((Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(21f / 16f, 0.2f);
    this.Label1.Text = "Policy Premium:";
    ((ARControl) this.txtPremium).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPremium).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPremium).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPremium).Border.TopStyle = (BorderLineStyle) 0;
    this.txtPremium.DistinctField = (string) null;
    this.txtPremium.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtPremium.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPremium = this.txtPremium;
    object obj2 = componentResourceManager.GetObject("txtPremium.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtPremium).Location = pointF2;
    ((ARControl) this.txtPremium).Name = "txtPremium";
    this.txtPremium.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtPremium).Size = new SizeF(1f, 0.2f);
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtPremium).EndInit();
  }

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    this._quoteOptionGuid = quoteOptionGuids[0];
  }

  private void DefaultQuoteDocument_ReportStart(object sender, EventArgs e)
  {
    this.txtPremium.Text = Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Premium FROM tblQuoteOptions WHERE QuoteOptionGuid=@QOG", new object[2]
    {
      (object) "@QOG",
      (object) this._quoteOptionGuid
    })));
  }

  public bool RequiresQuoteOptionGuids() => true;

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
