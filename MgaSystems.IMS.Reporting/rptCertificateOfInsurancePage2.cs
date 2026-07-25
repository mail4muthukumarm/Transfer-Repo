// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCertificateOfInsurancePage2
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptCertificateOfInsurancePage2 : MGAReport
{
  private Label Label;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;

  public rptCertificateOfInsurancePage2()
  {
    this.ReportEnd += new EventHandler(this.rptCertificateOfInsurancePage2_ReportEnd);
    this.ReportHeader = (ReportHeader) null;
    this.Detail = (Detail) null;
    this.ReportFooter = (ReportFooter) null;
    this.Label = (Label) null;
    this.Label1 = (Label) null;
    this.Label2 = (Label) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.Label5 = (Label) null;
    this.Label6 = (Label) null;
    this.Label7 = (Label) null;
    this.Label8 = (Label) null;
    this.Label9 = (Label) null;
    this.Label10 = (Label) null;
    this.InitializeComponent();
    this.HidePrintDateAndTime();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCertificateOfInsurancePage2));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3.145139f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.ReportHeader.Height = 0.8847222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label10
    });
    this.ReportFooter.Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.Label.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj1 = componentResourceManager.GetObject("Label.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label).Location = pointF1;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(7.875f, 0.25f);
    this.Label.Text = "IMPORTANT";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj2 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label1).Location = pointF2;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(6.625f, 3f / 16f);
    this.Label1.Text = "If the certificate holder is and ADDITIONAL INSURED, the policy(ies) must be endorsed. A statement";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj3 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label2).Location = pointF3;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(6.625f, 3f / 16f);
    this.Label2.Text = "on this certificate does not confer rights to the certificate holder in lieu of such endorsement(s).";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj4 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label3).Location = pointF4;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(6.625f, 3f / 16f);
    this.Label3.Text = "If SUBROGATION IS WAIVED, subject to the terms and conditions of the policy, certain policies may";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj5 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label4).Location = pointF5;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(6.625f, 3f / 16f);
    this.Label4.Text = "require an endorsement. A statement on this certificate does not confer rights to the certificate";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj6 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label5).Location = pointF6;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(6.625f, 3f / 16f);
    this.Label5.Text = "holder in lieu of such endorsement(s).";
    this.Label6.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj7 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label6).Location = pointF7;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(7.875f, 0.25f);
    this.Label6.Text = "DISCLAIMER";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj8 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label7).Location = pointF8;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(6.625f, 3f / 16f);
    this.Label7.Text = "The Certificate of Insurance on the reverse side of this form does not constitute a contract between";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj9 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label8).Location = pointF9;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(6.625f, 3f / 16f);
    this.Label8.Text = "the issuing insurer(s), authorized representative or producer, and the certificate holder, nor does it";
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj10 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label9).Location = pointF10;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(6.625f, 3f / 16f);
    this.Label9.Text = "affirmatively or negatively amend, extend or alter the coverage afforded by the policies listed thereon.";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj11 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label10).Location = pointF11;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(35f / 16f, 3f / 16f);
    this.Label10.Text = "ACORD 25 (2001/08)";
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
  }

  public override bool HasRecords => true;

  private void rptCertificateOfInsurancePage2_ReportEnd(object sender, EventArgs e)
  {
    this.DrawPageBorder();
  }

  private void DrawPageBorder()
  {
    try
    {
      foreach (Page page in this.Document.Pages)
      {
        page.ForeColor = Color.Black;
        page.DrawLine(page.Margins.Left, page.Margins.Top, page.Margins.Left, page.Height - page.Margins.Bottom - this.ReportFooter.Height);
        page.DrawLine(page.Margins.Left, page.Margins.Top, page.Width - page.Margins.Right, page.Margins.Top);
        page.DrawLine(page.Width - page.Margins.Right, page.Margins.Top, page.Width - page.Margins.Right, page.Height - page.Margins.Bottom - this.ReportFooter.Height);
        page.DrawLine(page.Margins.Left, page.Height - page.Margins.Bottom - this.ReportFooter.Height, page.Width - page.Margins.Right, page.Height - page.Margins.Bottom - this.ReportFooter.Height);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
