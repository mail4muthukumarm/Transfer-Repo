// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptEndorsementInfo
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{EC0D800D-48FC-44b5-AEE1-8DAFA6424C86}", Enums.AutomationDocGroups.PolicyDoc, "Endorsement Information", "Displays endorsement details.")]
public class rptEndorsementInfo : SectionReport, IQuoteDocument
{
  private TextBox txtTitle;
  private Label Label17;
  private Label Label15;
  private Label Label16;
  private Label Label13;
  private Label Label14;
  private Label Label8;
  private Label Label12;
  private Label Label11;
  private Label Label10;
  private Label Label9;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private CheckBox CheckBox1;
  private CheckBox CheckBox2;
  private CheckBox CheckBox3;
  private CheckBox CheckBox4;
  private CheckBox CheckBox5;
  private CheckBox CheckBox6;
  private CheckBox CheckBox7;
  private CheckBox CheckBox8;
  private CheckBox CheckBox9;
  private CheckBox CheckBox10;
  private Line Line1;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private Label Label20;
  private Picture Picture1;
  private RichTextBox EndorsementText;
  private Label lblDollar;
  private TextBox txtAmount;
  private TextBox txtCharge;
  private TextBox TextBox8;
  private Label Label22;
  private TextBox Premium1;
  private TextBox TextBox9;
  private SubReport srFees;
  private Label Label21;
  private TextBox Amount1;
  private TextBox ChargeName1;
  private Label Label18;
  private TextBox TextBox7;
  private Label Label19;
  private Picture Picture;
  private Guid _QuoteGuid;
  private bool _ShowContinued;
  private string _EndorsementNumber;

