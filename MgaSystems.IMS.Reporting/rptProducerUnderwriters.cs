// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProducerUnderwriters
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{B3444DDC-FFD1-4868-A9FE-532F29E0926C}", "Producer Underwriter Contacts", "List of Producer Underwriter contacts (only exportable to excel)", "Contacts")]
public class rptProducerUnderwriters : MGAReport, IReport
{
  private Label Label;
  private DataSet _ds;

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptProducerUnderwriters));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.Label = new Label();
    ((ISupportInitialize) this.Label).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.4270833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.Label.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj = componentResourceManager.GetObject("Label.Location");
    PointF pointF = obj != null ? (PointF) obj : new PointF();
    ((ARControl) label).Location = pointF;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(7.875f, 0.25f);
    this.Label.Text = "Please export to excel to get the results";
    this.Label.VerticalAlignment = (VerticalTextAlignment) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.Label).EndInit();
  }

  public rptProducerUnderwriters()
  {
    this.ReportStart += new EventHandler(this.rptProducerUnderwriters_ReportStart);
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.Label = (Label) null;
    this.InitializeComponent();
  }

  private void rptProducerUnderwriters_ReportStart(object sender, EventArgs e)
  {
    this._ds = new DataSet();
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(nameof (rptProducerUnderwriters), dbConnection))
      {
        using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command))
        {
          command.CommandType = CommandType.StoredProcedure;
          DefaultDatabase.DataAdapterFill(dataAdapter, this._ds);
        }
      }
    }
  }

  public override bool HasRecords => true;

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds.Tables[0], SaveFileTo);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;
}
