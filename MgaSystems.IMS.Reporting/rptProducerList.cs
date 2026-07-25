// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProducerList
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
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

[SecureReportResource("{6C9E674B-346E-45a1-9B5E-A34D3C96CB7B}", "Producer Contact List By Client Office", "Lists producer contact List by office location", "Contacts")]
public class rptProducerList : MGAReport, IReport
{
  private Label Label;
  private Label lblProducer;
  private Label lblAddress2;
  private Label lblCity;
  private Label lblState;
  private Label lblZip;
  private Label lblPhoneNumber;
  private Label lblFaxNumber;
  private Label lblContact;
  private Label lblAddress1;
  private Label lblStatus;
  private TextBox txtProducer;
  private TextBox txtState;
  private TextBox txtZip;
  private TextBox txtFaxNumber;
  private TextBox txtPhoneNumber;
  private TextBox txtCity;
  private TextBox txtAddress2;
  private TextBox txtAddress1;
  private SubReport srContacts;
  private Label ProducerLocationGuid;
  private TextBox txtStatus;
  private readonly Guid _OfficeGuid;
  private readonly bool _ShowIndividualContacts;
  private DataSet _ds;
  private readonly int _StatusID;
  private readonly string _ProducerLocationGuid;
  private readonly int _ProducerTypeID;
  private DataTable _ExcelDT;
  private int _rowCount;

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptProducerList));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.Label = new Label();
    this.lblProducer = new Label();
    this.lblAddress2 = new Label();
    this.lblCity = new Label();
    this.lblState = new Label();
    this.lblZip = new Label();
    this.lblPhoneNumber = new Label();
    this.lblFaxNumber = new Label();
    this.lblContact = new Label();
    this.lblAddress1 = new Label();
    this.lblStatus = new Label();
    this.txtProducer = new TextBox();
    this.txtState = new TextBox();
    this.txtZip = new TextBox();
    this.txtFaxNumber = new TextBox();
    this.txtPhoneNumber = new TextBox();
    this.txtCity = new TextBox();
    this.txtAddress2 = new TextBox();
    this.txtAddress1 = new TextBox();
    this.srContacts = new SubReport();
    this.ProducerLocationGuid = new Label();
    this.txtStatus = new TextBox();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.lblProducer).BeginInit();
    ((ISupportInitialize) this.lblAddress2).BeginInit();
    ((ISupportInitialize) this.lblCity).BeginInit();
    ((ISupportInitialize) this.lblState).BeginInit();
    ((ISupportInitialize) this.lblZip).BeginInit();
    ((ISupportInitialize) this.lblPhoneNumber).BeginInit();
    ((ISupportInitialize) this.lblFaxNumber).BeginInit();
    ((ISupportInitialize) this.lblContact).BeginInit();
    ((ISupportInitialize) this.lblAddress1).BeginInit();
    ((ISupportInitialize) this.lblStatus).BeginInit();
    ((ISupportInitialize) this.txtProducer).BeginInit();
    ((ISupportInitialize) this.txtState).BeginInit();
    ((ISupportInitialize) this.txtZip).BeginInit();
    ((ISupportInitialize) this.txtFaxNumber).BeginInit();
    ((ISupportInitialize) this.txtPhoneNumber).BeginInit();
    ((ISupportInitialize) this.txtCity).BeginInit();
    ((ISupportInitialize) this.txtAddress2).BeginInit();
    ((ISupportInitialize) this.txtAddress1).BeginInit();
    ((ISupportInitialize) this.ProducerLocationGuid).BeginInit();
    ((ISupportInitialize) this.txtStatus).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.txtProducer,
      (ARControl) this.txtState,
      (ARControl) this.txtZip,
      (ARControl) this.txtFaxNumber,
      (ARControl) this.txtPhoneNumber,
      (ARControl) this.txtCity,
      (ARControl) this.txtAddress2,
      (ARControl) this.txtAddress1,
      (ARControl) this.srContacts,
      (ARControl) this.ProducerLocationGuid,
      (ARControl) this.txtStatus
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1451389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label
    });
    this.ReportHeader.Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.lblProducer,
      (ARControl) this.lblAddress2,
      (ARControl) this.lblCity,
      (ARControl) this.lblState,
      (ARControl) this.lblZip,
      (ARControl) this.lblPhoneNumber,
      (ARControl) this.lblFaxNumber,
      (ARControl) this.lblContact,
      (ARControl) this.lblAddress1,
      (ARControl) this.lblStatus
    });
    this.PageHeader.Height = 0.25f;
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
    object obj1 = componentResourceManager.GetObject("Label.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label).Location = pointF1;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(10.375f, 3f / 16f);
    this.Label.Text = "Producer List";
    this.Label.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.lblProducer).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblProducer).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Border.TopStyle = (BorderLineStyle) 0;
    this.lblProducer.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblProducer.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblProducer.HyperLink = (string) null;
    Label lblProducer = this.lblProducer;
    object obj2 = componentResourceManager.GetObject("lblProducer.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) lblProducer).Location = pointF2;
    ((ARControl) this.lblProducer).Name = "lblProducer";
    ((ARControl) this.lblProducer).Size = new SizeF(15f / 16f, 3f / 16f);
    this.lblProducer.Text = "Producer";
    ((ARControl) this.lblAddress2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblAddress2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAddress2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAddress2).Border.TopStyle = (BorderLineStyle) 0;
    this.lblAddress2.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblAddress2.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblAddress2.HyperLink = (string) null;
    Label lblAddress2 = this.lblAddress2;
    object obj3 = componentResourceManager.GetObject("lblAddress2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) lblAddress2).Location = pointF3;
    ((ARControl) this.lblAddress2).Name = "lblAddress2";
    ((ARControl) this.lblAddress2).Size = new SizeF(25f / 16f, 3f / 16f);
    this.lblAddress2.Text = "Address 2";
    ((ARControl) this.lblCity).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblCity).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCity).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCity).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCity.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCity.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCity.HyperLink = (string) null;
    Label lblCity = this.lblCity;
    object obj4 = componentResourceManager.GetObject("lblCity.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) lblCity).Location = pointF4;
    ((ARControl) this.lblCity).Name = "lblCity";
    ((ARControl) this.lblCity).Size = new SizeF(1.375f, 3f / 16f);
    this.lblCity.Text = "City";
    ((ARControl) this.lblState).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblState).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblState).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblState).Border.TopStyle = (BorderLineStyle) 0;
    this.lblState.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblState.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblState.HyperLink = (string) null;
    Label lblState = this.lblState;
    object obj5 = componentResourceManager.GetObject("lblState.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) lblState).Location = pointF5;
    ((ARControl) this.lblState).Name = "lblState";
    ((ARControl) this.lblState).Size = new SizeF(0.5f, 3f / 16f);
    this.lblState.Text = "State";
    ((ARControl) this.lblZip).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblZip).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblZip).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblZip).Border.TopStyle = (BorderLineStyle) 0;
    this.lblZip.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblZip.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblZip.HyperLink = (string) null;
    Label lblZip = this.lblZip;
    object obj6 = componentResourceManager.GetObject("lblZip.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) lblZip).Location = pointF6;
    ((ARControl) this.lblZip).Name = "lblZip";
    ((ARControl) this.lblZip).Size = new SizeF(15f / 16f, 3f / 16f);
    this.lblZip.Text = "Zip";
    ((ARControl) this.lblPhoneNumber).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblPhoneNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPhoneNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPhoneNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.lblPhoneNumber.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblPhoneNumber.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblPhoneNumber.HyperLink = (string) null;
    Label lblPhoneNumber = this.lblPhoneNumber;
    object obj7 = componentResourceManager.GetObject("lblPhoneNumber.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) lblPhoneNumber).Location = pointF7;
    ((ARControl) this.lblPhoneNumber).Name = "lblPhoneNumber";
    ((ARControl) this.lblPhoneNumber).Size = new SizeF(0.875f, 3f / 16f);
    this.lblPhoneNumber.Text = "Phone #";
    ((ARControl) this.lblFaxNumber).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblFaxNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblFaxNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblFaxNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.lblFaxNumber.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFaxNumber.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblFaxNumber.HyperLink = (string) null;
    Label lblFaxNumber = this.lblFaxNumber;
    object obj8 = componentResourceManager.GetObject("lblFaxNumber.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) lblFaxNumber).Location = pointF8;
    ((ARControl) this.lblFaxNumber).Name = "lblFaxNumber";
    ((ARControl) this.lblFaxNumber).Size = new SizeF(15f / 16f, 3f / 16f);
    this.lblFaxNumber.Text = "Fax #";
    ((ARControl) this.lblContact).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblContact).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblContact).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblContact).Border.TopStyle = (BorderLineStyle) 0;
    this.lblContact.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblContact.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblContact.HyperLink = (string) null;
    Label lblContact = this.lblContact;
    object obj9 = componentResourceManager.GetObject("lblContact.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) lblContact).Location = pointF9;
    ((ARControl) this.lblContact).Name = "lblContact";
    ((ARControl) this.lblContact).Size = new SizeF(17f / 16f, 3f / 16f);
    this.lblContact.Text = "Contact";
    ((ARControl) this.lblAddress1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblAddress1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAddress1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAddress1).Border.TopStyle = (BorderLineStyle) 0;
    this.lblAddress1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblAddress1.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblAddress1.HyperLink = (string) null;
    Label lblAddress1 = this.lblAddress1;
    object obj10 = componentResourceManager.GetObject("lblAddress1.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) lblAddress1).Location = pointF10;
    ((ARControl) this.lblAddress1).Name = "lblAddress1";
    ((ARControl) this.lblAddress1).Size = new SizeF(25f / 16f, 3f / 16f);
    this.lblAddress1.Text = "Address 1";
    ((ARControl) this.lblStatus).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblStatus).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblStatus).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblStatus).Border.TopStyle = (BorderLineStyle) 0;
    this.lblStatus.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblStatus.HyperLink = (string) null;
    Label lblStatus = this.lblStatus;
    object obj11 = componentResourceManager.GetObject("lblStatus.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) lblStatus).Location = pointF11;
    ((ARControl) this.lblStatus).Name = "lblStatus";
    ((ARControl) this.lblStatus).Size = new SizeF(0.563f, 0.188f);
    this.lblStatus.Text = "Status";
    ((ARControl) this.txtProducer).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducer).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducer).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducer).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtProducer).DataField = "Name";
    this.txtProducer.DistinctField = (string) null;
    this.txtProducer.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtProducer.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtProducer = this.txtProducer;
    object obj12 = componentResourceManager.GetObject("txtProducer.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtProducer).Location = pointF12;
    ((ARControl) this.txtProducer).Name = "txtProducer";
    this.txtProducer.OutputFormat = (string) null;
    ((ARControl) this.txtProducer).Size = new SizeF(0.938f, 0.15f);
    ((ARControl) this.txtState).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtState).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtState).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtState).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtState).DataField = "State";
    this.txtState.DistinctField = (string) null;
    this.txtState.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtState.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtState = this.txtState;
    object obj13 = componentResourceManager.GetObject("txtState.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) txtState).Location = pointF13;
    ((ARControl) this.txtState).Name = "txtState";
    this.txtState.OutputFormat = (string) null;
    ((ARControl) this.txtState).Size = new SizeF(0.5f, 0.15f);
    ((ARControl) this.txtZip).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtZip).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtZip).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtZip).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtZip).DataField = "ZipCode";
    this.txtZip.DistinctField = (string) null;
    this.txtZip.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtZip.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtZip = this.txtZip;
    object obj14 = componentResourceManager.GetObject("txtZip.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtZip).Location = pointF14;
    ((ARControl) this.txtZip).Name = "txtZip";
    this.txtZip.OutputFormat = (string) null;
    ((ARControl) this.txtZip).Size = new SizeF(0.938f, 0.15f);
    ((ARControl) this.txtFaxNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFaxNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFaxNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFaxNumber).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFaxNumber).DataField = "Fax";
    this.txtFaxNumber.DistinctField = (string) null;
    this.txtFaxNumber.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFaxNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtFaxNumber = this.txtFaxNumber;
    object obj15 = componentResourceManager.GetObject("txtFaxNumber.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) txtFaxNumber).Location = pointF15;
    ((ARControl) this.txtFaxNumber).Name = "txtFaxNumber";
    this.txtFaxNumber.OutputFormat = (string) null;
    ((ARControl) this.txtFaxNumber).Size = new SizeF(0.938f, 0.15f);
    ((ARControl) this.txtPhoneNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPhoneNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPhoneNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPhoneNumber).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPhoneNumber).DataField = "Phone";
    this.txtPhoneNumber.DistinctField = (string) null;
    this.txtPhoneNumber.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtPhoneNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPhoneNumber = this.txtPhoneNumber;
    object obj16 = componentResourceManager.GetObject("txtPhoneNumber.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) txtPhoneNumber).Location = pointF16;
    ((ARControl) this.txtPhoneNumber).Name = "txtPhoneNumber";
    this.txtPhoneNumber.OutputFormat = (string) null;
    ((ARControl) this.txtPhoneNumber).Size = new SizeF(0.876f, 0.15f);
    ((ARControl) this.txtCity).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCity).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCity).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCity).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCity).DataField = "City";
    this.txtCity.DistinctField = (string) null;
    this.txtCity.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCity.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCity = this.txtCity;
    object obj17 = componentResourceManager.GetObject("txtCity.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) txtCity).Location = pointF17;
    ((ARControl) this.txtCity).Name = "txtCity";
    this.txtCity.OutputFormat = (string) null;
    ((ARControl) this.txtCity).Size = new SizeF(1.375f, 0.15f);
    ((ARControl) this.txtAddress2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAddress2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAddress2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAddress2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAddress2).DataField = "Address2";
    this.txtAddress2.DistinctField = (string) null;
    this.txtAddress2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAddress2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAddress2 = this.txtAddress2;
    object obj18 = componentResourceManager.GetObject("txtAddress2.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) txtAddress2).Location = pointF18;
    ((ARControl) this.txtAddress2).Name = "txtAddress2";
    this.txtAddress2.OutputFormat = (string) null;
    ((ARControl) this.txtAddress2).Size = new SizeF(1.563f, 0.15f);
    ((ARControl) this.txtAddress1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAddress1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAddress1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAddress1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAddress1).DataField = "Address1";
    this.txtAddress1.DistinctField = (string) null;
    this.txtAddress1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAddress1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAddress1 = this.txtAddress1;
    object obj19 = componentResourceManager.GetObject("txtAddress1.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) txtAddress1).Location = pointF19;
    ((ARControl) this.txtAddress1).Name = "txtAddress1";
    this.txtAddress1.OutputFormat = (string) null;
    ((ARControl) this.txtAddress1).Size = new SizeF(1.563f, 0.15f);
    ((ARControl) this.srContacts).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srContacts).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srContacts).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srContacts).Border.TopStyle = (BorderLineStyle) 0;
    this.srContacts.CloseBorder = false;
    SubReport srContacts = this.srContacts;
    object obj20 = componentResourceManager.GetObject("srContacts.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) srContacts).Location = pointF20;
    ((ARControl) this.srContacts).Name = "srContacts";
    this.srContacts.Report = (SectionReport) null;
    ((ARControl) this.srContacts).Size = new SizeF(1.063f, 0.15f);
    this.ProducerLocationGuid.BackColor = Color.Yellow;
    ((ARControl) this.ProducerLocationGuid).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.ProducerLocationGuid).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.ProducerLocationGuid).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.ProducerLocationGuid).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.ProducerLocationGuid).DataField = "ProducerLocationGuid";
    this.ProducerLocationGuid.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ProducerLocationGuid.ForeColor = Color.FromArgb(0, 0, 0);
    this.ProducerLocationGuid.HyperLink = (string) null;
    Label producerLocationGuid = this.ProducerLocationGuid;
    object obj21 = componentResourceManager.GetObject("ProducerLocationGuid.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) producerLocationGuid).Location = pointF21;
    ((ARControl) this.ProducerLocationGuid).Name = "ProducerLocationGuid";
    ((ARControl) this.ProducerLocationGuid).Size = new SizeF(11f / 16f, 1f / 16f);
    this.ProducerLocationGuid.Text = "";
    ((ARControl) this.ProducerLocationGuid).Visible = false;
    ((ARControl) this.txtStatus).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStatus).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStatus).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStatus).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtStatus).DataField = "Status";
    this.txtStatus.DistinctField = (string) null;
    this.txtStatus.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtStatus.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtStatus = this.txtStatus;
    object obj22 = componentResourceManager.GetObject("txtStatus.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) txtStatus).Location = pointF22;
    ((ARControl) this.txtStatus).Name = "txtStatus";
    this.txtStatus.OutputFormat = (string) null;
    ((ARControl) this.txtStatus).Size = new SizeF(0.563f, 0.15f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.lblProducer).EndInit();
    ((ISupportInitialize) this.lblAddress2).EndInit();
    ((ISupportInitialize) this.lblCity).EndInit();
    ((ISupportInitialize) this.lblState).EndInit();
    ((ISupportInitialize) this.lblZip).EndInit();
    ((ISupportInitialize) this.lblPhoneNumber).EndInit();
    ((ISupportInitialize) this.lblFaxNumber).EndInit();
    ((ISupportInitialize) this.lblContact).EndInit();
    ((ISupportInitialize) this.lblAddress1).EndInit();
    ((ISupportInitialize) this.lblStatus).EndInit();
    ((ISupportInitialize) this.txtProducer).EndInit();
    ((ISupportInitialize) this.txtState).EndInit();
    ((ISupportInitialize) this.txtZip).EndInit();
    ((ISupportInitialize) this.txtFaxNumber).EndInit();
    ((ISupportInitialize) this.txtPhoneNumber).EndInit();
    ((ISupportInitialize) this.txtCity).EndInit();
    ((ISupportInitialize) this.txtAddress2).EndInit();
    ((ISupportInitialize) this.txtAddress1).EndInit();
    ((ISupportInitialize) this.ProducerLocationGuid).EndInit();
    ((ISupportInitialize) this.txtStatus).EndInit();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptProducerList()
  {
    this.ReportStart += new EventHandler(this.rptProducerList_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
  }

  public rptProducerList(
    Guid OfficeGuid,
    string ProducerLocationGuid,
    int StatusID,
    bool ShowIndividualContacts,
    int ProducerTypeID)
  {
    this.ReportStart += new EventHandler(this.rptProducerList_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
    this._OfficeGuid = OfficeGuid;
    this._ShowIndividualContacts = ShowIndividualContacts;
    this._StatusID = StatusID;
    this._ProducerLocationGuid = ProducerLocationGuid;
    this._ProducerTypeID = ProducerTypeID;
    this._rowCount = 0;
    this._ExcelDT = new DataTable();
    this._ExcelDT.Columns.Add("Producer");
    this._ExcelDT.Columns.Add("Status");
    this._ExcelDT.Columns.Add("Address1");
    this._ExcelDT.Columns.Add("Address2");
    this._ExcelDT.Columns.Add("City");
    this._ExcelDT.Columns.Add("State");
    this._ExcelDT.Columns.Add("Zip");
    this._ExcelDT.Columns.Add("Phone");
    this._ExcelDT.Columns.Add("Fax");
    this._ExcelDT.Columns.Add("Contact");
  }

  private void rptProducerList_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter())
      {
        dataAdapter.SelectCommand = DefaultDatabase.CreateCommand();
        DbCommand selectCommand = dataAdapter.SelectCommand;
        selectCommand.CommandText = nameof (rptProducerList);
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Connection = dbConnection;
        DbParameterCollectionExtensions.AddWithValue(selectCommand.Parameters, "@OfficeGuid", (object) this._OfficeGuid);
        if (this._ProducerLocationGuid.Length > 0)
          DbParameterCollectionExtensions.AddWithValue(selectCommand.Parameters, "@ProducerLocationGuids", (object) this._ProducerLocationGuid);
        DbParameterCollectionExtensions.AddWithValue(selectCommand.Parameters, "@ProducerTypeID", (object) this._ProducerTypeID);
        DbParameterCollectionExtensions.AddWithValue(selectCommand.Parameters, "@ShowContacts", (object) this._ShowIndividualContacts);
        DbParameterCollectionExtensions.AddWithValue(selectCommand.Parameters, "@StatusID", (object) this._StatusID);
        selectCommand.CommandTimeout = 0;
        DefaultDatabase.DataAdapterFill(dataAdapter, this._ds);
      }
    }
    if (this._ShowIndividualContacts)
    {
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Format += new EventHandler(this.Detail_Format);
    }
    else
    {
      ((ARControl) this.srContacts).Visible = false;
      ((ARControl) this.lblContact).Visible = false;
      ((ARControl) this.lblProducer).Width = ((ARControl) this.lblProducer).Width + ((ARControl) this.lblContact).Width;
      ((ARControl) this.txtProducer).Width = ((ARControl) this.txtProducer).Width + ((ARControl) this.lblContact).Width;
      Label lblStatus = this.lblStatus;
      PointF location = ((ARControl) this.lblStatus).Location;
      double num1 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) lblStatus).Left = (float) num1;
      TextBox txtStatus = this.txtStatus;
      location = ((ARControl) this.txtStatus).Location;
      double num2 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) txtStatus).Left = (float) num2;
      Label lblAddress1 = this.lblAddress1;
      location = ((ARControl) this.lblAddress1).Location;
      double num3 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) lblAddress1).Left = (float) num3;
      TextBox txtAddress1 = this.txtAddress1;
      location = ((ARControl) this.txtAddress1).Location;
      double num4 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) txtAddress1).Left = (float) num4;
      Label lblAddress2 = this.lblAddress2;
      location = ((ARControl) this.lblAddress2).Location;
      double num5 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) lblAddress2).Left = (float) num5;
      TextBox txtAddress2 = this.txtAddress2;
      location = ((ARControl) this.txtAddress2).Location;
      double num6 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) txtAddress2).Left = (float) num6;
      Label lblCity = this.lblCity;
      location = ((ARControl) this.lblCity).Location;
      double num7 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) lblCity).Left = (float) num7;
      TextBox txtCity = this.txtCity;
      location = ((ARControl) this.txtCity).Location;
      double num8 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) txtCity).Left = (float) num8;
      Label lblState = this.lblState;
      location = ((ARControl) this.lblState).Location;
      double num9 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) lblState).Left = (float) num9;
      TextBox txtState = this.txtState;
      location = ((ARControl) this.txtState).Location;
      double num10 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) txtState).Left = (float) num10;
      Label lblZip = this.lblZip;
      location = ((ARControl) this.lblZip).Location;
      double num11 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) lblZip).Left = (float) num11;
      TextBox txtZip = this.txtZip;
      location = ((ARControl) this.txtZip).Location;
      double num12 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) txtZip).Left = (float) num12;
      Label lblPhoneNumber = this.lblPhoneNumber;
      location = ((ARControl) this.lblPhoneNumber).Location;
      double num13 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) lblPhoneNumber).Left = (float) num13;
      TextBox txtPhoneNumber = this.txtPhoneNumber;
      location = ((ARControl) this.txtPhoneNumber).Location;
      double num14 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) txtPhoneNumber).Left = (float) num14;
      Label lblFaxNumber = this.lblFaxNumber;
      location = ((ARControl) this.lblFaxNumber).Location;
      double num15 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) lblFaxNumber).Left = (float) num15;
      TextBox txtFaxNumber = this.txtFaxNumber;
      location = ((ARControl) this.txtFaxNumber).Location;
      double num16 = (double) location.X + (double) ((ARControl) this.lblContact).Width;
      ((ARControl) txtFaxNumber).Left = (float) num16;
    }
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    string str = "";
    DataRow row = this._ExcelDT.NewRow();
    row[0] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][1]);
    row[1] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][2]);
    row[2] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][3]);
    row[3] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][4]);
    row[4] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][5]);
    row[5] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][6]);
    row[6] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][7]);
    row[7] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][8]);
    row[8] = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[this._rowCount][9]);
    this.srContacts.Report = (SectionReport) new rptProducerList_Contacts(new DataView(this._ds.Tables[1], $"ProducerLocationGuid='{RuntimeHelpers.GetObjectValue(this.ProducerLocationGuid.Value)}'", "ProducerContact", DataViewRowState.CurrentRows));
    DataRow[] dataRowArray = this._ds.Tables[1].Select($"ProducerLocationGuid='{RuntimeHelpers.GetObjectValue(this.ProducerLocationGuid.Value)}'");
    int num = dataRowArray.Length - 1;
    for (int index = 0; index <= num; ++index)
      str = $"{str}{dataRowArray[index][1].ToString()}, ";
    row[9] = dataRowArray.Length <= 0 ? (object) "" : (object) str.Substring(0, str.Length - 2);
    ++this._rowCount;
    this._ExcelDT.Rows.Add(row);
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string FileName)
  {
    if (this._ShowIndividualContacts)
    {
      ExcelExport.ToExcel(this._ExcelDT, FileName);
    }
    else
    {
      DataTable source = this._ds.Tables[0].Copy();
      source.Columns.Remove("ProducerLocationGuid");
      source.Columns.Remove("ProducerType");
      ExcelExport.ToExcel(source, FileName);
      source.Dispose();
    }
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new OfficesAndProducerSelection(),
        (BaseReportControl) new GenericComboBox("Status", "(select -1 AS StatusID, 'All' AS Status) union (select StatusID, Status from lstStatus) order by StatusID ASC, Status DESC", "StatusID", "Status", typeof (int), 125, 125),
        (BaseReportControl) new GenericCheckBox("", "Show Contacts"),
        (BaseReportControl) new GenericComboBox("Type", "(select -1 AS ProducerTypeID, 'All' AS Description) union (select ProducerTypeID, Description from lstProducerTypes) order by ProducerTypeID ASC, Description DESC", "ProducerTypeID", "Description", typeof (int), 125, 125)
      };
    }
  }
}
