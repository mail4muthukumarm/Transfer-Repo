// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCertificateOfInsurance_PolicyDetails
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptCertificateOfInsurance_PolicyDetails : SectionReport
{
  private TextBox TextBox;
  private CheckBox CheckBox;

  public rptCertificateOfInsurance_PolicyDetails() => this.InitializeComponent();

  public rptCertificateOfInsurance_PolicyDetails(DataView dv)
  {
    this.InitializeComponent();
    this.DataSource = (object) dv;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCertificateOfInsurance_PolicyDetails));
    this.Detail = new Detail();
    this.TextBox = new TextBox();
    this.CheckBox = new CheckBox();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.CheckBox).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.TextBox,
      (ARControl) this.CheckBox
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "PolicyTypeDetail";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj1 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox).Location = pointF1;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(1.375f, 3f / 16f);
    this.TextBox.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.CheckBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox).DataField = "Checked";
    this.CheckBox.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CheckBox.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox = this.CheckBox;
    object obj2 = componentResourceManager.GetObject("CheckBox.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) checkBox).Location = pointF2;
    ((ARControl) this.CheckBox).Name = "CheckBox";
    ((ARControl) this.CheckBox).Size = new SizeF(3f / 16f, 3f / 16f);
    this.CheckBox.Text = "";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 1.572917f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.CheckBox).EndInit();
  }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
