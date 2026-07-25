// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptNoteReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public sealed class rptNoteReport : MGAReport
{
  private Label Label2;
  private Label lblSubject;
  private TextBox txtSubject;
  private Label Label1;
  private TextBox txtType;
  private Label Label4;
  private TextBox txtDateCreated;
  private Line Line1;
  private Label Label5;
  private TextBox txtCreatedBy;
  private Label Label6;
  private TextBox txtClaimNumber;
  private Label Label7;
  private TextBox txtDefenseFirm;
  private TextBox txtBody;

  public rptNoteReport(
    DateTime created,
    string subject,
    string noteType,
    string body,
    string createdBy,
    string claimNumber,
    string defenseFirm)
  {
    this.InitializeComponent();
    this.txtSubject.Value = (object) subject;
    this.txtType.Value = (object) noteType;
    this.txtDateCreated.Value = (object) created;
    this.txtCreatedBy.Value = (object) createdBy;
    this.txtClaimNumber.Value = (object) claimNumber;
    this.txtDefenseFirm.Value = (object) defenseFirm;
    this.txtBody.Text = body;
    this.SetStandardMargins();
    this.ShowPageNumbers();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptNoteReport));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.Label2 = new Label();
    this.lblSubject = new Label();
    this.txtSubject = new TextBox();
    this.Label1 = new Label();
    this.txtType = new TextBox();
    this.Label4 = new Label();
    this.txtDateCreated = new TextBox();
    this.Line1 = new Line();
    this.Label5 = new Label();
    this.txtCreatedBy = new TextBox();
    this.Label6 = new Label();
    this.txtClaimNumber = new TextBox();
    this.Label7 = new Label();
    this.txtDefenseFirm = new TextBox();
    this.txtBody = new TextBox();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.lblSubject).BeginInit();
    ((ISupportInitialize) this.txtSubject).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtType).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.txtDateCreated).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtCreatedBy).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.txtClaimNumber).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtDefenseFirm).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.Label2,
      (ARControl) this.lblSubject,
      (ARControl) this.txtSubject,
      (ARControl) this.Label1,
      (ARControl) this.txtType,
      (ARControl) this.Label4,
      (ARControl) this.txtDateCreated,
      (ARControl) this.Line1,
      (ARControl) this.Label5,
      (ARControl) this.txtCreatedBy,
      (ARControl) this.Label6,
      (ARControl) this.txtClaimNumber,
      (ARControl) this.Label7,
      (ARControl) this.txtDefenseFirm,
      (ARControl) this.txtBody
    });
    ((Section) this.Detail).Height = 2.301389f;
    this.Detail.KeepTogether = true;
    ((Section) this.Detail).Name = "Detail";
    this.PageHeader.Height = 0.0f;
    ((Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj1 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label2).Location = pointF1;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1f, 3f / 16f);
    this.Label2.Text = "Body:";
    ((ARControl) this.lblSubject).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSubject).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSubject).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSubject).Border.TopStyle = (BorderLineStyle) 0;
    this.lblSubject.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblSubject.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblSubject.HyperLink = (string) null;
    Label lblSubject = this.lblSubject;
    object obj2 = componentResourceManager.GetObject("lblSubject.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) lblSubject).Location = pointF2;
    ((ARControl) this.lblSubject).Name = "lblSubject";
    ((ARControl) this.lblSubject).Size = new SizeF(1f, 3f / 16f);
    this.lblSubject.Text = "Subject:";
    ((ARControl) this.txtSubject).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubject).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubject).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubject).Border.TopStyle = (BorderLineStyle) 0;
    this.txtSubject.DistinctField = (string) null;
    this.txtSubject.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtSubject.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtSubject = this.txtSubject;
    object obj3 = componentResourceManager.GetObject("txtSubject.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtSubject).Location = pointF3;
    ((ARControl) this.txtSubject).Name = "txtSubject";
    this.txtSubject.OutputFormat = (string) null;
    ((ARControl) this.txtSubject).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj4 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label1).Location = pointF4;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1f, 3f / 16f);
    this.Label1.Text = "Type:";
    ((ARControl) this.txtType).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtType).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtType).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtType).Border.TopStyle = (BorderLineStyle) 0;
    this.txtType.DistinctField = (string) null;
    this.txtType.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtType.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtType = this.txtType;
    object obj5 = componentResourceManager.GetObject("txtType.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) txtType).Location = pointF5;
    ((ARControl) this.txtType).Name = "txtType";
    this.txtType.OutputFormat = (string) null;
    ((ARControl) this.txtType).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj6 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label4).Location = pointF6;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1f, 3f / 16f);
    this.Label4.Text = "Date Created:";
    ((ARControl) this.txtDateCreated).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateCreated).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateCreated).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateCreated).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDateCreated.DistinctField = (string) null;
    this.txtDateCreated.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDateCreated.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDateCreated = this.txtDateCreated;
    object obj7 = componentResourceManager.GetObject("txtDateCreated.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) txtDateCreated).Location = pointF7;
    ((ARControl) this.txtDateCreated).Name = "txtDateCreated";
    this.txtDateCreated.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtDateCreated).Size = new SizeF(6f, 3f / 16f);
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 3f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 7f;
    this.Line1.Y1 = 21f / 16f;
    this.Line1.Y2 = 21f / 16f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj8 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label5).Location = pointF8;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1f, 3f / 16f);
    this.Label5.Text = "Created By:";
    ((ARControl) this.txtCreatedBy).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCreatedBy).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCreatedBy).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCreatedBy).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCreatedBy.DistinctField = (string) null;
    this.txtCreatedBy.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCreatedBy.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCreatedBy = this.txtCreatedBy;
    object obj9 = componentResourceManager.GetObject("txtCreatedBy.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) txtCreatedBy).Location = pointF9;
    ((ARControl) this.txtCreatedBy).Name = "txtCreatedBy";
    this.txtCreatedBy.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtCreatedBy).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj10 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label6).Location = pointF10;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(1f, 3f / 16f);
    this.Label6.Text = "Claim #:";
    ((ARControl) this.txtClaimNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClaimNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClaimNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClaimNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.txtClaimNumber.DistinctField = (string) null;
    this.txtClaimNumber.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtClaimNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtClaimNumber = this.txtClaimNumber;
    object obj11 = componentResourceManager.GetObject("txtClaimNumber.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) txtClaimNumber).Location = pointF11;
    ((ARControl) this.txtClaimNumber).Name = "txtClaimNumber";
    ((ARControl) this.txtClaimNumber).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj12 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label7).Location = pointF12;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(1f, 3f / 16f);
    this.Label7.Text = "Defense Firm:";
    ((ARControl) this.txtDefenseFirm).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDefenseFirm).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDefenseFirm).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDefenseFirm).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDefenseFirm.DistinctField = (string) null;
    this.txtDefenseFirm.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDefenseFirm.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDefenseFirm = this.txtDefenseFirm;
    object obj13 = componentResourceManager.GetObject("txtDefenseFirm.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) txtDefenseFirm).Location = pointF13;
    ((ARControl) this.txtDefenseFirm).Name = "txtDefenseFirm";
    this.txtDefenseFirm.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtDefenseFirm).Size = new SizeF(6f, 3f / 16f);
    this.txtBody.BackColor = Color.Transparent;
    ((ARControl) this.txtBody).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBody).Border.TopStyle = (BorderLineStyle) 0;
    this.txtBody.Font = new Font("Arial", 10f);
    this.txtBody.ForeColor = Color.Black;
    TextBox txtBody = this.txtBody;
    object obj14 = componentResourceManager.GetObject("txtBody.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtBody).Location = pointF14;
    ((ARControl) this.txtBody).Name = "txtBody";
    ((ARControl) this.txtBody).Size = new SizeF(6f, 1f);
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter);
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.lblSubject).EndInit();
    ((ISupportInitialize) this.txtSubject).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtType).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.txtDateCreated).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtCreatedBy).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.txtClaimNumber).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtDefenseFirm).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