  private virtual PageHeader PageHeader
  {
    get => this._PageHeader;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PageHeader_Format);
      PageHeader pageHeader1 = this._PageHeader;
      if (pageHeader1 != null)
        ((Section) pageHeader1).Format -= eventHandler;
      this._PageHeader = value;
      PageHeader pageHeader2 = this._PageHeader;
      if (pageHeader2 == null)
        return;
      ((Section) pageHeader2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("GroupHeader4")]
  private virtual GroupHeader GroupHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader2")]
  private virtual GroupHeader GroupHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader3")]
  private virtual GroupHeader GroupHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter3")]
  private virtual GroupFooter GroupFooter3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter2")]
  private virtual GroupFooter GroupFooter2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter4")]
  private virtual GroupFooter GroupFooter4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptEndorsementInfo(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptEndorsementInfo_ReportStart);
    this._ShowContinued = false;
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
  }

  private void rptEndorsementInfo_ReportStart(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(nameof (rptEndorsementInfo), new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._QuoteGuid
    });
    if (dataTable.Rows.Count != 1)
      return;
    this._EndorsementNumber = dataTable.Rows[0]["EndorsementNum"].ToString();
    this.txtTitle.Text = string.Format(this.txtTitle.Text, (object) this._EndorsementNumber);
    this.CheckBox1.Text = dataTable.Rows[0]["CheckBox1Text"].ToString();
    this.CheckBox2.Text = dataTable.Rows[0]["CheckBox2Text"].ToString();
    this.CheckBox3.Text = dataTable.Rows[0]["CheckBox3Text"].ToString();
    this.CheckBox4.Text = dataTable.Rows[0]["CheckBox4Text"].ToString();
    this.CheckBox5.Text = dataTable.Rows[0]["CheckBox5Text"].ToString();
    this.CheckBox6.Text = dataTable.Rows[0]["CheckBox6Text"].ToString();
    this.CheckBox7.Text = dataTable.Rows[0]["CheckBox7Text"].ToString();
    this.CheckBox8.Text = dataTable.Rows[0]["CheckBox8Text"].ToString();
    this.CheckBox9.Text = dataTable.Rows[0]["CheckBox9Text"].ToString();
    this.CheckBox10.Text = dataTable.Rows[0]["CheckBox10Text"].ToString();
    this.srFees.Report = (SectionReport) new rptQuoteDocFees(this._QuoteGuid);
    ((ARControl) this.Picture1).Visible = false;
    this.DataSource = (object) dataTable;
  }

  private void PageHeader_Format(object sender, EventArgs e)
  {
    if (this._ShowContinued)
      this.txtTitle.Text = $"ENDORSEMENT NO. {this._EndorsementNumber} (Continued)";
    this._ShowContinued = true;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptEndorsementInfo));
    this.Detail = new Detail();
    this.Picture1 = new Picture();
    this.EndorsementText = new RichTextBox();
    this.PageHeader = new PageHeader();
    this.txtTitle = new TextBox();
    this.PageFooter = new PageFooter();
    this.GroupHeader4 = new GroupHeader();
    this.GroupFooter4 = new GroupFooter();
    this.Label18 = new Label();
    this.TextBox7 = new TextBox();
    this.Label19 = new Label();
    this.Picture = new Picture();
    this.GroupHeader1 = new GroupHeader();
    this.Label17 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label8 = new Label();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.CheckBox1 = new CheckBox();
    this.CheckBox2 = new CheckBox();
    this.CheckBox3 = new CheckBox();
    this.CheckBox4 = new CheckBox();
    this.CheckBox5 = new CheckBox();
    this.CheckBox6 = new CheckBox();
    this.CheckBox7 = new CheckBox();
    this.CheckBox8 = new CheckBox();
    this.CheckBox9 = new CheckBox();
    this.CheckBox10 = new CheckBox();
    this.Line1 = new Line();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.Label20 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.Label21 = new Label();
    this.Amount1 = new TextBox();
    this.ChargeName1 = new TextBox();
    this.GroupHeader2 = new GroupHeader();
    this.GroupFooter2 = new GroupFooter();
    this.srFees = new SubReport();
    this.GroupHeader3 = new GroupHeader();
    this.GroupFooter3 = new GroupFooter();
    this.lblDollar = new Label();
    this.txtAmount = new TextBox();
    this.txtCharge = new TextBox();
    this.TextBox8 = new TextBox();
    this.Label22 = new Label();
    this.Premium1 = new TextBox();
    this.TextBox9 = new TextBox();
    ((ISupportInitialize) this.Picture1).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Picture).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.CheckBox2).BeginInit();
    ((ISupportInitialize) this.CheckBox3).BeginInit();
    ((ISupportInitialize) this.CheckBox4).BeginInit();
    ((ISupportInitialize) this.CheckBox5).BeginInit();
    ((ISupportInitialize) this.CheckBox6).BeginInit();
    ((ISupportInitialize) this.CheckBox7).BeginInit();
    ((ISupportInitialize) this.CheckBox8).BeginInit();
    ((ISupportInitialize) this.CheckBox9).BeginInit();
    ((ISupportInitialize) this.CheckBox10).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.Label21).BeginInit();
    ((ISupportInitialize) this.Amount1).BeginInit();
    ((ISupportInitialize) this.ChargeName1).BeginInit();
    ((ISupportInitialize) this.lblDollar).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtCharge).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.Premium1).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Picture1,
      (ARControl) this.EndorsementText
    });
    ((Section) this.Detail).Height = 3.363889f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.Picture1).Height = 0.75f;
    this.Picture1.ImageData = (Stream) componentResourceManager.GetObject("Picture1.ImageData");
    ((ARControl) this.Picture1).Left = 0.0f;
    this.Picture1.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    ((ARControl) this.Picture1).Name = "Picture1";
    ((ARControl) this.Picture1).Top = 41f / 16f;
    ((ARControl) this.Picture1).Visible = false;
    ((ARControl) this.Picture1).Width = 7.875f;
    this.EndorsementText.AutoReplaceFields = true;
    ((ARControl) this.EndorsementText).DataField = "EndorsementText";
    this.EndorsementText.Font = new Font("Arial", 10f);
    ((ARControl) this.EndorsementText).Height = 2.5f;
    ((ARControl) this.EndorsementText).Left = 0.0f;
    ((ARControl) this.EndorsementText).Name = "EndorsementText";
    this.EndorsementText.RTF = componentResourceManager.GetString("EndorsementText.RTF");
    ((ARControl) this.EndorsementText).Top = 0.0f;
    ((ARControl) this.EndorsementText).Width = 7.875f;
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtTitle
    });
    this.PageHeader.Height = 0.2597222f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.txtTitle).Height = 0.25f;
    ((ARControl) this.txtTitle).Left = 0.0f;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.Style = "font-size: 12pt; font-weight: bold; text-align: center";
    this.txtTitle.Text = "ENDORSEMENT NO. {0}";
    ((ARControl) this.txtTitle).Top = 0.0f;
    ((ARControl) this.txtTitle).Width = 7.875f;
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    this.GroupHeader4.Height = 0.0f;
    ((Section) this.GroupHeader4).Name = "GroupHeader4";
    ((Section) this.GroupFooter4).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label18,
      (ARControl) this.TextBox7,
      (ARControl) this.Label19,
      (ARControl) this.Picture
    });
    this.GroupFooter4.Height = 0.8020833f;
    ((Section) this.GroupFooter4).Name = "GroupFooter4";
    this.GroupFooter4.PrintAtBottom = true;
    ((ARControl) this.Label18).Height = 0.25f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 1f / 16f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 12pt";
    this.Label18.Text = "Issue Date:";
    ((ARControl) this.Label18).Top = 9f / 16f;
    ((ARControl) this.Label18).Width = 1f;
    ((ARControl) this.TextBox7).DataField = "DateIssued";
    ((ARControl) this.TextBox7).Height = 0.25f;
    ((ARControl) this.TextBox7).Left = 17f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = componentResourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "font-size: 12pt";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 9f / 16f;
    ((ARControl) this.TextBox7).Width = 1.375f;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Height = 0.25f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 79f / 16f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "ddo-char-set: 0";
    this.Label19.Text = "Authorized Representative";
    ((ARControl) this.Label19).Top = 9f / 16f;
    ((ARControl) this.Label19).Width = 2.875f;
    ((ARControl) this.Picture).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Picture).DataField = "UserSignature";
    ((ARControl) this.Picture).Height = 9f / 16f;
    this.Picture.ImageData = (Stream) null;
    ((ARControl) this.Picture).Left = 79f / 16f;
    this.Picture.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    ((ARControl) this.Picture).Name = "Picture";
    this.Picture.SizeMode = (SizeModes) 1;
    ((ARControl) this.Picture).Top = 0.0f;
    ((ARControl) this.Picture).Width = 2.875f;
    ((Section) this.GroupHeader1).Controls.AddRange(new ARControl[34]
    {
      (ARControl) this.Label17,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label8,
      (ARControl) this.Label12,
      (ARControl) this.Label11,
      (ARControl) this.Label10,
      (ARControl) this.Label9,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.CheckBox1,
      (ARControl) this.CheckBox2,
      (ARControl) this.CheckBox3,
      (ARControl) this.CheckBox4,
      (ARControl) this.CheckBox5,
      (ARControl) this.CheckBox6,
      (ARControl) this.CheckBox7,
      (ARControl) this.CheckBox8,
      (ARControl) this.CheckBox9,
      (ARControl) this.CheckBox10,
      (ARControl) this.Line1,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.Label20
    });
    this.GroupHeader1.Height = 4f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.Label17).Height = 3f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 4f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 9pt";
    this.Label17.Text = "10.";
    ((ARControl) this.Label17).Top = 3.625f;
    ((ARControl) this.Label17).Width = 0.25f;
    ((ARControl) this.Label15).Height = 3f / 16f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 4f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-size: 9pt";
    this.Label15.Text = "8.";
    ((ARControl) this.Label15).Top = 3.125f;
    ((ARControl) this.Label15).Width = 0.25f;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 4f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 9pt";
    this.Label16.Text = "9.";
    ((ARControl) this.Label16).Top = 3.375f;
    ((ARControl) this.Label16).Width = 0.25f;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 4f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 9pt";
    this.Label13.Text = "6.";
    ((ARControl) this.Label13).Top = 2.625f;
    ((ARControl) this.Label13).Width = 0.25f;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 4f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 9pt";
    this.Label14.Text = "7.";
    ((ARControl) this.Label14).Top = 2.875f;
    ((ARControl) this.Label14).Width = 0.25f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.0f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 9pt";
    this.Label8.Text = "1.";
    ((ARControl) this.Label8).Top = 2.625f;
    ((ARControl) this.Label8).Width = 3f / 16f;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 0.0f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 9pt";
    this.Label12.Text = "5.";
    ((ARControl) this.Label12).Top = 3.625f;
    ((ARControl) this.Label12).Width = 3f / 16f;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 0.0f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 9pt";
    this.Label11.Text = "4.";
    ((ARControl) this.Label11).Top = 3.375f;
    ((ARControl) this.Label11).Width = 3f / 16f;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 0.0f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 9pt";
    this.Label10.Text = "3.";
    ((ARControl) this.Label10).Top = 3.125f;
    ((ARControl) this.Label10).Width = 3f / 16f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 9pt";
    this.Label9.Text = "2.";
    ((ARControl) this.Label9).Top = 2.875f;
    ((ARControl) this.Label9).Width = 3f / 16f;
    ((ARControl) this.Label1).Height = 0.25f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 12pt";
    this.Label1.Text = "Named Insured:";
    ((ARControl) this.Label1).Top = 1f / 16f;
    ((ARControl) this.Label1).Width = 2f;
    ((ARControl) this.Label2).Height = 0.25f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 12pt";
    this.Label2.Text = "Policy Effective Date:";
    ((ARControl) this.Label2).Top = 0.375f;
    ((ARControl) this.Label2).Width = 2f;
    ((ARControl) this.Label3).Height = 0.25f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.0f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 12pt";
    this.Label3.Text = "Policy Expiration Date:";
    ((ARControl) this.Label3).Top = 0.625f;
    ((ARControl) this.Label3).Width = 2f;
    ((ARControl) this.Label4).Height = 0.25f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 1.5f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 12pt";
    this.Label4.Text = "This endorsement effective: 12:01 A.M.";
    ((ARControl) this.Label4).Top = 15f / 16f;
    ((ARControl) this.Label4).Width = 3.25f;
    ((ARControl) this.Label5).Height = 0.25f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 0.0f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 12pt";
    this.Label5.Text = "Policy No:";
    ((ARControl) this.Label5).Top = 19f / 16f;
    ((ARControl) this.Label5).Width = 0.875f;
    ((ARControl) this.Label6).Height = 0.25f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.0f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 12pt; text-align: center; text-decoration: underline";
    this.Label6.Text = "Amendatory Endorsement";
    ((ARControl) this.Label6).Top = 1.5f;
    ((ARControl) this.Label6).Width = 7.875f;
    ((ARControl) this.Label7).Height = 0.625f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 0.0f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 12pt";
    this.Label7.Text = componentResourceManager.GetString("Label7.Text");
    ((ARControl) this.Label7).Top = 1.75f;
    ((ARControl) this.Label7).Width = 7.875f;
    ((ARControl) this.CheckBox1).DataField = "CheckBox1Checked";
    ((ARControl) this.CheckBox1).Height = 3f / 16f;
    ((ARControl) this.CheckBox1).Left = 3f / 16f;
    ((ARControl) this.CheckBox1).Name = "CheckBox1";
    this.CheckBox1.Style = "font-size: 9pt";
    this.CheckBox1.Text = " ";
    ((ARControl) this.CheckBox1).Top = 2.625f;
    ((ARControl) this.CheckBox1).Width = 3.75f;
    ((ARControl) this.CheckBox2).DataField = "CheckBox2Checked";
    ((ARControl) this.CheckBox2).Height = 3f / 16f;
    ((ARControl) this.CheckBox2).Left = 3f / 16f;
    ((ARControl) this.CheckBox2).Name = "CheckBox2";
    this.CheckBox2.Style = "font-size: 9pt";
    this.CheckBox2.Text = " ";
    ((ARControl) this.CheckBox2).Top = 2.875f;
    ((ARControl) this.CheckBox2).Width = 3.75f;
    ((ARControl) this.CheckBox3).DataField = "CheckBox3Checked";
    ((ARControl) this.CheckBox3).Height = 3f / 16f;
    ((ARControl) this.CheckBox3).Left = 3f / 16f;
    ((ARControl) this.CheckBox3).Name = "CheckBox3";
    this.CheckBox3.Style = "font-size: 9pt";
    this.CheckBox3.Text = " ";
    ((ARControl) this.CheckBox3).Top = 3.125f;
    ((ARControl) this.CheckBox3).Width = 3.75f;
    ((ARControl) this.CheckBox4).DataField = "CheckBox4Checked";
    ((ARControl) this.CheckBox4).Height = 3f / 16f;
    ((ARControl) this.CheckBox4).Left = 3f / 16f;
    ((ARControl) this.CheckBox4).Name = "CheckBox4";
    this.CheckBox4.Style = "font-size: 9pt";
    this.CheckBox4.Text = " ";
    ((ARControl) this.CheckBox4).Top = 3.375f;
    ((ARControl) this.CheckBox4).Width = 3.75f;
    ((ARControl) this.CheckBox5).DataField = "CheckBox5Checked";
    ((ARControl) this.CheckBox5).Height = 3f / 16f;
    ((ARControl) this.CheckBox5).Left = 3f / 16f;
    ((ARControl) this.CheckBox5).Name = "CheckBox5";
    this.CheckBox5.Style = "font-size: 9pt";
    this.CheckBox5.Text = " ";
    ((ARControl) this.CheckBox5).Top = 3.625f;
    ((ARControl) this.CheckBox5).Width = 3.75f;
    ((ARControl) this.CheckBox6).DataField = "CheckBox6Checked";
    ((ARControl) this.CheckBox6).Height = 3f / 16f;
    ((ARControl) this.CheckBox6).Left = 4.25f;
    ((ARControl) this.CheckBox6).Name = "CheckBox6";
    this.CheckBox6.Style = "font-size: 9pt";
    this.CheckBox6.Text = " ";
    ((ARControl) this.CheckBox6).Top = 2.625f;
    ((ARControl) this.CheckBox6).Width = 3.625f;
    ((ARControl) this.CheckBox7).DataField = "CheckBox7Checked";
    ((ARControl) this.CheckBox7).Height = 3f / 16f;
    ((ARControl) this.CheckBox7).Left = 4.25f;
    ((ARControl) this.CheckBox7).Name = "CheckBox7";
    this.CheckBox7.Style = "font-size: 9pt";
    this.CheckBox7.Text = " ";
    ((ARControl) this.CheckBox7).Top = 2.875f;
    ((ARControl) this.CheckBox7).Width = 3.625f;
    ((ARControl) this.CheckBox8).DataField = "CheckBox8Checked";
    ((ARControl) this.CheckBox8).Height = 3f / 16f;
    ((ARControl) this.CheckBox8).Left = 4.25f;
    ((ARControl) this.CheckBox8).Name = "CheckBox8";
    this.CheckBox8.Style = "font-size: 9pt";
    this.CheckBox8.Text = " ";
    ((ARControl) this.CheckBox8).Top = 3.125f;
    ((ARControl) this.CheckBox8).Width = 3.625f;
    ((ARControl) this.CheckBox9).DataField = "CheckBox9Checked";
    ((ARControl) this.CheckBox9).Height = 3f / 16f;
    ((ARControl) this.CheckBox9).Left = 4.25f;
    ((ARControl) this.CheckBox9).Name = "CheckBox9";
    this.CheckBox9.Style = "font-size: 9pt";
    this.CheckBox9.Text = " ";
    ((ARControl) this.CheckBox9).Top = 3.375f;
    ((ARControl) this.CheckBox9).Width = 3.625f;
    ((ARControl) this.CheckBox10).DataField = "CheckBox10Checked";
    ((ARControl) this.CheckBox10).Height = 3f / 16f;
    ((ARControl) this.CheckBox10).Left = 4.25f;
    ((ARControl) this.CheckBox10).Name = "CheckBox10";
    this.CheckBox10.Style = "font-size: 9pt";
    this.CheckBox10.Text = " ";
    ((ARControl) this.CheckBox10).Top = 3.625f;
    ((ARControl) this.CheckBox10).Width = 3.625f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 0.0f;
    this.Line1.LineStyle = (LineStyle) 3;
    this.Line1.LineWeight = 3f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 63f / 16f;
    ((ARControl) this.Line1).Width = 7.875f;
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 7.875f;
    this.Line1.Y1 = 63f / 16f;
    this.Line1.Y2 = 63f / 16f;
    ((ARControl) this.TextBox1).DataField = "InsuredPolicyName";
    ((ARControl) this.TextBox1).Height = 0.25f;
    ((ARControl) this.TextBox1).Left = 2f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 12pt";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 1f / 16f;
    ((ARControl) this.TextBox1).Width = 5.875f;
    ((ARControl) this.TextBox2).DataField = "EffectiveDate";
    ((ARControl) this.TextBox2).Height = 0.25f;
    ((ARControl) this.TextBox2).Left = 2f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 12pt";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.375f;
    ((ARControl) this.TextBox2).Width = 1.125f;
    ((ARControl) this.TextBox3).DataField = "ExpirationDate";
    ((ARControl) this.TextBox3).Height = 0.25f;
    ((ARControl) this.TextBox3).Left = 2f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 12pt";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.625f;
    ((ARControl) this.TextBox3).Width = 1.125f;
    ((ARControl) this.TextBox4).DataField = "EndorsementEffective";
    ((ARControl) this.TextBox4).Height = 0.25f;
    ((ARControl) this.TextBox4).Left = 4.75f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 12pt";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 15f / 16f;
    ((ARControl) this.TextBox4).Width = 1.125f;
    ((ARControl) this.TextBox5).DataField = "PolicyNum";
    ((ARControl) this.TextBox5).Height = 0.25f;
    ((ARControl) this.TextBox5).Left = 0.875f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 12pt";
    this.TextBox5.Text = "TextBox5";
    ((ARControl) this.TextBox5).Top = 19f / 16f;
    ((ARControl) this.TextBox5).Width = 7f;
    ((ARControl) this.Label20).Height = 0.25f;
    this.Label20.HyperLink = (string) null;
    ((ARControl) this.Label20).Left = 5.875f;
    ((ARControl) this.Label20).Name = "Label20";
    this.Label20.Style = "font-size: 12pt";
    this.Label20.Text = "forms a part of";
    ((ARControl) this.Label20).Top = 15f / 16f;
    ((ARControl) this.Label20).Width = 2f;
    ((Section) this.GroupFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label21,
      (ARControl) this.Amount1,
      (ARControl) this.ChargeName1
    });
    this.GroupFooter1.Height = 9f / 32f;
    this.GroupFooter1.KeepTogether = true;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Height = 0.25f;
    this.Label21.HyperLink = (string) null;
    ((ARControl) this.Label21).Left = 0.062f;
    ((ARControl) this.Label21).Name = "Label21";
    this.Label21.Style = "font-size: 8pt; vertical-align: middle";
    this.Label21.Text = "$";
    ((ARControl) this.Label21).Top = 0.0f;
    ((ARControl) this.Label21).Width = 0.125f;
    ((ARControl) this.Amount1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount1).DataField = "PremiumPlusFees";
    ((ARControl) this.Amount1).Height = 0.25f;
    ((ARControl) this.Amount1).Left = 0.187f;
    ((ARControl) this.Amount1).Name = "Amount1";
    this.Amount1.OutputFormat = componentResourceManager.GetString("Amount1.OutputFormat");
    this.Amount1.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Amount1.Text = " ";
    ((ARControl) this.Amount1).Top = 0.0f;
    ((ARControl) this.Amount1).Width = 13f / 16f;
    ((ARControl) this.ChargeName1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.ChargeName1).Height = 0.25f;
    ((ARControl) this.ChargeName1).Left = 0.9995f;
    ((ARControl) this.ChargeName1).Name = "ChargeName1";
    this.ChargeName1.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle";
    this.ChargeName1.Text = "Grand Total";
    ((ARControl) this.ChargeName1).Top = 0.0f;
    ((ARControl) this.ChargeName1).Width = 1.5f;
    this.GroupHeader2.Height = 0.0f;
    ((Section) this.GroupHeader2).Name = "GroupHeader2";
    ((Section) this.GroupFooter2).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srFees
    });
    this.GroupFooter2.Height = 0.07291669f;
    ((Section) this.GroupFooter2).Name = "GroupFooter2";
    this.srFees.CloseBorder = false;
    ((ARControl) this.srFees).Height = 1f / 16f;
    ((ARControl) this.srFees).Left = 1f / 16f;
    ((ARControl) this.srFees).Name = "srFees";
    this.srFees.Report = (SectionReport) null;
    ((ARControl) this.srFees).Top = 0.0f;
    ((ARControl) this.srFees).Width = 4.875f;
    this.GroupHeader3.Height = 0.0f;
    ((Section) this.GroupHeader3).Name = "GroupHeader3";
    ((Section) this.GroupFooter3).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.lblDollar,
      (ARControl) this.txtAmount,
      (ARControl) this.txtCharge,
      (ARControl) this.TextBox8,
      (ARControl) this.Label22,
      (ARControl) this.Premium1,
      (ARControl) this.TextBox9
    });
    this.GroupFooter3.Height = 0.6770833f;
    ((Section) this.GroupFooter3).Name = "GroupFooter3";
    ((ARControl) this.lblDollar).Height = 0.188f;
    this.lblDollar.HyperLink = (string) null;
    ((ARControl) this.lblDollar).Left = 0.062f;
    ((ARControl) this.lblDollar).Name = "lblDollar";
    this.lblDollar.Style = "font-size: 8pt; vertical-align: middle";
    this.lblDollar.Text = "$";
    ((ARControl) this.lblDollar).Top = 0.312f;
    ((ARControl) this.lblDollar).Width = 0.125f;
    ((ARControl) this.txtAmount).DataField = "Premium";
    ((ARControl) this.txtAmount).Height = 0.188f;
    ((ARControl) this.txtAmount).Left = 0.187f;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = componentResourceManager.GetString("txtAmount.OutputFormat");
    this.txtAmount.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.txtAmount.Text = " ";
    ((ARControl) this.txtAmount).Top = 0.312f;
    ((ARControl) this.txtAmount).Width = 13f / 16f;
    ((ARControl) this.txtCharge).Height = 0.188f;
    ((ARControl) this.txtCharge).Left = 0.9995f;
    ((ARControl) this.txtCharge).Name = "txtCharge";
    this.txtCharge.Style = "font-size: 8pt; vertical-align: middle";
    this.txtCharge.Text = "Premium";
    ((ARControl) this.txtCharge).Top = 0.312f;
    ((ARControl) this.txtCharge).Width = 63f / 16f;
    ((ARControl) this.TextBox8).Height = 0.25f;
    ((ARControl) this.TextBox8).Left = 1f / 16f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-weight: bold";
    this.TextBox8.Text = "Breakdown:";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 4.875f;
    ((ARControl) this.Label22).Height = 0.188f;
    this.Label22.HyperLink = (string) null;
    ((ARControl) this.Label22).Left = 0.062f;
    ((ARControl) this.Label22).Name = "Label22";
    this.Label22.Style = "font-size: 8pt; vertical-align: middle";
    this.Label22.Text = "$";
    ((ARControl) this.Label22).Top = 0.5f;
    ((ARControl) this.Label22).Width = 0.125f;
    ((ARControl) this.Premium1).DataField = "TerrorismPremium";
    ((ARControl) this.Premium1).Height = 0.188f;
    ((ARControl) this.Premium1).Left = 0.187f;
    ((ARControl) this.Premium1).Name = "Premium1";
    this.Premium1.OutputFormat = componentResourceManager.GetString("Premium1.OutputFormat");
    this.Premium1.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Premium1.Text = " ";
    ((ARControl) this.Premium1).Top = 0.5f;
    ((ARControl) this.Premium1).Width = 13f / 16f;
    ((ARControl) this.TextBox9).Height = 0.188f;
    ((ARControl) this.TextBox9).Left = 0.9995f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "font-size: 8pt; vertical-align: middle";
    this.TextBox9.Text = "Terrorism Premium";
    ((ARControl) this.TextBox9).Top = 0.5f;
    ((ARControl) this.TextBox9).Width = 63f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.GroupHeader4);
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.GroupHeader2);
    this.Sections.Add((Section) this.GroupHeader3);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter3);
    this.Sections.Add((Section) this.GroupFooter2);
    this.Sections.Add((Section) this.GroupFooter1);
    this.Sections.Add((Section) this.GroupFooter4);
    this.Sections.Add((Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Picture1).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Picture).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.CheckBox2).EndInit();
    ((ISupportInitialize) this.CheckBox3).EndInit();
    ((ISupportInitialize) this.CheckBox4).EndInit();
    ((ISupportInitialize) this.CheckBox5).EndInit();
    ((ISupportInitialize) this.CheckBox6).EndInit();
    ((ISupportInitialize) this.CheckBox7).EndInit();
    ((ISupportInitialize) this.CheckBox8).EndInit();
    ((ISupportInitialize) this.CheckBox9).EndInit();
    ((ISupportInitialize) this.CheckBox10).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.Label21).EndInit();
    ((ISupportInitialize) this.Amount1).EndInit();
    ((ISupportInitialize) this.ChargeName1).EndInit();
    ((ISupportInitialize) this.lblDollar).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtCharge).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.Premium1).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public bool RequiresQuoteOptionGuids() => false;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
  }
}
