// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptContactList_Insureds
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{360C5A4C-AE41-4db6-9B33-DDD27BE4FDFC}", "Insured Contact List", "Lists insured addresses.", "Contacts")]
public class rptContactList_Insureds : MGAReport, IReport
{
  internal const string SecurityIDModifyGroupDescription = "{360C5A4C-AE41-4db6-9B33-DDD27BE4FDFC}";
  private TextBox txtTitle;
  private TextBox TextBox1;

  public rptContactList_Insureds()
  {
  }

  public rptContactList_Insureds(Guid InsuredGuid)
  {
    this.InitializeComponent();
    if (InsuredGuid.Equals(Guid.Empty))
      this.DataSource = (object) DefaultDatabase.ExecuteDataTable("rptContactList", new object[4]
      {
        (object) "@InsuredGuid",
        (object) InsuredGuid,
        (object) "@SelectAll",
        (object) 1
      });
    else
      this.DataSource = (object) DefaultDatabase.ExecuteDataTable("rptContactList", new object[2]
      {
        (object) "@InsuredGuid",
        (object) InsuredGuid
      });
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptContactList_Insureds));
    this.Detail = new Detail();
    this.ghTitle = new GroupHeader();
    this.gfTitle = new GroupFooter();
    this.txtTitle = new TextBox();
    this.TextBox1 = new TextBox();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTitle).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtTitle
    });
    this.ghTitle.Height = 0.2388889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTitle).Name = "ghTitle";
    this.gfTitle.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTitle).Name = "gfTitle";
    this.txtTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTitle.DistinctField = (string) null;
    this.txtTitle.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTitle.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTitle = this.txtTitle;
    object obj1 = componentResourceManager.GetObject("txtTitle.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtTitle).Location = pointF1;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.OutputFormat = (string) null;
    ((ARControl) this.txtTitle).Size = new SizeF(6.5f, 3f / 16f);
    this.txtTitle.Text = "Insured Contacts";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Address";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj2 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox1).Location = pointF2;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(6.5f, 3f / 16f);
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTitle);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTitle);
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[1]
      {
        (BaseReportControl) new Insureds("Insured", true)
      };
    }
  }

  [field: AccessedThroughProperty("ghTitle")]
  private virtual GroupHeader ghTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfTitle")]
  private virtual GroupFooter gfTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
